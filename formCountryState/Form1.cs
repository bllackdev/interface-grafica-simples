using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCountryState
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<User> listUser = new List<User>(); 

        //botão de adicionar
        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.country = textBox1.Text;
            user1.state = textBox2.Text;
            user1.genderM = radioButton1.Checked;
            user1.genderF = radioButton2.Checked;
            user1.postalMail = checkBox1.Checked;
            user1.email = checkBox2.Checked;

            //limpa as informações na tela
            textBox1.Clear();
            textBox2.Clear();
            
        }

        //botão de remover Country
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //botão de remover State
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        //botão de exibir mensagem
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Mr (s), we will contact you by Post Mail and / or Emial.");
        }

        //campo texto Country
        private void textBox1_country(object sender, EventArgs e)
        {
            
        }

        //campo texto State
        private void textBox2_state(object sender, EventArgs e)
        {

        }

        //Lista de Country
        private void listBox1_Changed(object sender, EventArgs e)
        {
            //exibe item da lista no campo de texto
            textBox1.Text = listBox1.SelectedItem.ToString(); 
        }

        //Lista de State
        private void comboBox1_Changed(object sender, EventArgs e)
        {
            //exibe item da lista no campo de texto
            textBox2.Text = comboBox1.SelectedItem.ToString();
        }
    }

    //Classe para receber as informações
    public class User
    {
        public String country;
        public String state;
        public Boolean postalMail;
        public Boolean email;
        public Boolean genderM;
        public Boolean genderF;

    }
}
