---
title: "Linked Entity Attribute Validity (msdyn_linkedentityattributevalidity) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Linked Entity Attribute Validity (msdyn_linkedentityattributevalidity) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Linked Entity Attribute Validity (msdyn_linkedentityattributevalidity) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Linked Entity Attribute Validity (msdyn_linkedentityattributevalidity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_linkedentityattributevalidiations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_linkedentityattributevalidiations(*msdyn_linkedentityattributevalidityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_linkedentityattributevalidiations(*msdyn_linkedentityattributevalidityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_linkedentityattributevalidiations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_linkedentityattributevalidiations(*msdyn_linkedentityattributevalidityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_linkedentityattributevalidiations(*msdyn_linkedentityattributevalidityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_linkedentityattributevalidiations(*msdyn_linkedentityattributevalidityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Linked Entity Attribute Validity (msdyn_linkedentityattributevalidity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Linked Entity Attribute Validity** |
| **DisplayCollectionName** | **Linked Entity Attribute Validations** |
| **SchemaName** | `msdyn_linkedentityattributevalidity` |
| **CollectionSchemaName** | `msdyn_linkedentityattributevalidities` |
| **EntitySetName** | `msdyn_linkedentityattributevalidiations`|
| **LogicalName** | `msdyn_linkedentityattributevalidity` |
| **LogicalCollectionName** | `msdyn_linkedentityattributevalidities` |
| **PrimaryIdAttribute** | `msdyn_linkedentityattributevalidityid` |
| **PrimaryNameAttribute** |`msdyn_attributename` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_attributename](#BKMK_msdyn_attributename)
- [msdyn_attributetype](#BKMK_msdyn_attributetype)
- [msdyn_datahash](#BKMK_msdyn_datahash)
- [msdyn_datavalidity](#BKMK_msdyn_datavalidity)
- [msdyn_errorcode](#BKMK_msdyn_errorcode)
- [msdyn_linkedentityattributevalidityId](#BKMK_msdyn_linkedentityattributevalidityId)
- [msdyn_linkeditemlookup](#BKMK_msdyn_linkeditemlookup)
- [msdyn_linkeditemlookupIdType](#BKMK_msdyn_linkeditemlookupIdType)
- [msdyn_validationresponse](#BKMK_msdyn_validationresponse)
- [msdyn_validationstatus](#BKMK_msdyn_validationstatus)
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

### <a name="BKMK_msdyn_attributename"></a> msdyn_attributename

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Attribute name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributename`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_attributetype"></a> msdyn_attributetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attribute type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_msdyn_attributetype`|

#### msdyn_attributetype Choices/Options

|Value|Label|
|---|---|
|0|**Email**|
|1|**Phone**|

### <a name="BKMK_msdyn_datahash"></a> msdyn_datahash

|Property|Value|
|---|---|
|Description|**Hash value for the record attribute that was used in the validation API.**|
|DisplayName|**Data hash**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datahash`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_datavalidity"></a> msdyn_datavalidity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Data validity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datavalidity`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_msdyn_datavalidity`|

#### msdyn_datavalidity Choices/Options

|Value|Label|
|---|---|
|0|**Invalid**|
|1|**Valid**|
|2|**Unknown**|

### <a name="BKMK_msdyn_errorcode"></a> msdyn_errorcode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errorcode`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_msdyn_errorcode`|

#### msdyn_errorcode Choices/Options

|Value|Label|
|---|---|
|0|**Unknown**|
|200|**Email Exists**|
|210|**Domain exists**|
|220|**Domain Exists But Expires Soon**|
|230|**None**|
|240|**Root Domain exists**|
|250|**Domain Exists But Expired Recently**|
|300|**Validation In Progress**|
|320|**Domain Expired**|
|340|**Domain Invalid**|
|350|**Domain Unknown**|
|360|**Domain Exists But Disposable**|
|370|**Email Exists But Hub**|
|380|**Address Malformed**|
|390|**Email Does Not Exist**|
|400|**Domain Exists But Spam**|
|410|**Fake Alias**|
|420|**Email Exists But Spam**|

### <a name="BKMK_msdyn_linkedentityattributevalidityId"></a> msdyn_linkedentityattributevalidityId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Linked Entity Attribute Validity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_linkedentityattributevalidityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_linkeditemlookup"></a> msdyn_linkeditemlookup

|Property|Value|
|---|---|
|Description|**Linked Entity Polymorphic Lookup Attribute**|
|DisplayName|**Linked Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkeditemlookup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact, lead|

### <a name="BKMK_msdyn_linkeditemlookupIdType"></a> msdyn_linkeditemlookupIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_linkeditemlookupidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_validationresponse"></a> msdyn_validationresponse

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation response**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validationresponse`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_validationstatus"></a> msdyn_validationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Validation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validationstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_msdyn_validationstatus`|

#### msdyn_validationstatus Choices/Options

|Value|Label|
|---|---|
|0|**New**|
|1|**Success**|
|2|**Failed**|
|3|**In Progress**|

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
|Description|**Status of the Linked Entity Attribute Validity**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Linked Entity Attribute Validity**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_linkedentityattributevalidity_statuscode`|

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

- [lk_msdyn_linkedentityattributevalidity_createdby](#BKMK_lk_msdyn_linkedentityattributevalidity_createdby)
- [lk_msdyn_linkedentityattributevalidity_createdonbehalfby](#BKMK_lk_msdyn_linkedentityattributevalidity_createdonbehalfby)
- [lk_msdyn_linkedentityattributevalidity_modifiedby](#BKMK_lk_msdyn_linkedentityattributevalidity_modifiedby)
- [lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby](#BKMK_lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby)
- [msdyn_linkeditemvalidity_polymorphic_contactid](#BKMK_msdyn_linkeditemvalidity_polymorphic_contactid)
- [msdyn_linkeditemvalidity_polymorphic_leadid](#BKMK_msdyn_linkeditemvalidity_polymorphic_leadid)
- [organization_msdyn_linkedentityattributevalidity](#BKMK_organization_msdyn_linkedentityattributevalidity)

### <a name="BKMK_lk_msdyn_linkedentityattributevalidity_createdby"></a> lk_msdyn_linkedentityattributevalidity_createdby

One-To-Many Relationship: [systemuser lk_msdyn_linkedentityattributevalidity_createdby](systemuser.md#BKMK_lk_msdyn_linkedentityattributevalidity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_linkedentityattributevalidity_createdonbehalfby"></a> lk_msdyn_linkedentityattributevalidity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_linkedentityattributevalidity_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_linkedentityattributevalidity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_linkedentityattributevalidity_modifiedby"></a> lk_msdyn_linkedentityattributevalidity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_linkedentityattributevalidity_modifiedby](systemuser.md#BKMK_lk_msdyn_linkedentityattributevalidity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby"></a> lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_linkedentityattributevalidity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_linkeditemvalidity_polymorphic_contactid"></a> msdyn_linkeditemvalidity_polymorphic_contactid

One-To-Many Relationship: [contact msdyn_linkeditemvalidity_polymorphic_contactid](contact.md#BKMK_msdyn_linkeditemvalidity_polymorphic_contactid)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_linkeditemlookup`|
|ReferencingEntityNavigationPropertyName|`msdyn_linkeditemlookup_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_linkeditemvalidity_polymorphic_leadid"></a> msdyn_linkeditemvalidity_polymorphic_leadid

One-To-Many Relationship: [lead msdyn_linkeditemvalidity_polymorphic_leadid](lead.md#BKMK_msdyn_linkeditemvalidity_polymorphic_leadid)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_linkeditemlookup`|
|ReferencingEntityNavigationPropertyName|`msdyn_linkeditemlookup_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_linkedentityattributevalidity"></a> organization_msdyn_linkedentityattributevalidity

One-To-Many Relationship: [organization organization_msdyn_linkedentityattributevalidity](organization.md#BKMK_organization_msdyn_linkedentityattributevalidity)

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

- [msdyn_linkedentityattributevalidity_AsyncOperations](#BKMK_msdyn_linkedentityattributevalidity_AsyncOperations)
- [msdyn_linkedentityattributevalidity_BulkDeleteFailures](#BKMK_msdyn_linkedentityattributevalidity_BulkDeleteFailures)
- [msdyn_linkedentityattributevalidity_MailboxTrackingFolders](#BKMK_msdyn_linkedentityattributevalidity_MailboxTrackingFolders)
- [msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses](#BKMK_msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses)
- [msdyn_linkedentityattributevalidity_ProcessSession](#BKMK_msdyn_linkedentityattributevalidity_ProcessSession)
- [msdyn_linkedentityattributevalidity_SyncErrors](#BKMK_msdyn_linkedentityattributevalidity_SyncErrors)

### <a name="BKMK_msdyn_linkedentityattributevalidity_AsyncOperations"></a> msdyn_linkedentityattributevalidity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_linkedentityattributevalidity_AsyncOperations](asyncoperation.md#BKMK_msdyn_linkedentityattributevalidity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkedentityattributevalidity_BulkDeleteFailures"></a> msdyn_linkedentityattributevalidity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_linkedentityattributevalidity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_linkedentityattributevalidity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkedentityattributevalidity_MailboxTrackingFolders"></a> msdyn_linkedentityattributevalidity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_linkedentityattributevalidity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_linkedentityattributevalidity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses"></a> msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkedentityattributevalidity_ProcessSession"></a> msdyn_linkedentityattributevalidity_ProcessSession

Many-To-One Relationship: [processsession msdyn_linkedentityattributevalidity_ProcessSession](processsession.md#BKMK_msdyn_linkedentityattributevalidity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_linkedentityattributevalidity_SyncErrors"></a> msdyn_linkedentityattributevalidity_SyncErrors

Many-To-One Relationship: [syncerror msdyn_linkedentityattributevalidity_SyncErrors](syncerror.md#BKMK_msdyn_linkedentityattributevalidity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_linkedentityattributevalidity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

