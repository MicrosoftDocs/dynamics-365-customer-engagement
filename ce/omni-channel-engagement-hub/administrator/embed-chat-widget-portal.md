---
title: "Embed chat widget in Dynamics 365 for Customer Engagement Portal | MicrosoftDocs"
description: "Instructions to embed chat widget in Dynamics 365 for Customer Engagement Portal."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: A81052BE-05DB-43FD-A868-605101ECABD9
ms.custom: 
---

# Embed chat widget in Dynamics 365 for Customer Engagement Portal

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

After creating a chat widget, you can configure your portal to embed the chat widget in it. Once your portal is configured, your customers can interact with your organization by using the chat widget.

1.	Sign in to Omni-channel Engagement Hub.
2.	Go to **Administration** > **Work Streams**.
3.	Select the work stream where you created your chat widget.
4.	On the **Chat settings** tab, select the name of the chat widget you want to embed in Dynamics 365 for Customer Engagement Portal.
5.	On the **Basic details** tab, copy the widget snippet code from the **Code snippet** section.
    > [!div class=mx-imgBorder]
    > ![Copy code snippet of a chat widget](../media/chat-widget-snippet.png "Copy code snippet of a chat widget")
6.	Open the Dynamics 365 for Customer Engagement Portal app.
7.	Go to **Portal** > **Content Snippets**.
    > [!div class=mx-imgBorder]
    > ![Select Content Snippets from Portal sitemap](../media/portal-content-snippet.png "Select Content Snippets from Portal sitemap")
8.	Find the **Chat Widget Code** content snippet and open it.
    > [!div class=mx-imgBorder]
    > ![Content snippets](../media/content-snippets.png "Content snippets")
9.	On the **General** tab, scroll-down to the **Value (HTML)** section.
10.	Paste the chat widget snippet code in the **HTML** tab.
    > [!div class=mx-imgBorder]
    > ![Paste code snippet of a chat widget](../media/paste-snippet.png "Paste code snippet of a chat widget")
11.	Save the changes. The chat widget is now embedded into the portal.

> [!NOTE]
> For advanced configuration like embedding chat widget on specific web pages, use portal customization. More information: [Use the front-side editing engine to publish content](../../portals/publish-content-editing-engine.md)
