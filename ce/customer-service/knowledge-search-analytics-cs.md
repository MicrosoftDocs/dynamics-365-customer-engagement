---
title: Knowledge article and search term analytics dashboards | Microsoft Docs
description: Learn about the knowledge article and search term analytics dashboards to better understand agent performance in your organization.
ms.date: 03/20/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Introduction to knowledge analytics

Knowledge analytics can help provide knowledge workers and supervisors with valuable insights about how knowledge articles are being used and searched, which can help them make improvements to their overall knowledge management system.

Knowledge analytics includes the following features:

- [Article insights](#article-insights)
- [Search term analytics](#search-term-analytics)

## Article insights

The article insights dashboard can help your organization's knowledge workers to understand the impact that knowledge management is making on the overall support experience. This includes the articles that are created, shared, and used.

![Knowledge article insights analytics dashboard.](media/knowledge-article-insights-dashboard.png "View of the knowledge article insights analytics dashboard")

### Article insights analytics dashboard metrics

The following are specific metrics represented in this dashboard:

| Metrics or chart | Definition |
|----------------------|-------------------------|
| Views | The total number of views on the knowledge articles. |
| Visitors | The total number of unique visitors viewing the knowledge articles. |
| Feedback rating | The average feedback rating provided by the consumers of the knowledge articles. |
| Most viewed articles | The top 20 articles used, along with visitors, avg feedback rating, linked cases and shares metrics. |
| Linked cases | The total number of cases that were linked to the articles. |
| Shares | The total number of the article that were shared by the support representative. |
| Owner (Filter) | The owner of the knowledge article. |

## Search term analytics

The knowledge search term analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles.

> [!NOTE]
> Knowledge search term analytics won't provide information about customer search behavior. Data is only from internal knowledge searches. 

![Knowledge search term analytics dashboard.](media/knowledge-search-analytics-dashboard.png "View of the knowledge search term analytics dashboard")

As a knowledge manager, it's your responsibility to maintain and improve your organization's overall knowledge base article offerings. By identifying searches that have low success or return no results, the Knowledge search term analytics dashboard can help you identify knowledge gaps, improve search results, and surface the most relevant articles.  

To access this dashboard, your organization's administrator must first enable it. For more information, see [Configure Knowledge search insights](enable-knowledge-search-insights.md).

### Knowledge search term analytics dashboard metrics

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

[Configure knowledge search insights](enable-knowledge-search-insights.md)
[Search for knowledge articles](search-knowledge-articles-csh.md) <br>
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md) <br>
[Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
