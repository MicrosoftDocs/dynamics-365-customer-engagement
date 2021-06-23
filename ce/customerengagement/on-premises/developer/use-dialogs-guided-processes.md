---
title: "Use dialogs for guided processes (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Dialogs are the synchronous or interactive processes in Dynamics 365 Customer Engagement (on-premises) Customer Engagement that collect and process information by using step-by-step scripts to direct users through a process"
ms.custom: 
ms.date: 05/24/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - workflow, dialog
ms.assetid: d17f8ae2-854b-4f67-a115-5a03d4f0b8ce
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Use dialogs for guided processes

Dialogs are the synchronous or interactive processes in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] that collect and process information by using step-by-step scripts to direct users through a process. For example, you can create dialogs to act as a guide for your service representatives for case resolution and case escalation. Similarly, you can create dialogs for standardizing sales processes such as opportunity qualification and lead scoring.

> [!IMPORTANT]
> [Dialogs are deprecated](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming#dialogs-are-deprecated), and should be replaced by business process flows or canvas apps in Power Apps. More information: [Replace dialogs with business process flows or canvas apps](/flow/replace-dialogs).
  
 Every time that you run a dialog in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], a `ProcessSession` record is created. The process session stores the session log about the dialog process that was run.  
  
> [!NOTE]
>  Due to the interactive nature of the dialog process, you can’t run a dialog using the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)]. A dialog can only be run through the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application. Dialogs aren’t supported in [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
### See also  
 [Processes, Workflows, and Dialogs](process-categories.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]