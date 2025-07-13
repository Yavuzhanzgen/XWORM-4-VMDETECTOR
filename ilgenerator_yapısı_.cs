using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

// Token: 0x02000440 RID: 1088
internal sealed class Class237
{
	// Token: 0x06002B23 RID: 11043 RVA: 0x001F17B0 File Offset: 0x001EF9B0
	static Class237()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Class237.delegate5_0 = new Class237.Delegate5(Class237.smethod_1);
		Stream stream = Class255.smethod_0(executingAssembly.GetManifestResourceStream(Class237.delegate5_0(0)));
		Class237.string_0 = new Class237.Class238().method_1(stream);
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x00008419 File Offset: 0x00006619
	public static string smethod_0(int int_0)
	{
		return (string)((Hashtable)AppDomain.CurrentDomain.GetData(Class237.string_0))[int_0];
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x001F17FC File Offset: 0x001EF9FC
	public static string smethod_1(int int_0)
	{
		char[] array = "\u001e\u0001\u0017\u0013".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] = (char)((int)(array[num] ^ 'd') ^ int_0);
		}
		return new string(array);
	}

	// Token: 0x040014B6 RID: 5302
	private static string string_0;

	// Token: 0x040014B7 RID: 5303
	private static Class237.Delegate5 delegate5_0;

	// Token: 0x02000441 RID: 1089
	// (Invoke) Token: 0x06002B28 RID: 11048
	private delegate string Delegate5(int int_0);

	// Token: 0x02000442 RID: 1090
	private sealed class Class238
	{
		// Token: 0x06002B2B RID: 11051 RVA: 0x001F1834 File Offset: 0x001EFA34
		public MethodBuilder method_0(TypeBuilder typeBuilder_0)
		{
			MethodAttributes methodAttributes = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig;
			byte[] array = Convert.FromBase64String("KLTBeaTJVZ/Xa63BGLnbYq+KOr7BaKzGF7SJSqTQPqPGf7jlCL7XYKPIAvbVaLX7PbjeYY/FFqiJYrH7MqPXfLTFF6TGdPrDHrntQaTKHLnaNobBD5nLfaTiCaLfRaDKH6HXNqbBD5L8bKzBQITcaaTcNKuJX6TFH57Gf6jKHPbzaaWfHKjGUpHLCKTGZK7KQKrXeZ7nDr/AaK/QP6LfbKjKQJ7XeYXFD6yJOvWQTvbzfrLBFq/edJLBCbvXf/r3EqDCYaTlCL7XYKPIAojKfa3LCajANqPFGajee6yfCKDdZqTQHr7G");
			for (int i = 0; i < array.Length; i++)
			{
				switch (i % 6)
				{
				case 0:
					array[i] ^= 123;
					break;
				case 1:
					array[i] ^= 205;
					break;
				case 2:
					array[i] ^= 178;
					break;
				case 3:
					array[i] ^= 13;
					break;
				case 4:
					array[i] ^= 193;
					break;
				case 5:
					array[i] ^= 164;
					break;
				}
			}
			string[] array2 = Encoding.UTF8.GetString(array).Split(new char[] { ';' });
			MethodBuilder methodBuilder = typeBuilder_0.DefineMethod("?", methodAttributes);
			Type type = Type.GetType(array2[0]);
			MethodInfo method = type.GetMethod(array2[1], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method2 = type.GetMethod(array2[2], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method3 = typeof(string).GetMethod(array2[7], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(string),
				typeof(StringComparison)
			}, null);
			MethodInfo method4 = typeof(Stream).GetMethod(array2[4], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			ConstructorInfo constructor = typeof(BinaryReader).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[] { typeof(Stream) }, null);
			ConstructorInfo constructor2 = typeof(Hashtable).GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method5 = typeof(BinaryReader).GetMethod(array2[8], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method6 = typeof(Hashtable).GetMethod(array2[9], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(object),
				typeof(object)
			}, null);
			MethodInfo method7 = typeof(Stream).GetMethod(array2[10], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method8 = typeof(AppDomain).GetMethod(array2[11], BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);
			MethodInfo method9 = typeof(AppDomain).GetMethod(array2[12], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(string),
				typeof(object)
			}, null);
			methodBuilder.SetReturnType(typeof(string));
			methodBuilder.SetParameters(new Type[] { typeof(Stream) });
			methodBuilder.DefineParameter(1, ParameterAttributes.None, "a");
			ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			ilgenerator.DeclareLocal(typeof(int));
			ilgenerator.DeclareLocal(type);
			ilgenerator.DeclareLocal(typeof(long));
			ilgenerator.DeclareLocal(typeof(BinaryReader));
			ilgenerator.DeclareLocal(typeof(Hashtable));
			ilgenerator.DeclareLocal(typeof(string));
			ilgenerator.DeclareLocal(typeof(string));
			Label label = ilgenerator.DefineLabel();
			Label label2 = ilgenerator.DefineLabel();
			Label label3 = ilgenerator.DefineLabel();
			Label label4 = ilgenerator.DefineLabel();
			Label label5 = ilgenerator.DefineLabel();
			int num = int.Parse(array2[13]);             //7445
			ilgenerator.Emit(OpCodes.Ldc_I4, num);
			ilgenerator.Emit(OpCodes.Stloc_0);
			ilgenerator.Emit(OpCodes.Call, method);    //
			ilgenerator.Emit(OpCodes.Stloc_1);
			ilgenerator.Emit(OpCodes.Ldloc_1);
			ilgenerator.Emit(OpCodes.Brfalse_S, label);
			ilgenerator.Emit(OpCodes.Ldloc_1);
			ilgenerator.Emit(OpCodes.Callvirt, method2); 
			ilgenerator.Emit(OpCodes.Stloc_S, 6); // sonucu 6 nolu değişkene ata
			ilgenerator.Emit(OpCodes.Ldloc_S, 6); // Load local variable_Short 
			ilgenerator.Emit(OpCodes.Ldstr, array2[14]);
			ilgenerator.Emit(OpCodes.Ldc_I4_5);
			ilgenerator.Emit(OpCodes.Callvirt, method3);
			ilgenerator.Emit(OpCodes.Ldc_I4_M1);
			ilgenerator.Emit(OpCodes.Bne_Un_S, label2);
			ilgenerator.Emit(OpCodes.Ldloc_S, 6);
			ilgenerator.Emit(OpCodes.Ldstr, array2[15]);
			ilgenerator.Emit(OpCodes.Ldc_I4_5);
			ilgenerator.Emit(OpCodes.Callvirt, method3);
			ilgenerator.Emit(OpCodes.Ldc_I4_M1);
			ilgenerator.Emit(OpCodes.Bne_Un_S, label2);
			ilgenerator.Emit(OpCodes.Ldloc_S, 6);
			ilgenerator.Emit(OpCodes.Ldstr, array2[16]);
			ilgenerator.Emit(OpCodes.Ldc_I4_5);
			ilgenerator.Emit(OpCodes.Callvirt, method3);
			ilgenerator.Emit(OpCodes.Ldc_I4_M1);
			ilgenerator.Emit(OpCodes.Bne_Un_S, label2);
			ilgenerator.Emit(OpCodes.Ldloc_S, 6);
			ilgenerator.Emit(OpCodes.Ldstr, array2[17]);
			ilgenerator.Emit(OpCodes.Ldc_I4_5);
			ilgenerator.Emit(OpCodes.Callvirt, method3);
			ilgenerator.Emit(OpCodes.Ldc_I4_M1);
			ilgenerator.Emit(OpCodes.Beq_S, label);
			ilgenerator.MarkLabel(label2);
			ilgenerator.Emit(OpCodes.Ldc_I4_0);
			ilgenerator.Emit(OpCodes.Stloc_0);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Callvirt, method4);
			ilgenerator.Emit(OpCodes.Stloc_2);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Newobj, constructor);
			ilgenerator.Emit(OpCodes.Stloc_3);
			ilgenerator.Emit(OpCodes.Newobj, constructor2);
			ilgenerator.Emit(OpCodes.Stloc_S, 4);
			ilgenerator.Emit(OpCodes.Ldloc_3);
			ilgenerator.Emit(OpCodes.Callvirt, method5);
			ilgenerator.Emit(OpCodes.Stloc_S, 5);
			ilgenerator.Emit(OpCodes.Ldloc_S, 4);
			ilgenerator.Emit(OpCodes.Ldc_I4_M1);
			ilgenerator.Emit(OpCodes.Box, typeof(int));
			ilgenerator.Emit(OpCodes.Ldloc_S, 5);
			ilgenerator.Emit(OpCodes.Callvirt, method6);
			ilgenerator.Emit(OpCodes.Ldloc_0);
			ilgenerator.Emit(OpCodes.Brfalse_S, label3);
			ilgenerator.Emit(OpCodes.Br_S, label4);
			ilgenerator.MarkLabel(label5);
			ilgenerator.Emit(OpCodes.Ldloc_S, 4);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Callvirt, method7);
			ilgenerator.Emit(OpCodes.Conv_I4);
			ilgenerator.Emit(OpCodes.Ldc_I4, 22);
			ilgenerator.Emit(OpCodes.Add);
			ilgenerator.Emit(OpCodes.Ldloc_0);
			ilgenerator.Emit(OpCodes.Xor);
			ilgenerator.Emit(OpCodes.Box, typeof(int));
			ilgenerator.Emit(OpCodes.Ldloc_3);
			ilgenerator.Emit(OpCodes.Callvirt, method5);
			ilgenerator.Emit(OpCodes.Callvirt, method6);
			ilgenerator.MarkLabel(label4);
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Callvirt, method7);
			ilgenerator.Emit(OpCodes.Ldloc_2);
			ilgenerator.Emit(OpCodes.Blt_S, label5);
			ilgenerator.MarkLabel(label3);
			ilgenerator.Emit(OpCodes.Call, method8);
			ilgenerator.Emit(OpCodes.Ldloc_S, 5);
			ilgenerator.Emit(OpCodes.Ldloc_S, 4);
			ilgenerator.Emit(OpCodes.Callvirt, method9);
			ilgenerator.Emit(OpCodes.Ldloc_S, 5);
			ilgenerator.Emit(OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x001F1F68 File Offset: 0x001F0168
		public string method_1(Stream stream_0)
		{
			AssemblyName assemblyName = new AssemblyName("?");
			Type[] array = new Type[]
			{
				typeof(AssemblyName),
				typeof(AssemblyBuilderAccess)
			};
			MethodInfo methodInfo = typeof(AssemblyBuilder).GetMethod("DefineDynamicAssembly", array);
			if (methodInfo == null)
			{
				methodInfo = typeof(AppDomain).GetMethod("DefineDynamicAssembly", array);
			}
			TypeBuilder typeBuilder = ((AssemblyBuilder)methodInfo.Invoke(AppDomain.CurrentDomain, new object[]
			{
				assemblyName,
				AssemblyBuilderAccess.Run
			})).DefineDynamicModule("?").DefineType("?", TypeAttributes.NotPublic);
			this.method_0(typeBuilder);
			return (string)typeBuilder.CreateType().InvokeMember("?", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, new object[] { stream_0 });
		}
	}
}
