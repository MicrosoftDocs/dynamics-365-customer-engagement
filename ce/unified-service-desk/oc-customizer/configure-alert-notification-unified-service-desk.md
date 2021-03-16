---
title: "Configure alert notifications in Unified Service Desk | MicrosoftDocs"
description: "Learn how to configure alert notification for agents using Omnichannel for Customer Service in Unified Service Desk."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Configure alert notifications in Unified Service Desk

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The process of configuring alert notification settings in Unified Service Desk involves multiple steps:

1. Create forms with notifications definition (in Extensible Application Markup Language \[XAML\] format).

2. Create hosted control.

3. Create action calls.

4. Attach the action calls to events.

5. Add the hosted control, action calls, and events to the agent and supervisor configurations.

Consider a scenario where you receive an incoming chat conversation request. What is the interaction experience for this incoming chat conversation? You see an alert notification for the incoming conversation request. Therefore, the following events must be created:

- Create an event to open a session when agent selects **Accept**

- Create an event and action when agent selects **Reject**

- Create an event and action when an agent does not act, and time is out after the **Wait Time**

## Create an event to open a session when agent selects Accept 

You must define an event and attach action calls so that an agent can accept an incoming request. When the agent selects the **Accept** button, he or she will experience the following actions:

- The notification closes.

- Communication panel panel (chat or voice) expands.

- Presence status of the agent is updated.

- Omnichannel customer session is created.

- Omnichannel session is accepted.

- KB Articles search control opens.

- Load default agent script.

- Load agent session Customer summary page.

- Focus on the Customer summary page.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)

## See also

- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)
- [Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 3: Create an action call to display the notification](alertnotification-step3-create-action-call-display-notification.md)
- [Step 4: Add the action calls to the events](alertnotification-step4-add-action-calls-events.md)
- [Step 5: Add the hosted controls, events, and action calls to the agent and supervisor configurations](alertnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]