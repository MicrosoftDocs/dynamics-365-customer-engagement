---
title: Configure knowledge sources for Sales Qualification Agent
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

# Configure knowledge sources for Sales Qualification Agent

By default, the agent uses public web data sources to research leads and their companies. However, you can enhance the relevance of the research insights and email content by adding custom knowledge sources that are specific to your organization and industry. For example, you can add customer testimonials and case studies as knowledge sources for outreach emails to engage with leads effectively.

## Considerations

Before you configure knowledge sources for the Sales Qualification Agent, consider the following factors:

- When you add a knowledge source to the agent, you'll be redirected to Microsoft Copilot Studio. So, ensure that you have the necessary permissions to access and modify the knowledge sources in Copilot Studio. The Sales Qualification Agent uses specialized, micro agents in Copilot Studio for outreach emails, follow-up emails, and research insights. Knowledge sources added to these micro agents are only used for the specific purpose it's configured for. For example, knowledge sources added to the **Research** micro agent are only used for research insights, and not for outreach emails or follow-up emails.

- If the Sales Qualification Agent and Opportunity Research Agent are in the same environment, they share the same knowledge sources for account research insights. The knowledge sources that you add to or remove from one of the agents is reflected in the other agent as well. If you see knowledge sources that you didn't add, it's possible that those sources are configured for the Opportunity Research Agent. Don't remove them unless you want to remove them from both the agents.

- Ensure that any files or documents that you want the agent to use are in a SharePoint folder. Any other file sources such as OneDrive aren't supported.

- In Copilot Studio, when you upload files from SharePoint, select the **SharePoint** option in the **Featured** section. The **SharePoint** option under the **Upload file** section isn't supported. Selecting this option blocks the agent from processing the leads. The following screenshot shows the correct option to select in Copilot Studio:

   :::image type="content" source="media/sales-qualification-agent-knowledge-source-sharepoint.png" alt-text="Screenshot showing the correct SharePoint option to select in Copilot Studio":::

## Add knowledge sources for company research

By default, the agent uses public web data sources to research leads and their companies. However, you can add custom knowledge sources that you want the agent to use to get more relevant and specific insights about the lead and their company.

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  

1. In the **Knowledge** section, select **Research**.
1. Under **Enrich research with knowledge sources**, select **Company research**. Company insights include industry type, company size, financials, priorities, and news. The following examples are the best sources to add as knowledge sources for company research:

    | Insight | Typical questions answered | Examples of out-of-box data sources |
    |---------|----------------------------|-------------------------------------|
    | Company background | What does the company do? What is its size and industry? | Company website, Wikipedia pages, Crunchbase profiles |
    | Strategic priorities | What is the firm focusing on? Does their priority match with what we are selling? | Annual reports, earnings-call transcripts |
    | Financials | How healthy is the business? Will they have budget to buy what we are selling? | SEC filings, Bloomberg, Dataverse finance tables |
    | Recent news | What just happened that matters to us, and shows a need or intent for our solutions? | Bing news search |  

1. Select **Add in Microsoft Copilot Studio** or **Manage in Microsoft Copilot Studio** to add or remove knowledge sources.
   You're redirected to the D365 Sales Agent - Research agent's **Knowledge** page in Copilot Studio.
1. Add relevant knowledge sources and return to the agent settings page.
   The knowledge sources you added in Copilot Studio are listed under **Company research**. You can now test the knowledge source.
1. Select the Test icon (:::image type="icon" source="media/test-icon.png" border="false":::) in the **Company research** section. Follow the instructions in the **Test insight** pane and verify whether the agent is generating relevant research insights using the knowledge sources you added.

## Add competitors and knowledge sources for competitor research

By default, the agent identifies competitors using CRM data and public web sources. You can add competitors list and add custom knowledge sources that you want the agent to use to get more relevant and specific insights about your competitors. Learn more in [Configure Sales Qualification Agent to generate competitor insights](sales-qualification-agent-competitor-insights.md).

## Add knowledge sources for custom research topics

By default, the agent generates research insights on standard topics such as company overview, financials, recent news, and competitor analysis using CRM records and public data. However, your sellers might need additional insights about the lead's company, such as their past spend from your internal billing data, or financial reports sourced from a country/region-specific data source. You can configure the agent to generate research insights based on these custom topics by specifying the topics and uploading relevant knowledge sources.

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  

1. Under **Knowledge**, select **Research**, and then scroll down to the **Create custom research** section.
1. Select **Create custom research** and enter the following details:
   - **Display name**: Enter a name for the custom research topic. This name is used as a title for the research insights generated by the agent and shown on the Lead insights page.
 
   - **What insight you want the seller to see**: Describe the type of insight you want the agent to generate for this topic. For example, "Summarize the lead company's past purchase history from our internal billing system."
   - **Preferred knowledge source**: Select a knowledge source that the agent should use to generate insights for this topic. The agent lists the knowledge sources and [MCP tools](connect-to-model-context-protocol-sales.md) configured in the D365 Sales Agent - Custom Research agent in Copilot Studio. You can add other knowledge resources or MCP tools to generate insights for custom research topics. If you don't select any knowledge sources, the agent relies on its own knowledge, public data, and other sources you've configured.
1. Return to the Sales Qualification Agent settings page and select the Test icon (:::image type="icon" source="media/test-icon.png" border="false":::) in the **Custom research** section. Follow the instructions in the **Test insight** pane and verify whether the agent is generating relevant research insights using the knowledge sources you added.

## Add knowledge sources for outreach and follow-up emails

You can add knowledge sources that the agent can use to draft outreach and follow-up emails to leads. For example, you can add customer testimonials and case studies as knowledge sources for outreach emails to engage with leads effectively.

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).
1. In the **Knowledge** section, select **Agent emails**. Add knowledge sources for the following email types:
        - **Knowledge sources for email personalization**: The agent uses these knowledge sources to draft personalized outreach emails. Add relevant customer testimonials, case studies, and other insights to engage with the lead effectively.  
        - **Knowledge sources for email responses**: This setting is only applicable for the Research and engage mode. The agent uses these knowledge sources to draft follow-up emails to respond accurately and ask insightful questions. For an effective follow-up, add knowledge sources that include price sources, product specifications, sales playbooks, SKUs, and more.  
1. Select **Manage** to add or remove knowledge sources in Microsoft Copilot Studio.
   For email personalization, the D365 Sales Agent - Outreach Emails agent's **Knowledge** page opens in Copilot Studio.
    For email responses, the D365 Sales Agent - Engage Autonomous agent's **Knowledge** page opens in Copilot Studio.
1. Add relevant knowledge sources and go back to the agent settings page.
   The knowledge sources you added in Copilot Studio are listed under the respective email type.


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

[Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot)  
[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
