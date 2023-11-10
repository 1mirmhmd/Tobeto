using Oop2;

// ind customer
Individual customer = new Individual();
customer.Id = 1;
customer.FirstName = "Ali";
customer.LastName = "Hancı";
customer.TcNo = "12345678901";

// corp customer
Corporate corporate = new Corporate();
corporate.Id = 2;
corporate.CustomerNo = "123";
corporate.TaxNo = "123456789";
corporate.CompanyName = "Kodlama.io";

// Individual Customer - Corporate 
// SOLID

Customer customer1 = new Individual();
Customer customer2 = new Corporate();

CustomerManager customerManager1 = new CustomerManager();
customerManager1.Add(customer1);
