using System;
using System.ComponentModel.DataAnnotations;



// Задание 64

    void fromNto1(int N)
    {
        Console.Write($"{N }");
        if (N > 1) Nto1(N-1);
        
    }


    Console.WriteLine("Input N");
    int N = Convert.ToInt32(Console.ReadLine());
    Nto1(N);






// Задание 66


    int SumMtoN(int N, int M)
    {

        if (N > M) return MtoNSum(N-1, M) + N;
        return N;


    }

        Console.WriteLine("Input M");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write(MtoNSum(N, M));







// Задание 68


    int Akk(int M, int N)
    {
        while(M != 0)
        {
            if(N == 0) N = 1;
            else N = Akkerman(M, N-1);
            M -= 1;
        }
        return N+1;
