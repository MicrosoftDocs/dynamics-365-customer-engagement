---
title: "Action calls | MicrosoftDocs"
description: "Learn about actions that represents a call to a UII action associated with a hosted control. Action calls are used to pass parameters required to execute the underlying UII action in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Action calls
An action call represents a call to a UII action associated with a hosted control. Action calls are used to pass parameters required to execute the underlying UII action in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 An action call can be attached to the following in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] so that they are executed when:  
  
- An event is raised.  
  
- A window navigation rule is processed.  
  
- A toolbar button is clicked.  
  
- An agent script is run or an answer is clicked.  
  
  The action calls, and the sequence in which they are called, define the behavior of the configured system. Action calls can be thought of as the function call itself, where the UII action is the function signature or definition.  
  
  You can also attach action calls to another action call to execute the attached action calls when the parent action call is executed. The action calls attached to an action call are called the sub-action calls.  
  
### See also  
 [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md)   
 [Add action calls to an event](../unified-service-desk/add-action-calls-event.md)   
 [UII actions](../unified-service-desk/uii-actions.md)   
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]