using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajazitovska.almina._4i.rubrica
{
    public class Contatto
    {
        private int numero;
        private string nome;//creo tre classi private, private può essere anche omesso dato che c'è di default
        private string cognome;

        public int Numero { get => numero; set => numero = value; }//=> 
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
    }
}
