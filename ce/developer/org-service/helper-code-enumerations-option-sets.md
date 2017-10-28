---
title: "Helper code: Enumerations for option sets (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The SDK download package includes an extension to the CrmSvcUtil code generation tool that you can use to generate enumerations for all option set values including global option sets, picklist, state, and status values."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "enumerations for option sets, helper code samples"
  - "using an enumeration to set values in the account entity sample"
  - "helper code samples, using CrmSvcUtil.exe to generate enumerations for all option set values"
  - "sample for using an enumeration to set values in the account entity"
  - "helper code samples, enumerations for option sets"
ms.assetid: 9ca7cb42-2b16-4429-8205-04f27e7eeb54
caps.latest.revision: 25
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Helper code: Enumerations for option sets
The SDK download package includes an extension to the CrmSvcUtil code generation tool that you can use to generate enumerations for all option set values including global option sets, picklist, state, and status values. For more information, see [Sample Extension to Generate Enumerations for Option Sets](extend-code-generation-tool.md#Generate_Enums). In addition, it includes a helper code file that contains the enumerations generated for all out-of-the-box values. These enumerations can be used in your code by adding the file `SampleCode\CS\HelperCode\OptionSets.cs` or `SampleCode\VB\HelperCode\OptionSets.vb` to your project.  
  
 Each numeration can be used to test or set the value for a property. Typically this property is an entity attribute but there are a few that are used for other properties.  
  
## Usage Example  
 The following example shows how to use one of these enumerations to set a value in the `Account` entity.  
  
 [!code-csharp[QuickStartCS#CRUDOperations2](../../snippets/csharp/CRMV8/quickstartcs/cs/crudoperations2.cs#crudoperations2)]  
  
 [!code-vb[QuickStartVB#CRUDOperations2](../../snippets/visualbasic/CRMV8/quickstartvb/vb/crudoperations2.vb#crudoperations2)]  
  
### See also  
 [Use the Sample and Helper Code](use-sample-helper-code.md)   
 [Helper code: ServerConnectionclass](helper-code-serverconnection-class.md)   
 [Helper code: SystemUserProviderclass](helper-code-systemuserprovider-class.md)   
 [Sample Extension to Generate Enumerations for Option Sets](extend-code-generation-tool.md#Generate_Enums)   
 [Quick Start: A Simple Program](simple-program-web-services.md)
