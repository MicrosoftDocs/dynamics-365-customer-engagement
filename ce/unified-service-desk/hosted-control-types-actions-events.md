---
title: "Hosted control types, actions, and events in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.custom: ""
ms.date: 04/24/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 17eec4a8-03a4-467b-af3e-de99fcab4e22
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Hosted control types, actions, and events in Unified Service Desk
There are various types of predefined hosted controls available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to let you build different controls and user experiences in your agent application. For example, to manage all the connections from your agent application to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you create a hosted control of the **Connection Manager** type. To display data from a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] page, you create a hosted control of the **CRM Page** type.  
  
> [!NOTE]
>  The **Ribbon Hosted Control** type is for internal use only. You must not use this hosted control type in your agent applications.  
  
## Mandatory hosted control types in an agent application  
 The **Connection Manager** and **Global Manager** hosted control types are mandatory for a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] agent application to work, and only a single instance of each of these hosted control types must exist in your agent application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connection Manager (Hosted Control)](../unified-service-desk/connection-manager-hosted-control.md) and [Global Manager (Hosted Control)](../unified-service-desk/global-manager-hosted-control.md)  
  
 The sample applications for [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] come preconfigured with an instance of each of these two hosted control types. If you disable any of these hosted controls in an application, the application will not work properly. For more information about the four sample applications, see [Sample Unified Service Desk applications](admin/sample-unified-service-desk-applications.md).  
  
## Predefined UII actions and events for hosted controls  
 Based on the type of hosted control, a set of predefined UII actions and events are available in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. UII actions are specific actions that a hosted control can perform. Events are raised by hosted controls, and you can execute a UII action when an event is raised by creating an action call for the UII action, and associating the action call to an event. For information about the predefined actions and events available for each hosted control type, see [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md).  
  
 You can also view the predefined UII actions and events for a hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [View predefined actions and events for a hosted control](../unified-service-desk/view-predefined-actions-events-hosted-control.md)  
  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides help about the predefined UII actions and events for hosted controls in the embedded help when you view or work with the UII action or event for the hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [View embedded help for actions and events](../unified-service-desk/view-embedded-help-for-actions-and-events.md)  
  
> [!NOTE]
>  Most of the predefined hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] have a predefined action called **default**, which calls an action on the hosted control that is marked as default. Since none of the predefined actions for any of the predefined hosted controls are marked as default, calling the **default** action on any predefined hosted control just loads the respective hosted control. However, for a custom [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted control, you can define an action and set it as default so that the action is called when the **default** action is called on the custom hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [USD Hosted Control (Hosted Control)](../unified-service-desk/usd-hosted-control-hosted-control.md)  
  
### See also  
 [Hosted Controls](../unified-service-desk/unified-service-desk-hosted-controls.md)   
 [Actions](../unified-service-desk/uii-actions.md)   
 [Events](../unified-service-desk/events.md)   
 [Get started with configuring your agent application](../unified-service-desk/get-started-configuring-agent-application.md)   
 [Unified Service Desk Configuration Walkthroughs](../unified-service-desk/unified-service-desk-configuration-walkthroughs.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)