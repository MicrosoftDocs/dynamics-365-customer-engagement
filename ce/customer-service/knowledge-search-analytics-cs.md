---
title: Knowledge search analytics dashboard | Microsoft Docs
description: Learn about the knowledge search analytics reports to better understand agent performance in your organization.
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

# Preview: Knowledge search analytics dashboard

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

The knowledge search analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles.

![Knowledge search analytics dashboard](media/knowledge-search-analytics-dashboard.png "Knowledge search analytics dashboard")

As a knowledge manager, it's your responsibility to maintain and improve your organization's overall knowledge base article offerings. By identifying searches that have low success or return no results, the Knowledge search analytics dashboard can help you identify knowledge gaps, improve search results, and surface the most relevant articles.  

The following are specific KPIs represented in this dashboard: 

| KPI | Definition |
|----------------------|-------------------------|
| Search count | The total number of searches completed within a given period. |
| Search count over duration | The number of searches of completed within a certain amount of time. |
| Avg. search rate trend | |
| Avg. search rank | The average position of the link selected by a user when presented within search results. |
| Engagement rate | The percentage of events where a user interacted with the search results compared to the search events presented with results. |
| Engagement rate trend |  |
| Rate of no-result searches | Percentage of instances where there are no results for the that was term searched for. |
| Rate of no-result searches trend |  |
| Top 20 search terms | The top 20 terms being searched, showing the number of times searched, the average search rate, and engagement rate. |
| Top 20 search terms with no results | The top 20 search terms that returned no results when searched. |
| Top 20 search terms with high avg. search rank | The top 20 search topics by volume with an average click position of greater than 5. |
| Top 20 search terms with low engagement rate | The top 20 search topics by volume with engagement rate of less than 40 percent. |
| Search volume by application | The percentage of searches across multiple applications. |
| Search volume by search type | The percentage of searches based on whether they were manual or automatic searches. |

### See also

[Search for knowledge articles](search-knowledge-articles-csh.md) <br>
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md) <br>
[Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)
