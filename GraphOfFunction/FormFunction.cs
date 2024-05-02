using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphOfFunction
{
    public partial class FormFunction : Form
    {
        private FunctionColor fc;
        public FunctionColor Fc
        {
            get
            {
                return fc;
            }
        }
        public FormFunction(FunctionColor fc)
        {
            InitializeComponent();
            this.fc = fc;

            textBoxFunction.Text = fc.Function;
            panelColor.BackColor = fc.Color;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            DialogResult dr =  colorDialogFunction.ShowDialog();
            panelColor.BackColor = colorDialogFunction.Color;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            fc.Function = textBoxFunction.Text;
            fc.Color = panelColor.BackColor;

            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Visible = false;
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            textBoxFunction.Text = textBoxFunction.Text.Insert(
                textBoxFunction.SelectionStart, ((Button)sender).Text);
        }
    }
}
