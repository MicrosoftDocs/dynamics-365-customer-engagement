---
title: Configure assignment rules for Sales Qualification Agent
description: Learn how to configure the assignment rules for the Sales Qualification Agent in Dynamics 365 Sales.
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

# Configure assignment rules for Sales Qualification Agent

Once the leads are qualified based on the handover criteria, the agent hands them over to sellers or teams based on your selection. The agent uses the round-robin distribution to assign leads fairly among the selected sellers or team.

> [!NOTE]
> Supervisors and sellers must have the salesperson role assigned to them and have at least read permission for the leads handed over by the agent.  

**Follow these steps**:

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the **Guidance** section, select **Assignment rules**.  

    :::image type="content" source="media/sqa-settings-assignment-rules.png" alt-text="Screenshot of the Sales Qualification Agent settings page with assignment rules highlighted.":::

1. Select whom to hand over the leads from the following options:  
    - **Sellers/Teams**: Select the users or team who will handle the leads transferred by the agent. If you choose to assign leads to teams, the leads are assigned to sellers within the team in round robin order.
    - **Add supervisor**: Select a supervisor who will monitor the leads assigned to the agent and take action when necessary. Currently, all users are listed. However, we recommend selecting users with the Sales Manager role.

## Next steps

[Configure knowledge source for Sales Qualification Agent](configure-sqa-knowledge-source.md)

## Related information

- [Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)  
- [(Seller)Work on leads handed over by the Sales Qualification Agent](use-sales-qualification-agent.md)  
- [(Supervisor)Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md)  
