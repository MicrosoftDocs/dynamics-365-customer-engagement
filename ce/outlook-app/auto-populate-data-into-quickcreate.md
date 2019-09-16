---
title: "Customize App for Outlook to auto populate data into Quick Create  (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 09/16/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 for Customer Engagement apps
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
# Customize App for Outlook to auto populate data from Outlook item into Quick Create form for Case entity 

Follow these steps to enable a custom entity to appear in Quick create. Note, this example shows addition of custom entity but it can be used to add any entity.

In order to auto populate information from an Outlook item into quick create form for the Case entity, use a new quick create form in App for Outlook.
Using the quick create form, details from the Outlook item are automatically populated making you more productive with App for Outlook.

The fields that will be populated automatically are below.

To get this experience, follow the steps below. 
1.	In Customer Engagement, go to Settings > Customizations > Customize the System.
2.	Expand Entities and choose the Case entity.
3.	Expand the entity and select Forms, then select Form Order and Quick Create Form Set.
4.	Ensure that App for Outlook Case Quick Create form is at the top of the list, for it to be used for quick create scenario.
5.	On the solution page, Publish All Customizations.
6.	Close the solutions page.
