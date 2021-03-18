---
title: "Attach search-related action calls to events | MicrosoftDocs"
description: "Learn how to attach the search-related action calls to events for agents and supervisors using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 4: Attach the search-related action calls to events

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to attach the search-related action calls to out-of-the-box events in Unified Service Desk for a Dynamics 365 Customer Service instance.

## Prerequisites 

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create search hosted control](search-step1-create-hosted-control.md), [Step 2: Create search-related action calls](search-step2-create-action-calls.md), and [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference)
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create OmnichannelSessionInlineSearchAndLink event

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select **+ New**.

5. Specify the following in the **New Event** page:

    | Tab | Field | Value |
    |---------------------|-------------------------|-------------------------|
    | General | Name | OmnichannelSessionInlineSearchAndLink |
    | Hosted Application | Search result tab |

6. Select **Save** to save the record. 

## Attach the action calls to events

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select the **PageReady** event for the **Search result tab** hosted control.

5. Select **Add an Existing Action Call**. The **Lookup Records** pane appears.

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Initialize Omnichannel Context - Window Variable - Search result tab** in the search box, select the action from the list, and then select **Add**. The action call is added to the **PageReady** event.

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events.

    | Event                              | Action Call                                    |
    |------------------------------------|------------------------------------------------|
    | PageReady | Get Entity Primary Attribute Value  |
    | OmnichannelSessionInlineSearchAndLink | Update Conversation Context Entities |

> [!div class="nextstepaction"]
> [Next topic: Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md) 

## See also

- [Overview](configure-search.md)
- [Step 1: Create search hosted control](search-step1-create-hosted-control.md)
- [Step 2: Create search-related action calls](search-step2-create-action-calls.md)
- [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)
- [Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]