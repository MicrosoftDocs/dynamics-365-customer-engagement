---
title: Filter knowledge articles in Dynamics 365 Customer Service | Microsoft Docs
description: Learn how you can filter knowledge articles in Dynamics 365 Customer Service.
ms.date: 08/25/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Filter knowledge articles

## Filter knowledge articles

With the help of text and visual filters, you can filter knowledge articles.

:::image type="content" source="media/csw-article-filter.png" alt-text="Filter knowledge articles":::

When you select the filter icon, you can see the **Filter by** menu where you can filter the items based on the following categories.

  | Category | Sub-category |
  |-----------------------|-----------------------|
  | Status | <ul> <li> Draft </li><li> Approved </li> <li> Published </li> <li> Scheduled </li> </ul> |
  | Visibility | <ul> <li> Internal </li> <li> External </li>  <li> All </li> </ul> |
  | Modified On | <ul> <li> Last 7 days </li> <li> Last 30 days </li> <li> Last 6 months </li> <li> Last year </li> <li> All </li> </ul> |
  | Language | <ul> <li> List of languages </li> </ul> **Note:** The language list is based on the articles that are present in those languages. For example, there are a total of 50 articles in five different languages such as French, English, Japanese, Spanish, and Danish. The language filter will show only these five languages. |
  |||

## Personalize your knowledge search article filters

If your administrator has configured knowledge filter personalization settings, as an agent, you can select the filters you want to use.

You can do the following:
- Set preselects
- Activate or deactivate a filter

Only the filters that your administrator has configured are viewable. If your administrator deactivates a filter, that filter becomes invisible without notifying you. If you notice that a filter has suddenly disappeared, contact your administrator for assistance. If your administrator disables all filters, you won't see any filters, and a message will be displayed that says, "No filters have been configured. Contact your administrator."

Any personalization you make to your filter selections will also be applicable to the form-based knowledge control and standalone knowledge base search page.

If you deactivate a filter, it will appear as deactivated. If you reactivate the same filter later, the filter will keep its previous configuration.

1. In **Customer Service Hub**, go to **Service** > **Knowledge** > **Knowledge Personalization**.
2. For each filter value you want to change, select the ellipsis in the top-right corner, and then select **Preselects**.
3. To make a filter value available by default, toggle the preset next to the filter to the right so that **Preselected** appears next to the filter name.
4. When you are finished making your selections, select **Done** > **Save**.
5. If you want to deactivate a filter, select the ellipsis in the top-right corner for the filter you want to stop using, and then select **Deactivate**.
6. Select **Done** > **Save**.
7. When you are ready to reactivate the filter, select the ellipsis again, and then select **Activate**.
   All of the previous configurations will be reinstated.

### Sort knowledge articles

The knowledge base search control also enables you to sort the knowledge articles. 

:::image type="content" source="media/csw-sort-km.png" alt-text="Sort knowledge article":::

Select the up-arrow icon to view the sorting options and select an option from the following: 

- Relevance
- Number of views
- Last modified date (newest first) 
- Last modified date (oldest first)

## View auto-filtered results

As a customer service agent, to view the most relevant results, you can have knowledge articles automatically filtered based on the case data. This helps with identifying the most relevant articles so that you can resolve customer queries quickly and accurately. You can also disable the auto-filter results and search the entire knowledge base. Auto-filtered results option is only available on single session.

An administrator or system customizer must configure this option for you. More information: [Configure automatic filtering](add-knowledge-base-search-control-forms.md#configure-automatic-filtering-for-the-web-client)

To view the auto-filtered results:

1. Search knowledge articles from the related section of the case. More information: [Search knowledge articles](search-knowledge-articles-csh.md). The articles are automatically filtered and displayed based on case data.

2. If you want to disable the automatic filtering option and search the entire knowledge base for articles, deselect **Auto-filter results**.  

    > [!NOTE]
    > Your administrator or system customizer must enable **Users can turn off automatic filtering** option for you to see the **Auto-filter results** option. If the **Users can turn off automatic filtering** option isn't enabled, you'll always see the auto-filtered results. More information: [Configure automatic filtering](add-knowledge-base-search-control-forms.md#configure-automatic-filtering-for-the-web-client)

Here's an example.

In the following illustration, the case subject is **Xbox**. If automatic filtering is configured on the case subject, with the **Auto filter results** checkbox selected, only those knowledge articles whose subject is **Xbox** are displayed. Other articles are automatically filtered out, as shown in the following image.

![Select Auto filter results.](media/ka-select-auto-filter-results.png "Select Auto filter results")
  
However, if the **Auto-filter results** checkbox isn't selected, you can see more articles that aren't related to the subject. These are the results from the entire knowledge base.

![Deselect Auto-filter results.](media/ka-deselect-auto-filter-results.png "Deselect Auto-filter results")

### See also

[Search knowledge articles](search-knowledge-articles-csh.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
