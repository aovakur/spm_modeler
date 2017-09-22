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
                MessageBox.Show("He правильно задан путь к файлу", "Ошибка");
                return;
            }
            System.IO.FileInfo file_info = new System.IO.FileInfo(this.textBox1.Text);

            if (!file_info.Exists)
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
            }

            checkBox1.Visible = true;


        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            DialogResult res = this.saveFileDialog1.ShowDialog();
            if (res != System.Windows.Forms.DialogResult.Cancel)
            {
                System.IO.StreamWriter outp; outp = new System.IO.StreamWriter(this.saveFileDialog1.FileName, true, System.Text.Encoding.GetEncoding(1251));
                outp.Write(this.listBox1.Text);
                outp.Close();
                MessageBox.Show(String.Format("0твет сохранен в файл: {0}.", this.saveFileDialog1.FileName), "Информация");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public int sum_cilindr = 0;
        public int sum_konus = 0;
        public int sum_rotate = 0;
        public int sum_paral = 0;
        public int sum_piramida = 0;
        public int sum_kub = 0;
        public int sum_priz6 = 0;
        public int sum_priz8 = 0;
        public int sum_sfera = 0;
        public int sum_plast4 = 0;
        public int sum_plast20 = 0;
        public int sum_shift = 0;
        public int sum_screw = 0;
        public int sum_solide = 0;
        public int local_count = 0;


        public void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;


            
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
                    if (element_kod == "paral")
                    {
                        sum_paral = sum_paral + 1;
                    }
                    if (element_kod == "piramida")
                    {
                        sum_piramida = sum_piramida + 1;
                    }
                    if (element_kod == "kub")
                    {
                        sum_kub = sum_kub + 1;
                    }
                    if (element_kod == "priz6")
                    {
                        sum_priz6 = sum_priz6 + 1;
                    }
                    if (element_kod == "priz8")
                    {
                        sum_priz8 = sum_priz8 + 1;
                    }
                    if (element_kod == "plast20")
                    {
                        sum_plast20 = sum_plast20 + 1;
                    }
                    if (element_kod == "plast4")
                    {
                        sum_plast4 = sum_plast4 + 1;
                    }
                    if (element_kod == "plast20")
                    {
                        sum_plast20 = sum_plast20 + 1;
                    }

                    if (element_kod == "sfera")
                    {
                        sum_sfera = sum_sfera + 1;
                    }

                    if (element_kod == "shift")
                    {
                        sum_shift = sum_shift + 1;
                    }
                    if (element_kod == "screw")
                    {
                        sum_screw = sum_screw + 1;
                    }
                    if (element_kod == "solide")
                    {
                        sum_solide = sum_solide + 1;
                    }

                    local_count++;
                }

                textBox2.Text = Convert.ToString(sum_cilindr);
                textBox3.Text = Convert.ToString(sum_konus);
                textBox4.Text = Convert.ToString(sum_rotate);
                textBox5.Text = Convert.ToString(sum_paral);
                textBox6.Text = Convert.ToString(sum_piramida);
                textBox7.Text = Convert.ToString(sum_plast20);
                textBox8.Text = Convert.ToString(sum_kub);
                textBox9.Text = Convert.ToString(sum_priz6);
                textBox10.Text = Convert.ToString(sum_priz8);
                textBox11.Text = Convert.ToString(sum_sfera);
                textBox12.Text = Convert.ToString(sum_plast4);
                textBox13.Text = Convert.ToString(sum_shift);
                textBox14.Text = Convert.ToString(sum_screw);
                textBox15.Text = Convert.ToString(sum_solide);
                textBox16.Text = Convert.ToString(local_count);
                textBox16.Visible = true;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button5.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;

            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;
            checkBox13.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = true;


            if (checkBox1.Checked == false)
            {
                button5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox6.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox9.Visible = false;
                textBox8.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;

                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                checkBox11.Visible = false;
                checkBox12.Visible = false;
                checkBox13.Visible = false;
                checkBox14.Visible = false;
                checkBox15.Visible = false;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            if (checkBox2.Checked == false)
            {
                textBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            if (checkBox3.Checked == false)
            {
                textBox3.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            if (checkBox4.Checked == false)
            {
                textBox5.Visible = false;
            }

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            if (checkBox5.Checked == false)
            {
                textBox6.Visible = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            if (checkBox6.Checked == false)
            {
                textBox8.Visible = false;
            }

        }
       

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Visible = true;
            if (checkBox9.Checked == false)
            {
                textBox11.Visible = false;
            }


        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Visible = true;
            if (checkBox10.Checked == false)
            {
                textBox12.Visible = false;
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            if (checkBox11.Checked == false)
            {
                textBox7.Visible = false;
            }


        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.Visible = true;
            if (checkBox12.Checked == false)
            {
                textBox13.Visible = false;
            }

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            textBox14.Visible = true;
            if (checkBox13.Checked == false)
            {
                textBox14.Visible = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Visible = true;
            if (checkBox14.Checked == false)
            {
                textBox15.Visible = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            if (checkBox15.Checked == false)
            {
                textBox4.Visible = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Visible = true;
            if (checkBox7.Checked == false)
            {
                textBox9.Visible = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            if (checkBox8.Checked == false)
            {
                textBox10.Visible = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
