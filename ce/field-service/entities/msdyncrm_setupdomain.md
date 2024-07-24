---
title: "Domain (msdyncrm_setupdomain) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Domain (msdyncrm_setupdomain) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Domain (msdyncrm_setupdomain) table/entity reference



## Messages

The following table lists the messages for the Domain (msdyncrm_setupdomain) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdyncrm_setupdomains<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_setupdomains(*msdyncrm_setupdomainid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_setupdomains(*msdyncrm_setupdomainid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_setupdomains<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_setupdomains(*msdyncrm_setupdomainid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_setupdomains(*msdyncrm_setupdomainid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_setupdomains(*msdyncrm_setupdomainid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Domain (msdyncrm_setupdomain) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Domain (msdyncrm_setupdomain) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Domain** |
| **DisplayCollectionName** | **Domains** |
| **SchemaName** | `msdyncrm_setupdomain` |
| **CollectionSchemaName** | `msdyncrm_setupdomains` |
| **EntitySetName** | `msdyncrm_setupdomains`|
| **LogicalName** | `msdyncrm_setupdomain` |
| **LogicalCollectionName** | `msdyncrm_setupdomains` |
| **PrimaryIdAttribute** | `msdyncrm_setupdomainid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_alignedname](#BKMK_msdyncrm_alignedname)
- [msdyncrm_domainalignmentrequired](#BKMK_msdyncrm_domainalignmentrequired)
- [msdyncrm_domainalignmentvalidationstatus](#BKMK_msdyncrm_domainalignmentvalidationstatus)
- [msdyncrm_domalignrechost](#BKMK_msdyncrm_domalignrechost)
- [msdyncrm_domalignrectype](#BKMK_msdyncrm_domalignrectype)
- [msdyncrm_domalignrecvalue](#BKMK_msdyncrm_domalignrecvalue)
- [msdyncrm_emailhost1](#BKMK_msdyncrm_emailhost1)
- [msdyncrm_emailhost2](#BKMK_msdyncrm_emailhost2)
- [msdyncrm_emailkey1](#BKMK_msdyncrm_emailkey1)
- [msdyncrm_emailkey2](#BKMK_msdyncrm_emailkey2)
- [msdyncrm_emailkeysvalidationstatus](#BKMK_msdyncrm_emailkeysvalidationstatus)
- [msdyncrm_emailtyperecord1](#BKMK_msdyncrm_emailtyperecord1)
- [msdyncrm_emailtyperecord2](#BKMK_msdyncrm_emailtyperecord2)
- [msdyncrm_generatedomainalignmentkeys](#BKMK_msdyncrm_generatedomainalignmentkeys)
- [msdyncrm_generateemailkeys](#BKMK_msdyncrm_generateemailkeys)
- [msdyncrm_generateformkeys](#BKMK_msdyncrm_generateformkeys)
- [msdyncrm_instructions](#BKMK_msdyncrm_instructions)
- [msdyncrm_ipinstructions](#BKMK_msdyncrm_ipinstructions)
- [msdyncrm_ipslist](#BKMK_msdyncrm_ipslist)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_ownershipvalidationstatus](#BKMK_msdyncrm_ownershipvalidationstatus)
- [msdyncrm_setupdomainId](#BKMK_msdyncrm_setupdomainId)
- [msdyncrm_txthostinstructions](#BKMK_msdyncrm_txthostinstructions)
- [msdyncrm_txtkey](#BKMK_msdyncrm_txtkey)
- [msdyncrm_txttyperecord](#BKMK_msdyncrm_txttyperecord)
- [msdyncrm_validationdate](#BKMK_msdyncrm_validationdate)
- [msdynmkt_emaildnsrecord1status](#BKMK_msdynmkt_emaildnsrecord1status)
- [msdynmkt_emaildnsrecord2status](#BKMK_msdynmkt_emaildnsrecord2status)
- [msdynmkt_StepWizardProgress](#BKMK_msdynmkt_StepWizardProgress)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_alignedname"></a> msdyncrm_alignedname

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Envelope-from domain name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_alignedname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_domainalignmentrequired"></a> msdyncrm_domainalignmentrequired

|Property|Value|
|---|---|
|Description|**Envelope-from domain required flag**|
|DisplayName|**Envelope-from domain required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_domainalignmentrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_setupdomain_msdyncrm_domainalignmentrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_domainalignmentvalidationstatus"></a> msdyncrm_domainalignmentvalidationstatus

|Property|Value|
|---|---|
|Description|**Envelope-from domain validation status**|
|DisplayName|**Envelope-from status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_domainalignmentvalidationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdyncrm_domainalignmentvalidationstatus Choices/Options

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

### <a name="BKMK_msdyncrm_domalignrechost"></a> msdyncrm_domalignrechost

|Property|Value|
|---|---|
|Description|**Instructions for CNAME Host field**|
|DisplayName|**Host**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_domalignrechost`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_domalignrectype"></a> msdyncrm_domalignrectype

|Property|Value|
|---|---|
|Description|**the dns record type for Envelope-from domain**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_domalignrectype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_domalignrecvalue"></a> msdyncrm_domalignrecvalue

|Property|Value|
|---|---|
|Description|**the value of the dns record for Envelope-from domain**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_domalignrecvalue`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_emailhost1"></a> msdyncrm_emailhost1

|Property|Value|
|---|---|
|Description|**The email DNS record 1 host**|
|DisplayName|**Host**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailhost1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_emailhost2"></a> msdyncrm_emailhost2

|Property|Value|
|---|---|
|Description|**The email DNS record 2 host**|
|DisplayName|**Host**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailhost2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_emailkey1"></a> msdyncrm_emailkey1

|Property|Value|
|---|---|
|Description|**Value of email key 1**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailkey1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_emailkey2"></a> msdyncrm_emailkey2

|Property|Value|
|---|---|
|Description|**Value of email key 1**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailkey2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_emailkeysvalidationstatus"></a> msdyncrm_emailkeysvalidationstatus

|Property|Value|
|---|---|
|Description|**Email keys validation status**|
|DisplayName|**Email status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailkeysvalidationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdyncrm_emailkeysvalidationstatus Choices/Options

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

### <a name="BKMK_msdyncrm_emailtyperecord1"></a> msdyncrm_emailtyperecord1

|Property|Value|
|---|---|
|Description|**The email DNS record 1 type**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailtyperecord1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_emailtyperecord2"></a> msdyncrm_emailtyperecord2

|Property|Value|
|---|---|
|Description|**The email DNS record 2 type**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailtyperecord2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_generatedomainalignmentkeys"></a> msdyncrm_generatedomainalignmentkeys

|Property|Value|
|---|---|
|Description|**Enable custom Envelope-from domain - generate Envelope-from domain keys**|
|DisplayName|**Enable custom Envelope-from domain**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_generatedomainalignmentkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_setupdomain_msdyncrm_generatedomainalignmentkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_generateemailkeys"></a> msdyncrm_generateemailkeys

|Property|Value|
|---|---|
|Description|**Enable for email sending (generate email keys)**|
|DisplayName|**Email sending enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_generateemailkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_setupdomain_msdyncrm_generateemailkeys`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_generateformkeys"></a> msdyncrm_generateformkeys

|Property|Value|
|---|---|
|Description|**Enable for form hosting**|
|DisplayName|**Form hosting enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_generateformkeys`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_setupdomain_msdyncrm_generateformkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyncrm_instructions"></a> msdyncrm_instructions

|Property|Value|
|---|---|
|Description|**How-to for system admin**|
|DisplayName|**Instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_instructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyncrm_ipinstructions"></a> msdyncrm_ipinstructions

|Property|Value|
|---|---|
|Description|**How to for system admin**|
|DisplayName|**Ip whitelisting instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_ipinstructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyncrm_ipslist"></a> msdyncrm_ipslist

|Property|Value|
|---|---|
|Description|**How to for system admin.**|
|DisplayName|**List of Ips that should be whitelisted.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_ipslist`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Domain name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_ownershipvalidationstatus"></a> msdyncrm_ownershipvalidationstatus

|Property|Value|
|---|---|
|Description|**Ownership validation status**|
|DisplayName|**Ownership status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_ownershipvalidationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_setupdomain_status`|

#### msdyncrm_ownershipvalidationstatus Choices/Options

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

### <a name="BKMK_msdyncrm_setupdomainId"></a> msdyncrm_setupdomainId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**Setup domain**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_setupdomainid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_txthostinstructions"></a> msdyncrm_txthostinstructions

|Property|Value|
|---|---|
|Description|**Host**|
|DisplayName|**Host**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_txthostinstructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyncrm_txtkey"></a> msdyncrm_txtkey

|Property|Value|
|---|---|
|Description|**The key of the DNS record for domain ownership**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_txtkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdyncrm_txttyperecord"></a> msdyncrm_txttyperecord

|Property|Value|
|---|---|
|Description|**The DNS record type for domain ownership**|
|DisplayName|**Record type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_txttyperecord`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_validationdate"></a> msdyncrm_validationdate

|Property|Value|
|---|---|
|Description|**The date when DNS registration was last confirmed**|
|DisplayName|**Confirmed on**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_validationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_emaildnsrecord1status"></a> msdynmkt_emaildnsrecord1status

|Property|Value|
|---|---|
|Description|**Email dns record 1 status**|
|DisplayName|**emaildnsrecord1status**|
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
|DisplayName|**emaildnsrecord2status**|
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

### <a name="BKMK_msdynmkt_StepWizardProgress"></a> msdynmkt_StepWizardProgress

|Property|Value|
|---|---|
|Description|**Internal field for tracking progress of entity configuration via wizard**|
|DisplayName|**Step Wizard Progress**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_stepwizardprogress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
|DisplayName|**Record created on**|
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
|Description|**Status of the domain**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_setupdomain_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the domain**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_setupdomain_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time zone rule version number**|
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
|Description|**Time zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time zone code**|
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
|Description|**Unique identifier of the user who created the record**|
|DisplayName|**Created by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created**|
|DisplayName|**Created on**|
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
|Description|**Unique identifier of the delegate user who created the record**|
|DisplayName|**Created by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record**|
|DisplayName|**Modified by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified**|
|DisplayName|**Modified on**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
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

- [lk_msdyncrm_setupdomain_createdby](#BKMK_lk_msdyncrm_setupdomain_createdby)
- [lk_msdyncrm_setupdomain_createdonbehalfby](#BKMK_lk_msdyncrm_setupdomain_createdonbehalfby)
- [lk_msdyncrm_setupdomain_modifiedby](#BKMK_lk_msdyncrm_setupdomain_modifiedby)
- [lk_msdyncrm_setupdomain_modifiedonbehalfby](#BKMK_lk_msdyncrm_setupdomain_modifiedonbehalfby)
- [organization_msdyncrm_setupdomain](#BKMK_organization_msdyncrm_setupdomain)

### <a name="BKMK_lk_msdyncrm_setupdomain_createdby"></a> lk_msdyncrm_setupdomain_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_setupdomain_createdby](systemuser.md#BKMK_lk_msdyncrm_setupdomain_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_setupdomain_createdonbehalfby"></a> lk_msdyncrm_setupdomain_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_setupdomain_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_setupdomain_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_setupdomain_modifiedby"></a> lk_msdyncrm_setupdomain_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_setupdomain_modifiedby](systemuser.md#BKMK_lk_msdyncrm_setupdomain_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_setupdomain_modifiedonbehalfby"></a> lk_msdyncrm_setupdomain_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_setupdomain_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_setupdomain_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyncrm_setupdomain"></a> organization_msdyncrm_setupdomain

One-To-Many Relationship: [organization organization_msdyncrm_setupdomain](organization.md#BKMK_organization_msdyncrm_setupdomain)

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

- [msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain](#BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain)
- [msdyncrm_setupdomain_AsyncOperations](#BKMK_msdyncrm_setupdomain_AsyncOperations)
- [msdyncrm_setupdomain_BulkDeleteFailures](#BKMK_msdyncrm_setupdomain_BulkDeleteFailures)
- [msdyncrm_setupdomain_MailboxTrackingFolders](#BKMK_msdyncrm_setupdomain_MailboxTrackingFolders)
- [msdyncrm_setupdomain_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_setupdomain_PrincipalObjectAttributeAccesses)
- [msdyncrm_setupdomain_ProcessSession](#BKMK_msdyncrm_setupdomain_ProcessSession)
- [msdyncrm_setupdomain_SyncErrors](#BKMK_msdyncrm_setupdomain_SyncErrors)

### <a name="BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain"></a> msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain

Many-To-One Relationship: [msdyncrm_defaultmarketingsetting msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain](msdyncrm_defaultmarketingsetting.md#BKMK_msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_defaultmarketingsetting`|
|ReferencingAttribute|`msdyncrm_defaultsetupdomain`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_setupdomain_msdyncrm_defaultmarketingsetting_DefaultSetupDomain`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_AsyncOperations"></a> msdyncrm_setupdomain_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_setupdomain_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_setupdomain_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_BulkDeleteFailures"></a> msdyncrm_setupdomain_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_setupdomain_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_setupdomain_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_MailboxTrackingFolders"></a> msdyncrm_setupdomain_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_setupdomain_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_setupdomain_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_PrincipalObjectAttributeAccesses"></a> msdyncrm_setupdomain_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_setupdomain_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_setupdomain_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_ProcessSession"></a> msdyncrm_setupdomain_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_setupdomain_ProcessSession](processsession.md#BKMK_msdyncrm_setupdomain_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_setupdomain_SyncErrors"></a> msdyncrm_setupdomain_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_setupdomain_SyncErrors](syncerror.md#BKMK_msdyncrm_setupdomain_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_setupdomain_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

