---
title: "Customize App for Outlook to auto populate data to the Quick Create form  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 09/16/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Customize App for Outlook to auto populate data from an Outlook item to a Quick Create form for the Case entity 

Use the quick create form in App for Outlook to auto populate information from an Outlook item  to the quick create form for the Case entity. 

These fields that will be populated automatically:

|                                                                                                |                                                                                              |                                                                                      |
|------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------|
|                                          **Outlook item field**                                           |  | **Quick Create Case form field** |
|                             Currently selected contact's account (if known)                                |                                             Mapped to ->                                              |                                         Customer                                          |
|                            Email/appointment subject                            |                                              Mapped to ->                                              |                                         Case Title                                          |
|                              Currently selected contact (if known)                              |                                             Mapped to ->                                              |                                         Contact                                          |
|                              Email                                |                                               Mapped to ->                                               |                                         Origin                                          |
|                                   Email/appointment body                                     |                                              Mapped to ->                                              |                                          Description                                        |




To turn this feature on, do the following: 

1.	In your Dynamics 365 apps, go to **Settings** > **Customizations** > **Customize the System**.
2.	Expand **Entities** and then select the **Case** entity.
3.	Expand the entity and select **Forms**, then select **Form Order** and  **Quick Create Form Set**.
4.	Ensure that **App for Outlook Case Quick Create form** is at the top of the list, for it to be used for quick create scenario.
5.	On the solution page, select **Publish All Customizations** and then close the page.

