---

title: What's new or changed in Project Service Automation Update Release 18, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 18, V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 04/27/2020
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

# Project Service Automation Update Release 18, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online, solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 18. This version has a build number of V3.10.8.12 and is generally available through a self-update in April 2020.

## Update Release 18

### Bug fixes

**Time and Expense**

- Fixed: **Recall**, **Request**, and **Cancel Approval** flows throw exceptions with unclear error messages.
- Fixed: When **Cancel Approval** fails for an expense, a relevant exception error is not thrown.
- Fixed: The Time Entry grid incorrectly handles non-working days in Australia after the daylight savings time (DST) switch in October.
- Fixed: Incorrect defaulting logic prevents submission of expenses.
- Fixed: When time entry approval fails, the approval remains in a state of **Pending**.
- Fixed: SQL Errors on bulk approvals (deadlock/timeout).
- Fixed: Significant performance issues in the user experience caused by updating team members while approving time entries.

**Project Management**

- Fixed: Time zone notification moved from the **Reconciliation** view to the **Project** main form.
- Fixed: Calendar template is not correctly defaulting when a new project form opens.
- Fixed: For chromium-based browsers, users are unable to easily select predecessor tasks to delete.
- Fixed: Creating or copying **Project from Empty template** fetches unrelated assignments.
- Fixed: In specific edge cases, creating a new assignment from the task grid results in duplicate records being created.
- Fixed: In manual mode, users are unable to update task start dates to be later than the current date saved.

**Resource Management**

- Fixed: **Reconciliation** view subtotal row incorrectly calculates bookings variance after extending bookings.
- Fixed: **Reconciliation** view incorrectly displays resource assignments when the bookable resource has a calendar that does not match the project calendar.

**Sales**

- Fixed: When time entries are re-approved (**Approve > Cancel >** approve again), a duplicate non-chargeable actual is created.
