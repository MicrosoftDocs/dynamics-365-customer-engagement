---
title: Use the Sales Development agent with multiple users (preview)
description: Learn how managers and supervisors can collaborate with the Sales Development agent in Microsoft Teams.
ms.date: 09/17/2026
ms.topic: how-to
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Use the Sales Development agent with multiple users (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As a manager, you can give supervisors access to your Sales Development agent and collaborate with them in Microsoft Teams group chats. This article explains role-based access, supported group chat behavior, and how to troubleshoot common issues.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Collaborate with the agent

1. [Grant Supervisor access](#grant-access) to each person.
1. Create or open a Microsoft Teams group chat, and then add the agent and supervisors.
1. [Collaborate with the agent](#collaborate-in-a-group-chat) by @mentioning it or replying to its messages.

## Understand roles and permissions

Each person in the group must have one of the following roles:

| Role | Permissions |
|---|---|
| **Manager** | Chat with the agent, use all its capabilities, grant or revoke Supervisor access, and review who has Supervisor access. |
| **Supervisor** | Chat with the agent and use most of its capabilities. A supervisor can't grant, revoke, or review access for others. |

> [!NOTE]
> People without an assigned role can't interact with the agent. If someone without access joins a group chat, the agent identifies that person and stops responding until the [manager grants them Supervisor access](#grant-access-from-an-access-card) or they leave the group.

The Manager role is assigned when the agent is created and can't be transferred through a chat command. Supervisor is the only role that the manager can grant or revoke.

## Manage supervisor access

Only a manager can grant, revoke, and review supervisor access. The manager must request the agent in their private one-to-one chat with the agent. Access management isn't supported in group chats.

### Grant access

Open a private one-to-one chat with the agent and use a Teams @mention to identify each person. For example:

- `Give @Jane Doe Supervisor access.`
- `Grant @Jane Doe and @Carlos Ruiz the Supervisor role.`

Wait for the agent to confirm the change before the supervisor contacts it.

### Review access

In your private one-to-one chat with the agent, ask `List users with Supervisor access`.

### Revoke access

In your private one-to-one chat with the agent, identify the person whose access you want to revoke. For example, enter `Remove @Carlos Ruiz's Supervisor access.`

After the agent confirms the change, the person can no longer interact with the agent.

## Grant access from an access card

When someone without access tries to interact with the agent in a group chat, you might receive a **Grant Supervisor Access** card in your private one-to-one chat with the agent. Select the button on the card to grant access after the agent confirms that you're the manager.

Keep these behaviors in mind:

- If you have an active conversation with the agent, the card arrives after that session ends.
- If several people need access, the cards arrive one at a time.
- The card might not appear if this capability isn't enabled for your tenant.

To avoid waiting for a card, you can grant access directly in your private one-to-one chat with the agent.

## Collaborate in a group chat

The Sales Development agent supports a Teams group chat with up to 10 people plus the agent. The 10-person limit includes one manager and up to nine supervisors. Everyone in the chat must have either the Manager or Supervisor role for that agent instance.

Only one agent can be in the group chat. If the chat contains multiple agents, the Sales Development agent posts a message that this configuration isn't supported.

To send a request, address the agent by using an @mention or replying to one of its messages. The agent doesn't treat general conversation between participants as a request. For example:

```text
@Sales Development agent Summarize the latest outreach activity.
```

The agent reads the recent conversation for context but stays quiet until someone addresses it directly.

If anyone in the chat doesn't have access, the agent stops responding to the whole chat and identifies who needs access. The manager must grant each person Supervisor access in their private one-to-one chat, or the person without access must leave the group. After resolving the issue, send the agent a new message.

## When the agent is busy

The agent handles one request at a time in each chat and responds to requests in the order they arrive. Responses might take longer when several people message the agent at once or when it's active in many chats.

For more reliable responses:

- Send one clear request at a time.
- Let the agent finish before resending a request.
- If you aren't sure whether the agent received your message, @mention it again.
- When possible, avoid having everyone in the chat message the agent at the same time.

## Troubleshooting

| Issue | Resolution |
|---|---|
| The agent doesn't respond in a group chat. | @mention the agent or reply to one of its messages. Confirm that everyone has Manager or Supervisor access, only one agent is in the chat, and the chat has no more than 10 people. If the agent is finishing earlier requests, wait for it to respond. |
| The agent stopped responding after someone joined. | The new participant might not have access. Grant them Supervisor access or remove them from the group, and then send the agent a new message. The agent doesn't repeat the same access warning, so it might appear unresponsive. |
| The manager can't change access in a group chat. | Open the manager's private one-to-one chat with the agent. Access management works only in that chat. |
| A supervisor can't grant access to someone else. | This behavior is expected. Only the manager can grant, revoke, or review supervisor access. |
| The manager didn't receive an access card. | Open a private one-to-one chat with the agent. If that chat was recently active, wait for the session to end. Cards for multiple people arrive one at a time. The card capability might also be disabled for your tenant. You can grant access directly without waiting for a card. |
| The agent doesn't respond after access is granted. | Send a new message that @mentions the agent or reply to one of its messages. |

