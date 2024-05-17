//Date: 17 May 2024
/*Types, methods, or assemblies can be marked with the System.Diagnostics.CodeAnalysis.ExperimentalAttribute to indicate an experimental feature. 
 * The compiler issues a warning if you access a method or type annotated with the ExperimentalAttribute.*/
using System.Diagnostics.CodeAnalysis;

#pragma warning disable test // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var result = GetNumber();
#pragma warning restore test // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
Console.WriteLine("Hello, World! " + result);


[Experimental("test")]
static int GetNumber()
{
    return 452;
}