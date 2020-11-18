using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApiFilmes.Dtos
{
    public class DirectorsDto
    {
        [JsonProperty("codigo_director")]
        public int codigo_director { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("qnt_filme")]
        public int qnt_filme { get; set; }
    }
}
