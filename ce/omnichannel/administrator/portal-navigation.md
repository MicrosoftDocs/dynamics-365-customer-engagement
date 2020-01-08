---
title: "Enable portal navigation | MicrosoftDocs"
description: "Enable portal navigation in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable self service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

The portal navigation feature displays information on the path (recent operations) the customer took just before initiating a conversation. The information enables the agents to understand why a customer reached out and also to provide a personalized service with fast resolution and improved customer satisfaction.

The data that you track as recent actions is stored in an entity where it is passed as part of context with portal navigation type, for a conversation that has been successfully closed between the customer and agent. A portal navigation record is created for each portal navigation action. To learn more, see [msdyn_visitorjourney Entity Reference](../developer/reference/entities/msdyn_visitorjourney.md).

## Prerequisites

- As an administrator, you need to enable the feature for the agents to see the **Portal navigation** tab is displayed to the agents when in a session. To learn more, see [Enable portal navigation](portal-navigation.md#enable-portal-navigation).
- As a developer, you need to enable the portal navigation using the developer experience. To learn more, see [Pass portal navigation history as context](../developer/reference/methods/setcontextprovider.md#pass-customers-portal-navigation-as-context) and [msdyn_visitorjourney](../developer/reference/entities/msdyn_visitorjourney.md#msdyn_type-options). 

## Enable portal navigation

1. Sign in to the Omnichannel Administration app.

2. Select **Portal navigation** under **Settings**. The **Omnichannel Configuration** page appears.

3. On the **Portal navigation settings** tab, set the **Portal Navigation** toggle to **Yes**.

4. Select **Save**.

## See also

[Self service](../agent/agent-oc/oc-customer-summary.md#Self service)
