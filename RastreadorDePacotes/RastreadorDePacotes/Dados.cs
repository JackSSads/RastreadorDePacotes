using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RastreadorDePacotes
{
    class Dados
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Ibge { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }

        public string JsonSerializar(Dados dados)
        {
            return JsonConvert.SerializeObject(dados);
        }

        public static Dados JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Dados>(Json);
        }
    }
}
