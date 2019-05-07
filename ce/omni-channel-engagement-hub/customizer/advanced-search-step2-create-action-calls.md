---
title: "Create Omni-channel Advanced Search-related action calls | MicrosoftDocs"
description: "Learn how to create Advanced Search-related action calls for agents using Omni-channel Engagement Hub."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: F0089899-0939-4D11-AAF7-D7FE1D53D3CA
ms.custom: 
---

# Step 2: Create Omni-channel Advanced Search-related action calls

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This topic demonstrates how to create Omni-channel Advanced Search-related action calls in Unified Service Desk for a Dynamics 365 for Customer Engagement instance.

## Prerequisites

- You must have required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] apps entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) and [Step 1: Create Omni-channel Advanced Search hosted control](advanced-search-step1-create-hosted-control.md). The configurations that you completed are required for this topic. 

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create action calls

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details:
 
    | Tab | Field | Value |
    |------------------|------------------|------------------|
    | General | Name           | Initialize Omni-channel Context - Agent Session Search Page     |
    | General | Hosted Control | Omni-channel Advanced Search |
    | General | Action         | RunScript             | 
    | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('\[\[$Settings.OmniChannelConfig\]+\]'); <br> var session = {"LiveWorkItemId" : "\[\[$Context.LiveWorkItemId\]+\]", "OCSessionId" : "\[\[$Context.OCSessionId\]+\]", "LiveWorkStreamId" : "\[\[$Context.LiveWorkStreamId\]+\]", "LiveWorkItemContext" : '\[\[$Context.LiveWorkItemContext\]\]'}; <br> ocConfig.config.sessionParams = session; <br> } <br> initOCContext(); |

6. Save the action call.

7. Repeat steps 3 through 6 to create the following additional action calls.

## Close Omni-channel Advanced Search
   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name           | Close Omni-channel Advanced Search     |
   | General | Order | 1 |
   | General | Hosted Control | Omni-channel Advanced Search |
   | General | Action         | Close             |

## Update Conversation Context Entities
   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name           | Update Conversation Context Entities    |
   | General | Order | 2 |
   | General | Hosted Control | Communication Panel |
   | General | Action         | OmnichannelUpdateContextEntities |
   | General | Data | ChatPayLoad=\[\[PostData\]\] |

## Load Agent Session Search Page
   | Tab | Field | Value |
   |------------------|------------------|------------------|
   | General | Name           | Load Agent Session Search Page    |
   | General | Order | 20 |
   | General | Hosted Control | Omni-channel Advanced Search |
   | General | Action         | Navigate |
   | General | Data | url=/main.aspx?pagetype=control&controlName=MscrmControls.OCSearchRuntime.OCSearchRuntimeControl&navbar=off <br> HideNavigationBar=true |

> [!div class="nextstepaction"]
> [Next topic: Step 3: Attach Omni-channel Advanced Search-related action calls to events](advanced-search-step3-attach-action-calls-events.md)

## See also

- [Step 1: Create advanced search hosted control](advanced-search-step1-create-hosted-control.md)
- [Step 4: Add hosted control, action calls, and events to configurations](advanced-search-step4-add-hosted-control-action-calls-events-configurations.md)
