---
title: "Create customer summary-related action calls for agents | MicrosoftDocs"
description: "Learn how to set up the customer summary-related action calls for agents using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 2: Create customer summary-related action calls

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic describes how to create customer summary-related action calls in Unified Service Desk for Dynamics 365 Customer Service.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) and [Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md). The configurations that you completed are required for this topic.
 
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

## Initialize Omnichannel Context - Window Variable - Customer Summary

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Initialize Omnichannel Context - Window Variable - Customer Summary      |
   | General | Order | 5 | 
   | General | Hosted Control | Customer Summary |
   | General | Action         | RunScript    |
   | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('[[$Settings.OmniChannelConfig]+]'); <br> var session = JSON.parse(JSON.stringify([[$Context.SessionParameters]])); <br> ocConfig.config.sessionParams = session; <br> window.ocContext = ocConfig; <br> }  <br> initOCContext(); |

## Update Conversation Context Entities

   | Tab     | Field          | Value                           |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Update Conversation Context Entities     |
   | General | Order | 2 | 
   | General | Hosted Control | Communication Panel |
   | General | Action         | OmnichannelUpdateContextEntities    |
   | General | Data | ChatPayLoad=\[\[PostData\]\] |

## Omnichannel Session Accepted

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Omnichannel Session Accepted   |
   | General | Order | 15 |
   | General | Hosted Control | Communication Panel |
   | General | Action         | OmnichannelSessionAccepted | 
   | General | Data | ConversationId=\[\[cid\]\] <br> SessionTabId=\[\[$Session.ActiveSession\]\] <br> From=\[\[from\]\] <br> CanActivateSession=\[\[CanActivateSession\]+\] |
   | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] ||  '\[\[CanActivateSession\]+\]' == 'True' |

## Show Dashboards On Data Available

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Show Dashboards On Data Available   |
   | General | Order | 21 |
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | ExecuteOnDataAvailable | 
   | General | Data | milliseconds=5000 <br> \[\[$Context.LiveWorkItemId\]\] <br> \[\[$Context.OCSessionId\]\] <br> \[\[$Context.LiveWorkStreamId\]\] |
   | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

## Load Customer Summary

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Load Customer Summary   |
   | General | Order | 200 |
   | General | Hosted Control | Customer Summary |
   | General | Action         | Navigate | 
   | General | Data | url=/main.aspx?navbar=off&cmdbar=false&pagetype=entityrecord&etn=msdyn_ocliveworkitem&formid=5fe86453-73ea-4821-b6dd-ddc06e1755a1&bodyOnly=true <br> Hidenav=true |

## Omnichannel Clear Context Entities

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Omnichannel Clear Context Entities |
   | General | Order | 1 |
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | ClearEntityList | 
   | General | Data | global=True |    

## Omnichannel Copy Contact Ids To Context

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Omnichannel Copy Contact Ids To Context |
   | General | Order | 2 |
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | CopyToContext | 
   | General | Data | contactIds = \[\[contact\]+\] |

## Omnichannel Fetch Context Contacts

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Omnichannel Fetch Context Contacts |
   | General | Order | 3 |
   | General | Hosted Control | CRM Global Manager |
   | General | Action         | DoSearch | 
   | General | Data | ContextContactSearch <br> global=True |
   | Advanced | Condition | $Expression('\[\[$Context.contactIds\]+\]' == '' ? "false" : "true") |

## Omnichannel Save Context Entities on Update

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Omnichannel Save Context Entities on Update |
   | General | Order | 4 |
   | General | Hosted Control | Communication Panel |
   | General | Action         | OmnichannelSaveUpdatedContextEntities | 
   | General | Data | LiveWorkItemId=\[\[LiveWorkItemId\]+\] |

## Refresh Customer Summary Controls

   | Tab | Field      | Value                       |
   |------------------|----------------------|---------------------------------|
   | General | Name           | Refresh Customer Summary Controls |
   | General | Order | 6 |
   | General | Hosted Control | Customer Summary |
   | General | Action         | RunScript | 
   | General | Data | function refreshControls() { <br> MscrmControls.FormInitiator.FormInitiatorControl.updateLinkedRecords(); <br> } <br> refreshControls(); |

> [!div class="nextstepaction"]
> [Next topic: Step 3: Attach customer summary-related action calls to events](customer-summary-step3-attach-action-calls-events.md)    

## See also

- [Step 1: Create customer summary hosted control](customer-summary-step1-create-hosted-control.md)
- [Step 4: Add the hosted control, action calls, and events to configurations](customer-summary-step4-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]