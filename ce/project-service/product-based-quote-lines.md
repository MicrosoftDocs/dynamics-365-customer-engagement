---
title: Product-based quote lines 
description: This topic provides information about product-based quote lines in Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 02/13/2019
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

# Product-based quote lines

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]


PSA uses the Dynamics 365 product catalog capabilities to create product-based quote lines. Product-based quote lines can be “write-in” lines or they can be items from the product catalog.

## Product catalog

Products are configured in a Dynamics 365 product catalog with a default unit and unit group. If several products share the same set of attributes, you may choose to create a product family that also has those attributes. All of the products in one product family inherit the same set of attributes.

For example, consider a company that sells subscription licenses for a variety of software. All subscription software has the following two key attributes:

- Number of users 
- Subscription duration listed as number of months

A good way to maintain this kind of catalog is to create a product family called **Subscription Software** with **Number of users** and **Subscription duration** as attributes. Individual products, such as **Dynamics 365 for Sales** or **Dynamics 365 for Field Service** can be products that you add to the **Subscription Software** product family.

## Adding product catalog items to a project quote

Project quotes and project contracts pages have sections for two types of lines: project-based lines and product-based lines. Product-based lines use Dynamics 365 for adding items from a catalog to a quote. The drop-down list on the quote line or project contract line lists all the products and units in the product price list attached to the quote or project contract. You may also add products that are not part of quote’s product price list.

You may also select products from other price lists or directly from the product catalog. When selecting directly from a catalog, sales price defaulting uses the default price list of that product to get the product’s sales price. If a default price list is not set, the price is set to 0.

You can override the sales price of a product catalog-based quote line directly on the quote line. 
Note that a quote line in Dynamics 365 has a pricing field. It has two settings options:

- Override pricing  
- Use default

When this field is set to override pricing, Dynamics 365 doesn’t set a default price. You must enter the price for the product on the quote line. When this field is set to use default, Dynamics 365 uses the default sales prices and locks the field to prevent editing.

After you install Project Service, product-based lines on a quote will have defaulted sales pricing and subsequently the pricing field is set to override pricing so that you’ll be able to edit the defaulted price on the quote line.

> ![Screenshot of setting override pricing](media/basic-guide-10.png)
 
## Quantity factors for products

Project Service uses quantity factors to support sales of subscription-based products. For subscription-based products, the quantity on the quote or project contract line is expressed as the number of user-months.

The price of subscription software is usually stored in the catalog as price per user, per month, although you can use other time descriptions. During the sales process, on the quote line, it is usually the per-user, per-month price that is negotiated and discounted by the IT sales agent. Each deal has its own number of users and a different number of subscription months. The quantity used to compute the quote line amount is a product of the number of users and the number of subscription months. To support this type of sales, Project Service introduced the concept of quantity factors. 

Quantity factors relies on the product attributes in Dynamics 365. When you configure a product with specific properties, with Project Service, you can flag a subset or all properties of a product as quantity factors.

Project Service validates that only numeric properties or product properties that have a numeric data type are flagged as quantity factors. When a product that has quantity factors configured is added to a quote line, the quantity field on the quote line becomes a read-only field. After you enter values for product properties that are quantity factors, Project Service computes the quantity of the quote line.

For example, Dynamics 365 might have the following properties: 
- Number of users (a quantity factor) 
- Number of subscription months (a quantity factor) 
- Product SKU 

Number of users and Number of subscription months may be flagged as quantity factors. On the quote line, it works like this:

> ![Flagging number of users and number of subscription months as quality factors](media/basic-guide-11.png)
 
