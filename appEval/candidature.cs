using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEval
{
    public class candidature
    {
        private int codeCandidat;


        public candidature(int unCodeCandidat)
        {
            this.codeCandidat = unCodeCandidat;
        }

        public int GetCodeCandidat()
        {
            return this.codeCandidat;
        }
    }
}
