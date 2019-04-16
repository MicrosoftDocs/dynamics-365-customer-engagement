---
title: "Dynamics 365 for Customer Engagement (online) Integration with Office 365 (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "Learn how Dynamics 365 for Customer Engagement apps customers that are subscribed to Office 365 can have single sign-on access through integration of Dynamics 365 for Customer Engagement apps with Office 365"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 24a41d45-e8dc-47f0-8faf-65cb01ab7f3c
caps.latest.revision: 48
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Dynamics 365 for Customer Engagement (online) Integration with Office 365

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This documentation applies to customers who access [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps through the [!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. Through integration of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] with [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)], [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] customers that are subscribed to [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] have single sign-on access, through identity federation, to any [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] supported application, such as [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)]. Similarly, when provisioned, [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] customers have access to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. In addition, by federating [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain accounts in [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] cloud services, businesses can manage a single set of user identities in both their [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps.  
  
 This topic provides information about where users’ identities are created and managed, and how they relate to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
## Identity management with Microsoft Online Services  
 When accessing the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] web services, your applications should know the identity provider associated with the logged on user’s [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps account. Configuration of the user’s authentication credentials for accessing the web services through SDK calls is slightly different for each provider. The details on how to configure user credentials for each identity provider and access the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] web services is discussed in the topic [Access the Dynamics 365 for Customer Engagement apps Services](authenticate-office-365-users-customer-engagement-web-services.md).  
  
 There are two identity providers supported by [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and provisioned through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)]: User ID, and [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] (through cloud federation). The following discussion provides an overview of these identity services and how they relate to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps.  
  
### User ID  
 User ID represents user identities provisioned by customers in [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] cloud services and is the identity provider for all customers who have subscribed to the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] collaboration environment. User ID enables you to have access to all [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] online services such as [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps. Customers with a User ID have their account credentials and policies managed through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)].  
  
 For the sake of this discussion, User ID users are referred to in this documentation as “managed” or “non-federated” users.  
  
### Active Directory  
 Federation allows customers to use [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]-based domain user accounts to access [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] such as [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] or [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. After federation is configured by an administrator, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]-based system user accounts can be locally managed, made available to [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)], and kept in sync with changes made to the on-premises [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] identities. The benefit of federation is a single sign-on experience across [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] (on-premises) apps and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps systems. This type of identity management is useful for large corporations that have hundreds or thousands of established users.  
  
 For more information about how to configure identity federation, see [Single sign-on: Roadmap](http://onlinehelp.microsoft.com/office365-enterprises/hh125004.aspx).  
  
## Identity management with Microsoft account  
 [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] continues to be a supported identity provider for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps. However, [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] is not supported for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps organizations when provisioned through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)]. [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps customers that are not subscribed through [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] can access [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] through their [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)].  
  
### See also  
 [Connect with Microsoft Office 365](connect-microsoft-office-365.md)   
 [Access the Dynamics 365 for Customer Engagement Web Services](authenticate-office-365-users-customer-engagement-web-services.md)   
 <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials>   
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)   
 [Active Directory Federation Services](https://msdn.microsoft.com/library/bb897402.aspx)   
 [Access Control Service 2.0](https://msdn.microsoft.com/library/hh147631.aspx)
