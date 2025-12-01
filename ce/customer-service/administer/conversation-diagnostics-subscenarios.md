---
title: Metadata for subscenarios in conversation diagnostics
description: Learn about subscenarios metadata for conversation diagnostics in Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: concept-article
ms.collection:
ms.date: 09/19/2025
ms.custom: bap-template
---

# Understand conversation diagnostics

When the system routes a work item, its corresponding data starts appearing in Application Insights within 15 minutes. The conversation diagnostics data is presented in the form of scenarios and subscenarios, as discussed in the following sections.

## Conversation diagnostics scenarios

The conversation diagnostics scenario captures data related to unified routing, AI agent, customer service representative (service representative or representative), and supervisor actions. The following table contains data about the subscenarios corresponding to the scenario.

| Subscenarios                       | Description                                           |
|------------------------------------|-------------------------------------------------------|
| Classification                     | Work item classification by unified routing.           |
| ConsultToCSRClosed                 | Representative closed the consultation request for the conversation. |
| ConversationClosed                 | Conversation closed by system.                         |
| ConversationCreated                | Conversation created by system. |
| ConsultToCSRInitiated              | Representative requested consultation with another representative for a conversation. |
| CopilotAgentAssignedToConversation | A Copilot agent is assigned to the conversation.|
| CopilotAgentEscalationToCSR        | AI agent escalated the conversation to a representative.               |
| CSRAccepted                        | Service representative accepts the work item assignment.              |
| CSRAssignment                      | Assignment attempted by unified routing when new work item is added to the queue. It can also include assignment to a representative when they become available.                   |
| CSRAvailabilityCheck               | Check if any service representative is available. |
| CSRClosedSession                   | Representative closed the session with the customer.                    |
| CSREndedConversation               | Representative ended the conversation.                          |
| CSRInitiatedTransfer               | Representative transferred the conversation to another representative.   |
| CSRLeftPublicConsult               | Representative left the public consultation for the conversation. |
| CSRNotificationTimeout             | Representative failed to accept the work item assignment.       |
| CSRPickedConversation              | Representative picked the work item.                                |
| CSRRejected                        | Representative rejected the work item assignment.                |
| CSRRejoined                        | Representative rejoined the call or conversation.               |
| CustomerDisconnected               | Customer disconnected from the call or conversation.   |
| CustomerEndedConversation          | Customer ended the conversation.                       |
| ManualAssignment                   | Representative or supervisor manually assigned the conversation. |
| RouteToQueue                       | Queue assignment by unified routing.                   |
| SupervisorForceClosedConversation  | Supervisor forcefully closed the conversation.             |
| SupervisorInitiatedTransfer        | Supervisor transferred the conversation to another representative. |
| TransferAssignment                 | Supervisor or representative transferred the conversation.          |
| TransferToQueue                    | Conversation transferred to a different queue by the representative. |

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
- **RuleHitPolicy**: Displays "First Match", to indicate that rules were processed until the first matching rule was found.
- **RuleSetInfo**: Provides information on the rule that’s run, with the following information:
  - **RuleId**: Classification rule ID
  - **Status**:
      - **Processed**: Work item didn't meet the rule conditions.
      - **Applied**: Work item met rule conditions and output was chosen.
      - **Not processed**: Rule conditions not evaluated for this work item.
  - **Order**: Rule order
  - **RuleItem**: Classification rule name.
  - **Condition**: Defined in classification rule.

### Subscenario: Route-to-queue

- **RuleSetName**: Route-to-queue ruleset name 
- **RuleHitPolicy**: Displays "Run All" to indicate that all the rules were processed in the stage to identify the matching ones.
- **RuleSetInfo**: Provides information on the rules run.
  - **RuleId**: Route-to-queue rule ID
  - **Status**:
      - **Processed**: Work item didn't meet the rule conditions.
      - **Matched**: Work item met rule conditions, but output wasn't chosen.
      - **Applied**: Work item met rule conditions and output was chosen.
  - **Order**: Rule order.
  - **RuleItem**: Route-to-queue rule name.
  - **Condition**: Defined in Route-to-queue rule.
  - **Output**:
      - **ID**: Output queue ID.
      - **DisplayName**: Output queue name.
- **OverflowInfo**:
  - **OverflowTrigger** : Condition that's evaluated for overflow.
  - **Overflow action**: Action that’s performed on the work item. Learn more in [Handle queue overflow](manage-overflow.md).
- **Omnichannel.description**: Appears when work item is routed to the fallback queue. An example is "Valid route to queue rules are missing in workstream. Routed to fallback queue."
- **Omnichannel.result**: The queue to which the work item is finally routed. If overflow is configured, the final queue is determined after overflow evaluation. The output is as follows:
    - **DisplayName**: Queue name.
    - **ID**: Queue ID.
- **AgentDetails**: Provides information about the representative as follows:
    - **AgentId**: Representative ID.
    - **AadUserId**: User ID.
    - **Skills**: Skills assigned to the representative.
    - **BasePresenceStatus**: Base presence of the representative.
    - **CurrentPresence**: Current presence of representative.
    - **AvailableCapacity**: Available representative capacity units.
    - **CapacityProfiles**: Capacity profiles associated with representative.
- **IsAgentAssigned**:
    - **True**: Representative is assigned to conversation.
    - **False**: Representative isn't assigned to conversation.
- **Omnichannel.work_item.details**:
    - **ConversationId**: Work item ID.
    - **SessionId**: Session ID.
    - **QueueId**: Queue ID where work item is queued.
    - **WorkStreamId**: Workstream ID associated with work item.
    - **RequiredCapacityUnits**: Required representative capacity in units for the work item.
    - **AllowedPresences**: Allowed representative presences for the work item.
    - **CapacityProfiles**: Required representative capacity profiles for the work item.
    - **RequiredSkills**: Skills required by the representative to work on the work item.

### Subscenario: IntentDetermination

Displays information about the intent and intent group determined for the conversation.

- **id**: 
- **Omnichannel.intent_details**:
  - **ActiveIntentFamilyId**: Line of business ID.
  - **ActiveIntentId**: Intent ID.
  - **ActiveIntentName**:
- **omnichannel.intent_group_details**: 
  - **ActiveIntentGroupId**: Intent group ID.
  - **ActiveIntentGroupName**: Intent group name.
- o**mnichannel.is_intent_determined**: True or false.
- **omnichannel.is_intent_group_determined**: True or false.


### Subscenario: LineOfBusinessIdentification

Displays information on the line of business identified for the conversation.

- **id**:
- **omnichannel.additional_info**:
  - **IntentFamilyRulesInformation**: Rules evaluated for identifying line of business.
  - **IsFamilyEnabledForIntentBasedRouting**: Returns true or false.
  - **LOBID**: GUID of the line of business.
  - **LOBName**: Line of business name.

### Subscenario: UserGroupIdentification

Displays information on the user group identified for the conversation.

- **id**:
- **RuleHitPolicy**: Hit-first or Hit-all.
- **RuleSetInfo**: Provides information on the rules that are run.
  - **RuleId**: Line of business evaluation rule ID.
  - **Status**:
      - **Processed**: Rule was evaluated but didn't match.
      - **Applied**: Rule was evaluated and output was chosen.
      - **Not processed**: Not evaluated.
  - **Order**: Rule order.
  - **RuleItem**: Rule name.
  - **Condition**: Conditions evaluated in intent group-user group mapping.
  - **UserGroupOutput**:
   - **id**: Identified user group ID.
   - **Name**: Identified user group name.
   - **Languages**: Languages supported by the user group.
   - **Regions**: Regions supported by the user group.
- **omnichannel.is_user_group_determined**: Returns true or false.
- **omnichannel.user_group_detail**: Details of the user group identified.

### Subscenario: CSRAccepted

- **Omnichannel.description**: Captures the information when representative accepts the conversation:
    - **Success**:
        1. Representative with ID xxxx assigned to the conversation xxxx. CSRAccepted request completed.
        1. Representative with ID xxxx already assigned to the Conversation xxxx. CSRAccepted request completed.
    - **Failure**:
        1. Representative with ID xxxx not found in the session xxxx for conversation xxxx. CSRAccepted request failed.
        1. **Scenario**: CSRAccepted for conversation: xxxx failed with exception: xxxx.
- **Omnichannel.target_agent.id**: Captures the ID of the representative who accepts the conversation.
- **Channel type**: Channel from which work item originated.

### Subscenario: SupervisorForceClosedConversation

- **Omnichannel.description**: Captures the information when supervisor attempts to forcefully close the conversation:
    - **Success**: 
        1. **Scenario**: SupervisorForceClosedConversation for Conversation: {Conversation ID} completed successfully.
    - **Failure**: 
        1. SupervisorForceClose request didn't get processed as the state is already closed for Conversation xxxx
        2. **Scenario**: SupervisorForceClosedConversation for Conversation: xxxx failed with exception: xxxx
- **omnichannel.initiator_agent.id**: The ID of the supervisor initiating the action.
- **Channel type**: Channel from which work item originated.

### Subscenario: CustomerEndedConversation

- **Omnichannel.description**: Captures the information when customer ends the conversation.
    - Success: 
      **Scenario**: CustomerEndedConversation for Conversation: {Conversation ID} completed successfully.
    - **Failure**: 
      1. Customer EndConversation request failed for ConversationId: xxxx as conversation state doesn't support the operation. Conversation state: xxxx
      1. Customer EndConversation request failed for ConversationId: xxxx as the conversation is already in closed state
      1. **Scenario**: CustomerEndedConversation for Conversation: xxxx failed with exception: xxxx
- **Channel type**: Channel from which work item originated.

### Subscenario: TransferToQueue

- **Omnichannel.description**: Captures the information when representative attempts to transfer the conversation to another queue.
    - **Success**: 
      **Scenario**: TransferToQueue for Conversation: {Conversation ID} completed successfully for Target Queue: xxxx with QueueId: xxxx.
    - **Failure**: 
      **Scenario**: TransferToQueue for Conversation: xxxx failed with exception: xxxx
- **omnichannel.initiator_agent.id**: The ID of the representative initiating the transfer.
- **Channel type**: Channel from which work item originated.

### Subscenario: ConsultToCSRInitiated

- **Omnichannel.description**: Captures the information about representative initiating consult request for the conversation.
    - **Success**: 
      **Scenario**: ConsultToCSRInitiated for Conversation: {Conversation ID} completed successfully for ConsultType: xxxx under ConversationAccess: xxxx
    - **Failure**: 
      **Scenario**: CSRInitiatedTransfer for Conversation: xxxx failed with exception: xxxx
- **omnichannel.initiator_agent.id**:	Captures the ID of the representative initiating the consult request
- **Omnichannel.target_agent.id**: Captures the ID of the representative receiving the consult request
- **Channel type**:	Channel from which work item originated.

### Subscenario: Other subscenarios for agents and supervisors

- **Subscenarios**:
    - CSRRejected    
    - CSRNotificationTimeout
    - CSRRejoined
    - CSRPickedConversation
    - CopilotAgentEscalationToCSR
    - CSREndedConversation
    - CSRClosedSession
    - ConversationClosed
    - CopliotAgentAssignedToConversation
    - CSRInitiatedTransfer
    - SupervisorInitiatedTransfer
    - CloseConsult
    - CSRLeftPublicConsult
- **Omnichannel.description**: Captures the information when the representative or supervisor takes an action on the conversation.
    - **Success**: {Subscenario} for Conversation: {Conversation ID} completed successfully.
      **Example**: CSRRejected for Conversation: XXXX completed successfully.
    - **Failure**: {Subscenario} for Conversation: {Conversation ID} failed with exception: {scenarioException.Message}
      **Example**: CSRClosedSession for Conversation: XXXX failed with exception: Too many requests.
- **Omnichannel.initiator_agent.id**:	Captures the ID of the representative initiating the action (As applicable)
- **Omnichannel.target_agent.i**d: Captures the ID of the representative receiving the action (As applicable)
- **Channel type**:	Channel from which work item originated

### Related information

[Configure conversation diagnostics](configure-conversation-diagnostics.md)  
[Sample queries and dashboard](/dynamics365/guidance/resources/conversation-diagnostics-sample-queries)  
