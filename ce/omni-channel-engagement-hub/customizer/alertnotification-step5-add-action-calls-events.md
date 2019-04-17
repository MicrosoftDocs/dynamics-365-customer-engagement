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
ms.assetid: 90690d1d-906e-48a0-b6c8-1ba8d491f2b0
ms.custom: 
---
# Step 5: Add the action calls to the events

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Attach the action calls to events

1. Sign in to a Microsoft Dynamics 365 for Customer Engagement instance.

2. Select the Down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Events** and then select the event to which you want to add the action call. Select **CreateCustomerSession**.

5. Select **Add Existing Action Call**. The **Lookup Records** pane appears.

6. In the **Lookup Records** pane, enter the name of the action call you want to add. Enter **Create Customer Session** in the search box and select the action from the list, and then select **Add**. The action call is added to the **BrowserWindowReady** event.

7. Select **Save**.

8. Repeat steps 4 through 7 to add the following action calls to the corresponding events. 

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
