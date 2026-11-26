---
title: Test the Sales Development agent in chat (preview)
description: Learn how to test the Sales Development agent in chat.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Test the Sales Development agent in chat (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Chat with the agent in a Teams chat to test the agent, give feedback, and approve the behavior in a low-risk environment. Provide learning materials so that the agent can learn from them.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

During testing you can provide feedback to the agent through chat messages. For example, ask the agent about what makes a good initial outreach email. After the agent replies, provide feedback about the tone, length of the email, and so on.

To further test the agent, you can do the following:

- [If you integrated the agent with your CRM](integrate-with-dynamics.md), tell the agent to run simulations with CRM leads. For example, you can say "Run a simulation with 10 leads from CRM and show me the outreach emails you'd send." The agent runs the simulation and shares the generated outreach emails in chat for your review.
- Provide a list of prospects as a CSV or Excel file to the agent and ask it to generate outreach emails for those prospects in chat. For example, you can say "Here's a list of prospects in this file. Generate outreach emails for them." The agent generates sample outreach emails for each prospect and shares them in chat for your review.

When you're confident that the agent is ready to work on real prospects, proceed to the next step.

## Upload your prospect list

Provide your prospect list to the agent for validation. The list can be a CSV or Excel file with one row per contact and column headers included. The required fields are:

| Field | Description |
|-------|-------------|
| Email | Prospect's email address. |
| Company Name | The organization the prospect works for. |
| Product | What you're promoting (especially important if you're using the same agent to cover multiple product lines or campaigns). |
| First name | For personalization. |

If there are file issues, the agent tells you what's missing:

- "No column named 'company name' found—please add before continuing."
- "This file is empty or unreadable." (the agent might not have permissions)
- "Some rows are missing key details. 92 out of 100 prospects are ready. I'll skip the remaining eight missing email or product data."

The agent handles issues such as:

- Rows missing critical fields are skipped (you can observe which ones).
- Malformed data, like invalid email formats, are ignored.

## Run a test

Once your list is validated, the agent begins generating test email content in Teams chat:

- Creates sample outreach emails using your configuration.
- Applies your tone and guidelines.
- Provides each draft in Teams for review.

For example, a generated test email references the company, highlights the value proposition, and ends with a clear call to action—aligning with the structure of a well-performing outreach sequence.

> [!NOTE]
> Test emails shown in chat have unsubscribe links. The links in chat are placeholders and don't function. When emails are sent to customers, the unsubscribe placeholders are replaced with functional unsubscribe links.

## Role-play real-world scenarios

To verify performance, test real-world cases:

- **Pricing questions**: "How much does this cost?". The agent should acknowledge the question and either provide high-level pricing guidance (if configured) or escalate to a human for detailed quotes, respecting your guardrails.
- **Competitive comparisons**: "How are you better than [competitor]?". The agent should highlight your differentiators without disparaging competitors, staying factual and focused on value.
- **Lack of interest**: "I'm not interested right now." The agent should acknowledge the response, offer to reconnect at a better time, and mark the conversation appropriately.

When testing is complete, type *I'm done with testing*.

When you type this phrase, the agent prepares for live outreach.

> [!NOTE]
> The agent doesn't automatically detect when testing is complete. You need to tell it.