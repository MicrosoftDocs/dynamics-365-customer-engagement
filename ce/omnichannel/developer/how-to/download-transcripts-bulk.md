---
title: "Download Omnichannel for Customer Service transcripts in bulk | Microsoft Docs"
description: "Read how you can send display custom context on the UI"
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 08/13/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Download Omnichannel for Customer Service transcripts in bulk

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service transcripts are stored in base64 encoded format in Annotation table in Common Data Service. Attachments are stored as separate records in the Annotations table. If a conversation has 2 files exchanged between the agent and the customer, a total of 3 records are created pertaining to this conversation. Any conversation always has n+1 records stored for it in the annotations table, where n is the number of attachments this conversation has. Attachments are also base64 encoded before being saved.

Use the following Web API requests to retrieve all the transcripts and attachments exchanged in the past one month.

The Web API request given below will retrieve all the textual transcripts. 

```
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_transcript'
```
The Web API request given below will retrieve all the file attachment annotations.

```
GET [Organization URI]/api/data/v9.1/annotations?$filter=objecttypecode eq 'msdyn_ocliveworkitem'
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




### See also

[Omnichannel for Customer Service for developers](../omnichannel-developer.md)