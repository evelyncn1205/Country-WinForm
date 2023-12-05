using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPaises.Modelos;

namespace TrabalhoPaises.Service
{
    
    public class DataService
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private DialogService dialogService;

        /// <summary>
        /// Construtor da classe DataService.
        /// Inicializa o serviço de diálogo (DialogService) e verifica se o diretório "Arquivo" existe.
        /// Caso não exista, o diretório é criado. Em seguida, é definido o caminho para o arquivo de base de dados (Paises.sqlite) na pasta "Arquivo".
        /// É estabelecida a conexão com a base de dados e, se ela não existir, é criada.
        ///  Executa um comando SQL para criar a tabela Paises caso não exista.
        /// </summary>
        public DataService()
        {
            dialogService = new DialogService();
            if (!Directory.Exists("Arquivo"))
            {
                Directory.CreateDirectory("Arquivo");
            }
            var path = @"Arquivo\Paises.sqlite";
            try
            {
                connection = new SQLiteConnection("Data Source=" + path); //conection string que liga a base de dados e cria se ela nao existir
                connection.Open();

                string sqlcommand =
              "CREATE TABLE IF NOT EXISTS Paises(Name VARCHAR(50), Capital VARCHAR(50), Region VARCHAR(50), SubRegion VARCHAR(50), Population INT, GiniKey VARCHAR(10), GiniValue DOUBLE, Flags VARCHAR(50))";
                // sqlcommand cria a tabela se ela não existir
                command = new SQLiteCommand(sqlcommand, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }

            
        }

        /// <summary>
        /// Método responsável por salvar os dados dos países na base de dados.
        /// Percorre a lista de países e executa uma instrução SQL INSERT TO para cada país.
        /// Os parâmetros são utilizados para preencher os valores da instrução SQL.
        /// </summary>
        /// <param name="Paises"></param>
        public void Savedata(List<Pais> Paises)
        {
            
            try
            {
                foreach (var pais in Paises)
                {
                    
                    string sql = "insert into Paises (Name, Capital, Region, SubRegion, Population, GiniKey,GiniValue,Flags) " +
                     "values (@Name, @Capital, @Region, @SubRegion, @Population, @GiniKey,@GiniValue, @Flags)";
                    command = new SQLiteCommand(sql, connection);
                    command.Parameters.AddWithValue("@Name", pais.name.common);
                    command.Parameters.AddWithValue("@Capital", pais.capital);
                    command.Parameters.AddWithValue("@Region", pais.region);
                    command.Parameters.AddWithValue("@SubRegion", pais.subregion);
                    command.Parameters.AddWithValue("@Population", pais.population);
                    command.Parameters.AddWithValue("@GiniKey", pais.gini.Keys.FirstOrDefault());
                    command.Parameters.AddWithValue("@GiniValue", pais.gini.Values.FirstOrDefault());
                    command.Parameters.AddWithValue("@Flags", pais.flags);
                                       
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch(Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }
        }

        
        public List<Pais> GetData()
        {
            List<Pais> pais = new List<Pais>();
            Pais paises;
            try
            {
                string sql = "select Name, Capital, Region, SubRegion, Population, GiniKey, GiniValue, Flags FROM Paises";
                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    string flag = (string)reader["Flags"];
                    string capitalData = (string)reader["Capital"];
                    pais.Add(new Pais
                    {
                        name = new Name { common = name },
                        capital = new List<string> { (string)reader["Capital"] },
                        region = (string)reader["Region"],
                        subregion = (string)reader["SubRegion"],
                        population = (int)reader["Population"],
                        gini = new Dictionary<string, double>()
                        {
                             { reader["GiniKey"].ToString(), Convert.ToDouble(reader["GiniValue"]) }
                        },
                        flags = new Flags { png = flag },

                    });
                    
                }
                connection.Close();
                return pais;
            }
            catch (Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
                return null;
            }
        }

       

        

        public void DeleteData() // limpa a base de dados para ser atualizada 
        {
            try
            {
                string sql = "Delete from Paises";
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }

        }
    }
}



