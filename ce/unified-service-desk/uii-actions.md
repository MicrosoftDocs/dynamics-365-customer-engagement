---
title: "UII actions in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about UII actions in Unified Service Desk that define a specific operation that can be performed when called."
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
ms.assetid: 145b3e99-2423-441e-88ac-ec99b1364ed6
caps.latest.revision: 6
author: kabala123
ms.author: kabala
manager: sakudes
---
# UII actions in Unified Service Desk
UII action is a concept inherited from [!INCLUDE[pn_user_interface_integration](../includes/pn-user-interface-integration.md)] (UII). UII actions are the core of a hosted control, and define a specific operation that can be performed when called. UII action can be thought of as the public methods that can be called from external components, and are the subject of action calls in [!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)]. A hosted control cannot interact with the rest of the application if no UII action is defined or available for the hosted control.  
  
 For each predefined hosted control type in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], a set of predefined UII actions are available. For information about predefined UII actions available for each hosted control type, see [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md). If you are developing a custom hosted control, it is not enough to just override the `DoAction` method in the code to handle a specific action for the hosted control. You must explicitly define the action in the **UII Actions** list for the custom hosted control in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], thereby enabling the user to call it using action calls. For more information about explicitly defining a UII action for a custom hosted control, see [Create custom Unified Service Desk hosted control](../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md).  
  
### See also  
 [Add a UII action to a hosted control](../unified-service-desk/add-uii-action-hosted-control.md)   
 [Action calls](../unified-service-desk/action-calls.md)   
 [Create an action call for a UII action](../unified-service-desk/create-action-call-uii-action.md)   
 [Core concepts for configuring Unified Service Desk](../unified-service-desk/core-concepts-for-configuring-unified-service-desk.md)
