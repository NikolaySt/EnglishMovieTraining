namespace Samples.WinForms.Advanced
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.myBtnPlay = new System.Windows.Forms.Button();
			this.myBtnStop = new System.Windows.Forms.Button();
			this.myLblState = new System.Windows.Forms.Label();
			this.myBtnPause = new System.Windows.Forms.Button();
			this.myVlcControl = new Vlc.DotNet.Forms.VlcControl();
			this.btnSeek = new System.Windows.Forms.Button();
			this.listBoxSubtitles = new System.Windows.Forms.ListBox();
			this.textBoxScript = new System.Windows.Forms.TextBox();
			this.btnAudioTracks = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).BeginInit();
			this.SuspendLayout();
			// 
			// myBtnPlay
			// 
			this.myBtnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.myBtnPlay.Location = new System.Drawing.Point(12, 623);
			this.myBtnPlay.Margin = new System.Windows.Forms.Padding(4);
			this.myBtnPlay.Name = "myBtnPlay";
			this.myBtnPlay.Size = new System.Drawing.Size(68, 28);
			this.myBtnPlay.TabIndex = 1;
			this.myBtnPlay.Text = "Play";
			this.myBtnPlay.UseVisualStyleBackColor = true;
			this.myBtnPlay.Click += new System.EventHandler(this.OnButtonPlayClicked);
			// 
			// myBtnStop
			// 
			this.myBtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.myBtnStop.Location = new System.Drawing.Point(164, 623);
			this.myBtnStop.Margin = new System.Windows.Forms.Padding(4);
			this.myBtnStop.Name = "myBtnStop";
			this.myBtnStop.Size = new System.Drawing.Size(68, 28);
			this.myBtnStop.TabIndex = 2;
			this.myBtnStop.Text = "Stop";
			this.myBtnStop.UseVisualStyleBackColor = true;
			this.myBtnStop.Click += new System.EventHandler(this.OnButtonStopClicked);
			// 
			// myLblState
			// 
			this.myLblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.myLblState.AutoSize = true;
			this.myLblState.Location = new System.Drawing.Point(583, 629);
			this.myLblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.myLblState.Name = "myLblState";
			this.myLblState.Size = new System.Drawing.Size(0, 17);
			this.myLblState.TabIndex = 7;
			// 
			// myBtnPause
			// 
			this.myBtnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.myBtnPause.Location = new System.Drawing.Point(88, 623);
			this.myBtnPause.Margin = new System.Windows.Forms.Padding(4);
			this.myBtnPause.Name = "myBtnPause";
			this.myBtnPause.Size = new System.Drawing.Size(68, 28);
			this.myBtnPause.TabIndex = 8;
			this.myBtnPause.Text = "Pause";
			this.myBtnPause.UseVisualStyleBackColor = true;
			this.myBtnPause.Click += new System.EventHandler(this.OnButtonPauseClicked);
			// 
			// myVlcControl
			// 
			this.myVlcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myVlcControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.myVlcControl.Location = new System.Drawing.Point(16, 15);
			this.myVlcControl.Margin = new System.Windows.Forms.Padding(4);
			this.myVlcControl.Name = "myVlcControl";
			this.myVlcControl.Size = new System.Drawing.Size(554, 569);
			this.myVlcControl.Spu = -1;
			this.myVlcControl.TabIndex = 0;
			this.myVlcControl.Text = "vlcRincewindControl1";
			this.myVlcControl.VlcLibDirectory = null;
			this.myVlcControl.VlcMediaplayerOptions = null;
			this.myVlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.OnVlcControlNeedLibDirectory);
			this.myVlcControl.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.myVlcControl_PositionChanged);
			// 
			// btnSeek
			// 
			this.btnSeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSeek.Location = new System.Drawing.Point(240, 623);
			this.btnSeek.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeek.Name = "btnSeek";
			this.btnSeek.Size = new System.Drawing.Size(68, 28);
			this.btnSeek.TabIndex = 19;
			this.btnSeek.Text = "Seek";
			this.btnSeek.UseVisualStyleBackColor = true;
			this.btnSeek.Click += new System.EventHandler(this.btnSeek_Click);
			// 
			// listBoxSubtitles
			// 
			this.listBoxSubtitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxSubtitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxSubtitles.FormattingEnabled = true;
			this.listBoxSubtitles.ItemHeight = 20;
			this.listBoxSubtitles.Location = new System.Drawing.Point(577, 15);
			this.listBoxSubtitles.Name = "listBoxSubtitles";
			this.listBoxSubtitles.Size = new System.Drawing.Size(752, 564);
			this.listBoxSubtitles.TabIndex = 20;
			this.listBoxSubtitles.DoubleClick += new System.EventHandler(this.listBoxSubtitles_DoubleClick);
			// 
			// textBoxScript
			// 
			this.textBoxScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxScript.Location = new System.Drawing.Point(577, 590);
			this.textBoxScript.Multiline = true;
			this.textBoxScript.Name = "textBoxScript";
			this.textBoxScript.Size = new System.Drawing.Size(752, 66);
			this.textBoxScript.TabIndex = 21;
			// 
			// btnAudioTracks
			// 
			this.btnAudioTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAudioTracks.Location = new System.Drawing.Point(316, 623);
			this.btnAudioTracks.Margin = new System.Windows.Forms.Padding(4);
			this.btnAudioTracks.Name = "btnAudioTracks";
			this.btnAudioTracks.Size = new System.Drawing.Size(68, 28);
			this.btnAudioTracks.TabIndex = 22;
			this.btnAudioTracks.Text = "Switch Audio";
			this.btnAudioTracks.UseVisualStyleBackColor = true;
			this.btnAudioTracks.Click += new System.EventHandler(this.btnAudioTracks_Click);
			// 
			// Sample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1347, 666);
			this.Controls.Add(this.btnAudioTracks);
			this.Controls.Add(this.textBoxScript);
			this.Controls.Add(this.listBoxSubtitles);
			this.Controls.Add(this.btnSeek);
			this.Controls.Add(this.myBtnPause);
			this.Controls.Add(this.myLblState);
			this.Controls.Add(this.myBtnStop);
			this.Controls.Add(this.myBtnPlay);
			this.Controls.Add(this.myVlcControl);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Sample";
			this.Text = "Vlc.DotNet - Winform Player Sample";
			((System.ComponentModel.ISupportInitialize)(this.myVlcControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl myVlcControl;
        private System.Windows.Forms.Button myBtnPlay;
        private System.Windows.Forms.Button myBtnStop;
        private System.Windows.Forms.Label myLblState;
        private System.Windows.Forms.Button myBtnPause;
		private System.Windows.Forms.Button btnSeek;
		private System.Windows.Forms.ListBox listBoxSubtitles;
		private System.Windows.Forms.TextBox textBoxScript;
		private System.Windows.Forms.Button btnAudioTracks;
	}
}

