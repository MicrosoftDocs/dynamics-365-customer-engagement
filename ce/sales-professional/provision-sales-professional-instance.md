---
title: "Provision your Dynamics 365 Sales Professional environment (Dynamics 365 Sales Professional) | MicrosoftDocs"
description: "Learn about the standard and advanced settings in Dynamics 365 Sales Professional."
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

# Provision your Dynamics 365 Sales Professional environment
Congratulations on the purchase of the Sales Professional application. 

Before you can start using the Sales Professional application you need to

1.	Provision a new Dynamics 365 environment (instance)
2.	Install the Sales Professional solution on a Dynamics 365 environment (instance).

> [!NOTE]
> You must be a global administrator of your Microsoft 365 org (tenant) to perform both the above actions.

## Provision a new Dynamics 365 environment

You need a Dynamics 365 environment to install the Sales Professional application. If you already have a Dynamics environment, say from using another Dynamics 365 application that you are already using, and you want to install the Sales Professional app on that environment, see the steps in the Install the Sales Professional solution on a Dynamics 365 environment section.

To provision a new Dynamics 365 environment

1.	In the Microsoft 365 admin center, select **Admin Centers** > **Dynamics 365**.

    ![Dynamics 365 option under Admin centers](../sales-professional/media/dynamics365-option-in-admin-center-sitemap.png "Dynamics 365 option under Admin centers")

2.	If you have a Dynamics 365 environment already, but are eligible for a new Dynamics 365 environment, you will be taken to the Dynamics 365 admin center showing an environment to configure. Select **Configure**.

    ![Configure option on Dynamics 365 admin center](media/dynamics365-admin-center-with-configure-option.png "Configure option on Dynamics 365 admin center")

    If you do not have any Dynamics environment yet, you will be taken to configure your Dynamics 365 environment automatically.

    ![Configure instance page](media/configure-environment-page.png "Configure instance page")
 
3.	Review the information in **Target version**, **Name**, **Instance type**, **Security Group**, **Language**, and **Currency**. Provide a URL and purpose for the environment. Select **Configure**.
 
    The Dynamics 365 environment will be provisioned and you will be returned to the Dynamics 365 administration center where you can review the environment you just created.

    ![Dynamics 365 Admin center with provisioned environment](media/dynamics365-admin-center-with-provisioned-environment.png "Dynamics 365 Admin center with provisioned environment")


For more details on managing your Dynamics 365 environments, see [Manage Dynamics 365 apps (online)](../admin/manage-online-instances.md) and [Add an environment to your subscription](../admin/add-instance-subscription.md).

## Install the Sales Professional solution on a Dynamics 365 environment

To install the Sales Professional solution on a Dynamics 365 environment

1.	In the Microsoft 365 admin center, select **Admin Centers** > **Dynamics 365**.

    ![Dynamics 365 option under Admin centers](media/dynamics365-option-in-admin-center-sitemap.png "Dynamics 365 option under Admin centers")
    
    The Dynamics 365 Administration Center opens.

2.	On the **Instances** tab, select your Dynamics 365 environment, and on the environment tile, select the**Manage your solutions** ![Icon for Manage your solutions](../admin/media/manage-solution.png "Icon for Manage your solutions") icon.

    ![Production environment on Instances tab](../sales-enterprise/media/production-instance-on-instances-tab.png "Production environment on Instances tab")
 
3.	On the **Manage your solutions** page, select **Dynamics 365 Sales Pro Application**, and on the tile, select **Install**.
    
    You can review the status of the installation by refreshing the Manage your solutions page and reviewing the status column on the page.

    ![Open option on the environment tile](media/open-option-on-environment-tile.png "Open option on the environment tile")

4.	After the installation, return to the environment tile and select **Open**.
                   
    Alternatively, go to Dynamics 365 home. 

5.	In the list of application, select **Sales Professional**. 
 
    ![Sales Professional app tile](media/sales-professional-app-tile.png "Sales Professional app tile")

### See also
[Overview of Dynamics 365 Sales Professional](sales-professional-overview.md)  
[Overview of admin settings](admin-settings-overview.md)  
[User Guide (Dynamics 365 Sales Professional)](user-guide.md)  
