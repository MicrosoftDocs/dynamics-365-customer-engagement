---
title: "Create search-related action calls for agents | MicrosoftDocs"
description: "Learn how to set up the search-related action calls for agents and supervisors using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 2: Create search-related action calls

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create search-related action calls in Unified Service Desk for a Dynamics 365 Customer Service instance.

## Prerequisites

- You must have the required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) and [Step 1: Create search hosted control](search-step1-create-hosted-control.md). The configurations that you completed are required for this topic. Also, any other hosted controls that are required to create the action calls discussed in this topic.
 
- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create action calls

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and then select **+ New**.

5. On the new page, specify the following details.

## Load Agent Session Search Page

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Load Agent Session Search Page    |
   | General | Order | 20 | 
   | General | Hosted Control | Search |
   | General | Action         | Navigate  |
   | General | Data | url=/main.aspx?pagetype=search&navbar=off <br> HideNavigationBar=true|

6. Select **Save** to save the action call.

7. Repeat steps  4 through 6 to create the following action calls.

## Focus on Search

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Focus on Search    |
   | General | Order | 230 | 
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | ShowTab  |
   | General | Data | Search |

## Initialize Omnichannel Context - Window Variable - Search result tab

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Initialize Omnichannel Context - Window Variable - Search result tab    |
   | General | Order | 5 | 
   | General | Hosted Control | Search result tab |
   | General | Action         | RunScript  |
   | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('\[\[$Settings.OmnichannelConfig\]+\]'); <br> var session = JSON.parse(JSON.stringify(\[\[$Context.SessionParameters\]+\])); <br> ocConfig.config.sessionParams = session; <br> window.ocContext = ocConfig;|

## Get Entity Primary Attribute Value

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Get Entity Primary Attribute Value   |
   | General | Order | 10 | 
   | General | Hosted Control | Search result tab |
   | General | Action         | RunScript  |
   | General | Data | function GetEntityPrimaryAttributeValue() { <br> return Xrm.Page.data.entity.getPrimaryAttributeValue(); <br> } <br> GetEntityPrimaryAttributeValue();|

## Copy Entity Page Title to $Context on Timeout

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Copy Entity Page Title to $Context on Timeout   |
   | General | Order | 20 | 
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | ExecuteOnTimeout  |
   | General | Data | milliseconds=1000 |

## Copy Entity Page Title to $Context

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Copy Entity Page Title to $Context  |
   | General | Order | 100 | 
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | CopyToContext  |
   | General | Data | EntityPageTitle=\[\[$Return.Get Entity Primary Attribute Value\]+\] |

## Update Conversation Context Entities

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Update Conversation Context Entities  |
   | General | Order | 2 | 
   | General | Hosted Control | Communication Panel |
   | General | Action         | OmnichannelUpdateContextEntities  |
   | General | Data | ChatPayLoad=/[/[PostData/]/] |

> [!div class="nextstepaction"]
> [Next topic: Step 3: Attach sub action calls to action calls](search-step3-attach-sub-action-calls.md)

## See also

- [Overview](configure-search.md)
- [Step 1: Create search hosted control](search-step1-create-hosted-control.md)
- [Step 4: Attach search-related action calls to events](search-step4-attach-action-calls-events.md)
- [Step 5: Configure window navigation rule for search](search-step5-configure-window-navigation-rule.md)
- [Step 6: Create toolbar buttons for search](search-step6-create-toolbar-button.md)
- [Step 7: Add hosted control, action calls, window navigation rule, and events to configurations](search-step7-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]