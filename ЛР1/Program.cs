Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = new double[n, m];
Console.WriteLine("Введите элементы для матрицы: ");
for (int i = 0; i<n ; i++)
{
    string[] r = Console.ReadLine().Split("");
    for(int j = 0; j<m;j++)
        matrix[i, j] = double.Parse(r[j]);
}
Console.WriteLine("Готовая матрица: ");
for(int j = 0; j<m; j++)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(matrix[i, j] + "\t");
    }
}

