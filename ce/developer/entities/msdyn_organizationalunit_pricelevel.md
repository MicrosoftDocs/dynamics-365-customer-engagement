---
title: "msdyn_organizationalunit_pricelevel Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_organizationalunit_pricelevel entity."
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
# msdyn_organizationalunit_pricelevel Entity Reference




## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_organizationalunit_pricelevelset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: <br />
**DisplayCollectionName**: <br />
**SchemaName**: msdyn_organizationalunit_pricelevel<br />
**CollectionSchemaName**: <br />
**LogicalName**: msdyn_organizationalunit_pricelevel<br />
**LogicalCollectionName**: <br />
**EntitySetName**: msdyn_organizationalunit_pricelevelset<br />
**PrimaryIdAttribute**: msdyn_organizationalunit_pricelevelid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [msdyn_organizationalunit_pricelevelId](#BKMK_msdyn_organizationalunit_pricelevelId)
- [msdyn_organizationalunitid](#BKMK_msdyn_organizationalunitid)
- [pricelevelid](#BKMK_pricelevelid)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_msdyn_organizationalunit_pricelevelId"></a> msdyn_organizationalunit_pricelevelId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_organizationalunit_pricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_organizationalunitid"></a> msdyn_organizationalunitid

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_organizationalunitid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_pricelevelid"></a> pricelevelid

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: pricelevelid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="manytomany"></a>

## Many-To-Many Relationships

Relationship details provided where the msdyn_organizationalunit_pricelevel entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_organizationalunit_pricelevel"></a> msdyn_organizationalunit_pricelevel

See msdyn_organizationalunit Entity [msdyn_organizationalunit_pricelevel](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_pricelevel) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_organizationalunit_pricelevel?text=msdyn_organizationalunit_pricelevel EntityType" />