﻿namespace PhoenixCollaborationApp
{
	partial class TaskManagement
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(751, 545);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 0;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// TaskManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bunifuImageButton1);
			this.Name = "TaskManagement";
			this.Size = new System.Drawing.Size(751, 545);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
	}
}
