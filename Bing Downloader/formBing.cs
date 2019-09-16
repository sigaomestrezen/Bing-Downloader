using System;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;

namespace Bing_Downloader
{
	public partial class formBing : Form
	{
		ArrayList vData = new ArrayList();
		ArrayList vNomeArquivo = new ArrayList();
		ArrayList vDesc = new ArrayList();
		string url;
		int idx;

		public formBing()
		{
			InitializeComponent();
		}

		private void carregarImagem1()
		{
			pcbBackground1.Load(dgvImagens.Rows[0].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem2()
		{
			pcbBackground2.Load(dgvImagens.Rows[1].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem3()
		{
			pcbBackground3.Load(dgvImagens.Rows[2].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem4()
		{
			pcbBackground4.Load(dgvImagens.Rows[3].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem5()
		{
			pcbBackground5.Load(dgvImagens.Rows[4].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem6()
		{
			pcbBackground6.Load(dgvImagens.Rows[5].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem7()
		{
			pcbBackground7.Load(dgvImagens.Rows[6].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem8()
		{
			pcbBackground8.Load(dgvImagens.Rows[7].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem9()
		{
			pcbBackground9.Load(dgvImagens.Rows[9].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem10()
		{
			pcbBackground10.Load(dgvImagens.Rows[10].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem11()
		{
			pcbBackground11.Load(dgvImagens.Rows[11].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem12()
		{
			pcbBackground12.Load(dgvImagens.Rows[12].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem13()
		{
			pcbBackground13.Load(dgvImagens.Rows[13].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem14()
		{
			pcbBackground14.Load(dgvImagens.Rows[14].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void carregarImagem15()
		{
			pcbBackground15.Load(dgvImagens.Rows[15].Cells[dgcUrl.Index].Value.ToString());
			Application.DoEvents();
		}

		private void filtrarDados()
		{
			string dataInicio = "<startdate>";
			string dataFim = "</startdate>";
			string urlInicio = "<url>";
			string urlFim = "</url>";
			string nomeInicio = "<urlBase>";
			string nomeFim = "</urlBase>";
			string descInicio = "<copyright>";
			string descFim = "</copyright>";
			int k = 0;
			for (int i = 0; i <= rtbSource.Lines.Count() - 1; i++)
			{
				if (rtbSource.Lines[i].Contains(dataInicio) || rtbSource.Lines[i].Contains(dataFim))
				{
					if (rtbSource.Lines[i].Contains(dataInicio))
					{
						string vDataItem = rtbSource.Lines[i].Substring(11, rtbSource.Lines[i].Length - 23);
						vDataItem = vDataItem.Substring(6, 2) + "/" + vDataItem.Substring(4, 2) + "/" + vDataItem.Substring(0, 4);
						dgvImagens.Rows.Add(vDataItem);
						vData.Add(vDataItem);
					}
				}
				if (rtbSource.Lines[i].Contains(urlInicio) || rtbSource.Lines[i].Contains(urlFim))
				{
					if (rtbSource.Lines[i].Contains(urlInicio))
					{
						string vURL = "http://www.bing.com" + rtbSource.Lines[i].Substring(5, rtbSource.Lines[i].Length - 11);
						dgvImagens.Rows[k].Cells[dgcUrl.Index].Value = vURL;
					}
				}
				if (rtbSource.Lines[i].Contains(nomeInicio) || rtbSource.Lines[i].Contains(nomeFim))
				{
					if (rtbSource.Lines[i].Contains(nomeInicio))
					{
						string vNome = rtbSource.Lines[i].Substring(20, rtbSource.Lines[i].Length - 30) + "_" + cboDimensoes.Text + ".jpg";
						//idx = vURL.LastIndexOf("/") + 1;
						//nomeArquivo = @vURL.Substring(idx, vURL.Length - idx);
						vNomeArquivo.Add(vNome);
					}
				}
				if (rtbSource.Lines[i].Contains(descInicio) || rtbSource.Lines[i].Contains(descFim))
				{
					if (rtbSource.Lines[i].Contains(descInicio))
					{
						string vDescItem = rtbSource.Lines[i].Substring(11, rtbSource.Lines[i].Length - 23);
						dgvImagens.Rows[k].Cells[dgcDesc.Index].Value = vDesc;
						vDesc.Add(vDescItem);
						k++;
					}
				}
				Application.DoEvents();
			}
		}

		private void habilitarBotoes()
		{
			if (rtbSource.Text == "")
			{
				cmdSalvar1.Enabled = false;
				cmdSalvar2.Enabled = false;
				cmdSalvar3.Enabled = false;
				cmdSalvar4.Enabled = false;
				cmdSalvar5.Enabled = false;
				cmdSalvar6.Enabled = false;
				cmdSalvar7.Enabled = false;
				cmdSalvar8.Enabled = false;
				cmdSalvar9.Enabled = false;
				cmdSalvar10.Enabled = false;
				cmdSalvar11.Enabled = false;
				cmdSalvar12.Enabled = false;
				cmdSalvar13.Enabled = false;
				cmdSalvar14.Enabled = false;
				cmdSalvar15.Enabled = false;
			}
			else
			{
				cmdSalvar1.Enabled = true;
				cmdSalvar2.Enabled = true;
				cmdSalvar3.Enabled = true;
				cmdSalvar4.Enabled = true;
				cmdSalvar5.Enabled = true;
				cmdSalvar6.Enabled = true;
				cmdSalvar7.Enabled = true;
				cmdSalvar8.Enabled = true;
				cmdSalvar9.Enabled = true;
				cmdSalvar10.Enabled = true;
				cmdSalvar11.Enabled = true;
				cmdSalvar12.Enabled = true;
				cmdSalvar13.Enabled = true;
				cmdSalvar14.Enabled = true;
				cmdSalvar15.Enabled = true;
			}
		}

		private void salvarImagem(int i)
		{
			this.Cursor = Cursors.WaitCursor;
			using (WebClient cliente = new WebClient())
			{
				bool existe = false;
				string filepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString());
				DirectoryInfo d = new DirectoryInfo(filepath);
				foreach (FileInfo file in d.GetFiles("*.jpg"))
				{
					string path = Path.GetFileNameWithoutExtension(file.FullName);
					int j = path.IndexOf('_');
					string path2 = path.Substring(0, j);
					int k = vNomeArquivo[i].ToString().IndexOf(path2);
					if (k == -1)
					{
						existe = false;
					}
					else
					{
						existe = true;
						break;
					}
				}
				if (existe == true)
				{
					if (MessageBox.Show("FOI ENCONTRADA A MESMA IMAGEM OU SIMILAR." + (char)13 + "CONFIRMA A SUBSTITUIÇÃO DO ARQUIVO [" + vNomeArquivo[i].ToString() + "] ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						cliente.DownloadFile(dgvImagens.Rows[i].Cells[dgcUrl.Index].Value.ToString(), vNomeArquivo[i].ToString());
					}
					else
					{
						MessageBox.Show("ARQUIVO IGNORADO.");
					}
				}
				else
				{
					cliente.DownloadFile(dgvImagens.Rows[i].Cells[dgcUrl.Index].Value.ToString(), vNomeArquivo[i].ToString());
				}
			}
			this.Cursor = Cursors.Default;
		}

		private void formBing_Load(object sender, EventArgs e)
		{
			rdbIdioma2_CheckedChanged(null, null);
			cboDimensoes_Click(null, null);
		}

		private void cboDimensoes_Click(object sender, EventArgs e)
		{
			int i = cboDimensoes.SelectedIndex;
			if (cboDimensoes.SelectedIndex == -1) i = 14;
			cboDimensoes.Items.Clear();
			cboDimensoes.Items.Add("150x150");
			cboDimensoes.Items.Add("240x320");
			cboDimensoes.Items.Add("320x240");
			cboDimensoes.Items.Add("480x640");
			cboDimensoes.Items.Add("480x800");
			cboDimensoes.Items.Add("640x480");
			cboDimensoes.Items.Add("720x1280");
			cboDimensoes.Items.Add("800x480");
			cboDimensoes.Items.Add("800x600");
			cboDimensoes.Items.Add("1024x768");
			cboDimensoes.Items.Add("1080x1920");
			cboDimensoes.Items.Add("1280x720");
			cboDimensoes.Items.Add("1366x768");
			cboDimensoes.Items.Add("1600x900");
			cboDimensoes.Items.Add("1920x1080");
			cboDimensoes.Items.Add("1920x1200");
			cboDimensoes.SelectedIndex = i;
		}

		private void cmdSalvar1_Click(object sender, EventArgs e)
		{
			salvarImagem(0);
		}

		private void cmdSalvar2_Click(object sender, EventArgs e)
		{
			salvarImagem(1);
		}

		private void cmdSalvar3_Click(object sender, EventArgs e)
		{
			salvarImagem(2);
		}

		private void cmdSalvar4_Click(object sender, EventArgs e)
		{
			salvarImagem(3);
		}

		private void cmdSalvar5_Click(object sender, EventArgs e)
		{
			salvarImagem(4);
		}

		private void cmdSalvar6_Click(object sender, EventArgs e)
		{
			salvarImagem(5);
		}

		private void cmdSalvar7_Click(object sender, EventArgs e)
		{
			salvarImagem(6);
		}

		private void cmdSalvar8_Click(object sender, EventArgs e)
		{
			salvarImagem(7);
		}

		private void cmdSalvar9_Click(object sender, EventArgs e)
		{
			salvarImagem(9);
		}

		private void cmdSalvar10_Click(object sender, EventArgs e)
		{
			salvarImagem(10);
		}

		private void cmdSalvar11_Click(object sender, EventArgs e)
		{
			salvarImagem(11);
		}

		private void cmdSalvar12_Click(object sender, EventArgs e)
		{
			salvarImagem(12);
		}

		private void cmdSalvar13_Click(object sender, EventArgs e)
		{
			salvarImagem(13);
		}

		private void cmdSalvar14_Click(object sender, EventArgs e)
		{
			salvarImagem(14);
		}

		private void cmdSalvar15_Click(object sender, EventArgs e)
		{
			salvarImagem(15);
		}

		private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstPaises.SelectedIndex == -1) return;
			this.Cursor = Cursors.WaitCursor;
			rtbSource.Text = "";
			dgvImagens.Rows.Clear();
			pcbBackground1.Image = null;
			pcbBackground2.Image = null;
			pcbBackground3.Image = null;
			pcbBackground4.Image = null;
			pcbBackground5.Image = null;
			pcbBackground6.Image = null;
			pcbBackground7.Image = null;
			pcbBackground8.Image = null;
			pcbBackground9.Image = null;
			pcbBackground10.Image = null;
			pcbBackground11.Image = null;
			pcbBackground12.Image = null;
			pcbBackground13.Image = null;
			pcbBackground14.Image = null;
			pcbBackground15.Image = null;
			vData.Clear();
			vNomeArquivo.Clear();
			vDesc.Clear();
			habilitarBotoes();
			Application.DoEvents();
			string url = "http://www.bing.com/HPImageArchive.aspx?format=xml&idx=0&n=8&mkt=";
			string codigo_pais = "";
			switch (lstPaises.SelectedIndex)
			{
				case 0:
					this.Cursor = Cursors.WaitCursor;
					codigo_pais = "en-ZA";
					break;
				case 1:
					codigo_pais = "de-DE";
					break;
				case 2:
					codigo_pais = "ar-SA";
					break;
				case 3:
					codigo_pais = "es-AR";
					break;
				case 4:
					codigo_pais = "en-AU";
					break;
				case 5:
					codigo_pais = "de-AT";
					break;
				case 6:
					codigo_pais = "fr-BE";
					break;
				case 7:
					codigo_pais = "nl-BE";
					break;
				case 8:
					codigo_pais = "pt-BR";
					break;
				case 9:
					codigo_pais = "fr-CA";
					break;
				case 10:
					codigo_pais = "en-CA";
					break;
				case 11:
					codigo_pais = "ko-KR";
					break;
				case 12:
					codigo_pais = "es-ES";
					break;
				case 13:
					codigo_pais = "es-US";
					break;
				case 14:
					codigo_pais = "en-US";
					break;
				case 15:
					codigo_pais = "fr-FR";
					break;
				case 16:
					codigo_pais = "en-IN";
					break;
				case 17:
					codigo_pais = "en-ID";
					break;
				case 18:
					codigo_pais = "it-IT";
					break;
				case 19:
					codigo_pais = "ja-JP";
					break;
				case 20:
					codigo_pais = "en-MY";
					break;
				case 21:
					codigo_pais = "es-MX";
					break;
				case 22:
					codigo_pais = "no-NO";
					break;
				case 23:
					codigo_pais = "nl-NL";
					break;
				case 24:
					codigo_pais = "pl-PL";
					break;
				case 25:
					codigo_pais = "zh-HK";
					break;
				case 26:
					codigo_pais = "en-GB";
					break;
				case 27:
					codigo_pais = "zh-CN";
					break;
				case 28:
					codigo_pais = "ru-RU";
					break;
				case 29:
					codigo_pais = "sv-SE";
					break;
				case 30:
					codigo_pais = "de-CH";
					break;
				case 31:
					codigo_pais = "fr-CH";
					break;
				case 32:
					codigo_pais = "zh-TW";
					break;
				case 33:
					codigo_pais = "tr-TR";
					break;
				default:
					this.Cursor = Cursors.Default;
					MessageBox.Show("SELECIONE UM PAÍS NA LISTAGEM");
					return;
			}
			url += codigo_pais;
			var requisicaoWeb = WebRequest.Create(url);
			requisicaoWeb.Method = "GET";
			using (var resposta = requisicaoWeb.GetResponse())
			{
				var streamDados = resposta.GetResponseStream();
				StreamReader reader = new StreamReader(streamDados);
				object objResponse = reader.ReadToEnd();
				rtbSource.Text = objResponse.ToString();
				streamDados.Close();
				resposta.Close();
			}
			url = "http://www.bing.com/HPImageArchive.aspx?format=xml&idx=8&n=8&mkt=" + codigo_pais;
			requisicaoWeb = WebRequest.Create(url);
			requisicaoWeb.Method = "GET";
			using (var resposta = requisicaoWeb.GetResponse())
			{
				var streamDados = resposta.GetResponseStream();
				StreamReader reader = new StreamReader(streamDados);
				object objResponse = reader.ReadToEnd();
				rtbSource.Text += objResponse.ToString();
				streamDados.Close();
				resposta.Close();
			}
			rtbSource.Text = rtbSource.Text.Replace("_1920x1080", "_" + cboDimensoes.Text).Replace("><", ">" + (char)13 + "<");
			filtrarDados();
			Thread th1 = new Thread(carregarImagem1);
			Thread th2 = new Thread(carregarImagem2);
			Thread th3 = new Thread(carregarImagem3);
			Thread th4 = new Thread(carregarImagem4);
			Thread th5 = new Thread(carregarImagem5);
			Thread th6 = new Thread(carregarImagem6);
			Thread th7 = new Thread(carregarImagem7);
			Thread th8 = new Thread(carregarImagem8);
			Thread th9 = new Thread(carregarImagem9);
			Thread th10 = new Thread(carregarImagem10);
			Thread th11 = new Thread(carregarImagem11);
			Thread th12 = new Thread(carregarImagem12);
			Thread th13 = new Thread(carregarImagem13);
			Thread th14 = new Thread(carregarImagem14);
			Thread th15 = new Thread(carregarImagem15);
			th1.Start();
			th2.Start();
			th3.Start();
			th4.Start();
			th5.Start();
			th6.Start();
			th7.Start();
			th8.Start();
			th9.Start();
			th10.Start();
			th11.Start();
			th12.Start();
			th13.Start();
			th14.Start();
			th15.Start();
			ttpInfo.SetToolTip(pcbBackground1, vData[0].ToString() + (char)13 + "[ " + vNomeArquivo[0].ToString() + " ]" + (char)13 + vDesc[0].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground2, vData[1].ToString() + (char)13 + "[ " + vNomeArquivo[1].ToString() + " ]" + (char)13 + vDesc[1].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground3, vData[2].ToString() + (char)13 + "[ " + vNomeArquivo[2].ToString() + " ]" + (char)13 + vDesc[2].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground4, vData[3].ToString() + (char)13 + "[ " + vNomeArquivo[3].ToString() + " ]" + (char)13 + vDesc[3].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground5, vData[4].ToString() + (char)13 + "[ " + vNomeArquivo[4].ToString() + " ]" + (char)13 + vDesc[4].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground6, vData[5].ToString() + (char)13 + "[ " + vNomeArquivo[5].ToString() + " ]" + (char)13 + vDesc[5].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground7, vData[6].ToString() + (char)13 + "[ " + vNomeArquivo[6].ToString() + " ]" + (char)13 + vDesc[6].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground8, vData[7].ToString() + (char)13 + "[ " + vNomeArquivo[7].ToString() + " ]" + (char)13 + vDesc[7].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground9, vData[9].ToString() + (char)13 + "[ " + vNomeArquivo[9].ToString() + " ]" + (char)13 + vDesc[9].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground10, vData[10].ToString() + (char)13 + "[ " + vNomeArquivo[10].ToString() + " ]" + (char)13 + vDesc[10].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground11, vData[11].ToString() + (char)13 + "[ " + vNomeArquivo[11].ToString() + " ]" + (char)13 + vDesc[11].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground12, vData[12].ToString() + (char)13 + "[ " + vNomeArquivo[12].ToString() + " ]" + (char)13 + vDesc[12].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground13, vData[13].ToString() + (char)13 + "[ " + vNomeArquivo[13].ToString() + " ]" + (char)13 + vDesc[13].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground14, vData[14].ToString() + (char)13 + "[ " + vNomeArquivo[14].ToString() + " ]" + (char)13 + vDesc[14].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			ttpInfo.SetToolTip(pcbBackground15, vData[15].ToString() + (char)13 + "[ " + vNomeArquivo[15].ToString() + " ]" + (char)13 + vDesc[15].ToString() + (char)13 + "[ CLIQUE PARA AMPLIAR ]");
			habilitarBotoes();
			this.Cursor = Cursors.Default;
		}

		private void pcbBackground1_Click(object sender, EventArgs e)
		{
			if (pcbBackground1.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[0].ToString();
			f.pcbOriginal.Image = pcbBackground1.Image;
			f.pcbPreview.Image = pcbBackground1.Image;
			f.Show();
		}

		private void pcbBackground2_Click(object sender, EventArgs e)
		{
			if (pcbBackground2.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[1].ToString();
			f.pcbOriginal.Image = pcbBackground2.Image;
			f.pcbPreview.Image = pcbBackground2.Image;
			f.Show();
		}

		private void pcbBackground3_Click(object sender, EventArgs e)
		{
			if (pcbBackground3.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[2].ToString();
			f.pcbOriginal.Image = pcbBackground3.Image;
			f.pcbPreview.Image = pcbBackground3.Image;
			f.Show();
		}

		private void pcbBackground4_Click(object sender, EventArgs e)
		{
			if (pcbBackground4.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[3].ToString();
			f.pcbOriginal.Image = pcbBackground4.Image;
			f.pcbPreview.Image = pcbBackground4.Image;
			f.Show();
		}

		private void pcbBackground5_Click(object sender, EventArgs e)
		{
			if (pcbBackground5.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[4].ToString();
			f.pcbOriginal.Image = pcbBackground5.Image;
			f.pcbPreview.Image = pcbBackground5.Image;
			f.Show();
		}

		private void pcbBackground6_Click(object sender, EventArgs e)
		{
			if (pcbBackground6.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[5].ToString();
			f.pcbOriginal.Image = pcbBackground6.Image;
			f.pcbPreview.Image = pcbBackground6.Image;
			f.Show();
		}

		private void pcbBackground7_Click(object sender, EventArgs e)
		{
			if (pcbBackground7.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[6].ToString();
			f.pcbOriginal.Image = pcbBackground7.Image;
			f.pcbPreview.Image = pcbBackground7.Image;
			f.Show();
		}

		private void pcbBackground8_Click(object sender, EventArgs e)
		{
			if (pcbBackground8.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[7].ToString();
			f.pcbOriginal.Image = pcbBackground8.Image;
			f.pcbPreview.Image = pcbBackground8.Image;
			f.Show();
		}

		private void pcbBackground9_Click(object sender, EventArgs e)
		{
			if (pcbBackground9.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[9].ToString();
			f.pcbOriginal.Image = pcbBackground9.Image;
			f.pcbPreview.Image = pcbBackground9.Image;
			f.Show();
		}

		private void pcbBackground10_Click(object sender, EventArgs e)
		{
			if (pcbBackground10.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[10].ToString();
			f.pcbOriginal.Image = pcbBackground10.Image;
			f.pcbPreview.Image = pcbBackground10.Image;
			f.Show();
		}

		private void pcbBackground11_Click(object sender, EventArgs e)
		{
			if (pcbBackground11.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[11].ToString();
			f.pcbOriginal.Image = pcbBackground11.Image;
			f.pcbPreview.Image = pcbBackground11.Image;
			f.Show();
		}

		private void pcbBackground12_Click(object sender, EventArgs e)
		{
			if (pcbBackground12.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[12].ToString();
			f.pcbOriginal.Image = pcbBackground12.Image;
			f.pcbPreview.Image = pcbBackground12.Image;
			f.Show();
		}

		private void pcbBackground13_Click(object sender, EventArgs e)
		{
			if (pcbBackground13.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[13].ToString();
			f.pcbOriginal.Image = pcbBackground13.Image;
			f.pcbPreview.Image = pcbBackground13.Image;
			f.Show();
		}

		private void pcbBackground14_Click(object sender, EventArgs e)
		{
			if (pcbBackground14.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[14].ToString();
			f.pcbOriginal.Image = pcbBackground14.Image;
			f.pcbPreview.Image = pcbBackground14.Image;
			f.Show();
		}

		private void pcbBackground15_Click(object sender, EventArgs e)
		{
			if (pcbBackground15.Image == null) return;
			formPreview f = new formPreview();
			f.Text = vNomeArquivo[15].ToString();
			f.pcbOriginal.Image = pcbBackground15.Image;
			f.pcbPreview.Image = pcbBackground15.Image;
			f.Show();
		}

		private void rdbIdioma1_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdbIdioma1.Checked) return;
			lstPaises.Items.Clear();
			lstPaises.Items.Add("África do Sul");
			lstPaises.Items.Add("Alemanha");
			lstPaises.Items.Add("Arábia Saudita");
			lstPaises.Items.Add("Argentina");
			lstPaises.Items.Add("Austrália");
			lstPaises.Items.Add("Áustria");
			lstPaises.Items.Add("Bélgica - Francês");
			lstPaises.Items.Add("Bélgica - Holandês");
			lstPaises.Items.Add("Brasil");
			lstPaises.Items.Add("Canadá - Francês");
			lstPaises.Items.Add("Canadá - Inglês");
			lstPaises.Items.Add("Coreia do Sul");
			lstPaises.Items.Add("Espanha");
			lstPaises.Items.Add("Estados Unidos - Espanhol");
			lstPaises.Items.Add("Estados Unidos - Inglês");
			lstPaises.Items.Add("França");
			lstPaises.Items.Add("Índia");
			lstPaises.Items.Add("Indonésia");
			lstPaises.Items.Add("Itália");
			lstPaises.Items.Add("Japão");
			lstPaises.Items.Add("Malásia");
			lstPaises.Items.Add("México");
			lstPaises.Items.Add("Noruega");
			lstPaises.Items.Add("Países Baixos");
			lstPaises.Items.Add("Polônia");
			lstPaises.Items.Add("RAE de Hong Kong");
			lstPaises.Items.Add("Reino Unido");
			lstPaises.Items.Add("República Popular da China");
			lstPaises.Items.Add("Rússia");
			lstPaises.Items.Add("Suécia");
			lstPaises.Items.Add("Suíça - Alemão");
			lstPaises.Items.Add("Suíça - Francês");
			lstPaises.Items.Add("Taiwan");
			lstPaises.Items.Add("Turquia");
			grbDimensoes.Text = " DIMENSÕES DA IMAGEM ";
			grbIdioma.Text = " IDIOMA ";
			rdbIdioma1.Text = "&Português";
			rdbIdioma2.Text = "&Inglês";
			rdbIdioma3.Text = "&Espanhol";
			cmdSalvar1.Text = "&Salvar";
			cmdSalvar2.Text = "&Salvar";
			cmdSalvar3.Text = "&Salvar";
			cmdSalvar4.Text = "&Salvar";
			cmdSalvar5.Text = "&Salvar";
			cmdSalvar6.Text = "&Salvar";
			cmdSalvar7.Text = "&Salvar";
			cmdSalvar8.Text = "&Salvar";
			cmdSalvar9.Text = "&Salvar";
			cmdSalvar10.Text = "&Salvar";
			cmdSalvar11.Text = "&Salvar";
			cmdSalvar12.Text = "&Salvar";
			cmdSalvar13.Text = "&Salvar";
			cmdSalvar14.Text = "&Salvar";
			cmdSalvar15.Text = "&Salvar";
		}

		private void rdbIdioma2_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdbIdioma2.Checked) return;
			lstPaises.Items.Clear();
			lstPaises.Items.Add("South Africa");
			lstPaises.Items.Add("Germany");
			lstPaises.Items.Add("Saudi Arabia");
			lstPaises.Items.Add("Argentina");
			lstPaises.Items.Add("Australia");
			lstPaises.Items.Add("Austria");
			lstPaises.Items.Add("Belgium - French");
			lstPaises.Items.Add("Belgium - Dutch");
			lstPaises.Items.Add("Brazil");
			lstPaises.Items.Add("Canada - French");
			lstPaises.Items.Add("Canada - English");
			lstPaises.Items.Add("Korea");
			lstPaises.Items.Add("Spain");
			lstPaises.Items.Add("United States - Spanish");
			lstPaises.Items.Add("United States - English");
			lstPaises.Items.Add("France");
			lstPaises.Items.Add("India");
			lstPaises.Items.Add("Indonesia");
			lstPaises.Items.Add("Italy");
			lstPaises.Items.Add("Japan");
			lstPaises.Items.Add("Malaysia");
			lstPaises.Items.Add("Mexico");
			lstPaises.Items.Add("Norway");
			lstPaises.Items.Add("Netherlands");
			lstPaises.Items.Add("Poland");
			lstPaises.Items.Add("Hong Kong S.A.R.");
			lstPaises.Items.Add("United Kingdom");
			lstPaises.Items.Add("People's Republic of China");
			lstPaises.Items.Add("Russia");
			lstPaises.Items.Add("Sweden");
			lstPaises.Items.Add("Switzerland - German");
			lstPaises.Items.Add("Switzerland - French");
			lstPaises.Items.Add("Taiwan");
			lstPaises.Items.Add("Turkey");
			grbDimensoes.Text = " PICTURE DIMENSIONS ";
			grbIdioma.Text = " LANGUAGE ";
			rdbIdioma1.Text = "&Portuguese";
			rdbIdioma2.Text = "&English";
			rdbIdioma3.Text = "&Spanish";
			cmdSalvar1.Text = "&Save";
			cmdSalvar2.Text = "&Save";
			cmdSalvar3.Text = "&Save";
			cmdSalvar4.Text = "&Save";
			cmdSalvar5.Text = "&Save";
			cmdSalvar6.Text = "&Save";
			cmdSalvar7.Text = "&Save";
			cmdSalvar8.Text = "&Save";
			cmdSalvar9.Text = "&Save";
			cmdSalvar10.Text = "&Save";
			cmdSalvar11.Text = "&Save";
			cmdSalvar12.Text = "&Save";
			cmdSalvar13.Text = "&Save";
			cmdSalvar14.Text = "&Save";
			cmdSalvar15.Text = "&Save";
		}

		private void rdbIdioma3_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdbIdioma3.Checked) return;
			lstPaises.Items.Clear();
			lstPaises.Items.Add("Sudáfrica");
			lstPaises.Items.Add("Alemania");
			lstPaises.Items.Add("Arabia Saudí");
			lstPaises.Items.Add("Argentina");
			lstPaises.Items.Add("Australia");
			lstPaises.Items.Add("Austria");
			lstPaises.Items.Add("Bélgica - Francés");
			lstPaises.Items.Add("Bélgica - Holandés");
			lstPaises.Items.Add("Brasil");
			lstPaises.Items.Add("Canadá - Francés");
			lstPaises.Items.Add("Canadá - Inglés");
			lstPaises.Items.Add("Corea");
			lstPaises.Items.Add("España");
			lstPaises.Items.Add("Estados Unidos - Español");
			lstPaises.Items.Add("Estados Unidos - Inglés");
			lstPaises.Items.Add("Francia");
			lstPaises.Items.Add("India");
			lstPaises.Items.Add("Indonesia");
			lstPaises.Items.Add("Italia");
			lstPaises.Items.Add("Japón");
			lstPaises.Items.Add("Malasia");
			lstPaises.Items.Add("México");
			lstPaises.Items.Add("Noruega");
			lstPaises.Items.Add("Países Bajos");
			lstPaises.Items.Add("Polonia");
			lstPaises.Items.Add("Hong Kong (RAE)");
			lstPaises.Items.Add("Reino Unido");
			lstPaises.Items.Add("República Popular China");
			lstPaises.Items.Add("Rusia");
			lstPaises.Items.Add("Suecia");
			lstPaises.Items.Add("Suiza - Alemán");
			lstPaises.Items.Add("Suiza - Francés");
			lstPaises.Items.Add("Taiwán");
			lstPaises.Items.Add("Turquía");
			grbDimensoes.Text = " DIMENSIONES DE IMAGEN ";
			grbIdioma.Text = " IDIOMA ";
			rdbIdioma1.Text = "&Portugués";
			rdbIdioma2.Text = "&Inglés";
			rdbIdioma3.Text = "&Español";
			cmdSalvar1.Text = "&Guardar";
			cmdSalvar2.Text = "&Guardar";
			cmdSalvar3.Text = "&Guardar";
			cmdSalvar4.Text = "&Guardar";
			cmdSalvar5.Text = "&Guardar";
			cmdSalvar6.Text = "&Guardar";
			cmdSalvar7.Text = "&Guardar";
			cmdSalvar8.Text = "&Guardar";
			cmdSalvar9.Text = "&Guardar";
			cmdSalvar10.Text = "&Guardar";
			cmdSalvar11.Text = "&Guardar";
			cmdSalvar12.Text = "&Guardar";
			cmdSalvar13.Text = "&Guardar";
			cmdSalvar14.Text = "&Guardar";
			cmdSalvar15.Text = "&Guardar";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pcbBackground1.Image == null) cmdSalvar1.Enabled = false; else cmdSalvar1.Enabled = true;
			if (pcbBackground2.Image == null) cmdSalvar2.Enabled = false; else cmdSalvar2.Enabled = true;
			if (pcbBackground3.Image == null) cmdSalvar3.Enabled = false; else cmdSalvar3.Enabled = true;
			if (pcbBackground4.Image == null) cmdSalvar4.Enabled = false; else cmdSalvar4.Enabled = true;
			if (pcbBackground5.Image == null) cmdSalvar5.Enabled = false; else cmdSalvar5.Enabled = true;
			if (pcbBackground6.Image == null) cmdSalvar6.Enabled = false; else cmdSalvar6.Enabled = true;
			if (pcbBackground7.Image == null) cmdSalvar7.Enabled = false; else cmdSalvar7.Enabled = true;
			if (pcbBackground8.Image == null) cmdSalvar8.Enabled = false; else cmdSalvar8.Enabled = true;
			if (pcbBackground9.Image == null) cmdSalvar9.Enabled = false; else cmdSalvar9.Enabled = true;
			if (pcbBackground10.Image == null) cmdSalvar10.Enabled = false; else cmdSalvar10.Enabled = true;
			if (pcbBackground11.Image == null) cmdSalvar11.Enabled = false; else cmdSalvar11.Enabled = true;
			if (pcbBackground12.Image == null) cmdSalvar12.Enabled = false; else cmdSalvar12.Enabled = true;
			if (pcbBackground13.Image == null) cmdSalvar13.Enabled = false; else cmdSalvar13.Enabled = true;
			if (pcbBackground14.Image == null) cmdSalvar14.Enabled = false; else cmdSalvar14.Enabled = true;
			if (pcbBackground15.Image == null) cmdSalvar15.Enabled = false; else cmdSalvar15.Enabled = true;
		}
	}
}
