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

### Work on prioritized list of leads

The agent prioritizes leads based on the hand-raiser criteria and ideal customer profile that your admin has defined, and other inherent prioritization logic. [Learn more about prioritization](#lead-prioritization).

1. In the Sales Hub app, go to Sales > **Leads**.
2. If you're in **Focused** view, switch to the **Read Only Grid** view.

    :::image type="content" source="media/sqa-leads-grid.png" alt-text="Screenshot of the My Open Leads page with Read only grid option highlighted.":::

    You'll see a carousal at the top of the **My Open Leads** view. This carousal displays leads that have been researched and prioritized by the Sales qualification agent.

    :::image type="content" source="media/sqa-lead-carousal.png" alt-text="Screenshot of the carousal with the prioritized leads.":::

    The cards on the carousal display the lead's name, their need, the next best action, and the reason for the suggested action, and a call-to-action button.

3. Hover over the up arrow :::image type="icon" source="media/up-arrow.png" border="false"::: next to the lead's name to view the reasoning behind the ranking of the lead.
4. Select a lead from the carousal to view detailed research insights about the lead:

    - [Know why the lead was chosen by the agent](#lead-prioritization).
    - [Understand the lead, their company, and their need better](#research-insights).
    - See who can introduce you to the lead.
    - When you're ready to engage with the lead, select the call-to-action button, such as Draft email, to take the [suggested action](#suggested-actions).

    :::image type="content" source="media/sqa-lead-insights.png" alt-text="Screenshot of the Lead insights page.":::

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

- **Suggested action**: The actions are suggested based on research insights and ideal customer profile criteria defined by your admin in the settings. Learn more about [suggested actions](#suggested-actions).
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

### Lead prioritization

The agent helps sellers focus on the most promising leads by organizing them based on their level of interest and alignment with your ideal customer profile (ICP) criteria. Here's how the prioritization works:

1. **Hand-raisers come first**

    Hand-raisers are leads that have explicitly expressed interest, such as by requesting a demo or contacting sales. These leads are your top priority, and the system will always recommend engaging with them first.

2. **Prioritization for all other leads**

    Leads that are not hand-raisers are ranked based on the following factors, listed in order of importance:

    1. **Lead's overall fit with your ideal customer profile -** Determines the fit of the lead with the ideal customer profile based on the criteria [defined by your admin](configure-sales-qualification-agent.md#how-to-set-up-and-activate-the-agent).
    2. **Overall Engagement -** Measures the lead's level of interaction, including:
        - Responses to sales emails.
        - Being marked as Sales Ready or Marketing Qualified by the Qualification models in Customer Insights - Journeys.

        High engagement indicates stronger interest and higher priority.

    3. **Association with Existing Accounts -** Evaluates if the lead is linked to an existing account, the number of other leads under the account, and the average estimated revenue from associated opportunities.

        Leads connected to current accounts with potential upsell or cross-sell opportunities are given higher priority.

    4. **Recency of lead creation** - Considers how recently the lead was created. Newer leads are prioritized higher to capitalize on fresh opportunities.

### Suggested actions

This section on the **Lead insights** page displays the next best action for the lead based on the research data, your company and product information, and emails from the lead.

The following scenarios and actions are supported:

**Initial outreach**

If there's no conversation history with the lead, the agent suggests drafting an initial email to engage with the lead.

- **Draft email:** Let Copilot craft a compelling introductory email to engage with the lead. The agent generates a highly personalized email to the lead, based on the lead research data, your company and product information (defined by your admin during setup), and lead and account information from Dataverse.

    This action is displayed only when the following conditions are met:

    - No prior emails, no upcoming meetings, no past appointments, and no previously unanswered calls.
    - The following fields in the lead record have valid values:
        - Company name which can be associated with an account.
        - Email address which is active and deliverable.
        - Lead's first and last name.

**Follow-up actions:**

After the conversation has been initiated with the lead, the agent reminds you to stay engaged with the lead by suggesting follow-up actions. These actions are based on the lead's email.

- **Schedule appointment:** If the lead has shown interest in meeting with you, the agent suggests scheduling an appointment with the lead.
- **Send follow-up email**: If the lead has asked for more information, the agent suggests sending an email with the required details. The agent generates a draft email with the necessary information based on the lead's request. When it doesn't know the specific information, it adds placeholders in the email draft for you to fill in.
- **Create task:** If the lead has asked something that requires action, the agent suggests creating a task to follow up. For example, if a lead has requested additional products, the agent suggests that you create a task to update your sales records.

> [!NOTE]
> When you select **Send email** for email-based actions, the email is sent directly if server-side synchronization is configured for your organization. If not, the email opens in Outlook for you to review and send.