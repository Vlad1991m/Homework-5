
int[] CreateRandomArray(int size) 
{
      int[] newArray = new int[size]; 
      for(int i = 0; i < size; i++) 
      newArray[i] = new Random().Next(100, 999); 
      return newArray; 
}

int Evenelements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)

    if(array[i]%2 == 0) 
    sum++;

    return sum;
}
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateRandomArray(size);
ShowArray(array);
int Even = Evenelements(array);
Console.WriteLine("Sum of even numbers in current array is " + Even);

 