---
title: "Tagged Record (msdyn_taggedrecord) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Tagged Record (msdyn_taggedrecord) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Tagged Record (msdyn_taggedrecord) table/entity reference (Microsoft Dynamics 365)

Tagged Record - Copilot for Sales

## Messages

The following table lists the messages for the Tagged Record (msdyn_taggedrecord) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_taggedrecords<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_taggedrecords<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_taggedrecords(*msdyn_taggedrecordid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Tagged Record (msdyn_taggedrecord) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Tagged Record** |
| **DisplayCollectionName** | **Tagged Records** |
| **SchemaName** | `msdyn_taggedrecord` |
| **CollectionSchemaName** | `msdyn_taggedrecords` |
| **EntitySetName** | `msdyn_taggedrecords`|
| **LogicalName** | `msdyn_taggedrecord` |
| **LogicalCollectionName** | `msdyn_taggedrecords` |
| **PrimaryIdAttribute** | `msdyn_taggedrecordid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_connectionid](#BKMK_msdyn_connectionid)
- [msdyn_crmrecordid](#BKMK_msdyn_crmrecordid)
- [msdyn_dynamicsrecordid](#BKMK_msdyn_dynamicsrecordid)
- [msdyn_dynamicsrecordidIdType](#BKMK_msdyn_dynamicsrecordidIdType)
- [msdyn_emailid](#BKMK_msdyn_emailid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_producttype](#BKMK_msdyn_producttype)
- [msdyn_recordtype](#BKMK_msdyn_recordtype)
- [msdyn_taggedrecordId](#BKMK_msdyn_taggedrecordId)
- [msdyn_userid](#BKMK_msdyn_userid)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_connectionid"></a> msdyn_connectionid

|Property|Value|
|---|---|
|Description|**Relationship with CRM Connection Entity**|
|DisplayName|**ConnectionId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectionid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_crmconnection|

### <a name="BKMK_msdyn_crmrecordid"></a> msdyn_crmrecordid

|Property|Value|
|---|---|
|Description|**Record Id for SF and Others**|
|DisplayName|**CRM Record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_crmrecordid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_dynamicsrecordid"></a> msdyn_dynamicsrecordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Dynamics Record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dynamicsrecordid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact, lead|

### <a name="BKMK_msdyn_dynamicsrecordidIdType"></a> msdyn_dynamicsrecordidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_dynamicsrecordididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_emailid"></a> msdyn_emailid

|Property|Value|
|---|---|
|Description|**Email Id of Contact/Lead**|
|DisplayName|**Email Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_producttype"></a> msdyn_producttype

|Property|Value|
|---|---|
|Description|**Identifier to track the association of this record with a Copilot product type**|
|DisplayName|**Product Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_producttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|10000|
|GlobalChoiceName|`msdyn_vivacopilottype`|

#### msdyn_producttype Choices/Options

|Value|Label|
|---|---|
|10000|**Copilot for Sales**|
|10001|**Copilot for Service**|
|11000|**Shared**|

### <a name="BKMK_msdyn_recordtype"></a> msdyn_recordtype

|Property|Value|
|---|---|
|Description|**Lead or Contact Type**|
|DisplayName|**Record Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_taggedrecordId"></a> msdyn_taggedrecordId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**TaggedRecord**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_taggedrecordid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_userid"></a> msdyn_userid

|Property|Value|
|---|---|
|Description|**AadObjectId of the User**|
|DisplayName|**UserId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_userid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the TaggedRecord**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_taggedrecord_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the TaggedRecord**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_taggedrecord_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_taggedrecord](#BKMK_business_unit_msdyn_taggedrecord)
- [lk_msdyn_taggedrecord_createdby](#BKMK_lk_msdyn_taggedrecord_createdby)
- [lk_msdyn_taggedrecord_createdonbehalfby](#BKMK_lk_msdyn_taggedrecord_createdonbehalfby)
- [lk_msdyn_taggedrecord_modifiedby](#BKMK_lk_msdyn_taggedrecord_modifiedby)
- [lk_msdyn_taggedrecord_modifiedonbehalfby](#BKMK_lk_msdyn_taggedrecord_modifiedonbehalfby)
- [msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid](#BKMK_msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid)
- [msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid](#BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid)
- [msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid](#BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid)
- [owner_msdyn_taggedrecord](#BKMK_owner_msdyn_taggedrecord)
- [team_msdyn_taggedrecord](#BKMK_team_msdyn_taggedrecord)
- [user_msdyn_taggedrecord](#BKMK_user_msdyn_taggedrecord)

### <a name="BKMK_business_unit_msdyn_taggedrecord"></a> business_unit_msdyn_taggedrecord

One-To-Many Relationship: [businessunit business_unit_msdyn_taggedrecord](businessunit.md#BKMK_business_unit_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_taggedrecord_createdby"></a> lk_msdyn_taggedrecord_createdby

One-To-Many Relationship: [systemuser lk_msdyn_taggedrecord_createdby](systemuser.md#BKMK_lk_msdyn_taggedrecord_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_taggedrecord_createdonbehalfby"></a> lk_msdyn_taggedrecord_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_taggedrecord_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_taggedrecord_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_taggedrecord_modifiedby"></a> lk_msdyn_taggedrecord_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_taggedrecord_modifiedby](systemuser.md#BKMK_lk_msdyn_taggedrecord_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_taggedrecord_modifiedonbehalfby"></a> lk_msdyn_taggedrecord_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_taggedrecord_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_taggedrecord_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid"></a> msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid

One-To-Many Relationship: [msdyn_crmconnection msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid](msdyn_crmconnection.md#BKMK_msdyn_msdyn_crmconnection_msdyn_taggedrecord_connectionid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_crmconnection`|
|ReferencedAttribute|`msdyn_crmconnectionid`|
|ReferencingAttribute|`msdyn_connectionid`|
|ReferencingEntityNavigationPropertyName|`msdyn_connectionid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid"></a> msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid

One-To-Many Relationship: [contact msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid](contact.md#BKMK_msdyn_msdyn_taggedrecord_contact_msdyn_dynamicsrecordid)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_dynamicsrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_dynamicsrecordid_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid"></a> msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid

One-To-Many Relationship: [lead msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid](lead.md#BKMK_msdyn_msdyn_taggedrecord_lead_msdyn_dynamicsrecordid)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_dynamicsrecordid`|
|ReferencingEntityNavigationPropertyName|`msdyn_dynamicsrecordid_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_taggedrecord"></a> owner_msdyn_taggedrecord

One-To-Many Relationship: [owner owner_msdyn_taggedrecord](owner.md#BKMK_owner_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_taggedrecord"></a> team_msdyn_taggedrecord

One-To-Many Relationship: [team team_msdyn_taggedrecord](team.md#BKMK_team_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_taggedrecord"></a> user_msdyn_taggedrecord

One-To-Many Relationship: [systemuser user_msdyn_taggedrecord](systemuser.md#BKMK_user_msdyn_taggedrecord)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_taggedrecord_Annotations](#BKMK_msdyn_taggedrecord_Annotations)
- [msdyn_taggedrecord_AsyncOperations](#BKMK_msdyn_taggedrecord_AsyncOperations)
- [msdyn_taggedrecord_BulkDeleteFailures](#BKMK_msdyn_taggedrecord_BulkDeleteFailures)
- [msdyn_taggedrecord_DuplicateBaseRecord](#BKMK_msdyn_taggedrecord_DuplicateBaseRecord)
- [msdyn_taggedrecord_DuplicateMatchingRecord](#BKMK_msdyn_taggedrecord_DuplicateMatchingRecord)
- [msdyn_taggedrecord_MailboxTrackingFolders](#BKMK_msdyn_taggedrecord_MailboxTrackingFolders)
- [msdyn_taggedrecord_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taggedrecord_PrincipalObjectAttributeAccesses)
- [msdyn_taggedrecord_ProcessSession](#BKMK_msdyn_taggedrecord_ProcessSession)
- [msdyn_taggedrecord_SyncErrors](#BKMK_msdyn_taggedrecord_SyncErrors)

### <a name="BKMK_msdyn_taggedrecord_Annotations"></a> msdyn_taggedrecord_Annotations

Many-To-One Relationship: [annotation msdyn_taggedrecord_Annotations](annotation.md#BKMK_msdyn_taggedrecord_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_AsyncOperations"></a> msdyn_taggedrecord_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_taggedrecord_AsyncOperations](asyncoperation.md#BKMK_msdyn_taggedrecord_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_BulkDeleteFailures"></a> msdyn_taggedrecord_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_taggedrecord_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_taggedrecord_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_DuplicateBaseRecord"></a> msdyn_taggedrecord_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_taggedrecord_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_taggedrecord_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_DuplicateMatchingRecord"></a> msdyn_taggedrecord_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_taggedrecord_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_taggedrecord_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_MailboxTrackingFolders"></a> msdyn_taggedrecord_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_taggedrecord_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_taggedrecord_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_PrincipalObjectAttributeAccesses"></a> msdyn_taggedrecord_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_taggedrecord_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_taggedrecord_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_ProcessSession"></a> msdyn_taggedrecord_ProcessSession

Many-To-One Relationship: [processsession msdyn_taggedrecord_ProcessSession](processsession.md#BKMK_msdyn_taggedrecord_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_taggedrecord_SyncErrors"></a> msdyn_taggedrecord_SyncErrors

Many-To-One Relationship: [syncerror msdyn_taggedrecord_SyncErrors](syncerror.md#BKMK_msdyn_taggedrecord_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_taggedrecord_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

