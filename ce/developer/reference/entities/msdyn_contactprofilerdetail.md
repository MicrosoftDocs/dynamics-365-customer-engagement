---
title: "contactprofilerdetail (msdyn_contactprofilerdetail) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the contactprofilerdetail (msdyn_contactprofilerdetail) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# contactprofilerdetail (msdyn_contactprofilerdetail) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the contactprofilerdetail (msdyn_contactprofilerdetail) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_contactprofilerdetails<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_contactprofilerdetails<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_contactprofilerdetails(*msdyn_contactprofilerdetailid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the contactprofilerdetail (msdyn_contactprofilerdetail) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **contactprofilerdetail** |
| **DisplayCollectionName** | **contactprofilerdetails** |
| **SchemaName** | `msdyn_contactprofilerdetail` |
| **CollectionSchemaName** | `msdyn_contactprofilerdetails` |
| **EntitySetName** | `msdyn_contactprofilerdetails`|
| **LogicalName** | `msdyn_contactprofilerdetail` |
| **LogicalCollectionName** | `msdyn_contactprofilerdetails` |
| **PrimaryIdAttribute** | `msdyn_contactprofilerdetailid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_additionalinfo](#BKMK_msdyn_additionalinfo)
- [msdyn_citation](#BKMK_msdyn_citation)
- [msdyn_contactid](#BKMK_msdyn_contactid)
- [msdyn_contactprofilerdetailId](#BKMK_msdyn_contactprofilerdetailId)
- [msdyn_contactprofilerresultid](#BKMK_msdyn_contactprofilerresultid)
- [msdyn_emailaddress](#BKMK_msdyn_emailaddress)
- [msdyn_firstname](#BKMK_msdyn_firstname)
- [msdyn_iscontactaddedtocrm](#BKMK_msdyn_iscontactaddedtocrm)
- [msdyn_ismarkedirrelevant](#BKMK_msdyn_ismarkedirrelevant)
- [msdyn_jobtitle](#BKMK_msdyn_jobtitle)
- [msdyn_lastname](#BKMK_msdyn_lastname)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_phonenumber](#BKMK_msdyn_phonenumber)
- [msdyn_profileurl](#BKMK_msdyn_profileurl)
- [msdyn_rank](#BKMK_msdyn_rank)
- [msdyn_reasoning](#BKMK_msdyn_reasoning)
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

### <a name="BKMK_msdyn_additionalinfo"></a> msdyn_additionalinfo

|Property|Value|
|---|---|
|Description||
|DisplayName|**additionalinfo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalinfo`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_citation"></a> msdyn_citation

|Property|Value|
|---|---|
|Description||
|DisplayName|**citation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_citation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_contactid"></a> msdyn_contactid

|Property|Value|
|---|---|
|Description||
|DisplayName|**contactid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyn_contactprofilerdetailId"></a> msdyn_contactprofilerdetailId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**contactprofilerdetailid**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_contactprofilerdetailid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_contactprofilerresultid"></a> msdyn_contactprofilerresultid

|Property|Value|
|---|---|
|Description||
|DisplayName|**contactprofilerresultid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contactprofilerresultid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_contactprofilerresult|

### <a name="BKMK_msdyn_emailaddress"></a> msdyn_emailaddress

|Property|Value|
|---|---|
|Description||
|DisplayName|**emailaddress**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_emailaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_firstname"></a> msdyn_firstname

|Property|Value|
|---|---|
|Description||
|DisplayName|**firstname**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_iscontactaddedtocrm"></a> msdyn_iscontactaddedtocrm

|Property|Value|
|---|---|
|Description||
|DisplayName|**iscontactaddedtocrm**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscontactaddedtocrm`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_contactprofilerdetail_msdyn_iscontactaddedtocrm`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_ismarkedirrelevant"></a> msdyn_ismarkedirrelevant

|Property|Value|
|---|---|
|Description||
|DisplayName|**ismarkedirrelevant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ismarkedirrelevant`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_contactprofilerdetail_msdyn_ismarkedirrelevant`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_jobtitle"></a> msdyn_jobtitle

|Property|Value|
|---|---|
|Description||
|DisplayName|**jobtitle**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobtitle`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastname"></a> msdyn_lastname

|Property|Value|
|---|---|
|Description||
|DisplayName|**lastname**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_phonenumber"></a> msdyn_phonenumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**phonenumber**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_profileurl"></a> msdyn_profileurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**profileurl**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_profileurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_rank"></a> msdyn_rank

|Property|Value|
|---|---|
|Description||
|DisplayName|**rank**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rank`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_reasoning"></a> msdyn_reasoning

|Property|Value|
|---|---|
|Description||
|DisplayName|**reasoning**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reasoning`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

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
|Description|**Status of the contactprofilerdetail**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_contactprofilerdetail_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the contactprofilerdetail**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_contactprofilerdetail_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|10001|Label: **Domain Mismatch**<br />State:0<br />TransitionData: None|

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

- [business_unit_msdyn_contactprofilerdetail](#BKMK_business_unit_msdyn_contactprofilerdetail)
- [lk_msdyn_contactprofilerdetail_createdby](#BKMK_lk_msdyn_contactprofilerdetail_createdby)
- [lk_msdyn_contactprofilerdetail_createdonbehalfby](#BKMK_lk_msdyn_contactprofilerdetail_createdonbehalfby)
- [lk_msdyn_contactprofilerdetail_modifiedby](#BKMK_lk_msdyn_contactprofilerdetail_modifiedby)
- [lk_msdyn_contactprofilerdetail_modifiedonbehalfby](#BKMK_lk_msdyn_contactprofilerdetail_modifiedonbehalfby)
- [msdyn_contactprofilerdetail_contactid_contact](#BKMK_msdyn_contactprofilerdetail_contactid_contact)
- [msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult](#BKMK_msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult)
- [owner_msdyn_contactprofilerdetail](#BKMK_owner_msdyn_contactprofilerdetail)
- [team_msdyn_contactprofilerdetail](#BKMK_team_msdyn_contactprofilerdetail)
- [user_msdyn_contactprofilerdetail](#BKMK_user_msdyn_contactprofilerdetail)

### <a name="BKMK_business_unit_msdyn_contactprofilerdetail"></a> business_unit_msdyn_contactprofilerdetail

One-To-Many Relationship: [businessunit business_unit_msdyn_contactprofilerdetail](businessunit.md#BKMK_business_unit_msdyn_contactprofilerdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_contactprofilerdetail_createdby"></a> lk_msdyn_contactprofilerdetail_createdby

One-To-Many Relationship: [systemuser lk_msdyn_contactprofilerdetail_createdby](systemuser.md#BKMK_lk_msdyn_contactprofilerdetail_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_contactprofilerdetail_createdonbehalfby"></a> lk_msdyn_contactprofilerdetail_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_contactprofilerdetail_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_contactprofilerdetail_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_contactprofilerdetail_modifiedby"></a> lk_msdyn_contactprofilerdetail_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_contactprofilerdetail_modifiedby](systemuser.md#BKMK_lk_msdyn_contactprofilerdetail_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_contactprofilerdetail_modifiedonbehalfby"></a> lk_msdyn_contactprofilerdetail_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_contactprofilerdetail_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_contactprofilerdetail_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contactprofilerdetail_contactid_contact"></a> msdyn_contactprofilerdetail_contactid_contact

One-To-Many Relationship: [contact msdyn_contactprofilerdetail_contactid_contact](contact.md#BKMK_msdyn_contactprofilerdetail_contactid_contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_contactid`|
|ReferencingEntityNavigationPropertyName|`msdyn_contactid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult"></a> msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult

One-To-Many Relationship: [msdyn_contactprofilerresult msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult](msdyn_contactprofilerresult.md#BKMK_msdyn_contactprofilerdetail_contactprofilerresultid_msdyn_contactprofilerresult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_contactprofilerresult`|
|ReferencedAttribute|`msdyn_contactprofilerresultid`|
|ReferencingAttribute|`msdyn_contactprofilerresultid`|
|ReferencingEntityNavigationPropertyName|`msdyn_contactprofilerresultid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_contactprofilerdetail"></a> owner_msdyn_contactprofilerdetail

One-To-Many Relationship: [owner owner_msdyn_contactprofilerdetail](owner.md#BKMK_owner_msdyn_contactprofilerdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_contactprofilerdetail"></a> team_msdyn_contactprofilerdetail

One-To-Many Relationship: [team team_msdyn_contactprofilerdetail](team.md#BKMK_team_msdyn_contactprofilerdetail)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_contactprofilerdetail"></a> user_msdyn_contactprofilerdetail

One-To-Many Relationship: [systemuser user_msdyn_contactprofilerdetail](systemuser.md#BKMK_user_msdyn_contactprofilerdetail)

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

- [msdyn_contactprofilerdetail_AsyncOperations](#BKMK_msdyn_contactprofilerdetail_AsyncOperations)
- [msdyn_contactprofilerdetail_BulkDeleteFailures](#BKMK_msdyn_contactprofilerdetail_BulkDeleteFailures)
- [msdyn_contactprofilerdetail_DuplicateBaseRecord](#BKMK_msdyn_contactprofilerdetail_DuplicateBaseRecord)
- [msdyn_contactprofilerdetail_DuplicateMatchingRecord](#BKMK_msdyn_contactprofilerdetail_DuplicateMatchingRecord)
- [msdyn_contactprofilerdetail_MailboxTrackingFolders](#BKMK_msdyn_contactprofilerdetail_MailboxTrackingFolders)
- [msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses)
- [msdyn_contactprofilerdetail_ProcessSession](#BKMK_msdyn_contactprofilerdetail_ProcessSession)
- [msdyn_contactprofilerdetail_SyncErrors](#BKMK_msdyn_contactprofilerdetail_SyncErrors)

### <a name="BKMK_msdyn_contactprofilerdetail_AsyncOperations"></a> msdyn_contactprofilerdetail_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_contactprofilerdetail_AsyncOperations](asyncoperation.md#BKMK_msdyn_contactprofilerdetail_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_BulkDeleteFailures"></a> msdyn_contactprofilerdetail_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_contactprofilerdetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_contactprofilerdetail_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_DuplicateBaseRecord"></a> msdyn_contactprofilerdetail_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_contactprofilerdetail_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_contactprofilerdetail_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_DuplicateMatchingRecord"></a> msdyn_contactprofilerdetail_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_contactprofilerdetail_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_contactprofilerdetail_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_MailboxTrackingFolders"></a> msdyn_contactprofilerdetail_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_contactprofilerdetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_contactprofilerdetail_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses"></a> msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_ProcessSession"></a> msdyn_contactprofilerdetail_ProcessSession

Many-To-One Relationship: [processsession msdyn_contactprofilerdetail_ProcessSession](processsession.md#BKMK_msdyn_contactprofilerdetail_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_contactprofilerdetail_SyncErrors"></a> msdyn_contactprofilerdetail_SyncErrors

Many-To-One Relationship: [syncerror msdyn_contactprofilerdetail_SyncErrors](syncerror.md#BKMK_msdyn_contactprofilerdetail_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_contactprofilerdetail_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

