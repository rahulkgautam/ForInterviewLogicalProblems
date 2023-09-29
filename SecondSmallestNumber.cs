int[] arr = { 9,6,4,25,23,1,4 };
            Array.Sort(arr);            
            List<int> newlist=new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(!newlist.Contains(arr[i]))
                    newlist.Add(arr[i]);
            }
            Console.WriteLine(newlist[1]);
