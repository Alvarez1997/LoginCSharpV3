namespace Presentation
{
    partial class MenuPrincipalLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(997, 450);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 256;
            this.lineShape1.X2 = 683;
            this.lineShape1.Y1 = 126;
            this.lineShape1.Y2 = 126;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 257;
            this.lineShape2.X2 = 684;
            this.lineShape2.Y1 = 202;
            this.lineShape2.Y2 = 202;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.DimGray;
            this.txtuser.Location = new System.Drawing.Point(341, 130);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(569, 25);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUARIO";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(341, 224);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(569, 25);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnlogin.Location = new System.Drawing.Point(341, 313);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(569, 50);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.DimGray;
            this.linkpass.Location = new System.Drawing.Point(493, 402);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(255, 21);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Ha Olvidado Su Contraseña?";
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(956, 6);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(31, 27);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 7;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(916, 6);
            this.btnminimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(31, 27);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // MenuPrincipalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipalLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipalLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtuser;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox btnsalir;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox btnminimizar;
    }
}

