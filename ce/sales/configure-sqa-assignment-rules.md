---
title: Configure assignment rules for Sales Qualification Agent
description: Learn how to configure the assignment rules for the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 07/31/2025
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

# Configure assignment rules for Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Once the leads are qualified based on the handoff criteria, the agent hands them over to sellers or teams based on your selection. The agent uses the round robin distribution to assign leads fairly among the selected sellers or team.

> [!NOTE]
> Supervisors and sellers must have the salesperson role assigned to them and have at least read permission for the leads handed over by the agent.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the **Guidance** section, select **Assignment rules**.  

    :::image type="content" source="media/sqa-settings-assignment-rules.png" alt-text="Screenshot of the Sales Qualification Agent settings page with assignment rules highlighted.":::

1. Select whom to hand over the leads from the following options:  
    - **Sellers**: Select the users who will handle the leads transferred by the agent. Select **Add users** and then search and select the users.  
        After you select the users, choose the supervisor who will monitor the assigned leads and handle any issues or escalations. Currently, all users are listed.  
    - **Teams**: Select a team. The processed leads are assigned to sellers within this team who get leads in round robin order. You can select only one team from the list. Select Add team, and then search and add the team.  
        After you select the users, choose the supervisor who will monitor the assigned leads and handle any issues or escalations. Currently, all users are listed.

## Next steps

[Configure knowledge source for Sales Qualification Agent](configure-sqa-knowledge-source.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
