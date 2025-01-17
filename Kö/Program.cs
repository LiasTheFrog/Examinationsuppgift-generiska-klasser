
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

public void print(){

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
minKo1.Add(1);
minKo1.Add(2);
minKo1.Add(3);
minKo2.Add(1);
minKo2.Add(2);
minKo2.Add(3);

   Console.WriteLine(minKo1.Compare(minKo2)); 

    }
}