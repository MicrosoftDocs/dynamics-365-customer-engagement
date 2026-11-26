---
title: Get reports from the Sales Development agent (preview)
description: Learn how to get reports from the Sales Development agent in Microsoft Teams.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Get reports from the Sales Development agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Because the Sales Development agent uses natural language, it doesn't have a fixed reporting menu. You type what you want to know, and the agent figures it out. The prompts in this section are starting points, not the only options. The key is knowing which report type to use depending on the question you're trying to answer.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## When to use which report

| I want to... | Use this |
|---|---|
| See how a campaign is performing overall | Campaign summary report |
| Investigate what happened with a specific prospect | Individual prospect report |
| See who is in a specific stage, or pull a list to act on | Stage export |

## Campaign summary report

Use this report when you want to measure overall campaign performance, such as how many emails went out, how many prospects replied, and where people ended up. This report provides a top-level health check for a specific prospect list.

Enter the following prompt to get a campaign summary report: `Show me a summary report of the outreach activity for [filename].xlsx`

> [!NOTE]
> Use the exact filename you gave to the agent for outreach. Copy the filename from the agent's confirmation message to avoid mismatches.

:::image type="content" source="media/campaign-report-file.png" alt-text="Screenshot of a campaign summary report file.":::

### How to read the numbers

The following worked example shows what the report metrics mean in practice. A test was run against a list of three prospects:

- **Prospect 1** received two emails, replied saying they're not interested, the agent replied, and the conversation escalated.
- **Prospect 2** received one email, replied saying they're interested, the agent replied, and was handed off.
- **Prospect 3** received all three emails with no reply and remains in Outreach. (Eventually the agent moves them to Suspend, but this action isn't captured here.)

:::image type="content" source="media/campaign-report.png" alt-text="Screenshot of a campaign summary report.":::

Here's how to read the report metrics:

| Metric | Value in example | What it means |
|---|---|---|
| Total Leads | 3 (100%) | Unique prospects in the CSV. Duplicates are excluded. |
| Total Emails Sent | 8 (100%) | Every email the agent sent: initial outreach, follow-ups, and replies to prospect responses. 6 outreach emails + 2 agent replies = 8. |
| Total Emails Received | 2 (100%) | All inbound emails the agent received from prospects. |
| Incoming Emails Processed | 2 (100%) | Inbound emails the agent read and acted on. Should always match **Total Emails Received**. |
| Initial Outreach Scheduled | 0 (0%) | Initial emails queued but not yet sent. Zero means all initial emails have already gone out. |
| Initial Outreach Sent | 3 (100%) | Initial outreach emails delivered. All three prospects got their first email. |
| C2 Replies Sent | 2 (100%) | Replies sent by the agent in response to a prospect who wrote back. Two prospects replied, so the agent replied to both. |
| Follow-ups Scheduled | 0 (0%) | Follow-up emails currently in the queue, not yet sent. Zero means nothing is pending. |
| Follow-ups Sent | 3 (100%) | Follow-up emails delivered. Prospect 1 got one follow-up; Prospect 3 got two. That's three total. |
| Lead Response Rate | 2 (66.67%) | Number and percentage of unique prospects who replied to at least one email. Two out of three prospects replied. 2/3 = 66.67%. |
| Email Response Rate | 2 (25%) | Number and percentage of all emails sent that got a reply. Two replies out of eight total emails. 2/8 = 25%. |
| Escalate | 1 (33.33%) | Prospects currently in the Escalate stage. One out of three prospects. 1/3 = 33.33%. |
| Handoff | 1 (33.33%) | Prospects currently in the Handoff stage. One out of three prospects. 1/3 = 33.33%. |
| Outreach | 1 (33.33%) | Prospects still in the Outreach stage with no reply and no outcome yet. One out of three prospects. 1/3 = 33.33%. Eventually moved to Suspend if they never reply. |

## Individual prospect report

Use this report when something looks off with a specific prospect and you want to dig in. For example, a prospect moved to an unexpected stage, you want to verify what emails were sent and when, or a prospect reached out to you directly and you need context before responding.

Enter the following prompt to get an individual prospect report: `Can you give me a summary related to [name] email [email address] in the campaign performance of [filename].xlsx`

The preceding prompt returns the research that the agent ran on the prospect and their company, all emails sent and their outcomes, current stage, any stage transitions, and a current situation summary.

> [!NOTE]
> Use the exact filename you gave to the agent for outreach. Copy the filename from the agent's confirmation message to avoid mismatches.

## Stage export report

Use this report when you want to see how prospects are distributed across stages, track activity over time, or pull a list to act on. For example, you might export all escalated leads at the end of the week to hand off to your sales team, or review everyone who unsubscribed to keep your CRM clean.

**Export all stages**

Enter the following prompt to get all stages in a CSV file: `Export all stages in CSV`

The preceding prompt returns a CSV with the columns Email, Transition Date, and Stage. It covers all stages: Outreach, Qualification, Handoff, Escalate, Disqualify, Suspend, Unsubscribe, Unresponsive, and Redirect.

**Export a specific stage**

Enter the following prompt to get all [stage name] leads in a CSV file: `Export all [stage name] leads to CSV`

Examples:

- `Export all escalated leads to CSV`
- `Export all unsubscribed leads to CSV`
- `Export all handoff leads to CSV`

The preceding prompts return a CSV filtered to only prospects in that stage.

:::image type="content" source="media/stage-report-1.png" alt-text="Screenshot of the prompt to export all escalated leads to CSV.":::

:::image type="content" source="media/stage-report-2.png" alt-text="Screenshot of the prompt to export all unsubscribed prospects to CSV.":::

## Report on prospect status with CSV export

As a sales manager, you often need to review and reconcile large volumes of prospect data for compliance, reporting, and performance tracking. The CSV export feature makes this task easier by allowing you to extract, analyze, and share prospect records in a structured format.

When you request prospect lists in terminal stages, the Sales Development agent offers a CSV export instead of showing a large result set in chat.

Supported terminal stages:

- Handoff
- Escalate
- Disqualify
- Suspend
- Unsubscribe
- Unresponsive

**How it works**:

- Each CSV file contains prospects from one stage only.
- The file includes key fields such as prospect email and the timestamp when the prospect entered that stage.
- The agent provides the CSV as a downloadable file.

**This helps managers**:

- Reconcile records with consent systems in bulk
- Analyze trends by campaign or segment
- Share data quickly with internal teams

**Example queries**:

- "Get me unsubscribed prospects this month in CSV file"
- "Give me all opt outs"
- "Export all escalated leads to CSV"

:::image type="content" source="media/prospect-export-csv.png" alt-text="Screenshot of Sales Development agent providing a CSV export option for terminal-stage prospects":::