---


title: What's new in Project Service Automation Update Release 12, V3
description: This topic provides information about what's new in Project Service Automation Update Release 12, V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 01/30/2020
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 Project Service Automation 3.x
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---


# Project Service Automation V3, Update Release 12
We’re pleased to announce the latest update for the Dynamics 365 Project Service Automation (PSA) application. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online, and go to the solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).


This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 12. This version has a build number of V3.10.2.34 and is generally available through a self-update in October, 2019.


## Update Release 12

### Bug fixes

- Time and Expense

     - Fixed: Search functionality on the expense **Approval** page does not work when searching by expense purpose.

- Resource Management

     - Fixed: Numbers in the reconciliation have been updated to be right justified.
     - Fixed: Named resources can't be assigned to tasks using the **Schedule** tab.

- Project Management

     - Fixed: Null reference exception when assigning a team member and the **TransactionType** is missing the setup for **Unit** and **DefaultGroup**.

- Sales

     - Fixed: Duplicate transaction type records leads to non-graceful failure when **Role Price** records are created.
     - Fixed: Additional buttons, **New Opportunity**, **Quote**, **Order Line**, and **Add Product** are visible in more commands for Opportunities, Quots, Orders, Products, and the project-based lines sub-grid.


