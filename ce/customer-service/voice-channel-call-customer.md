---
title: "Call a customer in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Call a customer

> [!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

To be able to call customers, your administrator must configure outbound calling, add you as user to the outbound capacity profile, and then set up outbound profiles. For more information, see [Outbound calling](voice-channel-outbound-calling.md).

**To make a call to a customer**

1. In Omnichannel for Customer Service, go to **Contacts**, and select a customer that you want to call to.

2. On the customer summary page, locate the **Mobile Phone** field and select the call icon to call the customer.
   The phone dialer opens with the phone number.

3. Select **Call** on the phone dialer.

> [!Note]
> In the dropdown list of the **Call** button, you'll see the phone number that you're making the call from. This is the outbound calling number that'll be displayed on the customer's phone when your agent makes the call.

When the call gets connected, you'll see the customer details on the conversation page. Based on your outbound calling profile, the transcription and recording starts. Again, if your capacity profile has a limit of one outbound call at a time, you won't be able to make another call when a call is in progress.

## Call customer using the phone dialer

In Omnichannel for Customer Service, you can select the **Launch dialer** phone icon on the menu bar to quickly call a customer. The dialer opens the number pad where you can enter the customer's phone number and then select **Call** to make your call.


[!INCLUDE[footer-include](../includes/footer-banner.md)]