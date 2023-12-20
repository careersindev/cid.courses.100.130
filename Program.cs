// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Delcaring integer primitive type with default value.");
int counter = 1;
Console.WriteLine("Counter: " + counter);


Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Delcaring nullable integer primitive type with no value.");
int? nullableCounter;
nullableCounter = counter + 1;
Console.WriteLine("Nullable Counter: " + nullableCounter);


Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Declaring integer primitive type using var keyword.");
var varCounter = 1;
Console.WriteLine("Var Counter: " + varCounter);


Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Declaring an instance of an object with an integer property named 'Id' and default value of 0.");
MyFirstClass classVariableNoDefault = new MyFirstClass();
Console.WriteLine("Class Variable - No Default Value: " + classVariableNoDefault.Id);


Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Declaring an instance of an object with an integer property named 'Id' and default value of 1.");
MyFirstClass classVariable = new MyFirstClass() { Id = 1 };
Console.WriteLine("Class Variable - Default Value: " + classVariable.Id);


Console.WriteLine("---------------------------------------------------------------------------------------------------------");
Console.WriteLine("Declaring an anonymous object with an integer property named 'Id' and default value of 1.");
var anonymousClass = new { Id = 1 };
Console.WriteLine("Anonymous Class Variable: " + anonymousClass.Id);


Console.ReadLine();


public class MyFirstClass
{
    public int Id { get; set; }
}
