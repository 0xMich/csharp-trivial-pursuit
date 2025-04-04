using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial_Pursuit.Model
{
    public class Questions
    {
        private string titre;
        private string reponse;

        // constructeur paramétré
        public Questions(string titre, string reponse)
        {
            this.titre = titre;
            this.reponse = reponse;
        }

        // constructeur par défaut
        public Questions()
        {

        }

        // Accesseurs
        public string getTitre()
        {
            return this.titre;
        }

        public string getReponse()
        {
            return this.reponse;
        }

        // Mutateurs
        public void setTitre(string titre)
        {
            this.titre = titre;
        }

        public void setReponse(string reponse)
        {
            this.reponse = reponse;
        }
    }
}
