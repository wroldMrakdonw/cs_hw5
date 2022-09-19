// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray(int len, int min, int max) {
    int[] array = new int[len];
    for (int i = 0; i < len; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        System.Console.Write($"{array[i]} ");
    }    
}

int notEvenIndexSum(int[] array){
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2){
        sum += array[i];    
    }
    return sum;
}

int[] array = GenerateArray(4, -10, 10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечетных индексах массива = {notEvenIndexSum(array)}.");