using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionApp
{
    public partial class Add : Form
    {
        FormMenu menu;
        public Add(FormMenu Menu)
        {
            InitializeComponent();
            menu = Menu;
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                bool istnieje = false;
                int min = int.Parse(textBoxMinWiek.Text);
                int max = int.Parse(textBoxMaxWiek.Text);
                string nazwa = textBoxNazwaGrupa.Text;
                for (int i = 0; i < menu.kontener.liczbaGrup; i++)
                {
                    if (menu.kontener.grupy[i].nazwaGrupy == nazwa)
                        istnieje = true;
                }
                if (!istnieje)
                    menu.kontener.AddGrupa(new Grupa(min, max, nazwa));
                else
                    MessageBox.Show("Grupa o takiej nazwie już istnieje.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAddPod_Click(object sender, EventArgs e)
        {

        }
    }
}
