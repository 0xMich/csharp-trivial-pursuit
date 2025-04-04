using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivial_Pursuit.Model;

namespace Trivial_Pursuit
{
    public partial class FrmQuestions : Form
    {
        private string category;
        public FrmQuestions(string laCategorie)
        {
            InitializeComponent();
            this.category = laCategorie;
        }

        public FrmQuestions()
        {
        }

        private void FrmQuestions_Load(object sender, EventArgs e)
        {
            lbl_question.Text = category;
            Categorie categorieData = Categorie.GetQuestionsFromCategory(category);
            List<Questions> listQuestions = categorieData.GetQuestions();

            Console.WriteLine(listQuestions[1].getTitre());
        }

        // bloquer le fait de pouvoir fermer la form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Empêcher la fermeture de la fenêtre
            e.Cancel = true;
        }
    }
}
