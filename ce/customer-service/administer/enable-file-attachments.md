---
title: Enable file attachments
description: Learn how to set the file size limit and blocked file extensions for attachments that customer service representatives and customers share in messaging channels in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 10/29/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.service: dynamics-365-customer-service
ms.custom: bap-template
---

# Enable file attachments

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Enable file attachments in your messaging channels so that customer service representatives (representatives) and customers can share files during messaging conversations.

Use this article to set the organization-wide file size limit and blocked file extensions that apply to attachments in all messaging channels.

To turn on file attachments for a specific channel, use the channel's settings:

- **Live chat**: Turn on file attachments for a chat widget, and learn about the customer experience and attachment validations, in [Configure file attachment capability](configure-file-attachment.md).
- **Asynchronous channels**: Turn on attachments for customers and representatives in the **General settings** configuration of the channel. Learn more about the file types that each channel supports in [Support for file attachments](card-support-in-channels.md#support-for-file-attachments).

Representatives can upload files by dragging and dropping them from File Explorer into the conversation. Customers must use the **Attach** icon to upload files. If a representative transfers a conversation to another representative, the receiving representative can access the files attached to the conversation.

## File size limit and unsupported extensions for attachments

By default, the file size limit for attachments is 5 megabytes (MB) (5,120 kilobytes). You can change this limit based on your organization's requirements, up to 128 MB. For live chat, the maximum size for image files is 20 MB.

> [!TIP]
> Check the documentation for your channel when you determine message size limits. If you enable file attachments for Facebook Messenger, configure a maximum limit of 25 MB (25,600 kilobytes) because the Facebook Messenger file size limit is 25 MB.

You can also block file extensions so that customers and representatives can't share those file types.

## Configure file size limit

To configure the file size limit and file extensions, complete the following steps:

1. In the Copilot Service workspace or Contact Center app, select the **Settings** icon in the navigation bar, and then select **Advanced Settings**.
1. In the sitemap, go to **System** > **Email Configuration** > **Email Settings**.
1. In **Attachments**, enter the new value for **Maximum file size for attachments** in kilobytes.
1. Select **Save**.

## Configure file extensions

1. In the Copilot Service workspace or Contact Center app, select the **Settings** icon in the navigation bar, and then select **Advanced Settings**.
1. In the sitemap, go to **System** > **Administration** > **General**.
1. In the **Set blocked file extensions for attachments** field, add or edit the file types you want blocked.
   > [!NOTE]
   > Don't block the .txt extension. If you block .txt files, transcripts aren't available for closed conversations.
1. Select **Save**.

Now, representatives and customers can share file attachments during their conversations.

> [!NOTE]
> Customers with Apple devices must have iOS version 13 to send file attachments.

### Related information

[Support for live chat and asynchronous channels](card-support-in-channels.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Configure a Facebook channel](configure-facebook-channel.md)   
[Configure a WhatsApp channel](configure-whatsapp-channel.md)   
[Configure a LINE channel](configure-line-channel.md)  
[Download file attachments from your Azure bot](../develop/download-attachments-bot.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
