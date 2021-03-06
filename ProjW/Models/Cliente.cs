﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjW.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string NomeCliente { get; set; }
        [Display(Name = "Cód. Interno")]
        public int CodigoInternoCliente { get; set; }

        //connect to Tarefas table
        public ICollection<Tarefa> Tarefas { get; set; }
        
    }
}