---
title: "TimeZoneDefinition Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the TimeZoneDefinition entity."
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
# TimeZoneDefinition Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Time zone definition, including name and time zone code.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|GetAllTimeZonesWithDisplayName|<xref href="Microsoft.Dynamics.CRM.GetAllTimeZonesWithDisplayName?text=GetAllTimeZonesWithDisplayName Function" />|<xref:Microsoft.Crm.Sdk.Messages.GetAllTimeZonesWithDisplayNameRequest>|
|GetTimeZoneCodeByLocalizedName|<xref href="Microsoft.Dynamics.CRM.GetTimeZoneCodeByLocalizedName?text=GetTimeZoneCodeByLocalizedName Function" />|<xref:Microsoft.Crm.Sdk.Messages.GetTimeZoneCodeByLocalizedNameRequest>|
|LocalTimeFromUtcTime||<xref:Microsoft.Crm.Sdk.Messages.LocalTimeFromUtcTimeRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/timezonedefinitions(*timezonedefinitionid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/timezonedefinitions<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|UtcTimeFromLocalTime||<xref:Microsoft.Crm.Sdk.Messages.UtcTimeFromLocalTimeRequest>|

## Entity Properties

**DisplayName**: Time Zone Definition<br />
**DisplayCollectionName**: Time Zone Definitions<br />
**SchemaName**: TimeZoneDefinition<br />
**CollectionSchemaName**: TimeZoneDefinitions<br />
**LogicalName**: timezonedefinition<br />
**LogicalCollectionName**: timezonedefinitions<br />
**EntitySetName**: timezonedefinitions<br />
**PrimaryIdAttribute**: timezonedefinitionid<br />
**PrimaryNameAttribute**: userinterfacename<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Bias](#BKMK_Bias)
- [DaylightName](#BKMK_DaylightName)
- [RetiredOrder](#BKMK_RetiredOrder)
- [StandardName](#BKMK_StandardName)
- [TimeZoneCode](#BKMK_TimeZoneCode)
- [TimeZoneDefinitionId](#BKMK_TimeZoneDefinitionId)
- [UserInterfaceName](#BKMK_UserInterfaceName)


### <a name="BKMK_Bias"></a> Bias

**Description**: Base time bias of the time zone.<br />
**DisplayName**: Bias<br />
**LogicalName**: bias<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_DaylightName"></a> DaylightName

**Description**: Time zone name for the daylight time.<br />
**DisplayName**: Daylight Name<br />
**LogicalName**: daylightname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: True<br />
**MaxLength**: 100


### <a name="BKMK_RetiredOrder"></a> RetiredOrder

**Description**: Order an entry for a time zone definition is retired. 0 for the latest entry.<br />
**DisplayName**: Retired Order<br />
**LogicalName**: retiredorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_StandardName"></a> StandardName

**Description**: Time zone name for the standard time.<br />
**DisplayName**: Standard Name<br />
**LogicalName**: standardname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: True<br />
**MaxLength**: 100


### <a name="BKMK_TimeZoneCode"></a> TimeZoneCode

**Description**: Time zone identification code.<br />
**DisplayName**: Time Zone Code<br />
**LogicalName**: timezonecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_TimeZoneDefinitionId"></a> TimeZoneDefinitionId

**Description**: Unique identifier of the time zone record.<br />
**DisplayName**: Time Zone Definition<br />
**LogicalName**: timezonedefinitionid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_UserInterfaceName"></a> UserInterfaceName

**Description**: Display name for the time zone in the Microsoft Windows registry.<br />
**DisplayName**: User Interface Name<br />
**LogicalName**: userinterfacename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: True<br />
**MaxLength**: 100

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the time zone record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the time zone record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the timezonedefinition.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the time zone record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the time zone record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the timezonedefinition.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the time zone definition.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: organization


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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [userentityinstancedata_timezonedefinition](#BKMK_userentityinstancedata_timezonedefinition)
- [lk_timezonerule_timezonedefinitionid](#BKMK_lk_timezonerule_timezonedefinitionid)
- [lk_timezonelocalizedname_timezonedefinitionid](#BKMK_lk_timezonelocalizedname_timezonedefinitionid)


### <a name="BKMK_userentityinstancedata_timezonedefinition"></a> userentityinstancedata_timezonedefinition

Same as userentityinstancedata entity [userentityinstancedata_timezonedefinition](userentityinstancedata.md#BKMK_userentityinstancedata_timezonedefinition) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_timezonedefinition<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_lk_timezonerule_timezonedefinitionid"></a> lk_timezonerule_timezonedefinitionid

Same as timezonerule entity [lk_timezonerule_timezonedefinitionid](timezonerule.md#BKMK_lk_timezonerule_timezonedefinitionid) Many-To-One relationship.

**ReferencingEntity**: timezonerule<br />
**ReferencingAttribute**: timezonedefinitionid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_timezonerule_timezonedefinitionid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_lk_timezonelocalizedname_timezonedefinitionid"></a> lk_timezonelocalizedname_timezonedefinitionid

Same as timezonelocalizedname entity [lk_timezonelocalizedname_timezonedefinitionid](timezonelocalizedname.md#BKMK_lk_timezonelocalizedname_timezonedefinitionid) Many-To-One relationship.

**ReferencingEntity**: timezonelocalizedname<br />
**ReferencingAttribute**: timezonedefinitionid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: lk_timezonelocalizedname_timezonedefinitionid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_timezonedefinition_modifiedby](#BKMK_lk_timezonedefinition_modifiedby)
- [lk_timezonedefinition_modifiedonbehalfby](#BKMK_lk_timezonedefinition_modifiedonbehalfby)
- [lk_timezonedefinition_createdonbehalfby](#BKMK_lk_timezonedefinition_createdonbehalfby)
- [lk_timezonedefinition_createdby](#BKMK_lk_timezonedefinition_createdby)


### <a name="BKMK_lk_timezonedefinition_modifiedby"></a> lk_timezonedefinition_modifiedby

See systemuser Entity [lk_timezonedefinition_modifiedby](systemuser.md#BKMK_lk_timezonedefinition_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_timezonedefinition_modifiedonbehalfby"></a> lk_timezonedefinition_modifiedonbehalfby

See systemuser Entity [lk_timezonedefinition_modifiedonbehalfby](systemuser.md#BKMK_lk_timezonedefinition_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_timezonedefinition_createdonbehalfby"></a> lk_timezonedefinition_createdonbehalfby

See systemuser Entity [lk_timezonedefinition_createdonbehalfby](systemuser.md#BKMK_lk_timezonedefinition_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_timezonedefinition_createdby"></a> lk_timezonedefinition_createdby

See systemuser Entity [lk_timezonedefinition_createdby](systemuser.md#BKMK_lk_timezonedefinition_createdby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.timezonedefinition?text=timezonedefinition EntityType" />