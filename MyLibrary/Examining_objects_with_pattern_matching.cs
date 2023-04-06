namespace CSharpBooklib;
public static class Examining_objects_with_pattern_matching {
    public record Rectangle(float Height, float Width);
    public record Circle(float Radius);
    public record Product(float Quantity, float UnitPrice);
    public static Rectangle rectangle => new(10, 0);
    public static Rectangle rectangle2 { get { return new(10, 20); } }
    public static Product product => new(20, 100);

    public static void The_constant_pattern() {
        if (rectangle.Width is 0) {
            Console.WriteLine("The rectangle]s width is 0, it will look like a standing line");
        }
        if (rectangle is not null) {
            Console.WriteLine("The rectangle is defined");
        }
    }
    public static void Type_patterns() {
        if (rectangle2 is Rectangle rect) {
            Console.WriteLine($"The area of rectangle is { rect.Width * rect.Height }");
        }
    }
    public static void Property_patterns() {
        if (rectangle is { Height: 0 }) {
            Console.WriteLine("The rectangle’s height is 0, it will look like a sleeping line");
        }
    }
    /// <summary>
    /// Conjunctive and disjunctive patterns are very much like logical && and || operators to     pair expressions.
    /// The following code snippets join the conditions of checking the Height property of a
    /// rectangle to be greater than 0 and less than or equal to 100 using the and conjunctive
    /// pattern:
    /// </summary>
    public static void Conjunctive_and_disjunctive_patterns() {
        if (rectangle is Rectangle { Height: > 0 and <= 100 }) {
            Console.WriteLine("This is a rectangle with maximum height of 100");
        }
        if (rectangle is Rectangle { Height: < 5 or >= 10000 }) {
            Console.WriteLine("This is a rectangle is either too small or too big");
        }
    }
    public static class Pattern_matching_with_the_switch_expression {
        public static double GetShapeArea(object o) {
            var result = o switch {
                Circle c => (22.0 / 7.0) * c.Radius * c.Radius,
                Rectangle r => r.Width * r.Height,
                _ => throw new ArgumentException("Not recognized shape")
            };
            return result;
        }
        public static float GetProductDiscount(Product product) {
            float discount = product switch {
                Product p when p.Quantity is >= 10 and < 20 =>
                 0.05F,
                Product p when p.Quantity is >= 20 and < 50 =>
                 0.10F,
                Product p when p.Quantity is >= 50 =>
                 0.10F,
                _ => throw new ArgumentException(nameof(product))
            };
            return discount * product.UnitPrice * product.Quantity;
        }
        public static bool Tuple_patterns__AndGate(bool x, bool y) =>
                        (x, y) switch {
                            (false, false) => false,
                            (false, true) => false,
                            (true, false) => false,
                            (true, true) => true
                        };

    }


}
