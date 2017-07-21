﻿/*
 * Created by SharpDevelop.
 * User: Brennced
 * Date: 09.07.2017
 * Time: 18:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CapsLockIndicatorV3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer updateTimer;
		private System.Windows.Forms.NotifyIcon numLockIcon;
		private System.Windows.Forms.NotifyIcon capsLockIcon;
		private System.Windows.Forms.NotifyIcon scrollLockIcon;
		private System.Windows.Forms.GroupBox iconsGroup;
		private System.Windows.Forms.CheckBox enableScrollIcon;
		private System.Windows.Forms.CheckBox enableCapsIcon;
		private System.Windows.Forms.CheckBox enableNumIcon;
		private System.Windows.Forms.GroupBox indicatorGroup;
		private System.Windows.Forms.CheckBox enableScrollInd;
		private System.Windows.Forms.CheckBox enableCapsInd;
		private System.Windows.Forms.CheckBox enableNumInd;
		private System.Windows.Forms.CheckBox showNoIcons;
		private System.Windows.Forms.CheckBox showNoNotification;
		private System.Windows.Forms.Panel aboutPanel;
		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.Label aboutText;
		private System.Windows.Forms.Label appNameLabel;
		private System.Windows.Forms.PictureBox aboutPanelTopBorder;
		private System.Windows.Forms.Button hideWindow;
		private System.Windows.Forms.Button exitApplication;
		private System.Windows.Forms.NotifyIcon generalIcon;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.numLockIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.capsLockIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.scrollLockIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconsGroup = new System.Windows.Forms.GroupBox();
            this.enableScrollIcon = new System.Windows.Forms.CheckBox();
            this.enableCapsIcon = new System.Windows.Forms.CheckBox();
            this.enableNumIcon = new System.Windows.Forms.CheckBox();
            this.indicatorGroup = new System.Windows.Forms.GroupBox();
            this.enableScrollInd = new System.Windows.Forms.CheckBox();
            this.enableCapsInd = new System.Windows.Forms.CheckBox();
            this.enableNumInd = new System.Windows.Forms.CheckBox();
            this.showNoIcons = new System.Windows.Forms.CheckBox();
            this.showNoNotification = new System.Windows.Forms.CheckBox();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutPanelTopBorder = new System.Windows.Forms.PictureBox();
            this.aboutText = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.hideWindow = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.generalIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.indSettings = new System.Windows.Forms.Button();
            this.checkForUpdatesButton = new System.Windows.Forms.Button();
            this.iconsGroup.SuspendLayout();
            this.indicatorGroup.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPanelTopBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 16;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimerTick);
            // 
            // numLockIcon
            // 
            this.numLockIcon.Text = "Num Lock";
            this.numLockIcon.Visible = true;
            // 
            // capsLockIcon
            // 
            this.capsLockIcon.Text = "Caps Lock";
            this.capsLockIcon.Visible = true;
            // 
            // scrollLockIcon
            // 
            this.scrollLockIcon.Text = "Scroll Lock";
            this.scrollLockIcon.Visible = true;
            // 
            // iconsGroup
            // 
            this.iconsGroup.Controls.Add(this.enableScrollIcon);
            this.iconsGroup.Controls.Add(this.enableCapsIcon);
            this.iconsGroup.Controls.Add(this.enableNumIcon);
            this.iconsGroup.Location = new System.Drawing.Point(12, 12);
            this.iconsGroup.Name = "iconsGroup";
            this.iconsGroup.Size = new System.Drawing.Size(113, 100);
            this.iconsGroup.TabIndex = 0;
            this.iconsGroup.TabStop = false;
            this.iconsGroup.Text = "Show icons for...";
            // 
            // enableScrollIcon
            // 
            this.enableScrollIcon.AutoSize = true;
            this.enableScrollIcon.Checked = true;
            this.enableScrollIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableScrollIcon.Location = new System.Drawing.Point(6, 72);
            this.enableScrollIcon.Name = "enableScrollIcon";
            this.enableScrollIcon.Size = new System.Drawing.Size(80, 19);
            this.enableScrollIcon.TabIndex = 2;
            this.enableScrollIcon.Text = "Scroll lock";
            this.enableScrollIcon.UseVisualStyleBackColor = true;
            this.enableScrollIcon.CheckedChanged += new System.EventHandler(this.enableScrollIcon_CheckedChanged);
            // 
            // enableCapsIcon
            // 
            this.enableCapsIcon.AutoSize = true;
            this.enableCapsIcon.Checked = true;
            this.enableCapsIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCapsIcon.Location = new System.Drawing.Point(6, 47);
            this.enableCapsIcon.Name = "enableCapsIcon";
            this.enableCapsIcon.Size = new System.Drawing.Size(77, 19);
            this.enableCapsIcon.TabIndex = 1;
            this.enableCapsIcon.Text = "Caps lock";
            this.enableCapsIcon.UseVisualStyleBackColor = true;
            this.enableCapsIcon.CheckedChanged += new System.EventHandler(this.enableCapsIcon_CheckedChanged);
            // 
            // enableNumIcon
            // 
            this.enableNumIcon.AutoSize = true;
            this.enableNumIcon.Checked = true;
            this.enableNumIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableNumIcon.Location = new System.Drawing.Point(6, 22);
            this.enableNumIcon.Name = "enableNumIcon";
            this.enableNumIcon.Size = new System.Drawing.Size(78, 19);
            this.enableNumIcon.TabIndex = 0;
            this.enableNumIcon.Text = "Num lock";
            this.enableNumIcon.UseVisualStyleBackColor = true;
            this.enableNumIcon.CheckedChanged += new System.EventHandler(this.enableNumIcon_CheckedChanged);
            // 
            // indicatorGroup
            // 
            this.indicatorGroup.Controls.Add(this.enableScrollInd);
            this.indicatorGroup.Controls.Add(this.enableCapsInd);
            this.indicatorGroup.Controls.Add(this.enableNumInd);
            this.indicatorGroup.Location = new System.Drawing.Point(131, 12);
            this.indicatorGroup.Name = "indicatorGroup";
            this.indicatorGroup.Size = new System.Drawing.Size(163, 100);
            this.indicatorGroup.TabIndex = 1;
            this.indicatorGroup.TabStop = false;
            this.indicatorGroup.Text = "Show notification when...";
            // 
            // enableScrollInd
            // 
            this.enableScrollInd.AutoSize = true;
            this.enableScrollInd.Checked = true;
            this.enableScrollInd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableScrollInd.Location = new System.Drawing.Point(6, 72);
            this.enableScrollInd.Name = "enableScrollInd";
            this.enableScrollInd.Size = new System.Drawing.Size(126, 19);
            this.enableScrollInd.TabIndex = 2;
            this.enableScrollInd.Text = "Scrolllock changed";
            this.enableScrollInd.UseVisualStyleBackColor = true;
            this.enableScrollInd.CheckedChanged += new System.EventHandler(this.enableScrollInd_CheckedChanged);
            // 
            // enableCapsInd
            // 
            this.enableCapsInd.AutoSize = true;
            this.enableCapsInd.Checked = true;
            this.enableCapsInd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCapsInd.Location = new System.Drawing.Point(6, 47);
            this.enableCapsInd.Name = "enableCapsInd";
            this.enableCapsInd.Size = new System.Drawing.Size(123, 19);
            this.enableCapsInd.TabIndex = 1;
            this.enableCapsInd.Text = "Capslock changed";
            this.enableCapsInd.UseVisualStyleBackColor = true;
            this.enableCapsInd.CheckedChanged += new System.EventHandler(this.enableCapsInd_CheckedChanged);
            // 
            // enableNumInd
            // 
            this.enableNumInd.AutoSize = true;
            this.enableNumInd.Checked = true;
            this.enableNumInd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableNumInd.Location = new System.Drawing.Point(6, 22);
            this.enableNumInd.Name = "enableNumInd";
            this.enableNumInd.Size = new System.Drawing.Size(124, 19);
            this.enableNumInd.TabIndex = 0;
            this.enableNumInd.Text = "Numlock changed";
            this.enableNumInd.UseVisualStyleBackColor = true;
            this.enableNumInd.CheckedChanged += new System.EventHandler(this.enableNumInd_CheckedChanged);
            // 
            // showNoIcons
            // 
            this.showNoIcons.AutoSize = true;
            this.showNoIcons.Location = new System.Drawing.Point(18, 118);
            this.showNoIcons.Name = "showNoIcons";
            this.showNoIcons.Size = new System.Drawing.Size(103, 19);
            this.showNoIcons.TabIndex = 2;
            this.showNoIcons.Text = "Show no icons";
            this.showNoIcons.UseVisualStyleBackColor = true;
            this.showNoIcons.CheckedChanged += new System.EventHandler(this.ShowNoIconsCheckedChanged);
            // 
            // showNoNotification
            // 
            this.showNoNotification.AutoSize = true;
            this.showNoNotification.Location = new System.Drawing.Point(137, 118);
            this.showNoNotification.Name = "showNoNotification";
            this.showNoNotification.Size = new System.Drawing.Size(136, 19);
            this.showNoNotification.TabIndex = 3;
            this.showNoNotification.Text = "Show no notification";
            this.showNoNotification.UseVisualStyleBackColor = true;
            this.showNoNotification.CheckedChanged += new System.EventHandler(this.ShowNoNotificationCheckedChanged);
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutPanelTopBorder);
            this.aboutPanel.Controls.Add(this.aboutText);
            this.aboutPanel.Controls.Add(this.appNameLabel);
            this.aboutPanel.Controls.Add(this.logo);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutPanel.Location = new System.Drawing.Point(0, 239);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(306, 66);
            this.aboutPanel.TabIndex = 4;
            // 
            // aboutPanelTopBorder
            // 
            this.aboutPanelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(180)))));
            this.aboutPanelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutPanelTopBorder.Location = new System.Drawing.Point(0, 0);
            this.aboutPanelTopBorder.Name = "aboutPanelTopBorder";
            this.aboutPanelTopBorder.Size = new System.Drawing.Size(306, 2);
            this.aboutPanelTopBorder.TabIndex = 3;
            this.aboutPanelTopBorder.TabStop = false;
            // 
            // aboutText
            // 
            this.aboutText.Location = new System.Drawing.Point(62, 25);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(232, 32);
            this.aboutText.TabIndex = 2;
            this.aboutText.Text = "{{aboutText}}";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.appNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(180)))));
            this.appNameLabel.Location = new System.Drawing.Point(62, 10);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(111, 15);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "CapsLock Indicator";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(8, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(48, 48);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // hideWindow
            // 
            this.hideWindow.AutoSize = true;
            this.hideWindow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideWindow.Location = new System.Drawing.Point(51, 146);
            this.hideWindow.Name = "hideWindow";
            this.hideWindow.Size = new System.Drawing.Size(94, 24);
            this.hideWindow.TabIndex = 5;
            this.hideWindow.Text = "&Hide window";
            this.hideWindow.UseVisualStyleBackColor = true;
            this.hideWindow.Click += new System.EventHandler(this.HideWindowClick);
            // 
            // exitApplication
            // 
            this.exitApplication.AutoSize = true;
            this.exitApplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitApplication.Location = new System.Drawing.Point(152, 146);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(101, 24);
            this.exitApplication.TabIndex = 6;
            this.exitApplication.Text = "&Exit application";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.ExitApplicationClick);
            // 
            // generalIcon
            // 
            this.generalIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.generalIcon.BalloonTipText = "You can show CapsLock Indicator again by double clicking on this icon.";
            this.generalIcon.BalloonTipTitle = "CapsLock Indicator";
            this.generalIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("generalIcon.Icon")));
            this.generalIcon.Text = "CapsLock Indicator";
            this.generalIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GeneralIconMouseDoubleClick);
            // 
            // indSettings
            // 
            this.indSettings.AutoSize = true;
            this.indSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.indSettings.Location = new System.Drawing.Point(51, 176);
            this.indSettings.Name = "indSettings";
            this.indSettings.Size = new System.Drawing.Size(202, 24);
            this.indSettings.TabIndex = 7;
            this.indSettings.Text = "&Notification settings";
            this.indSettings.UseVisualStyleBackColor = true;
            this.indSettings.Click += new System.EventHandler(this.indSettings_Click);
            // 
            // checkForUpdatesButton
            // 
            this.checkForUpdatesButton.AutoSize = true;
            this.checkForUpdatesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkForUpdatesButton.Location = new System.Drawing.Point(51, 206);
            this.checkForUpdatesButton.Name = "checkForUpdatesButton";
            this.checkForUpdatesButton.Size = new System.Drawing.Size(202, 24);
            this.checkForUpdatesButton.TabIndex = 9;
            this.checkForUpdatesButton.Text = "Check for &updates";
            this.checkForUpdatesButton.UseVisualStyleBackColor = true;
            this.checkForUpdatesButton.Click += new System.EventHandler(this.checkForUpdatesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(306, 305);
            this.Controls.Add(this.checkForUpdatesButton);
            this.Controls.Add(this.indSettings);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.hideWindow);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.showNoNotification);
            this.Controls.Add(this.showNoIcons);
            this.Controls.Add(this.indicatorGroup);
            this.Controls.Add(this.iconsGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapsLock Indicator";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.iconsGroup.ResumeLayout(false);
            this.iconsGroup.PerformLayout();
            this.indicatorGroup.ResumeLayout(false);
            this.indicatorGroup.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPanelTopBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button indSettings;
        private System.Windows.Forms.Button checkForUpdatesButton;
    }
}