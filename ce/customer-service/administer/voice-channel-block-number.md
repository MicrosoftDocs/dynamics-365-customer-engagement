---
title: Block spam numbers in the voice channel
description: Learn how to review, mark numbers as spam, and block the numbers in Omnichannel for Customer Service.
ms.date: 12/14/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Block spam numbers


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


You can block spam phone calls that your customer service representatives (service representative or representative) receive as part of their incoming customer calls. By blocking spam calls, you can help improve efficiency and productivity of representatives and prevent long wait times for actual customers who are in the queues. Your representatives and supervisors can also flag off incoming calls as spam, that you can later review and block as spam.

## Review phone numbers marked as spam

You can review phone numbers marked as spam in the Customer Service admin center or Contact Center admin center app.

1. In the site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.
1. In the **Blocked numbers** section, select **Manage**. The **Blocked numbers** page is displayed.
1. In the **Blocked numbers** section, you can do the following:

    - **Pending review** tab - Shows the list of numbers that have been flagged as spam by your representatives and supervisors. You can view the report for each phone number, and then block the specific number as spam. Select any number from the **Pending review** list, and then you can do the following:
      - **Block** - Select to block the number; the representative will no longer receive any calls from the blocked number.
      - **Remove from list** - Select to remove the number from the **Pending review** numbers list and clear the number from the spam numbers list.
      - **View report history** - Select to view the reports for the specific phone number in the **Pending review** list. You can review all spam notification reports by viewing the report history​. You can visit the conversation history page to review the conversation or recordings.​ You can also choose to either block the number or remove the number from the pending review list.

    - **Blocked** tab - Shows the list of phone numbers that have been blocked as spam.

## Manually block phone numbers
  
1. Navigate to **Blocked numbers** and select **Manage**.

1. Select **Block a number**.

1. In the **Block a phone number** dialog, enter a phone number, add any comments if you'd like, and then select **Block this number**.

## Automatically block phone numbers

You can set conditions so that some numbers are automatically added to the blocked numbers list if they match certain conditions based on the number of reports. Using the **Auto-block** option, you can also automatically block numbers if they're reported as spam, say two or more times. This not only saves time in reviewing every blocked call report received from your representatives, but also helps remove any delay from your end when you have too many spam numbers to review. The auto-block option is also useful in situations or instances where there might be a surge in spam calls from different numbers.

1. Navigate to **Blocked numbers**, and select **Manage**.

1. In the **Auto-block** section, select **Set up**.

1. In the **Auto-block** dialog that appears, do the following:
   1. Enable the **Turn on auto block** toggle.
   2. Enter a value for the number of reports in the **Block reported phone numbers if they receive** field. For example, if you entered **2**, then the phone number would automatically get blocked as spam after two reports are received.

1. Select **Save and close**.

### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
