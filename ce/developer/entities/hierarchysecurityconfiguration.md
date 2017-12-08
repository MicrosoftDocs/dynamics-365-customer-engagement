---
title: "HierarchySecurityConfiguration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the HierarchySecurityConfiguration entity."
ms.date: 12/05/2017
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




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations(*hierarchysecuritymodelingsettingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/hierarchysecurityconfigurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|HierarchySecurityConfiguration|
|DisplayCollectionName|Hierarchy Security Configurations|
|DisplayName|Hierarchy Security Configuration|
|EntitySetName|hierarchysecurityconfigurations|
|IsBPFEntity|False|
|LogicalCollectionName|hierarchysecurityconfigurations|
|LogicalName|hierarchysecurityconfiguration|
|OwnershipType|None|
|PrimaryIdAttribute|hierarchysecuritymodelingsettingid|
|PrimaryNameAttribute||
|SchemaName|HierarchySecurityConfiguration|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [EntityName](#BKMK_EntityName)
- [HierarchySecurityModelingSettingId](#BKMK_HierarchySecurityModelingSettingId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_EntityName"></a> EntityName

|Property|Value|
|--------|-----|
|Description|Logical entity name of the entity that is configured for hierarchy security.|
|DisplayName|Entity Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|entityname|
|MaxLength|64|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_HierarchySecurityModelingSettingId"></a> HierarchySecurityModelingSettingId

|Property|Value|
|--------|-----|
|Description|Shows the entity used for the Hierarchy Security Modeling Configuration.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|hierarchysecuritymodelingsettingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|



### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.hierarchysecurityconfiguration?text=hierarchysecurityconfiguration EntityType" />