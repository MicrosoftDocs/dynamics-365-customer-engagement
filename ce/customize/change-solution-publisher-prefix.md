---
title: "Change the solution publisher prefix (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ece684h8-ad40-4bfa-975a-3e5bafb854aa
caps.latest.revision: 55
ms.author: "rdubois"
manager: "brycho"
---

<a name="BKMK_SolutionPublisher"></a>   
# Change the solution publisher prefix for the default publisher  

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

 Every solution has a publisher. The default solution has a publisher named “Default Publisher for \<your organization name>”.  
  
 The publisher record contains a **Prefix** value. The default value of this prefix is “new”. When you create new solution components, this prefix will be appended to the name. This is a quick way that allows people to understand what solution the components are part of.  
  
 Before you start customizing the system we recommend that you change the prefix value for the default publisher to something that identifies your company.  
  
## To change the solution publisher prefix
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Select **Publishers**.  
  
3.  If there is more than one publisher, open the one with the **Display Name** that starts with **Default Publisher for** *\<your organization name>*.  
  
4.  At the bottom of the form, update the **Prefix** field to change the default value of “new” to something that identifies your organization.  
  
5.  When you change the value, make sure to tab to the next field. The **Option Value Prefix** will automatically generate a number based on the customization prefix. This number is used when you add options to option sets and provides an indicator of which solution was used to add the option.  
