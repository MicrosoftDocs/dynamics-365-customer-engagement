---
title: "Configure toast notifications in Unified Service Desk | MicrosoftDocs"
description: "Learn how to configure toast notification for agents in Omnichannel for Customer Service using Unified Service Desk settings."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Configure toast notifications in Unified Service Desk

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Steps for configuring toast notification

The process of configuring toast notification (floating notification) settings in Unified Service Desk involves multiple steps:

1. Create forms with notifications definition (XAML).

2. Create Hosted Control.

3. Create Action Calls.

4. Attach the Action Calls to Events

5. Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations.


> [!div class="nextstepaction"]
> [Next topic: Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)

## See also

- [Step 2: Create Omnichannel Toast Notification hosted control](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create Omnichannel Toast Notification-related action call](toastnotification-step3-create-action-call-display-notification.md)
- [Step 4: Attach Omnichannel Toast Notification-related action calls to the events](toastnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted control, events, and action calls to the agent and supervisor configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]