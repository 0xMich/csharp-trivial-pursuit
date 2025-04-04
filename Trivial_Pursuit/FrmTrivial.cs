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
    public partial class FrmTrivial : Form
    {
        private int currentPlayerIndex = 0;
        private Random random = new Random();
        private List<Player> players = new List<Player>();
        private List<Button> buttons;

        public FrmTrivial()
        {
            InitializeComponent();
            btn_dice.Visible = false;
            var scoreLabels = this.Controls.OfType<Label>()
                .Where(l => l.Name.StartsWith("lbl_score"))
                .ToList();

            foreach (var label in scoreLabels)
            {
                label.Visible = false;
            }


        }

        private void FrmTrivial_Load(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            GenerateGame();
        }

        private void GenerateGame()
        {
            this.buttons = this.Controls.OfType<Button>()
                .Where(b => b.Name.StartsWith("button"))
                .OrderBy(b => b.TabIndex).ToList();
            Random random = new Random();

            Color[] colors = { Color.Blue, Color.Yellow, Color.Pink, Color.Orange, Color.Maroon, Color.Green };

            if (!int.TryParse(txtB_nbPlayer.Text, out int nbPlayer) || nbPlayer <= 0)
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nbPlayer > 20)
            {
                MessageBox.Show("Le nombre de joueur(s) ne peut pas dépasser 20", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                players = Enumerable.Range(1, nbPlayer)
                    .Select(i => new Player(i, $"P{i}", 0, i))
                    .ToList();

                this.currentPlayerIndex = 1;

                colors = colors.OrderBy(c => random.Next()).ToArray();

                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].FlatAppearance.BorderSize = 0;
                    buttons[i].BackColor = colors[i % colors.Length];
                    buttons[i].Font = new Font("Arial", 10, FontStyle.Bold);

                    switch (colors[i % colors.Length].Name)
                    {
                        case "Yellow":
                        case "Pink":
                            buttons[i].ForeColor = Color.Black;
                            break;
                        case "Blue":
                        case "Maroon":
                        case "Green":
                            buttons[i].ForeColor = Color.White;
                            break;
                        case "Orange":
                            buttons[i].ForeColor = Color.White;
                            break;
                        default:
                            buttons[i].ForeColor = Color.Black;
                            break;
                    }

                    if (i < players.Count)
                    {
                        buttons[i].Text = players[i].Name;
                        buttons[i].Tag = players[i];
                    }
                    else
                    {
                        buttons[i].Text = "";
                    }
                }
                btn_play.Enabled = false;
                txtB_nbPlayer.Enabled = false;
                btn_dice.Visible = true;
                var scoreLabels = this.Controls.OfType<Label>()
                    .Where(l => l.Name.StartsWith("lbl_score"))
                    .ToList();

                foreach (var label in scoreLabels)
                {
                    label.Visible = true;
                }
            }
        }

        private void txtB_nbPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RunDice(object sender, EventArgs e)
        {
            if (players == null || players.Count == 0)
            {
                MessageBox.Show("Veuillez d'abord générer le jeu.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dice = random.Next(1, 7);
                MessageBox.Show("Joueur " + currentPlayerIndex + " a lancé " + dice, "Lancer de dé", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (currentPlayerIndex >= 1 && currentPlayerIndex <= players.Count)
                {
                    Player player = (Player)players[currentPlayerIndex - 1];
                    Button currentButton = (Button)buttons[player.Position - 1];

                    currentButton.Text = currentButton.Text.Replace(player.Name, "").Trim();

                    if (currentButton.Text.StartsWith("| "))
                    {
                        currentButton.Text = currentButton.Text.Substring(2);
                    }
                    if (currentButton.Text.EndsWith(" |"))
                    {
                        currentButton.Text = currentButton.Text.Substring(0, currentButton.Text.Length - 2);
                    }

                    player.Position = (player.Position + dice - 1) % buttons.Count + 1;
                    Button newButton = (Button)buttons[player.Position - 1];

                    newButton.Text = string.IsNullOrWhiteSpace(newButton.Text) ? player.Name : $"{newButton.Text.Trim()} | {player.Name}";

                    currentPlayerIndex = (currentPlayerIndex % players.Count);

                    Color currentColor = currentButton.BackColor;

                    Categorie laCategorie = Categorie.GetCategorie(currentColor);


                    FrmQuestions frmQuestions = new FrmQuestions(laCategorie.GetTitre());
                    frmQuestions.ShowDialog();

                    MessageBox.Show("Joueur " + currentPlayerIndex + " est sur la catégorie " + laCategorie.GetTitre(), "Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtB_nbPlayer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
