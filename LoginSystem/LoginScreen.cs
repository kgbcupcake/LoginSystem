using Pastel;
using static System.Console;
namespace LoginSystem
{
	public class LoginScreen
	{

		public static void WaitForAnyKeyPress()
		{
			Write("\nPress any key to continue....".Pastel("#210487"));
			ReadKey(true);
		}



		public void MainLogin()
		{








			WriteLine("Here is just a simple login in system you can use with any of your program's ".Pastel("#CB0FAB"));

			string userName, password = string.Empty;

			Write("Enter A User Name:".Pastel("#891414"));
			ForegroundColor = ConsoleColor.Blue;
			userName = ReadLine();
			ResetColor();
			Write("Enter a password:".Pastel("#891414"));
			ForegroundColor = ConsoleColor.Blue;
			password = ReadLine();


			using (StreamWriter sw = new StreamWriter(File.Create("c:\\LoginData.txt")))
			{
				sw.WriteLine(userName);
				sw.WriteLine(password);
				sw.Close();
			}
			WriteLine("Done");



			WaitForAnyKeyPress();
			Environment.Exit(0);
		}









	}
}
