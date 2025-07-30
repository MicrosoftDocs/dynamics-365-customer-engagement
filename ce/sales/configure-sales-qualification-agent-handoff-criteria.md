---
title: Configure hand off criteria for the Sales Qualification Agent
description: Configure ideal customer profile, budget, authority, need, and timeline criteria for the Sales Qualification Agent to effectively qualify leads.
ms.date: 07/31/2025
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

# Configure hand off criteria for the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define the ideal customer profile and BANT (Budget, Authority, Need, and Timeline) information to help the agent identify leads that it should focus on and engage with.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Configure the ideal customer profile and BANT criteria

Both Research-only and Research and engage modes use the ideal customer profile to identify leads that match your target customer characteristics. However, BANT criteria are only used by the Research and engage mode to determine whether to engage with a lead.

By default, the application defines a set of criteria. You can update any out-of-the-box criteria to add or remove attributes. Also, you can create a custom criterion.

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.  
1. In the **Handoff criteria** section, enter or select the criteria that describe your ideal customer profile, including industries, employee size, decision making roles, customer location, and annual revenue.  
1. (Research and engage mode only) Specify the BANT (Budget, Authority, Need, Timeline) criteria to help the agent identify leads it should engage with. The agent uses [purchase interest signals](sales-qualification-agent-concepts.md#what-is-purchase-interest-and-how-is-it-determined) along with BANT to evaluate leads and determine whether to engage with them. The agent evaluates the leads in the following order&mdash;need, timeline, budget, and authority.  
   The following table explains when a lead is qualified or disqualified based on the configured criteria:  

    | Criteria type | Value | Qualify or disqualify? |
    |---------------|-------|------------------------|
    | Purchase interest | Positive | Qualify |
    |                   | Negative | Disqualify |
    | BANT score | Medium or above matches at least two criteria | Qualify |
    |            | Low with one or no matches | Disqualify |

    When all qualification criteria are selected, the handover is done in the following ways:
    - If a lead satisfies both BANT and purchase interest criteria, then the lead is handed over to a seller or team with the lead readiness summary and recommended next set of actions.  
    - If a lead doesn’t satisfy any one criteria type, then the lead is disqualified. Upon disqualification, a summary is generated for the lead with reasons for disqualification and handed over to the supervisor for review in the supervisor dashboard.

   >[!NOTE]
   > If you don't want the agent to use BANT, you can leave the fields empty. However, we recommend that you define the BANT criterion to help the agent identify leads that it should engage with. When BANT is not defined, the agent uses only the [purchase interest signals](sales-qualification-agent-concepts.md#what-is-purchase-interest-and-how-is-it-determined) to evaluate leads and determine whether to engage with them.

1. Under each criteria, expand the **Where's this info stored** section to verify the fields used by default to evaluate the criteria. You can change these fields if needed.  

   :::image type="content" source="media/sqa-ideal-customer-profile.png" alt-text="Screenshot of the ideal customer profile configuration in Sales Qualification Agent settings.":::

1. Select **Add** to add a different field from the lead table or other related tables.  
     > [!TIP]
     > If you're just testing the agent, you can create a simple ideal customer profile that includes only a few criteria, such as industry and job title. This will make it easier to create leads that match the profile and validate the agent's functionality. For example, you can set the industry to "Technology" and the job title to "Manager". After this succeeds, you can gradually add more criteria that are relevant to your business.

      If you want to use custom fields or tables, [add a custom criterion](#add-custom-criteria-to-your-hand-off-criteria).

## Add custom criteria to your hand off criteria

Use custom criteria to define characteristics that are important for your ideal customer profile. You can map your criteria to custom fields in Dataverse or add public URLs that provide the relevant information. For example, you could add a custom criterion for "Environmental Sustainability Initiatives" and map it to a custom field in Dataverse or provide a URL that lists the company's key environmental initiatives.

1. [Open the Sales Qualification Agent settings page](open-sales-qualification-agent-settings.md) and go to the **Handoff criteria** section.

1. Select **New custom criterion**.  

1. Enter the name of the custom criterion and describe your criterion and what you're looking for. For example, enter the following details:
   - **Custom category:** Environmental Sustainability Initiatives
   - **Describe your target custom criteria:** The company should have a strong commitment to environmental sustainability, with at least 3 major initiatives in place. This description will help the agent understand what to look for when evaluating leads against this criterion.

1. Under **Where's this info stored?**, select **Add** to define where the agent should find the information. Select one of the following options depending on source of information you want to use for the custom criterion:
    - **Dataverse Field**: Select this option to map the custom criterion to a field in Dataverse. Select the field that the agent should use to validate the lead's fit.
    - **Website URL**: Select this option to provide a URL that contains information about the lead's company. The agent uses information in this URL to validate the lead's fit. The URL must be publicly accessible and not require any authentication.

1. If you added a URL, provide instructions for the agent to extract the information you're looking for.
   1. In the text box, enter the company's URL.
   2. Select **Next**.
   3. In the **Provide instructions** dialog, add specific instructions about the information you want the agent to extract from the website. Also, you can add a Dataverse field to the instruction by adding a forward slash (/).
   For example, you could say, "Look at the company's sustainability report and identify their key environmental initiatives /". The forward slash opens a dropdown list of available fields in the Dataverse table. Select a table and field from the list. In this example, Lead > Company Name is selected. The instruction is now "Look at the company's sustainability report and identify their key environmental initiatives based on {{Lead.Company Name}}."

    :::image type="content" source="media/sqa-ideal-customer-profile-custom-criterion-instruction.png" alt-text="Screenshot of adding instructions for the custom criterion.":::

1. Select **Add**.  
   The custom criterion is now added to the hand off criteria section. 

### Next step

[Configure assignment rules for the Sales Qualification Agent](configure-sqa-assignment-rules.md)

### Related information

- [Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
- [Understand Sales Qualification Agent concepts](sales-qualification-agent-concepts.md)