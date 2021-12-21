---
title: Configure knowledge management (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to configure the settings for knowledge management in Dynamics 365 Customer Service
ms.date: 12/03/2021
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
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-knowledgearticle
 - D365-UI-form
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement 
---

# Configure knowledge management

## Introduction

A comprehensive knowledge base is a key to increased customer satisfaction and improved productivity of users. Give users quick access to the knowledge base by setting up knowledge management in Dynamics 365 Customer Service.

> [!IMPORTANT]
> Usage of [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase as a knowledge management solution has been deprecated. For more information, see [Important changes coming](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
After knowledge management is set up, users will be able to:  
  
- Search for relevant knowledge base articles from Customer Service while they're working on a record.  
  
- Set up a search logic and search filters to get only the required knowledge articles, thereby providing timely and consistent information to customers while working on their cases.

- Use smart assist to receive AI suggestions on related knowledge articles and similar cases.

- See the content of the knowledge base article inline, including images and videos.

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, embedded knowledge search in service management is available in the Customer Service Hub. We recommend that you set up knowledge management using embedded knowledge search in the new experience.

## Setup overview

You can set up knowledge management on the Customer Service Admin Center, Customer Service Hub, or manually for a model-driven app.

- [Set up knowledge management](#set-up-knowledge-management)
- [Set up knowledge management settings page manually for a model-driven app](#set-up-knowledge-management-settings-page-manually-for-a-model-driven-app)

After you have configured knowledge management on your app, you must also set up the various other aspects of knowledge management, based on your organizational requirements, such as:

- [Create and manage categories](create-manage-categories.md#create-and-manage-categories)
- [Knowledge article templates](create-templates-knowledge-article.md#knowledge-article-templates)
- [Set up AI suggestions for article keywords and description](#set-up-ai-suggestions-for-article-keywords-and-description)
- [Set up a search provider in Customer Service Hub](set-up-search-providers.md#set-up-a-search-provider-in-customer-service-hub)

## Set up knowledge management
  
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].

You can set up knowledge management either on the Customer Service Hub or on Customer Service admin center (preview) app. Depending on your app, perform the following steps:
  
1. Go to the **Settings** page.

### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

> [!IMPORTANT]
> The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

  1. On the Customer Service admin center (preview) site map, select **Knowledge** in **Agent experience**.
  
  2. On the **Knowledge** page, do the following:
     * In the **Record types** section, select **Manage**.
      * On the **Record Types** page, add or edit the record types for which you want to turn on knowledge management.
     * In the **General Settings** section, select **Manage**.
      * On the **General Settings** page, in **Search results display count**, select the display count from the dropdown.
      * In the **Feedback** section, set the **Enable feedback** toggle to Yes. To learn more about how users use this option, see [Submit ratings and feedback for knowledge articles](search-knowledge-articles-csh.md#submit-ratings-and-feedback-for-knowledge-articles).
      * In the Filters section, set the **Enable search filters** toggle to Yes. If you want to allow agents to personalize the search filters, then set the **Allow agent to personalize the knowledge articles search filters** toggle to Yes.
      * In the **Authoring language** section, set the **Enable default knowledge authoring language** for your users to Yes.
        * If you want to select a default knowledge authoring language for your organization, then select the **Organization’s UI language** radio button. 
        *	If you want to use the organizations’ s UI language as the default knowledge authoring language, select the **Other language** radio button, and then select a language from the **Language** dropdown.
        *	If you also want to allow users to set their default knowledge authoring language, then set the **Allow users to set default knowledge authoring language** toggle to Yes. More information: Set a default knowledge article authoring language for your organization.
      *	In the **Origins allow list** section, add your origins links to the **Add origin links** field. More information: [Configure origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md#configure-origins-allow-list-for-knowledge-articles)
      *	In the **Knowledge search logic** section, set the **Set search mode as all** toggle to Yes. More information: [Set up knowledge search logic](#set-up-knowledge-search-logic)
	    * Select **Save**.
    * In the **Filters** section, select **Manage**.
    * In the **Portals** section, select **Manage**.
        * On the **Portals** page, 
            * In the **Support portal connection** section, do the following to share knowledge article as URLs:
                *	Set the **Use an external portal** toggle to Yes, to integrate an external portal to publish knowledge articles.
                * **URL Format**: Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: https://<support portal URL>/kb/{kbnum}. The placeholder "{kbnum}" is replaced by an actual knowledge article number.
        *	In the **Sync knowledge article attachments to portal** section, set the **Sync attachments to the portal** toggle to Yes. More information: [Update knowledge article attachments for portal](customer-service-hub-user-guide-knowledge-article.md#update-knowledge-article-attachments-for-portal)

### [Customer Service Hub](#tab/customerservicehub)

1. On the Customer Service Hub site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

2. On the **Settings** page, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  

3. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal to publish knowledge articles. If your organization uses one, select this check box.  

        Set the toggle to **Yes** to share the knowledge article as a link in the email sent to the customer. Set the toggle to **No** to share the article content inserted in the email body. If you select **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format:
        </br> </br> *https://\<support portal URL>/knowledgebase/article/{kbnum}* 
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
4. In the **Knowledge articles feedback** section, set the **Enable feedback** toggle to **Yes**. To learn more about how users use this option, see [Submit ratings and feedback for knowledge articles](search-knowledge-articles-csh.md#submit-ratings-and-feedback-for-knowledge-articles).

5. In the **Knowledge articles search filters** section, set the **Enable search filters** toggle to **Yes**. If you want to allow agents to personalize the search filters, then set the **Allow agents to personalize the knowledge articles search filters** toggle to **Yes**.

6. In the **Knowledge articles authoring language** section, set the **Set default knowledge authoring language for your users** to **Yes**.
   * If you want to set the default knowledge authoring language for your organization, then search and select a language in the **Select a language** field and then set the **Use organization’s UI language** toggle to **Yes**.
   * If you also want to allow users to set their default knowledge authoring language in the personalization option, then set the **​Allow users to set default knowledge authoring language** toggle to **Yes**​. More information: [Set a default knowledge article authoring language for your organization](set-knowledge-article-authoring-language.md#set-a-default-knowledge-article-authoring-language-for-your-organization).

7. In the **Sync knowledge article attachments to portal** section, set the **Sync attachments to portal** toggle to **Yes**. More information: [Update knowledge article attachments for portal](customer-service-hub-user-guide-knowledge-article.md#update-knowledge-article-attachments-for-portal).

8. In the **Origins allow list** section, add your origins links to the **Add origin links** field. More information: [Configure origins allow list for knowledge articles](configure-knowledge-article-origin-allow-list.md#configure-origins-allow-list-for-knowledge-articles).

9.  In the **Knowledge search logic** section, set the **Set search mode as all** toggle to **Yes**. More information: [Set up knowledge search logic](#set-up-knowledge-search-logic).

10. Select **Save**.

---

## Set up knowledge management settings page manually for a model-driven app

> [!NOTE]
> The embedded knowledge search control is deprecated in the web client. You must use the Knowledge Settings page in Unified Interface.

 If you are using the custom model-driven app, you need to manually update your sitemap with the Knowledge Settings page. To update the sitemap:
 
 1. Select your custom app.
 
 2. Select **Open in app designer**.
 
 3. Select **Site Map**.
  
 4.	Select **Add > Subarea** to create a new sub area for your area.
 
 5. In the **Properties > SUB AREA** section, provide the following information:
    * Type: Select **URL**. 
    * URL: Enter  ```/main.aspx?pagetype=inlinedialog&name=KnowledgeSettings```

## Set up AI suggestions for article keywords and description

You can enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in knowledge article entity. More information: [Configure AI suggestions for article keywords and description](configure-ai-suggested-article-keywords-description.md#configure-ai-suggestions-for-article-keywords-and-description).

## Set up knowledge search logic

If you have Relevance search enabled, you can apply knowledge search logic for your knowledge articles to help agents find only the articles they need. By default, knowledge search works by the `searchMode=any` logic, which brings up articles that match any of the keywords used in your search. If you search for Contoso Coffee, the search results will show articles that have either "Contoso" or "Coffee", as seen in the following example:

- Article 1: Contoso machine repair
- Article 2: Coffee powder quality
- Article 3: Contoso coffee order price
- Article 4: Coffee machine order for Contoso
- Article 5: Espresso coffee machine troubleshooting

You can enable the knowledge search to work by the `searchmode=all` logic, which matches all the keywords that you used in the search. If you search for Contoso Coffee, the search results will show articles that match both "Contoso" and "Coffee" as seen in the following example:

- Article 1: Contoso coffee order price
- Article 2: Coffee machine order for Contoso

You can set up the knowledge search logic either on the Customer Service Hub or on Customer Service admin center (preview) app. Depending on your app, perform the following steps:

1. Go to the **Settings** page.

### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

> [!IMPORTANT]
> The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

  * On the Customer Service admin center (preview) site map, select **Knowledge** in **Agent experience**.
  * On the **Knowledge** page, in the **General Settings** section, select **Manage**. The General settings page appears.

### [Customer Service Hub](#tab/customerservicehub)

  * On the Customer Service Hub site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

---

2. In the **Knowledge search logic** section, set the **Set search mode as all** toggle to **Yes**.

3. Select **Save**.

More information: [Search across table data using Dataverse search](/powerapps/developer/data-platform/webapi/relevance-search#searchmode-any--all-optional)

  
### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
