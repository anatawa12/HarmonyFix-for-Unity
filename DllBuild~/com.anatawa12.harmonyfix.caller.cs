namespace Anatawa12.HarmonyFix
{
    class Caller
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        public static void Init()
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(HarmonyFix).TypeHandle);
        }
    }
}

namespace System.Runtime.CompilerServices
{
    class ModuleInitializerAttribute : System.Attribute
    {

    }
}
