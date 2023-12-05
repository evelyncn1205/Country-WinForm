using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using TrabalhoPaises.Modelos;
using System.IO;

namespace TrabalhoPaises.Service
{
    public class ApiService
    {
        /// <summary>
        /// Método responsável por obter os dados dos países a partir de uma API.
        /// Se a resposta indicar sucesso (IsSuccessStatusCode), os dados são desserializados e retornados.
        /// Caso contrário, tenta obter os dados da base de dados local como alternativa.
        /// Se os dados da base de dados estiverem disponíveis, eles são retornados.
        /// Caso contrário, retorna uma resposta de falha com a mensagem de erro da resposta da API.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="controller"></param>
        /// <returns></returns>
        internal async Task<Response> GetPaises(string url, string controller)
        {
            
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(url);
                var response = await client.GetAsync(controller);
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var rates = JsonConvert.DeserializeObject<List<Pais>>(result);
                    return new Response
                    {
                        IsSuccess = true,
                        Result = rates
                    };
                }
                else
                {
                    
                    var databaseData = ObterDadosDaBaseDeDados(); 

                    if (databaseData != null)
                    {
                        return new Response
                        {
                            IsSuccess = true,
                            Result = databaseData
                        };
                    }
                    else
                    {
                        return new Response
                        {
                            IsSuccess = false,
                            Message = result
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
        /// <summary>
        /// Este método obtém os dados da base de dados para mostrar automaticamente em caso da Api não estar mais disponivel ou não funcione por algum outro motivo.
        /// </summary>
        /// <returns>paises</returns>
        private object ObterDadosDaBaseDeDados()
        {
            string connectionString = "Data Source=Arquivo/Paises.sqlite;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Name, Capital, Region, SubRegion, Population, GiniKey, GiniValue, Flags FROM Paises"; 

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<Pais> paises = new List<Pais>();

                        while (reader.Read())
                        {
                            string flag = "Arquivo/Flags";

                            Pais pais = new Pais
                            {
                                name = new Name { common = (string)reader["Name"] },
                                capital = new List<string> { (string)reader["Capital"] },
                                region = (string)reader["Region"],
                                subregion = (string)reader["SubRegion"],
                                population = (int)reader["Population"],
                                gini = new Dictionary<string, double>()
                                {
                                 { reader["GiniKey"].ToString(), Convert.ToDouble(reader["GiniValue"]) }
                                },

                                flags = new Flags { png = File.Exists(flag) ? flag : "Flags\\no image.png" }


                            };
                            paises.Add(pais);
                        }
                        return paises;
                    }

                }
            }
        }
    }
}

