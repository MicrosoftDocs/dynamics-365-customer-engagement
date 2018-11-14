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

The **Overview** dashboard provides information about agents on health and KPIs such as open work items, active work items, and active work items esclated. Typically, the **Overview** dashboard is divided into two sections: 

1.  [Live monitoring](#live-monitoring)  

2.  [Intraday monitoring](#_Intraday_monitoring)  

## Live monitoring

Displays information such as latest KPIs that is automatically refreshed to reflect the latest status on health parameters. This information refreshes within two to three minutes of a change in the app data. The following page is an example of how a live data monitoring dashboard displays: 

![live work monitoring for supervisor](media/oc-usd-supervisor-overview-live-monitoring.png "Live work monitoring for supervisor") The dashboard consists of the following KPIs:   

| **KPI **                                           | **Description **                                                                                                                                                                                    |
|----------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Active work items  **                            | ### Displays the number of work items that are in active state. The numbers are displayed in a bar chart for each live work stream that is configured.   |
| **Active work items exceeding 5min wait time **    | Displays the work items that are in active and open states and exceeded the time in queue threshold.                                                                                                |
| **Active work items exceeding 5 min handle time ** | Displays the active work items that are exceeding the handle time threshold.                                                                                                                        |
| **Active work items transferred **                 | Displays the work items that are active and transferred from one agent/supervisor to another agent/supervisor.                                                                                      |
| **Open work items **                               | Displays the number of work items that are in open state.                                                                                                                                           |

<span id="_Intraday_monitoring" class="anchor"></span>

## Intraday monitoring

Provides information on latest KPIs, health of queues on the status of the agents in the given day, and the information refreshes every 15 minutes. The following page is an example of how an intraday monitoring dashboard displays: 

![intraday work monitoring for supervisor](media/oc-usd-supervisor-overview-intraday-monitoring.png "Intraday work monitoring for supervisor")   

The dashboard consists of the following KPIs: 

**Note:**

All KPIs that application displays are for the past 24 hour running window. 

| **KPI **                          | **Description **                                                                                                                                                                                |
|-----------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Active work items **            | Displays the number of work items that are in active state. The numbers are displayed in a bar chart for each live work stream that is configured.                                              |
| **Average handle time **          | Displays the average time taken to complete a session from start to end for different work items.                                                                                               |
| **Average response time **        | Displays the average time taken to respond to a work item by an agent.                                                                                                                          |
| **Average wait time **            | Displays the average time taken for an agent to respond to a customer waiting in the queue.                                                                                                     |
| **Average work items per agent ** | Displays the average number of work items that are handled by an agent. The values are displayed for both logged-in (available, busy, and away) and online agents ( available and busy agents)  |
| **Closed work items **            | Displays the number of work items that are in closed state, and no further action can be taken.                                                                                                 |
| **Open work items **              | Displays the number of work items that are in open state.                                                                                                                                       |
| **Transferred work items **       | Displays the work items that are transferred from one agent/supervisor to another agent/supervisor.                                                                                             |
| **Waiting work items **           | Displays the number of work items that are in waiting state.                                                                                                                                    |

