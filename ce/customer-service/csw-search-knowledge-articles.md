---
title: Search knowledge articles in the Customer Service workspace in Dynamics 365 Customer Service | Microsoft Docs
description: See how you can effectively search knowledge articles in the Customer Service workspace.
ms.date: 01/27/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
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
---

# Search for knowledge articles in Customer Service workspace

In Customer Service workspace, knowledge base search lets you search for relevant knowledge articles to resolve a case. The knowledge area is available on the productivity pane.

## Prerequisites

- The productivity pane and knowledge search must be enabled in the app profile manager.
- The anchor tab should be a case or conversation for the knowledge search pane to be displayed.
- Dataverse search must be enabled.

The knowledge base search uses the dataverse search mechanism in the knowledge base search control area. More information: [How Dataverse search works](/power-platform/admin/configure-relevance-search-organization). Before you begin using dataverse search, your administrator must configure certain view columns in the Quick Find view columns list. More information: [Before you begin using Dataverse Search](search-knowledge-articles-csh.md#before-you-begin-using-dataverse-search).

## Use the knowledge search pane to search articles

In Customer Service workspace, for a case, when you select the Knowledge Search tab, knowledge articles that match the case title are displayed on the **Knowledge search** pane. These articles are displayed based on relevance and full-text search mechanisms.

The knowledge articles are applicable for all knowledge-enabled entities. By default, the full-text search displays 10 results and Dataverse search displays 50 results. You can also use the search box to enter keywords and search for articles if those displayed by default are not relevant.

:::image type="content" source="media/csw-knowledge-tab.png" alt-text="View features in knowledge base search":::

  |Label|Description|
  |-----|-----------|
  |1.| The Knowledge tab.|
  |2.| Tag when the article is linked to the entity.|
  |3.| Article number (Preview)|
  |4.| The number of times the article has been viewed. |
  |5.| Info card that displays search term matches from keywords, description, attachments, and any other custom fields. (Preview) |
  |6.| Lets you link or unlink the article to the entity, such as the case.|
  |7.| Status and visibility tags for the article.|
  |8.| Search results across attachments. The attachment title is displayed only when the search term matches the content in the attachment. (Preview)|
  
> [!NOTE]
> The article number, info card that displays search term matches across custom fields, and search results across attachments are in preview.

## Use the knowledge search pane to work on your articles

You can also perform the following actions on your knowledge article from the **Knowledge search** pane.

### View the knowledge article on the application tab

Select an article title to view the article on an application tab. You can view up to 10 articles on the application tab.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Knowledge article search pane":::

You can perform the following actions for the knowledge article:

- Copy URL to copy the external URL of the article so you can share it with your customers over channels like chat or email.
- Provide feedback by selecting the thumbs up or thumbs down icon.
  - Make sure that the knowledge article entity is enabled for feedback. To learn more, see [Enable an entity for feedback/ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).
  - Customer service agents and customer service managers can create, or view feedback based on their role and privileges on feedback entity. Out of the box, customer service agents can create, view, or edit their own feedback only. Customer service managers or knowledge managers can view feedback submitted by all agents.
- When you select thumbs down, the **Comments** box to provide feedback appears. Optionally, provide additional information and reasons for the feedback.

### Filter knowledge articles

With the help of text and visual filters, you can filter the knowledge articles.

:::image type="content" source="media/csw-article-filter.png" alt-text="Filter knowledge articles":::

When you select the filter icon, you can see the **Filter by** menu where you can filter the items based on the following categories.

  | Category | Sub-category |
  |-----------------------|-----------------------|
  | Status | <ul> <li> Approved </li> <li> Published </li> <li> Scheduled </li> </ul> |
  | Visibility | <ul> <li> Internal </li> <li> External </li> </ul> |
  | Modified On | <ul> <li> Last 7 days </li> <li> Last 30 days </li> <li> Last 6 months </li> <li> Last year </li> <li> All </li> </ul> |
  | Language | <ul> <li> List of languages </li> </ul> **Note:** The language list is based on the articles that are present in the those languages. For example, there are a total of 50 articles in five different languages such as French, English, Japanese, Spanish, and Danish. The language filter will show only these five languages. |
  |||

### Sort knowledge articles

The knowledge base search control also enables you to sort the knowledge articles. 

:::image type="content" source="media/csw-sort-km.png" alt-text="Sort knowledge article":::

Select the up-arrow icon to view the sorting options and select an option from the following: 

- Relevance
- Number of views
- Last modified date (newest first) 
- Last modified date (oldest first)

### Link and unlink the knowledge article to a record

When configured, you can link an article to case. You can associate and dissociate the knowledge article with a record.

:::image type="content" source="media/csw-link-unlink-km.png" alt-text="Link or unlink an article to a case":::

By default, the articles aren't linked to the case. When you select to link the article to the case, the link icon changes, and **Linked to Case** is displayed for the article.

### Email options

You can also share the knowledge article link or knowledge article content through mail by selecting the ellipsis next to an article.

:::image type="content" source="media/csw-email-url.png" alt-text="Email options for knowledge artcile":::

- **Copy URL**: You can copy the URL to share the knowledge article link.
- **Email URL:** The new email form opens with the link to the article in the mail box.
- **Email Content:** The article content is populated in the mail body. The fields are automatically populated based on the case and customer details.

Add other information as needed, and then on the command bar, select **Send**. Also, you can perform these actions for only published or expired articles.



### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)  
[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)  
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
