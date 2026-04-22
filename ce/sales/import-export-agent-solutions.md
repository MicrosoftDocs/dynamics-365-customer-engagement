---
title: Import an agent into a target environment
description: Learn how to export and import sales agent solutions across environments in Dynamics 365 Sales. 
ms.date: 05/01/2026
ms.update-cycle: 90-days
ms.topic: concept-article
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:07/09/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Import an agent into a target environment

Deploy agents in sandbox or test environments before deploying them in production. This approach ensures they function correctly and helps you avoid potential disruptions to your business operations.  
In Dynamics 365 Sales, use the Application Lifecycle Management (ALM) capabilities of Power Platform to export and import agent solutions across environments. Export the agent solution from a source environment, like a sandbox or test environment, and then import it into the target environment, typically production.

Use this procedure to import a sales agent solution such as Sales Qualification Agent, Sales Opportunity Agent, Sales Close Agent, or Data Enrichment Agent into a target environment.

## Considerations

Before you begin the export and import process, consider creating a separate solution for each agent before you export from the source environment. Exporting multiple agents in the same solution can unintentionally carry configuration changes across environments.

## Export the agent as a solution

Export the agent from the source environment as a solution. During the export process, you can choose to include all the components of the agent or select specific components to include in the solution. After the export is complete, you have a solution file to import into the target environment.

1. In the source environment, go to the [Power Apps maker portal](https://make.powerapps.com/).  
1. Select the environment that contains the agent you want to export.  
1. In the left navigation pane, select **Solutions**.
1. Select **New solution** to [create a solution](/power-apps/maker/data-platform/create-solution) and enter the necessary details such as name, publisher, and version. 
1. In the newly created solution, select **Add existing** and add the following types of components related to the agent you want to export:

    | Type | Description |
    | ---- | ----------- |
    | Table | **SalesAgentProfile** (`msdyn_salesagentprofile`) <br>**SalesAgentConfigurationV2** (`msdyn_salesagentconfigurationv2`) |
    | Agent | Add agents that contain knowledge sources relevant to the agent you want to export. For example, if you are exporting the **Sales Opportunity Agent - Account Research**, knowledge sources related to account research are automatically added as part of the agent component. Here, you can see public URL for **Contoso** and a document for **Cafe Mocha** are added to the agent. Each agent type requires a specific set of agents in the solution.  For a complete list of agents, see [Agents required for solution](#agents-required-for-solution). |

    :::image type="content" source="media/import-export-agent-solutions-add-tables.png" alt-text="Screen showing the added tables in the solution.":::

1. Publish the customizations to ensure they're saved and up to date.
1. Select **Export** to export the solution and save it to a location on your computer.
    During the export process, choose the solution managed solution. A managed solution is typically used for production environments.
    For more information about exporting solutions, see [Export solutions](/power-apps/maker/data-platform/export-solutions).  

### Agents required for solution

The agents you add to the solution depend on the agent you want to export. The following list shows the agents you need to add for each sales agent solution.

| Sales agent solution type | Agents to add |
| ------------------------ | ------------- |
| Sales Qualification Agent | D365 Sales Agent - Research<br> D365 Sales Agent - Competitor<br> D365 Sales Agent - Custom Research<br> D365 Sales Agent - Readiness<br> D365 Sales Agent - Email Validation<br> D365 Sales Agent - Outreach<br> D365 Sales Agent - Engage Autonomous<br> D365 Sales Agent - TCP Prefill Agent<br> D365 Sales Agent - Stakeholder Research<br> D365 Sales Agent - Engage Autonomous<br> D365 Sales Agent - Summary Synthesizer |
| Sales Opportunity Agent | <place holder> |
| Sales Close Agent | D365 Sales Agent - Research<br> D365 Sales Agent - Competitor<br> D365 Sales Agent - Custom Research |
| Data Enrichment Agent | <place holder> |

## Import the agent solution into the target environment

Import the exported solution file into the target environment. During the import process, you can choose to overwrite any existing components in the target environment that have the same name as those in the solution. After the import is complete, the agent is available in the target environment.

### Prerequisites

Before you begin the import process, ensure the following prerequisites are met:

- Create the following components manually in the target environment before activating the agent, as they're environment-specific and aren't included in the exported solution:  
    - Dataverse application user  
    - Required application registrations  
  
- The solution doesn't automatically include agent prerequisites that you configured in the source environment. Configure the prerequisites in the target environment before importing the solution:  
    - For Sales Qualification Agent, see [Configure requirements for Sales Qualification Agent](configure-requirements-for-sqa-agent.md).  
    - For Sales Opportunity Agent, see [Configure requirements for Sales Opportunity Agent](configure-requirements-for-sales-close-agent-research.md).
    - For Sales Close Agent, see [Configure requirements for Sales Close Agent](configure-requirements-for-sales-close-agent.md).
    - For Data Enrichment Agent, see [Configure prerequisites](data-enrichment-agent-configure.md#prerequisites).  

### Import the solution

1. Go to the [Power Apps maker portal](https://make.powerapps.com/) in the target environment.
1. Select the target environment where you want to import the agent solution.
1. In the left navigation pane, select **Solutions**.
1. Select **Import solution** and upload the solution file you exported from the source environment.  
    For more information, see [Import solutions](/power-apps/maker/data-platform/import-update-export-solutions).
1. Follow the prompts to complete the import process. During the import, choose to overwrite any existing components in the target environment that have the same name as those in the solution. This option ensures that the agent components are updated with the ones from the source environment.
    The solution is imported to the target environment and is listed in the **AI agents** page in your environment.  

### Configure and start the imported agent

After you import the solution, the agent is in draft state. Configure environment‑specific settings before activating the agent.  

1. **Select the application user**. Application users differ between source and target environments.
    1. Go to the imported agent configuration page. 
    1. In the agent profile section, select the Dataverse application user created for this agent.  
1. **Review assignment rules**. Some assignment‑related values configured in the source environment might not resolve correctly in the target environment. For example, if the assignment rule is based on a team or user that doesn't exist in the target environment, update the rule to ensure it functions correctly.
    1. Open the Assignment rules section.  
    1. Update any unresolved or incorrect values and text to ensure the assignment rules work as expected in the target environment.
1. **Verify knowledge sources**. Knowledge sources automatically appear after solution import if they were added to the corresponding bots in the source environment. However, the content within those knowledge sources might differ between environments. For example, if a SharePoint document library was used as a knowledge source in the source environment, the same document library might not be available in the target environment. Update the knowledge sources to point to the correct content in the target environment.
    1. Open the Knowledge source section.
    1. Verify that all configured knowledge sources are available. If any knowledge source is missing or not correctly configured, update it to ensure the agent has access to the necessary information.
1. **Activate the agent**. After updating the environment‑specific settings, save and start the agent.

## Related information

[AI agents in Dynamics 365 Sales](ai-agent-overview.md)