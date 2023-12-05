using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPaises.Modelos;
using TrabalhoPaises.Service;
using System.Globalization;

namespace TrabalhoPaises
{
    public partial class Form1 : Form
    {
        #region Atributo
        
        private List<Pais> PaisLista;
        private NetworkService networkService;
        private ApiService apiService;
        private DialogService dialogService;
        private DataService dataService;
       
        #endregion

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            
            LoadPaises();
            
        }

        
        /// <summary>
        /// Método que checa a conexão com a internet,
        /// preenche o combobox com os dados em ordem alfabética, 
        /// preenche a progressbar,
        /// transmite a informação da origem dos dados apresentados, se esta a ser carregado da Api ou da base de dados.
        /// </summary>

        private async void LoadPaises()
        {
            bool load;
            pictureBox_flags.Visible=false;
            label2.Visible=false;
            label3.Visible=false;
            label4.Visible=false;
            label5.Visible=false;
            label6.Visible=false;
            label7.Visible=false;
                        
            var connection = networkService.CheckConnection();
            if (!connection.IsSuccess)
            {
                LoadLocalPaises();
                load = false;

            }
            else
            {
                await LoadApiPaises();
                load = true;
            }

            if (PaisLista == null || PaisLista.Count == 0)
            {
                lbl_status.Text = "There is no internet connection" + Environment.NewLine +
                    "and the data of the Countries were not loaded." + Environment.NewLine +
                    "Try later";
                return;
            }                               

            if (load)
            {
                lbl_status2.Text = string.Format("Information loaded from the internet in {0:F}", DateTime.Now);
            }
            else
            {
                lbl_status2.Text = string.Format("Information loaded from the Database.");
            }
            progressBar1.Value = 100;

            
            foreach (Pais pais in PaisLista)
            {
                comboBox_paises.Items.Add(pais.name.common);
            }
            List<string> itemsList = new List<string>();
            foreach (var item in comboBox_paises.Items)
            {
                itemsList.Add(item.ToString());
            }
            itemsList.Sort();
            comboBox_paises.Items.Clear();
            foreach (var item in itemsList)
            {
                comboBox_paises.Items.Add(item);
            }
            comboBox_paises.AutoCompleteMode = AutoCompleteMode.Suggest;

            progressBar1.Value=100;
            

        }
        

        /// <summary>
        /// Método responsável por carregar os dados dos países a partir da base de dados local.
        /// Obtém os dados utilizando o método GetData do serviço de dados e armazena-os na variável PaisLista
        /// </summary>
        private void LoadLocalPaises()
        {
            PaisLista = dataService.GetData();
        }

        /// <summary>
        /// Método assíncrono responsável por carregar os dados dos países da API.
        /// Configura a progressbar com o valor inicial que é 0.
        /// Chama o método GetPaises do serviço da API para obter os dados dos países.
        /// Armazena a lista de países retornada na variável PaisLista
        /// Remove todos os dados existentes na base de dados.
        /// Salva os novos dados na base de dados utilizando o método Savedata do serviço de dados.
        /// </summary>
        /// <returns></returns>

        private async Task LoadApiPaises()
        {
            progressBar1.Value = 0;
            var response = await apiService.GetPaises("https://restcountries.com", "/v3.1/all?fields=name,flags,capital,population,region,subregion,gini,languages");
            PaisLista = (List<Pais>)response.Result;
            dataService.DeleteData();
            dataService.Savedata(PaisLista);
        }

        /// <summary>
        /// Evento de clique do botão "Informações".
        /// Chama o método BuscaInformacao() para preencher as informações do país selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_informações_Click(object sender, EventArgs e)
        {
            BuscaInformacao();

        }

        /// <summary>
        /// Método que verifica se um país foi selecionado no comboBox
        /// Obtém o nome do país selecionado
        /// preenche as informações do país selecionado nas labels e exibe a bandeira correspondente.
        /// torna visivel as labels com as respostas das informações.
        /// </summary>
        private void BuscaInformacao()
        {

            if (comboBox_paises.SelectedItem == null)
            {
                dialogService.ShowMessage("You need to choose a country.", "Erro");
                return;
            }
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            string nomePaisSelecionado = comboBox_paises.SelectedItem.ToString();


            Pais pais = PaisLista.FirstOrDefault(p => p.name.common == nomePaisSelecionado);

            lbl_name.Text = pais.name.common.ToString();
            lbl_capital.Text = string.Join(",", pais.capital ?? new List<string> { "No Information" });
            lbl_regiao.Text = pais.region.ToString();
            lbl_subregiao.Text = !string.IsNullOrEmpty(pais.subregion) ? pais.subregion : "No Information";
            
            if (pais.population > 0)
            {
                NumberFormatInfo numberFormat = new CultureInfo("en-US").NumberFormat;
                lbl_populacao.Text = pais.population.ToString("N0", numberFormat);
            }
            else
            {
                lbl_populacao.Text = "No Information";
            }
                        

            Dictionary<string, double> giniData = pais.gini;
            if (giniData != null && giniData.Count > 0)
            {
                foreach (KeyValuePair<string, double> entry in giniData)
                {
                    string giniKey = entry.Key;
                    double giniValue = entry.Value;
                    string giniText = $"{giniValue} - ({giniKey})";
                    lbl_gini1.Text = giniText;
                    break; 
                }
            }
            else
            {
                lbl_gini1.Text = "No Information";
            }
               

            string PaisSelecionado = comboBox_paises.SelectedItem.ToString();
            string nomeArquivo = PaisSelecionado + ".png";
            string pastaBandeiras = Path.Combine(Application.StartupPath, "Flags");
            string caminhoBandeira = Path.Combine(pastaBandeiras, nomeArquivo);
            string semBandeira = Path.Combine(Application.StartupPath, "Flags", "no image.png");
            pictureBox_flags.Visible = true;
            if (File.Exists(caminhoBandeira))
            {
                pictureBox_flags.Image = Image.FromFile(caminhoBandeira);
            }
            else
            {
                pictureBox_flags.Image = Image.FromFile(semBandeira);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
