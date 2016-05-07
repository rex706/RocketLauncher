namespace Rocket_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(108, 136);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(61, 20);
            this.XtextBox.TabIndex = 2;
            // 
            // YtextBox
            // 
            this.YtextBox.Location = new System.Drawing.Point(108, 164);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(61, 20);
            this.YtextBox.TabIndex = 3;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(27, 200);
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
            this.HorizontalCheckBox.Location = new System.Drawing.Point(94, 34);
            this.HorizontalCheckBox.Name = "HorizontalCheckBox";
            this.HorizontalCheckBox.Size = new System.Drawing.Size(73, 17);
            this.HorizontalCheckBox.TabIndex = 5;
            this.HorizontalCheckBox.Text = "Horizontal";
            this.SplitToolTip.SetToolTip(this.HorizontalCheckBox, "Horizontal split screen for vertical monitor set ups.");
            this.HorizontalCheckBox.UseVisualStyleBackColor = true;
            this.HorizontalCheckBox.CheckedChanged += new System.EventHandler(this.HorizontalCheckBox_CheckedChanged);
            // 
            // VerticalCheckBox
            // 
            this.VerticalCheckBox.AutoSize = true;
            this.VerticalCheckBox.Location = new System.Drawing.Point(94, 58);
            this.VerticalCheckBox.Name = "VerticalCheckBox";
            this.VerticalCheckBox.Size = new System.Drawing.Size(61, 17);
            this.VerticalCheckBox.TabIndex = 6;
            this.VerticalCheckBox.Text = "Vertical";
            this.SplitToolTip.SetToolTip(this.VerticalCheckBox, "Vertical split screen for horizontal monitor set ups.");
            this.VerticalCheckBox.UseVisualStyleBackColor = true;
            this.VerticalCheckBox.CheckedChanged += new System.EventHandler(this.VerticalCheckBox_CheckedChanged);
            // 
            // SplitLabel
            // 
            this.SplitLabel.AutoSize = true;
            this.SplitLabel.Location = new System.Drawing.Point(101, 10);
            this.SplitLabel.Name = "SplitLabel";
            this.SplitLabel.Size = new System.Drawing.Size(45, 13);
            this.SplitLabel.TabIndex = 7;
            this.SplitLabel.Text = "---Split---";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(92, 88);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(75, 13);
            this.ResolutionLabel.TabIndex = 8;
            this.ResolutionLabel.Text = "---Resolution---";
            // 
            // VersionLinkLabel
            // 
            this.VersionLinkLabel.AutoSize = true;
            this.VersionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.VersionLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.VersionLinkLabel.Location = new System.Drawing.Point(13, 13);
            this.VersionLinkLabel.Name = "VersionLinkLabel";
            this.VersionLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.VersionLinkLabel.TabIndex = 9;
            this.VersionLinkLabel.TabStop = true;
            this.VersionLinkLabel.Text = "v1.2";
            this.VersionLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.VersionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VersionLinkLabel_LinkClicked);
            // 
            // BorderlessCheckBox
            // 
            this.BorderlessCheckBox.AutoSize = true;
            this.BorderlessCheckBox.Checked = true;
            this.BorderlessCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BorderlessCheckBox.Location = new System.Drawing.Point(94, 111);
            this.BorderlessCheckBox.Name = "BorderlessCheckBox";
            this.BorderlessCheckBox.Size = new System.Drawing.Size(75, 17);
            this.BorderlessCheckBox.TabIndex = 10;
            this.BorderlessCheckBox.Text = "Borderless";
            this.SplitToolTip.SetToolTip(this.BorderlessCheckBox, "Enable/Disable borderless windowed mode.");
            this.BorderlessCheckBox.UseVisualStyleBackColor = true;
            this.BorderlessCheckBox.CheckedChanged += new System.EventHandler(this.BorderlessCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(257, 257);
            this.Controls.Add(this.BorderlessCheckBox);
            this.Controls.Add(this.VersionLinkLabel);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.SplitLabel);
            this.Controls.Add(this.VerticalCheckBox);
            this.Controls.Add(this.HorizontalCheckBox);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RocketLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
    }
}

