---
title: Qualify leads with the Sales Qualification Agent
description: Learn how to use the Sales Qualification Agent in Dynamics 365 Sales to qualify leads more effectively and improve sales outcomes.
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

# Qualify leads with the Sales Qualification Agent

The Sales Qualification Agent in Dynamics 365 Sales researches your leads, offers detailed insights about them, and determines if they're a good fit for your business based on an ideal customer profile. It also drafts an initial outreach email based on its research insights, saving you time and effort and improving your sales outcomes. This article describes how to use the Sales Qualification Agent to qualify your leads more effectively.

## Prerequisites

Before you can use the Sales Qualification Agent, your admin must [set it up](./configure-sales-qualification-agent.md) for you and your sales team.

## Selection criteria for research

To determine which leads to research and match against the ideal customer profile, the Sales Qualification Agent looks for leads that are:

- open
- created in the last 14 days
- owned by sellers who have a security role that allows them to access the agent.

The agent refreshes research data either daily, every three days, or weekly. Your admin determines the refresh frequency based on your company's business needs.

## Qualify leads

1. In the Sales Hub app, go to **Leads**.

1. Select a lead from the focused view or read-only grid view.

    After a few seconds, if the leads meet the agent's [selection criteria](#selection-criteria-for-research), a banner appears at the top of the lead form. The banner includes the agent's recommendation and two action buttons: **Review email** and **More insights**.

    :::image type="content" source="media/sqa-banner.png" alt-text="Screenshot of a lead form showing the Sales Qualification Agent's recommendation, with the agent banner highlighted.":::

1. Select an action button:

   - **Review email** opens a draft outreach email that the agent generated for you based on its insights. It's ready for you to send, but you should review it and make any needed changes before you send it.

      If your organization uses server-side sync, the email is sent directly from Dynamics 365. If it doesn't, the draft email opens in Outlook and you can edit and send it there. Learn more in [Why don't I see the **Review email** or **Draft email** option?](sales-qualification-agent-faq.md#cant-see-email-options) in the Sales Qualification Agent FAQ.

   - **More insights** opens the [**Lead insights** page](#lead-insights-page), which offers a 360-degree view of the lead and includes the date the agent last updated its research data.

### Lead insights page

The **Lead insights** page includes the following information.

- **Key insights**: This section summarizes key insights about the lead, including why it is or isn't a good fit for your business based on the ideal customer profile.

  To review the outreach email that the agent generated for you, select **Draft email**. It's ready for you to send, but you should review it and make any needed changes before you send it. Learn more in [Why don't I see the **Review email** or **Draft email** option?](sales-qualification-agent-faq.md#cant-see-email-options) in the Sales Qualification Agent FAQ.

  If your company uses Dynamics 365 Customer Insights - Journeys, key insights also include recent marketing activities, such as email opens, link clicks, event registrations and attendance, and form submissions.

- **Email validation**: The agent performs two checks on a lead's primary email address: whether it's a valid address and whether it's a work or personal address. These checks help make sure that the lead's email address is active, deliverable, and relevant for business communications.

  - **Email validity**: The agent looks for [email validation errors](work-invalid-email-addresses.md) to make sure that the address is properly formatted and deliverable. If the email address is invalid, the agent prompts you to enter a valid address.
  - **Email type**: The agent determines whether the address is a work or personal email address and labels it in the interface.

  To mark the address as valid or invalid and work or personal, you can select the email icon next to the address.

- **About lead**: This section includes a summary of key fields, opportunities that are open with the lead, and your colleagues who interacted with the lead in emails or meetings.

  You can also view contact suggestions for the lead based on the lead's email address. To manually connect a contact record to the lead to enrich the agent's insights, select **Connect a contact record**.

- **About account**: This section includes a summary of key details about the account based on insights that the agent pulls from the web.

  - **Business overview**: Insights on the company's industry, size, products and services, and mission statement.

  - **Finances**: Insights on the company's financial health and key financial metrics.

  - **Account news**: Insights from relevant news articles, such as product launches, leadership changes, contracts or clients won, community involvement, awards, and recognition.

   If an account record is connected to the lead, you can also view other contacts at the account that you can reach out to, and opportunities that are open with the account. To manually connect an account record to the lead, select **Connect an account**.

These insights about your leads seamlessly bridge the gap between marketing engagement data and sales, saving you&mdash;and your company&mdash;significant time and costs. You can focus on the most valuable opportunities faster and drive more personalized outreach and engagement.

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
