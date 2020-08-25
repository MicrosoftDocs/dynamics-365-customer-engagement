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
ms.author: ruhercul
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

# Project Service Automation Update Release 23, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 23. This version has a build number of V 3.10.34.25 and is generally available through a self-update in August 2020.

## Update Release 23

### Bug fixes

**Time and Expense**

The following issues have been fixed:
- Handle edge case in **Project Team Member Delete** to provide a meaningful exception.
- Assignment import results in a blank remove screen.

**Resource Management**

The following issues have been fixed:

- The **Resource utilization grid resource card** shows incorrect data when the time scale is more than five days.
- When customers create a bookable resource, the plug-in intermittently fails to automatically add the resource to a Microsoft Office 365 group.
- **Reconciliation** view displays manual contours incorrectly in the **Week** or **Month** view.

**Project Management**

The following issues have been fixed:

- An excessive number of **RetrieveMultiple for usersettings** entities are causing degraded performance for project approvals and other operations.
- The **Task Planning** grid resource lookup is limited to only show up to five team members from the project team. 
- The **Task Planning** grid resource lookup does not filter inactive resources.
- Manual mode is not working as expected in the project planning work breakdown structure.
- The **Task Planning** grid shows **Inactive Transaction Categories**.
- The **Resource Assignment** grid rounds incorrectly when a task has multiple assignments.
- Rounding values are different between planned cost and actual cost for a single task.

**Sales**

The following issues have been fixed:

- **Fetch All Transaction Categories** double-click creates multiple lines.
