---
title: Set up knowledge management using embedded knowledge search (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to set up knowledge management using embedded knowledge search in Dynamics 365 Customer Service
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/19/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 68356343-fdd5-4c0e-9c09-dbebf718c764
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Use embedded knowledge search to set up knowledge management

A comprehensive knowledge base is a key to increased customer satisfaction and improved productivity of users. Give users quick access to the knowledge base by setting up knowledge management in Dynamics 365 Customer Service.

> [!IMPORTANT]
> Usage of [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase as a knowledge management solution has been deprecated. For more information, see [Important changes coming](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
After knowledge management is set up, users will be able to:  
  
- Search for relevant KB articles right from Dynamics 365 Customer Service as they're working on a record.  
  
- See the content of the KB article inline, including images and videos.  
  
- Give timely and consistent information to customers when working on their cases by using actions like opening the article and sharing the information or emailing the article link to customers.   

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, embedded knowledge search in service management is available in the Customer Service Hub. We recommend that you set up knowledge management using embedded knowledge search in the new experience.
  
## Set up knowledge management (Customer Service Hub)
  
[!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].
  
1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 
  
2. In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  

  
3. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.  

        Select **Yes** to share the knowledge article as a link in the email sent to the customer. Select **No** to share the article content inserted in the email body. If you choose **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *http://\<support portal URL>/knowledgebase/article/{kbnum}* 
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
4. Select **Save**.  

## Set up knowledge management (Customer Service app)

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3. Under **Knowledge Base Management**, select **Embedded Knowledge Search**.  
  
4. In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  
  
5. Under **Knowledge Source**, in the **Knowledge Solution** field, select the knowledge solution.  
  
6. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.

        Select **Yes** to share the knowledge article as a link in the email sent to the customer. Select **No** to share the article content inserted in the email body.  If you choose **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: </br> </br> *http://\<support portal URL>/kb/{kbnum}*  
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
7. Select **Next**.  
  
8. If you’ve specified the details correctly, the page shows the connection details for Dynamics 365 Customer Service. Select **Finish** to complete the setup.  


## Enable feedback control

This option allows users to provide feedback on knowledge articles opened from knowledge search control. 

1. In the Customer Service Hub site map, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 

2. In the **Knowledge Articles Feedback** section, set **Enable users to provide feedback on knowledge articles from search control** to **Yes**.

To know more about how users use this option, see [Submit ratings and feedback for knowledge articles](search-knowledge-articles-csh.md#submit-ratings-and-feedback-for-knowledge-articles).

## Enable inline images

This option allows users to drag and drop or copy and paste images inline in knowledge articles.

1. In the Customer Service Hub site map, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 

2. In the **Knowledge Articles Inline Images** section, set **Enable users to use the inline image feature when authoring articles** to **Yes**.

  
### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   
