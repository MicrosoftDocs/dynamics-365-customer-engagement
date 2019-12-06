---
title: "Move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional (Dynamics 365 Sales) | MicrosoftDocs"
description: "Follow the steps in this topic to move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Move from Dynamics 365 Sales Enterprise edition to Dynamics 365 Sales Professional

[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional is targeted at businesses that have simpler sales needs and do not require the full sales capabilities. If you ever want to switch from [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional, do the following:

1.	Purchase a [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional subscription.

2.	Assign [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional licenses to the users.

3.	Install the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional edition solution.

4.	Delete the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise edition solution.


## Purchase Dynamics 365 Sales Professional subscription

1.  Sign in to Office 365 at admin.microsoft.com with the Dynamics 365 account that has admin permissions.

2.  Select **Billing** > **Subscriptions**.

    ![Select Subscriptions](media/subscription-office-365-admin-center.png "Select Subscriptions")

    You’ll see the active subscriptions. 

3.  Select **Add subscriptions**.

    The **Purchase Services** page opens. You’ll see a tile for [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional Edition.

4.	In the **[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional Edition** tile, move your mouse over the Ellipses icon and select **Buy Now**, and then follow the steps to purchase new licenses. 

## Assign licenses to your users

After you’ve purchased the licenses, assign the licenses to users. 

1.	On the Microsoft 365 admin center, select **Users** > **Active users**.

2.	Select multiple users, and then select **Edit product licenses**. 
    
    ![Bulk action to edit multiple product licenses](media/bulk-actions-edit-product-licenses.png "Bulk action to edit multiple product licenses")

3.	Select **Replace existing product license assignments**, and then select **Next**. 

4.	Turn on the license for your Dynamics 365 Sales plan. 

5.	Select **Replace**, and then select **Close** twice. 

6.	Review the license status on the **Active users** page and make other assignments as needed. 

## Install Dynamics 365 Sales Professional solution

1.	In the Microsoft 365 admin center, select **Admin Centers** > **Dynamics 365**.

    ![Dynamics 365 admin center in Office 365 nav bar](media/select-admin-center.png "Dynamics 365 admin center in Office 365 nav bar")
    
    The **Dynamics 365 Administration Center** opens.

2.	On the **Instances** tab, select your production instance, and on the product instance tile, select the **Manage your solutions** ![Manage your solutions](media/manage-your-solutions.png "Manage your solutions") icon.

    ![Production instance on the Instances tab](media/production-instance-on-instances-tab.png "Production instance on the Instances tab")

3.	On the **Manage your solutions** page, select **Dynamics 365 Sales Pro Application**, and on the tile, select **Install**.

After you complete these steps, your organization will be effectively moved to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional.


## Delete the Dynamics 365 Sales Enterprise solution

1.	Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

2.	Sign in to Dynamics 365. 

3.	Select **Settings** > **Solutions**. 

4.	Select the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise solution and select **Delete**. 

    > [!NOTE]

    > When you delete this solution, the Sales Enterprise app module is deleted and any configuration and customization specific to this app module such as its site map or form preferences are also lost.


> [!IMPORTANT]

> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)


### See also

[Dynamics 365 Licensing Update](https://docs.microsoft.com/en-us/dynamics365/licensing/update)
