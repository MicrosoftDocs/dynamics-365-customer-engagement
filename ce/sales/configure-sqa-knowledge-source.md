---
title: Configure knowledge source for Sales Qualification Agent (preview)
description: Learn how to configure knowledge sources for the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 08/04/2025
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

# Configure knowledge source for Sales Qualification Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Add knowledge sources in Copilot Studio to surface key insights such as customer testimonials and case studies that can be included in outreach and follow-up emails and used for researching your leads. You must add these knowledge sources in Microsoft Copilot Studio for the agent to use them.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Considerations

Consider the following before you configure knowledge sources for the Sales Qualification Agent:

- When you add a knowledge source to the agent, you're redirected to Copilot Studio. So, ensure that you have the necessary permissions to access and modify the knowledge sources in Copilot Studio. The Sales Qualification Agent uses micro agents in Copilot Studio for outreach emails, follow-up emails, and research insights. Knowledge sources added to these micro agents are only used for the specific purpose it's configured for. For example, knowledge sources added to the **Research** micro agent are only used for research insights, and not for outreach emails or follow-up emails.

- If the Sales Qualification Agent and Opportunity Research Agent are in the same environment, they share the same knowledge sources for account research insights. The knowledge sources that you add to or remove from one of the agents will be reflected in the other agent as well. If you see knowledge sources that you didn't add, it's possible that those are configured for the Opportunity Research Agent. Don't remove them unless you want to remove them from both the agents.

- When you upload files from SharePoint in Copilot Studio, select the **SharePoint** option in the **Featured** section. The **SharePoint** option under the **Upload file** section isn't supported. Selecting this option blocks the agent from processing the leads. The following screenshot shows the correct option to select in Copilot Studio:

   :::image type="content" source="media/sales-qualification-agent-knowledge-source-sharepoint.png" alt-text="Screenshot showing the correct SharePoint option to select in Copilot Studio":::

## Add knowledge sources

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  

1. In the **Knowledge** section, select the following options and configure the knowledge sources:  
    - **Research**: The agent uses knowledge sources to get research insights about the lead and their company. These insights include industry type, company size, financials, priorities, and news.  
        In the **Knowledge sources for insights** section, select **Add**. You're redirected to the **Copilot Studio** page where you can add knowledge sources. The following examples are the best sources to add as knowledge sources:

        | Insight | Typical questions answered | Examples of out-of-box data sources |
        |---------|----------------------------|-------------------------------------|
        | Company background | What does the company do? What is its size and industry? | Company website, Wikipedia pages, Crunchbase profiles |
        | Strategic priorities | What is the firm focusing on? Does their priority match with what we are selling? | Annual reports, earnings-call transcripts |
        | Financials | How healthy is the business? Will they have budget to buy what we are selling? | SEC filings, Bloomberg, Dataverse finance tables |
        | Recent news | What just happened that matters to us, and will show a need or intent for our solutions? | Bing news search |  

    - **Outreach emails**: The agent uses knowledge sources to create personalized outreach emails. These emails can include relevant customer testimonials, case studies, and other insights to engage the lead effectively.  
        In the **Knowledge sources** section, select **Add**. You're redirected to the **Copilot Studio** page where you can add knowledge sources.  
    - **Follow-up emails**: This is only applicable for **Engage**. The agent uses knowledge sources to create follow-up emails to respond accurately and ask insightful questions. For an effective follow-up, add knowledge sources that include price sources, product specifications, sales playbooks, SKUs, and more.  

- In the **Knowledge sources** section, select **Add**. You're redirected to the **Copilot Studio** page where you can add knowledge sources.  

To know more about adding knowledge sources in Copilot Studio, go to [Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot).

## Test knowledge sources

After you add knowledge sources, you can test if Sales Qualification Agent is picking these sources as part of research in the Microsoft Copilot Studio test pane.

**Follow these steps**:

> [!NOTE]
> In this example, we are using Contoso as the seller company and Microsoft as the lead company.

1. In the research source added page, select the **Test your agent** pane.
1. In the **Test your agent** pane, Enter the following script:  
    `{"sellerCompanyName": "Contoso", 
    "productInformation": "This agent is responsible for researching and qualifying high-priority leads interested in Contoso GPUs. It supports the sales team by identifying prospects with strong alignment to Contoso’s AI and HPC solutions, enabling focused and effective outreach.",
    "companyName": "Microsoft", 
    "accountDomain": "https://www.microsoft.com"}`  
    
    Replace the `sellerCompanyName` attribute with your company name, `productInformation` with your product’s value proposition that is [configured in the Products section](sales-qualification-agent-general-settings.md#configure-product-information), `companyName` with the company name where leads come from, and the `accountDomain` as company’s website.  

1. Microsoft Copilot Studio takes a few seconds to generate a response in JSON code.  
    
    :::image type="content" source="media/sales-qualification-agent-knowledge-source-test.png" alt-text="Screenshot showing the test pane in Copilot Studio for Sales Qualification Agent":::

1. Review the JSON response for the following keys&mdash;`accountFinances`, `accountOverview`.  
    The output maps the way the seller sees in the research insights once the agent is running.  

1. When you are satisfied with the output, save and activate the the knowledge source.
    Now, sellers can see the research insights in the Sales Qualification Agent once it is running.

## Example of knowledge sources

Your seller’s company sells GPUs. The administrator has added a recent report covering market share analysis of the prospective companies in the GPU market, so that the agent can use this to research any lead that comes from these companies.
Later, the administrator adds an internal CSV file capturing tech spending projections of major tech companies. This ensures that the agent gathers financial and strategic priority information from a trusted internal document.

## Best practices

The following are some best practices to consider while adding knowledge sources:

- **Keep descriptions specific**. Adding descriptions such as “Dataverse table with Assets Under Management by client” is more helpful than just “Finance table”.  
- **Limit public sites**. Too many broad domains dilute relevance; add the few that best match your industry.  
- **Review security**. The agent will only present data that the signed-in seller is permitted to access.  
- **Monitor capacity**. Large files and frequent refreshes consume AI credits; track usage in Power Platform admin center.  

With curated knowledge sources, the Sales Qualification Agent becomes a best researcher that understands your organization and surfaces the insights your sellers value most.

## Next steps

- [Run simulation to review outreach email content](run-simulation-sqa-outreach-email.md)
- [Start the Sales Qualification Agent](start-sales-qualification-agent.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
