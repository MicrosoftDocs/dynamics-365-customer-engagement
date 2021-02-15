---
title: "Configure communication panel for agents | MicrosoftDocs"
description: "Learn how to configure communication panel for agents using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Configure communication panel for agents overview

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to set up a communication panel for agents to converse with customers. When agents accept an incoming conversation notification request, they use the communication panel to engage with the customer.

## Prerequisites 

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)


- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring a communication panel in Unified Service Desk are as follows:

1. Create hosted control.

2. Create action calls.

3. Attach the action calls to events.

4. Create window navigation rules.

5. Add the hosted controls, actions, and events to the agent and supervisor configurations.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create communication panel entity search forms](communication-panel-step1-create-entity-searches.md)

## See also

- [Step 2: Create communication panel hosted control](communication-panel-step2-create-hosted-control.md)
- [Step 3: Create action calls related to communication panel](communication-panel-step3-create-action-calls.md)
- [Step 4: Attach communication panel-related action calls to events](communication-panel-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for communication panel](communication-panel-step5-configure-window-navigation-rule.md) 
- [Step 6: Add the hosted control, action calls, window navigation rule, and events to configurations](communication-panel-step6-add-hosted-control-action-calls-events-configurations.md) 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]