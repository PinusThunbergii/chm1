using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        double x0, dx, dot4, dot5, secondDerivative;
        double[] x_array, y_array;
        delegate double Function(double x);
        static double function(double x)
        {
            return 3.0d * Math.Pow(x, 2.0d) + Math.Pow(Math.Cos(x), 2.0d);
        }

        static void CalcTable(double x, double dx, out double[] x_array, out double[] y_array)
        {
            x_array = new double[5];
            y_array = new double[5];
            for (int i = 0; i < 5; i++)
            {
                x_array[i] = x;
                y_array[i] = function(x);
                Console.WriteLine($"x{i} = {x_array[i]} y{i} = {y_array[i]}");
                x += dx;
            }
        }

        static double fourDots(double[] y_array, double dx)
        {
            return (-11.0d * y_array[0] + 18.0d * y_array[1] - 9 * y_array[2] + 2 * y_array[3]) / (6.0d * dx);
        }

        static double fiveDots(double[] y_array, double dx)
        {
            return (-25.0d * y_array[0] + 48.0d * y_array[1] - 36.0d * y_array[2] + 16.0d * y_array[3] - 3.0d * y_array[4]) / (12.0d * dx);
        }

        static double secondDerive(double x0, double dx, Function function)
        {
            return (function(x0 + dx) - function(x0) + function(x0 - dx)) / Math.Pow(dx, 2.0d);
        }

        void calculateButtonHandler(object sender, EventArgs eventArgs)
        {
            try
            {
                if (!Double.TryParse(x0TextBox.Text, out x0) || !Double.TryParse(dXTextBox.Text, out dx))
                    throw new Exception("Input error");
                CalcTable(x0, dx, out x_array, out y_array);
                dot4 = fourDots(y_array, dx);
                dot5 = fiveDots(y_array, dx);
                secondDerivative = secondDerive(x0, dx, function);
                dot4ResultTextbox.Text = dot4.ToString();
                dot5ResultTextBox.Text = dot5.ToString();
                secondDeriveResultTextBox.Text = secondDerivative.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void compareButtonHandler(object sender, EventArgs eventArgs)
        {
            double toCompare;
            try
            {
                if (!Double.TryParse(toCompareTextBox.Text, out toCompare))
                    throw new Exception("Input error");
                diffTextBox.Text = $"5: {dot5 - toCompare} 4: {dot4 - toCompare}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
