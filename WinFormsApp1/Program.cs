using System;
using System.Windows.Forms;

namespace ComplexCalculator
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // �������� ���������� ����� ��� ����������
            Application.EnableVisualStyles();

            // ������������� ������������� � ��������� �����������
            Application.SetCompatibleTextRenderingDefault(false);

            // ��������� ������� ����� ���������� (Form1)
            Application.Run(new Form1());
        }
    }
}