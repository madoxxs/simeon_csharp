using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
       
        static void Main()
    {
        string izraz = Console.ReadLine();
        bool result = IsExpressionCorrect(izraz);

        Console.WriteLine(result);
    }

    static bool IsExpressionCorrect(string izraz)
    {
        int broqchNaSkobi = 0;
        for (int i = 0; i < izraz.Length; i++)
        {
            if (izraz[i] == '(')
            {
                broqchNaSkobi++;
            }
            else if (izraz[i] == ')')
            {
                broqchNaSkobi--;
            }
            if (broqchNaSkobi < 0)
            {
                break;
            }
        }
        if (broqchNaSkobi == 0)
        {
            return true;
        }
        else
        {
            return false;
        }


        }
    }
}
