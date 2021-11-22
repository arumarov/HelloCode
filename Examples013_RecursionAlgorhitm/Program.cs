// // ТАБЛИЦА ИЗ СТРОК
// // индексы начинаются с нуля
// string[,] table = new string[2, 5]; // в квадратных скобках сначала номер строки, затем номер столбца
// // String.Empty - инициализация строк проходит такой константой
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] - первая строка
// // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] - вторая строка

// table [1,2] = "слово"; // Чтобы обратиться к нужному элементу, указываем наименование, индекс строки и индекс столбца

// for (int rows = 0; rows<2; rows++) // Распечатываем массив, пока количество строк меньше двух
// {
//     for (int columns=0; columns<5; columns++) // Вложенный цикл с указанием количества столбцов
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); // Распечатывание элементов массива
//     }
// }

// ТАБЛИЦА ЧИСЕЛ

// void PrintArray(int[,] matr) // создаем метод для распечатывания массива
// {
//     for (int i = 0; i<matr.GetLength(0); i++) // цикл с указанием количества строк
//     {
//          for (int j=0; j<matr.GetLength(1); j++) // Вложенный цикл с указанием количества столбцов
//         {
//              Console.Write($"{matr[i, j]} "); // Распечатывание элементов массива
//          }
//         Console.WriteLine(); // принудительно делаем переход на новую строку
//     }
// }

// void FillArray(int[,] matr) // Создаем метод для заполнения матрицы случайными числами
// {
//     for (int i = 0; i<matr.GetLength(0); i++) // цикл с указанием количества строк
//     {
//          for (int j=0; j<matr.GetLength(1); j++) // цикл с указанием количества столбцов
//         {
//              matr[i,j] = new Random().Next(1,10); // Заполнение массива [1,10)
//          }
//     }
// }

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// // КОД ДЛЯ ЗАКРАШИВАНИЯ МАССИВА

// void PrintImage(int[,] image) // Метод, который печатает картинку (двумерный массив с картинкой условно не дается)
// {
//     for (int i = 0; i<image.GetLength(0); i++) 
//     {
//          for (int j=0; j<image.GetLength(1); j++) 
//         {
//              //Console.Write($"{matr[i, j]} "); 
//              if(image[i,j] == 0) Console.Write($" ") // Если значение будет равно 0 (пустая ячейка), печатаем пробел
//              else Console.Write($"+") // Либо печатаем +
//          }
//         Console.WriteLine(); 
//     }
// }

// void FillImage(int row, int col) // Метод, который закрашивает внутр. область. Входящие аргументы - координаты начальной точки
// {
//     if (pic[row,col] == 0)
//     {
//         pic[row,col] = 1;
//         FillImage(row-1, col); //в данном методе вызываем данный метод
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13); // ставим координаты случайной точки внутри изображения
// PrintImage(pic);



// Рекурсия
//Факториал
// int Factorial(int n)
// {
//     // 1! = 1
//     // !0 = 1
//     if (n==1) return 1; // если n = 1, возвращаем 1
//     else return n*Factorial(n-1); // либо умножаем n на факториал предыдущего числа
// }

// Console.WriteLine(Factorial(5)); 

//Факториал большого числа
// double Factorial(int n)
// {
//     // 1! = 1
//     // !0 = 1
//     if (n==1) return 1; // если n = 1, возвращаем 1
//     else return n*Factorial(n-1); // либо умножаем n на факториал предыдущего числа
// }

// for (int i=1; i<40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Числа Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i<50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}