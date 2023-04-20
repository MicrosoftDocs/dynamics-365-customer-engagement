---
title: "Create or edit quotes in Dynamics 365 Sales"
description: "Quotes include the pricing details of products your potential customer is interested in. A quote becomes an order once the customer accepts it."
ms.date: 10/25/2021
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Create or edit quotes

Quotes include the pricing details of products that your potential customer is interested in.  

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)]

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## How to create or edit quotes 

One way that can help you increase your sales is to add all products that your customer might need to your quote. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] may also offer product bundles or product families to make it easier for you to choose products for upsell and cross-sell.  
  
Most sales begin with a price quote, which eventually becomes an order.       
You'll probably edit a quote multiple times as a sale progresses. Initially, you create a draft, and then you need to activate it when it's ready to go to a customer.      
When the customer accepts the quote, you create an order. Otherwise, you close the quote as revised, canceled, or lost.  

## Create a quote from an opportunity

1. Select the site map  ![Site Map icon.](media/site-map-icon.png "site map icon"), and then select **Opportunities**.

2. Select the opportunity you want to create a quote for.

3. Go to the **Quotes** tab and then select **New Quote**.

    The quote form opens. The quote form is prefilled with important details from the opportunity record.

4. Enter shipping and payment information in the **Shipping Information** area of the **Quote** form.

5. Enter the billing and shipping addresses in the **Addresses** area of the **Quote** form.

6. To add products from your opportunity to your quote, on the command bar of the **Quote** form, select **Get Products**. Add more products or remove existing ones from the **Products** area.

7. Select **Save** in the lower-right corner of the screen.

8. When your quote is ready to send to your customer, on the command bar, select **Activate Quote**.

> [!NOTE]
> Your base record and all its line items must use the same currency. For example, if your quote has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the quote. You can't change the currency of the base record (in this case, an quote), unless you remove all the line items associated with the record.
> Similarly, if the quote is created from an opportunity, it must use the same currency as the opportunity.

## Create a quote

1. Select the site map ![Site Map icon.](media/site-map-icon.png "site map icon"), and then select **Quotes**.

2. Select **New**.

3. On the **Quote** form, enter data in the following required fields:

    -  **Name** 
  
    -  **Price List** and **Currency**: The price list that will be used to calculate the product prices and currency.

        > [!NOTE]
        > By default, selecting a price list is required to be able to add products a quote. However, your administrator can change your organization settings to make the Price list field optional.

4. In the **Sales Information** section, in **Potential Customer**, enter information about the customer you're creating this quote for.

5. On the command bar, select **Save** to enable other sections on the form.

6. To add products from an opportunity to your quote, select **Get Products** at the top of the **Quote** form, select an opportunity, and then select **OK**.
  
    -OR-

    To manually add other products, in the **Products** section, select the **More commands** icon ![More commands icon](media/more-commands-button.png "More commands icon"), and then select **Add New Quote Product**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to Quote, invoice, or order records](add-product-quote-order-invoice.md)

7. In the **Shipping Information** area, enter shipping details.

8. In the **Addresses** area, enter shipping and billing addresses.

9. Select **Save**.

10. When your quote is ready to send to your customer, on the command bar, select **Activate Quote**.   

## Email a quote

When you've added all the details to the quote, you can send it to the customer. To directly send an email to a customer with a quote attached, open the quote, and on the command bar, select **Email as PDF**. [!INCLUDE[proc-more-information-md](../includes/proc-more-information-md.md)] [Email a PDF file](create-quote-pdf.md#export-to-pdf)

## Typical next steps  
 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Create or edit an order](create-edit-order-sales.md)  
  
 ![Home button](media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  
 [Sales transactions in Dynamics 365 Sales](sales-transactions.md)  
 [Create a PDF file](create-quote-pdf.md)  
 [Track and manage activities](manage-activities.md)   
 [Print quote, invoice, or other records](print-records.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
