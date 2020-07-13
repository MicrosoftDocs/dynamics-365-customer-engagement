---
title: "Enable conversation notifications to be accepted automatically in Omnichannel for Customer Service | MicrosoftDocs"
description: "Instructions for enabling auto-accept conversation notifications in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable conversations to be accepted automatically

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

Some conversation requests from customers do not need an immediate response. For such requests, you can enable the auto-accept option in notification templates. When an incoming notification appears, the conversation is assigned to the agent automatically, either instantly or after the timeout period elapses. The agent will not be able to accept or reject the conversation.

## Enable conversations to be accepted automatically

1. In the Omnichannel Administration app, select **Notifications** under **Agent Experience** in the sitemap.
2. On the **Omnichannel Configuration** > **Omnichannel Configuration - Notifications** page, select the template for which you want to enable the incoming conversation notifications to be accepted.
3. On the ***<notification_name>* Notification Template** > **General** tab, set the toggle to **Yes** for **Auto-assign work items**. The label for **Accept Button** changes to **Open** and the toggle for **Reject Button** is disabled.
4. Select **Save**.

   > ![Enable automatic acceptance of conversations](../media/enable-auto-accept-chat.png " Enable automatic acceptance of conversations ")

### See also

[Manage notification templates](notification-templates.md)