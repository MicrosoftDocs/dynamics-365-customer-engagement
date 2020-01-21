---
title: "Enable self-service settings | MicrosoftDocs"
description: "Enable self service in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable self-service settings for customer actions in a conversation summary

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

The self-service feature displays information about the recent operations that a customer performed before starting a conversation with an agent. This information helps agents understand customer issues and provide a personalized service for enhanced customer satisfaction.

The data about recent actions that you track is stored in an entity where it's passed as part of context with self service type <!--note from editor: Not sure what "self service type" refers to?-->for a conversation that has been successfully closed between the customer and agent. A record is created for each self-service action. To learn more, see [msdyn_visitorjourney Entity Reference](../developer/reference/entities/msdyn_visitorjourney.md).

You can enable the self-service feature by using one of the following methods:

 - The Omnichannel Administration app
 - Developer experience (To learn more, see [Pass self service history as context](../developer/reference/methods/setcontextprovider.md#pass-customers-portal-navigation-as-context) and [msdyn_visitorjourney](../developer/reference/entities/msdyn_visitorjourney.md#msdyn_type-options).)

## Enable self service

1. Sign in to the Omnichannel Administration app.

2. Under **Settings**, select **Self service**. The **Omnichannel Configuration** page appears.

3. On the **Self service settings** tab, set the **Self service** toggle to **Yes**.

  > [!div class='mx-imgBorder']
  > ![Enable self service](../media/enable-self-service.png "Enable self service")
 
4. Select **Save**. The **Self service** tab will appear for the agent when a chat is started with a customer.

### See also
<!--note from editor: Just FYI, we make "See also" a level 3 heading so it doesn't show up in the mini-TOC for the article.-->
[Self service](../agent/agent-oc/oc-customer-summary.md#self-service)
