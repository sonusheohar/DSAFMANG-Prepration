namespace DSAFMANG.BigO
{

    #region Main method write in program.cs file
    //using DSAFMANG.BigO;
    //using System;

    //int[] num = { 2, 1, 10, 20, 5, 6, 3, 21 };
    //FindComplexity findComplexity = new FindComplexity();
    //var maxNumber = findComplexity.GetMaxNumber(num);
    //Console.WriteLine(maxNumber.ToString());
    //Console.ReadKey();

    #endregion
    public class FindComplexity
    {

        // Find Max in Array -O(n)
        public int GetMaxNumber(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if(num> max)
                    max = num;
            }
            return max;
        }
    }
}
