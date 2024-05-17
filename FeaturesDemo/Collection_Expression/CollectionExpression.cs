//Date: 17 May 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__12_Features.Collection_Expression
{
    public class CollectionExpression
    {
        #region Data Members 
        int[] ar = [1, 2, 3];
        int[] ar2 = [11, 12, 13];

        List<int> ar3 = new List<int>() { 22, 23, 21 };
        List<int> ar4 = new List<int>() { 41, 43, 45 };


        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];
        #endregion

        #region Member Functions
        /// <summary>
        /// use of spread operator
        /// </summary>
        public void CollectionExpressions()
        {
            try
            {
                //The spread operator, .. in a collection expression replaces its argument with the elements from that collection. 
                int[] result = [.. ar, .. ar2, 114, 458];
                string allvalue = string.Join("-", result);
                Console.WriteLine(allvalue);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                // Create a list:
                List<string> b = ["one", "two", "three"];

                List<int> listResult = [.. ar3, .. ar4, 456, 857];
                string allList = string.Join("-", listResult);
                Console.WriteLine(allList);

                List<Student> students1 = new()
                {
                    new Student { Name = "Alice", Standard = 10 },
                    new Student { Name = "Bob", Standard = 11 },
                    new Student { Name = "Charlie", Standard = 10 }
                };

                List<Student> students2 = new()
                {
                    new Student { Name = "David", Standard = 12 },
                    new Student { Name = "Eve", Standard = 11 }
                };


                List<Student> finalList = [.. students1, .. students2, new Student { Name = "nobita", Standard = 10 }];
                foreach (var item in finalList)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Standard);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        
        /// <summary>
        /// examples with Multi Dementional Array
        /// </summary>
        public void CollectionExpressionMda()
        {
            try
            {
                int[] single = [.. row0, .. row1, .. row2];
                foreach (var element in single)
                {
                    Console.Write($"{element}, ");
                }

                // Create a jagged 2D array from variables:
                int[][] twoDFromVariables = [row0, row1, row2];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
#endregion

    }
}
