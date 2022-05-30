using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolarHG
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strUrl = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=b611f277";
            using (HttpClient client  = new HttpClient())
            {

                try
                {
                    var response = client.GetAsync(strUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        lblBuy.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblSell.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVar.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    }
                    else
                    {
                        lblBuy.Text = "-";
                        lblSell.Text = "-";
                        lblVar.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    lblBuy.Text = "-";
                    lblSell.Text = "-";
                    lblVar.Text = "-";

                    Console.Write(ex.Message);
                }
               
            }        
        }
    }
}
