---
title: Qualify leads smartly with Sales Qualification Agent
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

As a seller, qualifying leads is crucial to your success. Use the sales qualification agent to get a prioritized list of leads, detailed research insights about each of them, and personalized outreach emails to engage with potential customers effectively.

## Prerequisite

Before you start using the Sales qualification agent, ensure your admin has enabled and configured the Sales qualification agent.

## Provide consent to agent

As a seller, you need to let the agent access data from Dataverse and emails from Exchange. This consent only applies to the Sales qualification agent and not to other Copilot features. The consent message is displayed when you first access the **My Open Leads** view after the agent activation.

> [!NOTE]
> - Consent is mandatory for viewing the prioritized list in the carousal and the suggested actions for each lead.
> - Consent can't be revoked once it's provided.

**Follow these steps:**

1. In the Sales Hub app, go to **Sales** > **Leads**.
2. If you're in **Focused** view, switch to the **Read Only Grid** view.

    :::image type="content" source="media/sqa-leads-grid.png" alt-text="Screenshot of the My Open Leads page with Read only grid option highlighted.":::

    A Connect message appears at the top of the page.

    :::image type="content" source="media/sqa-user-consent.png" alt-text="Screenshot of the consent dialog for sellers.":::

3. Select **Get Started** to provide consent to:
    1. Let the agent to access emails in Exchange.
    2. Let the agent to run on your Dataverse data.

    :::image type="content" source="media/sqa-user-consent-apps.png" alt-text="Screenshot of the consent dialog with the apps listed.":::

4. Select **Submit** to provide consent.

## Qualify leads with the Sales qualification agent

You can either work on a [prioritized list of leads](#work-on-prioritized-list-of-leads) or [individual leads](#work-on-individual-leads) that you want to focus on.

The agent selects leads that meet the following criteria for research and prioritization:

- Leads that are "open"
- Leads that are created in the last 14 days
- Leads owned by sellers of the security role that's allowed to access the agent

The agent runs the research and prioritization job every 4 hours.

### Work on individual leads

If you're in the focused view or if you want to work on a specific lead, you can view detailed research insights and suggested actions for that lead without going through the carousel. Research insights are only available for leads that meet the [selection criteria for research](#selectioncriteria).

1. In the Sales Hub app, go to **Leads**.
2. Select a lead from the focused view or read-only grid view.

    A banner at the top of the lead form displays the suggested action and the reason for the action.

    :::image type="content" source="media/sqa-banner.png" alt-text="Screenshot of the My Open Leads page with the banner highlighted.":::

3. Do one of the following:
    - Select the call-to-action button, such as **Draft email** to draft an email to the lead. This button is displayed only if you've [provided consent](#provide-consent-to-agent).
    - Select **More insights** to view **Lead insights** page:
        - [Know why the lead was chosen by the agent.](#lead-prioritization)
        - [Understand the lead, their company, and their need better.](#research-insights) See who can introduce you to the lead.
        - When you're ready to engage with the lead, select the call-to-action button to take the [suggested action](#suggested-actions).

### Research insights

On the **Lead insights** page, you can get a 360-degree view of a lead, including:

- **Suggested action**: The actions are suggested based on research insights and ideal customer profile criteria defined by your admin in the settings.
- **Email validation**: The agent performs two checks on a lead's primary email address (lead.emailaddress1).
    - **Email validity**: Checks whether the email is properly formatted and deliverable by looking for the [email validation errors](work-invalid-email-addresses.md). If the email is invalid, then it will be flagged in the UI as such, and the seller is prompted to enter a valid email. After the seller enters the new email ID, the lead's email address is updated.
    - **Email type**: Identifies whether the email is a work or personal address and labels it as such in the UI.

    These checks help ensure that lead emails are active, deliverable, and relevant for business communications.

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