// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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

int getMax(int[] array){
    int max = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] > max) max = array[i];
    }
    return max;
}

int getMin(int[] array){
    int min = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] < min) min = array[i];
    }
    return min;
}

int diffMaxMin(int[] array){
    return getMax(array) - getMin(array);
}

int[] array = GenerateArray(5, -10, 50);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между Max и Min значениями массива = {diffMaxMin(array)}.");