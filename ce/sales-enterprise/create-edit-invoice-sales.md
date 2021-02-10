---
title: "Create or edit invoices (Dynamics 365 Sales) | MicrosoftDocs"
description: "An invoice is an order that has been billed to the customer."
ms.date: 02/10/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-Entity-invoice
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Create or edit invoices (Sales Hub)

When a customer places an order, you can create an invoice to bill them for the upcoming sale.  
  
Typically, you convert an order into an invoice; however, you can also create an invoice that does not originate from an order.  
    
<a name="bkmk1"></a>   
## Create an invoice from an order  

1. In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "Site map icon"), and then select **Orders**. 
  
2. Select the order you want to create an invoice from.  
  
3. Select **Create Invoice** at the top of the screen.  

    > [!IMPORTANT]
    > If Dynamics 365 Sales is integrated with an external order processing application, you may see the **Submit Order** button instead of the **Create Invoice** button on the Order form command bar. This is because the integration allows an order created in Dynamics 365 Sales to be submitted, after which it is synchronized with the order processing app where the lifecycle of the order continues. A submitted order is locked for editing in Dynamics 365 Sales, except by an integration user. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enable sales order processing integration](developer/enable-sales-order-processing-integration.md)

4. Review the contents of the invoice and make any additions or corrections before sending to your customer.  

> [!NOTE]
> 
> Your base record and all its line items must use the same currency. For example, if your invoice has the currency set to U.S. Dollars, you must use the same currency for the price list items that you add to the invoice. You can't change the currency of the base record (in this case, an invoice), unless you remove all the line items associated with the record.
> Similarly, if the invoice is created from an order that's created from a quote created from an opportunity, it must use the same currency as the opportunity.
  
## Create an invoice  
  
1. In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "Site map icon"), and then select **Invoices**. 
  
2. Select **New**.  

3. On the **Invoice** form, enter data in the following required fields:

    -  **Name** 
  
    -  **Price List** and **Currency**: Select the price list and the currency that will be used to calculate the product prices. 

        > [!NOTE]
        > By default, selecting a price list is required to be able to add products to an invoice; however, your administrator can change your organization settings to make the Price List field optional. 

   -  **Prices Locked**. This field is read-only. You set **Prices Locked** by selecting **Lock Pricing** on the command bar. More information: [Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md), [Sales transactions in Dynamics 365 Sales](sales-transactions.md) 

  
4. In the **Sales Information** section, in **Potential Customer**, select the customer you're creating this invoice for.
  
5. On the command bar, select **Save** to create the invoice record.  
  
6. To add products from your opportunity to your order, select **Get Products** at the top of the screen, select your opportunity, and then select **OK**.  
  
    -OR-
    To manually add other products, in the **Products** section, select the **More commands** icon ![More commands icon](media/more-commands-button.png "More commands icon"), and then select **Add New Invoice Product**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to Quote, invoice, or order records](add-product-quote-order-invoice.md)
    
  
     You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] doesn't automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.  
  
7. In the **Shipping Information** area, enter shipping details.  
  
8. In the **Addresses** area, enter shipping and billing addresses.  
  
9. Select **Save** in the lower-right corner of the screen.  
  
> [!NOTE]
>  You close an invoice either by canceling the invoice or setting the invoice status as paid.  
  
<a name="bkmk3"></a>   
## Edit an invoice  
  
1. In the list of invoices, select the invoice you want to edit.  
  
2. Add or change any details about your invoice.  
  
3. Select **Save** in the lower-right corner of the screen.  

> [!NOTE]
> It isn't possible to edit multiple invoice records at once. 
  
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Close an opportunity as won or lost (Sales)](../sales-enterprise/close-opportunity-won-lost-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also  
[Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
[Print quote, invoice, or other records](print-records.md)
