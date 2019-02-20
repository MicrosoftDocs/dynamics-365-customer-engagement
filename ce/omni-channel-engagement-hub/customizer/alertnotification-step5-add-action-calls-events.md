---
title: "Add the action calls to the events | MicrosoftDocs"
description: "Learn how to add action calls to the events"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 90690d1d-906e-48a0-b6c8-1ba8d491f2b0
ms.custom: 
---
# Step 5: Add the action calls to the events

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

1. Sign in to Microsoft Dynamics 365 for Customer Engagement instance.

2. Go to **Settings** > **Unified Service Desk** > **Events**.

3. Select an event from the list. See the matrix to add the action call against the events.

4. On the event page, in the **Active Actions** section, select the plus sign (**+**). In the search box, type the name of the action call, and then select the search icon.

5. Select the action from the list to add the action call to the event.

6. Select **Save**.

 <table>
    <tr>
        <th>Event</th>
        <th>Action Call</th>
    </tr>
    <tr>
        <td rowspan="11">CreateCustomerSessionEvent</td>
        <td>CloseUSDPopupNotification</td>
    </tr>
    <tr>
        <td>Expand Right Pane</td>
    </tr>
    <tr>
        <td>Omni-channel Presence Status</td>
    </tr>
    <tr>
        <td>CreateCustomerSession</td>
    </tr>
    <tr>
        <td>OCSessionAccepted</td>
    </tr>
    <tr>
        <td>OCSessionAccepted</td>
    </tr>
    <tr>
        <td>FireSessionTimer</td>
    </tr>
    <tr>
        <td>Load Agent Search Session Page with Condition</td>
    </tr>
    <tr>
        <td>Load Default Agent Script</td>
    </tr>
    <tr>
        <td>Load Agent Session Overview Page</td>
    </tr>
    <tr>
        <td>Focus on Overview</td>
    </tr>
    <tr>
        <td rowspan="2">IncomingRequestRejected</td>
        <td>CloseUSDPopupNotification</td>
    </tr>
    <tr>
        <td>OCSessionRejected</td>
    </tr>
    <tr>
        <td>TimedOut</td>
        <td>OCSessionTimeout</td>
    </tr>
    <tr>
        <td>Omni-channel Context Fetch</td>
        <td>ShowSimpleChatRequestScreenPop</td>
    </tr>   
 </table>

7. Repeat steps 4 through 6 to add the following other action calls to the event.

> [!div class="nextstepaction"]
> [Next topic: Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](alertnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)

## See also

- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)
- [Step 1: Create forms to define layout and behavior of the notification](alertnotification-step1-create-forms-define-layout-behavior-notification.md)
- [Step 2: Create hosted controls](alertnotification-step2-create-hosted-controls.md)
- [Step 3: Create events](alertnotification-step3-create-the-events.md)
- [Step 4: Create an action call to display the notification](alertnotification-step4-create-action-call-display-notification.md)
- [Configure toast notification in Unified Service Desk](configure-toast-notification-unified-service-desk.md)
