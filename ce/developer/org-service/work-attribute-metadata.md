---
title: "Work with attribute metadata (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates creating, retriving, updating and attributes, and creating lookup, creating a picklist that uses a global option set, inserting a new status value, updating a state value and so on. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5fc61379-4811-4b3c-9bac-2227ce5662e2
caps.latest.revision: 25
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Work with attribute metadata

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic uses code snippets from the [Sample: Work with Attributes](sample-work-attribute-metadata.md) to show how to perform common tasks when working with attributes.  
  
<a name="BKMK_CreateAttributes"></a>   
## Create attributes  
 You create attributes by defining one of the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> types and then passing it to the <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> message.  
  
 The following sample defines the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> for a number of different types of attributes and adds them to a `List<AttributeMetadata>`. At the end of the code the attribute definitions are passed to an instance of the <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> class and the attribute is created using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method.  
  
 The following sample assumes that the current customization prefix is ‘new’ because that is the default customization prefix for the organization solution publisher. You should use the customization prefix for the solution publisher that makes sense for your solution context.  
  
 [!code-csharp[Attributes#WorkWithAttributes2](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes2.cs#workwithattributes2)]  
  
<a name="BKMK_RetrieveAttribute"></a>   
## Retrieve an attribute  
 This sample shows how to retrieve the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> for an attribute using the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest>. This sample retrieves the metadata for a custom <xref:Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata> attribute called ‘new_string’ from the Contact entity that was created in [Create Attributes](work-attribute-metadata.md#BKMK_CreateAttributes).  
  
> [!NOTE]
>  Because <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest.RetrieveAsIfPublished> is true, this request returns the current unpublished definition of this attribute. You might use this if you are creating an Attribute editor and you want to retrieve the unpublished definition of the attribute. Otherwise, you should not specify `RetrieveAsIfPublished`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Retrieving unpublished metadata](../customize-dev/publish-customizations.md#retrieving-unpublished-metadata).  
  
 [!code-csharp[Attributes#WorkWithAttributes4](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes4.cs#workwithattributes4)]  
  
<a name="BKMK_UpdateAttribute"></a>   
## Update an attribute  
 This sample shows how to update an attribute. This sample uses the <xref:Microsoft.Xrm.Sdk.Messages.UpdateAttributeRequest> to change the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.DisplayName> property of a previously retrieved custom attribute for the `Contact` entity.  
  
 [!code-csharp[Attributes#WorkWithAttributes5](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes5.cs#workwithattributes5)]  
  
<a name="BKMK_CreateLookupAttribute"></a>   
## Create a lookup attribute  
 A lookup attribute is created by using the <xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest>.  
  
 This sample code shows how to create a lookup attribute. For the complete sample, see [Sample: Create and update entity metadata](sample-create-update-entity-metadata.md)  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata5](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata5.cs#createupdateentitymetadata5)]  
  
<a name="BKMK_createcustlookup"></a>   
## Create a customer lookup attribute  
 Unlike a lookup attribute, a customer lookup attribute is created using the <xref:Microsoft.Xrm.Sdk.Messages.CreateCustomerRelationshipsRequest> message, which adds two relationships to the lookup attribute: one to the `Account` entity and the other one to the `Contact` entity. You cannot add relationship to any other entity except for `Account` and `Contact` entities for a customer lookup attribute.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../../includes/cc-feature-included-with-update-8-1-0-admins.md)]  
  
 This sample code shows how to create a customer lookup attribute. For the complete sample, see [Sample: Create and update entity metadata](sample-create-update-entity-metadata.md)  
  
 [!code-csharp[Entities#CreateUpdateEntityMetadata13](../../snippets/csharp/CRMV8/entities/cs/createupdateentitymetadata13.cs#createupdateentitymetadata13)]  
  
<a name="BKMK_CreatePicklistGlobalOptionSet"></a>   
## Create a picklist that uses a global option set  
 This sample shows how to create a <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute that is associated with a global option set.  
  
 The following sample uses <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> to set the options for a <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute to use a global option set with a name represented by the string variable `_globalOptionSetName`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Customize Global Option Sets in Dynamics 365](customize-global-option-sets.md)  
  
 [!code-csharp[OptionSets#WorkwithGlobalOptionSets3](../../snippets/csharp/CRMV8/optionsets/cs/workwithglobaloptionsets3.cs#workwithglobaloptionsets3)]  
  
<a name="BKMK_InsertNewStatusValue"></a>   
## Insert a new status value  
 This sample shows how to insert a new **Status Reason** option for <xref:Microsoft.Xrm.Sdk.Metadata.StatusAttributeMetadata> attribute.  
  
 The following sample uses the <xref:Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest> to specify a new option for the `Contact` entity `Contact.StatusCode` attribute that is valid when the `Contact.StateCode` is 0 (Active). The <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method processes the request.  
  
 The following sample allows two valid **Status Reason** options for active contacts: **Active** and **Dormant**.  
  
 [!code-csharp[Attributes#WorkWithAttributes3](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes3.cs#workwithattributes3)]  
  
<a name="BKMK_UpdateStateValue"></a>   
## Update a state value  
 This sample shows how to change the label for an option in a <xref:Microsoft.Xrm.Sdk.Metadata.StateAttributeMetadata> attribute.  
  
 The following sample uses <xref:Microsoft.Xrm.Sdk.Messages.UpdateStateValueRequest> to change the `Contact.StateCode` option label from **Active** to **Open**.  
  
 [!code-csharp[Attributes#WorkWithAttributes6](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes6.cs#workwithattributes6)]  
  
 You cannot add or remove `StateCode` options, but you can change the labels for the options.  
  
<a name="BKMK_InsertNewOptionLocalOptionSet"></a>   
## Insert a new option in a local option set  
 This sample shows how to add a new option to a local option set. The following sample uses <xref:Microsoft.Xrm.Sdk.Messages.InsertOptionValueRequest> to add a new option to a custom <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute for the `Contact` entity.  
  
 [!code-csharp[Attributes#WorkWithAttributes7](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes7.cs#workwithattributes7)]  
  
<a name="BKMK_ChangeOrderOptionLocalOptionSet"></a>   
## Change the order of options in a local option set  
 This sample shows how to change the order of options in a local option set. The following sample retrieves a custom <xref:Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata> attribute and changes the order of the original options using the [OrderBy](https://msdn.microsoft.com/library/system.linq.enumerable.orderby.aspx)**LINQ** function to sort items in ascending order by the label text. Then it uses <xref:Microsoft.Xrm.Sdk.Messages.OrderOptionRequest> to set the new order of the options for the attribute.  
  
 Use the [OrderByDecending](https://msdn.microsoft.com/library/system.linq.enumerable.orderbydescending.aspx) linq function to order the items in descending order.  
  
 [!code-csharp[Attributes#WorkWithAttributes8](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes8.cs#workwithattributes8)]  
  
<a name="BKMK_DeleteAttribute"></a>   
## Delete an attribute  
 This sample shows how to delete attributes stored in a `List<`<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>`>` that were created for the `Contact` entity in [Create Attributes](work-attribute-metadata.md#BKMK_CreateAttributes). For each <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata> the <xref:Microsoft.Xrm.Sdk.Messages.DeleteAttributeRequest> prepares the request that is processed using <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*>.  
  
 [!code-csharp[Attributes#WorkWithAttributes9](../../snippets/csharp/CRMV8/attributes/cs/workwithattributes9.cs#workwithattributes9)]  
  
### See also  
 [Customize entity attribute metadata](../customize-entity-attribute-metadata.md)   
 [Entity Attribute Metadata Messages](../entity-attribute-metadata-messages.md)   
 [Sample: Work with Attributes](sample-work-attribute-metadata.md)   
 [Customize Entity and Attribute Mappings](../customize-entity-attribute-mappings.md)
