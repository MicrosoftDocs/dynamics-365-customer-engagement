---
title: Configure knowledge management (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to configure the settings for knowledge management in Dynamics 365 Customer Service
ms.date: 12/14/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
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
  
- Set up the search logic, suggest-as-you-type option, and search filters to get only the required knowledge articles, thereby providing timely and consistent information to customers while working on their cases.

- Use smart assist to receive AI suggestions on related knowledge articles and similar cases.

- See the content of the knowledge base article inline, including images and videos.

## Setup overview

You can set up knowledge management on the Customer Service admin center, Customer Service Hub, or manually for a model-driven app.

- [Set up knowledge management](#set-up-knowledge-management)
- [Set up knowledge management settings page manually for a model-driven app](#set-up-knowledge-management-settings-page-manually-for-a-model-driven-app)

After you have configured knowledge management on your app, you must also set up the various other aspects of knowledge management, based on your organizational requirements, such as:

- [Configure knowledge base article URLs](#configure-knowledge-base-article-urls)
- [Create and manage categories](create-manage-categories.md#create-and-manage-categories)
- [Create templates for knowledge articles](create-templates-knowledge-article.md#create-templates-for-knowledge-articles)
- [Set up AI suggestions for article keywords and description](#set-up-ai-suggestions-for-article-keywords-and-description)
- [Set up external search providers](set-up-search-providers.md#set-up-external-search-providers)

## Set up knowledge management
  
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].

 You can set up knowledge management in the Customer Service admin center or Customer Service Hub app. The settings you configure for knowledge management in the Customer Service Hub app are carried over to the Customer Service admin center app, and vice versa.
  
### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  
  2. In the **Record types** section, select **Manage**.
      1. On the **Record Types** page, add and configure the record types for which you want to turn on knowledge management. More information: [Configure knowledge search control on app side pane for an entity record](configure-knowledge-search-control-productivity-pane.md). By default, knowledge management is enabled for **Case** and **Conversation** record types. The ability to set up knowledge search control for app side pane is available only in the Customer Service admin center app.
  3. In the **General Settings** section, select **Manage**. The **General Settings** page appears.
      1. In the **Search results display count** section, select the display count from the dropdown. This option is only available for the app side pane knowledge base search control, and standalone knowledge base search control in single session and multisession apps.
      1. In the **Feedback** section, set the **Enable feedback** toggle to **Yes**. To learn more about how users use this option, see [Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles).
      1. In the **Authoring language** section, set the **Enable default authoring language** for your users to **Yes**.
        * If you want to select a default knowledge authoring language for your organization, then select the **Organization’s UI language** radio button. 
        *	If you want to use the organizations’ s UI language as the default knowledge authoring language, select the **Other language** radio button, and then select a language from the **Language** dropdown.
        *	If you also want to allow users to set their default knowledge authoring language, set the **Allow users to set default knowledge authoring language** toggle to **Yes**. More information: [Configure a default knowledge article authoring language for your organization](set-knowledge-article-authoring-language.md#configure-a-default-knowledge-article-authoring-language-for-your-organization)
      *	In the **Origins allow list** section, add your origins links to the **Add origin links** field. More information: [Configure origins allowlist for knowledge articles](configure-knowledge-article-origin-allow-list.md#configure-origins-allowlist-for-knowledge-articles).
      *	In the **Knowledge search logic** section, set the **Set search mode as all** toggle to **Yes**. More information: [Set up knowledge search logic](#set-up-knowledge-search-logic)
	    * Select **Save**.
  4. Optionally, in the **Categories** section, select **Manage**. The **Categories System Views** page appears. You can create and manage a logical structure of categories for your records. More information: [Create and manage categories](create-manage-categories.md#create-and-manage-categories).
  5. In the **Filters** section, set the **Enable search filters** toggle to **Yes**. If you want to allow agents to save the the search filters according to their areas, set the **Allow agent to personalize** toggle to **Yes**.
  6. In the **Portals** section, select **Manage**. The **Portals** page appears.
      1. In the **Support portal connection** section, do the following to share knowledge articles as URLs:
          *	Set the **Use an external portal** toggle to **Yes** to integrate an external portal to publish knowledge articles.
          * **URL Format**: Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: https://support portal URL/kb/{kbnum}. The placeholder, "{kbnum}", is replaced by an actual knowledge article number.
      1.	In the **Sync knowledge article attachments to portal** section, set the **Sync attachments to the portal** toggle to **Yes**. More information: [Update knowledge article attachments for portal](#update-knowledge-article-attachments-for-portal)
  7. Optionally, in the **Article templates** section, select **Manage**. The **Article Templates System Views** page appears. You can create templates to help knowledge authors use consistent language and messaging. More information: [Create templates for articles](/power-platform/admin/create-templates-articles).
  8. Optionally, in the **Search providers** section, select **Manage**. The **Search providers System Views** page appears. You can use search providers to federate the search of files, documents, or articles from data sources outside of your current Dynamics 365 organization. More information: [Set up external search providers](set-up-search-providers.md#set-up-external-search-providers)

### [Customer Service Hub](#tab/customerservicehub)

1. In the site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

2. On the **Settings** page, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  

3. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal to publish knowledge articles. If your organization uses one, select this checkbox.  

        Set the toggle to **Yes** to share the knowledge article as a link in the email sent to the customer. Set the toggle to **No** to share the article content inserted in the email body. If you select **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: https://support portal URL/kb/{kbnum}. The placeholder, "{kbnum}", is replaced by an actual knowledge article number.  
  
4. In the **Knowledge articles feedback** section, set the **Enable feedback** toggle to **Yes**. To learn more about how users use this option, see [Submit ratings and feedback for knowledge articles](submit-feedback.md#submit-ratings-and-feedback-for-knowledge-articles).

5. In the **Knowledge articles search filters** section, set the **Enable search filters** toggle to **Yes**. If you want to allow agents to personalize the search filters, set the **Allow agents to personalize the knowledge articles search filters** toggle to **Yes**.

6. In the **Knowledge articles authoring language** section, set the **Set default knowledge authoring language for your users** to **Yes**.
   * If you want to set the default knowledge authoring language for your organization, search and select a language in the **Select a language** field, and then set the **Use organization’s UI language** toggle to **Yes**.
   * If you also want to allow users to set their default knowledge authoring language in the personalization option, set the **​Allow users to set default knowledge authoring language** toggle to **Yes**​. More information: [Configure a default knowledge article authoring language for your organization](set-knowledge-article-authoring-language.md#configure-a-default-knowledge-article-authoring-language-for-your-organization)

7. In the **Sync knowledge article attachments to portal** section, set the **Sync attachments to portal** toggle to **Yes**. More information: [Update knowledge article attachments for portal](#update-knowledge-article-attachments-for-portal)

8. In the **Origins allowlist** section, add your origins links to the **Add origin links** field. More information: [Configure origins allowlist for knowledge articles](configure-knowledge-article-origin-allow-list.md#configure-origins-allowlist-for-knowledge-articles).

9.  In the **Knowledge search logic** section, set the **Set search mode as all** toggle to **Yes**. More information: [Set up knowledge search logic](#set-up-knowledge-search-logic).

10. Select **Save**.

The configured settings are also available to users of Omnichannel for Customer Service.

---
> [!NOTE]
> During the creation of knowledge articles, duplicate detection rules aren't supported on the Knowledge Article entity.

## Set up knowledge management settings page manually for a model-driven app

> [!NOTE]
> The embedded knowledge search control is deprecated in the web client. You must use the Knowledge Settings page in Unified Interface.

 If you are using the custom model-driven app, you need to manually update your sitemap with the Knowledge Settings page. To update the sitemap:
 
 1. Select your custom app.
 
 2. Select **Open in app designer**.
 
 3. Select **Site Map**.
  
 4. Select **Add > Subarea** to create a new sub area for your area.
 
 5. In the **Properties > SUB AREA** section, provide the following information:
    * Type: Select **URL**. 
    * URL: Enter  ```/main.aspx?pagetype=inlinedialog&name=KnowledgeSettings```

## Configure knowledge base article URLs

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

## Update knowledge article attachments for portal

With the knowledge article attachments option, you can stop using notes attachments for the portal. To use knowledge article attachments for the portal, you must enable the feature in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to the **Sync knowledge article attachments to portal** section.

### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**. The **Knowledge** page appears.
  2. In the **Portals** section, select **Manage**. The **Portal** page appears.
  3. On the **Portals** page, go to the **Sync knowledge article attachments to portal** section.

### [Customer Service Hub](#tab/customerservicehub)

   1. In the site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.
   2. On the **Settings** page, go to the **Sync knowledge article attachments to portal** section.

---

2. Set the **Sync attachments to portal** toggle to **Yes**.
3. Select **Save**.


## Set up AI suggestions for article keywords and description

You can enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in knowledge article entity. More information: [Configure AI suggestions for article keywords and description](configure-ai-suggested-article-keywords-description.md#configure-ai-suggestions-for-article-keywords-and-description).

## Set up knowledge search logic

If you have Dataverse search enabled, you can apply knowledge search logic for your knowledge articles to help agents find only the articles they need. By default, knowledge search works by the `searchMode=any` logic, which brings up articles that match any of the keywords used in your search. If you search for Contoso Coffee, the search results will show articles that have either "Contoso" or "Coffee", as seen in the following example:

- Article 1: Contoso machine repair
- Article 2: Coffee powder quality
- Article 3: Contoso coffee order price
- Article 4: Coffee machine order for Contoso
- Article 5: Espresso coffee machine troubleshooting

You can enable the knowledge search to work by the `searchmode=all` logic, which matches all the keywords that you used in the search. If you search for Contoso Coffee, the search results will show articles that match both "Contoso" and "Coffee", as seen in the following example:

- Article 1: Contoso coffee order price
- Article 2: Coffee machine order for Contoso

You can set up the knowledge search logic in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to the **Settings** page.

### [Customer Service admin center](#tab/customerserviceadmincenter)

  1. In the site map, select **Knowledge** in **Agent experience**.
  1. On the **Knowledge** page, in the **General settings** section, select **Manage**. The **General settings** page appears.

### [Customer Service Hub](#tab/customerservicehub)

  * In the site map, go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

---

2. In the **Knowledge search experience** section, set the **Set search mode as all** toggle to **Yes**.

3. Select **Save**.

More information: [Search across table data using Dataverse search](/powerapps/developer/data-platform/webapi/relevance-search#searchmode-any--all-optional)

## Enable the suggest-as-you-type option

You can help agents improve their productivity by setting the **Enable suggest as you type** toggle to **Yes**. This feature provides suggestions on the most relevant records as agents type keywords in the search box. The search phrase is matched against the title of the article, and the matching results appear in a flyout menu. The matched text is highlighted to show the presence of the keyword. 

When an agent selects the record, the system displays the article inline on the knowledge search control embedded on a form, on an application tab in Customer Service workspace, and as an inline view in the independent knowledge search control. More information: [Use suggest-as-you-type](search-knowledge-articles-csh.md#use-suggest-as-you-type)

1. In the Customer Service admin center site map, select **Knowledge** in **Agent experience**.
2. On the **Knowledge** page, in the **General settings** section, select **Manage**. The **General settings** page appears.
3. In the **Knowledge search experience** section, set the **Enable suggest as you type** toggle to **Yes**.
4. Select **Save**.

:::image type="content" source="media/enable-suggest-as-you-type.png" alt-text="Screenshot shows toggle for the Enable-suggest-as-you-type option":::


### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
