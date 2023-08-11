---
title: View and manage unassigned records
description: You can view and manage unassigned lead and opportunity records through assignment rules in Microsoft Dynamics 365 sales accelerator.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: overview 
ms.collection: get-started 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# View and manage unassigned records

Monitoring of unassigned records allows you to view the lead or opportunity records that aren't assigned to any seller. As an administrator, sales manager, or sequence manager, you can view these unassigned records and assign to sellers.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## View unassigned records

You can view the unassigned records through the **Work assignment** homepage. The **Work assignment** homepage displays the number of unassigned records for each segment under the **Unassigned records** column. 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Work assignment**.
1. On the **Work assignment** page, in the **Record type** list, select a record type as **Leads**, **Opportunities**, or **Insights**.  
    The number of unassigned records that belong to a segment are displayed under the **Unassigned records** column.  

    :::image type="content" source="media/wa-home-page-unassigned-records-column.png" alt-text="Screenshot of the work assignment home page with unassigned records.":::

1. Select **Monitor *record***.  
    The monitor record type page opens with the list of records that are unassigned for segments.

    > [!NOTE]
    >
    > When a segment is deleted, the attached rules will be automatically linked to default segment.

    :::image type="content" source="media/wa-view-unassigned-records-view-records.png" alt-text="Screenshot of the list of unassigned lead records.":::

    - Use the **Segment** column to filter the records by segment. 
    - The **Assignment due in** column displays the number of hours left for the record to be assigned to a seller or a team. If the record isn't assigned to any seller or team within the timeframe, the record is marked as overdue. You must assign these records manually or schedule a reassignment run. The time limit is configured through the **Consider seller work schedule** option while configuring the distribution of records in assignment rules. To understand the **Consider seller work schedule** option, see step 8 in [To create and activate an assignment rule](wa-create-and-activate-assignment-rule.md#create-and-activate-an-assignment-rule).  
        
        When the the **Consider seller work schedule** option isn't selected for the rule, the dash (-) icon is displayed corresponding to the records.  
     
    - The **Status Reason** column displays why the record isn't assigned to a seller. By [analyzing the reason](#reason-for-unassigned-records), you can take appropriate action by assigning these records to sellers, creating an assignment rule, or by adding conditions to existing assignment rule. More information: [Create and activate an assignment rule](create-and-activate-assignment-rule.md#create-and-activate-an-assignment-rule).

## Reason for unassigned records

The records aren't assigned automatically because of one of the following reasons:

| Reason | Description |
|--------|-------------|
| Eligible sellers don't have availability | Record couldn't be assigned as eligible sellers aren't available. |
| Eligible sellers don't have capacity | Record couldn't be assigned as eligible sellers don't have the capacity. |
| No assignment rule for this record's segment | Record doesn't match any assignment rule that is currently active and available in the organization.|
| No sellers meet the conditions | Record isn't assigned as none of the sellers meet the conditions that are defined in the matched assignment rule. |
| Owner assigned manually | Owner is manually assigned to the record. |
| Owner assigned successfully | Owner is assigned to the record. |
| Record doesn't meet any conditions | Record isn't assigned as it doesn't match any conditions that are defined for the assignment rule. |
| Record unassigned as seller lacks security role privileges | Seller doesn't have sufficient roles to access the record. |
| Run is in progress | Specifies that the assignment is in progress for the record. |
| There was an issue with the server | Record isn't assigned as there's an issue with the server that your organization is hosted on. |

## Assign records manually

You can assign the unassigned records to sellers or a team.

1. Select the record that you want to assign to a seller and then select **Assign**. 

    >[!NOTE]
    >You can select multiple records at once to assign to a seller.  

    :::image type="content" source="media/wa-assign-unassigned-records-select-records.png" alt-text="Screenshot of selecting a record to assign to a seller.":::

1. On the **Assign *records* to a seller or team** page, select a seller or teams to who you want to assign the record.

    >[!NOTE]
    >- Enable the **Show eligible sellers** option to view only the seller who are added to assignment rules through team settings. More information: [Manage sales teams in assignment rules](manage-sales-teams.md)
    >- To assign the record to a team, select **Team** tab.

    :::image type="content" source="media/sa-ar-assign-unassigned-records-select-seller.png" alt-text="Screenshot of Select a record.":::

1. Select **Assign**.

    The record is assigned to the seller and the list refreshes to remove the assigned record.

## Schedule reassignment of unassigned records

You can schedule the reassignment of unassigned records to run automatically on a recurring basis by choosing the start date, time, and days to run. You can have up to one run scheduled for a segment, and the reassignment can run twice daily. For example, you can schedule the reassignment of unassigned records to run every weekday at 6:00 AM and 2:00 PM.

Once the scheduled run is complete, the history is updated with the latest time. More information: [View reassignment run history](#view-reassignment-run-history)

1. On the **Work assignment** page, open the segment for which you want to schedule the reassignment of unassigned records.  
1. Select **Segment properties**.  
    The **Segment properties** pane opens.  
1.  In the **Run assignment rules for unassigned leads (*number*)** section, select **Add schedule**.  
1. On the **Schedule run for *segment name*** pane, provide the required information.

    | Option | Description |  
    |--------|-------------|  
    | Start date | Select the start date of the scheduled run. |  
    | Time | Select the time at which you want to run the schedule. You can't have more than two schedules a day. |  
    | Days of the week | Select the days of the week on which you want to run the schedule. |  

    :::image type="content" source="media/sa-ar-run-reassignment-schedule-configuration-side-pane.png" alt-text="Screenshot illustrating the reassignment schedule configuration side pane.":::

1. Select **Save schedule**.

    The schedule is added to the segment and runs at the configured time. A calendar icon is displayed corresponding to the segment name to indicate that reassignment is scheduled.

    >[!NOTE]
    >- To edit the schedule, hover over the **Run scheduled** section and then select the pencil icon.
    >- To delete the schedule, hover over the **Run scheduled** section and then select the delete icon.

## Run reassignment of unassigned records

The number of unassigned records for a segment is displayed in the **Unassigned records** column in the **Assignment rules** page. Run the rules again in the segment and try to assign the records to the sellers. After the records are assigned, you can view the history of assigned records.

By default, a maximum of 500 records are considered for reassignment on each run. Older records are prioritized for assignment.

>[!NOTE]
>To learn how to schedule a time to run the reassignment, go to [Schedule reassignment of unassigned records](#schedule-reassignment-of-unassigned-records).

1. On the **Work assignment** page, open the segment.  
1. Select **Segment properties**.  
    The **Segment properties** pane opens.  
1.  In the **Run assignment rules for unassigned leads (*number*)** section, select **Run now**.  

    The rules run and assign the records to the sellers who are available and have the capacity to work and the **Last run** section is updated with the latest run time. To view the history of each run and the list of records that are assigned to sellers, select **Show history**. More information: [View reassignment run history](#view-reassignment-run-history)

## View reassignment run history

The reassignment run history provides information on each run such as the time it ran, the number of records that were reassigned, the time taken to complete the run, the status of the run, and how it was triggered.  

1. On the **Work assignment** page, open the segment.  
1. Select **Segment properties**.  
    The **Segment properties** pane opens.  
1. On the **Run assignment rules for unassigned leads (*number*)** section, under the **Last run** subsection, select **Show history**.  
    The history pane opens.  

    :::image type="content" source="media/sa-ar-run-reassignment-show-history.png" alt-text="Screenshot illustrating the reassignment run history":::

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage assignment rules](create-manage-assignment-rules.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
