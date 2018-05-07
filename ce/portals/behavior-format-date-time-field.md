---
title: "Behavior and format of the date and time field in Dynamics 365 | MicrosoftDocs"
description: "Behavior and format of the date and time fields that are used in a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: CF6AA85B-9191-4249-A2DD-2FB5A8B0C410
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Behavior and format of the date and time field

In Microsoft [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], the Date and Time data type is used in many system entity fields. For example, you can show when an account was last used in a marketing campaign, or show the date and time when a case was escalated. You can also create custom entities that include the date and time fields. Depending on what the field represents, you can choose one of the following field behaviors for portal forms and grids: 
- **User Local**: The field values are displayed in the user’s local time and formatted as per their current portal language/locale. The values are stored in UTC time zone format in Dynamics 365. When a user in Dynamics 365 (or another portal user) in a different time zone views that value, they see it converted to their own time zone.
- **Date Only**: The field values only contain the date and are displayed with no time zone conversion. The time portion of the value is always 12:00 AM. The value entered by one user is seen the same by other users in different time zones (for example, birth dates).
  
  > [!Note]
  > The behavior of this field can’t be changed after it’s saved.
  
- **Time-Zone Independent**: The field values contain date and time, and are displayed with no time zone conversion. The value entered by one user is seen the same by other users in different time zones.
  
  > [!Note]
  > The behavior of this field can’t be changed after it’s saved.

You can also override the default date/time format to be used on portals by creating the following site settings:
- DateTime/DateFormat: The date format used on the portal. 
- DateTime/TimeFormat: The time format used on the portal. 
- DateTime/DateTimeFormat: The format for full date and time used on the portal.

By default, the portal uses the standard date/time formats specified by the website language settings.
The accepted date/time formats are specified [here](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings).
