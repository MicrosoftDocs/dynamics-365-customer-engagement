---
title: What's new or changed in Project Service Automation version 3.x wave 1 2020 
description: This topic provides information about what is new and changed in Project Service Automation version 3 wave 1 2020
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom:
  - dyn365-projectservice
ms.date: 1/24/2020
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
The topic highlights key upgrade considerations when moving to the latest release of Oroect Service Automation (PSA) version 3.x wave 1 2020.

## Time Entry
The time entry experience has been extended to now deliver capabilities for extending time entry into more customer scenarios. This includes the capability to add entry types which now drive specific behavior based on the field schema name **Time Entry Settings"**, display name **Time Source**.

### Upgrade consideration
To support this new functionality, the roles within PSA have been updated to include new privledges which grant read access to the new entity, **Time Entry Settings**.

Users who require the ability to log time should now be granted the user role **Time Entry User** in addition to existing roles, as this role includes these changes and ensures that time entry will continue to work.

### Currently extended Time Entry changes
Our goal was to minimize the impact to current users of time entry, the role change is the only core requirement necessary to continue utlizing Time entry. If you have created completely custom views or completely seperate time entry experiences however, you must set the **Time Entry Setting** fields to the correct PSA value.
