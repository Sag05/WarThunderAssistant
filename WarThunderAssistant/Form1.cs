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
            var html = @"http://localhost:8111/";
            //var html = @"C:\Users\samue\Documents\localhost.htm";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            //TAS (True Airspeed)
            string tas = htmlDoc.GetElementbyId("stt-TAS, km/h").InnerText;
            tas = tas.Remove(0, 10);
            tas = "TAS: " + tas + "km/h";

            //IAS (Indicated Airspeed)
            string ias = htmlDoc.GetElementbyId("stt-IAS, km/h").InnerText;
            ias = ias.Remove(0, 10);
            ias = "IAS: " + ias + "km/h";

            //Current fuel left
            string fuel = htmlDoc.GetElementbyId("ind-fuel").InnerText.Remove(0, 5).Replace('.', ',');
            double fuelD = double.Parse(fuel);
            string fuelConsumption = htmlDoc.GetElementbyId("ind-fuel_consume").InnerText.Remove(0, 13).Replace('.', ',');
            double fuelConsumptionD = double.Parse(fuelConsumption);

            string fuelLeftS = Math.Round(fuelD / fuelConsumptionD).ToString();
            string fuelLeft = "Fuel: " + fuelLeftS;

            Invoke(new Action(() =>{
                tasLabel.Text = tas;
                iasLabel.Text = ias;
                fuelLeftLabel.Text = fuelLeft;
            }));
        }
    }
}