---
title: "Asynchronous service in Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about the asynchronous service that executes long-running operations independent of the main Dynamics 365 Customer Engagement (on-premises) Customer Engagement core operation. The asynchronous service features a managed queue for the execution of asynchronous registered plug-ins, workflows, and operations such as bulk mail, bulk import, and campaign activity propagation."
ms.date: 06/20/2023
ms.reviewer: pehecke
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Asynchronous service in Dynamics 365 Customer Engagement

The asynchronous service executes long-running operations independent of the main [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] core operation.

This results in improved overall system performance and improved scalability. The asynchronous service features a managed queue for the execution of asynchronous registered plug-ins, workflows, and operations such as bulk mail, bulk import, and campaign activity propagation. These operations are registered with the asynchronous service and executed periodically when the service processes its queue.

The asynchronous service can be hosted on a server other that the server running Dynamics 365 Customer Engagement (on-premises).  

> [!NOTE]
> See [Dataverse Developer guide: Asynchronous service](/power-apps/developer/data-platform/asynchronous-service) for information about interacting with the asynchronous service.

With on-premises, you can [Stop and start the asynchronous service](stop-start-asynchronous-service.md).
  

## Related Sections  
 [AsyncOperation EntityType](entities/asyncoperation.md)  
 [Event execution pipeline](/powerapps/developer/common-data-service/event-framework#event-execution-pipeline)  
 [Processes in Dynamics 365 Customer Engagement (on-premises) (formerly Workflows)](automate-business-processes-customer-engagement.md)  
 [Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
