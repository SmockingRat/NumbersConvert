using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GetNum;
        public string Result;


        private void ButtonForConvert_Click(object sender, EventArgs e)
        {
            GetNum = Convert.ToInt32(NumFoConv.Text);
            if (GetNum < 0)
            {
                Result += "минус ";
                GetNum *= -1;
            }
            int[] ChargeArray = new int [2];
            ChargeArray[0]= (GetNum - (GetNum % 1000))/1000;
            ChargeArray[1]= GetNum % 1000;
            for (int i = 0; i < 2; i++)
            {
                if (GetNum == 0)
                {
                    Result += "ноль";
                    i = 1;
                }

                if (((ChargeArray[i] - ChargeArray[i] % 100) / 100) != 0)
                {
                    
                    switch ((ChargeArray[i] - ChargeArray[i] % 100) / 100)
                    {
                        case 1: 
                            Result += "сто "; 
                            break;
                        
                        case 2: 
                            Result += "двести "; 
                            break;
                        
                        case 3: 
                            Result += "триста "; 
                            break;
                        
                        case 4: 
                            Result += "четыреста "; 
                            break;
                        
                        case 5: 
                            Result += "пятьсот "; 
                            break;
                        
                        case 6: 
                            Result += "шестьсот "; 
                            break;
                        
                        case 7: 
                            Result += "семьсот "; 
                            break;
                        
                        case 8: 
                            Result += "восемьсот "; 
                            break;
                        
                        case 9: 
                            Result += "девятьсот "; 
                            break;

                    }

                }

                if ((((ChargeArray[i] % 100) - ((ChargeArray[i] % 100) % 10)) / 10) != 1)
                {
                    switch ((((ChargeArray[i] % 100) - ((ChargeArray[i] % 100)) % 10) / 10))
                    {
                        case 2:
                            Result += "двадцать ";
                            break;

                        case 3:
                            Result += "тридцать ";
                            break;

                        case 4:
                            Result += "сорок ";
                            break;

                        case 5:
                            Result += "пятьдесят ";
                            break;

                        case 6:
                            Result += "шестьдесят ";
                            break;

                        case 7:
                            Result += "семьдесят ";
                            break;

                        case 8:
                            Result += "восемьдесят ";
                            break;

                        case 9:
                            Result += "девяносто ";
                            break;


                    }

                    switch (((ChargeArray[i] % 100) % 10))
                    {
                        case 1:
                            if (i == 0)
                            {
                                Result += "одна ";
                            }
                            else
                            {
                                Result += "один ";
                            }
                            break;

                        case 2:
                            if (i == 0)
                            {
                                Result += "две ";
                            }
                            else
                            {
                                Result += "два ";
                            }
                            break;

                        case 3:
                            Result += "три ";
                            break;

                        case 4:
                            Result += "четыре ";
                            break;

                        case 5:
                            Result += "пять ";
                            break;

                        case 6:
                            Result += "шесть ";
                            break;

                        case 7:
                            Result += "семь ";
                            break;

                        case 8:
                            Result += "восемь ";
                            break;

                        case 9:
                            Result += "девять ";
                            break;
                    }

                    if (i == 0)
                    {
                        switch (((ChargeArray[i] % 100) % 10))
                        {
                            case 1:
                                Result += "тысяча ";
                                break;

                            case 2:
                                Result += "тысячи ";
                                break;

                            case 3:
                                Result += "тысячи ";
                                break;

                            case 4:
                                Result += "тысячи ";
                                break;

                            case 5:
                                Result += "тысяч ";
                                break;

                            case 6:
                                Result += "тысяч ";
                                break;

                            case 7:
                                Result += "тысяч ";
                                break;

                            case 8:
                                Result += "тысяч ";
                                break;

                            case 9:
                                Result += "тысяч ";
                                break;
                        }
                    }



                }
                else
                {
                    switch (((ChargeArray[i] % 100) % 10))
                    {
                        case 0:
                            Result += "десять ";
                            break;

                        case 1:
                            Result += "одиннадцать ";
                            break;

                        case 2:
                            Result += "двенадцать ";
                            break;

                        case 3:
                            Result += "тринадцать ";
                            break;

                        case 4:
                            Result += "четырнадцать ";
                            break;

                        case 5:
                            Result += "пятнадцать ";
                            break;

                        case 6:
                            Result += "шестнадцать ";
                            break;

                        case 7:
                            Result += "семнадцать ";
                            break;

                        case 8:
                            Result += "восемнадцать ";
                            break;

                        case 9:
                            Result += "девятнадцать ";
                            break; 
                    }
                    if(i == 0)
                    {
                        Result += "тысяч ";
                    }

                }
               
            }
            LabelForResult.Text = " ";
            LabelForResult.Text = Result;
            Result = ""; 


        }

        private void NumFoConv_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumFoConv_Click(object sender, EventArgs e)
        {
            NumFoConv.Text = "";
        }
    }
}
