---
title: Qualify leads smartly with sales qualification agent
description: 
ms.date: 02/19/2025
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
  - ai-gen-description
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Qualify leads smartly with sales qualification agent

As a seller, qualifying leads is crucial to your success. The sales qualification agent gets detailed research insights about your leads and determines if they are a good fit for your business. Thus, helping you prioritize leads that you should focus on.

## Prerequisite

Before you start using the sales qualification agent, ensure your admin has enabled and configured the sales qualification agent.

## Selection criteria for research

The sales qualification agent uses the following criteria to select leads for research and ideal customer profile (ICP) matching:

- Leads that are "open"
- Leads that are created in the last 14 days
- Leads owned by sellers of the security role that's allowed to access the agent

The agent refreshes the research data based on the schedule set by your admin. 

### Qualify leads with the sales qualification agent

1. In the Sales Hub app, go to **Leads**.
2. Select a lead from the focused view or read-only grid view.

    A banner at the top of the lead form displays the option to view insights if the lead meets the [selection criteria for research](#selectioncriteria). Question: If they selected a lead from the focused view, do they directly land on the insights page?

    :::image type="content" source="media/sqa-banner.png" alt-text="Screenshot of the My Open Leads page with the banner highlighted.":::

3. Select **View insights** to get a 360-degree view of a lead and the date and time when the research was last updated. The Lead insights page includes the following aspects:

    - **Email validation**: The agent performs two checks on a lead's primary email address (lead.emailaddress1).
        - **Email validity**: Checks whether the email is properly formatted and deliverable by looking for the [email validation errors](work-invalid-email-addresses.md). If the email is invalid, then it will be flagged in the UI as such, and the seller is prompted to enter a valid email. After the seller enters the new email ID, the lead's email address is updated.
        - **Email type**: Identifies whether the email is a work or personal address and labels it as such in the UI.

        These checks help ensure that lead emails are active, deliverable, and relevant for business communications. You can select the Email icon next to the email ID to mark the email as invalid or work/personal. 
    
    - **About lead**: This section includes information about the lead, including:
        - **Connect contact record:** Lets you connect the lead to the corresponding contact record.
        - **Lead summary**: Summarizes key fields on the lead and its related entities that have been configured by your admin.
        - **Who knows whom**: Co-workers who have previously interacted with the lead over emails or meetings.
        - **Open opportunities related to the lead**
    
        You will also get suggested contacts to connect to the lead based on the lead's email ID. Otherwise, you can manually connect a contact record to the lead using **Connect a contact record** to enrich the insights.
    
    - **About account**: This section includes information about the lead's company, including:
        - **Connect account record:** Lets you connect the lead to the corresponding account record.
        - Account summary: Summarizes key details about the connected account. The summary is displayed only if an account record is connected to the lead.
        - **Business overview**: Insights pulled from the web on the company's industry, size, products and services, and mission statement.
        - **Finances**: Insights pulled from the web on the company's financial health and key financial metrics.
        - **Account news**: Insights pulled from the web on relevant news topics such as product launches, leadership changes, contracts/clients won, community involvement, awards and recognition.
        - The following insights are displayed only if an account record is connected to the lead. To connect an account manually, select **Connect an account** in the **About account** section:
            - Suggested contacts: Other contacts at the account that the seller can reach out to.
            - Open opportunities related to the account.