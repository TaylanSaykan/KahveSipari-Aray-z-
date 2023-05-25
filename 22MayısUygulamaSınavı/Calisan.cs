using _22MayısUygulamaSınavı;

namespace _22MayısUygulamaSınavı
{
    public enum Role
    {
        Barista,
        Cashier
    }

    public abstract class Employee
    {
        internal bool IsBusy;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        internal abstract void TakeOrder();
    }

}

