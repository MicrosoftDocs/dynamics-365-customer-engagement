---
title: Session metrics
description: Evaluate customer service performance using key session metrics like active sessions, transfer rates, and handle times to enhance efficiency and decision-making.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 04/14/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
---

# Session metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article highlights key metrics from Customer Service analytics reports to help you evaluate session performance and measure the efficiency of service representatives in managing customer requests within Dynamics 365 Customer Service.

[Understand the conversation workflow](overview-analytics-data-model.md#understand-the-conversation-workflow) to effectively utilize these metrics and improve customer service operations and decision-making.

## Session

This metric tracks assignment attempts within a single queue. When a conversation is routed to a queue for assignment, a new session is created to track the process. If the assignment is successful, the session updates the "agent assigned on" and "agent accepted on" measures. A session can be associated with a customer service representative, agent, or IVR.

## Active sessions

The number of sessions that are currently in progress. The system considers a session as active if no service representative is assigned to the session, the session is awaiting service representative acceptance, or service representatives are actively helping customers.

## Closed sessions

The number of sessions that are currently closed.

## Total sessions

The total number of sessions that were presented to or handled by service representatives.

## Session transfer rate

The rate at which service representatives transfer work that is assigned to them, or the rate at which supervisors transfer work in the queue that they monitor from one service representative to another or to another queue. It's calculated by dividing the total number of transferred sessions by the total number of handled sessions.

### Related metrics

- **Is Transferred Out**: Indicates whether the conversation and the underlying session were transferred out of a queue.
- **Transferred sessions**: The total number of sessions that were transferred.

## Session rejection rate

The rate at which service representatives reject work that is assigned to them. It's calculated by dividing the total number of sessions that service representatives rejected by the total number of sessions assigned to them.

### Related metrics

- **Rejected sessions**: The total number of times that service representatives rejected work that was assigned to them.
- **Session time to reject**: The average time that service representatives take to reject work that is assigned to them. This metric measures the time from when the customer request is assigned to a service representative to when the service representative rejects the request.

## Session time to accept

The average time that service representatives take to accept work that is assigned to them. This metric measures the time from when a customer request is assigned to a service representative to when the service representative accepts the request.

### Related metric

- **Engaged sessions**: The total number of sessions that service representatives accepted.

## Session timeout rate

The rate at which sessions time out because of service representative's inactivity. This metric is calculated by dividing the total number of requests where the service representative didn't provide any response by the total number of sessions that were assigned to them.

### Related metric

- **Timeout sessions**: The total number of times that service representatives didn't respond to the work that was assigned to them.

## Session wait time

This metric is a measure of the time, in seconds, that a customer spends waiting in a specific queue before a service representative accepts their request. If the customer abandons the request, or if the conversation is transferred, this metric measures the time from when the customer request arrives in the queue to when the request is closed.

## Average session handle time

This metric is like conversation handle time. However, it's calculated for every service representative who works on the conversation. This metric is relevant to conversations that multiple service representatives handled. If multiple service representatives were assigned to work on a conversation for any reason (for example, transfers or escalations), this metric measures the average time spent by each service representative. Conversation handle time is a measure of the aggregated session handle time for all the associated sessions.

### Related metric

- **Session handle time**: The time that service representatives spend helping customers on assigned customer requests.

## Is handled by external participant

Multiple service representatives might handle a customer request, including a combination of internal contact center service representatives and external service representatives. For example, your contact center can engage external service representatives through transfers to an external phone number or a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that service representatives outside Dynamics 365 Customer Service handled. It indicates the sessions that were assigned to and handled by external service representatives only.

### Related metrics

- **External participant channel**: This metric helps identify the channels that external service representatives were engaged through. For example, an external service representative can help customers with requests by calling them directly at their phone number or through a Microsoft Teams Public Switched Telephone Network (PSTN) call.
- **External participant channel type**: This metric represents the details of the external service representative, such as the phone number.

## Session participant

The list of participants within a single session. A session contains at least one session participant; participant can be a service representative, agent, or IVR. Additional participants can be added to the same session in scenarios like Monitor or Consult.


## Session participant count

The total number of service representatives who were involved in helping a customer. Includes the primary service representative assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

## Customer sentiment

The current sentiment of the customer. It's powered by Contact Center sentiment analysis.

## Related information

[Customize visual display](customize-reports.md#customize-visual-display)  
[Calculate conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics)  
[Service representative metrics](service-rep-metrics.md#service-representative-metrics)
