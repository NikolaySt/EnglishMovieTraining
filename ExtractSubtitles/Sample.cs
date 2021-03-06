using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Samples.WinForms.Advanced.Data;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;

namespace Samples.WinForms.Advanced
{
	public partial class Sample : Form
	{
		public delegate void UpdateControlsDelegate();

		public Sample()
		{
			InitializeComponent();
			LoadSubtitles();

		}

		/// <summary>
		/// When the Vlc control needs to find the location of the libvlc.dll.
		/// You could have set the VlcLibDirectory in the designer, but for this sample, we are in AnyCPU mode, and we don't know the process bitness.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVlcControlNeedLibDirectory(object sender, VlcLibDirectoryNeededEventArgs e)
		{
			var currentAssembly = Assembly.GetEntryAssembly();
			var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
			// Default installation path of VideoLAN.LibVLC.Windows
			e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

			if (!e.VlcLibDirectory.Exists)
			{
				var folderBrowserDialog = new FolderBrowserDialog
				{
					Description = "Select Vlc libraries folder.",
					RootFolder = Environment.SpecialFolder.Desktop,
					ShowNewFolderButton = true
				};
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
				}
			}
		}



		private void OnButtonStopClicked(object sender, EventArgs e)
		{
			myVlcControl.Stop();
		}

		private void OnButtonPauseClicked(object sender, EventArgs e)
		{
			myVlcControl.Pause();
		}

		private void myBtnDisableMouseEvents_Click(object sender, EventArgs e)
		{
			myVlcControl.Video.IsMouseInputEnabled = false;
			myVlcControl.Video.IsKeyInputEnabled = false;

		}

		private void myBtnEnableMouseEvents_Click(object sender, EventArgs e)
		{
			myVlcControl.Video.IsMouseInputEnabled = true;
			myVlcControl.Video.IsKeyInputEnabled = true;
		}

		private void btnSeek_Click(object sender, EventArgs e)
		{

			//Аз съм д-р Доналд Шърли. - Тони.	I'm Dr. Donald Shirley.	#00:14:40	#00:14:42
			//#00:16:43
			//Мадами ли ще водим?	Why? Are we bringing broads?
			myVlcControl.Time = (16 * 60 + 40) * 1000;
		}

		private void OnButtonPlayClicked(object sender, EventArgs e)
		{
			//myVlcControl.Rate = Convert.ToSingle(50.0 / 100.0);

			//myVlcControl.Play(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
			//myVlcControl.Play(new FileInfo(@"D:\Movies\Friends\Friends.S01E01.BDRip.Xvid.DualAudio.avi"));
			myVlcControl.Play(new FileInfo(@"D:\Movies\ted1.mp3"));

		}

		private void LoadSubtitles()
		{
			var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Subtitles");
			var file = Path.Combine(path, "ted1.bg.en.json");

			var json = File.ReadAllText(file);

			var lines = JsonConvert.DeserializeObject<List<RowTranslation>>(json);

			foreach (var item in lines)
			{
				listBoxSubtitles.Items.Add(item);
			}
		}

		private void listBoxSubtitles_DoubleClick(object sender, EventArgs e)
		{
			var listBox = sender as ListBox;
			if (listBox == null || listBox.SelectedItem == null)
				return;

			var row = listBox.SelectedItem as RowTranslation;
			textBoxScript.Text = row.ForeignLang.Text;

			var seekPosition = Convert.ToInt64(row.ForeignLang.From.TotalMilliseconds);
			Task.Factory.StartNew(() =>
			{
				myVlcControl.Time = seekPosition;
				if (!myVlcControl.IsPlaying)
				{
					myVlcControl.Pause();
				}
			});
		}

		private void currentTrackTime()
		{
			if (listBoxSubtitles.SelectedItem == null)
				return;

			var row = listBoxSubtitles.SelectedItem as RowTranslation;

			var stopPosition = Convert.ToInt64(row.ForeignLang.To.TotalMilliseconds) + 1 * 1000;

			Task.Factory.StartNew(() =>
			{
				if (myVlcControl.Time > stopPosition)
				{
					if (myVlcControl.IsPlaying)
					{
						myVlcControl.Pause();
					}
				}
			});
		}

		public void InvokeUpdateControls()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new UpdateControlsDelegate(currentTrackTime));
			}
			else
			{
				currentTrackTime();
			}
		}

		private void myVlcControl_PositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
		{
			InvokeUpdateControls();
		}

		private void btnAudioTracks_Click(object sender, EventArgs e)
		{
			Task.Factory.StartNew(() =>
			{
				myVlcControl.Audio.Tracks.Current = myVlcControl.Audio.Tracks.All.Last();
			});
		}
	}
}
