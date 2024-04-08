---
title: Omnichannel connector
description: Learn about using SOmnichannel connector to create macros
author: gandhamm
ms.author: mgandham
ms.topic: conceptual 
ms.collection: 
ms.date: 04/08/2024
ms.custom: bap-template 
---

# Omnichannel connector

You can use omnichannel connector to use actions to perform Omnichannel for Customer Service&ndash;related operations.  Omnichannel connector macros allow you to link and unlink records to conversations.

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service.

> [!NOTE]
> Macro actions for the Omnichannel connector is available if Customer Service workspace in Omnichannel for Customer Service is installed.

   :::image type="content" source="../media/macro-omnichannel-connector.png" alt-text="Macro actions Omnichannel connector.":::

## Link record to the conversation

This action links a record to the conversation when the customer is communicating with the agent in the Omnichannel for Customer Service session. This action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to link. <br> This is a mandatory field. |
   | Entity record id| Specify the entity record ID of the entity that you want to link. <br>This is a mandatory field.| 
   | Entity primary Name | Specify the primary name of the entity that you want to link. <br>This is a mandatory field.| 


### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Create a case from a Omnichannel conversation. | The following example is a macro to create a case and then link the case to the current conversation.| <ol><li> New step: Open a new form to create a record</li> <li>Save the record</li><li> New step: Link record to the conversation with the following attributes: <ul><li>Entity record ID: `Entity record ID`</li><li>Entity primary name: `Entity primary name` </li></li>Entity logical name: `Entity logical name`</li></ul></li></ol> |
 
## Unlink record from the conversation

This action unlinks a record from the conversation when the customer is communicating with the agent in the Omnichannel for Customer Service session. This action contains the following fields.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to unlink. <br> This is a mandatory field. |
   | Entity record id| Specify the entity record ID of the entity that you want to unlink. <br>This is a mandatory field.| 
   | Entity primary Name | Specify the primary name of the entity that you want to unlink. <br>This is a mandatory field.| 

### Examples

 | Scenarios | Description | Attribute|
   |-----------------|-----------------------------|---------------------------------|
   | Unlinks the case from the Omnichannel conversation. | The following example is a macro to unlink a case from an Omnichannel conversation. This macro is considering the following variables present in the session context.| <ol><li> New step: Unlink record from the conversation with the following attributes: <ul><li>Entity record ID: `${caseId}`</li><li>Entity primary name: `${caseTitle}` </li></li>Entity logical name: `incident`</li></ul></li></ul> |

#### Send knowledge base article link in chat

This action sends a knowledge base article link to the conversation chat window. It must be used with the **Search knowledge base for the populated phrase** action. Make sure that your admin has switched the **Use an external portal** toggle to **Yes**. More information: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management)

The action contains the following field.

   | Field | Description | 
   |-----------------|-----------------------------|
   | Entity record ID  | Specify the ID of the entity record. <br> This is a mandatory field. |





## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
