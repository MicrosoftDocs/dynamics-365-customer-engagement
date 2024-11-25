---
title: Create message templates
description: Learn how to create message templates for reusable messages in Omnichannel for Customer Service.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Create message templates

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


Message templates enable the one-time creation of reusable messages that can be sent to multiple customers. With message templates, you can maintain high-quality content and avoid spam in the ecosystem. You can save time and personalize the messages by using placeholder values that can be replaced with dynamic content when the message is sent.

**To create a message template**

1. In the site map of Customer Service admin center or Contact Center admin center, in **Agent experience**, select **Productivity**.
   
1. Select **Manage** for **Message templates**.

1. Select **New**, and enter the following details:

    - **Name:** Enter a name.
    - **Channel:** Select SMS.
    - **Default language:** Select a language.
    - **Default text:** Enter the default text for the message.

1. Select **Save**. After you save the template, the **Message template** panel appears.

1. Select **New message** and create a message using localized text in each language that you want to support.

    > [!div class=mx-imgBorder]
    > ![Create localized text of new message.](../media/message-template3.png "Create localized text of new message")
    
    Message templates support the following slugs.  

    | Slug | Description |
    |-----------------|-----------------------------|
    | {FullName{Customer}}  | The full name of the customer who initiated the conversation. |
    | {LastName{Customer}}| The family name of the customer.|
    | {NickName{Customer}}| The nickname for the customer.|
    | {FullName{Agent}}| The full name of the agent who is assigned to the conversation.|
    | {FirstName{Agent}}| The first name of the agent.|
    | {LastName{Agent}}| The family name of the agent.|
    | {Nickname{Agent}}| The nickname for the agent.|

      For more information, see [Slugs](automation-dictionary-keys.md#slugs).
    
1. Select **Save & Close** to see your localized message appear in the list of message templates.

## Related information

[Configure outbound messaging](outbound-messaging.md) <br />
[Configure an SMS channel for Twilio](Configure-sms-channel-twilio.md) <br />
[Configure a WhatsApp a channel through Twilio](configure-whatsapp-channel.md) 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
