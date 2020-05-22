---
title: What's new or changed in Project Service Automation version 3.x wave 1 2020 
description: This topic provides information about what is new and changed in Project Service Automation version 3 wave 1 2020.
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom:
  - dyn365-projectservice
ms.date: 05/15/2020
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Dynamics 365 Project Service Automation 3.x wave 1 2020 
author: stsporen
ms.author: stsporen
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  
---


# What's new or changed in Project Service Automation version 3 wave 1 2020
The topic highlights key upgrade considerations when moving to the latest release of Project Service Automation (PSA) version 3.x wave 1 2020.

## Time entry
The time entry experience has been extended to deliver capabilities for extending time entry into more customer scenarios. This includes the capability to add entry types, which now drive specific behavior based on the field schema name **Time Entry Settings**, displayed as **Time Source**. A new solution, called Time, Expense, Statusing, and Approvals (TESA) has been added to support this functionality.

### Upgrade consideration
To support this functionality, the roles within PSA have been updated to include new privileges. These privileges grant read access to the new entity, **Time Entry Settings**.

Users who require the ability to log time should be granted the user role **Time Entry User** in addition to existing roles. This role includes the new functionality and ensures that time entry will continue to work.

Additionally, if you have any custom app modules that include all forms for the time entry entity, you will be required to remove the **TESA time Entry Quick Create Form** from the module.

### Currently extended time entry changes
To minimize the impact to current users of time entry, this role change is the only core requirement necessary to continue utilizing time entry. If you have created custom views or separate time entry experiences, you must set the **Time Entry Setting** fields to the correct PSA value.
