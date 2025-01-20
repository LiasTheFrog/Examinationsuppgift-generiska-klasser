﻿
using System.ComponentModel;

public class Ko <T> where T : IComparable<T>{
    //variabler
    int last;
    int len;
    T[] items;

//metoder
public int Compare(Ko<T> OneArray){
if(last != OneArray.last){
return -1;
}
for(int i = 0; i <= last; i++){
  if(items[i].CompareTo(OneArray.items[i]) != 0){
return -1;
  }
}
return 0;
}

public void Add(T AddElement){
    if(last<len){
        items[last+1] = AddElement;
last++;
    }
else throw new LengthException();
}

public void Remove(){

}

public void Swap(){

}

/* public bool isEmpty(){

}

public T min(){

} */

public void print(int koNumber){
    Console.WriteLine($"detta är din kö {koNumber}:");
for(int i = 0; i <= last; i++){
    Console.Write($"[ {items[i]} ]");
}
Console.WriteLine(" ");
}

//Konstuktor 
public Ko(int size){
last = -1;
len = size;
items = new T[size];
}
}

public class LengthException : Exception{
    string message = "kön är full";
    public override string ToString()
    {
        return message;
    }
}


class Program{
    public static void Main(){

Ko<int> minKo1 = new Ko<int>(5);
Ko<int> minKo2 = new Ko<int>(6);

Console.WriteLine("(1) add");
Console.WriteLine("(2) remove");
Console.WriteLine("(3) compare");
Console.WriteLine("(4) print");
Console.WriteLine("(5)");
Console.WriteLine("(6)");

int Alt = int.Parse(Console.ReadLine());

switch(Alt){

case 1:

break;

case 2: 

break;

case 3:

break;

case 4:

break;

case 5:

break;

case 6:

break;

case 7:

break;


}

minKo1.Add(1);
minKo1.Add(2);
minKo1.Add(3);
minKo2.Add(1);
minKo2.Add(2);
minKo2.Add(3);

   Console.WriteLine("0 = lika, !0 = olika:", minKo1.Compare(minKo2)); 
   minKo1.print(1);
   minKo2.print(2);

    }
}