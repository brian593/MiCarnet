using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MiCarnet.Models;


namespace MiCarnet.Services
{
    public class ApiServices : IApiServices
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;
        public Vacuna.Root Items { get; private set; }


        public ApiServices()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        

       

        public async Task<Vacuna.Root> ObtenerVacunas(DateDNI dateDNI)
        {
            Items = new Vacuna.Root();
            Uri uri = new Uri(string.Format(Constants.Constants.BaseUrl, string.Empty));

            try
            {
                var formcontent = new FormUrlEncodedContent(new[]
                {
                 new KeyValuePair<string,string>("form[identificacion]",dateDNI.identificacion),
                 new KeyValuePair<string, string>("form[fechanacimiento]",dateDNI.fechanacimiento)
                });
                var response = await client.PostAsync(uri, formcontent);


                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<Vacuna.Root>(content, serializerOptions);
                }

                return Items;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
                return null;
            }
        }
    }
}
