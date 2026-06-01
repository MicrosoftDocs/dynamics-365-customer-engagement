---
title: Configure recommended actions
description: Learn how to configure recommended actions in Dynamics 365 Sales to help sellers focus on the most effective tasks for their opportunities.
ms.date: 06/01/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure Recommended actions (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an admin, you can configure recommended actions to control which agents are used, how actions are prioritized, and whether the feature is enabled.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Enable recommended actions for agents

Enable recommended actions depending on the agents you have in your organization. When you turn on the recommended actions toggle for an agent, the **Recommended Actions** agent appears in the list of AI agents.  

### Sales Opportunity Agent

1. In the agent configuration page, go to **Guidance** > **Connected skills**.
1. In the **Recommended action** section, turn on the toggle.  

    :::image type="content" source="media/soa-recommended-actions-toggle.png" alt-text="Recommended actions toggle in Sales Opportunity Agent configuration page":::

The recommended actions feature is enabled and action insight cards start appearing on opportunities that meet the criteria for the Sales Opportunity Agent.  

### Data Enrichment Agent

1. In the Data Enrichment Agent configuration page, go to **General** > **Connected skills**.  
1. In the **Recommended action** section, turn on the toggle.  

    :::image type="content" source="media/dea-recommended-actions-toggle.png" alt-text="Recommended actions toggle in Data Enrichment Agent configuration page":::  

The recommended actions feature is enabled and action insight cards from the Data Enrichment Agent start appearing on opportunities that meet the criteria for the agent.  

## Add custom agents for recommended actions

Add custom agents to show actions in the recommended actions experience by adding them to the recommended actions framework. To add the agent to the framework:

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.  
1. Go to **General settings** > **Dynamics 365 AI hub**.

    :::image type="content" source="media/sqa-settings-home-page.png" alt-text="Screenshot of the Sales Qualification Agent settings home page.":::

1. In the **Agent manager** section, select **Create and manage agent**.  
    The **AI agent** page opens.  
1. Select **Create**.  
    The create an agent dialog opens.
1. In the **Recommended Actions** section, select **Choose**.  
    The configuration page opens.

1. Select **Sources** and then select **New custom source**.
    The add a custom source dialog opens.
1. In the **Add a custom source** dialog, enter the following information:

    | Field | Description |
    |-------|-------------|
    | Source name | Enter a name for the custom source. This name identifies the source of the action in the recommended actions interface. |
    | Source ID | Enter a unique identifier string value that identifies the custom source. The system uses this ID to recognize and differentiate between different sources. For example, use a GUID or UUID. |
    | Description | Enter a description for the custom source. This description provides additional context about the source and the type of actions it provides. |

    :::image type="content" source="media/add-custom-source-dialog.png" alt-text="Screenshot of the add a custom source dialog in recommended actions configuration page.":::

1. Select **Add**.
    The custom source is added to the recommended actions framework and listed in the custom sources section of the configuration page. Your custom agent can now use the added custom source to return actionable insights that appear in the recommended actions interface.
    
    :::image type="content" source="media/custom-source-added.png" alt-text="Screenshot of the recommended actions configuration page showing the added custom source.":::

1. Comfigure the custom agents using the ```msdyn_PushActionDataToRecommendedActionAgent``` API to return actionable insights in the format required by the recommended actions framework. For more information, refer to the [Recommended actions API documentation](developer/recommended-actions-api.md).

## Disable recommended actions

To disable recommended actions for an agent, turn off the recommended actions toggle in the agent's configuration page.  
When  disabled, the agent continues to run and generate insights in its own interface but the insights don't appear in the recommended actions interface. You can re-enable the source at any time to get the insights back in the recommended actions interface.  

## Permissions required for custom security roles

If you use custom security roles in your organization, add the following privileges to allow users to access and interact with recommended actions. Built-in sales security roles include these privileges by default.

| Privilege | Table | Access level |
|-----------|-------|--------------|
| `prvReadmsdyn_rawactioncatalogue` | msdyn_rawactioncatalogue | User (Basic) |
| `prvWritemsdyn_rawactioncatalogue` | msdyn_rawactioncatalogue | User (Basic) |
| `prvReadmsdyn_prioritizedactioncatalogue` | msdyn_prioritizedactioncatalogue | User (Basic) |
| `prvWritemsdyn_prioritizedactioncatalogue` | msdyn_prioritizedactioncatalogue | User (Basic) |
| `prvReadmsdyn_recommendedactionsourceagentconfig` | msdyn_recommendedactionsourceagentconfig | Organization (Global) |
| `prvReadmsdyn_salesagentprofile` | msdyn_salesagentprofile | Organization (Global) |
| `prvReadmsdyn_dataqualitysuggestion` | msdyn_dataqualitysuggestion | Organization (Global) |
| `prvWritemsdyn_dataqualitysuggestion` | msdyn_dataqualitysuggestion | User (Basic) |
| `prvReadmsdyn_dataqualitysource` | msdyn_dataqualitysource | Organization (Global) |

To add these privileges to a custom security role, go to **Power Platform admin center** > **Environments** > select your environment > **Settings** > **Users + permissions** > **Security roles**. Open the custom role, locate each table on the **Custom Entities** or relevant tab, and set the specified access level.

## Migrate agents across environments

When you have configured the Recommended Actions Agent in one environment, you can export the agent as a solution and import it into another environment. This is especially useful when you have set up the agent in a sandbox or test environment and want to deploy it in production after testing and validation. Learn more in [Import an agent into a target environment](import-export-agent-solutions.md). 

## Related information

- [Add Custom Agent to the Recommended Actions Agent](developer/recommended-actions-api.md)  
- [Recommended actions overview](recommended-actions-overview.md)

