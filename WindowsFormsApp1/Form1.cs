using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using NAudio.Wave;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        WaveIn waveRecord;
        WaveFileWriter writerRecord;
        string PlayCommand;
        bool isOpen;
        string output_file_name;
        string file_name;
        WasapiLoopbackCapture capture;

        NAudio.Wave.WaveFileReader wave = null;
        NAudio.Wave.DirectSoundOut output = null;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr oCallback);

        //[DllImport("winmm.dll")]
        //public static extern int waveOutOpen(out IntPtr hWaveOut, int uDeviceID, Microsoft.DirectX.DirectSound.WaveFormat lpFormat, WaveDelegate dwCallback, IntPtr dwInstance, int dwFlags);

        public Form1()
        {
            InitializeComponent();
            LoadDevices();
            buttonStopRecord.Enabled = false;
            buttonStopRecordMic.Enabled = false;
        }

        private void LoadDevices()
        {
            for(int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                comboBoxRecordingDevice.Items.Add(deviceInfo.ProductName);
            }

            for (int deviceId = 0; deviceId < WaveIn.DeviceCount; deviceId++)
            {
                var deviceInfo = WaveIn.GetCapabilities(deviceId);
                comboBoxPlaybackDevice.Items.Add(deviceInfo.ProductName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "PlaySound")
            {
                System.Media.SoundPlayer SoundCardHandler = new System.Media.SoundPlayer(file_name);
                SoundCardHandler.Play();
            }
            if ((string)comboBox1.SelectedItem == "WMP")
            {
                axWindowsMediaPlayer1.URL = file_name;
            }
            if ((string)comboBox1.SelectedItem == "WaveOutWrite")
            {

            }
            if ((string)comboBox1.SelectedItem == "MCI")
            {
                PlayCommand = "Open \"" + file_name + "\" alias MediaFile";
                mciSendString(PlayCommand, null, 0, IntPtr.Zero);
                isOpen = true;

                if (isOpen)
                {
                    PlayCommand = "Play MediaFile";
                    mciSendString(PlayCommand, null, 0, IntPtr.Zero);
                }
            }
            if ((string)comboBox1.SelectedItem == "DirectSound")
            {
                wave = new NAudio.Wave.WaveFileReader(file_name);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(new NAudio.Wave.WaveChannel32(wave));

                output.Play();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "PlaySound")
            {
                System.Media.SoundPlayer SoundCardHandler = new System.Media.SoundPlayer();
                SoundCardHandler.Stop();
            }
            if ((string)comboBox1.SelectedItem == "WMP")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            if ((string)comboBox1.SelectedItem == "WaveOutWrite")
            {

            }
            if ((string)comboBox1.SelectedItem == "MCI")
            {
                PlayCommand = "Close MediaFile";
                mciSendString(PlayCommand, null, 0, IntPtr.Zero);
                isOpen = false;
            }
            if ((string)comboBox1.SelectedItem == "DirectSound")
            {
                output.Stop();
            }
        }

        private void buttonChooseFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = @"Wave File (*.wav)|*.wav";
            if (fileDialog.ShowDialog() != DialogResult)
            {
                file_name = fileDialog.InitialDirectory + fileDialog.FileName;
            }
        }

        private void buttonRecord_Click_1(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files | *.wav";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            output_file_name = dialog.FileName;

            buttonRecord.Enabled = false;
            buttonStopRecord.Enabled = true;

            capture = new WasapiLoopbackCapture();
            var writer = new WaveFileWriter(output_file_name, capture.WaveFormat);

            capture.DataAvailable += async (s, c) =>
            {
                if (writer != null)
                {
                    await writer.WriteAsync(c.Buffer, 0, c.BytesRecorded);
                    await writer.FlushAsync();
                }
            };

            capture.RecordingStopped += (s, c) =>
            {
                if (writer != null)
                {
                    writer.Dispose();
                    writer = null;
                }

                buttonRecord.Enabled = true;
                capture.Dispose();
            };

            capture.StartRecording();
        }

        

        private void buttonStopRecord_Click_1(object sender, EventArgs e)
        {
            buttonStopRecord.Enabled = false;
            capture.StopRecording();

            if (output_file_name == null)
                return;

            var processStartInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(output_file_name),
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        private void buttonStartAfterPause_Click_1(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "WMP")
            {
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)axWindowsMediaPlayer1.Ctlcontrols;
                controls.play();
            }
            if ((string)comboBox1.SelectedItem == "MCI")
            {
                string mciResume = "resume MediaFile";
                mciSendString(mciResume, null, 0, IntPtr.Zero);
            }
            if ((string)comboBox1.SelectedItem == "DirectSound")
            {
                output.Play();
            }
        }

        private void buttonPause_Click_1(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "PlaySound")
            {
                MessageBox.Show("Nie da sie zapauzowac!");
            }
            if ((string)comboBox1.SelectedItem == "WMP")
            {
                WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)axWindowsMediaPlayer1.Ctlcontrols;
                controls.pause();
            }
            if ((string)comboBox1.SelectedItem == "WaveOutWrite")
            {

            }
            if ((string)comboBox1.SelectedItem == "MCI")
            {
                string mciPause = "pause Mediafile";
                mciSendString(mciPause, null, 0, IntPtr.Zero);
            }
            if ((string)comboBox1.SelectedItem == "DirectSound")
            {
                output.Pause();
            }
        }

        private void buttonRecordMic_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files | *.wav";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            output_file_name = dialog.FileName;

            buttonRecordMic.Enabled = false;
            buttonStopRecordMic.Enabled = true;

            waveRecord = new WaveIn();
            waveRecord.WaveFormat = new WaveFormat(44100, 1);
            waveRecord.DeviceNumber = comboBoxRecordingDevice.SelectedIndex;
            waveRecord.DataAvailable += Wave_DataAvailable;
            waveRecord.RecordingStopped += Wave_RecordingStopped;
            writerRecord = new WaveFileWriter(output_file_name, waveRecord.WaveFormat);
            waveRecord.StartRecording();
        }

        private void buttonStopRecordMic_Click(object sender, EventArgs e)
        {
            buttonStopRecordMic.Enabled = false;
            waveRecord.StopRecording();

            if (output_file_name == null)
                return;

            var processStartInfo = new ProcessStartInfo
            {
                FileName = Path.GetDirectoryName(output_file_name),
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writerRecord.Dispose();
            buttonRecordMic.Enabled = true;
            buttonStopRecordMic.Enabled = false;
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writerRecord.Write(e.Buffer, 0, e.BytesRecorded);
        }
    }
}
