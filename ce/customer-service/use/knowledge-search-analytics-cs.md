---
title: Knowledge article and search term analytics dashboards
description: Learn about the knowledge article and search term analytics dashboards to better understand customer service representative performance in your organization.
ms.date: 02/03/2025
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Introduction to knowledge analytics
[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


Knowledge analytics helps provide knowledge workers and supervisors with valuable insights about how knowledge articles are being used and searched. Supervisors can use these insights to improve their knowledge management system.

Knowledge analytics includes the following features:

- [Article insights](#article-insights)
- [Search term insights](#search-term-insights)

## Article insights

The Article insights dashboard can help your organization's knowledge workers to understand the impact that knowledge management is making on the overall support experience. The insights include details about articles that are shared.

![Knowledge article insights analytics dashboard.](../media/knowledge-article-insights-dashboard.png "View of the knowledge article insights dashboard")

### Metrics in Article insights dashboard

The Articles insights dashboard represents the following metrics.

| Metrics or chart | Definition |
|----------------------|-------------------------|
|Duration | The duration for which you want to see the report.|
|Owner | The owner of the knowledge article. |
|Timezone| The time information according to the time zone that you specify.
| Views | The total number of views on the knowledge articles. |
| Visitors | The total number of unique visitors who viewed the knowledge articles. |
| Avg. feedback rating trend | The average feedback rating provided by the consumers of the knowledge articles. |
| Most viewed articles | The top 20 articles used, along with visitors, average feedback rating, linked cases and shares metrics. |
| Linked cases | The total number of cases that were linked to the articles. |
| Shares | The total number of the article that were shared by the support representative. |

## Search term insights

The Search term insights dashboard is designed to provide supervisors and knowledge workers with valuable insights into how customer service representatives find and use knowledge articles.

Your administrator must enable the dashboard for you to access it. More information: [Configure Knowledge search insights](../administer/enable-knowledge-search-insights.md).

> [!NOTE]
> Knowledge search term insights won't provide information about customer search behavior. Data is from internal knowledge searches only. 

![Knowledge Search term insights dashboard.](../media/knowledge-search-analytics-dashboard.png "View of the knowledge Search term insights dashboard")

As a knowledge manager, it's your responsibility to maintain and improve your organization's overall knowledge base article offerings. By identifying searches that have low success or return no results, the knowledge Search term insights dashboard can help you identify knowledge gaps, improve search results, and surface the most relevant articles.  

### Metrics in knowledge Search term insights dashboard

The knowledge Search term insights dashboard represents the following metrics.

| KPIs or chart | Definition |
|----------------------|-------------------------|
| Search count | The total number of searches completed within a given period. |
| Search count over duration | The number of searches completed within a certain amount of time. |
| Avg. search rank | The average position of the link selected by a user when presented within search results. |
| Avg. search rate trend | The day-by-day trend of the average list position of the link selected by a user when presented with search results. |
| Engagement rate | The percentage of events where a user interacted with the search results compared to the search events presented with results. |
| Engagement rate trend | The day-by-day trend of the percentage of events where a user interacted with the search results compared to the search events presented with results. |
| Rate of no-result searches | Percentage of instances where the searched term displayed no results. |
| Rate of no-result searches trend | The day-by-day trend of the percentage of search instances that displayed "no results". |
| Top 20 search terms | The top 20 terms being searched, showing the number of times searched, the average search rate, and engagement rate. |
| Top 20 search terms with no results | The top 20 search terms that returned no results when searched. |
| Top 20 search terms with high avg. search rank | The top 20 search topics by volume with an average click position of greater than five. |
| Top 20 search terms with low engagement rate | The top 20 search topics by volume with engagement rate of less than 40 percent. |
| Search volume by application | The percentage of searches across multiple applications. |
| Search volume by search type | The percentage of searches based on whether they were manual or automatic searches. |

### View reports in different time zones

Use the Timezone option available in the reports to view the  time information according to the time zone that you specify. You can save your preferred time zone settings for reports as bookmarks. The bookmarks allow you to switch between reports in various time zones, without having to set the time zone. More information: [Manage bookmarks for reports](manage-bookmarks.md#manage-bookmarks-for-reports)

:::image type="content" source="../media/knowledge-analytics-timezone.png" alt-text="Screenshot shows Timezone view in reports":::

## Overall performance (Preview)

[!INCLUDE preview-banner]

You can view this report if you have knowledge harvesting turned on in the Customer Service admin center. You must also have the **Real-time creation** and **Creation from historical cases** turned on for knowlegde harvesting. Learn more in [Manage Customer Knowledge Management Agent (preview)](../administer/admin-km-agent.md#manage-customer-knowledge-management-agent-preview).

### Related information

[Configure knowledge search insights](../administer/enable-knowledge-search-insights.md)  
[Search for knowledge articles](search-knowledge-articles-csh.md)  
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  
[Use embedded knowledge search to set up knowledge management](../administer/set-up-knowledge-management-embedded-knowledge-search.md)  
[Manage report bookmarks](manage-bookmarks.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
