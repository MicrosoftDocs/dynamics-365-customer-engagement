---
title: "Make and receive Teams calls in Dynamics 365"
description: "Make and receive Teams calls in Dynamics 365 through the dialer, a record, or a work item."
ms.date: 02/21/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
---

# Make and receive Teams calls in Dynamics 365  

Microsoft Teams dialer helps you to be more productive and get work done effectively by calling customers directly from within the Dynamics 365 Sales Hub app. You can make and receive calls through the Teams dialer.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Open Teams calls dialer

>[!NOTE]
> An administrator must configure the Microsoft Teams dialer in your organization for you to use it. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)

Sign in to your sales app and select the phone (![Phone icon.](media/phone-icon.png "Phone icon")) icon in the upper-right corner of the page to open the **Calls** and view the dial pad.  

> [!div class="mx-imgBorder"]
> ![Open Microsoft Teams dialer.](media/teams-dialer-open-dialer.png "Open Microsoft Teams dialer")  

> [!IMPORTANT]
> The dialer won't work if third-party cookies are blocked in the private or incognito window of your browser. To use the dialer, select the **Third-party cookie blocking** icon in your browser and select **Allow cookies**.  

## Make calls with Teams  

You can use Microsoft Teams to call a customer directly from the dialer, a record, or a work item in Dynamics 365.  

>[!NOTE]
>Verify that a valid phone number is associated with the Dynamics 365 records or work item.  

**To call a customer through a Dynamics 365 record** 

1.	Open a record. In this example, we're opening a contact record.

    In the **Business Phone** field, a phone number has been associated with the contact **Anthony Pruitt**.  

    > [!div class="mx-imgBorder"]
    > ![Open a contact record.](media/teams-dialer-contact-record.png "Open a contact record")

2.	Select ![Phone icon.](media/phone-icon.png "Phone icon") corresponding to the phone number. The call is established.  

    > [!div class="mx-imgBorder"]
    > ![Select the phone icon to make call.](media/teams-dialer-make-call.png "Select the phone icon to make call")
  
3. (Optional) Select the ellipses (three-dots menu) in the dialer screen to change your microphone and speaker settings. 

**To call a customer from a work list item**

1.	Go to **My Work** > **Sales accelerator**.

    Your work list opens. You can see the phone call activities that are pending for the day. In this example, the phone call activity for **Nancy Anderson** is pending for the day.

    > [!div class="mx-imgBorder"]
    > ![Open your work list.](media/teams-dialer-open-work-list.png "Open your work list")

2.	Select ![Phone icon.](media/phone-icon.png "Phone icon") corresponding to the work item.    
    The Teams dialer opens, and the call is established.   

    >[!NOTE]
    >You can also use the **Call** option in the **Up next** widget to make the call.


**To call a customer manually**

1. Open the Teams dialer.

2. Enter the phone number of the customer, or search for the customer through dialer search box.   
 
    > [!div class="mx-imgBorder"]
    > ![Search for or call a phone number manually.](media/teams-dialer-call-number-manually.png "Search for or call a phone number manually") 

3.  Select **Call**.

## Receive Teams calls in Dynamics 365

You can receive calls in Dynamics 365 Sales. When a call is received, a notification is displayed in the upper-right corner of the page, as shown in the following image:

> [!div class="mx-imgBorder"]
> ![Call receiving notification in Teams.](media/teams-dialer-receive-call-notification.png "Call receiving notification in Teams")  

The caller name is automatically displayed when the phone number is associated with a record. For example, Kenny Smith is a lead and has the mobile number +1 123 456 7890 associated with his record. When you receive a call from +1 123 456 7890, the name Kenny Smith is automatically displayed; you can select the name in the notification to open the record.  

> [!NOTE]
>- If a phone number is associated with more than one record, the notification will display up to 3 records and will indicate more records exist with this phone number. Select the appropriate record.
>- If you receive a call while you're on another call, the inbound call notification will provide an option to either end the current call and accept the incoming call, or to reject the incoming call and continue with the current call.

To receive the call, select **Answer**. The Teams telephony panel opens and the call is connected. 

A phone call activity is created and displayed on the timeline of the record. If the phone number is automatically resolved to a record, the **Call From** and **Regarding** fields of the phone call activity are automatically populated. If the received call isn't associated with any record, only a phone call activity is created. To associate the call with a record during the call, select the **Details** tab and then select **Connect a record**.

## Transfer a call (preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

While you're on a call with a customer, you can transfer the call to an expert in your organization. If the call isn't answered by the other user, you can choose to connect the call back to you.

1. In the **Teams dialer** pane, select the three-dot menu and select **Transfer**.
    The customer will placed on hold.

1. Enter the name of the person to transfer the call to or their phone number.
    You can transfer the call to only one user at a time and that user must be in the system.
1. Select the name. If you'd like the call to be connected back to you if there's no answer on the other side, select **Ring back if there's no answer**.  
   If you don't select this option, the customer's call will get disconnected if the call isn't answered by the other user.
1. Select **Transfer**. You'll see a drop-down if the user has more than one number.
    :::image type="content" source="media/dialer-call-transfer.png" alt-text="Teams dialer with transfer call":::
1.  Select the number that you want to transfer the call to.
     The other user will receive the transfer notification with the details of the original user and the customer. After the call is answered, the user can see the notes taken by the original user. After the call ends, both users will have access to the notes taken during the call.

## Consult a user before transferring a call (preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

While you're on a call with a customer, you can transfer the call to an expert after consulting whether they can help the customer. You can also just consult the expert and answer the customer directly without really transferring the call.

1. In the **Teams dialer** pane, select the three-dot menu and select **Consult and transfer**.
    The customer will placed on hold.

1. Enter the name of the person to consult or their phone number.
    You can select only one user at a time and that user must be in the system.
1. Select the person to consult and select **Call**. 
    The duration of the hold is displayed so that you know how long the customer has been waiting.
1. If the other user is the right person to help the customer, select **Transfer**.
     The other user will receive the transfer notification with the details of the original user and the customer. After the call is answered, the user can see the notes taken by the original user. After the call ends, both users will have access to the notes taken during the call.
 
    If the other user isn't the right person, or they didn't answer the call, or you've got the answer from the user that you can inform the customer directly, select **Cancel** to go back to the customer call.

## Call analysis

[Configure conversation intelligence](fre-setup-ci-sales-app.md) for real-time analysis of your call data with overview, summary, transcription, insights, and action items. More information: [Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)     
[Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
