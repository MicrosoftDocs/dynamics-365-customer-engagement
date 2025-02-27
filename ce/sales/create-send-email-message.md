---
title: Create and send an email message
description: Learn how to create and send email messages to your customers using email engagement features in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 02/27/2025
ms.custom: bap-template
---

# Create and send an email message <a name="CreateAndSend"></a>

In general, you can send email messages to your customers directly from Dynamics 365 Sales. However, When the email engagement feature is enabled, more choices are available for emails, such as follow or unfollow, when you compose an email.

Contact your administrator if you don't see the email engagement features described here. More information: [Configure email engagement](configure-email-engagement.md).

## Create a message <a name="NewMessage"></a>  

The features of email engagement apply to every email that you send through Dynamics 365 Sales. When you send an email, it automatically adds an email activity to the record, and that record is set as the message's **Regarding** value. Also, the email engagement feature collects key performance indicators (KPIs) and determines where the email is displayed based on the recipients (To, From, and Copy-to addresses). 

>[!NOTE]
>
>- Emails can't be tracked if a recipient chooses to block. More information: [blocks followed messages](configure-individuals-privacy-preferences.md).
>- Email engagement isn't supported when you send bulk email.  

Before creating the email, let's understand the different options that are available in the email form:  

:::image type="content" source="media/new-email-page-email-engagement-callouts.png" alt-text="Screenshot of the New Email page in Dynamics 365 Sales, with email engagement features highlighted." lightbox="media/new-email-page-email-engagement-callouts.png":::

1. **Attachment**: A list of files attached to your email along with controls for adding, removing, and modifying the attachments.  
1. **Follow/Don't Follow**: Turn on following to track your customer's engagement with the message or turn it off to stop tracking. Other controls and links appear as needed, such as when a recipient doesn't allow following. More information: [Follow or unfollow a message](#EnableTrackingOnMessages).  
1. **Send Later**: Set the delivery time for your message if you don't want to send it right away. Recommended delivery times may appear here, depending on the recipient's time zone.  
1. **Set a Reminder**: Set a reminder to follow up at a specific time. For example, you might want to get an alert if the message remains unopened for three days.  
1. **Insert Template**: Insert standard text that you can revise as needed. Your organization can have multiple templates depending on the business requirements, such as a meeting follow-up or an introduction. Email engagement suggests a template based on previous performance.

**To create and send an email**:

1. Open the record you want to add the activity to (typically a contact, opportunity, lead, or account).  
1. In the **Timeline** section, select **+** (**Create a timeline record**) > **Email**.  
1. Select a recipient and enter the message subject.  
1. Enter the body of your message, or [insert an email template](#EmailTemplates).  
1. Select **Send**, or select **Save** to save the message as a draft and finish it later.

> [!TIP]
> To add a link to your message, select the text you want to add the link to, press Ctrl+K, and type or paste the link address.

## Use an email template <a name="EmailTemplates"></a>

Email templates are standard messages that you send often, such as introductions, confirmations, thank-you messages, and reminders. They can include dynamic values that are filled in automatically, such as the recipient's name or an order number. They give you a quick start when you're writing common messages.

Email engagement analyzes the performance of all the messages your sales team has sent from Dynamics 365 Sales and identifies the most successful templates. It shows all available templates, but highlights the ones that it found to generate the most opens, replies, or sales.

1. [Create a message](#NewMessage).  
1. On the command bar, select **Insert Template**.  
1. In the **Email templates** window, select the language if needed, and then search for and select a template.  
1. Select **Apply template**.  
    The template content is inserted into the message body.  
1. Customize the template content as needed.  
1. Select **Send**, or select **Save** to save the message as a draft and finish it later.

## Add attachments <a name="FollowedAttachments"></a>

When you attach documents, spreadsheets, or images to your emails, you can follow these attachments to know whether the recipient opened them. You can include both followed and unfollowed attachments in the same email.  
By default, attachments aren't followed. You have to manually follow each attachment you want to track. Also, you can't follow attachments when the message recipients don't allow following.  

1. [Create a message](#NewMessage).  
1. In the **Attachment** section, select **+**.
1. Locate and select the file to attach.  
1. Select **Open**.  
    Depending on the file size, attaching might take several seconds.  
1. Select the attachment to track and then select more options > **Follow**.  
    The attachment is now followed and the **Followed** column shows **Yes**.  

    > [!NOTE]
    > - The **Follow** option is available only when the enhanced attachment feature is disabled. Contact your administrator to [disable the enhanced attachment feature](configure-email-engagement.md#disable-the-enhanced-attachment-feature).  
    > - You can follow attachments that are sent through Dynamics 365 email only. Attachments sent through the Outlook client aren't followed.

1. Select **Send**, or select **Save** to save the message as a draft and finish it later.  

## Follow or unfollow a message <a name="EnableTrackingOnMessages"></a>  

When you follow an email, email engagement can tell you if the recipient opened it, replied to it, opened an attachment, or selected a link in it. More information: [View message interactions with email engagement](email-engagement.md).  

The **Email Engagement** section includes the following indicators and controls:

| Indicator or control | Description |
|----------------------|-------------|
| ![Email follow state on](media/email-follow-state-on.png "Email follow state on") | Indicates you're following the current email, including any links you include, and you have the option to follow any files you attach. Select **Don't Follow** to stop tracking the message.<br>This state is the default for new messages when your organization has turned on email engagement and all the recipients allow following. |
| ![Email follow state off](media/email-follow-state-off.png "Email follow state set off") | Indicates you're not following the current email, including any links you include. You can't follow any attachments either. Select **Follow** to turn on following if the recipients allow it. |
| ![Email follow state blocked](media/email-follow-state-blocked.png "Email follow state blocked") | Indicates that one or more recipients have following set to **Do Not Allow**. You can't follow this message unless you either remove the recipients that don't allow following or change their setting.<br>- Select **View Preferences** to view the recipient names and following preferences in a new window. Select a name to open the recipient's record.<br>- If you removed recipients who don't want to be followed or changed their setting to allow following, select **Retry Follow** to try again.<br>- Select **Don't Follow** to stop trying to follow this message.<br>Within about 15 minutes after a followed message is opened, the system creates an action card in the assistant. The card includes links to the message and related records and action buttons to generate a call activity, snooze the alert, or dismiss it. [Learn more about guided customer communications with assistant](assistant.md). |

## Choose the most effective delivery time <a name="DeliveryTime"></a>

Your email messages might receive more or less attention depending on when they arrive in recipients' inboxes. For example, many people start their day with a full inbox, so messages that arrive overnight must compete for attention and might get put off or even forgotten. Emails that arrive later in the day might get noticed and handled right away. With email engagement, you can compose your email messages when it's convenient for you, but let Dynamics 365 Sales deliver them when it's best for your recipients.

The system sometimes recommends a delivery time based on the recipient's time zone. It assumes a standard workday of 8:00 AM to 5:00 PM, Monday through Friday, and suggests the next closest business hour if you're working outside the recipient's business day. If the message has more than one recipient or no address is provided, the system doesn't make a recommendation.

Your organization must turn on Bing Maps and the recipient must have a physical address in Sales for email engagement to determine the time zone.

If no recommendation is given, or if you prefer to use your own logic, you can specify any delivery time you choose.

The delivery time feature is available for both followed and unfollowed messages.

1. [Create a message](#NewMessage).

1. When you're ready to send the message, look under **Send Later** in the **Email Engagement** section.

    If the system can recommend a delivery time, one appears here. Whether or not it does, you can delay delivery anyway.

1. Select **Send Later**.

    :::image type="content" source="media/send-later-control.png" alt-text="Screenshot of the Send Later control under the email engagement section.":::

    If the system recommended a time or date, then that information is filled in for you. If not, the date is blank. In either case, it uses *your local time*, not the recipient's.

1. In the **Schedule email** dialog box, select date and time for delivery.

    :::image type="content" source="media/send-later-window.png" alt-text="Screenshot of the Schedule Email window.":::

1. Select **Schedule email**.

    The **Delay Send** indicator turns green. Select **Change Schedule** or **Remove Delay** if you need to change the delay or send the message right away. You can change the scheduled delivery at any time before the message is sent.

    :::image type="content" source="media/send-later-control-scheduled.png" alt-text="Screenshot of the Send Later control for a scheduled email in Dynamics 365 Sales.":::

1. Select **Send**, or select **Save** to save the message as a draft and finish it later.

Scheduled messages appear as such in the **Activities** list for the **Regarding** record. Until the scheduled time arrives, you can delete or reschedule the message from there. You can also edit the follow-up reminder date or time. You can't change any other settings after you select **Send**.

## Set a message follow-up reminder <a name="FollowUpAlert"></a>

If you want to make sure you don't forget to follow up on an important email, set a reminder. This feature is available only for sent email.

1. [Create a message](#NewMessage).

1. When you're ready to set the reminder, in the **Email Engagement** section, select **Set a reminder**.

    :::image type="content" source="media/set-reminder-control.png" alt-text="Screenshot of the Set Reminder control under the email engagement section.":::

1. In the **Set Reminder** dialog box, fill in the following fields.

    - **Condition**: Select the condition that triggers the reminder:  
        - **If I do not receive a reply by**: Triggers the reminder if no reply has been received by the **Remind by** date. Only available for followed messages.  
        - **If the email is not opened by**: Triggers the reminder if the message hasn't been opened by the **Remind by** date. Only available for followed messages.  
        - **Remind me anyway at**: Triggers the reminder at the specified time and date, no matter what.  
    - **Remind by**: Specify the date and time to show the reminder when the **Condition** is met.  
    - **Comment**: Optionally, add a note to the reminder.

    :::image type="content" source="media/set-reminder-window.png" alt-text="Screenshot of the Set Reminder window.":::

1. Select **OK** to save your settings and close the window.

    The **Set Reminder** indicator turns blue and a short summary of your reminder settings appears. After the reminder time passes, the summary updates to indicate this. Select **Change Reminder** or **Remove Reminder** if you need to change the reminder or remove it.

    :::image type="content" source="media/set-reminder-scheduled.png" alt-text="Screenshot of the reminder for a scheduled activity in Dynamics 365 Sales.":::

1. Select **Send**, or select **Save** to save the message as a draft and finish it later.

When the reminder is triggered, the system creates an action card in the assistant. The card is given high priority, so you should see it right away. The card includes links to the message and related records and action buttons to snooze or dismiss the alert. [Learn more about email reminder card](action-cards-reference.md#EmailReminder).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Turn on email engagement](configure-email-engagement.md)  
[View message interactions with email engagement](email-engagement.md)  
[Configure privacy preferences](configure-individuals-privacy-preferences.md)  
[Create templates for email](/dynamics365/customer-engagement/admin/create-templates-email)
