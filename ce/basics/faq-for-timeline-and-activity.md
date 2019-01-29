---
title: "Frequently Asked Questions about activities and timeline wall (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 01/28/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: b72fe4a3-30b8-4dc4-9b93-e87e5cdb7ef0
caps.latest.revision: 39
author: mkaur
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Frequently Asked Questions about Activities and Timeline Wall  

## Is a title required when adding a new note?

No. When adding a note to an activity, the title field is marked as a mandatory field but is not required. This is a known issue in the legacy Web Client.

## For an appointment, when I choose the option to *Save as Draft* it doesn't show that the appointment has been saved as a draft.

When you save an appointment in the legacy Web Client as a draft the title does not display **[DRAFT]** to indicate that the appointment has been saved as a draft.

## Can I add activities to read only records?

Yes. You can add activities to entities that are read only such as, notes, phone calls, tasks, and more. 

## Are HTML tags supported in **Notes**?

No. When creating a note activity for any record or entity, HTML tags are not supported. For example, if you add <TAG> </TAG> to a note field it will be displayed as <TAG_XXX="XX"> </TAG>.

## How can I improve performance on timeline wall?

Timeline Wall performance can be improved by optimizing how much data is returned by a specific entity record. 

1.	Configure entity forms to only show activities that are in use.  This can be done at the form level to only show useful activities.  For example, if you don’t use tasks for cases you can configure the timeline wall on the case form to not show tasks.
2.	Reduce the number of default records that are shown by the timeline wall.  By default, it is set to return 10, beyond 10 it can cause performance issues.  It is recommended to not exceed the default. 

## Activity Wall is not supported in Print Preview.

When you select the **Print Preview** option in Dynamics 365 the **Timeline Wall** will not show in the available list. You will see **Notes** but it will not show tasks or emails.





