---
title: "Add the action calls to the events | MicrosoftDocs"
description: "Learn how to add action calls to the events"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 68d5f710-90f4-4dcc-abd3-a7c0bf6389c3
ms.custom: 
---
# Step 5: Add the action calls to the events 

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

1.  Sign in to Microsoft Dynamics 365 for Customer Engagement instance. 

2.  Go to **Settings** > **Unified Service Desk** > **Events**. 

3.  Select an event from the list. See the matrix to add the action call against the events. 

4.  On the event page, in the **Active Actions** section, select  plus sign (**+** icon). In the search box, type the name of the action call, and select the search icon. 

5.  Select the action in the search list to add the action call to the event. 

6.  Select **Save**. 

| **Event**                    | **Action Call**                        |
|------------------------------|----------------------------------------|
| CreateCaseEntitySession      | CloseUSDToastNotification              |
|                              | Expand Right Pane                      |
|                              | CreateCustomerSession                  |
|                              | Set Entity Session Property in Context |
|                              | CollapseLeftPanel                      |
|                              | Load Form for Case Entity              |
|                              | OCSetSessionTabIdForEntitySession      |
| Show Foo Entity Notification | OmniChannelHostedControl               |

> [!div class="nextstepaction"]
> [Next topic: Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

## See also

- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
- [Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create events](toastnotification-step3-create-the-events.md)
- [Step 4: Create an action call to display the notification](toastnotification-step4-create-action-call-display-notification.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)
