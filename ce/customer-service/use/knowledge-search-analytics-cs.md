---
title: Knowledge article and search term analytics dashboards | Microsoft Docs
description: Learn about the knowledge article and search term analytics dashboards to better understand agent performance in your organization.
ms.date: 10/03/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
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

The Search term insights dashboard is designed to provide supervisors and knowledge workers with valuable insights into how agents find and use knowledge articles.

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

## Overall performance

### Prerequisites

- You must have knowledge harvesting turned on in CSAC. You must have the real time and/or  historical being turned on in from CSC.

The effectiveness of Copilot is closely linked to the quality of our knowledge base. To create, cultivate, and sustain high-quality knowledge, we rely on valuable insights. Knowledge Insights empower customers to assess Copilot’s performance, instilling confidence in autonomous content generation. Additionally, these analytics enhance our harvesting methods and guide customers toward impactful knowledge enhancements, streamlining their self-help resources.

Supervisors and content managers can view the Overall performance dashboard from Knowledge analytics in Customer Service workspace. 

Analysing how the articles are created, where they are in the review and publish workflow, if they're used in copilot responses and if the agents find them useful in their day-to-day work. Having visibility into this gives content managers a sense of how healthy their knowledge repository is and knowing when to act.

You can provide feedback through a 5 star rating approach with suggested prompts. This helps the system and the content managers identify and act on low quality articles more efficiently.

6 charts

1st chart: The first chart here it shows the number of articles that have been published. the bigger bar is really the articles that were created by copilot. So like the published articles. From like and this is a trend up to six months, 90 actually up to six months of trend here.

So you can show you can see how many articles are published and divided by like.
Natasha Fattedad 5 minutes 57 seconds
You know how they were created or not divided by like, you know, just like you can see that number per type of creation type.
Natasha Fattedad 6 minutes 8 seconds
This chart is really talking about like at this point in time, how many articles in each are in what state? If you look at a bug, bash instance is no longer bar chart.
Natasha Fattedad 6 minutes 19 seconds
Is actually going to be two pie charts, so the display is a little different.

so you'll see out of article all the articles that were there in the system that were.
Natasha Fattedad 6 minutes 38 seconds
Created by copilot.
Natasha Fattedad 6 minutes 41 seconds
Are they?
Natasha Fattedad 6 minutes 41 seconds
How many are in draft state?
Natasha Fattedad 6 minutes 42 seconds
How many are in review state and how many are in published state and then and then there's another pie chart about the same information.
Natasha Fattedad 6 minutes 50 seconds
But then just articles that were created manually.


Natasha Fattedad 7 minutes 54 seconds
That one got postponed till February, so it's not part of the public preview, but instead right now we still have the thumbs up and thumbs down in each knowledge article. If people choose to provide that information so.
Natasha Fattedad 8 minutes 6 seconds
Taking the thumbs up and thumbs down, we're gonna calculate the average score of all the articles that been like, you know, published in the system.

And then, like, you know, show that average score here.

here this is like you know the score, a trend of the score over the past X number of days.
Natasha Fattedad 8 minutes 26 seconds
So that people can see what like you know, if the knowledge articles are performing better or like you know, are they of better quality or not?
Natasha Fattedad 8 minutes 34 seconds
And then if not, they can act on that. Now here this one is usage by copilot.
Natasha Fattedad 8 minutes 39 seconds
This is something that I think a lot of customers ask for it.
Natasha Fattedad 8 minutes 42 seconds
They want to know if the articles are actually used by copilot.
Natasha Fattedad 8 minutes 45 seconds
So we wanna so we show that.


Natasha Fattedad
8 minutes 48 seconds8:48
Natasha Fattedad 8 minutes 48 seconds
And one bar.
Natasha Fattedad 8 minutes 48 seconds
The bar on the left shows like the articles that were created by copilot.
Natasha Fattedad 8 minutes 52 seconds
And then we're on the right shows the articles that were created manually so that they know like, you know, what's the quality difference there and where they need to invest their effort.
Natasha Fattedad 9 minutes 2 seconds
And then this one is a kind of like a trend of that quality score that you just saw above.
Natasha Fattedad 9 minutes 7 seconds
So over time, the copilot created articles versus the manually created articles.


- content managers see an overview of the health and effectiveness of the knowledge repository and the first chart.
- A trend of the number of articles drafted by copilot versus manual drafting is shown to give them an overview and help them fine tune their harvesting conditions.
- A trend of the number of articles drafted by copilot versus manual drafting is shown to give them an overview and help them fine tune their harvesting conditions. Not only does this show the performance difference, it also helps them identify the review and publish issues more quickly.
- The Average Quality score chart is a straightforward knowledge health indicator. It's based on the article quality feedback from the agents.
- The article to revise chart is about the trend of low quality articles.It's an actionable insight that is tied to the suggested actions view that's coming on the next slide.
- The usage by Copilot graph focuses on how many knowledge articles are used within the Copilot system. It's so that the customers can assess the impact of any knowledge related changes that they make, so for example to the content or the processes, and then so they can make adjustments accordingly.

1. in CSW, go to Knowledge Analytics, go to Overall performance.



### Related information

[Configure knowledge search insights](../administer/enable-knowledge-search-insights.md)  
[Search for knowledge articles](search-knowledge-articles-csh.md)  
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  
[Use embedded knowledge search to set up knowledge management](../administer/set-up-knowledge-management-embedded-knowledge-search.md)  
[Manage report bookmarks](manage-bookmarks.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
