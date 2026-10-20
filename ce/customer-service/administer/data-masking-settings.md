---
title: Create and manage data masking rules
description: Learn how to create and manage data masking rules to block sensitive data in Dynamics 365 Contact Center.
ms.date: 10/19/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
ms.topic: how-to
---

# Create and manage data masking rules

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

## Automated data masking

Use automated data masking to automatically block sensitive data such as credit card information, social security numbers (SSN), and profanity in conversation messages. Create a masking rule and define a [regular expression](/dotnet/standard/base-types/regular-expression-language-quick-reference) to identify the sensitive information and replace it with the masked characters. Any text masked in a conversation message is also masked in the conversation transcript. Data masking works for chat and asynchronous channels.

You can configure masking rules to apply to messages sent by a customer, a customer service representative (service representative or representative), or both. Make sure that the masking rules you want applied are set to **Active**. If not, the rules aren't applied to the selections you make.

> [!div class=mx-imgBorder]
> ![Data masking rules.](../media/general-masking-rules.png "Data masking rules")

You can choose to:

- **Mask private agent data from the customer**: Data the service representative sends is masked for both the customer and the representative for live chat and async channel messages.
- **Mask private customer data from the agent**: Data the customer sends is masked for both the customer and the  representative for live chat, but only for the user interface of the representative when using async channels.

The following masking rules are provided out of the box:
- **Credit Card**: Masks the credit card number, if provided in a message.
- **Email**: Masks the email address, if provided in a message.
- **SSN**: Masks the SSN, if provided in a message.

As an administrator, you can delete or modify the out-of-the-box masking rules and create new masking rules.

> [!NOTE]
> - Only administrators can access and edit data masking rules.
> - You can have a maximum of 10 data masking rules, including the out-of-the-box rules, in Dynamics 365 Contact Center.

### Create a data masking rule

> [!div class=mx-imgBorder]
> ![Create a masking rule.](../media/new-masking-rule.png "Create a masking rule")

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**.
1.	Select **Manage** for **Data masking**.
1.	In **Masking rules**, select **New Masking Rule**.
1.	On **New Masking Rule**, enter the following information:

    - **Name**: The name of the masking rule.

    - **Description**: An optional description of the masking rule.

    - **Regular expression**: A regular expression to identify the data to mask.
        
1. To test the data masking as defined by the specified regular expression, enter a value in the **Enter test data** field. The masked value appears in the **Masked test data** field. By default, the number sign (#) masks sensitive data.

   > [!div class=mx-imgBorder]
   > ![Email masking rules.](../media/email-masking-rule.png "Email masking rules")

1. Select **Save**.

### Manage data masking rules

After you create a masking rule, you can edit, activate, deactivate, or permanently delete it.

   > [!div class=mx-imgBorder]
   > ![Manage masking rules.](../media/masking-rule-card.png "Manage masking rules")

1.	Under **Masking rules**, select the ellipsis to see the options for managing an existing masking rule.
1. To activate, deactivate, or delete a masking rule, select the rule, and then select the desired action from the list.

## Manual data masking

Manual masking allows representatives to mask messages during an open conversation. Masked messages are immediately removed from the representative's transcript and aren't written to Dataverse when the conversation is closed. For auditing purposes, you can turn on encryption to keep an encrypted copy of each masked message. Only the encrypted copy is stored.

Manual masking works for all digital channels and voice transcripts.

> [!NOTE]
> - The purpose of manual data masking is to prevent your organization from retaining sensitive customer data, not to hide it from the customer. Depending on the channel, implementation, and conversation state, these messages might not be hidden on the customer's device.

> [!IMPORTANT]
> Manual masking removes masked text from voice transcripts, but not from any retained audio recordings.

### Allow manual masking globally

To enable masking globally:

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**.
1. Select **Manage** for **Data masking**.
1. Set **Enable Customer Service Representatives with masking permission to hide messages** to **Yes**.
1. Add the **Masking Agent Messages** and **Masking Customer Messages** security roles to the desired personas in **Role Persona Mapping**. Learn more in [Manage personas and custom security roles](role-persona-mapping.md).

### Encrypt manually masked messages

Turn on encryption to audit how representatives use manual masking. You can export conversations and audit the original messages. Without encryption, masked messages are permanently deleted and can't be retrieved.

To turn on encryption:

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**.
1. Select **Manage** for **Data masking**.
1. Set **Encrypt masked messages** to **Yes**.
1. In **Public Key URL**, enter the URL of a publicly accessible RSA public key in PEM format.

Encrypted messages appear in Dataverse transcripts under an `encryptedMessage` field. Because decryption requires your private key, you must export these messages. You can't view them in Contact Center interfaces.

> [!NOTE]
> - Encryption is only available for manually masked messages. Automatically masked messages are masked before they're ingested into Contact Center and aren't stored.
> - Encryption isn't available for files like images, videos, or documents. Instead, attachments are deleted.

### Configure the masked message text

You must configure a masked message for any workstream language that your organization uses. This text replaces the original message on both the representative's transcript and the customer's transcript (if possible, depending on the channel). If you don't configure a message for a workstream's configured language, representatives see an error when they try to mask a message.

To configure a masked message:

1. In the site map of Copilot Service admin center, select **Productivity** in **Support experience**.
1. Select **Manage** for **Data masking**.
1. Select **New Message masking rule**. A new page opens. If you're prompted, save any changes you made.
1. In **Language code**, start typing the workstream's language, and then select it from the suggestions. Languages appear in a "language - country/region" format, such as **English - United States**.
1. Enter a message text to display in **Masked Message**. For example, "(This message contained sensitive data and was removed for your protection.)"
1. Select **Save**.

### Mask messages as a representative

Representatives can mask messages based on the roles assigned to them:

- **Masking Customer Messages**: Mask messages that the customer sends.
- **Masking Agent Messages**: Mask messages that any representative in the conversation sends.

Before representatives can mask messages, your administrator must [allow manual masking globally](#allow-manual-masking-globally) and [configure the masked message text](#configure-the-masked-message-text) for each workstream language.

> [!IMPORTANT]
> Masking removes the message from Contact Center immediately and can't be undone. If encryption is turned on, an encrypted copy is kept for auditing. Learn more in [Encrypt manually masked messages](#encrypt-manually-masked-messages).

To mask a message in Copilot Service workspace:

1. In the conversation transcript, hover over the message that you want to mask.
1. Select **Mask** in the upper-right corner of the message.
1. In the confirmation dialog, select **Mask**.

The masked message text replaces the original message in your transcript. It also replaces it in the customer's transcript if the channel supports this.

> [!TIP]
> To mask several messages without the confirmation dialog, hold Shift when you select **Mask**.

If you get an error when you mask a message, contact your administrator. A masked message might not be configured for the workstream's language.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
