using System;
using System.Windows.Forms;

namespace EquationsSample
{
    public partial class Form1 : Form
    {
        private Equation _equation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btEvaluate_Click(object sender, EventArgs e)
        {
            ReadInput();
            OutputSolution();
        }

        private void ReadInput()
        {
            _equation = new Equation((double)nudA.Value, (double)nudB.Value, (double)nudAccuracy.Value);
        }

        private void OutputSolution()
        {
            lbResult.Text = $"X = {_equation.GetSolution()}";
        }
    }
}
