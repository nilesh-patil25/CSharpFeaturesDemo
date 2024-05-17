using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__12_Features.DefaultLambdaParameter
{
    public class DefaultLambdaValueDemo
    {
        #region Member Functions
        /// <summary>
        /// Lambda function having default value
        /// </summary>
        public void LambdaDefaultParam()
        {
            try
            {
                var Cube = (int num = 2) => num * num * num;

                Console.WriteLine(Cube(5));
                Console.WriteLine(Cube());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion


    }
}
