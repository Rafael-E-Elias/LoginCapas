using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
           
            UserModel Usuario = new UserModel();
            //var ValidLogin = Usuario.Log(textuser.Text, textpass.Text);
            if (Usuario.Log(textuser.Text, textpass.Text) == true)
            {
                MessageBox.Show("usuario y contraseña correctos");

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
                textpass.Clear();
                textuser.Focus();
            }
        }
    }
}
