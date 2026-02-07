---
title: "Compliance profile (msdynmkt_compliancesettings4) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Compliance profile (msdynmkt_compliancesettings4) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Compliance profile (msdynmkt_compliancesettings4) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Compliance profile (msdynmkt_compliancesettings4) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdynmkt_compliancesettings4s<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_compliancesettings4s<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_compliancesettings4s(*msdynmkt_compliancesettings4id*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Compliance profile (msdynmkt_compliancesettings4) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Compliance profile** |
| **DisplayCollectionName** | **Compliance profiles** |
| **SchemaName** | `msdynmkt_compliancesettings4` |
| **CollectionSchemaName** | `msdynmkt_compliancesettings4s` |
| **EntitySetName** | `msdynmkt_compliancesettings4s`|
| **LogicalName** | `msdynmkt_compliancesettings4` |
| **LogicalCollectionName** | `msdynmkt_compliancesettings4s` |
| **PrimaryIdAttribute** | `msdynmkt_compliancesettings4id` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_compliancesettings4Id](#BKMK_msdynmkt_compliancesettings4Id)
- [msdynmkt_consentlink](#BKMK_msdynmkt_consentlink)
- [msdynmkt_consentlink_customerprofile](#BKMK_msdynmkt_consentlink_customerprofile)
- [msdynmkt_consentlink_leads](#BKMK_msdynmkt_consentlink_leads)
- [msdynmkt_consentlinktype](#BKMK_msdynmkt_consentlinktype)
- [msdynmkt_ConsentProviderId](#BKMK_msdynmkt_ConsentProviderId)
- [msdynmkt_DOIConfirmationText](#BKMK_msdynmkt_DOIConfirmationText)
- [msdynmkt_DOIConfirmationType](#BKMK_msdynmkt_DOIConfirmationType)
- [msdynmkt_DOIConfirmationURL](#BKMK_msdynmkt_DOIConfirmationURL)
- [msdynmkt_DOIFailureReason](#BKMK_msdynmkt_DOIFailureReason)
- [msdynmkt_doijobstatus](#BKMK_msdynmkt_doijobstatus)
- [msdynmkt_DOIStatus](#BKMK_msdynmkt_DOIStatus)
- [msdynmkt_emaildescription](#BKMK_msdynmkt_emaildescription)
- [msdynmkt_extendedentityId](#BKMK_msdynmkt_extendedentityId)
- [msdynmkt_extendedentityIdType](#BKMK_msdynmkt_extendedentityIdType)
- [msdynmkt_gettrackingconsents](#BKMK_msdynmkt_gettrackingconsents)
- [msdynmkt_globaldoienabled](#BKMK_msdynmkt_globaldoienabled)
- [msdynmkt_jurisdiction](#BKMK_msdynmkt_jurisdiction)
- [msdynmkt_legaladdress](#BKMK_msdynmkt_legaladdress)
- [msdynmkt_migrationtimestamp](#BKMK_msdynmkt_migrationtimestamp)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_ssc_allowemaildescription](#BKMK_msdynmkt_ssc_allowemaildescription)
- [msdynmkt_ssc_allowsmsdescription](#BKMK_msdynmkt_ssc_allowsmsdescription)
- [msdynmkt_ssc_allowtrackingdescription](#BKMK_msdynmkt_ssc_allowtrackingdescription)
- [msdynmkt_ssc_consentchangereason](#BKMK_msdynmkt_ssc_consentchangereason)
- [msdynmkt_ssc_description](#BKMK_msdynmkt_ssc_description)
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
- [msdynmkt_TrackingConsentPurpose](#BKMK_msdynmkt_TrackingConsentPurpose)
- [msdynmkt_uionly_link_existing_profile](#BKMK_msdynmkt_uionly_link_existing_profile)
- [msdynmkt_uionly_linked_profile](#BKMK_msdynmkt_uionly_linked_profile)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdynmkt_compliancesettings4Id"></a> msdynmkt_compliancesettings4Id

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Compliance Settings**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings4id`|
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

### <a name="BKMK_msdynmkt_consentlink_customerprofile"></a> msdynmkt_consentlink_customerprofile

|Property|Value|
|---|---|
|Description|**Unsubscribe URL for customer profile**|
|DisplayName|**Consent link for customer profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentlink_customerprofile`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_consentlink_leads"></a> msdynmkt_consentlink_leads

|Property|Value|
|---|---|
|Description|**Unsubscribe URL for leads**|
|DisplayName|**Consent link for leads**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentlink_leads`|
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
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_consentlinktype`|

#### msdynmkt_consentlinktype Choices/Options

|Value|Label|
|---|---|
|534120000|**Preference page**|
|534120001|**Subscription center**|
|534120002|**External link**|
|534120003|**Preference center**|

### <a name="BKMK_msdynmkt_ConsentProviderId"></a> msdynmkt_ConsentProviderId

|Property|Value|
|---|---|
|Description|**Consent provider**|
|DisplayName|**Consent provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_consentproviderid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_consentprovider|

### <a name="BKMK_msdynmkt_DOIConfirmationText"></a> msdynmkt_DOIConfirmationText

|Property|Value|
|---|---|
|Description|**Double Opt-in Confirmation Text**|
|DisplayName|**DOI Confirmation Text**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doiconfirmationtext`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_DOIConfirmationType"></a> msdynmkt_DOIConfirmationType

|Property|Value|
|---|---|
|Description|**The type of double opt in confirmation - Text or URL.**|
|DisplayName|**DOI Confirmation Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doiconfirmationtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_compliancesettings4_msdynmkt_doiconfirmationtype`|

#### msdynmkt_DOIConfirmationType Choices/Options

|Value|Label|
|---|---|
|534120000|**Text**|
|534120001|**Url**|

### <a name="BKMK_msdynmkt_DOIConfirmationURL"></a> msdynmkt_DOIConfirmationURL

|Property|Value|
|---|---|
|Description|**Double Opt-in Confirmation URL**|
|DisplayName|**DOI Confirmation URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doiconfirmationurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdynmkt_DOIFailureReason"></a> msdynmkt_DOIFailureReason

|Property|Value|
|---|---|
|Description|**Double Opt-in Failure Reason**|
|DisplayName|**DOI Failure Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doifailurereason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_doijobstatus"></a> msdynmkt_doijobstatus

|Property|Value|
|---|---|
|Description|**Gets the current backend processing status of double opt in.**|
|DisplayName|**DOI Job Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doijobstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_doijobstatus_optionset`|

#### msdynmkt_doijobstatus Choices/Options

|Value|Label|
|---|---|
|0|**Request Accepted**|
|1|**Email Created**|
|2|**Email Published**|
|3|**Journey Created**|
|4|**Journey Publishing Started**|
|5|**Journey Published**|
|6|**Processing Completed**|
|7|**Failed**|
|8|**Email Create Failed**|
|9|**Email Publish Failed**|
|10|**Journey Create Failed**|
|11|**Journey Publish Failed**|

### <a name="BKMK_msdynmkt_DOIStatus"></a> msdynmkt_DOIStatus

|Property|Value|
|---|---|
|Description|**Gets the current status of double opt in.**|
|DisplayName|**DOI Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doistatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_compliancesettings4_msdynmkt_doistatus`|

#### msdynmkt_DOIStatus Choices/Options

|Value|Label|
|---|---|
|534120000|**Not enabled**|
|534120001|**Enabled**|
|534120002|**(Deprecated)Enabled**|

### <a name="BKMK_msdynmkt_emaildescription"></a> msdynmkt_emaildescription

|Property|Value|
|---|---|
|Description|**Additional text explaining what type of emails the customer may expect to receive.**|
|DisplayName|**Allow email description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_emaildescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_extendedentityId"></a> msdynmkt_extendedentityId

|Property|Value|
|---|---|
|Description|**Extended entity**|
|DisplayName|**Extended entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_extendedentityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_consentproviderdefaultconfiguration|

### <a name="BKMK_msdynmkt_extendedentityIdType"></a> msdynmkt_extendedentityIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_extendedentityidtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|GlobalChoiceName|`msdynmkt_compliancesettings4_msdynmkt_gettrackingconsents`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_globaldoienabled"></a> msdynmkt_globaldoienabled

|Property|Value|
|---|---|
|Description|**Send double opt-in email only once**|
|DisplayName|**Send double opt-in email only once**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_globaldoienabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_globaldoienabled`|
|DefaultValue|False|
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
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|300|

### <a name="BKMK_msdynmkt_migrationtimestamp"></a> msdynmkt_migrationtimestamp

|Property|Value|
|---|---|
|Description|**for migrated records, this is the timestamp for migration.**|
|DisplayName|**Migration Timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_migrationtimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|2000|

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

### <a name="BKMK_msdynmkt_TrackingConsentPurpose"></a> msdynmkt_TrackingConsentPurpose

|Property|Value|
|---|---|
|Description|**Tracking Consent Purpose for tracking the consents from customers.**|
|DisplayName|**Tracking Consent Purpose**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_trackingconsentpurpose`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_purpose|

### <a name="BKMK_msdynmkt_uionly_link_existing_profile"></a> msdynmkt_uionly_link_existing_profile

|Property|Value|
|---|---|
|Description|**UIOnly Link existing profile**|
|DisplayName|**UIOnly IsLinkedTo Existing Compliance Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_link_existing_profile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_compliancesettings4_msdynmkt_uionly_link_existing_profile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_uionly_linked_profile"></a> msdynmkt_uionly_linked_profile

|Property|Value|
|---|---|
|Description|**link existing profile to attach the existing purposes**|
|DisplayName|**UIOnly Existing Compliance Profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uionly_linked_profile`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

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
|Description|**Status of the Compliance**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_compliancesettings4_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Compliance**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_compliancesettings4_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdynmkt_compliancesettings4](#BKMK_business_unit_msdynmkt_compliancesettings4)
- [lk_msdynmkt_compliancesettings4_createdby](#BKMK_lk_msdynmkt_compliancesettings4_createdby)
- [lk_msdynmkt_compliancesettings4_createdonbehalfby](#BKMK_lk_msdynmkt_compliancesettings4_createdonbehalfby)
- [lk_msdynmkt_compliancesettings4_modifiedby](#BKMK_lk_msdynmkt_compliancesettings4_modifiedby)
- [lk_msdynmkt_compliancesettings4_modifiedonbehalfby](#BKMK_lk_msdynmkt_compliancesettings4_modifiedonbehalfby)
- [msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration](#BKMK_msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration)
- [msdynmkt_compliancesettings4_uionly_linkedprofile](#BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-many-to-one)
- [msdynmkt_msdynmkt_compliancesettings4_TrackingCons](#BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons)
- [msdynmkt_msdynmkt_consentprovider_msdynmkt_complia](#BKMK_msdynmkt_msdynmkt_consentprovider_msdynmkt_complia)
- [owner_msdynmkt_compliancesettings4](#BKMK_owner_msdynmkt_compliancesettings4)
- [team_msdynmkt_compliancesettings4](#BKMK_team_msdynmkt_compliancesettings4)
- [user_msdynmkt_compliancesettings4](#BKMK_user_msdynmkt_compliancesettings4)

### <a name="BKMK_business_unit_msdynmkt_compliancesettings4"></a> business_unit_msdynmkt_compliancesettings4

One-To-Many Relationship: [businessunit business_unit_msdynmkt_compliancesettings4](businessunit.md#BKMK_business_unit_msdynmkt_compliancesettings4)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings4_createdby"></a> lk_msdynmkt_compliancesettings4_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings4_createdby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings4_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings4_createdonbehalfby"></a> lk_msdynmkt_compliancesettings4_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings4_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings4_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings4_modifiedby"></a> lk_msdynmkt_compliancesettings4_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings4_modifiedby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings4_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_compliancesettings4_modifiedonbehalfby"></a> lk_msdynmkt_compliancesettings4_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_compliancesettings4_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_compliancesettings4_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration"></a> msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration

One-To-Many Relationship: [msdynmkt_consentproviderdefaultconfiguration msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration](msdynmkt_consentproviderdefaultconfiguration.md#BKMK_msdynmkt_compliancesettings4_msdynmkt_consentproviderdefaultconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_consentproviderdefaultconfiguration`|
|ReferencedAttribute|`msdynmkt_consentproviderdefaultconfigurationid`|
|ReferencingAttribute|`msdynmkt_extendedentityid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_extendedentityId_msdynmkt_consentproviderdefaultconfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-many-to-one"></a> msdynmkt_compliancesettings4_uionly_linkedprofile

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_compliancesettings4_uionly_linkedprofile](#BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_uionly_linked_profile`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_uionly_linked_profile`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons"></a> msdynmkt_msdynmkt_compliancesettings4_TrackingCons

One-To-Many Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_compliancesettings4_TrackingCons](msdynmkt_purpose.md#BKMK_msdynmkt_msdynmkt_compliancesettings4_TrackingCons)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_purpose`|
|ReferencedAttribute|`msdynmkt_purposeid`|
|ReferencingAttribute|`msdynmkt_trackingconsentpurpose`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_TrackingConsentPurpose`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_consentprovider_msdynmkt_complia"></a> msdynmkt_msdynmkt_consentprovider_msdynmkt_complia

One-To-Many Relationship: [msdynmkt_consentprovider msdynmkt_msdynmkt_consentprovider_msdynmkt_complia](msdynmkt_consentprovider.md#BKMK_msdynmkt_msdynmkt_consentprovider_msdynmkt_complia)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_consentprovider`|
|ReferencedAttribute|`msdynmkt_consentproviderid`|
|ReferencingAttribute|`msdynmkt_consentproviderid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_ConsentProviderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_compliancesettings4"></a> owner_msdynmkt_compliancesettings4

One-To-Many Relationship: [owner owner_msdynmkt_compliancesettings4](owner.md#BKMK_owner_msdynmkt_compliancesettings4)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_compliancesettings4"></a> team_msdynmkt_compliancesettings4

One-To-Many Relationship: [team team_msdynmkt_compliancesettings4](team.md#BKMK_team_msdynmkt_compliancesettings4)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_compliancesettings4"></a> user_msdynmkt_compliancesettings4

One-To-Many Relationship: [systemuser user_msdynmkt_compliancesettings4](systemuser.md#BKMK_user_msdynmkt_compliancesettings4)

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

- [msdynmkt_compliancesettings4_AsyncOperations](#BKMK_msdynmkt_compliancesettings4_AsyncOperations)
- [msdynmkt_compliancesettings4_BulkDeleteFailures](#BKMK_msdynmkt_compliancesettings4_BulkDeleteFailures)
- [msdynmkt_compliancesettings4_DuplicateBaseRecord](#BKMK_msdynmkt_compliancesettings4_DuplicateBaseRecord)
- [msdynmkt_compliancesettings4_DuplicateMatchingRecord](#BKMK_msdynmkt_compliancesettings4_DuplicateMatchingRecord)
- [msdynmkt_compliancesettings4_MailboxTrackingFolders](#BKMK_msdynmkt_compliancesettings4_MailboxTrackingFolders)
- [msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses)
- [msdynmkt_compliancesettings4_ProcessSession](#BKMK_msdynmkt_compliancesettings4_ProcessSession)
- [msdynmkt_compliancesettings4_SyncErrors](#BKMK_msdynmkt_compliancesettings4_SyncErrors)
- [msdynmkt_compliancesettings4_uionly_linkedprofile](#BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-one-to-many)
- [msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre](#BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre)
- [msdynmkt_msdynmkt_uionly_compliancesettings4_lookup](#BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup)

### <a name="BKMK_msdynmkt_compliancesettings4_AsyncOperations"></a> msdynmkt_compliancesettings4_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_compliancesettings4_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_compliancesettings4_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_BulkDeleteFailures"></a> msdynmkt_compliancesettings4_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_compliancesettings4_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_compliancesettings4_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_DuplicateBaseRecord"></a> msdynmkt_compliancesettings4_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_compliancesettings4_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_compliancesettings4_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_DuplicateMatchingRecord"></a> msdynmkt_compliancesettings4_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_compliancesettings4_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_compliancesettings4_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_MailboxTrackingFolders"></a> msdynmkt_compliancesettings4_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_compliancesettings4_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_compliancesettings4_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses"></a> msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_ProcessSession"></a> msdynmkt_compliancesettings4_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_compliancesettings4_ProcessSession](processsession.md#BKMK_msdynmkt_compliancesettings4_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_SyncErrors"></a> msdynmkt_compliancesettings4_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_compliancesettings4_SyncErrors](syncerror.md#BKMK_msdynmkt_compliancesettings4_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-one-to-many"></a> msdynmkt_compliancesettings4_uionly_linkedprofile

Many-To-One Relationship: [msdynmkt_compliancesettings4 msdynmkt_compliancesettings4_uionly_linkedprofile](#BKMK_msdynmkt_compliancesettings4_uionly_linkedprofile-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_compliancesettings4`|
|ReferencingAttribute|`msdynmkt_uionly_linked_profile`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_compliancesettings4_uionly_linkedprofile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre"></a> msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre

Many-To-One Relationship: [msdynmkt_preferencecenter msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre](msdynmkt_preferencecenter.md#BKMK_msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_preferencecenter`|
|ReferencingAttribute|`msdynmkt_complianceid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_compliancesettings4_msdynmkt_pre`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup"></a> msdynmkt_msdynmkt_uionly_compliancesettings4_lookup

Many-To-One Relationship: [msdynmkt_purpose msdynmkt_msdynmkt_uionly_compliancesettings4_lookup](msdynmkt_purpose.md#BKMK_msdynmkt_msdynmkt_uionly_compliancesettings4_lookup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_purpose`|
|ReferencingAttribute|`msdynmkt_uionlycomplianceprofilelookup`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_uionly_compliancesettings4_lookup`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4"></a> msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4

See [msdynmkt_purpose msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4 Many-To-Many Relationship](msdynmkt_purpose.md#BKMK_msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4)

|Property|Value|
|---|---|
|IntersectEntityName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|IsCustomizable|False|
|SchemaName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|IntersectAttribute|`msdynmkt_compliancesettings4id`|
|NavigationPropertyName|`msdynmkt_msdynmkt_purpose_msdynmkt_compliancev4`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

