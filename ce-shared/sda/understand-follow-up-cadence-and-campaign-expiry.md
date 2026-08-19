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

- **Queued follow-ups**: All follow-up emails are queued when the campaign starts. If your cadence generates more emails than intended and the campaign is already running, cancel the campaign after the last intended email sends to prevent additional emails.

- **Cancel behavior**: Cancelling a campaign stops future pending emails, but it doesn't stop the agent from replying to prospect responses already received.

- **Campaign expiry**: By default, all engagements in a campaign expire seven days after the last scheduled email sends. After expiry, the agent no longer processes incoming prospect replies for that campaign.

