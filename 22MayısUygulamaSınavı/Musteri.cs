public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public int OrderNumber { get; set; }
    public ServiceRating SatisfactionRating { get; set; }
    public int Points { get; set; }

    public Customer(string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        OrderNumber = 0;
        SatisfactionRating = ServiceRating.Average;
        Points = 0;
    }

    public void PlaceOrder(int orderNumber)
    {
        OrderNumber = orderNumber;
        PrintMessage($"{FirstName} {LastName} tarafından sipariş verildi. Sipariş Numarası: {OrderNumber}");
    }

    public void CancelOrder()
    {
        OrderNumber = 0;
        PrintMessage($"{FirstName} {LastName} tarafından verilen sipariş iptal edildi.");
    }

    public void RateService(ServiceRating rating)
    {
        SatisfactionRating = rating;
        if (rating == ServiceRating.VeryBad)
        {
            Points += 10;
        }
    }

    private void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
public enum ServiceRating
{
    VeryBad = 1,
    Bad,
    Average,
    Good,
    Excellent
}