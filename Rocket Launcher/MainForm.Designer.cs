namespace Rocket_Launcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.HorizontalCheckBox = new System.Windows.Forms.CheckBox();
            this.VerticalCheckBox = new System.Windows.Forms.CheckBox();
            this.SplitLabel = new System.Windows.Forms.Label();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.VersionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SplitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BorderlessCheckBox = new System.Windows.Forms.CheckBox();
            this.WindowedCheckBox = new System.Windows.Forms.CheckBox();
            this.FullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveResCheckBox = new System.Windows.Forms.CheckBox();
            this.HeaderPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ForceMSAACheckBox = new System.Windows.Forms.CheckBox();
            this.UnlockFPSCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(192, 43);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(192, 68);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "Y";
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(212, 39);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(61, 20);
            this.XtextBox.TabIndex = 2;
            // 
            // YtextBox
            // 
            this.YtextBox.Location = new System.Drawing.Point(212, 64);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(61, 20);
            this.YtextBox.TabIndex = 3;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.Location = new System.Drawing.Point(116, 323);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(204, 44);
            this.LaunchButton.TabIndex = 4;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // HorizontalCheckBox
            // 
            this.HorizontalCheckBox.AutoSize = true;
            this.HorizontalCheckBox.Location = new System.Drawing.Point(51, 64);
            this.HorizontalCheckBox.Name = "HorizontalCheckBox";
            this.HorizontalCheckBox.Size = new System.Drawing.Size(73, 17);
            this.HorizontalCheckBox.TabIndex = 5;
            this.HorizontalCheckBox.Text = "Horizontal";
            this.SplitToolTip.SetToolTip(this.HorizontalCheckBox, "--  double Y for horizontally split screen for vertical monitor set ups.");
            this.HorizontalCheckBox.UseVisualStyleBackColor = true;
            this.HorizontalCheckBox.CheckedChanged += new System.EventHandler(this.HorizontalCheckBox_CheckedChanged);
            // 
            // VerticalCheckBox
            // 
            this.VerticalCheckBox.AutoSize = true;
            this.VerticalCheckBox.Location = new System.Drawing.Point(51, 41);
            this.VerticalCheckBox.Name = "VerticalCheckBox";
            this.VerticalCheckBox.Size = new System.Drawing.Size(61, 17);
            this.VerticalCheckBox.TabIndex = 6;
            this.VerticalCheckBox.Text = "Vertical";
            this.SplitToolTip.SetToolTip(this.VerticalCheckBox, "|  double X for vertically split screen for horizontal monitor set ups.");
            this.VerticalCheckBox.UseVisualStyleBackColor = true;
            this.VerticalCheckBox.CheckedChanged += new System.EventHandler(this.VerticalCheckBox_CheckedChanged);
            // 
            // SplitLabel
            // 
            this.SplitLabel.AutoSize = true;
            this.SplitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitLabel.Location = new System.Drawing.Point(69, 13);
            this.SplitLabel.Name = "SplitLabel";
            this.SplitLabel.Size = new System.Drawing.Size(35, 17);
            this.SplitLabel.TabIndex = 7;
            this.SplitLabel.Text = "Split";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionLabel.Location = new System.Drawing.Point(252, 13);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(75, 17);
            this.ResolutionLabel.TabIndex = 8;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // VersionLinkLabel
            // 
            this.VersionLinkLabel.AutoSize = true;
            this.VersionLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLinkLabel.ForeColor = System.Drawing.Color.Black;
            this.VersionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.VersionLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.VersionLinkLabel.Location = new System.Drawing.Point(5, 4);
            this.VersionLinkLabel.Name = "VersionLinkLabel";
            this.VersionLinkLabel.Size = new System.Drawing.Size(37, 14);
            this.VersionLinkLabel.TabIndex = 9;
            this.VersionLinkLabel.TabStop = true;
            this.VersionLinkLabel.Text = "v#.#.#";
            this.SplitToolTip.SetToolTip(this.VersionLinkLabel, "GitHub");
            this.VersionLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.VersionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VersionLinkLabel_LinkClicked);
            // 
            // BorderlessCheckBox
            // 
            this.BorderlessCheckBox.AutoSize = true;
            this.BorderlessCheckBox.Location = new System.Drawing.Point(302, 91);
            this.BorderlessCheckBox.Name = "BorderlessCheckBox";
            this.BorderlessCheckBox.Size = new System.Drawing.Size(75, 17);
            this.BorderlessCheckBox.TabIndex = 10;
            this.BorderlessCheckBox.Text = "Borderless";
            this.SplitToolTip.SetToolTip(this.BorderlessCheckBox, "Enable/Disable borderless windowed mode.");
            this.BorderlessCheckBox.UseVisualStyleBackColor = true;
            this.BorderlessCheckBox.CheckedChanged += new System.EventHandler(this.BorderlessCheckBox_CheckedChanged);
            // 
            // WindowedCheckBox
            // 
            this.WindowedCheckBox.AutoSize = true;
            this.WindowedCheckBox.Location = new System.Drawing.Point(302, 66);
            this.WindowedCheckBox.Name = "WindowedCheckBox";
            this.WindowedCheckBox.Size = new System.Drawing.Size(77, 17);
            this.WindowedCheckBox.TabIndex = 11;
            this.WindowedCheckBox.Text = "Windowed";
            this.SplitToolTip.SetToolTip(this.WindowedCheckBox, "Enable/Disable windowed mode.");
            this.WindowedCheckBox.UseVisualStyleBackColor = true;
            this.WindowedCheckBox.CheckedChanged += new System.EventHandler(this.WindowedCheckBox_CheckedChanged);
            // 
            // FullscreenCheckBox
            // 
            this.FullscreenCheckBox.AutoSize = true;
            this.FullscreenCheckBox.Location = new System.Drawing.Point(302, 41);
            this.FullscreenCheckBox.Name = "FullscreenCheckBox";
            this.FullscreenCheckBox.Size = new System.Drawing.Size(74, 17);
            this.FullscreenCheckBox.TabIndex = 12;
            this.FullscreenCheckBox.Text = "Fullscreen";
            this.SplitToolTip.SetToolTip(this.FullscreenCheckBox, "Enable/Disable fullscreen mode.");
            this.FullscreenCheckBox.UseVisualStyleBackColor = true;
            this.FullscreenCheckBox.CheckedChanged += new System.EventHandler(this.FullscreenCheckBox_CheckedChanged);
            // 
            // SaveResCheckBox
            // 
            this.SaveResCheckBox.AutoSize = true;
            this.SaveResCheckBox.Location = new System.Drawing.Point(192, 92);
            this.SaveResCheckBox.Name = "SaveResCheckBox";
            this.SaveResCheckBox.Size = new System.Drawing.Size(104, 17);
            this.SaveResCheckBox.TabIndex = 13;
            this.SaveResCheckBox.Text = "Save Resolution";
            this.SplitToolTip.SetToolTip(this.SaveResCheckBox, "Optional - Save custom resolution for the next time you open RocketLauncher. Use " +
        "if Horizontal or Vertical do not work automatically.");
            this.SaveResCheckBox.UseVisualStyleBackColor = true;
            this.SaveResCheckBox.CheckedChanged += new System.EventHandler(this.SaveResCheckBox_CheckedChanged);
            // 
            // HeaderPictureBox
            // 
            this.HeaderPictureBox.BackgroundImage = global::RocketLauncher.Properties.Resources.header;
            this.HeaderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeaderPictureBox.Location = new System.Drawing.Point(5, 4);
            this.HeaderPictureBox.Name = "HeaderPictureBox";
            this.HeaderPictureBox.Size = new System.Drawing.Size(426, 134);
            this.HeaderPictureBox.TabIndex = 14;
            this.HeaderPictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(423, 159);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.SplitLabel);
            this.tabPage1.Controls.Add(this.HorizontalCheckBox);
            this.tabPage1.Controls.Add(this.SaveResCheckBox);
            this.tabPage1.Controls.Add(this.VerticalCheckBox);
            this.tabPage1.Controls.Add(this.FullscreenCheckBox);
            this.tabPage1.Controls.Add(this.BorderlessCheckBox);
            this.tabPage1.Controls.Add(this.WindowedCheckBox);
            this.tabPage1.Controls.Add(this.XLabel);
            this.tabPage1.Controls.Add(this.YLabel);
            this.tabPage1.Controls.Add(this.ResolutionLabel);
            this.tabPage1.Controls.Add(this.XtextBox);
            this.tabPage1.Controls.Add(this.YtextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ForceMSAACheckBox);
            this.tabPage2.Controls.Add(this.UnlockFPSCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // ForceMSAACheckBox
            // 
            this.ForceMSAACheckBox.AutoSize = true;
            this.ForceMSAACheckBox.Location = new System.Drawing.Point(249, 57);
            this.ForceMSAACheckBox.Name = "ForceMSAACheckBox";
            this.ForceMSAACheckBox.Size = new System.Drawing.Size(86, 17);
            this.ForceMSAACheckBox.TabIndex = 1;
            this.ForceMSAACheckBox.Text = "Force MSAA";
            this.SplitToolTip.SetToolTip(this.ForceMSAACheckBox, "Enable better antialiasing. Powerful PC required!");
            this.ForceMSAACheckBox.UseVisualStyleBackColor = true;
            this.ForceMSAACheckBox.CheckedChanged += new System.EventHandler(this.ForceMSAACheckBox_CheckedChanged);
            // 
            // UnlockFPSCheckBox
            // 
            this.UnlockFPSCheckBox.AutoSize = true;
            this.UnlockFPSCheckBox.Location = new System.Drawing.Point(79, 57);
            this.UnlockFPSCheckBox.Name = "UnlockFPSCheckBox";
            this.UnlockFPSCheckBox.Size = new System.Drawing.Size(83, 17);
            this.UnlockFPSCheckBox.TabIndex = 0;
            this.UnlockFPSCheckBox.Text = "Unlock FPS";
            this.SplitToolTip.SetToolTip(this.UnlockFPSCheckBox, "Uncap Rocket League\'s frame rate.");
            this.UnlockFPSCheckBox.UseVisualStyleBackColor = true;
            this.UnlockFPSCheckBox.CheckedChanged += new System.EventHandler(this.UnlockFPSCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(443, 379);
            this.Controls.Add(this.VersionLinkLabel);
            this.Controls.Add(this.HeaderPictureBox);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RocketLauncher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.CheckBox HorizontalCheckBox;
        private System.Windows.Forms.CheckBox VerticalCheckBox;
        private System.Windows.Forms.Label SplitLabel;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.LinkLabel VersionLinkLabel;
        private System.Windows.Forms.ToolTip SplitToolTip;
        private System.Windows.Forms.CheckBox BorderlessCheckBox;
        private System.Windows.Forms.CheckBox WindowedCheckBox;
        private System.Windows.Forms.CheckBox FullscreenCheckBox;
        private System.Windows.Forms.CheckBox SaveResCheckBox;
        private System.Windows.Forms.PictureBox HeaderPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ForceMSAACheckBox;
        private System.Windows.Forms.CheckBox UnlockFPSCheckBox;
    }
}

