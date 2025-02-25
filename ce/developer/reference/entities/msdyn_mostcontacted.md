---
title: "Most Contacted (msdyn_mostcontacted) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Most Contacted (msdyn_mostcontacted) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Most Contacted (msdyn_mostcontacted) table/entity reference (Microsoft Dynamics 365)

Most Contacted

## Messages

The following table lists the messages for the Most Contacted (msdyn_mostcontacted) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_mostcontacteds<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_mostcontacteds(*msdyn_mostcontactedid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_mostcontacteds(*msdyn_mostcontactedid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_mostcontacteds<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_mostcontacteds(*msdyn_mostcontactedid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_mostcontacteds(*msdyn_mostcontactedid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_mostcontacteds(*msdyn_mostcontactedid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Most Contacted (msdyn_mostcontacted) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Most Contacted** |
| **DisplayCollectionName** | **Most Contacted** |
| **SchemaName** | `msdyn_mostcontacted` |
| **CollectionSchemaName** | `msdyn_mostcontacteds` |
| **EntitySetName** | `msdyn_mostcontacteds`|
| **LogicalName** | `msdyn_mostcontacted` |
| **LogicalCollectionName** | `msdyn_mostcontacteds` |
| **PrimaryIdAttribute** | `msdyn_mostcontactedid` |
| **PrimaryNameAttribute** |`msdyn_primaryname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_account_regardingObjectId](#BKMK_msdyn_account_regardingObjectId)
- [msdyn_computationaccuracy](#BKMK_msdyn_computationaccuracy)
- [msdyn_contact_regardingObjectId](#BKMK_msdyn_contact_regardingObjectId)
- [msdyn_entityid](#BKMK_msdyn_entityid)
- [msdyn_entityImage_url](#BKMK_msdyn_entityImage_url)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_kpidatajson](#BKMK_msdyn_kpidatajson)
- [msdyn_lastcontactedby](#BKMK_msdyn_lastcontactedby)
- [msdyn_lastcontactedon](#BKMK_msdyn_lastcontactedon)
- [msdyn_lead_regardingObjectId](#BKMK_msdyn_lead_regardingObjectId)
- [msdyn_mostcontactedId](#BKMK_msdyn_mostcontactedId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_numberofemails](#BKMK_msdyn_numberofemails)
- [msdyn_numberofinmails](#BKMK_msdyn_numberofinmails)
- [msdyn_numberofmeetings](#BKMK_msdyn_numberofmeetings)
- [msdyn_numberofphonecalls](#BKMK_msdyn_numberofphonecalls)
- [msdyn_opportunity_regardingObjectId](#BKMK_msdyn_opportunity_regardingObjectId)
- [msdyn_primaryname](#BKMK_msdyn_primaryname)
- [msdyn_regardingentityid](#BKMK_msdyn_regardingentityid)
- [msdyn_regardingentityname](#BKMK_msdyn_regardingentityname)
- [msdyn_relationshiphealthscorecolor](#BKMK_msdyn_relationshiphealthscorecolor)
- [msdyn_relationshiphealthscorevalue](#BKMK_msdyn_relationshiphealthscorevalue)
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

### <a name="BKMK_msdyn_account_regardingObjectId"></a> msdyn_account_regardingObjectId

|Property|Value|
|---|---|
|Description|**Shows related account.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_computationaccuracy"></a> msdyn_computationaccuracy

|Property|Value|
|---|---|
|Description||
|DisplayName|**Computation Accuracy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_computationaccuracy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_kpicomputationaccuracy`|

#### msdyn_computationaccuracy Choices/Options

|Value|Label|
|---|---|
|100000000|**Complete**|
|100000001|**Partial**|

### <a name="BKMK_msdyn_contact_regardingObjectId"></a> msdyn_contact_regardingObjectId

|Property|Value|
|---|---|
|Description|**Shows related contact.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_contact_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyn_entityid"></a> msdyn_entityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**EntityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_entityImage_url"></a> msdyn_entityImage_url

|Property|Value|
|---|---|
|Description|**Entity Image URL**|
|DisplayName|**Entity Image URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityimage_url`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

|Property|Value|
|---|---|
|Description|**The entity name of the most contacted record.**|
|DisplayName|**Most Contacted Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_kpidatajson"></a> msdyn_kpidatajson

|Property|Value|
|---|---|
|Description|**Most contacted KPI data as JSON**|
|DisplayName|**Most contacted KPIs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_kpidatajson`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Disabled|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_lastcontactedby"></a> msdyn_lastcontactedby

|Property|Value|
|---|---|
|Description|**Shows who made the last contact.**|
|DisplayName|**Last Contacted By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcontactedby`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lastcontactedon"></a> msdyn_lastcontactedon

|Property|Value|
|---|---|
|Description|**Shows when the contact was last contacted.**|
|DisplayName|**Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcontactedon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_lead_regardingObjectId"></a> msdyn_lead_regardingObjectId

|Property|Value|
|---|---|
|Description|**Shows what the lead was regarding.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lead_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyn_mostcontactedId"></a> msdyn_mostcontactedId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances.**|
|DisplayName|**Most Contacted**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_mostcontactedid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdyn_numberofemails"></a> msdyn_numberofemails

|Property|Value|
|---|---|
|Description|**Shows the number of emails from the contact.**|
|DisplayName|**Emails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofemails`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_numberofinmails"></a> msdyn_numberofinmails

|Property|Value|
|---|---|
|Description|**Shows the number of InMails with the contact.**|
|DisplayName|**InMails**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofinmails`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_numberofmeetings"></a> msdyn_numberofmeetings

|Property|Value|
|---|---|
|Description|**Shows the number of meetings with the contact.**|
|DisplayName|**Meetings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofmeetings`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_numberofphonecalls"></a> msdyn_numberofphonecalls

|Property|Value|
|---|---|
|Description|**Shows the number of phone calls with the contact.**|
|DisplayName|**Phone Calls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofphonecalls`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_opportunity_regardingObjectId"></a> msdyn_opportunity_regardingObjectId

|Property|Value|
|---|---|
|Description|**Shows what the opportunity was regarding.**|
|DisplayName|**Regarding**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunity_regardingobjectid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_primaryname"></a> msdyn_primaryname

|Property|Value|
|---|---|
|Description|**Shows the primary name of the custom entity.**|
|DisplayName|**Primary Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingentityid"></a> msdyn_regardingentityid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding EntityId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_regardingentityname"></a> msdyn_regardingentityname

|Property|Value|
|---|---|
|Description||
|DisplayName|**Regarding Entity Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_regardingentityname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_relationshiphealthscorecolor"></a> msdyn_relationshiphealthscorecolor

|Property|Value|
|---|---|
|Description|**Health score for the account.**|
|DisplayName|**Relationship Health**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthscorecolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_relationshiphealthscorevalue"></a> msdyn_relationshiphealthscorevalue

|Property|Value|
|---|---|
|Description|**Health score for the account.**|
|DisplayName|**Relationship Health**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relationshiphealthscorevalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time the record was migrated.**|
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
|Description|**Status of the Most Contacted**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_mostcontacted_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Most Contacted**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_mostcontacted_statuscode`|

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
|Description|**Shows unique identifier for the organization.**|
|DisplayName|**Organization ID**|
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

- [lk_msdyn_mostcontacted_createdby](#BKMK_lk_msdyn_mostcontacted_createdby)
- [lk_msdyn_mostcontacted_createdonbehalfby](#BKMK_lk_msdyn_mostcontacted_createdonbehalfby)
- [lk_msdyn_mostcontacted_modifiedby](#BKMK_lk_msdyn_mostcontacted_modifiedby)
- [lk_msdyn_mostcontacted_modifiedonbehalfby](#BKMK_lk_msdyn_mostcontacted_modifiedonbehalfby)
- [msdyn_account_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId)
- [msdyn_contact_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId)
- [msdyn_lead_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId)
- [msdyn_opportunity_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId)
- [organization_msdyn_mostcontacted](#BKMK_organization_msdyn_mostcontacted)

### <a name="BKMK_lk_msdyn_mostcontacted_createdby"></a> lk_msdyn_mostcontacted_createdby

One-To-Many Relationship: [systemuser lk_msdyn_mostcontacted_createdby](systemuser.md#BKMK_lk_msdyn_mostcontacted_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_mostcontacted_createdonbehalfby"></a> lk_msdyn_mostcontacted_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_mostcontacted_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_mostcontacted_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_mostcontacted_modifiedby"></a> lk_msdyn_mostcontacted_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_mostcontacted_modifiedby](systemuser.md#BKMK_lk_msdyn_mostcontacted_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_mostcontacted_modifiedonbehalfby"></a> lk_msdyn_mostcontacted_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_mostcontacted_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_mostcontacted_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId"></a> msdyn_account_msdyn_mostcontacted_regardingObjectId

One-To-Many Relationship: [account msdyn_account_msdyn_mostcontacted_regardingObjectId](account.md#BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_account_regardingObjectId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId"></a> msdyn_contact_msdyn_mostcontacted_regardingObjectId

One-To-Many Relationship: [contact msdyn_contact_msdyn_mostcontacted_regardingObjectId](contact.md#BKMK_msdyn_contact_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_contact_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_contact_regardingObjectId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId"></a> msdyn_lead_msdyn_mostcontacted_regardingObjectId

One-To-Many Relationship: [lead msdyn_lead_msdyn_mostcontacted_regardingObjectId](lead.md#BKMK_msdyn_lead_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_lead_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_lead_regardingObjectId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId"></a> msdyn_opportunity_msdyn_mostcontacted_regardingObjectId

One-To-Many Relationship: [opportunity msdyn_opportunity_msdyn_mostcontacted_regardingObjectId](opportunity.md#BKMK_msdyn_opportunity_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_opportunity_regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`msdyn_opportunity_regardingObjectId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_mostcontacted"></a> organization_msdyn_mostcontacted

One-To-Many Relationship: [organization organization_msdyn_mostcontacted](organization.md#BKMK_organization_msdyn_mostcontacted)

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

- [msdyn_mostcontacted_AsyncOperations](#BKMK_msdyn_mostcontacted_AsyncOperations)
- [msdyn_mostcontacted_BulkDeleteFailures](#BKMK_msdyn_mostcontacted_BulkDeleteFailures)
- [msdyn_mostcontacted_MailboxTrackingFolders](#BKMK_msdyn_mostcontacted_MailboxTrackingFolders)
- [msdyn_mostcontacted_PrincipalObjectAttributeAccesses](#BKMK_msdyn_mostcontacted_PrincipalObjectAttributeAccesses)
- [msdyn_mostcontacted_ProcessSession](#BKMK_msdyn_mostcontacted_ProcessSession)
- [msdyn_mostcontacted_SyncErrors](#BKMK_msdyn_mostcontacted_SyncErrors)

### <a name="BKMK_msdyn_mostcontacted_AsyncOperations"></a> msdyn_mostcontacted_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_mostcontacted_AsyncOperations](asyncoperation.md#BKMK_msdyn_mostcontacted_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mostcontacted_BulkDeleteFailures"></a> msdyn_mostcontacted_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_mostcontacted_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_mostcontacted_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mostcontacted_MailboxTrackingFolders"></a> msdyn_mostcontacted_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_mostcontacted_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_mostcontacted_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mostcontacted_PrincipalObjectAttributeAccesses"></a> msdyn_mostcontacted_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_mostcontacted_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_mostcontacted_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mostcontacted_ProcessSession"></a> msdyn_mostcontacted_ProcessSession

Many-To-One Relationship: [processsession msdyn_mostcontacted_ProcessSession](processsession.md#BKMK_msdyn_mostcontacted_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_mostcontacted_SyncErrors"></a> msdyn_mostcontacted_SyncErrors

Many-To-One Relationship: [syncerror msdyn_mostcontacted_SyncErrors](syncerror.md#BKMK_msdyn_mostcontacted_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_mostcontacted_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

