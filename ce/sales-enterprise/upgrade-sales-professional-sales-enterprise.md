---
title: "Upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise (Dynamics 365 Sales) | MicrosoftDocs"
description: "Follow the steps in this topic to upgrade from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise."
ms.date: 09/23/2020
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Move from Dynamics 365 Sales Professional to Dynamics 365 Sales Enterprise

[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional is targeted at businesses that have simpler sales needs and do not require the full sales capabilities. However, if at any point you find your requirements growing, you can easily upgrade to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise. 

The upgrade process involves the following steps:

1. Purchasing a [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise subscription.

2. Assigning [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise licenses to the users.

3. Installing the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise edition solution.

4. Deleting the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution. 

## Purchase Dynamics 365 Sales Enterprise Edition subscription

1.  Sign in to [Microsoft 365 admin center](https://admin.microsoft.com) with the Dynamics 365 account that has admin permissions.

2.  In the navigation pane, select **Purchase Services**, and then select the Dynamics 365 Sales Enterprise Edition tile. 

    > [!div class="mx-imgBorder"]
    > ![Select Dynamics 365 Sales Enterprise tile](media/select-dynamics365-sales-enterprise-tile.png "Select Dynamics 365 Sales Enterprise tile") 

3.  Select **Buy**, and then follow the steps to purchase new licenses. 

    > [!div class="mx-imgBorder"]
    > ![Select Buy](media/buy-sales-enterprise-edition.png "Select Buy") 



## Assign licenses to your users

After you’ve purchased the licenses, assign the licenses to users. 

1.	Go to Microsoft 365 admin center, and in the navigation pane, select **Users** > **Active users**.

2.	Select multiple users, and then select **Manage product licenses**. 
    
    > [!div class="mx-imgBorder"]
    > ![Assign licenses to multiple users](media/assign-licenses-multiple-users.png "Assign licenses to multiple users")

3.	Select **Replace existing product license assignments**, and then select **Next**. 

4.	Turn on the license for your Dynamics 365 Sales plan. 

5.	Select **Replace**, and then select **Close** twice. 

6.	Review the license status on the **Active users** page and make other assignments as needed. 


## Install Dynamics 365 Sales Enterprise solution  

To install the Sales Enterprise solution on a Dynamics 365 environment:

1.	Sign in to the Power Platform admin center at [https://admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) as an admin (Dynamics 365 admin, Global admin, or Power Platform admin).

2. In the navigation pane, select **Environments**. 

3.	Open the environment in which you want to install the Sales Enterprise solution, and select **Dynamics 365 apps**.

   > [!div class="mx-imgBorder"] 
   > ![Select Dynamics 365 apps resource](../sales-professional/media/resources-select-dynamics-365-apps.png "Select Dynamics 365 apps resource")

4.	On the command bar, select **Install app**.

   > [!div class="mx-imgBorder"] 
   > ![Select Install app](../sales-professional/media/select-install-app-dynamics365-apps-resource.png "Select Install app")

5. In the **Install Dynamics 365 apps** panel, select 'Dynamics 365 Sales, Enterprise Edition app', and select **Next**.

6. Agree to the terms of service, and then select **Install**.

After you complete these steps, your organization will be effectively upgraded to [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Enterprise.


## Delete the Dynamics 365 Sales Professional solution

1.	Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

2.	Sign in to Dynamics 365. 

3.	Select **Settings** > **Solutions**. 

4.	Select the [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] Professional solution and select **Delete**. 

    > [!NOTE]
    > When you delete this solution, the Sales Pro app module is deleted, and any configuration specific to this app module such as its site map and form preferences are also lost.

> [!IMPORTANT]
> As per contractual agreement, you can't mix and match Enterprise and Professional users on the same instance. If you plan to keep Professional licenses, make sure you abide by the contractual requirements. More information: [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544)


### See also

[Dynamics 365 Licensing Update](https://docs.microsoft.com/dynamics365/licensing/update)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
