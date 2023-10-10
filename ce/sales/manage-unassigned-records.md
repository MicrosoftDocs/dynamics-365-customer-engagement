---
title: View and assign unassigned records
description: Learn how to view unassigned leads and opportunities so that you can assign them to sellers manually or run assignment rules again.
ms.date: 10/10/2023
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/10/2023
  - bap-template
---

# View and assign unassigned records

Leads and opportunities may be missed by your assignment rules and left unassigned. As an administrator, sales manager, or sequence manager, you can monitor these records to catch any that aren't assigned to a seller. If you find unassigned records, you can:

- [Run your assignment rules again](#run-reassignment-of-unassigned-records) in case the [conditions](#reasons-records-may-be-left-unassigned) that caused the records to be skipped the first time have changed.
- [Create an assignment rule](./create-and-activate-assignment-rule.md) to cover conditions you didn't anticipate.
- [Assign the records](#assign-records-manually) to sellers manually.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## View unassigned records

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select a **Record type** to view segments of that type.

    A red dot on the **Monitor *record type*** tab indicates the segment includes unassigned records. If you don't see a red dot, it means that all records of that type are assigned.

1. Select the **Monitor *record type*** tab.

    :::image type="content" source="media/sa-ar-view-unassigned-records-view-records.png" alt-text="Screenshot of the list of unassigned lead records.":::

 The **Unassigned leads** tab shows the following columns by default. To change the columns in the view, select **Edit columns**.

- **Name**, **Topic**, **Created on**: Identifies the lead or opportunity record.
- **Segment**: Identifies the segment the record is connected to.
- **Assignment rule**: Identifies the rule that tried to assign the record.
- **Assignment due in**: If a time limit is set in the assignment rule, displays the number of hours left for the record to be assigned before it's marked overdue. If no time limit is set, displays a hyphen (**&dash;**).
- **Status Reason**: Identifies the reason the record isn't assigned to a seller.

## Reasons records may be left unassigned

The reason a lead or opportunity wasn't assigned automatically is shown in the **Status reason** column in the list of unassigned records. Records may be included in the list for the following reasons:

- Eligible sellers don't have availability: No sellers who are able to be assigned automatically were available when the assignment rules ran. Assign the record manually, or run the assignment rules again in case more sellers are available now.

- Eligible sellers don't have capacity: No sellers who are able to be assigned automatically could take on more work when the assignment rules ran. Assign the record manually, or run the assignment rules again in case more sellers can accept work now.

- No sellers meet the conditions: No sellers met the assignment criteria when the assignment rules ran. Make sure your assignment rules include all eligible sellers, or create one that does, and run the assignment rules again.

- Record doesn't meet any conditions: The record doesn't meet the assignment criteria. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and run the rules again.

- No assignment rule for this record's segment: The segment the record is connected to doesn't match an active assignment rule. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and run the rules again.

- Seller lacks security role privileges: A seller met the assignment criteria but isn't able to be assigned automatically. Make sure your sellers are in the proper security roles and you included all the necessary security roles in your work assignment settings, and run the assignment rules again.

- There was an issue with the server: A problem with the server that your tenant is hosted on caused the assignment rules not to run. Run the assignment rules again.

## Run reassignment of unassigned records rhana

The number of unassigned records for a segment is displayed in the **Unassigned records** column in the **Assignment rules** page. Run the rules again in the segment and try to assign the records to the sellers. After the records are assigned, you can view the history of assigned records.

By default, a maximum of 500 records are considered for reassignment on each run. Older records are prioritized for assignment.

>[!NOTE]
>To learn how to schedule a time to run the reassignment, go to [Schedule reassignment of unassigned records](#schedule-reassignment-of-unassigned-records).

1. On the **Assignment rules** page, select the calendar icon that corresponds to the segment name for which you want to reassign the records.

    :::image type="content" source="media/sa-ar-run-reassignment-select-reassignment.png" alt-text="Screenshot illustrating the selection of calendar icon to open reassignment rules pane.":::

    The **Run assignment rules for *segment name*** pane opens with information on the number of records that aren't assigned, the date and time when the last reassignment was run, and the history.

    :::image type="content" source="media/sa-ar-run-reassignment-side-pane.png" alt-text="Screenshot illustrating the reassignment side pane.":::

1. On the **Run assignment rules for *segment name*** pane, select **Run now**.

    The rules run and assign the records to the sellers who are available and have the capacity to work and the **Last run** section is updated with the latest run time. To view the history of each run and the list of records that are assigned to sellers, select **Show history**. More information: [View reassignment run history](#view-reassignment-run-history)

## Schedule reassignment of unassigned records

You can schedule the reassignment of unassigned records to run automatically on a recurring basis by choosing the start date, time, and days to run. You can have up to one run scheduled for a segment, and the reassignment can run twice daily. For example, you can schedule the reassignment of unassigned records to run every weekday at 6:00 AM and 2:00 PM.

Once the scheduled run is complete, the history is updated with the latest time. More information: [View reassignment run history](#view-reassignment-run-history)

1. On the **Assignment rules** page, hover over the segment name and then select the calendar icon.

    :::image type="content" source="media/sa-ar-run-reassignment-select-reassignment.png" alt-text="Screenshot illustrating the selection of calendar icon to open reassignment rules pane.":::

    The **Run assignment rules for *segment name*** pane opens with information on the number of records that aren't assigned, the date and time when the last reassignment was run, and the history.

    :::image type="content" source="media/sa-ar-run-reassignment-side-pane.png" alt-text="Screenshot illustrating the reassignment side pane.":::

1. Select **+ Schedule run**.

1. On the **Schedule run for *segment name*** pane, provide the required information.

    | Option | Description |  
    |--------|-------------|  
    | Start date | Select the start date of the scheduled run. |  
    | Time | Select the time at which you want to run the schedule. You can't have more than two schedules a day. |  
    | Days of the week | Select the days of the week on which you want to run the schedule. |  

    :::image type="content" source="media/sa-ar-run-reassignment-schedule-configuration-side-pane.png" alt-text="Screenshot illustrating the reassignment schedule configuration side pane.":::

1. Select **Save schedule**.

    The schedule is added to the segment and runs at the configured time. A calendar icon is displayed corresponding to the segment name to indicate that reassignment is scheduled.

    :::image type="content" source="media/sa-ar-run-reassignment-schedule-confirmation-side-pane.png" alt-text="Screenshot illustrating the reassignment schedule side pane.":::

    >[!NOTE]
    >- To edit the schedule, hover over the **Run scheduled** section and then select the pencil icon.
    >- To delete the schedule, hover over the **Run scheduled** section and then select the delete icon.

## View reassignment run history

The reassignment run history provides information on each run such as the time it ran, the number of records that were reassigned, the time taken to complete the run, the status of the run, and how it was triggered.

On the **Run assignment rules for *segment name*** pane, under the **Last run** section, select **Show history**.

:::image type="content" source="media/sa-ar-run-reassignment-select-show-history.png" alt-text="Screenshot illustrating the selection of reassignment schedule history.":::

The history pane opens.

:::image type="content" source="media/sa-ar-run-reassignment-show-history.png" alt-text="Screenshot illustrating the reassignment run history":::

## Assign records manually

You can assign the unassigned records to sellers or a team.

1. Select the record that you want to assign to a seller and then select **Assign**. In this example, we're selecting a lead record.

    >[!NOTE]
    >You can select multiple records at once to assign to a seller.

    :::image type="content" source="media/sa-ar-assign-unassigned-records-select-records.png" alt-text="Screenshot of Select a record to assign to a seller.":::

1. On the **Assign leads to a seller or team** page, select a seller to who you want to assign the record.

    >[!NOTE]
    >- Enable the **Show eligible sellers** option to view only the seller who are added to assignment rules through team settings. More information: [Manage sales teams in assignment rules](manage-sales-teams.md)
    >- To assign the record to a team, select **Team** tab.

    :::image type="content" source="media/sa-ar-assign-unassigned-records-select-seller.png" alt-text="Screenshot of Select a record.":::

1. Select **Assign**.

    The record is assigned to the seller and the list refreshes to remove the assigned record.
    To view the details of the assigned records, select the **Assignment history** tab. A list of previously assigned records is displayed.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage assignment rules](create-manage-assignment-rules.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
