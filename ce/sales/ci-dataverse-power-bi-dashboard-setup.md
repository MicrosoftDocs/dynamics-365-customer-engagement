---
title: Set up Power BI dashboard for Conversation intelligence data stored in Dataverse
description: Learn how to connect the Copilot for Sales Power BI dashboard to your Dataverse environment, configure the semantic model, and validate your Conversation Intelligence analytics.
ms.date: 09/29/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
---

# Set up Power BI dashboard for Conversation intelligence data stored in Dataverse

If your organization's Conversation intelligence data is stored in Dataverse, you can use the **Microsoft Copilot for Sales - Dashboard (preview)** Power BI template app to view coaching opportunities, customer insights, and conversation recordings. This article describes how to connect the dashboard to your Dataverse environment, configure and refresh the semantic model, and validate that the data appears correctly.

The dashboard provides the following analytics report pages:

| Report page | Purpose |
|---|---|
| Coaching opportunities | Conversation trends, analyzed duration, coaching KPIs, brands, and seller vocabulary |
| Customer insights | Overall sentiment, sentiment over time, and customer conversation content |
| Conversation recordings | Activity trends and conversation-level drill-down with connected records |

> [!NOTE]
> The Power BI dashboard shows processed, customer-facing conversations. Internal employee-only conversations aren't included.
>
> System Monitoring from the legacy Sales Conversation Intelligence experience isn't available in this dashboard. System Monitoring reports upload and processing telemetry; the Dataverse dashboard is limited to coaching, customer insights, and conversation drill-down over data already processed into Dataverse.

## Prerequisites

- Power BI access and the licenses required by your organization to install and view Power BI apps.
- An organizational Dataverse account with read access to the required Conversation intelligence data.
- The target Dataverse environment URL.
- Permission to configure semantic-model parameters, credentials, refresh schedules, and app audiences.

## Set up the dashboard

### Step 1: Install or open the template app

Install **Microsoft Copilot for Sales - Dashboard (preview)** from Microsoft Marketplace. If the app is already installed, open the workspace that was created during installation.

Depending on the installation state, Power BI might display sample data and a **Connect your data** option. Installation creates two related Power BI artifacts: the visual **Report** and its underlying **Semantic model**. Power BI can assign the same display name to both; use the **Type** column in the workspace to distinguish them.

Select **Connect your data** in the notification banner to begin configuration. A refresh failure at this stage is expected until you provide valid parameters and credentials.

:::image type="content" source="media/power-bi-connect-your-data.png" alt-text="Screenshot of the Microsoft Copilot for Sales - Dashboard showing the Connect your data option.":::

### Step 2: Open semantic model settings

In the Power BI workspace, locate **Microsoft Copilot for Sales - Dashboard (preview)** whose **Type** is **Semantic model**. Open its ellipsis (**...**) menu and select **Settings**.

### Step 3: Configure parameters

Configure the semantic model to reference your Dataverse environment.

| Parameter | Required value | Notes |
|---|---|---|
| EnvironmentPath | Your Dataverse hostname, for example `yourorg.crm.dynamics.com` | Don't include `https://` or a trailing slash. |
| CRM type | Dynamics | Keep this value set to **Dynamics**. |

Select **Next** during initial setup or **Apply** when updating existing semantic-model settings.

> [!NOTE]
> Enable automatic daily refresh only when required by your organization's refresh policy.

### Step 4: Configure data-source credentials

1. In the semantic model settings, open **Data source credentials** and select **Edit credentials**.

1. Confirm that the Dataverse path shown matches your environment.

1. Set the **Authentication method** to **OAuth2** and the privacy level to **Organizational**.

1. Select **Sign in and connect** and authenticate with an organizational account that has read access to the required Conversation intelligence data.

### Step 5: Refresh the semantic model

After you configure the connection, return to the workspace and select **Refresh now** for the semantic model. When the refresh finishes, confirm that the latest entry in **Refresh history** shows success.

Reopen the report and verify that the **Data updated** date and available date range reflect your Dataverse organization.

To keep the report current, configure a scheduled refresh in the semantic model settings under **Refresh** according to your organization's reporting policy. Review the time zone setting before saving the schedule.

:::image type="content" source="media/refresh-semantic-models.png" alt-text="Screenshot of the Power BI semantic models page showing the Refresh settings.":::

## Validate the dashboard

After a successful refresh, confirm the following items:

- The available date range reflects the target Dataverse organization.
- **Coaching opportunities** shows trends, analyzed duration, KPIs, and seller vocabulary.
- **Customer insights** shows sentiment and customer conversation content.
- **Conversation recordings** shows activity trends and conversation-level records.
- Connected-record links open the intended Dataverse organization.
- Slicers for Date, Team, Seller, Activity type, Connected record, Stage, Campaign, Tag, and Call category all work correctly.
- Intended users have Power BI access and, where connected records are used, the required Dataverse access.

## Deployment verification checklist

Before handing off to end users, verify the following items:

- [ ] Correct Dataverse hostname is configured without a URL scheme or trailing slash.
- [ ] CRM type is set to **Dynamics**.
- [ ] Data-source credential test succeeds.
- [ ] Semantic model refresh completes successfully.
- [ ] **Data updated** date and report date range are current.
- [ ] All three report pages display expected data.
- [ ] Intended users have Power BI access and any required Dataverse access for connected records.
- [ ] Administrators understand the dashboard's data availability boundary and that System Monitoring isn't included.

## Troubleshoot common issues

| Issue | Recommended action |
|---|---|
| Repeated credential prompts | Confirm that **EnvironmentPath** contains only the Dataverse hostname (no `https://` or trailing slash). Save the parameter, and then enter the credentials again. |
| Report is empty or date shows 12/31/1969 | Confirm that processed, customer-facing conversations are available in the target organization, and then refresh the semantic model. Contact support if the issue persists. |
| Users or conversations are missing | Clear report filters and confirm that the data-source account has the required Dataverse read access. Contact the organization's administrator if data remains unavailable. |
| Report still shows the old environment | Confirm the semantic model parameter, authenticate the new data source, complete a full refresh, and then reopen the report. |


## Related information

- [Set up conversation intelligence in Sales Hub app](fre-setup-ci-sales-app.md)
- [Manage Conversation Intelligence data retention in Dataverse](ci-dataverse-data-retention-deletion.md)
- [Data retention and deletion through Privacy (Sales Hub app)](data-retention-deletion-policy-sales-app.md)
- [Conversation intelligence FAQs](faq-conversation-intelligence.md)

