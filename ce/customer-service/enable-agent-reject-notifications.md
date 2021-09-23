---
title: "Enable agent reject notifications| MicrosoftDocs"
description: "Learn about managing agent reject notifications in the Omnichannel Administration app"
ms.date: 09/21/2021
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# Enable agent reject notifications

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

With the agent reject feature, you can now enable agents to automatically set agent presence to **Do not disturb** when they reject an incoming notification for a work assignment. In addition to the status change, a message bar indicating that the agent presence was changed to **Do not disturb** is displayed on the agent's dashboard. Agents can reset their status by using the reset presence option that's displayed with the notification or by manually changing their status.

> [!IMPORTANT]
>
> - Agent reject won't apply to workstreams that have **Do not disturb** as an allowed presence for workstreams. More information: [Create workstreams for unified routing](create-workstreams.md)<!--note from editor: Edited because it looks like work-stream-introduction.md now resolves to create-workstreams.md.-->
> - Agent reject notification alerts aren't supported in Omnichannel for Customer Service on Unified Service Desk.


## Enable automatic update of agent presence when a work assignment is rejected by an agent

1. Sign in to Omnichannel Administration. In the **Agent Experience** area, select **Notifications**.

   or

   Sign in to the Omnichannel admin center. In the **Advanced Settings** area, go to **Agent Experience**, and then select  **Notification templates**.  

2. On the **Omnichannel Configuration** page, select the **Agent Reject** tab.  
3. Set the **Change agent status to "Do not disturb" after a notification is rejected** toggle to **Yes**. The **Status name** and **Status description** settings appear.
4. Select **Save**.

> [!div class=mx-imgBorder] 
> ![Enable agent reject notifications.](media/enable-agent-reject-notifications.png "Enable agent reject notifications")

### See also

[Manage notification settings and templates](/dynamics365/customer-servi/app-profile-manager/notification-templates)  
[View notifications](oc-notifications.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
