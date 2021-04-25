using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace mini_cas_v3
{
    public partial class Opzioni : Form
    {
        public Opzioni(ToolStrip barra)
        {
            InitializeComponent();
            this.barra = barra;
          //  check = new List<CheckBox>();
        }

        private void chiudi_bottone_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            controllo = punti_check.Checked;
        }

        private void Opzioni_Load(object sender, EventArgs e)
        {
            punti_check.Checked = linee_check.Checked = rettangoli_check.Checked = quadrati_check.Checked = controllo;
              if(elenco_figura_combo.Items.Count == 0)
              {
                  elenco_figura_combo.Items.Add("Punti");
                  elenco_figura_combo.Items.Add("Linee");
                  elenco_figura_combo.Items.Add("Rettangoli");
                  elenco_figura_combo.Items.Add("Quadrati");
              }
            if (elenco_figura_combo.Items.Count == 0)
                foreach (ToolStripButton bottone in barra.Items)
                {
                    elenco_figura_combo.Items.Add(bottone.Text);
           /*         check.Add(new CheckBox());
                    check[check.Count - 1].Location = new Point(140, 16 + check.Count * 20);
                    check[check.Count - 1].Text = "check" + bottone.Text;
                    check[check.Count - 1].Size = new Size(100, 17);
                    Controls.Add(check[check.Count - 1]/* as Control);*/
                }
        }

        static bool controllo = false;
        private ToolStrip barra = null;
      //  private List<CheckBox> check = null;
    }
}
