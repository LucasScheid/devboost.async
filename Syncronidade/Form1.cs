using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncronidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            label1.Text = "Rodando Sincrono.....";
            Thread.Sleep(5000);
            label1.Text = "Terminei no modo Sincrono";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
                button3.BackColor = Color.Blue;
            else
                button3.BackColor = Color.Red;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            label1.Text = "Rodando Assincrono.....";
            await PausaComTaskDelay();
            label1.Text = "Terminei no modo Assincrono";
        }

        async Task PausaComTaskDelay()
        {
            await Task.Delay(5000);
        }



    }
}
