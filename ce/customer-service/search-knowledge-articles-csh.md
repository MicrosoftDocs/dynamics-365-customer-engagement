---
title: Search knowledge articles in Dynamics 365 Customer Service | Microsoft Docs
description: Learn how you can search knowledge articles in Dynamics 365 Customer Service.
ms.date: 01/10/2023
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

# Search knowledge articles

You can search knowledge articles in Customer Service Hub, Customer Service workspace, or Omnichannel for Customer Service.

## Prerequisites

Dataverse search must be enabled. The knowledge base search uses the Dataverse search mechanism in the knowledge base search control area, in addition to the global search area where Dataverse search is already enabled. Dataverse search uses Azure search service to index and search records.

Dataverse search provides improved search functionality, like better relevance, highlighted search keyword text, and the ability to search within attachments and notes. With Dataverse search, you can also configure searchable fields in the knowledge article entity.

More information: [Configure searchable fields for Dataverse Search](/power-platform/admin/configure-relevance-search-organization)

> [!NOTE]
> To enable Dataverse search for the knowledge article entity, see [Enable Dataverse Search](/power-platform/admin/configure-relevance-search-organization) and [Select entities for Dataverse Search](/power-platform/admin/configure-relevance-search-organization). Once Dataverse search is enabled, irrespective of whether the knowledge article entity is enabled or disabled, Dataverse search will be used.

For more information, see [Understand knowledge base search mechanisms](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals).

Before you begin using Dataverse search, your administrator must configure certain view columns in the Quick Find view columns list. Dataverse search uses the scoring concepts as defined by Azure search. If any of these columns are deleted or missing, the search query displays an error.

> [!NOTE]
> An admin can configure the knowledge article quick find view columns list by navigating to Settings > Customizations > Entities > Knowledge Article > Views > Quick Find View > View Columns.

The following are the required view columns:

- Article Public Number
- Content
- Created On
- Keywords
- Knowledge Article Views
- Language
- Major Version Number
- Minor Version Number
- Modified On
- Rating
- Status
- Title

The **Content** field is hidden on the user interface to avoid unintentional deletion of content leading to disruption in the Dataverse search functionality.

### Customer Service workspace and Omnichannel for Customer Service

- The app side pane and knowledge search must be enabled in Agent experience profiles.
- The anchor tab should be a case or conversation for the knowledge pane to be displayed. To open the knowledge pane on any other entity, you must enable it. More information: [Configure knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management)

## Use the independent knowledge base search

You can perform independent knowledge base searches using the **Knowledge Search** option. In the Customer Service Hub site map, use the **Knowledge Search** option in the **Knowledge** area. In Customer Service Workspace, from the **Customer Service Agent Dashboard**, select any case to view the **Knowledge search** pane. This functionality performs like a knowledge search hub, where you can do the following:

- View an article 
- Send an article pop out 
- Copy and send article URLs (when preconfigured). To configure the ability to copy and send article URLs, see [Configure knowledge base article URLs](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-base-article-urls).

Type a keyword in the search field to search for knowledge articles.

 :::image type="content" source="media/search-kb-article.png" alt-text="Search for knowledge article":::

  |Label|Description|
  |-----|-----------|
  |1.| The Knowledge search field.|
  |2.| Status and visibility tags for the article.|
  |3.| The number of times the article has been viewed. |
  |4.| Article number.|
  |5.| Info card that displays search term matches from keywords, description, attachments, and any other custom fields.|
  |6.| Search results across attachments. The attachment title is displayed only when the search term matches the content in the attachment.|

- If Dataverse search isn't enabled, the keywords that you enter will initiate a search (using the Full-text search mechanism) in the following fields of a knowledge article: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**.

  > [!NOTE]
  > If there's a style tag with CSS styles at the top of the article, the summary of the content in the knowledge search results list will contain style tags. Use inline CSS styling instead of putting styles in style tags.

- If Dataverse search is enabled, you can configure the fields  that you want to be searched for. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure searchable fields for Dataverse Search](/power-platform/admin/configure-relevance-search-organization) 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add the Knowledge Base Search control to Main forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-main-forms) 

## Use the reference pane in Customer Service Hub

In Customer Service Hub, for example for a case, when you select the **Knowledge** option in the reference pane, the **Knowledge** tab shows you articles arranged in a single stream. Searching, sorting, and filtering articles in the search control is faster and more responsive, with improvements to article viewability and usability. The Knowledge Base Search capability is also available in Dynamics 365 Customer Engagement (on-premises) 9.1. More information: [New features in Dynamics 365 Customer Engagement (on-premises)](../customerengagement/on-premises/whats-new.md#agent-productivity-enhancements-to-knowledge-capabilities)

On the **Knowledge** tab, you can view the following options:

:::image type="content" source="media/knowledge-search-csh.png" alt-text="View the features of knowledge base search":::

|Label  |Description  |
|---------|---------|
|1.    |     Open filter pane    |
|2.     |    Sort search results by     |
|3.    |   Search box     |
|4.    |   Unlink this article from the current record      |
|5.    |  Pop out the article in a new window  |
|6.   |   Email the article to your customer      |
|7.     |  Rating       |
|8.     |  Number of views the article has received     |
|9.   |   Link this article to the current record (unlink will be displayed when the article is already linked to a record)      |
|10.    |    Status and visibility tags for the article     |
|11.    |    Confirmation that the record is linked to a case   |
|12.     | Info card that displays search term matches from keywords, description, attachments, and any other custom fields.       |
|13.     |    Article date    |
|14.    |   Article number     |

> [!NOTE]
> If the keyword you used matches, the matches are highlighted in yellow, but won't necessarily show up in the first three lines, so you might not see the highlighted text in search results.

In the knowledge base search control, you can do the following:
- Search for knowledge articles
- Filter articles using multiple filter options
- Sort knowledge articles
- Link and unlink a knowledge article to a record
- Email a knowledge article
- View the knowledge article inline in the search control

## Use the app side pane in Customer Service workspace and Omnichannel for Customer Service

In Customer Service workspace and Omnichannel for Customer Service, when you select the **Knowledge search** tab on the app side pane, knowledge articles that match the case title are displayed on the **Knowledge search** pane. These articles are displayed based on Dataverse and full-text search mechanisms.

The knowledge articles are applicable for all the knowledge-enabled entities. By default, the full-text search and Dataverse search display 10 results. You can also use the search box to enter keywords and search for articles if those results displayed by default aren't relevant.

:::image type="content" source="media/csw-knowledge-tab.png" alt-text="View features in knowledge base search":::

  |Label|Description|
  |-----|-----------|
  |1.| The Knowledge tab.|
  |2.| Tag when the article is linked to the entity.|
  |3.| Article number.|
  |4.| The number of times the article has been viewed. |
  |5.| Info card that displays search term matches from keywords, description, attachments, and any other custom fields.|
  |6.| Lets you link or unlink the article to the entity, such as the case.|
  |7.| Status and visibility tags for the article.|
  |8.| Search results across attachments. The attachment title is displayed only when the search term matches the content in the attachment.|

In addition to the above information, in Omnichannel for Customer Service, you can also use the **Send URL** option, when you select the ellipsis. The **Send URL** option pastes the article link in the conversation window when selected. However, if you're using the Voice channel, this option won't be available.

These actions can be performed for only published or expired articles.

## Use smart assist
Smart assist provides real-time knowledge article suggestions depending on the ongoing conversations with your customer. The smart assist option appears on the app side pane of Customer Service workspace only.

In Customer Service workspace, select the **Smart assist** option on the app side pane to see knowledge article suggestions related to your case.

## Use the suggest-as-you-type option

The suggest-as-you-type option provides you with suggestions on the most relevant knowledge articles as you type keywords into the Search box, thereby increasing your productivity with better discoverability of articles.

The search phrase is matched against the title of the article, and the matching results appear in a flyout menu. The maximum number of knowledge articles displayed in the flyout is six. The matched text is highlighted to show the presence of the keyword. When you select the record, the system displays the article inline on the knowledge search control embedded on a form, on an application tab in Customer Service workspace, and as an inline view in the independent knowledge search control.

To use the suggest-as-you-type option, your administrator must first enable it. More information: [Enable the suggest-as-you-type option](set-up-knowledge-management-embedded-knowledge-search.md#enable-the-suggest-as-you-type-option)


:::image type="content" source="media/autosuggest-ka-csw.png" alt-text="Screenshot shows use of the suggest-as-you-type option":::

## Use favorites (preview)

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

The favorites option provides you with the ability to save the most relevant and frequently used knowledge articles and access them quickly from the **Favorite** tab, while dealing with customer issues.

You can see the favorites option in the app side pane, standalone search control, form-embedded control, and the reference pane.

In Customer Service workspace or Omnichannel for Customer Service, when you select a favorite article, the article opens up in an app tab. ​In Customer Service Hub, the favorite article opens up in the pop-out mode and **Knowledge Search** option in the Knowledge area.

To add an article to the favorites list:

1. Select your article from the list of articles displayed in the **Search** tab.
1. Select the favorites (heart) icon to add an article to favorites. You can view your article in the **Favorite** tab.

To remove your article from the favorites list, cancel the selection.

The maximum number of articles that can be marked as favorite is 50. You'll see an error message if you've already marked 50 articles as favorites. If an article has been deleted, it will be no longer appear in your favorites list. Your article will be saved in the language in which it was saved as a favorite. You can see the latest published articles in the list. In case of latest published articles, if its a translated version then the new article won't be marked as favorite, but if it's just a major version in the same language, then the new version will be marked as favorite.

## View knowledge articles

### View the knowledge article on the application tab

In Customer Service workspace or Omnichannel for Customer Service, select an article title to view the complete article on an application tab. You can view up to 10 articles on the application tab.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Knowledge article search pane":::

You can perform the following actions for the knowledge article:

- Copy URL to copy the external URL of the article so you can share it with your customers over channels like chat or email.
- Provide feedback by selecting the thumbs up or thumbs down icon.
  - Make sure that the knowledge article entity is enabled for feedback. To learn more, see [Enable an entity for feedback/ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).
  - Customer service agents (you) and customer service managers can create or view feedback based on your role and privileges on feedback entity. Out of the box, you can create, view, or edit your own feedback only. Customer service managers or knowledge managers can view feedback submitted by you.
- When you select thumbs down, the **Comments** box to provide feedback appears. Optionally, provide additional information and reasons for the feedback.

### View the knowledge article inline in the search control

In Customer Service Hub, select an article title to see its full content rendered in the same control. The article opens inline, and you can scroll to read the complete article.

However, if you see an error while trying to open an article, it might be because the link types used in the article aren't a part of the origins allow list. The error message "Update your origins allow list if any iframe in the article doesn't work or displays error" will also appear. You must contact your administrator to update your origins allow list. More information: [Configure the origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md)

In this view mode, you can perform actions such as linking the knowledge article to a record or emailing the knowledge article to a customer. To learn more about sending the knowledge articles via email, go to [Email a knowledge article](email-articles.md#email-a-knowledge-article).

  > [!div class=mx-imgBorder]
  > ![Knowledge article inline view.](media/km-inline-article-view.png "Knowledge article inline view")

> [!NOTE]
> - Select the **Copy Link** button ![Copy knowledge article link button Dynamics 365 Customer Service](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365 Customer Service") to copy the external URL of the article so you can share it with your customers over channels like chat or email. If you use a browser other than [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], this option isn't available. 
>
> - The **Copy Link** and **Email Link** options are available only if your organization is using an external portal to publish the knowledge articles and your administrator selected the **Use an external portal** checkbox during embedded knowledge search setup. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)
>
> - The **Copy Link**, **Email Link**, and **Email** options can be used only for published or expired articles.

### View the knowledge article on a new window 

In Customer Service Hub, in the **Knowledge Search** reference pane, a pop-out option is displayed for every search article result. When you select the pop-out option for an article, the article opens in a new window.

:::image type="content" source="media/knowledge-search-pop-out-csh.png" alt-text="View knowledge article in a new window":::

### View search results from external sources

In Customer Service Hub and Customer Service workspace, if your administrator has configured the ability for you to search for files, documents, or articles from data sources outside of your current Dynamics 365 organization, you can view those results by selecting the provider from the drop-down list under **Knowledge**.

In Customer Service Hub:

   > [!div class=mx-imgBorder]
   > ![Agent view of search providers.](media/search-provider-agent.png "Agent view of available search providers")

In Customer Service workspace: 
:::image type="content" source="media/csw-external-sources.png" alt-text="Search results for external sources in Customer Service workspace":::

For more information on setting up search providers, see [Set up a search provider in Customer Service Hub](set-up-search-providers.md).

### See also

[Configure knowledge base article URLs](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-base-article-urls)

[Filter knowledge articles](filter-articles.md#filter-knowledge-articles)

[Link and unlink knowledge articles](link-articles.md#link-and-unlink-knowledge-articles)

[Email a knowledge article](email-articles.md#email-a-knowledge-article)

[Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
