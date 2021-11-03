
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.buttonStartAfterPause = new System.Windows.Forms.Button();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRecordingDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlaybackDevice = new System.Windows.Forms.ComboBox();
            this.buttonRecordMic = new System.Windows.Forms.Button();
            this.buttonStopRecordMic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(466, 65);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(334, 272);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(24, 115);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(160, 115);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(95, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(24, 162);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(89, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PlaySound",
            "WMP",
            "WaveOutWrite",
            "MCI",
            "DirectSound"});
            this.comboBox1.Location = new System.Drawing.Point(288, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(24, 212);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(89, 34);
            this.buttonRecord.TabIndex = 7;
            this.buttonRecord.Text = "RECORD";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click_1);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Location = new System.Drawing.Point(160, 211);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(95, 35);
            this.buttonStopRecord.TabIndex = 8;
            this.buttonStopRecord.Text = "STOP RECORD";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click_1);
            // 
            // buttonStartAfterPause
            // 
            this.buttonStartAfterPause.Location = new System.Drawing.Point(160, 162);
            this.buttonStartAfterPause.Name = "buttonStartAfterPause";
            this.buttonStartAfterPause.Size = new System.Drawing.Size(95, 43);
            this.buttonStartAfterPause.TabIndex = 9;
            this.buttonStartAfterPause.Text = "START AFTER PAUSE";
            this.buttonStartAfterPause.UseVisualStyleBackColor = true;
            this.buttonStartAfterPause.Click += new System.EventHandler(this.buttonStartAfterPause_Click_1);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(24, 65);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(231, 21);
            this.buttonChooseFile.TabIndex = 10;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recording Device";
            // 
            // comboBoxRecordingDevice
            // 
            this.comboBoxRecordingDevice.FormattingEnabled = true;
            this.comboBoxRecordingDevice.Location = new System.Drawing.Point(120, 276);
            this.comboBoxRecordingDevice.Name = "comboBoxRecordingDevice";
            this.comboBoxRecordingDevice.Size = new System.Drawing.Size(244, 21);
            this.comboBoxRecordingDevice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Playback Device";
            // 
            // comboBoxPlaybackDevice
            // 
            this.comboBoxPlaybackDevice.FormattingEnabled = true;
            this.comboBoxPlaybackDevice.Location = new System.Drawing.Point(120, 331);
            this.comboBoxPlaybackDevice.Name = "comboBoxPlaybackDevice";
            this.comboBoxPlaybackDevice.Size = new System.Drawing.Size(244, 21);
            this.comboBoxPlaybackDevice.TabIndex = 14;
            // 
            // buttonRecordMic
            // 
            this.buttonRecordMic.Location = new System.Drawing.Point(24, 376);
            this.buttonRecordMic.Name = "buttonRecordMic";
            this.buttonRecordMic.Size = new System.Drawing.Size(85, 41);
            this.buttonRecordMic.TabIndex = 15;
            this.buttonRecordMic.Text = "RECORD MIC";
            this.buttonRecordMic.UseVisualStyleBackColor = true;
            this.buttonRecordMic.Click += new System.EventHandler(this.buttonRecordMic_Click);
            // 
            // buttonStopRecordMic
            // 
            this.buttonStopRecordMic.Location = new System.Drawing.Point(160, 376);
            this.buttonStopRecordMic.Name = "buttonStopRecordMic";
            this.buttonStopRecordMic.Size = new System.Drawing.Size(95, 41);
            this.buttonStopRecordMic.TabIndex = 16;
            this.buttonStopRecordMic.Text = "STOP RECORD MIC";
            this.buttonStopRecordMic.UseVisualStyleBackColor = true;
            this.buttonStopRecordMic.Click += new System.EventHandler(this.buttonStopRecordMic_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(812, 429);
            this.Controls.Add(this.buttonStopRecordMic);
            this.Controls.Add(this.buttonRecordMic);
            this.Controls.Add(this.comboBoxPlaybackDevice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRecordingDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.buttonStartAfterPause);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.Button buttonStartAfterPause;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecordingDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPlaybackDevice;
        private System.Windows.Forms.Button buttonRecordMic;
        private System.Windows.Forms.Button buttonStopRecordMic;
    }
}

