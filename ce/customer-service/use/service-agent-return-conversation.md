---
title: Return to a previous Service Agent conversation
description: Learn how Service Agent restores your previous conversation when you return to a case in Dynamics 365 Customer Service.
ms.date: 06/30/2026
author: lalexms
ms.author: laalexan
ms.collection: bap-ai-copilot
ms.topic: how-to
ms.reviewer: laalexan
ms.update-cycle: 180-days
ms.custom: bap-template 
---

# Return to a previous Service Agent conversation

When you return to a case that you worked on previously, Service Agent automatically restores your most recent Service Agent conversation for that case. This behavior lets you continue where you left off without re-entering context or repeating previous questions.

## How previous conversations are restored

Each time you open Service Agent while a case is active, it checks whether a previous Service Agent conversation exists for that case. 

- If a previous Service Agent conversation exists, Service Agent automatically restores it in the Copilot pane.
- If no previous Service Agent conversation exists for the case, the Copilot pane opens with a new, empty conversation.

The title of the Service Agent conversation in your Copilot chat history includes the case number, making it easy to identify the correct conversation. For example: [CAS-01234] Coffee Machine Repair

## Return to a previous conversation

1. Open Copilot Service workspace and navigate to the case you were previously working on.
1. Open the Copilot pane. If a previous Service Agent conversation exists for the case, Service Agent automatically restores it.
1. Review the previous messages, and then continue the conversation by typing a new prompt.

You don't need to manually locate or reopen the Service Agent conversation. Service Agent restores it automatically when the case becomes active.

## Start a new conversation for a case

If you want to start a new Service Agent conversation instead of continuing the existing one, do the following steps: 

1. Open the Copilot pane while the case is active.
1. Select **New chat** (pencil icon) at the top of the conversation.

Service Agent starts a new conversation for the current case.

> [!NOTE]
> Starting a new conversation doesn't change the active case. The new conversation continues to use the current case as context.

## Considerations

- Service Agent restores only the most recent Service Agent conversation for a case.
- Conversation titles include the case number so you can quickly identify the correct conversation.
- If you open Service Agent without an active case, no previous Service Agent conversation is restored.
  
### Related information

- [Use Service Agent](use-service-agent.md)  
- [Service Agent overview](service-agent-overview.md)  
