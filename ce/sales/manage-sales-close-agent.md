---
title: Manage the Sales Close Agent
description: Learn how to manage such as stop or edit the sales close agent settings in Dynamics 365 Sales.
ms.date: 09/24/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Manage the Sales Close Agent
 
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can manage the Sales Close Agent in your organization by editing or stopping the agent.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Edit the Sales Close Agent

Edit the agent configurations to fine-tune the settings based on real-world insights, ensuring a more accurate, and efficient sales closing process.  

**Follow these steps**:

1. [Go to the agent settings page](open-sales-close-agent-settings.md).  
1. Edit the sections as required and then select **Apply changes**.  
    >[!NOTE]
    >The **Apply changes** option is available only when all the configurations are valid and shows the green check mark icon.  
1. On the confirmation dialog, select **Apply changes** to confirm the changes.  
    Applying the changes might take a few seconds to update the settings, you can continue working while the changes are being applied.  

The updated agent is active, and new records are processed according to the revised settings. However, records that are already processed based on the previous agent configurations will not be reprocessed.  

## Stop the Sales Close Agent

Stop the agent when you no longer want to use it in your organization. Stopping the agent doesn’t delete it and retains the configuration settings.

**Follow these steps**:

1. [Go to the agent settings page](open-sales-close-agent-settings.md).  
1. Open the agent and on the agent settings page, select **Stop agent**.  

    :::image type="content" source="media/sca-settings-stop-agent-page.png" alt-text="Screenshot of stopping the Sales Close Agent in settings page.":::

1. On the confirmation message select **Stop agent**.  
    The agent is stopped, and a confirmation message is displayed on the top of the page.  

Records that are already processed will continue to be available in the application. However, new records and records that are in process will not be processed.  

## Related information

[Start the Sales Close Agent](start-sales-close-agent.md)  
[Set up and configure the Sales Close Agent](configure-sales-close-agent.md)
