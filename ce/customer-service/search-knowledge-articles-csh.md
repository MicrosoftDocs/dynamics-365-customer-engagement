---
title: Search knowledge articles
description: Learn how to search for and view knowledge articles in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/21/2023
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Search knowledge articles

Search and view knowledge articles to help answer a customer's question or solve an issue.

Knowledge base search is available in Customer Service Hub, Customer Service workspace, Omnichannel for Customer Service, and some versions of [Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/whats-new#agent-productivity-enhancements-to-knowledge-capabilities). Customers can search your knowledge base on their own if your organization has provided a [self-service portal](knowledge-base-search-methods.md).

## Prerequisites

- Your administrator has [turned on Dataverse search](/power-platform/admin/configure-relevance-search-organization).

- Your administrator has set up the following columns in the **Quick Find View** by navigating to **Tables** > **Knowledge Article** > **Views** > **Quick Find Active Knowledge Articles**:

  - Article Public Number
  - Content  
        The **Content** field is hidden in the user interface to avoid unintentional deletion of content.
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

- You have access to knowledge article entities, such as Knowledge Article, Knowledge Article Views, Knowledge Article Attachment, Favorite Knowledge Article, and Knowledge Article Image.

- Your administrator has granted **Create**, **Read**, **Write**, **Delete**, **Append**, and **Appendto** privileges to any new custom roles you created.

- In Customer Service workspace and Omnichannel for Customer Service, your administrator has turned on the app side pane and knowledge search in agent experience profiles.

- You're dealing with a case or a conversation, or your administrator has [turned on the ability](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management) to open the knowledge pane for other entities.

## Tips for search results

If a keyword you enter matches content in the knowledge base, the matching words are highlighted in yellow in the search results. Matches don't necessarily appear in the first three lines or words of an article, so you might not see the highlighted text in the search results.

If style tags are visible in an article's content summary, it means that style tags were used to format the article. Consider offering feedback to the article's author to use inline CSS styling instead.

## Search the knowledge base directly in Customer Service Hub

In Customer Service Hub, you can search the knowledge base directly, without first viewing a case or conversation.

1. In Customer Service Hub, under **Knowledge**, select **Knowledge Search**.

:::image type="content" source="media/search-kb-article.png" alt-text="Screenshot that shows a direct search for a knowledge article in Knowledge Search in Customer Service Hub.":::

    :::image type="content" source="media/search-kb-article.png" alt-text="Screenshot of knowledge search in Customer Service Hub.":::

Legend:
1. The search box
1. Status and visibility tags
1. The number of attachments, likes, and views, and the date the article was most recently updated
1. The article ID
1. A card that displays search term matches from keywords, description, attachments, and other custom fields
1. An attachment that includes the search term in its title or contents

If your administrator hasn't turned on Dataverse search, the system uses the keywords you enter to perform a full-text search of the following knowledge article metadata: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**. If Dataverse search is turned on, your administrator can [select the columns that are searched](/power-platform/admin/configure-relevance-search-organization).

## Search for related articles in Customer Service Hub

You can search the knowledge base for related articles when you view a case or conversation in Customer Service Hub.

1. In Customer Service Hub, open a case or conversation.

1. In the reference pane to the right of the timeline, select the **Knowledge search** (book) icon.

1. The case title is used as the search term by default, but you can enter your own keywords to get more relevant results.

    :::image type="content" source="media/knowledge-search-csh.png" alt-text="Screenshot of knowledge search in the reference pane.":::

Legend:

1. Filters the list of results
1. Sorts the list of results
1. Search box
1. Unlinks the article from the current case or conversation
1. Opens the article in a new browser window
    To view the article in the reference pane, select its title in the search results.
1. Opens a new email so that you can send the article to your customer
1. Rating
1. The number of times the article has been viewed
1. Links the article to the current case or conversation
1. Status and visibility tags for the article
1. Confirmation that the record is linked to a case
1. A card that displays search term matches from keywords, description, attachments, and other custom fields
1. The date the article was most recently updated
1. The article ID

## Search for related articles in Customer Service workspace and Omnichannel for Customer Service

You can search the knowledge base for related articles in the app side pane when you view a case or conversation in Customer Service workspace and Omnichannel for Customer Service. By default, a successful search displays up to 10 results.

1. In Customer Service workspace or Omnichannel for Customer Service, open a case or conversation.

2. In the app side pane, select the **Knowledge search** (book) icon.

3. The case title is used as the search term by default, but you can enter your own keywords to get more relevant results.

    :::image type="content" source="media/csw-knowledge-tab.png" alt-text="Screenshot of knowledge search in the app side pane.":::

Legend:

1. **Knowledge Search** icon
1. The tag that indicates the article is linked to the case or conversation
1. The article ID
1. The number of times the article has been viewed
1. A card that displays search term matches from keywords, description, attachments, and other custom fields
1. Links the article to the current case or conversation, or, if the article is already linked, unlinks it
1. Status and visibility tags for the article
1. An attachment that includes the search term in its title or contents

Select **More options** (**&hellip;**) to:

- Select **Email Content** to open a new email so that you can send the article to your customer.
- Select **Send URL** to paste the article link in the conversation window in channels other than Voice in Omnichannel for Customer Service.

You can perform these actions only on published or expired articles.

## See suggested articles during a conversation in Customer Service workspace and Omnichannel for Customer Service

In Customer Service workspace and Omnichannel for Customer Service, smart assist suggests knowledge articles in real-time based on your ongoing conversation with your customer.

In the app side pane, select the **Smart assist** (light bulb) icon to view suggestions of knowledge articles that are related to your conversation.

## Save time searching with suggest-as-you-type

If your administrator has [turned on suggest-as-you-type](set-up-knowledge-management-embedded-knowledge-search.md#enable-the-suggest-as-you-type-option), the system suggests related knowledge articles as you type in the search box.

Your search term is matched against article titles, and the matching results appear in a flyout menu. If your search term consists of more than one word, only titles that contain the full string, not individual words, are matched. For example, if you search for **Cheque Book Reissue**, articles with "Cheque Book Reissue" in the title are returned. Articles with the individual words "Cheque," "Book," or "Reissue" in the title aren't.

Suggest-as-you-type suggests up to six knowledge articles. Text that matches your keyword is highlighted in yellow. When you select the record, the system displays the article inline on the knowledge search control embedded on a form, on an application tab in Customer Service workspace, and as an inline view in the direct knowledge base search.

:::image type="content" source="media/autosuggest-ka-csw.png" alt-text="Screenshot of the suggest-as-you-type feature in action.":::

## Search using favorites

If your administrator has provided [privileges to custom roles](#prerequisites), you can mark the knowledge articles you use most often as favorites to get back to them quickly while you're working on a case. You can mark up to 50 articles as favorites.

1. Select an article from the list of search results.
1. Select the **Favorite** (heart) icon to add the article to your favorites list, or, if it's already a favorite, remove it.

View your favorite articles on the **My favorites** tab. This tab is available in the app side pane, the standalone search control, the form-embedded control, and the reference pane.

The article you most recently marked as a favorite appears first in your favorites list. If an article is deleted, it no longer appears in the list.

Favorite articles are saved in the language in which you viewed them when you marked them as a favorite. The translated version of a favorite article doesn't appear as a favorite.

If you create a major or minor version of a favorite article, then the new version appears as a favorite and the earlier version is removed from the list.

In Customer Service workspace and Omnichannel for Customer Service, when you select a favorite article, it opens on an application tab. In Customer Service Hub, the article opens in a new browser window.

## Search across external search providers

In Customer Service Hub and Customer Service workspace, you can search for files, documents, and articles from data sources outside your Dynamics 365 organization, if your administrator has configured this option. To view those results, select the source in the list under **Knowledge**.

**In Customer Service Hub**

> [!div class=mx-imgBorder]
> ![Screenshot of the agent view of search providers in Customer Service Hub.](media/search-provider-agent.png "Screenshot of the agent view of search providers in Customer Service Hub")

**In Customer Service workspace**

For more information on setting up search providers, see [Set up external search providers](set-up-search-providers.md#set-up-external-search-providers).

## Search across integrated providers in Customer Service Hub and Customer Service workspace

In Customer Service Hub and Customer Service workspace, view and sort search results from [any providers your administrator has added](add-search-provider.md) for you. The name of the search provider the article was pulled from appears on the knowledge article card. If it's truncated, hover over it to view the full name.

1. In the Customer Service workspace site map, select a case and then select **Knowledge search** on the app side pane.
1. Enter the search keyword. You'll see search results along with the search provider.
1. Select **Show more** to view more results.

## View knowledge articles

When you select an article in the search results, where it opens depends on where you searched for it.

### View the knowledge article in an application tab in Customer Service workspace and Omnichannel for Customer Service

In Customer Service workspace and Omnichannel for Customer Service, the article opens in an application tab. You can open up to 10 articles in app tabs.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Screenshot of a knowledge article viewed in an app tab.":::

You can perform the following actions on knowledge articles you view in an app tab:

- Select **Copy URL** to copy the external URL of the article to share with your customer in channels like chat or email.
- If your administrator has turned on [feedback and ratings for knowledge articles](../customerengagement/on-premises/customize/enable-entity-feedback.md#enable-an-entity-for-feedback-and-ratings), you can select the thumbs-up or thumbs-down icon to rate how helpful the article was. If you select the thumbs-down icon, a comment box appears, where you can enter the reason for your rating.

    Customer service agents and customer service managers can create or view feedback based on their role and privileges. Unless your administrator allows it, you can create, view, or edit only your own feedback. Customer service managers and knowledge managers can view your feedback.

### View the knowledge article in the search control in Customer Service Hub

In Customer Service Hub, select an article title. The full article opens inline, right in the search control.

If you see an error like this when you open an article: "Update your origins allow list if any iframe in the article doesn't work or displays error," ask your administrator to [update your origins allow list](configure-knowledge-article-origin-allow-list.md).

You can perform the following actions on knowledge articles you view inline:

- Link it to a record, or, if it's already linked, unlink it.
- [Email it to a customer](email-articles.md#email-a-knowledge-article).

    :::image type="content" source="media/km-inline-article-view.png" alt-text="Screenshot of a knowledge article viewed inline in the search control.":::

- Select the **Copy Link** icon ![Copy knowledge article link button Dynamics 365 Customer Service](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365 Customer Service") to copy the external URL of the article to share with your customer in channels like chat or email.

The copy and email options are available only if the knowledge article is [published on an external portal](set-up-knowledge-management-embedded-knowledge-search.md).

### View the knowledge article on a new window

In Customer Service Hub, in the **Knowledge Search** reference pane, select the pop-out option to view the article on a new window.

:::image type="content" source="media/knowledge-search-pop-out-csh.png" alt-text="View knowledge article in a new window":::

### See also

[Filter knowledge articles](filter-articles.md#filter-knowledge-articles)

[Link and unlink knowledge articles](link-articles.md#link-and-unlink-knowledge-articles)

[Email a knowledge article](email-articles.md#email-a-knowledge-article)

[Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
