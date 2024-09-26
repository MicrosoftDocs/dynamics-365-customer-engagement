---
title: Use activity monitor to review and track rules
description: Manage activity monitor to review and track rules in Customer Service to view activity events, states, rule names, and more.
author: gandhamm
ms.author: mgandham
ms.topic: how-to
ms.collection:
ms.date: 09/26/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:10/03/2023
---


# Use activity monitor to review and track rules

You can review and track the health of the automatic record creation rules and resolve issues around them. By default, the activity monitor captures all the states. You can customize the events that you want to monitor by deselecting the monitor options in the application.

> [!NOTE]
> - The activity monitor works in online environments only, such as cloud applications.
> - The activity monitor tracks the rules until they're evaluated in Customer Service only and before the rule runs in Power Automate.


In Customer Service admin center, **Customer support** > **Overview** > **Case settings** displays the number of activity monitor events that ran in the past week along with their status. You can use either the **Activity monitor events for last 7 days** or **All activity monitor events** to view the activity monitor details.

1. Navigate to the views as follows:<br>
    - Select **Activity monitor events(past 7 days)** on Customer support overview to view the activity events for the last 7 days on the **Activity monitor events for last 7 days** page.
     :::image type="content" source="../media/email-activity-monitor.png" alt-text="A screenshot of the Activity monitor events for last seven days page.":::
    - Select **Case Settings** > **Automatic record creation and update rules** > **Record creation and update rules** and then select **View activity monitor** on the command bar to view the list of all the activity events on the **All activity monitor events** page.
2. The following details are available for the rules in the activity views:
   - **Current state:** Displays the state, such as, Failed, Skipped, or Ready for Power Automate.
   - **Rule name:** Name of the record creation rule.
   - **Monitored activity type:** Activity type, such as email, task, or appointment. By default this is not available on the **Activity monitor events for last 7 days** page. Use **Edit columns** to add the column to the view.
   - **Monitored activity item:** Displays the subject of the activity type.
   - **Condition name:** The name of the condition in which the issue occurred.
   - **Reason:** Displays information on how the rule was handled. For example, a case isn't created if the **Current state** for a rule is Skipped because an email is sent from an unknown sender who isn't added to **Contacts** and the rule condition, **Allow email from unknown senders** is set to No.
   - **Recommendation**: Displays the steps you can follow to resolve the issue. For example, if an email was sent from an unknown sender and the **Current state** for a rule is **Skipped** with **Reason**, Email is coming from an unknown sender, the application displays the recommendation  to set **Allow email from unknown senders** to Yes.
     > [!NOTE]
     > The text in the **Recommendation** field doesn't display hyperlinks. Select the activity record to see the hyperlinks in the recommended resolution in the **Activity monitor** page.
   - **Evaluated on:** Displays the date and time of the issue.
1. Select a rule or activity to view the activity monitoring summary that is displayed on the **Activity monitor** <rule_name> page.
   - If you navigate to an active rule from the activity monitor page, a message appears stating that the rule is active and therefore is read-only.
   - The legacy rules will also be monitored and listed on the activity monitor view.
 :::image type="content" source="../media/activity-monitor-page.png" alt-text="A screenshot of the Activity monitor rule_name page.":::
1. If you don't want to monitor any of the following states, you can clear the selection on the **Monitor options** dialog.
   - Ready for Power Automate / workflow
   - Failed
   - Skipped

> [!NOTE]
> To reprocess queue items that didn't succeed, go to **All Activities**, select the activity you want to run, and then select **Add To Queue**. Learn more in [Manage automatic record creation and update rule from a queue form](automatically-create-update-records.md#manage-automatic-record-creation-and-update-rule-from-a-queue-form).

## Related information

[Automatically create or update records](automatically-create-update-records.md)