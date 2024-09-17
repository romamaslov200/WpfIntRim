using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfIntRim.Core
{
    internal class ProverkaType
    {
        public T Type<T>(string s, TextBox textBox, Label label) where T : struct
        {
            while (true)
            {
                label.Content = s;
                //var input = Console.ReadLine();
                if (ConvertType<T>(textBox.Text.Replace(".", ","), out var result))
                {
                    return result;
                }
                else
                {

                }
            }
        }


        private bool ConvertType<T>(string input, out T result) where T : struct
        {
            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}
