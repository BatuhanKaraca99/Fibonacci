using System;

class Program {
  public static void Main (string[] args) {
    int a=1,b=1;
    Console.WriteLine("Fibonacci dizisinin kaçıncı sıraya kadar olacağına dair bir pozitif tamsayı giriniz:");
    int girilen=Int32.Parse(Console.ReadLine());
    Console.WriteLine("Verdiğiniz "+girilen+". sıraya kadar Fibonacci Serisi:");
    if(girilen == 1)
      Console.WriteLine(a); //1
    else if(girilen == 2)
      Console.WriteLine(a+" "+b); //1 1
    else if(girilen > 2){
      Console.Write(a+" "+b+" "); //1 1 Sonrakiterimler...
      int toplam=0;
      for(int i=2;i<girilen;i++)
        {
      toplam=a+b; // a ve b değişkenini topla
      a=b; //b değerini a ya ata
      b=toplam; //toplam değerini b ye ata
      Console.Write(toplam+" "); //toplamı yazdır
        }
    }
    else
      throw new Exception("Yanlış değer girdiniz.Girdiğiniz değer pozitif tam sayı olmalıdır.");
  }
      
}
