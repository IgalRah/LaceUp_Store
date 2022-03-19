(C# & WPF Project)

    1.About This Project:
This project intends to demo an online store for displaying and selling various products. It was built to demonstrate knowledge and implementation of C# and Entity Framework Programming fundamentals and principles,

    2.Built With:
The project was Built with Entity Framework Core as the data access technology, and SQL Server as the database structure. Though not mandatory, the GUI for the demo was built with WPF graphical environment.


    3.Getting Started:
Upon Loading, the projects verify if the Database exists. If the database does not exist, the app automatically invokes a Method to create and populate the database.

![image](https://user-images.githubusercontent.com/85184953/159066897-7f08f5b6-7a18-44d9-9036-35d2874ad8af.png)

    Predefined existing Users in the system:

    Admin user: Admin
    Password: Admin123

    Regular User: User
    Email address: User@admin.com
    Password: User123
With this details you can either login into as an regular account or as admin account.

    4.Entities, Relations design and logic:
The project implements EF TPT (Table-per-Type) inheritance model. Table-per-type inheritance uses a separate table in the database to maintain data for non-inherited properties and key properties for each type in the inheritance hierarchy.

The main model for the products section is an class ShoesInfo:

    public class ShoesInfo
    {
        public int Id { get; set; }
        [Required]
        public string ShoeName { get; set; }
        [Required]
        public string ShoeCategory { get; set; }
        [Required]
        public int ShoePrice { get; set; }
    }


There are currently 2 more models (ShoppingBag ans User), each has unique Properties:

    public class ShoppingBag
    {
    
        public int Id { get; set; }

        [Required]
        public string Shoe { get; set; }

        [Required]
        public int Price { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }

And each model controls different part of the app

    5.General usage Methods:

Log in / Sign up methods.

Populating the user's shopping cart.

Processing user's shopping cart.

Add Order / Edit order / removed from inventory.

    GUI Usage – Login & Sign Up :

Upon login, a new user is given the option to sign up for the system. One must provide a valid email address and username, and a password complying with the following criteria:

Length of 6+ characters.

At least one Upper Case character.

At least one numeric character (0-9).

At least one special symbol character (!"#$%&'()*+,-./:;&lt;=&gt;?@[]^_`{|}~).

Upon successful verification, the password is saved in the Users.DB


GUI Usage – Main Screen :

![image](https://user-images.githubusercontent.com/85184953/159066897-7f08f5b6-7a18-44d9-9036-35d2874ad8af.png)

GUI Usage – Register Screen :

![image](https://user-images.githubusercontent.com/85184953/159068617-c54a9965-3080-40d6-8a93-a63c2673c316.png)


GUI Usage – Shopping Cart :

![image](https://user-images.githubusercontent.com/85184953/159068811-a6344c5f-be24-42ef-8b62-b76ee9abf2b6.png)

GUI Usage – User Page :

![image](https://user-images.githubusercontent.com/85184953/159068763-759ec575-8ac5-4456-abc7-05d207ffeac2.png)

GUI Usage – Admin Page :

![image](https://user-images.githubusercontent.com/85184953/159068677-915754fd-381d-42f0-aaa2-0bf03cec1026.png)
