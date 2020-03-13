using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NAudioTest
{
    public partial class MainForm : Form
    {
        private IWavePlayer waveOut;
        private IWaveIn captureDevice;
        private WaveFileWriter writer;
        private AudioFileReader audioFileReader;
        private AudioFileReader audioFileReader2;
        private MultiplexingWaveProvider waveProvider;
        private Action<float> setVolumeDelegate;
        private string fileName = Application.StartupPath + "\\Audio.mp3";
        private string outputFilename;
        private readonly string outputFolder;
        public MainForm()
        {
            InitializeComponent();

            LoadAudioDevicesCombo();
            LoadWaveInDevicesCombo();
            comboBoxSampleRate.DataSource = new[] { 8000, 16000, 22050, 32000, 44100, 48000 };
            comboBoxSampleRate.SelectedIndex = 0;
            comboBoxChannels.DataSource = new[] { "Mono", "Stereo" };
            comboBoxChannels.SelectedIndex = 1;
            comboBoxChannels.Enabled = false;
            outputFolder = Path.Combine(Application.StartupPath, "Recording");
            Directory.CreateDirectory(outputFolder);

            comboWaveInDevice.SelectedIndexChanged += (s, a) => Cleanup();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            comboBoxLatency.Items.Add(25);
            comboBoxLatency.Items.Add(50);
            comboBoxLatency.Items.Add(100);
            comboBoxLatency.Items.Add(150);
            comboBoxLatency.Items.Add(200);
            comboBoxLatency.Items.Add(300);
            comboBoxLatency.Items.Add(400);
            comboBoxLatency.Items.Add(500);
            comboBoxLatency.SelectedIndex = 5;
        }

        private void LoadAudioDevicesCombo()
        {
            var devices = Enumerable.Range(0, WaveOut.DeviceCount).Select(n => WaveOut.GetCapabilities(n)).ToArray();
            comboBoxDriver.DataSource = devices;
            comboBoxDriver.DisplayMember = "ProductName";
        }

        private void LoadWaveInDevicesCombo()
        {
            var devices = Enumerable.Range(0, WaveIn.DeviceCount).Select(n => WaveIn.GetCapabilities(n)).ToArray();
            comboWaveInDevice.DataSource = devices;
            comboWaveInDevice.DisplayMember = "ProductName";
        }

        private void CreateWaveOut()
        {
            CloseWaveOut();
            var deviceNumber = (int)comboBoxDriver.Items.IndexOf(comboBoxDriver.SelectedItem);
            var latency = (int)comboBoxLatency.SelectedItem;
            waveOut = new MyWaveOut().CreateDevice(deviceNumber, latency);
            waveOut.PlaybackStopped += OnPlaybackStopped;
        }

        void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show(e.Exception.Message, "Playback Device Error");
            }
            if (audioFileReader != null)
            {
                audioFileReader.Position = 0;
            }
        }

        private void CloseWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                setVolumeDelegate = null;
                audioFileReader = null;
            }
            if (waveOut != null)
            {
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void PlayClick(object sender, EventArgs e)
        {
            if (!MyWaveOut.IsAvailable)
            {
                MessageBox.Show("The selected output driver is not available on this system");
                return;
            }
            if (waveOut != null)
            {
                if (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    return;
                }
                else if (waveOut.PlaybackState == PlaybackState.Paused)
                {
                    waveOut.Play();
                    return;
                }
            }
            try
            {
                CreateWaveOut();
            }
            catch (Exception driverCreateException)
            {
                MessageBox.Show(String.Format("{0}", driverCreateException.Message));
                return;
            }


            ISampleProvider sampleProvider;
            try
            {
                sampleProvider = CreateInputStream(fileName);
                Console.WriteLine("ISampleProvider:" + sampleProvider);
            }
            catch (Exception createException)
            {
                MessageBox.Show(String.Format("{0}", createException.Message), "Error Loading File");
                return;
            }

            totalTime.Text = String.Format("{0:00}:{1:00}", (int)audioFileReader.TotalTime.TotalMinutes,
                audioFileReader.TotalTime.Seconds);
            try
            {
                waveOut.Init(sampleProvider);
            }
            catch (Exception initException)
            {
                MessageBox.Show(String.Format("{0}", initException.Message), "Error Initializing Output");
                return;
            }
            waveOut.Play();
        }

        private ISampleProvider CreateInputStream(string fileName)
        {
            audioFileReader = new AudioFileReader(fileName);
            audioFileReader2 = new AudioFileReader(fileName);//创建一个静音流
            audioFileReader2.Volume = 0.0f;
            
            waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] {
                audioFileReader, audioFileReader2}, 2);
            
            //var mono = new StereoToMonoSampleProvider(audioFileReader);
            //mono.LeftVolume = 0.0f;
            //mono.RightVolume = 1.0f;
            //var mono2 = new SampleToWaveProvider(mono);
            //var waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] {
            //    mono2}, -1);
            if (leftRadio.Checked)
            {
                waveProvider.ConnectInputToOutput(2, 1);
                waveProvider.ConnectInputToOutput(3, 1);
            }
            else if (rightRadio.Checked)
            {
                waveProvider.ConnectInputToOutput(2, 0);
                waveProvider.ConnectInputToOutput(3, 0);
            }

            var sampleChannel = new SampleChannel(waveProvider, false);
            sampleChannel.PreVolumeMeter += OnPreVolumeMeter;//波形图
            setVolumeDelegate = vol => sampleChannel.Volume = vol;
            var postVolumeMeter = new MeteringSampleProvider(sampleChannel);
            postVolumeMeter.StreamVolume += OnPostVolumeMeter;

            return postVolumeMeter;
        }

        void OnPostVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            volumeMeter1.Amplitude = e.MaxSampleValues[0];
            volumeMeter2.Amplitude = e.MaxSampleValues[1];
        }

        void OnPreVolumeMeter(object sender, StreamVolumeEventArgs e)
        {
            Console.WriteLine(e.MaxSampleValues[0]+"---"+ e.MaxSampleValues[1]);
            waveformPainter1.AddMax(e.MaxSampleValues[0]);
            waveformPainter2.AddMax(e.MaxSampleValues[1]);
        }

        private void PauseClick(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                if (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    waveOut.Pause();
                }
            }
        }

        private void StopClick(object sender, EventArgs e) => waveOut?.Stop();

        private void OnOpenFileClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            string allExtensions = "*.wav;*.aiff;*.mp3;*.aac";
            openFileDialog.Filter = String.Format("All Supported Files|{0}|All Files (*.*)|*.*", allExtensions);
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
        }

        private void OnVolumeSliderChanged(object sender, EventArgs e)
        {
            setVolumeDelegate?.Invoke(volumeSlider1.Volume);
        }

        private void SolidChecked(object sender, EventArgs e)
        {
            if (waveOut != null && audioFileReader != null)
            {
                if (litiRadio.Checked)
                {
                    waveProvider.ConnectInputToOutput(0, 0);
                    waveProvider.ConnectInputToOutput(1, 1);
                }
            }
        }

        private void LeftChecked(object sender, EventArgs e)
        {
            if (waveOut != null && audioFileReader != null)
            {
                if (leftRadio.Checked)
                {
                    waveProvider.ConnectInputToOutput(0, 0);
                    //waveProvider.ConnectInputToOutput(1, 0);
                    waveProvider.ConnectInputToOutput(2, 1);
                    waveProvider.ConnectInputToOutput(3, 1);
                }
            }
        }

        private void RightChecked(object sender, EventArgs e)
        {
            if (waveOut != null && audioFileReader != null)
            {
                if (rightRadio.Checked)
                {
                    //waveProvider.ConnectInputToOutput(0, 1);
                    waveProvider.ConnectInputToOutput(1, 1);
                    waveProvider.ConnectInputToOutput(2, 0);
                    waveProvider.ConnectInputToOutput(3, 0);
                }
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (waveOut != null && audioFileReader != null)
            {
                TimeSpan currentTime = (waveOut.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : audioFileReader.CurrentTime;
                trackBar1.Value = Math.Min(trackBar1.Maximum, (int)(100 * currentTime.TotalSeconds / audioFileReader.TotalTime.TotalSeconds));
                currentTimeLabel.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes,
                    currentTime.Seconds);
            }
            else
            {
                trackBar1.Value = 0;
            }
        }


        private void OnButtonStartRecordingClick(object sender, EventArgs e)
        {
            Cleanup();
            StopClick(toolStripStop, new EventArgs());
            if (captureDevice == null)
            {
                captureDevice = CreateWaveInDevice();
            }
            outputFilename = GetFileName();
            label_audio.Text = outputFilename;
            writer = new WaveFileWriter(Path.Combine(outputFolder, outputFilename), captureDevice.WaveFormat);
            captureDevice.StartRecording();
            SetControlStates(true);
        }

        private void OnButtonStopRecordingClick(object sender, EventArgs e)
        {
            StopRecording();
        }

        private IWaveIn CreateWaveInDevice()
        {
            IWaveIn newWaveIn;
            var deviceNumber = comboWaveInDevice.SelectedIndex;
            newWaveIn = new WaveIn() { DeviceNumber = deviceNumber };
            var sampleRate = (int)comboBoxSampleRate.SelectedItem;
            var channels = comboBoxChannels.SelectedIndex + 1;
            newWaveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            newWaveIn.DataAvailable += OnDataAvailable;
            newWaveIn.RecordingStopped += OnRecordingStopped;
            return newWaveIn;
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                int secondsRecorded = (int)(writer.Length / writer.WaveFormat.AverageBytesPerSecond);
                if (secondsRecorded >= 30)
                {
                    StopRecording();
                }
                else
                {
                    progressBar1.Value = secondsRecorded;
                }
                /*
                //波形图
                var channels = comboBoxChannels.SelectedIndex + 1;
                float[] sts = new float[e.Buffer.Length / channels];
                Console.WriteLine("channels:" + channels + ";"+ sts.Length + ";"+ e.Buffer.Length + ";"+ e.BytesRecorded);

                float max = 0;
                // interpret as 16 bit audio
                for (int index = 0; index < e.BytesRecorded; index += channels)
                {
                    short sample = (short)((e.Buffer[index + 1] << 8) |
                                            e.Buffer[index + 0]);
                    // to floating point
                    var sample16 = sample / 32768f;
                    // absolute value 
                    if (sample16 < 0) sample16 = -sample16;
                    // is this the max value?
                    if (sample16 > max) max = sample16;
                }
                waveformPainter1.AddMax(max);*/
            }
        }

        void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<StoppedEventArgs>(OnRecordingStopped), sender, e);
            }
            else
            {
                FinalizeWaveFile();
                progressBar1.Value = 0;
                if (e.Exception != null)
                {
                    MessageBox.Show(String.Format("A problem was encountered during recording {0}",
                                                  e.Exception.Message));
                }
                SetControlStates(false);
            }
        }

        void StopRecording()
        {
            Console.WriteLine("StopRecording");
            captureDevice?.StopRecording();
        }

        private void SetControlStates(bool isRecording)
        {
            StartRecordingBtn.Enabled = !isRecording;
            StopRecordingBtn.Enabled = isRecording;
        }

        private void Cleanup()
        {
            if (captureDevice != null)
            {
                captureDevice.Dispose();
                captureDevice = null;
            }
            FinalizeWaveFile();
        }

        private void FinalizeWaveFile()
        {
            writer?.Dispose();
            writer = null;
        }

        private string GetFileName()
        {
            var deviceName = captureDevice.GetType().Name;
            var sampleRate = $"{captureDevice.WaveFormat.SampleRate / 1000}kHz";
            var channels = captureDevice.WaveFormat.Channels == 1 ? "mono" : "stereo";

            return $"{deviceName} {sampleRate} {channels} {DateTime.Now:yyy-MM-dd}.wav";
        }

        private void OnButtonPlayClick(object sender, EventArgs e)
        {
            Console.WriteLine("OnButtonPlayClick:" + label_audio.Text);
            if (label_audio.Text.Length != 0)
            {
                fileName = Path.Combine(outputFolder, outputFilename);
                PlayClick(toolStripPlay, new EventArgs());
            }
        }

        private void OnButtonDeleteClick(object sender, EventArgs e)
        {
            if (label_audio.Text.Length != 0)
            {
                fileName = Application.StartupPath + "\\Audio.mp3";
                File.Delete(Path.Combine(outputFolder, outputFilename));
                label_audio.Text = "";
            }
        }

        private void OnOpenFolderClick(object sender, EventArgs e)
        {
            Process.Start(outputFolder);
        }
    }
}
