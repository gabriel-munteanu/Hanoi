/*
 * Created by SharpDevelop.
 * User: wyrda
 * Date: 4/18/2011
 * Time: 3:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hanoi
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbl_Author = new System.Windows.Forms.Label();
			this.lbl_Author2 = new System.Windows.Forms.Label();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.lbl_Email2 = new System.Windows.Forms.Label();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.pbox_Icon = new System.Windows.Forms.PictureBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.27074F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.72926F));
			this.tableLayoutPanel1.Controls.Add(this.lbl_Author, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Author2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Email, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Email2, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 57);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lbl_Author
			// 
			this.lbl_Author.Location = new System.Drawing.Point(3, 0);
			this.lbl_Author.Name = "lbl_Author";
			this.lbl_Author.Size = new System.Drawing.Size(47, 23);
			this.lbl_Author.TabIndex = 0;
			this.lbl_Author.Text = "Author";
			// 
			// lbl_Author2
			// 
			this.lbl_Author2.Location = new System.Drawing.Point(56, 0);
			this.lbl_Author2.Name = "lbl_Author2";
			this.lbl_Author2.Size = new System.Drawing.Size(182, 23);
			this.lbl_Author2.TabIndex = 1;
			this.lbl_Author2.Text = "Munteanu Gabriel";
			// 
			// lbl_Email
			// 
			this.lbl_Email.Location = new System.Drawing.Point(3, 26);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(47, 23);
			this.lbl_Email.TabIndex = 2;
			this.lbl_Email.Text = "Email";
			// 
			// lbl_Email2
			// 
			this.lbl_Email2.Location = new System.Drawing.Point(56, 26);
			this.lbl_Email2.Name = "lbl_Email2";
			this.lbl_Email2.Size = new System.Drawing.Size(182, 23);
			this.lbl_Email2.TabIndex = 3;
			this.lbl_Email2.Text = "wyrdaprogramming@gmail.com";
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(92, 9);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(140, 35);
			this.lbl_Title.TabIndex = 1;
			this.lbl_Title.Text = "Hanoi solutions";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbox_Icon
			// 
			this.pbox_Icon.ErrorImage = null;
			this.pbox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.Image")));
			this.pbox_Icon.InitialImage = null;
			this.pbox_Icon.Location = new System.Drawing.Point(15, 9);
			this.pbox_Icon.Name = "pbox_Icon";
			this.pbox_Icon.Size = new System.Drawing.Size(49, 49);
			this.pbox_Icon.TabIndex = 2;
			this.pbox_Icon.TabStop = false;
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(92, 151);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 23);
			this.btn_Close.TabIndex = 3;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.Btn_CloseClick);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 186);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.pbox_Icon);
			this.Controls.Add(this.lbl_Title);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(276, 211);
			this.MinimumSize = new System.Drawing.Size(276, 211);
			this.Name = "About";
			this.Text = "About";
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.PictureBox pbox_Icon;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lbl_Email2;
		private System.Windows.Forms.Label lbl_Email;
		private System.Windows.Forms.Label lbl_Author2;
		private System.Windows.Forms.Label lbl_Author;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
