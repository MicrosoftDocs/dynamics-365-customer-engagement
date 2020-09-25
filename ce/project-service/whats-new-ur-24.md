---
title: What's new or changed in Project Service Automation Update Release 24, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 24, V3.
author: ruhercul
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 09/25/2020
ms.topic: article
ms.prod: 
ms.technology: Microsoft Dynamics 365 Project Service Automation 3.x
ms.author: stsporen
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  - ProjectOperations
---

# Project Service Automation Update Release 24, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 24. This version has a build number of V 3.10.42.19 and is generally available through a self-update in October 2020.

## Update Release 24

### Bug fixes

**Sales**
The following issues have been fixed:

- Problem while setting default price list of product.
- Performance of Quote win is slow due to the embedded price list and role price records copy.
- **Project Contract/Sales Hub** > **Product Line Item/Order Line Quantity** is automatically rounded to the nearest integer.
- Elevate to System privileges when reading price lists
- Copy customer address fields, **address1_freighttermscode** and **address1_shippingmethodcode** to Quote/Order. 


**Time and Expense**

The following issues have been fixed:

- The **Time Entry Grid** doesn't support **Date Only** time behavior
- **Time Entry** is not refreshing automatically. A manual refresh is required.
- Unable to import the time entries from an assignment when there is a break (0 hours) in a resource's assignments.
- When creating a time entry, set the start to the same as **msdyn_date**.
- Re-enable bulk edit for time entry.

**Resource Management**

The following issues have been fixed:

- Trying to update the status of an inter-day booking without a requirement will throw a null-ref exception.
- Error loading the **Reconciliation View**.


**Project Management**

The following issues have been fixed:

- In the **Project Schedule**, when changing from **Manual** to **Auto**, the auto save is not completing.
- Expense costs must not calculate towards variance on the **Project Tracking Grid**.
- Inconsistent behavior for **Estimates tag** columns during load vs on change of the **Time-Phase** type.
- The actual cost on project may not reflect the totals from **Actuals**.
- **Estimated Finish Date** on the **Summary** tab does not match the **WBS Schedule**.
- **Update Actual Hours** on outdent does not work correctly.
- Project manager outside of root **BU** can't create a project.
- Changes to task or category on **Expense Estimates** are not persisted.
- **Copy of contract** copies the invoice schedules and the run status.
- **Refresh Actuals** button incorrectly calculates summary tasks.
- Microsoft Project Add-in: Fix null reference error if any team member with empty resourcing unit.


