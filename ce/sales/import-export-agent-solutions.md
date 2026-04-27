---
title: Import an agent into a target environment
description: Learn how to export and import sales agent solutions across environments in Dynamics 365 Sales. 
ms.date: 04/27/2026
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

## Best practices

- Create **one solution per agent profile** to ensure each profile can be packaged and deployed independently. Including multiple profiles in a single solution might result in exporting unintended or untested changes.

- Use **organization-agnostic filters** in selection criteria so profiles continue to work after migration to another environment. Otherwise, you might need to manually update the filters after import.

## Export the agent as a solution

Export the agent from the source environment as a solution. During the export process, you can choose to include all the components of the agent or select specific components to include in the solution. After the export is complete, you have a solution file to import into the target environment.

1. In the source environment, go to the [Power Apps maker portal](https://make.powerapps.com/).  
1. Select the environment that contains the agent you want to export.  
1. In the left navigation pane, select **Solutions**.
1. Select **New solution** to [create a solution](/power-apps/maker/data-platform/create-solution) and enter the necessary details such as name, publisher, and version.  
1. Add required components.  
    Select **Add existing** > **More** > **Other** and then add the following components:  
    - **SalesAgentProfile**. When you create the agent, a corresponding agent profile is automatically created. In the **Add existing SalesAgentProfile** pane, select the agent profile from the list of existing agent profiles.  
    - **SalesAgentConfigurationV2**. When you create the agent, corresponding agent configurations are automatically created with the same name as the agent profile. In the **Add existing SalesAgentConfigurationV2** pane, select the agent configuration that has the same name as the agent profile you selected.  
    - **Sequence** (for Sales Qualification Agent only). When you create the Sales Qualification Agent, a corresponding sequence record is automatically created in the sequence component. In the **Add existing Sequence** pane, select the sequence record with the name **AgenticSequence**.  

1. Add knowledge sources.  
    Select **Add existing** > **Agent** > **Agent** and then add agents that contain knowledge sources relevant to the agent you want to export. For example, if you're exporting the **Sales Opportunity Agent - Account Research**, knowledge sources related to account research are automatically added as part of the agent component. Each agent type requires a specific set of agents in the solution. The following table shows the agents you need to add for each agent solution.  

    | Sales agent solution type | Agents to add |
    | ------------------------- |------------- |
    | Sales Qualification Agent | D365 Sales Agent - Research<br> D365 Sales Agent - Competitor<br> D365 Sales Agent - Custom Research<br> D365 Sales Agent - Readiness<br> D365 Sales Agent - Email Validation<br> D365 Sales Agent - Outreach<br> D365 Sales Agent - Engage Autonomous<br> D365 Sales Agent - TCP Prefill Agent<br> D365 Sales Agent - Stakeholder Research<br> D365 Sales Agent - Engage Autonomous<br> D365 Sales Agent - Summary Synthesizer |
    | Sales Opportunity Agent | Sales Opportunity Agent<br> Sales Opportunity Agent - Account Research<br>Sales Opportunity Agent - Compete Research<br>Sales Opportunity Agent - Custom Research<br>Sales Opportunity Agent - Stakeholder |
    | Sales Close Agent | Sales Close Agent |
 
    The following image shows an example of the added components for Sales Qualification Agent.  
    :::image type="content" source="media/import-export-agent-solutions-add-tables.png" alt-text="Screenshot of the added tables in the solution.":::

1. Save and publish the customizations.
1. Select **Export** to export the solution and save it to a location on your computer.  
    During the export process, choose the solution managed solution. A managed solution is typically used for production environments.
    For more information about exporting solutions, see [Export solutions](/power-apps/maker/data-platform/export-solutions).  

## Import the agent solution into the target environment

Import the exported solution file into the target environment. During the import process, you can choose to overwrite any existing components in the target environment that have the same name as those in the solution. After the import is complete, the agent is available in the target environment. 

>[!NOTE]
>- The agent is always imported in draft state.  
>- When you open the imported agent, select **Apply changes** to ensure that all the components of the agent are correctly applied in the target environment.  

### Import the solution

1. Go to the [Power Apps maker portal](https://make.powerapps.com/) in the target environment.
1. Select the target environment where you want to import the agent solution.
1. In the left navigation pane, select **Solutions**.
1. Select **Import solution** and upload the solution file you exported from the source environment.  
    For more information, see [Import solutions](/power-apps/maker/data-platform/import-update-export-solutions).
1. Follow the prompts to complete the import process. During the import, choose to overwrite any existing components in the target environment that have the same name as those in the solution. This option ensures that the agent components are updated with the ones from the source environment.
    The solution is imported to the target environment and is listed in the **AI agents** page in your environment.  

### Configure and start the agent

After you import the solution, the agent is imported in draft state. Open the agent and configure environment‑specific settings before starting the agent.

#### For Sales Qualification Agent, Sales Opportunity Agent, and Sales Close Agent

1. Create the following components manually in the target environment, as they're environment-specific and aren't included in the exported solution:  

    - Dataverse application user  
    - Required application registrations  

1. **Configure the prerequisites**. The exported solution doesn't include prerequisites because they often contain environment‑specific values that might differ between source and target environments.  

    - For Sales Qualification Agent, see [Configure requirements for Sales Qualification Agent](configure-requirements-for-sqa-agent.md).  
    - For Sales Opportunity Agent, see [Configure requirements for Sales Opportunity Agent](configure-requirements-for-sales-close-agent-research.md).
    - For Sales Close Agent, see [Configure requirements for Sales Close Agent](configure-requirements-for-sales-close-agent.md).

1. **Select the application user**. Application users differ between source and target environments.

    1. Go to the imported agent configuration page.  
    1. In the agent profile settings page, select the Dataverse application user created for this agent.  

1. **Review assignment rules or selection criteria**. Some assignment‑related values configured in the source environment might not resolve correctly in the target environment. For example, if the assignment rule is based on a team or user that doesn't exist in the target environment, update the rule to ensure it functions correctly.

    1. Open the **Assignment rules** settings page.  
    1. Update any unresolved or incorrect values and text to ensure the assignment rules work as expected in the target environment.  

1. **Verify knowledge sources**. Knowledge sources automatically appear after solution import if they were added to the corresponding bots in the source environment. However, the content within those knowledge sources might differ between environments. For example, if a SharePoint document library was used as a knowledge source in the source environment, the same document library might not be available in the target environment. Update the knowledge sources to point to the correct content in the target environment.  

    1. Open the **Knowledge sources** settings page.  
    1. Verify that all configured knowledge sources are available. If any knowledge source is missing or not correctly configured, update it to ensure the agent has access to the necessary information.  

1. **Activate the agent**. After updating the environment‑specific settings, save and start the agent.

#### For Deal Enrichment Agent

1. **Configure the prerequisites**. The exported solution doesn't include prerequisites because they often contain environment‑specific values that might differ between source and target environments. See [Configure prerequisites](data-enrichment-agent-configure.md#prerequisites) for more information.  

1. **Review record selection rules**. Some values in the record selection rules might not resolve correctly in the target environment. For example, if the rule is based on a team or user that doesn't exist in the target environment, update the rule to ensure it functions correctly.

    1. In the configuration page, go to the **Record selection** settings page.  
    1. Update any unresolved or incorrect values to ensure the record selection rules work as expected in the target environment.  
    To learn more about record selection, see [Select records for enrichment](data-enrichment-agent-edit-settings.md#select-records-for-enrichment).  

1. **Verify user access**. User access to the agent might differ between source and target environments. Ensure that users in the target environment have the necessary permissions to access and use the agent.

    1. In the configuration page, go to the **User access** settings page.  
    1. Verify that all users who need access to the agent have the appropriate permissions.  
    To learn more about user access, see [Configure user access](data-enrichment-agent-edit-settings.md#configure-user-access).  

1. **Verify field scope**. The fields selected for enrichment in the source environment might not be the same as those in the target environment. Review the selected fields to ensure they align with the requirements in the target environment.

    1. In the configuration page, go to the **Agent behavior** settings page.  
    1. In the **Field scope** section, review the selected fields and update them if necessary to ensure the agent enriches the correct data in the target environment.  
    To learn more about field scope, see [Configure agent behavior](data-enrichment-agent-edit-settings.md#configure-agent-behavior).  

1. **Activate the agent**. After updating the environment‑specific settings, save and start the agent.

## Related information

[AI agents in Dynamics 365 Sales](ai-agent-overview.md)