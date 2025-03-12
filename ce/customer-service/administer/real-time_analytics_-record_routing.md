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

# Introduction

Real-time analytics for record routing provides supervisors with critical insights into the health and key performance indicators (KPIs) of their contact centers. These analytics enable supervisors to monitor and optimize agent performance and customer interactions across multiple channels. By customizing and saving personalized views, supervisors can efficiently manage operational metrics, agent allocation, and ongoing cases to maintain high service levels and customer satisfaction.

This guide covers how to enable and use real-time analytics for record routing, including configuring security roles and permissions, accessing various reports, and understanding the metrics provided.

## Security roles and permissions

Real-time analytics takes advantage of the security permissions that are
defined in Dataverse. For example, if your organization has set business
unit-level permissions for you, only metrics that are computed based on
business unit-level data are shown to you.

As a supervisor, you can view the **Customer Service real-time analytics
for record routing** dashboard in Customer Service workspace or Contact
Center workspace. However, your administrator must provide the required
permissions for you. [Learn how to configure user roles to access
analytics and
dashboards.](https://learn.microsoft.com/en-us/dynamics365/customer-service/administer/configure-customer-service-analytics-insights-csh#configure-user-access-to-analytics-and-dashboards) 

**Note**: If different values are shown to different users in the
metrics, you must investigate the permissions for those users.

**Access reports** 

You can view the different reports in the Customer Service workspace or
Contact Center workspace app. In the default view of the applications,
select **Real-time analytics for record routing** in **Service**. By
default, the **Summary** report is shown. To view the **Queue, Agent,**
**Ongoing work items** and **Backlog work items** reports, select the
appropriate tabs. 

 If you can't view the reports, contact your system administrator. Learn
more in [Manage real-time analytics
reports](https://learn.microsoft.com/en-us/dynamics365/customer-service/administer/enable-realtime-analytics-dashboard-administrator#manage-real-time-analytics-reports-in-omnichannel-for-customer-service). 

## Dashboard details 

**Important:** Dynamics 365 Unified Routing uses work item
(conversation) to track case and record routing and assignment. Case and
record conversation states can be open, active or closed. Learn more in
[Understand conversation states \| Microsoft
Learn](https://learn.microsoft.com/en-us/dynamics365/customer-service/use/oc-conversation-state).
For example, a case that gets created automatically creates a
conversation in the Open state. When such a case gets re-assigned, a new
conversation gets created and the old one gets closed while the case
remains the same. This way, work item lifecycles can be tracked
seamlessly. 

The **Real-time analytics for record routing** dashboard consist of the
following reports: 

- **Summary**: This report provides an overview of your organization in
  real time.

- **Queue:** This report provides a case and record work item overview
  segmented by queue.

- **Agent**: This report provides an overview of the health and KPIs of
  agents in your organization.

- **Ongoing work items**: This report provides information about cases
  and records that agents are handling that are in an active or open
  state.

- **Backlog work items**: This report lists case and record work item
  conversations that have been modified, including created within the
  time range selected.

## Filter information displayed on dashboard 

Use the filters to drill down to KPIs across the dashboard. Adjust the
filters based on the insights that you're looking for. The available
filters include **Time**, **Agent**, **Agent status,** **Agent skill**,
**Workstream**, **Queue**, **Work item status,** **Work item skill** and
**Time zone**. 

## Auto-refresh 

Summary, queue and agent reports are auto-refreshed continuously to
allow for real-time analytics trend insights. This auto-refresh can be
paused and resumed. Ongoing and backlog work item views need to be
manually refreshed, which makes it easier to focus on supervisor tasks
without disrupting data refreshes. 

**Note**: For best use of real-time analytics for record routing, use
[capacity
profiles](https://learn.microsoft.com/en-us/dynamics365/customer-service/administer/capacity-profiles)
to manage agent capacity as this report is optimized for it. Use of
legacy unit-based capacity or mixed capacity management will lead to
reduced report actionability. 

# View and understand the Customer Service real-time analytics for record routing reports 

The **Summary** report appears by default when you open the **Real-time
analytics for record routing** dashboard in Customer Service workspace
or the Contact center workspace. You can filter this report by time,
queue, agent, workstream, work item status, work item skill and time
zone. Time filters available include **Last 24 hrs** and **Today**. This
frames the summary view towards real-time. 

## Summary report 

The **Summary** report provides a summary of cases and records over
time, by workstream or queue. Statistics about the workstream that a
work item was created against can help you analyze and manage queue
distribution and capacity use efficiency. For example, a high rate of
unassigned work items can lead to decreased customer satisfaction. To
address the rate of unassigned work items or long wait times before
cases are assigned, you can examine operational metrics such as agent
availability and case distribution for available agent capacity in real
time. 

By editing the visual display, you can add metrics to the ones that are
already shown on the **Summary** report. Learn more in [Customize visual
display](https://learn.microsoft.com/en-us/dynamics365/customer-service/use/customize-reports). 

[Learn more about the metrics that are shown on the Summary
report.](https://learn.microsoft.com/en-us/dynamics365/customer-service/use/oc-metrics-dimensions#use-omnichannel-for-customer-service-metrics) 

<img src="media/real-time_analytics_-record_routing/image2.png" style="width:6.5in;height:3.35139in" /> 

### Interactive charts 

You can view different types of charts in the report, such as bar,
horizontal bar, and donut charts. The visual display helps you discern
changes and patterns in the data, so that you can act quickly to address
the most important issues. 

When you select a component in a chart, the data is filtered
accordingly. In this way, you can view only data that is related to the
selected component. For example, if you select the **Offline** component
in the **Agent availability status** chart, the dashboard is refreshed
and shows only work items of agents who are currently in
the **Offline** state. 

The **Agent availability by capacity** chart also offers a drill down
view that lists agent availability in more detail per workstream. 

 

## Queue report

The queue report lists all advanced queues in the organization in a
table by default. Content can be filtered by individual queue, time,
agent, workstream, work item status, work item skill and time zone. 

The queue table has the following sortable columns: 

- **Queue:** Name of queue. 

<!-- -->

- **Assigned work items:** Work items assigned to agent during reporting
  period. 

<!-- -->

- **Unassigned work items:** Cases during reporting period that haven’t
  yet been assigned to an agent, which include transfers to queue. 

<!-- -->

- **Longest wait time:** Longest time for a case during reporting period
  in queue until status changed from open to active (assigned). 

<!-- -->

- **Agents available:** Lists the number of agents per queue that have
  presence set to Available. 

<!-- -->

- **Agents online:** Agents assigned to queue that are online. 

Because the table allows for sorting by Assigned cases, Unassigned
cases, Longest wait time, Agents available and Logged in agents, you can
easily identify queues where corrective action needs to be taken to
provide a smooth customer experience. For example, if you sort by
unassigned cases or longest wait time, you can ensure that enough agents
and agent capacity is available to handle the backlog efficiently. 

When a queue is selected in the table, queue work items can be listed as
an embedded ongoing work items table for easy management via the
*detailed view* option.

<img src="media/real-time_analytics_-record_routing/image3.png" style="width:6.5in;height:2.75208in" /> 

## Agent report 

The agent report provides an agent centric view for case and record
management. Time, Queue, Agent, Agent skill, Agent status and Time zone
are filters that enable you to drill into the data to identify agent
availability and capacity limitations to address unassigned work
items.  

A set of KPIs provide a quick insight into the filter scope. They
include Agents online, Agents available, Agents busy, and Agents at max
capacity.  

When you select a component in a chart, the data is filtered
accordingly. In this way, you can view only data that is related to the
selected component. For example, if you select the **Offline** component
in the **Agent availability status** chart, the dashboard is refreshed
and shows capacity that is essentially locked. The agent list table also
allows you to identify agents with the highest count of transferred work
items, which allows you to identify misassignments and to take
corrective steps.  

 

### Lists and charts 

**Agent availability status:** This donut chart lists all agents in the
org that are assigned to any record type queue. It lists all the
availability statuses, including custom ones. When clicking on a status,
the filter is automatically applied to the entire tab. 

**Agent availability by capacity profiles:** This table lists all
capacity profiles, as well as logged in agents linked to the capacity
profiles and capacity in use, which allows you to identify assignment
bottle necks caused by lack of capacity. If capacity is occupied in
profiles with blocking assignment toggle turned on, the entry is
displayed in red. Clicking on *show more* displays this table with
detailed agent availability status, which can be another cause for
unassigned work items, besides capacity.

**Agent list:** The agent list table lists all agents associated with a
queue of record type. Sortable columns are:  

- **Assigned agent:** Name of agent or bot. 

<!-- -->

- **Status:** Availability status of agent. 

<!-- -->

- **Status since:** Time stamp when agent entered current availability
  status. 

<!-- -->

- **Active:** Number of work items in active state assigned to agent
  during reporting period. 

<!-- -->

- **Closed:** Number of work items closed by an agent in the reporting
  period. 

<!-- -->

- **Transfers:** Number of work items agent transferred to queue or
  another agent in the reporting period. 

<!-- -->

- **Average duration:** Average time conversations that were active and
  assigned to agent during reporting period. 

<!-- -->

- **Accepted:** Number of conversations the agent accepted during the
  reporting period. 

<!-- -->

- **Rejected:** Number of conversations the agent rejected when it was
  assigned during reporting period. 

<!-- -->

- **Timeout:** Number of conversations that timed out before the agent
  accepted or rejected during reporting period. This doesn’t apply to
  setups where cases are auto assigned. 

 

 

<img src="media/real-time_analytics_-record_routing/image4.png" style="width:6.5in;height:3.13542in"
alt="A screenshot of a computer Description automatically generated" />

When selecting an agent in the list you can open a detailed agent view
of that agent. This view includes:

- Agent name and account.

- Agent specific KPIs (in reporting period).

  - Active work items assigned to agent.

  - Closed work items.

  - Transferred work items.

  - Average conversation time.

- Agent skills by proficiency.

- Agent availability by capacity profiles.

- List of record conversations assigned to agent, including associated
  queue, conversation status and conversation creation date/time.

- Agent presence history.

<img src="./e21689cff1ad89405cb81bb550bfc86a5940b0ff.png"
style="width:7.5in;height:4.42788in" />

The agent list status column also allows you to set agent status by
agent. This can be very useful when there are unassigned work items and
agents with available capacity but not in the available status.

<img src="media/real-time_analytics_-record_routing/image6.png" style="width:6.5in;height:5.18542in"
alt="A screenshot of a computer Description automatically generated" />

## Ongoing work items 

The Ongoing work items report lists all open and active state work items
that have been modified in the past 24 hours or today per time zone
setting. Content can be filtered by time, queue, agent, workstream, work
item skill and time zone.  

This report is specifically for real-time tracking of recent cases or
records. In this view, you can easily identify work items that have been
created but haven’t yet been assigned to an agent. It can help you
ensure that all new work items that need attention are triaged. Work
items can be assigned, transferred, or force closed from within the
dashboard. 

For longer time periods, you can use the [Backlog work items
view](#backlog-work-items).  

 

The table list view has the following columns: 

- **Subject:** Case or Record title. 

<!-- -->

- **Queue:** Queue that the work item has been routed to. 

<!-- -->

- **Status:** Open or active, where open has not yet been assigned to an
  agent. 

<!-- -->

- **Work item age:** Time in days since case or record was created.  

<!-- -->

- **Assigned agent:** Agent the work item is assigned to. 

<!-- -->

- **Created on:** Date and time stamp of when the case or record was
  created. 

<!-- -->

- **Case:** Unique number id of conversation linked case record. 

<!-- -->

- **Priority:** Priority of conversation linked case record. 

When a list item is selected, it can be assigned to an agent,
transferred to another queue or force closed. 

**Note:  **

- When a work item is transferred to a different queue, it could affect
  automatic assignment since the criteria for assignment doesn’t change
  upon transfer. In scenarios of push (automatic assignment),
  supervisors need to ensure that the destination queue has users who
  meet the criteria for work item assignment.  

<!-- -->

- **Force close** closes the work item (conversation) but not the case. 

 

 

<img src="media/real-time_analytics_-record_routing/image7.png" style="width:6.5in;height:3.28333in"
alt="A screenshot of a computer Description automatically generated" />

When you assign or transfer a selected work item, an assign or transfer
conversation dialog appears. This dialog allows you to identify the best
matching agent or queue (assign only) for the activity by displaying a
list of matching agents with availability, capacity and skill
proficiency match.

<img src="media/real-time_analytics_-record_routing/image8.png"
style="width:6.49097in;height:3.35625in" />

## Backlog work items 

The Backlog work items report is like ongoing work items with focus on
all work items, even when older than 24 hours since the last work item
update. It allows for filtering based on any created on date period in
the past. Content can be filtered by created on, queue, agent,
workstream, work item skill and time zone.  

Aside from filtering, it also provides four KPIs to track all-up volumes
within the selected filter for total work items, active work items,
unassigned work items and closed work items. It allows you to easily
identify overall case/record volume and provides easy identification of
unassigned work items for triage based on priority etc. 

The table list view has the following columns: 

- **Subject:** Case or Record title. 

<!-- -->

- **Queue:** Queue that the work item has been routed to. 

<!-- -->

- **Status:** Open or active, where open has not yet been assigned to an
  agent. 

<!-- -->

- **Work item age:** Time in days since case or record was created.  

<!-- -->

- **Assigned agent:** Agent the work item is assigned to. 

<!-- -->

- **Created on:** Date and time stamp of when the case or record was
  created. 

<!-- -->

- **Case:** Unique number id of conversation linked case record. 

<!-- -->

- **Priority:** Priority of conversation linked case record. 

 

<img src="media/real-time_analytics_-record_routing/image9.png" style="width:6.5in;height:3.33125in" /> 

For assign, transfer and force close description, go to the [ongoing
work items](#ongoing-work-items) section.

## Real-time analytics for record routing metrics

This section describes the metrics for real-time analytics for record
routing. For metrics pertaining to Omnichannel for Customer Service, go
to [Use Omnichannel for Customer Service
metrics.](https://learn.microsoft.com/en-us/dynamics365/customer-service/use/oc-metrics-dimensions)

**Assigned work items**

This summary view metric is a measure of the total number of assigned
work items. It's irrespective of work item state, which is every state
except Open and closed.

**Unassigned work items**

This summary view metric is a measure of the total number of unassigned
work items. It's irrespective of work item state.

**Work items over time**

Used in stacked column chart in real-time analytics for record routing,
this summary view metric shows the number of work items in assigned and
unassigned state projected over created on time in x-axis.

**Assignment time**

This is a table column in ongoing work items view. The metric displays
time taken for the assignment of the record between record conversation
creation and record assignment.

**Work item age**

This is a table column in ongoing work items view. The metric displays
the time elapsed since the record conversation was created.

**Case number**

This is a table column in ongoing work items view. It displays the case
number for the underlying case record. Data exists only if the
conversation is of case entity type.

**Priority**

This is a table column in ongoing work items view. It displays the case
priority for the underlying case record. Data exists only if the
conversation is of case entity type.

**Agents available**

This agent view metric is a measure of the total number of agents whose
base presence status is available.

**Agents busy**

This agent view metric is a measure of the total number of agents whose
base presence status is busy.

**Agents at max capacity**

This agent view metric is a measure of the total number of agents who
have no available capacity.

**Active work items**

This is a table column in agent view. It lists the number of active work
items assigned to the agent.

**Accepted**

This is a table column in agent view. It lists the number of sessions
accepted by the agent during the reporting period.

**Rejected**

This is a table column in agent view. It lists the number of sessions
rejected by the agent during the reporting period.

**Timeout**

This is a table column in agent view. It lists the number of sessions
timed out waiting for the agent to accept or reject during the reporting
period.

**Agents available**

This is a table column in queue view. It lists the number of agents in
the queue whose base presence status is available.
