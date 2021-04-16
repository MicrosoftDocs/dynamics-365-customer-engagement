---
title: "Use solutions for your customizations (Dynamics 365 Customer Engagement on-premises) | MicrosoftDocs"
description: "Learn how to customize the default solution"
ms.custom: 
ms.date: 02/28/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: f993c4ed-1fc3-4e47-bef1-d38695ddb11a
caps.latest.revision: 57
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Use a solution to customize  
[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Use the Common Data Services Default Solution](/powerapps/maker/common-data-service/use-solutions-for-your-customizations)

We recommend that you create a solution to manage your customizations. With a custom solution, you can easily find just the solution components you’ve customized, consistently apply your solution publisher prefix, and export your solution for distribution to other environments.  

If you don’t use a custom solution, you'll be working in the default solution in the unmanaged layer. The Default Solution is a special solution that contains all components in the system. The default solution is useful for discovering all of the components and configurations in your system.  

## Why you shouldn’t use the Default Solution to manage customizations
There are a few reasons why you shouldn’t create apps and make customizations in the Default Solution:  
- The Default Solution contains all components and customizations from all solutions in the environment. 
- It is difficult to locate or identify the customizations you have made in the environment using the Default Solution. 
- Using the Default Solution, when creating components will also use the default publisher assigned to it. This may result in the wrong publisher prefix being applied to some components. 
- The Default Solution can’t be exported. Therefore, you can’t distribute the Default Solution to another environment.  
 
<a name="BKMK_PrivacyNotice"></a>   

## Privacy notices  
 [!INCLUDE[cc_privacy_crm_gcc_solution_import](../includes/cc-privacy-crm-gcc-solution-import.md)]  
  
 [!INCLUDE[cc_privacy_crm_customizations](../includes/cc-privacy-crm-customizations.md)]  
  
### See also  
 [Customization overview](../customize/overview.md)<br/>
 [Getting started with customization](Getting-started-customization.md)  
 [Privileges required for customization](Privileges-required-customization.md)<br/>
 [Whitepaper: Patterns and Principles for Solution Builders](https://go.microsoft.com/fwlink/p/?LinkID=533946)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]