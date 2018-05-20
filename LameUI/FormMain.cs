using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LameUI
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			//had to do it this way because bugs
			comboBoxBitrateMode.Text = "VBR";
			comboBoxQuality.Text = "0";
			comboBoxMode.Text = "j (joint)";
			comboBoxReplayGain.Text = "None (--noreplaygain)";
			comboBoxNoiseShaping.Text = "0";
		}

		const String encoderFileName = "lame.exe";
		String path, filename, extension, options;

		private void btnAddArgs_Click(object sender, EventArgs e)
		{
			String bitrate = " -V 0";
			if (comboBoxBitrateMode.SelectedIndex == 0)
			{
				 bitrate = String.Concat(" -V ", comboBoxQuality.Text);
			}

			else
				if(txtBoxBitrate.Text=="")
				{
					txtBoxBitrate.Text = 320.ToString();
				}

			if (comboBoxBitrateMode.SelectedIndex == 1)
			{
				bitrate = String.Concat(" --cbr -b ", txtBoxBitrate.Text);
			}

			if (comboBoxBitrateMode.SelectedIndex == 2)
			{
				bitrate = String.Concat(" --abr ", txtBoxBitrate.Text);
			}

			options = String.Concat(bitrate," -m ", comboBoxMode.SelectedItem.ToString()[0], " --noreplaygain", " -q ", comboBoxNoiseShaping.Text);

			txtBoxCommand.Text = String.Concat(encoderFileName, options, " \"", path, '\\', filename, extension, "\" \"", path, '\\', filename, ".mp3\"");

		}

		private void comboBoxBitrateMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(comboBoxBitrateMode.SelectedIndex)
			{
				case 0: //VBR
				{
					comboBoxQuality.Enabled = true;
					labelQuality.Enabled = true;
					labelBitrate.Enabled = false;
					txtBoxBitrate.Enabled = false;
					break;
				}

				case 1:    //CBR
				case 2:    //ABR
					{
					comboBoxQuality.Enabled = false;
					labelQuality.Enabled = false;
					labelBitrate.Enabled = true;
					txtBoxBitrate.Enabled = true;
					break;
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			#region wall of text
			String help = String.Concat("LAME 64bit version 3.100 (http://lame.sf.net)\n",
				"usage: lame [options] <infile> [outfile]\n",
				"\n",
				"OPTIONS:\n",
				"  Operational options:\n",
				"    -m <mode>       (j)oint, (s)imple, (f)orce, (d)ual-mono, (m)ono (l)eft (r)ig\n",
				"ht\n",
				"                    default is (j)\n",
				"                    joint  = Uses the best possible of MS and LR stereo\n",
				"                    simple = force LR stereo on all frames\n",
				"                    force  = force MS stereo on all frames.\n",
				"    --replaygain-fast   compute RG fast but slightly inaccurately (default)\n",
				"    --replaygain-accurate   compute RG more accurately and find the peak sample\n",
				"    --noreplaygain  disable ReplayGain analysis\n",
				"\n",
				"\n",
				"  Noise shaping & psycho acoustic algorithms:\n",
				"    -q <arg>        <arg> = 0...9.  Default  -q 3\n",
				"                    -q 0:  Highest quality, very slow\n",
				"                    -q 9:  Poor quality, but fast\n",
				"\n",
				"\n",
				"  CBR (constant bitrate, the default) options:\n",
				"    -b <bitrate>    set the bitrate in kbps, default 128 kbps\n",
				"    --cbr           enforce use of constant bitrate\n",
				"\n",
				"  ABR options:\n",
				"    --abr <bitrate> specify average bitrate desired (instead of quality)\n",
				"\n",
				"  VBR options:\n",
				"    -V n            quality setting for VBR.  default n=4\n",
				"                    0=high quality,bigger files. 9=smaller files\n",
				"    -b <bitrate>    specify minimum allowed bitrate, default  32 kbps\n",
				"    -B <bitrate>    specify maximum allowed bitrate, default 320 kbps\n",
				"    -F              strictly enforce the -b option, for use with players that\n",
				"                    do not support low bitrate mp3\n",
				"\n",
				"\n",
				"  Filter options:\n",
				"  --lowpass <freq>        frequency(kHz), lowpass filter cutoff above freq\n",
				"  --lowpass-width <freq>  frequency(kHz) - default 15% of lowpass freq\n",
				"  --highpass <freq>       frequency(kHz), highpass filter cutoff below freq\n",
				"  --highpass-width <freq> frequency(kHz) - default 15% of highpass freq\n",
				"  --resample <sfreq>  sampling frequency of output file(kHz)- default=automatic\n",
				"\n",
				"\n",
				"MS-Windows-specific options:\n",
				"    --priority <type>  sets the process priority:\n",
				"                         0,1 = Low priority (IDLE_PRIORITY_CLASS)\n",
				"                         2 = normal priority (NORMAL_PRIORITY_CLASS, default)\n",
				"                         3,4 = High priority (HIGH_PRIORITY_CLASS))\n",
				"    Note: Calling '--priority' without a parameter will select priority 0.\n",
				"\n",
				"Misc:\n",
				"MPEG-1   layer III sample frequencies (kHz):  32  48  44.1\n",
				"bitrates (kbps): 32 40 48 56 64 80 96 112 128 160 192 224 256 320\n",
				"\n",
				"MPEG-2   layer III sample frequencies (kHz):  16  24  22.05\n",
				"bitrates (kbps):  8 16 24 32 40 48 56 64 80 96 112 128 144 160\n",
				"\n",
				"MPEG-2.5 layer III sample frequencies (kHz):   8  12  11.025\n",
				"bitrates (kbps):  8 16 24 32 40 48 56 64");
			#endregion
			MessageBox.Show(help, "LAME Help", MessageBoxButtons.OK);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.RedirectStandardOutput = false;
			process.StartInfo.RedirectStandardOutput = false;
			process.StartInfo.FileName = encoderFileName;
			process.StartInfo.Arguments = String.Concat(options, " \"", path, '\\', filename, extension, "\" \"", path, '\\', filename, ".mp3\"");

			process.Start();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "WAVE audio files|*.wav",
				Title = "Select a WAVE File"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
				filename = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
				extension = System.IO.Path.GetExtension(openFileDialog.FileName);
				
				txtBoxInput.Text = String.Concat(path, '\\', filename, extension);
				txtBoxOutput.Text = String.Concat(path, '\\', filename, ".mp3");
			}
		}
	}
}
