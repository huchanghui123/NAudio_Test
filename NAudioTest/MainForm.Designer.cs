namespace NAudioTest
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.currentTimeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.totalTime = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightRadio = new System.Windows.Forms.RadioButton();
            this.leftRadio = new System.Windows.Forms.RadioButton();
            this.litiRadio = new System.Windows.Forms.RadioButton();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.volumeMeter2 = new NAudio.Gui.VolumeMeter();
            this.comboBoxLatency = new System.Windows.Forms.ComboBox();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.waveformPainter2 = new NAudio.Gui.WaveformPainter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.StopRecordingBtn = new System.Windows.Forms.Button();
            this.StartRecordingBtn = new System.Windows.Forms.Button();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.comboBoxSampleRate = new System.Windows.Forms.ComboBox();
            this.comboWaveInDevice = new System.Windows.Forms.ComboBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label_audio = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpen,
            this.toolStripPlay,
            this.toolStripPause,
            this.toolStripStop,
            this.toolStripLabel1,
            this.currentTimeLabel,
            this.toolStripLabel2,
            this.totalTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = global::NAudioTest.Properties.Resources.Open;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "toolStripButton1";
            this.toolStripOpen.Click += new System.EventHandler(this.OnOpenFileClick);
            // 
            // toolStripPlay
            // 
            this.toolStripPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlay.Image = global::NAudioTest.Properties.Resources.Play;
            this.toolStripPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlay.Name = "toolStripPlay";
            this.toolStripPlay.Size = new System.Drawing.Size(23, 22);
            this.toolStripPlay.Text = "toolStripButton2";
            this.toolStripPlay.Click += new System.EventHandler(this.PlayClick);
            // 
            // toolStripPause
            // 
            this.toolStripPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPause.Image = global::NAudioTest.Properties.Resources.Pause;
            this.toolStripPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPause.Name = "toolStripPause";
            this.toolStripPause.Size = new System.Drawing.Size(23, 22);
            this.toolStripPause.Text = "toolStripButton3";
            this.toolStripPause.Click += new System.EventHandler(this.PauseClick);
            // 
            // toolStripStop
            // 
            this.toolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStop.Image = global::NAudioTest.Properties.Resources.Stop;
            this.toolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStop.Name = "toolStripStop";
            this.toolStripStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripStop.Text = "toolStripButton4";
            this.toolStripStop.Click += new System.EventHandler(this.StopClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Current Time:";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(39, 22);
            this.currentTimeLabel.Text = "00:00";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel2.Text = "Total Time:";
            // 
            // totalTime
            // 
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(39, 22);
            this.totalTime.Text = "00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.comboBoxDriver);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Driver";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rightRadio);
            this.panel1.Controls.Add(this.leftRadio);
            this.panel1.Controls.Add(this.litiRadio);
            this.panel1.Controls.Add(this.volumeSlider1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.volumeMeter2);
            this.panel1.Controls.Add(this.comboBoxLatency);
            this.panel1.Controls.Add(this.volumeMeter1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 146);
            this.panel1.TabIndex = 1;
            // 
            // rightRadio
            // 
            this.rightRadio.AutoSize = true;
            this.rightRadio.Location = new System.Drawing.Point(27, 116);
            this.rightRadio.Name = "rightRadio";
            this.rightRadio.Size = new System.Drawing.Size(59, 16);
            this.rightRadio.TabIndex = 10;
            this.rightRadio.Text = "右声道";
            this.rightRadio.UseVisualStyleBackColor = true;
            this.rightRadio.CheckedChanged += new System.EventHandler(this.RightChecked);
            // 
            // leftRadio
            // 
            this.leftRadio.AutoSize = true;
            this.leftRadio.Location = new System.Drawing.Point(27, 94);
            this.leftRadio.Name = "leftRadio";
            this.leftRadio.Size = new System.Drawing.Size(59, 16);
            this.leftRadio.TabIndex = 9;
            this.leftRadio.Text = "左声道";
            this.leftRadio.UseVisualStyleBackColor = true;
            this.leftRadio.CheckedChanged += new System.EventHandler(this.LeftChecked);
            // 
            // litiRadio
            // 
            this.litiRadio.AutoSize = true;
            this.litiRadio.Checked = true;
            this.litiRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.litiRadio.Location = new System.Drawing.Point(27, 72);
            this.litiRadio.Name = "litiRadio";
            this.litiRadio.Size = new System.Drawing.Size(59, 16);
            this.litiRadio.TabIndex = 8;
            this.litiRadio.TabStop = true;
            this.litiRadio.Text = "立体声";
            this.litiRadio.UseVisualStyleBackColor = true;
            this.litiRadio.CheckedChanged += new System.EventHandler(this.SolidChecked);
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(71, 37);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider1.TabIndex = 5;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.OnVolumeSliderChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume:";
            // 
            // volumeMeter2
            // 
            this.volumeMeter2.Amplitude = 0F;
            this.volumeMeter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.volumeMeter2.Location = new System.Drawing.Point(144, 59);
            this.volumeMeter2.MaxDb = 18F;
            this.volumeMeter2.MinDb = -60F;
            this.volumeMeter2.Name = "volumeMeter2";
            this.volumeMeter2.Size = new System.Drawing.Size(15, 77);
            this.volumeMeter2.TabIndex = 7;
            this.volumeMeter2.Text = "volumeMeter2";
            // 
            // comboBoxLatency
            // 
            this.comboBoxLatency.FormattingEnabled = true;
            this.comboBoxLatency.Location = new System.Drawing.Point(71, 9);
            this.comboBoxLatency.Name = "comboBoxLatency";
            this.comboBoxLatency.Size = new System.Drawing.Size(75, 20);
            this.comboBoxLatency.TabIndex = 3;
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.volumeMeter1.Location = new System.Drawing.Point(125, 59);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(15, 77);
            this.volumeMeter1.TabIndex = 6;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latency:";
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(7, 21);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(187, 20);
            this.comboBoxDriver.TabIndex = 0;
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.waveformPainter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waveformPainter1.Location = new System.Drawing.Point(12, 234);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(439, 55);
            this.waveformPainter1.TabIndex = 8;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // waveformPainter2
            // 
            this.waveformPainter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.waveformPainter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.waveformPainter2.Location = new System.Drawing.Point(13, 295);
            this.waveformPainter2.Name = "waveformPainter2";
            this.waveformPainter2.Size = new System.Drawing.Size(438, 55);
            this.waveformPainter2.TabIndex = 9;
            this.waveformPainter2.Text = "waveformPainter2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(0, 356);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(463, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickFrequency = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonPlay);
            this.groupBox2.Controls.Add(this.label_audio);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.StopRecordingBtn);
            this.groupBox2.Controls.Add(this.StartRecordingBtn);
            this.groupBox2.Controls.Add(this.comboBoxChannels);
            this.groupBox2.Controls.Add(this.comboBoxSampleRate);
            this.groupBox2.Controls.Add(this.comboWaveInDevice);
            this.groupBox2.Location = new System.Drawing.Point(223, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WAV Recording";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 120);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recording Progress:";
            // 
            // StopRecordingBtn
            // 
            this.StopRecordingBtn.Enabled = false;
            this.StopRecordingBtn.Location = new System.Drawing.Point(117, 74);
            this.StopRecordingBtn.Name = "StopRecordingBtn";
            this.StopRecordingBtn.Size = new System.Drawing.Size(105, 23);
            this.StopRecordingBtn.TabIndex = 4;
            this.StopRecordingBtn.Text = "Stop Recording";
            this.StopRecordingBtn.UseVisualStyleBackColor = true;
            this.StopRecordingBtn.Click += new System.EventHandler(this.OnButtonStopRecordingClick);
            // 
            // StartRecordingBtn
            // 
            this.StartRecordingBtn.Location = new System.Drawing.Point(6, 74);
            this.StartRecordingBtn.Name = "StartRecordingBtn";
            this.StartRecordingBtn.Size = new System.Drawing.Size(105, 23);
            this.StartRecordingBtn.TabIndex = 3;
            this.StartRecordingBtn.Text = "Start Recording";
            this.StartRecordingBtn.UseVisualStyleBackColor = true;
            this.StartRecordingBtn.Click += new System.EventHandler(this.OnButtonStartRecordingClick);
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Location = new System.Drawing.Point(118, 48);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(104, 20);
            this.comboBoxChannels.TabIndex = 2;
            // 
            // comboBoxSampleRate
            // 
            this.comboBoxSampleRate.FormattingEnabled = true;
            this.comboBoxSampleRate.Location = new System.Drawing.Point(7, 48);
            this.comboBoxSampleRate.Name = "comboBoxSampleRate";
            this.comboBoxSampleRate.Size = new System.Drawing.Size(105, 20);
            this.comboBoxSampleRate.TabIndex = 1;
            // 
            // comboWaveInDevice
            // 
            this.comboWaveInDevice.FormattingEnabled = true;
            this.comboWaveInDevice.Location = new System.Drawing.Point(6, 20);
            this.comboWaveInDevice.Name = "comboWaveInDevice";
            this.comboWaveInDevice.Size = new System.Drawing.Size(216, 20);
            this.comboWaveInDevice.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(6, 170);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(60, 23);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.OnButtonPlayClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(86, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(162, 170);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(60, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.OnOpenFolderClick);
            // 
            // label_audio
            // 
            this.label_audio.AutoSize = true;
            this.label_audio.Location = new System.Drawing.Point(9, 151);
            this.label_audio.Name = "label_audio";
            this.label_audio.Size = new System.Drawing.Size(0, 12);
            this.label_audio.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.waveformPainter2);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "AudioTest";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripPlay;
        private System.Windows.Forms.ToolStripButton toolStripPause;
        private System.Windows.Forms.ToolStripButton toolStripStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel currentTimeLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel totalTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLatency;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.Label label3;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.VolumeMeter volumeMeter2;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.WaveformPainter waveformPainter2;
        private System.Windows.Forms.RadioButton rightRadio;
        private System.Windows.Forms.RadioButton leftRadio;
        private System.Windows.Forms.RadioButton litiRadio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSampleRate;
        private System.Windows.Forms.ComboBox comboWaveInDevice;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.Button StopRecordingBtn;
        private System.Windows.Forms.Button StartRecordingBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label_audio;
    }
}

