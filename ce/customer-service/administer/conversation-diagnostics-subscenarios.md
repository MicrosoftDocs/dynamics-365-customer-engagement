---
title: Understand conversation diagnostics data
description: Learn about the metadata for conversation diagnostics in Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: concept-article
ms.collection:
ms.date: 01/19/2026
ms.custom: bap-template
---

# Understand conversation diagnostics data

When the system routes a work item, its corresponding data starts appearing in Azure Application Insights within 15 minutes. The conversation diagnostics data is presented in the form of scenarios and subscenarios as discussed in the following sections.

## Prerequisite

[Conversation diagnostics](configure-conversation-diagnostics.md) is configured.

## Conversation diagnostics scenarios

The conversation diagnostics scenario captures data related to unified routing, AI agent, customer service representative (service representative or representative), and supervisor actions. The following tables contain data about the subscenarios corresponding to the scenario. Other telemetry events might appear in the logs but the ones listed here only are relevant.

## Non-channel-specific events

### Assignment and routing

| Subscenarios                       | Description                                           |
|------------------------------------|-------------------------------------------------------|
| ManualAssignment | Representative or supervisor manually assigned the conversation. |
| RouteToQueue | Queue assignment by unified routing. |
| Classification | Work item classification by unified routing. |
| CSRPickedConversation | Representative picked the work item. |
| CopilotAgentAssignedToConversation | A Copilot agent is assigned to the conversation. |
| CSRAssignment | Assignment attempted by unified routing when new work item is added to the queue. It can also include assignment to a representative when they become available. |

### Conversation end

| Subscenario                      | Description                                           |
|------------------------------------|-------------------------------------------------------|
| ConversationClosed | Conversation closed by system. |
| Call Ended | Tracks who ended call and if there were any system issues associated with the call. |
| CSRClosedSession | Representative closed the session with the customer. |
| CSREndedConversation | Representative ended the conversation. |
| BotChatEnd | Messaging conversation ended by Copilot agent. |
| CustomerDisconnected | Customer disconnected from the call or conversation. |
| CustomerEndedConversation | Customer ended the conversation. |
| SupervisorForceClosedConversation | Supervisor forcefully closed the conversation. |

### Transfer and consult

| Subscenario                       | Description                                           |
|------------------------------------|-------------------------------------------------------|
| TransferAssignment | Supervisor or representative transferred the conversation. |
| TransferToQueue | Conversation transferred to a different queue by the representative. |
| SupervisorInitiatedTransfer | Supervisor transferred the conversation to another representative. |
| ConsultToCSRClosed | Representative closed the consultation request for the conversation. |
| ConsultToCSRInitiated | Representative requested consultation with another representative for a conversation. |
| CSRInitiatedTransfer | Representative transferred the conversation to another representative. |
| CSRLeftPublicConsult | Representative left the public consultation for the conversation. |
| CSRInitiatedTransfer | Representative transferred the conversation to another representative. |
| Transfer | Monitors for voice-channel-specific errors that might have affected a transfer. |
| Consult | Tracks if voice consult is successful and if it isn't, logs an error. |
| CONSULT_BYCHAT_REQUESTAGENT | Representative initiates a consult over chat channel. |
| TRANSFER_CSR_REQUEST2COMPLETED | Representative requests a transfer to another representative. |
| TRANSFER_QUEUE_REQUEST2COMPLETED | Representative requests a transfer of conversation to another queue. |
| CONSULT_BYVOICE_REQUESTAGENT | Representative initiates consult over voice channel. |

## Other non-channel specific events

| Subscenario | Description |
|----|----|
| ConversationCreated | Conversation created by system. |
| SESSION_CREATE | Customer is connected with a service representative and session is created for a customer interaction. |
| CopilotAgentEscalationToCSR | AI agent escalated the conversation to a representative. |
| CSRAccepted | Service representative accepts the work item assignment. |
| CSRNotificationTimeout | Representative failed to accept the work item assignment. |
| CSRRejected | Representative rejected the work item assignment. |
| CSRRejoined | Representative rejoined the call or conversation. |
| GET_QUICK_REPLIES | Representative leverages quick reply options for a messaging conversation. |
| FILES_DOWNLOAD | Representative downloads a file during a conversation. |
| AGENT_LOGIN | Representative logs into the system. |
| Banner Codes | Banner code message shown to representative in conversation control that might indicate errors and prevent representative from responding to customer. |
| SentimentDerived | Logs sentiment analysis result for a message. |
| SentimentChanged | Tracks changes in sentiment during a conversation. |
| PRESENCE_FIRST_LOAD | Representative presence initialized. |
| CSRAvailabilityCheck | Check if any service representative is available. |
| CopilotAgentSessionInitialization | Agent is connected to conversation. |

## Assignment snapshot

Assignment snapshot adds transparency to the automatic assignment process in unified routing. By surfacing detailed insights into the logic and criteria behind assignment decisions, assignment snapshot helps supervisors and administrators understand why work items remain unassigned or are assigned to specific representatives. This transparency reduces the need for support tickets and escalations to Microsoft, as customers can remediate and take corrective actions based on the information provided.

Administrators can use the following information that's logged in Application Insights:

- Presence changes

- Unit and profile-based capacity changes
- Skill changes for representatives
- Queue membership changes
- Representative, skill, queue, and capacity profile names with the corresponding IDs
- Assignment ruleset and rule ID matched during the assignment attempt for custom assignment rulesets
- Assignment ruleset and rule details for custom assignment rulesets

### Subscenario: CSRConfiguration

Provides information about the static configuration settings related to service representatives, such as their associated skills, capacity profiles, queues they are part of, default presence, maximum capacity units. This is synced whenever there is a change to any of the configurations and at periodic intervals of 10 days.

- **omnichannel.agent.id**: The ID of the service representative being logged.
- **omnichannel.queue.ids**: The associated queue IDs for the service representative.
- **omnichannel.max_capacity.units**: The maximum capacity units for the service representative.
- **omnichannel.default_presence**: The default presence for the service representative.
    - f523f628-c07a-e811-8162-000d3aa11f50 → Available
    -	efdeb843-c07a-e811-8162-000d3aa11f50 → Busy
    -	08971864-c07a-e811-8162-000d3aa11f50 → Busy - Do Not Disturb (DND)
    -	3dacae76-c07a-e811-8162-000d3aa11f50 → Away
    -	70139190-c07a-e811-8162-000d3aa11f50 → Offline
-	**omnichannel.capacity_profile.ids**: The capacity profile IDs for the service representative.
-	**omnichannel.associated_skills**: The skills for the service representative.

### Subscenario: QueueConfiguration

Is related to the configuration of queues, which includes the queue id, type, priority, and assignment strategy for the queue. The information is synced whenever there is a change to any of these configurations.

- **omnichannel.queue.id**: The ID of the queue.
- **omnichannel.priority**: The priority of the queue.
- **omnichannel.assignment_strategy**: The assignment strategy for the queue. Possible values are:
    - Highest Capacity(OmnichannelAssignment) = 192350000
    - Round Robin = 192350001
    - Custom Assignment Configuration = 192350002
- **omnichannel.queue.name**: Name of the queue.
- **omnichannel.queue.type**: The type of the queue. Possible values are
    - Digital Messaging = 192350000
    - Entity = 192350001
    - Phone Call = 192350002

### Subscenario: AssignmentRuleset

Is for the custom assignment rulesets used for assignment, prioritization, and selection. It includes the ruleset name and rules configured as part of the ruleset. The information is synced whenever there is a change to any of these configurations and at periodic intervals of 10 days.

- **omnichannel.queue.id**: Identifier of the queue the ruleset belongs to.
- **omnichannel.ruleset_name**: The name of the ruleset.
- **omnichannel.rule_hit_policy**: The rule hit policy for the ruleset.
- **omnichannel.rules**: Details for each rule present in the ruleset (rule name, conditions, order).
- **omnichannel.ruleset_type**: The type of the ruleset (assignment/prioritization/selection ruleset).

### Subscenario: CSRStatusandCapacityDetails

Provides status and capacity history of service representatives, including their presence, capacity profile, and available units. The data is synced whenever there is a change to any of these configurations.

- **omnichannel.agent.id**: The ID of the service representative being logged.
- **omnichannel.current_presence_id**: The current presence ID of the service representative.
- **omnichannel.current_base_presence**: The current base presence of the service representative.
- **omnichannel.available_capacity.units**: The available capacity units for the service representative.
- **omnichannel.capacity_profile**: The capacity profile details (capacity profile id, available capacity, capacity profile reset duration, default maximum capacity, is force assignment, is block assignment).

## Channel-specific subscenarios

### Voice

| Subscenario | Description |
|----|----|
| Call Connect | Captures successful connection of a voice call to an agent or representative. |
| Wait for Agent | Wait Time Music is playing while customer is waiting to connect to a representative. |
| Callback | Logs if customer is provide with a callback option and if they accept the callback option. |
| Transcription | Tracks whether transcription started successfully. |
| VOICE_UNMUTE | Representative unmuted from conversation control during voice call. |
| VOICE_MUTE | Representative selected mute button from conversation control during voice channel. |
| VOICE_SEND_DTMF | Customer’s DTMF options are sent to representative. |
| VOICE_SET_SPEAKER | Representative speaker initialized. |
| VOICE_SET_MICROPHONE | Representative microphone initialized. |
| VOICE_SUPERVISOR_BARGE | Supervisor barges into a voice call. |
| VOICE_PAUSE_RECORDING_AND_TRANSCRIPTION | Captures representative pausing of both recording and transcription. |
| VOICE_PAUSE_TRANSCRIPTION | Captures representative pausing of transcription only. |
| VOICE_RESUME_RECORDING_AND_TRANSCRIPTION | Representative resumes recording and transcription. |
| VOICE_RESUME_TRANSCRIPTION | Captures resuming of transcription only. |
| VOICE_HOLDPARTICIPANT | Representative selects hold button to place a customer on hold during a voice call. |
| VOICE_UNHOLDPARTICIPANT | Representative uses the hold button to remove customer from hold. |
| CALLQUALITYSURVEY_SHOWN2DISMISSED | Tracks when a call quality survey is shown to the customer and dismissed. |

### Messaging

| Subscenario | Description |
|----|----|
| ChatReconnection | Logs if a reconnection was attempted for an existing chat session. |
| ChatAuthentication | Tracks if customer authentication fails. |
| MessageProcessed | For async channels, this tracks sending and receiving of message, including buffering delays. |
| TimeoutRuleTriggered | Timeout rule is triggered with information about trigger of timeout rule. |
| PostChatSurvey | Captures sending or starting of a post-chat survey. |

### Live chat

| Subscenario | Description |
|----|----|
| ChatInitialization | Set up of chat widget. |
| ChatConfiguration | Validates details about chat widget configuration (org details). |
| ChatButtonAction | Customer selects chat widget button to open widget. |
| CloseChatAction | Customer closes the chat window. |
| CustomContextReceived | Logs receipt of custom context data for chat. |
| DownloadTranscriptAction | Customer selects download button from widget. |
| EmailTranscriptButtonAction | Customer selects email transcript button from widget. |
| DownloadTranscript | Chat transcript is downloaded by customer. |
| EmailTranscript | Chat transcript is emailed by customer. |
| EndChatEventReceived | Logs when customer selects end chat button on live chat widget. |
| LiveChatWidgetButtonLoading | Tracks loading of the chat icon. |
| LiveChatWidgetStart | Track loading of the live chat widget. |
| MessageReceived | Customer receives a message. |
| MessageSent | Customer sends a message. |
| MinimizeChatAction | Customer minimizes chat window. |
| AuthTokenValidation | Captures successful token validation. |
| OutOfOperatingHours | Logs attempt to start chat outside operating hours. |
| PostChatSurvey | Tracks rendering of post-conversation survey. |
| PrechatSurvey | Tracks rendering of pre-conversation survey. |
| ProactiveChat | Proactive chat initiated. |
| ProactiveChatTimeOut | Logs timeout to accept proactive chat invitation. |
| ChatHistoryMessageReceivedCompleted | Retrieval of chat message history into conversation. |
| SystemMessageReceived | Tracks receipt of system messages. |
| ChatSessionInitialization | Logs when chat session is available for customer to converse. |
| UnrecognizedOrgUrl | Live chat widget contains an invalid org URL. |

## Understand conversation logs

The event log entries and their descriptions of some events in the subscenarios are as follows.

### Common metadata

The following metadata can be a part of the custom dimensions in the **Traces** table.

| Event log       | Description                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| Channel type    | Channel from which work item originated                                     |
| Org.id          | Environment ID                                                              |
| Resource.id     | Conversation ID                                                             |
| Scenario        | Diagnostics scenario, such as conversation diagnostics scenario or representative configuration scenario. |
| Subscenario     | The subscenario, such as classification or route-to-queue.      |
| Duration | The elapsed time between the start and end of the subscenario |
| Workstream ID | The ID of the workstream to which the conversation belongs. |
| Timestamp | The time the subscenario started. |

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

### Subscenario: Call End

- **Omnichannel.description and Omnichannel.messsage**: Captures whether the subscenario started, completed successfully, or failed. If the subscenario failed, error or exception information is provided 

- **Call Status Code**: A code that can be used to learn more details about how/why the call ended. 

- **Conversation stage**: End

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

### Voice, conversation control, live chat, and messaging telemetry subscenarios

- **Subscenarios**:

    - CONSULT_BYCHAT_REQUESTAGENT
    - TRANSFER_AGENT_REQUEST2COMPLETED
    - TRANSFER_QUEUE_REQUEST2COMPLETED
    - CONSULT_BYVOICE_REQUESTAGENT
    - SESSION_CREATE
    - Transfer
    - Consult
    - Call Connect
    - Wait for CSR
    - Callback
    - Transcription
    - VOICE_UNMUTE
    - VOICE_MUTE
    - VOICE_SEND_DTMF
    - VOICE_SET_SPEAKER
    - VOICE_SET_MICROPHONE
    - VOICE_SUPERVISOR_BARGE
    - VOICE_PAUSE_RECORDING_AND_TRANSCRIPTION
    - VOICE_PAUSE_TRANSCRIPTION
    - VOICE_RESUME_RECORDING_AND_TRANSCRIPTION
    - VOICE_RESUME_TRANSCRIPTION
    - VOICE_HOLDPARTICIPANT
    - VOICE_UNHOLDPARTICIPANT
    - CALLQUALITYSURVEY_SHOWN2DISMISSED
    - GET_QUICK_REPLIES
    - FILES_DOWNLOAD
    - AGENT_LOGIN
    - Banner Codes
    - ChatButtonAction
    - CloseChatAction
    - CustomContextReceived
    - DownloadTranscriptAction
    - EmailTranscriptButtonAction
    - EndChatEventReceived
    - LCWChatButtonLoading
    - LiveChatWidgetStart
    - MessageReceived
    - MessageSent
    - MinimizeChatAction
    - PRESENCE_FIRST_LOAD
    - AuthTokenValidation
    - OutOfOperatingHoursPostChatSurvey
    - PrechatSurvey
    - ProactiveChat
    - ProactiveChatTimeOut
    - ChatHistoryMessageReceivedCompleted
    - SystemMessageReceived
    - ChatSessionInitialization
    - UnrecognizedOrgUrl

- **Omnichannel.description and Omnichannel.messsage**: Captures whether the subscenario started, completed successfully, or failed. If the subscenario failed, error or exception information is provided.

- **Conversation stage**: Indicates the stage of the conversation lifecycle that the subscenario relates to. Possible values include: 

    - Initialization
    - Self Service
    - CSR Engagement
    - End

- **Subscenario**:

    - ChatReconnection  

    - ChatAuthentication  
    - BotChatEnd  
    - MessageProcessed  
    - TimeoutRuleTriggered  
    - CopilotAgentSessionInitialization  
    - PostChatSurvey  
    - DownloadTranscript  
    - EmailTranscript  
    - SentimentDerived  
    - SentimentChanged  

- **Omnichannel.description and Omnichannel.messsage**: Captures whether the subscenario started, completed successfully, or failed. If the subscenario failed, error or exception information is provided.

### Related information

[Configure conversation diagnostics](configure-conversation-diagnostics.md)  
[Sample queries and dashboard](/dynamics365/guidance/resources/conversation-diagnostics-sample-queries)  
