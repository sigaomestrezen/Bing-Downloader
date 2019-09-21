using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bing_Downloader
{
	public partial class formPreview : Form
	{
		public formPreview()
		{
			InitializeComponent();
		}

		private void formPreview_Load(object sender, EventArgs e)
		{
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			cboZoom.SelectedIndex = 0;
		}

		private void cboZoom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboZoom.SelectedIndex == 0)
			{
				pcbPreview.Width = pnlPreview.ClientSize.Width;
				pcbPreview.Height = pnlPreview.ClientSize.Height;
				pcbPreview.SizeMode = PictureBoxSizeMode.Zoom;
				pnlPreview.AutoScroll = false;
			}
			else
			{
				pcbPreview.SizeMode = PictureBoxSizeMode.AutoSize;
				Size newSize = new Size(pcbOriginal.Image.Width * (cboZoom.SelectedIndex + 1), pcbOriginal.Image.Height * (cboZoom.SelectedIndex + 1));
				Bitmap bmp = new Bitmap(pcbOriginal.Image, newSize);
				pcbPreview.Image = bmp;
				pnlPreview.AutoScroll = true;
			}
		}
	}
}
