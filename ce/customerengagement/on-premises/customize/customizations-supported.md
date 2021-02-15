---
title: "Supported and unsupported customization | MicrosoftDocs"
description: "Learn about what kinds of customizations are supported and what kind are not"
ms.custom: 
ms.date: 05/20/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.assetid: e9810433-224b-4bde-851a-e581cf5fb8a4
caps.latest.revision: 21
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---

# Supported and unsupported customization

Developers who extend Dynamics 365 Customer Engagement (on-premises) have a responsibility to follow rules and best practices documented in the SDK: [Best practices for developing with Dynamics 365 Customer Engagement (on-premises)](../developer/best-practices-sdk.md). The SDK documents the APIs available to developers and provides guidance about how to best use them. [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] supports only the APIs and practices that are documented in the SDK. You may find something on the Internet that describes how you can solve a problem, but if it doesn’t leverage APIs documented in the SDK, it isn’t supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. Before you have a developer apply a change you should verify whether it uses supported methods.  
  
 If developers use the APIs and best practices described in the SDK we can be sure to test whether any of the changes we make to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] has the potential to break existing customizations. Our goal is that code customizations written using supported methods will continue to work when new versions or updates of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps are released. You benefit because you can upgrade to new versions with improved features without having developers change their code each time.  
  
 If we detect that a change in a new version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps will cause a supported customization to break, we will document what is affected and how people can change their code to fix it.  
  
<a name="BKMK_Unsupported"></a>   
## What kinds of customizations aren’t supported with Dynamics 365 Customer Engagement (on-premises)?  
 Just because certain APIs and programming practices aren’t supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] doesn’t mean that they don’t work. “Unsupported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]” means exactly what it says: you can’t get support about these APIs or programming practices from [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. We don’t test them and we don’t know if something we change will break them. We can’t predict what will happen if someone changes code in our application.  
  
 The developer who uses unsupported APIs and programming practices assumes the responsibility to support their code. They will need to test their code to make sure it works.  
  
 If you choose to use unsupported customizations in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps deployment you should be sure to document what was done and have a strategy to remove those customizations before you contact Dynamics 365 Customer Engagement (on-premises) Technical Support. If you need help with unsupported customizations, contact the developer or organization who prepared the customizations.  
  
<a name="BKMK_CommonUnsupportedCustomizations"></a>   
### Common unsupported customization practices  
 The following is a list of common customization practices that aren’t supported. This is not a complete list. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Supported extensions for Dynamics 365 Customer Engagement (on-premises): Unsupported customizations](../developer/supported-extensions.md#Unsupported). 
 
**Interacting with the web application Document Object Model (DOM) elements using JavaScript**  
 Any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries used anywhere in the application must only interact with the documented APIs. When [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developers work with applications they frequently access DOM elements using specific names. Because Dynamics 365 Customer Engagement (on-premises) is a web application these techniques work, but they are likely to break during an update because the names of the elements they reference are subject to change at any time. We reserve the right to make any changes necessary in the application and this frequently means changing how the page is constructed. Adding any changes that depend on the current structure of the page means that you’ll need to invest in testing and perhaps changing the custom code in these scripts each time you apply an update to your application.  
  
 jQuery is a very common library used by [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developers. Most of the benefit of using jQuery is that it simplifies a developer’s ability to access and create DOM elements, which is exactly what we do not support in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps application pages. jQuery is recommended when developers are creating custom user interfaces with HTML web resources, but within the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]apps application pages, the supported APIs do not require jQuery to be used.  
  
 **Using any undocumented internal objects or methods using JavaScript**  
 Dynamics 365 Customer Engagement (on-premises) uses many [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] objects within pages. A [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developer can discover these objects by debugging a page and then access and reuse these objects. We reserve the right to make any changes necessary to these objects, including removing them or changing the names of the methods. If a script references these objects, the script will break if they are not found.  <a name="BKMK_Metadata"></a>   

### See also
[App making and customization overview for Dynamics 365 for Customer Engagement, version 9 (on-premises)](overview.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]