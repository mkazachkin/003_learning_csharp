using Geekbrains;

double[,] array = Double2DArray.MakeCustom(true);
Double2DArray.Print(array, 3, " {0:f0}");
Console.WriteLine();
Double2DArray.Print(Double2DArray.FrequencyDictionary(array), 6, " {0:f0}");
