---
title: "Create Omnichannel Agent Dashboard-related action calls | MicrosoftDocs"
description: "Learn how to create the Omnichannel Agent Dashboard-related action calls for agents using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Step 2: Create Omnichannel Agent Dashboard-related action calls

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

This topic demonstrates how to create Omnichannel Agent Dashboard-related action calls in Unified Service Desk for Dynamics 365 Customer Service.

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md) and [Step 1: Create Omnichannel Agent Dashboard hosted control](agent-dashboard-step1-create-hosted-control.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)
  
  
## Create action calls

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**.

5. In the new page, specify the following details:

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name       | Initialize Omnichannel Context - Agent Home Page  |
  | General | Hosted Control | Omnichannel Agent Dashboard |
  | General | Action     | RunScript | 
  | General | Data | function initOCContext() { <br> var ocConfig = JSON.parse('[[$Settings.OmniChannelConfig]+]'); <br> window.ocContext = ocConfig; <br> } <br> initOCContext();|

6. Save the action call.

7. Repeat steps 3 through 6 to create the following additional action calls.
 
## Omnichannel Check Existing Session For Conversation

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name       | Omnichannel Check Existing Session For Conversation   |
  | General | Hosted Control | Communication Panel |
  | General | Action     | OmnichannelCheckExistingSessionForConversation | 
  | General | Data | ConversationId=\[\[OcConversationId\]+\] <br> OcSessionId=\[\[OcSessionId\]+\] <br> LiveWorkStreamId=\[\[LiveWorkStreamId\]+\]|
  | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] < \[\[$Global.maxNumberOfSessions\]+\] |

## Show My Work Items Error Toast Notification

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name       | Show My Work Items Error Toast Notification  |
  | General | Order | 10 |
  | General | Hosted Control | Omnichannel Toast Notification |
  | General | Action     | Show | 
  | General | Data | formname=ToastNotification <br> top=85 <br> left=82 <br> timeout=7 <br> tack=true <br> stackHeight=56 <br> placementmode=absolute  <br> ToastNotificationText=\[\[$Resources.MyItemsErrorToastNotificationText\]+\] <br> NotificationIcon=new_omni_toast_error_icon|
  | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] >= \[\[$Global.maxNumberOfSessions\]+\] |

## Load Agent Home Page

  | Tab | Field | Value |
  |------------------|------------------|------------------|
  | General | Name       | Load Agent Home Page  |
  | General | Order | 1 |
  | General | Hosted Control | Omnichannel Agent Dashboard |
  | General | Action     | Navigate |
  | General | Data | url=/main.aspx?pagetype=dashboard&id=e8fb53c5-2f79-e811-8162-000d3aa3ef73&_canOverride=false <br> HideNavigationBar=True |

> [!div class="nextstepaction"]
> [Next topic: Step 3: Attach Omnichannel Agent Dashboard-related action calls to events](agent-dashboard-step3-attach-action-calls-events.md)

## See also

- [Step 1: Create Omnichannel Agent Dashboard hosted control](agent-dashboard-step1-create-hosted-control.md)
- [Step 4: Add hosted control, action calls, and events to configurations](agent-dashboard-step4-add-hosted-control-action-calls-events-configurations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]