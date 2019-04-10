---
title: "Configure communication panel for agents | MicrosoftDocs"
description: "Learn how to configure communication panel for agents using Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 68C78C8A-A4A3-4213-A0A4-F641B11A8541
ms.custom: 
---

# Configure communication panel for agents

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic demonstrates how to set up communication panel for agents to converse with the customers. When agents get an incoming conversation notification request and accept, then agents use the communication panel to engage with the customers.

## Prerequisites 

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types and action/event reference](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference)  
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

The steps for configuring Communication panel in Unified Service Desk involves multiple steps:

1.  Create hosted control.

2.  Create action Calls.

3.  Attach the action Calls to events

4.  Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations.

> [!div class="nextstepaction"]
> [Next topic: Steps for configuring communication panel](steps-configure-communication-panel.md)