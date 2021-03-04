---
title: "Create toolbar buttons for search | MicrosoftDocs"
description: "Learn how to create and add toolbar buttons to search."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 6:  Create toolbar buttons for search

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create toolbar buttons in Unified Service Desk for Dynamics 365 Customer Service.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create search hosted control](search-step1-create-hosted-control.md), [Step 2: Create search-related action calls](search-step2-create-action-calls.md), [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md), [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md), and [Step 5: Configure window navigation rule for communication panel](search-step5-configure-window-navigation-rule.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)


## Create toolbar buttons

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Toolbars** and then select **Omnichannel ToolbarStrip** from the list.

5. Select **Search Icon** from the **Buttons** section.

6. Select the **Related** tab and then select **Toolbar Buttons**.

7. Select **+ New Toolbar Button**.

8. Specify the following in the **New Toolbar Button** page:

    | Tab | Field | Value |
    |-----------|--------------------|----------------------|
    | General | Name | Search |
    | General | Image | new_omnisearch_icon |
    | General | Button Text | [[$Resources.AgentSessionSearchPageHCDisplayName]] |
    | General | Order | 101 |
    | Condition | Visible Condition | "\[\[$Session.IsGlobal\]\]" == "False" && "\[\[$Context.ISENTITYSESSION\]+\]" != "True" |

9. Select **Save** to save toolbar button. After you the save, the **Actions** section appears.

10. Select **Add Existing Action Call** in the **Actions** section. The **Lookup Records** pane appears.

11. Type the name of the action in the search box and select it from the results. You can search for the following action calls:
    - Load Agent Session Search Page
    - Focus on search

    Now, select **Add**.

12. Select **Save** to save the changes.


> [!div class="nextstepaction"]
> [Next topic: Step 7: Add the hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)

## See also

- [Overview](configure-search.md)
- [Step 1: Create search hosted control](search-step1-create-hosted-control.md)
- [Step 2: Create search-related action calls](search-step2-create-action-calls.md)
- [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)
- [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]