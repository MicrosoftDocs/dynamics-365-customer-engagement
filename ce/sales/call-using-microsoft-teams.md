---
title: "Call customers through Microsoft Teams dialer in Dynamics 365 Sales"
description: "Call customers through Microsoft Teams dialer through records and up next widget in Dynamics 365 Sales."
ms.date: 12/06/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
ms.custom: 
  - dyn365-sales
---

# Call using Microsoft Teams (Preview)

> [!IMPORTANT]
> - While in preview, Teams calls does not support emergency calling.
> - Preview features are not complete, but are made available to you before general availability so you can evaluate them and provide feedback to Microsoft. Preview features are not intended for production use and may have limited or restricted functionality, as further explained in our [Product Terms](https://go.microsoft.com/fwlink/?linkid=2173816). 

Microsoft Teams dialer helps you to be more productive and get work done effectively by calling customers directly from within Dynamics 365 Sales Hub app. You can make and receive calls through Teams. 

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Open Teams calls dialer

>[!NOTE]
>- An administrator must configure the Microsoft Teams dialer in your organization to use. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md). 
>- You can't make emergency calls using Teams dialer in Dynamics 365 Sales.

When you sign in to your organization, you can view the **Calls (preview)** dialer pane on the right of the page.   
Select the phone icon (![Phone icon.](media/phone-icon.png "Phone icon")) on the top-right corner of the page to open the **Calls (preview)** and view the dial pad. 

> [!div class="mx-imgBorder"]
> ![Open Microsoft Teams dialer.](media/teams-dialer-open-dialer.png "Open Microsoft Teams dialer")     

## Make calls using Teams  

You can use Microsoft Teams to call a customer directly through the dial pad, a record, or a work item to make a call. 

>[!NOTE]
>Verify that a valid phone number is associated with the Dynamics 365 records or work item.  

**To dial a customer through a Dynamics 365 record** 

1.	Open a record. In this example, we’re opening a contact record.    
    In the **Business Phone** field, a phone number has been associated with the contact **Nancy Anderson**.  

    > [!div class="mx-imgBorder"]
    > ![Open contact record.](media/teams-dialer-contact-record.png "Open contact record")    

2.	Select the phone icon (![Phone icon.](media/phone-icon.png "Phone icon")) corresponding to the phone number and the call is established.   

    > [!div class="mx-imgBorder"]
    > ![Select phone icon to make call.](media/teams-dialer-make-call.png "Select phone icon to make call")     

**To dial a customer work list item**

1.	Go to **My Work** > **Sales accelerator**.    
    Your work list opens. You can see the phone call activities that are pending for the day. In this example, the phone call activity for **Nancy Anderson** is pending for the day.

    > [!div class="mx-imgBorder"]
    > ![Open work list.](media/teams-dialer-open-work-list.png "Open work list")    

2.	Select the phone icon (![Phone icon.](media/phone-icon.png "Phone icon")) corresponding to the work item.    
    The Teams dialer opens, and the call is established.   

    >[!NOTE]
    >You can also use the **Call** option in the **Up next** widget to make the call.

    > [!div class="mx-imgBorder"]
    > ![Select phone icon to make call through work item.](media/teams-dialer-work-item-make-call.png "Select phone icon to make call through work item")    

## Receive calls using Teams

Through Teams you can receive calls in Dynamics 365 Sales Hub app. To receive a call, open any record such as lead, contact, or work list item. A notification is displayed at the bottom-right corner of the page as shown in the following image:

> [!div class="mx-imgBorder"]
> ![Call receiving notification in Teams.](media/teams-dialer-receive-call-notification.png "Call receiving notification in Teams")    

When a call is received, the caller name is automatically displayed when the phone number is associated with a record. For example, Kenny Smith is lead and has the mobile number +1 123 456 7890 associated with his lead record. When you receive a call from +1 123 456 7890, the name Kenny Smith is automatically displayed and select the name to open the record. 

To receive the call, select **Answer**. The Teams telephony panel opens and the call is connected. A phone call activity is created and appears on the timeline of the record. If the received call is not associated with any record, only a phone call activity is created.    

## Call analysis

[Configure conversation intelligence](fre-setup-ci-sales-app.md) for real-time analysis of your call data with overview, summary, transcription, insights, and action items.

More information: [Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure Microsoft Teams dialer](configure-microsoft-teams-dialer.md)     
[Get real-time call data through Teams call](get-real-time-call-data-through-teams-call.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
