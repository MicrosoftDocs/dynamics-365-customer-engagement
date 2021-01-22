---
title: "Download Omnichannel for Customer Service transcripts in bulk | Microsoft Docs"
description: "Read how you can send display custom context on the UI"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/20/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Download Omnichannel for Customer Service transcripts in bulk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service transcripts are stored in base64 encoded format in Annotation table in Microsoft Dataverse. Attachments are stored as separate records in the Annotations table. If a conversation has 2 files exchanged between the agent and the customer, a total of 3 records are created pertaining to this conversation. Any conversation always has n+1 records stored for it in the annotations table, where n is the number of attachments this conversation has. Attachments are also base64 encoded before being saved.

Use the following Web API requests to retrieve all the transcripts and attachments exchanged in the past one month.

The Web API request given below will retrieve all the textual transcripts. 

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_transcript'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```
The Web API request given below will retrieve all the file attachment annotations.

```http
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_ocliveworkitem'
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

The response obtained from each of the above Web API requests contains an attribute called `documentBody` which contains the base64 encoded transcript or attachment.

You can call the above APIs using C# code and then iterate over each of the returned records, access the `documentBody` attribute and process it to get the whole transcripts.

## Structure of the JSON transcript

The transcripts you see in the above link can contain different kinds of messages:
-	Control Messages
-	System Messages
-	Text message (for example, Hi, Hello, How are you, etc)
-	File Attachment metadata

On each of these times of messages you can see a `createdDateTime` field which denotes the exact time at which this message was posted/created.

A control message is of no visual value and indicates an event like Agent joined or left conversation. It usually has a flag called `isControlMessage` set to `true`.

A System message is a special kind of message that is shown to the customer regarding events during the conversations. For example, when an agent joins, when an agent disconnects and when a new agent joins.

Text messages exchanged during the chat between agent and customer appear as shown below.

As seen from above, messages sent by the customer have a display name of either ‘customer’ in case of an unidentified customer or their actual name if they are known to Omnichannel for Customer Service.

For the message that is sent by an agent to a customer, there are tags denoting that it is a “public” message sent by the agent. If the tags contain “private”, then its an internal message exchanged between 2 agents and are not exposed to the customer.

A `FileAttachment` message looks like this in the JSON.

It usually has metadata related to the attachment(s) exchanged during the Chat. The highlighted `annotationid` is the key to the base64 encoded record in Annotations table for that file attachment. You can retrieve that record using this Web API request.

```http
GET [Organization URI]/api/data/v9.1/annotations(<annotationid>)
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0  
```

The above Web API request will give you the base64 encoded Attachment which you can decode and use the way you want.

### See also

[Omnichannel for Customer Service for developers](developer/omnichannel-developer.md)
