---
title: Knowledge search analytics dashboard | Microsoft Docs
description: Learn about the knowledge search analytics reports to better understand agent performance in your organization.
author: lalexms
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: laalexan
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Knowledge search analytics dashboard

The knowledge search analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles.

> [!NOTE]
> Knowledge search analytics won't provide information about customer search behavior. Data is only from internal knowledge searches. 

![Knowledge search analytics dashboard](media/knowledge-search-analytics-dashboard.png "Knowledge search analytics dashboard")

As a knowledge manager, it's your responsibility to maintain and improve your organization's overall knowledge base article offerings. By identifying searches that have low success or return no results, the Knowledge search analytics dashboard can help you identify knowledge gaps, improve search results, and surface the most relevant articles.  

To access this dashboard, your organization's administrator must first enable it. For more information, see [Configure Knowledge search insights](enable-knowledge-search-analytics.md).

## Knowledge search analytics dashboard metrics

The following are specific metrics represented in this dashboard: 

| KPIs or chart | Definition |
|----------------------|-------------------------|
| Search count | The total number of searches completed within a given period. |
| Search count over duration | The number of searches of completed within a certain amount of time. |
| Avg. search rate trend | The day-by-day trend of the average list position of the link selected by a user when presented with search results. |
| Avg. search rank | The average position of the link selected by a user when presented within search results. |
| Engagement rate | The percentage of events where a user interacted with the search results compared to the search events presented with results. |
| Engagement rate trend | The day-by-day trend of the percentage of events where a user interacted with the search results compared to the search events presented with results. |
| Rate of no-result searches | Percentage of instances where there are no results for the that was term searched for. |
| Rate of no-result searches trend | The day-by-day trend of the percentage of instances where there were no results for the search term used by the agent. |
| Top 20 search terms | The top 20 terms being searched, showing the number of times searched, the average search rate, and engagement rate. |
| Top 20 search terms with no results | The top 20 search terms that returned no results when searched. |
| Top 20 search terms with high avg. search rank | The top 20 search topics by volume with an average click position of greater than five. |
| Top 20 search terms with low engagement rate | The top 20 search topics by volume with engagement rate of less than 40 percent. |
| Search volume by application | The percentage of searches across multiple applications. |
| Search volume by search type | The percentage of searches based on whether they were manual or automatic searches. |


### See also

[Search for knowledge articles](search-knowledge-articles-csh.md) <br>
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md) <br>
[Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]