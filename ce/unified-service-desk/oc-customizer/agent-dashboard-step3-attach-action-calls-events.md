---
title: "Attach action calls to the events | MicrosoftDocs"
description: "Learn how to attach the Omnichannel Agent Dashboard-related action calls to the out-of-the-box events for agents using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 3:  Attach Omnichannel Agent Dashboard-related action calls to events 

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to attach Omnichannel Agent Dashboard-related action calls to the out-of-the-box events in Unified Service Desk for Dynamics 365 Customer Service.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create Omnichannel Agent Dashboard hosted control](agent-dashboard-step1-create-hosted-control.md), and [Step 2:  Create  Omnichannel Agent Dashboard-related action calls](agent-dashboard-step2-create-action-calls.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Attach the action calls to events

1. Sign in to the Dynamics 365 instance.

2. Select the **Down** arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select **BrowserWindowReady**.

5. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Initialize Omnichannel Context - Agent Home Page** in the search box and select the action from the list, and then select **Add**. The action call is added to the **BrowserWindowReady** event.

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events.

    | Event                              | Action call                                    |
    |------------------------------------|------------------------------------------------|
    |  BrowserWindowReady | <ul> Initialize Omnichannel - Agent Home Page </ul> |
    | OpenConversationAsSession | <ul> <li>Omnichannel Check Existing Session For Conversation</li> <li>Show My Work Items Error Toast Notification</li></ul> |
    | Refresh | <ul>Initialize Omnichannel - Agent Home Page</ul>|
    | DesktopReady | <ul>Load Agent Home Page</ul>|

> [!div class="nextstepaction"]
> [Next topic: Step 4: Add the hosted control, action calls, and events to configurations](agent-dashboard-step4-add-hosted-control-action-calls-events-configurations.md) 

## See also

- [Step 1: Create Omnichannel Agent Dashboard hosted control](agent-dashboard-step1-create-hosted-control.md)
- [Step 2: Create Omnichannel Agent Dashboard-related action calls](agent-dashboard-step2-create-action-calls.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]