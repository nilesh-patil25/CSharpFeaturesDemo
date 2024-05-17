//Date: 17 May 2024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//feature is under preview so manually created the class InterceptsLocationAttribute which is sealed 
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    //use to define the the intercept location 
    internal sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}