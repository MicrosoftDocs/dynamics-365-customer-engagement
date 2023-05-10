---
title: Search knowledge articles
description: Learn how to search for and view knowledge articles in Dynamics 365 Customer Service.
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

Search and view knowledge articles to help answer a customer's question or solve an issue.

Knowledge base search is available in Customer Service Hub, Customer Service workspace, Omnichannel for Customer Service, and some versions of [Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/whats-new#agent-productivity-enhancements-to-knowledge-capabilities). Customers can search your knowledge base on their own if your organization has provided a [self-service portal](knowledge-base-search-methods.md).

## Prerequisites

- Your administrator has [turned on Dataverse search](/power-platform/admin/configure-relevance-search-organization).

- Your administrator has set up the following columns in the **Quick Find View**:<!-- EDITOR'S NOTE: Does an agent need to know this? -->

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
<!-- EDITOR'S NOTE: For all these prereqs, I recommend keeping only those the agent really needs to know about and has some control over. Otherwise, I'd say something like, "Hey, if any of this doesn't work the way we say it should, your knowledge search may not be set up the right way. Go talk to your admin." -->

## Tips for search results

If a keyword you enter matches content in the knowledge base, the matching words are highlighted in yellow in the search results. Matches don't necessarily appear in the search results, which only show the first few lines or words of an article.

If style tags are visible in an article's content summary, it means that style tags were used to format the article. Consider offering feedback to the article's author to use inline CSS styling instead.

## Search the knowledge base directly in Customer Service Hub

You can search the knowledge base directly, without viewing a case or conversation first, in Customer Service Hub.

1. In Customer Service Hub, under **Knowledge**, select **Knowledge Search**.

1. Enter a keyword in the search box.

    :::image type="content" source="media/search-kb-article.png" alt-text="Screenshot of knowledge search in Customer Service Hub.":::<!-- EDITOR'S NOTE: Please revise the numbered callouts in the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

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

Legend:<!-- EDITOR'S NOTE: Some items are identified separately in this screenshot that were lumped together in the previous one. Can you please treat them the same way for better consistency? -->

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

You can search the knowledge base for related articles when you view a case or conversation in Customer Service workspace and Omnichannel for Customer Service. By default, a successful search displays up to 10 results.

1. In Customer Service workspace or Omnichannel for Customer Service, open a case or conversation.

2. In the app side pane, select the **Knowledge search** (book) icon.

3. The case title is used as the search term by default, but you can enter your own keywords to get more relevant results.

    :::image type="content" source="media/csw-knowledge-tab.png" alt-text="Screenshot of knowledge search in the app side pane.":::<!-- EDITOR'S NOTE: Please revise the numbered callouts in the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

Legend:<!-- EDITOR'S NOTE: Some items are identified differently in this screenshot than in the previous ones, and the search box isn't called out at all. Can you please treat them the same way in all the screenshots for better consistency? -->

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

You can perform these actions only on published or expired articles.<!-- EDITOR'S NOTE: Expired articles? -->

## See suggested articles during a conversation in Customer Service workspace and Omnichannel for Customer Service

In Customer Service workspace and Omnichannel for Customer Service, smart assist suggests knowledge articles in real-time based on your ongoing conversation with your customer.

In the app side pane, select the **Smart assist** (light bulb) icon to view suggestions of knowledge articles that are related to your conversation.

## Save time searching with suggest-as-you-type

If your administrator has [turned on suggest-as-you-type](set-up-knowledge-management-embedded-knowledge-search.md#enable-the-suggest-as-you-type-option), the system suggests related knowledge articles as you type in the search box.

Your search term is matched against article titles. If your search term consists of more than one word, only titles that contain the full string, not individual words, are matched. For example, if you search for **Cheque Book Reissue**, articles with "Cheque Book Reissue" in the title are returned. Articles with the individual words "Cheque," "Book," or "Reissue" in the title aren't.

Suggest-as-you-type suggests up to six knowledge articles. Text that matches your keyword is highlighted in yellow.

:::image type="content" source="media/autosuggest-ka-csw.png" alt-text="Screenshot of the suggest-as-you-type feature in action.":::<!-- EDITOR'S NOTE: Please crop and add callouts to the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

## Find frequently used articles quickly

If your administrator has provided [privileges to custom roles](#prerequisites), you can mark the knowledge articles you use most often as favorites to get back to them quickly while you're working on a case. You can mark up to 50 articles as favorites.

1. Select an article from the list of search results.
1. Select the **Favorite** (heart) icon to add the article to your favorites list, or, if it's already a favorite, remove it.

View your saved articles in the **My favorites** tab. The **My favorites** tab is available in the app side pane, standalone search control, form-embedded control, and the reference pane.

The article you most recently marked as a favorite appears first in your favorites list. If an article is deleted, it no longer appears in the list.

Favorite articles are saved in the language in which you viewed them when you marked them as a favorite. The translated version of a favorite article doesn't appear as a favorite.

If you create a major or minor version of a favorite article, then the new version appears as a favorite and the earlier version is removed from the list.

In Customer Service workspace and Omnichannel for Customer Service, when you select a favorite article, it opens in an app tab. In Customer Service Hub, the article opens in a new browser window.

## Search across integrated providers in Customer Service Hub and Customer Service workspace

In Customer Service Hub and Customer Service workspace, view and sort search results from [any providers your administrator has added](add-search-provider.md) for you. The name of the search provider the article was pulled from appears on the knowledge article card. If it's truncated, hover over it to view the full name.

:::image type="content" source="media/search-provider-agent.png" alt-text="Screenshot of search results from various providers.":::<!-- EDITOR'S NOTE: I moved this screenshot from the section on viewing search results from external providers. If this doesn't show the right information, please replace it with one that does. I think this section would benefit from including a screenshot. -->

## View knowledge articles

When you select an article in the search results, where it opens depends on where you searched for it.

### View the knowledge article in an application tab in Customer Service workspace and Omnichannel for Customer Service

In Customer Service workspace and Omnichannel for Customer Service, the article opens in an application tab. You can open up to 10 articles in app tabs.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Screenshot of a knowledge article viewed in an app tab.":::<!-- EDITOR'S NOTE: Please crop and highlight the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

You can perform the following actions on knowledge articles you view in an app tab:

- Select **Copy URL** to copy the external URL of the article to share with your customer in channels like chat or email.
- If your administrator has turned on [feedback and ratings for knowledge articles](/dynamics365/customer-engagement/customize/enable-entity-feedback), you can select the thumbs-up or thumbs-down icon to rate how helpful the article was. If you select the thumbs-down icon, a comment box appears, where you can enter the reason for your rating.

    Customer service agents and customer service managers can create or view feedback based on their role and privileges. Unless your administrator allows it, you can create, view, or edit only your own feedback. Customer service managers and knowledge managers can view your feedback.

### View the knowledge article in the search control in Customer Service Hub

In Customer Service Hub, select an article title. The full article opens inline, right in the search control.

If you see an error like this when you open an article: "Update your origins allow list if any iframe in the article doesn't work or displays error," ask your administrator to [update your origins allow list](configure-knowledge-article-origin-allow-list.md).

You can perform the following actions on knowledge articles you view inline:

- Link it to a record, or, if it's already linked, unlink it.
- [Email it to a customer](email-articles.md#email-a-knowledge-article).

    :::image type="content" source="media/km-inline-article-view.png" alt-text="Screenshot of a knowledge article viewed inline in the search control.":::

- Select the **Copy Link** icon ![Copy knowledge article link button Dynamics 365 Customer Service](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365 Customer Service") to copy the external URL of the article to share with your customer in channels like chat or email. If you use a browser other than Internet Explorer, this option isn't available.<!-- EDITOR'S NOTE: Internet Explorer, really? Can you please confirm this shouldn't be Edge (and maybe Chrome)? -->

The copy and email options are available only if the knowledge article is [published on an external portal](set-up-knowledge-management-embedded-knowledge-search.md).

The **Copy Link**, **Email Link**, and **Email** actions can be used only on published or expired articles.<!-- EDITOR'S NOTE: Expired articles? -->

### View the knowledge article in a new window in Customer Service Hub

In the **Knowledge Search** reference pane in Customer Service Hub, select the pop-out icon to open the article in a new window.

:::image type="content" source="media/knowledge-search-pop-out-csh.png" alt-text="Screenshot of the reference pane in Customer Service Hub, with the pop-out icon highlighted.":::<!-- EDITOR'S NOTE: Please crop the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main) and highlight the pop-out icon.-->

### See also

[Filter knowledge articles](filter-articles.md#filter-knowledge-articles)

[Link and unlink knowledge articles](link-articles.md#link-and-unlink-knowledge-articles)

[Email a knowledge article](email-articles.md#email-a-knowledge-article)

[Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
