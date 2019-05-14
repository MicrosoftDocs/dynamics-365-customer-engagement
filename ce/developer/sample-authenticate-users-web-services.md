---
title: "Sample: Authenticate users with Dynamics 365 for Customer Engagement web services (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "This sample shows how to authenticate a user with any Microsoft Dynamics 365 for Customer Engagement deployment and obtain a reference to the web services."
keywords: 
ms.date: 03/29/2019
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 3bde1482-60d4-489b-8379-49d3bc2f4abc
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - authenticating users with Microsoft Dynamics CRM web services sample
  - authenticating users with Microsoft Dynamics CRM web services, authentication sample
  - sample for authenticating users with Microsoft Dynamics CRM web services
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Authenticate users with Dynamics 365 for Customer Engagement web services

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample shows how to authenticate a user with any [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement deployment and obtain a reference to the web services. This sample includes support for [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] users provisioned in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
 Download the sample: [Authenticate users with Microsoft Dynamics 365 for Customer Engagement web services](https://code.msdn.microsoft.com/Authenticate-users-with-707e0375).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Demonstrates  
 This sample demonstrates how to authenticate a user with any [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] deployment and make web service calls. This sample doesn’t rely on the CrmServiceHelpers.cs helper code. For a sample that does use helper code, see [Sample: QuickStart sample program](sample-quick-start.md).  
  
## Example  
 [!code-csharp[authenticatewithnohelp#authenticatewithnohelp](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp.cs#authenticatewithnohelp)]  
  
### See also  
 [Authenticate Users with Dynamics 365 for Customer Engagement Web Services](authenticate-users.md)   
 [Helper Code: ServerConnection Class](org-service/helper-code-serverconnection-class.md)   
 [Authenticate Office 365 Users with Dynamics 365 for Customer Engagement apps (online) Web Services](authenticate-office-365-users-customer-engagement-web-services.md)   
 [Connect with Microsoft Office 365 and Dynamics 365 for Customer Engagement apps (online)](connect-microsoft-office-365.md)
