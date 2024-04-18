using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_2_17_04_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.TextLength == 0)
                MessageBox.Show(" Por Favor Digite Algo! ", " AVISO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxNome.Focus();
            {
                cmblista.Items.Add(textBoxNome.Text);
                textBoxNome.Clear();
                textBoxNome.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cmblista.SelectedIndex == 0)
                MessageBox.Show(" Por Favor Selecione um Item ", " AVISO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                cmblista.Items.Remove(cmblista.SelectedItem);
                cmblista.SelectedIndex = 0;
            }
        }
    }
}
