---
title: Work on leads handed over by the Sales Qualification Agent
description: Learn how to work with leads handed over by the Sales Qualification Agent in Dynamics 365 Sales. Discover research insights, handover summaries, and recommended actions for effective lead management.
ms.date: 09/30/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Work on leads handed over by the Sales Qualification Agent

Depending on the automation level your admin has configured, the Sales Qualification Agent can help you qualify leads by automatically by completing the following tasks:

- **Research-only mode**:
    - Researches leads and determines whether they are a good fit for your business based on the ideal customer profile.
    - Provides insights about the lead, such as company information, financial health, and recent news. 
    - Hands over the lead to a seller if it fits your ideal customer profile. Else, disqualifies the lead and notifies the supervisor.
    - Generates a draft outreach email for you to review and send.

- **Research and engage mode**:
    - Researches leads and determines whether they are a good fit for your business based on the ideal customer profile and BANT criteria (Budget, Authority, Need, and Timelines).
    - Provides insights about the lead, such as company information, financial health, and recent news.
    - Sends a personalized outreach email to the lead based on its insights.
    - Engages with the lead based on their responses to the outreach email.
    - Sends follow-up emails to the lead based on their responses and engagement.
    - Hands over the lead to you when it detects positive intent. Else, disqualifies the lead and notifies the supervisor. Additional handover scenarios are explained in the Lead handover process section below.

## Prerequisites

- Your admin has [set up the Sales Qualification Agent](./configure-sales-qualification-agent.md) for your org.
- Check with your admin about the following details:
  - The mode of the agent (Research-only or Research and engage).
  - The selection criteria for leads that the agent will handle.
  - The ideal customer profile (ICP) and BANT criteria configured to determine the lead's fit.
  - The assignment rules for agent handover.  
  This information helps you understand how the agent will process leads and what actions you need to take.

## Lead handover process

The lead handover process goes through the following stages:

1. When a lead meets the selection criteria defined by your admin, it gets assigned to the agent for processing. 
1. After the agent processes the lead and completes its analysis, it hands over the lead to you for further action. Depending on the mode configured by your admin, the handover happens at different stages.
    - **Research-only mode**:
        When the ideal customer profile (ICP) fit for a lead is high or medium, the agent hands over the lead to a seller as per the [assignment rule configured by the admin](configure-sqa-assignment-rules.md) for outreach and engagement. If the ICP fit is low, the agent disqualifies the lead and notifies the supervisor. The lead continues to be assigned to the agent in this case.

    - **Research and engage mode**:
        The agent hands over the lead to a seller as per the [assignment rule configured by the admin](configure-sqa-assignment-rules.md) in the following scenarios:
        - The lead meets the ICP and BANT criteria, sends a positive response to the outreach email, or shows positive intent. In this case, you can review the research and engagement summary and qualify the lead if appropriate.
        - The agent can't detect the lead's intent. Review the research and engagement summary and follow up with the lead to determine their purchase intent.
        - The agent is blocked on the lead as it's unable to find the answer to the lead's question. Respond to the lead's question and follow up with the lead.
    > [!NOTE]
    >- If the assignment rule is set to assign leads to a team, the agent assigns the lead in a round-robin fashion to the team members.
    >- If the agent fails to process the lead due to invalid or missing email, it hands over the lead to the original seller to update the email ID.
    
1. If the lead doesn't meet the hand over criteria, the agent disqualifies the lead and notifies the supervisor. The lead continues to be assigned to the agent in this case.

## View leads handed over by the agent

If you're a seller, you get notified when a lead is handed over to you. If you missed that, follow the steps in this section to view all leads handed over to you by the Sales Qualification Agent.

If you're a supervisor, you get notified when a lead is disqualified by the agent. Learn more in [View leads disqualified by the agent](#view-leads-disqualified-by-the-agent). You can also view detailed agent performance metrics and data on the AI Optimization hub. Learn more in [Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md).

> [!NOTE]
> If you don't see the views mentioned in this section, contact your admin to [add agent-specific views to your app](start-sales-qualification-agent.md#add-agent-specific-views-to-your-app).

1. In the Sales Hub app, go to **Leads**.

1. From the views drop-down, select **My leads from AI Agent** to view all leads handed over to you by the agent. Leads remain in this view even after they are qualified or disqualified by you.
   > [!NOTE]
   > The agents hands over leads that [meet the handoff criteria](configure-sales-qualification-agent-handoff-criteria.md) defined by your admin.
1. Select a lead.
   - If you're in the focused view, you'll see the **Lead research** page for the lead.

   - If you're in the read-only grid view, you'll see the lead form. Wait for a few seconds for the page to load the research summary at the top of the lead form.  
    :::image type="content" source="media/lead-research-insights-summary.png" alt-text="Screenshot of the lead research insights summary at the top of the lead form.":::

      The summary includes recommended actions and reasons for recommendation.  
1. Select **See full research** to view the [**Lead research** page](#lead-research-page).

## View leads disqualified by the agent

Leads disqualified by the agent are not handed over to sellers. If you're a supervisor, you can view these leads to understand why the agent disqualified them and reassign them to a seller if you think they are worth pursuing.

1. In the Sales Hub app, go to **Leads**.

1. From the views drop-down, select **Leads disqualified by AI agent**.
   > [!NOTE]
   > Though this view is meant for supervisors, it is also available to sellers unless your admin has set the `EnableRoleBasedSystemViews` setting to **true**.
1. Open a lead to view the reason for disqualification. The reason is displayed in the **Lead research** page under the **Suggested action** section.
1. If you think the lead is worth pursuing, select **Reassign** to assign it to a seller.
   The lead is handed over to a seller based on the [assignment rule configured by the admin](configure-sqa-assignment-rules.md).

### Lead research page

The **Lead research** page offers a 360-degree view of the lead, key insights, and provides recommended actions. Most of the insights are the same in both modes of the agent. In the following sections, we highlight the differences where applicable.

#### Header

The header section includes the same information in both Research-only and Research and engage modes. The following screenshot shows the header of the **Lead research** page:

:::image type="content" source="media/leads-insights-page-header.png" alt-text="Screenshot of the header of the Lead research page in research and engage mode.":::

This section includes the basic information about the lead:

- **Lead information**: Provides key details about the lead, including topic, job title, company name, phone number, and primary email address from the lead record. This section also includes the lead rating, which the agent calculates based on various factors. Learn more about [how lead rating is calculated](sales-qualification-agent-concepts.md#how-does-the-agent-determine-the-lead-rating).

- **Connected accounts and contacts**: Select the link icon next to the lead's name to view the accounts and contacts that are connected to the lead. 
    - If the lead isn't connected to any account, the agent automatically connects to the most relevant account by matching the lead's email address with the company and domain name.
    - If the lead isn't connected to any contact, the agent automatically connects to the most relevant contact by matching the lead's email address with the existing contacts.
   If the connected records aren't accurate, select **Disconnect** to remove the connection and then connect the lead to a different account or contact. The connected records are used to evaluate the lead's fit and generate outreach emails.  

- **Email validation**: The agent performs checks on a lead's primary email address to ensure it is active, deliverable, and relevant for business communications. Checks include **Email validity** (properly formatted and deliverable; prompts for correction if invalid) and **Email type** (work or personal, labeled in the interface). You can mark the address as valid/invalid and work/personal by selecting the email icon.

- **Research timestamp**: Displays the date and time when the agent last updated its research data for the lead. This helps you understand how current the insights are. The agent doesn't refresh the research data unless there's a change that significantly impacts the current evaluation of the lead. Learn more about the trigger events in [When does the agent run?](sales-qualification-agent-faq.md#when-does-the-agent-run)

#### Suggested action

The following screenshot shows the **Suggested action** section of the **Lead research** page in research and engage mode as an example.

:::image type="content" source="media/lead-insights-page-suggested-action.png" alt-text="Screenshot of the Suggested action section of the Lead research page in research and engage mode.":::

This section summarizes the lead's alignment with the hand over criteria and provides recommended actions. Select the call-to-action button to take action. The following actions are available:
  
**Research-only mode**: 
    - **Draft email**: Displays the pre-generated outreach email that you can review and send to the lead.
    - **Reassign**: Lets you reassign a disqualified lead to a seller if you think it is worth pursuing.
**Research and engage mode**: 
    - **Draft email**: Displays the email draft for following up with the lead. 
    - **Qualify**: Lets you qualify the lead.
    - **Reassign**: Lets you reassign a disqualified lead to a seller if you think it is worth pursuing.

#### Key insights

The following screenshot shows the **Key insights** section of the **Lead research** page in Research and engage mode as an example.

:::image type="content" source="media/lead-insights-page-key-insights.png" alt-text="Screenshot of the Key insights section of the Lead research page in research and engage mode.":::

- **What happened to this lead? (Available only in Research and engage mode)**: Includes an interaction summary that outlines any CRM activities such as emails, phone calls, appointments, and Customer Insights - Journeys interactions that the agent had with the lead. This section helps the seller quickly get up to speed with all the interactions between the agent and the lead.

- **Why this lead is rated hot, warm, or cold**: Summarizes the key reasons for rating the lead as hot, warm, or cold. See [How does the agent determine the lead rating?](sales-qualification-agent-concepts.md#how-does-the-agent-determine-the-lead-rating).

- **How was this generated?**: Displays the signal strength and the series of steps that the agent performed to generate the insights. 

    - **Signal strength**: Indicates the completeness and reliability of the input data used to generate the insights. The higher the signal strength, the more reliable the insights are. The agent proactively flags when it lacks sufficient or reliable data to complete the research and make a strong recommendation. This helps you distinguish between weak signals due to poor data versus lack of interest from the lead.
    - **Steps interpretation**: Includes the chain-of-thought reasoning that the agent used to generate the insights. This helps you understand how the agent arrived at its conclusions and recommendations.
- The following screenshot shows the signal strength and steps in Research-only mode.

    :::image type="content" source="media/lead-insights-page-explainer.png" alt-text="Screenshot of the How was this generated section of the Lead research page in research-only mode.":::

#### Deeper insights

**Company overview**

The agent searches the public web for information about the lead’s company. If your admin has configured custom knowledge sources for research, the agent prioritizes looking for information from those specified websites.

- **Overview:** Fetches general information about the lead’s company, such as industry, location, company size, products and services sold, and whether it is B2B or B2C. Outlines the company’s strategic priorities and how those relate to your offerings.
- **Finances:** Summarizes the company’s financial health, outlines key financial metrics, and interprets what they mean for your sales approach.
- **News:** Summarizes up to three recent news articles and explains how they relate to your offerings.

**Competitor insights**

The agent identifies the key competitors for the lead and provides insights about them. This information can help you understand the competitive landscape and tailor your sales approach accordingly. The agent provides the following insights about competitors based on public web sources and knowledge sources configured by your admin.

Learn more about [How the agent identifies competitors to research](sales-qualification-agent-competitor-insights.md#how-the-agent-identifies-competitors-to-research).

- **Overview:** Provides a brief description of each competitor, including their industry, location, size, and market share based on public information and knowledge sources configured by your admin.
- **Strengths, weaknesses, opportunities, and threats (SWOT analysis):** Summarizes the key strengths, weaknesses, opportunities, and threats of each competitor based on public information and knowledge sources configured by your admin.
- **Talking points:** Suggests potential talking points to differentiate your offerings from those of the competitors based on battle cards, positioning briefs, and other competitive intelligence documents configured by your admin as knowledge sources.

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq.md)
- [Set up the Sales Qualification Agent](configure-sales-qualification-agent.md)
