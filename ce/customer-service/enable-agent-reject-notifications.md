---
title: "Enable automatic status update on rejection of work assignment| MicrosoftDocs"
description: "Learn about managing agent reject notifications in the Omnichannel Administration app"
ms.date: 09/23/2021
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# Enable automatic update of presence on rejection of work assignment

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction
You can enable the agent presence to be updated to **Do not disturb** when agents reject an incoming notification for a work assignment. Also, a message indicating that the agent presence was changed is displayed at the top of the agent dashboard. Agents can reset their status by using the reset presence option that's displayed with the notification or by manually changing their status.

> [!IMPORTANT]
>
> - The status will not change for agents when the the work is routed through a workstream that has **Do not disturb** as an allowed presence. More information: [Create workstreams for unified routing](create-workstreams.md)
> - Automatic change of agent status when agent rejects a notification is not supported in Omnichannel for Customer Service on Unified Service Desk.

## Enable notifications

1. Sign in to the Omnichannel admin center. In the **Advanced Settings** area, go to **Agent Experience**, and then select  **Notification templates**.  

2. On the **Omnichannel Configuration** page, select the **Agent Reject** tab.  
3. Set the **Change agent status to "Do not disturb" after a notification is rejected** toggle to **Yes**. The **Status name** and **Status description** settings appear.
4. Select **Save**.

> [!div class=mx-imgBorder] 
> ![Enable agent reject notifications.](media/enable-agent-reject-notifications.png "Enable agent reject notifications")

### See also

[Manage notification settings and templates](/dynamics365/customer-servi/app-profile-manager/notification-templates)  
[View notifications](oc-notifications.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
