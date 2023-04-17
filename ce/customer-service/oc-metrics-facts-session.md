---
title: Session
description: Learn about FactSession metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/17/2023
ms.custom: bap-template
---

# Session

## Average session handle time

This metric is similar to conversation handle time, but granular and is calculated for every agent working on the conversation. This metric is relevant for conversations that have been handled by multiple agents. If multiple agents were assigned to work on a customer request, due to various reasons, such as transfers and escalations, this metric provides the average time spent by each of those agents working with the customer. Conversation handle time is the aggregation of session handle time of all the associated sessions.  

**Related metric**
- Session handle time: This metric represents the time spent by agents assisting customers on assigned customer requests. 

## Customer sentiment

This metric represents the current sentiment of the customer. This is powered by Omnichannel for Customer Service sentiment analysis.

## Is handled by external participant

A customer request could be handled by more than one agent, including a combination of internal contact center agents and external agents. This metric can be used to identify the portion of a customer request that was handled by agents outside of Dynamics 365 Customer Service. External agents could be engaged by your contact center through transfers to an external phone number, such as Microsoft Teams voice call.
This metric will only show sessions that were assigned to and handled by external agents. For metrics around consultations with external agents, go to [Is handled by external participant](oc-metrics-facts-sessionparticipant.md#is-handled-by-external-participant) in Session participant.

## Session transfer rate
 
This metric measures the rate at which agents transfer work assigned to them, or supervisors transfer work in the queue they monitor from one agent to another, or to another queue. It is calculated by dividing the total number of sessions transferred, by the total number of sessions handled.

- Is Transferred Out:

- Transferred sessions:  

## Session rejection rate

This metric measures the rate at which agents reject work assigned to them. It is calculated by dividing the total number of sessions rejected by agents, by the total number of sessions assigned to them.  

**Related metrics**

- Rejected sessions: This metric refers to the total number of times agents rejected work assigned to them.

- Session time to reject: This metric refers to the average time taken by agents to reject work assigned to them. It is the time difference between an agent being assigned a customer request and the agent rejecting the request.  

## Session time to accept  

This metric refers to the average time taken by agents to accept work assigned to them. It is the time difference between an agent being assigned a customer request and the agent accepting the request.  

**Related metrics**

- Engaged sessions: This metric refers to the total number of sessions accepted by agents.

## Session timeout rate

This metric measures the session timeout rate because of agent's inactivity. The agent didn’t accept or reject the customer requests. It is calculated by dividing the total number of requests where the agent didn’t provide any response, by the total number of sessions assigned to them.  

**Related metrics**

- Timeout sessions: This metric refers to the total number of times agents didn’t respond to the work assigned to them.  
 
## Session wait time

It is a measure of the time taken before an agent responds to a customer's request. It represents the time, in seconds, spent by a customer waiting in a session.
 
## Session closure reason

This metric represents the reason why a session was closed. A session can be closed for reasons, such as, agent ending a session after assisting a customer, agent rejecting the request to assist the customer. The following table lists all the reasons.

|Value  | Label |
|---------|---------|
|192350000     |  Default |
|192350001     |  AgentReject |
|192350002     |  AgentTimeout |
|192350003     |  ConversationTimeout|
|192350004     |  AgentClosed |
|192350005     |  ConversationClosed |
|192350006     |  AgentTransfered |
|192350007     |  AgentDisconnected  |
|192350008     |  AgentReRouted |
|192350009     |  VirtualAgentClosed |
|192350010     |  AgentTransferToQueue |
|192350011     |  SupervisorAssignToQueue |
|192350013     |  SystemReject |
|192350014     |  ForceClose |

## Session Id

This metric refers to the reference Id for a session. This is how Dynamics 365 identifies individual sessions and uses the Id to associate a conversation with its associated sessions.

## Active sessions

Count of sessions that are currently in progress. A session is considered active, if it is yet to have an agent assigned, is waiting for agent acceptance, or have agents actively assisting customers.  

## Closed sessions

Count of sessions that are currently closed.  

## Total sessions

The total count of all sessions that were presented to or handled by agents.

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display)
