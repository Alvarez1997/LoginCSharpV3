using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //poder arrastrar la ventana 
using Domain;

namespace Presentation
{
    public partial class MenuPrincipalLogin : Form
    {
        public MenuPrincipalLogin()
        {
            InitializeComponent();
        }


        //Arrastrar ventana y poder moverla////////////////////////////////////////////
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        ////////////////////////////////////////////////////////////////////////////////

        #region Eventos/Efectos del menu Login

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true; //esconder la contraseña
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false; //mostrar la palabra CONTRASEÑA si no hay una contraseña
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimizar la ventana actual
        }

        private void MenuPrincipalLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //para que tambien se pueda mover desde el lado del logo
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        //Login con ambos formularios ya agregados
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUARIO")
            {
                if(txtpass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel(); //instanciar al modelo usuario de la capa de dominio
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text); //pasar por parametro el usuario y contraseña
                    if (validLogin == true) //si el inicio de sesion es correcto, instancio al formulario principal 
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout; //sobrecargar el metodo FormClosed con el metodo de cerrar secion
                        this.Hide(); //oculta el menu login
                    }
                    else //si el inicio de sesion no es exitoso
                    {
                        msgError("Usuario o Contraseña incorrectos! \n  Por Favor intentelo de nuevo.");
                        txtpass.Text = "CONTRASEÑA";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else msgError("Por favor ingrese una contraseña!");
            }
            else msgError("Por favor ingrese un usuario!");
            
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show(); //muestra de nuevo el menu Login en ves del menu principal
            //txtuser.Focus();
        }
    }
}
