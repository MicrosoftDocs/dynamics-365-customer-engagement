---
title: "msdyn_wallsavedqueryusersettings Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_wallsavedqueryusersettings entity."
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
# msdyn_wallsavedqueryusersettings Entity Reference

Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.

**Added by**: Activity Feeds Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueryusersettingses(*msdyn_wallsavedqueryusersettingsid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Filter<br />
**DisplayCollectionName**: Filters<br />
**SchemaName**: msdyn_wallsavedqueryusersettings<br />
**CollectionSchemaName**: msdyn_wallsavedqueryusersettingses<br />
**LogicalName**: msdyn_wallsavedqueryusersettings<br />
**LogicalCollectionName**: msdyn_wallsavedqueryusersettingses<br />
**EntitySetName**: msdyn_wallsavedqueryusersettingses<br />
**PrimaryIdAttribute**: msdyn_wallsavedqueryusersettingsid<br />
**PrimaryNameAttribute**: msdyn_entityname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_data](#BKMK_msdyn_data)
- [msdyn_default](#BKMK_msdyn_default)
- [msdyn_entitydisplayname](#BKMK_msdyn_entitydisplayname)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_includewallinresponse](#BKMK_msdyn_includewallinresponse)
- [msdyn_isfollowing](#BKMK_msdyn_isfollowing)
- [msdyn_IsVirtual](#BKMK_msdyn_IsVirtual)
- [msdyn_isvisible](#BKMK_msdyn_isvisible)
- [msdyn_isvisiblebit](#BKMK_msdyn_isvisiblebit)
- [msdyn_otc](#BKMK_msdyn_otc)
- [msdyn_savedqueryname](#BKMK_msdyn_savedqueryname)
- [msdyn_sortorder](#BKMK_msdyn_sortorder)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_userid](#BKMK_msdyn_userid)
- [msdyn_wallsavedqueryid](#BKMK_msdyn_wallsavedqueryid)
- [msdyn_wallsavedqueryusersettingsId](#BKMK_msdyn_wallsavedqueryusersettingsId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_data"></a> msdyn_data

**Description**: XML blob that stores personalization data for the user.<br />
**DisplayName**: Data<br />
**LogicalName**: msdyn_data<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10000


### <a name="BKMK_msdyn_default"></a> msdyn_default

**Description**: Indicates that view is selected by default if value is greater than 0. Also contains information which specific filter is applied.<br />
**DisplayName**: Default<br />
**LogicalName**: msdyn_default<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_entitydisplayname"></a> msdyn_entitydisplayname

**Description**: Display name of the entity to which the corresponding views belong.<br />
**DisplayName**: Entity Display Name<br />
**LogicalName**: msdyn_entitydisplayname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

**Description**: Name of the entity to which the corresponding views belong.<br />
**DisplayName**: Entity Name<br />
**LogicalName**: msdyn_entityname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_includewallinresponse"></a> msdyn_includewallinresponse

**Description**: Indicates that wall should be included in response to avoid roundtrips to server<br />
**DisplayName**: Include Wall in response<br />
**LogicalName**: msdyn_includewallinresponse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_isfollowing"></a> msdyn_isfollowing

**Description**: Indicates that corresponding view is following view<br />
**DisplayName**: Is Following<br />
**LogicalName**: msdyn_isfollowing<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsVirtual"></a> msdyn_IsVirtual

**Description**: Indicates that the record is virtual<br />
**DisplayName**: Is Virtual<br />
**LogicalName**: msdyn_isvirtual<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_isvisible"></a> msdyn_isvisible

**Description**: Information that indicates whether the corresponding view should be displayed on the personal wall for this user.<br />
**DisplayName**: Display on the wall<br />
**LogicalName**: msdyn_isvisible<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Shown
- **FalseOption Value**: 0 **Label**: Hidden

**DefaultValue**: True


### <a name="BKMK_msdyn_isvisiblebit"></a> msdyn_isvisiblebit

**Description**: For internal use only.<br />
**DisplayName**: Is Visible bit<br />
**LogicalName**: msdyn_isvisiblebit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_otc"></a> msdyn_otc

**Description**: Virtual column which contains entity type code for the entities returned by corresponding savedquery<br />
**DisplayName**: Entity Type<br />
**LogicalName**: msdyn_otc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_savedqueryname"></a> msdyn_savedqueryname

**Description**: Name of the corresponding view.<br />
**DisplayName**: View Name<br />
**LogicalName**: msdyn_savedqueryname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_sortorder"></a> msdyn_sortorder

**Description**: Sort order to be used when displaying the filter on the user’s personal wall.<br />
**DisplayName**: Sort Order<br />
**LogicalName**: msdyn_sortorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_type"></a> msdyn_type

**Description**: Reserved to support different view types. Currently not used.<br />
**DisplayName**: Type<br />
**LogicalName**: msdyn_type<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_userid"></a> msdyn_userid

**Description**: Unique identifier for User associated with Wall View User Setting.<br />
**DisplayName**: User Id<br />
**LogicalName**: msdyn_userid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_wallsavedqueryid"></a> msdyn_wallsavedqueryid

**Description**: Unique identifier for Wall View associated with Wall View User Setting.<br />
**DisplayName**: Wall View Id<br />
**LogicalName**: msdyn_wallsavedqueryid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_wallsavedquery


### <a name="BKMK_msdyn_wallsavedqueryusersettingsId"></a> msdyn_wallsavedqueryusersettingsId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Filter<br />
**LogicalName**: msdyn_wallsavedqueryusersettingsid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Wall View User Setting<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Wall View User Setting<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_useridName](#BKMK_msdyn_useridName)
- [msdyn_useridYomiName](#BKMK_msdyn_useridYomiName)
- [msdyn_wallsavedqueryidName](#BKMK_msdyn_wallsavedqueryidName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_useridName"></a> msdyn_useridName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_useridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_useridYomiName"></a> msdyn_useridYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_useridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_wallsavedqueryidName"></a> msdyn_wallsavedqueryidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_wallsavedqueryidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
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

- [msdyn_wallsavedqueryusersettings_SyncErrors](#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors)
- [msdyn_wallsavedqueryusersettings_AsyncOperations](#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)
- [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders)
- [msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas](#BKMK_msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas)
- [msdyn_wallsavedqueryusersettings_ProcessSession](#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)
- [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures)
- [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_wallsavedqueryusersettings_SyncErrors"></a> msdyn_wallsavedqueryusersettings_SyncErrors

Same as syncerror entity [msdyn_wallsavedqueryusersettings_SyncErrors](syncerror.md#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations"></a> msdyn_wallsavedqueryusersettings_AsyncOperations

Same as asyncoperation entity [msdyn_wallsavedqueryusersettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders"></a> msdyn_wallsavedqueryusersettings_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas"></a> msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_wallsavedqueryusersettings_ProcessSession"></a> msdyn_wallsavedqueryusersettings_ProcessSession

Same as processsession entity [msdyn_wallsavedqueryusersettings_ProcessSession](processsession.md#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures"></a> msdyn_wallsavedqueryusersettings_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_wallsavedqueryusersettings_createdby](#BKMK_lk_msdyn_wallsavedqueryusersettings_createdby)
- [lk_msdyn_wallsavedqueryusersettings_createdonbehalfby](#BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby)
- [lk_msdyn_wallsavedqueryusersettings_modifiedby](#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby)
- [lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby](#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby)
- [user_msdyn_wallsavedqueryusersettings](#BKMK_user_msdyn_wallsavedqueryusersettings)
- [team_msdyn_wallsavedqueryusersettings](#BKMK_team_msdyn_wallsavedqueryusersettings)
- [business_unit_msdyn_wallsavedqueryusersettings](#BKMK_business_unit_msdyn_wallsavedqueryusersettings)
- [msdyn_systemuser_wallsavedqueryusersettings_userid](#BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid)
- [msdyn_wallsavedquery_wallsavedqueryusersettings](#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)


### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_createdby"></a> lk_msdyn_wallsavedqueryusersettings_createdby

See systemuser Entity [lk_msdyn_wallsavedqueryusersettings_createdby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby"></a> lk_msdyn_wallsavedqueryusersettings_createdonbehalfby

See systemuser Entity [lk_msdyn_wallsavedqueryusersettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby"></a> lk_msdyn_wallsavedqueryusersettings_modifiedby

See systemuser Entity [lk_msdyn_wallsavedqueryusersettings_modifiedby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby"></a> lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby

See systemuser Entity [lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_wallsavedqueryusersettings"></a> user_msdyn_wallsavedqueryusersettings

See systemuser Entity [user_msdyn_wallsavedqueryusersettings](systemuser.md#BKMK_user_msdyn_wallsavedqueryusersettings) One-To-Many relationship.

### <a name="BKMK_team_msdyn_wallsavedqueryusersettings"></a> team_msdyn_wallsavedqueryusersettings

See team Entity [team_msdyn_wallsavedqueryusersettings](team.md#BKMK_team_msdyn_wallsavedqueryusersettings) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_wallsavedqueryusersettings"></a> business_unit_msdyn_wallsavedqueryusersettings

See businessunit Entity [business_unit_msdyn_wallsavedqueryusersettings](businessunit.md#BKMK_business_unit_msdyn_wallsavedqueryusersettings) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid"></a> msdyn_systemuser_wallsavedqueryusersettings_userid

See systemuser Entity [msdyn_systemuser_wallsavedqueryusersettings_userid](systemuser.md#BKMK_msdyn_systemuser_wallsavedqueryusersettings_userid) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings"></a> msdyn_wallsavedquery_wallsavedqueryusersettings

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_wallsavedqueryusersettings](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_wallsavedqueryusersettings?text=msdyn_wallsavedqueryusersettings EntityType" />