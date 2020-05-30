---

title: What's new or changed in Project Service Automation Update Release 15, V3
description: This topic provides information about what's new in Project Service Automation Update Release 15, V3.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 01/27/2020
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


# Project Service Automation Update Release 15, V3

We’re pleased to announce the latest update for the Dynamics 365 Project Service Automation (PSA) application. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online, and go to the solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for PSA V3, Update Release 15. This version has a build number of V3.10.5.28 and is generally available through a self-update in January 2020.

## Update Release 15 

### Enhancements

- Project Management

### Bug fixes

- Time and Expense

  - Fixed: Add on-load error handling in the reconciliation view.
  - Fixed: Project Resource Hub: Rename **Amount** to reduce ambiguity.
  - Fixed: Adjust the view **Copy Time Entry Columns** to include the type.
  - Fixed: Editing time entry duration in the grid view using decimal numbers results in unknown error for some numbers.

- Project Management

  - Fixed: The drop-down menu for **Use in Tracking View** now expands based on the width of the options.
  - Fixed: When managing projects in the +13 time zone, tasks calculations can display inaccurate results.
  - Fixed: **Team Member End Time** has been corrected when using a 24-hour calendar.
  - Fixed: Re-activated the **BPF** in **msdyn_project** main form.
  - Fixed: Assignments calculation no longer ignores one day.
  - Fixed: A new notification banner has been added to the project form when the time zone differs between user and project.

- Sales

  - Fixed: Expense estimate category lookup can be used to filter duplicates.
  - Fixed: Code in **PluginDomain.ExecuteInTryCatchBlock(..)** no longer hides the origin of the exception.
  - Fixed: No longer get an error message in **Project lookup** in the **Quote Line** form when there are more than 1000 projects.
  - Fixed: **Estimates** grid for labor estimates and expense estimates now displays the correct currency symbol.
  - Fixed: After an organization updates PSA from Update Release 14 to Update Release 15, the **Schedule** tab no longer appears as blank on the **Project** form.
