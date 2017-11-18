---
title: "TeamProfiles Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TeamProfiles entity."
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
# TeamProfiles Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Team Profiles


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/teamprofilescollection<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: Team Profiles<br />
**DisplayCollectionName**: Team Profiles<br />
**SchemaName**: TeamProfiles<br />
**CollectionSchemaName**: TeamProfiles<br />
**LogicalName**: teamprofiles<br />
**LogicalCollectionName**: teamprofilescollection<br />
**EntitySetName**: teamprofilescollection<br />
**PrimaryIdAttribute**: teamprofileid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


### <a name="BKMK_TeamProfileId"></a> TeamProfileId

**Description**: For internal use only.<br />
**DisplayName**: <br />
**LogicalName**: teamprofileid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [FieldSecurityProfileId](#BKMK_FieldSecurityProfileId)
- [TeamId](#BKMK_TeamId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_FieldSecurityProfileId"></a> FieldSecurityProfileId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: fieldsecurityprofileid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_TeamId"></a> TeamId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: teamid<br />
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

Relationship details provided where the TeamProfiles entity is the first entity in the relationship. Listed by **SchemaName**.


### <a name="BKMK_teamprofiles_association"></a> teamprofiles_association

See team Entity [teamprofiles_association](team.md#BKMK_teamprofiles_association) Many-To-Many Relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.teamprofiles?text=teamprofiles EntityType" />