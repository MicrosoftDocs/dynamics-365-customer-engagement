---
title: Summary Dashboard | Microsoft Docs
description: Learn about the Summary dashboard insights overview to better understand your organization's customer service experience.
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/22/2020
ms.topic: article
ms.service: 
  dynamics-365-customerservice
ms.custom: 
  dyn365-customerservice
search.audienceType: 
  admin
  customizer
  enduser
search.app: 
  D365CE
  D365CS
  
---

# Preview: Summary dashboard

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).


The Summary dashboard gives you a broad overview of the customer service experience in your organization. It uses artificial intelligence (AI) technology to show you topics that are generating the highest volume and emerging topics with the highest rate of change in volume.

![Summary dashboard](media/summary-dashboard-analytics-cs.png "View the Summary dashboard")

The KPI summary dashboard includes a variety of charts with graphical views of your system's key performance indicators. 

The Case volume drivers and Emerging case volume by topic charts use natural language understanding to group support cases as *topics* that are a collection of related cases. These charts show you the customer support topics that are generating the most volume and emerging topics with the highest rate of change in volume, helping you identify areas for improvement that can have the greatest impact on system performance.

By default, the dashboard shows you KPIs for the past month and for all products, channels, business units, and teams in your system. To change the time period, select a value from the **Time period** drop-down list at the top of the dashboard. You can select either past day, past week, or past month.

To filter data by product, channel, business unit, or team, select a value from the **Product**, **Channel**, **Business Unit**, or **Team** drop-down list. If you switch to a different dashboard, the filter you specify persists and is applied to the data on all dashboards. For more information on working with filters, see [Work with Customer Service Insights dashboards](use-dashboard-sample-data.md).


## Key insights card

![Key insights discovery card](media/key-insights-card.png)

The Key Insights Discovery card has two areas:

- **KPI insights**: Important subjects that impact performance.

- **Topics to watch**: Topics that rank high across the three key areas to make it easier for customer service managers to discover top issues.
  

## KPI summary details

The KPI summary charts summarize the key performance indicators for the specified time period and the percent change over the period. You can filters these areas by duration, channel, queue, and agent.

Insights for the following areas are displayed:

- Incoming cases
- Active cases
- Escalated cases
- Average resolve time
- Average CSAT
- Average survey sentiment

KPIs are displayed as follows:

- Case volume by status
- Open cases by priority
- Incoming cases by channel
- Open cases by age
- Case volume trend
- Average CSAT trend
- Average survey sentiment trend
- Top 10 volume topics
- Emerging case volume by topic
- Case metrics by channel
- Case metrics


A blue up-and-down indicator next to the value indicates the percent change in a positive direction. A red indicator indicates the percent change in a negative direction.

