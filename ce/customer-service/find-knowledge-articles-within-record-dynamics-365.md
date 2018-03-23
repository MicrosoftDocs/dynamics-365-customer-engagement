---
title: Find knowledge articles from within a record (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to find knowledge articles from within a record in Dynamics 365 for Customer Service
keywords: Find knowledge articles; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: sakudes
ms.date: 09/15/2017
ms.topic: article
ms.service: crm-online
ms.assetid: 8dc8e53f-984d-4c5c-98aa-4396786a16e3
---

# Find knowledge articles from within a record

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

For any customer service team, it’s important to give customers the right information at the right time. After your administrator sets up knowledge management for your organization, you can search for articles while working on a customer’s case or other records in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], give customers accurate and consistent information, and also redirect frequently-asked questions. With rich knowledge at your fingertips, you’re likely to spend less time finding information, potentially reducing issue handling time and increasing customer satisfaction.  
  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] supports two knowledge management solutions:  
  
-   Native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management: This option is available for both [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] on-premises users. For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organizations, the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge solution is only available if you've installed the [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)]. For on-premises [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organizations, this feature is only available if you've updated to CRM 2016.  
  
- [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base: This option is available only for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users. <!--This feature was introduced in [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)].-->  
  
> [!IMPORTANT]
> [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base as a knowledge management solution has been deprecated for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. For more information, see [Important changes coming](https://docs.microsoft.com/en-us/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
 Depending on the knowledge solution your organization chooses, you’ll see knowledge articles residing either in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] or in [!INCLUDE[pn_parature](../includes/pn-parature.md)].  
  
 The search options that you get while you search for knowledge articles will differ based on the knowledge management solution your organization is using.  
  
1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  
  
2.  Open a case record.  
  
3.  On the Activity wall, click **KB Records**.  
  
     You’ll see a list of suggested knowledge articles based on the case title. You’ll also see a short description of the article along with its rating and number of views the article had.  
  
     If an article is still in draft or is expired, you’ll see its status before the title, so you know if you really want to share the article with the customer.  
  
    > [!IMPORTANT]
    > - If your organization uses the [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base, the search results are filtered and shown based on the default language of your [!INCLUDE[pn_parature](../includes/pn-parature.md)] department. To view or edit the default language of your [!INCLUDE[pn_parature](../includes/pn-parature.md)] department, in Parature Service Desk, go to **Setup** > **Department Management** > **Department Profile**.  
    > - If you see a message that knowledge management hasn’t been set up, ask your system administrator to set it up for you.  
  
4.  If you want to search the knowledge articles for a different keyword, start typing the keyword in the **search** box and you’ll start seeing matching results as you type.  
  
5.  To sort articles in the search results, in the **Select how to sort results** drop-down list, select a sort order. If your organization is using the [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base, you can sort the search results based on relevance, rating, number of views, or modified date.  
  
     If your organization is using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, the option to sort results based on rating is not available.  
  
 ![Option to sort knowledge article results in Dynamics 365](../customer-service/media/sort-article-search-results.png "Option to sort knowledge article results in Dynamics 365")  
  
6.  To filter the search results, in the **Filter Result By** drop-down list, select a filter.  
  
     If you’re using the [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base, you can filter the search results to show all articles, all draft articles, or all published articles.  
  
 ![Option to filter knowledge article search results](../customer-service/media/filter-article-search-results.png "Option to filter knowledge article search results")  
  
   If you’re using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, you can filter the search results to show all draft articles, all approved articles, or all published articles.  
  
7.  To see the full content of the article, select the article name link.  
  
     You’ll be able to see the full content of the article along with images and videos, if the article has any.  
  
8.  You can take the following actions on the search results:  
  
    1.  To associate a knowledge article with the current case, select a knowledge article, and then click the **Link the KB article to the current case** button ![Link knowledge article to current case button in Dynamics 365](../customer-service/media/link-article-current-record.png "Link knowledge article to current case button in Dynamics 365"). [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] adds the associated knowledge article to the **Associated Knowledge Base records** section. This association helps customer service managers determine which knowledge articles were effective in resolving cases.  
  
         You can also choose to disassociate the article from the case by clicking the **Unlink the KB article from the current record** button ![Unlink knowledge article from current record button in Dynamics 365](../customer-service/media/unlink-article.png "Unlink knowledge article from current record button in Dynamics 365").  
  
    2.  To copy the external URL of the article so you can share it with your customers over channels like chat or email, click the **Copy Link** button ![Copy knowledge article link button Dynamics 365](../customer-service/media/copy-link-button.png "Copy knowledge article link button Dynamics 365"). This option is available only if you are using [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
        > [!NOTE]
        >  If you don’t see a URL when you try to paste it, it could be because the article is still in draft state or is expired.  
  
         If you’re using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, the Copy Link option is available only for published articles.  
  
    3.  To associate an article with a case and share the article link with the customer through email, click the **Link the KB article to the case and email the link to the customer** button ![Link knowledge article to case and email link to article button in Dynamics 365](../customer-service/media/email-article-link.png "Link knowledge article to case and email link to article button in Dynamics 365"). An email form opens with the **To** field automatically filled with the customer’s information and the link added to the email body. Fill in any additional details, and then click **Send**.  
  
         This action also associates the knowledge article with the case automatically.  
  
         If you’re using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, the **Email Link** option is available only for published articles.  
  
         For published articles, an external link is copied to the email body.  
  
         If you’re using the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management solution, and if your administrator has not selected the **Use an external portal** option when setting up knowledge management, the **Email Link** option will not be available.  
  
         If you’re using the native [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledge base, and if the article is a draft, an internal Parature Service Desk link will be copied into the email. The customer may not be able to view this knowledge article.  
  
    4.  To associate an article with a case and share the article content with the customer through email, click the **Link Article to the Case and Email Content** button ![Link article to case and email content button in Dynamics 365](../customer-service/media/v8-1-link-article-case-and-email-content.png "Link article to case and email content button in Dynamics 365"). An email form opens with the **To** field automatically filled with the customer’s information and the knowledge article content added to the email body. Fill in any additional details, and then click **Send**.  
  
    5.  To open the article in a new window, click the **Pop Out** button ![Pop out knowledge article in a new window button in Dynamics 365](../customer-service/media/pop-out-article.png "Pop out knowledge article in a new window button in Dynamics 365").  
  
### See also  
 [Create and manage a case (Customer Service Hub)](user-guide-customer-service-hub.md) <br>
 [Create and manage a case (Customer Service)](user-guide-customer-service.md)
