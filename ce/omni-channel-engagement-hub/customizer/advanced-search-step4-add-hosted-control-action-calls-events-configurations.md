---
title: "Add hosted control, action calls, and events to configurations | MicrosoftDocs"
description: "Learn how to add hosted control, action calls, and events to configurations for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 17C3F1A7-C755-464B-A7AC-3A4667A09000
ms.custom: 
---

# Step 4: Add the hosted control, action calls, and events to configurations

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to add hosted control, action calls, and events to configurations in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create Omni-channel Advanced Search hosted control](advanced-search-step1-create-hosted-control.md), [Step 2: Create Omni-channel Advanced Search-related action calls](advanced-search-step2-create-action-calls.md), and [Step 3: Attach Omni-channel Advanced Search-related action calls to events](advanced-search-step3-attach-action-calls-events.md). The configurations that you completed are required for this topic.

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Add the hosted control, action calls, and events to agent and supervisor configurations

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**

4. Select **Configuration** and then select a configuration from the list.

5. On the navigation bar, select the Down arrow next to **Configuration** and then select **Action Calls**.

6. On the next page, select **Add Existing Action Call**, type the name of the action in the search bar, and then press **Enter** or select the search icon.

7. Add the action calls that are shown in the search results.

8. Repeat steps 4 through 7 to add the hosted controls and the events by selecting the Down arrow next to **Configuration** and then selecting **Hosted Controls** and **Events**, respectively.

9. When you've finished, select **Save**.  

- [Step 1: Create advanced search hosted control](advanced-search-step1-create-hosted-control.md)
- [Step 2: Create advanced search related action calls](advanced-search-step2-create-action-calls.md)
- [Step 3: Attach advanced search related action call to events](advanced-search-step3-attach-action-calls-events.md)
