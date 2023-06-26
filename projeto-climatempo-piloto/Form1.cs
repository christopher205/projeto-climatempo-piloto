using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_climatempo_piloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BuscaDadosNaApi("minhaapi.com/dados");
        }
        
        private void BuscaDadosNaApi(string url)
        {
            WebRequest request =  WebRequest.Create(url);
            
            using (WebResponse response = request.GetResponse()) 
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseText = reader.ReadToEnd();

                    
                    textBox2.Text = responseText;
                }
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
