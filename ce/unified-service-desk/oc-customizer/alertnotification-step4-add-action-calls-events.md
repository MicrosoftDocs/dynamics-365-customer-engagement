---
title: "Add the Omnichannel Alert Notification-related action calls to the events | MicrosoftDocs"
description: "Learn how to add action calls to the events"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 4: Attach Omnichannel Alert Notification-related action calls to the events

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites 

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md), [Step 2: Create Omnichannel Alert Notification hosted controls](alertnotification-step2-create-hosted-controls.md), and [Step 3: Create Omnichannel Alert Notification-related action call](alertnotification-step3-create-action-call-display-notification.md). The configurations that you completed are required for this topic.
 
- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Attach the action calls to events

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select **CreateCustomerSession**.

5. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Create Customer Session** in the search box and select the action from the list, and then select **Add**. The action call is added to the **BrowserWindowReady** event.

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events. 

 | Event | Action Call |
 |------------------------------------------------|--------------------------------------------------------|
 | CreateCustomerSession | <ul> <li>Close Omnichannel Alert Notification</li> <li>Expand Right Pane</li> <li>Omnichannel Presence Status</li> <li>Create Customer Session</li> <li>Omnichannel Session Accepted</li> <li>Omnichannel Session Rejected</li> <li>Fire Session Timer</li> <li> Load Agent Search Session Page</li> <li>Load Default Agent Script</li> <li>Load Agent Session Overview Page</li> <li>Focus on Overview</li> |
 | IncomingRequestRejected | <ul> <li>Close Omnichannel Alert Notification</li> <li>Omnichannel Session Rejected</li> </ul> |
 | TimedOut | <ul>Omnichannel Session Timeout</ul> |
 | OmnichannelContextFetch | <ul> <li>Show Chat Transfer Request Alert Notification </li> <li>Show Consult Request Alert Notification</li> <li>Show Simple Chat Request Alert Notification</li> <li>Show Simple Chat Request From Supervisor Alert Notification</li>  |

> [!div class="nextstepaction"]
> [Next topic: Step 5: Add the hosted control, events, and action calls to configurations](alertnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

## See also

- [Configure notification for agents](configure-notification-screen-pop-agents.md)
- [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Alert Notification hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 3: Create Omnichannel Alert Notification-related action calls](alertnotification-step3-create-action-call-display-notification.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]