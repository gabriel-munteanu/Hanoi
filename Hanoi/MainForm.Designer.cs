/*
 * Created by SharpDevelop.
 * User: wyrda
 * Date: 4/16/2011
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hanoi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.cbobox_DiskNr = new System.Windows.Forms.ComboBox();
			this.lbl_DiskNr = new System.Windows.Forms.Label();
			this.btn_StartStop = new System.Windows.Forms.Button();
			this.btn_PauseResume = new System.Windows.Forms.Button();
			this.cbox_AutoPlay = new System.Windows.Forms.CheckBox();
			this.panel_Draw = new System.Windows.Forms.Panel();
			this.txt_PlaySpeed = new System.Windows.Forms.TextBox();
			this.lbl_PlaySpeed = new System.Windows.Forms.Label();
			this.btn_Forward = new System.Windows.Forms.Button();
			this.btn_Back = new System.Windows.Forms.Button();
			this.panel_ManualControl = new System.Windows.Forms.Panel();
			this.lbl_StepByStep = new System.Windows.Forms.Label();
			this.tmr_Play = new System.Windows.Forms.Timer(this.components);
			this.menustrip_MainMenu = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_ManualControl.SuspendLayout();
			this.menustrip_MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbobox_DiskNr
			// 
			this.cbobox_DiskNr.FormattingEnabled = true;
			this.cbobox_DiskNr.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10"});
			this.cbobox_DiskNr.Location = new System.Drawing.Point(38, 49);
			this.cbobox_DiskNr.MaxDropDownItems = 10;
			this.cbobox_DiskNr.Name = "cbobox_DiskNr";
			this.cbobox_DiskNr.Size = new System.Drawing.Size(35, 21);
			this.cbobox_DiskNr.TabIndex = 0;
			this.cbobox_DiskNr.Text = "1";
			this.cbobox_DiskNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbobox_DiskNrKeyPress);
			this.cbobox_DiskNr.TextUpdate += new System.EventHandler(this.Cbobox_DiskNrTextUpdate);
			// 
			// lbl_DiskNr
			// 
			this.lbl_DiskNr.Location = new System.Drawing.Point(24, 28);
			this.lbl_DiskNr.Name = "lbl_DiskNr";
			this.lbl_DiskNr.Size = new System.Drawing.Size(75, 18);
			this.lbl_DiskNr.TabIndex = 1;
			this.lbl_DiskNr.Text = "No. of disks";
			this.lbl_DiskNr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn_StartStop
			// 
			this.btn_StartStop.Location = new System.Drawing.Point(24, 83);
			this.btn_StartStop.Name = "btn_StartStop";
			this.btn_StartStop.Size = new System.Drawing.Size(75, 21);
			this.btn_StartStop.TabIndex = 2;
			this.btn_StartStop.Text = "Start";
			this.btn_StartStop.UseVisualStyleBackColor = true;
			this.btn_StartStop.Click += new System.EventHandler(this.Btn_StartStopClick);
			// 
			// btn_PauseResume
			// 
			this.btn_PauseResume.Enabled = false;
			this.btn_PauseResume.Location = new System.Drawing.Point(24, 203);
			this.btn_PauseResume.Name = "btn_PauseResume";
			this.btn_PauseResume.Size = new System.Drawing.Size(75, 23);
			this.btn_PauseResume.TabIndex = 3;
			this.btn_PauseResume.Text = "Pause";
			this.btn_PauseResume.UseVisualStyleBackColor = true;
			this.btn_PauseResume.Click += new System.EventHandler(this.Btn_PauseResumeClick);
			// 
			// cbox_AutoPlay
			// 
			this.cbox_AutoPlay.Location = new System.Drawing.Point(24, 115);
			this.cbox_AutoPlay.Name = "cbox_AutoPlay";
			this.cbox_AutoPlay.Size = new System.Drawing.Size(75, 24);
			this.cbox_AutoPlay.TabIndex = 4;
			this.cbox_AutoPlay.Text = "Auto play";
			this.cbox_AutoPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cbox_AutoPlay.UseVisualStyleBackColor = true;
			this.cbox_AutoPlay.CheckedChanged += new System.EventHandler(this.Cbox_AutoPlayCheckedChanged);
			// 
			// panel_Draw
			// 
			this.panel_Draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Draw.Location = new System.Drawing.Point(143, 35);
			this.panel_Draw.Name = "panel_Draw";
			this.panel_Draw.Size = new System.Drawing.Size(380, 275);
			this.panel_Draw.TabIndex = 5;
			// 
			// txt_PlaySpeed
			// 
			this.txt_PlaySpeed.Enabled = false;
			this.txt_PlaySpeed.Location = new System.Drawing.Point(38, 167);
			this.txt_PlaySpeed.MaxLength = 5;
			this.txt_PlaySpeed.Name = "txt_PlaySpeed";
			this.txt_PlaySpeed.Size = new System.Drawing.Size(52, 20);
			this.txt_PlaySpeed.TabIndex = 6;
			this.txt_PlaySpeed.Text = "1.000";
			this.txt_PlaySpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PlaySpeedKeyPress);
			// 
			// lbl_PlaySpeed
			// 
			this.lbl_PlaySpeed.Location = new System.Drawing.Point(2, 142);
			this.lbl_PlaySpeed.Name = "lbl_PlaySpeed";
			this.lbl_PlaySpeed.Size = new System.Drawing.Size(135, 22);
			this.lbl_PlaySpeed.TabIndex = 7;
			this.lbl_PlaySpeed.Text = "Auto play speed(seconds)";
			// 
			// btn_Forward
			// 
			this.btn_Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Forward.Location = new System.Drawing.Point(69, 32);
			this.btn_Forward.Name = "btn_Forward";
			this.btn_Forward.Size = new System.Drawing.Size(38, 30);
			this.btn_Forward.TabIndex = 8;
			this.btn_Forward.Text = ">";
			this.btn_Forward.UseVisualStyleBackColor = true;
			this.btn_Forward.Click += new System.EventHandler(this.Btn_ForwardClick);
			// 
			// btn_Back
			// 
			this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Back.Location = new System.Drawing.Point(21, 32);
			this.btn_Back.Name = "btn_Back";
			this.btn_Back.Size = new System.Drawing.Size(38, 30);
			this.btn_Back.TabIndex = 9;
			this.btn_Back.Text = "<";
			this.btn_Back.UseVisualStyleBackColor = true;
			this.btn_Back.Click += new System.EventHandler(this.Btn_BackClick);
			// 
			// panel_ManualControl
			// 
			this.panel_ManualControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_ManualControl.Controls.Add(this.lbl_StepByStep);
			this.panel_ManualControl.Controls.Add(this.btn_Back);
			this.panel_ManualControl.Controls.Add(this.btn_Forward);
			this.panel_ManualControl.Enabled = false;
			this.panel_ManualControl.Location = new System.Drawing.Point(2, 243);
			this.panel_ManualControl.Name = "panel_ManualControl";
			this.panel_ManualControl.Size = new System.Drawing.Size(135, 67);
			this.panel_ManualControl.TabIndex = 8;
			// 
			// lbl_StepByStep
			// 
			this.lbl_StepByStep.Location = new System.Drawing.Point(3, 6);
			this.lbl_StepByStep.Name = "lbl_StepByStep";
			this.lbl_StepByStep.Size = new System.Drawing.Size(127, 23);
			this.lbl_StepByStep.TabIndex = 10;
			this.lbl_StepByStep.Text = "Step by step control";
			this.lbl_StepByStep.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tmr_Play
			// 
			this.tmr_Play.Interval = 1000;
			this.tmr_Play.Tick += new System.EventHandler(this.Tmr_PlayTick);
			// 
			// menustrip_MainMenu
			// 
			this.menustrip_MainMenu.BackColor = System.Drawing.SystemColors.Control;
			this.menustrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem});
			this.menustrip_MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menustrip_MainMenu.Location = new System.Drawing.Point(0, 0);
			this.menustrip_MainMenu.Name = "menustrip_MainMenu";
			this.menustrip_MainMenu.Size = new System.Drawing.Size(525, 24);
			this.menustrip_MainMenu.TabIndex = 10;
			this.menustrip_MainMenu.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.aboutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 318);
			this.Controls.Add(this.menustrip_MainMenu);
			this.Controls.Add(this.btn_PauseResume);
			this.Controls.Add(this.lbl_PlaySpeed);
			this.Controls.Add(this.cbox_AutoPlay);
			this.Controls.Add(this.panel_ManualControl);
			this.Controls.Add(this.txt_PlaySpeed);
			this.Controls.Add(this.panel_Draw);
			this.Controls.Add(this.btn_StartStop);
			this.Controls.Add(this.lbl_DiskNr);
			this.Controls.Add(this.cbobox_DiskNr);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menustrip_MainMenu;
			this.MaximumSize = new System.Drawing.Size(531, 343);
			this.MinimumSize = new System.Drawing.Size(531, 343);
			this.Name = "MainForm";
			this.Text = "Hanoi solutions";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.panel_ManualControl.ResumeLayout(false);
			this.menustrip_MainMenu.ResumeLayout(false);
			this.menustrip_MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menustrip_MainMenu;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Timer tmr_Play;
		private System.Windows.Forms.Panel panel_ManualControl;
		private System.Windows.Forms.Label lbl_StepByStep;
		private System.Windows.Forms.Button btn_Back;
		private System.Windows.Forms.Button btn_Forward;
		private System.Windows.Forms.Label lbl_PlaySpeed;
		private System.Windows.Forms.TextBox txt_PlaySpeed;
		private System.Windows.Forms.ComboBox cbobox_DiskNr;
		private System.Windows.Forms.Label lbl_DiskNr;
		private System.Windows.Forms.Panel panel_Draw;
		private System.Windows.Forms.CheckBox cbox_AutoPlay;
		private System.Windows.Forms.Button btn_PauseResume;
		private System.Windows.Forms.Button btn_StartStop;
	}
}
