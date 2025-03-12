---
title: View and understand real-time analytics for the ongoing work items report
description:
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 03/12/2025
ms.custom: bap-template
---

# View and understand real-time analytics for the ongoing work items report

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

- **Queue:** Queue that the work item has been routed to. 

- **Status:** Open or active, where open has not yet been assigned to an
  agent. 

- **Work item age:** Time in days since case or record was created.  

- **Assigned agent:** Agent the work item is assigned to. 

- **Created on:** Date and time stamp of when the case or record was
  created. 

- **Case:** Unique number id of conversation linked case record. 

- **Priority:** Priority of conversation linked case record. 

When a list item is selected, it can be assigned to an agent,
transferred to another queue or force closed. 

> [!NOTE]
> When a work item is transferred to a different queue, it could affect
  automatic assignment since the criteria for assignment doesn’t change
  upon transfer. In scenarios of push (automatic assignment),
  supervisors need to ensure that the destination queue has users who
  meet the criteria for work item assignment.   

- **Force close** closes the work item (conversation) but not the case. 

:::image type="content" source="../media/record-routing-ongoingworkitems.png" alt-text="Screenshot of the real-tiem analytics for ongoing work items report.":::

When you assign or transfer a selected work item, an assign or transfer
conversation dialog appears. This dialog allows you to identify the best
matching agent or queue (assign only) for the activity by displaying a
list of matching agents with availability, capacity and skill
proficiency match.

:::image type="content" source="../media/record-routing-assign-conversation.png" alt-text="Screenshot of the ongoing work items conversation report.":::

## Related information

