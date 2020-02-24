using Cliente_Api_Rest.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Cliente_Api_Rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var blankContextMenu = new ContextMenuStrip();
            textBoxUsuario_Id.ContextMenuStrip = blankContextMenu;
            textBoxUsuario_idA.ContextMenuStrip = blankContextMenu;
            textBoxEliminar.ContextMenuStrip = blankContextMenu;
            this.textBoxUsuario_idA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_idA_KeyPress);
            this.textBoxUsuario_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_Id_KeyPress);
            this.textBoxEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEliminar_KeyPress);
        }

        private void textBoxUsuario_idA_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // Remover el caracter
            }            
        }

        private void textBoxUsuario_Id_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // Remover el caracter
            }
        }

        private void textBoxEliminar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true; // Remover el caracter
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxNombres.Text)) || (string.IsNullOrEmpty(textBoxApellidos.Text)))
            {
                MessageBox.Show("Por favor ingresar toda la informacion", "Consumo API Rest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.usuario_id = 0;
                usuario.nombres = textBoxNombres.Text;
                usuario.apellidos = textBoxApellidos.Text;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@"https://localhost:44349/api/usuario");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(usuario);
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    labelRespuesta.Text = streamReader.ReadToEnd();
                }

            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxUsuario_idA.Text)) || (string.IsNullOrEmpty(textBoxNombresA.Text)) || (string.IsNullOrEmpty(textBoxApellidosA.Text)))
            {
                MessageBox.Show("Por favor ingresar toda la informacion", "Consumo API Rest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.usuario_id = Convert.ToInt32(textBoxUsuario_idA.Text);
                usuario.nombres = textBoxNombresA.Text;
                usuario.apellidos = textBoxApellidosA.Text;
                string miurl = "https://localhost:44349/api/usuario/" + textBoxUsuario_idA.Text;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@miurl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(usuario);
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    labelRespuesta.Text = streamReader.ReadToEnd();
                }
            }
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario_Id.Text))
            {
                MessageBox.Show("Por favor ingresar Usuario_id", "Consumo API Rest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario usuario;
                string miurl = "https://localhost:44349/api/usuario/" + textBoxUsuario_Id.Text;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@miurl);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    usuario = JsonConvert.DeserializeObject<Usuario>(json);
                }
                labelNombres.Text = "Nombres: " + usuario.nombres;
                labelApellidos.Text = "Apellidos: " + usuario.apellidos;
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEliminar.Text))
            {
                MessageBox.Show("Por favor ingresar Usuario_id", "Consumo API Rest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string miurl = "https://localhost:44349/api/usuario/" + textBoxEliminar.Text;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(@miurl);
                httpWebRequest.Method = "DELETE";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    labelRespuesta.Text = streamReader.ReadToEnd();
                }
            }
        }

        private void button_ConsultarTodo_Click(object sender, EventArgs e)
        {
            List<Usuario> arlListado = new List<Usuario>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://localhost:44349/api/usuario");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                arlListado = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < arlListado.Count; i++)
            {
                listBox1.Items.Add(arlListado[i].usuario_id+" - "+ arlListado[i].nombres + " " + arlListado[i].apellidos);
            }
        }

        
    }
}