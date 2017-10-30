---
title: "Plug-in development (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn more about how to develop plug-ins that can integrate with Dynamics 365 Customer Engagement to modify or augment the standard behavior of the platform. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aa037f4a-b5ae-485c-aac9-8a138a57c576
caps.latest.revision: 30
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Plug-in development
A plug-in is custom business logic (code) that you can integrate with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement to modify or augment the standard behavior of the platform. Another way to think about plug-ins is that they are handlers for events fired by [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. You can subscribe, or register, a plug-in to a known set of events to have your code run when the event occurs.  
  
 For more information about plug-in run-time execution, see [Event Execution Pipeline](event-execution-pipeline.md).  
  
## In This Section  
 [Write a Plug-in](write-plugin.md)  
  
 [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md)  
  
 [Handle Exceptions in Plug-ins](handle-exceptions-plugins.md)  
  
 [Passing Data Between Plug-ins](pass-data-between-plug-ins.md)  
  
 [Impersonation in Plug-ins](impersonation-plugins.md)  
  
 [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
 [Debug a Plug-in](debug-plugin.md)  
  
 [Analyze Plug-in Performance](analyze-plugin-performance.md)  
  
 [Walkthrough: Register a Plug-in using the Plug-in Registration Tool](walkthrough-register-plugin-using-plugin-registration-tool.md)  
  
 [Walkthrough: Configure Assembly Security for an Offline Plug-in](walkthrough-configure-assembly-security-offline-plugin.md)  
  
 [Sample: Basic Plug-in](sample-create-basic-plugin.md)  
  
 [Sample: Web Access from a Sandboxed Plug-in](sample-web-access-sandboxed-plugin.md)  
  
## Related Sections  
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)  
  
 [Event Execution Pipeline](event-execution-pipeline.md)  
  
 [Web Service Authentication and Impersonation](authenticate-users.md)
