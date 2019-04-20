---
title: "Configure Omni-channel Agent Dashboard for agents | MicrosoftDocs"
description: "Learn how to configure Omni-channel Agent Dashboard for agents using Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 5347F6B9-93F8-466F-80FB-11E989A6A3CE
ms.custom: 
---

# Configure Omni-channel Agent Dashboard for agents

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic describes how to set up an Omni-channel Agent Dashboard for agents to view the conversation (work items). When agents accept an incoming conversation notification request, they use the Omni-channel Agent Dashboard to engage with the customer.

## Prerequisites 

- You must have the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring an Omni-channel Agent Dashboard in Unified Service Desk are as follows:

1. Create hosted control.

2. Create action calls.

3. Attach the action calls to events.

4. Add the hosted controls, actions, and events to the agent and supervisor configurations.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create Omni-channel Agent Dashboard hosted control](agent-dashboard-step1-create-hosted-control.md)

## See also

- [Step 2: Create Omni-channel Agent Dashboard-related action calls](agent-dashboard-step2-create-action-calls.md)
- [Step 3: Attach Omni-channel Agent Dashboard-related action calls to events](agent-dashboard-step3-attach-action-calls-events.md)
- [Step 4: Add hosted control, action calls, and events to configurations](agent-dashboard-step4-add-hosted-control-action-calls-events-configurations.md)
