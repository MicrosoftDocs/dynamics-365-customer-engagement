---
title: Overview of real-time analytics for record routing
description: Learn how to configure and use real-time analytics for record routing to enhance agent performance and customer support.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.date: 02/10/2025
ms.custom: bap-template
---

# Overview of real-time analytics for record routing

Real-time analytics for record routing provides supervisors with critical insights into the health and key performance indicators (KPIs) of their contact centers. These analytics enable supervisors to monitor and optimize customer service representative (service representative or representative) performance and customer interactions across multiple channels. As a supervisor, you can customize and save personalized views, and efficiently manage operational metrics, service representative allocation, and ongoing cases to maintain high-service levels and customer satisfaction.

## Security roles and permissions

Real-time analytics uses the security permissions defined in Dataverse. For example, if your organization has set business unit-level permissions for you, metrics that are computed based on business unit-level data only are shown to you.

As a supervisor, you can view the **Real-time analytics for record routing** dashboards in either the Customer Service workspace or Contact Center workspace. However, your administrator must provide the required permissions for you. Learn more in [Configure user access to analytics and dashboards](../administer/configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

> [!NOTE]
> If different values are shown to different users in the metrics, you must investigate the permissions for those users.

## **Access reports** 

You can view the different reports in the Customer Service workspace or Contact Center workspace app. In the default view of the applications, select **Real-time analytics for record routing** in **Service**. By default, the **Summary** report is shown. To view the **Queue, Agent,** **Ongoing work items** and **Backlog work items** reports, select the
appropriate tabs. 

 If you can't view the reports, contact your system administrator. Learn more in [Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing). 

## Dashboard details 

Dynamics 365 Unified Routing uses work item (conversation) to track case and record routing and assignment. Case and record conversation states can be open, active, or closed. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states). 

For example, a case that gets created automatically creates a conversation in the Open state. When such a case gets reassigned, a new conversation gets created and the old one gets closed while the case remains the same. This way, work item lifecycles can be tracked seamlessly. 

**Real-time analytics for record routing** consist of the following reports: 

- **Summary**: This report provides an overview of your organization in real time.

- **Queue:** This report provides a case and record work item overview segmented by queue.

- **Agent**: This report provides an overview of the health and KPIs of service representatives in your organization.

- **Ongoing work items**: This report provides information about cases and records that service representatives are handling that are in an active or open state.

- **Backlog work items**: This report lists case and record work item conversations that have been modified, including work items created within the time range selected.

## Filter information displayed on dashboard 

Use the filters to drill down to KPIs across the dashboard. Adjust the filters based on the insights that you're looking for. The available filters include **Time**, **Agent**, **Agent status,** **Agent skill**, **Workstream**, **Queue**, **Work item status,** **Work item skill**, and **Time zone**. 

## Autorefresh 

Summary, queue, and agent reports are autorefreshed continuously to allow for real-time analytics trend insights. This autorefresh can be paused and resumed. Ongoing and backlog work item views need to be manually refreshed, which makes it easier to focus on supervisor tasks without disrupting data refreshes. 

> [!NOTE]
> For optimum use of real-time analytics for record routing, use [capacity profiles](../administer/capacity-profiles.md#create-and-manage-capacity-profiles). Use of legacy unit-based capacity or mixed capacity management leads to reduced report actionability. 

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Summary report](../use/rr-summary.md#view-and-understand-real-time-analytics-for-the-summary-report)  
[Queue report](../use/rr-queue.md#view-and-understand-real-time-analytics-for-the-queue-report)  
[Agent report](rr-agent.md#view-and-understand-real-time-analytics-for-the-agent-report)  
[Ongoing work items report](../use/rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-the-ongoing-work-items-report)  
[Backlog work items report](../use/rr-backlogitems.md#view-and-understand-real-time-analytics-for-the-backlog-work-items-report)  