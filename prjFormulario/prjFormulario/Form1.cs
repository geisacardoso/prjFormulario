using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonalizarCor_Click(object sender, EventArgs e)
        {
            // chama a caixa de cor
            colorDialog1.ShowDialog();
            // o this é referente ao formulário em execução
            // muda a cor pela selecionada
            this.BackColor = colorDialog1.Color;
        }

        private void btnPersonalizarFonte_Click(object sender, EventArgs e)
        {
            // chama a caixa fonte
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;

        }
    }
}
