namespace Bing_Downloader
{
	partial class formPreview
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
			this.trbZoom = new System.Windows.Forms.TrackBar();
			this.pnlPreview = new System.Windows.Forms.Panel();
			this.pcbPreview = new System.Windows.Forms.PictureBox();
			this.pcbOriginal = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.trbZoom)).BeginInit();
			this.pnlPreview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
			this.SuspendLayout();
			// 
			// trbZoom
			// 
			this.trbZoom.Location = new System.Drawing.Point(13, 13);
			this.trbZoom.Maximum = 5;
			this.trbZoom.Minimum = 1;
			this.trbZoom.Name = "trbZoom";
			this.trbZoom.Size = new System.Drawing.Size(199, 45);
			this.trbZoom.TabIndex = 1;
			this.trbZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trbZoom.Value = 1;
			this.trbZoom.Scroll += new System.EventHandler(this.trbZoom_Scroll);
			// 
			// pnlPreview
			// 
			this.pnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPreview.AutoScroll = true;
			this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPreview.Controls.Add(this.pcbPreview);
			this.pnlPreview.Location = new System.Drawing.Point(12, 64);
			this.pnlPreview.Name = "pnlPreview";
			this.pnlPreview.Size = new System.Drawing.Size(776, 374);
			this.pnlPreview.TabIndex = 2;
			// 
			// pcbPreview
			// 
			this.pcbPreview.Location = new System.Drawing.Point(3, 3);
			this.pcbPreview.Name = "pcbPreview";
			this.pcbPreview.Size = new System.Drawing.Size(218, 134);
			this.pcbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pcbPreview.TabIndex = 1;
			this.pcbPreview.TabStop = false;
			// 
			// pcbOriginal
			// 
			this.pcbOriginal.Location = new System.Drawing.Point(705, 12);
			this.pcbOriginal.Name = "pcbOriginal";
			this.pcbOriginal.Size = new System.Drawing.Size(83, 46);
			this.pcbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbOriginal.TabIndex = 3;
			this.pcbOriginal.TabStop = false;
			this.pcbOriginal.Visible = false;
			// 
			// formPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::Bing_Downloader.Properties.Settings.Default.backcolor;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pcbOriginal);
			this.Controls.Add(this.pnlPreview);
			this.Controls.Add(this.trbZoom);
			this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Bing_Downloader.Properties.Settings.Default, "backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::Bing_Downloader.Properties.Resources.icons8_bing;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formPreview";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "formPreview";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.trbZoom)).EndInit();
			this.pnlPreview.ResumeLayout(false);
			this.pnlPreview.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar trbZoom;
		private System.Windows.Forms.Panel pnlPreview;
		public System.Windows.Forms.PictureBox pcbPreview;
		public System.Windows.Forms.PictureBox pcbOriginal;
	}
}