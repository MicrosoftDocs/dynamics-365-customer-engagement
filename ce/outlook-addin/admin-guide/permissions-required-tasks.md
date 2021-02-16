---
title: "Permissions required for Dynamics 365 for Outlook tasks | MicrosoftDocs"
ms.custom: 
ms.date: 08/28/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 871df72e-d9b4-4bff-89e2-6a3fc96f3be3
caps.latest.revision: 9
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
# Permissions required for Dynamics 365 for Outlook tasks
The following table shows the default security roles required to perform [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] tasks, and whether the task can be performed while using [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] offline.  


|[!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] Tasks|Default Security Roles and Required Privileges| Can Task Be Done Offline? |
|--|--|--|
|Go Offline|Security roles:   Any<br /><br /> Privileges: <br /> Go Offline <br /> Read Saved View  |Yes|
|Set synchronization options [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] to [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]|Security roles:  Any<br /><br /> Privileges:<br />  Sync to [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]<br /> Read Saved View |Yes|
|Set local data synchronization options|Security roles:  Any<br /><br /> Privileges:  Go Offline  |Yes|
|Synchronize [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] to [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]|Security roles:  Any<br /><br /> Privileges:  Sync to [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]|Yes|
| Save and link [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] tasks and appointments in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] |Security roles:  Any<br /><br /> Privileges:  For the record type: Write, Append To|Yes|
|Save and link [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] contacts in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]|Security roles:  Any<br /><br /> Privileges:  Contact record type: Write, Append To|Yes|
|Remove tracking in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] from a record| Security roles:  Any<br /><br /> Privileges:  Contact record type: Write, Append To<br /><br /> For the record type: Write, Append To |Yes|


[!INCLUDE[footer-include](../../includes/footer-banner.md)]