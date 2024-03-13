using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFiche1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                lb_liste.Items.Add(tb_saisie.Text);
                tb_saisie.Text = ""; 
                tb_saisie.Focus();
            }
            catch
            {
                MessageBox.Show("aucun texte saisi", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Selectionner un texte a supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
