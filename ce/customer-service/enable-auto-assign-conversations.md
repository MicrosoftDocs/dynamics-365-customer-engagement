---
title: "Enable conversations to be assigned automatically in Omnichannel for Customer Service | MicrosoftDocs"
description: "Instructions for enabling auto-assign of conversations in Omnichannel for Customer Service."
ms.date: 07/30/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Enable conversations to be assigned automatically

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Some customer conversation requests, such as those coming from a Facebook channel or an SMS channel, might not need an immediate response because of a longer service-level agreement. For such requests, you can enable the auto-assign option in the notification templates. When an incoming notification appears, the conversation is assigned to the agent automatically, either instantly or after the timeout period elapses.

> [!IMPORTANT]
> Auto-assign isn't supported in Omnichannel for Customer Service on Unified Service Desk.

Perform the following steps:

1. In Customer Service admin center, in the site map, go to **Workspaces** under **Agent experience**.

2. Select **Manage** for **Notification templates**.

3. On the **Omnichannel Configuration** > **Omnichannel Configuration - Notifications** page, select the template for which you want to enable the incoming conversation to be assigned.

4. On the **General** tab of the ***<notification_name>* Notification Template**, set the toggle to **Yes** for **Auto-assign work items**. The label for **Accept Button** changes to **Open**, and the toggle for **Show Reject Button** is disabled.

5. Select **Save**.

> [!NOTE]
> We recommend that you don't enable the auto-assign setting in consult notification templates.


## Enable voice calls and chats to be accepted automatically

When an agent rejects an incoming conversation, it is routed back to the queue. This impacts customer SLAs, queue wait times, and customer satisfaction. To avoid such scenarios, a conversation can be automatically accepted by an agent, either instantly or after the timer elapses.

Perform the following steps:

1. In Customer Service admin center, in the site map, go to **Workspaces** under **Agent experience**.

2. Select **Manage** for **Notification templates**.

3. On the **Omnichannel Configuration** > **Omnichannel Configuration - Notifications** page, select the template for which you want to enable the incoming conversations to be assigned.

1. On the **General** tab of the ***<notification_name>* Notification Template**, set the toggle to **Yes** for **Auto-assign work items**, and then set the **Auto-accept voice/chat calls** toggle to **Yes**. The **Show Countdown** field is set to **Yes** and disabled.

5. Select **Save**.

### See also

[Manage notification templates](/dynamics365/app-profile-manager/notification-templates)  
[View notifications](oc-notifications.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
