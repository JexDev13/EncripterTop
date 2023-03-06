namespace FormularioED
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSubMenuDesencriptar = new System.Windows.Forms.Panel();
            this.buttonDesencriptar = new System.Windows.Forms.Button();
            this.buttonGuardarArchivoClaro = new System.Windows.Forms.Button();
            this.buttonSalir = new FormularioED.ButtonP();
            this.buttonDesencriptarMenu = new System.Windows.Forms.Button();
            this.panelSubMenuEncriptar = new System.Windows.Forms.Panel();
            this.buttonEncriptar = new System.Windows.Forms.Button();
            this.buttonGuardarArchivoEncriptado = new System.Windows.Forms.Button();
            this.buttonEncriptarMenu = new System.Windows.Forms.Button();
            this.panelArchivosSubMenu = new System.Windows.Forms.Panel();
            this.buttonAbrirArchivoEncriptado = new System.Windows.Forms.Button();
            this.buttonAbrirArchivoClaro = new System.Windows.Forms.Button();
            this.buttonArchivos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSubMenuDesencriptar.SuspendLayout();
            this.panelSubMenuEncriptar.SuspendLayout();
            this.panelArchivosSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(197, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 338);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(413, 18);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 338);
            this.textBox2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 385);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panelSubMenuDesencriptar);
            this.panel2.Controls.Add(this.buttonSalir);
            this.panel2.Controls.Add(this.buttonDesencriptarMenu);
            this.panel2.Controls.Add(this.panelSubMenuEncriptar);
            this.panel2.Controls.Add(this.buttonEncriptarMenu);
            this.panel2.Controls.Add(this.panelArchivosSubMenu);
            this.panel2.Controls.Add(this.buttonArchivos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 385);
            this.panel2.TabIndex = 8;
            // 
            // panelSubMenuDesencriptar
            // 
            this.panelSubMenuDesencriptar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSubMenuDesencriptar.Controls.Add(this.buttonDesencriptar);
            this.panelSubMenuDesencriptar.Controls.Add(this.buttonGuardarArchivoClaro);
            this.panelSubMenuDesencriptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuDesencriptar.Location = new System.Drawing.Point(0, 242);
            this.panelSubMenuDesencriptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubMenuDesencriptar.Name = "panelSubMenuDesencriptar";
            this.panelSubMenuDesencriptar.Size = new System.Drawing.Size(179, 60);
            this.panelSubMenuDesencriptar.TabIndex = 6;
            // 
            // buttonDesencriptar
            // 
            this.buttonDesencriptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDesencriptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDesencriptar.FlatAppearance.BorderSize = 0;
            this.buttonDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesencriptar.Image = global::FormularioED.Properties.Resources.icons8_open_lock_24;
            this.buttonDesencriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesencriptar.Location = new System.Drawing.Point(0, 0);
            this.buttonDesencriptar.Name = "buttonDesencriptar";
            this.buttonDesencriptar.Size = new System.Drawing.Size(179, 28);
            this.buttonDesencriptar.TabIndex = 3;
            this.buttonDesencriptar.Text = "Desencriptar";
            this.buttonDesencriptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDesencriptar.UseVisualStyleBackColor = false;
            this.buttonDesencriptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGuardarArchivoClaro
            // 
            this.buttonGuardarArchivoClaro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGuardarArchivoClaro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGuardarArchivoClaro.FlatAppearance.BorderSize = 0;
            this.buttonGuardarArchivoClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarArchivoClaro.Image = global::FormularioED.Properties.Resources.icons8_guardar_30;
            this.buttonGuardarArchivoClaro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarArchivoClaro.Location = new System.Drawing.Point(0, 32);
            this.buttonGuardarArchivoClaro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardarArchivoClaro.Name = "buttonGuardarArchivoClaro";
            this.buttonGuardarArchivoClaro.Size = new System.Drawing.Size(179, 28);
            this.buttonGuardarArchivoClaro.TabIndex = 6;
            this.buttonGuardarArchivoClaro.Text = "Guardar archivo en claro";
            this.buttonGuardarArchivoClaro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarArchivoClaro.UseVisualStyleBackColor = false;
            this.buttonGuardarArchivoClaro.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.DimGray;
            this.buttonSalir.BackgroundColor = System.Drawing.Color.DimGray;
            this.buttonSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSalir.BorderRadius = 20;
            this.buttonSalir.BorderSize = 0;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Image = global::FormularioED.Properties.Resources.icons8_salida_30;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(56, 315);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(39, 40);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.TextColor = System.Drawing.Color.White;
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonDesencriptarMenu
            // 
            this.buttonDesencriptarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDesencriptarMenu.FlatAppearance.BorderSize = 0;
            this.buttonDesencriptarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesencriptarMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonDesencriptarMenu.Image = global::FormularioED.Properties.Resources.icons8_escudo_de_restricción_30;
            this.buttonDesencriptarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesencriptarMenu.Location = new System.Drawing.Point(0, 218);
            this.buttonDesencriptarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDesencriptarMenu.Name = "buttonDesencriptarMenu";
            this.buttonDesencriptarMenu.Size = new System.Drawing.Size(179, 24);
            this.buttonDesencriptarMenu.TabIndex = 5;
            this.buttonDesencriptarMenu.Text = "DESENCRIPTAR";
            this.buttonDesencriptarMenu.UseVisualStyleBackColor = true;
            this.buttonDesencriptarMenu.Click += new System.EventHandler(this.buttonDesencriptarMenu_Click);
            // 
            // panelSubMenuEncriptar
            // 
            this.panelSubMenuEncriptar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSubMenuEncriptar.Controls.Add(this.buttonEncriptar);
            this.panelSubMenuEncriptar.Controls.Add(this.buttonGuardarArchivoEncriptado);
            this.panelSubMenuEncriptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEncriptar.Location = new System.Drawing.Point(0, 156);
            this.panelSubMenuEncriptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubMenuEncriptar.Name = "panelSubMenuEncriptar";
            this.panelSubMenuEncriptar.Size = new System.Drawing.Size(179, 62);
            this.panelSubMenuEncriptar.TabIndex = 4;
            // 
            // buttonEncriptar
            // 
            this.buttonEncriptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEncriptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEncriptar.FlatAppearance.BorderSize = 0;
            this.buttonEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncriptar.Image = global::FormularioED.Properties.Resources.icons8_contraseña_30;
            this.buttonEncriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEncriptar.Location = new System.Drawing.Point(0, 0);
            this.buttonEncriptar.Name = "buttonEncriptar";
            this.buttonEncriptar.Size = new System.Drawing.Size(179, 28);
            this.buttonEncriptar.TabIndex = 2;
            this.buttonEncriptar.Text = "Encriptar";
            this.buttonEncriptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEncriptar.UseVisualStyleBackColor = false;
            this.buttonEncriptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardarArchivoEncriptado
            // 
            this.buttonGuardarArchivoEncriptado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGuardarArchivoEncriptado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGuardarArchivoEncriptado.FlatAppearance.BorderSize = 0;
            this.buttonGuardarArchivoEncriptado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarArchivoEncriptado.Image = global::FormularioED.Properties.Resources.icons8_guardar_30;
            this.buttonGuardarArchivoEncriptado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarArchivoEncriptado.Location = new System.Drawing.Point(0, 34);
            this.buttonGuardarArchivoEncriptado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardarArchivoEncriptado.Name = "buttonGuardarArchivoEncriptado";
            this.buttonGuardarArchivoEncriptado.Size = new System.Drawing.Size(179, 28);
            this.buttonGuardarArchivoEncriptado.TabIndex = 7;
            this.buttonGuardarArchivoEncriptado.Text = "Guardar archivo encriptado";
            this.buttonGuardarArchivoEncriptado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarArchivoEncriptado.UseVisualStyleBackColor = false;
            this.buttonGuardarArchivoEncriptado.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonEncriptarMenu
            // 
            this.buttonEncriptarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEncriptarMenu.FlatAppearance.BorderSize = 0;
            this.buttonEncriptarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncriptarMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonEncriptarMenu.Image = global::FormularioED.Properties.Resources.icons8_llave_30;
            this.buttonEncriptarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEncriptarMenu.Location = new System.Drawing.Point(0, 132);
            this.buttonEncriptarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEncriptarMenu.Name = "buttonEncriptarMenu";
            this.buttonEncriptarMenu.Size = new System.Drawing.Size(179, 24);
            this.buttonEncriptarMenu.TabIndex = 3;
            this.buttonEncriptarMenu.Text = "ENCRIPTAR";
            this.buttonEncriptarMenu.UseVisualStyleBackColor = true;
            this.buttonEncriptarMenu.Click += new System.EventHandler(this.buttonEncriptarMenu_Click);
            // 
            // panelArchivosSubMenu
            // 
            this.panelArchivosSubMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelArchivosSubMenu.Controls.Add(this.buttonAbrirArchivoEncriptado);
            this.panelArchivosSubMenu.Controls.Add(this.buttonAbrirArchivoClaro);
            this.panelArchivosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchivosSubMenu.Location = new System.Drawing.Point(0, 72);
            this.panelArchivosSubMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelArchivosSubMenu.Name = "panelArchivosSubMenu";
            this.panelArchivosSubMenu.Size = new System.Drawing.Size(179, 60);
            this.panelArchivosSubMenu.TabIndex = 2;
            // 
            // buttonAbrirArchivoEncriptado
            // 
            this.buttonAbrirArchivoEncriptado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAbrirArchivoEncriptado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAbrirArchivoEncriptado.FlatAppearance.BorderSize = 0;
            this.buttonAbrirArchivoEncriptado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirArchivoEncriptado.Image = global::FormularioED.Properties.Resources.icons8_archivo_asegurado_24;
            this.buttonAbrirArchivoEncriptado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirArchivoEncriptado.Location = new System.Drawing.Point(0, 32);
            this.buttonAbrirArchivoEncriptado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAbrirArchivoEncriptado.Name = "buttonAbrirArchivoEncriptado";
            this.buttonAbrirArchivoEncriptado.Size = new System.Drawing.Size(179, 28);
            this.buttonAbrirArchivoEncriptado.TabIndex = 1;
            this.buttonAbrirArchivoEncriptado.Text = "Abrir Archivo Encriptado";
            this.buttonAbrirArchivoEncriptado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirArchivoEncriptado.UseVisualStyleBackColor = false;
            this.buttonAbrirArchivoEncriptado.Click += new System.EventHandler(this.buttonAbrirArchivoEncriptado_Click);
            // 
            // buttonAbrirArchivoClaro
            // 
            this.buttonAbrirArchivoClaro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAbrirArchivoClaro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbrirArchivoClaro.FlatAppearance.BorderSize = 0;
            this.buttonAbrirArchivoClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirArchivoClaro.Image = global::FormularioED.Properties.Resources.addfileinterfacesymbolofpapersheetwithtextlinesandplussign_79821;
            this.buttonAbrirArchivoClaro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirArchivoClaro.Location = new System.Drawing.Point(0, 0);
            this.buttonAbrirArchivoClaro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAbrirArchivoClaro.Name = "buttonAbrirArchivoClaro";
            this.buttonAbrirArchivoClaro.Size = new System.Drawing.Size(179, 28);
            this.buttonAbrirArchivoClaro.TabIndex = 0;
            this.buttonAbrirArchivoClaro.Text = "Abrir Archivo en Claro";
            this.buttonAbrirArchivoClaro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirArchivoClaro.UseVisualStyleBackColor = false;
            this.buttonAbrirArchivoClaro.Click += new System.EventHandler(this.buttonAbrirArchivoClaro_Click);
            // 
            // buttonArchivos
            // 
            this.buttonArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonArchivos.FlatAppearance.BorderSize = 0;
            this.buttonArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchivos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonArchivos.Image = global::FormularioED.Properties.Resources.icons8_abrir_carpeta_301;
            this.buttonArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArchivos.Location = new System.Drawing.Point(0, 48);
            this.buttonArchivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonArchivos.Name = "buttonArchivos";
            this.buttonArchivos.Size = new System.Drawing.Size(179, 24);
            this.buttonArchivos.TabIndex = 1;
            this.buttonArchivos.Text = "Archivos";
            this.buttonArchivos.UseVisualStyleBackColor = true;
            this.buttonArchivos.Click += new System.EventHandler(this.buttonArchivos_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 48);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSubMenuDesencriptar.ResumeLayout(false);
            this.panelSubMenuEncriptar.ResumeLayout(false);
            this.panelArchivosSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEncriptar;
        private System.Windows.Forms.Button buttonDesencriptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonGuardarArchivoClaro;
        private System.Windows.Forms.Button buttonGuardarArchivoEncriptado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ButtonP buttonSalir;
        private System.Windows.Forms.Panel panelArchivosSubMenu;
        private System.Windows.Forms.Button buttonAbrirArchivoEncriptado;
        private System.Windows.Forms.Button buttonAbrirArchivoClaro;
        private System.Windows.Forms.Button buttonArchivos;
        private System.Windows.Forms.Panel panelSubMenuDesencriptar;
        private System.Windows.Forms.Button buttonDesencriptarMenu;
        private System.Windows.Forms.Panel panelSubMenuEncriptar;
        private System.Windows.Forms.Button buttonEncriptarMenu;
        private System.Windows.Forms.Panel panel3;
    }
}

