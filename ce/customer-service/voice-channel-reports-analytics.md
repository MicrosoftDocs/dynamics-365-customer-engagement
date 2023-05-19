---
title: Voice channel historical analytics and call insights
description: Learn about the analytics reports and call insights that are available in the voice channel in Omnichannel for Customer Service.
ms.date: 04/26/2023
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
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

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

The Voice analytics report provides comprehensive information on the overall performance of customer support across the voice channel. The reports provide administrators and supervisors with a visualization and ability to filter across channels, queues, agents, and date ranges to help better understand performance and troubleshoot problem areas.

:::image type="content" source="media/voice-channel-conversation-report.png" alt-text="Voice channel conversation report.":::

**Access the Voice dashboard**

[!INCLUDE[cc-navigation](../includes/cc-navigation.md)]

## Report details

The following KPIs are displayed in the Voice dashboard.

| Metric | Definition (historical)  |
|----------------|---------------------|
| Incoming conversations  | The number of conversations initiated by the customer and can be presented to a human agent. |
| Engaged conversations  | The conversations that the agent was engaged in. Customer-to-agent communication can begin at this point. |
| Abandon rate | Percentage of conversations that are not engaged by agents.
| Average wait time | The average time customers waited before connecting to agents. Similar to "speed to answer", but includes time waited on each session within a conversation. |
| Average Speed to answer (sec) | The average time customers waited in the queue before connecting to an agent (the time for acceptance). |
| Avg. CSAT <br> **Note:** Currently unavailable. | The average of customer satisfaction ratings provided by customers.  |
| Avg. Conversation sentiment | The average sentiment score based on the verbatim provided in customer voice survey. |
| Avg. handle time | The average time that an agent spent on a conversation.  |
| Transfer rate | The percentage of times a conversation was transferred from one agent to another agent. |
| Avg. customer effort | The time that a customer spent on a conversation to get their issue resolved. |
| Avg. sessions per conversation | The average sessions created and engaged for each conversation engaged. |

The following report includes conversation intelligence, which uses analytics and data science to gather data from agent call recordings and Omnichannel for Customer Service. Conversation intelligence analyzes the data to provide you with the information and insights to intelligently manage your support team and proactively coach agents.

:::image type="content" source="media/voice-channel-agent-drill-down.png" alt-text="Voice agent drill-down report.":::

The following metrics are available for the agent conversation style.

| Metric  | Definition  |
|----------------|------------|
| Talk to listen ratio | The average listen and talk ratio of agent in conversations with customers.  |
| Talking speed (WPM) | The average number of words used per minute by agent. |
| Switches per conversation | The average exchanges between an agent and a customer in a conversation; the number of times the conversation switched from one person to another. This is a sign of engagement during conversations. |
| Pause before speaking (sec)  | The milliseconds the agent paused before responding to customer queries; indicates agent's patience. |
| Longest customer monologue (sec)  | The longest monologue by the customer with an agent; indicates that the agent is asking good questions and understanding customer needs. |

## Call insights

Supervisors can look into each topic, and view the CSAT and sentiment to see coaching opportunities. Supervisors can view details of a conversation by drilling through the topics and selecting a conversation title.

Supervisors can also see entire transcripts to understand the conversation style and get precise verbatim used so that they can make informed decisions about training requirements for the agent.

:::image type="content" source="media/voice-recording-transcript-viewer.png" alt-text="Voice recording transcript viewer.":::

### See also

[Introduction to the voice channel](voice-channel.md)  
[Provision and set up the voice channel](voice-channel-install.md)  
[View voice calls usage](voice-channel-usage.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
