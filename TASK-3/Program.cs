
double[] CreateRandomArray(int size) 
{
      double[] newArray = new double[size]; 
      for(int i = 0; i < size; i++) 
      newArray[i] = new Random().Next(1, 99); 
      return newArray; 
}

double diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    

    for(int i = 1; i < array.Length; i++)
    if(array[i] < min) 
    min = array[i];
    for(int i = 1; i < array.Length; i++)
    if(array[i] > max)
    max = array[i];
    double diffrence = max - min;

    return diffrence;
}
void ShowArray(double[] array) 
{ 
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
double[] array = CreateRandomArray(size);
ShowArray(array);
double dif = diff(array);
Console.WriteLine("min and max difference is " + diff(array));