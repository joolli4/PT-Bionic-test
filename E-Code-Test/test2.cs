using System;

public class SoalKedua
{
    public static void Main(string[] args)
    {
        var array=new int[]{10,7,5,8,11,9,1};
        int terendah=0;
        int tertinggi=0;
        int selisih=0;

        for (var i=0; i<array.Length; i++) 
        {
            for (var j=i+1; j<array.Length; j++)
            {
                if (array[i]>array[j])
                {
                    continue;
                }
                if (selisih<array[j]-array[i])
                {
                    selisih=array[j]-array[i];
                    terendah=array[i];
                    tertinggi=array[j];
                }
            }
        }
        Console.WriteLine($"Nilai selisih = {selisih} dari array {terendah} s/d {tertinggi}");
    }
}