---
title: "Create search page hosted control | MicrosoftDocs"
description: "Learn how to create the search hosted control for agents and supervisors using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 1: Create search hosted control

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create a search hosted control in Unified Service Desk for a Dynamics 365 Customer Service instance.

## Prerequisites 

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)


## Create hosted control

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** and then select **+ New**.

5. On the page for new hosted control, specify the following:

    | Field                                         | Value                           |
    |-----------------------------------------------|---------------------------------|
    | Name                                | Search |
    | Sort Order | 40 |
    | Display Name | \[\[$Resources.AgentSessionSearchPageHCDisplayName\]\] |
    | Unified Service Desk Component Type | Unified Interface Page |
    | Hosting Type | Chrome Process |
    | Pre-Fetch | Select the check box |
    | Allow Multiple Page | No |
    | Display Group              | MainPanel |
    | Adapter              | Use No Adapter |
    | Application is Dynamic               | yes |
    | User Can Close | Select the check box |

6.  Save the hosted control.

7. Repeat steps 4 through 6 to create the following hosted control:

    | Field                                         | Value                           |
    |-----------------------------------------------|---------------------------------|
    | Name                                | Search result tab |
    | Sort Order | 50 |
    | Display Name | \[\[$Context.EntityPageTitle\]+\] |
    | Unified Service Desk Component Type | Unified Interface Page |
    | Hosting Type | Chrome Process |
    | Pre-Fetch | Select the check box |
    | Allow Multiple Page | No |
    | Display Group              | MainPanel |
    | Adapter              | Use No Adapter |
    | Application is Dynamic               | yes |
    | User Can Close | Select the check box |


> [!div class="nextstepaction"]
> [Next topic: Step 2: Create search-related action calls](search-step2-create-action-calls.md)

## See also

- [Overview](configure-search.md)
- [Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)
- [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md)
- [Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]