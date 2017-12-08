---
title: "msdyn_organizationalunit_pricelevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_organizationalunit_pricelevel entity."
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
# msdyn_organizationalunit_pricelevel Entity Reference




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_organizationalunit_pricelevelset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName||
|DisplayCollectionName||
|DisplayName||
|EntitySetName|msdyn_organizationalunit_pricelevelset|
|IsBPFEntity|False|
|LogicalCollectionName||
|LogicalName|msdyn_organizationalunit_pricelevel|
|OwnershipType|None|
|PrimaryIdAttribute|msdyn_organizationalunit_pricelevelid|
|PrimaryNameAttribute||
|SchemaName|msdyn_organizationalunit_pricelevel|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [msdyn_organizationalunit_pricelevelId](#BKMK_msdyn_organizationalunit_pricelevelId)
- [msdyn_organizationalunitid](#BKMK_msdyn_organizationalunitid)
- [pricelevelid](#BKMK_pricelevelid)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_msdyn_organizationalunit_pricelevelId"></a> msdyn_organizationalunit_pricelevelId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunit_pricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_organizationalunitid"></a> msdyn_organizationalunitid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunitid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_pricelevelid"></a> pricelevelid

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricelevelid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_organizationalunit_pricelevel entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_organizationalunit_pricelevel"></a> msdyn_organizationalunit_pricelevel

See msdyn_organizationalunit Entity [msdyn_organizationalunit_pricelevel](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_pricelevel) Many-To-Many Relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_organizationalunit_pricelevel?text=msdyn_organizationalunit_pricelevel EntityType" />