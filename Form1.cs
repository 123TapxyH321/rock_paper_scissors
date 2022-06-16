using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    
    public partial class Form1 : Form
    {
        string[] MyList;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyList = new string[]
            {
                "Камень",
                "Ножницы",
                "Бумага"
            };
            for(int i = 0; i < MyList.Length; i++) { comBox_List.Items.Add(MyList[i]); }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            listBox_Rezal.Items.Clear();
            string str1 = comBox_List.Text;
            string str2=MyList[new Random().Next(0,3)];
            
            listBox_Rezal.Items.Add(str1 + " vs " + str2);
            if (str1 == str2) { listBox_Rezal.Items.Add("---Ничья---"); }
            else 
            {
                switch (str1) 
                {
                    case "Камень":
                        if (str2 == "Ножницы") 
                        { listBox_Rezal.Items.Add("---Победа---");}
                        else 
                            listBox_Rezal.Items.Add("---Проиграл---");
                        break;
                    case "Ножницы":
                        if (str2 == "Бумага")
                        { listBox_Rezal.Items.Add("---Победа---"); }
                        else
                            listBox_Rezal.Items.Add("---Проиграл---");
                        break;
                    case "Бумага":
                        if (str2 == "Камень")
                        { listBox_Rezal.Items.Add("---Победа---"); }
                        else
                            listBox_Rezal.Items.Add("---Проиграл---");
                        break;
                }
                    
            }
           
        }
    }
}
