# csharp_dotnet_getstarted
* Started at: (2021/12/19)
* First: Reading and coding along the Get Started section: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/local-environment
* Second: Udemy tutorials

### SetUp your local environment
* [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) creates an application. This command generates the files and assets necessary for your application. The introduction to C# tutorials all use the console application type. Once you've got the basics, you can expand to other application types.
  * `dotnet new console -o myApp`
* `dotnet build` builds the executable.
* `dotnet run` runs the executable.

# Udemy Course
* Coding along C# Udemy Tutorial: https://www.udemy.com/course/c-and-net-core-for-beginners/learn/lecture/12677526#overview
* 
### Section4 - Synteax and Structure
* `Namespaces` are a logical grouping of related classes.
* `Classes` are a logical grouping of related method.
* `Methods` are a logical grouping of related logic.
* `Debugger`:
  * `F5` to start a debug session.
* `VSCode TIP`: Hit `CTRL` + `SHIFT` + `SPACE` inside a method call to see its arguments required.
* `VSCode TIP`: To write a new `WriteLine` type `cw` and press `TAB`.


### Section5 - Crucial VS Keyboard Shortcuts
* `CTRL+.`: generates tips, for example generates a new method for your class.
* `F12`: go to definition.
* `CTRL+T`: means Go To All, to find anything inside the project.


### Section7 - Variables
* **Variable Names**:
  * Always named with `camelCase`
  * Avoid abbreviations, prefixes, suffixes.
* **Scoping**:
  * A variable is only accessible within the scope it's defined in.
  * Scopes are defined using brackets
* **Fields**:
  * A variable in class scope is called `field`. (Basically a class variable)
```C#
class Program
{
  static string name;

  static void Main(string[] args)
  {
    name = "Pontus";
  }

  static void DoStuff()
  {
    // Works since fields are defined in class scope
    Console.WriteLine(name);
  }
}
```
* The `var` Keyword.
  * Can be used to infer the data type based on the assigned value.
  * Only works with local variables.


### Section18 - Classes and Objects
* **Constructors**:
  * Called to create an object of a class (using a *new* keyword)
  * looks like a method but lacks return type/void
  * Has the same name as the class
  * The `This` Keyword refers to the current object, often used to differentiate between a parameter and a field:
```C#
class Person
{
  string name;

  public Person(string name)
  {
    this.name = name;
  }
}
```
* On the above example, `this.name` overwrites the field `name` using the value of the parameter passed in the constructor `name`.
* **Private** vs **Public**:
  * Members are private by default (only accessible inside the class).
  * Public members are accessible both inside the class and through objects of the class.
* **Static Members**:
  * Called on the `class` rather than on any specific `instance`.
  * Consider the static WriteLine method on


### Section20 - Properties
* Properties work much the same as `public fields` but offers some benefits:
  * Values can be validated before assignment.
  * Properties can be made read only.
  * The read/write operations can have different visibility modifiers.
* Syntax:
  * "Wraps" access to a private field
  * Named with PascalCase
  * The assigned value can be reached using the `value` keyword:
```C#
class Person
{
  int age;

  public int Age
  {
    get { return age; }
    set { age = value; }
  }
}
```
* `Property` represents data, while `Method` represents action.
* You can think of `properties` as sintatic sugar is comparing to `methods`:

```C#
//Field
int age;

// Property
public int Age
{
  get { return age; }
  set { age = value; }
}

// Methods
public int GetAge()
{
  return age;
}

public int SetAge(int age)
{
  return this.age = age;
}
```
* `Automatic Properties` can offer more terse syntax (removing the need for explicit an field). If you use automatic properties you cant do any validation before assignment:
```C#
class Person
{
  public int Age { get; set; }
}
```
* **TIP**:
  * Write `propful` and TAB on Vscode to create a property with full syntax.
  * Write `prop` and TAB on Vscode to write a short syntax of property.


### 24 - Exception Handling
```C#
try
{
  // Try to run the code that might not work
}
catch (FileNotFoundException e)
{
  // Catch a specific type of eror
}
catch (Exception e)
{
  // Catch any generic error
}
finally
{
  // Finally clean up after yourself (always runs)
}
```