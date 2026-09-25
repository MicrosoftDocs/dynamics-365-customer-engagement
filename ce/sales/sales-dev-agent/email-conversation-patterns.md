---
title: Sales Development agent email conversation patterns (preview)
description: Learn about the email conversation patterns of the Sales Development agent.
ms.date: 08/21/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Sales Development agent email conversation patterns (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Sales Development agent keeps email conversations going by tracking the thread context instead of just looking at the original recipient address. This model means Sales Development agent can keep a sales conversation going even when prospects forward emails, add teammates, or have colleagues reply for them.

This behavior matters in real buying cycles, where multiple stakeholders join one thread at different times. Sales Development agent keeps track of participant context, spots qualified interest, and sends handoff messages to the right people.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Conversation continuity model

Prospect engagement often shifts from a one-to-one exchange to multi-party coordination. In practice, prospects might forward messages internally, add colleagues to replies, or let someone else respond directly.

Sales Development agent keeps continuity by following the email thread. If thread markers stay in place, Sales Development agent treats the new message as part of the same conversation, even when the sender changes from the original prospect to another contact.

## Contact identity and name personalization

Sales Development agent picks how to address contacts based on the message type and available identity signals.

| Email type | Name source |
|---|---|
| Initial outreach | Prospect record from CRM or uploaded file (CSV or Excel) |
| Follow-up email | Same stored prospect record used for outreach |
| Reply email | Incoming message content, including signature, to identify who actually wrote the reply |

This approach makes sure Sales Development agent addresses the current responder correctly, including cases where the responder wasn't the original prospect in the system.

## Engagement pattern concepts

### Forward-to-colleague response with original prospect retained

In this pattern, the original prospect forwards the Sales Development agent's message internally. A colleague then replies to the Sales Development agent and keeps the original prospect copied.

The Sales Development agent recognizes the reply as part of the original thread, preserves participants already in the loop, detects qualified interest (for example, a request to schedule a call), and initiates handoff by adding the seller to the **To** line. The resulting handoff reaches the colleague who replied, the original prospect, and the seller.

### Prospect reply with colleague added in CC

In this pattern, the original prospect replies directly to the Sales Development agent and adds a colleague in CC while expressing interest.

The Sales Development agent treats this as the same ongoing conversation, preserves the added colleague in CC, and performs handoff when intent is qualified. The response is addressed to the replying prospect, includes the seller for handoff, and keeps the added colleague in the loop.

### Original prospect out of loop after colleague direct reply

In this pattern, the original prospect forwards internally, and the colleague replies directly to the Sales Development agent without including the original prospect.

The Sales Development agent still recognizes thread continuity but respects current recipient scope. It identifies the replying colleague's name from the incoming message (including signature), addresses that person directly, and sends handoff only to active participants in the reply. The original prospect remains out of the loop unless reintroduced in-thread.

## Handoff behavior and current limitations

The Sales Development agent processes each incoming message as it arrives. This design supports fast response, but it doesn't wait for internal side discussions to complete before replying.

Two practical limitations follow from that design:

- **Immediate response in multi-party replies**: If a prospect adds a colleague and asks that colleague a question, the Sales Development agent responds right away when qualified interest is detected, rather than waiting for the colleague's input.
- **Finality after handoff and escalation**: Once the Sales Development agent hands off to a seller, it exits the thread. Later replies in that thread are handled by the seller, and the Sales Development agent doesn't re-enter the conversation.

These boundaries keep ownership clear after qualification while preserving rapid response behavior during automated engagement.