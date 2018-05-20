namespace LameUI
{
	partial class FormMain
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
			this.txtBoxInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxOutput = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.txtBoxCommand = new System.Windows.Forms.TextBox();
			this.groupBoxSwitches = new System.Windows.Forms.GroupBox();
			this.comboBoxNoiseShaping = new System.Windows.Forms.ComboBox();
			this.comboBoxQuality = new System.Windows.Forms.ComboBox();
			this.labelQuality = new System.Windows.Forms.Label();
			this.labelNoiseShaping = new System.Windows.Forms.Label();
			this.txtBoxBitrate = new System.Windows.Forms.TextBox();
			this.labelBitrate = new System.Windows.Forms.Label();
			this.comboBoxReplayGain = new System.Windows.Forms.ComboBox();
			this.labelReplayGain = new System.Windows.Forms.Label();
			this.labelBitrateMode = new System.Windows.Forms.Label();
			this.comboBoxBitrateMode = new System.Windows.Forms.ComboBox();
			this.labelMode = new System.Windows.Forms.Label();
			this.comboBoxMode = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.groupBoxSwitches.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBoxInput
			// 
			this.txtBoxInput.AllowDrop = true;
			this.txtBoxInput.Location = new System.Drawing.Point(57, 12);
			this.txtBoxInput.Name = "txtBoxInput";
			this.txtBoxInput.Size = new System.Drawing.Size(265, 20);
			this.txtBoxInput.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Output";
			// 
			// txtBoxOutput
			// 
			this.txtBoxOutput.Location = new System.Drawing.Point(57, 41);
			this.txtBoxOutput.Name = "txtBoxOutput";
			this.txtBoxOutput.Size = new System.Drawing.Size(265, 20);
			this.txtBoxOutput.TabIndex = 3;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(328, 10);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(53, 23);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "Open ...";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtBoxCommand
			// 
			this.txtBoxCommand.Location = new System.Drawing.Point(72, 189);
			this.txtBoxCommand.Name = "txtBoxCommand";
			this.txtBoxCommand.ReadOnly = true;
			this.txtBoxCommand.Size = new System.Drawing.Size(199, 20);
			this.txtBoxCommand.TabIndex = 5;
			// 
			// groupBoxSwitches
			// 
			this.groupBoxSwitches.Controls.Add(this.comboBoxNoiseShaping);
			this.groupBoxSwitches.Controls.Add(this.comboBoxQuality);
			this.groupBoxSwitches.Controls.Add(this.labelQuality);
			this.groupBoxSwitches.Controls.Add(this.labelNoiseShaping);
			this.groupBoxSwitches.Controls.Add(this.txtBoxBitrate);
			this.groupBoxSwitches.Controls.Add(this.labelBitrate);
			this.groupBoxSwitches.Controls.Add(this.comboBoxReplayGain);
			this.groupBoxSwitches.Controls.Add(this.labelReplayGain);
			this.groupBoxSwitches.Controls.Add(this.labelBitrateMode);
			this.groupBoxSwitches.Controls.Add(this.comboBoxBitrateMode);
			this.groupBoxSwitches.Controls.Add(this.labelMode);
			this.groupBoxSwitches.Controls.Add(this.comboBoxMode);
			this.groupBoxSwitches.Location = new System.Drawing.Point(12, 76);
			this.groupBoxSwitches.Name = "groupBoxSwitches";
			this.groupBoxSwitches.Size = new System.Drawing.Size(369, 105);
			this.groupBoxSwitches.TabIndex = 7;
			this.groupBoxSwitches.TabStop = false;
			this.groupBoxSwitches.Text = "LAME Switches";
			// 
			// comboBoxNoiseShaping
			// 
			this.comboBoxNoiseShaping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNoiseShaping.Enabled = false;
			this.comboBoxNoiseShaping.FormattingEnabled = true;
			this.comboBoxNoiseShaping.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.comboBoxNoiseShaping.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.comboBoxNoiseShaping.Location = new System.Drawing.Point(234, 73);
			this.comboBoxNoiseShaping.Name = "comboBoxNoiseShaping";
			this.comboBoxNoiseShaping.Size = new System.Drawing.Size(125, 21);
			this.comboBoxNoiseShaping.TabIndex = 9;
			// 
			// comboBoxQuality
			// 
			this.comboBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxQuality.FormattingEnabled = true;
			this.comboBoxQuality.ImeMode = System.Windows.Forms.ImeMode.Alpha;
			this.comboBoxQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.comboBoxQuality.Location = new System.Drawing.Point(78, 72);
			this.comboBoxQuality.Name = "comboBoxQuality";
			this.comboBoxQuality.Size = new System.Drawing.Size(70, 21);
			this.comboBoxQuality.TabIndex = 5;
			// 
			// labelQuality
			// 
			this.labelQuality.AutoSize = true;
			this.labelQuality.Location = new System.Drawing.Point(6, 75);
			this.labelQuality.Name = "labelQuality";
			this.labelQuality.Size = new System.Drawing.Size(39, 13);
			this.labelQuality.TabIndex = 4;
			this.labelQuality.Text = "Quality";
			// 
			// labelNoiseShaping
			// 
			this.labelNoiseShaping.AutoSize = true;
			this.labelNoiseShaping.Location = new System.Drawing.Point(154, 76);
			this.labelNoiseShaping.Name = "labelNoiseShaping";
			this.labelNoiseShaping.Size = new System.Drawing.Size(74, 13);
			this.labelNoiseShaping.TabIndex = 12;
			this.labelNoiseShaping.Text = "Noise shaping";
			// 
			// txtBoxBitrate
			// 
			this.txtBoxBitrate.Enabled = false;
			this.txtBoxBitrate.Location = new System.Drawing.Point(78, 46);
			this.txtBoxBitrate.Name = "txtBoxBitrate";
			this.txtBoxBitrate.Size = new System.Drawing.Size(70, 20);
			this.txtBoxBitrate.TabIndex = 3;
			// 
			// labelBitrate
			// 
			this.labelBitrate.AutoSize = true;
			this.labelBitrate.Enabled = false;
			this.labelBitrate.Location = new System.Drawing.Point(6, 49);
			this.labelBitrate.Name = "labelBitrate";
			this.labelBitrate.Size = new System.Drawing.Size(37, 13);
			this.labelBitrate.TabIndex = 2;
			this.labelBitrate.Text = "Bitrate";
			// 
			// comboBoxReplayGain
			// 
			this.comboBoxReplayGain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxReplayGain.Enabled = false;
			this.comboBoxReplayGain.FormattingEnabled = true;
			this.comboBoxReplayGain.Items.AddRange(new object[] {
            "None (--noreplaygain)",
            "Fast (--replaygain-fast)",
            "Accurate (--replaygain-accurate)"});
			this.comboBoxReplayGain.Location = new System.Drawing.Point(234, 46);
			this.comboBoxReplayGain.Name = "comboBoxReplayGain";
			this.comboBoxReplayGain.Size = new System.Drawing.Size(125, 21);
			this.comboBoxReplayGain.TabIndex = 11;
			// 
			// labelReplayGain
			// 
			this.labelReplayGain.AutoSize = true;
			this.labelReplayGain.Location = new System.Drawing.Point(154, 49);
			this.labelReplayGain.Name = "labelReplayGain";
			this.labelReplayGain.Size = new System.Drawing.Size(62, 13);
			this.labelReplayGain.TabIndex = 10;
			this.labelReplayGain.Text = "ReplayGain";
			// 
			// labelBitrateMode
			// 
			this.labelBitrateMode.AutoSize = true;
			this.labelBitrateMode.Location = new System.Drawing.Point(6, 22);
			this.labelBitrateMode.Name = "labelBitrateMode";
			this.labelBitrateMode.Size = new System.Drawing.Size(66, 13);
			this.labelBitrateMode.TabIndex = 1;
			this.labelBitrateMode.Text = "Bitrate mode";
			// 
			// comboBoxBitrateMode
			// 
			this.comboBoxBitrateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBitrateMode.FormattingEnabled = true;
			this.comboBoxBitrateMode.Items.AddRange(new object[] {
            "VBR",
            "CBR",
            "ABR"});
			this.comboBoxBitrateMode.Location = new System.Drawing.Point(78, 19);
			this.comboBoxBitrateMode.Name = "comboBoxBitrateMode";
			this.comboBoxBitrateMode.Size = new System.Drawing.Size(70, 21);
			this.comboBoxBitrateMode.TabIndex = 0;
			this.comboBoxBitrateMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxBitrateMode_SelectedIndexChanged);
			// 
			// labelMode
			// 
			this.labelMode.AutoSize = true;
			this.labelMode.Location = new System.Drawing.Point(154, 22);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(34, 13);
			this.labelMode.TabIndex = 9;
			this.labelMode.Text = "Mode";
			// 
			// comboBoxMode
			// 
			this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMode.FormattingEnabled = true;
			this.comboBoxMode.Items.AddRange(new object[] {
            "j (joint)",
            "s (simple)",
            "f (force)",
            "d (dual-mono)",
            "m (mono)",
            "l (left)",
            "r (right)"});
			this.comboBoxMode.Location = new System.Drawing.Point(234, 19);
			this.comboBoxMode.Name = "comboBoxMode";
			this.comboBoxMode.Size = new System.Drawing.Size(125, 21);
			this.comboBoxMode.TabIndex = 1;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(277, 187);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(50, 23);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnAddArgs_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Command";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(333, 187);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(48, 23);
			this.btnStart.TabIndex = 14;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(328, 39);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(53, 23);
			this.btnHelp.TabIndex = 15;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 221);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.groupBoxSwitches);
			this.Controls.Add(this.txtBoxCommand);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.txtBoxOutput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormMain";
			this.Text = "LameUI";
			this.groupBoxSwitches.ResumeLayout(false);
			this.groupBoxSwitches.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBoxOutput;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox txtBoxCommand;
		private System.Windows.Forms.GroupBox groupBoxSwitches;
		private System.Windows.Forms.Label labelBitrateMode;
		private System.Windows.Forms.ComboBox comboBoxBitrateMode;
		private System.Windows.Forms.ComboBox comboBoxQuality;
		private System.Windows.Forms.Label labelQuality;
		private System.Windows.Forms.TextBox txtBoxBitrate;
		private System.Windows.Forms.Label labelBitrate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxNoiseShaping;
		private System.Windows.Forms.Label labelNoiseShaping;
		private System.Windows.Forms.ComboBox comboBoxReplayGain;
		private System.Windows.Forms.Label labelReplayGain;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.ComboBox comboBoxMode;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnHelp;
	}
}

