using System;
using System.Configuration;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class TruckModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string matricula { get; set; }
        public string capacidad { get; set; }

        public TruckModel()
        {

        }

        public TruckModel(int id, string marca, string modelo, string matricula, string capacidad) : this()
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.capacidad = capacidad;
        }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public TruckModel GetTruckByUserId(int id_usuario)
        {
            try
            {
                RestClient client = new RestClient($"{apiUrl}/truck/by_user/{id_usuario}");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    TruckModel responseBody = JsonConvert.DeserializeObject<TruckModel>(response.Content);
                    return responseBody;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
