---
title: "Upgrade from Dynamics 365 for Sales Professional to Dynamics 365 for Sales Enterprise (Dynamics 365 for Sales) | Microsoft Docs"
description: "Follow the steps in this topic to upgrade from Dynamics 365 for Sales Professional to Dynamics 365 for Sales Enterprise."
keywords: "Dynamics 365 for Sales, Professional, Enterprise, Upgrade"
ms.date: 05/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: b56f50ee-c4aa-447b-9912-a7031a0075ff
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Upgrade from Dynamics 365 for Sales Professional to Dynamics 365 for Sales Enterprise

[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional is targeted at businesses that have simpler sales needs and do not require the full sales capabilities. However, if at any point you find your requirements growing, you can easily upgrade to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise. 

The upgrade process involves three steps:

1.  Purchasing a [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise subscription.

2.  Assigning [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise licenses to the users.

3.  Installing the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise edition solution.

## Purchase Dynamics 365 for Sales Enterprise Edition subscription

1.  Sign in to Office 365 at portal.office.com with the Dynamics 365 account that has admin permissions.

2.  Select **Billing** > **Subscription**.

    ![Select Subscription](media/subscription-office-365-admin-center.png "Select Subscription")

    You’ll see the active subscriptions. 

    ![Active subscriptions](media/active-subscriptions.png "Active subscriptions")

3.  Select **Add subscriptions**.

    The **Purchase Services** page opens. You’ll see a tile for [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise Edition.

    ![Dynamics 365 for Sales Enterprise Edition tile on Purchase Services page](media/purchase-services-page.png "Dynamics 365 for Sales Enterprise Edition tile on Purchase Services page")
 
4.	In the **[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise Edition** tile, move your mouse over the Ellipses icon and select **Buy Now**, and then follow the steps to purchase new licenses. 

    ![Buy Dynamics 365 for Sales Enterprise Edition plan](media/buy-sales-enterprise.png "Buy Dynamics 365 for Sales Enterprise Edition plan")


## Assign licenses to your users

After you’ve purchased the licenses, assign the licenses to users. 

1.	On the Office 365 admin center, select **Users** > **Active users**.

2.	Select multiple users, and then select **Edit product licenses**. 
    
    ![Bulk action to edit multiple product licenses](media/bulk-actions-edit-product-licenses.png "Bulk action to edit multiple product licenses")

3.	Select **Replace existing product license assignments**, and then select **Next**. 

4.	Turn on the license for your Dynamics 365 plan. 

    ![Turn on your Dynamics 365 plan](media/turn-license-on.png "Turn on your Dynamics 365 plan")

5.	Select **Replace**, and then select **Close** twice. 

6.	Review the license status on the **Active users** page and make other assignments as needed. 

    ![Active users page](media/active-users-page.png "Active users page")


## Install Dynamics 365 for Sales Enterprise solution

1.	In the Office 365 admin center, select **Admin Center** > **Dynamics 365**.

    ![Dynamics 365 admin center in Office 365 nav bar](media/select-admin-center.png "Dynamics 365 admin center in Office 365 nav bar")
    
    The **Dynamics 365 Administration Center** opens.

2.	On the **Instances** tab, select your production instance, and on the product instance tile, select the **Manage your solutions** ![Manage your solutions](media/manage-your-solutions.png "Manage your solutions") icon.

    ![Production instance on the Instances tab](media/production-instance-on-instances-tab.png "Production instance on the Instances tab")

3.	On the **Manage your solutions** page, select **Dynamics 365 for Sales Application**, and on the tile, select **Install**.

After you complete these steps, your organization will be effectively upgraded to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise.


> [!IMPORTANT]

> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)
