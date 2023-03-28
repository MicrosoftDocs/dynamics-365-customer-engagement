---
title: Search knowledge articles
description: Learn how to search knowledge articles in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/28/2023
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Search knowledge articles

You can search knowledge articles in Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service to help answer a customer's question or solve an issue.

> [!NOTE]
> Knowledge base search is available in some versions of Dynamics 365 Customer Engagement (on-premises) also. For more information, go to [New features in Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/whats-new#agent-productivity-enhancements-to-knowledge-capabilities).

The article describes the various options you can use to search knowledge articles.

## Prerequisites

To use the various search options discussed in this article, one or more of the following prerequisites apply:

- Your administrator has [enabled Dataverse search](/power-platform/admin/configure-relevance-search-organization). [Learn more about knowledge base search mechanisms](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals).

- Your administrator has configured the following view columns for the **Quick Find View** in the advanced settings:

    - Article Public Number
    - Content  
      The Content field is hidden in the user interface to avoid unintentional deletion of content leading to disruption in the Dataverse search functionality.
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
    
- You have access to knowledge article entities, such as Knowledge Articles, Favorites, Attachments, and Views. Your administrator has granted the **Create**, **Read**, **Write**, **Append**, and **Appendto** privileges to any new custom roles that you've created.

- In Customer Service workspace and Omnichannel for Customer Service, your administrator has enabled the app side pane and knowledge search in Agent experience profiles.

- To open the knowledge pane, you're dealing with a case or conversation. To open the knowledge pane for any other entity, your administrator must enable it in [knowledge management configuration](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management).

## Use the direct knowledge base search in Customer Service Hub

You can search the knowledge base directly, without viewing a case or conversation first, in Customer Service Hub.

1. In the Customer Service Hub site map, under **Knowledge**, select **Knowledge Search**.

1. Enter a keyword in the search box.

 :::image type="content" source="media/search-kb-article.png" alt-text="Search for knowledge article":::

 Legend:
  1. Search box
  1. Visibility and status tags
  1. The number of attachments, likes, and views, and the date the article was most recently updated
  1. Article ID
  1. Info card that displays search term matches from keywords, description, attachments, and any other custom fields.
  1. An attachment that includes the search term in its title or contents. The attachment title appears only when the search term matches the content in the attachment.
  
If your administrator hasn't enabled Dataverse search, the keywords that you enter are used to perform a full-text search of the following knowledge article metadata: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**. If Dataverse search is enabled, your administrator can [select the columns to be searched](/power-platform/admin/configure-relevance-search-organization).

> [!TIP]
> If style tags are visible in the article's content summary, it means that style tags have been used to format the article. Consider offering feedback to the article's author to use inline CSS styling instead of putting styles in style tags.

## Use the reference pane in Customer Service Hub

You can search the knowledge base for related articles in the reference pane when you view a case or conversation in Customer Service Hub. The case title is used as the search term by default. You can enter your own keywords for more relevant results.

1. Open a case or conversation.

1. In the reference pane to the right of the timeline, select the Knowledge search (book) icon.

1. Replace the default search term with your own keyword to fine-tune the search results.

    :::image type="content" source="media/knowledge-search-csh.png" alt-text="View the features of knowledge base search":::

Legend:

1. Filter the list of results
1. Sort the list of results
1. Search box
1. Unlink this article from the current record
1. Opens the article in a new browser window. To view the article in the reference pane, select its title in the search results.
1. Opens a new email so that you can send the article to your customer
1. Rating
1. Number of views the article has received
1. Links the article to the current case or conversation
1. Status and visibility tags for the article
1. Confirmation that the record is linked to a case
1.Info card that displays search term matches from keywords, description, attachments, and any other custom fields
1. Article date
1. Article number

> [!NOTE]
> If the keyword you used matches, the matches are highlighted in yellow, but won't necessarily show up in the first three lines, so you might not see the highlighted text in search results.

## Use the app side pane in Customer Service workspace and Omnichannel for Customer Service

You can search the knowledge base for related articles in the app side pane when you view a case or conversation in Customer Service workspace and Omnichannel for Customer Service. The case title is used as the search term by default. You can enter your own keywords for more relevant results.

These articles are displayed based on Dataverse and full-text search mechanisms. The knowledge articles are applicable for all the knowledge-enabled entities. By default, the full-text search and Dataverse search display 10 results.

1. Open a case or conversation.

2. In the app side pane, select the Knowledge search (book) icon.

3. Replace the default search term with your own keyword to fine-tune the search results.

:::image type="content" source="media/csw-knowledge-tab.png" alt-text="View features in knowledge base search":::

Legend:

1. **Knowledge Search** icon
1. Tag when the article is linked to the entity
1. Article ID
1. The number of times the article has been viewed
1. Info card that displays search term matches from keywords, description, attachments, and any other custom fields
1. Links the article to the current case or conversation. If the article is already linked, select the icon to unlink it from the current case or conversation.
1. Status and visibility tags for the article.
1. Search results across attachments. The attachment title appears only when the search term matches the content in the attachment

Select More options (**&hellip;**) to:

- Select **Email Content** to open a new email, so that you can send the article to your customer.
- In channels other than Voice in Omnichannel for Customer Service, you can also select **Send URL** to paste the article link in the conversation window.

These actions can be performed for only published or expired articles.

## Use smart assist

In Customer Service workspace and Omnichannel for Customer Service, smart assist suggests knowledge articles in real-time based on the ongoing conversation with your customer.

- In the app side pane, select the **Smart assist** (light bulb) icon to view knowledge article suggestions that are related to your case.

## Use suggest-as-you-type

The suggest-as-you-type feature starts suggesting relevant knowledge articles as you type keywords in the search box.

The search phrase is matched against the title of the article, and the matching results appear in a flyout menu. However, if your search phrase consists of more than one keyword, you'll see knowledge article suggestions with a full-string match only. For example, if you search for **Cheque Book Reissue**, you'll see knowledge article suggestions that match the full string **Cheque Book Reissue** and not the individual keywords, such as **Cheque**, **Book**, or **Reissue**.

The maximum number of knowledge articles displayed in the flyout is six. The matched text is highlighted to show the presence of the keyword. When you select the record, the system displays the article inline on the knowledge search control embedded on a form, on an application tab in Customer Service workspace, and as an inline view in the direct knowledge base search.

Your administrator must [enable suggest-as-you-type](set-up-knowledge-management-embedded-knowledge-search.md#enable-the-suggest-as-you-type-option) before you can use it.

:::image type="content" source="media/autosuggest-ka-csw.png" alt-text="Screenshot shows use of the suggest-as-you-type option":::

## Use favorites (preview)

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

You can save the knowledge articles you use most as favorites to access them quickly while you're working on a case. You can save up to 50 articles as favorites.

1. Select an article from the list of search results.
1. Select the **Favorite** (heart) icon to add the article to your favorites.

To remove an article from the favorites list, clear the **Favorite** (heart) icon.

View your saved articles in the **Favorites** tab. The **Favorites** tab is available in the app side pane, standalone search control, form-embedded control, and the reference pane.

The article you last marked as favorite appears first in your Favorites list. If an article has been deleted, it no longer appears in the list. Favorite articles are saved in the language in which you viewed them when you marked them as a favorite.

In Customer Service workspace and Omnichannel for Customer Service, when you select a favorite article, it opens in an app tab. In Customer Service Hub, the article opens in a new browser window.

## Use integrated search providers (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

View the most relevant search results for your query across search providers in a single ranking. With easy sorting, find the knowledge article that best suits your needs while dealing with a customer. The name of the source provider appears on the knowledge article card. You can hover over to get the full name of the source provider, if necessary.

To enable the integrated search provider option, contact your administrator. More information: [Manage integrated search providers (preview)](add-search-provider.md#manage-integrated-search-providers-preview). After your administrator enables the feature, you can view search results for your keywords across your configured search providers in both Customer Service Hub and Customer Service workspace.

To search from Customer Service workspace, for example:

1. In the Customer Service workspace site map, select a case and then select **Knowledge search** on the app side pane.
1. Enter the search keyword. Depending on the keyword, you can see the most relevant search results along with the search provider.
1. Select **Show more** to view more results.

## View knowledge articles

When you select an article in the search results, where it opens depends on where you searched for it.

### View the knowledge article in an application tab

In Customer Service workspace and Omnichannel for Customer Service, the article opens in an application tab. You can open up to 10 articles in the app tabs.

:::image type="content" source="media/csw-article-app-tab.png" alt-text="Knowledge article search pane":::

You can perform the following actions for the knowledge article:

- Copy URL to copy the external URL of the article so you can share it with your customers over channels like chat or email.
- Select the thumbs up or thumbs down icon to rate how helpful the article was. When you select the thumbs down icon, a **Comments** box appears where you can provide additional information and reasons for your rating.  
    Your administrator must [enable knowledge articles for feedback and ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).  
    Customer service agents and customer service managers can create or view feedback based on their role and privileges. Out of the box, you can create, view, or edit your own feedback only. Customer service managers and knowledge managers can view feedback that you submit.

### View the knowledge article inline in the search control

In Customer Service Hub, select an article title to see its full content rendered in the same control. The article opens inline, and you can scroll to read the complete article.

However, if you see an error when you try to open an article, it might be because the link types used in the article aren't a part of the origins allow list. The error message "Update your origins allow list if any iframe in the article doesn't work or displays error" will also appear. You must contact your administrator to update your origins allow list. More information: [Configure the origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md)

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

In Customer Service Hub and Customer Service workspace, you may be able to search for files, documents, and articles from data sources outside your Dynamics 365 organization, if your administrator configured the option. To view those results, select the source from the list under **Knowledge**.

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
