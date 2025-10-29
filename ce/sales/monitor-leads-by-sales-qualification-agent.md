---
title: Monitor leads handled by the Sales Qualification Agent (preview)
description: Monitor Sales Qualification Agent performance in Dynamics 365 Sales with supervisor dashboard insights. Track lead processing rates, revenue generation, and engagement effectiveness.
ms.date: 08/04/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
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

# Monitor leads handled by the Sales Qualification Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As a supervisor or administrator, you can monitor the performance of the Sales Qualification Agent and the leads it handles to verify its effectiveness. The supervisor workspace includes a dashboard that provides insights into the agent's performance, including the percentage of leads handled by the agent, revenue generated from these leads, and customer engagement effectiveness. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## View the supervisor dashboard

1. In the Sales Hub app, go to **App settings**.
1. Under General settings, select **Dynamics 365 AI hub**. If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. Learn more in [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md)
1. In the **AI Optimization** card, select **See insights**.  
   The supervisor workspace opens, displaying various cards that provide insights into the Sales Qualification Agent's performance.  
1. Verify the **Last refreshed** date and time to ensure the data is up-to-date. The data is refreshed when you open the dashboard. If needed, you can refresh the dashboard by selecting the **Refresh** icon.
1. Select the **Time period** filter to specify the period for which you want to view the data. By default, the dashboard shows data for the last 7 days.
1. To view the list of leads handled by the agent, select any of the following buttons:

> [!NOTE]
> If you don't see the views mentioned in this section, contact your admin to [add agent-specific views to your app](start-sales-qualification-agent.md#add-agent-specific-views-to-your-app).

   - **See disqualified leads**: Opens the **Leads disqualified by AI agent** view that lists leads that were disqualified by the agent during the selected time period. Open a lead to view the details of the disqualification in the **Lead insights** page. If you don't agree with the disqualification, select **Reassign** to assign the lead to a seller for follow-up and qualification.

   - **See leads in process**: Opens the **Leads being processed by AI agent** view that lists all leads that the agent is currently processing. This includes leads that are being researched and leads that are being engaged with (research and engage mode only). In the research and engage mode, leads might stay in the "In process" state for a longer time if the agent is waiting for a response from the lead.

   - **See handed over leads**: Opens the **Leads handed over by AI agent** view that lists all leads that were handed over to sellers for followup and qualification during the selected time period.
   
   > [!NOTE]
   > Though the above views are meant for supervisors, they are also available to sellers unless your admin has set the `EnableRoleBasedSystemViews` setting to **true**. However, sellers can only view leads that they have access to, based on their security roles and permissions. Learn more about changing the setting in [Environment database settings](/power-platform/admin/environment-database-settings).

1. Depending on the agent mode, you may see different metrics and insights in the dashboard:
   - [View metrics related to research-only mode](#view-metrics-related-to-research-only-mode)
   - [View metrics related to research and engage mode](#view-metrics-related-to-engage-mode)

## View metrics related to research-only mode

If your admin has configured the Sales Qualification Agent to run in research-only mode, you can view the agent's effectiveness in researching leads, generating outreach emails, disqualifying low fit leads, and handing over promising leads to sellers. In this mode, the agent doesn't send outreach emails to leads or engage with leads.

:::image type="content" source="media/supervisor-dashboard-research-mode.png" alt-text="Screenshot of the supervisor dashboard for research-only mode":::

- **Top metrics**: The following table shows the key performance metrics:

    | Metric | Description | Formula |
    |--------|-------------|---------|
    | Autonomous processing rate | The percentage of leads the agent could confidently process on its own, either by handing over promising leads to sellers or disqualifying them due to low fit, compared to the total number of leads processed by the agent. | (Leads handed over to sellers + Leads disqualified due to low fit) ÷ Total leads processed by agent × 100 |
    | AI Agent handover rate | The percentage of leads that were handed over to the sellers, compared to the total number of leads processed by the agent. | Leads handed over to sellers ÷ Total leads processed by agent × 100 |

- **Business metrics**: Displays the following metrics:

- **Lead processing funnel**: This funnel chart includes the number of leads at each stage of the lead processing funnel, including the total number of leads assigned to the agent, leads in progress, disqualified, failed, and handed over to the sellers. Hover over the funnel chart to view the flow and the number of leads at each stage. This chart includes the following categories:

    | Category                | Description |
    |-------------------------|-------------|
    | **Leads assigned**      | Leads assigned to the agent for processing. |
    | **In progress**         | Leads currently being processed for research and outreach email generation. |
    | **Leads disqualified**  | Leads disqualified by the agent due to low fit. Disqualified leads that are reassigned by a supervisor are included in **Handed over to sellers**. |
    | **Failed**              | Leads that failed to engage with the agent or were not successfully processed. |
    | **Handed over to sellers** | Leads handed over to sellers by the agent, including disqualified leads reassigned by the supervisor. |

## View metrics related to engage mode

If your admin has configured the Sales Qualification Agent to run in research and engage mode, you can view the agent's effectiveness in researching leads, engaging with leads, disqualifying low fit leads, and handing over promising leads to sellers. In this mode, the agent autonomously sends outreach emails to leads and engages with them based on their responses.

:::image type="content" source="media/supervisor-dashboard-engage-mode.png" alt-text="Screenshot of the supervisor dashboard for engage mode":::

- **Top metrics**: The following table shows the key performance metrics:

    | Metric | Description | Formula |
    |--------|-------------|---------|
    | Autonomous processing rate | The percentage of leads the agent could confidently process on its own, either by handing them over with positive intent or disqualifying them due to low interest, compared to the total number of leads processed by the agent. | (Leads handed over with positive intent + Leads disqualified due to low interest) ÷ Total leads processed by agent × 100 |
    | AI Agent lead qualification rate | The percentage of leads that were converted into customers by the agent, compared to the total number of leads processed by the agent. | Leads converted to customers ÷ Total leads processed by agent × 100 |
    | AI generated pipeline | The total revenue from opportunities generated from leads that were handed over by the agent. | Sum of estimated revenue from all opportunities created from leads handed over by agent |

- **Agent effectiveness**: The following table shows the agent effectiveness metrics:

    | Metric | Description | Formula |
    |--------|-------------|---------|
    | Lead research completion rate | The percentage of leads for which the agent completed the research, compared to the total number of leads assigned to the agent. | Leads with completed research ÷ Total leads assigned to agent × 100 |
    | AI agent lead handover rate | The percentage of leads that were handed over to the seller with positive buying intent, compared to the total number of leads processed by the agent. | Leads handed over with positive buying intent ÷ Total leads processed by agent × 100 |
    | Email response rate | The percentage of leads that responded to the outreach email sent by the agent, compared to the total number of outreach emails sent by the agent. | Leads that responded to outreach emails ÷ Total outreach emails sent by agent × 100 |
    | Customer queries responded | The number of customer queries that the agent responded to during the selected time period. | Count of customer queries responded by agent |

- **Business metrics**: 

    - **Lead processing funnel:** This funnel chart includes the number of leads at each stage of the lead processing funnel. The following table describes the categories in the funnel chart:

    | Category                | Description |
    |-------------------------|-------------|
    | **Leads assigned**      | Leads assigned to the agent for processing. |
    | **In progress**         | Leads currently being processed for research and outreach email generation. |
    | **Blocked** | Leads that the agent couldn't autonomously process due to an open question that the agent couldn't answer. These leads are assigned to the seller who owned the lead. |
    | **Disqualified**  | Leads disqualified by the agent due to low fit. Disqualified leads that are reassigned by a supervisor are included in **Handed over to sellers**. |
    | **Failed**              | Leads that failed to engage with the agent or were not successfully processed. |
    | **Handed over to sellers** | Leads handed over to sellers by the agent, including disqualified leads reassigned by the supervisor. |
    | **Opportunities created** | Leads that were handed over by the agent and converted into opportunities. |


    - **Customer engagement funnel**: This funnel chart includes the number of leads at each stage of the customer engagement funnel, including the total number of outreach emails sent, customer responses received, and no response received. The customer responses are further divided into the following categories: 
 
    | Category                | Description |
    |-------------------------|-------------|
    | **In progress** | Includes leads that the agent is currently engaging with. |
    | Autonomous engagements | Includes leads that the agent has completed the engagement with, either by disqualifying them or handing them over to the seller with a positive buying intent. |
    | **Transferred to sellers** | Includes leads that are handed over to the seller for follow-up and clarification. This number doesn't include leads that were handed over with positive intent. |
    | **Handover failed** | Includes leads that the agent couldn't hand over to the seller due to technical issues or other reasons. These leads are assigned to the seller who owned the lead. |

    - **Lead classification**: Displays the leads handled by the agent, categorized by their rating such as, **Hot**, **Warm**, and **Cold**.
    
    - **Positive buying interest**: The percentage of leads that were handed over to the seller with positive buying interest, compared to the total number of leads processed by the agent. You can also see the number of leads with positive, negative, and undetected intent. This metric is calculated as Leads handed over with positive buying interest ÷ Total leads processed by agent × 100.