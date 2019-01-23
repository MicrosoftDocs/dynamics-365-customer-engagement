---
title: Set up record identification rule for work streams
description: See how you can set up record identification rules for work streams in the Omni-channel Engagement Hub
keywords: set up record identification rules for work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 6da7ee5c-9e34-4f01-920c-6c381d2f4157
ms.custom: 
---

# Set up record identification rule

Record identification rules help agents identify and assist customers better by showing their details on the **Customer summary** page. When an incoming conversation request is received, a notification appears that includes contextual information for the request. When an agent accepts the incoming notification, the **Customer summary** page opens, and shows the details of the customer and case. 

For more information, see [View Customer summary for an incoming engagement request](../agent/agent-csh/csh-view-customer-360-incoming-conversation-request.md).

> [!NOTE]
> In this preview, the record identification rules are pre-configured in the work streams out-of-the-box. The rules are further mapped to a limited set of pre-chat survey questions. As a customer completes a pre-chat survey for an incoming conversation, the information can be used to identify the customer. 
    
For the pre-configured record identification rules to work, you **must** create the following questions for the pre-chat survey.

For information about how to create questions and use them in a pre-chat survey, see [Create a question library](create-question-library.md) and [Configure a pre-chat survey](configure-pre-chat-survey.md). 

**Authenticated chat**

|Question name  |Answer type  |Question text |
|---------|---------|---------|
|CaseNumber    |     Multiple lines    |  Case Number         |
|    |         |         |

**Unauthenticated chat**

|Question name   |Answer type |Question text  |
|---------|---------|---------|
|CaseNumber     |    Multiple lines     |  Case Number        |
|Name      | Single line         |   Name       |
|Email      |    Single line      |  Email        |
|Phone      |  Single line       |   Phone      |
|    |         |         |

            

            
> [!NOTE]
> Make sure that each question name is unique, and that it's used "as is" in the preceding code snippet. Otherwise, the record identification rule won't work. You can provide question text that meets your requirements.

### See also

[Create and manage work streams](work-streams.md)
