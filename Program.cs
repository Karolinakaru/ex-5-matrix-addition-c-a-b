internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrixA = new int[10, 10];
        int[,] matrixB = new int[10, 10];
        int[,] matrixC = new int[10, 10];
        for (int i = 0; i < matrixA.GetLength(0); i++)// values of matrixA
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                matrixA[i, j] = 1;
            }
        }
        for (int i = 0; i < matrixB.GetLength(0); i++)// values of matrixB
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixB[i, j] = 2;
            }
        }
        for (int i = 0; i < matrixC.GetLength(0); i++)// sum values for matrixC
        {
            for(int j = 0;j < matrixC.GetLength(1); j++)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        // displaying the calculated matrix
        for (int i = 0; i < matrixC.GetLength(0); i++) 
        {
            for(int j = 0; j < matrixC.GetLength(1); j++)
            {
                Console.Write(matrixC[i, j] + " ");// 1 row
            }
            Console.WriteLine();// move to a new row for display the result like matrix
        }
    }
}