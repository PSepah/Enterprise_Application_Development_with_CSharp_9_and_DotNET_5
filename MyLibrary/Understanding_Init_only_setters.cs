namespace CSharpBooklib;
/// <summary>
/// The following code snippet defines the Order class with OrderId as an init-only setter.
/// This enforces OrderId to be initialized only during object creation:
/// </summary>
public class Understanding_Init_only_setters {
    public int OrderId { get; init; }
    public decimal TotalPrice { get; set; }
}
