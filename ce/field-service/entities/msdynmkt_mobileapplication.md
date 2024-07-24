---
title: "Mobile app configuration (msdynmkt_mobileapplication) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Mobile app configuration (msdynmkt_mobileapplication) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Mobile app configuration (msdynmkt_mobileapplication) table/entity reference



## Messages

The following table lists the messages for the Mobile app configuration (msdynmkt_mobileapplication) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_mobileapplications<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_mobileapplications(*msdynmkt_mobileapplicationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_mobileapplications(*msdynmkt_mobileapplicationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveEntityChanges`<br />Event: True | |<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityChangesRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_mobileapplications<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /msdynmkt_mobileapplications(*msdynmkt_mobileapplicationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_mobileapplications(*msdynmkt_mobileapplicationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Mobile app configuration (msdynmkt_mobileapplication) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Mobile app configuration (msdynmkt_mobileapplication) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Mobile app configuration** |
| **DisplayCollectionName** | **Mobile app configurations** |
| **SchemaName** | `msdynmkt_mobileapplication` |
| **CollectionSchemaName** | `msdynmkt_mobileapplications` |
| **EntitySetName** | `msdynmkt_mobileapplications`|
| **LogicalName** | `msdynmkt_mobileapplication` |
| **LogicalCollectionName** | `msdynmkt_mobileapplications` |
| **PrimaryIdAttribute** | `msdynmkt_mobileapplicationid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Virtual` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [msdynmkt_activefcm](#BKMK_msdynmkt_activefcm)
- [msdynmkt_activeios](#BKMK_msdynmkt_activeios)
- [msdynmkt_apikey](#BKMK_msdynmkt_apikey)
- [msdynmkt_apiToken](#BKMK_msdynmkt_apiToken)
- [msdynmkt_applicationmode](#BKMK_msdynmkt_applicationmode)
- [msdynmkt_applicationnicknameapns](#BKMK_msdynmkt_applicationnicknameapns)
- [msdynmkt_applicationnicknamefcm](#BKMK_msdynmkt_applicationnicknamefcm)
- [msdynmkt_authenticationmode](#BKMK_msdynmkt_authenticationmode)
- [msdynmkt_BundleId](#BKMK_msdynmkt_BundleId)
- [msdynmkt_certificate](#BKMK_msdynmkt_certificate)
- [msdynmkt_CertificateName](#BKMK_msdynmkt_CertificateName)
- [msdynmkt_description](#BKMK_msdynmkt_description)
- [msdynmkt_endpoint](#BKMK_msdynmkt_endpoint)
- [msdynmkt_isconnected](#BKMK_msdynmkt_isconnected)
- [msdynmkt_keyId](#BKMK_msdynmkt_keyId)
- [msdynmkt_mobileapplicationId](#BKMK_msdynmkt_mobileapplicationId)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_organizationid](#BKMK_msdynmkt_organizationid)
- [msdynmkt_password](#BKMK_msdynmkt_password)
- [msdynmkt_signingKey](#BKMK_msdynmkt_signingKey)
- [msdynmkt_teamId](#BKMK_msdynmkt_teamId)
- [msdynmkt_testmessage](#BKMK_msdynmkt_testmessage)
- [msdynmkt_tokencopied](#BKMK_msdynmkt_tokencopied)
- [msdynmkt_validationfcm](#BKMK_msdynmkt_validationfcm)
- [msdynmkt_validationios](#BKMK_msdynmkt_validationios)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)

### <a name="BKMK_msdynmkt_activefcm"></a> msdynmkt_activefcm

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_activefcm`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_activefcm`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_activeios"></a> msdynmkt_activeios

|Property|Value|
|---|---|
|Description||
|DisplayName|**Active**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_activeios`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_activeios`|
|DefaultValue|True|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdynmkt_apikey"></a> msdynmkt_apikey

|Property|Value|
|---|---|
|Description||
|DisplayName|**API token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_apikey`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_apiToken"></a> msdynmkt_apiToken

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
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_applicationmode`|
|DefaultValue|False|
|True Label|Sandbox|
|False Label|Production|

### <a name="BKMK_msdynmkt_applicationnicknameapns"></a> msdynmkt_applicationnicknameapns

|Property|Value|
|---|---|
|Description||
|DisplayName|**iOS app**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_applicationnicknameapns`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_applicationnicknamefcm"></a> msdynmkt_applicationnicknamefcm

|Property|Value|
|---|---|
|Description||
|DisplayName|**Android app**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_applicationnicknamefcm`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

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
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_authenticationmode`|
|DefaultValue|False|
|True Label|Token|
|False Label|Certificate|

### <a name="BKMK_msdynmkt_BundleId"></a> msdynmkt_BundleId

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

### <a name="BKMK_msdynmkt_certificate"></a> msdynmkt_certificate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Upload certificate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_certificate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdynmkt_CertificateName"></a> msdynmkt_CertificateName

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

### <a name="BKMK_msdynmkt_endpoint"></a> msdynmkt_endpoint

|Property|Value|
|---|---|
|Description|**The public endpoint.**|
|DisplayName|**Public endpoint**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_endpoint`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_isconnected"></a> msdynmkt_isconnected

|Property|Value|
|---|---|
|Description|**Is ready to be used**|
|DisplayName|**Is connected**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_isconnected`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_keyId"></a> msdynmkt_keyId

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

### <a name="BKMK_msdynmkt_mobileapplicationId"></a> msdynmkt_mobileapplicationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Application Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_mobileapplicationid`|
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

### <a name="BKMK_msdynmkt_organizationid"></a> msdynmkt_organizationid

|Property|Value|
|---|---|
|Description|**The organization id.**|
|DisplayName|**Organization Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_organizationid`|
|RequiredLevel|None|
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
|DisplayName|**Password**|
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

### <a name="BKMK_msdynmkt_signingKey"></a> msdynmkt_signingKey

|Property|Value|
|---|---|
|Description||
|DisplayName|**Key Id**|
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

### <a name="BKMK_msdynmkt_testmessage"></a> msdynmkt_testmessage

|Property|Value|
|---|---|
|Description|**Notification message for test send**|
|DisplayName|**Test message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_testmessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_tokencopied"></a> msdynmkt_tokencopied

|Property|Value|
|---|---|
|Description||
|DisplayName|**Copied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_tokencopied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_tokencopied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_validationfcm`|

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
|GlobalChoiceName|`msdynmkt_mobileapplication_msdynmkt_validationios`|

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


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication](#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication)
- [msdynmkt_mobileapplication_mobiledevice](#BKMK_msdynmkt_mobileapplication_mobiledevice)

### <a name="BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication"></a> msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication

Many-To-One Relationship: [msdynmkt_journeydependency msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication](msdynmkt_journeydependency.md#BKMK_msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_journeydependency`|
|ReferencingAttribute|`msdynmkt_dependency`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_journeydependency_dependency_msdynmkt_mobileapplication`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_mobileapplication_mobiledevice"></a> msdynmkt_mobileapplication_mobiledevice

Many-To-One Relationship: [msdynmkt_mobiledevice msdynmkt_mobileapplication_mobiledevice](msdynmkt_mobiledevice.md#BKMK_msdynmkt_mobileapplication_mobiledevice)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_mobiledevice`|
|ReferencingAttribute|`msdynmkt_mobileapplicationid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_mobileapplication_mobiledevice`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

