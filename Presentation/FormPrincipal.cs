using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

        }

        #region Funcionalidades del formulario
        //METODO PARA ARRASTRAR FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            //dibujar un grip en el rectangulo
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere salir del Programa?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }               
        }
       
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Capturar posicion y tamaño antes de maximizar para restaurarlo despues de darle al btnRestaurar
        int lx, ly;
        int ancho, alto;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            ancho = this.Size.Width;
            alto = this.Size.Height;

            btnMaximizar.Visible = false;
            btnnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnnRestaurar_Click(object sender, EventArgs e)
        {
            //le envio un nuevo objeto posicion y tamaño con los parametros que almacenan el tamaño por defecto
            this.Size = new Size(ancho, alto);
            this.Location = new Point(lx, ly);

            btnMaximizar.Visible = true;
            btnnRestaurar.Visible = false;
        }

        private void panelFormularios_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFormulario1_Click(object sender, EventArgs e)
        {
           // AbrirFormulario<Form1>(); //Utilizo el metodo para abrir formularios dentro del panel

            btnFormulario1.BackColor = Color.FromArgb(12, 61, 92); //esto ya es extra, que el boton mantenga el color de pulsado si el form esta abierto
        }

        private void btnFormulario2_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form2>(); //Utilizo el metodo para abrir formularios dentro del panel

            btnFormulario2.BackColor = Color.FromArgb(12, 61, 92); //CloseForms
        }

        private void btnFormulario3_Click(object sender, EventArgs e)
        {
           // AbrirFormulario<Form3>(); //Utilizo el metodo para abrir formularios dentro del panel

            btnFormulario3.BackColor = Color.FromArgb(12, 61, 92); //CloseForms
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la sesion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Metodos para los formularios 
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<Miform>()where Miform : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<Miform>().FirstOrDefault();//busca en la coleccion el formulario
            //si el formulario/instancia no existe
            if(formulario == null)
            {
                formulario = new Miform(); //crear una nueva instancia
                formulario.TopLevel = false; //le digo que no es un formulario de nivel superior
                formulario.FormBorderStyle = FormBorderStyle.None; //quitarle el borde al formulario
                formulario.Dock = DockStyle.Fill; //hacer que rellene el panelFormularios
                panelFormularios.Controls.Add(formulario);//agrego el formulario a la coleccion de controles del panel
                panelFormularios.Tag = formulario;//especifico la propiedad tag
                formulario.Show();
                formulario.BringToFront();//correcion del error que hace que los formularios aparezcan detras 

                formulario.FormClosed += new FormClosedEventHandler(CloseForms); //regresar el color por defecto a los botones de abrir formulario
            }
            //si el formulario/instancia si existe
            else 
            {
                formulario.BringToFront();
            }
        }
        
        private void CloseForms(object sender, FormClosedEventArgs e) //reiniciar color del boton si el form esta cerrado
        {
            if (Application.OpenForms["Form1"] == null) btnFormulario1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null) btnFormulario2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null) btnFormulario3.BackColor = Color.FromArgb(4, 41, 68);
        }
        #endregion
    }
}
