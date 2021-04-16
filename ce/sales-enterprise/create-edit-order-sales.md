---
title: "Create or edit orders (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use orders in Dynamics 365 Sales to track details of the products or services your customers want to place an order for. A sales order is a quote that your customer has accepted."
ms.date: 02/10/2021
ms.service: dynamics-365-sales
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
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

# Create or edit orders (Sales Hub)

Congratulations! Your hard work nurturing your customer has paid off and they're ready to place an order for your products or services. In [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)], an order can originate from a customer's acceptance of a quote, or you can place an order without an accepted quote, depending on the situation.  
  
 One way that can help you increase your sales is to add all products that your customer might need to your order. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] may also offer product bundles or product families to make it easier for you to choose products for upsell and cross-sell. If you've already prepared a quote for your customer, you can create an order from that quote.  
  
<a name="bkmk1"></a>   
## Create an order from a quote  
 Typically, you convert a quote that you have won into an order. Start with an active quote. Note that after a quote is accepted, you won't be able to revise it.  
  
1. In the Sales Hub app, select the Site map icon ![Site Map icon](media/site-map-icon.png "Site map icon"), and then select **Quotes**. 
  
2. Select the quote you want to create an order from.  

3. On the command bar, select **Activate Quote**.
  
4. Select **Create Order** at the top of the **Quote** form.  
  
5. In the **Create Order** dialog box, the **Date Won** field is set to the current date. Select a different date if required.

6. Add a description, and select **OK**.  
  
7. To add products from your opportunity to your quote, select **Get Products** at the top of the screen, select your opportunity, and select **OK**.  
  
8. Select **Save** in the lower-right corner of the screen.  

> [!NOTE]
> 
> Your base record and all its line items must use the same currency. For example, if your order has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the order. You can't change the currency of the base record (in this case, an order), unless you remove all the line items associated with the record.
> Similarly, if the order is created from a quote that is generated from an opportunity, it must use the same currency as the opportunity.


> [!IMPORTANT]
> Once your order is final, you can create an invoice from the order by selecting the **Create Invoice** button on the command bar. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)][Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
> If Dynamics 365 Sales is integrated with an external order processing application, you may see the **Submit Order** button instead of the **Create Invoice** button on the Order form command bar. This is because the integration allows an order created in Dynamics 365 Sales to be submitted, upon which the order is synced to the order processing app where the lifecycle of the order continues. A submitted order is locked for editing in Dynamics 365 Sales except by an integration user. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enable sales order processing integration](developer/enable-sales-order-processing-integration.md)


## Create an order  
 You can create an order that is based on your communication with a customer instead of an accepted quote.  
  
1. In the Sales Hub app, select the Site map icon![Site Map icon](media/site-map-icon.png "Site map icon"), and then select **Orders**. 
  
2. Select **New**.  
  
3. On the **Order** form, enter data in the following required fields:

   -  **Name**. You must enter a name with a length of 100 characters or fewer. The information should be
meaningful and unique. By default, these records are sorted by Name in the records list.
   
   - **Price List** and **Currency**: Select the price list and the currency that will be used to calculate the product prices. 

        > [!NOTE]
        > By default, selecting a price list is required to be able to add products to an order. However, your administrator can change your organization settings to make the Price list field optional.

   -  **Prices Locked**. This field is read-only. You set **Prices Locked** by selecting **Lock Pricing** on the command bar. More information: [Lock or unlock the price for an order or invoice](lock-unlock-price-order-invoice.md), [Sales transactions in Dynamics 365 Sales](sales-transactions.md) 

4. In the **Sales Information** section, in **Potential Customer**, select the customer you're creating this order for.

5. On the command bar, select **Save**.

6. To add products from a previously created opportunity to your order, select **Get Products** at the top of the screen, select your opportunity, and then select **OK**.  

    -OR-

    To manually add other products, in the **Products** section, select the **More commands** icon ![More commands icon](media/more-commands-button.png "More commands icon"), and then select **Add New Order Product**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add products to Quote, invoice, or order records](add-product-quote-order-invoice.md)
  
   > [!NOTE]
   >  You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] does not automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.  
  
7. In the **Shipping Information** area, enter shipping details.  
  
8. In the **Addresses** area, enter shipping and billing addresses.  
  
9. Select **Save** in the lower-right corner of the screen.  
  
> [!NOTE]
>  You close an order by either fulfilling the order or canceling the order. Products or services that are shipped are fulfilled. You should cancel orders for any products or services that are not shipped.  
>   
>  You can't update or change an order after it has been closed, or if it has been partially or completely fulfilled.  
  
  
<a name="bkmk3"></a>   
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md) 
  
### See also  
[Print quote, invoice, or other records](print-records.md)  
[Sales transactions in Dynamics 365 Sales](sales-transactions.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
