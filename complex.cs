using System;
class complex
{
    public int r;
    public int i;

    public complex()
    {
        r=i=0;
    }
    public complex(int d_r,int d_i)
    {
        r=d_r;
        i=d_i;
    }
    public void display()
    {
        Console.WriteLine("r= "+r+" i= "+i);
    }
    complex add_complex(complex d_c)
    {
        return (new complex(this.r+d_c.r,this.i+d_c.i));
    }
    public static void Main()
    {
        Console.WriteLine("Name:- Hemal Parmar");
		Console.WriteLine("date:-19/12/2019");
		Console.WriteLine("aim:-code to perform operation on complex no");
        complex c1=new complex();
        c1.display();
        complex c2=new complex(2,3);
        complex c3=new complex(10,20);
        c1=c2.add_complex(c3);
        c1.display();
        Console.ReadKey();
    }
}