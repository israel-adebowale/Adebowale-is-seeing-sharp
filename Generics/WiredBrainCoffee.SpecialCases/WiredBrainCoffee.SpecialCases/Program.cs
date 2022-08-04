_ = new Container<string>();
 _ = new Container<string>();
 var container = new Container<int>();

Console.WriteLine($"Container<string>: {Container<string>.InstanceCount}");
Console.WriteLine($"Container<int>: {Container<int>.InstanceCount}");
Console.WriteLine($"Container<bool>: {Container<bool>.InstanceCount}");
Console.WriteLine($"ContainerBase: {ContainerBase.InstanceCountBase}");

container.PrintItem("Hello from generic method in generic class");

var result = Add(2, 3);
Console.WriteLine($"2 + 3 = {result}");

var result2 = Add(2.5, 3.8);
Console.WriteLine($"2.5 + 3.8 = {result2}");

Console.ReadLine();

T Add<T>(T x, T y) where T : notnull
{
    dynamic a = x;
    dynamic b = y;
    return a + b;
}
class ContainerBase
{
    public ContainerBase() => InstanceCountBase++;
    
    public static int InstanceCountBase { get; private set; }
}

class Container<T> : ContainerBase
{
    public Container() => InstanceCount++;

    public static int InstanceCount { get; private set; }
    public void PrintItem<Titem>(Titem item)
    {
        Console.WriteLine($"Item: {item}");
    }
}
