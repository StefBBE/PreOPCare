using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Net.Http;

namespace PDMS
{
    public class ReadCard
    {

        public Patient readpatient()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://10.196.4.114/lanccr/v1/Labor%20(02:47:6d)/status");
                client.DefaultRequestHeaders.Add("User-Agent", "Anything");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpContent myJson = new StringContent("{}", Encoding.UTF8, "application/json");
                var response = client.PostAsync("", myJson).Result;
                response.EnsureSuccessStatusCode();
                String temp = response.Content.ReadAsStringAsync().Result;

                JObject MyObject = JObject.Parse(temp);
                JToken status = MyObject["status"];
                JToken cardData = status["cardData"];
                string MyVorname = status["baseContact"]["cardData"]["vorname"].ToString();
                string MyNachname = status["baseContact"]["cardData"]["nachname"].ToString();
                string MyGeburtsdatum = status["baseContact"]["cardData"]["geburtsdatum"].ToString();
                string MyGeschlecht = status["baseContact"]["cardData"]["geschlecht"].ToString();
                string MyCin = status["baseContact"]["cardData"]["cin"].ToString();
                string MySvNr = status["baseContact"]["cardData"]["nummer"].ToString();
                bool sex = false;
                if (MyGeschlecht == "M") { sex = true; }
                HexConverter hc = new HexConverter();
                String HMyCin = hc.converter(MyCin);
                Patient found = new Patient(0, MyVorname, MyNachname, "", MySvNr, MyGeburtsdatum, sex, 0, 0,HMyCin);
                return found;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Patient found = new Patient(0, "", "", "", "", "", false, 0, 0,"");
                return found;
            }
        }

            public string readhexcin()
            {
                try
                {
                    var client = new HttpClient();
                    client.BaseAddress = new Uri("https://10.196.4.114/lanccr/v1/Labor%20(02:47:6d)/status");
                    client.DefaultRequestHeaders.Add("User-Agent", "Anything");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpContent myJson = new StringContent("{}", Encoding.UTF8, "application/json");
                    var response = client.PostAsync("", myJson).Result;
                    response.EnsureSuccessStatusCode();
                    String temp = response.Content.ReadAsStringAsync().Result;

                    JObject MyObject = JObject.Parse(temp);
                    JToken status = MyObject["status"];
                    JToken cardData = status["cardData"];
                    string MyCin = status["baseContact"]["cardData"]["cin"].ToString();
                    HexConverter Hex = new HexConverter();
                    return Hex.converter(MyCin);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return "";
                }
            }
        
    }
}
