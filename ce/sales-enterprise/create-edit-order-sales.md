---
title: "Create or edit an order (Dynamics 365 for Sales) | MicrosoftDocs"
description: "A sales order is a quote that your customer has accepted."
keywords: "Order, quote, accepted"
ms.date: 09/22/2017
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 19543bce-3228-4723-825f-2358c4b18ff7
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 34
topic-status: Fixing Edits
---

# Create or edit an order (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Congratulations! Your hard work nurturing your customer has paid off and they're ready to place an order for your products or services. In [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)], an order can originate from a customer's acceptance of a quote, or you can place an order without an accepted quote, depending on the situation.  
  
 One way that can help you increase your sales is to add all products that your customer might need to your order. Your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system might offer product bundles or product families to make it easier for you to choose products for upsell and cross-sell. If you've already prepared a quote for your customer, you can create an order from that quote.  
  
<a name="bkmk1"></a>   
## Create an order from a quote  
 Typically, you convert a quote that you have won into an order. Start with an active quote. Note that after a quote is accepted, you won't be able to revise it.  
  
1. [!INCLUDE[proc_sales_quotes](../includes/proc-sales-quotes.md)]  

   or

   In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Quotes**. 
  
2.  Select the quote you want to create an order from.  

3.  On the command bar, select **Activate Quote**.
  
4.  Select **Create Order** at the top of the **Quote** form.  
  
5.  In the **Create Order** dialog box, the **Date Won** field is set to the current date. Select a different date if required.

4.  Add a description, and select **OK**.  
  
5.  To add products from your opportunity to your quote, select **Get Products** at the top of the screen, select your opportunity, and select **OK**.  
  
6.  Select **Save** in the lower-right corner of the screen.  
  
<a name="bkmk2"></a>   
## Create an order  
 You can create an order that is based on your communication with a customer instead of an accepted quote.  
  
1. [!INCLUDE[proc_sales_orders](../includes/proc-sales-orders.md)]  

   or

   In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Orders**. 
  
2.  Select **New**.  
  
3.  Add your customer's contact information.  
  
4.  To add products from your opportunity to your order, select **Get Products** at the top of the screen, select your opportunity, and then select **OK**.  
  
    > [!NOTE]
    >  You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] does not automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.  
  
5.  In the **Shipping Information** area, enter shipping details.  
  
6.  In the **Addresses** area, enter shipping and billing addresses.  
  
7.  Select **Save** in the lower-right corner of the screen.  
  
> [!NOTE]
>  You close an order by either fulfilling the order or canceling the order. Products or services that are shipped are fulfilled. You should cancel orders for any products or services that are not shipped.  
>   
>  You can't update or change an order after it has been closed, or if it has been partially or completely fulfilled.  
  
  
<a name="bkmk3"></a>   
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit an invoice](../sales-enterprise/create-edit-invoice-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md) 
  
### See also  
[Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)
