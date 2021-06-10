---
title: "Define ribbon commands (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "A Ribbon command creates a reusable definition that can be referenced by ribbon control elements."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - ribbon, commands
ms.assetid: 7c6c4d14-428d-4b96-9fe3-5260c3a6ae36
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Define ribbon commands

A *Ribbon* command creates a reusable definition that can be referenced by ribbon control elements.  
  
## Ribbon command elements  
 The `<CommandDefinition>` element defines a command in the ribbon. The `Id` attribute specifies a unique identifier for the command that can be referenced by ribbon control elements by using the `Command` parameter.  
  
 A ribbon command defines three things:  
  
- **Enable Rules**: Specifies when a specific ribbon control is enabled.  
  
- **Display Rules**: Specifies when a specific ribbon element is visible.  
  
- **Actions**: Specifies what code executes when a ribbon control is used.  
  
> [!IMPORTANT]
>  All command definitions are downloaded to a user's computer so that they can be evaluated at run time. This means that a user without the privileges to see a particular control in the ribbon can use the browser **View Source** command, review the code, and determine that a control exists that isn’t displayed to them in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Use Localized Labels with Ribbons](use-localized-labels-ribbons.md)   
 [Define Ribbon Enable Rules](define-ribbon-enable-rules.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]