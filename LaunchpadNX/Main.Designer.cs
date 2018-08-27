namespace LaunchpadNX
{
    partial class LaunchpadNX
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
            this.atmsCheckbox = new System.Windows.Forms.CheckBox();
            this.lfsCheckbox = new System.Windows.Forms.CheckBox();
            this.hbmenuCheckbox = new System.Windows.Forms.CheckBox();
            this.hbmenuTitleSelect = new System.Windows.Forms.ComboBox();
            this.sigpatchesCheckbox = new System.Windows.Forms.CheckBox();
            this.tinfoilCheckbox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.checkpointCheckbox = new System.Windows.Forms.CheckBox();
            this.ftpdCheckbox = new System.Windows.Forms.CheckBox();
            this.hbasCheckbox = new System.Windows.Forms.CheckBox();
            this.switchidentCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpNroOptions = new System.Windows.Forms.GroupBox();
            this.lbl_hbmButton = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpNroOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // atmsCheckbox
            // 
            this.atmsCheckbox.AutoSize = true;
            this.atmsCheckbox.Checked = true;
            this.atmsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.atmsCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.atmsCheckbox.Enabled = false;
            this.atmsCheckbox.Location = new System.Drawing.Point(6, 21);
            this.atmsCheckbox.Name = "atmsCheckbox";
            this.atmsCheckbox.Size = new System.Drawing.Size(109, 17);
            this.atmsCheckbox.TabIndex = 0;
            this.atmsCheckbox.Text = "Atmosphere Base";
            this.atmsCheckbox.UseVisualStyleBackColor = true;
            // 
            // lfsCheckbox
            // 
            this.lfsCheckbox.AutoSize = true;
            this.lfsCheckbox.Location = new System.Drawing.Point(139, 21);
            this.lfsCheckbox.Name = "lfsCheckbox";
            this.lfsCheckbox.Size = new System.Drawing.Size(77, 17);
            this.lfsCheckbox.TabIndex = 1;
            this.lfsCheckbox.Text = "LayeredFS";
            this.lfsCheckbox.UseVisualStyleBackColor = true;
            // 
            // hbmenuCheckbox
            // 
            this.hbmenuCheckbox.AutoSize = true;
            this.hbmenuCheckbox.Location = new System.Drawing.Point(139, 44);
            this.hbmenuCheckbox.Name = "hbmenuCheckbox";
            this.hbmenuCheckbox.Size = new System.Drawing.Size(107, 17);
            this.hbmenuCheckbox.TabIndex = 2;
            this.hbmenuCheckbox.Text = "Homebrew Menu";
            this.hbmenuCheckbox.UseVisualStyleBackColor = true;
            this.hbmenuCheckbox.CheckedChanged += new System.EventHandler(this.hbmenuCheckbox_CheckedChanged);
            // 
            // hbmenuTitleSelect
            // 
            this.hbmenuTitleSelect.Enabled = false;
            this.hbmenuTitleSelect.FormattingEnabled = true;
            this.hbmenuTitleSelect.Items.AddRange(new object[] {
            "Album",
            "Controllers Screen"});
            this.hbmenuTitleSelect.Location = new System.Drawing.Point(139, 73);
            this.hbmenuTitleSelect.Name = "hbmenuTitleSelect";
            this.hbmenuTitleSelect.Size = new System.Drawing.Size(107, 21);
            this.hbmenuTitleSelect.TabIndex = 3;
            this.hbmenuTitleSelect.Text = "Album";
            // 
            // sigpatchesCheckbox
            // 
            this.sigpatchesCheckbox.AutoSize = true;
            this.sigpatchesCheckbox.Location = new System.Drawing.Point(6, 44);
            this.sigpatchesCheckbox.Name = "sigpatchesCheckbox";
            this.sigpatchesCheckbox.Size = new System.Drawing.Size(79, 17);
            this.sigpatchesCheckbox.TabIndex = 4;
            this.sigpatchesCheckbox.Text = "Sigpatches";
            this.sigpatchesCheckbox.UseVisualStyleBackColor = true;
            // 
            // tinfoilCheckbox
            // 
            this.tinfoilCheckbox.AutoSize = true;
            this.tinfoilCheckbox.Enabled = false;
            this.tinfoilCheckbox.Location = new System.Drawing.Point(6, 42);
            this.tinfoilCheckbox.Name = "tinfoilCheckbox";
            this.tinfoilCheckbox.Size = new System.Drawing.Size(54, 17);
            this.tinfoilCheckbox.TabIndex = 5;
            this.tinfoilCheckbox.Text = "Tinfoil";
            this.tinfoilCheckbox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 216);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(265, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // checkpointCheckbox
            // 
            this.checkpointCheckbox.AutoSize = true;
            this.checkpointCheckbox.Enabled = false;
            this.checkpointCheckbox.Location = new System.Drawing.Point(6, 65);
            this.checkpointCheckbox.Name = "checkpointCheckbox";
            this.checkpointCheckbox.Size = new System.Drawing.Size(80, 17);
            this.checkpointCheckbox.TabIndex = 8;
            this.checkpointCheckbox.Text = "Checkpoint";
            this.checkpointCheckbox.UseVisualStyleBackColor = true;
            // 
            // ftpdCheckbox
            // 
            this.ftpdCheckbox.AutoSize = true;
            this.ftpdCheckbox.Location = new System.Drawing.Point(6, 67);
            this.ftpdCheckbox.Name = "ftpdCheckbox";
            this.ftpdCheckbox.Size = new System.Drawing.Size(62, 17);
            this.ftpdCheckbox.TabIndex = 9;
            this.ftpdCheckbox.Text = "sys-ftpd";
            this.ftpdCheckbox.UseVisualStyleBackColor = true;
            // 
            // hbasCheckbox
            // 
            this.hbasCheckbox.AutoSize = true;
            this.hbasCheckbox.Enabled = false;
            this.hbasCheckbox.Location = new System.Drawing.Point(6, 19);
            this.hbasCheckbox.Name = "hbasCheckbox";
            this.hbasCheckbox.Size = new System.Drawing.Size(127, 17);
            this.hbasCheckbox.TabIndex = 10;
            this.hbasCheckbox.Text = "Homebrew App Store";
            this.hbasCheckbox.UseVisualStyleBackColor = true;
            // 
            // switchidentCheckbox
            // 
            this.switchidentCheckbox.AutoSize = true;
            this.switchidentCheckbox.Enabled = false;
            this.switchidentCheckbox.Location = new System.Drawing.Point(139, 19);
            this.switchidentCheckbox.Name = "switchidentCheckbox";
            this.switchidentCheckbox.Size = new System.Drawing.Size(82, 17);
            this.switchidentCheckbox.TabIndex = 11;
            this.switchidentCheckbox.Text = "SwitchIdent";
            this.switchidentCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpdCheckbox);
            this.groupBox1.Controls.Add(this.atmsCheckbox);
            this.groupBox1.Controls.Add(this.lfsCheckbox);
            this.groupBox1.Controls.Add(this.hbmenuCheckbox);
            this.groupBox1.Controls.Add(this.sigpatchesCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // grpNroOptions
            // 
            this.grpNroOptions.Controls.Add(this.lbl_hbmButton);
            this.grpNroOptions.Controls.Add(this.hbasCheckbox);
            this.grpNroOptions.Controls.Add(this.tinfoilCheckbox);
            this.grpNroOptions.Controls.Add(this.switchidentCheckbox);
            this.grpNroOptions.Controls.Add(this.hbmenuTitleSelect);
            this.grpNroOptions.Controls.Add(this.checkpointCheckbox);
            this.grpNroOptions.Location = new System.Drawing.Point(12, 110);
            this.grpNroOptions.Name = "grpNroOptions";
            this.grpNroOptions.Size = new System.Drawing.Size(265, 100);
            this.grpNroOptions.TabIndex = 13;
            this.grpNroOptions.TabStop = false;
            this.grpNroOptions.Text = "Homebrew Apps";
            // 
            // lbl_hbmButton
            // 
            this.lbl_hbmButton.AutoSize = true;
            this.lbl_hbmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hbmButton.Location = new System.Drawing.Point(137, 58);
            this.lbl_hbmButton.Name = "lbl_hbmButton";
            this.lbl_hbmButton.Size = new System.Drawing.Size(106, 12);
            this.lbl_hbmButton.TabIndex = 12;
            this.lbl_hbmButton.Text = "Homebrew Menu Button";
            // 
            // LaunchpadNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 253);
            this.Controls.Add(this.grpNroOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Name = "LaunchpadNX";
            this.Text = "LaunchpadNX";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNroOptions.ResumeLayout(false);
            this.grpNroOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox atmsCheckbox;
        private System.Windows.Forms.CheckBox lfsCheckbox;
        private System.Windows.Forms.CheckBox hbmenuCheckbox;
        private System.Windows.Forms.ComboBox hbmenuTitleSelect;
        private System.Windows.Forms.CheckBox sigpatchesCheckbox;
        private System.Windows.Forms.CheckBox tinfoilCheckbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox checkpointCheckbox;
        private System.Windows.Forms.CheckBox ftpdCheckbox;
        private System.Windows.Forms.CheckBox hbasCheckbox;
        private System.Windows.Forms.CheckBox switchidentCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpNroOptions;
        private System.Windows.Forms.Label lbl_hbmButton;
    }
}

