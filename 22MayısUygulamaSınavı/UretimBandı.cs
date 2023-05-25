public abstract class ProductionLine
{
    public abstract void ProductReady(Customer customer, int orderNumber);

    protected void SendSMS(string phoneNumber, string message)
    {
        if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(message))
        {
            throw new ArgumentException("Geçersiz telefon numarası veya mesaj.");
        }

        // Burada gerçek bir SMS gönderme işlemi yapılabilir veya simulasyon amaçlı bir işlem gerçekleştirilebilir
        Console.WriteLine($"SMS gönderildi: {phoneNumber} - {message}");
    }

    protected void DeliveryCompleted(Customer customer)
    {
        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer), "Müşteri bilgileri geçersiz.");
        }

        // Teslimat tamamlandı işlemleri
        Console.WriteLine($"Teslimat tamamlandı. Müşteri: {customer.FirstName} {customer.LastName}");
    }
}

public class ConcreteProductionLine : ProductionLine
{
    public override void ProductReady(Customer customer, int orderNumber)
    {
        if (orderNumber <= 0)
        {
            throw new ArgumentException("Geçersiz sipariş numarası.");
        }

        if (customer == null)
        {
            throw new ArgumentNullException(nameof(customer), "Müşteri bilgileri geçersiz.");
        }

        DeliveryCompleted(customer);
        SendSMS(customer.Phone, $"Siparişiniz ({orderNumber}) hazır. Bardan teslim alabilirsiniz.");
    }
}
