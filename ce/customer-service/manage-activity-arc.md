---
title: Manage activity monitor to review and track rules
description: How to manage activity monitor to review and track rules
author: gandhamm
ms.author: mgandham
ms.service: dynamics-365
ms.topic: how-to 
ms.date: 09/22/2023
---


# Manage activity monitor to review and track rules

You can review and track the health of the automatic record creation rules and resolve issues around them. By default, the activity monitor captures all the states. You can customize the events that you want to monitor by deselecting the monitor options in the application.

> [!NOTE]
> - Activity monitor is supported only with online environments, such as cloud applications, and not with on-premises environments.
> - The activity monitor tracks the rules only until they're evaluated in Customer Service before the rule is run in Power Automate.

Perform the following steps to view the activity monitor details for the rules:

- In Customer Service admin center, the Customer support overview page displays the number of activity monitor events that ran in the past week along with their status.
-  You can use either the **Activity monitor events for last 7 days** or **All activity monitor events** to view the activity monitor details. Navigate to the views as follows:<br>
  - Select **Activity monitor events(past 7 days)** on Customer support overview to view the activity events for the last 7 days on the **Activity monitor events for last 7 days** page.
    :::image type="content" source="media/email-activity-monitor.png" alt-text="A screenshot of the Activity monitor events for last seven days page.":::
  - Select **Case Settings** > **Automatic record creation and update rules** > **Record creation and update rules** and then select **View activity monitor** on the command bar to view the list of all the activity events on the **All activity monitor events** page.
  You can also switch between both these views.
- The following details are available for the rules in the activity views:
   - **Current state:** Displays the state, such as, Failed, Skipped, or Ready for Power Automate.
  - **Rule name:** Name of the record creation rule.
  - **Monitored activity type:** Activity type, such as email, task, or appointment.
  - **Monitored activity item:** Displays the subject of the activity type.
  - **Condition name:** The name of the condition in which the issue occurred.
  - **Reason:** Displays information on how the rule was handled. For example, if the **Current state** for a rule is Skipped because an email is sent from an unknown sender who isn't added to **Contacts**, a case isn't created because the rule condition, **Allow email from unknown senders** is set to No.
  - **Recommendation**: Displays the steps you can follow to resolve the issue. 
  For example, if an email was sent from an unknown sender and the **Current state** for a rule is **Skipped** with **Reason**, 'Email is coming from an unknown sender', the application displays the recommendation  to set **Allow email from unknown senders** to Yes.
  - For example, the **Current state** for a rule is skipped with the **Reason** that an active case is already connected to this record. The application displays the following recommendation: the incoming email is related to a parent email linked to an existing case. You can turn off the **use correlation to track email conversations** if you'd like to change the existing behavior.
    > [!NOTE]
    > Hyperlinks aren't displayed in **Recommendation**. If you'd like to see the hyperlinks in the recommended resolution, double click the record to view the activity monitor event details that are displayed on the **Activity monitor** page.
  - **Evaluated on:** Displays the date and time of the issue.
- You can select a rule or activity to view the activity monitoring summary that is displayed on the **Activity monitor** <rule_name> page.
:::image type="content" source="media/activity-monitor-page.png" alt-text="A screenshot of the Activity monitor rule_name page.":::
  
> [!NOTE]
> - If you navigate to an active rule from the activity monitor page, a message appears stating that the rule is active and therefore is read-only.
> - The legacy rules will also be monitored and listed on the activity monitor view.
- If you don't want to monitor any of the following states, you can deselect the state on the **Monitor options** dialog.
   - Ready for Power Automate / workflow
   - Failed
   - Skipped
