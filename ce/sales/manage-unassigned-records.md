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

[Assignment rules](./create-and-activate-assignment-rule.md) can miss leads and opportunities, leaving them unassigned. As an administrator, sales manager, or sequence manager, you can monitor these records to catch any that aren't assigned. You can view the number of unassigned records by segment and record type, and view detailed information about the records and assign them to a seller or sales team.

If you find unassigned records, you can:

- [Assign the records manually](#assign-records-manually).
- Address the [reasons the records were skipped](#reasons-records-may-be-left-unassigned), and [run your assignment rules again](#run-assignment-rules).
- [Create an assignment rule](./create-and-activate-assignment-rule.md) to cover conditions you didn't anticipate.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## View the number of unassigned records

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Assignment rules**.

    The **Unassigned records** column shows the number of records that are unassigned in each segment.

    :::image type="content" source="./media/sa-ar-view-unassigned-records-home-page-unassigned-column.png" alt-text="Screenshot of the assignment rules home page with unassigned records column.":::

If no segment is attached to a rule, then the rule is grouped under **No segments**.

## View details and act on unassigned records

A red dot on the **Monitor** tab in the **Assignment rules** page indicates there are unassigned records. If you don't see a red dot, it means that all records are assigned.

:::image type="content" source="media/sa-ar-view-unassigned-records-home-page.png" alt-text="Screenshot of the Assignment rules home page, with the Monitor tab highlighted.":::

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Assignment rules**.

1. Select the **Monitor** tab.

    :::image type="content" source="media/sa-ar-view-unassigned-records-view-records.png" alt-text="Screenshot of the list of unassigned lead records, with the Assignment due in and Status reason columns highlighted.":::

    The **Unassigned *records*** tab shows the following columns by default. To change the columns in the view, select **Edit columns**.

    - **Name**, **Topic**, **Created on**: Identifies the lead or opportunity record.
    - **Segment**: Identifies the segment the record is connected to.
    - **Assignment rule**: Identifies the rule that tried to assign the record.
    - **Assignment due in**: If a time limit is set in the assignment rule, displays the number of hours left for the record to be assigned before it's marked overdue. If no time limit is set, displays a hyphen (**&dash;**).
    - **Status Reason**: Identifies the reason the record isn't assigned to a seller.

1. [Assign the records manually](#assign-records-manually), or address the [reason the records were left unassigned](#reasons-records-may-be-left-unassigned) and [run your assignment rules again](#run-assignment-rules).

### Assign records manually

If you don't have an assignment rule for a lead or opportunity, you can assign it to a salesperson or sales team yourself.

1. [View unassigned records](#view-details-and-act-on-unassigned-records).

1. Select one or more records to assign to the same salesperson or team, and then select **Assign**.

    :::image type="content" source="media/sa-ar-assign-unassigned-records-select-records.png" alt-text="Screenshot of an unassigned record selected, with the Assign button highlighted.":::

1. Select a seller. To assign the record to a team instead, select the **Teams** tab, and then select a sales team. [Learn more about sales teams and assignment rules](manage-sales-teams.md).

    To limit your selection to sellers who can be assigned by a rule, turn on **Show eligible sellers**.

1. Select **Assign**.

The record is assigned to the seller or team and the list refreshes to remove the record.

To view details of the assigned records, select the **Assignment history** tab.

### Run assignment rules

After you address the [reasons the records were left unassigned](#reasons-records-may-be-left-unassigned), run the assignment rules again. Up to 500 records are considered for assignment on each run, with older records taking priority over newer ones. You can run the rules immediately or schedule them to run later.

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Assignment rules**.

1. Select the calendar icon in a segment that has unassigned records.

    :::image type="content" source="media/sa-ar-run-reassignment-select-reassignment.png" alt-text="Screenshot of the Assignment rules page, with the calendar icon highlighted.":::

    The **Run assignment rules for *segment name*** pane opens. It shows the number of records that aren't assigned and the last date and time the assignment rules were run. To [view the assignment history](#view-assignment-run-history), select **Show history**.

    :::image type="content" source="media/sa-ar-run-reassignment-side-pane.png" alt-text="Screenshot of the Run assignment rules pane.":::

1. To run the rules immediately, select **Run now**. *Or*, to run the rules later:

    Select **+ Schedule run**, and then select a **Start date**, the days of the week on which the schedule should run, and up to two times it should run on those days. When you're finished, select **Save schedule**.

    :::image type="content" source="media/sa-ar-run-reassignment-schedule-configuration-side-pane.png" alt-text="Screenshot of the Schedule run pane.":::

    Assignment rule schedules run automatically. A segment can have one scheduled run that fires up to twice a day. For example, you might schedule high-priority segments to run assignment rules every weekday at 6:00 AM and 2:00 PM. Rules for lower-priority segments might run every Friday at 5:00 PM.

#### Override, edit, or delete an assignment rule schedule

To override the scheduled run of a segment's assignment rules and run the rules immediately, select **Run now**.

To edit the schedule, select the pencil icon.

To delete the schedule, select the trashcan icon.

:::image type="content" source="media/sa-ar-run-reassignment-schedule-confirmation-side-pane.png" alt-text="Screenshot of the Run assignment rules pane, with a run scheduled and the edit and delete icons highlighted.":::

#### View assignment run history

The assignment run history is a record of each time a segment's assignment rules were run and what the results were. You can see the date and time a run started, how long it took, the number of records that were assigned, the run's status, and whether it was triggered manually or ran on schedule.

In the **Run assignment rules for *segment name*** pane, select **Show history**.

## Reasons records might be left unassigned

The reason a lead or opportunity wasn't assigned automatically is shown in the **Status reason** column in the list of unassigned records. Records might be included in the list for the following reasons:

- Eligible sellers don't have availability: No sellers who are able to be assigned automatically were available when the assignment rules ran. Assign the record manually, or [run the assignment rules](#run-assignment-rules) again in case more sellers are available now.

- Eligible sellers don't have capacity: No sellers who are able to be assigned automatically could take on more work when the assignment rules ran. Assign the record manually, or [run the assignment rules](#run-assignment-rules) again in case more sellers can accept work now.

- No sellers meet the conditions: No sellers met the assignment criteria when the assignment rules ran. Make sure your assignment rules include all eligible sellers, or create one that does, and [run the assignment rules](#run-assignment-rules) again.

- Record doesn't meet any conditions: The record doesn't meet the assignment criteria. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and [run the assignment rules](#run-assignment-rules) again.

- No assignment rule for this record's segment: The segment the record is connected to doesn't match an active assignment rule. Assign it manually, or create a rule that will assign it, and any future records like it, automatically, and [run the assignment rules](#run-assignment-rules) again.

- Seller lacks security role privileges: A seller met the assignment criteria but isn't able to be assigned automatically. Make sure your sellers are in the proper security roles and you included all the necessary security roles in your work assignment settings, and [run the assignment rules](#run-assignment-rules) again.

- There was an issue with the server: A problem with the server that your tenant is hosted on caused the assignment rules not to run. [run the assignment rules](#run-assignment-rules) again.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Automatically assign leads and opportunities](create-manage-assignment-rules.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
