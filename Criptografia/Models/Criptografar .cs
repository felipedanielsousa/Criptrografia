using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Criptografia.Models
{
    public class Criptografar : Criptografia
    {
        public static string Crip(string texto, string chave)
        {
            return Cipher(texto, chave, true);
        }
    }
}