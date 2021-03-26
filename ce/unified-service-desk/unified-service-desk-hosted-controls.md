---
title: "Unified Service Desk Hosted Controls | MicrosoftDocs"
description: "Learn about the basic concepts related to hosted controls in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
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
# Unified Service Desk Hosted Controls
The hosted control concept is central to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] implementation, and is the primary element used for building agent applications using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. A hosted control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is a .NET component or a model-driven app/external webpage that is hosted within an agent application.
  
<a name="PredefinednCustom"></a>   
## Predefined and custom Unified Service Desk hosted controls  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides you with various types of *predefined* hosted control depending on the component that you want to configure and display in your agent application. For example, a **CRM Page** type of hosted control is used to display a model-driven apps page in your agent application and a **Standard Web Application** type of hosted control is used for external web pages. Each hosted control type has a set of predefined events and actions associated with it. For more information, see [Events](../unified-service-desk/events.md) and [UII actions](../unified-service-desk/uii-actions.md). You can execute an action on a hosted control by creating an action call for the action. For more information, see [Action calls](../unified-service-desk/action-calls.md).  
  
 You can also create custom [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted controls if none of the predefined hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] serve your purpose, and you desire some custom functionality. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create custom Unified Service Desk hosted control](../unified-service-desk/walkthrough-create-custom-hosted-control-for-unified-service-desk.md)  
  
 For information about the various types of predefined hosted controls, and the events and UII actions associated with each type, see [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md).  
  
<a name="BaseClass"></a>   
## Base class of a Unified Service Desk hosted control  
 All the predefined and custom hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] are objects that are derived from the [DynamicsBaseHostedControl](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class. This class defines the methods and properties that are applicable to all the hosted controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 This is important for you to know because you can also create [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] hosted controls, which are derived from another class, and host them in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. For more information about the UII hosted controls, see [Use UII hosted controls with Unified Service Desk](../unified-service-desk/use-uii-hosted-controls-unified-service-desk.md).  
  
<a name="Global"></a>   
## Global and session-based Unified Service Desk hosted controls  
 From a lifecycle perspective, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] has two types of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] hosted controls: global and session-based. A global hosted control is started when the agent application starts and is recycled when the agent application is terminated. A session-based hosted control is started when the session starts, and is usually recycled at the end of the session.  
  
<a name="Dynamic"></a>   
## Dynamic Unified Service Desk hosted controls  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] also supports dynamic hosted controls, which allow an agent to start or close a hosted control on demand, either by using the UI or programmatically in code. A dynamic hosted control can be global or non-global. Global dynamic hosted controls are loaded at the first request and hidden thereafter, and they can be requested at any time, such as during a global session, normal session, or workflow. Non-global dynamic hosted controls can only be loaded after a session has started, and each session uses a different instance of the application. If a dynamic hosted control is part of a workflow, and has not started when the workflow starts, then the workflow will start the hosted control and close it when the workflow is complete.  
  
### See also  
 [Hosted control types, actions, and events](../unified-service-desk/hosted-control-types-actions-events.md)   
 [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)   
 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   
 [Learn to use Unified Service Desk](../unified-service-desk/learn-to-use-unified-service-desk.md)   
 [Use UII hosted controls with Unified Service Desk](../unified-service-desk/use-uii-hosted-controls-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]