---
title: "Customize global option sets | MicrosoftDocs"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6786ff10-0e38-4f5c-b973-c682d1d60de5
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Customize global option sets
Typically, you use global option sets to set fields so that different fields can share the same set of options, which are maintained in one location. You can reuse global option sets. You will also see them used in request parameters in a manner similar to an enumeration.  
  
 When you define an option value by using <xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest>, 
 we recommend that you let the system assign a value. You do this by passing a **null** value when you create the 
 new `OptionMetadata` instance. When you define an option, it will contain an option value prefix specific to the 
 context of the publisher set for the solution that the option set is created in. 
 This prefix helps reduce the chance of creating duplicate option sets for a managed solution, 
 and in any option sets that are defined in organizations where your managed solution is installed. For more information, 
 see [Merge option set options](../understand-managed-solutions-merged.md#merge-option-set-options).  
 
 ## Messages  
 The following table lists the messages that you can use with global option sets.  
  
|Message|Description|  
|-------------|-----------------------------------------------------------------|  
|[CreateOptionSetRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.createoptionsetrequest)|Creates a new global option set.|  
|[DeleteOptionSetRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.deleteoptionsetrequest)|Deletes a global option set.|  
|[DeleteOptionValueRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.deleteoptionvaluerequest)|Deletes one of the values in a global option set.|  
|[InsertOptionValueRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.insertoptionvaluerequest)|Inserts a new option into a global option set.|  
|[InsertStatusValueRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.insertstatusvaluerequest)|Inserts a new option into the global option set used in the `Status` attribute.|  
|[OrderOptionRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.orderoptionrequest)|Changes the relative order of the options in an option set.|  
|[RetrieveAllOptionSetsRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.retrievealloptionsetsrequest)|Retrieves all the global option sets.|  
|[RetrieveOptionSetRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.retrieveoptionsetrequest)|Retrieves a global option set.|  
|[UpdateOptionSetRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.updateoptionsetrequest)|Updates a global option set.|  
|[UpdateOptionValueRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.updateoptionvaluerequest)|Updates an option in a global option set.|  
|[UpdateStateValueRequest](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.messages.updatestatevaluerequest)|Inserts a new option into the option set used in the `Status` attribute.|  

<a name="BKMK_RetrieveAGlobalOptionSet"></a>   
## Retrieve a global option set  
 The following sample shows how to retrieve a global option set by name using the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveOptionSetRequest> message:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets6](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets6.cs#workwithglobaloptionsets6)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets6](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets6.vb#workwithglobaloptionsets6)]  
  
<a name="BKMK_CreateGlobalOptionSet"></a>   
## Create a global option set  
 Use the <xref:Microsoft.Xrm.Sdk.Messages.CreateOptionSetRequest> message to create a new global option set. Set the 
 <xref:Microsoft.Xrm.Sdk.Metadata.OptionSetMetadataBase.IsGlobal> property to `true` to indicate that the option set is global. The following code example creates a global option set called “Example Option Set”:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets2](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets2.cs#workwithglobaloptionsets2)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets2](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets2.vb#workwithglobaloptionsets2)]  
  
<a name="BKMK_CreatePicklistWithGlobalOptionSet"></a>   
## Create a picklist that uses a global option set  
 The following sample shows how to create a picklist attribute that uses a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets3](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets3.cs#workwithglobaloptionsets3)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets3](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets3.vb#workwithglobaloptionsets3)]  
  
<a name="BKMK_UpdateGlobalOptionSet"></a>   
## Update a global option set  
 The following sample shows how to update the label for a global option set by using 
 <xref:Microsoft.Xrm.Sdk.Messages.UpdateOptionSetRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets4](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets4.cs#workwithglobaloptionsets4)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets4](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets4.vb#workwithglobaloptionsets4)]  
  
<a name="BKMK_OrderingOptions"></a>   
## Ordering options  
 The following sample shows how the options in a global option set can be ordered by using 
 <xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets8](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets8.cs#workwithglobaloptionsets8)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets8](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets8.vb#workwithglobaloptionsets8)]  
  
<a name="BKMK_RetrieveAllGlobalOptionSets"></a>   
## Retrieve all global option sets  
 The following sample shows how to retrieve all global option sets by using 
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllOptionSetsRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets9](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets9.cs#workwithglobaloptionsets9)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets9](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets9.vb#workwithglobaloptionsets9)]  
  
<a name="BKMK_DeleteAGlobalOptionSet"></a>   
## Delete a global option set  
 The following sample shows how to check whether a global option set is being used by another solution component by using <xref:Microsoft.Crm.Sdk.Messages.RetrieveDependentComponentsRequest>, and then how to delete it by using <xref:Microsoft.Xrm.Sdk.Messages.DeleteOptionSetRequest>:  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets12](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets12.cs#workwithglobaloptionsets12)]  
  
 [!code-vb[OptionSetsVB#WorkwithGlobalOptionSets12](../../snippets/visualbasic/CRMV8/optionsetsvb/vb/workwithglobaloptionsets12.vb#workwithglobaloptionsets12)]  
  
### See also  
 [Customize Dynamics 365 Customer Engagement applications](../customize-dev/customize-applications.md)   
 [Extend the Metadata Model for Dynamics 365](use-organization-service-metadata.md)   
 [Insert, update, delete, and order global option set options](insert-update-delete-order-global-option-set-options.md)   
 [Sample: Create Global Option Set](sample-create-global-option-set.md)   
 [Sample: Work with Global Option Sets](sample-work-global-option-sets.md)   
 [Sample: Dump Global Option Set Information to a File](sample-dump-global-option-set-information-file.md)
