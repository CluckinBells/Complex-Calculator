using System;

public class Complex
{
    public double Real { get; private set; }
    public double Imaginary { get; private set; }

    // Конструктор, принимающий действительную и мнимую части
    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Копирующий конструктор
    public Complex(Complex other)
    {
        Real = other.Real;
        Imaginary = other.Imaginary;
    }

    // Метод для получения действительной части
    public double Re()
    {
        return Real;
    }

    // Метод для получения мнимой части
    public double Im()
    {
        return Imaginary;
    }

    // Метод для получения модуля числа
    public double Abs()
    {
        return Math.Sqrt(Real * Real + Imaginary * Imaginary);
    }

    // Операция сложения
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    // Операция вычитания
    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    // Операция умножения
    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
    }

    // Операция деления
    public static Complex operator /(Complex a, Complex b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator, (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
    }

    // Переопределение метода ToString для удобного вывода
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}