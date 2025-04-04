using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial_Pursuit.Model
{
    public class QCM : Questions
    {
        private string R1, R2, R3;

        // constructeur paramétré
        public QCM(string titre, string reponse, string R1, string R2, string R3) : base(titre, reponse)
        {
            this.R1 = R1;
            this.R2 = R2;
            this.R3 = R3;
        }

        // constructeur par défaut
        public QCM()
        {

        }

        // Accesseurs
        public string getR1()
        {
            return this.R1;
        }

        public string getR2()
        {
            return this.R2;
        }

        public string getR3()
        {
            return this.R3;
        }

        // Mutateurs
        public void setR1(string R1)
        {
            this.R1 = R1;
        }

        public void setR2(string R2)
        {
            this.R2 = R2;
        }

        public void setR3(string R3)
        {
            this.R3 = R3;
        }
    }
}
