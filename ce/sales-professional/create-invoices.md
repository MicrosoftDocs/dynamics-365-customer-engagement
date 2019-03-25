Create and manage invoices in Dynamics 365 for Sales Professional
=================================================================

Once your customer accepts the quote, you can create an invoice in Dynamics 365
for Sales Professional to bill them for the upcoming sale.

You may also create an invoice that doesn’t generate from a quote.

Create an invoice from a quote
------------------------------

1.  In the site map, select **Quotes**.

2.  Select the active quote that you want to create an invoice from.

3.  On the command bar, select **Create Invoice**.

>   The Invoice form opens.

![](media/41cc32e81dbe62865fe54a6f3a4ed7ed.png)

>   A screenshot of a social media post Description automatically generated

1.  Review the contents of the invoice and make any additions or corrections
    before sending to your customer.

Create a new invoice
--------------------

1.  In the site map, select **Invoices**.

2.  Select **New**.

>   The Invoice form opens.

![](media/3e447269042aab5b482a126f62972b2c.png)

>   A screenshot of a cell phone Description automatically generated

1.  Add the invoice details.

2.  In the **Sales Information** section, select the customer you’re creating
    this invoice for. If the record doesn’t already exist, you can create a new
    one.

3.  Select **Save** at the top left to create the invoice record.

4.  To add products from your opportunity to your order, choose **Get Products**
    at the top of the screen, select your opportunity, and select **OK**.

>   OR

>   In the **Products** section, select the **More Commands** icon, and then
>   select **Add New Invoice Products**.

![](media/2d9e428f4ac1da984ad6991d8f835603.png)

>   A screenshot of a cell phone Description automatically generated

1.  In the **Quick Create: Invoice Product** form, enter the details:

    1.  In the **Select Product** toggle button, select whether you want to add
        an existing product or create a new one:

        1.  To use an existing product, select **Lookup** to search for and add
            a product. Also, select a unit of measurement for the product.

        2.  To create a product, select **Write-In**, and then enter the name of
            the product.

    2.  Fill in details in the **Pricing** section:

        1.  Toggle the **Pricing** button to indicate whether you want to use
            the default pricing that is listed in the product catalog or
            override the price. For a write-in product, this field is set to
            **Override** Price.

        2.  **I**f you’re adding a write-in product, in **Price Per Unit**,
            enter the price to be charged per unit for the product.

        3.  Enter the quantity of the product or service that will be included.

        4.  If you want to offer a discount to the product price, enter it in
            **Manual Discount**.

        5.  If required, enter the appropriate tax amount.  
            You need to enter the tax amount when you add a product to a quote,
            order, or invoice. Dynamics 365 for Sales Professional doesn’t
            automatically calculate tax for individual products. However, the
            total tax is calculated automatically based on the sum of the tax
            amounts for all of the individual products in a quote, order, or
            invoice.

2.  Select **Save and Close**.

Lock or unlock prices of an invoice
-----------------------------------

Price locked locks the price for a product in an open invoice. Even if the price
changes in the product catalog, that invoice remains at the agreed price.

To lock the prices

1.  Go to the list of invoices and open the invoice that you want.

2.  To lock the price, on the command bar, select **Lock Pricing**. 

>   OR -

To use the price of a product from the product catalog, select **Use Current
Pricing**.  

Close an invoice
----------------

You close an invoice either by canceling the invoice or setting the invoice
status as paid. To do this, open the invoice you want to close, and on the
command bar, select **Cancel Invoice** or **Invoice Paid**.

Email an invoice
----------------

When you’ve added all the details to the invoice, send it to the customer.

To directly send an email to customer with an invoice attached, open the
invoice, and on the command bar, select the **More Commands** icon

![Icon for More Commands](media/8ee65c6454c46d9d95de8bc81379a04b.png)

, and then select **Send by Email**.

### See Also

Develop sales from lead to cash in Dynamics 365 for Sales Professional  
Overview of Dynamics 365 for Sales Professional
