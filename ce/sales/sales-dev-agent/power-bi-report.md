---
title: Create a Power BI report for the Sales Development agent
description: Learn how to connect Power BI Desktop to Sales Development agent reporting data and create a custom report.
ms.date: 09/25/2026
ms.topic: how-to
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Create a Power BI report for the Sales Development agent

Extend the Sales Development agent's built-in reporting with the deeper analysis and flexibility of Power BI. Use the same prospect and engagement data that powers the agent's performance dashboard to create custom reports, combine agent insights with your business data, and build dashboards tailored to your organization's needs.

To get started, ask your agent for its OData reporting endpoint, connect to it from Power BI Desktop, and sign in with the work account assigned as the agent manager.

## Prerequisites

Before you begin, make sure that:

- You're the manager of the Sales Development agent.
- The agent is fully provisioned and has started processing prospects.
- Power BI Desktop is installed.
- You can sign in to Power BI with the work account assigned as the agent manager.

> [!IMPORTANT]
> Reporting data can include prospect names, email addresses, companies, and engagement activity. Store and share reports according to your organization's data-handling policies.

## Get the reporting endpoint

In your conversation with the agent, ask:

> What is the Power BI reporting endpoint for this agent?

You can also ask:

- What is the OData endpoint?
- How do I connect Power BI to this agent?

The agent responds with a message similar to the following example:

```text
Here is your Power BI OData endpoint: <url>
In Power BI Desktop, go to Get Data > OData Feed, paste this URL, and sign in with your work account.
```

Copy the complete URL. The endpoint is specific to the agent and its region. Don't change the host or any of the identifiers in the URL.

## Connect Power BI Desktop to the endpoint

1. Open **Power BI Desktop**.
1. On the **Home** ribbon, select **Get data**.
1. Search for and select **OData Feed**, and then select **Connect**.
1. Select **Basic**.
1. In **URL**, paste the complete reporting endpoint URL that the agent provided.
1. Select **OK**.
1. When Power BI prompts you to specify how to connect, select **Organizational account**.
1. Select **Sign in**, and then sign in with the work account assigned as the agent manager.
1. If Power BI prompts you to set a privacy level, select **Organizational**.
1. Select **Connect**.

For more information about the connector, see [Power Query OData Feed connector](/power-query/connectors/odata-feed).

## Select the reporting data

In the **Navigator** window, select one or both of the following tables:

| Table | Data |
| --- | --- |
| `prospects` | All prospects in the pipeline, including prospects that are queued, active, failed, canceled, or on hold. |
| `engagements` | Active and completed engagement details, including stages, email activity, stage transitions, company information, and recent activity. |

Then, select one of the following options:

- **Load**: Add the data directly to the report.
- **Transform Data**: Review columns, change data types, remove columns, or filter rows before loading the data. Use this option if you want to prepare the data for your report.

If you load both tables, use the `EngagementId` column to create a relationship between them. The `EngagementId` value is blank until the agent begins processing a prospect and creates an engagement.

## Understand the reporting data

The following tables describe commonly used fields. A field can be blank if its source data isn't available or the engagement hasn't reached the relevant stage.

### Prospect fields

| Field | Description |
| --- | --- |
| `ProspectId` | Unique identifier for the prospect record. |
| `EngagementId` | Identifier for the related engagement. The value is blank while the prospect is queued. |
| `ProspectName` | Prospect's display name. |
| `ProspectEmail` | Prospect's email address. |
| `ProspectTitle` | Prospect's job title. |
| `CompanyName` | Prospect's company. |
| `CohortName` | Source cohort or uploaded file. |
| `Status` | Prospect status: `Queued`, `Active`, `Failed`, `Cancelled`, or `OnHold`. |
| `Stage` | Current engagement stage, if an engagement exists. |
| `CreatedOn` | Date and time when the prospect entered the pipeline. |
| `LastActivityOn` | Date and time of the most recent engagement activity. |

### Engagement fields

| Field | Description |
| --- | --- |
| `EngagementId` | Unique identifier for the engagement record. |
| `Stage` | Current engagement stage. |
| `StageStatus` | Current stage status. |
| `ProspectName`, `ProspectEmail` | Prospect's name and email address. |
| `CompanyName`, `CompanyIndustry` | Company name and industry. |
| `ProductRecommendation` | Product used to personalize outreach. |
| `CohortName` | Source cohort or uploaded file. |
| `DetectedLocale` | Locale detected for the prospect. |
| `EmailsSentCount` | Number of emails that the agent sent. |
| `ScheduledEmailsCount` | Number of emails prepared but not yet sent. |
| `EmailsReceivedCount` | Number of genuine prospect replies. |
| `UndeliverableCount` | Number of delivery failures or bounced emails. |
| `AutoReplyCount` | Number of automatic replies, such as out-of-office messages. |
| `LastStageReason` | Reason for the most recent stage transition. |
| `CreatedOn`, `ModifiedOn` | Creation and last-modified dates and times. |

## Build a starter report

Use the following visuals as a starting point for your report.

### Pipeline status

Create a column or bar chart with:

- **Axis:** `prospects[Status]`
- **Values:** Count of `prospects[ProspectId]`

This chart shows the number of prospects that are queued, active, failed, canceled, or on hold.

### Engagements by stage

Create a column or funnel chart with:

- **Category:** `engagements[Stage]`
- **Values:** Count of `engagements[EngagementId]`

### Email activity

Create a card visual for each of the following values:

- Sum of `engagements[EmailsSentCount]`
- Sum of `engagements[EmailsReceivedCount]`
- Sum of `engagements[ScheduledEmailsCount]`
- Sum of `engagements[UndeliverableCount]`

### Recent engagement activity

Create a table with the following fields:

- `ProspectName`
- `CompanyName`
- `Stage`
- `StageStatus`
- `LastStageReason`
- `EmailsSentCount`
- `EmailsReceivedCount`
- `ModifiedOn`

Sort the table by `ModifiedOn` in descending order.

### Date and cohort filters

Add slicers for the following fields:

- `CreatedOn`
- `ModifiedOn`
- `CohortName`
- `CompanyIndustry`
- `DetectedLocale`

## Refresh the report data

In Power BI Desktop, select **Refresh** to retrieve the latest reporting data. If Power BI prompts you to sign in again, use the work account assigned as the agent manager.

The endpoint returns data in pages. Power BI follows the paging links automatically, so you don't need to create page URLs.

## Troubleshoot connection and data issues

### The agent says that the endpoint isn't configured for the region

The reporting endpoint isn't available in the agent's current region. Contact your administrator and provide the exact message returned by the agent.

### The agent says that its identity isn't available

Ask for the endpoint in your conversation with the specific Sales Development agent that you want to report on. If the message continues to appear, start a new conversation with that agent and try again.

### Power BI says that the URL isn't a valid OData service

- Copy a new URL from the agent.
- Paste only the URL, without the surrounding sentence, quotation marks, or punctuation.
- Use the service-root URL returned by the agent. Don't remove or replace any of its three identifiers.
- Confirm that the URL starts with `https://`.

### Power BI repeatedly prompts you to sign in

1. In Power BI Desktop, go to **File** > **Options and settings** > **Data source settings**.
1. Select **Global permissions**.
1. Select the reporting endpoint or its regional host.
1. Select **Clear Permissions**.
1. Connect again, and then select **Organizational account**.

For more information, see [Troubleshoot OData sign-in errors in Power BI Desktop](/power-bi/connect-data/desktop-troubleshoot-odata).

### Access is denied or the connection returns a forbidden error

The signed-in account must match the manager configured for the agent.

- Confirm that Power BI is signed in with the correct work account.
- If Power BI used a different account, clear the saved permissions and reconnect.
- If the agent manager recently changed, confirm that the agent configuration is updated before you try again.

### The endpoint returns a page-not-found error

- Request a new endpoint URL from the agent, and then try again.
- Confirm that you copied the complete URL.
- If the new URL also fails, the reporting feature might not be enabled for the agent's environment. Contact your administrator.

### Power BI connects, but no tables appear

Use the root endpoint exactly as returned by the agent. If you add `/engagements`, `/prospects`, or other text to the URL, the **Navigator** window might not display both tables.

### The tables are empty

The connection can succeed before the agent has reporting data. Try the following actions:

- Confirm that prospects are added to the agent.
- Check whether the prospects are still waiting to be processed.
- Refresh the report after the agent starts outreach.
- Remove Power Query filters that might exclude all rows.

### A queued prospect has no engagement ID

This behavior is expected. The `EngagementId` value remains blank until the agent begins processing the prospect and creates an engagement.

### Refresh fails after the agent manager changes

Clear the saved data-source permissions, and then reconnect by using the new manager's organizational account. Power BI Desktop doesn't automatically replace its stored credentials.

## Contact your administrator

When you contact your administrator, provide:

- The exact error message.
- The point at which the failure occurs: when you request the URL, sign in, load the **Navigator** window, or refresh the data.
- The date and approximate time of the failure.
- The agent name.

Don't include access tokens, passwords, or exported prospect data.
