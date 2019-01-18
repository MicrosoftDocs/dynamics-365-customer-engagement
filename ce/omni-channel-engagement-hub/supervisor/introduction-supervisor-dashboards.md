---
title: "Introduction to supervisor dashboards"
description: 
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 3780b473-907a-4f69-80f0-c505f7b715ee
ms.custom: 
---
# Introduction to supervisor dashboards

The **Overview** dashboard provides information about the health and key performance indicators (KPIs) of agents in your organization. The KPIs include the number of open work items, the number of active work items, and the number of active work items that have been escalated.

Typically, the **Overview** dashboard is divided into two sections:

- [Live monitoring](#live-monitoring)
- [Intraday monitoring](#intraday-monitoring)

## Live monitoring

The **Live monitoring** section shows information that is automatically updated to reflect the latest status of health parameters. This information includes the latest KPIs. The information is updated within two to three minutes after the app data is changed.

The following illustration shows an example of the **Live monitoring** section.

![Live work monitoring for supervisors](../media/oc-usd-supervisor-overview-live-monitoring.png "Live work monitoring for supervisors")

This section of the dashboard consists of the following KPIs.

| KPI                                           | Description |
|-----------------------------------------------|-------------|
| Active work items                             | The number of work items that are in the **Active** state. Numbers are shown in a bar chart for each live work stream that is configured. |
| Active work items exceeding 5 min wait time   | The number of work items that are in the **Active** and **Open** states, and that are exceeding the time-in-queue threshold. |
| Active work items exceeding 5 min handle time | The number of active work items that are exceeding the handle-time threshold. |
| Active work items transferred                 | The number of active work items that have been transferred from one agent or supervisor to another agent or supervisor. |
| Open work items                               | The number of work items that are in the **Open** state. |

## Intraday monitoring

The **Intraday monitoring** section provides information about the latest KPIs, the health of queues on the status of the agents on a given day. The information is updated every 15 minutes.

The following illustration shows an example of the **Intraday monitoring** section.

![Intraday work monitoring for supervisors](../media/oc-usd-supervisor-overview-intraday-monitoring.png "Intraday work monitoring for supervisors")

This section of the dashboard consists of the following KPIs.

> [!NOTE]
> All KPIs that the application shows are for the last 24-hour running window.

| KPI                          | Description |
|------------------------------|-------------|
| Active work items            | The number of work items that are in the **Active** state. Numbers are shown in a bar chart for each live work stream that is configured.|
| Average handle time          | The average time that is taken to complete a session from start to end for different work items. |
| Average response time        | The average time that an agent takes to respond to a work item. |
| Average wait time            | The average time that an agent takes to respond to a customer who is waiting in the queue. |
| Average work items per agent | The average number of work items that are handled by an agent. The numbers are shows for both agents who are signed in (available, busy, and away) and for online agents (available and busy). |
| Closed work items            | The number of work items that are in the **Closed** state, so that no further action can be taken on them. |
| Open work items              | The number of work items that are in the **Open** state. |
| Transferred work items       | The number of work items that have been transferred from one agent or supervisor to another agent or supervisor. |
| Waiting work items           | The number of work items that are in the **Waiting** state. |
