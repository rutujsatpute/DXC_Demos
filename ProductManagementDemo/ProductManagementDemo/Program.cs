using System.Transactions;

namespace ProductManagementDemo
{
    //CRUD - Create, Retrive, Update, Delete
    class Customer
    {
        public int Srno { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string UID { get; internal set; }
    }

    class Management
    {
        int n = 0;
        List<Customer> customers;
        public Management()
        {
            customers = new List<Customer>()
            {
                new Customer { Srno = 1, FirstName ="Sumit",LastName= "Yadav", Email = "sumityadav@gmail.com", Age = 18, PhoneNumber = 9876543211, City = "Mumbai"},
                new Customer { Srno = 2, FirstName = "Kunal", LastName= "Gokhale", Email= "kunalg@gmail.com", Age= 22, PhoneNumber = 9823762387, City = "Pune"}
            };
        }


        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public int GenerateCustomerId(string firstName, string lastName)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 9999);
            return randomNumber;
        }

        public Customer GetCustomer(int Srno)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Srno == Srno)
                    return customer;
            }
            return null;
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public bool UpdateDetails(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    Console.WriteLine("Enter the New Details");
                    Console.WriteLine("Enter First Name");
                    c.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name");
                    c.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Email Id: ");
                    c.Email = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    c.Age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number:");
                    string num = Console.ReadLine();
                    if (num.Length != 10)
                    {
                        Console.WriteLine("Invalid Number!! Enter the number again: ");
                        c.PhoneNumber = Console.ReadLine();
                    }
                    Console.WriteLine("Enter City");
                    c.City = Console.ReadLine();
                    return true;
                }



            }
            return false;
        }



        public List<Customer> GetCustomers()
        {
            return customers;
        }



        public bool DeleteCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    customers.Remove(c);
                    return true;
                }
            }
            return false;
        }

    public bool DeleteCustomer (int srno)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Srno == srno)
                {
                    customers.Remove(customer);
                    return true;

                }
            }
            return false;

                    
            }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Management obj = new Management();
            obj.randomuserid();
            string ans = "";
            do
            {
                Console.WriteLine("Welcome to Customers Manement App");
                Console.WriteLine("1 Add Customer");
                Console.WriteLine("2 Get Customer Details By Srno");
                Console.WriteLine("3 Get All Customers Deatils");
                Console.WriteLine("4 Delete Customer Details");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Customer Srno");
                            int srno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Customer First Name");
                            string fname = Console.ReadLine();
                            Console.WriteLine("Enter the Customer Last Name");
                            string lname = Console.ReadLine();
                            Console.WriteLine("Enter the Customer Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter the Customer Age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Customer ph no.");
                            int phno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Customer City");
                            string city = Console.ReadLine();

                            obj.AddCustomer(new Customer() { Srno = srno, FirstName = fname, LastName = lname, Email = email, Age = age, City = city });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Product Srno");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Customer? customer = obj.GetCustomer(id);
                            if (customer == null)
                            {
                                Console.WriteLine("Product with specified srno does not exists");
                            }   
                            else
                            {
                                Console.WriteLine($"{customer.Srno} {customer.FirstName} {customer.LastName} {customer.Email} {customer.Age} {customer.City}");
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var customer in obj.GetCustomers())
                            {
                                Console.WriteLine($"{customer.Srno} {customer.FirstName} {customer.LastName} {customer.Email} {customer.Age} {customer.City}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            if (obj.DeleteCustomer(id))
                            {
                                Console.WriteLine("Product Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Product with specified id does not exist");
                            }
                            break;
                        }


                }
            
                Console.WriteLine("Do you wish to continue? [y/n] ");
                ans = Console.ReadLine();
            } while (ans.ToLower() == "y");
            
        }   
         
    }
}