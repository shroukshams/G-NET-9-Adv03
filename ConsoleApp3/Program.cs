
#region Q1: What is a generic class? Why use generics?
///*
//A **generic class** is a class that can operate on data of any type, specified at the time of its instantiation. Instead of being tied to a specific data type (like `int` or `string`), a generic class uses a **type parameter** (e.g., `T`) as a placeholder for the actual data type. This allows the class to be reusable with different types without requiring separate implementations for each type.

//**Why use generics?**
//1.  **Type Safety:** Generics provide type safety without the overhead of casting or the risk of runtime type errors. The compiler enforces type constraints at compile time, catching errors early.
//2.  **Code Reusability:** You can write a single class or method definition that works with various data types, reducing code duplication and making your codebase more maintainable.
//3.  **Performance:** Generics avoid boxing and unboxing operations that occur when using non-generic collections with value types (e.g., `ArrayList` storing `int`s). This leads to better performance and reduced memory allocation.
//4.  **Clarity and Readability:** Code becomes more readable as the intent of working with a specific type is clear, and explicit casting is often eliminated.
//*/
#endregion

#region Q2: Write a generic class Container<T> with Add and Get methods.
//public class Container<T>
//{
//    private T _item;

//    public void Add(T item)
//    {
//        _item = item;
//    }

//    public T Get()
//    {
//        return _item;
//    }
//}

///*
//// Example Usage:
//Container<string> stringContainer = new Container<string>();
//stringContainer.Add("Hello Generics");
//string message = stringContainer.Get(); // message is "Hello Generics"

//Container<int> intContainer = new Container<int>();
//intContainer.Add(123);
//int number = intContainer.Get(); // number is 123
//*/
#endregion

#region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
///*
//**Multiple type parameters** allow a generic type or method to work with more than one placeholder type. Each type parameter is specified independently, enabling the generic construct to handle relationships between different types.
//*/

//public class Pair<TKey, TValue>
//{
//    public TKey Key { get; set; }
//    public TValue Value { get; set; }

//    public Pair(TKey key, TValue value)
//    {
//        Key = key;
//        Value = value;
//    }
//}

///*
//// Example Usage:
//Pair<string, int> studentGrade = new Pair<string, int>("Alice", 95);
//Console.WriteLine($"Student: {studentGrade.Key}, Grade: {studentGrade.Value}");

//Pair<Guid, string> userSession = new Pair<Guid, string>(Guid.NewGuid(), "Active");
//Console.WriteLine($"Session ID: {userSession.Key}, Status: {userSession.Value}");
//*/
#endregion

#region Q4: What is a generic method? Write Swap<T> method.
///*
//A **generic method** is a method declared with type parameters, allowing it to be invoked with arguments of different types. The type parameters are specified when the method is called, making the method reusable across various data types without needing to overload it for each specific type.
//*/

//public class GenericMethods
//{
//    public static void Swap<T>(ref T a, ref T b)
//    {
//        T temp = a;
//        a = b;
//        b = temp;
//    }
//}

///*
//// Example Usage:
//int x = 10, y = 20;
//Console.WriteLine($"Before Swap: x = {x}, y = {y}"); // Output: Before Swap: x = 10, y = 20
//GenericMethods.Swap(ref x, ref y);
//Console.WriteLine($"After Swap: x = {x}, y = {y}");  // Output: After Swap: x = 20, y = 10

//string s1 = "Hello", s2 = "World";
//Console.WriteLine($"Before Swap: s1 = {s1}, s2 = {s2}"); // Output: Before Swap: s1 = Hello, s2 = World
//GenericMethods.Swap(ref s1, ref s2);
//Console.WriteLine($"After Swap: s1 = {s1}, s2 = {s2}");  // Output: After Swap: s1 = World, s2 = Hello
//*/
#endregion

#region Q5: Write a generic method FindMax<T> that finds maximum value
///*
//To find the maximum value, the type `T` must be comparable. This is achieved by applying a constraint that `T` must implement the `IComparable<T>` interface.
//*/

//public class MathOperations
//{
//    public static T FindMax<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b) > 0 ? a : b;
//    }
//}

///*
//// Example Usage:
//int maxInt = MathOperations.FindMax(5, 10); // maxInt is 10
//Console.WriteLine($"Max Int: {maxInt}");

//double maxDouble = MathOperations.FindMax(3.14, 2.71); // maxDouble is 3.14
//Console.WriteLine($"Max Double: {maxDouble}");

//string maxString = MathOperations.FindMax("Apple", "Banana"); // maxString is "Banana"
//Console.WriteLine($"Max String: {maxString}");
//*/
#endregion

#region Q6: What is a generic interface? Write IRepository<T>.
/*
//A **generic interface** is an interface that defines type parameters. This allows the interface to specify contracts that can be implemented by classes for various data types, promoting type-safe and reusable designs for common patterns like repositories, factories, or services.
//*/

//public interface IRepository<T>
//{
//    void Add(T entity);
//    void Update(T entity);
//    void Delete(T entity);
//    T GetById(int id);
//    IEnumerable<T> GetAll();
//}

///*
//// Example Usage (implementation):
//public class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//public class ProductRepository : IRepository<Product>
//{
//    private List<Product> _products = new List<Product>();
//    private int _nextId = 1;

//    public void Add(Product entity)
//    {
//        entity.Id = _nextId++;
//        _products.Add(entity);
//    }

//    public void Update(Product entity)
//    {
//        var existingProduct = _products.FirstOrDefault(p => p.Id == entity.Id);
//        if (existingProduct != null)
//        {
//            existingProduct.Name = entity.Name;
//            existingProduct.Price = entity.Price;
//        }
//    }

//    public void Delete(Product entity)
//    {
//        _products.RemoveAll(p => p.Id == entity.Id);
//    }

//    public Product GetById(int id)
//    {
//        return _products.FirstOrDefault(p => p.Id == id);
//    }

//    public IEnumerable<Product> GetAll()
//    {
//        return _products;
//    }
//}

//// Usage of ProductRepository:
//// IRepository<Product> productRepo = new ProductRepository();
//// productRepo.Add(new Product { Name = "Laptop", Price = 1200m });
//// var laptop = productRepo.GetById(1);
*/
#endregion

#region Q7: What is the 'struct' constraint? Write an example.
/*
The **`struct` constraint** (`where T : struct`) specifies that the type argument must be a non-nullable value type. This includes all structs, enums, and primitive types (like `int`, `double`, `bool`). It ensures that the generic type or method works only with value types, preventing reference types from being used.
//*/

//public class ValueTypeProcessor<T> where T : struct
//{
//    public T Value { get; set; }

//    public ValueTypeProcessor(T value)
//    {
//        Value = value;
//    }

//    public void DisplayValue()
//    {
//        Console.WriteLine($"The value is: {Value} (Type: {typeof(T).Name})");
//    }
//}

///*
//// Example Usage:
//ValueTypeProcessor<int> intProcessor = new ValueTypeProcessor<int>(100);
//intProcessor.DisplayValue(); // Output: The value is: 100 (Type: Int32)

//ValueTypeProcessor<double> doubleProcessor = new ValueTypeProcessor<double>(99.99);
//doubleProcessor.DisplayValue(); // Output: The value is: 99.99 (Type: Double)

//// ValueTypeProcessor<string> stringProcessor = new ValueTypeProcessor<string>("test"); // Compile-time error: 'string' must be a non-nullable value type
//*/
#endregion

#region Q8: What is the 'class' constraint? Write an example.
///*
//The **`class` constraint** (`where T : class`) specifies that the type argument must be a reference type. This includes classes, interfaces, delegates, and arrays. It ensures that the generic type or method works only with reference types, preventing value types from being used.
//*/

//public class ReferenceTypeProcessor<T> where T : class
//{
//    public T Data { get; set; }

//    public ReferenceTypeProcessor(T data)
//    {
//        Data = data;
//    }

//    public bool IsNull()
//    {
//        return Data == null;
//    }
//}

///*
//// Example Usage:
//ReferenceTypeProcessor<string> stringProcessor = new ReferenceTypeProcessor<string>("Hello");
//Console.WriteLine($"Is string data null? {stringProcessor.IsNull()}"); // Output: Is string data null? False

//ReferenceTypeProcessor<List<int>> listProcessor = new ReferenceTypeProcessor<List<int>>(null);
//Console.WriteLine($"Is list data null? {listProcessor.IsNull()}"); // Output: Is list data null? True

//// ReferenceTypeProcessor<int> intProcessor = new ReferenceTypeProcessor<int>(10); // Compile-time error: 'int' must be a reference type
//*/
#endregion

#region Q9: What is the 'new()' constraint? Write an example.
///*
//The **`new()` constraint** (`where T : new()`) specifies that the type argument must have a public parameterless constructor. This allows the generic type or method to create new instances of `T` using `new T()`. This constraint must be the last constraint specified for a type parameter.
//*/

//public class Factory<T> where T : new()
//{
//    public T CreateInstance()
//    {
//        return new T();
//    }
//}

//public class MyClass
//{
//    public string Name { get; set; }
//    public MyClass() { Name = "Default"; }
//}

//public class AnotherClass
//{
//    public AnotherClass(string name) { /* ... */ }
//}

///*
//// Example Usage:
//Factory<MyClass> myClassFactory = new Factory<MyClass>();
//MyClass instance = myClassFactory.CreateInstance();
//Console.WriteLine($"Created instance of MyClass with Name: {instance.Name}"); // Output: Created instance of MyClass with Name: Default

//// Factory<AnotherClass> anotherClassFactory = new Factory<AnotherClass>(); // Compile-time error: 'AnotherClass' must have a public parameterless constructor
//*/
#endregion

#region Q10: What is the interface constraint? Write an example.
///*
//The **interface constraint** (`where T : IMyInterface`) specifies that the type argument must implement the specified interface (or inherit from the specified class). This allows the generic type or method to access members defined by that interface, ensuring that the type argument provides certain functionalities.
//*/

//public interface ILoggable
//{
//    void LogMessage(string message);
//}

//public class Logger<T> where T : ILoggable
//{
//    public void Log(T item, string message)
//    {
//        item.LogMessage($"Logging for {typeof(T).Name}: {message}");
//    }
//}

//public class Event : ILoggable
//{
//    public string Description { get; set; }
//    public void LogMessage(string message)
//    {
//        Console.WriteLine($"Event Log: {message} - Description: {Description}");
//    }
//}

//public class TaskItem : ILoggable
//{
//    public string Title { get; set; }
//    public void LogMessage(string message)
//    {
//        Console.WriteLine($"Task Log: {message} - Title: {Title}");
//    }
//}

///*
//// Example Usage:
//Logger<Event> eventLogger = new Logger<Event>();
//Event myEvent = new Event { Description = "User Login" };
//eventLogger.Log(myEvent, "Successful login attempt.");
//// Output: Event Log: Logging for Event: Successful login attempt. - Description: User Login

//Logger<TaskItem> taskLogger = new Logger<TaskItem>();
//TaskItem myTask = new TaskItem { Title = "Complete Report" };
//taskLogger.Log(myTask, "Task started.");
//// Output: Task Log: Logging for TaskItem: Task started. - Title: Complete Report

//// public class SimpleClass { /* ... */ }
//// Logger<SimpleClass> simpleLogger = new Logger<SimpleClass>(); // Compile-time error: 'SimpleClass' does not implement 'ILoggable'
//*/
#endregion

#region Q11: What is the base class constraint? Write an example.
/*
The **base class constraint** (`where T : MyBaseClass`) specifies that the type argument must be, or inherit from, the specified base class. This allows the generic type or method to access members (public, protected, internal) defined in the base class, ensuring that the type argument has a common set of functionalities or properties.
*/

public abstract class Animal
{
    public string Name { get; set; }
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name) { Name = name; }
    public override void MakeSound() { Console.WriteLine($"{Name} barks."); }
}

public class Cat : Animal
{
    public Cat(string name) { Name = name; }
    public override void MakeSound() { Console.WriteLine($"{Name} meows."); }
}

public class AnimalShelter<T> where T : Animal
{
    private List<T> _animals = new List<T>();

    public void AdmitAnimal(T animal)
    {
        _animals.Add(animal);
        Console.WriteLine($"Admitted {animal.Name} to the shelter.");
    }

    public void MakeAllSounds()
    {
        foreach (var animal in _animals)
        {
            animal.MakeSound();
        }
    }
}

/*
// Example Usage:
AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
dogShelter.AdmitAnimal(new Dog("Buddy"));
dogShelter.AdmitAnimal(new Dog("Lucy"));
dogShelter.MakeAllSounds();
// Output:
// Admitted Buddy to the shelter.
// Admitted Lucy to the shelter.
// Buddy barks.
// Lucy meows.

AnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();
catShelter.AdmitAnimal(new Cat("Whiskers"));
catShelter.MakeAllSounds();
// Output:
// Admitted Whiskers to the shelter.
// Whiskers meows.

// public class Rock { /* ... */ }
// AnimalShelter<Rock> rockShelter = new AnimalShelter<Rock>(); // Compile-time error: 'Rock' must be a 'Animal' to use it as parameter 'T'
*/
#endregion

#region Q12: How do you apply multiple constraints? Write an example.
/*
Multiple constraints can be applied to a single type parameter by listing them after the `where` keyword, separated by commas. This allows for more specific requirements on the type argument, combining the functionalities or characteristics of several constraints.

**Order of constraints:**
1.  The base class constraint (if any) must be specified first.
2.  Interface constraints can follow in any order.
3.  The `new()` constraint (if any) must be specified last.
4.  `struct` or `class` constraints are mutually exclusive and cannot be combined with a base class constraint (as a base class is implicitly a reference type, and `struct` is a value type).
*/

public interface IIdentifiable
{
    int Id { get; }
}

public interface IAuditable
{
    DateTime CreatedDate { get; set; }
}

public class Entity : IIdentifiable, IAuditable
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Name { get; set; }

    public Entity() { CreatedDate = DateTime.Now; }
}

public class DataProcessor<T> where T : Entity, IIdentifiable, IAuditable, new()
{
    public T CreateAndProcess(int id, string name)
    {
        T item = new T(); // Requires new() constraint
        item.Id = id;
        item.Name = name;
        // item.CreatedDate is set by constructor, but also accessible due to IAuditable
        Console.WriteLine($"Processing entity: Id={item.Id}, Name={item.Name}, Created={item.CreatedDate}");
        return item;
    }
}

/*
// Example Usage:
DataProcessor<Entity> processor = new DataProcessor<Entity>();
Entity myEntity = processor.CreateAndProcess(1, "Sample Item");
// Output: Processing entity: Id=1, Name=Sample Item, Created=...

// If Entity did not implement IIdentifiable, IAuditable, or have a parameterless constructor, this would be a compile-time error.
*/
#endregion

#region Q13: What does the 'default' keyword do in generics?
/*
The **`default` keyword** in generics provides the default value for a type parameter `T`. Its behavior depends on whether `T` is a value type or a reference type:

*   For **value types** (e.g., `int`, `struct`), `default(T)` returns the default value for that type (e.g., `0` for `int`, `false` for `bool`, or an all-zero initialized struct).
*   For **reference types** (e.g., `class`, `interface`), `default(T)` returns `null`.

This is particularly useful when you need to initialize a generic type variable or return a default value without knowing the specific type at compile time, ensuring type safety and avoiding uninitialized variables.
*/

public class DefaultValueExample
{
    public static T GetDefaultValue<T>()
    {
        return default(T);
    }
}

/*
// Example Usage:
int defaultInt = DefaultValueExample.GetDefaultValue<int>();       // 0
string defaultString = DefaultValueExample.GetDefaultValue<string>(); // null
bool defaultBool = DefaultValueExample.GetDefaultValue<bool>();     // false

Console.WriteLine($"Default int: {defaultInt}");
Console.WriteLine($"Default string: {defaultString ?? "(null)"}");
Console.WriteLine($"Default bool: {defaultBool}");
*/
#endregion

#region Q14: Write a SafeList<T> that returns default when the index is invalid.
/*
This `SafeList<T>` class demonstrates the use of `default(T)` to provide a safe way to access elements. If an invalid index is provided, it returns the default value for the type `T` instead of throwing an `IndexOutOfRangeException`.
*/

using System.Collections.Generic;

public class SafeList<T>
{
    private List<T> _list = new List<T>();

    public void Add(T item)
    {
        _list.Add(item);
    }

    public T Get(int index)
    {
        if (index >= 0 && index < _list.Count)
        {
            return _list[index];
        }
        return default(T); // Returns default value for T if index is invalid
    }

    public int Count => _list.Count;
}

/*
// Example Usage:
SafeList<string> names = new SafeList<string>();
names.Add("Alice");
names.Add("Bob");

Console.WriteLine($"Name at index 0: {names.Get(0)}"); // Output: Name at index 0: Alice
Console.WriteLine($"Name at index 1: {names.Get(1)}"); // Output: Name at index 1: Bob
Console.WriteLine($"Name at index 2 (invalid): {names.Get(2) ?? "(null)"}"); // Output: Name at index 2 (invalid): (null)

SafeList<int> numbers = new SafeList<int>();
numbers.Add(10);
Console.WriteLine($"Number at index 0: {numbers.Get(0)}"); // Output: Number at index 0: 10
Console.WriteLine($"Number at index 1 (invalid): {numbers.Get(1)}"); // Output: Number at index 1 (invalid): 0
*/
#endregion

#region Q15: What is covariance? Explain the 'out' keyword.
/*
**Covariance** allows a generic type parameter to be assigned a more derived type than that specified by the generic. In C#, covariance applies to generic interfaces and delegates, specifically when the type parameter is used only as a return type (output) from the interface or delegate's methods.

The **`out` keyword** is used to mark a generic type parameter as covariant. This means that if you have a generic interface `IProducer<out T>`, and `Derived` inherits from `Base`, then `IProducer<Derived>` can be implicitly converted to `IProducer<Base>`. The `out` keyword ensures that `T` can only appear in 
an "out" position (e.g., as a method return type, but not as a method argument).
*/

public class Animal { public string Name { get; set; } }
public class Dog : Animal { }

public interface IReadOnlyListCovariant<out T>
{
    T GetItem(int index);
    int Count { get; }
}

public class DogList : IReadOnlyListCovariant<Dog>
{
    private List<Dog> _dogs = new List<Dog>();

    public DogList(IEnumerable<Dog> dogs)
    {
        _dogs.AddRange(dogs);
    }

    public Dog GetItem(int index)
    {
        if (index >= 0 && index < _dogs.Count)
        {
            return _dogs[index];
        }
        return null;
    }

    public int Count => _dogs.Count;
}

/*
// Example Usage:
Dog[] dogs = { new Dog { Name = "Buddy" }, new Dog { Name = "Lucy" } };
IReadOnlyListCovariant<Dog> dogList = new DogList(dogs);

// Covariance in action: IReadOnlyListCovariant<Dog> can be assigned to IReadOnlyListCovariant<Animal>
IReadOnlyListCovariant<Animal> animalList = dogList;

Console.WriteLine($"First animal in list: {animalList.GetItem(0).Name}"); // Output: First animal in list: Buddy
*/
#endregion

#region Q16: What is contravariance? Explain the 'in' keyword.
/*
**Contravariance** allows a generic type parameter to be assigned a more generic type than that specified by the generic. In C#, contravariance applies to generic interfaces and delegates, specifically when the type parameter is used only as an argument type (input) to the interface or delegate’s methods.

The **`in` keyword** is used to mark a generic type parameter as contravariant. This means that if you have a generic interface `IComparer<in T>`, and `Base` is a base class of `Derived`, then `IComparer<Base>` can be implicitly converted to `IComparer<Derived>`. The `in` keyword ensures that `T` can only appear in an "in" position (e.g., as a method argument, but not as a method return type).
*/

public class Person { public string Name { get; set; } }
public class Employee : Person { }

public interface IComparerContravariant<in T>
{
    int Compare(T x, T y);
}

public class PersonComparer : IComparerContravariant<Person>
{
    public int Compare(Person x, Person y)
    {
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
}

/*
// Example Usage:
IComparerContravariant<Person> personComparer = new PersonComparer();

// Contravariance in action: IComparerContravariant<Person> can be assigned to IComparerContravariant<Employee>
IComparerContravariant<Employee> employeeComparer = personComparer;

Employee emp1 = new Employee { Name = "Alice" };
Employee emp2 = new Employee { Name = "Bob" };

int result = employeeComparer.Compare(emp1, emp2);
Console.WriteLine($"Comparison result for employees: {result}"); // Output: Comparison result for employees: -1 (Alice < Bob)
*/
#endregion

#region Q17: What is the difference between covariance and contravariance?
/*
| Feature           | Covariance (`out`)                               | Contravariance (`in`)                               |
| :---------------- | :----------------------------------------------- | :-------------------------------------------------- |
| **Direction**     | Preserves assignment compatibility (more derived to more generic) | Reverses assignment compatibility (more generic to more derived) |
| **Keyword**       | `out`                                            | `in`                                                |
| **Usage in API**  | Type parameter used as a return type (output)    | Type parameter used as an argument type (input)     |
| **Example**       | `IEnumerable<out T>`, `IComparable<out T>` (in some contexts) | `IComparer<in T>`, `Action<in T>`                   |
| **Analogy**       | You can use a list of `Dog` where a list of `Animal` is expected (outputting `Animal`s). | You can use a comparer for `Animal` where a comparer for `Dog` is expected (inputting `Dog`s). |

In essence, **covariance** allows you to use a more specific type where a less specific type is expected (e.g., `List<Dog>` as `List<Animal>`), primarily for outputting values. **Contravariance** allows you to use a less specific type where a more specific type is expected (e.g., `IComparer<Animal>` as `IComparer<Dog>`), primarily for consuming values.
*/
#endregion

#region Q18: How do static members work in generic types?
/*
**Static members in generic types** are unique for each closed constructed type. This means that if you have a generic class `MyGenericClass<T>`, `MyGenericClass<int>.StaticField` is a completely separate field from `MyGenericClass<string>.StaticField`.

Each unique combination of type arguments creates a distinct static member. This is different from non-generic classes where static members are shared across all instances of the class.
*/

public class GenericStaticExample<T>
{
    public static int Counter { get; set; }

    public GenericStaticExample()
    {
        Counter++;
    }

    public static void DisplayCounter()
    {
        Console.WriteLine($"Counter for {typeof(T).Name}: {Counter}");
    }
}

/*
// Example Usage:
new GenericStaticExample<int>();
new GenericStaticExample<int>();
GenericStaticExample<int>.DisplayCounter(); // Output: Counter for Int32: 2

new GenericStaticExample<string>();
GenericStaticExample<string>.DisplayCounter(); // Output: Counter for String: 1

GenericStaticExample<int>.DisplayCounter(); // Output: Counter for Int32: 2 (still 2, not affected by string instance)
*/
#endregion

#region Q19: How can you inherit from a generic class?
/*
You can inherit from a generic class in a few ways:

1.  **By providing concrete type arguments:** The derived class is no longer generic.
2.  **By passing its own type parameters to the base generic class:** The derived class remains generic.
3.  **By combining concrete types and its own type parameters.**

When inheriting, the base class's generic type parameters must be satisfied.
*/

// Base generic class
public class BaseGenericClass<T>
{
    public T Value { get; set; }

    public BaseGenericClass(T value)
    {
        Value = value;
    }

    public void DisplayValue()
    {
        Console.WriteLine($"Base value ({typeof(T).Name}): {Value}");
    }
}

// 1. Derived class with concrete type argument
public class SpecificDerivedClass : BaseGenericClass<string>
{
    public SpecificDerivedClass(string value) : base(value) { }

    public void DisplaySpecificValue()
    {
        Console.WriteLine($"Specific derived value: {Value.ToUpper()}");
    }
}

// 2. Derived class passing its own type parameter
public class GenericDerivedClass<T> : BaseGenericClass<T>
{
    public GenericDerivedClass(T value) : base(value) { }

    public void DisplayGenericDerivedValue()
    {
        Console.WriteLine($"Generic derived value ({typeof(T).Name}): {Value}");
    }
}

// 3. Derived class with its own type parameter and a concrete type for the base
public class MixedDerivedClass<TId> : BaseGenericClass<string>
{
    public TId Id { get; set; }

    public MixedDerivedClass(string value, TId id) : base(value)
    {
        Id = id;
    }

    public void DisplayMixedValue()
    {
        Console.WriteLine($"Mixed derived value (Base: {Value}, Id: {Id})");
    }
}

/*
// Example Usage:
SpecificDerivedClass specific = new SpecificDerivedClass("hello");
specific.DisplayValue();
specific.DisplaySpecificValue();
// Output:
// Base value (String): hello
// Specific derived value: HELLO

GenericDerivedClass<int> genericDerived = new GenericDerivedClass<int>(123);
genericDerived.DisplayValue();
genericDerived.DisplayGenericDerivedValue();
// Output:
// Base value (Int32): 123
// Generic derived value (Int32): 123

MixedDerivedClass<Guid> mixedDerived = new MixedDerivedClass<Guid>("item", Guid.NewGuid());
mixedDerived.DisplayValue();
mixedDerived.DisplayMixedValue();
// Output:
// Base value (String): item
// Mixed derived value (Base: item, Id: ...)
*/
#endregion

#region Q20: Complete Exercise - Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
/*
This `Cache<TKey, TValue>` class provides a simple in-memory cache with basic operations and an expiration mechanism. It uses a `Dictionary` internally to store cache entries, where each entry includes the value and its expiration time.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Cache<TKey, TValue>
{
    private class CacheEntry
    {
        public TValue Value { get; set; }
        public DateTime ExpirationTime { get; set; }
    }

    private readonly Dictionary<TKey, CacheEntry> _cache = new Dictionary<TKey, CacheEntry>();
    private readonly TimeSpan _defaultExpiration;

    public Cache(TimeSpan defaultExpiration)
    {
        _defaultExpiration = defaultExpiration;
    }

    /// <summary>
    /// Adds an item to the cache with the default expiration.
    /// </summary>
    public void Add(TKey key, TValue value)
    {
        Add(key, value, _defaultExpiration);
    }

    /// <summary>
    /// Adds an item to the cache with a specified expiration duration.
    /// </summary>
    public void Add(TKey key, TValue value, TimeSpan duration)
    {
        var expirationTime = DateTime.UtcNow.Add(duration);
        _cache[key] = new CacheEntry { Value = value, ExpirationTime = expirationTime };
        Console.WriteLine($"Added item with key '{key}'. Expires at {expirationTime.ToLocalTime()}");
    }

    /// <summary>
    /// Retrieves an item from the cache. Returns default(TValue) if not found or expired.
    /// </summary>
    public TValue Get(TKey key)
    {
        if (_cache.TryGetValue(key, out var entry))
        {
            if (entry.ExpirationTime > DateTime.UtcNow)
            {
                Console.WriteLine($"Retrieved item with key '{key}'.");
                return entry.Value;
            }
            else
            {
                // Item expired, remove it
                _cache.Remove(key);
                Console.WriteLine($"Item with key '{key}' expired and removed.");
            }
        }
        Console.WriteLine($"Item with key '{key}' not found or already expired.");
        return default(TValue);
    }

    /// <summary>
    /// Removes an item from the cache.
    /// </summary>
    public bool Remove(TKey key)
    {
        if (_cache.Remove(key))
        {
            Console.WriteLine($"Removed item with key '{key}'.");
            return true;
        }
        Console.WriteLine($"Item with key '{key}' not found for removal.");
        return false;
    }

    /// <summary>
    /// Checks if the cache contains an active item for the given key.
    /// </summary>
    public bool Contains(TKey key)
    {
        if (_cache.TryGetValue(key, out var entry))
        {
            if (entry.ExpirationTime > DateTime.UtcNow)
            {
                Console.WriteLine($"Cache contains active item for key '{key}'.");
                return true;
            }
            else
            {
                // Item expired, remove it
                _cache.Remove(key);
                Console.WriteLine($"Item with key '{key}' expired and removed during Contains check.");
            }
        }
        Console.WriteLine($"Cache does not contain active item for key '{key}'.");
        return false;
    }

    /// <summary>
    /// Cleans up all expired items from the cache.
    /// </summary>
    public void CleanUpExpiredItems()
    {
        var expiredKeys = _cache.Where(kvp => kvp.Value.ExpirationTime <= DateTime.UtcNow)
                                 .Select(kvp => kvp.Key)
                                 .ToList();

        foreach (var key in expiredKeys)
        {
            _cache.Remove(key);
            Console.WriteLine($"Cleaned up expired item with key '{key}'.");
        }
        if (!expiredKeys.Any())
        {
            Console.WriteLine("No expired items to clean up.");
        }
    }

    public int CountActiveItems()
    {
        CleanUpExpiredItems(); // Ensure only active items are counted
        return _cache.Count;
    }
}

/*
// Example Usage:
Console.WriteLine("\n--- Cache Example ---");
var myCache = new Cache<string, string>(TimeSpan.FromSeconds(5)); // Default expiration of 5 seconds

myCache.Add("user:1", "Alice", TimeSpan.FromSeconds(10)); // Custom expiration
myCache.Add("product:101", "Laptop"); // Default expiration
myCache.Add("session:abc", "ActiveSessionData", TimeSpan.FromSeconds(2));

Console.WriteLine($"Get user:1: {myCache.Get("user:1")}");
Console.WriteLine($"Contains product:101: {myCache.Contains("product:101")}");

System.Threading.Thread.Sleep(3000); // Wait for 3 seconds

Console.WriteLine($"Get session:abc after 3s: {myCache.Get("session:abc") ?? "(null)"}"); // Should be expired
Console.WriteLine($"Contains session:abc after 3s: {myCache.Contains("session:abc")}");

Console.WriteLine($"Get product:101 after 3s: {myCache.Get("product:101")}"); // Still active

myCache.Remove("user:1");
Console.WriteLine($"Contains user:1 after removal: {myCache.Contains("user:1")}");

System.Threading.Thread.Sleep(3000); // Wait for another 3 seconds (total 6s)

Console.WriteLine($"Get product:101 after 6s: {myCache.Get("product:101") ?? "(null)"}"); // Should be expired
Console.WriteLine($"Active items in cache: {myCache.CountActiveItems()}");
*/
#endregion
