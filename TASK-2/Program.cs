
int[] CreateRandomArray(int size) 
{
      int[] newArray = new int[size]; 
      for(int i = 0; i < size; i++) 
      newArray[i] = new Random().Next(-99, 99); 
      return newArray; 
}

int Oddelements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)

    if(i % 2 != 0) sum += array[i];

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
int Odd = Oddelements(array);
Console.WriteLine("Sum of odd position elements in current array is " + Odd);

 