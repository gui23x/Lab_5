using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class TelaFotos : Form
    {
        public TelaFotos()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos jpeg|*.jpeg";

            if(openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.ImageLocation = openFileDialogFoto.FileName;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos jpeg|*.jpeg";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto1.ImageLocation = openFileDialogFoto.FileName;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg|*.jpg|Arquivos jpeg|*.jpeg";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto2.ImageLocation = openFileDialogFoto.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
