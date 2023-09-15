---
title: Call a customer in the voice channel
description: Use this topic to understand how you can make customer calls in Omnichannel for Customer Service.
ms.date: 09/19/2023
ms.custom: bap-template
ms.topic: how-to
author: gandhamm
ms.author: mgandham
---

# Call a customer

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To be able to call customers, your administrator must configure outbound calling, add you as user to the outbound capacity profile, and then set up outbound profiles. More information: [Outbound calling](voice-channel-outbound-calling.md)

1. In Customer Service workspace or Omnichannel for Customer Service, go to **Contacts**, and then select a customer to call.

1. On the **Active Conversation** page, locate the **Mobile Phone** field, and then select the call icon to call the customer. You can also select the **Launch dialer** phone icon on the menu bar to quickly call a customer.

 The **Dial number** panel appears. On the panel you can perform the following actions:

 - On the dial pad, you can copy or type in a number or select a number from the recently called numbers. The dropdown displays the list of supported countries and regions that you can call. You can also view and call the most recently called numbers. By default, you’ll see the last 20 calls that you’ve received or made.
 - In the call dropdown list, you'll see the phone number that you're using to make the call. This is the outbound calling number that'll be displayed on the customer's phone when they receive your call.
 - You can only call the regions that have been set in their outbound profile by your administrator. If you have multiple outbound profiles set, the profile that has the region assigned is displayed to call the customer. 
 - By default, the number pad is hidden. To display the number pad, select the number pad icon.

1. Select **Call**.

When the call connects, you'll see the customer details on the conversation page. Based on your outbound calling profile, the transcription and recording starts. If your capacity profile has a limit of one outbound call at a time, you won't be able to make another call when a call is in progress.

> [!NOTE]
> If you need more trial minutes or phone numbers, we recommend that you file a request with Microsoft Support.

## Next steps
[Use agent dashboard and call controls in the voice channel](voice-channel-agent-experience.md)  

### See also

[Overview of the voice channel](voice-channel.md)  
[Use trial phone numbers in the voice channel](voice-channel-trial-phone-numbers.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
