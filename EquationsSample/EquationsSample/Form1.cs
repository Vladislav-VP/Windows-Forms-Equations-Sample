using System;
using System.Windows.Forms;

namespace EquationsSample
{
    public partial class Form1 : Form
    {
        private Equation _equation;

        private bool _isInputValid;

        public Form1()
        {
            InitializeComponent();
        }

        private void btEvaluate_Click(object sender, EventArgs e)
        {
            ReadEquationDataInput();

            if (_isInputValid)
            {
                OutputSolution();
            }            
        }

        private void ReadEquationDataInput()
        {
            _isInputValid = false;

            double a = (double)nudA.Value;
            double b = (double)nudB.Value;
            double accuracy = (double)nudAccuracy.Value;

            if (a >= b)
            {
                MessageBox.Show("A can not be greater or equal B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _isInputValid = true;
            _equation = new Equation((double)nudA.Value, (double)nudB.Value, (double)nudAccuracy.Value);
        }

        private void OutputSolution()
        {
            lbResult.Text = $"X = {_equation.GetSolution()}";
        }
    }
}
