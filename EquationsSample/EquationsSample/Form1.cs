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

        private void btWriteToTable_Click(object sender, EventArgs e)
        {
            ReadTableDataInput();
            if (!_isInputValid)
            {
                return;
            }

            WriteIntoTable();
        }

        private void btPlot_Click(object sender, EventArgs e)
        {
            ReadTableDataInput();
            if (!_isInputValid)
            {
                return;
            }

            PlotGraphic();
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
            _equation = new Equation(a, b, accuracy);
        }

        private void OutputSolution()
        {
            lbResult.Text = $"X = {_equation.GetSolution()}";
        }

        private void ReadTableDataInput()
        {
            _isInputValid = false;

            double a = (double)nudA.Value;
            double b = (double)nudB.Value;
            double deltaX = (double)nudDelta.Value;

            if (a >= b)
            {
                MessageBox.Show("A can not be greater or equal B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (deltaX == 0)
            {
                MessageBox.Show("Delta X can not be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _isInputValid = true;
            _equation = new Equation(a, b);
            _equation.DeltaX = deltaX;
        }

        private void WriteIntoTable()
        {
            listBResult.Items.Clear();
            _equation.CurrentX = _equation.MinValue;
            listBResult.Items.Add("X Y");
            while (_equation.CurrentX <= _equation.MaxValue)
            {
                double y = _equation.GetValueForCurrentX();
                listBResult.Items.Add($"{_equation.CurrentX} {y}");
                _equation.CurrentX += _equation.DeltaX;
            }
        }

        private void PlotGraphic()
        {
            _equation.CurrentX = _equation.MinValue;
            while (_equation.CurrentX <= _equation.MaxValue)
            {
                double y = _equation.GetValueForCurrentX();
                chGraphic.Series[0].Points.AddXY(_equation.CurrentX, y);
                _equation.CurrentX += _equation.DeltaX;
            }
        }
    }
}
