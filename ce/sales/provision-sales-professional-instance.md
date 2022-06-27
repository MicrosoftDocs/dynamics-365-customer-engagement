---
title: "Provision an environment for Dynamics 365 Sales Professional"
description: "Learn about provisioning a Power Platform environment for Dynamics 365 Sales Professional."
ms.date: 06/27/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provision an environment for Dynamics 365 Sales Professional

Congratulations on the purchase of the Sales Professional application. 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|



Before you can start using the Sales Professional application, you need to do one of the following actions:

- If you don't have an existing Power Platform environment with Dynamics 365 apps enabled, [provision a new environment and install the Sales Professional app](#provision-a-new-power-platform-environment-for-sales-professional) 
- If you have an existing Power Platform environment with Dynamics 365 apps enabled, just [install the Sales Professional app on that environment](#install-the-sales-professional-app-on-an-existing-environment)

> [!NOTE]
> You must be a global administrator of your Microsoft 365 org (tenant) to perform both the above actions.

## Provision a new Power Platform environment for Sales Professional

1. Follow the instructions in [Create an environment with a database](/power-platform/admin/create-environment#create-an-environment-with-a-database) in the Power Platform admin guide.

1. Select **Sales Pro** as app name to deploy in the environment.  
    
1. After the environment moves to **Ready** state, go to Dynamics 365 home. 

8.	In the list of application, select **Sales Professional**. 

## Install the Sales Professional app on an existing environment

<a name="install-app"> </a>

You can install the Sales Professional app on an existing Power Platform environment, which is enabled for Dynamics 365 apps. For example, if you already have an environment for Dynamics 365 Customer Service, you can install the Sales Professional app on the same environment. 

1.	Sign in to the Power Platform admin center at [https://admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) as an admin (Dynamics 365 admin, Global admin, or Power Platform admin).

2. In the navigation pane, select **Environments**. 

3.	Open the environment in which you want to install the Sales Professional app, and select **Resources** > **Dynamics 365 apps**.

   > [!div class="mx-imgBorder"] 
   > ![Select Dynamics 365 apps resource.](media/resources-select-dynamics-365-apps.png "Select Dynamics 365 apps resource")

4.	On the command bar, select **Install app**.

   > [!div class="mx-imgBorder"] 
   > ![Select Install app.](media/select-install-app-dynamics365-apps-resource.png "Select Install app")

5. In the **Install Dynamics 365 apps** panel, select 'Dynamics 365 Sales, Professional', and select **Next**.

6. Agree to the terms of service, and then select **Install**.

7.	After the installation, go to Dynamics 365 home. 

8.	In the list of application, select **Sales Professional**. 
 
    ![Sales Professional app tile.](media/sales-professional-app-tile.png "Sales Professional app tile")


### See also
[Overview of Dynamics 365 Sales](overview.md)  
[Overview of admin settings](admin-settings-overview.md)  
[Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
