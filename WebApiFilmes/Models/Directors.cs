﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFilmes.Models
{
    public class Directors
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade_Filmes { get; set; }
    }
}
