using System;
using System.IO;
using System.Reflection;

namespace PAF__Project_
{
	internal class Program
	{
		static string[] addcart = new string[10];
		static int cartCount = 0;
		static double subtotal = 0;

		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("Online Food Ordering System in C# Console Application");
			Console.ForegroundColor = ConsoleColor.Green;
			string logo = @"  ____                  _           _     _        ____                 _                       
 |  _ \  ___  ___ _ __ (_) ___ __ _| |__ | | ___  |  _ \  _____   _____| | ___  _ __   ___ _ __ 
 | | | |/ _ \/ __| '_ \| |/ __/ _` | '_ \| |/ _ \ | | | |/ _ \ \ / / _ \ |/ _ \| '_ \ / _ \ '__|
 | |_| |  __/\__ \ |_) | | (_| (_| | |_) | |  __/ | |_| |  __/\ V /  __/ | (_) | |_) |  __/ |   
 |____/ \___||___/ .__/|_|\___\__,_|_.__/|_|\___| |____/ \___| \_/ \___|_|\___/| .__/ \___|_|   
                 |_|                                                           |_|            ";
			Console.WriteLine(logo);
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("_______________________//  Welcome to the  Online Food Ordering System  //_______________________");
			Console.WriteLine("");
			while (true)
			{
				Console.WriteLine(" [1] to Main Menu ");
				Console.WriteLine(" [2] to View Cart ");
				Console.WriteLine(" [3] to Checkout ");
                Console.WriteLine(" [4] to Searching Categories by Name ");
                Console.WriteLine(" [0] to Exit.."); 
				Console.WriteLine("");
				Console.Write(" Enter a Number : ");
				int num = int.Parse(Console.ReadLine());
				switch (num)
				{
					case 1:
						main_menu(num);
						break;
					case 2:
						view_cart();
						break;
					case 3:
						checkout();

						break;
					case 4:
						s_by_name();
						break;
					case 0:
						exit();
						return;
				}
			}
		}
		static void s_by_name()
		{
			Console.Clear();
			Console.WriteLine("//---Searching_By_Name---//");
			Console.WriteLine("");
			string path = "main_menu.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string mainmenu = sr.ReadLine();
			Console.Write("Searching By Name ");
			Console.Write("(");
			while (mainmenu != null)
			{
				Console.Write(" {0} ,", mainmenu);
				mainmenu = sr.ReadLine();
			}
			Console.Write(") :");
			sr.Close();
			file.Close();
			string name = Console.ReadLine();
			if (name == "karahi" || name == "Karahi")
			{
                Console.WriteLine("Selected Cateogry :{0} ",name);
                Console.WriteLine("");
                karahi();
			}
			else if (name == "burger" || name == "Burger")
			{
				Console.WriteLine("Selected Cateogry :{0} ", name);
				Console.WriteLine("");
				burger();
			}
			else if (name == "colddrink" || name == "Colddrink")
			{
				Console.WriteLine("Selected Cateogry :{0} ", name);
				Console.WriteLine("");
				colddrink();
			}
			else if (name == "pizza" || name == "Pizza")
			{
				Console.WriteLine("Selected Cateogry :{0} ", name);
				Console.WriteLine("");
				pizza();
			}
			else if (name =="bbq" || name=="BBQ")
			{
				Console.WriteLine("Selected Cateogry :{0} ", name);
				Console.WriteLine("");
				bbq();
			}
			else
			{
                Console.WriteLine("Some thing Went Wrong");
                Console.WriteLine("");
                Console.WriteLine("any key to exit...");
				Console.ReadKey();
				main_menu(1);
			
			}

		}
		

		static void main_menu(int a)
		{
			if (a == 1)
			{
				Console.WriteLine("");
				Console.WriteLine("//___Welcome To Main Menu___\\");
				Console.WriteLine("");
				

				string path = "main_menu.txt";
				FileStream file = new FileStream(path,FileMode.Open,FileAccess.Read);
				StreamReader sr = new StreamReader(file);
				string mainmenu = sr.ReadLine();
				int index = 1;
				while (mainmenu!=null)
				{
                    Console.WriteLine("Press {0} to Explore {1} Menu :",index,mainmenu);
					mainmenu = sr.ReadLine();
					index++;


				}
                Console.WriteLine("Press 0 to Exit...");

                sr.Close();
				file.Close();
                Console.WriteLine("");
                Console.Write("Enter Number :");
				int menu = int.Parse(Console.ReadLine());
				switch (menu)
				{
					case 0:
						Console.Clear();
						main_menu(1);
						break;
					case 1:
						karahi();
						break;
					case 2:
						burger();
						break;
					case 3:
						colddrink();
						break;
					case 4:
						pizza();
						break;
					case 5:
						bbq();
						break;
				}
			}
		}

		static void karahi()
		{
			
			string path = "karahi.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string karahi1 = sr.ReadLine();
			string karahi1p = sr.ReadLine();
			double karahi1price = double.Parse(karahi1p);
			string karahi2 = sr.ReadLine();
			string karahi2p = sr.ReadLine();
			double karahi2price = double.Parse(karahi2p);
			


			sr.Close();
			file.Close();
            Console.WriteLine("Press 1 for {0} {1}", karahi1, karahi1price);
			Console.WriteLine("Press 2 for {0} {1}", karahi2, karahi2price);
            Console.WriteLine("Press 0 for Exit...");

            int option = int.Parse(Console.ReadLine());

			if (option == 1)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", karahi1);
				double q = double.Parse(Console.ReadLine());

				cart(karahi1, karahi1price, q);
			}
			else if (option == 2)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", karahi2);
				double q = double.Parse(Console.ReadLine());

				cart(karahi2, karahi2price, q);
			}
			else if (option ==0)
			{
				Console.Clear();
				main_menu(1);
			}
			else
			{
				Console.WriteLine("Something went wrong");
			}
		}

		static void burger()
		{
			string path = "burger.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string burger1 = sr.ReadLine();
			string burger1p = sr.ReadLine();
			double burger1price = double.Parse(burger1p);
			string burger2 = sr.ReadLine();
			string burger2p = sr.ReadLine();
			double burger2price = double.Parse(burger2p);



			sr.Close();
			file.Close();
			Console.WriteLine("Press 1 for {0} {1}", burger1, burger1price);
			Console.WriteLine("Press 2 for {0} {1}", burger2, burger2price);
            Console.WriteLine("Press 0 to Exit...");



            int option = int.Parse(Console.ReadLine());
			if (option == 1)
			{
					
				Console.WriteLine("Enter a Quantity of {0}", burger1);
				double q = double.Parse(Console.ReadLine());

				cart(burger1, burger1price, q);
			}
			else if (option == 2)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", burger1);
				double q = double.Parse(Console.ReadLine());

				cart(burger1, burger2price, q);
			}
			else if (option ==0)
			{
				Console.Clear();
				main_menu(1);
			}
			else
			{
				Console.WriteLine("Something went wrong");
			}
		}

		static void colddrink()
		{
			string path = "colddrink.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string drink1 = sr.ReadLine();
			string drink1p = sr.ReadLine();
			double drink1price = double.Parse(drink1p);
			string drink2 = sr.ReadLine();
			string drink2p = sr.ReadLine();
			double drink2price = double.Parse(drink2p);



			sr.Close();
			file.Close();
			Console.WriteLine("Press 1 for {0} {1}", drink1, drink1price);
			Console.WriteLine("Press 2 for {0} {1}", drink2, drink2price);
            Console.WriteLine("Press 0 to Exit...");


            int option = int.Parse(Console.ReadLine());

			if (option == 1)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", drink1);
				double q = double.Parse(Console.ReadLine());

				cart(drink1, drink1price, q);
			}
			else if (option == 2)
			{
			
				Console.WriteLine("Enter a Quantity of {0}", drink2);
				double q = double.Parse(Console.ReadLine());

				cart(drink2, drink2price, q);
			}
			else if (option ==0)
			{
				main_menu(1);
			}
			else
			{
				Console.WriteLine("Something went wrong");
			}
		}

		static void pizza()
		{
			string path = "pizza.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string pizza1 = sr.ReadLine();
			string pizza1p = sr.ReadLine();
			double pizza1price = double.Parse(pizza1p);
			string pizza2 = sr.ReadLine();
			string pizza2p = sr.ReadLine();
			double pizza2price = double.Parse(pizza2p);



			sr.Close();
			file.Close();
			Console.WriteLine("Press 1 for {0} {1}", pizza1, pizza1price);
			Console.WriteLine("Press 2 for {0} {1}", pizza2, pizza2price);
			Console.WriteLine("Press 0 to Exit...");
			int option = int.Parse(Console.ReadLine());

			if (option == 1)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", pizza1);
				double q = double.Parse(Console.ReadLine());

				cart(pizza1, pizza1price, q);
			}
			else if (option == 2)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", pizza2);
				double q = double.Parse(Console.ReadLine());

				cart(pizza2, pizza2price, q);
			}
			else if (option == 0)
			{
				main_menu(1);
			}
			else
			{
				Console.WriteLine("Something went wrong");
			}
		}

		static void bbq()
		{
			string path = "bbq.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(file);
			string bbq1 = sr.ReadLine();
			string bbq1p = sr.ReadLine();
			double bbq1price = double.Parse(bbq1p);
			string bbq2 = sr.ReadLine();
			string bbq2p = sr.ReadLine();
			double bbq2price = double.Parse(bbq2p);



			sr.Close();
			file.Close();
			Console.WriteLine("Press 1 for {0} {1}", bbq1, bbq1price);
			Console.WriteLine("Press 2 for {0} {1}", bbq2, bbq2price);
			Console.WriteLine("Press 0 to Exit...");
			int option = int.Parse(Console.ReadLine());
			if (option == 1)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", bbq1);
				double q = double.Parse(Console.ReadLine());

				cart(bbq1, bbq1price, q);
			}
			else if (option == 2)
			{
				
				Console.WriteLine("Enter a Quantity of {0}", bbq2);
				double q = double.Parse(Console.ReadLine());

				cart(bbq2, bbq2price, q);
			}
			else if (option ==0)
			{
				main_menu(1);
			}
			else
			{
				Console.WriteLine("Something went wrong");
			}
		}

		static void view_cart()
		{
			Console.Clear();
			if (addcart != null)
			{
				Console.Clear();
				Console.WriteLine("Your Cart Items");
				Console.WriteLine("");
				Console.WriteLine("____________________");

				for (int d = 0; d < cartCount; d++)
				{
					Console.WriteLine(addcart[d]);
				}
				Console.WriteLine("____________________");
				Console.WriteLine("");
				Console.WriteLine("Subtotal Price is RS={0}", subtotal);
				Console.WriteLine("");

				Console.WriteLine("Press 1 to Proceed to Checkout :");
				Console.WriteLine("Press 2 to Main_Menu :");
				int nu = int.Parse(Console.ReadLine());
				if (nu == 1)
				{
					checkout();
				}
				else if (nu == 2)
				{
					main_menu(1);
				}
				else
				{
					Console.WriteLine("Some thing Went Wrong Please Try Again");
				}

			}
			else
			{
                Console.WriteLine("Cart is Empty...");
                Console.WriteLine("");
                Console.WriteLine("Press any Key to Main Menu...");
				Console.ReadKey();
				Console.Clear();
            }
		}

		static void cart(string name, double price, double q)
		{
			double totalPrice = price * q;
			string val = $"{name} {price}/{q}";
			subtotal += totalPrice;

			if (cartCount < addcart.Length)
			{
				addcart[cartCount] = val;
				cartCount++;
			}
			else
			{
				Console.WriteLine("Cart is full. Cannot add more Product.");
			}

			Console.Clear();
			Console.WriteLine("{0} is  Added to Cart Successfully", name);
            Console.WriteLine("");
        }

		static void checkout()
		{
			Console.WriteLine("//----Submit a Billing Address  : ----//");

			Console.Write("Enter Your FullName :");
			string fname = Console.ReadLine();

			Console.Write("Enter Your Mobile Number :");
			double mobile = double.Parse(Console.ReadLine());

			Console.Write("Enter Your Address:");
			string address = Console.ReadLine();

			slip(fname, mobile, address);
		}

		static void slip(string name, double number, string address)
		{
			Console.Clear();
            Console.WriteLine("Thanks for Ordering Food");
            Console.WriteLine("");
            Console.WriteLine("-x-x-x-x-x-x-x-x-x-");
			Console.WriteLine("Your Payment Slip");
			Console.WriteLine("-x-x-x-x-x-x-x-x-x-");
			Console.WriteLine("");
			Console.WriteLine("Your Details :");
			Console.WriteLine("Name : {0}", name);
			Console.WriteLine("Mobile Number : {0}", number);
			Console.WriteLine("Address : {0}", address);
			Console.WriteLine("/-/--Your Ordered Food --/-/");
			for (int d = 0; d < cartCount; d++)
			{
				Console.WriteLine(addcart[d]);
			}
			Console.WriteLine("Subtotal: {0}", subtotal);
			Console.ReadKey(); 
		}

		static void exit()
		{
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
