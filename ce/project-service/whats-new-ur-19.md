---

title: What's new or changed in Project Service Automation Update Release 19, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 19, V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 05/05/2020
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

# Project Service Automation V3, Update Release 19

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for PSA V3, Update Release 19. This version has a build number of V3.10.30.41 and is generally available through a self-update in May 2020.

## Update Release 19

### Bug fixes

**Time and Expense**

The following issues have been fixed: 

- Errors derived from time entry imports are not surfaced correctly.
- Time Entry Grid does not support **Date Only** field behavior.
- Project Resources are unable to create an expense with a project.

**Project Management**

The following issues have been fixed: 

-  Grandchild task causes an incorrect effort estimate during the Completion (EAC) Calculation.

**Sales**

The following issues have been fixed: 

- The **Recalculate** action does not work with expense contract line details or quote line details.
- **Update Prices** is missing for expense estimates.
-  Customers are unable to select custom contract status reasons from the **Project Contract** page.
- Customers experience degraded performance when creating a custom price list from a quote.
- Customers experience inconsistency with **unit** defaults on **Quote Line Details** and **Contract Line Details** pages.
- Adding non-chargeable transaction category items to a chargeable contract line will not respect the **Non-chargeable** billing type of the transaction category.
- Customers can't use the newly added roles and category on previously created contracts.
- Customers experience degraded performance Unnecessary retrieve in PreValidateProjectTeamMemberUpdate.cs
- Roles set up as non-chargeable in the **Resource Categories** list should be added to the **Chargeable Roles** tab as **Non0chargeable** on the contract line for a project.
- Customers may experience degraded performance when creating a project because **GetBookableResourceIdFromUser** retrieves all columns of bookable resources instead of just the primary ID.
- **TransactionType** entity missing the pre-validation update plug-in to prevent users from entering **Units** and **UnitGroups** that are not valid for transaction types.
- The **Remove** step does not work for time entry import.
