---
title: Customer Service Team Member app | Microsoft Docs
description: Customer Service Team Member app
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---
## Preview: Customer Service Team Member app

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

With the entry-level Team Member license, you can now address self-service support scenarios using a Dynamics 365 Customer Service app.

The Customer Service Team Member app is a new  module that will be available to you with the Dynamics 365 Team Member license.

### Install Customer Service Team Member app

The Customer Service Team Member app must be manually installed in your instance and the **Customer Service Team Member** role assigned to the users before they can access it.

1. Sign in to Dynamics 365 Administration Center as an administrator, and select **Manage Solutions**. The **Manage your Dynamics 365 instances** page appears.
2. Select the instance in which you want to install the Team Member app, and select the edit icon beside **Solutions**. The **Manage your solutions** page appears.
3. Select **Customer Service Team Member Anchor**, and select **INSTALL**. The solution is installed and the **STATUS** column in the table displays "Installed".
4. Enable the **Customer Service Team Member** role for the app. To learn about enabling the role, see [Manage access to apps by using security roles](/on-premises/customize/manage-access-apps-security-roles).

### Using Customer Service Team Member app

In the Customer Service Team Member app, you can perform the following tasks:

- Create cases. To learn more, see [Create a case](customer-service-hub-user-guide-case-sla.md)
- Read and update the cases that you created
- Search and view knowledge articles. To learn more, see [Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md)