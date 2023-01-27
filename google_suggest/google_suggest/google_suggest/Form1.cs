using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace google_suggest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private const string _suggestSearchUrl = "http://www.google.com/complete/search?output=toolbar&q={0}&hl=en";

        public async Task<List<GoogleSuggestion>> GetSearchSuggestions(string query)
        {
            if (String.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm");
            }

            string result = String.Empty;

            using (HttpClient client = new HttpClient())
            {
                result = await client.GetStringAsync(String.Format(_suggestSearchUrl, query));
            }

            XDocument doc = XDocument.Parse(result);

            var suggestions = from suggestion in doc.Descendants("CompleteSuggestion")
                              select new GoogleSuggestion
                              {
                                  Phrase = suggestion.Element("suggestion").Attribute("data").Value
                              };

            return suggestions.ToList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
            List<GoogleSuggestion> x = new List<GoogleSuggestion>();
             x = await GetSearchSuggestions(txtKeyword.Text);
            foreach (GoogleSuggestion item in x)
            {
                txtResult.Text = txtResult.Text + item.Phrase + "\n";
            }

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            IWebDriver drive = new ChromeDriver();
            drive.Navigate().GoToUrl("https://www.blogger.com/");
            var username = drive.FindElement(By.XPath("//span[contains(text(),'Đăng nhập')]"));
            username.Click();
            Thread.Sleep(1000);

        }
    }


    public class GoogleSuggestion
    {
        public string Phrase { get; set; }
        public override string ToString()
        {
            return this.Phrase;
        }
    }

}
