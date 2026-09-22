---
title: Configure risk criteria for Sales Opportunity Agent
description: Learn how to configure risk criteria for Sales Opportunity Agent in Dynamics 365 Sales, customize assessments, and identify deal risks.
ms.date: 09/07/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure risk criteria for Sales Opportunity Agent

The agent evaluates opportunities and identifies potential deal risks that could delay or prevent a successful close. It assesses multiple risk signals and calculates an overall risk score for each opportunity.  
By default, the agent uses predefined risk criteria, but administrators can customize them to better reflect their organization's sales process and methodology.

As an administrator, you can customize the configuration of risk criteria to align with your organization's sales process and priorities.

- **Customize Default Risk Criteria**: Modify the thresholds and logic behind the default risks to align with your business processes. For example, if your sales cycle is shorter than average, you can reduce the "stalled in stage" threshold from 30 days to 10 days.  
- **Configure Role-Based Risks**: Customize the roles used in risk evaluation rather than relying on hard-coded roles. For example, instead of using a predefined "Champion" role, you can select the role used in your organization.
- **Add Stage-Specific Thresholds**: Define different risk thresholds for each stage of the sales process. For example, you might set a shorter "stalled in stage" threshold for early-stage opportunities compared to late-stage opportunities. This helps ensure risk evaluation matches the expected pace of each stage.  
- **Create Custom Risk Criteria**: Create entirely new risk criteria specific to your business. Custom risks can be defined and fine-tuned through natural language instructions and configuration settings. For example, you might create a risk criterion for "No technical approver engaged" or "Legal review not started." These custom criteria allow organizations to incorporate their own sales methodology and governance processes into the agent's risk model. For more information, see [Create custom risk criteria](#create-custom-risk-criteria).

## How the overall risk score is calculated

The agent evaluates each configured risk criterion individually and assigns a severity level. It then aggregates those evaluations into an overall opportunity risk indicator. For example:  

- No engagement for 15 days → Low risk  
- No engagement for 30 days → High risk

The agent combines all applicable risk signals to determine the overall opportunity risk level.

## Configure the risk criteria

1. [Open the Sales Opportunity Agent settings page](open-sales-opportunity-agent-settings.md).
1. Under **Advanced**, select **Risk criteria**.  
1. Open the list of available criteria and review the existing risk criteria.  

   :::image type="content" source="media/sales-close-agent-risk-criteria.png" alt-text="Screenshot of the risk criteria section on the Sales Opportunity Agent configuration page.":::
1. Modify the criteria as needed. The following table lists the available risk criteria for the **Sales Opportunity Agent**:  

    | Risk criteria | Description |
    |---------------|-------------|
    | No recent engagement | Flags opportunities with no activity (email, reply, or meeting) within the configured time window. |
    | Unresponsive champion | Flags opportunities where the champion doesn't respond after the configured number of touchpoints. |
    | Not multithreaded | Flags opportunities with limited stakeholder engagement. Multithreading means connecting with multiple contacts; this risk appears when contact coverage is below the configured threshold. |
    | Missing stakeholder roles | Flags opportunities missing one or more required stakeholder roles in connections or email conversations once the opportunity reaches the configured stage. |
    | Close date deviation | Flags opportunities where the estimated close date is near or past before reaching the configured stage. |
    | Stalled in stage | Flags opportunities that remain in the configured stage longer than the allowed number of days. |
    | Objections raised | Flags opportunities where email conversations or notes include configured objection keywords or phrases. |
    | Missing BANT info | Flags opportunities missing one or more BANT fields (Budget, Authority, Need, Timeline) by the configured stage. |
    | Aging opportunity | Flags opportunities that are open longer than the average age of previously won deals, indicating they might need extra attention. |
    | Competitor mention | Flags opportunities where competitor names or mentions appear in email conversations, signaling competitive positioning might be needed. |
    | Negative news | Flags opportunities where external events such as layoffs, budget cuts, or mergers and acquisitions detected through company insights could impact deal success. |

1. To remove a criterion from risk assessment, turn off the toggle next to it under the **Use in assessment** column.

## Create custom risk criteria

1. [Open the Sales Opportunity Agent settings page](open-sales-opportunity-agent-settings.md).
1. Under **Advanced**, select **Risk criteria**.  
1. In the **Advanced settings** section, select **New custom criterion** to create a new risk criterion.  
 
   :::image type="content" source="media/sales-close-agent-custom-risk-criteria.png" alt-text="Screenshot of the custom risk criteria section on the Sales Opportunity Agent configuration page.":::  

    In the **Custom risk criterion** section, define new risk criteria that are specific to your organization's needs.

1. In the **Custom risk criterion (Optional)** section, enter the name and description for the new risk criterion.
1. Add fields to map to the new custom risk criterion.
    1. Select **Add**.
    1. In the **Select field to map** pane, select the field that you want to map to the new custom risk criterion. Choose opportunity-related fields or fields from related entities.  
1. Repeat Step 5 for each additional field you want to map to the new custom risk criterion.  

    :::image type="content" source="media/sales-close-agent-add-custom-risk-criteria.png" alt-text="Screenshot of the process for adding a custom risk criterion on the Sales Opportunity Agent configuration page."::: 

1. After adding the necessary fields to the new custom risk criterion, select **Add**.  
    The custom risk criterion is now added and available for use in risk assessments.  

    :::image type="content" source="media/sales-close-agent-custom-risk-criteria-added.png" alt-text="Screenshot of the custom risk criterion after it is added on the Sales Opportunity Agent configuration page.":::
1. To edit or delete the existing custom risk criterion, select the **More options** (ellipsis) icon next to it.  
1. To disable a criterion from risk assessment, turn off the toggle next to it under the **Use in assessment** column. 

## Next step

[Configure importance criteria.](sales-opportunity-agent-advanced-settings.md)

## Related information

[Set up and configure Sales Opportunity Agent](configure-sales-opportunity-agent.md)

