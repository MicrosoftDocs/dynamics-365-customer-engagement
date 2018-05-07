---
title: "Create or edit an invoice (Dynamics 365 for Sales) | MicrosoftDocs"
description: "An invoice is an order that has been billed to the customer."
keywords: "Invoice, bill, sale"
ms.date: 09/22/2017
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: b58780fa-4e39-4925-99ad-e2e1bbfb5fa4
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 34
topic-status: Drafting
---

# Create or edit an invoice (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

When a customer places an order, you can create an invoice to bill them for the upcoming sale.  
  
Typically, you convert an order into an invoice. However, you can also create an invoice that does not originate from an order.  
    
<a name="bkmk1"></a>   
## Create an invoice from an order  

1. [!INCLUDE[proc_sales_orders](../includes/proc-sales-orders.md)]  

    or

    In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Orders**. 
  
2.  Select the order you want to create an invoice from.  
  
3.  Select **Create Invoice** at the top of the screen.  
  
4.  Review the contents of the invoice and make any additions or corrections before sending to your customer.  
  
<a name="bkmk2"></a>   
## Create an invoice  
  
1. [!INCLUDE[proc_sales_invoices](../includes/proc-sales-invoices.md)]  

    or

    In the Sales Hub app, select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Invoices**. 
  
2.  Select **New**.  
  
3.  Add your customer's contact information.  
  
4.  Select **Save** in the upper-left corner to create the invoice record.  
  
5.  To add products from your opportunity to your order, select **Get Products** at the top of the screen, select your opportunity, and then select **OK**.  
  
6.  To add information about a product on the invoice, in the **Products** area, select **Add a Product** ![Add button](../sales-enterprise/media/add-button.PNG "Add button"), and then select one of the following options:  
  
    - **Existing Product**: A product created in the product catalog that is associated with a price list  
  
    - **Write-in Product**: A product that is available but not a part of the product catalog  
  
    - **Get Products**: Products from a previously created opportunity  
  
     You need to enter the tax amount when you add a product to a quote, order, or invoice. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] doesn't automatically calculate tax for individual products. However, the total tax is calculated automatically based on the sum of the tax amounts for all of the individual products in a quote, order, or invoice.  
  
7.  In the **Shipping Information** area, enter shipping details.  
  
8.  In the **Addresses** area, enter shipping and billing addresses.  
  
9. Select **Save** in the lower-right corner of the screen.  
  
> [!NOTE]
>  You close an invoice either by canceling the invoice or setting the invoice status as paid.  
  
<a name="bkmk3"></a>   
## Edit an invoice  
  
1. [!INCLUDE[proc_sales_invoices](../includes/proc-sales-invoices.md)]  
  
2.  Select the invoice you want to edit.  
  
3.  Add or change any details about your invoice.  
  
4.  Select **Save** in the lower-right corner of the screen.  
  
<a name="bkmk4"></a>   
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Close an opportunity as won or lost (Sales)](../sales-enterprise/close-opportunity-won-lost-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also  
[Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)
[Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)
