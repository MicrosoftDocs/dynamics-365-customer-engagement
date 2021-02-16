---
title: "Sample: Authenticate users with Dynamics 365 Customer Engagement web services (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample shows how to authenticate a user with any Microsoft Dynamics 365 Customer Engagement deployment and obtain a reference to the web services."
keywords: 
ms.date: 10/28/2019
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

---

# Sample: Authenticate users with Dynamics 365 Customer Engagement web services

This sample shows how to authenticate a user with Dynamics 365 Customer Engagement (on-premises) deployment and obtain a reference to the web services.  
  
 Download the sample: [Authenticate users with Microsoft Dynamics 365 Customer Engagement web services](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/AuthenticateWithNoHelp).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Demonstrates  
 This sample demonstrates how to authenticate a user with Dynamics 365 Customer Engagement (on-premises) deployment and make web service calls. This sample doesn’t rely on the CrmServiceHelpers.cs helper code. For a sample that does use helper code, see [Sample: QuickStart sample program](sample-quick-start.md).  
  
## Example  
 [!code-csharp[authenticatewithnohelp#authenticatewithnohelp](../snippets/csharp/CRMV8/authenticatewithnohelp/cs/authenticatewithnohelp.cs#authenticatewithnohelp)]  
  
### See also  
 [Authenticate Users with Dynamics 365 Customer Engagement Web Services](authenticate-users.md)   
 [Authenticate Office 365 Users with Dynamics 365 Customer Engagement Web Services](authenticate-office-365-users-customer-engagement-web-services.md)   
 [Connect with Microsoft Office 365 and Dynamics 365 Customer Engagement](connect-microsoft-office-365.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]