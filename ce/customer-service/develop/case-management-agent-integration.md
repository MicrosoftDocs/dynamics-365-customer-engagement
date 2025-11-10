---
title: Integrate Case Management Agent with custom Copilot Studio agents
description: Learn how to integrate autonomous Case Management Agent with custom Copilot Studio agents.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 08/08/2025
ms.custom: bap-template
---

# Integrate Case Management Agent with custom Copilot Studio agents

The Case Management Agent integrates with custom AI agents built in Microsoft Copilot Studio to autonomously handle customer service cases. This integration enables automated case processing, where the Case Management Agent collaborates with a custom agent to resolve customer issues during case conversations, reducing manual effort and improving response times. The integration supports both fully autonomous and semi-autonomous case resolution scenarios, allowing organizations to tailor their case management workflows to meet specific business needs.

## Prerequisites

- [Autonomous case resolution](../administer/set-up-case-resolution-agent.md) is enabled for the Case Management Agent.
- Intent is enabled for the Case Management Agent.
- A custom AI agent is created in Microsoft Copilot Studio and is added to the specific intent in Copilot Service admin center.

## How the integration works

1. For an incoming email linked to a case, the case resolution feature of the Case Management Agent identifies the intent of the email and if there's a custom AI agent linked to the intent, invokes the custom AI agent. The Case Management Agent sends a request to the custom agent as follows. The message includes the case ID that the Copilot Studio custom agent uses to retrieve the case details and context from Dataverse.

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
        "needsReview": "true" / "false", // only to be used along with customer interaction states - Question / Resolved
      } // optional
      }
     ```

1. Based on the response of the custom agent, the Case Management Agent does the following actions:

   | **Scenario**                                        | **Custom Agent Output** | **Action by Case Management Agent**       |
   | --------------------------------------------------- | ----------------------- | -------------------- |
   | Custom agent requires more information from the customer| Question            | <ol><li> The custom AI agent sends a message to the Case Management Agent. Based on the case resolution workflow configured, the following actions occur: <ul><li> For a fully-autonomous case resolution workflow, the AI agent drafts and sends and email with the required information to the customer.</li><li> For a semi-autonomous case resolution workflow, the AI agent drafts the email with the required information. Customer service representative sends the email to the customer.</li></ul></li><li>Once the customer responds, the Case Management Agent invokes custom AI agent with the payload of caseId guid as specified in the [How the integration works](#how-the-integration-works) section. The Custom AI agent has the missing information in the form of updated case information and continues the workflow execution.</li></ol>|
   | Custom agent resolves and sends output              | Resolved                | <ol><li> The custom AI agent sends a response with the output to the Case Management Agent. Based on the case resolution workflow configured, the following actions occur: <ul><li> For a fully-autonomous case resolution workflow, the AI agent drafts and sends the resolution email to the customer.</li><li> For a semi-autonomous case resolution workflow, the AI agent drafts the resolution email. Customer service representative sends the email to the customer.</li></ul></li><li>The AI agent triggers case follow-up and closure, if configured.</li></ol>|
   | Custom agent cannot resolve                         | UnableToResolve         | The AI agent escalates the case to a service representative.|
   | Custom agent completes task, no Case Management Agent action required | NoAction                | No further action    |
   | Custom agent requests automatic case closure        | ResolveCase             | The custom AI agent sends a message in the output. Case Management Agent sends an email to customer and then resolves the case.    |


Throughout the process, the `conversationID` is maintained to preserve context across all the Case Management Agent and custom AI agent interactions for the same case.

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
1. The Case Management Agent sends an email to the customer to confirm the refund amount.
1. Once the customer responds, the Case Management Agent invokes the custom agent again with the same case ID  as input:
       ```json
        {
         "caseId": "12345"
        }
       ```
1.  The Custom Agent processes the refund and responds with:
      ```json
      {
     "responseType": "Resolved",
     "message": "Refund has been processed successfully."
     }
    ```
1. The Case Management Agent sends an email to the customer that their refund is processed. If case follow-up and closure is configured, the Case Management Agent follows up with the customer and then resolve the case.