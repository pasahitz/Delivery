using System;
using System.Runtime.InteropServices;
	
namespace Delivery

{ public class CMD
{ [DllImport("msvcrt.dll")]
public static extern int system(string cmd);
public static void Main()
{ system("Paste powershell command line");
}}}
