---
title: View and work on seller insights
description: The seller insights feature displays contextual and intelligent insights about Dynamics 365 Sales records, based on specific criteria.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to 
ms.collection: 
ms.date: 04/30/2026
ms.custom: bap-template 
---

# View and work on seller insights (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The seller insights feature displays contextual and intelligent insights about Dynamics 365 Sales records, based on specific criteria. For example, sellers can view insights about an account that they're working on. They can then either perform suggested actions to move the deal forward or assign the insight to another colleague to work on.

## Prerequisites

- Your administrator must enable the seller insights feature for your organization. For more information, see [Enable seller insights](enable-seller-insights.md).
- Your administrator must grant your security role access to view and act on seller insights. For more information, see [Manage access to view insights](manage-access-view-insights.md).

## View insights

You can view the insight for a record from the Sales Accelerator work list. Insights are indicated by a light bulb symbol in the work list. View the insight through the following items in the sales accelerator workspace:

- **Work list**: Only the heading of the insight is displayed. From here, you can perform tasks such as accepting the insight, declining it, or assigning it to another individual. A blue dot next to the insight indicates that you didn't view it.
- **Up next widget**: Detailed information for the insight is displayed, such as the due date and estimated revenue. From here, you can perform tasks such as accepting the insight, declining it, or assigning it to another individual.

For more information about how to perform tasks, see the [Work on insights](#work-on-insights) section.

The following image shows an example of insights in the work list and the Up next widget.

:::image type="content" source="media/si-wi-uw-insights.png" alt-text="Screenshot that shows seller insights in the work list and the Up next widget.":::

## Work on insights

As an owner, you can perform basic tasks such as accepting the displayed insights, declining them, or assigning them to another seller.

- **Accept**: If you find that an insight is relevant and believe that it helps move the deal forward, select **Accept**. After you accept the insight, you can perform the following actions, based on the requirement:

    - [Connect to a sequence.](#connect-to-a-sequence)
    - [Create an activity.](#create-an-activity)
    - [Close the insight.](#close-the-insight)

- **Decline**: If you find that an insight isn't relevant to the record, follow these steps:

    1. Select **Decline**.
    1. In the confirmation dialog box, enter your reason for declining the insight, and then select **Submit**. The insight is removed from the record.

- **Assign to a seller**: If you find that an insight is relevant to another seller who might be better suited to work on it, follow these steps:

    1. Select **Assign to a seller**.
    1. Select a seller or team to assign the insight to. The insight is assigned to the selected seller or team, and is removed from your list.

    > [!NOTE]
    > If you're the owner of the insight, and the seller or team that you assigned it to doesn't accept it, you can assign it back to yourself.

### Connect to a sequence

When you open a record that connects to a sequence, you see the activities that the sequence defines. Complete these activities to move the deal forward.

Select **Connect Sequence** to connect a sequence. If an insight already has a sequence, the system connects it automatically. Otherwise, create a sequence and connect it to the insight.

For more information, see [Create and connect sequences for yourself](create-sequence-seller.md).

Open the record to view and work on the tasks. When you complete a task, the timeline of the record automatically updates.

Select the sequence name to view the list of activities in the sequence and the current step that the record is in.

### Create an activity

Based on the insight, add manual activities such as an appointment, email, phone call, or task to the record. To add an activity, follow these steps:

1. Select **Create activity**, and then select the activity.
1. Enter the information about the activity, and save your changes. The activity is created for the insight and added to the record. You can view the activities on the timeline wall.

### Close the insight

After you complete the activities that the insight defines, mark the insight as completed. To close the insight, follow these steps:

1. Select **Close insight**.
1. In the confirmation dialog box, enter your reason for closing the insight, and then select **Submit**. The insight is marked as completed and removed from the record. The timeline of the record updates accordingly.

## Filter insights

The work list displays all records based on your related work items. To view the insights that you're interested in, filter the records.

Select the **Filter** button on the work list command bar, and then select the filters that meet your requirements. The following default insight filters are available:

- **Insights view type**: Select the view type to view only the work items that have insights. Select **Insights** as the view type.
- **Insights status**: Select the filter to view work items that are in an active or in-progress status. 
- **Insights with activities**: Select the filter to view work items where activities are defined for the insights.
- **Insights assigned to others**: Select the filter to view work items that are assigned to other sellers.

You can also create custom filters for insights. For more information, see [Custom filters](prioritize-sales-pipeline-through-work-list.md#custom-filters).

## Related information

[Enable seller insights](enable-seller-insights.md)  
[Get intelligent insights to improve sales](seller-insights-intro.md)
