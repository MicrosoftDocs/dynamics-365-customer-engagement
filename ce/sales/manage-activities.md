---
title: Track and manage activities
description: Track and manage customer communications with Sales activities such as emails, phone calls, tasks, and appointments.
ms.date: 04/30/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - ai-gen-docs-bap
  - ai-gen-desc
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-activitypointer
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Track and manage activities 

Activities in Dynamics 365 Sales help you build stronger customer relationships by creating a complete record of every interaction. When you log emails, phone calls, meetings, and tasks, your team can see the full context of your customer relationships, avoid duplicating efforts, and follow up more effectively.

For example, when you record a phone call with a prospect about pricing, that information is automatically attached to their record. Later, when a colleague opens the same prospect's account, they'll see that conversation and won't waste time covering the same ground again. The system automatically timestamps each activity and shows who created it, so your team always knows the latest status.

By tracking all your customer interactions—every email, phone call, task, and appointment—you create a complete history that your entire team can reference. This builds trust with customers and ensures no opportunity falls through the cracks. 

## Find your activities

Find your activities under **My Work** > **Activities** in the site map.  

## See activities in Kanban, Calendar, Focused, or Read-only Grid view

> [!NOTE]
> - The **Save As** option is available only when your administrator adds one or more view types to the **Activity** grid through system customizations.  
> - To add the **Kanban** view to the **Activity** grid, see [Add the Kanban control to Opportunity or Activity entities](add-kanban-control.md). By following the steps in the article, you can add other views such as **Calendar** and **Pipeline view**.

1. In the site map, select **Activities**.

1. On the command bar, select **Show As** and then choose the view type you want to see: **Focused**, **Calendar**, **Kanban**, or **Read Only Grid**.

    :::image type="content" source="media/activity-show-as-kanban-view.png" alt-text="Screenshot of different views available in the activity grid.":::
  
The following view types are supported for the **Activity** grid:

- **Read Only Grid.** Shows a list of all activities.  
- **Calendar.** Shows a calendar with a list of the day's scheduled activities and the associated deals.  
- **Focused.** Shows a filtered list of activities that are most relevant to you.  
- **Kanban.** Shows a visual representation of your sales activities in their different states. This view lets you see the status of every activity in your pipeline and drag them to move from one status to another (for example, Open, Completed, Canceled, Scheduled). More information: [Work with activities in the Kanban view](activity-kanban-view.md)

## Change your activities view

Switch between different views to focus on the activities that matter most. You can view your own activities, your team's activities, or filter by other criteria. 

1. In the site map, under **My Work**, select **Activities**.

1. From the Views dropdown, select the view you want to switch to. 

:::image type="content" source="media/activity-view-drop-down.png" alt-text="Screenshot of activity view drop-down list.":::

## Filter the list of activities

Filter the list of activities to see only the ones you're interested in. For example, you can further limit the activities you're seeing in a view by using the activity type filter. The activity type filter allows you to filter activities based on the type, such as email, task, phone call, and so on.

You can also use the **Due** filter to see the activities that are due in a specified time, such as activities that are due today or earlier or activities that are due in the next seven days or earlier.

## Create or edit a new activity

You can create independent activities that aren't associated with any customer or sales record. To do so, in the site map, select **Activities** and then on the command bar, select **Email**, **Phone Call**, or **Task**, depending on which activity you want to create.

To edit an existing activity record, open the activity by selecting its title.

## Add a new activity for a customer

Most often, you add an activity associated with a contact, opportunity, account, or other type of record to help you keep track of all the communication history you have with a customer. You can also add an activity for yourself.

As your organization's relationship with a customer builds over time, you and other people on your team can look through the activity feed as you work with the customer, and see the history of your interactions. You can also include activities in reports to track your ongoing progress.

**To add an activity for a customer:**

1. Open the account record of the customer. Use Quick Search on the navigation bar to find a record quickly.  
1. Select **Related** > **Activities**.
1. On the **Activities** page, select **New Activity** > ***Activity type***.  
1. On the **Quick Create** pane, enter the necessary information and then select **Save and Close**.
 
## Add an activity for yourself  

Add a task or note for yourself when you want a reminder to do something personal, like schedule a doctor's appointment or attend a sporting event.  

Otherwise, to keep a history of your interactions with a customer, add new activities that are associated with a customer's record, so those activities become part of the history that other people on your team can view.  
  
**To add an activity for yourself:**

1. In the site map, under **My Work**, select **Activities**.
1. On the command bar, select the type of activity you want to add, such as **Task** or **Email**.  
1. Fill in the fields and then select **Save and Close**.  
  
## Attach a document  

You can attach documents, spreadsheets, pictures, and just about any type of file to emails and notes.  

**To attach a document to an email:**
  
1. Open the email form.  
1. On the command bar, select **Attach File**.    
1. Browse to and then select the file that you want to attach.  
    The selected file appears in the **Attachment** pane.

**To attach a document to a note:**
  
1. In the **Timeline** pane, select **+** and then select **Note**.  
1. Add the note and select the attachment icon before the **Add note** button.  
1. Browse to and then select the file that you want to attach.  
    The selected file appears above the **Add note** button.
  
## Mark an activity complete  

After you call someone, complete a task, send an email, or go to an appointment, mark the activity for that action as completed.  
  
1. Open the activity.  
1. On the command bar, select **Mark Complete**.  
  
    :::image type="content" source="media/mark-activity-complete.png" alt-text="Screenshot of marking an activity as complete.":::

## Mark several activities complete at the same time  

1. On the list of activities, select all the activities that you want to mark complete.  
1. On the command bar, select **Mark Complete**.  
  
## Best practices for activities  

Here are some suggestions about how to use activities to your organization's best advantage:  
  
- **Add an activity for every customer interaction**. Make sure a customer's history includes a record of every communication you have with them.  
- **Use the right activity type for the action**. It might be tempting to enter a new note that says, "Sent an email to confirm pricing," or "Called the customer to discuss their service case." However, you should add an email or phone call activity to track those types of actions, and use notes for more general text.  
- **Add activities for yourself, too**. You can keep track of your own assignments, events, and notes without associating these activities with a customer.  
  
     Use the **Create** command on the navigation bar. Find these activities in the list by sorting on the **Regarding** column, which is blank to let you know that the activity isn't associated with a customer record.  

- **Keep in mind that activities "roll up" under their associated records.** Let's say you want to remind yourself to follow up with Cecil Langer, a contact who's associated with the account, ​Wingtip Toys. You need to add the task activity to the contact record for Cecil (not for the account, ​Wingtip Toys).  
  
     That way, your task automatically "rolls up" under the account, and you and other people on your team see the task when they're looking at the contact and when they're looking at the account for ​Wingtip Toys. (And they know you've got it handled.) 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Work with activities in the Kanban view](activity-kanban-view.md)  
