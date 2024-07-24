---
title: "Virtual Domain (msdynmkt_virtualdomain) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Virtual Domain (msdynmkt_virtualdomain) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Virtual Domain (msdynmkt_virtualdomain) table/entity reference

Virtual domains entity used from representing set of both msdyncrm_setupdomain and msdynmkt_domain entities.

## Messages

The following table lists the messages for the Virtual Domain (msdynmkt_virtualdomain) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_virtualdomains<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_virtualdomains(*msdynmkt_virtualdomainid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_virtualdomains(*msdynmkt_virtualdomainid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_virtualdomains<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_virtualdomains(*msdynmkt_virtualdomainid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_virtualdomains(*msdynmkt_virtualdomainid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Virtual Domain (msdynmkt_virtualdomain) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Virtual Domain (msdynmkt_virtualdomain) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Virtual Domain** |
| **DisplayCollectionName** | **Virtual Domains** |
| **SchemaName** | `msdynmkt_virtualdomain` |
| **CollectionSchemaName** | `msdynmkt_virtualdomains` |
| **EntitySetName** | `msdynmkt_virtualdomains`|
| **LogicalName** | `msdynmkt_virtualdomain` |
| **LogicalCollectionName** | `msdynmkt_virtualdomains` |
| **PrimaryIdAttribute** | `msdynmkt_virtualdomainid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_alignedname](#BKMK_msdynmkt_alignedname)
- [msdynmkt_businessunitowned](#BKMK_msdynmkt_businessunitowned)
- [msdynmkt_createdby](#BKMK_msdynmkt_createdby)
- [msdynmkt_createdon](#BKMK_msdynmkt_createdon)
- [msdynmkt_createdonbehalfby](#BKMK_msdynmkt_createdonbehalfby)
- [msdynmkt_domainalignmentrecordhost](#BKMK_msdynmkt_domainalignmentrecordhost)
- [msdynmkt_domainalignmentrecordtype](#BKMK_msdynmkt_domainalignmentrecordtype)
- [msdynmkt_domainalignmentrecordvalue](#BKMK_msdynmkt_domainalignmentrecordvalue)
- [msdynmkt_domainalignmentvalidationstatus](#BKMK_msdynmkt_domainalignmentvalidationstatus)
- [msdynmkt_emaildnsrecord1status](#BKMK_msdynmkt_emaildnsrecord1status)
- [msdynmkt_emaildnsrecord2status](#BKMK_msdynmkt_emaildnsrecord2status)
- [msdynmkt_emailhost1](#BKMK_msdynmkt_emailhost1)
- [msdynmkt_emailhost2](#BKMK_msdynmkt_emailhost2)
- [msdynmkt_emailkey1](#BKMK_msdynmkt_emailkey1)
- [msdynmkt_emailkey2](#BKMK_msdynmkt_emailkey2)
- [msdynmkt_emailtyperecord1](#BKMK_msdynmkt_emailtyperecord1)
- [msdynmkt_emailtyperecord2](#BKMK_msdynmkt_emailtyperecord2)
- [msdynmkt_generatedomainalignmentkeys](#BKMK_msdynmkt_generatedomainalignmentkeys)
- [msdynmkt_generateemailkeys](#BKMK_msdynmkt_generateemailkeys)
- [msdynmkt_generateformkeys](#BKMK_msdynmkt_generateformkeys)
- [msdynmkt_modifiedby](#BKMK_msdynmkt_modifiedby)
- [msdynmkt_modifiedon](#BKMK_msdynmkt_modifiedon)
- [msdynmkt_modifiedonbehalfby](#BKMK_msdynmkt_modifiedonbehalfby)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_ownershiprecordkey](#BKMK_msdynmkt_ownershiprecordkey)
- [msdynmkt_ownershiprecordtype](#BKMK_msdynmkt_ownershiprecordtype)
- [msdynmkt_ownershipvalidationstatus](#BKMK_msdynmkt_ownershipvalidationstatus)
- [msdynmkt_owningbusinessunit](#BKMK_msdynmkt_owningbusinessunit)
- [msdynmkt_sourceentityId](#BKMK_msdynmkt_sourceentityId)
- [msdynmkt_sourceentitytype](#BKMK_msdynmkt_sourceentitytype)
- [msdynmkt_validationdate](#BKMK_msdynmkt_validationdate)
- [msdynmkt_virtualdomainId](#BKMK_msdynmkt_virtualdomainId)

### <a name="BKMK_msdynmkt_alignedname"></a> msdynmkt_alignedname

|Property|Value|
|---|---|
|Description|**Name of aligned (envelope-from) domain**|
|DisplayName|**Envelope-from domain name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_alignedname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_businessunitowned"></a> msdynmkt_businessunitowned

|Property|Value|
|---|---|
|Description||
|DisplayName|**Business Unit Owned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_businessunitowned`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_virtualdomain_msdynmkt_businessunitowned`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_createdby"></a> msdynmkt_createdby

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_createdon"></a> msdynmkt_createdon

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_createdonbehalfby"></a> msdynmkt_createdonbehalfby

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_domainalignmentrecordhost"></a> msdynmkt_domainalignmentrecordhost

|Property|Value|
|---|---|
|Description|**Host of envelope-from DNS record**|
|DisplayName|**Envelope-from record host**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_domainalignmentrecordhost`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdynmkt_domainalignmentrecordtype"></a> msdynmkt_domainalignmentrecordtype

|Property|Value|
|---|---|
|Description|**Type of DNS record for envelope-from domain**|
|DisplayName|**Envelope-from record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_domainalignmentrecordtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_domainalignmentrecordvalue"></a> msdynmkt_domainalignmentrecordvalue

|Property|Value|
|---|---|
|Description|**Value of envelope-from DNS record**|
|DisplayName|**Enveope-from record value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_domainalignmentrecordvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_domainalignmentvalidationstatus"></a> msdynmkt_domainalignmentvalidationstatus

|Property|Value|
|---|---|
|Description|**Envelope-from domain validation status**|
|DisplayName|**Envelope-from verification status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_domainalignmentvalidationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdynmkt_domainalignmentvalidationstatus Choices/Options

|Value|Label|
|---|---|
|0|**Waiting to confirm**|
|1|**Confirmed**|
|2|**canceled**|
|3|**Not requested**|
|4|**Confirming DNS registration**|
|30|**Keys not found on DNS**|
|31|**Record not found**|
|32|**Internal error**|

### <a name="BKMK_msdynmkt_emaildnsrecord1status"></a> msdynmkt_emaildnsrecord1status

|Property|Value|
|---|---|
|Description|**Email dns record 1 status**|
|DisplayName|**Email Key 1 Verification Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emaildnsrecord1status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdynmkt_emaildnsrecord1status Choices/Options

|Value|Label|
|---|---|
|0|**Waiting to confirm**|
|1|**Confirmed**|
|2|**canceled**|
|3|**Not requested**|
|4|**Confirming DNS registration**|
|30|**Keys not found on DNS**|
|31|**Record not found**|
|32|**Internal error**|

### <a name="BKMK_msdynmkt_emaildnsrecord2status"></a> msdynmkt_emaildnsrecord2status

|Property|Value|
|---|---|
|Description|**Email dns record 2 status**|
|DisplayName|**Email Key 2 Verification Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emaildnsrecord2status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdynmkt_emaildnsrecord2status Choices/Options

|Value|Label|
|---|---|
|0|**Waiting to confirm**|
|1|**Confirmed**|
|2|**canceled**|
|3|**Not requested**|
|4|**Confirming DNS registration**|
|30|**Keys not found on DNS**|
|31|**Record not found**|
|32|**Internal error**|

### <a name="BKMK_msdynmkt_emailhost1"></a> msdynmkt_emailhost1

|Property|Value|
|---|---|
|Description|**The email DNS record 1 host**|
|DisplayName|**Email Record Host 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailhost1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_emailhost2"></a> msdynmkt_emailhost2

|Property|Value|
|---|---|
|Description|**The email DNS record 2 host**|
|DisplayName|**Email Record Host 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailhost2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_emailkey1"></a> msdynmkt_emailkey1

|Property|Value|
|---|---|
|Description|**Value of email key 1**|
|DisplayName|**Email Record Value 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailkey1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_emailkey2"></a> msdynmkt_emailkey2

|Property|Value|
|---|---|
|Description|**Value of email key 2**|
|DisplayName|**Email Record Value 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailkey2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_emailtyperecord1"></a> msdynmkt_emailtyperecord1

|Property|Value|
|---|---|
|Description|**Type of DNS email 1 record**|
|DisplayName|**Email Record Type 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailtyperecord1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_emailtyperecord2"></a> msdynmkt_emailtyperecord2

|Property|Value|
|---|---|
|Description|**Type of DNS email 2 record**|
|DisplayName|**Email Record Type 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emailtyperecord2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_generatedomainalignmentkeys"></a> msdynmkt_generatedomainalignmentkeys

|Property|Value|
|---|---|
|Description|**Enable envelope-from domain and generate envelope-from domain keys**|
|DisplayName|**Enable custom Envelope-from domain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_generatedomainalignmentkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_virtualdomain_msdynmkt_generatedomainalignmentkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_generateemailkeys"></a> msdynmkt_generateemailkeys

|Property|Value|
|---|---|
|Description|**Enable for email sending (generate email keys)**|
|DisplayName|**Email sending enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_generateemailkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_virtualdomain_msdynmkt_generateemailkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_generateformkeys"></a> msdynmkt_generateformkeys

|Property|Value|
|---|---|
|Description|**Enable for form hosting**|
|DisplayName|**Form hosting enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_generateformkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_virtualdomain_msdynmkt_generateformkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_modifiedby"></a> msdynmkt_modifiedby

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_modifiedon"></a> msdynmkt_modifiedon

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_modifiedonbehalfby"></a> msdynmkt_modifiedonbehalfby

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ownershiprecordkey"></a> msdynmkt_ownershiprecordkey

|Property|Value|
|---|---|
|Description|**The key of the DNS record for domain ownership**|
|DisplayName|**Ownership Record Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ownershiprecordkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_ownershiprecordtype"></a> msdynmkt_ownershiprecordtype

|Property|Value|
|---|---|
|Description|**The DNS record type for domain ownership**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ownershiprecordtype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ownershipvalidationstatus"></a> msdynmkt_ownershipvalidationstatus

|Property|Value|
|---|---|
|Description|**Ownership validation status**|
|DisplayName|**Ownership status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ownershipvalidationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdynmkt_ownershipvalidationstatus Choices/Options

|Value|Label|
|---|---|
|0|**Waiting to confirm**|
|1|**Confirmed**|
|2|**canceled**|
|3|**Not requested**|
|4|**Confirming DNS registration**|
|30|**Keys not found on DNS**|
|31|**Record not found**|
|32|**Internal error**|

### <a name="BKMK_msdynmkt_owningbusinessunit"></a> msdynmkt_owningbusinessunit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_msdynmkt_sourceentityId"></a> msdynmkt_sourceentityId

|Property|Value|
|---|---|
|Description|**Id of the source domain entity**|
|DisplayName|**Source Entity Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceentityid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourceentitytype"></a> msdynmkt_sourceentitytype

|Property|Value|
|---|---|
|Description|**Type of the source domain entity**|
|DisplayName|**Source entity type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourceentitytype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_validationdate"></a> msdynmkt_validationdate

|Property|Value|
|---|---|
|Description|**The date when DNS registration was last confirmed**|
|DisplayName|**Confirmed on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_validationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_virtualdomainId"></a> msdynmkt_virtualdomainId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Virtual Domain**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_virtualdomainid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit](#BKMK_msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit)
- [msdynmkt_systemuser_msdynmkt_virtualdomain_createdby](#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdby)
- [msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby](#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby)
- [msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby](#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby)
- [msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby](#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby)

### <a name="BKMK_msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit"></a> msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit

One-To-Many Relationship: [businessunit msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit](businessunit.md#BKMK_msdynmkt_businessunit_msdynmkt_virtualdomain_owningbusinessunit)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`msdynmkt_owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdby"></a> msdynmkt_systemuser_msdynmkt_virtualdomain_createdby

One-To-Many Relationship: [systemuser msdynmkt_systemuser_msdynmkt_virtualdomain_createdby](systemuser.md#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_createdby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby"></a> msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby

One-To-Many Relationship: [systemuser msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby](systemuser.md#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby"></a> msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby

One-To-Many Relationship: [systemuser msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby](systemuser.md#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_modifiedby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby"></a> msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby

One-To-Many Relationship: [systemuser msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby](systemuser.md#BKMK_msdynmkt_systemuser_msdynmkt_virtualdomain_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

