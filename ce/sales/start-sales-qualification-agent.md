---
title: Start the Sales Qualification Agent
description: Learn how to start the sales qualification settings in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 08/01/2025
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Start the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

> [!IMPORTANT]
>
> - Ensure the agent is properly configured to avoid editing configurations after starting. Editing the agent changes how leads are processed before and after the change, giving different results.
> - Ensure that terms are accepted for Bing Search and Move data across regions in Power Platform admin center.

After you configure all the settings, the **Start agent** option is enabled.  

> [!NOTE]
> For **Research and engage** mode, you must also [simulate outreach emails](run-simulation-sqa-outreach-email.md) to start the agent.

:::image type="content" source="media/sqa-settings-start-agent.png" alt-text="Screenshot of selecting start agent option on the Sales Qualification Agent settings page.":::

A confirmation message is displayed, select **Start agent** to start the agent. The agent might take a few seconds to start, and you can continue working while the agent is being started. Upon successful activation, the agent is listed under the AI agents home page with status as **On**. As soon as the agent is started, the agent starts processing the leads that match the [configured selection criteria](sales-qualification-agent-selection-criteria.md).

## Related information

- [Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)  
- [Manage the Sales Qualification Agent](manage-sales-qualification-agent.md)
