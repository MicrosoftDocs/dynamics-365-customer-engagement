---
title: "intentattribute_entity (msdyn_intentattribute_entity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the intentattribute_entity (msdyn_intentattribute_entity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# intentattribute_entity (msdyn_intentattribute_entity) table/entity reference (Microsoft Dynamics 365)

Associates the value of an intent attribute identified for a given case or conversation.

## Messages

The following table lists the messages for the intentattribute_entity (msdyn_intentattribute_entity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_intentattribute_entities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_intentattribute_entities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_intentattribute_entities(*msdyn_intentattribute_entityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the intentattribute_entity (msdyn_intentattribute_entity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **intentattribute_entity** |
| **DisplayCollectionName** | **intentattribute_entities** |
| **SchemaName** | `msdyn_intentattribute_entity` |
| **CollectionSchemaName** | `msdyn_intentattribute_entities` |
| **EntitySetName** | `msdyn_intentattribute_entities`|
| **LogicalName** | `msdyn_intentattribute_entity` |
| **LogicalCollectionName** | `msdyn_intentattribute_entities` |
| **PrimaryIdAttribute** | `msdyn_intentattribute_entityid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attributecandidate](#BKMK_msdyn_attributecandidate)
- [msdyn_attributestate](#BKMK_msdyn_attributestate)
- [msdyn_harvestingtag](#BKMK_msdyn_harvestingtag)
- [msdyn_intent_entityid](#BKMK_msdyn_intent_entityid)
- [msdyn_intentattribute_entityId](#BKMK_msdyn_intentattribute_entityId)
- [msdyn_intentattributeid](#BKMK_msdyn_intentattributeid)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objectid](#BKMK_msdyn_objectid)
- [msdyn_objectidIdType](#BKMK_msdyn_objectidIdType)
- [msdyn_objecttype](#BKMK_msdyn_objecttype)
- [msdyn_value](#BKMK_msdyn_value)
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

### <a name="BKMK_msdyn_attributecandidate"></a> msdyn_attributecandidate

|Property|Value|
|---|---|
|Description|**Attribute extracted from the interaction which is associated with unknown intent.**|
|DisplayName|**attributecandidate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributecandidate`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_attributestate"></a> msdyn_attributestate

|Property|Value|
|---|---|
|Description|**attribute state of the runtime intent attribute entity**|
|DisplayName|**attributestate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributestate`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_intentattribute_entity_msdyn_attributestate`|

#### msdyn_attributestate Choices/Options

|Value|Label|
|---|---|
|192350000|**Open**|
|192350001|**Fulfilled**|

### <a name="BKMK_msdyn_harvestingtag"></a> msdyn_harvestingtag

|Property|Value|
|---|---|
|Description|**harvesting tag of the intent-attribute entity**|
|DisplayName|**harvestingtag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_harvestingtag`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_harvestingtag`|

#### msdyn_harvestingtag Choices/Options

|Value|Label|
|---|---|
|192350000|**Not Required**|
|192350001|**Solution Harvesting**|

### <a name="BKMK_msdyn_intent_entityid"></a> msdyn_intent_entityid

|Property|Value|
|---|---|
|Description|**Lookup to intent entity record associated with this c2 interaction**|
|DisplayName|**intent_entityid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intent_entityid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_intententity|

### <a name="BKMK_msdyn_intentattribute_entityId"></a> msdyn_intentattribute_entityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**intentattribute_entity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentattribute_entityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_intentattributeid"></a> msdyn_intentattributeid

|Property|Value|
|---|---|
|Description|**Attribute attribute ID reference**|
|DisplayName|**intentattributeid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intentattributeid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_intentattribute|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the intent attribute.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_objectid"></a> msdyn_objectid

|Property|Value|
|---|---|
|Description|**Polymorphic lookup to a row in the Conversation entity (case, chat)**|
|DisplayName|**objectid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objectid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocliveworkitem|

### <a name="BKMK_msdyn_objectidIdType"></a> msdyn_objectidIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_objectididtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_objecttype"></a> msdyn_objecttype

|Property|Value|
|---|---|
|Description|**Name of the target entity**|
|DisplayName|**objecttype**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objecttype`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_value"></a> msdyn_value

|Property|Value|
|---|---|
|Description|**Value of the attribute from the C2 interaction**|
|DisplayName|**value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_value`|
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
|Description|**Status of the intentattribute_entity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentattribute_entity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the intentattribute_entity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_intentattribute_entity_statuscode`|

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
|RequiredLevel|SystemRequired|
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

- [business_unit_msdyn_intentattribute_entity](#BKMK_business_unit_msdyn_intentattribute_entity)
- [lk_msdyn_intentattribute_entity_createdby](#BKMK_lk_msdyn_intentattribute_entity_createdby)
- [lk_msdyn_intentattribute_entity_createdonbehalfby](#BKMK_lk_msdyn_intentattribute_entity_createdonbehalfby)
- [lk_msdyn_intentattribute_entity_modifiedby](#BKMK_lk_msdyn_intentattribute_entity_modifiedby)
- [lk_msdyn_intentattribute_entity_modifiedonbehalfby](#BKMK_lk_msdyn_intentattribute_entity_modifiedonbehalfby)
- [msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid](#BKMK_msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid)
- [msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid](#BKMK_msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid)
- [msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid](#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid)
- [owner_msdyn_intentattribute_entity](#BKMK_owner_msdyn_intentattribute_entity)
- [team_msdyn_intentattribute_entity](#BKMK_team_msdyn_intentattribute_entity)
- [user_msdyn_intentattribute_entity](#BKMK_user_msdyn_intentattribute_entity)

### <a name="BKMK_business_unit_msdyn_intentattribute_entity"></a> business_unit_msdyn_intentattribute_entity

One-To-Many Relationship: [businessunit business_unit_msdyn_intentattribute_entity](businessunit.md#BKMK_business_unit_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentattribute_entity_createdby"></a> lk_msdyn_intentattribute_entity_createdby

One-To-Many Relationship: [systemuser lk_msdyn_intentattribute_entity_createdby](systemuser.md#BKMK_lk_msdyn_intentattribute_entity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentattribute_entity_createdonbehalfby"></a> lk_msdyn_intentattribute_entity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentattribute_entity_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_intentattribute_entity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentattribute_entity_modifiedby"></a> lk_msdyn_intentattribute_entity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_intentattribute_entity_modifiedby](systemuser.md#BKMK_lk_msdyn_intentattribute_entity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_intentattribute_entity_modifiedonbehalfby"></a> lk_msdyn_intentattribute_entity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_intentattribute_entity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_intentattribute_entity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid"></a> msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid

One-To-Many Relationship: [msdyn_intentattribute msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid](msdyn_intentattribute.md#BKMK_msdyn_msdyn_intentattribute_msdyn_intentattribute_entity_intentattributeid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intentattribute`|
|ReferencedAttribute|`msdyn_intentattributeid`|
|ReferencingAttribute|`msdyn_intentattributeid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intentattributeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid"></a> msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid

One-To-Many Relationship: [msdyn_intententity msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid](msdyn_intententity.md#BKMK_msdyn_msdyn_intententity_msdyn_intentattribute_entity_intent_entityid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_intententity`|
|ReferencedAttribute|`msdyn_intententityid`|
|ReferencingAttribute|`msdyn_intent_entityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_intent_entityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid"></a> msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid

One-To-Many Relationship: [msdyn_ocliveworkitem msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_ocliveworkitem_msdyn_intententityattribute_objectid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocliveworkitem`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_objectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_objectid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_intentattribute_entity"></a> owner_msdyn_intentattribute_entity

One-To-Many Relationship: [owner owner_msdyn_intentattribute_entity](owner.md#BKMK_owner_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_intentattribute_entity"></a> team_msdyn_intentattribute_entity

One-To-Many Relationship: [team team_msdyn_intentattribute_entity](team.md#BKMK_team_msdyn_intentattribute_entity)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_intentattribute_entity"></a> user_msdyn_intentattribute_entity

One-To-Many Relationship: [systemuser user_msdyn_intentattribute_entity](systemuser.md#BKMK_user_msdyn_intentattribute_entity)

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

- [msdyn_intentattribute_entity_AsyncOperations](#BKMK_msdyn_intentattribute_entity_AsyncOperations)
- [msdyn_intentattribute_entity_BulkDeleteFailures](#BKMK_msdyn_intentattribute_entity_BulkDeleteFailures)
- [msdyn_intentattribute_entity_DuplicateBaseRecord](#BKMK_msdyn_intentattribute_entity_DuplicateBaseRecord)
- [msdyn_intentattribute_entity_DuplicateMatchingRecord](#BKMK_msdyn_intentattribute_entity_DuplicateMatchingRecord)
- [msdyn_intentattribute_entity_MailboxTrackingFolders](#BKMK_msdyn_intentattribute_entity_MailboxTrackingFolders)
- [msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses](#BKMK_msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses)
- [msdyn_intentattribute_entity_ProcessSession](#BKMK_msdyn_intentattribute_entity_ProcessSession)
- [msdyn_intentattribute_entity_SyncErrors](#BKMK_msdyn_intentattribute_entity_SyncErrors)

### <a name="BKMK_msdyn_intentattribute_entity_AsyncOperations"></a> msdyn_intentattribute_entity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_intentattribute_entity_AsyncOperations](asyncoperation.md#BKMK_msdyn_intentattribute_entity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_BulkDeleteFailures"></a> msdyn_intentattribute_entity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_intentattribute_entity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_intentattribute_entity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_DuplicateBaseRecord"></a> msdyn_intentattribute_entity_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentattribute_entity_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_intentattribute_entity_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_DuplicateMatchingRecord"></a> msdyn_intentattribute_entity_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_intentattribute_entity_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_intentattribute_entity_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_MailboxTrackingFolders"></a> msdyn_intentattribute_entity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_intentattribute_entity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_intentattribute_entity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses"></a> msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_ProcessSession"></a> msdyn_intentattribute_entity_ProcessSession

Many-To-One Relationship: [processsession msdyn_intentattribute_entity_ProcessSession](processsession.md#BKMK_msdyn_intentattribute_entity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_intentattribute_entity_SyncErrors"></a> msdyn_intentattribute_entity_SyncErrors

Many-To-One Relationship: [syncerror msdyn_intentattribute_entity_SyncErrors](syncerror.md#BKMK_msdyn_intentattribute_entity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_intentattribute_entity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

