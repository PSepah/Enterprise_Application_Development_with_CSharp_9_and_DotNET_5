namespace CSharpBooklib;

public class Understanding_static_anonymous_functions {
    /// <summary>
    /// An anonymous function is a set of statements or expressions that can be used or executed 
    ///  whenever a delegate type is expected.With the use of anonymous functions, we might
    ///  get unintended behavior if we accidentally refer to a local variable inside an anonymous
    ///  function.With the use of static anonymous functions, we can avoid unintentional use of
    ///  he state or local variables.
    ///  onsider the following code snippet to understand static anonymous functions:
    /// </summary>
    string formatString = "order id "; //bad format string value
    public void GenerateSummary(string[] args) {
        var tmp = GenerateOrderReport(() =>
        {
            return formatString;
        });
    }
    /// <summary>
    /// From the preceding code, we see that the GenerateOrderReport function takes a 
    /// function argument that takes the format string. The anonymous function that is passed
    /// into GenerateOrderReport returns the formatString instance format string value.
    /// If the intent here is to have a format string to generate the report for an order, we will get
    /// unintended results.We will not get any compilation errors as the code is legally correct. 
    /// To address such errors, we can leverage static anonymous functions, as follows:
    /// </summary>
    public void GenerateSummary2(string[] args) {
        var tmp = GenerateOrderReport(static () =>
        {
            // return formatString; // Will get error
            return "Order Id:{0}, Order Date:{1}";
        });
    }
    /// <summary>
    ///  Changing the anonymous function to a static anonymous function as shown in the 
    ///  preceding code snippet will result in a compilation error as a non-static variable is used in 
    ///  a static function.This will force the developer to fix the right format string.
    ///  In the next section, let’s learn about the module initializer, which will help execute eager
    ///  initialization code when the assembly is loaded
    /// </summary>
    public void GenerateSummary3(string[] args) {
       var tmp= GenerateOrderReport2("Order Id:{0}, Order Date:{1}");
    }
    static string GenerateOrderReport(Func<string> getFormatString) {
        var order = new {
            Orderid = 1,
            OrderDate = DateTime.Now
        };
        return string.Format(getFormatString(), order.Orderid, order.OrderDate);
    }
    static string GenerateOrderReport2(string formatString) {
        var order = new {
            Orderid = 1,
            OrderDate = DateTime.Now
        };
        return string.Format(formatString, order.Orderid, order.OrderDate);
    }
}
