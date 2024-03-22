using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno();
            MessageBox.Show(alumno1.ToString());

            Alumno alumno2 = new Alumno("Que", "so");
            MessageBox.Show(alumno2.ToString());

            Alumno alumno3 = new Alumno("Que", "so", true, "josefina", "privado", "no@thanks.com", "nose", "123123123");
            MessageBox.Show(alumno3.ToString());
        }
    }
}