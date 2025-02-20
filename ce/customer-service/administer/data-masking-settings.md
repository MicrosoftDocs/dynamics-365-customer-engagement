---
title: Create and manage data masking rules
description: Learn how to create and manage data masking rules to block sensitive data in Omnichannel for Customer Service.
ms.date: 02/20/2025
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
ms.topic: how-to
---

# Create and manage data masking rules

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use data masking to block sensitive data such as credit card information, social security number (SSN), or even profanity in a conversation. You can create a masking rule and define a regular expression to identify the sensitive information and replace it with the masked characters. Any masked text in a conversation is also masked in the conversation transcript. Data masking works for chat and asynchronous channels.

Masking rules can be configured to apply to messages sent by a customer, a customer service representative (service representative or representative), or both. You must make sure that the masking rules you want applied are set to **Active**; otherwise, they won't apply to the selections you make.

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
> - Only an administrator can access and edit data masking rules.
> - Only 10 data masking rules, including the rules provided out of the box, can exist in Omnichannel for Customer Service.

## Create a data masking rule

   > [!div class=mx-imgBorder]
   > ![Create a masking rule.](../media/new-masking-rule.png "Create a masking rule")

1. In the site map of Customer Service admin center or Contact Center admin center, in **Agent experience**, select **Productivity**.

1.	Select **Manage** for **Data masking**.

1.	In **Masking rules**, select **New Masking Rule**.

1.	On the **New Masking Rule** page, provide the following information:

    - **Name**: The name of the masking rule.

    - **Description**: An optional description of the masking rule.

    - **Regular expression**: A regular expression to identify the data to be masked.
        
1. To test the data masking as defined by the specified regular expression, enter a value in the **Enter test data** field. The masked value is displayed in the **Masked test data** field. By default, the number sign (#) is used to mask sensitive data.

   > [!div class=mx-imgBorder]
   > ![Email masking rules.](../media/email-masking-rule.png "Email masking rules")

1. Select **Save**.

## Manage data masking rules

After a masking rule is created, you can edit, activate, deactivate, or permanently delete it.

   > [!div class=mx-imgBorder]
   > ![Manage masking rules.](../media/masking-rule-card.png "Manage masking rules")

1.	Under **Masking rules**, select the ellipsis to see the options for managing an existing masking rule.

2. To activate, deactivate, or delete a masking rule, select the rule, and then select the appropriate action from the list.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
