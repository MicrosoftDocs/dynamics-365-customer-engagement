---
title: "Configure SharePoint integration using the list component for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 5f3ab396-4252-4990-96f3-762be6a8a947
caps.latest.revision: 17
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Configure SharePoint integration using the list component
If you can’t use server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, you must install the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] to get document management functionality. The [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] is a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] solution that you upload and activate on a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site collection. This feature uses a client-to-[!INCLUDE[pn_SharePoint_Server_short](../includes/pn-sharepoint-server-short.md)] strategy to authenticate and transmit data.  
  
> [!WARNING]
> [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)] has removed code-based sandbox solutions. Notice that the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] is a sandboxed solution that requires a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] sandbox environment.  
>   
>  -   If you're integrating [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] with [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] for the first time, use server-based authentication. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up SharePoint integration with Microsoft Dynamics 365](https://technet.microsoft.com/library/dn531154.aspx)  
> -   If you currently use the list component, we strongly recommend that you switch to server-based authentication. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Switching from the list component or changing the deployment](https://technet.microsoft.com/library/dn946910.aspx)  
  
1.  Make sure that you meet the requirements to use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] documentation management feature with [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. For more information, see [SharePoint Document Management software requirements for Microsoft Dynamics 365](../admin/sharepoint-document-management-software-requirements.md).  
  
2. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_check_your_security_role](../includes/proc-check-your-security-role.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
3.  Install the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] on the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] server.  
  
    > [!IMPORTANT]
    >  The [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] is not required when you use server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration. For more information, see [Set up SharePoint integration with Microsoft Dynamics 365](../admin/set-up-sharepoint-integration.md) .  
  
 [!INCLUDE[proc_settings_doc_mgmt](../includes/proc-settings-doc-mgmt.md)] On the command bar, click **Install List Component** and follow the instructions here.  
  
    1.  Locate the folder where you downloaded `CRM2016-SharePointList2013-ENU-amd64.exe` or `CRM2016-SharePointList2010-ENU-amd64.exe`, and open it.  
  
    2.  Select **Click here** to accept the license agreement.  
  
    3.  Select a folder to store the extracted files, and then click **OK**.  
  
    4.  If you downloaded CRM2016-SharePointList2013-ENU-amd64.exe, the AllowHtcExtn.ps1 and crmlistcomponent.wsp files are extracted.  
  
         If you downloaded CRM2016-SharePointList2010-ENU-amd64.exe, the crmlistcomponent.wsp file is extracted.  
  
    5.  Open your browser, and then in the address bar, type the URL of the site collection where you want to install the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)], and press **Enter**.  
  
    6.  Locate **Solution Gallery** in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]:  
  
        -   If you’re using [!INCLUDE[pn_Microsoft_SharePoint_2010](../includes/pn-microsoft-sharepoint-2010.md)]: Click **Site Actions**, then **Site Settings**, and then under **Galleries**, click **Solutions**.  
  
        -   If you’re using [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] or [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)]: Click the **Settings** button in the top-right corner, then **Site Settings**, and then under **Web Designer Galleries**, click **Solutions**.  
  
        > [!NOTE]
        >  If you don’t see the **Solutions** link, check the custom script setting. In the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)], click **Admin** > **Settings**. Under **Custom Script**, click **Allow users to run custom script on self-service created sites**. Click **OK**. Changes may take up to 24 hours to take effect.  
  
    7.  On the **Solutions** tab, in the **New** group, click **Upload Solution**.  
  
    8.  Click **Browse**, locate the crmlistcomponent.wsp file, click **Open**, and then click **OK**.  
  
    9. After the solution is added, click **Activate** and then click **Close**.  
  
        > [!NOTE]
        >  If you can’t activate this solution, see [Allow HTC files in SharePoint 2013](../admin/configure-sharepoint-integration-using-list-component.md#BKMK_allowHTC).  
  
4.  For detailed document management configuration steps, see [Set up Dynamics 365 (online) to use SharePoint Online](../admin/set-up-dynamics-365-online-to-use-sharepoint-online.md).  
  
<a name="BKMK_allowHTC"></a>   
## Allow HTC files in SharePoint 2013  
 By default, HTML component (.htc) files aren’t enabled on [!INCLUDE[pn_sharepoint_2013](../includes/pn-sharepoint-2013.md)]. To enable HTC, follow these steps.  
  
1.  Open [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] and navigate to the location where you downloaded and extracted the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] to.  
  
2.  Type the following command, where *https://mysharepointserver/Dynamics365* is the URL where the list component solution is installed, and then press **ENTER**.  
  
    ```ms-dos  
    ./AllowHtcExtn.ps1 https://mysharepointserver/CRM  
    ```  
  
### See also  
 [Download: Microsoft Dynamics CRM 2016 List Component for Microsoft SharePoint](http://go.microsoft.com/fwlink/p/?LinkId=627384)   
 [Set up SharePoint integration with Microsoft Dynamics 365](../admin/set-up-sharepoint-integration.md)   
 [Permissions required for document management tasks](../admin/permissions-required-document-management-tasks.md)