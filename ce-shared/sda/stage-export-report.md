Use this report when you want to see how prospects are distributed across stages, track activity over time, or pull a list to act on. For example, you might export all escalated leads at the end of the week to hand off to your sales team, or review everyone who unsubscribed to keep your CRM clean.

**Export all stages**

Enter the following prompt to get all stages in CSV file: `Export all stages in CSV`

The above prompt returns a CSV with columns: Email, Transition Date, Stage. It covers all stages: Outreach, Qualification, Handoff, Escalate, Disqualify, Suspend, Unsubscribe, Unresponsive, and Redirect.

**Export a specific stage**

Enter the following prompt to get all [stage name] leads in CSV file: `Export all [stage name] leads to CSV`

Examples:

- `Export all escalated leads to CSV`
- `Export all unsubscribed leads to CSV`
- `Export all handoff leads to CSV`

The above prompts return a CSV filtered to only prospects in that stage.

:::image type="content" source="../../ce/sales/sales-dev-agent/media/stage-report-1.png" alt-text="Screenshot of the prompt to export all escalated leads to CSV.":::

:::image type="content" source="../../ce/sales/sales-dev-agent/media/stage-report-2.png" alt-text="Screenshot of the prompt to export all unsubscribed prospects to CSV.":::

