using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilmes.Dtos
{
    public class MoviesDto
    {
        [JsonProperty("codigo_filme")]
        public int codigo_filme { get; set; }

        [JsonProperty("nota")]
        public int nota { get; set; }

        [JsonProperty("nome_filme")]
        public string nome_filme { get; set; }
    }
}
