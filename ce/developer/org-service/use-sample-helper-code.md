---
title: "Use the Organization Service sample and helper code (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Some tasks that are common to all Dynamics 365 samples such as connecting to Dynamics 365 Customer Engagement web services, registering a computing device with Microsoft account and creating additional users in Active Directory and Dynamics 365 (online) Customer Engagement are done using the sample helper code available in Developers Guide for Dynamics 365 Customer Engagement (SDK)."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3afa448b-aa1d-42bb-a725-23b7f5eeb411
caps.latest.revision: 36
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use the Organization Service sample and helper code

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Most managed code samples provided in the [!INCLUDE [pn-sdk](../../includes/pn-sdk.md)] that use the organization and discovery web services are using shared helper code to perform common tasks. You might find this helper code useful in applications that you write. This sample code is available as a NuGet package: [Microsoft.CrmSdk.Samples.HelperCode-CS](https://www.nuget.org/packages/Microsoft.CrmSdk.Samples.HelperCode-CS)
  
 When writing an application that uses the .NET SDK assemblies, you typically have to perform a number of steps to configure your application’s project. To learn more about setting up a project in [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)], or other development environment, see [Start a managed code project in Visual Studio](start-managed-code-project-visual-studio.md).  
  
To view a sample application that uses the helper code and includes the required .NET references, see [Run a simple program using Customer Engagement web services](../simple-program-web-services.md).  
  
 A non-customized early-bound types file that is named `MyOrganizationCrmSdkTypes` is included in the `Microsoft.CrmSdk.Samples.HelperCode-CS` NuGet package to help get you started. However, if your organization has custom or customized entities, you should generate a new early-bound types file. For the purposes of this documentation, the generated classes are included in the global namespace. For more information, see [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md).  
  
### See also  
 [Extend Dynamics 365 Customer Engagement on the server](../extend-dynamics-365-server.md)   
 [Best practices for developing with Dynamics 365 Customer Engagement](../best-practices-sdk.md)   
 [Helper Code: ServerConnection Class](helper-code-serverconnection-class.md)  
 [Helper Code: SystemUserProvider class](helper-code-systemuserprovider-class.md)   
 [Helper Code: Enumerations for Option Sets](helper-code-enumerations-option-sets.md)   
 [Sample code directory for Dynamics 365 Customer Engagement](../sample-code-directory.md)   
 [Assemblies Included in the Dynamics 365 SDK](assemblies-included-sdk.md)   
 [Use Dynamics 365 Services in Code](use-services-in-code.md)
