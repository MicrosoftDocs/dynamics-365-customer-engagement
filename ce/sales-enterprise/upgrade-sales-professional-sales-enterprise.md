---
title: "Upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise (Dynamics 365 Sales) | MicrosoftDocs"
description: "Follow the steps in this topic to upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise."
keywords: ""
ms.date: 10/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
ms.assetid: 82effd98-e46a-b70c-6d1b-3f487e103565
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise

[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional is targeted at businesses that have simpler sales needs and do not require the full sales capabilities. However, if at any point you find your requirements growing, you can easily upgrade to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise. 

The upgrade process involves three steps:

1. Purchasing a [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise subscription.

2. Assigning [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise licenses to the users.

3. Installing the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise edition solution.

4. Deleting the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution. 

## Purchase Dynamics 365 Sales Enterprise Edition subscription

1. Sign in to Office 365 at admin.microsoft.com with the Dynamics 365 account that has admin permissions.

2. Select **Billing** > **Subscriptions**.

   > [!div class="mx-imgBorder"]
   > ![Select Subscriptions](media/subscription-office-365-admin-center.png "Select Subscriptions")

   You’ll see the active subscriptions. 

   > [!div class="mx-imgBorder"]
   > ![Active subscriptions](media/active-subscriptions.png "Active subscriptions")

3. Select **Add subscriptions**.

   The **Purchase Services** page opens. You’ll see a tile for [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise Edition.

   > [!div class="mx-imgBorder"]
   > ![Dynamics 365 for for Sales Enterprise Edition tile on Purchase Services page](media/purchase-services-page.png "Dynamics 365 Sales Enterprise Edition tile on Purchase Services page")
 
4. In the **[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise Edition** tile, move your mouse over the Ellipses icon and select **Buy Now**, and then follow the steps to purchase new licenses. 

   > [!div class="mx-imgBorder"]
   > ![Buy Dynamics 365 Sales Enterprise Edition plan](media/buy-sales-enterprise.png "Buy Dynamics 365 Sales Enterprise Edition plan")


## Assign licenses to your users

After you’ve purchased the licenses, assign the licenses to users. 

1.	On the Microsoft 365 admin center, select **Users** > **Active users**.

2.	Select multiple users, and then select **Edit product licenses**. 
    
   > [!div class="mx-imgBorder"]
   > ![Bulk action to edit multiple product licenses](media/bulk-actions-edit-product-licenses.png "Bulk action to edit multiple product licenses")

3.	Select **Replace existing product license assignments**, and then select **Next**. 

4.	Turn on the license for your Dynamics 365 Sales plan. 

   > [!div class="mx-imgBorder"]
   > ![Turn on your Dynamics 365 Sales plan](media/turn-license-on.png "Turn on your Dynamics 365 Sales plan")

5.	Select **Replace**, and then select **Close** twice. 

6.	Review the license status on the **Active users** page and make other assignments as needed. 

   > [!div class="mx-imgBorder"]
   > ![Active users page](media/active-users-page.png "Active users page")


## Install Dynamics 365 Sales Enterprise solution

1.	In the Microsoft 365 admin center, select **Admin Centers** > **Dynamics 365**.

   > [!div class="mx-imgBorder"]
   > ![Dynamics 365 admin center in Office 365 nav bar](media/select-admin-center.png "Dynamics 365 admin center in Office 365 nav bar")
    
    The **Dynamics 365 Administration Center** opens.

2.	On the **Instances** tab, select your production instance, and on the product instance tile, select the **Manage your solutions** ![Manage your solutions](media/manage-your-solutions.png "Manage your solutions") icon.

   > [!div class="mx-imgBorder"]
   > ![Production instance on the Instances tab](media/production-instance-on-instances-tab.png "Production instance on the Instances tab")

3.	On the **Manage your solutions** page, select **Dynamics 365 Sales Application**, and on the tile, select **Install**.

After you complete these steps, your organization will be effectively upgraded to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise.


## Delete the Dynamics 365 Sales Professional solution

1.	Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

2.	Sign in to Dynamics 365. 

3.	Select **Settings** > **Solutions**. 

4.	Select the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution and select **Delete**. 

    > [!NOTE]

    > When you delete this solution, the Sales Pro app module is deleted, and any configuration specific to this app module such as its site map and form preferences are also lost.

> [!IMPORTANT]
> 
> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)


### See also

[Dynamics 365 Licensing Update](https://docs.microsoft.com/dynamics365/licensing/update)
