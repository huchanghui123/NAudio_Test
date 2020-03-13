﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;

namespace NAudioTest
{
    class MyWaveOut
    {
        public static string Name { get { return "MyWaveOut"; } }

        public static bool IsAvailable { get { return WaveOut.DeviceCount > 0; } }

        public static int Priority { get { return 1; } }

        public IWavePlayer CreateDevice(int deviceNumber, int latency)
        {
            IWavePlayer device;
            var waveOut = new WaveOutEvent
            {
                DeviceNumber = deviceNumber,
                DesiredLatency = latency
            };
            device = waveOut;
            return device;
        }
    }
}
