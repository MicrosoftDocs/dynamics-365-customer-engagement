---
title: "Channel Analytics | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 10/15/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
ms.assetid: 340185D3-8C9E-43B2-901D-13D9591632F5
author: susikka
ms.author: susikka
manager: shujoshi
---

# Channel Analytics

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Channel Integration Framework provides insights about how the call center is performing in terms of agent assignments, customer satisfaction, average handling time and agent performance. It uses predictive algorithms to calculate upcoming load, customer satisfaction, relationship scores and upsell probability, and helps you utilize operational and conversational analytics for better future planning. 

> [!div class="mx-imgBorder"]
> ![Channel Analytics](media/channel-analytics.PNG "Channel Analytics")

Channel Analytics provides a consistent, seamless and unified experience when it comes to channel related analytics and insights. This means that:

- Channel Analytics enables users to slice and dice KPIs based on different dimensions, including the channel type.
- Users need not jump across apps to get channel specific information.
- Both the conversational data from third party providers and transactional data from Dynamics 365 apps is used to provide a comprehensive contact center analytics information.

### How do analytics help Supervisors?

- Identify the root cause for anomalies in a session. For example, low handle time, low customer satisfaction scores, missed SLAs, etc.
- Prepare audit reports for dissatisfactory conversations and prepare coaching plan for under performing agents.
- Track KPIs that impact customer sentiment. For example, hold time, wait time in queues, first contact resolution, etc.
- In the real-time, analytics can help supervisors identify the on-going service requests that need their intervention. 
- Supervisors can monitor conversations for customer sentiment and language.
- They can also monitor service requests for any KPI breach. For example, SLA expiry and handle time.

### How do analytics help Customer Service Managers?

- Allows them to review anomalies in the contact center. For example, long handling time, low customer satisfaction scores, missed SLAs, etc. They can use this information to identify process improvement opportunities like misrouting, failing automations, etc.
- Track KPIs that indicate the infrastructural health. For example, call abandonment rate, call disconnections, etc.
- Get predictive insights about volume of requests and resource requirements.
- Monitor the health of contact center in terms of load, customer wait time, etc.
- Track KPIs that impact high priority customer sentiment in the contact center.

### How do analytics help Customer Service Agents?

- They can see their performance metrics on different dimensions like customer satisfaction, average handling time, etc.
- They can see burndown trend for their daily work items.
- They can see customer sentiment for ongoing conversations.
- Allows them to track approaching KPI breaches.

## Channel Analytics APIs

The two APIs for tracking event analytics are:

| Name | Description |
|-------|-------|
| [initLogAnalytics](reference/microsoft-ciframework/initLogAnalytics.md) | Invoke this method on an incoming conversation to log analytics. |
| [logAnalyticsEvent](reference/microsoft-ciframework/logAnalyticsEvent.md) | Invoke this method to log analytics for custom events. |

### See also

[What's new in Channel Integration Framework](whats-new-channel-integration-framework.md)