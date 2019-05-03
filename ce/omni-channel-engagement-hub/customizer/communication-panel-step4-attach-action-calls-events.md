---
title: "Attach communication panel-related action calls to events | MicrosoftDocs"
description: "Learn how to the attach the communication panel-related action calls to the out-of-the-box events for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 03125D65-65F4-4189-BCD4-B1317B68CE3C
ms.custom: 
---

# Step 4:  Attach communication panel-related action calls to events 

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to attach communication panel-related action calls to the out-of-the-box events in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md), [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md), and [Step 3: Create action calls related to a communication panel](communication-panel-step3-create-action-calls.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Attach the action calls to events

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select **DesktopReady**.

5. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

    ![Select Add an Existing Action Call from the event page](../media/oc-usd-cp-desktopready-add.png "Add an existing action call") 

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Launch Communication Panel** in the search box and select the action from the list, and then select **Add**. The action call is added to the **DesktopReady** event.

    ![Enter the action call name in the search box select the action call and select add](../media/oc-usd-cp-desktopready-search-add.png "Search and add the action call")

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events.

    | Event                              | Action call                                    |
    |------------------------------------|------------------------------------------------|
    | OmnichannelFetchConfigurationData | <ul> <li> Omni-channel Clear Entity List </li> <li>Omni-channel Fetch Live Work Streams </li> <li> Omni-channel Fetch Service End Point </li> <li>Omni-channel Save Configuration Data </li> </ul> |
    | OmnichannelUpdateConfigurationContext | <ul>Update Omni-channel Configuration</ul> |
    | AADAuthenticationFailed | <ul>Omni-channel AAD Authentication Failed</ul> |
    | CreateCustomerSession | <ul> <li>Omni-channel Activate Session</li> <li>Omni-channel Rehydrate Conversation</li> <li>Create Customer Session</li> <li>Show Session Assignment Toast Notification</li> <li>Set IsCaseSession to False</li> <li>Omni-channel Session Accepted</li> </ul> |
    | CreateEntitySession | <ul> <li>Close Toast Notification</li> <li>Expand Right Pane</li> <li>Create Customer Session</li> <li>Show Session Error Toast Notification</li> <li>Set Entity Session Property in Context</li> <li>Collapse Left Panel</li> <li>Load Case Session Agent Script</li> <li>Load Form for Entity</li> <li>Omni-channel Set Session Tab Id for Entity</li> <li>Session</li> </ul>|
    | DisplayKBSearchControl | <ul> <li> Expand Right Pane </li> <li>Focus on KB Search</li> </ul> |
    | DisplayMessage | <ul>Display Message Action</ul> |
    | EndConversation | <ul> <li>Omni-channel End Conversation</li> <li>Omni-channel Presence Status Update</li> </ul> |
    | IncomingChatRequest | <ul>Omni-channel Incoming Session Request</ul> |
    | Omni-channel Conversation Control Ready | <ul> <li>Load Supervisor Dashboard</li> <li>Load Agent Home Page</li> <li>Omni-channel Communication Panel Loaded</li> <li>Load Supervisor Conversations</li> </ul> |
    | OmnichannelFetchContextEntities | <ul> <li>Omni-channel Clear Context Entities</li> <li>Omni-channel Copy Contact Ids To Context</li> <li>Omni-channel Fetch Context Contacts</li> <li>Omni-channel Save Context Entities</li></ul> |
    | OmnichannelFetchContextEntitiesOnUpdate | <ul> <li>Omni-channel Clear Context Entities</li> <li>Omni-channel Copy Contact Ids To Context</li> <li>Omni-channel Fetch Context Contacts</li> <li>Omni-channel Save Context Entities on Update</li> <li>Initialize Omni-channel Context - Window Variable - Customer Summary</li> <li>Refresh Customer Summary Controls</li> </ul> |
    | OmnichannelNotifyConversationControlError | <ul> Omni-channel Notify Communication Panel Error </ul> |
    | OmnichannelProxyHttpResponse | <ul>Omni-channel Proxy Response</ul> |
    | OmnichannelSessionTransferInitiated | <ul>Omni-channel Session Transfer Initiated</ul> |
    | OmnichannelSwitchToGlobalSession | <ul>Focus on Omni-channel Agent Dashboard</ul> |
    | OmnichannelUpdatePresenceGlobalContext | <ul> <li>Update Old Presence Status In Settings</li> <li>Update Current Presence Status In Settings</li></ul> |
    | OmnichannelUpdatePresenceParameters | <ul> <li>Update Current Presence Status In Settings</li> <li>Update All Presence State In Settings</li> </ul> |
    | EntityNotification | <ul> <li>ShowCaseEntityNotification</li> <li>ShowDefaultEntityNotification</li> </ul> |
    | UnreadMessage | <ul> Omni-channel Unread Message Action </ul> |
    | UpdatePresence | <ul> Omni-channel Update Presence </ul> |
    | UpdateSessionCount | <ul> Update Session Count in Dictionary </ul> |

> [!div class="nextstepaction"]
> [Next topic: Step 5: Configure window navigation rule for communication panel](communication-panel-step5-configure-window-navigation-rule.md) 

## See also

- [Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md)
- [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md)
- [Step 3: Attach communication panel-related action calls to events](communication-panel-step3-create-action-calls.md)
- [Step 6: Add the hosted control, action calls, window navigation rule, and events to configurations](communication-panel-step6-add-hosted-control-action-calls-events-configurations.md)
