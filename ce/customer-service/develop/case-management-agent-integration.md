---
title: Integrate Case Management Agent with custom AI agents (preview)
description: Learn how to set up autonomous Case Management Agent to help customer support teams efficiently handle case management tasks.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 05/26/2025
ms.custom: bap-template
---

# Integrate Case Management Agent with custom AI agents (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Case Management Agent can invoke the custom AI agents built in Microsoft Copilot Studio to handle customer service cases autonomously. This integration enables automated case processing where the CPA interacts with a custom agent to resolve customer issues through case conversations, reducing manual intervention and improving response times.
The integration supports both fully autonomous and semi-autonomous case resolution scenarios, allowing organizations to customize their case management workflow based on business requirements.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- Autonomous case resolution is enabled for the Case Management Agent.
- Intent is enabled for the Case Management Agent.
- A custom AI agent is created in Microsoft Copilot Studio and is added to the specific intent in Copilot Service admin center.

## How the integration works

1. For an incoming email linked to a case, the case resolution feature of the Case Management Agent identifies the intent of the email and if there's a custom AI agent linked to the intent, invokes the custom AI agent. The Case Management Agent sends a request to the custom agent as follows. The message includes the case ID, which Copilot Studio custom agent uses to retrieve the case details and context from the Dataverse.
       ```json
        {
         "caseId": "<case-id>"
        } 
        ```
1. The custom agent responds with the required details in the following format:

```json
{
   "responseType": "Question / Resolved / UnableToResolve / NoAction / ResolveCase",
   "message": "<agent output>", // optional
   "handlingOptions":  {
       “needsReview”: true / false, // only to be used along with customer interaction states - Question / Resolved
     } // optional
        }
```
1. Based on the response of the custom agent, the Case Management Agent does the following actions:

| **Scenario**                                        | **Custom Agent Output** | **Action by Case Management Agent**       |
| --------------------------------------------------- | ----------------------- | -------------------- |
| Custom agent requires more information from the customer| Question            | <ol> Based on the workflow configured, the following actions occur: <ul><li> For a fully-autonomous case resolution workflow, the AI agent drafts and sends and email with the required information to the customer.</li><li> For a semi-autonomous case resolution workflow, the AI agent drafts the email with the required information. Customer service representative sends the email to the customer.</li></ul><li>Once the customer responds, the AI agent sends the information to the custom AI agent.</li>|
| Custom agent resolves and sends output              | Resolved                | <ol> Based on the workflow configured, the following actions occur: <ul><li> For a fully-autonomous case resolution workflow, the AI agent drafts and sends the resolution email to the customer.</li><li> For a semi-autonomous case resolution workflow, the AI agent drafts the resolution email. Customer service representative sends the email to the customer.</li></ul><li>The AI agent triggers case follow-up and closure, if configured.</li>|
| Custom agent cannot resolve                         | UnableToResolve         | The AI agent escalates the case to a service representative.|
| Custom agent completes task, no Case Management Agent action required | NoAction                | No further action    |
| Custom agent requests automatic case closure        | ResolveCase             | The AI agent closes the case.     |


Throughout the process, the `conversationID` is maintained to preserve context across multiple Case Management Agent and custom AI agent interactions for the same case.

## Example

In this scenario, the customer is requesting a refund for a recent order. 

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
5. Once the customer responds, the Case Management Agent invokes the custom agent again with the same case ID. The Custom Agent processes the refund and responds with:
   ```json
   {
     "responseType": "Resolved",
     "message": "Refund has been processed successfully."
   }
   ```
7. The Case Management Agent updates the case as resolved and sends an email to the customer that their refund is processed.