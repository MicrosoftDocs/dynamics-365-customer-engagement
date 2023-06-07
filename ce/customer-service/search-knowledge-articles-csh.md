---
title: Search knowledge articles
description: Learn how to search knowledge articles in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/02/2023
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Search knowledge articles

To help answer a customer's question or solve an issue, you can search knowledge articles in Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service.

> [!NOTE]
> Knowledge base search is also available in some versions of Dynamics 365 Customer Engagement (on-premises). For more information, go to [New features in Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/whats-new#agent-productivity-enhancements-to-knowledge-capabilities).

The article describes the different options that you can use to search knowledge articles.

## Prerequisites

The different search options that are described in this article have one or more of the following prerequisites:

- Your administrator must [enable Dataverse search](/power-platform/admin/configure-relevance-search-organization). [Learn more about knowledge base search mechanisms](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals).
- Your administrator must configure the following view columns for the **Quick Find** view by going to **Tables** \> **Knowledge Article** \> **Views** \> **Quick Find Active Knowledge Articles**:

    - **Article Public Number**
    - **Content**

        > [!NOTE]
        > The **Content** field is hidden in the user interface (UI) to help prevent unintentional deletion of content. Content deletion might disrupt the Dataverse search functionality.

    - **Created On**
    - **Keywords**
    - **Knowledge Article Views**
    - **Language**
    - **Major Version Number**
    - **Minor Version Number**
    - **Modified On**
    - **Rating**
    - **Status**
    - **Title**

- You must have access to knowledge article entities, such as Knowledge Article, Knowledge Article Views, Knowledge Article Attachment, Favorite Knowledge Article, and Knowledge Article Image. In addition, your administrator must grant the **Create**, **Read**, **Write**, **Delete**, **Append**, and **Appendto** privileges to any new custom roles that you've created.
- In Customer Service workspace and Omnichannel for Customer Service, your administrator must enable the app side pane and knowledge search in agent experience profiles.
- To open the knowledge pane, you must be working with a case or conversation. Before you can open the knowledge pane for any other entity, your administrator must enable it in the [knowledge management configuration](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management).

## Use direct knowledge base search in Customer Service Hub

In Customer Service Hub, you can search the knowledge base directly, without first viewing a case or conversation.

1. In Customer Service Hub, in the site map, under **Knowledge**, select **Knowledge Search**.
1. In the search box, enter a keyword.

:::image type="content" source="media/search-kb-article.png" alt-text="Screenshot that shows a direct search for a knowledge article in Knowledge Search in Customer Service Hub.":::

Legend:

1. The search box.
1. Visibility and status tags.
1. The number of attachments, likes, and views, and the date when the article was last updated.
1. The article ID.
1. An info card that displays search term matches from keywords, the description, attachments, and any other custom fields.
1. An attachment that includes the search term in its title or contents. The attachment title appears only when the search term matches content in the attachment.

If your administrator hasn't enabled Dataverse search, the keywords that you enter are used to do a full-text search of the following knowledge article metadata: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**. If Dataverse search is enabled, your administrator can [select the columns that are searched](/power-platform/admin/configure-relevance-search-organization).

> [!TIP]
> If style tags are visible in the article's content summary, style tags have been used to format the article. Consider sending feedback to the article's author to suggest that they use inline CSS styling instead of putting styles in style tags.

## Use the reference pane in Customer Service Hub

When you view a case or conversation in Customer Service Hub, you can search the knowledge base for related articles in the reference pane. By default, the case title is used as the search term. However, you can enter your own keywords for more relevant results.

1. Open a case or conversation.
1. In the reference pane to the right of the timeline, select the **Knowledge search** button (book symbol).
1. Replace the default search term with your own keyword to fine-tune the search results.

:::image type="content" source="media/knowledge-search-csh.png" alt-text="Screenshot that shows the features of knowledge base search in Customer Service Hub.":::

Legend:

1. Filter the list of results.
1. Sort the list of results.
1. The search box.
1. Unlink the article from the current record.
1. Open the article in a new browser window. To view the article in the reference pane, select its title in the search results.
1. Open a new email so that you can send the article to your customer.
1. The rating.
1. The number of views that the article has received.
1. Link the article to the current case or conversation.
1. Status and visibility tags for the article.
1. Confirmation that the record is linked to a case.
1. An info card that displays search term matches from keywords, the description, attachments, and any other custom fields.
1. The article date.
1. The article number.

> [!NOTE]
> Matches for the keyword that you used are highlighted in yellow but don't necessarily appear in the first three lines. Therefore, the highlighted text might not be visible in search results.

## Use the app side pane in Customer Service workspace and Omnichannel for Customer Service

When you view a case or conversation in Customer Service workspace and Omnichannel for Customer Service, you can search the knowledge base for related articles in the app side pane. By default, the case title is used as the search term. However, you can enter your own keywords for more relevant results.

Articles are displayed based on Dataverse and full-text search mechanisms. The knowledge articles are applicable to all the knowledge-enabled entities. By default, the Dataverse and full-text search mechanisms display 10 results.

1. Open a case or conversation.
2. In the app side pane, select the **Knowledge search** button (book symbol).
3. Replace the default search term with your own keyword to fine-tune the search results.

:::image type="content" source="media/csw-knowledge-tab.png" alt-text="Screenshot that shows the features of knowledge base search in Customer Service workspace or Omnichannel for Customer Service.":::

Legend:

1. The **Knowledge search** button.
1. A tag that indicates that the article is linked to an entity.
1. The article ID.
1. The number of times that the article has been viewed.
1. An info card that displays search term matches from keywords, the description, attachments, and any other custom fields.
1. Link the article to the current case or conversation. If the article is already linked, select the button to unlink it from the current case or conversation.
1. Status and visibility tags for the article.
1. Search results across attachments. The attachment title appears only when the search term matches the content in the attachment.

Select **More options** (**&hellip;**), and then use the menu to perform other actions.

> [!NOTE]
> These actions can be performed only for published or expired articles.

- Select **Email Content** to open a new email so that you can send the article to your customer.
- In channels other than voice in Omnichannel for Customer Service, you can select **Send URL** to paste the article link into the conversation window.

## Use smart assist

In Customer Service workspace and Omnichannel for Customer Service, smart assist suggests knowledge articles in real time, based on your ongoing conversation with a customer.

- In the app side pane, select the **Smart assist** button (light bulb symbol) to view knowledge article suggestions that are related to your case.

## Use suggest-as-you-type

The suggest-as-you-type feature starts to suggest relevant knowledge articles as you type keywords in the search box.

Your search phrase is matched against the title of the article, and the matching results appear on a flyout. However, if the search phrase consists of more than one keyword, only knowledge articles that have a full-string match are suggested. For example, if you search for *Cheque Book Reissue*, only knowledge articles that match the full string *Cheque Book Reissue* are suggested. Articles that match individual keywords (*Cheque*, *Book*, and *Reissue*) aren't suggested.

The flyout displays a maximum of six knowledge articles. The matched text is highlighted to show the presence of the search phrase. When you select a record, the system displays the article inline in the knowledge search control that is embedded in a form, on an application tab in Customer Service workspace, and as an inline view in the direct knowledge base search.

Your administrator must [enable suggest-as-you-type](set-up-knowledge-management-embedded-knowledge-search.md#enable-the-suggest-as-you-type-option) before you can use it.

:::image type="content" source="media/autosuggest-ka-csw.png" alt-text="Screenshot that shows the suggest-as-you-type feature being used in Customer Service workspace.":::

## Use favorites

Save the knowledge articles that you use most as favorites. In this way, you can quickly access them while you're working on a case. You can save up to 50 articles as favorites. Your administrator must provide [privileges to custom roles](#prerequisites) before you can use favorites.

To mark an article as a favorite, follow these steps:

1. Select an article in the list of search results.
1. Select the **Favorite** button (heart symbol) to add the article to your favorites list.

To remove an article from your favorites list, select the **Unfavorite** button (heart symbol).

View your favorite articles on the **My favorites** tab. This tab is available in the app side pane, the standalone search control, the form-embedded control, and the reference pane.

The last article that you marked as a favorite appears first in your favorites list. If an article is deleted, it no longer appears in the list. 

Favorite articles are saved in the language that you were viewing them in when you marked them as a favorite. Translated versions of a favorite article don't appear as favorites. If you create a major or minor version of a favorite article, the new version will appear as a favorite, and the earlier version will be removed from your favorites list.

In Customer Service workspace and Omnichannel for Customer Service, when you select a favorite article, it opens on an application tab. In Customer Service Hub, the article opens in a new browser window.

## Use integrated search providers

View the most relevant search results for your query across search providers in a single ranking. Easy sorting helps you find the knowledge article that best suits your needs while you're working with a customer. The name of the source provider appears on the knowledge article's card. You can hover on it to get the full name of the source provider, if necessary.

To enable the integrated search provider option, contact your administrator. For more information, go to [Manage integrated search providers](add-search-provider.md#manage-integrated-search-providers). After your administrator enables the feature, you can view search results for your keywords across your configured search providers in both Customer Service Hub and Customer Service workspace.

To search from Customer Service workspace, for example, follow these steps:

1. In Customer Service workspace, in the site map, select a case. Then select **Knowledge search** in the app side pane.
1. Enter the search keyword. Depending on the keyword, the most relevant search results are displayed, together with the search provider.
1. Select **Show more** to view more results.

## View knowledge articles

When you select an article in the search results, the place where it opens depends on the place where you searched for it.

### View a knowledge article on an application tab

In Customer Service workspace and Omnichannel for Customer Service, the article opens on an application tab. You can open up to 10 articles on application tabs.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Screenshot of an article opened on an application tab in Customer Service workspace.":::

You can perform the following actions for the knowledge article:

- Select **Copy URL** to copy the external URL of the article so that you can share it with your customers over channels such as chat or email.
- Select the thumbs-up or thumbs-down button to rate how helpful the article was. If you select the thumbs-down button, a **Comments** box appears, where you can provide additional information and reasons for your rating.

    Your administrator must [enable knowledge articles for feedback and ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback) before you can rate them.

    Depending on their role and privileges, customer service agents and customer service managers can create or view feedback. Out of the box, you can create, view, or edit only your own feedback. Customer service managers and knowledge managers can view feedback that you submit.

### View the knowledge article inline in the search control

In Customer Service Hub, when you select an article title, its full content is rendered in the same control. The article opens inline, and you can scroll to read the complete article.

If you receive an error when you try to open an article, the link types that are used in the article might not be part of the origins allow list. In this case, the following error message also appears: "Update your origins allow list if any iframe in the article doesn't work or displays error." You must contact your administrator to [update your origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md).

> [!div class=mx-imgBorder]
> ![Screenshot of the inline view of a knowledge article in Customer Service Hub.](media/km-inline-article-view.png "Screenshot of the inline view of a knowledge article in Customer Service Hub")

In this view mode, you can perform actions such as linking the knowledge article to a record or emailing it to a customer. [Learn more about how to send knowledge articles via email.](email-articles.md#email-a-knowledge-article)

Select the **Copy Link** button ![Copy Link button in Dynamics 365 Customer Service](../customer-service/media/copy-link-button.png "Copy Link button in Dynamics 365 Customer Service") to copy the external URL of the article so you can share it with your customers over channels like chat or email.

> [!NOTE]
> - If you use a browser other than [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], the **Copy Link** button isn't available.
> - The **Copy Link** and **Email Link** options on the **More options** (**&hellip;**) menu are available only if your organization is using an external portal to publish knowledge articles, and your administrator selected the **Use an external portal** checkbox during the setup of embedded knowledge search. For more information, go to [Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md).
> - The **Copy Link**, **Email Link**, and **Email** options on the **More options** (**&hellip;**) menu can be used only for published or expired articles.

### View the knowledge article in a new window

In Customer Service Hub, in the reference pane, a pop-out button is displayed for every article in the search results. When you select the pop-out button for an article, the article opens in a new window.

:::image type="content" source="media/knowledge-search-pop-out-csh.png" alt-text="Screenshot that shows the pop-out option for a knowledge article in Customer Service Hub.":::

### View search results from external sources

In Customer Service Hub and Customer Service workspace, you can search for files, documents, and articles from data sources outside your Dynamics 365 organization, if your administrator has configured this option. To view those results, select the source in the list under **Knowledge**.

**In Customer Service Hub**

> [!div class=mx-imgBorder]
> ![Screenshot of the agent view of search providers in Customer Service Hub.](media/search-provider-agent.png "Screenshot of the agent view of search providers in Customer Service Hub")

**In Customer Service workspace**

:::image type="content" source="media/csw-external-sources.png" alt-text="Screenshot of the search results for external sources in Customer Service workspace.":::

[Learn how to set up search providers in Customer Service Hub.](set-up-search-providers.md)

### See also

[Configure knowledge base article URLs](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-base-article-urls)

[Filter knowledge articles](filter-articles.md#filter-knowledge-articles)

[Link and unlink knowledge articles](link-articles.md#link-and-unlink-knowledge-articles)

[Email a knowledge article](email-articles.md#email-a-knowledge-article)

[Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
