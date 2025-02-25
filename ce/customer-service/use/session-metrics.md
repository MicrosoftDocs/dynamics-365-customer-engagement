---
title: Session metrics
description: This document outlines various session metrics used to measure the performance and efficiency of service representatives in handling customer requests within Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/25/2025
ms.custom: bap-template
---

# Session metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides key metrics to evaluate sessions from Customer Service analytics reports, helping you measure the performance and efficiency of service representatives in handling customer requests within Dynamics 365 Customer Service.

[Understand the workflow](metrics-data-model.md#understand-the-workflow) to effectively utilize these metrics and improve customer service operations and decision-making.

## Session

This metric represents assignment attempt within a single queue. Whenever a conversation is routed to a queue for assignment, a new session is created to track assignment. If the assignment is successful, the session, the "agent assigned on" and "agent accepted on" measures are updated. A session can be associated with a customer service representative, bot or IVR.

## Active sessions

This metric is a count of sessions that are currently in progress. The system considers a session active if no service representative has yet been assigned to it, it's awaiting service representative acceptance, or service representatives are actively helping customers.

## Closed sessions

This metric is a count of sessions that are currently closed.

## Total sessions

This metric is a measure of the total number of sessions that were presented to or handled by service representatives.

## Session transfer rate

This metric is a measure of the rate at which service representatives transfer work that is assigned to them, or the rate at which supervisors transfer work in the queue that they monitor from one service representative to another or to another queue. It's calculated by dividing the total number of transferred sessions by the total number of handled sessions.

### Related metrics

- **Is Transferred Out**: This metric indicates whether the conversation and the underlying session were transferred out of a queue.
- **Transferred sessions**: This metric is a measure of the total number of sessions that were transferred.

## Session rejection rate

This metric is a measure of the rate at which service representatives reject work that is assigned to them. It's calculated by dividing the total number of sessions that service representatives rejected by the total number of sessions assigned to them.

### Related metrics

- **Rejected sessions**: This metric is a measure of the total number of times that service representatives rejected work that was assigned to them.
- **Session time to reject**: This metric is a measure of the average time that service representatives take to reject work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to a service representative and the point when the service representative rejects the request.

## Session time to accept

This metric is a measure of the average time that service representatives take to accept work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to a service representative and the point when the service representative accepts the request.

### Related metric

- **Engaged sessions**: This metric is a measure of the total number of sessions that service representatives accepted.

## Session timeout rate

This metric is a measure of the rate at which sessions time out because of service representative's inactivity. The service representative didn't accept or reject the customer requests. This metric is calculated by dividing the total number of requests where the service representative didn't provide any response by the total number of sessions that were assigned to them.

### Related metric

- **Timeout sessions**: This metric is a measure of the total number of times that service representatives didn't respond to the work that was assigned to them.

## Session wait time

This metric is a measure of the time, in seconds, that a customer spends waiting in a specific queue before an service representative accepts their request. If the customer abandons the request, or if the conversation is transferred to another queue, the calculation is based on the time between the point when the customer request arrives in the queue and the point when the request is closed.

## Average session handle time

This metric is like conversation handle time, but it's granular and is calculated for every service representative who works on the conversation. This metric is relevant to conversations that multiple service representatives handled. If multiple service representatives were assigned to work on a customer request for any reason (for example, transfers or escalations), this metric measures the average time that each service representative who worked with the customer spent. Conversation handle time is a measure of the aggregated session handle time for all the associated sessions.

### Related metric

- **Session handle time**: This metric is a measure of the time that service representatives spend helping customers on assigned customer requests.

## Is handled by external participant

Multiple service representatives might handle a customer request, including a combination of internal contact center service representatives and external service representatives. For example, your contact center can engage external service representatives through transfers to an external phone number or through a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that service representatives outside Dynamics 365 Customer Service handled. It indicates the sessions that were assigned to and handled by external service representatives only.

### Related metrics

- **External participant channel**: This metric helps identify the channels that external service representatives were engaged through. For example, an external service representative can help customers with requests by calling them directly at their phone number or via a Microsoft Teams Public Switched Telephone Network (PSTN) call.
- **External participant channel type**: This metric represents the details of the external service representative, such as the phone number.

## Session participant

This metric is a measure of the list of participants within a single session. A session will contain at least one session participant; participant can be a service representative, bot, or IVR. Additional participants can be added to the same session in scenarios like Monitor or Consult.


## Session participant count

This metric is a measure of the total number of service representatives who were involved in helping a customer. These service representatives include the primary service representative who was assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

## Sentiment

The metric is a measure of the current sentiment of customer. It's powered by Contact Center sentiment analysis.

## Customer sentiment

This metric is a measure of the current sentiment of the customer. It's powered by Contact Center sentiment analysis.

## Related information

[Customize visual display](customize-reports.md#customize-visual-display)  
[Conversation metrics](oc-metrics-dimensions.md#conversation-metrics)  
[Service representatives](service-rep-metrics.md#service-representatives)
