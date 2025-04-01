---
title: Use Omnichannel connector macros
description: Learn about using Omnichannel connector to create macros.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 12/04/2024
ms.custom: bap-template 
---

# Use Omnichannel connector macros

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

You can use Omnichannel connector to use actions to perform Omnichannel for Customer Service&ndash;related operations. Omnichannel connector macros allow you to link and unlink records to conversations.

You can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service.

> [!NOTE]
> Macro actions for the Omnichannel connector is available if Customer Service workspace in Omnichannel for Customer Service is installed.

   :::image type="content" source="../media/macro-omnichannel-connector.png" alt-text="Macro actions Omnichannel connector.":::

## Link record to the conversation

Links a record to the conversation in the focused session when the agent is communicating with a customer in omnichannel. This action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity Logical Name |  Specify the logical name of the entity. |
   | Entity record ID| Specify the entity record ID of the entity.| 
   | Entity primary Name | Specify the primary name of the entity.| 

> [!NOTE]
> If you switch to a different conversation while the macro is running, you may see unexpected results.

### Example: Create a case from conversations

Perform the following steps to create a case from an Omnichannel conversation. The macro creates a case and then links it to the current conversation. Add the following actions:
1. **Open a new form to create a record** 
1. **Save the record**
1. **Link record to the conversation** with the following attributes:
     - **Entity record ID**: `Entity record ID`
     - **Entity primary name**: `Entity primary name` 
     - **Entity logical name**: `Entity logical name`
 
## Unlink record from the conversation

Unlinks a record from the conversation in the focused session when the agent is communicating with a customer in omnichannel. This action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity Logical Name |  Specify the logical name of the entity. |
   | Entity record ID| Specify the entity record ID of the entity. | 
   | Entity primary Name | Specify the primary name of the entity.| 

> [!NOTE]
> If you switch to a different conversation while the macro is running, you may see unexpected results.

### Example: Unlink the case from the conversation

Perform the following tasks to create a macro that unlinks a case from a conversation. This macro considers the variables present in the session context.
Add the **Unlink record from the conversation** action with the following attributes: 
  - **Entity record ID**: `${caseId}`
  - **Entity primary name**: `${caseTitle}`
  - **Entity logical name**: `incident`

#### Send knowledge base article link in chat

Sends a knowledge base article link to the conversation chat window. It must be used with the **Search knowledge base for the populated phrase** action. Make sure that you switch the **Use an external portal** toggle to **Yes**. More information: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management)

## Next steps

[Flow connector](macro-flow-connector.md)  