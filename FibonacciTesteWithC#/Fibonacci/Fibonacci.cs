
using System;
public static class Fibonacci
{
    public static bool  FibonacciMethod(int num){
        var contador = 2;
        if (num == 0 || num == 1) return true;
        for(int i=1; contador<num;i++){
            contador = i + contador;
            if(contador == num) return true;
        }
        return false;
    }
}

