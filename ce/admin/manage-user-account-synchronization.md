---
title: "Manage user account online and on-premises synchronization | MicrosoftDocs"
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
ms.assetid: d72e27e3-a8c4-4d0d-96d1-c7f3f85bafdb
caps.latest.revision: 5
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Manage user account synchronization
Because [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] user identities are provisioned through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)], you have multiple options for managing user synchronization between your online and on-premises environments.  
  
## Decide on a user management approach  
 There are three possible methods to manage your user accounts:  
  
1.  Manage user accounts in [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]  
  
     This is the simplest approach but can require more long-term administrative effort. Every time you create a new user account, you will need to create the user in two locations: on-premises and in [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]. Name and password changes will require editing the accounts in both locations.  
  
2.  Synchronize on-premises directory objects with [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]  
  
     Active Directory synchronization (also referred to as DirSync) sets up a one-way synchronization relationship between your on-premises Active Directory server and [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)]. You get the benefit of easing the burden of maintaining user accounts without significantly adding to your hardware and failover requirements. However, you will still need to maintain two sets of passwords for your on-premises Active Directory accounts and your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] accounts.  
  
3.  Use [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] to manage users  
  
     This approach requires careful planning for redundancy and failover and requires the most expertise and effort to deploy.  
  
     In this approach, users in your organization can use corporate credentials to access the services in [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] that your company subscribes to such as [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. Users sign in once and don’t have to sign in again to access a different service. There’s a single password to manage.  
  
 Your decision on which method to choose is based largely on the size of your company and the depth and breadth of your IT resources.  
  
 Review the following resources to equip you to make the right decision for your company:  
  
-   [Understanding Office 365 identity and Azure Active Directory](http://go.microsoft.com/fwlink/p/?LinkID=534820)  
  
-   [What is an Azure AD directory?](http://go.microsoft.com/fwlink/p/?LinkID=525593)  
  
-   [Prepare for single sign-on](http://go.microsoft.com/fwlink/p/?LinkID=528168)  
  
## Tip for admins: provide a single sign-on organization URL for your users  
 If you’ve deployed synchronization with single sign-on (option 3 above), you can provide a URL to your users that takes advantage of your company’s Active Directory and simplifies the sign-in experience.  
  
 The URL follows this pattern:  
  
 https://\<*yourCRMOrganizationName*>.crm.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
  
 You can get the \<*yourCRMOrganizationName*> by looking at the URL you use to access [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. For example, in https://contoso.crm.dynamics.com, *contoso* is \<*yourCRMOrganizationName*>.  
  
> [!IMPORTANT]
>  The following URLs would be used for subscriptions hosted in these locations.  
>   
>  -   LATAM/SAM: https://\<*yourCRMorganizationname*>.crm2.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   CAN: https://\<*yourCRMorganizationname*>.crm3.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   EMEA: https://\<*yourCRMorganizationname*>.crm4.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   APAC: https://\<*yourCRMorganizationname*>.crm5.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   OCE: https://\<*yourCRMorganizationname*>.crm6.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   JPN: https://\<*yourCRMorganizationname*>.crm7.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   IND: https://\<*yourCRMorganizationname*>.crm8.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   United States of America Government: https://\< *yourCRMorganizationname*>.crm9.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   UK: https://\<*yourCRMorganizationname*>.crm11.dynamics.com?whr=\<*yourFederationServiceIdentifier*>  
> -   DEU: https://\<*yourCRMorganizationname*>.crm.microsoftdynamics.de?whr=\<yourFederationServiceIdentifier>  
  
 You can get the Federation Service identifier for your organization by using the following steps:  
  
1.  On the server that is running [!INCLUDE[pn_ADFS2](../includes/pn-adfs2.md)], click or tap **Start** > **Administrative Tools** > **AD FS 2.0 Management**.  
  
2.  In the console tree, right-click or tap **AD FS 2.0**, and then click or tap **Edit Federation Service Properties**.  
  
3.  Select the **General** tab.  
  
     Make note of your Federation Service identifier. For example: http://sts1.fabrikam.com/adfs/services/trust  
  
 Your URL should look like: https://*contoso*.crm.dynamics.com?whr=*http://sts1.fabrikam.com/adfs/services/trust*  
  
 Send this URL to your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] users and encourage them to bookmark it.