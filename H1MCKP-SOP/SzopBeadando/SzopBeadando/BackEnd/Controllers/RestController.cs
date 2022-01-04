using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SzopBeadando.BackEnd.Model;

namespace SzopBeadando.BackEnd.Controllers
{
    class RestController
    {
        private static RestClient client = new RestClient("http://localhost:80/Server/");

        public static string Login(string uname, string pwd)
        {
            var request = new RestRequest("auth/login.php", Method.GET);
            request.AddHeader("Authorization", string.Format("Bearer {0} {1}", uname, pwd));
            
            try
            {
                var response = JObject.Parse(client.Execute<string>(request).Content);
                return response.GetValue("Status").ToString();
            }
            catch(JsonReaderException e)
            {
                return  "";
            }
        }
        public static List<EnergyDrink> getAllEnergyDrink()
        {
            var request = new RestRequest("crud/server.php", Method.GET);
            List<EnergyDrink> queryResult = client.Execute<List<EnergyDrink>>(request).Data;
            return queryResult;
        }

        public static EnergyDrink getEnergyDrinkById(int id)
        {
            var request = new RestRequest("crud/server.php?id={id}", Method.GET);
            request.AddParameter("id", id);
            EnergyDrink queryResult = client.Execute<EnergyDrink>(request).Data;
            return queryResult;
        }

        public static void deleteEnergyDrinkById(int id)
        {
            var request = new RestRequest("crud/server.php?id={id}", Method.DELETE);
            request.AddParameter("id", id);
            request.AddHeader("Authorization", string.Format("Bearer {0} {1}", User.UserName, User.Pwd));
            
            if (User.UserName != null)
            {
                var response = JObject.Parse(client.Execute<string>(request).Content);
                if (response.GetValue("status").ToString() == "1") return;
                else throw new ArgumentException();
            } else
            {
                MessageBox.Show("You have to login to use this function!");
            }
        }

        public static void updateEnergyDrinkByID(EnergyDrink energyDrink)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new Resolver();
            var request = new RestRequest($"crud/server.php?id={energyDrink.Id}", Method.PUT);
            request.AddParameter("id", energyDrink.Id.ToString(), ParameterType.QueryString);
            
            string body = JsonConvert.SerializeObject(energyDrink, settings);
            request.AddJsonBody(body);
            request.AddHeader("Authorization", string.Format("Bearer {0} {1}", User.UserName, User.Pwd));
            
            if(User.UserName != null)
            {
                var response = JObject.Parse(client.Execute<string>(request).Content);
                if (response.GetValue("status").ToString() == "1") return;
                else throw new ArgumentException();
            }
            else
            {
                MessageBox.Show("You have to login to use this function!");
            }
        }

        public static void addEnergyDrink(EnergyDrink energyDrink)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new Resolver();
            string body = JsonConvert.SerializeObject(energyDrink, settings);
            
            var request = new RestRequest("crud/server.php", Method.POST);
            request.AddJsonBody(body);
            request.AddHeader("Authorization", string.Format("Bearer {0} {1}", User.UserName, User.Pwd));
   
            
            try
            {
                if (User.UserName != null)
                {
                    var response = JObject.Parse(client.Execute<string>(request).Content);
                    if (response.GetValue("status").ToString() == "1") return;
                    else throw new ArgumentException();
                }
                else
                {
                    MessageBox.Show("You have to login to use this function!");
                }
            }
            catch(JsonReaderException)
            {
                return;
            }
        }

    }
}
