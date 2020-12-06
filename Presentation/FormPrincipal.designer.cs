namespace Presentation
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFormulario3 = new System.Windows.Forms.Button();
            this.btnFormulario2 = new System.Windows.Forms.Button();
            this.btnFormulario1 = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1150, 602);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(188, 32);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(962, 570);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFormularios_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.lblEmail);
            this.panelMenu.Controls.Add(this.lblName);
            this.panelMenu.Controls.Add(this.lblPosition);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnFormulario3);
            this.panelMenu.Controls.Add(this.btnFormulario2);
            this.panelMenu.Controls.Add(this.btnFormulario1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 570);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // btnFormulario3
            // 
            this.btnFormulario3.FlatAppearance.BorderSize = 0;
            this.btnFormulario3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnFormulario3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnFormulario3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormulario3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFormulario3.Location = new System.Drawing.Point(0, 354);
            this.btnFormulario3.Name = "btnFormulario3";
            this.btnFormulario3.Size = new System.Drawing.Size(188, 40);
            this.btnFormulario3.TabIndex = 2;
            this.btnFormulario3.Text = "Formulario 3";
            this.btnFormulario3.UseVisualStyleBackColor = true;
            this.btnFormulario3.Click += new System.EventHandler(this.btnFormulario3_Click);
            // 
            // btnFormulario2
            // 
            this.btnFormulario2.FlatAppearance.BorderSize = 0;
            this.btnFormulario2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnFormulario2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnFormulario2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormulario2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFormulario2.Location = new System.Drawing.Point(0, 308);
            this.btnFormulario2.Name = "btnFormulario2";
            this.btnFormulario2.Size = new System.Drawing.Size(188, 40);
            this.btnFormulario2.TabIndex = 1;
            this.btnFormulario2.Text = "Formulario 2";
            this.btnFormulario2.UseVisualStyleBackColor = true;
            this.btnFormulario2.Click += new System.EventHandler(this.btnFormulario2_Click);
            // 
            // btnFormulario1
            // 
            this.btnFormulario1.FlatAppearance.BorderSize = 0;
            this.btnFormulario1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnFormulario1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnFormulario1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormulario1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFormulario1.Location = new System.Drawing.Point(0, 262);
            this.btnFormulario1.Name = "btnFormulario1";
            this.btnFormulario1.Size = new System.Drawing.Size(188, 40);
            this.btnFormulario1.TabIndex = 0;
            this.btnFormulario1.Text = "Formulario 1";
            this.btnFormulario1.UseVisualStyleBackColor = true;
            this.btnFormulario1.Click += new System.EventHandler(this.btnFormulario1_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1150, 32);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1076, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 26);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnnRestaurar
            // 
            this.btnnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnnRestaurar.Image")));
            this.btnnRestaurar.Location = new System.Drawing.Point(1076, 3);
            this.btnnRestaurar.Name = "btnnRestaurar";
            this.btnnRestaurar.Size = new System.Drawing.Size(33, 26);
            this.btnnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnRestaurar.TabIndex = 2;
            this.btnnRestaurar.TabStop = false;
            this.btnnRestaurar.Visible = false;
            this.btnnRestaurar.Click += new System.EventHandler(this.btnnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1044, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 26);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1109, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 488);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.LightGray;
            this.lblPosition.Location = new System.Drawing.Point(43, 128);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(57, 17);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Posicion";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightGray;
            this.lblName.Location = new System.Drawing.Point(43, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.LightGray;
            this.lblEmail.Location = new System.Drawing.Point(43, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 602);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnnRestaurar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFormulario3;
        private System.Windows.Forms.Button btnFormulario2;
        private System.Windows.Forms.Button btnFormulario1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

