---
title: "Suggested Contact (msdyn_suggestedcontact) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Suggested Contact (msdyn_suggestedcontact) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Suggested Contact (msdyn_suggestedcontact) table/entity reference (Microsoft Dynamics 365)

Contact suggestions

## Messages

The following table lists the messages for the Suggested Contact (msdyn_suggestedcontact) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_suggestedcontacts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_suggestedcontacts(*msdyn_suggestedcontactid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_suggestedcontacts(*msdyn_suggestedcontactid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_suggestedcontacts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Update`<br />Event: True |`PATCH` /msdyn_suggestedcontacts(*msdyn_suggestedcontactid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_suggestedcontacts(*msdyn_suggestedcontactid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Suggested Contact (msdyn_suggestedcontact) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Suggested Contact** |
| **DisplayCollectionName** | **Contact Suggestions** |
| **SchemaName** | `msdyn_suggestedcontact` |
| **CollectionSchemaName** | `msdyn_suggestedcontacts` |
| **EntitySetName** | `msdyn_suggestedcontacts`|
| **LogicalName** | `msdyn_suggestedcontact` |
| **LogicalCollectionName** | `msdyn_suggestedcontacts` |
| **PrimaryIdAttribute** | `msdyn_suggestedcontactid` |
| **PrimaryNameAttribute** |`msdyn_fullname` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdyn_accountid](#BKMK_msdyn_accountid)
- [msdyn_accountidname](#BKMK_msdyn_accountidname)
- [msdyn_accountname](#BKMK_msdyn_accountname)
- [msdyn_addresscity](#BKMK_msdyn_addresscity)
- [msdyn_addressline1](#BKMK_msdyn_addressline1)
- [msdyn_addressline2](#BKMK_msdyn_addressline2)
- [msdyn_addresspostalcode](#BKMK_msdyn_addresspostalcode)
- [msdyn_companyname](#BKMK_msdyn_companyname)
- [msdyn_createdon](#BKMK_msdyn_createdon)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_email](#BKMK_msdyn_email)
- [msdyn_firstname](#BKMK_msdyn_firstname)
- [msdyn_fullname](#BKMK_msdyn_fullname)
- [msdyn_jobtitle](#BKMK_msdyn_jobtitle)
- [msdyn_lastname](#BKMK_msdyn_lastname)
- [msdyn_mobilephone](#BKMK_msdyn_mobilephone)
- [msdyn_preferredcontactmethodcode](#BKMK_msdyn_preferredcontactmethodcode)
- [msdyn_suggestedcontactId](#BKMK_msdyn_suggestedcontactId)
- [msdyn_telephone](#BKMK_msdyn_telephone)

### <a name="BKMK_msdyn_accountid"></a> msdyn_accountid

|Property|Value|
|---|---|
|Description|**Account Name**|
|DisplayName|**Account Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets||

### <a name="BKMK_msdyn_accountidname"></a> msdyn_accountidname

|Property|Value|
|---|---|
|Description|**Account Name**|
|DisplayName|**Account Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountidname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_accountname"></a> msdyn_accountname

|Property|Value|
|---|---|
|Description|**Account Name**|
|DisplayName|**Account Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_addresscity"></a> msdyn_addresscity

|Property|Value|
|---|---|
|Description|**Address City**|
|DisplayName|**Address City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addresscity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_addressline1"></a> msdyn_addressline1

|Property|Value|
|---|---|
|Description|**AddressLine1**|
|DisplayName|**AddressLine1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addressline1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_addressline2"></a> msdyn_addressline2

|Property|Value|
|---|---|
|Description|**AddressLine2**|
|DisplayName|**AddressLine2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addressline2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_addresspostalcode"></a> msdyn_addresspostalcode

|Property|Value|
|---|---|
|Description|**Address Postal Code**|
|DisplayName|**Address Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addresspostalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_companyname"></a> msdyn_companyname

|Property|Value|
|---|---|
|Description|**Company Name**|
|DisplayName|**Company Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_companyname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_createdon"></a> msdyn_createdon

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Description**|
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
|MaxLength|100|

### <a name="BKMK_msdyn_email"></a> msdyn_email

|Property|Value|
|---|---|
|Description|**Email**|
|DisplayName|**Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_email`|
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
|Description|**first name**|
|DisplayName|**First Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_fullname"></a> msdyn_fullname

|Property|Value|
|---|---|
|Description|**Full Name**|
|DisplayName|**Full Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fullname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_jobtitle"></a> msdyn_jobtitle

|Property|Value|
|---|---|
|Description|**Job Title**|
|DisplayName|**Job Title**|
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
|Description|**Last Name**|
|DisplayName|**Last Name**|
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

### <a name="BKMK_msdyn_mobilephone"></a> msdyn_mobilephone

|Property|Value|
|---|---|
|Description|**Mobile Phone**|
|DisplayName|**Mobile Phone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mobilephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_preferredcontactmethodcode"></a> msdyn_preferredcontactmethodcode

|Property|Value|
|---|---|
|Description|**Preferred Contact Method Code**|
|DisplayName|**Preferred Contact Method Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredcontactmethodcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_suggestedcontactId"></a> msdyn_suggestedcontactId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Suggested Contact**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestedcontactid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_telephone"></a> msdyn_telephone

|Property|Value|
|---|---|
|Description|**Telephone**|
|DisplayName|**Telephone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_telephone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|




### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

