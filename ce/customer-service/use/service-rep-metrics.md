---
title: Service representatives metrics
description: Understand key metrics to evaluate service representatives' performance, optimize operations, and enhance customer satisfaction in customer service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 04/11/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
  - ai-gen-title
---

# Service representative metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides detailed metrics to evaluate the performance and efficiency of service representatives in Dynamics 365 Customer Service, enabling you to optimize operations and enhance customer satisfaction.

[Understand the conversation workflow](overview-analytics-data-model.md#understand-the-conversation-workflow) to effectively utilize these metrics and improve customer service operations and decision-making.

## Average first response time

Whereas speed to answer provides insights into how quickly a service representative was connected with a customer, first response time provides insights into how quickly the service representative responded to the customer. First response time is a measure of the time that customers spend waiting for a first response from a service representative. The time is adjusted based on operating hours. The calculation is based on the time between the point when a customer initiates a conversation (or, in the case of an AI agent-escalated conversation, the point when the AI agent escalates it) and the point when the service representative accepts the request and responds to the customer. For messaging conversations, this time represents how soon the service representative sent the first response to customer.

The system calculates average first response time by dividing the total first response time across all engaged conversations by the number of engaged conversations.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

## Average service representative response time

Service representative response time is a measure of the average time that customers who sent a message must wait to get a response from a service representative. The time is adjusted based on operating hours. The system calculates average service representative response time by dividing the total response time by the number of exchanges between customers and service representatives across all engaged conversations. A longer response time indicates that more time passes between messages as customers wait for a service representative to respond and provide updates. A longer response time negatively affects the customer experience.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

## First response service level

The percentage of customer conversations that have a service representative response time of less than 60 seconds.

## Service representative response service level

This metric is a measure of the percentage of customer messages that have a service representative response time of less than 60 seconds.

## Total capacity units

The maximum capacity units that are assigned. It applies only to organizations that use capacity units.

### Related metrics

- **Total available capacity units**: This metric is a measure of the capacity units that are available to handle conversations.
- **Total occupied capacity units**: This metric is a measure of the capacity units that are currently occupied.

## Assigned capacity profile count

This metric is a count of capacity profiles that are assigned to service representatives. 

## Total work item capacity

This metric is a measure of the maximum work items that are allowed, based on the configuration of the capacity profile.

### Related metrics

- **Total available work item capacity**: This metric is a measure of the maximum number of more work items that can be assigned.
- **Total work item capacity in use**: This metric is a measure of the work items that are currently being handled.

## Logged in service representatives

This metric is a count of omnichannel service representatives who are currently signed in.

## Total service representatives

This metric is a measure of the total number of omnichannel service representatives.

## Status duration

This metric is a measure of the time that a service representative spent in a presence status.

## Consult

This metric represents the service representative participation **consult** mode. The related metrics aren't available by default. You can use these metrics to customize the visual display of your reports. Select **Edit report** to find the following metrics in your data model when you search for **Consult**. Learn more in [Customize visual display](customize-reports.md#customize-visual-display).

### Related metrics

- **Average consult time**: The average time that service representatives spend helping other service representatives on consult requests. It's calculated by dividing the total time spent by service representatives on these requests by the total number of consult requests accepted. You can display the average consult time in seconds or in the hh:mm:ss format.

- **Consult acceptance rate**: The total number of sessions accepted by service representative over all the sessions requested for consult from the service representative.

- **Consult not acceptance rate**: The total number of sessions that didn't have acceptance by the service representative over all the sessions requested for consult from the service representative. This number includes timed out and rejected requests.  

- **Consult rejection rate**: The total number of sessions that the service representative rejected over all the sessions requested for consult from the service representative.

- **Consults requested**: The total number of sessions that were requested for consultation.

- **Consult requests accepted**: The total number of sessions that were requested for consultation and accepted by the service representative.

- **Consult requests not accepted**: The total number of sessions that were requested for consultation and had no acceptance from the service representative.

- **Consult requests rejected**: The total number of sessions that were requested for consult but the service representative rejected. 

- **Consult requests timed out**: The total number of sessions that were requested for consult from the service representative but resulted in a timeout because the service representative failed to respond.

- **Consult time**: The time taken by service representatives to help other service representatives on consult requests. This metric can be viewed in seconds and in *hh:mm:ss* formats. Available only for the omnichannel real-time out-of-the-box dashboard.

- **Consult sessions**: The total number of sessions that are under consult. Available only for the omnichannel historical out-of-the-box dashboard.

- **Consult timed out rate**: The total number of sessions that resulted in timeout over all the sessions requested for consult from the service representative.

## Related infromation

[Customize visual display](customize-reports.md#customize-visual-display)  
[Conversation metrics](oc-metrics-dimensions.md#conversation-metrics)  
[Session](session-metrics.md#session)


