---
title: "Add the action calls to the events"
description: 
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

