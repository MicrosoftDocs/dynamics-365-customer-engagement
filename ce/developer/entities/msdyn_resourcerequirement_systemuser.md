---
title: "msdyn_resourcerequirement_systemuser Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcerequirement_systemuser entity."
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
# msdyn_resourcerequirement_systemuser Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcerequirement_systemuserset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: <br />
**DisplayCollectionName**: <br />
**SchemaName**: msdyn_resourcerequirement_systemuser<br />
**CollectionSchemaName**: <br />
**LogicalName**: msdyn_resourcerequirement_systemuser<br />
**LogicalCollectionName**: <br />
**EntitySetName**: msdyn_resourcerequirement_systemuserset<br />
**PrimaryIdAttribute**: msdyn_resourcerequirement_systemuserid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [msdyn_resourcerequirement_systemuserId](#BKMK_msdyn_resourcerequirement_systemuserId)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
- [systemuserid](#BKMK_systemuserid)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_msdyn_resourcerequirement_systemuserId"></a> msdyn_resourcerequirement_systemuserId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcerequirement_systemuserid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcerequirementid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_systemuserid"></a> systemuserid

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: systemuserid<br />
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

Relationship details provided where the msdyn_resourcerequirement_systemuser entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_msdyn_resourcerequirement_systemuser"></a> msdyn_resourcerequirement_systemuser

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_systemuser](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_systemuser) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcerequirement_systemuser?text=msdyn_resourcerequirement_systemuser EntityType" />