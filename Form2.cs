using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSDA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;          // Sélectionne toute la ligne
            listView1.GridLines = false;              // Lignes visibles
            listView1.Columns.Add("Produit", 120);   // Colonne 1
            listView1.Columns.Add("Prix", 70);   // Colonne 2
           
        }

        private void AjouterProduit(string nom , double prix)
        {

            string texte = nom + " - " + prix + " €";

            listView1.Items.Add(texte);
        }

        private void EsprBut_Click(object sender, EventArgs e)
        {
            AjouterProduit("Espresso", 2);
        }
        

        private void MochBut_Click(object sender, EventArgs e)
        {
            AjouterProduit("Mocha", 3);
        }

        private void DoEsBut_Click(object sender, EventArgs e)
        {
            AjouterProduit("Double espresso", 4);
        }

        private void CroisBut_Click(object sender, EventArgs e)
        {
            AjouterProduit("Croissant", 2);
        }

        private void ChocoBut_Click(object sender, EventArgs e)
        {
            AjouterProduit("Chocolatine", 2);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Prend le premier élément sélectionné
                string texte = listView1.SelectedItems[0].Text;

                // Affiche dans une boîte de message
                MessageBox.Show("Tu as sélectionné : " + texte);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                // Si ton item est du type "Espresso - 2 €"
                string texte = item.Text;

                // On récupère le nombre après le tiret
                int indexEuro = texte.IndexOf('€');
                if (indexEuro > 0)
                {
                    string partiePrix = texte.Substring(texte.IndexOf('-') + 1, indexEuro - texte.IndexOf('-') - 1);
                    double prix;
                    if (double.TryParse(partiePrix, out prix))
                    {
                        total += prix;
                    }
                }
            }

            MessageBox.Show("Total à payer : " + total.ToString("0.00") + " €", "Paiement");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signin sign = new Signin();
            this.Hide();
            sign.Show();
        }
    }
}
