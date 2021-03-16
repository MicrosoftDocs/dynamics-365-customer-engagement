---
title: "Dynamics 365 Customer Engagement (on-premises) Integration with Office 365 (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn how Dynamics 365 Customer Engagement (on-premises) customers that are subscribed to Office 365 can have single sign-on access through integration of Dynamics 365 Customer Engagement (on-premises) with Office 365"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 24a41d45-e8dc-47f0-8faf-65cb01ab7f3c
caps.latest.revision: 48
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Dynamics 365 Customer Engagement (on-premises) Integration with Office 365

This documentation applies to customers who access Dynamics 365 Customer Engagement (on-premises) through the [!INCLUDE[pn_ms_online_services_environment](../includes/pn-ms-online-services-environment.md)]. Through integration of Dynamics 365 Customer Engagement (on-premises) with [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)], Dynamics 365 Customer Engagement (on-premises) customers that are subscribed to [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] have single sign-on access, through identity federation, to any [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] supported application, such as [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)]. Similarly, when provisioned, [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] customers have access to Dynamics 365 Customer Engagement (on-premises). In addition, by federating [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain accounts in [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] cloud services, businesses can manage a single set of user identities in both their [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] domain and Dynamics 365 Customer Engagement (on-premises).  
  
 This topic provides information about where users’ identities are created and managed, and how they relate to Dynamics 365 Customer Engagement (on-premises).  
  
## Identity management with Microsoft Online Services  
 When accessing the Dynamics 365 Customer Engagement (on-premises) web services, your applications should know the identity provider associated with the logged on user’s Dynamics 365 Customer Engagement (on-premises) account. Configuration of the user’s authentication credentials for accessing the web services through SDK calls is slightly different for each provider. The details on how to configure user credentials for each identity provider and access the Dynamics 365 Customer Engagement (on-premises) web services is discussed in the topic [Access the Dynamics 365 Customer Engagement (on-premises) Services](authenticate-office-365-users-customer-engagement-web-services.md).  
  
 There are two identity providers supported by Dynamics 365 Customer Engagement (on-premises) and provisioned through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)]: User ID, and [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] (through cloud federation). The following discussion provides an overview of these identity services and how they relate to Dynamics 365 Customer Engagement (on-premises)].  
  
### User ID  
 User ID represents user identities provisioned by customers in [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] cloud services and is the identity provider for all customers who have subscribed to the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] collaboration environment. User ID enables you to have access to all [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] online services such as [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] and Dynamics 365 Customer Engagement (on-premises). Customers with a User ID have their account credentials and policies managed through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)].  
  
 For the sake of this discussion, User ID users are referred to in this documentation as “managed” or “non-federated” users.  
  
### Active Directory  
 Federation allows customers to use [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]-based domain user accounts to access [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)] such as [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] or Dynamics 365 Customer Engagement (on-premises). After federation is configured by an administrator, [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]-based system user accounts can be locally managed, made available to [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)], and kept in sync with changes made to the on-premises [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] identities. The benefit of federation is a single sign-on experience across Dynamics 365 Customer Engagement (on-premises) and Dynamics 365 Customer Engagement (on-premises) systems. This type of identity management is useful for large corporations that have hundreds or thousands of established users.  
  
 For more information about how to configure identity federation, see [Single sign-on: Roadmap](https://onlinehelp.microsoft.com/office365-enterprises/hh125004.aspx).  
  
## Identity management with Microsoft account  
 [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] continues to be a supported identity provider for Dynamics 365 Customer Engagement (on-premises). However, [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)] is not supported for Dynamics 365 Customer Engagement (on-premises) organizations when provisioned through [!INCLUDE[pn_MS_Online_Services](../includes/pn-ms-online-services.md)]. Dynamics 365 Customer Engagement (on-premises) customers that are not subscribed through [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] can access Dynamics 365 Customer Engagement (on-premises) through their [!INCLUDE[pn_Windows_Live_ID](../includes/pn-windows-live-id.md)].  
  
### See also  
 [Connect with Microsoft Office 365](connect-microsoft-office-365.md)   
 [Access the Dynamics 365 Customer Engagement Web Services](authenticate-office-365-users-customer-engagement-web-services.md)   
 <xref:Microsoft.Xrm.Sdk.Client.AuthenticationCredentials>   
 [Active Directory and Claims-Based Authentication](active-directory-claims-based-authentication.md)   
 [Active Directory Federation Services](https://msdn.microsoft.com/library/bb897402.aspx)   
 [Access Control Service 2.0](https://msdn.microsoft.com/library/hh147631.aspx)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]