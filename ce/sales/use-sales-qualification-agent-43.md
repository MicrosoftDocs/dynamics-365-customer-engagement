---
title: Work on leads researched by Sales Qualification Agent (pre-7.3 version)
description: Learn how to use the Sales Qualification Agent in Dynamics 365 Sales to qualify leads more effectively and improve sales outcomes.
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

# Work on leads researched by Sales Qualification Agent (pre-7.3 version)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

> [!NOTE]
> This article is for the version of Sales Qualification Agent that was part of the April 2025 public preview. The latest version of the agent is available in 9.0.25073.10001 (7.3) release. To know the version in your organization, check the **Server version** in **Settings** > **About** in the Sales Hub app. To check your deployment schedule, go to [Latest version availability](/dynamics365/released-versions/dynamics365sales#latest-version-availability) and look for the 9.0.25073.10001 version. If your org has the latest version, your existing  agent will be in the Draft mode and you must [reconfigure it](upgrade-sales-qualification-agent.md) to use the agent.

The Sales Qualification Agent in Dynamics 365 Sales researches your leads, offers detailed insights about them, and determines if they're a good fit for your business based on your ideal customer profile. It also drafts an initial outreach email based on its research insights, saving you time and effort and improving your sales outcomes. This article describes how to use the Sales Qualification Agent to qualify your leads more effectively.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you can use the Sales Qualification Agent, your admin must [set it up](./configure-sales-qualification-agent-43.md) for you and your sales team.

<a name="selection-criteria-for-research"></a>
## Selection criteria for initial research

After the Sales Qualification Agent is set up, it automatically researches leads that are:

- open
- created in the last 14 days
- owned by sellers who have a security role that allows them to access the agent.

The agent processes the leads only once, unless significant changes are made to the lead. Learn more about trigger events in [When does the agent run?](sales-qualification-agent-faq-43.md#trigger-events).

## Qualify leads

1. In the Sales Hub app, go to **Leads**.

1. Select a lead from the focused view or read-only grid view.

    After a few seconds, if the lead meets the agent's [selection criteria](#selection-criteria-for-research), a banner appears at the top of the lead form. The banner includes the agent's recommendation and two action buttons: **Review email** and **More insights**.

    :::image type="content" source="media/sqa-banner-43.png" alt-text="Screenshot of a lead form showing the Sales Qualification Agent's recommendation, with the agent banner highlighted.":::

1. Select an action button:

   - **Review email** opens a draft outreach email that the agent generated for you based on its insights. It's ready for you to send, but you should review it and make any needed changes before you send it. [Why don't I see the **Review email** or **Draft email** option?](sales-qualification-agent-faq-43.md#cant-see-email-options) in the Sales Qualification Agent FAQ.

   - **More insights** opens the [**Lead insights** page](#lead-insights-page), which offers a 360-degree view of the lead and includes the date the agent last updated its research data.  
     :::image type="content" source="media/lead-insights-page-annotated-43.png" alt-text="Screenshot of the Lead insights page showing the Sales Qualification Agent's insights about a lead with annotations.":::
    The next section describes each annotated segment in the screenshot.

### Lead insights page

The **Lead insights** page includes the following information.


| Number on the screenshot | Section                        | Description |
|--------|--------------------------------|---------------|
| 1 | Header: Connected accounts and contacts | Select the link icon next to the lead's name to view the accounts and contacts that are connected to the lead. If the lead isn't connected to any account or contact, the agent automatically connects to the most relevant account and contact records based on the lead's email address, domain, and company name. If the connected records aren't accurate, select **Disconnect** to remove the connection and then connect the lead to a different account or contact. <br> Note: Once you manually connect a record, the agent uses that connection for future research. |
| 2 | Header: Email validation | The agent performs checks on a lead's primary email address to ensure it is active, deliverable, and relevant for business communications. Checks include: **Email validity** (properly formatted and deliverable; prompts for correction if invalid) and **Email type** (work or personal, labeled in the interface). You can mark the address as valid/invalid and work/personal by selecting the email icon. |
| 3 | Key insights | Summarizes key insights about the lead, including why it is or isn't a good fit for your business based on the ideal customer profile. To review the outreach email the agent generated, select **Draft email**. Review and edit as needed before sending. If your company uses Dynamics 365 Customer Insights - Journeys, key insights also include recent marketing activities such as email opens, link clicks, event registrations and attendance, and form submissions. |
| 4 | Who can make an introduction | Lists people who can introduce you to the lead, including mutual connections and colleagues who interacted with the lead in emails or meetings. |
| 5 | Business overview | Provides insights on the company's industry, size, products and services, and mission statement. |
| 6 | Finances | Offers insights on the company's financial health and key financial metrics. |
| 7 | Account news | Shares insights from relevant news articles, such as product launches, leadership changes, contracts or clients won, community involvement, awards, and recognition.  

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

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq-43.md)
- [Set up the Sales Qualification Agent](configure-sales-qualification-agent-43.md)
