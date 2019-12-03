---
title: "Upgrade Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/3/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Upgrade Field Service

auto update motion 
how it works, whats the cadence, 
same or different from platform
lack of disruption

For FS v8, our plan is that orgs on v8 UR13 (FS v8.8.7.47) or higher will begin receiving automatic updates, correct? Can we add a note to the FS documentation about auto-update?

https://aka.ms/fsuciupgrade

Advise customers about the FS upgrade cadence and difference between FS updates and Core updates. Also to provide steps to check for available upgrades for FS as a first step.

- All new Dynamics 365 Field Service environments will install the latest generally available Field Service solution. If you would like to set up a trial of the latest Field Service version, create a trial through [https://trials.dynamics.com](https://trials.dynamics.com).

Customize against forms for opp, quote, etc require a specific updated in a web resource so they can work correctly.


Error : 500: : An error occurred while processing this request. (on requirement save)


 - For existing environments, when a new upgrade is available, you can upgrade your solution in **Admin Center** > **Dynamics 365**, as seen in the following screenshot.
> [!div class="mx-imgBorder"]
> ![Screenshot of the admin center upgrade path for Field Service](./media/admin-upgrade-to-latest-admin-center.png)


## Mobile

Installing Field Service Mobile from the Windows Store can allow for automatic upgrades of new versions.

## Resource Scheduling


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-rs-health-diagnostics.png)

## Resource scheduling Optimization



## Prerequisites
> [!Note]
>



## Configuration considerations
## Additional Notes

- Field Service upgrade failure/DB out of sync and resolution steps that the customer can try on their own.
- Solution installation failed / Update Installation Failed
- Field Service database version is out of sync


### See also
[Field Service version history](version-history.md)

[Important Notes for Field Service and Project Service Automation after upgrade of Dynamics 365 Organizations to version 9.0](https://community.dynamics.com/365/b/365teamblog/posts/important-notes-for-field-service-and-project-service-automation-after-upgrade-of-dynamics-365-organizations-to-version-9-0)