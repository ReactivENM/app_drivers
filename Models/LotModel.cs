using System;
using System.Configuration;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class LotModel
    {
        public int id { get; set; }
        public int id_almacen { get; set; }
        public string estado { get; set; }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public LotModel()
        {

        }

        public LotModel(int id, int id_almacen, string estado) : this()
        {
            this.id = id;
            this.id_almacen = id_almacen;
            this.estado = estado;
        }

        public List<LotModel> GetAll(int id_camion)
        {
            List<LotModel> data = new List<LotModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot/assigned/{id_camion}");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<LotModel> responseBody = JsonConvert.DeserializeObject<List<LotModel>>(response.Content);

                    foreach (LotModel item in responseBody)
                    {
                        data.Add(item);
                    }

                    return data;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool MarkAsDelivered(int id, int IdAlmacen)
        {
            try
            {
                var data = new { IdAlmacen, Estado = "entregado" };
                RestClient client = new RestClient($"{apiUrl}/lot/{id}");
                RestRequest request = new RestRequest(Method.PUT);
                request.AddJsonBody(data);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UnmarkAsDelivered(int id, int IdAlmacen)
        {
            try
            {
                var data = new { IdAlmacen, Estado = "en_viaje" };
                RestClient client = new RestClient($"{apiUrl}/lot/{id}");
                RestRequest request = new RestRequest(Method.PUT);
                request.AddJsonBody(data);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}