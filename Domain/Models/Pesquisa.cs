﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Pesquisa
    {
        /// <summary>
        /// Termo a ser pesquisado.
        /// </summary>
        [Required]
        public string TermoPesquisa { get; set; }

        /// <summary>
        /// Ano de lançamento.
        /// </summary>
        public int? AnoLancamento { get; set; }
    }
}
