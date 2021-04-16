---
title: "Enable file attachments | MicrosoftDocs"
description: "Enable file attachments in messaging channels in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 08/25/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# Enable file attachments

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can enable or disable the capability for your agents and customers to send file attachments during a conversation. 

When you enable the option for customers in the **General settings** configuration of your channel, customers can include attachments with their messages. Similarly, when you enable the option for agents, agents can send attachments from the communication panel to the customers. Agents can upload files by dragging and dropping the file from the file explorer into the conversation canvas. Customers must use the **Attach** icon to upload files.

If an agent transfers the conversation to another agent, the agent who receives the chat can also access the files attached in the conversation.

For more information about the agent and customer experience of using file attachments in chat, see [Configure file attachment](configure-file-attachment.md).

For more information about which file types are supported in each channel, see [Asynchronous channel support](asynchronous-channels.md).

## File size limit and unsupported extensions (types) for attachments

By default, Omnichannel for Customer Service has a file size limit of 5 megabytes (MB) (5,120 kilobytes). However, you can configure the file as per your organization's requirements.

> [!Tip]
> Refer to documentation for your channel when determining message size limits. When you are enabling file attachments for Facebook messenger, we recommend that you configure a maximum limit of 25 MB (25,600 kilobytes) because the Facebook messenger file size limit is 25 MB.

You can set the file extension types that customers and agents can share.

## Configure file size limit and file extensions

To configure the file size limit and file extensions, follow these steps:

1. Sign in to Dynamics 365.

2. Select the settings icon in the nav bar, and then select **Advanced Settings**.

3. Go to **Settings** > **Administration** > **System Settings**.

4. In the **System Settings** window, go to the **Email** tab.

5. Go to the **Set file size limit for attachments** section, and in the **Maximum file size (in kilobytes)** field, enter the value in kilobytes.

    > [!div class=mx-imgBorder]
    > ![Set file size limit for attachment](media/file-size-limit.png "Set file size limit for attachment")

6. To specify unsupported file types, go to the **General** tab.

7. In the **Set blocked file extensions for attachments** field, add or edit the file types.

    > [!div class=mx-imgBorder]
    > ![Specify unsupported file types](media/unsupported-file-types.png "Specify unsupported file types")

8. Select **OK**.

Now, agents and customers can share file attachments during their conversation.

### See also

[Asynchronous channel support](asynchronous-channels.md)<br>
[Configure file attachment](configure-file-attachment.md)<br>
[Configure a Facebook channel](configure-facebook-channel.md)<br>
[Configure a Twitter channel](configure-twitter-channel.md)<br>
[Configure a WhatsApp channel](configure-whatsapp-channel.md)<br>
[Configure a WeChat channel](configure-wechat-channel.md)<br>
[Configure a LINE channel](configure-line-channel.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]