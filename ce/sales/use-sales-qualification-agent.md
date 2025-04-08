---
title: Qualify leads smartly with sales qualification agent
description: Learn how to use the sales qualification agent in Dynamics 365 Sales to qualify leads effectively and improve sales outcomes.
ms.date: 02/19/2025
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

# Qualify leads smartly with sales qualification agent

As a seller, qualifying leads is crucial to your success. The sales qualification agent gets detailed research insights about your leads and determines if they're a good fit for your business. Thus, helping you focus on leads that are most likely to convert.

## Prerequisite

Before you start using the sales qualification agent, ensure that your admin enabled and configured the sales qualification agent.

<a name="selectioncriteria"></a>
## Selection criteria for research

The sales qualification agent uses the following criteria to select leads for research and ideal customer profile (ICP) matching:

- Leads that are "open"
- Leads that are created in the last 14 days
- Leads owned by sellers of the security role that's allowed to access the agent

The agent refreshes the research data based on the [schedule set by your admin](configure-sales-qualification-agent.md#adjust-the-frequency-of-research-data-refresh). 

### Qualify leads with the sales qualification agent

1. In the Sales Hub app, go to **Leads**.
2. Select a lead from the focused view or read-only grid view.

    A banner at the top of the lead form displays the option to view insights if the lead meets the [selection criteria for research](#selectioncriteria). **Question: If they selected a lead from the focused view, do they directly land on the insights page?**

    :::image type="content" source="media/sqa-banner.png" alt-text="Screenshot of the My Open Leads page with the banner highlighted.":::

3. Select **View insights** to get a 360-degree view of a lead and the timestamp of when the research was last updated. 
   The Lead insights page includes the following aspects:

    - **Key insights**: This section summarizes why the lead is or isn't a good fit for your business based on the ideal customer profile (ICP) configured by your admin.
        - For a lead that exactly matches your ideal customer profile, this section displays the message **Engage now** and recommends drafting an outreach email.
        - For a lead that closely matches your ideal customer profile, this section displays the message **Engage only after you've exhausted your best leads** and lets you draft an outreach email.
        - For a lead that doesn't match your ideal customer profile, this section displays the message **Do not engage** and displays the **Draft email** option if you want to draft an outreach email anyway.

    - **Email validation**: The agent performs two checks on a lead's primary email address (lead.emailaddress1).
        - **Email validity**: Checks whether the email is properly formatted and deliverable by looking for the [email validation errors](work-invalid-email-addresses.md). If the email is invalid, then it's flagged in the UI as such, and the seller is prompted to enter a valid email. After the seller enters the new email ID, the lead's email address is updated.
        - **Email type**: Identifies whether the email is a work or personal address and labels it as such in the UI.

        These checks help ensure that lead's email ID is active, deliverable, and relevant for business communications. You can select the Email icon next to the email ID to mark the email as valid/invalid or work/personal
    
    - **About lead**: This section includes information about the lead, including:
        - **Connect contact record:** Lets you connect the lead to the corresponding contact record.
        - **Lead summary**: Summarizes key fields on the lead and related tables as configured by your admin.
        - **Who knows whom**: Coworkers who previously interacted with the lead over emails or meetings.
        - **Open opportunities related to the lead**
    
        You can also see contact suggestion for the lead based on the lead's email ID. Otherwise, you can manually connect a contact record to the lead using **Connect a contact record** to enrich the insights.
    
    - **About account**: This section includes information about the lead's company, including:
        - **Connect account record:** Lets you connect the lead to the corresponding account record.
        - Account summary: Summarizes key details about the connected account. The summary is displayed only if an account record is connected to the lead.
        - **Business overview**: Insights pulled from the web on the company's industry, size, products and services, and mission statement.
        - **Finances**: Insights pulled from the web on the company's financial health and key financial metrics.
        - **Account news**: Insights pulled from the web on relevant news articles such as product launches, leadership changes, contracts/clients won, community involvement, awards, and recognition.
        - The following insights are displayed only if an account record is connected to the lead. To connect an account manually, select **Connect an account** in the **About account** section:
            - Suggested contacts: Other contacts at the account that the seller can reach out to.
            - Open opportunities related to the account.
4. Select **Draft email** to engage with the customer. 
   An introduction email opens up with the AI-generated draft. **Question: What's info is included in the introduction email?**
5. Review the email draft, make any necessary edits, and select **Send**.
   If server-side sync is enabled, the email is directly sent from Dynamics 365. If not, Outlook opens with the email draft, and you can send it from there.

    