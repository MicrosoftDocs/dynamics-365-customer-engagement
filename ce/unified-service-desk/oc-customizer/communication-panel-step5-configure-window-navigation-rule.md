---
title: "Create window navigation rule for communication panel | MicrosoftDocs"
description: "Learn how to create window navigation rule for communication panel."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 5: Configure window navigation rule for communication panel

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The topic describes how to create window navigation rule for communication panel.

## Prerequisites

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md), [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md), [Step 3: Create communication panel-related action calls](communication-panel-step3-create-action-calls.md), and [Step 4: Attach communication panel-related action calls to events](communication-panel-step4-attach-action-calls-events.md). The configurations that you completed are required for this topic.

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Configure window navigation rule

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Window Navigation Rules** and then select **+ New**.

5. In the new page, specify the following.

    | Tab           | Field             | Value              |
    |---------------|-------------------|--------------------|
    | General | Name | Route external links from Communication Panel |
    | General | Order | 1 |    
    | General | Type | Communication Panel |    
    | Result | Route Type | In Place |
    | Result | Destination | Tab |    
    | Result | Action | Route Window |    
    | Result | Target Tab | View Page |    
    | Result | Show Tab | View Page |    
    | Result | Hide Command Bar | No |    
    | Result | Hide Navigation Bar | No |    

6. Save the window navigation rule information.

## Add window navigation rule to configuration

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**

4. Select **Configuration** and then select a configuration from the list.

5. Select the **Toolbars, Window Navigation Rules and Entity Searches** tab.

6. In the **Window Navigation Rules** section, select the more commands (...) and select **Add Existing Window Navigation Rules**. The **Lookup Records** pane appears.

7. Type the name of the **Window Navigation Rules** in the search box. Select **Session Lines** from the search results, and select **Add**.

8. Select **Save** to save the changes.

> [!div class="nextstepaction"]
> [Next topic: Step 6: Add the hosted control, action calls, window navigation rule, and events to configurations](communication-panel-step6-add-hosted-control-action-calls-events-configurations.md) 

## See also

- [Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md)
- [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md)
- [Step 3: Create communication panel-related action calls](communication-panel-step3-create-action-calls.md)
- [Step 4: Attach communication panel-related action calls to events](communication-panel-step4-attach-action-calls-events.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]