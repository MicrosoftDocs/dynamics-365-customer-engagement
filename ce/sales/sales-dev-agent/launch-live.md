---
title: Launch live outreach with the Sales Development agent (preview)
description: Learn how to launch live outreach with the Sales Development agent in Microsoft Teams to automate sales outreach and prospect management.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Launch live outreach with the Sales Development agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Provide the list of prospects in either of the following ways and ask for the go-live plan:

- As a CSV or an Excel file to the agent
- By connecting the [agent to your CRM system](integrate-with-dynamics.md), in which case the agent can pull the prospect list directly from the CRM.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

After you review and approve the plan, the agent starts working on the prospects and sends outreach emails to them. The agent also informs you of its progress and proactively escalates if it finds any issue.

You can also ask the agent about the status. For example, you can enter the following prompt: *Give me a summary of the leads you've been working on.*

When the agent confirms it's ready to go:

1. Upload your final, approved prospect list.
1. Confirm your playbooks, guidelines, and settings are finalized.
1. Type *Go live*.

What happens when you *go live*?

- The agent starts sending emails following your approved cadence.
- It tracks replies and automatically classifies outcomes.
- It respects all guardrails and unsubscribe rules.
- You get progress updates via Teams messages.

While it's live, the agent provides summary updates in Teams:

- Total prospects contacted.
- Replies received.
- Leads either handed off or escalated.

You can request real-time updates by asking:

- *Show me this week's outreach summary.*
- *Which prospects haven't replied yet?*

> [!NOTE]
> When you go live, the agent starts sending emails immediately. To control which days and hours the agent is allowed to send outreach, use [Configure send time](configure-send-time.md).

## CRM actions during live outreach

After integration, the agent can outreach any new leads created in the CRM environment. The CRM saves every correspondence to and from the agent and prospects, so you can track each prospect's engagement history.

When the agent determines that a prospect is interested based on their email response, it updates the lead status in CRM to **qualified** and assigns the lead to its manager (the agent's creator) for follow-up. When the agent determines that a prospect isn't interested, it updates the lead status in CRM to **disqualified**.

You can tell the agent to stop CRM-based outreach at any time, which prevents it from processing new CRM leads. However, the agent continues working with prospects it already contacted before the stop command was issued.