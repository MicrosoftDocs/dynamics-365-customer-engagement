---
title: "Understand sales transactions (Dynamics 365 for Sales, Preview) | Microsoft Docs"
description: "Understand how to use quotes and invoices for sales transactions in Dynamics 365 for Sales, Preview"
keywords: "Quotes; quote stages; current pricing; locked pricing; invoice; sales"
ms.date: 12/15/2017
ms.service: dynamics-365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom: dyn365-sales
ms.assetid: 91f58ed9-0be1-4395-b033-742c2cef11e7
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Sales transactions in [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc-applies-to-update-9-0-0.md)]

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

In [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview, a sale typically starts with a draft quote. When the quote is ready, it is activated and sent to the customer for revisions before it is accepted, and then when you’re shipping the products offered in the quote, an invoice is generated from the quote.

Quotes and invoices in the Sales app are the same item in different states of transition. You can use tools and templates to create and print quotes and invoices.

## Understanding Quote Stages

When you create a new quote, it is automatically set to Draft, and the revision ID is set to 0.

Before a quote it sent to a customer, it must be set Active. Activating a quote makes it read-only so your versions matches the customer's version. If you revise it, the revision ID will increase by one.

When you close a quote, you have three choices: Lost, Canceled, or Revised. If you revise it, a new quote is created, set to Draft status, and you can start over. If you do not revise it, the quote is closed.

## Differences between Current Pricing and Prices Locked in invoices

[!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)] has two kinds of pricing behavior on invoices: **Use Current Pricing** and **Prices Locked**.

The **Use Current Pricing** comes directly from the product catalog; If you change the price of a product there, then it will change in all open invoices that include the product.

**Prices Locked** locks the price for a product in an open invoice. Even if the price changes in the product catalog, that invoice will remain at the agreed price.


### See Also
[Create and manage quotes in Dynamics 365 for Sales, Preview](create-manage-quotes.md)  
[Create and manage invoices in Dynamics 365 for Sales, Preview](create-manage-invoices.md)  
[Overview of Dynamics 365 for Sales, Preview](overview-dynamics-365-for-sales.md)  
