---
title: "Enable agent reject notifications| MicrosoftDocs"
description: "Learn about managing agent reject notifications in the Omnichannel Administration app"
ms.date: 09/14/2021
ms.topic: article
author: sdas
ms.author: sdas
manager: shujoshi
---

# Enable agent reject notifications

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

With the agent reject feature, you can now enable agents to automatically set agent presence to Do not disturb when they reject an incoming notification for work assignment. In addition to the status change, a message bar indicating that the agent presence was changed to Do not disturb will be displayed on the agent dashboard. Agents can reset their status by using the reset presence option that's displayed with the notification or by manually changing their status.

> [!IMPORTANT]
> Agent reject won’t apply to workstreams that have "Do not disturb" as an allowed presence for work streams. More information: [Understand and create work streams](work-streams-introduction.md)

## Enable automatic update of agent presence when a work assignment is rejected by an agent

1. In the Omnichannel Administration app, select **Notification templates** under **Agent Experience**.
2. On the **Omnichannel Configuration** page, select the **Agent Reject** tab.
3. Set the toggle to **Yes** for **Change agent status to "Do not disturb" after a notification is rejected**. The **Status name** and **Status description** settings appear.
4. Select **Save**.

> [!div class=mx-imgBorder] 
> ![Enable agent reject notifications.](media/enable-agent-reject-notifications.png "Enable agent reject notifications")

### See also

[Manage notification settings and templates](/dynamics365/customer-servi/app-profile-manager/notification-templates)  
[View notifications](oc-notifications.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
