When you configure a send window, the agent only sends outreach emails during the specified days and hours. For example, when set to 24/7 Pacific Time, all days are updated to 00:00–23:59.

Keep the following in mind when configuring send time:

- **Default send window**: For tenants where this feature is enabled, the send window defaults to Monday–Friday, 8am–6pm. For agents that were already active when the feature was enabled, the timezone defaults to UTC; the timezone is only set during the hiring flow for newly configured agents. If your agent was pre-existing, explicitly set the timezone to avoid sending at unexpected times.

- **Timezone must be specified**: Timezone is not inferred. It must be specified explicitly. If you say "9am to 3pm" without a timezone, the agent will not make an assumption—you need to say "9am to 3pm PST" (or whichever timezone applies). It will not default to your location or the prospect's location.

- **Holiday blocking is date-specific, not recurring**: Holiday blocking applies to the specific date provided, not the recurring holiday. If you instruct the agent to skip Christmas or the Fourth of July, it blocks that exact date—for example, 2025-12-25. It will not automatically apply the same block in future years. This needs to be re-configured annually.

- **Reporting may appear inconsistent when a send window is active**: For example, if your window is set to Monday–Friday, 9am–3pm PST, and you pull a report on a Sunday, all prospects in your list show as "Outreach" stage even though no emails have been sent yet. The agent is correctly holding sends until the window opens, but this is not reflected in the report. This is a known limitation and not an indication that emails are going out outside your defined window.

- **14-day look-ahead limit**: If no available send window exists within the next 14 days—for example, if all dates in that window are blocked—the email will not be sent. If you are blocking an extended period, make sure there is at least one available slot within the next 14 days to avoid sends being dropped entirely.

