---
title: Project service version history
ms.custom: dyn365-projectservice
ms.date: 04/28/2020
ms.reviewer: kfend
ms.service: dynamics-365-projectservice
ms.suite: ""
ms.technology:
  - "project-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to:
  - "Dynamics 365 Project Service"
author: kfend
ms.assetid: 
caps.latest.revision: 42
ms.author: rumant
manager: annbe
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365PS
---

# Project service version history

## Latest version availability

| Solution  | Latest version |
|-------|----|
| Project Service Automation    |  Update release 18, Version 3  |
| Project Service Automation desktop add-in                | 3.15          |

For information about other updates to Project Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

|  | Region | Current Version | Next Version |  Scheduled Date
| :---   | :---   | :---   | :---   |:---   |         
|<strong>Station 1</strong> | |  |  | |
| | <i>First Release</i> |[V3.10.8.12](whats-new-ur-18.md)| TBD | 05/01/20
|<strong>Station 2</strong> | |  |  | |
| | <i>South America</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  TBD | 05/01/20
| | <i>Canada</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| TBD | 05/01/20 
| | <i>India</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| TBD | 05/01/20
| | <i>France</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  TBD | 05/01/20
| | <i>United Arab Emirates</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  TBD | 05/01/20
| | <i>South Africa</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  TBD | 05/01/20
| | <i>Germany</i> |[8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| TBD | 05/01/20
|<strong>Station 3</strong> | |  |  | |
| | <i>Japan</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)| [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/01/2020 
| | <i>Asia Pacific</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  05/01/2020
| | <i>Great Britain</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  05/01/2020
| | <i>Oceana</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)|  05/01/2020
|<strong>Station 4</strong> | |  |  | |
| | <i>Europe</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/08/2020
|<strong>Station 5</strong> | |  |  | |
| | <i>North America</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/15/2020
|<strong>Station 6</strong> | |  |  | |
| | <i>Goverment Community Cloud</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)|  [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/22/2020
| | <i>China</i> |[8.8.11.19](https://docs.microsoft.com/dynamics365/field-service/version-history#881119)| [8.8.12.2](https://docs.microsoft.com/dynamics365/field-service/version-history#88122)| 05/22/2020


## Project Service Automation Update Release 18, V3

### Fixes

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

## Project Service Automation Update Release 17.5, V3
### Fixes 

**Project Management**

- Fixed: Addressed server-side synchronization issues that occur with long duration tasks.
- Fixed: Addressed 24-hour work hour templates inaccurately adding an additional day to tasks.
- Fixed: Addressed +13 GMT work hour templates inaccurately shifting tasks one day ahead.
