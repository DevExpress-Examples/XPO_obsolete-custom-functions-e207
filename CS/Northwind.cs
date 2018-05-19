namespace Northwind {
    using System;
    using DevExpress.Xpo;

    [Persistent("Customers")]
    public class Customer : XPLiteObject {
        public Customer(Session session) : base(session) { }

        string _customerID;
        
        [Key]
        public string CustomerID {
            get { return _customerID; }
            set { SetPropertyValue("CustomerID", ref _customerID, value); }
        }

        string _contactTitle;
        public string ContactTitle {
            get { return _contactTitle; }
            set { SetPropertyValue("ContactTitle", ref _contactTitle, value); }
        }

        string _companyName;
        public string CompanyName {
            get { return _companyName; }
            set { SetPropertyValue("CompanyName", ref _companyName, value); }
        }

	string _address;
        public string Address {
            get { return _address; }
            set { SetPropertyValue("Address", ref _address, value); }
        }        

        [Association("CustomerOrders", typeof(Order))]
        public XPCollection<Order> Orders {
            get {
                return GetCollection<Order>("Orders");
            }
        }
    }

    [Persistent("Orders")]
    public class Order : XPLiteObject {
        public Order(Session session) : base(session) { }

        [Key(true), Persistent]
        int OrderID = -1;

        [PersistentAlias("OrderID")]
        public int ID {
            get { return OrderID; }
        }

        private DateTime _OrderDate;
        public DateTime OrderDate {
            get {
                return _OrderDate;
            }
            set {
                SetPropertyValue("OrderDate", ref _OrderDate, value);
            }
        }

        [PersistentAlias("Custom('GetMonth', [OrderDate])")]
        public int OrderMonth {
            get {
                // .NET implementation of the custom function (GetMonth)
                return OrderDate.Month;
            }
        }

        Customer _customer;
        [Persistent("CustomerID"), Association("CustomerOrders")]
        public Customer Customer {
            get { return _customer; }
            set { SetPropertyValue("Customer", ref _customer, value); }
        }

        private Employee _Employer;
        [Persistent("EmployeeID")]
        public Employee Employee {
            get {
                return _Employer;
            }
            set {
                SetPropertyValue("Employer", ref _Employer, value);
            }
        }
    }

    [Persistent("Employees")]
    public class Employee : XPLiteObject {
        public Employee(Session session) : base(session) { }

        [Key(true), Persistent]
        public int EmployeeID;

        private string _FirstName;
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                SetPropertyValue("FirstName", ref _FirstName, value);
            }
        }
        private string _LastName;
        public string LastName {
            get {
                return _LastName;
            }
            set {
                SetPropertyValue("LastName", ref _LastName, value);
            }
        }

        [PersistentAlias("Concat([FirstName], ' ', [LastName])")]
        public string FullName {
            get {
                return (string)EvaluateAlias("FullName");
            }
        }
    }
}
