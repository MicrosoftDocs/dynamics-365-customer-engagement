---
title: Voice channel historical analytics and call insights
description: Learn about the analytics reports and call insights that are available in the voice channel in Contact Center.
ms.date: 07/01/2024
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.custom:
- bap-template
- dyn365-customerservice
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
---

# Voice channel historical analytics, reports, and call insights

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature isn't intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with customer service representatives might be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their customer service representatives that their communications with end users might be monitored, recorded, or stored.

The Voice analytics report provides comprehensive information on the overall performance of customer support across the voice channel. The reports provide administrators and supervisors with a visualization and ability to filter across channels, queues, customer service representatives (service representatives or representatives), and date ranges to help better understand performance and troubleshoot problem areas.

:::image type="content" source="../media/voice-channel-conversation-report.png" alt-text="Voice channel conversation report.":::

## Report details

The following KPIs are displayed in the Voice dashboard.

| Metric | Definition (historical)  |
|----------------|---------------------|
| Incoming conversations  | The number of conversations initiated by the customer and can be presented to a service representative. |
| Engaged conversations  | The conversations that the service representative was engaged in. Customer-to-representative communication can begin at this point. |
| Abandon rate | Percentage of conversations that aren't engaged by service representatives.
| Average wait time | The average time customers waited before connecting to service representatives. Similar to speed to answer, but includes time waited on each session within a conversation. |
| Average Speed to answer (sec) | The average time customers waited in the queue before connecting to a service representative (the time for acceptance). |
| Avg. CSAT <br> **Note:** Currently unavailable. | The average of customer satisfaction ratings provided by customers.  |
| Avg. Conversation sentiment | The average sentiment score based on the verbatim provided in customer voice survey. |
| Avg. handle time | The average time that a service representative spent on a conversation.  |
| Transfer rate | The percentage of times a conversation was transferred from one representative to another. |
| Avg. customer effort | The time that a customer spent on a conversation to get their issue resolved. |
| Avg. sessions per conversation | The average sessions created and engaged for each conversation engaged. |

The following report includes conversation intelligence, which uses analytics and data science to gather data from service representative call recordings. Conversation intelligence analyzes the data to provide you with the information and insights to intelligently manage your support team and proactively coach representativess.

:::image type="content" source="../media/voice-channel-agent-drill-down.png" alt-text="Voice service representative drill-down report.":::

The following metrics are available for the service representative conversation style.

| Metric  | Definition  |
|----------------|------------|
| Talk to listen ratio | The averages listen and talk ratio of service representatives in conversations with customers.  |
| Talking speed (WPM) | The average number of words used per minute by service representatives. |
| Switches per conversation | The average exchanges between a representatives and a customer in a conversation; the number of times the conversation switched from one person to another. This is a sign of engagement during conversations. |
| Pause before speaking (sec)  | The milliseconds a service representative paused before responding to customer queries; indicates representatives's patience. |
| Longest customer monologue (sec)  | The longest monologue by the customer with a service representative; indicates that the service representative is asking good questions and understanding customer needs. |

## Call insights

Supervisors can look into each article, and view the CSAT and sentiment to see coaching opportunities. Supervisors can view details of a conversation by drilling through the topics and selecting a conversation title.

Supervisors can also see entire transcripts to understand the conversation style and get precise verbatim used so that they can make informed decisions about training requirements for the service representative.

:::image type="content" source="../media/voice-recording-transcript-viewer.png" alt-text="Voice recording transcript viewer.":::

### Related information

[Introduction to the voice channel](../administer/voice-channel.md)  
[Provision and set up the voice channel](../administer/voice-channel-install.md)  
[View voice calls usage](../administer/voice-channel-usage.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
