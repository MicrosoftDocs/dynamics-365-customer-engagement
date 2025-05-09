---
title: "Upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise (Dynamics 365 Sales) | MicrosoftDocs"
description: "Follow the steps in this topic to upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise."
ms.date: 04/06/2025
ms.topic: upgrade-and-migration-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise 

Learn the steps to upgrade from Sales Professional to Sales Enterprise.

## Move from Sales Professional to Sales Enterprise 

[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional is targeted at businesses that have simpler sales needs and do not require the full sales capabilities. However, if at any point you find your requirements growing, you can easily upgrade to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise. 

The upgrade process involves the following steps:

1. Purchasing a [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise subscription.

2. Assigning [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise licenses to the users.

3. Installing the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise edition solution.

4. Deleting the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution. 

## Purchase Dynamics 365 Sales Enterprise Edition subscription

1. Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the Dynamics 365 account that has admin permissions.

1. In the left pane, select **Billing** > **Purchase Services**.

1. Find **Dynamics 365 Sales Enterprise Edition**, and then select **Details**.

1. In **Select license quantity**, select or enter the number of licenses to purchase.

1. Select **Buy**, and then complete the purchase process.

## Assign licenses to your users

After you've purchased the licenses, assign the licenses to users. 

1.	Go to Microsoft 365 admin center, and in the left pane, select **Users** > **Active users**.

2.	Select multiple users, and then select **Manage product licenses**. 
    
    :::image type="content" source="media/assign-licenses-multiple-users.png" alt-text="Screenshot of assigning licenses to multiple users.":::

3.	In **Manage product licenses** pane, select **Replace**, and then select the license for your Dynamics 365 Sales plan. 

4.	Select **Save changes**, and then select **Done**.

5.	Review the license status on the **Active users** page and make other assignments as needed. 


## Install Dynamics 365 Sales Enterprise solution  

To install the Sales Enterprise solution on a Power Platform environment with Dynamics 365 apps enabled:

1.	Sign in to the Power Platform admin center at [https://admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) as an admin (Dynamics 365 admin or Power Platform admin).

2. In the navigation pane, select **Environments**. 

3.	Open the environment in which you want to install the Sales Enterprise solution, and select **Dynamics 365 apps**.

    :::image type="content" source="media/resources-select-dynamics-365-apps.png" alt-text="Screenshot of selecting the Dynamics 365 apps resource.":::

4.	On the command bar, select **Install app**.

    :::image type="content" source="media/select-install-app-dynamics365-apps-resource.png" alt-text="Screenshot of selecting the Install app option.":::

5. In the **Install Dynamics 365 apps** panel, select 'Dynamics 365 Sales, Enterprise Edition app', and select **Next**.

6. Agree to the terms of service, and then select **Install**.

After you complete these steps, your organization will be effectively upgraded to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise.


## Delete the Dynamics 365 Sales Professional solution

1. Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. Sign in to Dynamics 365. 

1. Select **Settings** > **Advanced Settings**.

    The **Power Platform Environment Settings** page opens.

1. In the left pane, select **Customization** > **Solutions**.

1. Select the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution and select **Delete**. 

    > [!NOTE]
    > When you delete this solution, the Sales Pro app module is deleted, and any configuration specific to this app module such as its site map and form preferences are also lost.

> [!IMPORTANT]
> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Dynamics 365 Licensing Update](/dynamics365/licensing/update)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
