---
title: View and edit properties of a segment
description: View and edit the details of a segment such as, priority, allow records from other segments to move, and schedule to run assignment rules.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# View and edit properties of a segment

View and edit the details of a segment such as, priority, allow records from other segments to move, and schedule to run assignment rules. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Open and view properties of a segment

>[!NOTE]
>In this procedure, we are using leads as example.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.  
1. From the **Record type** list, choose **Leads** and then open the segment.  

    :::image type="content" source="media/sa-segment-edit-list-lead-segments.png" alt-text="Screenshot of segment page with a list of segments for the selected record type.":::  

    > [!NOTE]
    >
    > When you open the segment, the **Overview** section displays the details of the properties that are configured for the segment along with connected sequence and assignment rules.  

1. On the segment page, select **Segment properties**.  
    The **Segment properties** pane opens.  

    :::image type="content" source="media/wa-segment-segment-properties-pane.png" alt-text="Screenshot of segment properties pane.":::

1. Update or configure the following properties as required and save your changes:  
    - If necessary, update the name and description.
    - [Change the priority of the segment](#change-priority-of-the-segment).
    - [Allow records from other segments to move to this segment](#allow-records-from-other-segments-to-move-to-this-segment). 
    - [Schedule to run assignment rules](#schedule-to-run-assignment-rules).

## Change priority of the segment

In the **Segment priority (Total segments *number*)** option, enter the priority of the segment.  
The priority of a segment specifies the order in which the segment is applied to the records. If a record matches multiple segments, it's connected to the segment that has the highest priority. Prioritizations of inactive segments are not taken into consideration for applying records. 
When you change the priority of a segment, the records that are already connected to that segment remain connected. Only new or updated records are connected to the segment based on the new priority.  
Also, the sequence of segments is readjusted to align with the revised priority order.  
 
## Allow records from other segments to move to this segment

To allow records from another segment to move to this segment, turn on **Previously-segmented leads**. The application validates the records for conditions that are defined in this segment and moves the records accordingly, although the records are connected to a different segment. When they're moved, the records are connected to the sequence from this segment. However, the assignment rules aren't changed. To apply the current assignment rule to the moved records, select the **Run assignment rules when a lead moves into this segment** checkbox.

## Schedule to run assignment rules

Configure an automated schedule to periodically run the assignment rules. Select the start date, time, and days for the process to run, thereby assigning unassigned records to sellers.  
You can have up to one run scheduled for a segment, and the reassignment can run twice daily. For example, you can schedule the reassignment of unassigned records to run every weekday at 6:00 AM and 2:00 PM.  
Once the scheduled run is complete, the history is updated with the latest time. More information: [View reassignment run history](#view-reassignment-run-history)  

1. In the **Run assignment rules for unassigned leads (*number*)** section, select **Add schedule**.  
1. On the **Schedule run for *segment name*** pane, provide the required information.  

    | Option | Description |  
    |--------|-------------|  
    | Start date | Select the start date of the scheduled run. |  
    | Time | Select the time at which you want to run the schedule. You can't have more than two schedules a day. |  
    | Days of the week | Select the days of the week on which you want to run the schedule. |  

    :::image type="content" source="media/wa-run-reassignment-schedule-configuration-side-pane.png" alt-text="Screenshot illustrating the reassignment schedule configuration side pane.":::

1. Select **Save changes**.  
    The schedule is added to the segment and runs at the configured time. A calendar icon is displayed corresponding to the segment name to indicate that reassignment is scheduled.  

    :::image type="content" source="media/wa-run-reassignment-schedule-confirmation.png" alt-text="Screenshot illustrating the reassignment schedule.":::

    >[!NOTE]
    >
    >- To edit the schedule, select the pencil icon.
    >- To delete the schedule,then select the bin icon.
    >- To run the schedule immediately, select **Run now**.

### View reassignment run history

The reassignment run history provides information on each run such as the time it ran, the number of records that were reassigned, the time taken to complete the run, the status of the run, and how it was triggered.  

In the **Run assignment rules for unassigned leads (*number*)** section, under the **Last run** section, select **Show history**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a segment](create-and-activate-a-segment.md)  
[Edit a segment](wa-edit-a-segment.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
