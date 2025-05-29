---
title: Make and receive Teams calls in Dynamics 365
description: Make and receive calls directly from Dynamics 365 with Microsoft Teams dialer and analyze conversations for real-time insights.
ms.date: 08/26/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/13/2023
ai-usage: ai-assisted
---

# Make and receive Teams calls in Dynamics 365

Microsoft Teams dialer helps you to be more productive and get work done effectively by calling customers directly from within the Dynamics 365 Sales Hub app. You can make and receive calls through the Teams dialer.

## Open Teams calls dialer

> [!NOTE]
> An administrator must configure the Microsoft Teams dialer in your organization for you to use it. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)

Sign in to your sales app and select the phone (![Phone icon.](media/phone-icon.png "Phone icon")) icon in the upper-right corner of the page to open the **Calls** pane and view the dial pad.

> [!div class="mx-imgBorder"]
> ![Open Microsoft Teams dialer.](media/teams-dialer-open-dialer.png "Open Microsoft Teams dialer")

> [!IMPORTANT]
>- The dialer won't work if third-party cookies are blocked in the private or incognito window of your browser. To use the dialer, select the **Third-party cookie blocking** icon in your browser and select **Allow cookies**.
>- The dialer isn't supported for custom entities. Though the phone icon appears on the custom entity forms, the dialer doesn't work.

## Make calls with Teams

You can use Microsoft Teams to call a customer directly from the dialer, a record, or a work item in Dynamics 365.

> [!NOTE]
>- Verify that a valid phone number is associated with the Dynamics 365 records or work item.
>- After the call ends, a phone call activity is created and displayed on the timeline of the record and on the **Activities** page. 

**To call a customer through a Dynamics 365 record** 

1. Open a record. In this example, we're opening a contact record.

    In the **Business Phone** field, a phone number has been associated with the contact **Jim Glynn**.

1. Select ![Phone icon.](media/phone-icon.png "Phone icon") corresponding to the phone number. The call is established.

1. Select your conversation language from the language drop-down. Selecting the approrpirate language ensures accurate transcription, keyword tracking, analysis, insights, and KPIs.
   :::image type="content" source="media/teams-dialer-make-call.png" alt-text="Screenshot of Teams dialer with language drop-down highlighted":::


1. (Optional) Select the ellipses (three-dots menu) in the dialer screen to change your microphone and speaker settings.

<a name="call-from-list-view"></a>
**To call a customer from the list view**

**Prerequisite**: Your administrator must have turned on the **[Call from view](configure-microsoft-teams-dialer.md#teams-call-from-views)** option.

1. Open the read-only grid view of any entity, such as **Contacts**, **Leads**, or **Accounts**.

1. Select the phone number of the customer from any of the phone number columns.
   :::image type="content" source="media/teams-dialer-call-from-view.png" alt-text="Screenshot of the All Accounts page with phone column highlighted.":::

    The Teams dialer opens and calls the number automatically.

**To call a customer from a work list item**

1. Go to **My Work** > **Sales accelerator**.

    Your work list opens. You can see the phone call activities that are pending for the day. In this example, the phone call activity for **Nancy Anderson** is pending for the day.

    > [!div class="mx-imgBorder"]
    > ![Open your work list.](media/teams-dialer-open-work-list.png "Open your work list")

1. Select ![Phone icon.](media/phone-icon.png "Phone icon") corresponding to the work item.

    The Teams dialer opens, and the call is established.

    > [!NOTE]
    > You can also use the **Call** option in the **Up next** widget to make the call.

**To call a customer manually**

1. Open the Teams dialer.
1. Enter the phone number of the customer, or search for the customer through dialer search box.

    > [!div class="mx-imgBorder"]
    > ![Search for or call a phone number manually.](media/teams-dialer-call-number-manually.png "Search for or call a phone number manually")

1. Select **Call**.

## Receive Teams calls in Dynamics 365

You can receive calls in Dynamics 365 Sales. When a call is received, a notification is displayed in the upper-right corner of the page, as shown in the following image:

> [!div class="mx-imgBorder"]
> ![Call receiving notification in Teams.](media/teams-dialer-receive-call-notification.png "Call receiving notification in Teams")

The caller name is automatically displayed when the phone number is associated with a record. For example, Kenny Smith is a lead and has the mobile number +1 123 456 7890 associated with their record. When you receive a call from +1 123 456 7890, the name Kenny Smith is automatically displayed; you can select the name in the notification to open the record.

> [!NOTE]
> - If a phone number is associated with more than one record, the notification will display up to 3 records and will indicate more records exist with this phone number. Select the appropriate record.
> - If you receive a call while you're on another call, the inbound call notification will provide an option to either end the current call and accept the incoming call, or to reject the incoming call and continue with the current call.

To receive the call, select **Answer**. The Teams telephony panel opens and the call is connected.

A phone call activity is created and displayed on the timeline of the record. If the phone number is automatically resolved to a record, the **Call From** and **Regarding** fields of the phone call activity are automatically populated. If the received call isn't associated with any record, only a phone call activity is created. To associate the call with a record during the call, select the **Details** tab, and then select **Connect a record**.

## View missed calls in Dynamics 365

If you've missed a call, a notification is displayed in the in-app notification center in Dynamics 365. To view the missed call notification, select the Notifications icon (bell icon) in the upper-right corner of the page. If you've answered the call from another app, such as Teams desktop, the call isn't considered as missed.

> [!NOTE]
> Your administrator must have enabled and [set up the in-app notifications](configure-microsoft-teams-dialer.md#configure-the-dialer) for you to view the missed calls.


## Transfer a Teams call (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Prerequisite:**
Your administrator must have [turned on the call transfer feature](configure-microsoft-teams-dialer.md#teams-call-transfer).

You can transfer a customer's call to a colleague's Teams line or their phone number.

1. While you're on the call, select **More options** (**&hellip;**), and then select **Transfer (preview)**.

    :::image type="content" source="media/call-transfer-options.png" alt-text="Screenshot that shows the call transfer options, including Transfer (preview).":::

    The customer's call is put on hold.

1. On the dial pad, enter the name or phone number of your colleague.
1. (Optional) If you're calling the Teams line of your colleague, select **Ring back if there's no answer** to ensure a safe transfer. Otherwise, the call will be disconnected if it isn't answered. This option isn't available when you transfer to a phone number.
1. Follow one of these steps:

    - If the recipient is available, select **Transfer**.
    - If the recipient is unavailable, select **Cancel** and then **Resume** to go back to the customer.

    If you're transferring to a Teams line, the recipient receives a transfer notification that includes information about you and the customer. After you transfer the call, it's treated as a new call. In this case, no notes or recordings that you made during the original call are transferred to the recipient.

## Consult and transfer a Teams call (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Prerequisite:**
Your administrator must have [turned on the call transfer feature](configure-microsoft-teams-dialer.md#teams-call-transfer).

You can consult a colleague before you transfer a customer's call to them. You can also consult a colleague and then answer the customer directly, without transferring the call.

1. While you're on the call, select **More options** (**&hellip;**), and then select **Consult then transfer (preview)**.

    :::image type="content" source="media/call-transfer-options.png" alt-text="Screenshot that shows the call transfer options, including Consult then transfer (preview).":::

    The customer is put on hold.

1. Enter the name or phone number of your colleague.
1. Follow one of the steps:

    - If the recipient is available, follow these steps:

        1. Select **Call**. The duration of the hold is displayed, so that you know how long the customer has been waiting.
        1. Consult your colleague.
        1. If your colleague is ready to take the call, select **Transfer**.

        If you're transferring to a Teams line, the recipient receives a transfer notification that includes information about you and the customer. After you transfer the call, it's treated as a new call. In this case, no notes or recordings that you made during the original call are transferred to the recipient.

    - If the recipient is unavailable, or if you want to answer the customer directly, select **Cancel** and then **Resume** to go back to the customer.


## Add a participant to an ongoing Teams call (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Prerequisite:**
Your administrator must have [turned on the add people to calls feature](configure-microsoft-teams-dialer.md#teams-add-people-to-call).

You can add a participant to an ongoing Teams call. The added participant can be an internal user or an external contact. If you don't want the current participants to hear the ringing sound, you can place the call on hold while you add the participant.

1. While you're on the call, select the **Add people** icon and enter the name or number of the participant you want to add.

    :::image type="content" source="media/teams-dialer-add-participant.png" alt-text="Screenshot that shows the Add people icon and the search box to add a participant to the call."::: 

1. Select **Call** to place the call.
   When the call is answered, a voice message is played to inform the other participants about the new participant.

> [!NOTE]
> You can remove a participant from the call by selecting the three-dot menu (**&hellip;**) next to the participant's name and selecting **Remove**. This option is available only when there are more than two participants in the call.

## View phone call activities

After you make or receive a call, a phone call activity is recorded.

- If the call is associated with a record, the phone call activity is displayed in the following locations:
    - On the timeline of the record.
    - On the **My Activities** page. The **Regarding** column on the page displays the linked record.

- If the call is not associated with any record:
    - A phone call activity is created and displayed only on the **Activities** page.

By default, unanswered calls aren't recorded as an activity. If you'd like to track unanswered calls, reach out to your administrator to [enable documenting call attempts](configure-microsoft-teams-dialer.md#teams-call-attempts).

## Call analysis

[Configure conversation intelligence](fre-setup-ci-sales-app.md) for real-time analysis of your call data with overview, summary, transcription, insights, and action items. More information: [Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)  
[Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
