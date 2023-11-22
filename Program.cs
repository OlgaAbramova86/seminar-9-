using System;
using System.ComponentModel.DataAnnotations;





//////////////////////////////////////////////
void task64(int z)
{
    void Nto1(int N)
    {
        Console.Write($"{N }");
        if (N > 1) Nto1(N-1);
        
    }


    Console.WriteLine("Input N");
    int N = Convert.ToInt32(Console.ReadLine());
    Nto1(N);
}

/////////////////////////////////////////////////

void task66(int z)
{
    int MtoNSum(int N, int M)
    {

        if (N > M) return MtoNSum(N-1, M) + N;
        return N;


    }

        Console.WriteLine("Input M");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write(MtoNSum(N, M));

}

///////////////////////////////////////////////////

void task68(int z)
{
    int Akkerman(int M, int N)
    {
        while(M != 0)
        {
            if(N == 0) N = 1;
            else N = Akkerman(M, N-1);
            M -= 1;
        }
        return N+1;
    }


        Console.WriteLine("Input M");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write(Akkerman(M, N));

}

System.Console.WriteLine("какое задание запустить? (1, 2 или 3)");
int z = Convert.ToInt32(Console.ReadLine());
if (z == 1) task64(z);
if (z == 2) task66(z);
if (z == 3) task68(z);






