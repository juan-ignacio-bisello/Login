using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMenssage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lParam);



        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassw_Enter(object sender, EventArgs e)
        {
            if (txtPassw.Text == "Contraseña")
            {
                txtPassw.Text = "";
                txtPassw.ForeColor = Color.LightGray;
                txtPassw.UseSystemPasswordChar = true;
            }
        }

        private void txtPassw_Leave(object sender, EventArgs e)
        {
            if (txtPassw.Text =="")
            {
                txtPassw.Text = "Contraseña";
                txtPassw.ForeColor = Color.DimGray;
                txtPassw.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //to free move the form in the screen
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
