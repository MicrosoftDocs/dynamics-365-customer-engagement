---
title: "Attach sub actions to action calls | MicrosoftDocs"
description: "Learn how to attach sub action calls to action calls for agents and supervisors using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 3: Attach sub action calls to action calls

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to attach a action call as sub-action call to another action call in Unified Service Desk for a Dynamics 365 Customer Service instance.

## Prerequisites

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create search-related actions calls](search-step1-create-hosted-control.md), and [Step 2: Create search-related action calls](search-step2-create-action-calls.md). The configurations that you completed are required for this topic.
 
- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Attach sub action calls

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** under **Basic Settings**.

5. Select the **Get Entity Primary Attribute Value** action call from the list.

6. Select the **Related** tab and select **Sub Action Calls**.

7. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

8. Type **Copy Entity Page Title to $Context on Timeout** in the search box. Select the record that appears in the list, and then select **Add** to add the record.

9. Select **Save** to save the record.

10. Repeat step 4.

11. Select the **Copy Entity Page Title to $Context on Timeout** action call from the list.

12. Select the **Related** tab and select **Sub Action Calls**.

13. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

14. Type **Get Entity Primary Attribute Value** in the search box. Select the record that appears in the list, and then select **Add** to add the record.

15. Select **Save** to save the record.

> [!div class="nextstepaction"]
> [Next topic: Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)

## See also

- [Overview](configure-search.md)
- [Step 1: Create search hosted control](search-step1-create-hosted-control.md)
- [Step 2: Create search-related action calls](search-step2-create-action-calls.md)
- [Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md)
- [Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]