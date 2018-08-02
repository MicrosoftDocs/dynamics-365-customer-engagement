---
title: "Events in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Events in Unified Service Desk are notifications that a hosted control can trigger to indicate to the application that something is occurring. You can assign action calls to an event that you want to run when an event occurs, and the action calls will be executed in the order that is defined in the Order field of the event definition."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: dbb7d1c8-bbcf-42b2-a92d-96c82b285471
caps.latest.revision: 6
author: kabala123
ms.author: kabala
manager: sakudes
---
# Events in Unified Service Desk
Events in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] are notifications that a hosted control can trigger to indicate to the application that something is occurring. You can assign action calls to an event that you want to run when an event occurs, and the action calls will be executed in the order that is defined in the **Order** field of the event definition.  
  
 Events can have parameters, which are returned when the event occurs, and can be used by an action calls assigned to the event as a data parameter. The event parameters are used like replacement parameters. For example, the **BrowserDocumentComplete** event for a **CRM Page** type of hosted control returns the URL of the page that has loaded as an event parameter. This can be used like replacement parameter, for example [[url]], to an action call that is assigned to the event.  
  
 You can also create a user-defined event in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a user-defined event](../unified-service-desk/create-user-defined-event.md)  
  
### See also  
 [Add action calls to an event](../unified-service-desk/add-action-calls-event.md)   
 [Action calls](../unified-service-desk/action-calls.md)   
 [Core concepts for configuring Unified Service Desk](../unified-service-desk/core-concepts-for-configuring-unified-service-desk.md)
