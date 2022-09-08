---
title: Install the Sales Professional app
description: Create a Power Platform environment if you don't already have one and install Dynamics 365 Sales Professional.
ms.date: 09/08/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
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

## Create an environment for Sales Professional

1. In the Power Platform admin center, [create an environment with a database](/power-platform/admin/create-environment#create-an-environment-with-a-database).

1. After the environment moves to the **Ready** state, open the environment URL.

1. [Install the Sales Professional app in the environment](/power-platform/admin/manage-apps#install-an-app).
<!--NOTE: It seems odd to me that the article that covers how to install a Dynamics 365 app in an environment doesn't include how to get it from the App Store if it isn't in the list of apps available to install. Is this an oversight?-->

> [!IMPORTANT]
> [Hide the **Sales Hub** app](/power-apps/maker/model-driven-apps/deactivate-app) if you have it. Only Sales Enterprise and Sales Premium customers may use Sales Hub. Sales Professional customers are entitled to use only the Sales Professional app.

### See also

[Overview of Dynamics 365 Sales](overview.md)  
[Overview of admin settings](admin-settings-overview.md)  
[Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
