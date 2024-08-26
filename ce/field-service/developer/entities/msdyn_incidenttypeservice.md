---
title: "Incident Type Service (msdyn_incidenttypeservice) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Incident Type Service (msdyn_incidenttypeservice) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Incident Type Service (msdyn_incidenttypeservice) table/entity reference (Microsoft Dynamics 365 Field Service)

This entity gives the ability to pre-configure services to be added to a work order when the related incident is added to the work order

## Messages

The following table lists the messages for the Incident Type Service (msdyn_incidenttypeservice) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_incidenttypeservices<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_incidenttypeservices<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_incidenttypeservices(*msdyn_incidenttypeserviceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Incident Type Service (msdyn_incidenttypeservice) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Incident Type Service (msdyn_incidenttypeservice) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Incident Type Service** |
| **DisplayCollectionName** | **Incident Type Services** |
| **SchemaName** | `msdyn_incidenttypeservice` |
| **CollectionSchemaName** | `msdyn_incidenttypeservices` |
| **EntitySetName** | `msdyn_incidenttypeservices`|
| **LogicalName** | `msdyn_incidenttypeservice` |
| **LogicalCollectionName** | `msdyn_incidenttypeservices` |
| **PrimaryIdAttribute** | `msdyn_incidenttypeserviceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AppliedSuggestionResult](#BKMK_msdyn_AppliedSuggestionResult)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_incidenttypeserviceId](#BKMK_msdyn_incidenttypeserviceId)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Service](#BKMK_msdyn_Service)
- [msdyn_Unit](#BKMK_msdyn_Unit)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AppliedSuggestionResult"></a> msdyn_AppliedSuggestionResult

|Property|Value|
|---|---|
|Description|**Incident type suggestion result applied to this incident type service.**|
|DisplayName|**Applied Suggestion Result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appliedsuggestionresult`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttyperecommendationresult|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Enter the description of the service as presented to the customer. The value defaults to the description defined on the service.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Shows the duration of the service.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

|Property|Value|
|---|---|
|Description|**The Incident related to this product**|
|DisplayName|**Incident Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_incidenttype|

### <a name="BKMK_msdyn_incidenttypeserviceId"></a> msdyn_incidenttypeserviceId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Incident Type Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeserviceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

|Property|Value|
|---|---|
|Description|**Enter any internal notes you want to track on this service.**|
|DisplayName|**Internal Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internaldescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_Service"></a> msdyn_Service

|Property|Value|
|---|---|
|Description|**Unique identifier for Product/Service associated with Incident Type Service.**|
|DisplayName|**Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_service`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**The unit that determines the pricing for this service**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Incident Type Service**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttypeservice_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Incident Type Service**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttypeservice_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [business_unit_msdyn_incidenttypeservice](#BKMK_business_unit_msdyn_incidenttypeservice)
- [lk_msdyn_incidenttypeservice_createdby](#BKMK_lk_msdyn_incidenttypeservice_createdby)
- [lk_msdyn_incidenttypeservice_createdonbehalfby](#BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby)
- [lk_msdyn_incidenttypeservice_modifiedby](#BKMK_lk_msdyn_incidenttypeservice_modifiedby)
- [lk_msdyn_incidenttypeservice_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)
- [msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult](#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult)
- [msdyn_product_msdyn_incidenttypeservice_Service](#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)
- [msdyn_uom_msdyn_incidenttypeservice_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)
- [owner_msdyn_incidenttypeservice](#BKMK_owner_msdyn_incidenttypeservice)
- [team_msdyn_incidenttypeservice](#BKMK_team_msdyn_incidenttypeservice)
- [user_msdyn_incidenttypeservice](#BKMK_user_msdyn_incidenttypeservice)

### <a name="BKMK_business_unit_msdyn_incidenttypeservice"></a> business_unit_msdyn_incidenttypeservice

One-To-Many Relationship: [businessunit business_unit_msdyn_incidenttypeservice](businessunit.md#BKMK_business_unit_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeservice_createdby"></a> lk_msdyn_incidenttypeservice_createdby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeservice_createdby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby"></a> lk_msdyn_incidenttypeservice_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeservice_modifiedby"></a> lk_msdyn_incidenttypeservice_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeservice_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby"></a> lk_msdyn_incidenttypeservice_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeservice_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeservice_IncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult"></a> msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeservice_AppliedSuggestionResult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`msdyn_appliedsuggestionresult`|
|ReferencingEntityNavigationPropertyName|`msdyn_AppliedSuggestionResult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_incidenttypeservice_Service"></a> msdyn_product_msdyn_incidenttypeservice_Service

One-To-Many Relationship: [product msdyn_product_msdyn_incidenttypeservice_Service](product.md#BKMK_msdyn_product_msdyn_incidenttypeservice_Service)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_service`|
|ReferencingEntityNavigationPropertyName|`msdyn_service`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit"></a> msdyn_uom_msdyn_incidenttypeservice_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_incidenttypeservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_incidenttypeservice"></a> owner_msdyn_incidenttypeservice

One-To-Many Relationship: [owner owner_msdyn_incidenttypeservice](owner.md#BKMK_owner_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_incidenttypeservice"></a> team_msdyn_incidenttypeservice

One-To-Many Relationship: [team team_msdyn_incidenttypeservice](team.md#BKMK_team_msdyn_incidenttypeservice)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_incidenttypeservice"></a> user_msdyn_incidenttypeservice

One-To-Many Relationship: [systemuser user_msdyn_incidenttypeservice](systemuser.md#BKMK_user_msdyn_incidenttypeservice)

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

- [msdyn_incidenttypeservice_ActivityPointers](#BKMK_msdyn_incidenttypeservice_ActivityPointers)
- [msdyn_incidenttypeservice_adx_inviteredemptions](#BKMK_msdyn_incidenttypeservice_adx_inviteredemptions)
- [msdyn_incidenttypeservice_adx_portalcomments](#BKMK_msdyn_incidenttypeservice_adx_portalcomments)
- [msdyn_incidenttypeservice_Annotations](#BKMK_msdyn_incidenttypeservice_Annotations)
- [msdyn_incidenttypeservice_Appointments](#BKMK_msdyn_incidenttypeservice_Appointments)
- [msdyn_incidenttypeservice_AsyncOperations](#BKMK_msdyn_incidenttypeservice_AsyncOperations)
- [msdyn_incidenttypeservice_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)
- [msdyn_incidenttypeservice_chats](#BKMK_msdyn_incidenttypeservice_chats)
- [msdyn_incidenttypeservice_connections1](#BKMK_msdyn_incidenttypeservice_connections1)
- [msdyn_incidenttypeservice_connections2](#BKMK_msdyn_incidenttypeservice_connections2)
- [msdyn_incidenttypeservice_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)
- [msdyn_incidenttypeservice_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)
- [msdyn_incidenttypeservice_Emails](#BKMK_msdyn_incidenttypeservice_Emails)
- [msdyn_incidenttypeservice_Faxes](#BKMK_msdyn_incidenttypeservice_Faxes)
- [msdyn_incidenttypeservice_Letters](#BKMK_msdyn_incidenttypeservice_Letters)
- [msdyn_incidenttypeservice_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)
- [msdyn_incidenttypeservice_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts)
- [msdyn_incidenttypeservice_msdyn_copilottranscripts](#BKMK_msdyn_incidenttypeservice_msdyn_copilottranscripts)
- [msdyn_incidenttypeservice_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)
- [msdyn_incidenttypeservice_msdyn_ocsessions](#BKMK_msdyn_incidenttypeservice_msdyn_ocsessions)
- [msdyn_incidenttypeservice_msfp_alerts](#BKMK_msdyn_incidenttypeservice_msfp_alerts)
- [msdyn_incidenttypeservice_msfp_surveyinvites](#BKMK_msdyn_incidenttypeservice_msfp_surveyinvites)
- [msdyn_incidenttypeservice_msfp_surveyresponses](#BKMK_msdyn_incidenttypeservice_msfp_surveyresponses)
- [msdyn_incidenttypeservice_PhoneCalls](#BKMK_msdyn_incidenttypeservice_PhoneCalls)
- [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservice_ProcessSession](#BKMK_msdyn_incidenttypeservice_ProcessSession)
- [msdyn_incidenttypeservice_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)
- [msdyn_incidenttypeservice_ServiceAppointments](#BKMK_msdyn_incidenttypeservice_ServiceAppointments)
- [msdyn_incidenttypeservice_SocialActivities](#BKMK_msdyn_incidenttypeservice_SocialActivities)
- [msdyn_incidenttypeservice_SyncErrors](#BKMK_msdyn_incidenttypeservice_SyncErrors)
- [msdyn_incidenttypeservice_Tasks](#BKMK_msdyn_incidenttypeservice_Tasks)

### <a name="BKMK_msdyn_incidenttypeservice_ActivityPointers"></a> msdyn_incidenttypeservice_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_incidenttypeservice_ActivityPointers](activitypointer.md#BKMK_msdyn_incidenttypeservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_adx_inviteredemptions"></a> msdyn_incidenttypeservice_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_incidenttypeservice_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_incidenttypeservice_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_adx_portalcomments"></a> msdyn_incidenttypeservice_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_incidenttypeservice_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_incidenttypeservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Annotations"></a> msdyn_incidenttypeservice_Annotations

Many-To-One Relationship: [annotation msdyn_incidenttypeservice_Annotations](annotation.md#BKMK_msdyn_incidenttypeservice_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Appointments"></a> msdyn_incidenttypeservice_Appointments

Many-To-One Relationship: [appointment msdyn_incidenttypeservice_Appointments](appointment.md#BKMK_msdyn_incidenttypeservice_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_AsyncOperations"></a> msdyn_incidenttypeservice_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_incidenttypeservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttypeservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_BulkDeleteFailures"></a> msdyn_incidenttypeservice_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_incidenttypeservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_chats"></a> msdyn_incidenttypeservice_chats

Many-To-One Relationship: [chat msdyn_incidenttypeservice_chats](chat.md#BKMK_msdyn_incidenttypeservice_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_connections1"></a> msdyn_incidenttypeservice_connections1

Many-To-One Relationship: [connection msdyn_incidenttypeservice_connections1](connection.md#BKMK_msdyn_incidenttypeservice_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_connections2"></a> msdyn_incidenttypeservice_connections2

Many-To-One Relationship: [connection msdyn_incidenttypeservice_connections2](connection.md#BKMK_msdyn_incidenttypeservice_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord"></a> msdyn_incidenttypeservice_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttypeservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord"></a> msdyn_incidenttypeservice_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttypeservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Emails"></a> msdyn_incidenttypeservice_Emails

Many-To-One Relationship: [email msdyn_incidenttypeservice_Emails](email.md#BKMK_msdyn_incidenttypeservice_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Faxes"></a> msdyn_incidenttypeservice_Faxes

Many-To-One Relationship: [fax msdyn_incidenttypeservice_Faxes](fax.md#BKMK_msdyn_incidenttypeservice_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Letters"></a> msdyn_incidenttypeservice_Letters

Many-To-One Relationship: [letter msdyn_incidenttypeservice_Letters](letter.md#BKMK_msdyn_incidenttypeservice_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders"></a> msdyn_incidenttypeservice_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_incidenttypeservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts"></a> msdyn_incidenttypeservice_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_incidenttypeservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_incidenttypeservice_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_copilottranscripts"></a> msdyn_incidenttypeservice_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_incidenttypeservice_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_incidenttypeservice_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems"></a> msdyn_incidenttypeservice_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_incidenttypeservice_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_incidenttypeservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msdyn_ocsessions"></a> msdyn_incidenttypeservice_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_incidenttypeservice_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_incidenttypeservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msfp_alerts"></a> msdyn_incidenttypeservice_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_incidenttypeservice_msfp_alerts](msfp_alert.md#BKMK_msdyn_incidenttypeservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msfp_surveyinvites"></a> msdyn_incidenttypeservice_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_incidenttypeservice_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_incidenttypeservice_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_msfp_surveyresponses"></a> msdyn_incidenttypeservice_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_incidenttypeservice_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_incidenttypeservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_PhoneCalls"></a> msdyn_incidenttypeservice_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_incidenttypeservice_PhoneCalls](phonecall.md#BKMK_msdyn_incidenttypeservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_ProcessSession"></a> msdyn_incidenttypeservice_ProcessSession

Many-To-One Relationship: [processsession msdyn_incidenttypeservice_ProcessSession](processsession.md#BKMK_msdyn_incidenttypeservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters"></a> msdyn_incidenttypeservice_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_incidenttypeservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_incidenttypeservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_ServiceAppointments"></a> msdyn_incidenttypeservice_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_incidenttypeservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_incidenttypeservice_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_SocialActivities"></a> msdyn_incidenttypeservice_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_incidenttypeservice_SocialActivities](socialactivity.md#BKMK_msdyn_incidenttypeservice_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_SyncErrors"></a> msdyn_incidenttypeservice_SyncErrors

Many-To-One Relationship: [syncerror msdyn_incidenttypeservice_SyncErrors](syncerror.md#BKMK_msdyn_incidenttypeservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeservice_Tasks"></a> msdyn_incidenttypeservice_Tasks

Many-To-One Relationship: [task msdyn_incidenttypeservice_Tasks](task.md#BKMK_msdyn_incidenttypeservice_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeservice_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

