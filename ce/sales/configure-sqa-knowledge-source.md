---
title: Configure knowledge sources for Sales Qualification Agent (preview)
description: Learn how to configure knowledge sources for the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 09/17/2025
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

# Configure knowledge sources for Sales Qualification Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Add knowledge sources that the agent can use for researching leads and their companies, and for drafting outreach and follow-up emails. For example, you can add customer testimonials and case studies as knowledge sources for outreach emails to engage leads effectively.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Considerations

Consider the following before you configure knowledge sources for the Sales Qualification Agent:

- When you add a knowledge source to the agent, you're redirected to Copilot Studio. So, ensure that you have the necessary permissions to access and modify the knowledge sources in Copilot Studio. The Sales Qualification Agent uses specialized, micro agents in Copilot Studio for outreach emails, follow-up emails, and research insights. Knowledge sources added to these micro agents are only used for the specific purpose it's configured for. For example, knowledge sources added to the **Research** micro agent are only used for research insights, and not for outreach emails or follow-up emails.

- If the Sales Qualification Agent and Opportunity Research Agent are in the same environment, they share the same knowledge sources for account research insights. The knowledge sources that you add to or remove from one of the agents is reflected in the other agent as well. If you see knowledge sources that you didn't add, it's possible that those sources are configured for the Opportunity Research Agent. Don't remove them unless you want to remove them from both the agents.

- Ensure that the knowledge sources that you want the agent to use are in the SharePoint folder. Any other file sources such as OneDrive aren't supported.

- When you upload files from SharePoint in Copilot Studio, select the **SharePoint** option in the **Featured** section. The **SharePoint** option under the **Upload file** section isn't supported. Selecting this option blocks the agent from processing the leads. The following screenshot shows the correct option to select in Copilot Studio:

   :::image type="content" source="media/sales-qualification-agent-knowledge-source-sharepoint.png" alt-text="Screenshot showing the correct SharePoint option to select in Copilot Studio":::

## Add knowledge sources for the agent

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  

1. In the **Knowledge** section, select the following options and configure the knowledge sources:  
    - **Research**: The agent uses knowledge sources to get research insights about the lead, their company, and their competitors. 
        - **Company insights:** Company insights include industry type, company size, financials, priorities, and news. The following examples are the best sources to add as knowledge sources for company research:

            | Insight | Typical questions answered | Examples of out-of-box data sources |
            |---------|----------------------------|-------------------------------------|
            | Company background | What does the company do? What is its size and industry? | Company website, Wikipedia pages, Crunchbase profiles |
            | Strategic priorities | What is the firm focusing on? Does their priority match with what we are selling? | Annual reports, earnings-call transcripts |
            | Financials | How healthy is the business? Will they have budget to buy what we are selling? | SEC filings, Bloomberg, Dataverse finance tables |
            | Recent news | What just happened that matters to us, and shows a need or intent for our solutions? | Bing news search |  

        - **Competitor insights:** Competitor insights include industry, location, size, and market share of the competitor, their strengths, weaknesses, opportunities, and threats (SWOT analysis), and recommended talking points to position against the competitor. Learn more in [Configure Sales Qualification Agent to generate competitor insights (preview)](sales-qualification-agent-competitor-insights.md).
    - **Outreach emails**: The agent uses knowledge sources to create personalized outreach emails. These emails can include relevant customer testimonials, case studies, and other insights to engage the lead effectively.  
    - **Follow-up emails**: This setting is only applicable for the Research and engage mode. The agent uses knowledge sources to create follow-up emails to respond accurately and ask insightful questions. For an effective follow-up, add knowledge sources that include price sources, product specifications, sales playbooks, SKUs, and more.  

1. In the **Knowledge sources** section, select **Add**. You're redirected to the **Copilot Studio** page where you can add knowledge sources.  

To know more about adding knowledge sources in Copilot Studio, go to [Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot).

### Test knowledge source for company insights

After you add knowledge sources for company insights, you can test if Sales Qualification Agent is picking these sources as part of research in the Microsoft Copilot Studio test pane.

**Follow these steps**:

> [!NOTE]
> In this example, we're using Contoso as the seller company and Microsoft as the lead company.

1. Open the **Research** agent in Copilot Studio.
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

1. When you're satisfied with the output, save and activate the knowledge source.
    Now, sellers can see the research insights in the Sales Qualification Agent once it's running.

## Example Scenario: Contoso Investment Bank targets high-net-worth (HNW) leads

Goal: Contoso’s sales operations team wants the agent to decide if a lead’s personal net worth exceeds US$5 million. If it does, they want to include tailored talking points in the outreach email.

| Insight area         | Contoso data source| How to add|
|----------------------|------------------|--------------------|
| Financials           | SharePoint list "Client financial profiles" (NetWorth, AUM, RiskTolerance)<br> | Add as a knowledge source, describe columns, tag with financials                                 |
| Company background   | Public site hoovers.com profile pages<br>Dunn & Bradstreet (D&B) number from Account.DUNSNumber | Add https://www.hoovers.com/ as a public website<br>D&B’s D-U-N-S number is synced to Dataverse Account table and added to Copilot Studio. |
| Recent news          | Bloomberg RSS feed for the prospect’s company                                     | Upload the RSS XML file or connect via a news API                                            |
| Strategic priorities | Contoso analyst reports stored in a SharePoint library                            | Add SharePoint URL                                                                           |


After you publish the knowledge sources, the agent:

- Fetches NetWorth from the SharePoint list to decide if the lead meets the high-net-worth threshold.
- Uses Dunn & Bradstreet’s high-quality data to augment public sources.  
- Surfaces company priorities from the analyst reports suggesting relevant investment products.
- Quotes the latest Bloomberg headline in the latest news card.  
- Generates an email that references the lead’s net-worth range and a recent strategic move.

## Best practices

The following are some best practices to consider while adding knowledge sources:

- **Keep descriptions specific**. Adding descriptions such as "Dataverse table with Assets Under Management by client" is more helpful than just "Finance table."  
- **Limit public sites**. Too many broad domains dilute relevance; add the few that best match your industry.  
- **Review security**. The agent only presents data that the signed-in seller is permitted to access.  
- **Monitor capacity**. Large files and frequent refreshes consume AI credits; track usage in Power Platform admin center.  

With curated knowledge sources, the Sales Qualification Agent becomes a best researcher that understands your organization and surfaces the insights your sellers value most.

## Next steps

- [Run simulation to review outreach email content](run-simulation-sqa-outreach-email.md)
- [Start the Sales Qualification Agent](start-sales-qualification-agent.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
