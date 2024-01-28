using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        long wynikoLiczba = 0;
        long operacyjnaLiczba = 0;
        bool first_number = false;
        bool check = false;
        bool clear = false;
        bool equals_1 = false;
        bool equals_2 = false;
        bool equals_clicked = false;
        string send;
        string reminder;
        string operation_changer;
        public MainWindow()
        {
            InitializeComponent();
        }

        // ----- NUMBERS ------ //
        private void L1_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "1";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "1");
            check = false;
            equals_1 = true;
        }

        private void L2_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "2";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "2");
            check = false;
            equals_1 = true;
        }

        private void L3_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "3";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "3");
            check = false;
            equals_1 = true;
        }

        private void L4_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "4";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "4");
            check = false;
            equals_1 = true;
        }

        private void L5_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "5";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "5");
            check = false;
            equals_1 = true;
        }

        private void L6_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "6";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "6");
            check = false; 
            equals_1 = true;
        }

        private void L7_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "7";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "7");
            check = false;
            equals_1 = true;
        }

        private void L8_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "8";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "8");
            check = false;
            equals_1 = true;
        }

        private void L9_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "9";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "9");
            check = false;
            equals_1 = true;
        }

        private void L0_Click(object sender, RoutedEventArgs e)
        {
            if ((clear == true) || (Result.Text == "0"))
            {
                Result.Text = "0";
                clear = false;
            }
            else
                Result.Text = (Result.Text + "0");
            check = false;
            equals_1 = true;
        }
        // ----- DZIAŁACZ ----- //
        private void Action_Man()
        {
            operacyjnaLiczba = Convert.ToInt64(Result.Text);
           //Memory.Text += operacyjnaLiczba;
            if (reminder == "div")
            {
                Result.Text = Convert.ToString(wynikoLiczba / operacyjnaLiczba);
                reminder = send;
            }
            else if (reminder == "mul")
            {
                Result.Text = Convert.ToString(wynikoLiczba * operacyjnaLiczba);
                reminder = send;
            }
            else if (reminder == "sub")
            {
                Result.Text = Convert.ToString(wynikoLiczba - operacyjnaLiczba);
                reminder = send;
            }
            else if (reminder == "add" )
            {
                Result.Text = Convert.ToString(wynikoLiczba + operacyjnaLiczba);
                reminder = send;
            }
            wynikoLiczba = Convert.ToInt64(Result.Text);
            operacyjnaLiczba = 0;
        }

        // ----- DZIELENIE ----- //
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            equals_2 = true;
            if (Result.Text == "0")
            { }
            else if(check == false)
            {
                if (Memory.Text == "")
                    Memory.Text = "";//Result.Text;

                // Clear for smooth numbers displaying
                clear = true;

                // -- Divide functioning -- //
                if ((first_number == false) || (equals_clicked = true))
                {
                    // Check for first number tag
                    first_number = true;
                    wynikoLiczba = Convert.ToInt64(Result.Text);
                    // "Divide was clicked" reminder
                    reminder = "div";
                    check = true;
                    equals_clicked = false;
                }
                else
                {
                    if (reminder == "")
                        reminder = "div";
                    send = "div";
                    Action_Man();
                    check = true;
                }
               /*operation_changer = Memory.Text.Substring(Memory.Text.Length - 1);
                if ((operation_changer == "+") || (operation_changer == "*") || (operation_changer == "-"))
                    Memory.Text = Memory.Text.Substring(0, Memory.Text.Length - 1) + "/";
                else
                    Memory.Text += "/";*/
            }
        }
        // ----- MNOZENIE ----- //
        private void Times_Click(object sender, RoutedEventArgs e)
        {
            equals_2 = true;
            if (check == false)
            {

                if (Memory.Text == "")
                    Memory.Text = "";//Result.Text;

                // Clear for smooth numbers displaying
                clear = true;

                // -- Multiplication functioning -- //
                if ((first_number == false) || (equals_clicked = true))
                {
                    // Check for first number tag
                    first_number = true;
                    wynikoLiczba = Convert.ToInt64(Result.Text);
                    // "Times was clicked" reminder
                    reminder = "mul";
                    check = true;
                    equals_clicked = false;
                }
                else
                {
                    if (reminder == "")
                        reminder = "mul";
                    send = "mul";
                    Action_Man();
                    check = true;
                }
               /* operation_changer = Memory.Text.Substring(Memory.Text.Length - 1);
                if ((operation_changer == "/") || (operation_changer == "+") || (operation_changer == "-"))
                    Memory.Text = Memory.Text.Substring(0, Memory.Text.Length - 1) + "*";
                else
                    Memory.Text += "*";*/
            }
        }
        // ----- ODEJMOWANIE ----- //
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            equals_2 = true;
            if (check == false)
            {
                // Memory text filler
                if (Memory.Text == "")
                    Memory.Text = "";// Result.Text;

                // Clear for smooth numbers displaying
                clear = true;

                // -- Minus functioning -- //
                if ((first_number == false) || (equals_clicked = true))
                {
                    // Check for first number tag
                    first_number = true;
                    wynikoLiczba = Convert.ToInt64(Result.Text);
                    // "Minus was clicked" reminder
                    reminder = "sub";
                    check = true;
                    equals_clicked = false;
                }
                else
                {
                    if (reminder == "")
                        reminder = "sub";
                    send = "sub";
                    Action_Man();
                    check = true;
                }
                /*operation_changer = Memory.Text.Substring(Memory.Text.Length - 1);
                if ((operation_changer == "/") || (operation_changer == "*") || (operation_changer == "+"))
                    Memory.Text = Memory.Text.Substring(0, Memory.Text.Length - 1) + "-";
                else
                    Memory.Text += "-";*/
            }
        }

        // ----- DODAWANIE ----- //
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            equals_2 = true;
            if (check == false)
            {

                if (Memory.Text == "")
                    Memory.Text = "";//Result.Text;

                // Clear for smooth numbers displaying
                clear = true;

                // -- Plus functioning -- //
                if ((first_number == false) || (equals_clicked = true))
                {
                    // Check for first number tag
                    first_number = true;
                    wynikoLiczba = Convert.ToInt64(Result.Text);
                    // "Plus was clicked" reminder
                    reminder = "add";
                    check = true;
                    equals_clicked = false;
                }
                else
                {
                    if (reminder == "")
                        reminder = "add";
                    send = "add";
                    Action_Man();
                    check = true;

                }
                
               /* operation_changer = Memory.Text.Substring(Memory.Text.Length - 1);
                if ((operation_changer == "/") || (operation_changer == "*") || (operation_changer == "-"))
                    Memory.Text = Memory.Text.Substring(0, Memory.Text.Length - 1) + "+";
                else
                    Memory.Text += "+";*/
            }
        }
        // ----- ROWNA SIE ----- //
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if ((equals_1 == true) && (equals_2 == true))
            {
                Action_Man();
                reminder = "";
                equals_clicked = true;
            }
        }
        // ----- KASUJ ----- //
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text.Substring(0, Result.Text.Length - 1);
            if (Result.Text == "")
                Result.Text = "0";
        }
        // ----- RESET ----- //
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            wynikoLiczba = 0;
            operacyjnaLiczba = 0;
            first_number = false;
            check = false;
            clear = false;
            equals_1 = false;
            equals_2 = false;
            send = "";
            reminder = "";
            Result.Text = "0";
            Memory.Text = "";
        }
        // ----- CLEAR ----- //
        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
        }
    }
}
