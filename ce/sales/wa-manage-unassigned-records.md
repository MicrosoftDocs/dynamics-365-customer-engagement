---
title: View and assign unassigned records
description: Learn how to view unassigned leads, opportunities, and insights in Dynamics 365 Sales so that you can assign them to sellers manually or run assignment rules again.
ms.date: 05/20/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/10/2023
  - bap-template
---

# View and assign unassigned records

[Assignment rules](./wa-create-and-activate-assignment-rule.md) can miss leads, opportunities, and insights, leaving them unassigned. As an administrator, sales manager, or sequence manager, you can monitor incoming records to catch any that aren't assigned to a seller. You can view the number of unassigned records by segment and record type and get detailed information about them. Then, assign them to a seller or sales team.

- [Run your assignment rules again](#run-assignment-rules) in case the [conditions](#reasons-records-might-be-left-unassigned) that caused the records to be skipped the first time have changed.
- [Create an assignment rule](./wa-create-and-activate-assignment-rule.md) to cover conditions you didn't anticipate.
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

    :::image type="content" source="./media/wa-home-page-unassigned-records-column.png" alt-text="Screenshot of the Work assignment page showing lead records, with the Monitor leads button and unassigned records highlighted.":::

    A red dot on the **Monitor *record type*** button indicates there are unassigned records. If you don't see a red dot, it means that all records are assigned. The **Unassigned records** column shows the number of records that are unassigned in each segment.

1. Select **Monitor *record type***.

    :::image type="content" source="media/sa-ar-view-unassigned-records-view-records.png" alt-text="Screenshot of the list of unassigned lead records.":::

    The **Unassigned *records*** tab shows the following columns by default. To change the columns in the view, select **Edit columns**.

    - **Name**, **Topic**, **Created on**: Identifies the lead or opportunity record.
    - **Segment**: Identifies the segment the record is connected to.
    - **Assignment rule**: Identifies the rule that tried to assign the record.
    - **Assignment due in**: If a time limit is set in the assignment rule, displays the amount of hours left for the record to be assigned before it's marked overdue. If no time limit is set, displays a hyphen (**&dash;**).
    - **Status reason**: Identifies the reason the record wasn't assigned to a seller.
    - **Assignment attempt**: Identifies the last time an attempt was made to assign the record.

## Understand the priority of rule for unassigned records  

A record can remain unassigned due to several reasons. These reasons are categorized as failure rules and prioritized in the following order of importance. The highest priority failure is displayed in the **Monitoring** grid for unassigned records:

1. **Distribution to seller failed**: This is the highest priority failure. The rule was unable to assign the record to the seller and this could be due to reasons such as seller lacks security role privileges or eligible sellers don't have capacity.  
1. **Seller match failed**: This failure means that the system couldn't find a suitable seller to assign the record.
1. **Entity match failed**: This failure means that the record didn't meet the conditions defined in the rule.
1. **Record is aged**: This is the lowest priority. It means that the record was created before the specified time period in the rule.

If there are multiple rules which ran for a record and failed to assign the record to a seller, the highest priority failure is considered and an appropriate reason is displayed in the **Monitoring** grid.

The reasons for the failure to assign are defined as described in the [Reasons records might be left unassigned](#reasons-records-might-be-left-unassigned) section.

## Reasons records might be left unassigned

The reason a lead or opportunity wasn't assigned automatically is shown in the **Status reason** column in the list of unassigned records. Records might be left unassigned for the following reasons:

- Eligible sellers don't have availability: No sellers who are able to be assigned automatically were available when the assignment rules ran. Assign the record manually, or [run the assignment rules](#run-assignment-rules) again in case more sellers are available now.

- Eligible sellers don't have capacity: No sellers who are able to be assigned automatically could take on more work when the assignment rules ran. Assign the record manually, or [run the assignment rules](#run-assignment-rules) again in case more sellers can accept work now.

- No sellers meet the conditions: No sellers met the assignment criteria when the assignment rules ran. Make sure your assignment rules include all eligible sellers, or create one that does, and [run the assignment rules](#run-assignment-rules) again.

- Record doesn't meet any conditions: The record doesn't meet the assignment criteria. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and [run the assignment rules](#run-assignment-rules) again.

- No assignment rule for this record's segment: The segment the record is connected to doesn't match an active assignment rule. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and [run the assignment rules](#run-assignment-rules) again.

- Seller lacks security role privileges: A seller met the assignment criteria but isn't able to be assigned automatically. Make sure your sellers are in the proper security roles and you included all the necessary security roles in your work assignment settings, and [run the assignment rules](#run-assignment-rules) again.

- There was an issue with the server: A problem with the server that your tenant is hosted on caused the assignment rules not to run. [run the assignment rules](#run-assignment-rules) again.

## Run assignment rules

After you address the [reasons the records were left unassigned](#reasons-records-might-be-left-unassigned), run the assignment rules again. Up to 500 records are considered for assignment on each run, with older records taking priority over newer ones. You can run the rules immediately or schedule them to run later.

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select a **Record type** to view segments of that type.

1. Select or open a segment that has unassigned records, and then select **Segment properties**.

1. Under **Run assignment rules for unassigned *record type***, select **Run now**.

    To run the rules later, select **+ Schedule run**, and then select a **Start date**, the days of the week on which the schedule should run, and up to two times it should run on those days. When you're finished, select **Save schedule**.

    :::image type="content" source="media/sa-ar-run-reassignment-schedule-configuration-side-pane.png" alt-text="Screenshot of the Schedule run pane.":::

    Assignment rule schedules run automatically. A segment can have one scheduled run that fires up to twice a day. For example, you might schedule high-priority segments to run assignment rules every weekday at 6:00 AM and 2:00 PM. Rules for lower-priority segments might run every Friday at 5:00 PM.

### View reassignment run history

The assignment run history is a record of each time a segment's assignment rules were run and what the results were. You can see the date and time a run started, how long it took, the number of records that were assigned, the run's status, and whether it was triggered manually or ran on schedule.

In the **Run assignment rules for *segment name*** pane, select **Show history**.

### Override, edit, or delete an assignment rule schedule

To override the scheduled run of a segment's assignment rules and run the rules immediately, select **Run now**.

To edit the schedule, select the pencil icon.

To delete the schedule, select the trashcan icon.

:::image type="content" source="media/sa-ar-run-reassignment-schedule-confirmation-side-pane.png" alt-text="Screenshot of the Run assignment rules pane, with a run scheduled and the edit and delete icons highlighted.":::

## Assign records manually

If you don't have an assignment rule for a lead or opportunity, you can assign it to a salesperson or sales team yourself.

1. [View unassigned records](#view-unassigned-records).

1. Select one or more records to assign to the same salesperson or team, and then select **Assign**.

    :::image type="content" source="media/sa-ar-assign-unassigned-records-select-records.png" alt-text="Screenshot of an unassigned record selected, with the Assign button highlighted.":::

1. Select a seller. To assign the record to a team instead, select the **Teams** tab, and then select a sales team. [Learn more about sales teams and assignment rules](manage-sales-teams.md).

    To limit your selection to sellers who can be assigned by a rule, turn on **Show eligible sellers**.

1. Select **Assign**.

The record is assigned to the seller or team and the list refreshes to remove the record.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
