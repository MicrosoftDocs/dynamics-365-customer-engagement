---
title: "Create or edit orders (Dynamics 365 Sales Professional) | MicrosoftDocs"
description: "A sales order is a quote that your customer has accepted."
ms.date: 07/21/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdyn_salespro
  - D365-Entity-salesorder
  - D365-Entity-quote
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create and manage orders in Dynamics 365 Sales Professional

Congratulations! Your hard work nurturing your customer has paid off and they're ready to place an order for your products or services. In [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], an order can originate from a customer's acceptance of a quote, or you can place an order without an accepted quote, depending on the situation.  
  
 One way that can help you increase your sales is to add all products that your customer might need to your order. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] may also offer product bundles or product families to make it easier for you to choose products for upsell and cross-sell. 

If your administrator has enabled the Quote to Order setting, you can create an order from a quote if you've already prepared a quote for your customer. More information: [Enable creation of orders from quotes](enable-creation-of-orders-from-quotes.md) 
  
## Create an order from a quote  

Typically, you convert a quote that you have won into an order. Start with an active quote. Note that after a quote is accepted, you won't be able to revise it.  
  
1.  In the site map, select **Quotes**.

2.  Select the active quote that you want to create an order from.

3.  On the command bar, select **Create Order**.
  
4. In the **Create Order** dialog box, the **Date Won** field is set to the current date. Select a different date if required.

5. Add a description, and select **OK**.  
  
6. To add products from your opportunity to your quote, select **Get Products** at the top of the screen, select your opportunity, and select **OK**.  
  
7. Select **Save** in the lower-right corner of the screen.  

> [!NOTE]
> 
> Your base record and all its line items must use the same currency. For example, if your order has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the order. You can’t change the currency of the base record (in this case, an order), unless you remove all the line items associated with the record.
> Similarly, if the order is created from a quote that is generated from an opportunity, it must use the same currency as the opportunity.


> [!IMPORTANT]
> Once your order is final, you can create an invoice from the order by selecting the **Create Invoice** button on the command bar. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)][Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
> If Dynamics 365 Sales is integrated with an external order processing application, you may see the **Submit Order** button instead of the **Create Invoice** button on the Order form command bar. This is because the integration allows an order created in Dynamics 365 Sales to be submitted, upon which the order is synced to the order processing app where the lifecycle of the order continues. A submitted order is locked for editing in Dynamics 365 Sales except by an integration user. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enable sales order processing integration](../sales-enterprise/developer/enable-sales-order-processing-integration.md)


## Create an order  
 You can create an order that is based on your communication with a customer instead of an accepted quote.  
  
1.  In the site map, select **Orders**.

2.  Select **New**.

    The Order form opens.
  
3. On the **Order** form, enter data in the following required fields:

    -	**Name** 
  
    -	**Price List** and **Currency**: Select the price list and the currency that will be used to calculate the product prices. 

        > [!NOTE]
        > By default, selecting a price list is required to be able to add products to an order. However, your administrator can change your organization settings to make the **Price list** field optional.

4. In the **Sales Information** section, in **Potential Customer**, select the customer you're creating this order for.

5. On the command bar, select **Save**.

6. To add products from a previously created opportunity to your order, select **Get Products** at the top of the screen, select your opportunity, and then select **OK**.  

    -OR-

    To manually add other products, in the **Products** section, select the **More commands** icon ![More commands icon](media/more-commands-button.png "More commands icon"), and then select **Add New Order Product**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to Quote, invoice, or order records](add-product-quote-order-invoice-sp.md)
  
   > [!NOTE]
   >  You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] does not automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.  
  
7. In the **Shipping Information** area, enter shipping details.  
  
8. In the **Addresses** area, enter shipping and billing addresses.  
  
9. Select **Save** in the lower-right corner of the screen.  
  
> [!NOTE]
>  You close an order by either fulfilling the order or canceling the order. Products or services that are shipped are fulfilled. You should cancel orders for any products or services that are not shipped.  
>   
>  You can't update or change an order after it has been closed, or if it has been partially or completely fulfilled.  
  
[Develop sales from lead to cash in Dynamics 365 Sales Professional](develop-sales-lead-to-cash-sales-professional.md)  
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)
[Sales transactions in Dynamics 365 Sales Professional](understanding-sales-transactions-sales-professional.md)  
[Enable creation of orders from quotes](enable-creation-of-orders-from-quotes.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]