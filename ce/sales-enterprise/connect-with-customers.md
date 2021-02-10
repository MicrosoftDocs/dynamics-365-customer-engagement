---
title: "Connect with customers in Dynamics 365 Sales | MicrosoftDocs"
description: "Make phone calls or send emails by using a record or the Up next widget in Dynamics 365 Sales."
ms.date: 01/11/2021
ms.service: crm-online
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Connect with customers by using a record or the Up next widget

As a seller using Dynamics 365 Sales, you can connect with your customers daily by using multiple channels, such as phone and email, without losing context or needing to switch among multiple applications. When an activity for contacting customers through a phone call or email appears in a sequence, the corresponding phone or email icons are displayed in your [work list](prioritize-sales-pipeline-through-work-list.md#view-my-records-by-using-the-work-list) record and the [Up next](prioritize-sales-pipeline-through-work-list.md#understand-the-up-next-widget) widget. After you make the phone call or send the email, you mark the activity as complete in the **Up next** widget and continue with the next activity defined in the sequence.

If an activity isn't required to be completed by the due date or you're unable to connect with a customer, you can [skip or snooze the activity](#skip-or-snooze-an-activity).

## Call a customer

You can make a phone call to your customer from a record in the **My work** list or an activity in the **Up next** widget. The business phone number of the contact is used to initiate the call. If the business phone number isn't available, the mobile phone number will be used to initiate the call. If both business and mobile phone number are not available, the softphone dialer is displayed for you to dial a phone number manually. If the contact has set their preference not to be contacted by phone, a warning message is displayed. After you've successfully made the phone call, you must mark the **Phone Call** activity as complete.

When you make a phone call, a **Phone Call** activity is created and linked to the lead or opportunity. The **Phone Call** activity captures the following information:

>[!NOTE]
>Administrator must configure the option to automatically create the phone call activity. To learn more, see **step 7** from [Configure the Sales accelerator](enable-configure-sales-accelerator.md#configure-the-sales-accelerator).

- **Subject**: Name of the activity in the **Up next** widget.
- **Call From**: Name of the contact who made the call.
- **Call To**: Name of the contact to whom the call is made.
- **Phone Number**: Phone number of the contact to whom the call is made.
- **Direction**: Direction of the call. This value will always be **Outgoing**, because the call is made and not received.

> [!div class="mx-imgBorder"]
> ![Phone call activity](media/phone-call-activity.png "Phone call activity")

**To make a phone call**

Do either of the following:

- Select the phone icon in the **My work** list record.

    > [!div class="mx-imgBorder"]
    > ![Make a phone call from the My work list](media/my-work-list-call.png "Make a phone call from the My work list")

- Select **Call** in the activity in the **Up next** widget.

    > [!div class="mx-imgBorder"]
    > ![Make a phone call from the Up next widget](media/up-next-widget-call.png "Make a phone call from the Up next widget")

## Send an email to a customer

You can send an email to your customer from a record in the **My work** list or an activity in the **Up next** widget. If the email address of a contact isn't available, a warning message is displayed. When you send an email, an Email activity is created and linked to the lead or opportunity.

While composing an email, if you try to navigate to another record or send an email from another lead or opportunity, a warning message is displayed to save the email first.

**To send an email**

Do either of the following:

- Select the email icon in the **My work** list record.

    > [!div class="mx-imgBorder"]
    > ![Send email from the My work list](media/my-work-list-email.png "Send email from the My work list")

- Select **Email** in the activity in the **Up next** widget.

    > [!div class="mx-imgBorder"]
    > ![Send email from the Up next widget](media/up-next-widget-email.png "Send email from the Up next widget")

## Skip or snooze an activity

You can skip an activity if it's not required to be completed by the due date. When you skip an activity, it's removed from the sequence and the next activity is displayed for taking action. The skipped activity is moved to the completed list. If you skip a manual task, it's marked as canceled.

If you're unable to connect with a customer by the due date&mdash;but still need to follow up later&mdash;you can snooze the activity, and select a new date and time to connect with the customer. Note that you can't snooze a manual task.

**To skip an activity**

1. In the **Up next** widget, go to the activity you want to skip.

2. Select **More actions** > **Skip item**.

    > [!div class="mx-imgBorder"]
    > ![Skip an activity](media/skip-activity.png "Skip an activity")

The activity is skipped, and the next activity in the sequence is displayed.

**To snooze an activity**

1. In the **Up next** widget, go to the activity you want to snooze.

2. Select **More actions** > **Snooze**.

    > [!div class="mx-imgBorder"]
    > ![Snooze an activity](media/postpone-activity.png "Snooze an activity")

3. Select the new date and time by which the activity should be completed.

    > [!div class="mx-imgBorder"]
    > ![Select snooze date and time](media/snooze-time.png "Select snooze date and time")

### See also

[Integrate a sample softphone dialer with Dynamics 365 Sales](integrate-sample-softphone.md)<br>
[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)
