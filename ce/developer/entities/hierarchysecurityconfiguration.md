---
title: "HierarchySecurityConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the HierarchySecurityConfiguration entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# HierarchySecurityConfiguration Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations(*hierarchysecuritymodelingsettingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: Hierarchy Security Configuration<br />
**DisplayCollectionName**: Hierarchy Security Configurations<br />
**SchemaName**: HierarchySecurityConfiguration<br />
**CollectionSchemaName**: HierarchySecurityConfiguration<br />
**LogicalName**: hierarchysecurityconfiguration<br />
**LogicalCollectionName**: hierarchysecurityconfigurations<br />
**EntitySetName**: hierarchysecurityconfigurations<br />
**PrimaryIdAttribute**: hierarchysecuritymodelingsettingid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityName](#BKMK_EntityName)
- [HierarchySecurityModelingSettingId](#BKMK_HierarchySecurityModelingSettingId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_EntityName"></a> EntityName

**Description**: Logical entity name of the entity that is configured for hierarchy security.<br />
**DisplayName**: Entity Name<br />
**LogicalName**: entityname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**IsValidForUpdate**: False<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 64


### <a name="BKMK_HierarchySecurityModelingSettingId"></a> HierarchySecurityModelingSettingId

**Description**: Shows the entity used for the Hierarchy Security Modeling Configuration.<br />
**DisplayName**: <br />
**LogicalName**: hierarchysecuritymodelingsettingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />



## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.hierarchysecurityconfiguration?text=hierarchysecurityconfiguration EntityType" />