---
title: "Enable missed notification in Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing notification templates in Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Manage missed notifications
<!--Is it okay that the TOC and the title both call this "Enable missed notifications"?-->
[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

With the missed notifications feature, you can now choose to automatically set agent presence to inactive, so no new tasks will be assigned when agents miss notifications for incoming chat conversations.<!--Edit okay? I was a bit unsure how the two halves of this sentence related to each other.--> In addition to the status change, a message bar indicating that a notification has been missed appears on the agent dashboard.<!--Suggested. If you don't like, it should be "will be displayed" rather than "will display."--> Agents can reset their status by using the reset presence option that's displayed with the notification or by manually changing their status.

> [!IMPORTANT]
> Missed notifications will work only when "away" isn't an allowed presence<!--Suggest using the "allowed presence" phrase because it's what the reader will see if they go to the work streams topic.--> for work streams. More information: [Understand and create work streams](work-streams-introduction.md)<!--Would it maybe be clearer to state this in reverse? Something like "Missed notifications won't work if Away is one of the allowed presence options in work streams. More information", etc.-->

## Enable automatic update of agent presence on missed notifications

1. In the Omnichannel Administration app, select **Notifications** under **Agent Experience** in the site map.
2. On the **Omnichannel Configuration** page, select the **Missed Notifications** tab.
3. Set the toggle to **Yes** for **Change agent status to inactive after a missed notification**. The **Status name** and **Status description** settings appear.
4. Select **Save**.

> [!div class=mx-imgBorder] 
> ![Enable missed notifications](../media/enable-missed-notifications.png "Enable missed notifications")
