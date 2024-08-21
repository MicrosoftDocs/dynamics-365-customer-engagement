---
title: "Incident Type Product (msdyn_incidenttypeproduct) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Incident Type Product (msdyn_incidenttypeproduct) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Incident Type Product (msdyn_incidenttypeproduct) table/entity reference

This entity gives the ability to pre-configure products to be added to a work order when the related incident is added to the work order

## Messages

The following table lists the messages for the Incident Type Product (msdyn_incidenttypeproduct) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_incidenttypeproducts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_incidenttypeproducts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_incidenttypeproducts(*msdyn_incidenttypeproductid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Incident Type Product (msdyn_incidenttypeproduct) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Incident Type Product (msdyn_incidenttypeproduct) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Incident Type Product** |
| **DisplayCollectionName** | **Incident Type Products** |
| **SchemaName** | `msdyn_incidenttypeproduct` |
| **CollectionSchemaName** | `msdyn_incidenttypeproducts` |
| **EntitySetName** | `msdyn_incidenttypeproducts`|
| **LogicalName** | `msdyn_incidenttypeproduct` |
| **LogicalCollectionName** | `msdyn_incidenttypeproducts` |
| **PrimaryIdAttribute** | `msdyn_incidenttypeproductid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AppliedSuggestionResult](#BKMK_msdyn_AppliedSuggestionResult)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_incidenttypeproductId](#BKMK_msdyn_incidenttypeproductId)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
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
|Description|**Incident type suggestion result applied to this incident type product.**|
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
|Description|**Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.**|
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

### <a name="BKMK_msdyn_incidenttypeproductId"></a> msdyn_incidenttypeproductId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Incident Type Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_incidenttypeproductid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

|Property|Value|
|---|---|
|Description|**Enter any internal notes you want to track on this product.**|
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

### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|---|---|
|Description|**Unique identifier for Product/Service associated with Incident Type Product.**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|---|---|
|Description|**Shows the actual quantity of the product.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**The unit that determines the pricing and final quantity for this product**|
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
|Description|**Status of the Incident Type Product**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttypeproduct_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Incident Type Product**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_incidenttypeproduct_statuscode`|

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

- [business_unit_msdyn_incidenttypeproduct](#BKMK_business_unit_msdyn_incidenttypeproduct)
- [lk_msdyn_incidenttypeproduct_createdby](#BKMK_lk_msdyn_incidenttypeproduct_createdby)
- [lk_msdyn_incidenttypeproduct_createdonbehalfby](#BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby)
- [lk_msdyn_incidenttypeproduct_modifiedby](#BKMK_lk_msdyn_incidenttypeproduct_modifiedby)
- [lk_msdyn_incidenttypeproduct_modifiedonbehalfby](#BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby)
- [msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)
- [msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult](#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult)
- [msdyn_product_msdyn_incidenttypeproduct_Product](#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)
- [msdyn_uom_msdyn_incidenttypeproduct_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)
- [owner_msdyn_incidenttypeproduct](#BKMK_owner_msdyn_incidenttypeproduct)
- [team_msdyn_incidenttypeproduct](#BKMK_team_msdyn_incidenttypeproduct)
- [user_msdyn_incidenttypeproduct](#BKMK_user_msdyn_incidenttypeproduct)

### <a name="BKMK_business_unit_msdyn_incidenttypeproduct"></a> business_unit_msdyn_incidenttypeproduct

One-To-Many Relationship: [businessunit business_unit_msdyn_incidenttypeproduct](businessunit.md#BKMK_business_unit_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeproduct_createdby"></a> lk_msdyn_incidenttypeproduct_createdby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeproduct_createdby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby"></a> lk_msdyn_incidenttypeproduct_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeproduct_modifiedby"></a> lk_msdyn_incidenttypeproduct_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby"></a> lk_msdyn_incidenttypeproduct_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_incidenttypeproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_incidenttypeproduct_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_incidenttypeproduct_IncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_incidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_incidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult"></a> msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult

One-To-Many Relationship: [msdyn_incidenttyperecommendationresult msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult](msdyn_incidenttyperecommendationresult.md#BKMK_msdyn_msdyn_incidenttyperecommendationresult_msdyn_incidenttypeproduct_AppliedSuggestionResult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttyperecommendationresult`|
|ReferencedAttribute|`msdyn_incidenttyperecommendationresultid`|
|ReferencingAttribute|`msdyn_appliedsuggestionresult`|
|ReferencingEntityNavigationPropertyName|`msdyn_AppliedSuggestionResult`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_incidenttypeproduct_Product"></a> msdyn_product_msdyn_incidenttypeproduct_Product

One-To-Many Relationship: [product msdyn_product_msdyn_incidenttypeproduct_Product](product.md#BKMK_msdyn_product_msdyn_incidenttypeproduct_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit"></a> msdyn_uom_msdyn_incidenttypeproduct_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_incidenttypeproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_incidenttypeproduct"></a> owner_msdyn_incidenttypeproduct

One-To-Many Relationship: [owner owner_msdyn_incidenttypeproduct](owner.md#BKMK_owner_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_incidenttypeproduct"></a> team_msdyn_incidenttypeproduct

One-To-Many Relationship: [team team_msdyn_incidenttypeproduct](team.md#BKMK_team_msdyn_incidenttypeproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_incidenttypeproduct"></a> user_msdyn_incidenttypeproduct

One-To-Many Relationship: [systemuser user_msdyn_incidenttypeproduct](systemuser.md#BKMK_user_msdyn_incidenttypeproduct)

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

- [msdyn_incidenttypeproduct_ActivityPointers](#BKMK_msdyn_incidenttypeproduct_ActivityPointers)
- [msdyn_incidenttypeproduct_adx_inviteredemptions](#BKMK_msdyn_incidenttypeproduct_adx_inviteredemptions)
- [msdyn_incidenttypeproduct_adx_portalcomments](#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)
- [msdyn_incidenttypeproduct_Annotations](#BKMK_msdyn_incidenttypeproduct_Annotations)
- [msdyn_incidenttypeproduct_Appointments](#BKMK_msdyn_incidenttypeproduct_Appointments)
- [msdyn_incidenttypeproduct_AsyncOperations](#BKMK_msdyn_incidenttypeproduct_AsyncOperations)
- [msdyn_incidenttypeproduct_BulkDeleteFailures](#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)
- [msdyn_incidenttypeproduct_chats](#BKMK_msdyn_incidenttypeproduct_chats)
- [msdyn_incidenttypeproduct_connections1](#BKMK_msdyn_incidenttypeproduct_connections1)
- [msdyn_incidenttypeproduct_connections2](#BKMK_msdyn_incidenttypeproduct_connections2)
- [msdyn_incidenttypeproduct_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)
- [msdyn_incidenttypeproduct_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)
- [msdyn_incidenttypeproduct_Emails](#BKMK_msdyn_incidenttypeproduct_Emails)
- [msdyn_incidenttypeproduct_Faxes](#BKMK_msdyn_incidenttypeproduct_Faxes)
- [msdyn_incidenttypeproduct_Letters](#BKMK_msdyn_incidenttypeproduct_Letters)
- [msdyn_incidenttypeproduct_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)
- [msdyn_incidenttypeproduct_msdyn_bookingalerts](#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts)
- [msdyn_incidenttypeproduct_msdyn_copilottranscripts](#BKMK_msdyn_incidenttypeproduct_msdyn_copilottranscripts)
- [msdyn_incidenttypeproduct_msdyn_ocliveworkitems](#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)
- [msdyn_incidenttypeproduct_msdyn_ocsessions](#BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions)
- [msdyn_incidenttypeproduct_msfp_alerts](#BKMK_msdyn_incidenttypeproduct_msfp_alerts)
- [msdyn_incidenttypeproduct_msfp_surveyinvites](#BKMK_msdyn_incidenttypeproduct_msfp_surveyinvites)
- [msdyn_incidenttypeproduct_msfp_surveyresponses](#BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses)
- [msdyn_incidenttypeproduct_PhoneCalls](#BKMK_msdyn_incidenttypeproduct_PhoneCalls)
- [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeproduct_ProcessSession](#BKMK_msdyn_incidenttypeproduct_ProcessSession)
- [msdyn_incidenttypeproduct_RecurringAppointmentMasters](#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)
- [msdyn_incidenttypeproduct_ServiceAppointments](#BKMK_msdyn_incidenttypeproduct_ServiceAppointments)
- [msdyn_incidenttypeproduct_SharePointDocumentLocations](#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations)
- [msdyn_incidenttypeproduct_SocialActivities](#BKMK_msdyn_incidenttypeproduct_SocialActivities)
- [msdyn_incidenttypeproduct_SyncErrors](#BKMK_msdyn_incidenttypeproduct_SyncErrors)
- [msdyn_incidenttypeproduct_Tasks](#BKMK_msdyn_incidenttypeproduct_Tasks)

### <a name="BKMK_msdyn_incidenttypeproduct_ActivityPointers"></a> msdyn_incidenttypeproduct_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_incidenttypeproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_incidenttypeproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_adx_inviteredemptions"></a> msdyn_incidenttypeproduct_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_incidenttypeproduct_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_incidenttypeproduct_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_adx_portalcomments"></a> msdyn_incidenttypeproduct_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_incidenttypeproduct_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_incidenttypeproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Annotations"></a> msdyn_incidenttypeproduct_Annotations

Many-To-One Relationship: [annotation msdyn_incidenttypeproduct_Annotations](annotation.md#BKMK_msdyn_incidenttypeproduct_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Appointments"></a> msdyn_incidenttypeproduct_Appointments

Many-To-One Relationship: [appointment msdyn_incidenttypeproduct_Appointments](appointment.md#BKMK_msdyn_incidenttypeproduct_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_AsyncOperations"></a> msdyn_incidenttypeproduct_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_incidenttypeproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_incidenttypeproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures"></a> msdyn_incidenttypeproduct_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_incidenttypeproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_chats"></a> msdyn_incidenttypeproduct_chats

Many-To-One Relationship: [chat msdyn_incidenttypeproduct_chats](chat.md#BKMK_msdyn_incidenttypeproduct_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_connections1"></a> msdyn_incidenttypeproduct_connections1

Many-To-One Relationship: [connection msdyn_incidenttypeproduct_connections1](connection.md#BKMK_msdyn_incidenttypeproduct_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_connections2"></a> msdyn_incidenttypeproduct_connections2

Many-To-One Relationship: [connection msdyn_incidenttypeproduct_connections2](connection.md#BKMK_msdyn_incidenttypeproduct_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord"></a> msdyn_incidenttypeproduct_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttypeproduct_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord"></a> msdyn_incidenttypeproduct_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_incidenttypeproduct_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Emails"></a> msdyn_incidenttypeproduct_Emails

Many-To-One Relationship: [email msdyn_incidenttypeproduct_Emails](email.md#BKMK_msdyn_incidenttypeproduct_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Faxes"></a> msdyn_incidenttypeproduct_Faxes

Many-To-One Relationship: [fax msdyn_incidenttypeproduct_Faxes](fax.md#BKMK_msdyn_incidenttypeproduct_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Letters"></a> msdyn_incidenttypeproduct_Letters

Many-To-One Relationship: [letter msdyn_incidenttypeproduct_Letters](letter.md#BKMK_msdyn_incidenttypeproduct_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders"></a> msdyn_incidenttypeproduct_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_incidenttypeproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts"></a> msdyn_incidenttypeproduct_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_incidenttypeproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_incidenttypeproduct_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_copilottranscripts"></a> msdyn_incidenttypeproduct_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_incidenttypeproduct_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_incidenttypeproduct_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems"></a> msdyn_incidenttypeproduct_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_incidenttypeproduct_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions"></a> msdyn_incidenttypeproduct_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_incidenttypeproduct_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_incidenttypeproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msfp_alerts"></a> msdyn_incidenttypeproduct_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_incidenttypeproduct_msfp_alerts](msfp_alert.md#BKMK_msdyn_incidenttypeproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msfp_surveyinvites"></a> msdyn_incidenttypeproduct_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_incidenttypeproduct_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_incidenttypeproduct_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses"></a> msdyn_incidenttypeproduct_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_incidenttypeproduct_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_incidenttypeproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_PhoneCalls"></a> msdyn_incidenttypeproduct_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_incidenttypeproduct_PhoneCalls](phonecall.md#BKMK_msdyn_incidenttypeproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_ProcessSession"></a> msdyn_incidenttypeproduct_ProcessSession

Many-To-One Relationship: [processsession msdyn_incidenttypeproduct_ProcessSession](processsession.md#BKMK_msdyn_incidenttypeproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters"></a> msdyn_incidenttypeproduct_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_incidenttypeproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_incidenttypeproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_ServiceAppointments"></a> msdyn_incidenttypeproduct_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_incidenttypeproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_incidenttypeproduct_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations"></a> msdyn_incidenttypeproduct_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_incidenttypeproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_incidenttypeproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_SocialActivities"></a> msdyn_incidenttypeproduct_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_incidenttypeproduct_SocialActivities](socialactivity.md#BKMK_msdyn_incidenttypeproduct_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_SyncErrors"></a> msdyn_incidenttypeproduct_SyncErrors

Many-To-One Relationship: [syncerror msdyn_incidenttypeproduct_SyncErrors](syncerror.md#BKMK_msdyn_incidenttypeproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incidenttypeproduct_Tasks"></a> msdyn_incidenttypeproduct_Tasks

Many-To-One Relationship: [task msdyn_incidenttypeproduct_Tasks](task.md#BKMK_msdyn_incidenttypeproduct_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_incidenttypeproduct_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

