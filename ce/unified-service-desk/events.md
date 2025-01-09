---
title: "Events in Unified Service Desk | MicrosoftDocs"
description: "Use this topic to get an overview of events in Unified Service Desk, how you can add action calls to events, and create user-defined events."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# Events in Unified Service Desk
Events in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] are notifications that a hosted control can trigger to indicate to the application that something is occurring. You can assign action calls to an event that you want to run when an event occurs, and the action calls will be executed in the order that is defined in the **Order** field of the event definition.  
  
 Events can have parameters, which are returned when the event occurs, and can be used by an action calls assigned to the event as a data parameter. The event parameters are used like replacement parameters. For example, the **BrowserDocumentComplete** event for a **CRM Page** type of hosted control returns the URL of the page that has loaded as an event parameter. This can be used like replacement parameter, for example [[url]], to an action call that is assigned to the event.  
  
 You can also create a user-defined event in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a user-defined event](../unified-service-desk/create-user-defined-event.md)  
  
### See also  
 [Add action calls to an event](../unified-service-desk/add-action-calls-event.md)   
 [Action calls](../unified-service-desk/action-calls.md)   
 [Components of Unified Service Desk](../unified-service-desk/core-concepts-for-configuring-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
