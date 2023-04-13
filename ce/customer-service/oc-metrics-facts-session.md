---
title: Session
description: Learn about FactSession metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/13/2023
ms.custom: bap-template
---

# Session

## Avg. session handle time

This metric is similar to conversation handle time, but granular and is calculated for every agent working on the conversation. This metric is relevant for conversations that have been handled by multiple agents.  If multiple agents were assigned to work on a customer request, due to transfers, escalations etc. this metric will allow provide average time spent by each of those agents working with the customer. Conversation handle time is aggregation of session handle time of all the associated session.  

Session handle time: This metric represents time spent by agents assisting customers on request they have been assigned to handle.  

## Customer sentiment

This metric represents the current sentiment of customer. This is powered by Omnichannel for Customer Service sentiment analysis. 

## Is handled by external participant

A customer request could be handled by more than one agent – including a combination of internal contact center agents and external agents. This metric can be used to identify the portion of a customer request that was handled by agents outside of Dynamics 365 Customer Service. External agents could be engaged by your contact center through transfers to an external phone number, Microsoft Teams voice call etc. 
This metric will only show sessions that were assigned to and handled by external agents. For metrics around consult with external agents refer to < Is handled by external participant> on Session Participant.  

## Session transfer rate 
This is a measure of rate at which agents transfer work assigned to them, or supervisors transfer work in the queue they monitor from one agent to another, or to another queue. It is calculated by diving total number of sessions transferred by total number of sessions handled.

- Is Transferred Out:

- Transferred sessions:  

## Session rejection rate 
This is a measure of rate at which agents reject work assigned to them. It is calculated by diving the total number of sessions rejected by agents divided by total number of sessions assigned to them.  

- Rejected sessions: This metric refers to the total number of times agents rejected work assigned to them. 

- Session time to reject: This metric refers to the average time it takes for agents to reject work assigned to them. It is calculated by summing up time difference between when an agent was assigned to work, and the time when the agent rejected the request.  

## Session time to accept  

This metric refers to the average time it takes for agents to reject work assigned to them. It is calculated by summing up time difference between when an agent was assigned to work, and the time when the agent rejected the request.  

- Engaged sessions: This metrics refers to total number of sessions accepted by agents  

## Session timeout rate 
This is a measure of rate at which agents do not respond to work assigned to them. In these scenarios, the agent didn’t accept or reject when offered to work on customer requests.  It is calculated by diving the total number of request where the agent didn’t provide any response by agents divided by total number of sessions assigned to them.  

- Timeout sessions: This metric refers to the total number of times didn’t respond to work assigned to them.  
 
## Session wait time (sec) 
<Reuse content from conversation wait time> 
 
 
## Session closure reason 
Represents reason why a session was closed. A session can be closed for many reasons – from agent ending it after assisting customer to an agent rejecting the request to assist the customer. Here is a glossary of all reasons.

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

Reference Id for session. This is how Dynamics 365 identifies individual sessions and can be used to associate a conversation with all of its associated sessions.

## Active sessions

Count of sessions that are currently in progress. A session is considered active if that are yet to have an agent assigned, or waiting for agent acceptance or have agents actively assisting customers.  

## Closed sessions 
Count of that are currently closed.  

## Total sessions 
Total count of all sessions that were presented to or handled by agents.

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)
