using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using FifaScrape.Models;
using FifaScrape.DataHolders;

namespace FifaScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String baseURL = "https://www.easports.com/fifa/ultimate-team/api/fut/item?page=";
                int page = 7;
                int totalPages=8;
                Boolean requestFailed = false;
                do
                {
                    String instanceUrl = baseURL + page;
                    Console.WriteLine("Connecting to "+instanceUrl);
                    WebRequest request = WebRequest.Create(instanceUrl);
                    using(WebResponse response = request.GetResponse())
                    {
                        String responseEncodingStr = response.ContentType;

                        MemoryStream ms = new MemoryStream();
                        response.GetResponseStream().CopyTo(ms);
                        byte[] responseBody = ms.ToArray();
                        String s = Encoding.UTF8.GetString(responseBody);
                        JObject jsonData = JObject.Parse(s);
                        //totalPages =jsonData["totalPages"].Value<int>();

                        JArray items = jsonData["items"].Value<JArray>();
                        for(int i=0;i<items.Count;i++)
                        {
                            JObject playerJSON = items[i].Value<JObject>();
                            Player p = Player.FromJson(playerJSON);
                            ItemLists.AddPlayer(p);
                        }


                        page++;
                        if(page>totalPages)
                        {
                            requestFailed = true;
                        }
                    }

                } while (!requestFailed);

                var players = ItemLists.GetPlayers();
                Console.WriteLine("Players = " + players.Count);

                String folderPath = "C:/Users/Thomas/Desktop/Fifa";
                String playersPath = folderPath + "/players.js";
                File.Create(playersPath).Close();
                JArray jarr = new JArray();
                foreach (int id in players.Keys)
                {
                    Player p = players[id];
                    jarr.Add(p.ToJson());
                }
                File.WriteAllText(playersPath, jarr.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            


            Console.WriteLine("END");
            Console.ReadKey();
            
        }
    }
}
