//Print and calculate an invoice

using System;
namespace InvoiceApplication
{
    public class Invoice
    {
        decimal invTotal;
        string invoiceString;

        public string CustomerName { get; set; }

        public int StudentID { get; set; }

        //products
        double KonaBlend = 14.95;
        double CafeVerona = 9.95;
        double EspressoRoast = 9.90;
        double FrenchRoast = 10.45;
        double OrganicShadeGrown = 13.45;

        double KonaTotal;
        double CafeTotal;
        double EspressoTotal;
        double FrenchTotal;
        double OrganicTotal;

        public string ProductType;

        //constructor
        public Invoice(string customerName, int studentId)
        {
            CustomerName = customerName;
            StudentID = studentId;
        }

        //displaymessage method
        public void DisplayMessage()
        {
            Console.WriteLine($"Student Name: {CustomerName}\n");

            Console.WriteLine($"Student ID: {StudentID}\n");

            Console.WriteLine("Please choose from the following products by entering the product code followed by quantity. Enter <ctrl> z to exit:\n");

            Console.WriteLine("Product 1 - Kona Blend - $14. 95");
            Console.WriteLine("Product 2 - Cafe Verona - $9.95");
            Console.WriteLine("Product 3 - Espresso Roast - $9.90");
            Console.WriteLine("Product 4 - French Roast - $10.45");
            Console.WriteLine("Product 5 - Organic Shade Grown - $13.45");
            Console.WriteLine("--------------------------------------------------------------\n");
        }

        //additem method
        public void AddItem()
        {
            Console.WriteLine("Please enter product code (1,2,3,4,or 5) followed by the quantity on the next line: ");

            string ProductType = (Console.ReadLine());

            double qty = Convert.ToDouble(Console.ReadLine());

            double total;

            while (ProductType == null)
            {
                if (ProductType == "1")
                {
                    KonaTotal = KonaBlend * qty;
                    Console.WriteLine(KonaTotal);
                }

                if (ProductType == "2")
                {
                    CafeTotal = CafeVerona * qty;
                    Console.WriteLine(CafeTotal);
                }

                if (ProductType == "3")
                {
                    EspressoTotal = EspressoRoast * qty;
                    Console.WriteLine(EspressoTotal);
                }

                if (ProductType == "4")
                {
                    FrenchTotal = FrenchRoast * qty;
                    Console.WriteLine(FrenchTotal);
                }

                if (ProductType == "5")
                {
                    OrganicTotal = OrganicShadeGrown * qty;
                    Console.WriteLine(OrganicTotal);
                }
            }
            
        }

        //displaytotals method
        public void DisplayTotals()
        {
            double InvoiceTotal = KonaTotal + CafeTotal + EspressoTotal + FrenchTotal + OrganicTotal;

            Console.WriteLine("Product 1 - Kona Blend:" + KonaTotal);
            Console.WriteLine("Product 2 - Cafe Verona Blend:" + CafeTotal);
            Console.WriteLine("Product 3 - Espresso Roast:" + EspressoTotal);
            Console.WriteLine("Product 4 - French Roast:" + FrenchTotal);
            Console.WriteLine("Product 5 - Organic Shade Grown:" + OrganicTotal);
            Console.WriteLine("Invoice Total: " + InvoiceTotal);
        }
    }
}
