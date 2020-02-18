---


title: What's new in Project Service Automation Update Release 16, V3
description: This topic lists the features and fixes that are available in release 16 of Project Service Automation V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 01/23/2020
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


# Project Service Automation V3, Update Release 16
We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability.

This release is compatible with Dynamics 365 9.x. To update to this release,
visit the Admin Center for Dynamics 365 online, solutions page to install the
update. For details, refer How to Install, Update a Preferred Solution

**Bug fixes**

-   Time and Expense

    -   Fixed: Users attempting to submit deleted time and expense entries for
        approvals will receive contextually relevant error messages.

-   Project Management

    -   Fixed: The resourcing units defined for team members in templates are
        respected with the templates are applied to a new project.

    -   Fixed: Improved handling of the re-assignment of record ownership.

    -   Fixed: Projects in the progress of being copied will not be permitted to
        copied until all copy operations are complete.

-   Resource Management

    -   Fixed: Extend Bookings now handle small durations correctly and does not
        create zero hours of extended bookings.

    -   Fixed: Reconciliation view now renders when the project timezone is
        +5:30 GMT and the user’s timezone is different.

-   Sales

    -   Fixed: Whenever a project mapped to a contract line is removed and new project is mapped, the actual records on the newly project were not getting re-evaluated based on the billing and pricing rules defined on the contract line. This has been fixed in this release. Pricing and actual records on the newly mapped project will get reversed and re-created correctly based on the pricing and billing rules of the contract line. The actual records of the un-mapped project will also get re-evaluated and re-created as a consequence. 

    -   Fixed: Additional validation has been added to an estimate line’s
        "amount" field to ensure null values are not persisted.

    -   Fixed: [PSA 3.x] When actuals have been updated on a project, a new
        refresh button has been added to the project main form to allow users to
        re-sync the actuals.

    -   Fixed: When users upgrade from 2.X to 3.X, projects with a NULL value
        for project name will be permitted.

Project Service Automation Team
