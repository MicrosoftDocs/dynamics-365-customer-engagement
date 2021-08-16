---
title: Enable entities for queues | MicrosoftDocs
description: Learn how you can enable entities for queues so that they can be routed through unified routing.
ms.date: 08/11/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Enable entities for queues for unified routing

## Enable an entity for queues<a name="enable-entities"> </a>

Any record you want to enable for routing needs to be enabled for queues.

1. Sign in to the Dynamics 365 instance.

2. Select **Settings** > **Customizations** > **Customize the System**.

3. Expand **Entities** below **Components**.

4. Select a record from the solution pane.

5. Select the Queues checkbox under **Communication & Collaboration** section:

6. Select **Save**.

7. Select **Publish**.

> [!Note]
> If you enable the option - **Automatically move records to the owner's default queue when a record is created or assigned**, in the entity customization, then the record won't be automatically distributed to the agents. You must clear the checkbox to automatically distribute the records. <br><br> ![Automatic record movement to the agent's default queue.](media/route-owner-queue.png "Automatic record movement to the agent's default queue")