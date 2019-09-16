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

		private void trbZoom_Scroll(object sender, EventArgs e)
		{
			Size newSize = new Size((int)(pcbOriginal.Image.Width * trbZoom.Value), (int)(pcbOriginal.Image.Height * trbZoom.Value));
			Bitmap bmp = new Bitmap(pcbOriginal.Image, newSize);
			pcbPreview.Image = bmp;
		}
	}
}
