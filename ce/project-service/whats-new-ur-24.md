---
title: What's new or changed in Project Service Automation Update Release 23, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 23, V3.
author: ruhercul
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 08/25/2020
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

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 23. This version has a build number of V 3.10.34.30 and is generally available through a self-update in August 2020.

## Update Release 24

### Bug fixes

**Sales**
The following issues have been fixed:
- Problem while setting default price list of product
- Performance of Quote win is slow due to the embedded price list and role price records copy
- Project Contract/Sales Hub > Product Line Item/Order Line quantity rounded to the nearest integer automatically
- Elevate to System privileges when reading price lists
- Copy customer Address fields "address1_freighttermscode" and "address1_shippingmethodcode" to Quote/Order 


**Time and Expense**

The following issues have been fixed:
- Time Entry Grid doesn't support Date Only time behavior
- Time Entry not refreshing automatically (require manual refresh)
- Unable to import the time entries from assignment when there is break (0 hours) in resource's assignments
- When creating a time entry set the start to the same as msdyn_date
- Re-enable bulk edit for Time Entry

**Resource Management**

The following issues have been fixed:

- Trying to update the status of an inter-day booking without a requirement will throw a null-ref exception
- Error loading Reconciliation View


**Project Management**

The following issues have been fixed:

- In the Project Schedule when changing from Manual to Auto the auto save is not completing
- Expense costs must not calculate towards variance on the project tracking grid
- Inconsistent behavior for Estimates tag columns during load vs onchange of Time-Phase type
- Actual Cost on project may not reflect totals from Actuals
- Estimated Finish Date in Summary tab does not match with WBS Schedule
- Update Actual Hours on outdent does not work correctly
- Project Manager outside of root BU cannot create Project
- Changes to task or category on Expense Estimates are not persisted
- Copy of contract copies the invoice schedules along with run status
- Refresh Actuals button incorrectly calculates summary tasks
- MS Project Add-in: Fix null reference error if any team member with empty resourcing unit


