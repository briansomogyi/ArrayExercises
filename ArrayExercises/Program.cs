namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("Number of elements: ", 3);
            int[] ints = new int[n];
            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = ReadNumber($"Element at index {i}: ", 2);
            }
            string elements = string.Join(",", ints);
            Console.WriteLine(elements);
            int min = Min(ints);
            Console.WriteLine(min);
            SelectionSort(ints);
            string elementsSorted = string.Join(",", ints);
            Console.WriteLine(elementsSorted);
        }

        static int ReadNumber(string label, int maxAttempts) 
        {
            int attempts = 1;
            do
            { 
                Console.Write(label);
                string input = Console.ReadLine();
                bool isValidNumber = int.TryParse(input, out int result);
                if (isValidNumber)
                {
                    return result;
                }
                if (attempts < maxAttempts)
                {
                    Console.WriteLine($"Value '{input}' is not a valid number, please try again.");
                }
                attempts++;
            } while (attempts <= maxAttempts);
            Console.WriteLine($"No valid number input, continuing with 0 as default value.");
            return 0;
        }

        static int Min(int[] ints) 
        {
            if (ints is null)
            {
                throw new ArgumentNullException(nameof(ints),"Cannot calculate min value for a null array.");
            }
            if (ints.Length == 0)
            {
                throw new ArgumentException("Cannot calculate min value for an empty array.", nameof(ints));
            }
            int min = ints[0];
            for (int i = 1; i < ints.Length; i++) 
            {
                if (ints[i] < min)
                {
                    min = ints[i];
                }
            }
            return min;
        }

        public static void SelectionSort(int[] ints) 
        {
            if(ints is null)
            {
                throw new ArgumentNullException(nameof(ints),"Cannot sort a null array.");
            }
            if(ints.Length == 0)
            {
                throw new ArgumentException("Cannot sort an empty array.", nameof(ints));
            }
            for (int i = 0; i < ints.Length - 1; i++)
            {
                int min = ints[i];
                for (int j = i; j < ints.Length; j++)
                {
                    if (ints[j] < min)
                    {
                        // Swap ints[i] with ints[j]
                        int temp = ints[i];
                        ints[i] = ints[j];
                        ints[j] = temp;
                    }
                }
                
                /*
                    int min = ints[0];
                    for (int i = 1; i < ints.Length; i++) 
                    {
                        if (ints[i] < min)
                        {
                            min = ints[i];
                        }
                    }
                */
            }
        }
    }
}