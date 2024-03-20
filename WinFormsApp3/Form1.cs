using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        // Создание стартового аккаунта администратора


        public Form1()
        {
            InitializeComponent();

            Worker adm = new Worker();
            adm.name = "Иванов И.И.";
            adm.prof = "administrator";
            adm.status = "Действующий";
            adm.smena = "Первая";
            adm.login = "ivadm";
            adm.password = "ivadmpassword";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text = adm.login)
            {

            }
            if (textBox2.Text = adm.password)
            {

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public class Worker
        {
            public string name = "";
            public string prof = "Undefined";
            public string status = "Undefined";
            public string smena = "Undefined";
            public string login = "unknown";
            public string password = "unknown";
        }
    }
}
