---
title: "Configure search | MicrosoftDocs"
description: "Learn how to configure search for agents and supervisors to search records using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Configure search overview

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring search in Unified Service Desk are as follows:

1. Create the search and search result hosted control.

2. Create search-related action calls.

3. Attach sub action calls to action calls.

4. Attach the action calls to events.

5. Configure the window navigation rule for search.

6. Create toolbar buttons for search.

7. Add the hosted control, action calls, window navigation rule, toolbar buttons, and events to the agent and supervisor configurations.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create search hosted control](search-step1-create-hosted-control.md)

## See also

- [Step 2: Create search-related action calls](search-step2-create-action-calls.md) 
- [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)
- [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md)
- [Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]