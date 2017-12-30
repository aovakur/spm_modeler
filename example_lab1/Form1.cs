using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace example_lab1
{
    public partial class Form1 : Form
    {
        SData.SData data;
        public int z, b, c;
        public string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButSearchSPB_Click(object sender, EventArgs e)
        {
            this.DialogOpenFile.Filter = "Структурно-параметрическая база|*.spb";
            DialogResult res = this.DialogOpenFile.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                this.TextBoxSPBFilePath.Text = this.DialogOpenFile.FileName;
            }
        }

        private void ButLoadSData_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();

            if (!System.ComponentModel.SyntaxCheck.CheckRootedPath(this.TextBoxSPBFilePath.Text))
            {
                MessageBox.Show("Не правильный путь до файла", "Ошибка");
                return;
            }

            System.IO.FileInfo fi = new System.IO.FileInfo(this.TextBoxSPBFilePath.Text);
            if (!fi.Exists)
            {
                MessageBox.Show("Файл не существует", "Ошибка");
                return;
            }

            this.data = new SData.SData();
            this.data.LoadFromSPB(this.TextBoxSPBFilePath.Text);

            string message_text = String.Format("Файл {0} загружен!", this.TextBoxSPBFilePath.Text);
            MessageBox.Show(message_text);

            AddTextToReport(message_text);
        }

        private void AddTextToReport(string text)
        {
            this.listBox.Items.Add(text);
        }

        private void ButMakeReport_Click(object sender, EventArgs e)
        {
            if (this.data == null)
            {
                MessageBox.Show("Данные не загружены!");
                return;
            }

            this.AddTextToReport("В базе присутствуют следующие БЭФ:");

            int local_count = 1;
            for (int i = 1; i < data.GetElemCount(); i++)
            {
                SData.i_Element current_element = data.GetElem(i);

                string current_type = current_element.type.ToString();

                if (true)
                {
                    int element_id = current_element.id;
                    string element_name = current_element.name;
                    string element_kod = current_element.spec;
                    string line = string.Format("{0}. {1} с кодом {2}", local_count, element_name, element_kod);
                    CustomItem item = new CustomItem();
                    item.Name = element_name;
                    item.Code = element_kod;
                    item.ID = element_id;
                    item.IDLocal = local_count;

                    this.listBox.Items.Add(item);
                    
                    local_count++;
                }
            }
        }
       private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_info.Text = string.Empty;
           
            if (this.listBox.SelectedItem is CustomItem)
            {
                CustomItem item = (CustomItem)this.listBox.SelectedItem;

                SData.i_Element cur_elem = data.GetElem(item.ID);

                this.textBox_info.Text += "---Параметры:" + System.Environment.NewLine;
                List<SData.i_Parameter> pars = data.GetPars(cur_elem.id);
                for (int i = 0; i < pars.Count; i++)
                {

                    try
                    {
                        
                        {
                            for (int j = i+1; j < pars.Count; j++)
                            {

                               

                                if (Convert.ToDouble(pars[i].value_smart) > Convert.ToDouble(pars[j].value_smart))
                                {

                                    temp = pars[i].value_smart;
                                    pars[i].value_smart = pars[j].value_smart;
                                    pars[j].value_smart = temp;
                                    
                                }

                                this.textBox_info.Text += pars[i].name + "=" + pars[i].value_smart + System.Environment.NewLine;
                            }
                        }

                    }
                    catch 
                    {
                        Console.WriteLine("Преобразование строки в число не удалось");
                    }                         
                }
            }
        }
    }
}
