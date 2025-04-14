---
title: "Customer feedback survey invite (msdyn_customerfeedbacksurveyinvite) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Customer feedback survey invite (msdyn_customerfeedbacksurveyinvite) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Customer feedback survey invite (msdyn_customerfeedbacksurveyinvite) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Customer feedback survey invite (msdyn_customerfeedbacksurveyinvite) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_customerfeedbacksurveyinvites<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_customerfeedbacksurveyinvites(*msdyn_customerfeedbacksurveyinviteid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_customerfeedbacksurveyinvites(*msdyn_customerfeedbacksurveyinviteid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_customerfeedbacksurveyinvites<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_customerfeedbacksurveyinvites(*msdyn_customerfeedbacksurveyinviteid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_customerfeedbacksurveyinvites(*msdyn_customerfeedbacksurveyinviteid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_customerfeedbacksurveyinvites(*msdyn_customerfeedbacksurveyinviteid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer feedback survey invite (msdyn_customerfeedbacksurveyinvite) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer feedback survey invite** |
| **DisplayCollectionName** | **Customer feedback surveys invite** |
| **SchemaName** | `msdyn_customerfeedbacksurveyinvite` |
| **CollectionSchemaName** | `msdyn_customerfeedbacksurveyinvites` |
| **EntitySetName** | `msdyn_customerfeedbacksurveyinvites`|
| **LogicalName** | `msdyn_customerfeedbacksurveyinvite` |
| **LogicalCollectionName** | `msdyn_customerfeedbacksurveyinvites` |
| **PrimaryIdAttribute** | `msdyn_customerfeedbacksurveyinviteid` |
| **PrimaryNameAttribute** |`msdyn_customerfeedbacksurveyurl` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_customerfeedbacksurveyid](#BKMK_msdyn_customerfeedbacksurveyid)
- [msdyn_customerfeedbacksurveyinviteId](#BKMK_msdyn_customerfeedbacksurveyinviteId)
- [msdyn_customerfeedbacksurveyurl](#BKMK_msdyn_customerfeedbacksurveyurl)
- [msdyn_inviteemailaddress](#BKMK_msdyn_inviteemailaddress)
- [msdyn_inviteexpirationdate](#BKMK_msdyn_inviteexpirationdate)
- [msdyn_invitestatus](#BKMK_msdyn_invitestatus)
- [msdyn_otherproperties](#BKMK_msdyn_otherproperties)
- [msdyn_regardingobjectid](#BKMK_msdyn_regardingobjectid)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_customerfeedbacksurveyid"></a> msdyn_customerfeedbacksurveyid

|Property|Value|
|---|---|
|Description|**Customer feedback survey Id**|
|DisplayName|**Customer feedback survey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerfeedbacksurvey|

### <a name="BKMK_msdyn_customerfeedbacksurveyinviteId"></a> msdyn_customerfeedbacksurveyinviteId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Customer feedback survey invite Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyinviteid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_customerfeedbacksurveyurl"></a> msdyn_customerfeedbacksurveyurl

|Property|Value|
|---|---|
|Description|**Customer feedback survey URL**|
|DisplayName|**Customer feedback survey URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerfeedbacksurveyurl`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyn_inviteemailaddress"></a> msdyn_inviteemailaddress

|Property|Value|
|---|---|
|Description|**Invite email address**|
|DisplayName|**Invite email address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inviteemailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_inviteexpirationdate"></a> msdyn_inviteexpirationdate

|Property|Value|
|---|---|
|Description|**Date and time when the invite expires**|
|DisplayName|**Invite expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inviteexpirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_invitestatus"></a> msdyn_invitestatus

|Property|Value|
|---|---|
|Description|**Customer feedback bot status**|
|DisplayName|**Customer feedback bot status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_invitestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|357891000|
|GlobalChoiceName|`msdyn_invitestatus`|

#### msdyn_invitestatus Choices/Options

|Value|Label|
|---|---|
|357891000|**Created**|
|357891001|**Sent**|
|357891002|**Responded**|
|357891003|**Invalid**|

### <a name="BKMK_msdyn_otherproperties"></a> msdyn_otherproperties

|Property|Value|
|---|---|
|Description|**Other properties**|
|DisplayName|**Other properties**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otherproperties`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_regardingobjectid"></a> msdyn_regardingobjectid

|Property|Value|
|---|---|
|Description|**Regarding object identifier**|
|DisplayName|**Regarding object identifier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingobjectid`|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the customer feedback survey invite**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerfeedbacksurveyinvite_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the customer feedback survey invite**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerfeedbacksurveyinvite_statuscode`|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msdyn_customerfeedbacksurveyinvite_createdby](#BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdby)
- [lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby](#BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby)
- [lk_msdyn_customerfeedbacksurveyinvite_modifiedby](#BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedby)
- [lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby](#BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby)
- [msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite](#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite)
- [organization_msdyn_customerfeedbacksurveyinvite](#BKMK_organization_msdyn_customerfeedbacksurveyinvite)

### <a name="BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdby"></a> lk_msdyn_customerfeedbacksurveyinvite_createdby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurveyinvite_createdby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby"></a> lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurveyinvite_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedby"></a> lk_msdyn_customerfeedbacksurveyinvite_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurveyinvite_modifiedby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby"></a> lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_customerfeedbacksurveyinvite_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite"></a> msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite

One-To-Many Relationship: [msdyn_customerfeedbacksurvey msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite](msdyn_customerfeedbacksurvey.md#BKMK_msdyn_customerfeedbacksurvey_msdyn_customerfeedbacksurveyinvite)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerfeedbacksurvey`|
|ReferencedAttribute|`msdyn_customerfeedbacksurveyid`|
|ReferencingAttribute|`msdyn_customerfeedbacksurveyid`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_customerfeedbacksurveyinvite"></a> organization_msdyn_customerfeedbacksurveyinvite

One-To-Many Relationship: [organization organization_msdyn_customerfeedbacksurveyinvite](organization.md#BKMK_organization_msdyn_customerfeedbacksurveyinvite)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customerfeedbacksurveyinvite_AsyncOperations](#BKMK_msdyn_customerfeedbacksurveyinvite_AsyncOperations)
- [msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures](#BKMK_msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures)
- [msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord](#BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord)
- [msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord](#BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord)
- [msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders](#BKMK_msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders)
- [msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse](#BKMK_msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse)
- [msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses)
- [msdyn_customerfeedbacksurveyinvite_ProcessSession](#BKMK_msdyn_customerfeedbacksurveyinvite_ProcessSession)
- [msdyn_customerfeedbacksurveyinvite_SyncErrors](#BKMK_msdyn_customerfeedbacksurveyinvite_SyncErrors)

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_AsyncOperations"></a> msdyn_customerfeedbacksurveyinvite_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_customerfeedbacksurveyinvite_AsyncOperations](asyncoperation.md#BKMK_msdyn_customerfeedbacksurveyinvite_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures"></a> msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord"></a> msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord"></a> msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders"></a> msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse"></a> msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse

Many-To-One Relationship: [msdyn_customerfeedbacksurveyresponse msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse](msdyn_customerfeedbacksurveyresponse.md#BKMK_msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerfeedbacksurveyresponse`|
|ReferencingAttribute|`msdyn_customerfeedbacksurveyinviteid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_msdyn_customerfeedbacksurveyresponse`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses"></a> msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_ProcessSession"></a> msdyn_customerfeedbacksurveyinvite_ProcessSession

Many-To-One Relationship: [processsession msdyn_customerfeedbacksurveyinvite_ProcessSession](processsession.md#BKMK_msdyn_customerfeedbacksurveyinvite_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerfeedbacksurveyinvite_SyncErrors"></a> msdyn_customerfeedbacksurveyinvite_SyncErrors

Many-To-One Relationship: [syncerror msdyn_customerfeedbacksurveyinvite_SyncErrors](syncerror.md#BKMK_msdyn_customerfeedbacksurveyinvite_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerfeedbacksurveyinvite_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

