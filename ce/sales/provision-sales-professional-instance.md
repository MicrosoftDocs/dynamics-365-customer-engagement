---
title: Install the Sales Professional app
description: Create a Power Platform environment if you don't already have one and install Dynamics 365 Sales Professional.
ms.date: 09/08/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Install the Sales Professional app

The Sales Professional app provides essential sales force automation for organizations that have straightforward sales processes. With Sales Professional, your sellers can automate common, repetitive, daily tasks and focus on what matters. Before your organization can start using Sales Professional, you need to install the app in a Power Platform environment that has Dynamics 365 apps enabled.

- If you have a Power Platform environment, [install the Sales Professional app](#install-the-sales-professional-app-in-an-existing-environment).
- If you don't have a Power Platform environment already, [create one and install the Sales Professional app](#create-an-environment-for-sales-professional).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Professional<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>You must be a global administrator of your Microsoft 365 org (tenant)<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Install the Sales Professional app in an existing environment

<a name="install-app"></a>

You can install the Sales Professional app in any Power Platform environment that has Dynamics 365 apps enabled. For example, if you already have Dynamics 365 Customer Service, you can install Sales Professional in the same environment.

[Install the Sales Professional app in a Power Platform environment](/power-platform/admin/manage-apps#install-an-app).

After the app is installed, open the environment URL and select the **Sales Professional** app.

> [!IMPORTANT]
> If you see the **Sales Hub** app in your **Published Apps** list, [hide](/power-apps/maker/model-driven-apps/deactivate-app) or [delete](/power-apps/maker/model-driven-apps/delete-model-driven-app) the Sales Hub app as it's only applicable for Sales Enterprise and Sales Premium licenses. Sales Professional users are entitled to use only the Sales Professional app.

## Create an environment for Sales Professional

1. In the Power Platform admin center, [create an environment with a database](/power-platform/admin/create-environment#create-an-environment-with-a-database).

1. After the environment moves to the **Ready** state, [install the Sales Professional app in the environment](/power-platform/admin/manage-apps#install-an-app).
1. After the app is installed, open the environment URL and select the **Sales Professional** app.
> [!IMPORTANT]
> If you see the **Sales Hub** app in your **Published Apps** list, [hide](/power-apps/maker/model-driven-apps/deactivate-app) or [delete](/power-apps/maker/model-driven-apps/delete-model-driven-app) the Sales Hub app as it's only applicable for Sales Enterprise and Sales Premium licenses. Sales Professional users are entitled to use only the Sales Professional app.

### See also

[Overview of Dynamics 365 Sales](overview.md)  
[Overview of admin settings](admin-settings-overview.md)  
[Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
