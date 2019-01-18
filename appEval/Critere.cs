using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEval
{
    public class Critere
    {
        private string libelleCritere;

        public Critere(string libelleCritere)
        {
            this.libelleCritere = libelleCritere;
        }

        public string LibelleCritere { get => libelleCritere; set => libelleCritere = value; }
    }
}
