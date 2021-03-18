---
title: "Understand and create workstreams | MicrosoftDocs"
description: "Understand and create workstreams in Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/01/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Create workstreams for conversations

A workstream is a collection of routing and work distribution settings. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue.

Perform the following steps to configure the workstream in Omnichannel admin center:

1. In Omnichannel admin center, go to the home page.
2. On the site map, select **Workstreams**, select **New**, and then select **Create a workstream**.
3. Enter the following details for the workstream:
    - **Name:** Enter an intuitive name, such as **Contoso chat workstream**.
    - **Work distribution mode:** Select **Push** or **Pick**.
    - **Type:** Select Messaging.
    - **Channel:** Select a channel from the list.

4. Select **Create**. The workstream that you created is displayed with the option to configure the selected channel instance.
    > [!div class=mx-imgBorder]
    > ![Set up a channel](media/set-up-wechat.png "Set up a channel")
5. Perform the steps outlined in one of the following sections depending on the channel that you've selected.
   - [Configure a chat widget](add-chat-widget.md#configure-chat-in-omnichannel-admin-center)
   - [Configure a Facebook channel](configure-facebook-channel.md)
   - [Configure a WeChat instance](configure-wechat-channel.md)
   - [Configure a LINE channel](configure-line-channel.md)
   - [Configure a Twitter channel](configure-twitter-channel.md)
   - [Configure a WhatsApp channel](configure-whatsapp-channel.md)
   - [Configure a Microsoft Teams channel](configure-microsoft-teams.md)
   - [Configure a custom messaging channel](configure-custom-channel.md)
6. Configure routing rules for the worksteam. More information: [Configure routing rules]()