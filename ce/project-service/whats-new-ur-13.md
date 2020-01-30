---


title: What's new in Project Service Automation Update Release 13, V3
description: This topic provides information about what's new in Project Service Automation Update Release 13, V3.
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


# Project Service Automation V3, Update Release 13
We’re pleased to announce the latest update for the Dynamics 365 Project Service Automation (PSA) application. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online, and go to the solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 13. This version has a build number of V3.10.3.18 and is available on the following schedule:

- **General availability (self-update):** November 2019
- **Auto-update:** December 2019


## Update Release 13 

### Bug fixes

- Time and Expense

     - Fixed: Search functionality on the expense **Approval** page does not work when searching by expense purpose.

- Resource Management

     - Fixed: Numbers in the reconciliation have been updated to be right justified.
     - Fixed: Named Resources cannot be assigned to tasks through the Schedule tab.

- Project Management

     - Fixed: Null reference exception when assigning team member when TransactionType missing setup for Unit and DefaultGroup.

- Sales

     - Fixed: Duplicate Transaction Type records leads to non-graceful failure during creation of Role Price records.
     - Fixed: Extra buttons(New Opportunity/Quote/Order Line, Add Product) are visible in more commands for Opportunity/Quote/Order Product and project-based Lines Sub Grid.


