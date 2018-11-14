---
title: "Configure alert notification in unified Service Desk "
description: 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: db796d02-2286-407d-a8c2-60dec859cee0
ms.custom: 
---
# Configure alert notification in Unified Service Desk.

Alert notification settings in Unified Service Desk is a multi-step process.

1.  Create forms with notifications definition (XAML).

2.  Create Hosted Control.

3.  Create Events.

4.  Create Action Calls.

5.  Attach the Action Calls to Events

6.  Add the Hosted Controls, Actions, and Events to the Agent and Supervisor Configurations.

Consider a scenario—you are getting an incoming chat engagement request and what are the interaction experience for this incoming chat engagement.

You see an alert notification for an incoming engagement request where you need to define the events for the following:

-   Create an event to open a session when agent selects **Accept**

-   Create an event and action when agent selects **Reject**

-   Create an event and action when an agent does not act, and time is out after the **Wait Time**

### Create an event to open a session when agent selects Accept 

You must define an event and attach the action calls for an agent to accept an incoming request. When agent selects the **Accept** button, the agent will experience the following actions:

-   The notification closes.

-   Communication control panel (chat or voice) expands.

-   Presence status of the agent is updated.

-   Omni-channel customer session is created.

-   Omni-channel session is accepted.

-   Session timer starts.

-   KB Articles search control opens.

-   Open agent session search page.

-   Load default agent script.

-   Load agent session Customer 360 page.

-   Focus on the Customer 360 page.

 ![alert notification and screen pop experience](media/alert-notification-screenpop.png "Alert notification and screen pop experience")  

### Create an event and action when agent selects Reject 

You must define an event and attach the action calls for an agent to reject an incoming request. When agent selects the **Reject** button, the agent will experience the following actions:

-   The notification closes.

-   Omni-channel session is rejected.

### Create an event and action when agent does not act, and time is out after the Wait Time

You must define an event and an action call when an agent does not act in a stipulated time. The notification hides after the wait time. The agent will experience the following action:

-   The Omni-channel session will time out.

