public static void Main(string[] args) { 
            int[] arr = { 1, 2, 3, 4, 5, 2,3 };
            List<int> dublicate = new List<int>();
            List<int> unique = new List<int>();
            for (int i = 0; i < arr.Length; i++){
                if (!unique.Contains(arr[i]))
                    unique.Add(arr[i]);   
                else
                    dublicate.Add(arr[i]);
            }
            Console.WriteLine("Duplicate number");
            Array.ForEach(unique.ToArray(), Console.WriteLine);
            Console.WriteLine("Duplicate number");
            Array.ForEach(dublicate.ToArray(), Console.WriteLine);
        }
