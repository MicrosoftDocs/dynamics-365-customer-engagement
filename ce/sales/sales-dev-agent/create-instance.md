---
title: Create a Sales Development agent instance (preview)
description: Learn how to create an instance of the Sales Development agent in Microsoft Teams or Microsoft 365 Copilot.
ms.date: 08/21/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Create a Sales Development agent instance (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You can create an instance of the Sales Development agent from either the Microsoft Teams Store or the Microsoft 365 Copilot Agent Store.

> [!NOTE]
> An administrator must [activate the Sales Development agent](activate-agent.md) in the Microsoft 365 admin center before you can create an instance.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

1. Based on your preference, go to either Microsoft Teams or Microsoft 365 Copilot.
    - In Microsoft Teams, go to **Store**, go to the **Agents for your team** category, or search for **Sales Development (Frontier)**.
    - In Microsoft 365 Copilot, go to **Agents**, scroll to **Agents for your team**, or search for **Sales Development (Frontier)**.

1. Select the agent, and then select **Create instance**.

    :::image type="content" source="media/create-agent-instance-1.png" alt-text="Screenshot of creating a Sales Development agent instance.":::

1. Create the agent identity by entering a unique name and email alias.

1. Select **Create** to finish.

    :::image type="content" source="media/create-agent-instance.png" alt-text="Screenshot of entering name and email alias when creating a Sales Development agent instance.":::

    > [!NOTE]
    > During instance creation, you may be able to choose a different email domain. After the agent is created, an IT admin can change the username, email alias, and domain in Microsoft Entra or the Microsoft 365 admin center.

    The agent is then created with its own identity and provisioned with a Teams account, Exchange mailbox, OneDrive, and SharePoint.

    > [!NOTE]
    > Provisioning typically takes about 5 minutes, but it can take longer.