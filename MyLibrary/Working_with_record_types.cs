namespace CSharpBooklib;
public class Working_with_record_types {
    public record Shape(string Name);
    public void RunTest() {
        Shape s1 = new Shape("Shape");
        Shape s2 = new Shape("Shape");
        // ToString of record is overwritten to print the properties of the type
        Console.WriteLine(s1.ToString());
        // GetHashCode of record is overwritten to generate the hash code based on values
        Console.WriteLine($"HashCode of s1 is :{ s1.GetHashCode()}");
        Console.WriteLine($"HashCode of s2 is :{ s2.GetHashCode()}");
        // Equality operator of record type is overwritten to check equality based on the values
        Console.WriteLine($"Is s1 equals s2: { s1 == s2}");
    }
}
