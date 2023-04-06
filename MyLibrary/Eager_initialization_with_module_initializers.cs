namespace CSharpBooklib;
using System.Runtime.CompilerServices;
public  class Eager_initialization_with_module_initializers {
    private string field { get; set; }
    public Eager_initialization_with_module_initializers() {
        field = "test";
    }
    /// <summary>
    /// The .NET runtime will execute the method that is marked with the 
    ///    ModuleInitializer attribute when the assembly is first loaded.
    ///    Here are the requirements of the module initializer method:
    ///        • It must be a static method.
    ///        • The return type must be void.
    ///        • It must not be a generic method.
    ///        • It must be a parameter-less method.
    ///        • The method must be accessible from the containing module.
    ///    We will get a compilation error if we do not adhere to these.
    /// </summary>
#pragma warning disable CA2255 // The 'ModuleInitializer' attribute should not be used in libraries
    [ModuleInitializer]
#pragma warning restore CA2255 // The 'ModuleInitializer' attribute should not be used in libraries
    public static void Initialize() {
        Console.WriteLine("Module Initialization");
    }
}
