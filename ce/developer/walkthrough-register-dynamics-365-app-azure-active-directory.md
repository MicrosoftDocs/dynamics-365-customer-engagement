---
title: "Walkthrough: Register a Dynamics 365 for Customer Engagement app with Azure Active Directory (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "This walkthrough describes how to register an application with Azure Active Directory so that it can connect to the Dynamics 365 for Customer Engagement Online instance, authenticate using OAuth, and access the web services"
ms.custom: 
ms.date: 07/25/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 8fb9f7e2-8002-427e-bc66-a7c0d6e32ac8
caps.latest.revision: 10
author: KumarVivek    
ms.author: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Walkthrough: Register a Dynamics 365 for Customer Engagement app with Azure Active Directory

This walkthrough describes how to register an application with Azure Active Directory, which enables a user with Dynamics 365 for Customer Engagement user account to connect to their Dynamics 365 for Customer Engagement Online instance from external client applications using OAuth authentication.

> [!IMPORTANT]
> Dynamics 365 for Customer Engagement also provides you with Server-to-Server (S2S) authentication option to connect to Dynamics 365 for Customer Engagement Online instance from external applications and services using the special *application user* account. S2S authentication is the common way that apps registered on Microsoft AppSource use to access the Dynamics 365 for Customer Engagement data of their subscribers. More information: [Build web applications using Server-to-Server (S2S) authentication](build-web-applications-server-server-s2s-authentication.md).

App registration in Azure Active Directory is typically done by ISVs who want to develop external client applications to read and write data in Customer Engagement. Registering an app in Azure Active Directory provides you with **Application ID** and **Redirect URI** values that ISVs can use in their client application's authentication code. When end users use the ISV's application for the *first time* to connect to their Customer Engagement instance by providing their Customer Engagement credentials, a consent form is presented to the end user. After consenting to use their Customer Engagement account with the ISV's application, end users can connect to Customer Engagement instance from external application. The consent form is not displayed again to other users after the first user who has already consented to use the ISV's app. Apps registered in Azure Active Directory are multi-tenant, which implies that other Customer Engagement users from other tenant can connect to their instance using the ISV's app. 

App registration can also be done by an application developer or individual user who is building a client application to connect to and read/write data in Customer Engagement. Use the **Application ID** and **Redirect URI** values from your registered app in your client application's authentication code to be able to connect to Customer Engagement instance from your client application, and perform the required operations. Note that if the app is registered in the same tenant as your Customer Engagement instance, you won't be presented with a consent form when connecting from your client application to your Customer Engagement instance.



## Prerequisites  
<!--- **For an on-premises or Internet-facing deployment (IFD)**:  
  
    -   The server must be configured to use claims authentication and have OAuth authentication enabled.  
  
    -   A Microsoft [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] subscription for application registration. A trial account will also work.  
  
- **For a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] deployment**:-->  
  
- The user who is registering the application must have a Dynamics 365 for Customer Engagement user account with System Administrator security role and the global administrator role for the Office 365 subscription.  
  
- An Azure subscription for application registration. A trial account will also work.  
  
  <!--For either deployment type, you must know the redirect URL for your application. Instructions for finding that URL are provided in the section named [Obtain the redirect URI](walkthrough-register-app-active-directory.md#bkmk_redirect).-->  
    
<a name="bkmk_online"></a>   

## How to: Register an application with Microsoft Azure Active Directory  
  
1. Sign in to the [Azure portal](https://go.microsoft.com/fwlink/?linkid=2083908) using an account with administrator permission. You must use an account in the same Office 365 subscription (tenant) as you intend to register the app with. You can also access the Azure portal through the Office 365 [Admin center](https://admin.microsoft.com/adminportal) by expanding the **Admin centers** item in the left navigation pane, and selecting **Azure Active Directory**.  
  
   > [!NOTE]
   > If you don’t have an Azure tenant (account) or you do have one but your Office365 subscription with Dynamics 365 for Customer Engagement is not available in your Azure subscription, following the instructions in the topic [Set up Azure Active Directory access for your Developer Site](https://msdn.microsoft.com/office/office365/HowTo/setup-development-environment) to associate the two accounts.<br><br> If you don’t have an account, you can sign up for one by using a credit card. However, the account is free for application registration and your credit card won’t be charged if you only follow the procedures called out in this topic to register one or more apps. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Active Directory Pricing Details](http://azure.microsoft.com/pricing/details/active-directory/)  
  
2. In the Azure portal, select **Azure Active Directory** in the left pane and select **App registrations** and click on **New registration**.
    
    ![Azure App Registration](media/azure-app-registrations-page.png "Azure app registration")  

3. In the **Register an application page**, enter your application's registration information:
   - In the **Name** section, enter a meaningful application name that will be displayed to the users.
   - Select **Accounts in any organizational directory** option from **Supported account types** section.
   - Set the **Redirect URI**.
   - Click on **Register** to create the application.

      ![New App registration page](media/new-app-registration-page.png "New App registration page")

5. On the app **Overview** page, hover over **Application (client) ID** value, and select the **Copy to clipboard** icon to copy the value as you’ll need to specify this in your application’s authentication code or app.config file where appropriate.

    ![Copy application ID](media/app-registration-overview-page.png "Copy application ID")
  
5. Select **Manifest** tab, in the manifest editor, set the *allowPublicClient** property to **true** and click on **Save**.
   
    ![App registration Manifest](media/app-registration-manifest-page.png "App registration Manifest")

6. Select **API permissions** tab, click on **Add a permission**. 

    ![Add app permission](media/azure-api-permissions-page.png "Add app permission")

7. Select **Dynamics CRM** under the **Microsoft APIs** tab.
    
    ![Select API](media/app-registration-select-api-page.png "Select API")    

8. Click on **Delegated permissions** and check the options and click on **Add permissions**. 
    
    ![Delegate Permissions](media/app-registration-delegate-permissions-page.png "Delegate Permission")

This completes the registration of your application in Azure Active Directory.
       
  
<!--### Register an application with AD FS  
  
-   If you’re federating users between an [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and you want to use the app with either server, you must register the application with both [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] on the [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server. Follow the steps provided in this topic. Your [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server must be running [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)].-->  
  
### See also  
 [Application registration in Azure Active Directory](https://docs.microsoft.com/azure/active-directory/develop/active-directory-integrating-applications)    
 [Authenticate Users with Dynamics 365 for Customer Engagement Web Services](authenticate-users.md)
