// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
struct Complex
{
    public double im;
    public double re;
    public Complex Munus(Complex complex)
    {
        Complex newComplex;
        newComplex.re = re - complex.re;
        newComplex.im = im - complex.im;
        return newComplex;
    }
    static void Main() 
    {
          Complex complex01;
          complex01.re = 2;
          complex01.im = 3;

        Complex complex02;
        complex02.re = 0;
        complex02.im = -2;

        Console.WriteLine(complex01);
        Console.WriteLine(complex02);

        Complex complex03 = complex02.Munus(complex01);
        Console.WriteLine($"Результат вычитания комплексных чисел:{ complex02} - { complex01} = { complex03}");
       

        Console.ReadLine();
    }
}
