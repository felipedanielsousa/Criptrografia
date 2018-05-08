
namespace Criptografia.Models
{
    public class Descriptografar : Criptografia
    {
        public static string Descrip(string texto, string chave)
        {
            return Cipher(texto, chave, false);
        }
    }
}