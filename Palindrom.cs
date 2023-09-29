int number = 1213;
            int originNumber = number;
            int reverse = 0;
            while (number != 0)
            {
                int rem = number % 10;
                reverse = (reverse * 10) +rem;
                number /= 10;
            }
            if(originNumber == reverse)
                Console.WriteLine("Number is palindrom {0}",originNumber);
            else
                Console.WriteLine("Number is not palindrom {0}", originNumber);
