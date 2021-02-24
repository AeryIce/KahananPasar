namespace KahananPasar
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
			this.pnWindows = new System.Windows.Forms.Panel();
			this.btMinimize = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pnWindows
			// 
			this.pnWindows.BackColor = System.Drawing.Color.DodgerBlue;
			this.pnWindows.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnWindows.Location = new System.Drawing.Point(0, 0);
			this.pnWindows.Name = "pnWindows";
			this.pnWindows.Size = new System.Drawing.Size(800, 29);
			this.pnWindows.TabIndex = 0;
			// 
			// btMinimize
			// 
			this.btMinimize.Location = new System.Drawing.Point(558, 113);
			this.btMinimize.Name = "btMinimize";
			this.btMinimize.Size = new System.Drawing.Size(45, 31);
			this.btMinimize.TabIndex = 1;
			this.btMinimize.Text = "btMinimize";
			this.btMinimize.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btMinimize);
			this.Controls.Add(this.pnWindows);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnWindows;
		private System.Windows.Forms.Button btMinimize;
	}
}

