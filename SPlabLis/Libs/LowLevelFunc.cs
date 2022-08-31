using System;
using System.Reflection.Emit;
using System.Reflection;

namespace SPLib
{
    public class LowLevelFunc
    {
        public interface IAdd
        {
            int add(int a, int b);
        }
        public static void SaveDll()
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "AddTwoOperands";
            AssemblyBuilder newAssembly =
            System.Threading.Thread.GetDomain().DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
            ModuleBuilder newModule = newAssembly.DefineDynamicModule("MCOperands", "lowLvlAdd.dll");

            TypeBuilder myType = newModule.DefineType("COperands", TypeAttributes.Public);
            myType.AddInterfaceImplementation(typeof(IAdd));

            Type[] paramTypes = new Type[] {
                typeof(int),typeof(int)
            };
            Type returnType = typeof(int);
            MethodBuilder simpleMethod = myType.DefineMethod("add",
            MethodAttributes.Public | MethodAttributes.Virtual, returnType, paramTypes);

            ILGenerator generator = simpleMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldarg_1);
            generator.Emit(OpCodes.Ldarg_2);
            generator.Emit(OpCodes.Add_Ovf);
            generator.Emit(OpCodes.Ret);
            MethodInfo addInfo = typeof(IAdd).GetMethod("add");

            myType.DefineMethodOverride(simpleMethod, addInfo);

            myType.CreateType();
            newAssembly.Save("lowLvlAdd.dll");
        }
    }
}
