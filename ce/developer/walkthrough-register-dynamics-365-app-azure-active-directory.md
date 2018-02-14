---
title: "Walkthrough: Register a Dynamics 365 app with Azure Active Directory (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This walkthrough describes how to register an application with Azure Active Directory so that it can connect to the Dynamics 365 Customer Engagement server, authenticate using OAuth, and access the web services"
ms.custom: ""
ms.date: 02/13/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8fb9f7e2-8002-427e-bc66-a7c0d6e32ac8
caps.latest.revision: 10
author: "JimDaly"
ms.author: "jdaly"
---
# Walkthrough: Register a Dynamics 365 app with Azure Active Directory

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This walkthrough describes how to register an application with [!INCLUDE[pn_microsoft_azure_active_directory](../includes/pn-microsoft-azure-active-directory.md)], which enables a user with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] user account to connect to their [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Online Customer Engagement instance from *external* client applications using OAuth authentication.

App registration in Azure Active Directory is typically done by ISVs who provide external client applications to read and write data in Customer Engagement. Registering an app in Azure Active Directory provides you with **Application ID** and **Redirect URI** values that you can use in your client application's authentication code. This enables Customer Engagement users to connect to their instances by using their Customer Engagement credentials from client application using OAuth authentication. Apps registered in Azure Active Directory are multi-tenant, which implies that users can connect to Customer Engagement instance in any tenant if they have access. A consent form is presented *first time* to the end user when he/she uses the ISV client application to connect to his/her Customer Engagement instance. 

If you are an application developer building a client application to conect to and read/write data in Customer Engagement, you can also register an app with Azure Active Directory, and then use the **Application ID** and **Redirect URI** values from your registered app in your client application authentication code to test your client application. If the app is registered in the same tenant as your Customer Engagement instance, you won't be presented with a consent form when connecting from your client application to your Customer Engagement instance.

> [!IMPORTANT]
> This topic provides information about registering an app that uses your Customer Engagement credentials to connect from an external client application to your Customer Engagement instance. To know about using Server-to-Server (S2S) authentication to connect to Dynamics 365 Customer Engagement instance using an application user, see [Build web applications using Server-to-Server (S2S) authentication](build-web-applications-server-server-s2s-authentication.md)
 
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
## Prerequisites  
<!--- **For an on-premises or Internet-facing deployment (IFD)**:  
  
    -   The server must be configured to use claims authentication and have OAuth authentication enabled.  
  
    -   A Microsoft [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] subscription for application registration. A trial account will also work.  
  
- **For a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] deployment**:-->  
  
-   The user who is registering the application must have a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] user account with System Administrator security role and the global administrator role for the [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] subscription.  
  
-   An [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] subscription for application registration. A trial account will also work.  
  
 <!--For either deployment type, you must know the redirect URL for your application. Instructions for finding that URL are provided in the section named [Obtain the redirect URI](walkthrough-register-app-active-directory.md#bkmk_redirect).-->  
    
<a name="bkmk_online"></a>   
## How to: Register an application with Microsoft Azure Active Directory  
  
1.  [Sign in](http://manage.windowsazure.com) to the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] management portal by using an account with administrator permission. You must use an account in the same [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] subscription (tenant) as you intend to register the app with.<br><br> You can also access the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] management portal through the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] [Admin center](https://portal.office.com/adminportal) by expanding the **Admin centers** item in the left navigation pane, and selecting **Azure AD**.  
  
    > [!NOTE]
    > If you don’t have an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] tenant (account) or you do have one but your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] subscription with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] is not available in your [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] subscription, following the instructions in the topic [Set up Azure Active Directory access for your Developer Site](https://msdn.microsoft.com/office/office365/HowTo/setup-development-environment) to associate the two accounts.<br><br> If you don’t have an account, you can sign up for one by using a credit card. However, the account is free for application registration and your credit card won’t be charged if you only follow the procedures called out in this topic to register one or more apps. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Active Directory Pricing Details](http://azure.microsoft.com/pricing/details/active-directory/)  
  
1. In the Azure management portal, follow the steps as described in the [Adding an application](https://docs.microsoft.com/en-us/azure/active-directory/develop/active-directory-integrating-applications#adding-an-application) section in the Azure Active Directory developers guide to create an app. 
  
1. On creating an app in Azure Active Directory, a unique **Application ID** (previously called **Client ID**) is generated for your application, and the newly registered app appears on the registered apps page. Click the app to open the app information page.

1. On the app information page, hover over **Application ID** (previously called **Client ID**) value, and select the **Click to copy** icon to copy the value as you’ll need to specify this in your application’s authentication code or app.config file where appropriate.

    ![Copy application ID](media/Azure-copy-app-id.png "Copy application ID")
  
1. Select **Settings** in the app info page, and use the **Redirect URIs** option on the **Settings** page to copy the redirect URI value for your app. You can also change and add additional URIs if required. For an app of **Web app / API** application type, you will see **Reply URLs** option instead of the **Redirect URIs** option.

1. On the **Settings** page, select **Required permissions** > **Add** to add permissions for the registered app.

    ![Add app permission](media/Azure-add-app-permission.png "Add app permission")
  
1. On the **Add API access** page:
    - Select **Select an API** > **Dynamics CRM Online**, and then click **Select**.

      ![Add app permission](media/Azure-add-api-access.png "Add app permission")  
   
    - Select **Select permissions** > **Access CRM Online as organization users**, and then click **Select**.
  
      ![Add application permission in Dynamics 365](media/azure-add-permission.PNG "Add application permission in Dynamics 365")  

    - Select **Done** to add the delegated permission to the registered app.

This completes the registration of your application in Azure Active Directory.
       
  
<!--### Register an application with AD FS  
  
-   If you’re federating users between an [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and you want to use the app with either server, you must register the application with both [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] on the [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server. Follow the steps provided in this topic. Your [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] server must be running [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)].-->  
  
### See also  
 [Application registration in Azure Active Directory](https://docs.microsoft.com/azure/active-directory/develop/active-directory-integrating-applications)    
 [Authenticate Users with Dynamics 365 Web Services](authenticate-users.md)
