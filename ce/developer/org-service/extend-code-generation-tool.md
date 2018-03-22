---
title: "Create extensions for the code generation tool | MicrosoftDocs"
description: "You can extend the functionality of the code generation tool by specifying additional command-line parameters and parameter values."
keywords: ""
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
author: "JimDaly"
ms.assetid: 00533626-2587-4bb2-ad82-98560024794e
ms.author: jdaly
manager: jdaly
---

# Create extensions for the code generation tool

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

You can extend the functionality of the code generation tool by specifying additional command-line parameters and parameter values. To specify a parameter, add the following to the command line: /\<*parametername*>:\<*class name*>,\<*assembly name*>. Note that assembly name does not include the .dll extension. As an alternative, you can add the equivalent value to the config file in the format “<add key=”\<*parametername*>” value=”\<*class name*>,\<*assembly name*>” />”.  

The following table lists the parameters that you can use.  

|Parameter name|Interface Name|Description|  
|--------------------|--------------------|-----------------|  
|/codecustomization|ICustomizeCodeDomService|Called after the CodeDOM generation has been completed, assuming the default instance of `ICodeGenerationService`. It is useful for generating additional classes, such as the constants in picklists.|  
|/codewriterfilter|ICodeWriterFilterService|Called during the process of CodeDOM generation, assuming the default instance of `ICodeGenerationService`, to determine whether a specific object or property should be generated.|  
|/codewritermessagefilter|ICodeWriterMessageFilterService|Called during the process of CodeDOM generation, assuming the default instance of `ICodeGenerationService`, to determine whether a specific message should be generated. This should not be used for requests/responses as these are already generated in Microsoft.Crm.Sdk.Proxy.dll and Microsoft.Xrm.Sdk.dll.|  
|/metadataproviderservice|IMetadataProviderService|Called to retrieve the metadata from the server. This may be called multiple times during the generation process, so the data should be cached.|  
|/codegenerationservice|ICodeGenerationService|Core implementation of the CodeDOM generation. If this is changed, the other extensions may not behave in the manner described.|  
|/namingservice|INamingService|Called during the CodeDOM generation to determine the name for objects, assuming the default implementation.|

The implementation of these interfaces must have one of the following constructors:

`MyNamingService`()<br />
`MyNamingService`(`INamingService``defaultService`)<br />
`MyNamingService`(`IDictionary`<`string`, `string`> `parameters`)<br />
`MyNamingService`(`INamingService``defaultService`, `IDictionary`<`string`, `string`> `parameters`)

The `Microsoft.Crm.Services.Utility` namespace is defined in CrmSvcUtil.exe. Add a reference to CrmSvcUtil.exe in your [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] code generation tool extension projects.

<a name="Generate_Enums"></a>

## Sample extension to generate enumerations for option sets

The following sample code demonstrates how to write an extension.  

[!code-csharp[CrmSvcUtilExtensions#BasicFilteringService](../../snippets/csharp/CRMV8/crmsvcutilextensions/cs/basicfilteringservice.cs#basicfilteringservice)]  

Download the sample: [CrmSvcUtilExtensions](https://code.msdn.microsoft.com/Create-extensions-for-the-b8b24d1d) and  [GeneratePickListEnums](https://code.msdn.microsoft.com/Create-extensions-for-the-3dd56a27). 

The **GeneratePicklistEnums** sample extension outputs a source code file that contains enumerations for all option sets, state codes, and status codes. For an example of how to use these enumerations, see the `SampleCode\CS\QuickStart` sample.  

### See Also

 [Create Early-Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](create-early-bound-entity-classes-code-generation-tool.md)<br />
 [Use the Early Bound Entity Classes for Create, Update and Delete](use-entity-class-create-update-delete.md)<br />
 [Troubleshooting Tips](troubleshooting-tips.md)<br />
 [Run a simple program using Customer Engagement web services](../simple-program-web-services.md)
