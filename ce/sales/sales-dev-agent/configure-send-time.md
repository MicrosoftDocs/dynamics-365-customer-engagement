---
title: Configure send time for the Sales Development agent (preview)
description: Learn how to configure the send time for the Sales Development agent in Microsoft Teams to optimize sales outreach.
ms.date: 08/21/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Configure send time (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You can define a send window, which specifies days and hours the agent is allowed to send outreach emails, and the agent will follow it.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How it works

When you configure a send window, the agent only sends outreach emails during the specified days and hours. For example, when set to 24/7 Pacific Time, all days are updated to 00:00–23:59.

Keep the following in mind when configuring send time:

- **Default send window**: For tenants where this feature is enabled, the send window defaults to Monday–Friday, 8am–6pm. For agents that were already active when the feature was enabled, the timezone defaults to UTC; the timezone is only set during the hiring flow for newly configured agents. If your agent was pre-existing, explicitly set the timezone to avoid sending at unexpected times.

- **Timezone must be specified**: Timezone is not inferred. It must be specified explicitly. If you say "9am to 3pm" without a timezone, the agent will not make an assumption—you need to say "9am to 3pm PST" (or whichever timezone applies). It will not default to your location or the prospect's location.

- **Holiday blocking is date-specific, not recurring**: Holiday blocking applies to the specific date provided, not the recurring holiday. If you instruct the agent to skip Christmas or the Fourth of July, it blocks that exact date—for example, 2025-12-25. It will not automatically apply the same block in future years. This needs to be re-configured annually.

- **Reporting may appear inconsistent when a send window is active**: For example, if your window is set to Monday–Friday, 9am–3pm PST, and you pull a report on a Sunday, all prospects in your list show as "Outreach" stage even though no emails have been sent yet. The agent is correctly holding sends until the window opens, but this is not reflected in the report. This is a known limitation and not an indication that emails are going out outside your defined window.

- **14-day look-ahead limit**: If no available send window exists within the next 14 days—for example, if all dates in that window are blocked—the email will not be sent. If you are blocking an extended period, ensure there's at least one available slot within the next 14 days to avoid dropping sends.



## Understand follow-up cadence and campaign expiry

Your follow-up cadence determines how many emails are sent and when they are sent. The initial outreach is always sent on day 0. Each cadence interval is cumulative. Every step is based on the actual send date of the previous email, not the original outreach date.

For example, a cadence of `[1, 3, 5]` means:

- 1 day after initial outreach, the first follow-up is sent.
- 3 days after the first follow-up, the second follow-up is sent.
- 5 days after the second follow-up, the final email is sent.

This cadence sends four emails total per prospect: initial outreach, two follow-ups, and a final email.

Keep the following cadence behaviors in mind:

- **Send window impact**: Your configured send window affects when each email is delivered. If a calculated send date falls outside your allowed window, the email is delayed until the next available date and time. The next interval then starts from that actual send date.

- **Final email behavior**: The final email follows the rules defined in the **Final** section of your guidelines configuration (if configured).

- **Three-email cadence**: If you want only one follow-up and one final email (three emails total), use two intervals only, such as `[1, 3]`.

- **Queued follow-ups**: All follow-up emails are queued when the campaign starts. If your cadence generates more emails than intended and the campaign is already running, cancel the campaign after the last intended email sends to prevent sending more emails.

- **Cancel behavior**: Cancelling a campaign stops future pending emails, but it doesn't stop the agent from replying to prospect responses already received.

- **Campaign expiry**: By default, all engagements in a campaign expire seven days after the last scheduled email sends. After expiry, the agent no longer processes incoming prospect replies for that campaign.

