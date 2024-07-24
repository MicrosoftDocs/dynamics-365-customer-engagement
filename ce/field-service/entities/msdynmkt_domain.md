---
title: "Domain (msdynmkt_domain) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Domain (msdynmkt_domain) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Domain (msdynmkt_domain) table/entity reference

Business unit aware domain entity

## Messages

The following table lists the messages for the Domain (msdynmkt_domain) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_domains(*msdynmkt_domainid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_domains<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_domains(*msdynmkt_domainid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_domains(*msdynmkt_domainid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_domains<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_domains(*msdynmkt_domainid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_domains(*msdynmkt_domainid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_domains(*msdynmkt_domainid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Domain (msdynmkt_domain) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Domain (msdynmkt_domain) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Domain** |
| **DisplayCollectionName** | **Domains** |
| **SchemaName** | `msdynmkt_domain` |
| **CollectionSchemaName** | `msdynmkt_domains` |
| **EntitySetName** | `msdynmkt_domains`|
| **LogicalName** | `msdynmkt_domain` |
| **LogicalCollectionName** | `msdynmkt_domains` |
| **PrimaryIdAttribute** | `msdynmkt_domainid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_alignedname](#BKMK_msdynmkt_alignedname)
- [msdynmkt_businessunitowned](#BKMK_msdynmkt_businessunitowned)
- [msdynmkt_domainalignmentrecordhost](#BKMK_msdynmkt_domainalignmentrecordhost)
- [msdynmkt_domainalignmentrecordtype](#BKMK_msdynmkt_domainalignmentrecordtype)
- [msdynmkt_domainalignmentrecordvalue](#BKMK_msdynmkt_domainalignmentrecordvalue)
- [msdynmkt_domainalignmentvalidationstatus](#BKMK_msdynmkt_domainalignmentvalidationstatus)
- [msdynmkt_domainId](#BKMK_msdynmkt_domainId)
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
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_ownershiprecordkey](#BKMK_msdynmkt_ownershiprecordkey)
- [msdynmkt_ownershiprecordtype](#BKMK_msdynmkt_ownershiprecordtype)
- [msdynmkt_ownershipvalidationstatus](#BKMK_msdynmkt_ownershipvalidationstatus)
- [msdynmkt_stepwizardprogress](#BKMK_msdynmkt_stepwizardprogress)
- [msdynmkt_validationdate](#BKMK_msdynmkt_validationdate)
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
|GlobalChoiceName|`msdynmkt_domain_msdynmkt_businessunitowned`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdynmkt_domainId"></a> msdynmkt_domainId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Domain**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_domainid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|GlobalChoiceName|`msdynmkt_domain_msdynmkt_generatedomainalignmentkeys`|
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
|GlobalChoiceName|`msdynmkt_domain_msdynmkt_generateemailkeys`|
|DefaultValue|True|
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
|GlobalChoiceName|`msdynmkt_domain_msdynmkt_generateformkeys`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Domain Name**|
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

### <a name="BKMK_msdynmkt_stepwizardprogress"></a> msdynmkt_stepwizardprogress

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
|Description|**Status of the Domain**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_domain_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Domain**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_domain_statuscode`|

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

- [business_unit_msdynmkt_domain](#BKMK_business_unit_msdynmkt_domain)
- [lk_msdynmkt_domain_createdby](#BKMK_lk_msdynmkt_domain_createdby)
- [lk_msdynmkt_domain_createdonbehalfby](#BKMK_lk_msdynmkt_domain_createdonbehalfby)
- [lk_msdynmkt_domain_modifiedby](#BKMK_lk_msdynmkt_domain_modifiedby)
- [lk_msdynmkt_domain_modifiedonbehalfby](#BKMK_lk_msdynmkt_domain_modifiedonbehalfby)
- [owner_msdynmkt_domain](#BKMK_owner_msdynmkt_domain)
- [team_msdynmkt_domain](#BKMK_team_msdynmkt_domain)
- [user_msdynmkt_domain](#BKMK_user_msdynmkt_domain)

### <a name="BKMK_business_unit_msdynmkt_domain"></a> business_unit_msdynmkt_domain

One-To-Many Relationship: [businessunit business_unit_msdynmkt_domain](businessunit.md#BKMK_business_unit_msdynmkt_domain)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_domain_createdby"></a> lk_msdynmkt_domain_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_domain_createdby](systemuser.md#BKMK_lk_msdynmkt_domain_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_domain_createdonbehalfby"></a> lk_msdynmkt_domain_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_domain_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_domain_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_domain_modifiedby"></a> lk_msdynmkt_domain_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_domain_modifiedby](systemuser.md#BKMK_lk_msdynmkt_domain_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_domain_modifiedonbehalfby"></a> lk_msdynmkt_domain_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_domain_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_domain_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_domain"></a> owner_msdynmkt_domain

One-To-Many Relationship: [owner owner_msdynmkt_domain](owner.md#BKMK_owner_msdynmkt_domain)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_domain"></a> team_msdynmkt_domain

One-To-Many Relationship: [team team_msdynmkt_domain](team.md#BKMK_team_msdynmkt_domain)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_domain"></a> user_msdynmkt_domain

One-To-Many Relationship: [systemuser user_msdynmkt_domain](systemuser.md#BKMK_user_msdynmkt_domain)

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

- [msdynmkt_domain_AsyncOperations](#BKMK_msdynmkt_domain_AsyncOperations)
- [msdynmkt_domain_BulkDeleteFailures](#BKMK_msdynmkt_domain_BulkDeleteFailures)
- [msdynmkt_domain_MailboxTrackingFolders](#BKMK_msdynmkt_domain_MailboxTrackingFolders)
- [msdynmkt_domain_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_domain_PrincipalObjectAttributeAccesses)
- [msdynmkt_domain_ProcessSession](#BKMK_msdynmkt_domain_ProcessSession)
- [msdynmkt_domain_SyncErrors](#BKMK_msdynmkt_domain_SyncErrors)

### <a name="BKMK_msdynmkt_domain_AsyncOperations"></a> msdynmkt_domain_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_domain_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_domain_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_domain_BulkDeleteFailures"></a> msdynmkt_domain_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_domain_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_domain_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_domain_MailboxTrackingFolders"></a> msdynmkt_domain_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_domain_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_domain_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_domain_PrincipalObjectAttributeAccesses"></a> msdynmkt_domain_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_domain_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_domain_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_domain_ProcessSession"></a> msdynmkt_domain_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_domain_ProcessSession](processsession.md#BKMK_msdynmkt_domain_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_domain_SyncErrors"></a> msdynmkt_domain_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_domain_SyncErrors](syncerror.md#BKMK_msdynmkt_domain_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_domain_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

