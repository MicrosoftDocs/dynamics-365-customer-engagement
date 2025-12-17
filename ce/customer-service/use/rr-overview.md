---
title: Overview of real-time analytics for record routing
description: Monitor contact center performance with real-time analytics for record routing. Access dashboards, view KPIs, and analyze summary, queue, agent, and work item reports to improve productivity.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: overview
ms.date: 12/17/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/13/2025
---

# Overview of real-time analytics for record routing

Real-time analytics for record routing helps you monitor and improve your contact center's performance.

**Key capabilities:**
- Monitor real-time performance metrics and KPIs
- Track service representative productivity and workload distribution
- Analyze queue performance and backlog trends
- [Customize the visual display](customize-reports.md#customize-visual-display) of  reports and save personalized views as [bookmarks](manage-bookmarks.md#manage-bookmarks-for-reports)
- Access detailed insights across summary, queue, agent, and work item reports

## Security roles and permissions

Real-time analytics uses the security permissions defined in Microsoft Dataverse. For example, if your organization set business unit-level permissions for you, metrics that are computed based on business unit-level data only are shown to you.

As a supervisor, you can view the **Real-time analytics for record routing** dashboards in the Copilot Service workspace app. However, your administrator must provide the required permissions for you. Learn more in [Configure user access to analytics and dashboards](../administer/configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards). To view the real-time analytics for record-routing dashboards, you must have the CSR Manager role.

> [!NOTE]
> If different values are shown to different users in the metrics, you must investigate the permissions for those users.

## Access reports

In the site map of Copilot Service workspace, select **Real-time analytics for record routing** in **Service**. The **Summary** report appears by default. To switch reports, select the required report from the report filter. 

:::image type="content" source="../media/dashboard-filter-record-routing.png" alt-text="Screenshot of the report filter":::

For example, to view the **Agent** report, select **Agent** from the report filter.

If you can't view the reports, contact your system administrator. Learn more in [Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing).

## Dashboard details 

Dynamics 365 Unified Routing uses work item (conversation) to track case and record routing and assignment. Case and record conversation states can be open, active, or closed. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states). 

For example, a case that gets created automatically creates a conversation in the open state. When such a case gets reassigned, a new conversation gets created, and the old one gets closed while the case remains the same. This way, work item lifecycles can be tracked seamlessly.

**Real-time analytics for record routing** consists of the following reports:

- **Summary**: This report provides an overview of your organization in real time.

- **Queue:** This report provides a case and record work item overview, segmented by queue. This report shows entity record type queues only.

- **Agent**: This report provides an overview of the health and KPIs of service representatives in your organization.

- **Ongoing work items**: This report provides information about cases and records that service representatives are handling, and that are in an active or open state.

- **Backlog work items**: This report lists case and record work item conversations that are modified, including work items created within the time range selected.

- **Intent group**: This report shows contact center data organized by intent, intent groups, and line of business that help you effectively monitor and track work items by record type. 

- **User group**: This report helps you filter data by user group, that help you quickly spot trends, evaluate team performance, and accelerate case resolution.

## Filter information displayed on dashboard 

Use the filters to drill down to KPIs across the dashboard. Adjust the filters based on the insights that you're looking for. The available filters include **Modified on**, **Agent**, **Agent status,** **Agent skill**, **Queue**, **Work item status,** **Work item skill**, and **Time zone**. 

For example, the dropdown list for the **Time** filter includes the following options:

- **2 hrs**: By default, shows all conversations from the last 2 hours. You can see conversations up to last 24 hours.
- **Today**: Shows all conversations started or modified in the selected time zone.

> [!NOTE]
> The queues filter shows entity record type queues only.

:::image type="content" source="../media/realtime-time-filter.png" alt-text="Screenshot of the Time filter on real-time analytics.":::

Optionally, you can also add the **Business Unit** filter that provides a consistent way to focus on a single business unit or compare multiple units. The filter can be configured through data model customization or by adjusting the visual under data measure for the dimension **DimBusinessUnit**. The **Business Unit** filter doesn't grant additional access; it simply restricts data visibility based on existing roles and business unit hierarchy. If a user doesn't have security permissions to view a business unit's data, selecting that business unit won't display any information.

## Autorefresh 

Summary, queue, and agent reports are autorefreshed continuously to allow for real-time analytics trend insights. This autorefresh can be paused and resumed. Ongoing and backlog work item views need to be manually refreshed, which makes it easier to focus on supervisor tasks without disrupting data refreshes.

> [!NOTE]
> For optimum use of real-time analytics for record routing, use [capacity profiles](../administer/capacity-profiles.md#create-and-manage-capacity-profiles). The use of legacy unit-based capacity or mixed capacity management leads to reduced report actionability.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Summary report](rr-summary.md)  
[Queue report](rr-queue.md)  
[Agent report](rr-agent.md)  
[Backlog work items report](rr-backlogitems.md)  
[Ongoing work items report](rr-ongoingworkitems.md)  
[Intent group report (preview)](record-routing-intent-group.md#)  
[User group report (preview)](record-routing-user-group.md)  
