---
title: Call a customer in the voice channel
description: Use this article to understand how you can make customer calls.
ms.date: 02/17/2025
ms.custom: bap-template
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Call a customer

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

To be able to call customers, your administrator must configure outbound calling, add you as user to the outbound capacity profile, and then set up outbound profiles. Learn more in [outbound calling](../administer/voice-channel-outbound-calling.md).

You can launch the outbound dialer from the menu bar, **Contacts** or **Active conversation** page. On the number pad that appears, enter the customer's country code, phone number, and then select **Call** to make your call. You don't have to add the plus sign (+) to the number.

## Prerequisites

Make sure that the administrator has assigned a voice queue and an outbound capacity profile to your user profile. Learn more in [Manage contact center users](../administer/users-user-profiles.md#manage-contact-center-users).

## Test call controls, make a test call 

 In the outbound dialer, you can test your microphone and speaker before you make a call. You can also make a test call to check the quality of the call.

To test your microphone and speaker, do the following steps:

1. In Customer Service workspace or Contact Center workspace, select the **Launch dialer** phone icon on the menu bar and then select the **Settings** icon. 
1. In the **Speaker** and **Microphone** sections, select the speaker and microphone to test. If you have multiple devices, the default devices that are currently in use appear.
1. In the **Secondary Ringer** section, select the device to be used to amplify or extend incoming call notifications. This is useful in noisy environments where the primary device's ringtone is low or difficult to hear.
1. Select the following options:
    - **Test speaker**. The application plays a sound that stops automatically after 15 seconds.
    -  **Test microphone**: The microphone starts recording your voice. The recording automatically stops after 15 seconds and is played back to you.
    - **Make a test call**: The following actions occur:
       - The **Active Conversation** form opens with the message that a test call is in progress. 
       - The **Communication Panel** displays the device settings and the **End call** button. 
       - When you select device settings, you can see the speaker and microphone. A visual indicator is displayed against the device to indicate that it is connected. 

    > [!NOTE]
    > You can select the **Device settings** or use **Settings** in the **Dialer** to test your microphone and speaker when you're in an ongoing call. 


## Make a call using the outbound dialer

1. In Customer Service workspace or Contact Center workspace, go to **Contacts**, and then select a customer to call.
2. On the **Active Conversation** page, locate the **Mobile Phone** field, and then select the call icon to call the customer. You can also select the **Launch dialer** phone icon on the menu bar to quickly call a customer.
     The **Dial number** panel appears. You can perform the following actions:<br>
     - Search for a contact or account by name. The results are displayed in a dropdown. You can select **Account** or **Contact** to filter the results further. Once you select the customer's name, the application displays the customer's phone number, name, country, country code, and outbound profile that you can use to make the call.
       > [!NOTE]
       > For a contact, you'll see the business number and the mobile number. For an account you'll see the main phone number.   
     - On the input box, you can copy, type in a number, or select a number from the recently dialed numbers. The country code dropdown displays the list of supported countries and regions that you can call. 
     - View and call from the most recently dialed called numbers. By default, the last 20 calls that you’ve received or made are displayed.
     - You can select the customer's name in **Recents** to view the customer's account or contact details in a new session.
     - In the profile dropdown, the outbound profile and the phone number that you're using to make the call is displayed. This is the outbound calling number that is displayed on the customer's phone when they receive your call. 
     - Select **Set default** in the profile dropdown to set an outbound profile as the default profile for all your calls.
     - You can call those phone numbers only whose regions are configured in the outbound profiles.
     - When you select a country from the dropdown, the appropriate country code is populated in the phone number field. If you change the country code while making an outbound call, the new country becomes the default code.
     - The dropdown displays the list of supported countries and regions from all the outbound profiles assigned to you. 
     - When you enter the number you'd like to call, the application identifies the outbound profile that has the dialed number's country or region configured.
     - By default, the number pad is hidden. To display the number pad, select the number pad icon.

3. Select **Call**. 

   > [!NOTE]
   > If you aren't assigned an outbound profile, you won't be able to make a call.

 :::image type="content" source="../media/outbound-dialer.png" alt-text="Outbound dialer for voice calls.":::

When the call connects, you see the customer details on the conversation page. Based on your outbound calling profile, the transcription and recording starts. If your capacity profile has a limit of one outbound call at a time, you can't make another call when a call is in progress.

> [!NOTE]
> If you need more trial minutes or phone numbers, we recommend that you raise a request with Microsoft Support.



### Related information


[Use agent dashboard and call controls in the voice channel](/dynamics365/contact-center/use/voice-channel-agent-experience)    
[Overview of the voice channel](../administer/voice-channel.md)  
[Use trial phone numbers in the voice channel](../administer/voice-channel-trial-phone-numbers.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
