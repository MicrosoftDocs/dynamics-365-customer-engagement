---


title: What's new in Project Service Automation Update Release 15, V3
description: We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability.

This release is compatible with Dynamics 365 9.x. To update to this release,
visit the Admin Center for Dynamics 365 online, solutions page to install the
update. For details, refer How to Install, Update a Preferred Solution
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


# Project Service Automation V3, Update Release 15

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 15 This version has a build number of V3.10.5.28 and is available on the following schedule:

- **General availability (self-update):** January 2020



### Update Release 15 bug fixes
-   **Enhancements**

    -   Project Management

        -   Fixed: A new notification banner has been added to the project form
            when the time zone differs between user and project.

-   **Bug fixes**

    -   Time and Expense

        -   Fixed: Add on-load error handling in the reconciliation view.

        -   Fixed: Project Resource Hub: Rename "Amount" to reduce ambiguity

        -   Fixed: Adjust the view "Copy Time Entry Columns" to include the
            type.

        -   Fixed: Editing time entry duration in the grid view using decimal
            numbers results in unknown error for some numbers.

    -   Project Management

        -   Fixed: The dropdown for Use in tracking View does not expand based
            on the width of the options.

        -   Fixed: +13 time zone project tasks shifts when created

        -   Fixed: Team Member End Time incorrect when using 24hr Calendar

        -   Fixed: Re-activate the BPF in msdyn_project main form

        -   Fixed: Assignments calculation is ignoring one day

    -   Sales

        -   Fixed: Expense estimate category lookup does not filter duplicates

        -   Fixed: Code inside PluginDomain.ExecuteInTryCatchBlock(..) hides
            origin of the exception.

        -   Fixed: Error when getting an error message in Project lookup in
            Quote Line form when more than 1000 Projects

        -   Fixed: Estimates grid for labor estimates and expense estimates does
            not show the correct currency symbol

        -   Fixed: [Org where PS upgraded from UR14 to UR15] - "Schedule" tab
            showing as blank on Project form



