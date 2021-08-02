
namespace WindowsDiagnostic
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsCheckComponents = new System.Windows.Forms.CheckBox();
            this.settingsDumpDb = new System.Windows.Forms.CheckBox();
            this.eventsListBox = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startupListBox = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gpuInfo = new System.Windows.Forms.Label();
            this.ramInfo = new System.Windows.Forms.Label();
            this.osName = new System.Windows.Forms.Label();
            this.motherboardInfo = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorsFlexBox = new System.Windows.Forms.FlowLayoutPanel();
            this.computerOwnerInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.Value = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 26);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.settingsCheckComponents);
            this.groupBox1.Controls.Add(this.settingsDumpDb);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(800, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnosis controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // settingsCheckComponents
            // 
            this.settingsCheckComponents.AutoSize = true;
            this.settingsCheckComponents.Location = new System.Drawing.Point(283, 31);
            this.settingsCheckComponents.Name = "settingsCheckComponents";
            this.settingsCheckComponents.Size = new System.Drawing.Size(197, 17);
            this.settingsCheckComponents.TabIndex = 3;
            this.settingsCheckComponents.Text = "Check system components for errors";
            this.settingsCheckComponents.UseVisualStyleBackColor = true;
            // 
            // settingsDumpDb
            // 
            this.settingsDumpDb.AutoSize = true;
            this.settingsDumpDb.Checked = true;
            this.settingsDumpDb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsDumpDb.Location = new System.Drawing.Point(115, 30);
            this.settingsDumpDb.Name = "settingsDumpDb";
            this.settingsDumpDb.Size = new System.Drawing.Size(161, 17);
            this.settingsDumpDb.TabIndex = 2;
            this.settingsDumpDb.Text = "Fetch WIN32 database data";
            this.settingsDumpDb.UseVisualStyleBackColor = true;
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventsListBox.HideSelection = false;
            this.eventsListBox.LabelWrap = false;
            this.eventsListBox.Location = new System.Drawing.Point(3, 16);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(774, 309);
            this.eventsListBox.TabIndex = 3;
            this.eventsListBox.UseCompatibleStateImageBehavior = false;
            this.eventsListBox.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.eventsListBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1464, 331);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Events";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.startupListBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 331);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Startup tasks";
            // 
            // startupListBox
            // 
            this.startupListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startupListBox.HideSelection = false;
            this.startupListBox.LabelWrap = false;
            this.startupListBox.Location = new System.Drawing.Point(3, 16);
            this.startupListBox.Name = "startupListBox";
            this.startupListBox.Size = new System.Drawing.Size(774, 309);
            this.startupListBox.TabIndex = 3;
            this.startupListBox.UseCompatibleStateImageBehavior = false;
            this.startupListBox.View = System.Windows.Forms.View.List;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 369);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Startup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.computerOwnerInfo);
            this.tabPage3.Controls.Add(this.gpuInfo);
            this.tabPage3.Controls.Add(this.ramInfo);
            this.tabPage3.Controls.Add(this.osName);
            this.tabPage3.Controls.Add(this.motherboardInfo);
            this.tabPage3.Controls.Add(this.cpuLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Computer info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gpuInfo
            // 
            this.gpuInfo.AutoSize = true;
            this.gpuInfo.Location = new System.Drawing.Point(11, 105);
            this.gpuInfo.Name = "gpuInfo";
            this.gpuInfo.Size = new System.Drawing.Size(104, 13);
            this.gpuInfo.TabIndex = 4;
            this.gpuInfo.Text = "GRAPHICS CARD - ";
            // 
            // ramInfo
            // 
            this.ramInfo.AutoSize = true;
            this.ramInfo.Location = new System.Drawing.Point(11, 83);
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.Size = new System.Drawing.Size(40, 13);
            this.ramInfo.TabIndex = 3;
            this.ramInfo.Text = "RAM - ";
            // 
            // osName
            // 
            this.osName.AutoSize = true;
            this.osName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.osName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.osName.Location = new System.Drawing.Point(9, 3);
            this.osName.Name = "osName";
            this.osName.Size = new System.Drawing.Size(290, 26);
            this.osName.TabIndex = 2;
            this.osName.Text = "Microsoft Windows 10 Home";
            // 
            // motherboardInfo
            // 
            this.motherboardInfo.AutoSize = true;
            this.motherboardInfo.Location = new System.Drawing.Point(11, 61);
            this.motherboardInfo.Name = "motherboardInfo";
            this.motherboardInfo.Size = new System.Drawing.Size(76, 13);
            this.motherboardInfo.TabIndex = 1;
            this.motherboardInfo.Text = "Motherboard - ";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(11, 39);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(38, 13);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "CPU - ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.errorsFlexBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "System component errors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // errorsFlexBox
            // 
            this.errorsFlexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsFlexBox.AutoScroll = true;
            this.errorsFlexBox.Location = new System.Drawing.Point(9, 7);
            this.errorsFlexBox.Name = "errorsFlexBox";
            this.errorsFlexBox.Size = new System.Drawing.Size(775, 330);
            this.errorsFlexBox.TabIndex = 0;
            // 
            // computerOwnerInfo
            // 
            this.computerOwnerInfo.AutoSize = true;
            this.computerOwnerInfo.Location = new System.Drawing.Point(11, 128);
            this.computerOwnerInfo.Name = "computerOwnerInfo";
            this.computerOwnerInfo.Size = new System.Drawing.Size(83, 13);
            this.computerOwnerInfo.TabIndex = 5;
            this.computerOwnerInfo.Text = "ComputerOwner";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 506);
            this.Name = "window";
            this.Text = "WinDiag";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView startupListBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListView eventsListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Label motherboardInfo;
        private System.Windows.Forms.Label osName;
        private System.Windows.Forms.Label ramInfo;
        private System.Windows.Forms.Label gpuInfo;
        private System.Windows.Forms.CheckBox settingsDumpDb;
        private System.Windows.Forms.CheckBox settingsCheckComponents;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel errorsFlexBox;
        private System.Windows.Forms.Label computerOwnerInfo;
    }
}

