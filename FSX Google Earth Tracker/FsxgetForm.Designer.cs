namespace Fsxget
{
	partial class FsxetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FsxetForm));
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.runMicrosoftFlightSimulatorXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runGoogleEarthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.createGoogleEarthKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearUserAircraftPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.timerIPAddressRefresh = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogKMLFile = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconMain.Text = "notifyIcon1";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableTrackerToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.runMicrosoftFlightSimulatorXToolStripMenuItem,
            this.runGoogleEarthToolStripMenuItem,
            this.toolStripMenuItem4,
            this.createGoogleEarthKMLFileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.clearUserAircraftPathToolStripMenuItem,
            this.toolStripMenuItem2,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStrip1";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(237, 210);
            this.contextMenuStripNotifyIcon.Text = "Test";
            // 
            // enableTrackerToolStripMenuItem
            // 
            this.enableTrackerToolStripMenuItem.Checked = true;
            this.enableTrackerToolStripMenuItem.CheckOnClick = true;
            this.enableTrackerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableTrackerToolStripMenuItem.Name = "enableTrackerToolStripMenuItem";
            this.enableTrackerToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.enableTrackerToolStripMenuItem.Text = "&Enable Tracker";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(233, 6);
            // 
            // runMicrosoftFlightSimulatorXToolStripMenuItem
            // 
            this.runMicrosoftFlightSimulatorXToolStripMenuItem.Name = "runMicrosoftFlightSimulatorXToolStripMenuItem";
            this.runMicrosoftFlightSimulatorXToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.runMicrosoftFlightSimulatorXToolStripMenuItem.Text = "Run Microsoft Flight Simulator X";
            this.runMicrosoftFlightSimulatorXToolStripMenuItem.Click += new System.EventHandler(this.runMicrosoftFlightSimulatorXToolStripMenuItem_Click);
            // 
            // runGoogleEarthToolStripMenuItem
            // 
            this.runGoogleEarthToolStripMenuItem.Name = "runGoogleEarthToolStripMenuItem";
            this.runGoogleEarthToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.runGoogleEarthToolStripMenuItem.Text = "Run Google Earth 4";
            this.runGoogleEarthToolStripMenuItem.Click += new System.EventHandler(this.runGoogleEarthToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(233, 6);
            // 
            // createGoogleEarthKMLFileToolStripMenuItem
            // 
            this.createGoogleEarthKMLFileToolStripMenuItem.Name = "createGoogleEarthKMLFileToolStripMenuItem";
            this.createGoogleEarthKMLFileToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.createGoogleEarthKMLFileToolStripMenuItem.Text = "Create Google Earth KML File";
            this.createGoogleEarthKMLFileToolStripMenuItem.Click += new System.EventHandler(this.createGoogleEarthKMLFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // clearUserAircraftPathToolStripMenuItem
            // 
            this.clearUserAircraftPathToolStripMenuItem.Name = "clearUserAircraftPathToolStripMenuItem";
            this.clearUserAircraftPathToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.clearUserAircraftPathToolStripMenuItem.Text = "&Clear User Aircraft Path";
            this.clearUserAircraftPathToolStripMenuItem.Click += new System.EventHandler(this.clearUserAircraftPathToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(375, 466);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(294, 466);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogKMLFile
            // 
            this.saveFileDialogKMLFile.DefaultExt = "kml";
            this.saveFileDialogKMLFile.Filter = "Google Earth Files|*.kml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 501);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FSX Google Earth Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.NotifyIcon notifyIconMain;
		private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Timer timerIPAddressRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem enableTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runMicrosoftFlightSimulatorXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runGoogleEarthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem createGoogleEarthKMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clearUserAircraftPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKMLFile;
	}
}
