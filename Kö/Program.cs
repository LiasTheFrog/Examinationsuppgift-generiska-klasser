
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Ko <T> where T : IComparable<T>{
    //variabler
    int last;
    int len;
    T[] items;
    T temp;

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

public void Remove(int removeIndex){
    for(int i = removeIndex; i <= last; i++){
        items[removeIndex] = items[removeIndex +1];
    }

last--;
}

public void Swap(int indexnumber1, int indexnumber2){

temp = items[indexnumber1];
items[indexnumber1] = items[indexnumber2];
items[indexnumber2] = temp;
}

public bool isEmpty(){
    Console.WriteLine("är kön tom?: ");
   Console.WriteLine(last < 0);
return last < 0;
}

public T Min(){
T min;


min = items[0];

for(int i = 1; i < last; i++){
    
    if(min.CompareTo(items[i]) > 0){
       
min = items[i];
Console.WriteLine($"jaja {min}");
    } 

}

Console.WriteLine($"nejnej {min}");
return min;
}

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
int chooseIndex;
bool active = true;
int index1;
int index2;

Ko<int> minKo1 = new Ko<int>(5);
Ko<int> minKo2 = new Ko<int>(6);
while(active){
Console.Clear();

Console.WriteLine("(1) add");
Console.WriteLine("(2) remove");
Console.WriteLine("(3) compare");
Console.WriteLine("(4) print");
Console.WriteLine("(5) swap");
Console.WriteLine("(6) isEmpty");
Console.WriteLine("(7) Minsta");
Console.WriteLine("(8) Exit");

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
minKo2.Add(addNumber);
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 2: 
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());
if(chooseKo == 1){
    Console.WriteLine("välj index att ta bort: ");
    chooseIndex = int.Parse(Console.ReadLine());
minKo1.Remove(chooseIndex);
}else{
    Console.WriteLine("välj index att ta bort: ");
    chooseIndex = int.Parse(Console.ReadLine());
minKo2.Remove(chooseIndex);
}
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
minKo2.print(2);
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 5:
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());

if(chooseKo == 1){
    Console.WriteLine("välj första indexet som ska byta plats: ");
    index1 = int.Parse(Console.ReadLine());
    Console.WriteLine("välj andra indexet som ska byta plats: ");
    index2 = int.Parse(Console.ReadLine());
minKo1.Swap(index1,index2);
}else{
     Console.WriteLine("välj första indexet som ska byta plats: ");
    index1 = int.Parse(Console.ReadLine());
    Console.WriteLine("välj andra indexet som ska byta plats: ");
    index2 = int.Parse(Console.ReadLine());
minKo2.Swap(index1,index2);
}


Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 6:
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());

if(chooseKo == 1){
    
minKo1.isEmpty();
}else{
    
minKo2.isEmpty();
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 7:
Console.WriteLine("välj kö: ");
chooseKo = int.Parse(Console.ReadLine());

if(chooseKo == 1){
    
minKo1.Min();
}else{
    
minKo2.Min();
}
Console.WriteLine("press enter to continue");
Console.ReadKey();
break;

case 8:
active = false;
break;
}

}
    }
}