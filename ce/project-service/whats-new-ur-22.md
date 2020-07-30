---

title: What's new or changed in Project Service Automation Update Release 22, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 22, V3. 
author: ruhercul  
manager: kfend 
ms.service: dynamics-365-projectservice 
ms.custom: dyn365-projectservice 
ms.date: 07/28/2020 
ms.topic: article 
ms.prod: 
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

# Project Service Automation Update Release 22, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 22. This version has a build number of V 3.xx.xx.xx and is generally available through a self-update in June 2020.

## Update Release 22

### Bug fixes



**Time and Expense**

The following issues have been fixed:

- **Time entries** are not automatically added in the Time entries schedule after import.
- The **Time Entry** grid date picker does not recognize a user's regional settings.

**Resource Management**

The following issues have been fixed:

- In manual mode, changes to **Resource Assignment** contours are not recognized when generating **Resource Requirements**.
- **Resource Requests** do not support custom request statuses.

**Project Management**

The following issues have been fixed:

- Using double-click on EstimateGridControl will not correctly parse Dutch format numbers.
- Assigned hours do not update correctly when assignments are changed using the Microsoft Project desktop client add-in.
- Project Tracking and Estimates grids display incorrect sales currency code when contract currency is different than customer currency and organization is configured to display currency codes instead of currency symbols.
- A Team member's finish date will add one day if the work hour schedule is 24-hours per day.
- On the Project Schedule, adding a Transaction Category to a task does not trigger auto save.
- The following error is displayed when adding a team member to the Project Template: "Resource requirements cannot be associated with project templates". 
- Ribbon rule script "msdyn.Approval.CanApproveOrReject" displays a timeout error.

**Sales**

The following issues have been fixed:

- Validation error message not displayed when a Cost Price List is selected in Price List lookup on 'New Quote Project Price List' form/entity.
- Closing the quote as won does not navigate to the created contract if a BPF attached to the quote is in the final stage.
- Reversing **Unbilled Sales** is linked to original cost when a time entry is recalled.
- After selecting the **Confirm** button, the invoice status doesn't change to **Confirmed** unless the invoice is refreshed.
