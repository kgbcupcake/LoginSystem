#						Login-System
 
## Description:
#### just a simple Login-System you can use for any of your program's Enjoy....
#### The Login Info can be located in your  C:
---


## heres the login code for you'll need for your other program. 



		 public void MainLogin()
		{
			string? username, password, username1, password1 = string.Empty;

			WriteLine("Plz make sure you've created a UserAnme & Password with the Login System Provide");
			System.Threading.Thread.Sleep(1500);
			Clear();
			Write("Enter UserName:");
			username = ReadLine();
			WriteLine("Enter A Password");
			password = ReadLine();


			using (StreamReader sr = new StreamReader(File.Open("c:\\LoginData.txt", FileMode.Open)))
			{
				username1 = sr.ReadLine();
				password1 = sr.ReadLine();
				sr.Close();

			}
			if (username == username1 && password == password1)
			{

				WriteLine("Login Successful");
				System.Threading.Thread.Sleep(500);
				Clear();
			}
			else
			{
				WriteLine("Login Failed");
				System.Threading.Thread.Sleep(500);
				Environment.Exit(0);
			}
		}

