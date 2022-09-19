// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int countOfEvenNums(int[] array){
    int counter = 0; 
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] array = GenerateArray(10, 100, 999);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"В заданном массиве {countOfEvenNums(array)} четных чисел");