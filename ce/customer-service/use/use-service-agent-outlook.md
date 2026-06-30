---
title: Use Service Agent with Outlook
description: Learn how Service Agent reads context from open Outlook emails to help you resolve cases in Dynamics 365 Customer Service.
ms.date: 06/30/2026
author: lalexms
ms.author: laalexan
ms.collection: bap-ai-copilot
ms.topic: how-to
ms.reviewer: laalexan
ms.update-cycle: 180-days
ms.custom: bap-template 
---

# Use Service Agent with Outlook

When you use Service Agent in Outlook, it can use the currently open email thread as context to help you summarize messages, draft replies, answer questions, and recommend next steps. You don't need to copy or paste the email into your prompt.

## Prerequisites

Your administrator must configure Service Agent before you can use it. Learn more in [Enable Service Agent in Microsoft 365 Copilot](../administer/configure-service-agent.md).

## Use Service Agent with an Outlook email thread

1. Open the email thread that you want to work with in Outlook.
1. Open Service Agent.
1. Type a prompt about the current email thread.
1. Review the response and continue the conversation as needed.

**Example prompts**

- *Summarize this email thread.*
- *Draft a reply to the customer based on this thread.*
- *What action should I take next based on this conversation?*

Service Agent uses the current email thread as context when generating its response.

## Considerations

- Service Agent uses the currently open email thread as context when generating responses.
- If no email thread is open, Service Agent can't use Outlook email context.
- Continue the conversation with follow-up prompts to refine or expand the response.

### Related information

- [Use Service Agent](use-service-agent.md)  
- [Reference records and context in Service Agent prompts](reference-records-service-agent.md)  
- [Service Agent overview](service-agent-overview.md)  
