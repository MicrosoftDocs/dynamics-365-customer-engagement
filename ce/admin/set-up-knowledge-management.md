---
title: "Set up knowledge management for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e6944ce3-8e2e-4566-a5de-fa801ad63866
caps.latest.revision: 17
ms.author: "anjgup"
manager: "sakudes"
---
# Set up knowledge management with a knowledge base
A comprehensive knowledge base is a key to increased customer satisfaction and improved productivity of users. Give users quick access to the knowledge base by setting up knowledge management in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports two knowledge management solutions that you can choose from:  
  
-   Native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge management. This option is available for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users. For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organizations, the native [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] knowledge solution is only available if you've updated to [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)]. .  
  
- [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase. This option is available only for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users. This feature was introduced in [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)].  
  
     Interested in getting this feature? [Find your Dynamics 365 administrator or support person](http://go.microsoft.com/fwlink/p/?LinkID=513070).  
  
 After knowledge management is set up, users will be able to:  
  
-   Search for relevant KB articles in [!INCLUDE[pn_parature](../includes/pn-parature.md)] right from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as they're working on a record.  
  
-   See the content of the KB article inline, including images and videos.  
  
-   Give timely and consistent information to customers when working on their cases by using actions like opening the article and sharing the information or emailing the article link to customers.  
  
<a name="BKMK_Prereq"></a>   
## Prerequisites  
 If you want to use [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase, before setting up knowledge management in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], do this:  
  
-   Set up a [!INCLUDE[pn_parature](../includes/pn-parature.md)] account in the same [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] tenant as your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] organization.  
  
-   Add your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization to the list of allowed URLs in the CORS settings in [!INCLUDE[pn_parature](../includes/pn-parature.md)]. To do this, in Parature Service Desk, go to **Setup** > **Department Management** > **CORS Settings** and add your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization URL.  
  
> [!NOTE]
>  Any [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] user with a Professional user subscription license can use the knowledge base integration capability without any additional set up in [!INCLUDE[pn_parature](../includes/pn-parature.md)]. If a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] user with an Enterprise user subscription license wants to use knowledge base integration capability, you’ll need to assign the user a [!INCLUDE[pn_parature](../includes/pn-parature.md)] license and then create a CSR with a Knowledgebase View Only role in [!INCLUDE[pn_parature](../includes/pn-parature.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Assign Parature licenses to Dynamics 365 users](../admin/assign-parature-licenses-users.md)  
  
<a name="BKMK_Setup"></a>   
## Set up knowledge management  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)] You must also be the tenant administrator of [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)].  
  
2. [!INCLUDE[proc_settings_service_management](../includes/proc-settings-service-management.md)]  
  
3.  Under **Knowledge Base Management**, click **Embedded Knowledge Search**.  
  
4.  In the **Knowledge Base Management Settings** wizard, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all entities that are available for an N:N relationship. Knowledge management is enabled for case entity by default.  
  
5.  Under **Knowledge Source**, in the **Knowledge Solution** field, select between the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] native knowledge solution and [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase.  
  
    > [!IMPORTANT]
    >  The **Knowledge Solution** field is available only if your organization has installed [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)] or later.  
  
6.  If you’re using **Native Dynamics 365** knowledge solution, in the **Support Portal Connection** section, enter the following:  
  
    - **Use an external portal**. You can integrate an external portal for publishing knowledge articles. If your organization uses one, select this check box.  
  
    - **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: http://\<support portal URL>/kb/{kbnum}  
  
         The placeholder "{kbnum}" is replaced by an actual knowledge article number.  
  
7.  If you want to use the [!INCLUDE[pn_parature](../includes/pn-parature.md)] knowledgebase, in **Parature Connection Details**, enter the following:  
  
    1. **Parature Instance**. Select the [!INCLUDE[pn_parature](../includes/pn-parature.md)] instance to connect to. The drop-down list by default shows the instance present in your [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] subscription.  
  
    2. **Parature URL**. This is automatically filled and shows the URL of the selected [!INCLUDE[pn_parature](../includes/pn-parature.md)] instance in the tenant.  
  
    3. **Account ID**. This is automatically filled and shows the ID of the account as it is set up in [!INCLUDE[pn_parature](../includes/pn-parature.md)] for the selected [!INCLUDE[pn_parature](../includes/pn-parature.md)] instance.  
  
    4. **Parature Department ID**. Specify the department ID for the selected [!INCLUDE[pn_parature](../includes/pn-parature.md)] instance. Every department in an organization can have their own knowledge base. So you must specify the ID of the department you want to connect to. You can connect to only one department at a time. To find the department ID, sign in to [!INCLUDE[pn_parature](../includes/pn-parature.md)], and on the **Setup** tab, click **System Overview**.  
  
 ![Account and Department ID in Parature](../admin/media/parature-system-overview.png "Account and Department ID in Parature")  
  
    5. **Support Portal URL**. Type the support portal URL that will be used to create external (public-facing) portal links for KB articles, which the service agents can share with the customers. [!INCLUDE[pn_parature](../includes/pn-parature.md)] offers a customer-facing support portal that your customers can use to access your knowledge base articles or download content. To find the support portal URL, sign in to the [!INCLUDE[pn_parature](../includes/pn-parature.md)] Service Desk, and on the **Setup** tab, click **Portal** > **Aliases**.  
  
         The external URL is created in the following format:  
  
         \<Support Portal URL>/link/portal/\<account id>/\<department id>/Article/\<Article id>  
  
        > [!NOTE]
        >  If you’ve connected to [!INCLUDE[pn_parature](../includes/pn-parature.md)] before, and want to remove details of the existing [!INCLUDE[pn_parature](../includes/pn-parature.md)] instance that you connected with, choose **Reset**.  
  
8.  Click **Next**.  
  
9. If you’ve specified the details correctly, the page shows the connection details for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] or [!INCLUDE[pn_parature](../includes/pn-parature.md)]. Click **Finish** to complete the setup.  
  
### See also  
 [Add the Knowledge Base Search pane to a Dynamics 365 form](../admin/add-knowledge-base-search-control-forms.md)   
 [Assign Parature licenses to Microsoft Dynamics 365 users](../admin/assign-parature-licenses-users.md)