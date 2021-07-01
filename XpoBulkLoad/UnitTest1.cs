using DevExpress.Xpo;
using NUnit.Framework;
using System.Diagnostics;

namespace XpoBulkLoad
{
    public  class Tests
    {
        IDataLayer dl;
        [SetUp]
        public void Setup()
        {
            //https://docs.devexpress.com/XPO/DevExpress.Xpo.Session._methods
            string conn = DevExpress.Xpo.DB.AccessConnectionProvider.GetConnectionString("TestDb.mdb");
            dl = XpoDefault.GetDataLayer(conn, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            using (Session session = new Session(dl))
            {
                System.Reflection.Assembly[] assemblies =
                        new System.Reflection.Assembly[] {
                                   typeof(Customer).Assembly
                   };
                session.UpdateSchema(assemblies);
                session.CreateObjectTypeRecords(assemblies);
            }
            UnitOfWork unitOfWork = new UnitOfWork(dl);
            if(unitOfWork.FindObject<Customer>(null)==null)
            {
                var Javier = new Customer(unitOfWork) { Code = "001", Name = "Javier" };
                var Hector = new Customer(unitOfWork) { Code = "002", Name = "Hector" };
                var Oniel = new Customer(unitOfWork) { Code = "003", Name = "Oniel" };
                var Hismel = new Customer(unitOfWork) { Code = "004", Name = "Hismel" };
                var Joche = new Customer(unitOfWork) { Code = "005", Name = "Joche" };


                var Computer=new Product(unitOfWork) { Code = "001", Name = "Computer" };
                var Cellphone = new Product(unitOfWork) { Code = "002", Name = "Cellphone" };
                var Laptop = new Product(unitOfWork) { Code = "003", Name = "Laptop" };
                unitOfWork.CommitChanges();
            }

        }
        [Test]
        public void WithoutBulkLoad()
        {
            UnitOfWork unitOfWork = new UnitOfWork(dl);
            XPCollection<Customer> Customers = new XPCollection<Customer>(unitOfWork);
            XPCollection<Product> Products = new XPCollection<Product>(unitOfWork);

            foreach (Customer customer in Customers)
            {
                Debug.WriteLine($"{customer.Code} {customer.Name}");
            }
            foreach (Product product in Products)
            {
                Debug.WriteLine($"{product.Code} {product.Name}");
            }
            Assert.Pass();
        }
        [Test]
        public void WithBulkLoad()
        {
            UnitOfWork unitOfWork = new UnitOfWork(dl);
            XPCollection<Customer> Customers = new XPCollection<Customer>(unitOfWork);
            XPCollection<Product> Products = new XPCollection<Product>(unitOfWork);

            unitOfWork.BulkLoad(Customers, Products);

            foreach (Customer customer in Customers)
            {
                Debug.WriteLine($"{customer.Code} {customer.Name}");
            }
            foreach (Product product in Products)
            {
                Debug.WriteLine($"{product.Code} {product.Name}");
            }
            Assert.Pass();
        }
    }
}