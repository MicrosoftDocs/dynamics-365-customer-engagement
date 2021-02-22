---
title: "Configure window navigation rule for search | MicrosoftDocs"
description: "Learn how to create window navigation rule for search."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 5: Configure window navigation rule for search

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create a window navigation rule for search.

## Prerequisites

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create search hosted control](search-step1-create-hosted-control.md), [Step 2: Create search-related action calls](search-step2-create-action-calls.md), [Step 3: Attach subaction calls to action calls](search-step3-attach-sub-action-calls.md), and [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Configure a window navigation rule

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Window Navigation Rules** and then select **+ New**:

5. In the new page, specify the following.

    | Tab           | Field             | Value              |
    |---------------|-------------------|--------------------|
    | General | Name | Open form in search result tab |
    | General | Order | 10 |
    | General | Type | Search |
    | Result | Route Type | In Place |
    | Result | Destination | Tab |
    | Result | Action | Route Window |
    | Result | Target Tab | Search result tab |
    | Result | Show Tab | Search result tab |
    | Result | Hide Command Bar | No |
    | Result | Hide Navigation Bar | No |
    | Advanced | Condition | '\[\[$Session.IsGlobal\]\]'=='False' |

6. Save the window navigation rule information.

> [!div class="nextstepaction"]
> [Next topic: Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)

## See also

- [Overview](configure-search.md)
- [Step 1: Create search hosted control](search-step1-create-hosted-control.md)
- [Step 2: Create search-related action calls](search-step2-create-action-calls.md)
- [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)
- [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]