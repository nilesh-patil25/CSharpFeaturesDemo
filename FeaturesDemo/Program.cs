//Date: 17 May 2024
using C__12_Features.AnyTypeAlias;
using C__12_Features.Collection_Expression;
using C__12_Features.DefaultLambdaParameter;
using C__12_Features.InlineArray;
using C__12_Features.Primary_Constructor;
using C__12_Features.RefReadOnly;
using System.Runtime.CompilerServices;



Employee empp = new Employee("alice", 45000);
empp.Name = empp.Name;
Console.WriteLine(empp.Name);
Console.WriteLine(empp.Salary);
Console.WriteLine(empp.DeptName);

Console.WriteLine();

Employee emp = new Employee();
Console.WriteLine(emp.Name);
Console.WriteLine(emp.Salary);
Console.WriteLine(emp.DeptName);

Console.WriteLine();

Employee emppp = new Employee("rajesh", "e998", "prod");
Console.WriteLine(emppp.Name);
Console.WriteLine(emppp.Salary);
Console.WriteLine(emppp.DeptName);
Console.WriteLine(emppp.Code);

var collection = new CollectionExpression();
collection.CollectionExpressions();
collection.CollectionExpressionMda();

var inDemo = new RefReadOnly();
inDemo.Main(55);

var defaultLambda = new DefaultLambdaValueDemo();
defaultLambda.LambdaDefaultParam();

var inlineArray = new InlineArray();
inlineArray.Main();

AliasAnyType alias = new AliasAnyType();
alias.CalArea(7, 11);