---
title: Sample queries for conversation diagnostics (preview)
description: Learn about how to query and retrieve conversation diagnostics from Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.collection:
ms.date: 02/24/2025
ms.custom: bap-template
---

# Sample queries in conversation diagnostics (preview)

Learn about the queries that you can use to retrieve the diagnostics data for unified routing from Application Insights.

## Fallback queues

Purpose: Diagnose number of work items routed to fallback queues

**Query**

let _endTime = datetime(2024-11-21T22:29:53Z);
let _startTime = datetime(2024-09-22T21:29:53Z);
traces
| where timestamp >= _startTime and timestamp <= _endTime
| extend customDim = parse_json(customDimensions)
| extend conversationId = tostring(customDim["powerplatform.analytics.resource.id"]), 
         subscenario = tostring(customDim["powerplatform.analytics.subscenario"]),
         queueResult = parse_json(tostring(customDim["omnichannel.result"])).DisplayName
| where subscenario == "RTQ" and queueResult == "va_chat_queue" 
| project timestamp, conversationId, queueResult

## Overflow handling

**Purpose**: Diagnose number of work items where overflow is trigger

**Query**

traces
| extend customDim = parse_json(customDimensions)
| extend conversationId = tostring(customDim["powerplatform.analytics.resource.id"]),
         subscenario = tostring(customDim["powerplatform.analytics.subscenario"])
| extend omnichannelAdditionalInfo = tostring((customDim["omnichannel.additional_info"]))
| where omnichannelAdditionalInfo contains "OverflowTrigger"
| project timestamp, conversationId, subscenario, omnichannelAdditionalInfo

## Agents who reject assignments
 
**Purpose**: Diagnose agents who reject new assignments (by conversationId)

**Query**

let _endTime = datetime(2024-11-21T22:32:51Z);
let _startTime = datetime(2024-09-22T21:32:51Z);
traces
| where timestamp >= _startTime and timestamp <= _endTime
| extend customDim = parse_json(customDimensions)
| extend conversationId = tostring(customDim["powerplatform.analytics.resource.id"]), 
         subscenario = tostring(customDim["powerplatform.analytics.subscenario"]),
         agentId = tostring(customDim["omnichannel.target_agent.id"]) // Extract agent ID from custom dimensions
| where subscenario == "AgentReject"
| summarize agentRejectionCount = count() by conversationId, agentId // Count rejections per agent per conversation
| summarize rejectionCount = sum(agentRejectionCount), 
            agentRejectionDetails = make_list(pack('agentId', agentId, 'rejectionCount', agentRejectionCount)) 
    by conversationId // Aggregate results by conversation
| where rejectionCount > 1 // Filter conversations with more than one rejection
| project conversationId, rejectionCount, agentRejectionDetails

**Purpose**: Diagnose agents rejecting new assignments (by agents) 
let _endTime = datetime(2024-11-21T22:33:55Z);
let _startTime = datetime(2024-09-22T21:33:55Z);
traces
| where timestamp >= _startTime and timestamp <= _endTime
| extend customDim = parse_json(customDimensions)
| extend conversationId = tostring(customDim["powerplatform.analytics.resource.id"]), 
         subscenario = tostring(customDim["powerplatform.analytics.subscenario"]),
         agentId = tostring(customDim["omnichannel.target_agent.id"]) // Extract agent ID from custom dimensions
| where subscenario == "AgentReject"
| summarize agentRejectionCount = count() by conversationId, agentId // Count rejections per agent per conversation
| summarize rejectionCount = sum(agentRejectionCount), 
            agentRejectionDetails = make_list(pack('agentId', agentId, 'rejectionCount', agentRejectionCount)) 
    by conversationId // Aggregate results by conversation
| where rejectionCount > 1 // Filter conversations with more than one rejection
| project conversationId, rejectionCount, agentRejectionDetails
