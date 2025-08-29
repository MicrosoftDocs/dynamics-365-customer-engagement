---
title: "SalesAgentProfile (msdyn_salesagentprofile) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the SalesAgentProfile (msdyn_salesagentprofile) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SalesAgentProfile (msdyn_salesagentprofile) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the SalesAgentProfile (msdyn_salesagentprofile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesagentprofiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesagentprofiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesagentprofiles(*msdyn_salesagentprofileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the SalesAgentProfile (msdyn_salesagentprofile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **SalesAgentProfile** |
| **DisplayCollectionName** | **salesagentprofiles** |
| **SchemaName** | `msdyn_salesagentprofile` |
| **CollectionSchemaName** | `msdyn_salesagentprofiles` |
| **EntitySetName** | `msdyn_salesagentprofiles`|
| **LogicalName** | `msdyn_salesagentprofile` |
| **LogicalCollectionName** | `msdyn_salesagentprofiles` |
| **PrimaryIdAttribute** | `msdyn_salesagentprofileid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActivatedBy](#BKMK_msdyn_ActivatedBy)
- [msdyn_ActivatedOn](#BKMK_msdyn_ActivatedOn)
- [msdyn_aidisclaimer](#BKMK_msdyn_aidisclaimer)
- [msdyn_complianceprofile](#BKMK_msdyn_complianceprofile)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_emailsignaturerecordid](#BKMK_msdyn_emailsignaturerecordid)
- [msdyn_MicroAgentsConfiguration](#BKMK_msdyn_MicroAgentsConfiguration)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_otherterms](#BKMK_msdyn_otherterms)
- [msdyn_purpose](#BKMK_msdyn_purpose)
- [msdyn_SalesAgentInfo](#BKMK_msdyn_SalesAgentInfo)
- [msdyn_salesagentprofileId](#BKMK_msdyn_salesagentprofileId)
- [msdyn_SalesAgentType](#BKMK_msdyn_SalesAgentType)
- [msdyn_SegmentInfo](#BKMK_msdyn_SegmentInfo)
- [msdyn_topic](#BKMK_msdyn_topic)
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

### <a name="BKMK_msdyn_ActivatedBy"></a> msdyn_ActivatedBy

|Property|Value|
|---|---|
|Description||
|DisplayName|**ActivatedBy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activatedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_ActivatedOn"></a> msdyn_ActivatedOn

|Property|Value|
|---|---|
|Description||
|DisplayName|**ActivatedOn**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_aidisclaimer"></a> msdyn_aidisclaimer

|Property|Value|
|---|---|
|Description|**AI disclaimer text for the sales agent**|
|DisplayName|**AI Disclaimer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_aidisclaimer`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_complianceprofile"></a> msdyn_complianceprofile

|Property|Value|
|---|---|
|Description|**Compliance profile entity record id.**|
|DisplayName|**Compliance Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_complianceprofile`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description of the Agent**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_emailsignaturerecordid"></a> msdyn_emailsignaturerecordid

|Property|Value|
|---|---|
|Description|**Email signature id for the sales agent**|
|DisplayName|**Email Signature**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailsignaturerecordid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_MicroAgentsConfiguration"></a> msdyn_MicroAgentsConfiguration

|Property|Value|
|---|---|
|Description||
|DisplayName|**MicroAgentsConfiguration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_microagentsconfiguration`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_otherterms"></a> msdyn_otherterms

|Property|Value|
|---|---|
|Description|**Other terms and conditions for the sales agent**|
|DisplayName|**Other Terms**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_otherterms`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_purpose"></a> msdyn_purpose

|Property|Value|
|---|---|
|Description|**Purpose entity record id.**|
|DisplayName|**Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purpose`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SalesAgentInfo"></a> msdyn_SalesAgentInfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**SalesAgentInfo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentinfo`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_salesagentprofileId"></a> msdyn_salesagentprofileId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**SalesAgentProfileId**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagentprofileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SalesAgentType"></a> msdyn_SalesAgentType

|Property|Value|
|---|---|
|Description|**Type of agent**|
|DisplayName|**Agent type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesagenttype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesagentprofile_msdyn_salesagenttype`|

#### msdyn_SalesAgentType Choices/Options

|Value|Label|
|---|---|
|1|**SQA Research**|
|2|**SQA Autonomous**|
|3|**DCA Research**|
|4|**DCA Autonomous**|

### <a name="BKMK_msdyn_SegmentInfo"></a> msdyn_SegmentInfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Segment info**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentinfo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_topic"></a> msdyn_topic

|Property|Value|
|---|---|
|Description|**Topic entity record id.**|
|DisplayName|**Topic**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_topic`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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
|Description|**Status of the SalesAgentProfile**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentprofile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Inactive**<br />DefaultStatus: 1<br />InvariantName: `Inactive`|
|1|Label: **Active**<br />DefaultStatus: 2<br />InvariantName: `Active`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the SalesAgentProfile**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesagentprofile_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **On**<br />State:1<br />TransitionData: None|
|3|Label: **Off**<br />State:0<br />TransitionData: None|
|4|Label: **Testing**<br />State:1<br />TransitionData: None|
|5|Label: **Upgrade**<br />State:0<br />TransitionData: None|

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

- [business_unit_msdyn_salesagentprofile](#BKMK_business_unit_msdyn_salesagentprofile)
- [lk_msdyn_salesagentprofile_createdby](#BKMK_lk_msdyn_salesagentprofile_createdby)
- [lk_msdyn_salesagentprofile_createdonbehalfby](#BKMK_lk_msdyn_salesagentprofile_createdonbehalfby)
- [lk_msdyn_salesagentprofile_modifiedby](#BKMK_lk_msdyn_salesagentprofile_modifiedby)
- [lk_msdyn_salesagentprofile_modifiedonbehalfby](#BKMK_lk_msdyn_salesagentprofile_modifiedonbehalfby)
- [msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy](#BKMK_msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy)
- [msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo](#BKMK_msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo)
- [owner_msdyn_salesagentprofile](#BKMK_owner_msdyn_salesagentprofile)
- [team_msdyn_salesagentprofile](#BKMK_team_msdyn_salesagentprofile)
- [user_msdyn_salesagentprofile](#BKMK_user_msdyn_salesagentprofile)

### <a name="BKMK_business_unit_msdyn_salesagentprofile"></a> business_unit_msdyn_salesagentprofile

One-To-Many Relationship: [businessunit business_unit_msdyn_salesagentprofile](businessunit.md#BKMK_business_unit_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprofile_createdby"></a> lk_msdyn_salesagentprofile_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprofile_createdby](systemuser.md#BKMK_lk_msdyn_salesagentprofile_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprofile_createdonbehalfby"></a> lk_msdyn_salesagentprofile_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprofile_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentprofile_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprofile_modifiedby"></a> lk_msdyn_salesagentprofile_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprofile_modifiedby](systemuser.md#BKMK_lk_msdyn_salesagentprofile_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesagentprofile_modifiedonbehalfby"></a> lk_msdyn_salesagentprofile_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesagentprofile_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesagentprofile_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy"></a> msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy](systemuser.md#BKMK_msdyn_systemuser_msdyn_salesagentprofile_ActivatedBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_activatedby`|
|ReferencingEntityNavigationPropertyName|`msdyn_ActivatedBy`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo"></a> msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo](systemuser.md#BKMK_msdyn_systemuser_msdyn_salesagentprofile_SalesAgentInfo)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_salesagentinfo`|
|ReferencingEntityNavigationPropertyName|`msdyn_SalesAgentInfo`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salesagentprofile"></a> owner_msdyn_salesagentprofile

One-To-Many Relationship: [owner owner_msdyn_salesagentprofile](owner.md#BKMK_owner_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salesagentprofile"></a> team_msdyn_salesagentprofile

One-To-Many Relationship: [team team_msdyn_salesagentprofile](team.md#BKMK_team_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salesagentprofile"></a> user_msdyn_salesagentprofile

One-To-Many Relationship: [systemuser user_msdyn_salesagentprofile](systemuser.md#BKMK_user_msdyn_salesagentprofile)

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

- [msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile](#BKMK_msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile)
- [msdyn_salesagentprofile_AsyncOperations](#BKMK_msdyn_salesagentprofile_AsyncOperations)
- [msdyn_salesagentprofile_BulkDeleteFailures](#BKMK_msdyn_salesagentprofile_BulkDeleteFailures)
- [msdyn_salesagentprofile_DuplicateBaseRecord](#BKMK_msdyn_salesagentprofile_DuplicateBaseRecord)
- [msdyn_salesagentprofile_DuplicateMatchingRecord](#BKMK_msdyn_salesagentprofile_DuplicateMatchingRecord)
- [msdyn_salesagentprofile_MailboxTrackingFolders](#BKMK_msdyn_salesagentprofile_MailboxTrackingFolders)
- [msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile](#BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile)
- [msdyn_salesagentprofile_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesagentprofile_PrincipalObjectAttributeAccesses)
- [msdyn_salesagentprofile_ProcessSession](#BKMK_msdyn_salesagentprofile_ProcessSession)
- [msdyn_salesagentprofile_SyncErrors](#BKMK_msdyn_salesagentprofile_SyncErrors)
- [msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile](#BKMK_msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile)

### <a name="BKMK_msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile"></a> msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile

Many-To-One Relationship: [msdyn_salesagentexecutionconfig msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile](msdyn_salesagentexecutionconfig.md#BKMK_msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesagentexecutionconfig`|
|ReferencingAttribute|`msdyn_salesagentprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentexecutionconfig_msdyn_salesagentprofileid_msdyn_salesagentprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_AsyncOperations"></a> msdyn_salesagentprofile_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesagentprofile_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesagentprofile_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_BulkDeleteFailures"></a> msdyn_salesagentprofile_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesagentprofile_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesagentprofile_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_DuplicateBaseRecord"></a> msdyn_salesagentprofile_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesagentprofile_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salesagentprofile_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_DuplicateMatchingRecord"></a> msdyn_salesagentprofile_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesagentprofile_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salesagentprofile_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_MailboxTrackingFolders"></a> msdyn_salesagentprofile_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesagentprofile_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesagentprofile_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile"></a> msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile

Many-To-One Relationship: [msdyn_salesagentrun msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile](msdyn_salesagentrun.md#BKMK_msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesagentrun`|
|ReferencingAttribute|`msdyn_salesagentprofileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_msdyn_salesagentrun_SalesAgentProfile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_PrincipalObjectAttributeAccesses"></a> msdyn_salesagentprofile_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesagentprofile_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesagentprofile_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_ProcessSession"></a> msdyn_salesagentprofile_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesagentprofile_ProcessSession](processsession.md#BKMK_msdyn_salesagentprofile_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesagentprofile_SyncErrors"></a> msdyn_salesagentprofile_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesagentprofile_SyncErrors](syncerror.md#BKMK_msdyn_salesagentprofile_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesagentprofile_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile"></a> msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile

Many-To-One Relationship: [msdyn_triggersalesagent msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile](msdyn_triggersalesagent.md#BKMK_msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_triggersalesagent`|
|ReferencingAttribute|`msdyn_salesagentprofile`|
|ReferencedEntityNavigationPropertyName|`msdyn_triggersalesagent_salesagentprofile_msdyn_salesagentprofile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

