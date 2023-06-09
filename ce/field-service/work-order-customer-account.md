---
title: "Work orders and service accounts"
description: Learn how to add a customer, location, and related account details to a work order in Dynamics 365 Field Service
ms.date: 12/08/2022
ms.topic: article
author: lmasieri
ms.author: lmasieri
---

# Work orders and service accounts

Dynamics 365 Field Service uses accounts and contacts throughout the work order process.

In this article, we'll explore creating and using accounts on work orders.

## Use a service account on a work order

1. Go to **Field Service** > **Work Orders**.
1. Select **+New**.
1. Choose an [existing service account or create a new one](accounts.md).

   Some values are automatically populated:

   - **Billing Account**

   - **Price List**

   - **Primary Contact**

   - **Service Territory and Instructions**

   - **Address**

   - **Location**

     > [!TIP]
     > Move the map pin to edit the work order location. For example, if the address points to an arbitrary location but the work order must take place at a specificlocation.

## Invoice the billing account

When the work order is finished and the system status is changed to **Closed-Posted**, an invoice with all used work order products and services is generated for the account listed in the **billing account** on the work order.

Go to **Field Service > Sales > Invoices** to view the newly generated invoice for the closed work order. Notice the account on the invoice is the billing account on the work order, and the name references the work order number. See the following screenshot for reference.

> [!div class="mx-imgBorder"]
> ![Screenshot of invoice for billing account.](./media/work-order-invoice.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
