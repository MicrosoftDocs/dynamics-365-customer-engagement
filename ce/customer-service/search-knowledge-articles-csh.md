---
title: Search knowledge articles in the Customer Service Hub in Dynamics 365 for Customer Engagement | Microsoft Docs
description: See how you can effectively search knowledge articles in the Customer Service Hub for Customer Service in Microsoft Dynamics 365 for Customer Engagement
keywords: Knowledge articles; Customer Service Hub; Customer Service; Microsoft Dynamics 365 for Customer Engagement
author: anjgupta
applies_to: Dynamics 365 for Customer Engagement (online)
ms.author: anjgup
manager: shujoshi
ms.date: 02/12/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 1268c4ce-9ffa-4da9-aa92-998a327734c2
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Search for knowledge articles in the Customer Service Hub
 Knowledge base search in the Customer Service Hub app lets you search for relevant knowledge articles to resolve a case. To search for knowledge articles in a case form, select the **Knowledge Base Search** search box in the **Knowledge Base Search control** of the **Related** section.

The search results are automatically populated based on a field your administrator configured in the **Knowledge Base Search** control properties. Out of the box, for a case this is the title of the case record.  

For more information, see [Knowledge Base Search control](#knowledge-base-search-control).

## Knowledge base search control powered by Relevance search 

Knowledge base search in the Customer Service Hub now comes with an improved search functionality. The knowledge base search is now enabled to use Relevance search mechanism in the knowledge base search control area, in addition to the global search area where the Relevance search mechanism was already enabled.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How Relevance Search works](../admin/configure-relevance-search-organization.md#how-relevance-search-works)

Relevance search mechanism uses Azure search service to index and search records.  Relevance search provides improved search functionality like better relevance, highlighted search keyword text, and search within attachments and notes. With Relevance search, you can also configure searchable fields in the knowledge article entity. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure searchable fields for Relevance Search](../admin/configure-relevance-search-organization.md#configure-searchable-fields-for-relevance-search)


> [!NOTE]
> To enable Relevance search for knowledge article entity, see [Enable Relevance Search](../admin/configure-relevance-search-organization.md#enable-relevance-search) and [Select entities for Relevance Search](../admin/configure-relevance-search-organization.md#select-entities-for-relevance-search).</br>
If Relevance search is not enabled for the entity, standard Full-text search is used. 

For more information, see [Understand knowledge base search mechanisms](knowledge-base-search-methods.md).


### Before you begin using Relevance search

Relevance search uses the scoring concepts as defined by Azure search. To be able to search the knowledge base using Relevance search, certain view columns should be mandatorily configured in the Quick Find view columns list. If any of these columns are deleted or missing, the search query displays an error.

> [!NOTE]
> An admin can configure the knowledge article quick find view columns list by navigating to **Settings > Customizations > Entities > Knowledge Article > Views > Quick Find View > View Columns**.

Here are the required view columns:

- Article Public Number
- Title 
- Created On 
- Keywords
- Knowledge Article Views 
- Language
- Major Version Number 
- Minor Version Number 
- Rating
- Status
- Modified On

## Knowledge Base Search control

  ![Knowledge-article-search](media/case-form-search-rp.png "Knowledge article search") 

In the Knowledge Base search box:

- Type a keyword to search for knowledge articles:
   - If Relevance search is not enabled, the keywords that you enter will trigger a search (using Full-text search mechanism) in the following fields of a knowledge article: **Title**, **Content**, **Keywords**, **Description**, and **Article Public Number**.  
   - If Relevance search is enabled, you can configure the fields that you want to be searched upon. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure searchable fields for Relevance Search](../admin/configure-relevance-search-organization.md#configure-searchable-fields-for-relevance-search)

- To see knowledge articles in specific states, use the **State** filter. You can filter search results to see all draft, published, or approved articles.  You can also filter the articles based on language.
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add the Knowledge Base Search control to Main forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-main-forms)

- To choose how you want to sort your search results, select **Sort by**. You can sort the knowledge articles on relevance, number of views, newest first, or oldest first.  

- Select the article title to see its full content. The article opens inline and you can scroll to read the complete article. You can perform various quick actions either in full view mode or in list view mode.

   - To associate the knowledge article with the current case, select the  **Link the KB Article** button ![Select link the knowledge article to the case](../customer-service/media/v8-link-kb-article.png "Select to link the knowledge article to the case").  You can also dissociate the article from the case by choosing the **Unlink the knowledge article from the current record** button ![Unlink knowledge article from current record button in Dynamics 365 for Customer Engagement](../customer-service/media/unlink-article.png "Unlink knowledge article from current record button in Dynamics 365 for Customer Engagement").  

   - To email the article directly, select the **Email** button. To send an external link of the knowledge article in an email, select **Email Link**. 

      An email form opens with the link to the article. The article content is populated in the email body. The fields are automatically populated based on the case and customer details. Add other information as needed, and then on the command bar, select **Send**.

   - To copy the external URL of the article so you can share it with your customers over channels like chat or email, select the **Copy Link** button ![Copy knowledge article link button Dynamics 365 for Customer Engagement](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365 for Customer Engagement").  If you use a browser other than [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], this option isn’t available. 

      > [!NOTE]
      > Copy Link and Email Link options are available only if your organization is using an external portal to publish the knowledge articles and your administrator has selected the **Use an external portal** check box in the **Embedded Knowledge search** setup.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use embedded knowledge search to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md).

  > [!IMPORTANT]
  > Copy Link, Email Link, and Email options can be used only for published and expired articles. 

> [!IMPORTANT]
>  Knowledge base search in the Customer Service Hub shows relevant knowledge articles only when your organization is set up to use the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management capability. For more information, talk to your administrator. 



### See also

[Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md)

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

[Understand knowledge base search mechanisms](knowledge-base-search-methods.md)

