using System;
using System.Windows.Forms;

namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� �������� �� ��������� �����
                double real1 = double.Parse(real1TextBox.Text);
                double imaginary1 = double.Parse(imaginary1TextBox.Text);
                double real2 = double.Parse(real2TextBox.Text);
                double imaginary2 = double.Parse(imaginary2TextBox.Text);

                // ������� ����������� �����
                Complex a = new Complex(real1, imaginary1);
                Complex b = new Complex(real2, imaginary2);

                Complex? result = null;

                // ��������� ��������� ��������
                switch (operationComboBox.SelectedItem.ToString())
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    default:
                        MessageBox.Show("�������� ��������");
                        return;
                }

                // ������� ���������
                resultLabel.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }
    }
}