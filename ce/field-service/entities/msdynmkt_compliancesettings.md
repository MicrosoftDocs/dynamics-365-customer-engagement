---
title: "(Deprecated) Compliance (msdynmkt_compliancesettings) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the (Deprecated) Compliance (msdynmkt_compliancesettings) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# (Deprecated) Compliance (msdynmkt_compliancesettings) table/entity reference



## Messages

The following table lists the messages for the (Deprecated) Compliance (msdynmkt_compliancesettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msdynmkt_compliancesettingses<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_compliancesettingses(*msdynmkt_compliancesettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_compliancesettingses(*msdynmkt_compliancesettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_compliancesettingses<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_compliancesettingses(*msdynmkt_compliancesettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_compliancesettingses(*msdynmkt_compliancesettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_compliancesettingses(*msdynmkt_compliancesettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the (Deprecated) Compliance (msdynmkt_compliancesettings) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the (Deprecated) Compliance (msdynmkt_compliancesettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **(Deprecated) Compliance** |
| **DisplayCollectionName** | **(Deprecated) Compliances** |
| **SchemaName** | `msdynmkt_compliancesettings` |
| **CollectionSchemaName** | `msdynmkt_compliancesettingses` |
| **EntitySetName** | `msdynmkt_compliancesettingses`|
| **LogicalName** | `msdynmkt_compliancesettings` |
| **LogicalCollectionName** | `msdynmkt_compliancesettingses` |
| **PrimaryIdAttribute** | `msdynmkt_compliancesettingsid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_compliancesettingsId](#BKMK_msdynmkt_compliancesettingsId)
- [msdynmkt_consentlink](#BKMK_msdynmkt_consentlink)
- [msdynmkt_consentlinktype](#BKMK_msdynmkt_consentlinktype)
- [msdynmkt_consentmodel](#BKMK_msdynmkt_consentmodel)
- [msdynmkt_defaulttracking](#BKMK_msdynmkt_defaulttracking)
- [msdynmkt_gettrackingconsents](#BKMK_msdynmkt_gettrackingconsents)
- [msdynmkt_jurisdiction](#BKMK_msdynmkt_jurisdiction)
- [msdynmkt_legaladdress](#BKMK_msdynmkt_legaladdress)
- [msdynmkt_marketinglogconsentchangesswitch](#BKMK_msdynmkt_marketinglogconsentchangesswitch)
- [msdynmkt_marketingrespectconsentswitch](#BKMK_msdynmkt_marketingrespectconsentswitch)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_ssc_allowemaildescription](#BKMK_msdynmkt_ssc_allowemaildescription)
- [msdynmkt_ssc_allowsmsdescription](#BKMK_msdynmkt_ssc_allowsmsdescription)
- [msdynmkt_ssc_allowtrackingdescription](#BKMK_msdynmkt_ssc_allowtrackingdescription)
- [msdynmkt_ssc_consentchangereason](#BKMK_msdynmkt_ssc_consentchangereason)
- [msdynmkt_ssc_description](#BKMK_msdynmkt_ssc_description)
- [msdynmkt_ssc_emaildescription](#BKMK_msdynmkt_ssc_emaildescription)
- [msdynmkt_ssc_emailtitle](#BKMK_msdynmkt_ssc_emailtitle)
- [msdynmkt_ssc_errorpagetext](#BKMK_msdynmkt_ssc_errorpagetext)
- [msdynmkt_ssc_legaltext](#BKMK_msdynmkt_ssc_legaltext)
- [msdynmkt_ssc_smsdescription](#BKMK_msdynmkt_ssc_smsdescription)
- [msdynmkt_ssc_smstitle](#BKMK_msdynmkt_ssc_smstitle)
- [msdynmkt_ssc_submitbuttonlabel](#BKMK_msdynmkt_ssc_submitbuttonlabel)
- [msdynmkt_ssc_thankyoupagetext](#BKMK_msdynmkt_ssc_thankyoupagetext)
- [msdynmkt_ssc_title](#BKMK_msdynmkt_ssc_title)
- [msdynmkt_ssc_trackingdescription](#BKMK_msdynmkt_ssc_trackingdescription)
- [msdynmkt_ssc_trackingtitle](#BKMK_msdynmkt_ssc_trackingtitle)
- [msdynmkt_subscriptioncenter](#BKMK_msdynmkt_subscriptioncenter)
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

### <a name="BKMK_msdynmkt_compliancesettingsId"></a> msdynmkt_compliancesettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Compliance Settings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_consentlink"></a> msdynmkt_consentlink

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent link**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentlink`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_consentlinktype"></a> msdynmkt_consentlinktype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent link type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentlinktype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentlinktype`|

#### msdynmkt_consentlinktype Choices/Options

|Value|Label|
|---|---|
|534120000|**Preference page**|
|534120001|**Subscription center**|
|534120002|**External link**|
|534120003|**Preference center**|

### <a name="BKMK_msdynmkt_consentmodel"></a> msdynmkt_consentmodel

|Property|Value|
|---|---|
|Description||
|DisplayName|**Consent model**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentmodel`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_consentmodel`|

#### msdynmkt_consentmodel Choices/Options

|Value|Label|
|---|---|
|534120000|**Restrictive**|
|534120001|**Non-Restrictive**|

### <a name="BKMK_msdynmkt_defaulttracking"></a> msdynmkt_defaulttracking

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default tracking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_defaulttracking`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_compliancesettings_msdynmkt_defaulttracking`|
|DefaultValue|False|
|True Label|Track|
|False Label|Don't track|

### <a name="BKMK_msdynmkt_gettrackingconsents"></a> msdynmkt_gettrackingconsents

|Property|Value|
|---|---|
|Description||
|DisplayName|**Get tracking consents from customers**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_gettrackingconsents`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_compliancesettings_msdynmkt_gettrackingconsents`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_jurisdiction"></a> msdynmkt_jurisdiction

|Property|Value|
|---|---|
|Description||
|DisplayName|**Jurisdiction**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_jurisdiction`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_jurisdiction`|

#### msdynmkt_jurisdiction Choices/Options

|Value|Label|
|---|---|
|534120000|**GDPR/CCPA**|
|534120001|**Other**|

### <a name="BKMK_msdynmkt_legaladdress"></a> msdynmkt_legaladdress

|Property|Value|
|---|---|
|Description|**Company address**|
|DisplayName|**Company address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_legaladdress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdynmkt_marketinglogconsentchangesswitch"></a> msdynmkt_marketinglogconsentchangesswitch

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Log Consent Changes Switch**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketinglogconsentchangesswitch`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_compliancesettings_msdynmkt_marketinglogconsentchangesswitch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_marketingrespectconsentswitch"></a> msdynmkt_marketingrespectconsentswitch

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Respect Consent Switch**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingrespectconsentswitch`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_compliancesettings_msdynmkt_marketingrespectconsentswitch`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdynmkt_ssc_allowemaildescription"></a> msdynmkt_ssc_allowemaildescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what type of emails the customer may expect to receive.**|
|DisplayName|**Allow email description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_allowemaildescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_ssc_allowsmsdescription"></a> msdynmkt_ssc_allowsmsdescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what type of SMS messages the customer may expect to receive.**|
|DisplayName|**Allow sms description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_allowsmsdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_ssc_allowtrackingdescription"></a> msdynmkt_ssc_allowtrackingdescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what kind of data will be collected.**|
|DisplayName|**Allow tracking description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_allowtrackingdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_ssc_consentchangereason"></a> msdynmkt_ssc_consentchangereason

|Property|Value|
|---|---|
|Description|**Text explaining that the customer can list reasons for changing their consent preferences. This field will be shown as optional to end-users.**|
|DisplayName|**Consent change reason label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_consentchangereason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_ssc_description"></a> msdynmkt_ssc_description

|Property|Value|
|---|---|
|Description|**Additional text explaining the purpose of the preference page.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_emaildescription"></a> msdynmkt_ssc_emaildescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what type of emails the customer may expect to receive.**|
|DisplayName|**Allow email description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_emaildescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_emailtitle"></a> msdynmkt_ssc_emailtitle

|Property|Value|
|---|---|
|Description|**Text to the right of the checkbox that the customer will select when opting in to receive marketing emails.**|
|DisplayName|**Allow email title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_emailtitle`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_errorpagetext"></a> msdynmkt_ssc_errorpagetext

|Property|Value|
|---|---|
|Description|**The text that is displayed after an unsuccessful form submission.**|
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_errorpagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_msdynmkt_ssc_legaltext"></a> msdynmkt_ssc_legaltext

|Property|Value|
|---|---|
|Description|**We recommend using this field to present your privacy policy and terms of service, which you can hyperlink to.**|
|DisplayName|**Legal text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_legaltext`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_ssc_smsdescription"></a> msdynmkt_ssc_smsdescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what type of SMS messages the customer may expect to receive.**|
|DisplayName|**Allow sms description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_smsdescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_smstitle"></a> msdynmkt_ssc_smstitle

|Property|Value|
|---|---|
|Description|**Text to the right of the checkbox that the customer will select when opting in to receive SMS messages.**|
|DisplayName|**Allow sms title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_smstitle`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_submitbuttonlabel"></a> msdynmkt_ssc_submitbuttonlabel

|Property|Value|
|---|---|
|Description|**The text that is displayed on the “Submit” button. This can remain “Submit,” but you can also choose another word.**|
|DisplayName|**Submit button label**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_submitbuttonlabel`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_thankyoupagetext"></a> msdynmkt_ssc_thankyoupagetext

|Property|Value|
|---|---|
|Description|**The text that is displayed after a succesful form submission.**|
|DisplayName|**Thank you message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_thankyoupagetext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_title"></a> msdynmkt_ssc_title

|Property|Value|
|---|---|
|Description|**Preference page where end users can manage their consent preferences.**|
|DisplayName|**Page title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_title`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_trackingdescription"></a> msdynmkt_ssc_trackingdescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what kind of data will be collected.**|
|DisplayName|**Allow tracking description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_trackingdescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_ssc_trackingtitle"></a> msdynmkt_ssc_trackingtitle

|Property|Value|
|---|---|
|Description|**Text to the right of the checkbox that the customer will select when opting in to behavior tracking.**|
|DisplayName|**Allow tracking title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_ssc_trackingtitle`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_subscriptioncenter"></a> msdynmkt_subscriptioncenter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Subscription center**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_subscriptioncenter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Compliance Settings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_compliancesettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Compliance Settings**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_compliancesettings_statuscode`|

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

- [lk_msdynmkt_compliancesettings_createdby](#BKMK_lk_msdynmkt_compliancesettings_createdby)
- [lk_msdynmkt_compliancesettings_createdonbehalfby](#BKMK_lk_msdynmkt_compliancesettings_createdonbehalfby)
- [lk_msdynmkt_compliancesettings_modifiedby](#BKMK_lk_msdynmkt_compliancesettings_modifiedby)
- [lk_msdynmkt_compliancesettings_modifiedonbehalfby](#BKMK_lk_msdynmkt_compliancesettings_modifiedonbehalfby)
- [organization_msdynmkt_compliancesettings](#BKMK_organization_msdynmkt_compliancesettings)

### <a name="BKMK_lk_msdynmkt_compliancesettings_createdby"></a> lk_msdynmkt_compliancesettings_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings_createdby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings_createdonbehalfby"></a> lk_msdynmkt_compliancesettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings_modifiedby"></a> lk_msdynmkt_compliancesettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings_modifiedby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings_modifiedonbehalfby"></a> lk_msdynmkt_compliancesettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdynmkt_compliancesettings"></a> organization_msdynmkt_compliancesettings

One-To-Many Relationship: [organization organization_msdynmkt_compliancesettings](organization.md#BKMK_organization_msdynmkt_compliancesettings)

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

- [msdynmkt_compliancesettings_AsyncOperations](#BKMK_msdynmkt_compliancesettings_AsyncOperations)
- [msdynmkt_compliancesettings_BulkDeleteFailures](#BKMK_msdynmkt_compliancesettings_BulkDeleteFailures)
- [msdynmkt_compliancesettings_DuplicateBaseRecord](#BKMK_msdynmkt_compliancesettings_DuplicateBaseRecord)
- [msdynmkt_compliancesettings_DuplicateMatchingRecord](#BKMK_msdynmkt_compliancesettings_DuplicateMatchingRecord)
- [msdynmkt_compliancesettings_MailboxTrackingFolders](#BKMK_msdynmkt_compliancesettings_MailboxTrackingFolders)
- [msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses)
- [msdynmkt_compliancesettings_ProcessSession](#BKMK_msdynmkt_compliancesettings_ProcessSession)
- [msdynmkt_compliancesettings_SyncErrors](#BKMK_msdynmkt_compliancesettings_SyncErrors)
- [msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings](#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings)
- [msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings](#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings)

### <a name="BKMK_msdynmkt_compliancesettings_AsyncOperations"></a> msdynmkt_compliancesettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_compliancesettings_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_compliancesettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_BulkDeleteFailures"></a> msdynmkt_compliancesettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_compliancesettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_compliancesettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_DuplicateBaseRecord"></a> msdynmkt_compliancesettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_compliancesettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_compliancesettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_DuplicateMatchingRecord"></a> msdynmkt_compliancesettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_compliancesettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_compliancesettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_MailboxTrackingFolders"></a> msdynmkt_compliancesettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_compliancesettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_compliancesettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses"></a> msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_ProcessSession"></a> msdynmkt_compliancesettings_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_compliancesettings_ProcessSession](processsession.md#BKMK_msdynmkt_compliancesettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings_SyncErrors"></a> msdynmkt_compliancesettings_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_compliancesettings_SyncErrors](syncerror.md#BKMK_msdynmkt_compliancesettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings"></a> msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings

Many-To-One Relationship: [msdynmkt_email msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings](msdynmkt_email.md#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_email`|
|ReferencingAttribute|`msdynmkt_compliancesettings`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_compliancesettings_msdynmkt_email_compliancesettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings"></a> msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings

Many-To-One Relationship: [msdynmkt_emailtemplate msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings](msdynmkt_emailtemplate.md#BKMK_msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_emailtemplate`|
|ReferencingAttribute|`msdynmkt_compliancesettings`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_compliancesettings_msdynmkt_emailtemplate_compliancesettings`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

