using System;
//using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface,
  AllowMultiple = true)]
public class AuthorAttribute : System.Attribute
{
    public string Name { get; private set; }

    public AuthorAttribute(string name)
    {
        this.Name = name;
    }
}
[Author("Niki Kostov")]
[Author("Bobi Penev")]
[Author("Gosho Goshev")]
[Author("Pesho Peshev")]
public class CustomAttributesDemo
{
    static void Main(string[] args)
    {
        Type type = typeof(CustomAttributesDemo);
        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (AuthorAttribute authorAttribute in allAttributes)
        {
            Console.WriteLine("The class is written by {0}: ",authorAttribute.Name);
        }
    }
}

