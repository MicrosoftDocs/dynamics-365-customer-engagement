---
title: Configure conversation diagnostics
description: Learn about how to query and retrieve conversation diagnostics from Application Insights.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.date: 02/24/2025
ms.custom: bap-template
---

# Configure conversation diagnostics

Conversation diagnostics logs each of the conversation lifecycle events, giving you a greater visibility into conversations-based operational telemetry of your organization.  This helps your support team to proactively monitor the system and allows developers to easily identify, diagnose, and fix problematic conversations, or seek swift support.

Connect your Dynamics 365 Customer Service environment to an Azure Application Insights instance to collect and store conversation logs. For more information about Application Insights features and how they can be used to monitor your telemetry and diagnose failures, see [Application Insights Overview dashboard](/azure/azure-monitor/app/overview-dashboard) and [Diagnose failures using the Azure portal](/azure/azure-monitor/app/asp-net-exceptions#diagnose-failures-using-the-azure-portal).

You can then use the conversation lifecycle events data from Customer Service in Application Insights to monitor system health, export, and combine it with additional data sets to build custom dashboards for your business needs.

> [!NOTE]
> - Export of Power Automate and Dynamics 365 Customer Service data is not available in sovereign clouds, such as Government Community Cloud (GCC), Government Community Cloud - High (GCC High), and Department of Defense (DoD).
> - The feature is available in managed environments only.

## Prerequisites

- The user must have access level Contributor or higher on Azure Services to set up, and minimum Reader to query data in Application Insights.

- The user must be a Power Platform administrator or System Administrator.
- The environment is a managed environment.

## Pricing

The conversation diagnostics data is stored in Azure Application Insights database. Azure Application Insights is an extension of Azure Monitor and charges for data ingested. The two log ingestion plans are Basic and Analytic logs. Learn more about the pricing for your business requirements at [Azure Monitor pricing](https://azure.microsoft.com/pricing/details/monitor/#pricing).

The following table lists the analysis of the average data consumption in Application Insights
 
| Data Consumption                                                                 | Size in kilobytes (average<sup>**1**</sup>) |
|----------------------------------------------------------------------------------|------------------------------|
| Per routed work item (Call/Conversation/Record) with one classification, one route-to-queue (RTQ) ruleset and one assignment ruleset 7  |
| Per ruleset with a single rule in it                                             | 2                            |
| Per new rule in a ruleset                                                        | 1                            |
 
<sup>**1**</sup> The average values can vary based on factors, like the number of rules, conditions defined within a ruleset, and size of the conditions (number of characters).
 
Let's take an example in which each routing stage has a single ruleset with a couple of rules and moderately complex rule conditions. If you route 500 work items per day, it consumes approximately 4.88 MB of data. Learn about routing stages in [Understand routing stages](unified-routing-diagnostics.md#understand-routing-stages-and-diagnostics).

## Set up a connection with Azure Application Insights

Before you perform a data export, create a connection between your Customer Service instance and Azure Application Insights in Power Platform admin center. You can create only one data export configuration from Customer Service to Application Insights per environment. Learn more at [How to enable data export](/power-platform/admin/conversation-diagnostics-application-insights#set-up-a-connection-with-azure-application-insights).

## Access and use the conversation information in Application Insights

After you've configured the data export setup, conversation lifecycle information for live chat, digital messaging, voice, and custom channel conversations is available in the Application Insights **Traces** table.

To view the logs for a conversation, as a user with minimum reader level, perform the following steps:
1.	Sign into [Azure portal](https://ms.portal.azure.com/) and access your Application Insights instance. Make sure that it's the same instance that you used to set up data export.
1.	Select **Logs** in **Monitoring**.
1.	Use the following sample query in the editor.

    Traces
    | extend customDim = parse_json(customDimensions)
    | extend workItem = tostring(customDim["powerplatform.analytics.resource.id"])
    | extend subscenario = tostring(customDim["powerplatform.analytics.subscenario"])
    | where workItem == "Insert conversation ID of work item"
    // | where subscenario contains "Classification"
    | project timestamp, workItem, subscenario, customDim

1.	The **Results** tab displays the query results. 

## Understand conversation diagnostics

When the system routes a work item, its corresponding data starts appearing in Application Insights within 15 minutes. The conversation diagnostics data is presented in the form of scenario and subscenarios, as discussed in the following sections.

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
| AgentTransfer                   | Representative transferred the conversation to another agent   |
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

### Common metadata

The following metadata can be a part of the custom dimensions in the **Traces** table.

| Event log       | Description                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| Channel type    | Channel from which work item originated                                     |
| Org.id          | Environment ID                                                              |
| Resource.id     | Conversation ID                                                             |
| Scenario        | Diagnostics scenario, such as conversation diagnostics scenario or agent configuration scenario |
| Subscenario     | The subscenario, such as classification or route-to-queue        |

### Subscenarios metadata

The event log entries and their descriptions of some events in the subscenarios are as follows.

**Subscenario**: Classification

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

**Subscenario**: Route-to-queue

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
    - RequiredCapacityUnits: Required agent capacity in units for the work item
    - AllowedPresences: Allowed agent presences for the work item
    - CapacityProfiles: Required agent capacity profiles for the work item
    - RequiredSkills: Skills required from agent to work on the work item

## Conversation scenarios

The **Traces** table contains data about the following conversation scenarios.

- **Category**: Conversation initiation 
  - **Scenario**: Conversation is initialized 
  - **Scenario**: Customer identified

- **Category**: Virtual agent interaction
  - **Scenario**: Virtual agent assigned
  - **Scenario**: Conversation ended by virtual assistant
  - **Scenario**: Virtual assistant escalation to human agent from virtual agent

- **Category**:  Routing
  - **Scenario**: Demand Classification
  - **Scenario**: Queue assignment

- **Category**:  Human agent interaction
  - **Scenario**: Agent accepted
  - **Scenario**: Agent rejected
  - **Scenario**: Acceptance request timed out
  - **Scenario**: Agent rejoined
  - **Scenario**: Agent self-assignment

- **Category**: Conversation completion
  - **Scenario**: Conversation ended by customer
  - **Scenario**: Conversation ended by agent
  - **Scenario**: Agent session closed
  - **Scenario**: Conversation abandoned by customer/customer disconnect
  - **Scenario**: Conversation force close by supervisor
  - **Scenario**: Conversation closed

**Subscenario**: AgentAccept

- **Omnichannel.description**: Captures the information when representative accepts the conversation:
    - **Success**:
        1. Agent with ID xxxx assigned to the Conversation xxxx. AgentAccept request completed.
        1. Agent with id xxxx already assigned to the Conversation xxxx. AgentAccept request completed.
    - **Failure**:
        1. Agent with id xxxx not found in the session xxxx for Conversation xxxx. AgentAccept request failed.
        1. **Scenario**: AgentAccept for Conversation: xxxx failed with exception: xxxx.
- **Omnichannel.target_agent.id**: Captures the ID of the representative who accepts the conversation.
- **Channel type**: Channel from which work item originated.

**Subscenario**: SupervisorForceCloseConversation

- **Omnichannel.description**: Captures the information when supervisor attempts to forcefully close the conversation:
    - **Success**: 
        1. **Scenario**: SupervisorForceCloseConversation for Conversation: {Conversation ID} completed successfully.
    - **Failure**: 
        1. SupervisorForceClose request didn't get processed as the state is already closed for Conversation xxxx
        2. **Scenario**: SupervisorForceCloseConversation for Conversation: xxxx failed with exception: xxxx
- **omnichannel.initiator_agent.id**: The ID of the supervisor initiating the action.
- **Channel type**: Channel from which work item originated.

**Subscenario**: CustomerEndConversation

- **Omnichannel.description**: Captures the information when customer ends the conversation.
    - Success: 
      Scenario: CustomerEndConversation for Conversation: {Conversation ID} completed successfully.
    - Failure: 
      1. Customer EndConversation request failed for ConversationId: xxxx as conversation state doesn't support the operation. Conversation state: xxxx
      1. Customer EndConversation request failed for ConversationId: xxxx as the conversation is already in closed state
      1. Scenario: CustomerEndConversation for Conversation: xxxx failed with exception: xxxx
- **Channel type**: Channel from which work item originated.

**Subscenario**: QueueTransfer

- **Omnichannel.description**: Captures the information when agent attempts to transfer the conversation to another queue.
    - **Success**: 
      Scenario: QueueTransfer for Conversation: {Conversation ID} completed successfully for Target Queue: xxxx with QueueId: xxxx.
    - **Failure**: 
      Scenario: QueueTransfer for Conversation: xxxx failed with exception: xxxx
- omnichannel.initiator_agent.id: The ID of the agent initiating the transfer.
- **Channel type**: Channel from which work item originated.

**Subscenario**: InitiateAgentConsult

- **Omnichannel.description**: Captures the information about representative initiating consult request for the conversation.
    - **Success**: 
      Scenario: InitiateAgentConsult for Conversation: {Conversation ID} completed successfully for ConsultType: xxxx under ConversationAccess: xxxx
    - **Failure**: 
      Scenario: AgentTransfer for Conversation: xxxx failed with exception: xxxx
- omnichannel.initiator_agent.id:	Captures the ID of the agent initiating the consult request
- Omnichannel.target_agent.id: Captures the ID of the agent receiving the consult request
- **Channel type**:	Channel from which work item originated.

**Subscenario**: AgentReject/AgentTimeout/AgentRejoined/AgentPickAssignment/BotEscalationToHuman/AgentEndConversation/AgentCloseSession/ConversationClose/BotAssignedToConversation/AgentTransfer/SupervisorTransferToAgent/CloseConsult/LeavePublicAgentConsult

- **Omnichannel.description**: Captures the information when the representative or supervisor takes an action on the conversation.
    - Success: {Subscenario} for Conversation: {Conversation ID} completed successfully.
      Example: AgentReject for Conversation: XXXX completed successfully.
    - Failure: {Subscenario} for Conversation: {Conversation ID} failed with exception: {scenarioException.Message}
      Example: AgentCloseSession for Conversation: XXXX failed with exception: Too many requests.
- Omnichannel.initiator_agent.id:	Captures the ID of the agent initiating the action (As applicable)
- Omnichannel.target_agent.id:	Captures the ID of the agent receiving the action (As applicable)
- **Channel type**:	Channel from which work item originated




### Conversation scenarios metadata

The conversation scenarios in the **Traces** table contains has the following metadata.

-	Org ID
- LiveWorkItem ID
-	Channel Type
-	Scenario Status (Started/Failed/Completed)
-	Timestamp
-	Duration (for completed scenarios)
-	Participant Type (human agent or virtual agent)
-	Active Directory User ID (where applicable)

## Understand conversation logs metadata

A description of the attributes displayed in Application Insights is as follows:

- **Timestamp \[UTC\]**: The date and time at which the event is logged. 
- **Message**: Indicates the scenario status the conversation lifecycle event. This can be Started, Failed, or Completed.
    -   **Started**: Indicates that the conversation scenario started.
    -   **Completed**: Indicates that the conversation scenario was successfully completed.
    -   **Failed**: Indicates that the conversation scenario failed.
- **customDimensions**: Contains the following metadata required for detailed debugging:
    - **organizationId**: The unique identifier of the organization.
    - **LiveWorkItemID**: The unique identifier of the conversation to which the message must be sent to.
    - **Channel Type**: Indicates the channel through which the customer is sending messages.
    - **Duration**: The time taken for the scenario to complete.
    - **Participant Type**: Indicates if the conversation is assigned to a human agent or a bot.
- **Operation\_name**: Indicates the conversation lifecycle event.
- **Operation\_id**: The unique identifier of the root operation. This is the transaction ID of the conversation from Dynamics 365 Customer Service.
- **Operation\_parentid**: The conversation ID of the conversation.
- **Session\_id**: The instance of the user's interaction with the app.
- **User\_id**: Represents the user of the application. This field is populated with the Active Directory user ID whenever the scenario includes human agents or bots. For all other scenarios, 0 is displayed.
- **Severitylevel**: The trace severity level. This is set to 0.
- **itemType**: The table that the record was retrieved from. This is always set to Trace.

For example, in a scenario where a live chat conversation is assigned to a queue, the Traces table displays the following metadata:

-   The **ScenarioStarted** message, with the **Operation\_name**, QueueAssignment, and the timestamp at which the scenario started.
-   The **ScenarioCompleted** message, with the duration the application took for the scenario to be successfully completed as the scenario is a success, and the conversation is assigned to a queue.  
      
    ![The metadata when a live chat conversation is assigned to a queue.](../media/live-chat-assigned-to-queue.png)

## Access conversation logs

Do the steps in [Access conversation logs from Application Insights](/power-platform/admin/conversation-diagnostics-application-insights#access-conversation-logs-from-application-insights) to view the logs for a conversation.

## Unified routing scenarios

The following scenarios are covered that start from when a work item is created to how it's routed to a queue and agent.

| Business question                                                                          | Category               |
|--------------------------------------------------------------------------------------------|------------------------|
| How are skills identified for the call?                                                    | Classification         |
| How is case priority identified?                                                           | Classification         |
| Why is case or call routed to a particular queue?                                          | Route to queue         |
| Why is conversation routed to fallback queue?                                              | Fallback queue routing |
| Why is the call transferred to voicemail instead of being added to the queue?              | Pre-queue Overflow     |
| Did the customer close the conversation?                                                   | Customer Actions       |
| Why is the call assigned to Agent A?                                                       | Assignment             |
| Has any agent accepted or rejected the call assignment?                                    | Agent actions          |
| Virtual agent interactions                                                                 | Bot Interactions       |
| Is supervisor able to clear backlog conversations?                                         | Supervisor actions     |
| What skills are predicted by intelligent skill finder?                                     | AI   




