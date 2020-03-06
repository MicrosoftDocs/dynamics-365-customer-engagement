---


title: What's new or changed in Project Service Automation Update Release 17, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 17, V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 02/18/2020
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


# Project Service Automation V3, Update Release 17

We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability.  This release is compatible with Dynamics 365 9.x. To update to this release,
visit the Admin Center for Dynamics 365 online, solutions page to install the
update. For more information, see [Install, Update a Preferred Solution](https://docs.microsoft.com/dynamics365/project-service/upgrade-psa-home-page).
This topic lists the features and fixes that are new or changed for PSA V3, Update Release 17. This version has a build number of V3.10.6.34 and is generally available through a self-update in March 2020.


## Update Release 17
**Bug fixes**

-   General

    -   Fixed: Update Project Service Automation to enforce Team Member licenses
        (Project Resource Hub will include Team Member Service plan metadata
        3.x)

-   Time and Expense

    -   Fixed: It is not possible to change an expense estimate from a non-zero
        price to 0. The change is ignored.

-   Project Management

    -   Fixed: A check for null values has been added on a team member's
        position name.

    -   Fixed: msdyn_userresourceid field on msdyn_resourceassignment entity has
        been deprecated.

    -   Fixed: Upgrades from 2.x to 3.x handle empty effort contours on task
        assignments.

-   Sales

    -   Fixed: Invoice.PreValidateInvoiceUpdate now handles reassign records
        owner scenario properly.

    -   Fixed: On QuoteLineDetail QuickCreate validation always ensures when
        transaction class is time, Unitgroup and Unit should always be
        non-editable with values based on TransactionType.
