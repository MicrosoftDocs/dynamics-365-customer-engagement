---
title: "Attach customer summary-related action calls to events | MicrosoftDocs"
description: "Learn how to attach the customer summary-related action calls to events for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: CA19D28A-F33D-46B5-B3A9-9243032297F7
ms.custom: 
---

# Step 3: Attach the customer summary-related action calls to events

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to attach the customer summary-related action calls to out-of-the-box events in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md), and [Step 2: Create customer summary-related action calls](customer-summary-step2-create-action-calls.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)


## Attach the action calls to events

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select **BrowserWindowReady**.

5. Select **Add an Existing Action Call**. The **Lookup Records** pane appears.

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Initialize Omni-channel Context - Window Variable - Customer Summary** in the search box and select the action from the list, and then select **Add**. The action call is added to the **BrowserWindowReady** event.

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events.  

    | Event                              | Action Call                                    |
    |------------------------------------|------------------------------------------------|
    | BrowserWindowReady | <ul> Initialize Omni-channel Context - Window Variable - Customer Summary </ul> |
    | OmnichannelSessionInlineSearchAndLink | <ul> Update Conversation Context Entities </ul> |
    | Refresh | <ul> Initialize Omni-channel Context - Window Variable - Customer Summary </ul> |
    | CreateCustomerSession | <ul> Omni-channel Session Accepted <ul> Sub action calls <ul> <li> Show Dashboards On Data Available </li> <ul> Sub action calls  <ul><li>Load Customer Summary</li></ul></ul></ul> |
    | OmnichannelFetchContextEntitiesOnUpdate | <ul> <li>Omni-channel Clear Context Entities</li> <li>Omni-channel Copy Contact Ids To Context</li> <li>Omni-channel Fetch Context Contacts</li> <li>Omni-channel Save Context Entities on Update</li> <li>Initialize Omni-channel Context - Window Variable - Customer Summary</li> <li>Refresh Customer Summary Controls</li> </ul> |

> [!div class="nextstepaction"]
> [Next topic: Step 4: Add the hosted control, action calls, and events to configurations](customer-summary-step4-add-hosted-control-action-calls-events-configurations.md)  

## See also

- [Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md)
- [Step 2: Create customer summary-related action calls](customer-summary-step2-create-action-calls.md)
