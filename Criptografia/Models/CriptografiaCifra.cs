using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Criptografia.Models
{
    public class CriptografiaCifra
    {
        public string Texto { get; set; }

        public string Chave { get; set; }

        public bool CripDescrip { get; set; }

        public string TextoFinal { get; set; }
    }
}