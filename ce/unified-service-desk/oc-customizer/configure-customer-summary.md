---
title: "Configure customer summary page for agents | MicrosoftDocs"
description: "Learn how to configure customer summary pages for agents  using Omnichannel for Customer Service to view customer and conversation details."
author: neeranelli
ms.topic: overview
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 06/27/2024
monikerRange: '>= dynamics-usd-4.1'
ms.custom: evergreen
---


# Configure customer summary page for agents overview

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]


This topic describes how to configure customer summary page for agents to view customer and conversation details and engage with customers. When agents accept an incoming conversation notification request, they see the details of the customer and conversation using the customer summary page.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring customer summary pages in Unified Service Desk are as follows:

1.  Create a customer summary hosted control.

2.  Create customer summary-related action calls.

3.  Attach the action calls to events.

4.  Add the hosted control, actions calls, and events to the agent and supervisor configurations.

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md)


## See also

- [Step 2: Create customer summary-related action calls](customer-summary-step2-create-action-calls.md)
- [Step 3: Attach customer summary-related action calls to events](customer-summary-step3-attach-action-calls-events.md)
- [Step 4: Add the hosted control, action calls, and events to configurations](customer-summary-step4-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
