using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using System.Timers;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WarThunderAssistant
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Object used for "emulating" the site
        /// </summary>
        private WebDriver WebDriver;

        
        void UpdateLabelText(Label label, string text)
        {

            this.Invoke(() =>
            {
                label.Text = text;
            });
        }
        //void UpdateLabel(Label label, string id, string formatting)
        //{
        //    if (currentHtmlDoc is null) return;

        //    HtmlNode elementNode = currentHtmlDoc.GetElementbyId(id);
        //    if (elementNode is null)
        //        UpdateLabelText(label, string.Format(formatting, "[NULL]"));
        //    else
        //        UpdateLabelText(label, string.Format(formatting, elementNode.InnerText));
        //}

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// Initializes the entire software, downloads page
        /// </summary>
        void Init()
        {
            //Add handler to exit the browser emulator
            Application.ApplicationExit += this.Application_ApplicationExit;
            
            //Create options for WebDriver
            ChromeOptions webDriverOptions = new ChromeOptions();
            webDriverOptions.AddArgument("--headless");

            //Create the web driver
            WebDriver = new ChromeDriver(webDriverOptions);
            WebDriver.Navigate().GoToUrl("http://127.0.0.1:8111");

            System.Timers.Timer t = new System.Timers.Timer(100);
            t.Elapsed += this.UpdateForm;
            t.AutoReset = true;
            t.Enabled = true;
        }

        private void Application_ApplicationExit(object? sender, EventArgs e)
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }

        private void UpdateForm(Object source, ElapsedEventArgs e)
        {
            IWebElement element = WebDriver.FindElement(By.Id("stt-TAS, km/h"));
            UpdateLabelText(this.tasLabel, element.Text);
        }
    }
}