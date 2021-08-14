---
title: "Block spam numbers in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how to block spam numbers in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Manage spam numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

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


In Omnichannel for Customer Service, you can block phone numbers that your agents receive as part of their incoming customer calls. As an administrator, you can mark phone numbers as spam so your agents can engage with actual customers​, instead of unsolicited or irrelevant calls that don't correspond to your line of business. This capability for admins to control which calls can be received by your agents helps improve efficiency of agents​. It also helps to prevent long waits of actual customers in queues​. Your agents and supervisors can also flag incoming phone calls as spam, that you can later review and mark as spam.

## Review phone numbers marked as spam

You can review all spam notification reports by viewing the report history​. You can visit the conversation history page to review the conversation or even the recordings.​ You can also choose to either block the number or remove the number from pending review list.

**To review phone numbers marked as spam**

1. In the site map of Omnichannel admin center, under **Advanced settings**, select **Customer settings**.
   
2. In the **Customer experience** area, select **Blocked numbers (preview)**, and then select **Manage**.

3. On the **Blocked numbers (preview) page**, you can do the following:
    
    - **Pending review** tab - Shows the list of numbers that have been flagged as spam by your agents and supervisors. You can view the report for each phone number, and then block the specific number as spam. Select any number from the **Pending review** list, and then you can do the following:
      - **Block** - Select to block the number.
      - **Remove from list** - Select to remove the number from the **Pending review** numbers list.
      - **View report history** - Select to view the reports for the specific phone number in the **Pending review** list. You can view call details.
    
    - **Blocked** tab - Shows the list of phone numbers that have been blocked as spam.

## Manually block a phone number

1. In the site map of Omnichannel admin center, under **Advanced settings**, select **Customer settings**.
  
2. In the **Customer experience** area, select **Blocked numbers (preview)**, and then select **Manage**.

3. Select **Block a number**.

## Automatically block phone numbers

You can also automatically block numbers if they're reported as spam two or more times. This not only saves time in reviewing every blocked call report received from your agents, but also helps remove the delay from the administrator's end when there are too many spam numbers to be reviewed. The auto-block option also helps in situations or instances where there might be a surge in spam calls from different numbers. You can also set conditions so that some numbers are automatically added to the blocked numbers list if they match certain conditions based on the number of reports.


### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
