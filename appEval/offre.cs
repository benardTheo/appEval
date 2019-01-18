using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEval
{
   public class offre
    {
        private string libelle;
        private int codeEmplois;

        public offre(string unLibelle, int unCodeEmplois)
        {
            this.libelle = unLibelle;
            this.codeEmplois = unCodeEmplois;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }

        public int GetCodeEmplois()
        {
            return this.codeEmplois;
        }
    }
}
