The following worked example shows what the report metrics mean in practice. A test was run against a list of three prospects:

- **Prospect 1** received two emails, replied saying they weren't interested, the agent replied, and the conversation escalated.
- **Prospect 2** received one email, replied saying they were interested, the agent replied, and was handed off.
- **Prospect 3** received all three emails with no reply and remains in Outreach. (Eventually the agent moves them to Suspend, but this isn't captured here.)

:::image type="content" source="../../ce/sales/sales-dev-agent/media/campaign-report.png" alt-text="Screenshot of a campaign summary report.":::

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

