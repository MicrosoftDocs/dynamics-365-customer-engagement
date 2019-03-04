---
title: Product catalog pricing 
description: This topic provides information about how pricing catalog products in Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 02/14/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Product catalog pricing 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]


Microsoft Dynamics 365 for Product Service Automation (PSA) supports product catalog pricing by using price lists and price list item entities. For the most part, PSA uses this functionality for catalog-based lines on project quotes and project contracts.

For project-based lines, a contract represents the deal after it was won. Because the process of negotiation usually precedes that win, the pricing attached to the quote is always copied as-is into a new price list and attached to the contract. This new price list can't be changed outside the scope of the contract. This is so that the negotiated rate card is protected from any changes in prices to the master price list.

Products should be set up with default cost and list prices in the product catalog. You must use the list price, standard cost, and current cost to configure default cost and list prices. These default list prices are used on a quote line or a project contract line only when the system can’t find a price list line for that product in the product price list of the quote or project contract.

The cost price of product catalog lines can be changed between quotes. This is important because if you don’t accurately track costs, you can’t determine operational profits on project engagements. Cost price is defaulted from standard cost of the product. This can be updated to a different value on the quote line if there’s a different cost price for that quote.

## Price list items

You can add products from a catalog to different price lists. Price list lines for products always reference a specific unit. Pricing for a product on price list items can be configured as a currency amount or as a function of the list price, current cost, or standard cost. 
PSA supports various rounding options when price is configured as a function of the list price, standard cost, or current cost. In addition to multiple pricing methods and rounding options, you have the option to associate discount lists with price list items. 

> ![Add products from a catalog to different price lists](media/basic-guide-16.png)

When you create a new custom price list for a quote by using **Create Custom Pricing** on the **Project Quote** page, PSA makes a copy of the price list and the **Entity** field on the new price list header is set to **Sales Entity**. The name of the new price list is appended with the name of the quote and the timestamp. You also can use the name of the new price list and the name of the quote in custom workflows to trigger additional review and approvals for quotes that use custom pricing.

 
## Product price list defaults

Each customer record contains a **Default Price List** field. You can add a price list that matches the currency of the customer to this field. In PSA, this field does not automatically default. When a custom pricing agreement exists with a specific customer, you can associate a price list to the customer by using this field.

The **Opportunity**, **Quote**, and **Project Contract** entities use the following order for defaulting product price lists. This is the same order that is used for project price lists.

1.	Quote
2.	Opportunity
3.	Customer
4.	Global settings for Project Service

By default, the **Product** field on the quote line shows all of the active products in the product price list of the quote. If the product you are looking for has been deactivated or is a draft product, you won’t see it in the drop-down list, even if it is in the price list. 

Product catalog lines are added to the first invoice that’s created for a project contract. These invoice lines can be deleted on a draft invoice. In that scenario, the lines will appear on a subsequent invoice until they are invoiced, or the invoice is sent to the customer. With PSA, you can’t invoice a partial quantity of a product invoice line. When the product lines from the project contract are invoice, actuals are created. However, these actuals don’t have any links to the related project entity. In other words, product-based project contract lines are independent of any project-based usage. PSA doesn’t track material consumption on projects.
