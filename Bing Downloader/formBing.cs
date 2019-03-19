using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
		//string nomeArquivo;

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
			string vDataItem = "";
			string vURL = "";
			string vNome = "";
			string vDescItem = "";
			int k = 0;
			for (int i = 0; i <= rtbSource.Lines.Count() - 1; i++)
			{
				if (rtbSource.Lines[i].Contains(dataInicio) || rtbSource.Lines[i].Contains(dataFim))
				{
					if (rtbSource.Lines[i].Contains(dataInicio))
					{
						vDataItem = rtbSource.Lines[i].Substring(11, rtbSource.Lines[i].Length - 23);
						vDataItem = vDataItem.Substring(6, 2) + "/" + vDataItem.Substring(4, 2) + "/" + vDataItem.Substring(0, 4);
						dgvImagens.Rows.Add(vDataItem);
						vData.Add(vDataItem);
					}
				}
				if (rtbSource.Lines[i].Contains(urlInicio) || rtbSource.Lines[i].Contains(urlFim))
				{
					if (rtbSource.Lines[i].Contains(urlInicio))
					{
						vURL = "http://www.bing.com" + rtbSource.Lines[i].Substring(5, rtbSource.Lines[i].Length - 11);
						dgvImagens.Rows[k].Cells[dgcUrl.Index].Value = vURL;
					}
				}
				if (rtbSource.Lines[i].Contains(nomeInicio) || rtbSource.Lines[i].Contains(nomeFim))
				{
					if (rtbSource.Lines[i].Contains(nomeInicio))
					{
						vNome = rtbSource.Lines[i].Substring(20, rtbSource.Lines[i].Length - 30) + "_1920x1080.jpg";
						//idx = vURL.LastIndexOf("/") + 1;
						//nomeArquivo = @vURL.Substring(idx, vURL.Length - idx);
						vNomeArquivo.Add(vNome);
					}
				}
				if (rtbSource.Lines[i].Contains(descInicio) || rtbSource.Lines[i].Contains(descFim))
				{
					if (rtbSource.Lines[i].Contains(descInicio))
					{
						vDescItem = rtbSource.Lines[i].Substring(11, rtbSource.Lines[i].Length - 23);
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
			}
		}
		
		private void salvarImagem(int i)
		{
			this.Cursor = Cursors.WaitCursor;
			using (WebClient cliente = new WebClient())
			{
				cliente.DownloadFile(dgvImagens.Rows[i].Cells[dgcUrl.Index].Value.ToString(), vNomeArquivo[i].ToString());
			}
			this.Cursor = Cursors.Default;
		}

		private void formBing_Load(object sender, EventArgs e)
		{
			rdbIdioma2_CheckedChanged(null, null);
		}

		private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstPaises.SelectedIndex == -1) return;
			this.Cursor = Cursors.WaitCursor;
			rtbSource.Text = "";
			dgvImagens.Rows.Clear();
			pcbBackground1.Image = null;
			chkImg1.Checked = false;
			pcbBackground2.Image = null;
			chkImg2.Checked = false;
			pcbBackground3.Image = null;
			chkImg3.Checked = false;
			pcbBackground4.Image = null;
			chkImg4.Checked = false;
			pcbBackground5.Image = null;
			chkImg5.Checked = false;
			pcbBackground6.Image = null;
			chkImg6.Checked = false;
			pcbBackground7.Image = null;
			chkImg7.Checked = false;
			pcbBackground8.Image = null;
			chkImg8.Checked = false;
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
			rtbSource.Text = rtbSource.Text.Replace("_1366x768", "_1920x1080").Replace("><", ">" + (char)13 + "<");
			filtrarDados();
			//carregarImagens();
			Thread th1 = new Thread(carregarImagem1);
			Thread th2 = new Thread(carregarImagem2);
			Thread th3 = new Thread(carregarImagem3);
			Thread th4 = new Thread(carregarImagem4);
			Thread th5 = new Thread(carregarImagem5);
			Thread th6 = new Thread(carregarImagem6);
			Thread th7 = new Thread(carregarImagem7);
			Thread th8 = new Thread(carregarImagem8);
			th1.Start();
			th2.Start();
			th3.Start();
			th4.Start();
			th5.Start();
			th6.Start();
			th7.Start();
			th8.Start();
			ttpInfo.SetToolTip(pcbBackground1, vData[0].ToString() + (char)13 + "[ " + vNomeArquivo[0].ToString() + " ]" + (char)13 + vDesc[0].ToString());
			ttpInfo.SetToolTip(pcbBackground2, vData[1].ToString() + (char)13 + "[ " + vNomeArquivo[1].ToString() + " ]" + (char)13 + vDesc[1].ToString());
			ttpInfo.SetToolTip(pcbBackground3, vData[2].ToString() + (char)13 + "[ " + vNomeArquivo[2].ToString() + " ]" + (char)13 + vDesc[2].ToString());
			ttpInfo.SetToolTip(pcbBackground4, vData[3].ToString() + (char)13 + "[ " + vNomeArquivo[3].ToString() + " ]" + (char)13 + vDesc[3].ToString());
			ttpInfo.SetToolTip(pcbBackground5, vData[4].ToString() + (char)13 + "[ " + vNomeArquivo[4].ToString() + " ]" + (char)13 + vDesc[4].ToString());
			ttpInfo.SetToolTip(pcbBackground6, vData[5].ToString() + (char)13 + "[ " + vNomeArquivo[5].ToString() + " ]" + (char)13 + vDesc[5].ToString());
			ttpInfo.SetToolTip(pcbBackground7, vData[6].ToString() + (char)13 + "[ " + vNomeArquivo[6].ToString() + " ]" + (char)13 + vDesc[6].ToString());
			ttpInfo.SetToolTip(pcbBackground8, vData[7].ToString() + (char)13 + "[ " + vNomeArquivo[7].ToString() + " ]" + (char)13 + vDesc[7].ToString());
			habilitarBotoes();
			this.Cursor = Cursors.Default;
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
			grbStatus.Text = " STATUS ";
			chkImg1.Text = "Imagem 1";
			chkImg2.Text = "Imagem 2";
			chkImg3.Text = "Imagem 3";
			chkImg4.Text = "Imagem 4";
			chkImg5.Text = "Imagem 5";
			chkImg6.Text = "Imagem 6";
			chkImg7.Text = "Imagem 7";
			chkImg8.Text = "Imagem 8";
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
			grbStatus.Text = " STATUS ";
			chkImg1.Text = "Picture 1";
			chkImg2.Text = "Picture 2";
			chkImg3.Text = "Picture 3";
			chkImg4.Text = "Picture 4";
			chkImg5.Text = "Picture 5";
			chkImg6.Text = "Picture 6";
			chkImg7.Text = "Picture 7";
			chkImg8.Text = "Picture 8";
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
			grbStatus.Text = " ESTATUS ";
			chkImg1.Text = "Imagen 1";
			chkImg2.Text = "Imagen 2";
			chkImg3.Text = "Imagen 3";
			chkImg4.Text = "Imagen 4";
			chkImg5.Text = "Imagen 5";
			chkImg6.Text = "Imagen 6";
			chkImg7.Text = "Imagen 7";
			chkImg8.Text = "Imagen 8";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pcbBackground1.Image == null) chkImg1.Checked = false; else chkImg1.Checked = true;
			if (pcbBackground2.Image == null) chkImg2.Checked = false; else chkImg2.Checked = true;
			if (pcbBackground3.Image == null) chkImg3.Checked = false; else chkImg3.Checked = true;
			if (pcbBackground4.Image == null) chkImg4.Checked = false; else chkImg4.Checked = true;
			if (pcbBackground5.Image == null) chkImg5.Checked = false; else chkImg5.Checked = true;
			if (pcbBackground6.Image == null) chkImg6.Checked = false; else chkImg6.Checked = true;
			if (pcbBackground7.Image == null) chkImg7.Checked = false; else chkImg7.Checked = true;
			if (pcbBackground8.Image == null) chkImg8.Checked = false; else chkImg8.Checked = true;
		}
	}
}
