
//Создать рандомный массив
/*int[] CreateRandomArray(int size, int min,int max)
{
    int[] array = new int [size];

    for(int i=0;i<size;i++)
       array[i] = new Random().Next(min,max+1);

       return array;
}
//Создать массив
int[] CreateArray()
{
   Console.WriteLine("Welcom to array creating program");
   int size = Convert.ToInt32(Console.ReadLine());

   int[] array= new int [size];

   for(int i=0;i<size;i++)
   {
    Console.Write($"Imput {i + 1} element: ");
    array[i]= Convert.ToInt32(Console.ReadLine());
   }
   return array;

}
// Показать массив
void ShowArray(int[] array)

{
for(int i=0;i<array.Length;i++)
   Console.Write(array[i] + " ");

Console.WriteLine();

}
//Сумма положительных чисел
int SumPositive(int[] array)
{
   int sum = 0;
   for(int i = 0;i < array.Length;i++)
      if(array[i] > 0) sum+= array[i];
      return sum;

}
//Другой спосоп суммы положительных чисел
int FindSum(int[] array, bool isPositive)
{
   int sumPositive = 0;
   int sumNegative = 0;
   for(int i = 0;i < array.Length;i++)
      if(array[i] > 0 && isPositive) sumPositive+= array[i];
      else if(array[i] < 0 && !isPositive)sumNegative+= array[i];

   return isPositive ? (sumPositive) :(sumNegative);


}

//Пример в котором считается сумма положительных чисел и отрицательных из масива 

bool positive = true; 

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

Console.WriteLine(FindSum(myArray, positive));
Console.WriteLine(FindSum(myArray, !positive));*/


//Задача: поменять местами в массиве положительные числа с отрицательными

/*int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i=0;i<size;i++)
       array[i] = new Random().Next(-5,6);

       return array;
}
 int[] ChangeElements(int[] array)
 {
   for(int i=0;i<array.Length;i++)
    array[i] *= -1;
    return array;
 }

 void ShowArray(int[] array)

{
for(int i=0;i<array.Length;i++)
   Console.Write(array[i] + " ");

Console.WriteLine();
}
int[] OurArray = CreateRandomArray(8);
ShowArray(OurArray);
ShowArray(ChangeElements(OurArray));*/



//Задача:Создать массив и узнать имеется ли в данном массиве определенное число
/*int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i=0;i<size;i++)
       array[i] = new Random().Next(-5,6);

       return array;
}
void ShowArray(int[] array)

{
for(int i=0;i<array.Length;i++)
   Console.Write(array[i] + " ");
}
CreateRandomArray(array);
ShowArray(array);

bool CheckNumber(int[] array, int num)
{

    for(int i=0;i<array.Length;i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}

int number =0;
Console.WriteLine(CheckNumber(array, number));*/
//Задача: Задать массив из 20 чисел и найти все двухзначные числа
