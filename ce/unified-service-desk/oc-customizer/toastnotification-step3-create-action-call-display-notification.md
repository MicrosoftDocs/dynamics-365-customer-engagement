---
title: "Create Omnichannel Toast Notification-related action call | MicrosoftDocs"
description: "Learn how to create action calls that can be used to show notifications in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---
# Step 3: Create an action call to display the notification 

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Prerequisites

- You must have required Dynamics 365 Customer Service permissions to configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and access the required Dynamics 365 Customer Service entities. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Access management in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/security-unified-service-desk)

- You must have completed [Create agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md), [Step 1: Create forms to define notification layout](toastnotification-step1-create-forms-define-layout-behavior-notification.md), and [Step 2: Create Omnichannel Toast Notification hosted control](toastnotification-step2-create-hosted-controls.md). The configurations that you completed are required for this topic.

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:  
  
  - [Unified Service Desk Hosted Controls](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk-hosted-controls)  
  
  - These three types of hosted controls: Connection Manager, Global Manager, and Panel Layout. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types, action, and event reference in Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/hosted-control-types-action-event-reference) 
  
  - Filter access using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](/dynamics365/customer-engagement/unified-service-desk/admin/manage-access-using-unified-service-desk-configuration)

## Create action calls

1. Sign in to the Dynamics 365 instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Action Calls** and select **+ New**. 

5. On the page for the new action call, specify the following details. 

 | Tab             | Field           | Value                       |
 |-----------------|-----------------|-----------------------------|
 | General | Name            | Show Session Assignment Toast Notification          |
 | General | Order           | 10                          |
 | General | Hosted Control  | Omnichannel Toast Notification   |
 | General | Action          | Show           |
 | General | Data            | formname=ToastNotification <br> top=85 <br> left=82 <br> timeout=7 <br> stack=true <br> stackHeight=56 <br> placementmode=absolute <br> ToastNotificationText=\[\[$Resources.SessionAssignmentToastNotification\]+\] <br> NotificationIcon=new_omni_toast_tick_icon  |
 | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] >= \[\[$Global.maxNumberOfSessions\]+\] && '\[\[CanActivateSession\]+\]' != 'True' |

6. Save the action call.

7. Repeat steps 4 through 6 to create the following additional action calls.
 
## Show Session Error Toast Notification

 | Tab | Field | Value |
 |------------------|------------------|------------------|
 | General | Name           | Show Session Error Toast Notification   |
 | General | Order | 10 |
 | General | Hosted Control | Omnichannel Toast Notification |
 | General | Action         | Show | 
 | General | Data | formname=ToastNotification <br> top=85 <br> left=82 <br> timeout=7 <br> stack=true <br> stackHeight=56 <br> placementmode=absolute <br> ToastNotificationText=To open this incoming conversation in a session, close an existing session. <br> NotificationIcon=new_omni_toast_error_icon |
 | Advanced | Condition | \[\[$GlobalDictionary.CurrentSessionCount\]+\] >= \[\[$Global.maxNumberOfSessions\]+\] && '\[\[CanActivateSession\]+\]' != 'True' |


> [!div class="nextstepaction"]
> [Next topic: Step 4: Attach Omnichannel Toast Notification-related action calls to events](toastnotification-step4-add-action-calls-events.md)

### See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create Omnichannel Toast Notification-related hosted control](toastnotification-step2-create-hosted-controls.md)
- [Step 5: Add the hosted control, events, and action calls to the agent and supervisor configurations](toastnotification-step5-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]