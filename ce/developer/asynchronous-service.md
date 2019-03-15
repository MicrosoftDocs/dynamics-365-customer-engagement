---
title: "Asynchronous service in Dynamics 365 for Customer Engagement (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "Learn about the asynchronous service that executes long-running operations independent of the main Dynamics 365 for Customer Engagement (online) Customer Engagement core operation. The asynchronous service features a managed queue for the execution of asynchronous registered plug-ins, workflows, and operations such as bulk mail, bulk import, and campaign activity propagation."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 1a668103-29aa-40d1-877a-263487ba3be1
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Asynchronous service in Dynamics 365 for Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The asynchronous service executes long-running operations independent of the main 
[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps core operation. 
This results in improved overall system performance and improved scalability. The asynchronous service features a managed queue for the execution of 
asynchronous registered plug-ins, workflows, and operations such as bulk mail, bulk import, and campaign activity propagation. These operations are 
registered with the asynchronous service and executed periodically when the service processes its queue. The asynchronous service can be hosted on a 
server other that the server running [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
## In This Section  
 [Asynchronous Service Architecture](asynchronous-service-architecture.md)  
  
 [Asynchronous Operation (system job) Entity](asyncoperation-system-job-entity.md)  
  
 [Asynchronous Operation States](asynchronous-operation-states.md)  
  
 [Dependency and Execution Order in Asynchronous Operations](dependency-execution-order-asynchronous-operations.md)  
  
 [Recurrence Pattern in Asynchronous Job Execution](recurrence-pattern-asynchronous-job-execution.md)  
  
 [Supported Entities for Asynchronous Operations](supported-entities-asynchronous-operations.md)  
  
 [Walkthrough: Stop and Start the Asynchronous Service](stop-start-asynchronous-service.md)  
  
## Related Sections  
 [AsyncOperation EntityType](entities/asyncoperation.md) 

 [Event execution pipeline](/powerapps/developer/common-data-service/event-framework#event-execution-pipeline)
  
 [Processes in Dynamics 365 for Customer Engagement apps (formerly Workflows)](automate-business-processes-customer-engagement.md)  
  
 [Data Management in Dynamics 365 for Customer Engagement apps](manage-data.md)
