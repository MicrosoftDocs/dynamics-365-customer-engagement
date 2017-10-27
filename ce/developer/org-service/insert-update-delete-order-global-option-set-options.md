---
title: "Insert, update, delete, and order global option set options (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: dfcafa54-d368-46c8-8760-19bcbc4c6797
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Insert, update, delete, and order global option set options
These code samples show you how to insert, update, delete, and order options in a global option set.  
  
<a name="BKMK_InsertNewOption"></a>   
## Insert a new option  
 The following sample shows how to add a new option to a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets5](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets5.cs#workwithglobaloptionsets5)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets5](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets5.vb#workwithglobaloptionsets5)]  
  
<a name="BKMK_UpdateAnOption"></a>   
## Update an option  
 The following sample shows how to update an option in a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionValueRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets7](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets7.cs#workwithglobaloptionsets7)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets7](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets7.vb#workwithglobaloptionsets7)]  
  
<a name="BKMK_DeleteAnOption"></a>   
## Delete an option  
 The following sample shows how to deletes an option in a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets11](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets11.cs#workwithglobaloptionsets11)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets11](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets11.vb#workwithglobaloptionsets11)]  
  
<a name="BKMK_OrderOptions"></a>   
## Order options  
 The following sample shows how to set the order of options in a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets8](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets8.cs#workwithglobaloptionsets8)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets8](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets8.vb#workwithglobaloptionsets8)]  
  
### See also  
 [Customize Global Options Sets](../org-service/customize-global-option-sets.md)   