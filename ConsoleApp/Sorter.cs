namespace ConsoleApp.CustomTypes
{
    public struct Sorter
    {
        private delegate bool CompareFunc(int a, int b);

        private bool CompareAscending(int a, int b)
        {
            return a > b;
        }

        private bool CompareDescending(int a, int b)
        {
            return a < b;
        }


        public void BubbleSort(int[] numbers, SortOrder order)
        {
            CompareFunc pointer;
            if (order == SortOrder.Ascending)
            {
                pointer = CompareAscending;
            }
            else
            {
                pointer = CompareDescending;
            }


            int tempValue;
            for(int i = 0; i <= numbers.GetUpperBound(0); i++)
            {
                tempValue = numbers[i];
                for(int j = i+1; j <= numbers.GetUpperBound(0); j++)
                {
                    if(pointer(tempValue, numbers[j]))
                    {
                        numbers[i] = numbers[j];
                        numbers[j] = tempValue;
                        tempValue = numbers[i];
                    }
                    //if(order == SortOrder.Ascending)
                    //{
                    //    if(CompareAscending(tempValue, numbers[j]))
                    //    {
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                    //else
                    //{
                    //    if(CompareDescending(tempValue, numbers[j]))
                    //    {
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                }
            }
        }
    }

    public enum SortOrder
    {
        Ascending,
        Descending
    }
}