---
title: Configure opportunity assessment for Sales Opportunity Agent
description: Learn how to configure the opportunity assessment settings for the Sales Opportunity Agent in Dynamics 365 Sales.
ms.date: 10/27/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure opportunity assessment for Sales Opportunity Agent

Configure the fields that the agent uses to assess the importance and risk of the opportunities. In addition to these fields, the agent uses other signals such as customer interactions, stakeholder engagement, and so on. 

**Follow these steps**:

1. [Open the Sales Opportunity Agent settings page](open-sales-opportunity-agent-settings.md).  
1. Under **Advanced**, select **Opportunity assessment**.  
    :::image type="content" source="media/sales-opportunity-agent-assessment-settings.png" alt-text="Screenshot of the Sales Opportunity Agent opportunity assessment settings page.":::
1. In the **Opportunity assessment** settings, select the fields that the agent should use for assessing the importance and risk of opportunities.
    - **Monetary value:** Select the field that represents the monetary value, such as **Est. revenue**.
    - **Estimated close date:** Select the field that represents the estimated close date, such as **Est. close date**. 
    - **Business process flow:** Select the business process flow that you want to use for assessing the opportunity risk. You can use the different stages of the selected business process flow when you [configure risk criteria for Sales Opportunity Agent](configure-sales-opportunity-agent-risk-criteria.md). The following options are available:
        - **Sales Process** (default): Uses the standard sales process stages (Qualified, Develop, Propose, Close).
        - **None**: Disables stage-based risk filtering.
        - **Custom business process flow**: If your organization has created custom business process flows, they appear as options in this dropdown.

    >[!NOTE]
    >You can customize the thresholds for risk and importance criteria in the **Advanced** settings. To learn more, see [Configure risk and importance criteria](sales-opportunity-agent-advanced-settings.md).

## Next step

[Configure recommended actions for Sales Opportunity Agent](configure-sales-opportunity-agent-connected-skills.md)

## Related information

[Set up and configure Sales Opportunity Agent.](configure-sales-opportunity-agent.md)


