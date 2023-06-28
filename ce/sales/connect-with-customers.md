---
title: Connect with customers through your work list or the Up next widget
description: Learn how to use the Up next widget or the My work list to connect with customers by phone, email, and Teams meeting in Dynamics 365 Sales.
ms.date: 02/10/2023
ms.topic: article
author: udaykirang
ms.author: udag
---

# Connect with customers through your work list or the Up next widget

As a seller using Dynamics 365 Sales, you can connect with your customers daily by phone, email, and in Teams meetings. You don't lose context or need to switch among multiple applications.

When a sequence contains a customer contact activity, your [work list](prioritize-sales-pipeline-through-work-list.md#view-my-records-by-using-the-work-list) and the [**Up next**](understand-the-up-next-widget.md) widget display the corresponding icon (phone, email, or Teams meeting). After you make the phone call, send the email, or attend the meeting, you'll mark the activity complete and continue with the next activity in the sequence. If an activity doesn't need to be completed or you can't connect with a customer, you can [skip or snooze the activity](#skip-or-snooze-an-activity). You can add notes to activities to help you remember important information.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Call a customer

You can make a phone call to your customer from the record in the **My work** list or an activity in the **Up next** widget. The app calls the contact's business phone number if there's one. If no business phone number is available, the app calls the contact's mobile phone number. If both a business and a mobile phone number aren't available, the app displays the softphone dialer for you to dial a phone number manually. If the contact has indicated they don't want to be contacted by phone, the app displays a warning message before you make the call.

To make a call from your work list, select the phone icon in the **My work** list record.

:::image type="content" source="media/my-work-list-call.png" alt-text="Screenshot of making a phone call from the My work list.":::

To make a call from the **Up next** widget, select **Call** in the activity. After you've successfully made the phone call, mark the **Phone Call** activity complete.

:::image type="content" source="media/up-next-widget-call.png" alt-text="Screenshot of making a phone call from the Up next widget.":::

When you make a phone call, the app creates a **Phone Call** activity and links it to the lead or opportunity. The **Phone Call** activity captures the following information:

- **Subject**: The name of the activity in the **Up next** widget
- **Call From**: The name of the person who made the call
- **Call To**: The name of the person who was called
- **Phone Number**: The phone number of the person who was called
- **Direction**: The direction of the call; always **Outgoing**

:::image type="content" source="media/phone-call-activity.png" alt-text="Screenshot of a Phone Call activity.":::

## Send an email to a customer

You can send an email to your customer from the record in the **My work** list or an activity in the **Up next** widget. If the email address of a contact isn't available, the app displays a warning message. When you send an email, the app creates an **Email** activity and links it to the lead or opportunity.

If you try to navigate to another record or send an email from another lead or opportunity while you're composing an email, the app warns you to save the email first.

To send an email from your work list, select the email icon in the **My work** list record.

:::image type="content" source="media/my-work-list-email.png" alt-text="Screenshot of sending email from the My work list.":::

To send an email from the **Up next** widget immediately, select **Email** in the activity.

:::image type="content" source="media/up-next-widget-email-schedule-suggestion.png" alt-text="Screenshot of an Email activity in the Up next widget, with Email and Suggested send time highlighted.":::

You can also compose an email from the **Up next** widget and send it later.

1. Select **Suggested send time**.

    > [!NOTE]
    > If email suggestions don't appear, ask your administrator to [turn on email engagement](configure-email-engagement.md) for your organization.

1. The app suggests when the recipient is likely to read the email. To accept the suggestion or send the email at a different time, select **Schedule email**.

    :::image type="content" source="media/up-next-widget-email-schedule-view-suggestion.png" alt-text="Screenshot of the email schedule suggestion.":::

1. The **Schedule email** box fills with the suggested time. Select a different time if you like, and then select **Schedule email**.

    The email task closes and the app adds it to the timeline. The status of the email task remains **Pending** until the email is sent at the scheduled time. Then the status changes to **Complete**.

## Join a Teams meeting or view appointment details

You can create an appointment in Dynamics 365 or create one in Outlook and track it in Dynamics 365. In both cases, the appointment is associated with a record and appears in your work list. If you created the appointment as a Teams meeting, the work list and **Up next** widget display the Teams meeting icon, and you can join the meeting by selecting it. If the appointment isn't associated with a Teams meeting, you can view the appointment details, such as participants, scheduled time, and description.

To join a Teams meeting from your work list, select the Teams meeting icon in the **My work** list record.

:::image type="content" source="media/sa-join-teams-meeting-work-list.png" alt-text="Screenshot of joining a Teams meeting from the My work list.":::

To join a Teams meeting from the **Up next** widget, select **Join** in the activity.

:::image type="content" source="media/sa-join-teams-meeting-upnext-widget.png" alt-text="Screenshot of joining a Teams meeting from the Up next widget.":::

To open an appointment from your work list, select the **Event** icon in the **My work** list record.

:::image type="content" source="media/sa-create-appointment-work-list.png" alt-text="Screenshot of opening an appointment from the My work list.":::

To open an appointment from the **Up next** widget, select **Open** in the activity.

:::image type="content" source="media/sa-create-appointment-upnext-widget.png" alt-text="Screenshot of opening an appointment from the Up next widget.":::

## Send a text message to customers

You can send a text message (SMS) to your customer from the record in the My work list or an activity in the **Up next** widget.  

A phone number must be available for the contact you're sending the message to. If not, a warning message is displayed. When you send an SMS, the app creates an activity and links it to the record and updates the Timeline wall accordingly.

You can select the text message option in the following ways:  

-	From your work list, hover over the work list card and then select the message icon. 

-	From the **Up next** widget, select **Text message** in the activity.

When the text message is selected, the conversation pane opens, allowing you to compose your message or select a template through the text box to send. Additionally, if you have multiple phone numbers associated, you can choose which number to use for sending the message. 

:::image type="content" source="media/sms-text-message-pane.png" alt-text="Screenshot of the conversation pane.":::

The message history is linked to the record and available for you or other sellers who work on the record for reference. Also, you can view replies from the customers and respond to them through the conversation pane. More information: [Manage text message conversations](manage-text-message-communications.md)

## Add a note to an activity

Notes that you add to an activity appear on the record's timeline.

> [!NOTE]
> If you're using custom forms and the timeline doesn't appear on a form, add it. [Learn how to add, configure, move, or delete sections on a form](/power-apps/maker/model-driven-apps/add-move-or-delete-sections-on-form).

You can add a note when an activity is in progress.

1. In the activity in the **Up next** widget, select **More options** (**...**) > **+ Note**.

    :::image type="content" source="media/sa-add-notes-up-next-widget.png" alt-text="Screenshot of adding a note to an activity.":::

1. Enter your note, and then select **Save**.

    :::image type="content" source="media/sa-provide-notes-up-next-widget.png" alt-text="Screenshot of entering and saving a note.":::

You can add a note when you mark an activity complete, too.

1. In the activity, select **Mark complete**.

1. Enter your note, and then select **Got it**.

    :::image type="content" source="media/sa-provide-notes-mark-complete-dialog.png" alt-text="Screenshot of entering a note while marking an activity complete.":::

## Skip or snooze an activity

You can skip an activity if it doesn't need to be completed. The next activity in the sequence takes the place of the skipped activity in the work list, and the skipped activity is moved to the completed list. If you skip a manual task that isn't part of a sequence, it's marked as canceled.

To skip an activity, in the **Up next** widget, select **More actions** (**...**) > **Skip**.

:::image type="content" source="media/skip-activity.png" alt-text="Screenshot of skipping an activity.":::

If you can't connect with a customer by the due date and want to follow up later, you can snooze the activity and select a new date and time to connect. You can't snooze a manual task.

1. In the **Up next** widget, select **More actions** (**...**) > **Snooze**.

    :::image type="content" source="media/postpone-activity.png" alt-text="Screenshot of snoozing an activity.":::

1. Select a new date and time by which the activity should be completed, and then select **Save**.

    :::image type="content" source="media/snooze-time.png" alt-text="Screenshot of selecting a snooze date and time.":::

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)  
[Understand the Up next widget](understand-the-up-next-widget.md)  
[Use Outlook category to track appointments and emails](/power-platform/admin/use-outlook-category-track-appointments-emails)  
[Track Outlook appointments in Dynamics 365 for Outlook](/dynamics365/outlook-addin/user-guide/track-outlook-appointments)  
[Integrate a sample softphone dialer with Dynamics 365 Sales](integrate-sample-softphone.md)  
[Microsoft Teams integration with customer engagement apps in Dynamics 365](/dynamics365/teams-integration/teams-integration) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
