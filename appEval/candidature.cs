using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEval
{
    public class candidature
    {
        private string codeCandidat;


        public candidature(string unCodeCandidat)
        {
            this.codeCandidat = unCodeCandidat;
        }

        public string GetCodeCandidat()
        {
            return this.codeCandidat;
        }
    }
}
