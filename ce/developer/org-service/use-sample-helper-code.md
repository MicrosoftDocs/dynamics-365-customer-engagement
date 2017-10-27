---
title: "Use the sample and helper code (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
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
helpviewer_keywords: 
  - "shared helper code in the CRM SDK"
  - "using the sample and helper code, steps for configuring your application project in the CRM SDK"
  - "using the sample and helper code, how to run"
  - "using the sample and helper code, location of samples"
  - "Microsoft Dynamics CRM SDK, using shared helper code to perform common tasks"
  - "using the sample and helper code"
  - "using the sample and helper code, introduction to the helper code samples"
  - "using shared helper code to perform common tasks,"
ms.assetid: 3afa448b-aa1d-42bb-a725-23b7f5eeb411
caps.latest.revision: 36
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Use the sample and helper code
Most managed code samples provided in the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] that use the organization and discovery web services are using shared helper code to perform common tasks. You might find this helper code useful in applications that you write. Sample helper code can be found in the following folders in the SDK, and also by following the links provided later in this topic. [!INCLUDE[sdk_download](../../includes/sdk-download.md)]  
  
 `SDK\SampleCode\CS\HelperCode`  
  
 `SDK\SampleCode\VB\HelperCode`  
  
 When writing an application that uses the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)], you typically have to perform a number of steps to configure your application’s project. To learn more about setting up a project in [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)], or other development environment, see [Start a managed code project in Visual Studio](start-managed-code-project-visual-studio.md).  
  
 For more information about running the samples included in the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] download, see the SDK\SampleCode\Readme.docx. To view a sample application that uses the helper code and includes the required .NET references, see [Quick Start: A Simple Program](simple-program-web-services.md).  
  
 A non-customized early-bound types file that is named `MyOrganizationCrmSdkTypes` is included in the SDK download in the `SampleCode\CS\HelperCode` and `SampleCode\VB\HelperCode` folders to help get you started. However, if your organization has custom or customized entities, you should generate a new early-bound types file. For the purposes of this documentation, the generated classes are included in the global namespace. For more information, see [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md).  
  
### See also  
 [Write Code for Dynamics 365 (Web Services)](extend-dynamics-365-server.md)   
 [Best Practices for Developing with Dynamics 365](best-practices-sdk.md)   
 [Helper Code: ServerConnection Class](helper-code-serverconnection-class.md)  
 [Helper Code: SystemUserProvider class](helper-code-systemuserprovider-class.md)   
 [Helper Code: Enumerations for Option Sets](helper-code-enumerations-option-sets.md)   
 [Sample Code Directory for Dynamics 365](sample-code-directory.md)   
 [Assemblies Included in the Dynamics 365 SDK](assemblies-included-sdk.md)   
 [Use Dynamics 365 Services in Code](use-services-in-code.md)
