---
title: "Steps or procedure to configure customer summary page for agents | MicrosoftDocs"
description: "Learn how to set up the customer summary hosted control for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B498A03B-9CD7-4048-804E-281208711F19
ms.custom: 
---

# Step 2: Create customer summary related action calls

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic demonstrates how to create customer summary hosted control in Unified Service Desk for Dynamics 365 for Customer Engagement instance.

## Prerequisites 

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md). The configurations that you completed are required for this topic.

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles)

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types and action/event reference](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)


## Create action calls

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Select down arrow next Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details.

    | Tab     | Field          | Value                           |
    |------------------|----------------------|---------------------------------|
    | General | Name           | Initialize Omni-channel Context - Window Variable - Customer Summary      |
    | General | Order | 5 | 
    | General | Hosted Control | Customer Summary |
    | General | Action         | RunScript    |
    | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('\[\[$Settings.OmniChannelConfig\]+\]');  <br> var session = {"LiveWorkItemId" : "\[\[$Context.LiveWorkItemId\]+\]", "OCSessionId" : "\[\[$Context.OCSessionId\]+\]", "LiveWorkStreamId" : "\[\[$Context.LiveWorkStreamId\]+\]", "LiveWorkItemContext" : '\[\[$Context.LiveWorkItemContext\]\]', "SessionInfo": '\[\[$Context.SessionInfo\]+\]'};  <br> ocConfig.config.sessionParams = session;  <br> window.ocContext = ocConfig;  <br> }  <br> initOCContext(); |

    
