---
title: View and work on seller insights
description: The seller insights feature displays contextual and intelligent insights about Dynamics 365 Sales records based on certain criteria. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# View and work on seller insights (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The seller insights feature displays contextual and intelligent insights about Dynamics 365 Sales records based on certain criteria. For example, sellers can view insights about an account that they’re working on and perform suggested actions to move the deal forward or assign the insight to another colleague to work on. 

## Prerequisites

- Your administrator must have enabled the Seller insights feature for your organization. More information: [Enable Seller insight](enable-seller-insights.md)
-	Your administrator must have granted access to your security role to view and act on seller insights. More information: [Manage access to view insights](manage-access-view-insights.md)

## View insights

You can view the insight for a record from the Sales Accelerator work list. Insights are indicated with a bulb icon in the work list. View the insight through the following items in the sales accelerator workspace:

- **Work list items**: You can see only the heading of the insight. From there, you can do various tasks such as accepting, declining, or assigning to another individual. A blue dot is displayed next to the insight to indicate that it hasn't been viewed.
- **Up next widget**: You can see the insight with detailed information such as, due date, estimated revenue, and insight details. From there you can do tasks such as accept, decline, and or assigning to another individual. 

For more information on how to do tasks, see [Work on insights](#work-on-insights).

The following image is an example of insights displayed in the work list and the Up next widget

:::image type="content" source="media/si-wi-uw-insights.png" alt-text="A screenshot showing seller insights in the work list item and the up next widget.":::  

## Work on insights

When insights are displayed, as an owner, you can do basic tasks such as accepting, declining, or assigning the insight to another seller.  

- **Accept**: If you find an insight relevant and believe it helps move the deal forward, select Accept. Once accepted, you can do the following actions based on the requirement:
    - [Connect to a sequence](#connect-to-a-sequence). 
    - [Create an activity](#create-an-activity).
    - [Close the insight](#close-the-insight).

- **Decline**: If you find that an insight isn't relevant to the record, do the following:  
    1.	Select **Decline**.
    1.	On the confirmation message, enter the reason to decline the insight and select **Submit**.
        The insight is removed from the record.
- **Assign to a seller**: If you find that an insight is relevant to another seller who might be better suited to work on it, select **Assign to a seller** and select a seller or team to assign to. The insight is assigned to the selected users or team and removed from your list.  

    > [!NOTE]
    > If you’re the owner of the insight and the assignee didn’t accept the insights, you can assign it back to you.

### Connect to a sequence

If a record is connected to a sequence, a series of activities defined in the sequence are displayed when you open the record. Complete the activities accordingly to move the deal forward.  

To connect a sequence, select **Connect Sequence**. If a sequence is already defined for the insight, it’s automatically connected. If not, create one and then connect it to the insight.  

More information: [Create and connect sequences for yourself](create-sequence-seller.md).

Open the record to view and work on the tasks. When a task is completed, the timeline of the record is automatically updated. 
To view the list of activities in the sequence and the current step that the record is in, select the sequence name.

### Create an activity

Based on the insight, you can add manual activities such as an appointment, email, phone call, or task to the record. To add an activity:  

1.	Select **Create activity** and then choose the activity.  
1.	Enter the information about the activity and save.  

The activity is created for the insight and added to the record. You can view the activities on the timeline wall.

### Close the insight

After you complete the activities defined for the insights, mark the insight as complete. To close the insight:

1.	Select **Close insight**.
1.	In the confirmation dialog, enter the reason and then select **Submit**.

The insight is marked as complete and removed from the record. The timeline of the record is updated accordingly.

## Filter insights

The work list displays all records based on your related work items. To view the insights that you're interested in, you can filter the records. 

Select the **Filter** icon from the work list command bar and choose the filters that meet your requirements. The following default insights filters are available:

- **Insights view type**: Select the view type to view only the work items with insights. Select **View type** as **Insights**.
- **Insights status**: Select the filter to view work items that are in active or in progress status. 
- **Insights with activities**: Select the filter to view work item that has activities defined for the insights.  
- **Insights assigned to others**: Select the filter to view work items that are assigned to other sellers.

Also, you can create custom filters for insights. More information: [Custom filters](prioritize-sales-pipeline-through-work-list.md#custom-filters).

### See also

[Enable seller insights](enable-seller-insights.md)  
[Get intelligent insights to improve sales](seller-insights-intro.md)