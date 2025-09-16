---
title: Configure Sales Qualification Agent to generate competitor insights
description: Learn how to configure the selection criteria for the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to 
ms.date: 09/16/2025
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

## Configure Sales Qualification Agent to generate competitor insights

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Qualification Agent can provide insights about competitors for a lead, helping sellers understand the competitive landscape and tailor their sales approach accordingly.

As an admin, you can configure the agent to generate competitor insights by specifying key competitors and uploading relevant knowledge sources. The agent uses this information to research competitors and provide insights such as their strengths, weaknesses, and market position, and generate talking points for sellers.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

<a name="competitor-identification"></a>
## How the agent identifies competitors to research

The agent identifies the competitors for a lead from the following sources:

- Competitors added to the lead record are given the highest priority, regardless of other sources.
- If no competitors are specified in the lead record, the agent looks for competitors from:
    - Web search results based on account research and value proposition.
    - Closed opportunities that include competitor information.
    - Competitors list configured in the agent settings (as explained in the following section).
   
    The agent prioritizes competitors based on the number of sources they appear in. If a competitor is mentioned across multiple sources, the agent prioritizes that competitor. The following table illustrates how the agent prioritizes competitors based on different scenarios:
    
    | Scenario                                                                                  | Which competitors are considered?                                   |
    |-------------------------------------------------------------------------------------------|---------------------------------------------------------------------|
    | Contoso appears in three sources, Fabrikam in two, and Northwind in one                   | Contoso                     |
    | Contoso and Fabrikam each appear in three sources, Northwind in two                       | Contoso and Fabrikam  |
    | Contoso and Fabrikam both appear in two sources           | The competitor from the most recent opportunity is prioritized      |
    | Contoso, Fabrikam, and Northwind each appear in one source (No overlap among sources)     | Competitors configured by the admin are shown as fallback           |
    | No competitor information available in records and no competitors configured in agent settings             | Competitors from web search results are shown                       |

The agent ranks the competitors and researches the top most competitor. If there are multiple competitors with the same rank, the agent provides research insights for up to three competitors.

## Add competitors and knowledge sources for competitor insights

When the agent doesn't find competitor information in the lead record or other public web sources, it uses the competitors list you specify in the agent settings. Learn more about [how the agent identifies competitors to research](#competitor-identification).

You can also upload relevant documents such as battle cards, positioning briefs, and market analysis reports to help the agent generate more accurate and relevant insights.

1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the **Research insights** section, go to **Competitor insights**.

1. Under **Key competitors**, select **+ Competitor** to add up to three competitors for the product line that the agent will work on.  
1. Select **Add** or **Manage** to add or remove knowledge sources for competitor insights. 
   The **D365 Sales Agent - Competitors** agent's **Knowledge** page opens in Copilot Studio. 

1. Select **Add knowledge** and then select **Upload file**.
   > [!NOTE]
   > You can only upload slide decks or documents as knowledge sources for competitor insights.
1. Select the documents. You can group similar documents into a group to help the agent understand the context better. For example, you can group all documents related to a specific competitor. Select **Upload** > **Upload as a group** to upload the documents as a group.  

   :::image type="content" source="media/group-upload-copilot-studio.png" alt-text="Screenshot of the Group upload option in Copilot Studio.":::  

   You can also group individual documents into a group after uploading them. Select a document in the **Knowledge** page and select **Create file group** to create a group and add the document to it.