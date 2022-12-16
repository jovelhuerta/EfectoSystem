using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class PeticionesHttp
    {
        public string MethodHtt(string url, NameValueCollection requestParam ,string method = "POST")//, T objectRequest, string method = "POST")
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] responsebytes = null;
                    if (requestParam != null)
                        responsebytes = client.UploadValues(url, method, requestParam);
                    else
                        responsebytes = client.DownloadData(url);
                    return Encoding.UTF8.GetString(responsebytes);
                    //return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responsebody);
                }
            }
            catch (WebException ex)
            {
                using (StreamReader r = new StreamReader(ex.Response.GetResponseStream()))
                {
                    return r.ReadToEnd(); // access the reponse message
                }
            }
        }
    
        /// <summary>
        /// Metodo que Realiza la peticion POST y que envio un BODY
        /// </summary>
        /// <typeparam name="T">tipo de Modelo a Enviar</typeparam>
        /// <param name="url">la URL de la API</param>
        /// <param name="UrlCplement">Controlador y metodo a enviar</param>
        /// <param name="datas">clase de Objeto con los datos</param>
        /// <returns></returns>
        public async Task<int> MethodPostBody<T>(string url,string UrlCplement, T datas)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                
                var data = JsonConvert.SerializeObject(datas);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(UrlCplement, content);

                if (response.IsSuccessStatusCode)
                {
                    return 1;
                }
                return 0;
            }
        }
    
        /// <summary>
        /// Metodo que realiza las peticiones GET con Parametros
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="UrlComplement"></param>
        /// <returns></returns>
        public async Task<T> MethodGet<T>(string url,string UrlComplement)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };

            // Assign default header (Json Serialization)
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Make an API call and receive HttpResponseMessage
            var responseMessage = await client.GetAsync(UrlComplement, HttpCompletionOption.ResponseContentRead);
            if (responseMessage.IsSuccessStatusCode)
            {
                // Convert the HttpResponseMessage to string
                var resultArray = await responseMessage.Content.ReadAsStringAsync();

                // Deserialize the Json string into type using JsonConvert
                return JsonConvert.DeserializeObject<T>(resultArray);
            }
            return default(T);
            
        }

        /// <summary>
        /// Metodo que Realiza peticiones POST de tipo FROMFORM
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="UrlCplement"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public async Task<T> MethodPostForm<T>(string url, string UrlCplement, Dictionary<string, string> values)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var formSend = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(UrlCplement, formSend);

                if (response.IsSuccessStatusCode)
                {
                    var resultArray = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(resultArray);
                }
                return default(T);
            }
        }
    }
}
