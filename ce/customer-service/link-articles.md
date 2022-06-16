---
title: Search knowledge articles in Dynamics 365 Customer Service | Microsoft Docs
description: Learn how you can search knowledge articles in Dynamics 365 Customer Service.
ms.date: 06/16/2022
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

# Search for knowledge articles

You can search for knowledge articles through Customer Service workspace or Customer Service Hub.

## Prerequisites

### Customer Service workspace

- The productivity pane and knowledge search must be enabled in the app profile manager.
- The anchor tab should be a case or conversation for the knowledge search pane to be displayed.
- Dataverse search must be enabled.

### Customer Service Hub

Dataverse search must be enabled. The knowledge base search uses the Dataverse search mechanism in the knowledge base search control area. More information: [Knowledge base search control powered by Dataverse search](search-knowledge-articles-csh.md#knowledge-base-search-control-powered-by-dataverse-search). Before you begin using Dataverse search, your administrator must configure certain view columns in the Quick Find view columns list. More information: [Before you begin using Dataverse Search](search-knowledge-articles-csh.md#before-you-begin-using-dataverse-search).

## Use the independent knowledge base search

In the Customer Service Hub site map, you can perform independent knowledge base searches outside of cases using the **Knowledge Search** option in the **Knowledge** area. This functionality performs like a knowledge search hub, where you can do the following:

- View an article 
- Send an article pop out 
- Copy and send article URLs (when preconfigured). To configure the ability to copy and send article URLs, see [Configure knowledge base article URLs](#configure-knowledge-base-article-urls).

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

- If Dataverse search is not enabled, the keywords that you enter will initiate a search (using the Full-text search mechanism) in the following fields of a knowledge article: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**.

  > [!NOTE]
  > If there's a style tag with CSS styles at the top of the article, the summary of the content in the knowledge search results list will contain style tags. Use inline CSS styling instead of putting styles in style tags.

- If Dataverse search is enabled, you can configure the fields  that you want to be searched for. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure searchable fields for Dataverse Search](/power-platform/admin/configure-relevance-search-organization) 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add the Knowledge Base Search control to Main forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-main-forms) 

## Use the Knowledge Search pane to search articles related to a case

### How to search in Customer Service workspace

In Customer Service workspace, for a case, when you select the **Knowledge search** tab in the productivity pane, knowledge articles that match the case title are displayed on the **Knowledge search** pane. These articles are displayed based on relevance and full-text search mechanisms.

The knowledge articles are applicable for all knowledge-enabled entities. By default, the full-text search displays 10 results and Dataverse search displays 50 results. You can also use the search box to enter keywords and search for articles if those displayed by default are not relevant.

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

### How to search in Customer Service Hub

In Customer Service Hub, for a case, when you select the **Knowledge** option in the **Related** section, the **Knowledge** tab shows you articles arranged in a single stream. Searching, sorting, and filtering the articles in the search control is faster and more responsive, with improvements to article viewability and usability. The Knowledge Base Search capability is also available in Dynamics 365 Customer Engagement (on-premises) 9.1. More information: [New features in Dynamics 365 Customer Engagement (on-premises)](../customerengagement/on-premises/whats-new.md#agent-productivity-enhancements-to-knowledge-capabilities)

On the **Knowledge** tab, and you can view the following:

  > [!div class=mx-imgBorder]
  > ![Knowledge-article-search.](media/knowledge-base-search-details.png "View the features in knowledge base search")

  1. Knowledge
  2. Open filter pane
  3. Sort search results by
  4. Search knowledge articles
  5. Link this article to the current record (unlink will be displayed when the article is already linked to a record)
  6. Copy
  7. Displays Pop out and Email Content 
  8. Link this article to a record and send via email
  9. Rating
  10. Unlink an article that is currently linked to a case
  11. Number of views the article has received
  12. Article date
  13. Confirmation that the record is linked to a case
  14. Status and visibility tags for the article

> [!NOTE]
> If the keyword you used matches, the matches are highlighted in yellow, but won't necessarily show up in the first three lines, so you might not see the highlighted text in search results.

In the knowledge base search control, you can do the following:
- Search for knowledge articles
- Filter articles using multiple filter options
- Sort knowledge articles
- Link and unlink a knowledge article to a record
- Email a knowledge article
- View the knowledge article inline in the search control

## Use smart assist to search for knowledge articles
Smart assist provides real-time knowledge article suggestions depending on the ongoing conversations with your customer. The smart assist option appears on the productivity pane.

In Customer Service workspace, select the **Smart assist** option on the productivity pane to see knowledge article suggestions related to your case.

## Use portal search

Use the portal search to access information through simple queries. You can search for your knowledge articles by selecting Knowledge Base from your portal. More information: [Search the knowledge base on portals](knowledge-base-search-methods.md#search-the-knowledge-base-on-portals)

## How to refine your search


### View the knowledge article on the application tab

In Customer Service workspace, select an article title to view the complete article on an application tab. You can view up to 10 articles on the application tab. 

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

In this view mode, you can perform actions such as linking the knowledge article to a record or emailing the knowledge article to a customer. To learn more about sending the knowledge articles via email, go to [Email the knowledge article](#email-the-knowledge-article).

  > [!div class=mx-imgBorder]
  > ![Knowledge article inline view.](media/km-inline-article-view.png "Knowledge article inline view")

> [!NOTE]
> - Select the **Copy Link** button ![Copy knowledge article link button Dynamics 365 Customer Service](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365 Customer Service") to copy the external URL of the article so you can share it with your customers over channels like chat or email. If you use a browser other than [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], this option isn't available. 
>
> - The **Copy Link** and **Email Link** options are available only if your organization is using an external portal to publish the knowledge articles and your administrator selected the **Use an external portal** checkbox during embedded knowledge search setup. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md)
>
> - The **Copy Link**, **Email Link**, and **Email** options can be used only for published or expired articles.

### Filter knowledge articles

With the help of text and visual filters, you can filter the knowledge articles.

:::image type="content" source="media/csw-article-filter.png" alt-text="Filter knowledge articles":::

When you select the filter icon, you can see the **Filter by** menu where you can filter the items based on the following categories.

  | Category | Sub-category |
  |-----------------------|-----------------------|
  | Status | <ul> <li> Approved </li> <li> Published </li> <li> Scheduled </li> </ul> |
  | Visibility | <ul> <li> Internal </li> <li> External </li> </ul> |
  | Modified On | <ul> <li> Last 7 days </li> <li> Last 30 days </li> <li> Last 6 months </li> <li> Last year </li> <li> All </li> </ul> |
  | Language | <ul> <li> List of languages </li> </ul> **Note:** The language list is based on the articles that are present in those languages. For example, there are a total of 50 articles in five different languages such as French, English, Japanese, Spanish, and Danish. The language filter will show only these five languages. |
  |||

### Personalize your knowledge search article filters

If your administrator has configured knowledge filter personalization settings, as an agent, you can select the filters you want to use.

Agents can do the following:
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

### Link and unlink the knowledge article to a record

When configured, you can link an article to a case. You can associate and dissociate the knowledge article with a record.

:::image type="content" source="media/csw-link-unlink-km.png" alt-text="Link or unlink an article to a case":::

By default, the articles aren't linked to the case. When you select to link the article to the case, the link icon changes, and **Linked to Case** is displayed for the article.

### Email options

You can also share the knowledge article link or knowledge article content through mail by selecting the ellipsis next to an article.

:::image type="content" source="media/csw-email-url.png" alt-text="Email options for knowledge artcile":::

- **Copy URL**: You can copy the URL to share the knowledge article link.
- **Email URL:** The new email form opens with the link to the article in the mailbox.
- **Email Content:** The article content is populated in the mail body. The fields are automatically populated based on the case and customer details.

### Email the knowledge article

Use the **Email** button to send the knowledge article via mail. When you select the **Email** button, first, the knowledge article is linked to the current case record. Simultaneously, an email form opens with the link to the article. The article content is populated in the email body. The fields are automatically populated based on the case and customer details. Add other information as needed, and then on the command bar, select **Send**.

  > [!div class=mx-imgBorder]
  > ![Email knowledge article.](media/km-email.png "Email knowledge article")


You can perform these actions for only published or expired articles.

### Linked knowledge articles subgrid

The linked knowledge article subgrid is available for an entity, such as a case or account, only if your system administrator has added the subgrid to the entity form. The knowledge article subgrid displays the knowledge articles that have been linked with the entity. Some of the options available are as follows:

- Add a knowledge article
- Select and edit an article's content
- Sort
- Bulk operations
 
You can also edit a knowledge article by double-clicking it in the linked articles list.

To link the knowledge article to an entity, you need to do the following steps. For the sake of this example, let us consider the entity as Accounts.

1. In the Customer Service Hub site map, go to **Customers** > **Accounts**.

2. Select any active account from the list of accounts.

3. On the **Summary** tab, scroll down to the **Linked Knowledge Articles** subgrid.

  > [!NOTE]
  > The name of the subgrid can vary depending on the customizations your organization has made.

4. Select **More commands** (⁝), and then select **Add Existing Knowledge Article**.

   > [!div class=mx-imgBorder]
   > ![Add an existing knowledge article.](media/add-existing-knowledge-article.png "Add an existing knowledge article")

5. Search for the knowledge article that you want to link, and select **Link.**

   > [!div class=mx-imgBorder]
   > ![Search for a knowledge article to link to an entity.](media/search-related-article.png "Search for a related knowledge article to link to an entity")

6. Select **Done**. The article will appear in the **Linked Knowledge Articles** subgrid.

### Configure knowledge base article URLs

Knowledge articles can be configured with their portal URLs, and then agents can copy and share the URL links.

> [!NOTE]
> Before you can configure knowledge articles with their own URLs, you must create a portal using your domain name. For information on how to create a portal, see [Create a portal in an environment containing customer engagement apps](/powerapps/maker/portals/create-dynamics-portal).

You can configure a knowledge base article URL in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to the **Support portal connection** section.

### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  1. On the **Knowledge** page, go to the **Portal** section and select **Manage**. The **Portal** page appears.
  1. On the **Portal** page, go to the **Support portal connection** section.

### [Customer Service Hub](#tab/customerservicehub)

  1. In the site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**.
  1. On the **Settings** page, go to the **Support portal connection** section.

---

2. Set the **Use an external portal** toggle to **Yes**.

3. In the **URL format** field, enter the URL name.

 4. Select **Save**.

The knowledge base article link is now active and can be copied and shared.



### View auto-filtered results

As a customer service agent, to view the most relevant results, you can have knowledge articles automatically filtered based on the case data. This helps with identifying the most relevant articles so that you can resolve customer queries quickly and accurately. You can also disable the auto-filter results and search the entire knowledge base.  

An administrator or system customizer must configure this option for you. More information: [Configure automatic filtering](add-knowledge-base-search-control-forms.md#configure-automatic-filtering-for-the-web-client)

To view the auto-filtered results:

1. Search knowledge articles from the related section of the case. More information: [Search for knowledge articles in the Customer Service Hub](#search-for-knowledge-articles-in-the-customer-service-hub)

2. The articles are automatically filtered and displayed based on case data.

3. If you want to disable the automatic filtering option and search the entire knowledge base for articles, deselect **Auto-filter results**.  

    > [!NOTE]
    > Your administrator or system customizer must enable **Users can turn off automatic filtering** option in order for you to see the **Auto-filter results** option. If the **Users can turn off automatic filtering** option is not enabled, you'll always see the auto-filtered results. More information: [Configure automatic filtering](add-knowledge-base-search-control-forms.md#configure-automatic-filtering-for-the-web-client)

Let’s understand this in detail with the help of an example.

In the following illustration, the case subject is **Xbox**. If automatic filtering is configured on the case subject, with the **Auto filter results** checkbox selected, only those knowledge articles whose subject is **Xbox** are displayed. Other articles are automatically filtered out, as shown in the following image.

![Select Auto filter results.](media/ka-select-auto-filter-results.png "Select Auto filter results")   
  
However, if the **Auto-filter results** checkbox isn't selected, you can see more articles that aren't related to the subject. These are the results from the entire knowledge base.

![Deselect Auto-filter results.](media/ka-deselect-auto-filter-results.png "Deselect Auto-filter results")

### View search results from external sources

In Customer Service Hub, if your administrator has configured the ability for you to search for files, documents, or articles from data sources outside of your current Dynamics 365 organization, you can view those results by selecting the provider from the drop-down list under **Knowledge**.

   > [!div class=mx-imgBorder]
   > ![Agent view of search providers.](media/search-provider-agent.png "Agent view of available search providers")

For more information on setting up search providers, see [Set up a search provider in Customer Service Hub](set-up-search-providers.md).
    
### Submit ratings and feedback for knowledge articles

You can easily provide feedback on knowledge articles with the help of knowledge article rating. Knowledge article rating lets you provide feedback on knowledge articles within the context of case resolution. Knowledge managers can capture and review the feedback on the articles to improve and maintain a healthy knowledge base.

When you are working on a case and refer to an article from the **Knowledge** tab, you'll be presented with an option to rate whether the article is helpful and provides relevant information to assist customers quickly. If you think it’s not helpful, you can rate the article accordingly and provide comments on how it can be improved.

> [!NOTE]
> - Ensure that the knowledge article entity is enabled for feedback. To learn more, see [Enable an entity for feedback/ratings](/dynamics365/customer-engagement/customize/enable-entity-feedback).
> - Customer service agents and customer service managers can create, or view feedbacks based on their role and privileges on feedback entity. Out of the box, customer service agents can create, view, or edit their own feedback only. Customer service managers or knowledge managers can view feedback submitted by all agents.

1. Open an article from search results to read it.

2. You can rate a knowledge article and submit feedback. 

    You can provide your feedback on the article, whether it is helpful or not, by selecting the **Thumbs up** or **Thumbs down** button.    

    ![Provide feedback.](media/ka-rating-feedback-thubms-up-down.png "Provide feedback")

    If the article is not helpful, you can also provide your comments in the comment box on how the article can be improved. The comment box is displayed when you select **Thumbs down**.

    ![Provide comments.](media/ka-rating-feedback-provide-comments.png "Provide comments")

To set up the feedback control, see [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management).

### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)  
[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)  
[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
