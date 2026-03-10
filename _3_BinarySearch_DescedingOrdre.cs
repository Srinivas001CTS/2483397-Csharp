namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the elements in descending order:");
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The array you entered: ");

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            //binary search in descending order
            Console.WriteLine("Enter the searching value:");
            int search = Convert.ToInt32(Console.ReadLine());
            int start, mid, end;
            start = 0;
            end = size;
            bool found = false;
            while(start < end)
            {
                mid = start + (end - start) / 2;
                if (arr[mid] == search)
                {
                    found = true;
                    Console.WriteLine("The element " + search + " found at the index: " + mid);
                    break;
                }else if (arr[mid] > search)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }
            if (!found)
            {
                Console.Write("Element was not found");
            }

        }
    }
}
