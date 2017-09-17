using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form

    {
        SData.SData data;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.ComponentModel.SyntaxCheck.CheckRootedPath(this.textBox1.Text))
            {
                MessageBox.Show("He правильно задан путь к файлу", "Ошибка"); return;
            }
            System.IO.FileInfo file_info = new System.IO.FileInfo(this.textBox1.Text); if (!file_info.Exists)
            {

                MessageBox.Show("Файл не существует", "Ошибка");
                return;
            }
            this.data = new SData.SData();
            this.data.LoadFromSPB(this.textBox1.Text);
            string message_text = String.Format("Файл {0} загружен.", this.textBox1.Text);
            MessageBox.Show(message_text, "Информация");
            this.textBox1.Text = message_text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Файлы СПБ (*.spb)|*.spb"; DialogResult res = this.openFileDialog1.ShowDialog(); if (res != System.Windows.Forms.DialogResult.Cancel)
                this.textBox1.Text = this.openFileDialog1.FileName;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Text = this.listBox1.Text + System.Environment.NewLine + listBox1;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (this.data == null)
            {
                MessageBox.Show("Heт загруженной базы!", "Ошибка");
                return;
            }

            this.listBox1.Items.Add("B базе присутствуют следующие БЭФ:");
            int local_count = 1;



            for (int i = 1; i < data.GetElemCount(); i++)
            {
                SData.i_Element current_element = data.GetElem(i);
                string element_type = current_element.type.ToString();

                if (element_type == "0")

                {
                    string element_name = current_element.name;
                    string element_kod = current_element.spec;
                    

                    string line = String.Format("{0}. {1} с кодом {2}", local_count, element_name, element_kod);
                    listBox1.Items.Add(line);



                    local_count++;


                }

                button5.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            DialogResult res = this.saveFileDialog1.ShowDialog(); if (res != System.Windows.Forms.DialogResult.Cancel)
            {
                System.IO.StreamWriter outp; outp =
                new System.IO.StreamWriter(this.saveFileDialog1.FileName, true, System.Text.Encoding.GetEncoding(1251));
                outp.Write(this.listBox1.Text); outp.Close();
                MessageBox.Show(String.Format("0T4eT сохранен в файл: {0}.", this.saveFileDialog1.FileName),
                 "Информация");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


     public int sum_cilindr = 0;
     public int sum_konus = 0;
     public int sum_rotate = 0;

        public void button5_Click(object sender, EventArgs e)
        {



            int local_count = 0;
            for (int i = 1; i < data.GetElemCount(); i++)
            {
                SData.i_Element current_element = data.GetElem(i);
                string element_type = current_element.type.ToString();

                if (element_type == "0")

                {
                    string element_name = current_element.name;
                    string element_kod = current_element.spec;
                    

                    if (element_kod == "cilindr")

                    {
                        sum_cilindr = sum_cilindr + 1;

                    }

                    if (element_kod == "konus")
                    {
                        sum_konus = sum_konus + 1;

                    }

                    if (element_kod == "rotate")
                    {
                        sum_rotate = sum_rotate + 1;
                    }

                    local_count++;

                }
            }
            textBox2.Text = Convert.ToString(sum_cilindr);
            textBox3.Text = Convert.ToString(sum_konus);
            textBox4.Text = Convert.ToString(sum_rotate);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

      