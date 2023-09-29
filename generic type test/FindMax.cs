namespace generic_type_test;

public class FindMax:IMax<int[]>
{
        public int Max(int[] items)
        {
            if (items == null || items.Length == 0)
            {
                System.Console.WriteLine("invalid number of items");
                return 0;
            }
            // int[] max = new int[];

            int max = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] > max)
                {
                    max = items[i];
                }
            }

            return max;
        }

}

