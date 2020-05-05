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

Project Service Automation V3, Update Release 19
================================================

We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability. This release is compatible with Dynamics
365 9.x. To update to this release, visit the Admin Center for Dynamics 365
online, solutions page to install the update. For more information, see
[Install, update, or remove a preferred
solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for PSA V3,
Update Release 19. This version has a build number of V3.10.30.41 and is
generally available through a self-update in May 2020.

Update Release 19
-----------------

### Bug fixes

**General**

**Time and Expense**

-   Fixed: Errors derived from time entries imports are not correctly properly
    surfaced.

-   Fixed: Time Entry Grid does not support "Date Only" field behavior.

-   Fixed: Project Resources are unable to create expense with project.

**Project Management**

-   Fixed: Grand Child Task Causes Incorrect Effort Estimate at Completion (EAC)
    Calculation

**Sales**

-   Fixed: Recalculate action does not work with expense contract line details
    or quote line details.

-   Fixed: 'Update Prices' action is missing for expense estimates.

-   Fixed: Customers are unable to select custom contract status reasons from
    the project contract form.

-   Fixed: Customers experience degraded performance when creating a custom
    price list from a quote.

-   Fixed: Customers experience inconsistency in "unit" defaulting on Quote Line
    Details and Contract Line details.

-   Fixed: Adding non-chargeable transaction category items to a chargeable
    contract line will not respect “non-chargeable” billing type of the
    transaction category.

-   Fixed: Customers are unable to use newly added roles and category on
    previously created contracts.

-   Fixed: Customers experience degraded performance Unnecessary retrieve in
    PreValidateProjectTeamMemberUpdate.cs

-   Fixed: Roles setup as non-chargeable in the Resource Categories list should
    be added to the Chargeable Roles tab on a Project Contract line as
    non-chargeable

-   Fixed: Customers may experience degraded performance when created a project
    because GetBookableResourceIdFromUser retrieve all columns of bookable
    resources instead of the primary id.

-   Fixed: TransactionType entity missing pre validation update plugin to
    prevent users. entering invalid Unit and UnitGroup setup for transaction
    types.

-   Fixed: "Remove" step does not work for time entry import.
