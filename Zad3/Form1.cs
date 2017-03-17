using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Zupelnie inny tekst.",
                "Nieważna wiadomość");
            
            DialogResult result2 = MessageBox.Show("Czy wierzysz że to nieważna wiadomość?",
                "Niewazna wiadomość",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            DialogResult result3 = MessageBox.Show("Czy to jest pytanie?",
                "To nie pytanie",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
            
            MessageBox.Show("Nie zdałeś",
                "To nie krytyczna wiadomość",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign,
                false);
            
            MessageBox.Show("Potwierdź, że nie zdałeś",
                "Nie ważne co klikniesz",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
