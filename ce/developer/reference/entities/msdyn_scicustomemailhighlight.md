---
title: "Custom Email Highlight (msdyn_SciCustomEmailHighlight) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Custom Email Highlight (msdyn_SciCustomEmailHighlight) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Custom Email Highlight (msdyn_SciCustomEmailHighlight) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Custom Email Highlight (msdyn_SciCustomEmailHighlight) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_scicustomemailhighlights<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_scicustomemailhighlights<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_scicustomemailhighlights(*msdyn_scicustomemailhighlightid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Custom Email Highlight (msdyn_SciCustomEmailHighlight) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Custom Email Highlight** |
| **DisplayCollectionName** | **Custom Email Highlights** |
| **SchemaName** | `msdyn_SciCustomEmailHighlight` |
| **CollectionSchemaName** | `msdyn_SciCustomEmailHighlights` |
| **EntitySetName** | `msdyn_scicustomemailhighlights`|
| **LogicalName** | `msdyn_scicustomemailhighlight` |
| **LogicalCollectionName** | `msdyn_scicustomemailhighlights` |
| **PrimaryIdAttribute** | `msdyn_scicustomemailhighlightid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ContentProperties](#BKMK_msdyn_ContentProperties)
- [msdyn_EmailHighlightTarget](#BKMK_msdyn_EmailHighlightTarget)
- [msdyn_Link](#BKMK_msdyn_Link)
- [msdyn_LinkDescription](#BKMK_msdyn_LinkDescription)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_Publisher](#BKMK_msdyn_Publisher)
- [msdyn_SciCustomEmailHighlightId](#BKMK_msdyn_SciCustomEmailHighlightId)
- [msdyn_Snippet](#BKMK_msdyn_Snippet)
- [msdyn_UsedInsights](#BKMK_msdyn_UsedInsights)
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

### <a name="BKMK_msdyn_ContentProperties"></a> msdyn_ContentProperties

|Property|Value|
|---|---|
|Description||
|DisplayName|**Content Properties**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contentproperties`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_EmailHighlightTarget"></a> msdyn_EmailHighlightTarget

|Property|Value|
|---|---|
|Description||
|DisplayName|**Email Highlight Target**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailhighlighttarget`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_conversationaggregatedinsights|

### <a name="BKMK_msdyn_Link"></a> msdyn_Link

|Property|Value|
|---|---|
|Description||
|DisplayName|**Link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_link`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_LinkDescription"></a> msdyn_LinkDescription

|Property|Value|
|---|---|
|Description||
|DisplayName|**Link Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkdescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msdyn_Publisher"></a> msdyn_Publisher

|Property|Value|
|---|---|
|Description||
|DisplayName|**Publisher**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publisher`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_scicustompublisher|

### <a name="BKMK_msdyn_SciCustomEmailHighlightId"></a> msdyn_SciCustomEmailHighlightId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Custom Email Highlight**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_scicustomemailhighlightid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_Snippet"></a> msdyn_Snippet

|Property|Value|
|---|---|
|Description||
|DisplayName|**Snippet**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_snippet`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_UsedInsights"></a> msdyn_UsedInsights

|Property|Value|
|---|---|
|Description||
|DisplayName|**Used Insights**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_usedinsights`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

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
|Description|**Status of the Custom Email Highlight**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_scicustomemailhighlight_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Custom Email Highlight**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_scicustomemailhighlight_statuscode`|

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

- [business_unit_msdyn_scicustomemailhighlight](#BKMK_business_unit_msdyn_scicustomemailhighlight)
- [lk_msdyn_scicustomemailhighlight_createdby](#BKMK_lk_msdyn_scicustomemailhighlight_createdby)
- [lk_msdyn_scicustomemailhighlight_createdonbehalfby](#BKMK_lk_msdyn_scicustomemailhighlight_createdonbehalfby)
- [lk_msdyn_scicustomemailhighlight_modifiedby](#BKMK_lk_msdyn_scicustomemailhighlight_modifiedby)
- [lk_msdyn_scicustomemailhighlight_modifiedonbehalfby](#BKMK_lk_msdyn_scicustomemailhighlight_modifiedonbehalfby)
- [msdyn_msdyn_scicustomemailhighlight_EmailHighli](#BKMK_msdyn_msdyn_scicustomemailhighlight_EmailHighli)
- [msdyn_msdyn_scicustomemailhighlight_Publisher_m](#BKMK_msdyn_msdyn_scicustomemailhighlight_Publisher_m)
- [owner_msdyn_scicustomemailhighlight](#BKMK_owner_msdyn_scicustomemailhighlight)
- [team_msdyn_scicustomemailhighlight](#BKMK_team_msdyn_scicustomemailhighlight)
- [user_msdyn_scicustomemailhighlight](#BKMK_user_msdyn_scicustomemailhighlight)

### <a name="BKMK_business_unit_msdyn_scicustomemailhighlight"></a> business_unit_msdyn_scicustomemailhighlight

One-To-Many Relationship: [businessunit business_unit_msdyn_scicustomemailhighlight](businessunit.md#BKMK_business_unit_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_scicustomemailhighlight_createdby"></a> lk_msdyn_scicustomemailhighlight_createdby

One-To-Many Relationship: [systemuser lk_msdyn_scicustomemailhighlight_createdby](systemuser.md#BKMK_lk_msdyn_scicustomemailhighlight_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_scicustomemailhighlight_createdonbehalfby"></a> lk_msdyn_scicustomemailhighlight_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_scicustomemailhighlight_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_scicustomemailhighlight_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_scicustomemailhighlight_modifiedby"></a> lk_msdyn_scicustomemailhighlight_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_scicustomemailhighlight_modifiedby](systemuser.md#BKMK_lk_msdyn_scicustomemailhighlight_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_scicustomemailhighlight_modifiedonbehalfby"></a> lk_msdyn_scicustomemailhighlight_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_scicustomemailhighlight_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_scicustomemailhighlight_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_scicustomemailhighlight_EmailHighli"></a> msdyn_msdyn_scicustomemailhighlight_EmailHighli

One-To-Many Relationship: [msdyn_conversationaggregatedinsights msdyn_msdyn_scicustomemailhighlight_EmailHighli](msdyn_conversationaggregatedinsights.md#BKMK_msdyn_msdyn_scicustomemailhighlight_EmailHighli)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_conversationaggregatedinsights`|
|ReferencedAttribute|`msdyn_conversationaggregatedinsightsid`|
|ReferencingAttribute|`msdyn_emailhighlighttarget`|
|ReferencingEntityNavigationPropertyName|`msdyn_emailhighlighttarget`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Cascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_scicustomemailhighlight_Publisher_m"></a> msdyn_msdyn_scicustomemailhighlight_Publisher_m

One-To-Many Relationship: [msdyn_scicustompublisher msdyn_msdyn_scicustomemailhighlight_Publisher_m](msdyn_scicustompublisher.md#BKMK_msdyn_msdyn_scicustomemailhighlight_Publisher_m)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_scicustompublisher`|
|ReferencedAttribute|`msdyn_scicustompublisherid`|
|ReferencingAttribute|`msdyn_publisher`|
|ReferencingEntityNavigationPropertyName|`msdyn_publisher`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_scicustomemailhighlight"></a> owner_msdyn_scicustomemailhighlight

One-To-Many Relationship: [owner owner_msdyn_scicustomemailhighlight](owner.md#BKMK_owner_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_scicustomemailhighlight"></a> team_msdyn_scicustomemailhighlight

One-To-Many Relationship: [team team_msdyn_scicustomemailhighlight](team.md#BKMK_team_msdyn_scicustomemailhighlight)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_scicustomemailhighlight"></a> user_msdyn_scicustomemailhighlight

One-To-Many Relationship: [systemuser user_msdyn_scicustomemailhighlight](systemuser.md#BKMK_user_msdyn_scicustomemailhighlight)

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

- [msdyn_scicustomemailhighlight_AsyncOperations](#BKMK_msdyn_scicustomemailhighlight_AsyncOperations)
- [msdyn_scicustomemailhighlight_BulkDeleteFailures](#BKMK_msdyn_scicustomemailhighlight_BulkDeleteFailures)
- [msdyn_scicustomemailhighlight_DuplicateBaseRecord](#BKMK_msdyn_scicustomemailhighlight_DuplicateBaseRecord)
- [msdyn_scicustomemailhighlight_DuplicateMatchingRecord](#BKMK_msdyn_scicustomemailhighlight_DuplicateMatchingRecord)
- [msdyn_scicustomemailhighlight_MailboxTrackingFolders](#BKMK_msdyn_scicustomemailhighlight_MailboxTrackingFolders)
- [msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses)
- [msdyn_scicustomemailhighlight_ProcessSession](#BKMK_msdyn_scicustomemailhighlight_ProcessSession)
- [msdyn_scicustomemailhighlight_SyncErrors](#BKMK_msdyn_scicustomemailhighlight_SyncErrors)

### <a name="BKMK_msdyn_scicustomemailhighlight_AsyncOperations"></a> msdyn_scicustomemailhighlight_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_scicustomemailhighlight_AsyncOperations](asyncoperation.md#BKMK_msdyn_scicustomemailhighlight_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_BulkDeleteFailures"></a> msdyn_scicustomemailhighlight_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_scicustomemailhighlight_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_scicustomemailhighlight_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_DuplicateBaseRecord"></a> msdyn_scicustomemailhighlight_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_scicustomemailhighlight_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_scicustomemailhighlight_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_DuplicateMatchingRecord"></a> msdyn_scicustomemailhighlight_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_scicustomemailhighlight_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_scicustomemailhighlight_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_MailboxTrackingFolders"></a> msdyn_scicustomemailhighlight_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_scicustomemailhighlight_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_scicustomemailhighlight_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses"></a> msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_ProcessSession"></a> msdyn_scicustomemailhighlight_ProcessSession

Many-To-One Relationship: [processsession msdyn_scicustomemailhighlight_ProcessSession](processsession.md#BKMK_msdyn_scicustomemailhighlight_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_scicustomemailhighlight_SyncErrors"></a> msdyn_scicustomemailhighlight_SyncErrors

Many-To-One Relationship: [syncerror msdyn_scicustomemailhighlight_SyncErrors](syncerror.md#BKMK_msdyn_scicustomemailhighlight_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_scicustomemailhighlight_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

