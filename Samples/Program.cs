using Samples;

Method(0);
Method(1);
Method(2);

Console.ReadKey();

void Method(int a)
{
    try
    {
        switch (a)
        {
            case 0: throw new CustomException1();
            case 1: throw new CustomException2();
            case 2: throw new Exception("Unknow Exception");
        }
    }
    catch (Exception exp) when (exp is CustomException1 || exp is CustomException2)
    {
        Console.WriteLine(exp.Message);
    }
    catch (Exception exp) 
    {
        Console.WriteLine(exp.Message);
    }
}