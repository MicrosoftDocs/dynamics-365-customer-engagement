---
title: "Create and manage quotes in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Use quotes in Dynamics 365 Sales Professional to make formal offers for products with proposed prices to customers."
ms.date: 12/12/2019
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create and manage quotes in Dynamics 365 Sales Professional

Most sales begin with a price quote in Dynamics 365 Sales Professional. A quote is a formal offer for products proposed at specific prices and related payment terms, which you send to an opportunity, account, or contact. 

If you've created your quote from an opportunity, you might have already added products that your customer is interested in to the opportunity. When you create a quote from the opportunity, all the products are already added to the quote.

You'll probably edit a quote multiple times as a sale progresses. Initially, you create a draft, and then you need to activate it when it's ready to go to a customer.

When the customer accepts the quote, and you are ready to ship the products, you create an invoice. Otherwise, you close the quote as revised, canceled, or lost.

## Create a quote from an opportunity

1.  In the site map, select **Opportunities**.

2.  Select the opportunity you want to create a quote for.

3.  On the command bar, select **Create Quote**.

    The Quote form opens.

    > [!div class="mx-imgBorder"]
    > ![Quote form with data from opportunity](media/quote-form-opportunity-data.png "Quote form with data from opportunity")

4.  Enter shipping and payment information in the **Shipping Information** area of the **Quote** screen.

5.  Enter the billing and shipping addresses in the **Addresses** area of the **Quote** screen.

6.  To add products from your opportunity to your quote, on the command bar of the Quote form, select **Get Products**. You add more products or remove existing ones from the **Quote Products** grid.

7.  In the **Products Summary** area, enter all the information you have available. If you are adding a discount, add a percentage or amount, or both.

8.  Select **Save** at the lower-right corner of the screen.

9.  When your quote is ready to send to your customer, select **Activate Quote** at the top of the screen.

After you activate the quote, you can create an invoice from it. More information: [Create and manage invoices in Dynamics 365 Sales Professional](create-invoices.md)

> [!NOTE]
> In Sales Professional, the Quote-Order-Invoice functionality is simplified to generate an invoice directly from a quote. Therefore, the **Create Order** button isn't available on the Quote form. 


## Create a new quote

1.  In the site map, select **Quotes**.

2.  Select **New**.

    The Quote form opens.

    > [!div class="mx-imgBorder"]
    > ![Quote form](media/empty-quote-form.png "Quote form")

3.  Add your quote information.

4.  To add products from an opportunity to your quote, select **Get Products** at the top of the **Quote** screen, and select **OK**.

5.  In the **Sales Information** area, select the potential customer you're creating this quote for. If the record doesn't already exist, you can create a new one.

6.  In the **Shipping Information** area, enter shipping details.

7.  In the **Addresses** area, enter shipping and billing addresses.

8.  Select the **Save** button in the lower-right corner of the screen.

9.  When your quote is ready to send to your customer, select **Activate Quote** at the top of the screen.


## Email a quote

When you've added all the details to the quote, you can send it to the customer. To directly send an email to a customer with a quote attached, open the quote, and on the command bar, select **Email as PDF**. [!INCLUDE[proc-more-information-md](../includes/proc-more-information-md.md)] [Email a PDF file](create-quote-pdf-sales-professional.md#email-as-a-pdf-file)

### See also

[Develop sales from lead to cash in Dynamics 365 Sales Professional](develop-sales-lead-to-cash-sales-professional.md)  
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)  
[Sales transactions in Dynamics 365 Sales Professional](understanding-sales-transactions-sales-professional.md)  
