---
title: Approve or reject time-off requests
description: Use the Service Agent to approve or reject a representatives time-off request directly in chat.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: parasnigam
ms.author: parasnigam
ms.reviewer: laalexan
---

# Approve or reject time-off requests

Use this capability when you're a supervisor and need to decide a worker's time-off request without leaving the conversation.

## What it does

The assistant approves or rejects a single time-off request. Identify the request you want to decide - by its ID, by its name, or by the agent and the date - and say whether you're approving or rejecting it. When you reject a request, you also provide a short reason that is saved on the request. If your description matches more than one pending request, the assistant lists the matches so you can choose.

The assistant records who reviewed the request and when, alongside your decision.

## Try prompts like

- "Approve time-off request 0a1b2c3d-1111-2222-3333-444455556666"
- "Approve the time-off request 'Time off on 1/1/2027'"
- "Approve agent1's time off for 08/02/2026"
- "Approve this time-off request"
- "Reject time-off request 0a1b2c3d-1111-2222-3333-444455556666, staffing is too low"
- "Reject Jordan's time-off request for next Monday - we don't have enough coverage that week"
- "Decline this request - the team is already short-staffed"

## What you see in chat

The assistant confirms the decision in text: whether the request was approved or rejected, that you were recorded as the reviewer, and the reason you gave when rejecting. There's no separate panel - the result is a short written confirmation.

## Helpful tips

- Point to the request by its ID, its name, or the agent and the date. If several pending requests match, the assistant lists them so you can pick the right one.
- When rejecting, always include a reason. The system requires this reason and saves it on the request for the worker to see.
- Approving and rejecting are decisions a supervisor makes. You need reviewer permission on the request.
- If someone else already decided the same request, the assistant tells you and doesn't overwrite their decision.
- You can only decide time-off requests here. The assistant declines other request types.

> [!TIP]
> Keep your rejection reason short and specific, such as "team is short-staffed that week." The worker sees this note.

## What happens next

After the decision is recorded, you can continue with prompts like:

- "Decide the next time-off request"
- "Reject the other request, same reason"
- "Show this worker's other requests"

## Does this change data?

**Yes, deciding a time-off request changes data.**

Approving or rejecting writes the decision, the reviewer, and the review time to the request. Rejecting also saves your reason. The assistant makes this change when you ask it to approve or reject.
