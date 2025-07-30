---
title: Work on leads handed over by the Sales Qualification Agent
description: 
ms.date: 07/03/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Work on leads handed over by the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Depending on the automation level your admin has configured, the Sales Qualification Agent can help you qualify leads by automatically by completing the following tasks:

- **Research-only mode**:
    - Researches leads and determines whether they are a good fit for your business based on the ideal customer profile.
    - Provides insights about the lead, such as company information, financial health, and recent news. 
    - Hands off the lead to you if it fits your ideal customer profile or disqualifies the lead if it isn't a good fit.
    - Generates a draft outreach email for you to review and send.

- **Research and engage mode**:
    - Researches leads and determines whether they are a good fit for your business based on the ideal customer profile and BANT criteria (Budget, Authority, Need, and Timelines).
    - Provides insights about the lead, such as company information, financial health, and recent news.
    - Sends a personalized outreach email to the lead based on its insights.
    - Engages with the lead based on their responses to the outreach email.
    - Sends follow-up emails to the lead based on their responses and engagement.
    - Hands off the lead to you when it detects positive intent or disqualifies the lead if it isn't a good fit or detects negative intent.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Your admin has [set up the Sales Qualification Agent](./configure-sales-qualification-agent.md) for your org.
- Check with your admin about the following details:
  - The mode of the agent (Research-only or Research and engage).
  - The selection criteria for leads that the agent will handle.
  - The ideal customer profile (ICP) and BANT criteria configured to determine the lead's fit.
  - The assignment rules for agent handover.
  This information helps you understand how the agent will process leads and what actions you need to take.

## Lead hand over process

The lead hand over process goes through the following stages:

1. When a lead meets the selection criteria defined by your admin, it gets assigned to the agent for processing. 
1. After the agent processes the lead and completes its analysis, it hands over the lead to you for further action. Depending on the mode configured by your admin, the hand over happens at different stages.
    - **Research-only mode**:
        When the ideal customer profile (ICP) fit for a lead is high or medium, the agent hands over the lead to a seller as per the [assignment rule configured by the admin](configure-sqa-assignment-rules.md) for outreach and engagement. If the ICP fit is low, the agent disqualifies the lead. The lead continues to be assigned to the agent.
    - **Research and engage mode**:
        The agent hands over the lead in the following scenarios:
        - The lead meets the ICP and BANT criteria, sends a positive response to the outreach email, or shows positive intent. In this case, you can review the research and engagement summary and qualify the lead if appropriate.
        - The agent can't detect the lead's intent. Review the research and engagement summary and follow up with the lead to determine their purchase intent.
        - The agent is blocked on the lead as it's unable to find the answer to the lead's question. Respond to the lead's question and follow up with the lead.
       If the lead doesn't meet the hand off criteria, the agent disqualifies the lead. The lead continues to be assigned to the agent in this case.

    > [!NOTE]
    > If the assignment rule is set to assign leads to a team, the agent assigns the lead in a round-robin fashion to the team members.

## View leads handed over by the agent

You get notified when a lead is handed over to you. If you missed that, follow these steps to view the leads handed over by the Sales Qualification Agent.

1. In the Sales Hub app, go to **Leads**.

1. From the views drop-down, select **Leads handed over by AI Agent**.
1. Select a lead.
   - If you're in the focused view, you'll see the **Lead insights** page for the lead.

   - If you're in the read-only grid view, you'll see the lead form. Wait for a few seconds for the page to load the research summary at the top of the lead form.  
    :::image type="content" source="media/lead-research-insights-summary.png" alt-text="Screenshot of the lead research insights summary at the top of the lead form.":::

      The summary includes recommended actions and reasons for recommendation. Select **See full research** to view the **Lead insights** page.

### Lead insights page

The **Lead insights** page offers a 360-degree view of the lead, key insights, and provides recommended actions. Most of the insights are the same in both modes of the agent. In the following sections, we highlight the differences where applicable.

#### Header

The following screenshot shows the header of the **Lead insights** page in Research and engage mode.

:::image type="content" source="media/leads-insights-page-header.png" alt-text="Screenshot of the header of the Lead insights page in research and engage mode.":::

- **Lead information**: Provides key details about the lead, including topic, job title, company name, phone number, primary email address, and lead rating. Learn more about [how lead rating is calculated](sales-qualification-agent-concepts.md#how-does-the-agent-determine-the-lead-rating).

- **Connected accounts and contacts**: Select the link icon next to the lead's name to view the accounts and contacts that are connected to the lead. If the lead isn't connected to any account or contact, the agent automatically connects to the most relevant account and contact records based on the lead's email address, domain, and company name. If the connected records aren't accurate, select **Disconnect** to remove the connection and then connect the lead to a different account or contact.  
If you manually connect a record, the agent uses that connection for future research.
- **Email validation**: The agent performs checks on a lead's primary email address to ensure it is active, deliverable, and relevant for business communications. Checks include **Email validity** (properly formatted and deliverable; prompts for correction if invalid) and **Email type** (work or personal, labeled in the interface). You can mark the address as valid/invalid and work/personal by selecting the email icon.

- **Research timestamp**: Displays the date and time when the agent last updated its research data for the lead. This helps you understand how current the insights are. The agent doesn't refresh the research data unless there's a change that significantly impacts the current evaluation of the lead. Learn more about the trigger events in [When does the agent run?](sales-qualification-agent-faq.md#when-does-the-agent-run)

#### Suggested action

The following screenshot shows the **Suggested action** section of the **Lead insights** page in research and engage mode.

:::image type="content" source="media/lead-insights-page-suggested-action.png" alt-text="Screenshot of the Suggested action section of the Lead insights page in research and engage mode.":::

This section summarizes the lead's alignment with the hand off criteria and provides recommended actions. Select the call-to-action button to take action. The following actions are available:
  
- **Research-only mode**: The **Draft email** action lets you view the pre-generated outreach email and send it to the lead.  
- **Research and engage mode**: The **Draft email** action lets you view the response to a pending inquiry from the lead, if any. The **Qualify** action lets you qualify the lead.

#### Key insights

The following screenshot shows the **Key insights** section of the **Lead insights** page in Research and engage mode.

:::image type="content" source="media/lead-insights-page-key-insights.png" alt-text="Screenshot of the Key insights section of the Lead insights page in research and engage mode.":::

- **What happened to this lead? (Available only in Research and engage mode)**: Includes an interaction summary that outlines any CRM activities such as emails, phone calls, appointments, and Customer Insights - Journeys interactions that the agent had with the lead. This section helps the seller quickly get up to speed with all the interactions between the agent and the lead.

- **Why this lead is rated hot, warm, or cold**: Summarizes the key reasons for rating the lead as hot, warm, or cold. See [How does the agent determine the lead rating?](sales-qualification-agent-concepts.md#how-does-the-agent-determine-the-lead-rating).

- **How was this generated?**: Displays the signal strength and the series of steps that explains how the agent generated the insights. **Signal strength** indicates the quality and completeness of the input data used to generate the insights. The higher the signal strength, the more reliable the insights are. The following screenshot shows the signal strength and steps in Research-only mode.

:::image type="content" source="media/lead-insights-page-explainer.png" alt-text="Screenshot of the How was this generated section of the Lead insights page in research-only mode.":::

#### Deeper insights

**Company overview, finances, and news**

The agent searches the public web for information about the lead’s company. If your admin has configured custom knowledge sources for research, the agent prioritizes looking for information from those specified websites.

- **Overview:** Fetches general information about the lead’s company, such as industry, location, company size, products and services sold, and whether it is B2B or B2C. Outlines the company’s strategic priorities and how those relate to your offerings.
- **Finances:** Summarizes the company’s financial health, outlines key financial metrics, and interprets what they mean for your sales approach.
- **News:** Summarizes up to three recent news articles and explains how they relate to your offerings.


## View leads disqualified by the agent

Leads disqualified by the agent are not handed over to sellers. If you're a supervisor, you can view these leads to understand why the agent disqualified them and reassign them to a seller if you think they are worth pursuing.

1. In the Sales Hub app, go to **Leads**.
1. From the views drop-down, select **Leads disqualified by AI Agent**.
1. Open a lead to view the reason for disqualification. The reason is displayed in the **Lead insights** page under the **Suggested action** section. 
1. If you think the lead is worth pursuing, select **Reassign** to assign it to a seller. 
   The lead is handed over to a seller based on the [assignment rule configured by the admin](configure-sqa-assignment-rules.md).


## Filter leads by priority ranking

The Sales Qualification Agent ranks leads based on how well they match the ideal customer profile. Instead of manually sorting through leads, you can filter them based on whether the agent ranked them as high, medium, or low priority. Focusing on the most promising leads can help improve your sales outcomes.

1. In the Sales Hub app, select **Leads**.

1. If you're in the focused view, switch to the read-only grid.

1. On the **My Open Leads** page, select **Edit filters**.

    **Owner** should already be set to **Equals current user**, and **Status** should equal **Open**.

1. Add a filter for **Related entity** with the following values:

    - **Related entity**: Select **Lead Agent Results**.
    - **Operator**: Select **Contains data**.

1. Add a filter for a field in the **Lead Agent Results** entity with the following values:

    - **Field**: Select **Qualification Result Rank**.
    - **Operator**: Select **Equals**.
    - **Value**: Select the ranks, such as **High** and **Medium**.

   :::image type="content" source="media/agent-ranked-leads-list.png" alt-text="Screenshot showing the Edit filters pane for the Leads table with a filter on Qualification Result Rank applied.":::

1. Apply the filters.  
    Leads that match the specified qualification rank criteria are displayed.

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq.md)
- [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md)
