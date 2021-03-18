---
title: "Attach Omnichannel Toast Notification-related action calls to events | MicrosoftDocs"
description: "Learn how to add Omnichannel Toast Notification-related action calls to events"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 4: Add the action calls to the events 

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to attach Omnichannel Toast Notification related action calls to events.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create forms to define notification layout](toastnotification-step1-create-forms-define-layout-behavior-notification.md) [Step 2: Create Omnichannel Toast Notification hosted control](toastnotification-step2-create-hosted-controls.md), and [Step 3: Create Omnichannel Toast Notification-related action call](toastnotification-step3-create-action-call-display-notification.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

1. Sign in to the Dynamics 365 instance. 

2. Go to **Settings** > **Unified Service Desk** > **Events**. 

3. Select an event from the list. See the matrix to add the action call against the events. 

4. On the event page, in the **Active Actions** section, select  plus sign (**+** icon). In the search box, type the name of the action call, and select the search icon. 

5. Select the action in the search list to add the action call to the event. 

6. Select **Save**. 

| **Event**                    | **Action Call**                        |
|------------------------------|----------------------------------------|
| CreateCustomerSession      | Show Session Assignment Toast Notification              |
|                            | Show Session Error Toast Notification  

> [!div class="nextstepaction"]
> [Next topic: Step 5: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

### See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Toast Notification hosted control](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create Omnichannel Toast Notification-related action call to display the notification](toastnotification-step3-create-action-call-display-notification.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]