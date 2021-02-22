---
title: "Customize commands and the ribbon (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Dynamics 365 Customer Engagement displays commands in different ways depending on the entity and the client. In most places in the web application you will see a command bar instead of a ribbon. Dynamics 365 for tablets also uses data defined as ribbons to control what commands are available using a command bar that is optimized for touch. "
ms.custom: 
ms.date: 09/25/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - ribbon
  - customize, ribbon
ms.assetid: c688a24a-ef2d-4c0b-951b-e6db22382686
caps.latest.revision: 38
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Customize commands and the ribbon

[!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] displays commands in different ways depending on the entity and the client. In most places in the web application you will see a *command bar* instead of a ribbon. [!INCLUDE[pn_moca_short](../../includes/pn-moca-short.md)] also uses data defined as ribbons to control what commands are available using a command bar that is optimized for touch.  
  
 The command bar provides better performance. The ribbon is still displayed in the web application for certain entity forms and it is still used for list views in [!INCLUDE[pn_crm_2016_outlook](../../includes/pn-crm-2016-outlook.md)].  
  
 Both the command bar and the ribbon use the same underlying XML data to define what commands to display, when the commands are enabled, and what the commands do.  
  
 The topics in this section introduce you to key concepts that you must understand, and common tasks you perform when you customize the command bar or the ribbon.  
  
> [!NOTE]
>  Because the underlying XML schema was designed to display commands as ribbons, the term *ribbon* will continue to be used in the documentation.  
  
 The SDK describes the process of editing the ribbon by editing the customization.xml file directly. The most frequently used tool created by the community is the [Ribbon Workbench](https://www.develop1.net/public/rwb/ribbonworkbench.aspx) 
 
To obtain support or help to use this program, contact the program publisher.  
  
  
## See also  
 [Ribbon Core Schema](ribbon-core-schema.md)  
  
 [Ribbon Types Schema](ribbon-types-schema.md)  
  
 [Ribbon WSS Schema](ribbon-wss-schema.md) 

 [Sample: Export Ribbon Definitions](sample-export-ribbon-definitions.md) 
  
 [Client scripting using JavaScript](../clientapi/client-scripting.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]