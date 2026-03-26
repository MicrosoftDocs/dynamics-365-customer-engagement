---
title: Install the Sales Professional app
description: Learn how to install the Sales Professional app in a Power Platform environment that has Dynamics 365 apps enabled.
ms.date: 03/12/2026
ms.topic: install-set-up-deploy
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Install the Sales Professional app

The Sales Professional app is a streamlined version of Dynamics 365 Sales designed for small and medium-sized businesses. It provides essential sales force automation capabilities—such as lead and opportunity management, contact tracking, and sales pipeline visibility—without the complexity of the full Dynamics 365 Sales application.

> [!NOTE]
> The Sales Professional app requires a specific Dynamics 365 Sales license. For licensing details, see the [Dynamics 365 Sales licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).


- If you have a Power Platform environment, [install the Sales Professional app](#install-sales-professional-app-in-an-existing-power-platform-environment) directly.
- If you don't have a Power Platform environment already, [Create a Power Platform environment to deploy the app](#create-a-power-platform-environment-to-deploy-the-app).

## Install Sales Professional app in an existing Power Platform environment

You can install the Sales Professional app in any Power Platform environment that has Dynamics 365 apps enabled. For example, if you already have Dynamics 365 Customer Service, you can install the Sales Professional app in the same environment.

[Install the Sales Professional app in a Power Platform environment](/power-platform/admin/manage-apps#install-an-app).

After the app is installed, open the environment URL and select the **Sales Professional** app.

> [!IMPORTANT]
> If you see the **Sales Hub** app in your **Published Apps** list, [hide](/power-apps/maker/model-driven-apps/deactivate-app) the Sales Hub app as it's only applicable for enterprise licenses.

## Create a Power Platform environment to deploy the app

1. In the Power Platform admin center, [create an environment with a database](/power-platform/admin/create-environment#create-an-environment-with-a-database).

1. After the environment moves to the **Ready** state, [install the Sales Professional app in the environment](/power-platform/admin/manage-apps#install-an-app).
1. After the app is installed, open the environment URL and select the **Sales Professional** app.

> [!IMPORTANT]
> If you see the **Sales Hub** app in your **Published Apps** list, [hide](/power-apps/maker/model-driven-apps/deactivate-app) the Sales Hub app as it's only applicable for enterprise licenses.

## Related information

[Overview of Dynamics 365 Sales](overview.md)  
[Overview of admin settings](admin-settings-overview.md)  
[Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
