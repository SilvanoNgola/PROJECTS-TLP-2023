using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();

            webBrowser.Width = this.Width;
            webBrowser.Height = this.Height-80;
        }

        
        private void navegar()
        {
            if (txtUrl.Text != "")
            {
                webBrowser.Navigate(txtUrl.Text);
            }
            else
            {
                MessageBox.Show("Digite um Endereço URL!");
                txtUrl.Focus();
            }
        }
        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navegar();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            navegar();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void webBrower_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = webBrowser.CanGoBack;

        }
        private void webBrower_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = webBrowser.CanGoForward;

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser.Width = this.Width;
            webBrowser.Height = this.Height - 80;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
