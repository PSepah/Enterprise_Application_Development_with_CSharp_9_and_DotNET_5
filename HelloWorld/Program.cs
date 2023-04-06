using CSharpBooklib;
using System.Text;
#region How to Use the “Using Static” Feature in C#
    /// <summary>
    ///     the following codes show how to use static classes in a short way
    ///     How do I use the C#6 "Using static" feature:
    ///     https://stackoverflow.com/questions/31852389/how-do-i-use-the-c6-using-static-feature
    ///     How to Use the “Using Static” Feature in C#
    ///     https://code-maze.com/using-static-feature-csharp/
    /// </summary>
    using static CSharpBooklib.Examining_objects_with_pattern_matching;
    using static CSharpBooklib.Examining_objects_with_pattern_matching.Pattern_matching_with_the_switch_expression;
#endregion
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
#region Introducing C# 9
    #region Understanding top-level statements
        /// <summary>
        /// <code>
        /// using System;
        /// namespace TopLevelStatements {
        ///    class Program {
        ///         static void Main(string[] args) {
        ///             Console.WriteLine(“Hello World!”);
        ///         }
        ///     }
        /// }
        /// </code>
        /// 1- Using system is added implicity
        /// 2- "namespace TopLevelStatements {...}" is changed to "namespace TopLevelStatements;"
        /// 3- All above ceromony codes is deleted and remained only :  Console.WriteLine(“Hello World!”);
        /// 4-  Only one file in the application can have top-level arguments as there can be only one 
        ///     entry point to the application. If more than one file contains top-level statements, it will 
        ///     show a compilation error. We can access the command-line arguments passed with the 
        ///     args variable name as shown in the following code:    
        /// </summary>
        foreach (var v in args) {
                System.Console.WriteLine(v);
        }
    #endregion
    #region Understanding Init only setters 
        var myOrder = new Understanding_Init_only_setters {
            OrderId = 120,
            TotalPrice = 200
        };
    #endregion
    #region Working with record types
        var recordTypeTest = new Working_with_record_types();
        recordTypeTest.RunTest();
    #endregion
    #region The with expression
        The_with_expression.PersonType Person = new("Ali", "Kamali");
        The_with_expression.PersonType Person2 = Person with { name = "Reza" };
#endregion
    #region Examining_objects_with_pattern_matching
        The_constant_pattern();
        Type_patterns();
        Property_patterns();
        Conjunctive_and_disjunctive_patterns();
        #region Pattern_matching_with_the_switch_expression
            GetShapeArea(new Rectangle(10, 20));
            GetShapeArea(new Circle(2));
            GetProductDiscount(new Product(20, 1000));
            var result = Tuple_patterns__AndGate(true, false);
            result = Tuple_patterns__AndGate(true, true);
    #endregion
    #endregion
    #region Understanding type inference with targettyped expressions
    /// <summary>
    /// Target-typed expressions remove redundant mentions of the type when creating an object. 
    /// With target-typed expressions, the type is inferred from the context it is used in. In C#, we 
    /// use the new keyword to instantiate an object by specifying the type. To create an object of 
    /// StringBuilder, the following is an example code snippet:
    /// </summary>
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new ();
#endregion
    #region Understanding static anonymous functions
        Understanding_static_anonymous_functions x = new();
        x.GenerateSummary(new string[] {});
        x.GenerateSummary2(new string[] {});
        x.GenerateSummary3(new string[] { });
    #endregion
    #region Eager initialization with module initializers
            Eager_initialization_with_module_initializers y = new();
    #endregion
#endregion
app.MapGet("/", () => "Hello World!");

app.Run();