---
title: Call a customer in the voice channel
description: Use this article to understand how you can make customer calls.
ms.date: 10/28/2025
ms.custom: bap-template
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Call a customer

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

To call customers, your administrator must configure outbound calling, add you as a user to the outbound capacity profile, and then set up outbound profiles. Learn more in [outbound calling](../administer/voice-channel-outbound-calling.md).

You can launch the outbound dialer from the menu bar, **Contacts**, or **Active conversation** page. On the number pad that appears, enter the country code and phone number, then select **Call** to make your call. You don't need to add the plus sign (+) to the number.

## Prerequisites

Make sure that your administrator assigned a voice queue and an outbound capacity profile to your user profile. Learn more in [Manage contact center users](../administer/users-user-profiles.md#manage-contact-center-users).

## Test call controls, make a test call 

 In the outbound dialer, you can test your microphone and speaker before you make a call. You can also make a test call to check the quality of the call.

To test your microphone and speaker, follow these steps:

1. In Copilot Service workspace, select the **Launch dialer** phone icon on the menu bar and then select the **Settings** icon. 

1. In the **Speaker** and **Microphone** sections, select the speaker and microphone to test. If you have multiple devices, the default devices that are currently in use appear. The speaker that you select is the primary ringer and plays notifications for calls and chat notifications.
1. In the **Secondary Ringer** section, select the device to amplify or extend incoming call notifications. This feature is useful in noisy environments where the primary device's ringtone is low or difficult to hear.  
   > [!NOTE]
   > - You can set a secondary ringer only if you have multiple devices connected to your system.
   > - If the device set as a secondary ringer is disconnected, incoming call notifications aren't extended.
   > - If the secondary ringer is unavailable, like when your laptop is out of range for your headset's bluetooth connection), the application removes the secondary ringer. You must reconfigure the secondary ringer after you reconnect the device.

1. Select the following options:
    
    - **Test speaker**. The application plays a sound that stops automatically after 15 seconds. 
    - **Test microphone**: The microphone starts recording your voice. The recording automatically stops after 15 seconds and is played back to you.
    - **Make a test call**: The following actions occur:
       - The **Active Conversation** form opens with the message that a test call is in progress. 
       - The **Communication Panel** displays the device settings and the **End call** button. 
       - When you select device settings, you can see the speaker and microphone. A visual indicator appears and indicates that the device is connected. 

    > [!NOTE]
    > You can select the **Device settings** or use **Settings** in the **Dialer** to test your microphone and speaker when you're in an ongoing call. 

### Use noise suppression in calls

In Copilot Service workspace, select the **Launch dialer** phone icon on the menu, then select the **Settings** icon. On the dialer, use the following options:

- Turn on **Call connection sound** to receive an audible ping when a call connects. You can know the audio status, have a smooth start to customer interactions, and experience enhanced call quality, satisfaction, with privacy compliance.  

- Turn on **Noise suppression** to reduce background sounds during calls while keeping your voice clear. This setting reduces interruptions and improves customer experience.  


## Make a call by using the outbound dialer

1. In Copilot Service workspace, go to **Contacts**, and then select a customer to call.

1. On the **Active Conversation** page, locate the **Mobile Phone** field, and then select the call icon to call the customer. You can also select the **Launch dialer** phone icon on the menu bar to quickly call a customer.
     The **Dial number** panel appears. You can perform the following actions:  
     
     - Search for a contact or account by name. The results are displayed in a dropdown. You can select **Account** or **Contact** to filter the results further. Once you select the customer's name, the application displays the customer's phone number, name, country/region, country code, and outbound profile that you can use to make the call.
       > [!NOTE]
       > - To search for a contact or account, clear the existing country code.
       > - For a contact, you see the business number and the mobile number. For an account, you see the main phone number.   
     - On the input box, you can copy, type in a number, or select a number from the recently dialed numbers. The country code dropdown displays the list of supported countries and regions that you can call. 
     - View and call the most recently dialed numbers. By default, the last 20 calls you received or made are shown. Select **Call** to call a number. If you select a number from the **Recents** list, the call uses the same outbound profile as the original call, irrespective of the outbound profile currently selected in the dialer.
     - You can select the customer's name in **Recents** to view the customer's account or contact details in a new session. 
     - The **Profile** dropdown shows the outbound profile and the phone number that you're using to make the call. The outbound calling number appears on the customer's phone when they receive your call. The selected outbound profile applies only if you type the number.
     - Select **Set default** in the profile dropdown to set an outbound profile as the default profile for all your calls.
     - You can call those phone numbers only whose regions are configured in the outbound profiles.
     - When you select a country/region from the dropdown, the appropriate country code is populated in the phone number field. If you change the country code while making an outbound call, the new country/region becomes the default code.
     - The dropdown displays the list of supported countries and regions from all the outbound profiles assigned to you. 
     - When you enter the number you want to call, the application identifies the outbound profile that has the dialed number's country/region configured.
     - By default, the number pad is hidden. To display the number pad, select the number pad icon.

1. Select **Call**. 

   > [!NOTE]
   > - If you aren't assigned an outbound profile, you can't make a call.
   > - You can initiate multiple calls at the same time.

    :::image type="content" source="../media/outbound-dialer.png" alt-text="Outbound dialer for voice calls.":::


The outbound dialer pane displays the following information:

- A widget appears with the message, "Communication panel loading", and indicates that the call started.

- When the call connects, the customer details appear on the conversation page. The widget displays the call status and the **Mute** and **End call** call controls.
- The call controls you select on the widget reflect on the ongoing call in the Communication panel. For example, if you select **Mute** on the widget, the call is indicated as muted in the Communication panel.
- You can view all the active calls, including inbound and outbound, on the widget.
- If you have multiple active calls, the calls are displayed.

    :::image type="content" source="../media/outbound-dialer-improvement.png" alt-text="Screenshot of widget with Outbound dialer for voice calls.":::


### Related information

[Use agent dashboard and call controls in the voice channel](/dynamics365/contact-center/use/voice-channel-agent-experience)    
[Overview of the voice channel](../administer/voice-channel.md)  
[Use trial phone numbers in the voice channel](../administer/voice-channel-trial-phone-numbers.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
