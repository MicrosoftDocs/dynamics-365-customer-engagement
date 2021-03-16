---
title: Use settings to set up knowledge management (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to set up settings in knowledge management in Dynamics 365 Customer Service
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Use settings to set up knowledge management

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
  
1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Settings**. 
  
2. In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  

  
3. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.  

        Select **Yes** to share the knowledge article as a link in the email sent to the customer. Select **No** to share the article content inserted in the email body. If you choose **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *https://\<support portal URL>/knowledgebase/article/{kbnum}* 
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
4. Select **Save**.  

## Set up knowledge management (Customer Service app)

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].  
  
2. Go to **Settings** > **Service Management**. 
  
3. Under **Knowledge Base Management**, select **Embedded Knowledge Search**.  
  
4. In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  
  
5. Under **Knowledge Source**, in the **Knowledge Solution** field, select the knowledge solution.  
  
6. In the **Support Portal Connection** section, enter the following:  
  
   - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.

        Select **Yes** to share the knowledge article as a link in the email sent to the customer. Select **No** to share the article content inserted in the email body.  If you choose **Yes**, provide the **URL format**.
  
   - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: </br> </br> *https://\<support portal URL>/kb/{kbnum}*  
  
        The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
7. Select **Next**.  
  
8. If you’ve specified the details correctly, the page shows the connection details for Dynamics 365 Customer Service. Select **Finish** to complete the setup.  


## Enable feedback control

This option allows users to provide feedback on knowledge articles opened from knowledge search control. 

1. In the Customer Service Hub site map, go to **Service Management** and select **Knowledge Base Management** > **Settings**. 

2. In the **Knowledge Articles Feedback** section, set **Enable users to provide feedback on knowledge articles from search control** to **Yes**.

To know more about how users use this option, see [Submit ratings and feedback for knowledge articles](search-knowledge-articles-csh.md#submit-ratings-and-feedback-for-knowledge-articles).

  
### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]