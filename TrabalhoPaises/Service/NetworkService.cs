using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoPaises.Service
{
    using TrabalhoPaises.Modelos;
    public class NetworkService
    {
        /// <summary>
        /// Metodo que devolve a resposta  e checa se tem conexção com a internet ou não.
        /// utiliza o endereço da google para teste ligação a internet 
        /// </summary>
        /// <returns></returns>
        public Response CheckConnection()  
        {
            var client = new WebClient();
            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSuccess = true

                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Configure your internet connection"
                };
            }
        }
    }
}
