---
title: "Create extensions for the code generation tool (CrmSvcUtil.exe) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: You can extend the functionality of the CrmSvcUtil.exe code generation tool by specifying additional command-line parameters and parameter values for Dynamics 365 Customer Engagement (on-premises).
keywords: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: JimDaly
ms.author: jdaly
ms.reviewer: pehecke
search.audienceType: 
  - developer
---
# Create extensions for the code generation tool

You can extend the functionality of the code generation tool by specifying additional command-line parameters and parameter values. To specify a parameter, add the following to the command line:

`<*parametername*>:<*class name*>,<*assembly name*>`

Note that assembly name does not include the .dll extension. As an alternative, you can add the equivalent value to the config file in the format:

`<add key="<*parametername*>" value="<*class name*>,<*assembly name*>" />`

The following table lists the parameters that you can use.  

|Parameter name|Interface Name|Description|  
|--------------------|--------------------|-----------------|  
|`codecustomization`|`ICustomizeCodeDomService`|Called after the CodeDOM generation has been completed, assuming the default instance of `ICodeGenerationService`. It is useful for generating additional classes, such as the constants in picklists.|  
|`codewriterfilter`|`ICodeWriterFilterService`|Called during the process of CodeDOM generation, assuming the default instance of `ICodeGenerationService`, to determine whether a specific object or property should be generated.|  
|`codewritermessagefilter`|`ICodeWriterMessageFilterService`|Called during the process of CodeDOM generation, assuming the default instance of `ICodeGenerationService`, to determine whether a specific message should be generated. This should not be used for requests/responses as these are already generated in Microsoft.Crm.Sdk.Proxy.dll and Microsoft.Xrm.Sdk.dll.|  
|`metadataproviderservice`|`IMetadataProviderService`|Called to retrieve the metadata from the server. This may be called multiple times during the generation process, so the data should be cached.|  
|`codegenerationservice`|`ICodeGenerationService`|Core implementation of the CodeDOM generation. If this is changed, the other extensions may not behave in the manner described.|  
|`namingservice`|`INamingService`|Called during the CodeDOM generation to determine the name for objects, assuming the default implementation.|

The implementation of these interfaces must have one of the following constructors:

`MyNamingService()`<br />
`MyNamingService(INamingService defaultService)`<br />
`MyNamingService(IDictionary<string, string> parameters)`<br />
`MyNamingService(INamingService defaultService, IDictionary<string, string> parameters)`

The `Microsoft.Crm.Services.Utility` namespace is defined in CrmSvcUtil.exe. Add a reference to CrmSvcUtil.exe in your Visual Studio code generation tool extension projects.

<a name="Generate_Enums"></a>

## Sample extension to generate enumerations for choices (option sets)

The following sample code demonstrates how to write an extension.  

```csharp
using System;

using Microsoft.Crm.Services.Utility;
using Microsoft.Xrm.Sdk.Metadata;

/// <summary>
/// Sample extension for the CrmSvcUtil.exe tool that generates early-bound
/// classes for custom entities.
/// </summary>
public sealed class BasicFilteringService : ICodeWriterFilterService
{
    public BasicFilteringService(ICodeWriterFilterService defaultService)
    {
        this.DefaultService = defaultService;
    }

    private ICodeWriterFilterService DefaultService { get; set; }

    bool ICodeWriterFilterService.GenerateAttribute(AttributeMetadata attributeMetadata, IServiceProvider services)
    {
        return this.DefaultService.GenerateAttribute(attributeMetadata, services);
    }

    bool ICodeWriterFilterService.GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
    {
        if (!entityMetadata.IsCustomEntity.GetValueOrDefault()) { return false; }
        return this.DefaultService.GenerateEntity(entityMetadata, services);
    }

    bool ICodeWriterFilterService.GenerateOption(OptionMetadata optionMetadata, IServiceProvider services)
    {
        return this.DefaultService.GenerateOption(optionMetadata, services);
    }

    bool ICodeWriterFilterService.GenerateOptionSet(OptionSetMetadataBase optionSetMetadata, IServiceProvider services)
    {
        return this.DefaultService.GenerateOptionSet(optionSetMetadata, services);
    }

    bool ICodeWriterFilterService.GenerateRelationship(RelationshipMetadataBase relationshipMetadata, EntityMetadata otherEntityMetadata,
    IServiceProvider services)
    {
        return this.DefaultService.GenerateRelationship(relationshipMetadata, otherEntityMetadata, services);
    }

    bool ICodeWriterFilterService.GenerateServiceContext(IServiceProvider services)
    {
        return this.DefaultService.GenerateServiceContext(services);
    }
}

```

Download the sample: [CrmSvcUtilExtensions](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BasicFilteringService) and  [GeneratePickListEnums](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/GeneratePicklistEnums).

The **GeneratePicklistEnums** sample extension outputs a source code file that contains enumerations for all option sets, state codes, and status codes.

Each enumeration can be used to test or set the value for a property. Typically this property is a table column (entity attribute) but there are a few that are used for other properties.

### Usage Example

The following example shows how to use one of these enumerations to set a value in an account.

```csharp
// Instantiate an account object. Note the use of the option set enumerations defined
// in OptionSets.cs.
Account account = new Account { Name = "Fourth Coffee" };
account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

// Create an account record named Fourth Coffee.
// Save the record reference so we can delete it during cleanup later.
Guid accountId = service.Create(account);
```

### See Also

[Create early-bound entity classes with the Code Generation tool](create-early-bound-entity-classes-code-generation-tool.md)
