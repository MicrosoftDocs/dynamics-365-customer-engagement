---
title: Integrate Case Management Agent with custom Copilot Studio agents
description: Learn how to integrate autonomous Case Management Agent with custom Copilot Studio agents in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 11/06/2026
ms.custom: bap-template
ai-usage: ai-assisted
---

# Integrate Case Management Agent with custom Copilot Studio agents

The Case Management Agent integrates with custom AI agents built in Microsoft Copilot Studio to autonomously handle customer service cases. This integration enables automated case processing, where the Case Management Agent collaborates with a custom agent to resolve customer issues during case conversations, reducing manual effort and improving response times. The integration supports both fully autonomous and semi-autonomous case resolution scenarios, allowing organizations to tailor their case management workflows to meet specific business needs.

## Prerequisites

- [Autonomous case resolution](../administer/set-up-case-resolution-agent.md) is enabled for the Case Management Agent.
- Intent is enabled for the Case Management Agent.
- A custom AI agent is created in Microsoft Copilot Studio and is added to the specific intent in Copilot Service admin center.

## How the integration works

1. For an incoming email linked to a case, Case Management Agent identifies the intent and invokes the custom agent linked to that intent. The custom agent uses the [input contract](#input-contract) to retrieve case details and context from Dataverse.
2. The custom agent returns a message that follows the [output contract](#output-contract). Case Management Agent reads only the last message returned by the custom agent.
3. Based on the custom agent's response, Case Management Agent takes the following actions.

   | Scenario | Custom agent output | Action by Case Management Agent |
   |----------|---------------------|---------------------------------|
   | The custom agent needs more information from the customer. | `Question` | Drafts or sends the question according to the configured automation mode. The message might be rephrased. After the customer responds, invokes the custom agent again with updated case context. |
   | The custom agent provides a resolution message. | `Resolved` | Drafts or sends the message verbatim, without rephrasing it with a language model. The case stays open; any configured follow-up and closure process is separate. |
   | The custom agent can't resolve the issue. | `UnableToResolve` | Might escalate the case to a human queue. |
   | The custom agent completes its task without needing further action. | `NoAction` | Takes no follow-up action and makes no case change. |
   | The custom agent requests case closure. | `ResolveCase` | Sends a message if one is supplied, then closes the case. |
   | The custom agent needs time to complete asynchronous work. | `Wait` | Becomes idle while the custom agent completes the work. The custom agent then calls `msdyn_invokeCaseProcessingAgent` with `customAgentOutput` and a response type other than `Wait`. See [Return an asynchronous custom-agent result](use-case-processing-agent.md#return-an-asynchronous-custom-agent-result). |

For customer interactions, fully autonomous mode sends the email automatically. Semi-autonomous mode creates a draft for a customer service representative to review and send.

Throughout the process, Case Management Agent uses the same conversation ID for interactions with the custom agent for a case (`Conversation.Id`).

## Input contract

Case Management Agent supports both input formats: only `caseId`, or `caseId` with relevant context. When the `CustomAgentInputContractV2` feature switch is off, Case Management Agent sends only `caseId`. When it's on, Case Management Agent includes additional context. Design your agent to accept both input formats and tolerate extra JSON fields.

### Case ID only

Case Management Agent sends the case ID to your custom agent in the following format. Your custom agent uses this ID to retrieve case details and context from Dataverse.

```json
{
  "caseId": "<case-id>"
}
```

After the customer responds to a question, Case Management Agent invokes your custom agent again with the same case ID. Your custom agent retrieves the updated case information from Dataverse and continues its workflow. The [example](#example) shows this interaction.

### Case ID with relevant context

This input includes the same case ID, along with relevant case, source, and intent context. Your custom agent can use the supplied context and retrieve any additional case details it needs from Dataverse.

The following example shows this input format.

```json
{
  "caseId": "2e581856-b213-f111-8342-7c1e525424d8",
  "caseEntityName": "incident",
  "ticketNumber": "CAS-01160-R9D5W0",
  "sourceContext": {
    "entityName": "email",
    "entityId": "ac909a43-b213-f111-8342-7c1e5254ad6e"
  },
  "intentContext": {
    "name": "Password Reset",
    "attributes": [
      {
        "name": "Account Email",
        "answer": "user@contoso.com"
      }
    ]
  },
  "automationLevel": "Full",
  "version": "1.0"
}
```

The following table describes the input fields when additional context is included.

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `caseId` | String (GUID) | Yes | ID of the case. Use it to retrieve case details through Dataverse connectors. |
| `caseEntityName` | String | Yes | Logical name of the case table, typically `incident`. Custom case tables are supported. |
| `ticketNumber` | String | No | Ticket number for a case in the standard case table. Not present for custom case tables. |
| `sourceContext.entityName` | String | No | Logical name of the table that triggered the invocation, typically `email`. |
| `sourceContext.entityId` | String (GUID) | No | ID of the triggering email or other record. |
| `intentContext.name` | String | Yes | Intent identified by the intent engine. |
| `intentContext.attributes` | Array of objects | No | Intent attribute answers collected so far. Each object contains `name` and `answer`. |
| `automationLevel` | String | Yes | Configured automation mode: `Full`, `Semi`, or `Shadow`. |
| `version` | String | Yes | Contract version, currently `"1.0"`. |

## Output contract

Return a JSON object with `responseType` and the optional fields needed for your scenario. The following example includes the optional fields for a third-party or asynchronous response. Omit `customAgentName` and `environmentId` for the standard synchronous integration.

```json
{
  "responseType": "Resolved",
  "message": "<agent output>",
  "handlingOptions": {
    "needsReview": "true"
  },
  "templateId": "<template-guid>",
  "templateGroupId": "<language-group-guid>",
  "customAgentName": "<agent-schema-name>",
  "environmentId": "<environment-id>"
}
```

The following table describes the output fields.

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `responseType` | String | Yes | One of `Resolved`, `Question`, `UnableToResolve`, `ResolveCase`, `Wait`, or `NoAction`. This is the only mandatory output field. |
| `message` | String | No | Message for the customer. For `Resolved`, the message is used verbatim. For `Question`, it might be rephrased. |
| `handlingOptions.needsReview` | String | No | Use `"true"` to require representative review for `Question` or `Resolved`. The supported values are the strings `"true"` and `"false"`. If omitted, the administrator-configured case settings apply. |
| `templateId` | String (GUID) | No | Email template to use instead of the default template. |
| `templateGroupId` | String (GUID) | No | Language-group ID used to select a template that matches the case language code (LCID). Takes precedence over `templateId`. Requires the `CustomAgentEmailTemplateGroupEnabled` feature switch, which is off by default. |
| `customAgentName` | String | No | Agent schema name used to identify the responding agent in the audit trail for third-party or asynchronous responses. Don't set it for the standard synchronous integration. |
| `environmentId` | String | No | For third-party or asynchronous responses, identifies the Power Platform environment that hosts the custom agent. Omit it or use an empty value when the agent is in the same environment. |

> [!IMPORTANT]
> Don't set `handlingOptions` to `null`. Omit it when you don't need to specify review handling.

## Example

In this scenario, the customer requests a refund for a recent order.

1. A customer sends an email linked to caseID 12345 about a refund request.
2. The Case Management Agent processes the email and recognized "refund" as the intent and invokes the custom AI agent with this input:

   ```json
   {
     "caseId": "12345"
   }
   ```

3. The Custom Agent looks up the case details and realizes it needs the refund amount. It responds with:

   ```json
   {
     "responseType": "Question",
     "message": "Could you please confirm the refund amount?"
   }
   ```

4. The Case Management Agent sends an email to the customer to confirm the refund amount.
5. Once the customer responds, the Case Management Agent invokes the custom agent again with the same case ID as input:

   ```json
   {
     "caseId": "12345"
   }
   ```

6. The Custom Agent processes the refund and responds with:

   ```json
   {
     "responseType": "Resolved",
     "message": "Refund has been processed successfully."
   }
   ```

7. The Case Management Agent sends the message verbatim to confirm that the refund is processed. The `Resolved` response leaves the case open. If case follow-up and closure is configured, that process can follow up with the customer and then resolve the case.
