---
title: "Mobile app configuration (msdynmkt_mobileapp) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Mobile app configuration (msdynmkt_mobileapp) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Mobile app configuration (msdynmkt_mobileapp) table/entity reference



## Messages

The following table lists the messages for the Mobile app configuration (msdynmkt_mobileapp) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_mobileapps<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_mobileapps<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_mobileapps(*msdynmkt_mobileappid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Mobile app configuration (msdynmkt_mobileapp) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Mobile app configuration (msdynmkt_mobileapp) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Mobile app configuration** |
| **DisplayCollectionName** | **Mobile app configurations** |
| **SchemaName** | `msdynmkt_mobileapp` |
| **CollectionSchemaName** | `msdynmkt_mobileapps` |
| **EntitySetName** | `msdynmkt_mobileapps`|
| **LogicalName** | `msdynmkt_mobileapp` |
| **LogicalCollectionName** | `msdynmkt_mobileapps` |
| **PrimaryIdAttribute** | `msdynmkt_mobileappid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_activefcm](#BKMK_msdynmkt_activefcm)
- [msdynmkt_activeios](#BKMK_msdynmkt_activeios)
- [msdynmkt_apikey](#BKMK_msdynmkt_apikey)
- [msdynmkt_apitoken](#BKMK_msdynmkt_apitoken)
- [msdynmkt_applicationmode](#BKMK_msdynmkt_applicationmode)
- [msdynmkt_authenticationmode](#BKMK_msdynmkt_authenticationmode)
- [msdynmkt_bundleId](#BKMK_msdynmkt_bundleId)
- [msdynmkt_certificate1](#BKMK_msdynmkt_certificate1)
- [msdynmkt_certificate2](#BKMK_msdynmkt_certificate2)
- [msdynmkt_certificate3](#BKMK_msdynmkt_certificate3)
- [msdynmkt_certificate4](#BKMK_msdynmkt_certificate4)
- [msdynmkt_certificate5](#BKMK_msdynmkt_certificate5)
- [msdynmkt_certificateName](#BKMK_msdynmkt_certificateName)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_keyid](#BKMK_msdynmkt_keyid)
- [msdynmkt_mobileappId](#BKMK_msdynmkt_mobileappId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_password](#BKMK_msdynmkt_password)
- [msdynmkt_signingkey](#BKMK_msdynmkt_signingkey)
- [msdynmkt_teamId](#BKMK_msdynmkt_teamId)
- [msdynmkt_uionly_value_endpoint](#BKMK_msdynmkt_uionly_value_endpoint)
- [msdynmkt_uionly_value_organizationid](#BKMK_msdynmkt_uionly_value_organizationid)
- [msdynmkt_validationfcm](#BKMK_msdynmkt_validationfcm)
- [msdynmkt_validationios](#BKMK_msdynmkt_validationios)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_activefcm"></a> msdynmkt_activefcm

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active FCM**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_activefcm`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_activefcm`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_activeios"></a> msdynmkt_activeios

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active iOS**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_activeios`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_activeios`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_apikey"></a> msdynmkt_apikey

|Property|Value|
|---|---|
|Description||
|DisplayName|**API Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_apikey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_apitoken"></a> msdynmkt_apitoken

|Property|Value|
|---|---|
|Description|**Unique identifier for API token associated with mobile application.**|
|DisplayName|**API token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_apitoken`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_applicationmode"></a> msdynmkt_applicationmode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Application mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_applicationmode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_applicationmode`|
|DefaultValue|False|
|True Label|Sandbox|
|False Label|Production|

### <a name="BKMK_msdynmkt_authenticationmode"></a> msdynmkt_authenticationmode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Authentication mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_authenticationmode`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_authenticationmode`|
|DefaultValue|False|
|True Label|Token|
|False Label|Certificate|

### <a name="BKMK_msdynmkt_bundleId"></a> msdynmkt_bundleId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Bundle Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_bundleid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificate1"></a> msdynmkt_certificate1

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate part 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificate2"></a> msdynmkt_certificate2

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate part 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificate3"></a> msdynmkt_certificate3

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate part 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificate4"></a> msdynmkt_certificate4

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate part 4**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate4`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificate5"></a> msdynmkt_certificate5

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate part 5**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate5`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_certificateName"></a> msdynmkt_certificateName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificatename`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_description"></a> msdynmkt_description

|Property|Value|
|---|---|
|Description|**The description of the custom entity.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_keyid"></a> msdynmkt_keyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Key Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_keyid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_mobileappId"></a> msdynmkt_mobileappId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Mobile Application Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_mobileappid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

### <a name="BKMK_msdynmkt_password"></a> msdynmkt_password

|Property|Value|
|---|---|
|Description||
|DisplayName|**Certificate Password**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_password`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_signingkey"></a> msdynmkt_signingkey

|Property|Value|
|---|---|
|Description||
|DisplayName|**Signing Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_signingkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_teamId"></a> msdynmkt_teamId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Team Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_teamid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_uionly_value_endpoint"></a> msdynmkt_uionly_value_endpoint

|Property|Value|
|---|---|
|Description|**The public endpoint - ui only value**|
|DisplayName|**Public endpoint**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_value_endpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_uionly_value_organizationid"></a> msdynmkt_uionly_value_organizationid

|Property|Value|
|---|---|
|Description|**The organization id - ui only value.**|
|DisplayName|**Organization Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_value_organizationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_validationfcm"></a> msdynmkt_validationfcm

|Property|Value|
|---|---|
|Description||
|DisplayName|**Android validation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_validationfcm`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|295660000|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_validationfcm`|

#### msdynmkt_validationfcm Choices/Options

|Value|Label|
|---|---|
|295660000|**Not started**|
|295660001|**Checking ...**|
|295660002|**Valid**|
|295660003|**Invalid**|
|295660004|**Valid connected**|

### <a name="BKMK_msdynmkt_validationios"></a> msdynmkt_validationios

|Property|Value|
|---|---|
|Description||
|DisplayName|**iOS validation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_validationios`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|295660000|
|GlobalChoiceName|`msdynmkt_mobileapp_msdynmkt_validationios`|

#### msdynmkt_validationios Choices/Options

|Value|Label|
|---|---|
|295660000|**Not started**|
|295660001|**Checking ...**|
|295660002|**Valid**|
|295660003|**Invalid**|
|295660004|**Valid connected**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Overriden created on**|
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
|Description|**Status of the mobile device**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_mobileapp_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Status of the mobile device**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_mobileapp_statuscode`|

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
|Description|**Time zone code that was in use when the record was created.**|
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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
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
|Description|**Unique identifier of the user who modified the record.**|
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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified by (delegate)**|
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
|DisplayName|**Business unit**|
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
|DisplayName|**Owning team**|
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
|DisplayName|**Owning user**|
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

- [business_unit_msdynmkt_mobileapp](#BKMK_business_unit_msdynmkt_mobileapp)
- [lk_msdynmkt_mobileapp_createdby](#BKMK_lk_msdynmkt_mobileapp_createdby)
- [lk_msdynmkt_mobileapp_createdonbehalfby](#BKMK_lk_msdynmkt_mobileapp_createdonbehalfby)
- [lk_msdynmkt_mobileapp_modifiedby](#BKMK_lk_msdynmkt_mobileapp_modifiedby)
- [lk_msdynmkt_mobileapp_modifiedonbehalfby](#BKMK_lk_msdynmkt_mobileapp_modifiedonbehalfby)
- [owner_msdynmkt_mobileapp](#BKMK_owner_msdynmkt_mobileapp)
- [team_msdynmkt_mobileapp](#BKMK_team_msdynmkt_mobileapp)
- [user_msdynmkt_mobileapp](#BKMK_user_msdynmkt_mobileapp)

### <a name="BKMK_business_unit_msdynmkt_mobileapp"></a> business_unit_msdynmkt_mobileapp

One-To-Many Relationship: [businessunit business_unit_msdynmkt_mobileapp](businessunit.md#BKMK_business_unit_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mobileapp_createdby"></a> lk_msdynmkt_mobileapp_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_mobileapp_createdby](systemuser.md#BKMK_lk_msdynmkt_mobileapp_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mobileapp_createdonbehalfby"></a> lk_msdynmkt_mobileapp_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_mobileapp_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_mobileapp_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mobileapp_modifiedby"></a> lk_msdynmkt_mobileapp_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_mobileapp_modifiedby](systemuser.md#BKMK_lk_msdynmkt_mobileapp_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_mobileapp_modifiedonbehalfby"></a> lk_msdynmkt_mobileapp_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_mobileapp_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_mobileapp_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_mobileapp"></a> owner_msdynmkt_mobileapp

One-To-Many Relationship: [owner owner_msdynmkt_mobileapp](owner.md#BKMK_owner_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_mobileapp"></a> team_msdynmkt_mobileapp

One-To-Many Relationship: [team team_msdynmkt_mobileapp](team.md#BKMK_team_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_mobileapp"></a> user_msdynmkt_mobileapp

One-To-Many Relationship: [systemuser user_msdynmkt_mobileapp](systemuser.md#BKMK_user_msdynmkt_mobileapp)

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

- [msdynmkt_journeydependency_dependency_msdynmkt_mobileapp](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp)
- [msdynmkt_mobileapp_AsyncOperations](#BKMK_msdynmkt_mobileapp_AsyncOperations)
- [msdynmkt_mobileapp_BulkDeleteFailures](#BKMK_msdynmkt_mobileapp_BulkDeleteFailures)
- [msdynmkt_mobileapp_MailboxTrackingFolders](#BKMK_msdynmkt_mobileapp_MailboxTrackingFolders)
- [msdynmkt_mobileapp_mobiledevice](#BKMK_msdynmkt_mobileapp_mobiledevice)
- [msdynmkt_mobileapp_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_mobileapp_PrincipalObjectAttributeAccesses)
- [msdynmkt_mobileapp_ProcessSession](#BKMK_msdynmkt_mobileapp_ProcessSession)
- [msdynmkt_mobileapp_SyncErrors](#BKMK_msdynmkt_mobileapp_SyncErrors)

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp"></a> msdynmkt_journeydependency_dependency_msdynmkt_mobileapp

Many-To-One Relationship: [msdynmkt_journeydependency msdynmkt_journeydependency_dependency_msdynmkt_mobileapp](msdynmkt_journeydependency.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapp)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_dependency_msdynmkt_mobileapp`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_AsyncOperations"></a> msdynmkt_mobileapp_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_mobileapp_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_mobileapp_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_BulkDeleteFailures"></a> msdynmkt_mobileapp_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_mobileapp_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_mobileapp_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_MailboxTrackingFolders"></a> msdynmkt_mobileapp_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_mobileapp_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_mobileapp_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_mobiledevice"></a> msdynmkt_mobileapp_mobiledevice

Many-To-One Relationship: [msdynmkt_mobiledevice msdynmkt_mobileapp_mobiledevice](msdynmkt_mobiledevice.md#BKMK_msdynmkt_mobileapp_mobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobiledevice`|
|ReferencingAttribute|`msdynmkt_mobileappid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_mobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_PrincipalObjectAttributeAccesses"></a> msdynmkt_mobileapp_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_mobileapp_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_mobileapp_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_ProcessSession"></a> msdynmkt_mobileapp_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_mobileapp_ProcessSession](processsession.md#BKMK_msdynmkt_mobileapp_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapp_SyncErrors"></a> msdynmkt_mobileapp_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_mobileapp_SyncErrors](syncerror.md#BKMK_msdynmkt_mobileapp_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapp_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

