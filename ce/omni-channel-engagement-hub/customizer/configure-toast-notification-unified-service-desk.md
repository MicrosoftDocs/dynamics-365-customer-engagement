---
title: "Configure toast notification in unified Service Desk "
description: "Learn how to configure toast notification for agents in Omni-channel Engagement Hub using Unified Service Desk settings."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 476eb2cf-05e7-42ef-a268-4cb6342fb9b2
ms.custom: 
---
# Configure toast notification in Unified Service Desk.

Toast notification settings in Unified Service Desk is a multi-step process.

1.  Create forms with notifications definition (XAML).

2.  Create Hosted Control.

3.  Create Events.

4.  Create Action Calls.

5.  Attach the Action Calls to Events

6.  Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations.

Consider a scenario—you are getting a case request and what are the interaction experience for this case request.

You see a toast notification (floating notification) for the case request where you need to define the events for the following: 

-   Create an event to open a session when agent selects the toast notification.

<!-- -->

-   Create an event and action when an agent does not act, and the notification hides after a brief wait time.

### Create an event to open a session when agent selects the toast notification

You must define an event and attach the action calls for an agent to select the case request notification. When agent selects the notification, the agent will experience the following actions: 

-   The notification closes.

-   The right panel expands.

-   Omni-channel customer session is created.

-   The communication control panel does not load as it is not a chat request.

-   Load the form of the case

-   Load the Omni-channel session for the case entity

> [!div class="nextstepaction"]
> [Next topic: Step 1: Create forms to define layout and behavior of the notification](toastnotification-step1-create-forms-define-layout-behavior-notification.md)

## See also

- [Step 2: Create hosted controls](toastnotification-step2-create-hosted-controls.md)
- [Step 3: Create events](toastnotification-step3-create-the-events.md)
- [Step 4: Create an action call to display the notification](toastnotification-step4-create-action-call-display-notification.md)
- [Step 5: Add the action calls to the events](toastnotification-step5-add-action-calls-events.md)
- [Step 6: Add the hosted controls, events, and action calls to the agent and supervisor configurations](toastnotification-step6-add-hosted-controls-events-action-callsagent-supervisor-configurations.md)
- [Configure alert notification in Unified Service Desk](configure-alert-notification-unified-service-desk.md)