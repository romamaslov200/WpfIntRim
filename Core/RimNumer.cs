using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfIntRim.Core
{
    internal class RimNumer
    {
        ProverkaType proverkatype = new ProverkaType();

        string[] RimNumber = { 
            "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "XI", "X",
            "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX",
            "XXI", "XXII", "XXIII", "XXIV", "XXV", "XXVI", "XXVII", "XXVIII", "XXIX", "XXX"};

        public void IntRim(System.Windows.Controls.Label LabelRim, TextBox InputTextBox)
        {
            int i;

            if(int.TryParse(InputTextBox.Text, out i) && i > 0 && i <= 30)
            {
                LabelRim.Content = RimNumber[i - 1];
            }
            else
            {
                LabelRim.Content = "Введите число от 1 до 30";
            }


            //proverkatype.Type<int>("Введите число от 1 до 10", InputTextBox, LabelRim);
            //LabelRim.Content = RimNumber[proverkatype.Type<int>("Введите число от 1 до 10", InputTextBox, LabelRim) + -1];
        }
    }
}
    