
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

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
//variables
int Alt;
int chooseKo;
int addNumber;
bool active = true;

Ko<int> minKo1 = new Ko<int>(5);
Ko<int> minKo2 = new Ko<int>(6);
while(active){
Console.Clear();

Console.WriteLine("(1) add");
Console.WriteLine("(2) remove");
Console.WriteLine("(3) compare");
Console.WriteLine("(4) print");
Console.WriteLine("(5) swap");
Console.WriteLine("(6) Exit");

Alt = int.Parse(Console.ReadLine());

switch(Alt){

case 1:
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());
if(chooseKo == 1){
    Console.WriteLine("ange nummret du vill lägga till: ");
addNumber = int.Parse(Console.ReadLine());
minKo1.Add(addNumber);
}else{
Console.WriteLine("ange nummret du vill lägga till: ");
addNumber = int.Parse(Console.ReadLine());
minKo1.Add(addNumber);
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 2: 
Console.WriteLine("tom case");
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 3:
Console.Write("0 = lika, !0 = olika: ");
Console.WriteLine(minKo1.Compare(minKo2)); 
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 4:
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());
if(chooseKo == 1){
minKo1.print(1);
}else{
minKo1.print(2);
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 5:
Console.WriteLine("tom case");
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 6:
active = false;
break;
}

}
    }
}