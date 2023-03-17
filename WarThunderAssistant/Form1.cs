using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Timers;

namespace WarThunderAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer();
        }

        private void Timer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer(100);
            
            aTimer.AutoReset = true;
            aTimer.Elapsed += HtmlChecker;
            aTimer.Enabled = true;
        }


        private void HtmlChecker(Object source, ElapsedEventArgs e)
        {
            //var html = @"http://localhost:8111/";
            var html = @"C:\Users\samue\Documents\localhost.htm";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);


            int tas = Int32.Parse(htmlDoc.GetElementbyId("stt-TAS, km/h").InnerText);

            Invoke(new Action(() =>{
                tasLabel.Text = tas.ToString();
            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}