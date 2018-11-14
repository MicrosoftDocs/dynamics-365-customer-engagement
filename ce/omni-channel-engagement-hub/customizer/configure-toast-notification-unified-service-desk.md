---
title: "Configure toast notification in unified Service Desk "
description: 
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

