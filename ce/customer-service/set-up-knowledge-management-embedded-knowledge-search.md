---
title: Configure knowledge management (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to configure the settings for knowledge management in Dynamics 365 Customer Service
ms.date: 10/04/2021
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

# Configure knowledge management

A comprehensive knowledge base is a key to increased customer satisfaction and improved productivity of users. Give users quick access to the knowledge base by setting up knowledge management in Dynamics 365 Customer Service.

> [!IMPORTANT]
> Usage of [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase as a knowledge management solution has been deprecated. For more information, see [Important changes coming](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
After knowledge management is set up, users will be able to:  
  
- Search for relevant KB articles right from Dynamics 365 Customer Service as they're working on a record.  
  
- See the content of the KB article inline, including images and videos.  
  
- Give timely and consistent information to customers when working on their cases by using actions like opening the article and sharing the information or emailing the article link to customers.   

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, embedded knowledge search in service management is available in the Customer Service Hub. We recommend that you set up knowledge management using embedded knowledge search in the new experience.
  
## Set up knowledge management (Customer Service Hub)
  
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].
  
1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Settings**.
  
2. In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  

  
3. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.  

        Set the toggle to **Yes** to share the knowledge article as a link in the email sent to the customer. Set the toggle to **No** to share the article content inserted in the email body. If you choose **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *https://\<support portal URL>/knowledgebase/article/{kbnum}* 
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
4. Select **Save**.  

## Set up knowledge management settings page manually (unified interface)

> [!NOTE]
> The Embedded Knowledge Search Control entity is deprecated in the web client. You must use the unified interface Knowledge Settings entity.

 To manually go to the unified interface knowledge settings page from your custom app:

1.	Select your custom app.

2.  Select **Open in app designer**.
3.  Select **Site Map**.
4.	Select **Add > Subarea** to create a new sub area for your area.
5. In the **Properties > SUB AREA** section, provide the following information:
  * Type: Select **URL**. 
  * URL: Enter **/main.aspx?pagetype=inlinedialog&name=KnowledgeSettings**

## Set up AI suggestions for article keywords and description (preview)

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

You can enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in knowledge article entity. More information: [Configure AI suggestions for article keywords and description (preview)](configure-ai-suggested-article-keywords-description.md#configure-ai-suggestions-for-article-keywords-and-description-preview)


## Enable feedback control

This option allows users to provide feedback on knowledge articles opened from knowledge search control. 

1. In the Customer Service Hub site map, go to **Service Management** and select **Knowledge Base Management** > **Settings**. 

2. In the **Knowledge Articles Feedback** section, set **Enable users to provide feedback on knowledge articles from search control** to **Yes**.

To know more about how users use this option, see [Submit ratings and feedback for knowledge articles](search-knowledge-articles-csh.md#submit-ratings-and-feedback-for-knowledge-articles).

  
### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
