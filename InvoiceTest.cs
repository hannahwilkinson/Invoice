//Print and calculate an invoice

using System;
namespace InvoiceApplication
{
	public class InvoiceTest
	{
		public static void Main()
		{
			//object
			Invoice invoice1 = new Invoice("Hannah Wilkinson", 800309181);

            //call the DisplayMessage method
            invoice1.DisplayMessage();

			//call the AddItem method
			invoice1.AddItem();

			invoice1.DisplayTotals();
		}
	}
}

