---
title: Metadata for subscenarios in conversation diagnostics (preview)
description: Learn about subscenarios metadata for conversation diagnostics in Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: conceptual
ms.collection:
ms.date: 02/28/2025
ms.custom: bap-template
---

# Understand conversation diagnostics

When the system routes a work item, its corresponding data starts appearing in Application Insights within 15 minutes. The conversation diagnostics data is presented in the form of scenarios and subscenarios, as discussed in the following sections.

## Conversation diagnostics scenarios

This scenario captures data related to unified routing, AI agent, customer service representative, and supervisor actions. The following table contains data about the subscenarios corresponding to the scenario.


| Subscenarios                    | Description                                           |
|---------------------------------|-------------------------------------------------------|
| AgentAccept                     | Customer service representative (service representative or representative) accepts the work item assignment                |
| AgentAssignment                 | Representative assigned by unified routing                   |
| AgentAvailabilityTrigger        | Assignment triggered when new representative is available |
| AgentCloseSession               | Representative closed the session with the customer                    |
| AgentEndConversation            | Representative ended the conversation                          |
| AgentPickAssignment             | Representative picked the work item                                |
| AgentReject                     | Representative rejects the work item assignment                |
| AgentRejoined                   | Representative rejoined the call or conversation               |
| AgentTimeout                    | Representative failed to accept the work item assignment       |
| AgentTransfer                   | Representative transferred the conversation to another representative   |
| BotEscalationToHuman            | AI agent escalated to a representative               |
| Classification                  | Work item classification by unified routing           |
| CloseAgentConsult               | Representative closed the consultation request for the conversation |
| ConversationClose               | Conversation closed by system                         |
| CustomerDisconnect              | Customer disconnected from the call or conversation   |
| CustomerEndConversation         | Customer ended the conversation                       |
| InitiateAgentConsult            | Representative requested consultation with another representative for a conversation |
| LeavePublicAgentConsult         | Representative left the public consultation for the conversation |
| ManualAssignment                | Representative or supervisor manually assigned the conversation |
| NewWorkItemTrigger              | Assignment triggered due to new work item added to queue |
| QueueTransfer                   | Conversation transferred to a different queue by representatives |
| RTQ                             | Queue assignment by unified routing                   |
| SupervisorForceCloseConversation| Supervisor forcefully closed conversation             |
| SupervisorTransferToAgent       | Supervisor transferred the conversation to another representative |
| TransferAssignment              | Supervisor or representative transferred the conversation          |

## Understand conversation logs

The event log entries and their descriptions of some events in the subscenarios are as follows.

### Common metadata

The following metadata can be a part of the custom dimensions in the **Traces** table.

| Event log       | Description                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| Channel type    | Channel from which work item originated                                     |
| Org.id          | Environment ID                                                              |
| Resource.id     | Conversation ID                                                             |
| Scenario        | Diagnostics scenario, such as conversation diagnostics scenario or representative configuration scenario |
| Subscenario     | The subscenario, such as classification or route-to-queue        |

### Subscenario: Classification

- **RuleSetName**: Name of the classification ruleset that’s run.
- **RuleHitPolicy**: Displays as “First Match” that tells that rules were processed until the first matching rule was found.
- **RuleSetInfo**: Provides information on the rule that’s run, with the following information:
  - **RuleId**: Classification rule ID
  - **Status**:
      - **Processed**: Work item did not meet the rule conditions.
      - **Applied**: Work item met rule conditions and output was chosen.
      - **Not processed**: Rule conditions not evaluated for this work item.
  - **Order**: Rule order
  - **RuleItem**: Classification rule name
  - **Condition**: Defined in classification rule

### Subscenario: Route-to-queue

- **RuleSetName**: Route-to-queue ruleset name 
- **RuleHitPolicy**: Displays as "Run All" to indicate that all the rules were processed in the stage to identify the matching ones.
- **RuleSetInfo**: Provides information on the rules run.
  - **RuleId**: Route-to-queue rule ID
  - **Status**:
      - **Processed**: Work item didn't meet the rule conditions.
      - **Matched**: Work item met rule conditions, but output wasn't chosen.
      - **Applied**: Work item met rule conditions and output was chosen.
  - **Order**: Rule order
  - **RuleItem**: Route-to-queue rule name
  - **Condition**: Defined in Route-to-queue rule
  - **Output**:
      - **ID**: Output queue ID
      - **DisplayName**: Output queue name
- **OverflowInfo**:
  - **OverflowTrigger** : Condition that's evaluated for overflow
  - **Overflow action**: Action that’s performed on the work item. Learn more in [Handle queue overflow](manage-overflow.md).
- **Omnichannel.description**: Appears when work item is routed to the fallback queue. An example is "Valid route to queue rules are missing in workstream. Routed to fallback queue."
- **Omnichannel.result**: The queue to which the work item is finally routed. If overflow is configured, the final identified queue is determined after overflow evaluation. The output is as follows:
    - **DisplayName**: Queue name
    - **ID**: Queue ID
- **AgentDetails**: Provides information about the representative as follows:
    - **AgentId**: Representative ID
    - **AadUserId**: User ID
    - **Skills**: Skills assigned to the representative
    - **BasePresenceStatus**: Base presence of the representative
    - **CurrentPresence**: Current representative presence
    - **AvailableCapacity**: Available representative capacity units
    - **CapacityProfiles**: Capacity profiles associated with representative
- **IsAgentAssigned**:
    - **True**: Representative assigned to conversation
    - **False**: Representative isn't assigned to conversation
- **Omnichannel.work_item.details**:
    - ConversationId: Work item ID
    - SessionId: Session ID
    - QueueId: Queue ID where work item is queued
    - WorkStreamId: Workstream ID associated with work item
    - RequiredCapacityUnits: Required representative capacity in units for the work item
    - AllowedPresences: Allowed representative presences for the work item
    - CapacityProfiles: Required representative capacity profiles for the work item
    - RequiredSkills: Skills required from representative to work on the work item

## Conversation scenarios

The **Traces** table contains data about the following conversation scenarios.

- **Category**: Conversation initiation 
  - **Scenario**: Conversation is initialized 
  - **Scenario**: Customer identified

- **Category**: AI agent interaction
  - **Scenario**: AI agent assigned
  - **Scenario**: Conversation ended by AI agent
  - **Scenario**: AI agent escalation to service representative

- **Category**:  Routing
  - **Scenario**: Demand Classification
  - **Scenario**: Queue assignment

- **Category**:  Service representative interaction
  - **Scenario**: Representative accepted
  - **Scenario**: Representative rejected
  - **Scenario**: Acceptance request timed out
  - **Scenario**: Representative rejoined
  - **Scenario**: Representative self-assignment

- **Category**: Conversation completion
  - **Scenario**: Conversation ended by customer
  - **Scenario**: Conversation ended by representative
  - **Scenario**: Representative session closed
  - **Scenario**: Conversation abandoned by customer/customer disconnect
  - **Scenario**: Conversation force close by supervisor
  - **Scenario**: Conversation closed

### Subscenario: AgentAccept

- **Omnichannel.description**: Captures the information when representative accepts the conversation:
    - **Success**:
        1. Representative with ID xxxx assigned to the Conversation xxxx. AgentAccept request completed.
        1. Representative with ID xxxx already assigned to the Conversation xxxx. AgentAccept request completed.
    - **Failure**:
        1. Representative with ID xxxx not found in the session xxxx for Conversation xxxx. AgentAccept request failed.
        1. **Scenario**: AgentAccept for Conversation: xxxx failed with exception: xxxx.
- **Omnichannel.target_agent.id**: Captures the ID of the representative who accepts the conversation.
- **Channel type**: Channel from which work item originated.

### Subscenario: SupervisorForceCloseConversation

- **Omnichannel.description**: Captures the information when supervisor attempts to forcefully close the conversation:
    - **Success**: 
        1. **Scenario**: SupervisorForceCloseConversation for Conversation: {Conversation ID} completed successfully.
    - **Failure**: 
        1. SupervisorForceClose request didn't get processed as the state is already closed for Conversation xxxx
        2. **Scenario**: SupervisorForceCloseConversation for Conversation: xxxx failed with exception: xxxx
- **omnichannel.initiator_agent.id**: The ID of the supervisor initiating the action.
- **Channel type**: Channel from which work item originated.

### Subscenario: CustomerEndConversation

- **Omnichannel.description**: Captures the information when customer ends the conversation.
    - Success: 
      Scenario: CustomerEndConversation for Conversation: {Conversation ID} completed successfully.
    - Failure: 
      1. Customer EndConversation request failed for ConversationId: xxxx as conversation state doesn't support the operation. Conversation state: xxxx
      1. Customer EndConversation request failed for ConversationId: xxxx as the conversation is already in closed state
      1. Scenario: CustomerEndConversation for Conversation: xxxx failed with exception: xxxx
- **Channel type**: Channel from which work item originated.

### Subscenario: QueueTransfer

- **Omnichannel.description**: Captures the information when representative attempts to transfer the conversation to another queue.
    - **Success**: 
      Scenario: QueueTransfer for Conversation: {Conversation ID} completed successfully for Target Queue: xxxx with QueueId: xxxx.
    - **Failure**: 
      Scenario: QueueTransfer for Conversation: xxxx failed with exception: xxxx
- omnichannel.initiator_agent.id: The ID of the representative initiating the transfer.
- **Channel type**: Channel from which work item originated.

### Subscenario: InitiateAgentConsult

- **Omnichannel.description**: Captures the information about representative initiating consult request for the conversation.
    - **Success**: 
      Scenario: InitiateAgentConsult for Conversation: {Conversation ID} completed successfully for ConsultType: xxxx under ConversationAccess: xxxx
    - **Failure**: 
      Scenario: AgentTransfer for Conversation: xxxx failed with exception: xxxx
- omnichannel.initiator_agent.id:	Captures the ID of the representative initiating the consult request
- Omnichannel.target_agent.id: Captures the ID of the representative receiving the consult request
- **Channel type**:	Channel from which work item originated.

### Subscenario: AgentReject/AgentTimeout/AgentRejoined/AgentPickAssignment/BotEscalationToHuman/AgentEndConversation/AgentCloseSession/ConversationClose/BotAssignedToConversation/AgentTransfer/SupervisorTransferToAgent/CloseConsult/LeavePublicAgentConsult

- **Omnichannel.description**: Captures the information when the representative or supervisor takes an action on the conversation.
    - Success: {Subscenario} for Conversation: {Conversation ID} completed successfully.
      Example: AgentReject for Conversation: XXXX completed successfully.
    - Failure: {Subscenario} for Conversation: {Conversation ID} failed with exception: {scenarioException.Message}
      Example: AgentCloseSession for Conversation: XXXX failed with exception: Too many requests.
- Omnichannel.initiator_agent.id:	Captures the ID of the representative initiating the action (As applicable)
- Omnichannel.target_agent.id:	Captures the ID of the representative receiving the action (As applicable)
- **Channel type**:	Channel from which work item originated

### Related information

[Configure conversation diagnostics](configure-conversation-diagnostics.md)  
[Sample queries and dashboard](conversation-diagnostics-sample-queries.md)  