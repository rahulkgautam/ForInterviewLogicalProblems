public void MinAndMax(){
int[] arr = { 5, 8, 2, 10, 3, 6, 9, 4, 7 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)               
                    max = arr[i];               

                if (arr[i] < min)                
                    min = arr[i];                
            }
            // Display the result
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
}
