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
			this.pnlPreview = new System.Windows.Forms.Panel();
			this.pcbPreview = new System.Windows.Forms.PictureBox();
			this.pcbOriginal = new System.Windows.Forms.PictureBox();
			this.cboZoom = new System.Windows.Forms.ComboBox();
			this.lblZoom = new System.Windows.Forms.Label();
			this.pnlPreview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlPreview
			// 
			this.pnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPreview.AutoScroll = true;
			this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPreview.Controls.Add(this.pcbPreview);
			this.pnlPreview.Location = new System.Drawing.Point(12, 39);
			this.pnlPreview.Name = "pnlPreview";
			this.pnlPreview.Size = new System.Drawing.Size(776, 399);
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
			// cboZoom
			// 
			this.cboZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboZoom.FormattingEnabled = true;
			this.cboZoom.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x"});
			this.cboZoom.Location = new System.Drawing.Point(74, 12);
			this.cboZoom.Name = "cboZoom";
			this.cboZoom.Size = new System.Drawing.Size(51, 21);
			this.cboZoom.TabIndex = 4;
			this.cboZoom.SelectedIndexChanged += new System.EventHandler(this.cboZoom_SelectedIndexChanged);
			// 
			// lblZoom
			// 
			this.lblZoom.AutoSize = true;
			this.lblZoom.Location = new System.Drawing.Point(9, 15);
			this.lblZoom.Name = "lblZoom";
			this.lblZoom.Size = new System.Drawing.Size(59, 13);
			this.lblZoom.TabIndex = 5;
			this.lblZoom.Text = "Ampliação:";
			// 
			// formPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::Bing_Downloader.Properties.Settings.Default.backcolor;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblZoom);
			this.Controls.Add(this.cboZoom);
			this.Controls.Add(this.pcbOriginal);
			this.Controls.Add(this.pnlPreview);
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
			this.Load += new System.EventHandler(this.formPreview_Load);
			this.pnlPreview.ResumeLayout(false);
			this.pnlPreview.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbOriginal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel pnlPreview;
		public System.Windows.Forms.PictureBox pcbPreview;
		public System.Windows.Forms.PictureBox pcbOriginal;
		private System.Windows.Forms.ComboBox cboZoom;
		private System.Windows.Forms.Label lblZoom;
	}
}