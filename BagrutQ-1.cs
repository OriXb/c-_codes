namespace ConsoleApp3
{
    class Program 
    {
        // checking of the code of the command "isCorner"
        static void Main(string[] args)
        {
            int[,] metrix = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
            for (int i = 0; i < metrix.GetLength(0); i++)
            {
                for (int z = 0; z < metrix.GetLength(1); z++)
                {
                    Console.WriteLine(i + " " + z);
                    metrix[i, z] = int.Parse(Console.ReadLine());
                }
            }
            if(isCorner(metrix))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }
        }

        // command of checking if the matrix build in a certain shape, answer to a Bagrut question.
        public static bool isCorner(int[,] matrix)
        {
            int num = 1;
            int num2 = 0;
            if (matrix.GetLength(1) != matrix.GetLength(0) || matrix.GetLength(1) == 0)
            {

                return false;
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0 + num2; j < matrix.GetLength(1) - num2; j++)
                {
                    if(matrix[i,j] != num)
                    {
                        Console.WriteLine(matrix[i, j]);

                        return false;
                    }
                }
                for (int j = 0 + num2; j < matrix.GetLength(1) - num2; j++)
                {
                    if (matrix[j, i] != num)
                    {
                        Console.WriteLine(matrix[j, i]);

                        return false;
                    }
                }
                num2 = num2 + 1;
                num = num + 1;
                Console.WriteLine("next loop");

            }
            return true;
        }

    }
}