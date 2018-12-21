---
title: "Add the action calls to the events"
description: "Learn how to add action calls to the events"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 90690d1d-906e-48a0-b6c8-1ba8d491f2b0
ms.custom: 
---
# Step 5: Add the action calls to the events

1.  Sign in to Dynamics 365.

2.  Go to **Settings** &gt; **Unified Service Desk** &gt; **Events**.

3.  Select an event from the list. See the matrix to add the action call against the events.

4.  In the event page, under the **Active Actions** section, select **+** icon. In the search box, type the name of the action call, and select the search icon.

5.  Select the action from the list to add the action call to the event.

6.  Select **Save**.

| **Event**                  | **Action Call**                               |
|----------------------------|-----------------------------------------------|
| CreateCustomerSessionEvent | CloseUSDPopupNotification                     |
|                            | Expand Right Pane                             |
|                            | Omni-channel Presence Status                  |
|                            | CreateCustomerSession                         |
|                            | OCSessionAccepted                             |
|                            | ExecuteKBSearchOnDataAvailable                |
|                            | FireSessionTimer                              |
|                            | Load Agent Search Session Page with Condition |
|                            | Load Default Agent Script                     |
|                            | Load Agent Session Overview Page              |
|                            | Focus on Overview                             |
| IncomingRequestRejected    | CloseUSDPopupNotification                     |
|                            | OCSessionRejected                             |
| TimedOut                   | OCSessionTimeout                              |
| Omni-channel Context Fetch | ShowSimpleChatRequestScreenPop                |

> [!div class="nextstepaction"]
> [Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](alertnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

## See also

[Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)

[Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)

[Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)

[Step 3: Create events](alertnotification-step3-create-the-events.md)

[Step 4: Create an action call to display the notification](alertnotification-step4-create-action-call-display-notification.md)

[Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)