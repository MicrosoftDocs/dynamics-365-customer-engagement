---
title: "Implement single sign-on from an ASPX webpage or IFRAME (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This topic describes how to develop a custom webpage that can make SDK calls to Dynamics 365 Customer Engagement (on-premises) on behalf of the Dynamics 365 Customer Engagement (on-premises) user who is signed in"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - single sign-on from an ASPX webpage or IFRAME, implementing
  - ASPX webpage with (optionally) IFRAME display, implementing single sign-on from an ASPX webpage or IFRAME
  - Windows Azure-hosted webpage, implementing single sign-on from an ASPX webpage or IFRAME
  - implementing single sign-on from an ASPX webpage or IFRAME, ASPX webpage with (optionally) IFRAME display
  - custom website makes SDK calls to CRM on behalf of logged-on user, separate website for
ms.assetid: c2b38554-eab9-4793-a2f5-62b7a11d99f7
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Implement single sign-on from an ASPX webpage or IFRAME

This topic describes how to develop a custom webpage that can make SDK calls to Dynamics 365 Customer Engagement (on-premises) on behalf of the Dynamics 365 Customer Engagement (on-premises) user who is signed in. The typical use of this capability is to write a webpage that is displayed in an inline frame in the Dynamics 365 Customer Engagement (on-premises) web application user interface. That webpage performs its intended operation, for example, providing a store front, while being hosted on a website independent of the site that’s hosting [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. However, the webpage can perform its operations on behalf of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user who is signed in. The result is seamless integration between a webpage and Dynamics 365 Customer Engagement (on-premises).  
  
## Dynamics 365 Customer Engagement (on-premises) with a separate website  
 This scenario is for a Dynamics 365 Customer Engagement (on-premises) Internet-facing deployment (IFD) where a separate website hosts a custom ASPX webpage that is optionally displayed in an inline frame of the Dynamics 365 Customer Engagement (on-premises) web application. This scenario uses federated claims. Therefore, you’ll have to set up a security token service (STS) server for identity management. You’ll also need a certificate to be used when making Dynamics 365 Customer Engagement (on-premises) and the website relying parties, which established cross-domain trust between these parties.  
  
### Background information  
 For more information about how to configure claims and a relying party, see the following topics in [Deploying and administering Microsoft Dynamics 365 Customer Engagement (on-premises)](https://technet.microsoft.com/library/hh699811.aspx):  
  
- [Post-Installation and Configuration Guidelines](https://technet.microsoft.com/library/hh699726.aspx) - Configure a Dynamics 365 Customer Engagement (on-premises) Internet-facing deployment (IFD)  
  
- [System requirements and required technologies](https://technet.microsoft.com/library/hh699831.aspx) - Accessing Dynamics 365 Customer Engagement (on-premises) from the Internet - Claims-based authentication and [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)] requirements  
  
  For more information about identity management, see [the identity training course](https://channel9.msdn.com/Learn/Courses/IdentityTrainingCourse).  
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough: Single Sign-on from a Custom Web Page](https://msdn.microsoft.com/library/gg509057\(v=crm.5\).aspx) in the [!INCLUDE[pn_CRM_2011](../includes/pn-crm-2011.md)] SDK.  
  
<a name="crmonline-azure"></a>   
## Dynamics 365 Customer Engagement (on-premises) with an Azure-hosted webpage  
 This scenario is for use with Dynamics 365 Customer Engagement (on-premises) where [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] hosts a custom webpage that’s optionally displayed in an inline frame of the Dynamics 365 Customer Engagement (on-premises) web application. This scenario uses federated claims, provided by the [!INCLUDE[pn_Windows_Live](../includes/pn-windows-live.md)] security token service (STS) server for identity management. You must provide a certificate to be used when making Dynamics 365 Customer Engagement (on-premises) and the [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] website relying parties, which established cross-domain trust between these parties.  
  
### Background information  
 For more information about how to configure a relying party, see the following topic: [Secure Azure Web Role ASP.NET Web Application Using Access Control Service v2.0](https://social.technet.microsoft.com/wiki/contents/articles/2590.aspx)  
  
 For more information about identity management, see [https://channel9.msdn.com/Learn/Courses/IdentityTrainingCourse](https://channel9.msdn.com/Learn/Courses/IdentityTrainingCourse)  
  
 For more information about implementing this scenario including problems you may run into and the workarounds, see these blogs: [Dynamics 365 Customer Engagement (on-premises) & Azure: Improving the SSO experience](https://blogs.msdn.com/b/devkeydet/archive/2013/01/14/crm-online-amp-windows-azure-improving-the-sso-experience.aspx), and [Dynamics 365 Customer Engagement (on-premises) & Azure Series](https://blogs.msdn.com/b/devkeydet/archive/2013/01/27/crm-online-amp-windows-azure-series.aspx).  
  
<a name="BKMK_EnableIFrameCommunicationAccrossDomains"></a>   
## Enable inline frame communication across domains  
 If you want to enable communication for an inline frame (iframe) that contains content from a different domain, you can use the `Window.postMessage` method. This browser method can be used for [!INCLUDE[pn_IE_8](../includes/pn-ie-8.md)]. [!INCLUDE[tn_Google_Chrome](../includes/tn-google-chrome.md)], [!INCLUDE[tn_Mozilla_Firefox](../includes/tn-mozilla-firefox.md)], and [!INCLUDE[tn_Apple_Safari](../includes/tn-apple-safari.md)] also support this method. For more information about using `postMessage`, see the following blog posts:  
  
-   [Cross domain calls to the parent CRM 2011 form](https://blogs.msdn.com/b/devkeydet/archive/2012/02/14/cross-domain-calls-to-the-parent-crm-2011-form.aspx)  
  
-   [Cross-Document Messaging and RPC](https://msdn.microsoft.com/magazine/ff800814.aspx)  
  
### See also  
 [Access the Web Services (Authentication) in Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md)   
 [Sample: Impersonate Using the ActOnBehalfOf Privilege](org-service/sample-impersonate-actonbehalfof-privilege.md)   
 [Impersonate Another User](org-service/impersonate-another-user.md)   
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]