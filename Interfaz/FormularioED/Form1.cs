using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using TemasDasnet;

namespace FormularioED
{
    public partial class Form1 : Form
    {
        private string encryptedFile = null;
        private string decryptedFile = null;
        private string inputFile;
        //byte[] keyPath = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["keyByte"]);
        string keyPath = ConfigurationManager.AppSettings["key"];
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog grabar = new SaveFileDialog();
            grabar.Filter = "Archivo texto|*.txt";

            if (grabar.ShowDialog() == DialogResult.OK) 
            {
                using (StreamWriter escribir = new StreamWriter(grabar.FileName))
                {
                    escribir.Write(this.textBox1.Text);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo texto|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader leer = new StreamReader(abrir.FileName)) 
                {
                    this.inputFile = leer.ReadToEnd();
                    this.textBox1.Text = this.inputFile;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.encryptedFile =Algotritmo.encriptador(inputFile, keyPath);
            this.textBox2.Text = this.encryptedFile;

            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.decryptedFile = Algotritmo.encriptador(encryptedFile, keyPath);
            this.textBox1.Text = this.decryptedFile;

            hideSubMenu();
        }

        private void abrirArchivoEncriptadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo texto|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader leer = new StreamReader(abrir.FileName))
                {
                    this.encryptedFile = leer.ReadToEnd();
                    this.textBox2.Text = this.encryptedFile;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(decryptedFile != null)
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_desencriptado.txt", decryptedFile);
                MessageBox.Show("Archivo desencriptado almacenado correctamente", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("No se ha desencriptado ningun archivo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (encryptedFile != null)
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo_encriptado.txt", encryptedFile);
                MessageBox.Show("Archivo encriptado almacenado correctamente", "Archivo Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha encriptado ningun archivo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            hideSubMenu(); 
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            TemaColores.ElegirTema("Dark");
            panel1.BackColor = TemaColores.PanelPadre;
            panel2.BackColor = TemaColores.PanelBotones;
            textBox1.BackColor = TemaColores.TextBusqueda;
            textBox2.BackColor = TemaColores.TextBusqueda;
        }

        private void customizeDesing()
        {
            panelArchivosSubMenu.Visible = false;
            panelSubMenuEncriptar.Visible = false;
            panelSubMenuDesencriptar.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelArchivosSubMenu.Visible == true)
                panelArchivosSubMenu.Visible = false;
            if (panelSubMenuEncriptar.Visible == true)
                panelSubMenuEncriptar.Visible = false;
            if (panelSubMenuDesencriptar.Visible == true)
                panelSubMenuDesencriptar.Visible = false;
        }

        private void showSubMenu(Panel subMenu) 
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonArchivos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelArchivosSubMenu);
        }

        private void buttonAbrirArchivoClaro_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo texto|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader leer = new StreamReader(abrir.FileName))
                {
                    this.inputFile = leer.ReadToEnd();
                    this.textBox1.Text = this.inputFile;
                }
            }

            hideSubMenu();
        }

        private void buttonAbrirArchivoEncriptado_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo texto|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader leer = new StreamReader(abrir.FileName))
                {
                    this.encryptedFile = leer.ReadToEnd();
                    this.textBox2.Text = this.encryptedFile;
                }
            }

            hideSubMenu();
        }

        private void buttonEncriptarMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEncriptar);
        }

        private void buttonDesencriptarMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuDesencriptar);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
