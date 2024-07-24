---
title: "Marketing form submission (msdyncrm_marketingformsubmission) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing form submission (msdyncrm_marketingformsubmission) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing form submission (msdyncrm_marketingformsubmission) table/entity reference



## Messages

The following table lists the messages for the Marketing form submission (msdyncrm_marketingformsubmission) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingformsubmissions<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyncrm_UpdateMarketingFormSubmission`<br />Event: False |**msdyncrm_UpdateMarketingFormSubmission action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingformsubmissions<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingformsubmissions(*msdyncrm_marketingformsubmissionid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing form submission (msdyncrm_marketingformsubmission) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing form submission (msdyncrm_marketingformsubmission) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing form submission** |
| **DisplayCollectionName** | **Marketing form submissions** |
| **SchemaName** | `msdyncrm_marketingformsubmission` |
| **CollectionSchemaName** | `msdyncrm_marketingformsubmissions` |
| **EntitySetName** | `msdyncrm_marketingformsubmissions`|
| **LogicalName** | `msdyncrm_marketingformsubmission` |
| **LogicalCollectionName** | `msdyncrm_marketingformsubmissions` |
| **PrimaryIdAttribute** | `msdyncrm_marketingformsubmissionid` |
| **PrimaryNameAttribute** |`msdyncrm_formname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_contactmatchingresult](#BKMK_msdyncrm_contactmatchingresult)
- [msdyncrm_customerjourneyid](#BKMK_msdyncrm_customerjourneyid)
- [msdyncrm_customerjourneyid_value](#BKMK_msdyncrm_customerjourneyid_value)
- [msdyncrm_eventid_value](#BKMK_msdyncrm_eventid_value)
- [msdyncrm_failuredescription](#BKMK_msdyncrm_failuredescription)
- [msdyncrm_failuretechnicaldetails](#BKMK_msdyncrm_failuretechnicaldetails)
- [msdyncrm_formname](#BKMK_msdyncrm_formname)
- [msdyncrm_leadmatchingresult](#BKMK_msdyncrm_leadmatchingresult)
- [msdyncrm_marketingemailid](#BKMK_msdyncrm_marketingemailid)
- [msdyncrm_marketingemailid_value](#BKMK_msdyncrm_marketingemailid_value)
- [msdyncrm_marketingformid](#BKMK_msdyncrm_marketingformid)
- [msdyncrm_marketingformid_value](#BKMK_msdyncrm_marketingformid_value)
- [msdyncrm_marketingformsubmissionId](#BKMK_msdyncrm_marketingformsubmissionId)
- [msdyncrm_marketingpageid](#BKMK_msdyncrm_marketingpageid)
- [msdyncrm_marketingpageid_value](#BKMK_msdyncrm_marketingpageid_value)
- [msdyncrm_matchedcontactid](#BKMK_msdyncrm_matchedcontactid)
- [msdyncrm_matchedleadid](#BKMK_msdyncrm_matchedleadid)
- [msdyncrm_originalcontactid](#BKMK_msdyncrm_originalcontactid)
- [msdyncrm_originalcontactid_value](#BKMK_msdyncrm_originalcontactid_value)
- [msdyncrm_pageurl](#BKMK_msdyncrm_pageurl)
- [msdyncrm_processingstep](#BKMK_msdyncrm_processingstep)
- [msdyncrm_registrationid_value](#BKMK_msdyncrm_registrationid_value)
- [msdyncrm_sessionid_value](#BKMK_msdyncrm_sessionid_value)
- [msdyncrm_timestamp_submission](#BKMK_msdyncrm_timestamp_submission)
- [msdyncrm_visitorid_value](#BKMK_msdyncrm_visitorid_value)
- [msdyncrm_websiteid_value](#BKMK_msdyncrm_websiteid_value)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_contactmatchingresult"></a> msdyncrm_contactmatchingresult

|Property|Value|
|---|---|
|Description|**Contact matching result**|
|DisplayName|**Contact matching result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_contactmatchingresult`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_customerjourneyid"></a> msdyncrm_customerjourneyid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source customer journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_customerjourney|

### <a name="BKMK_msdyncrm_customerjourneyid_value"></a> msdyncrm_customerjourneyid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Journey Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_customerjourneyid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_eventid_value"></a> msdyncrm_eventid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**event id value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_eventid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_failuredescription"></a> msdyncrm_failuredescription

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_failuredescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_failuretechnicaldetails"></a> msdyncrm_failuretechnicaldetails

|Property|Value|
|---|---|
|Description||
|DisplayName|**Technical details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_failuretechnicaldetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdyncrm_formname"></a> msdyncrm_formname

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Form name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_formname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_leadmatchingresult"></a> msdyncrm_leadmatchingresult

|Property|Value|
|---|---|
|Description|**Lead matching result**|
|DisplayName|**Lead matching result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_leadmatchingresult`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marketingemailid"></a> msdyncrm_marketingemailid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source marketing email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_marketingemailid_value"></a> msdyncrm_marketingemailid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Email Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marketingformid"></a> msdyncrm_marketingformid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source marketing form**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingform|

### <a name="BKMK_msdyncrm_marketingformid_value"></a> msdyncrm_marketingformid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Form Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_marketingformsubmissionId"></a> msdyncrm_marketingformsubmissionId

|Property|Value|
|---|---|
|Description|**Unique identifier for this entity**|
|DisplayName|**Marketing form submission**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingformsubmissionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_marketingpageid"></a> msdyncrm_marketingpageid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source marketing page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingpage|

### <a name="BKMK_msdyncrm_marketingpageid_value"></a> msdyncrm_marketingpageid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing Page Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingpageid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_matchedcontactid"></a> msdyncrm_matchedcontactid

|Property|Value|
|---|---|
|Description|**Unique identifier for Contact associated with Marketing form submission.**|
|DisplayName|**Matched contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchedcontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_matchedleadid"></a> msdyncrm_matchedleadid

|Property|Value|
|---|---|
|Description|**Unique identifier for Lead associated with Marketing form submission.**|
|DisplayName|**Matched lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_matchedleadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_msdyncrm_originalcontactid"></a> msdyncrm_originalcontactid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_originalcontactid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msdyncrm_originalcontactid_value"></a> msdyncrm_originalcontactid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original Contact Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_originalcontactid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_pageurl"></a> msdyncrm_pageurl

|Property|Value|
|---|---|
|Description||
|DisplayName|**page url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_pageurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2083|

### <a name="BKMK_msdyncrm_processingstep"></a> msdyncrm_processingstep

|Property|Value|
|---|---|
|Description|**Number of step to be processed**|
|DisplayName|**Processing step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_processingstep`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_msdyncrm_registrationid_value"></a> msdyncrm_registrationid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**registration id value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_registrationid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_sessionid_value"></a> msdyncrm_sessionid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**session id value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_sessionid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_timestamp_submission"></a> msdyncrm_timestamp_submission

|Property|Value|
|---|---|
|Description||
|DisplayName|**timestamp of form submission**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_timestamp_submission`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_visitorid_value"></a> msdyncrm_visitorid_value

|Property|Value|
|---|---|
|Description||
|DisplayName|**visitor id value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_visitorid_value`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_websiteid_value"></a> msdyncrm_websiteid_value

|Property|Value|
|---|---|
|Description|**Website id**|
|DisplayName|**Website id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_websiteid_value`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner ID**|
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
|Description|**Status of the marketing form submission**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformsubmission_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350000<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the marketing form submission**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingformsubmission_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|
|192350000|Label: **Pending**<br />State:0<br />TransitionData: None|
|192350001|Label: **Failure**<br />State:0<br />TransitionData: None|
|192350002|Label: **Success**<br />State:0<br />TransitionData: None|
|192350003|Label: **Finished**<br />State:0<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
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
- [msdyncrm_submittedvalues](#BKMK_msdyncrm_submittedvalues)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Indicates the person who created this.**|
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
|Description|**Indicates the person who created this for another person.**|
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
|Description|**Indicates the person who modified this.**|
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
|Description|**Indicates the person who modified this for another person.**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyncrm_submittedvalues"></a> msdyncrm_submittedvalues

|Property|Value|
|---|---|
|Description|**Submitted values**|
|DisplayName|**Submitted values**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_submittedvalues`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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
|Description|**Indicates the business unit that owns this**|
|DisplayName|**Owning business unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Indicates the team that owns this.**|
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
|Description|**Indicates the person who owns this.**|
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

- [business_unit_msdyncrm_marketingformsubmission](#BKMK_business_unit_msdyncrm_marketingformsubmission)
- [lk_msdyncrm_marketingformsubmission_createdby](#BKMK_lk_msdyncrm_marketingformsubmission_createdby)
- [lk_msdyncrm_marketingformsubmission_createdonbehalfby](#BKMK_lk_msdyncrm_marketingformsubmission_createdonbehalfby)
- [lk_msdyncrm_marketingformsubmission_modifiedby](#BKMK_lk_msdyncrm_marketingformsubmission_modifiedby)
- [lk_msdyncrm_marketingformsubmission_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingformsubmission_modifiedonbehalfby)
- [msdyncrm_contact_marketingformsubmission_matched](#BKMK_msdyncrm_contact_marketingformsubmission_matched)
- [msdyncrm_contact_marketingformsubmission_original](#BKMK_msdyncrm_contact_marketingformsubmission_original)
- [msdyncrm_customerjourney_marketingformsubmission](#BKMK_msdyncrm_customerjourney_marketingformsubmission)
- [msdyncrm_lead_marketingformsubmission_matched](#BKMK_msdyncrm_lead_marketingformsubmission_matched)
- [msdyncrm_marketingemail_marketingformsubmission](#BKMK_msdyncrm_marketingemail_marketingformsubmission)
- [msdyncrm_marketingform_marketingformsubmission](#BKMK_msdyncrm_marketingform_marketingformsubmission)
- [msdyncrm_marketingpage_marketingformsubmission](#BKMK_msdyncrm_marketingpage_marketingformsubmission)
- [owner_msdyncrm_marketingformsubmission](#BKMK_owner_msdyncrm_marketingformsubmission)
- [team_msdyncrm_marketingformsubmission](#BKMK_team_msdyncrm_marketingformsubmission)
- [user_msdyncrm_marketingformsubmission](#BKMK_user_msdyncrm_marketingformsubmission)

### <a name="BKMK_business_unit_msdyncrm_marketingformsubmission"></a> business_unit_msdyncrm_marketingformsubmission

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingformsubmission](businessunit.md#BKMK_business_unit_msdyncrm_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformsubmission_createdby"></a> lk_msdyncrm_marketingformsubmission_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformsubmission_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingformsubmission_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformsubmission_createdonbehalfby"></a> lk_msdyncrm_marketingformsubmission_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformsubmission_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformsubmission_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformsubmission_modifiedby"></a> lk_msdyncrm_marketingformsubmission_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformsubmission_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingformsubmission_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingformsubmission_modifiedonbehalfby"></a> lk_msdyncrm_marketingformsubmission_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingformsubmission_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingformsubmission_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_marketingformsubmission_matched"></a> msdyncrm_contact_marketingformsubmission_matched

One-To-Many Relationship: [contact msdyncrm_contact_marketingformsubmission_matched](contact.md#BKMK_msdyncrm_contact_marketingformsubmission_matched)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_matchedcontactid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_contact_marketingformsubmission_original"></a> msdyncrm_contact_marketingformsubmission_original

One-To-Many Relationship: [contact msdyncrm_contact_marketingformsubmission_original](contact.md#BKMK_msdyncrm_contact_marketingformsubmission_original)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyncrm_originalcontactid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_Contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_customerjourney_marketingformsubmission"></a> msdyncrm_customerjourney_marketingformsubmission

One-To-Many Relationship: [msdyncrm_customerjourney msdyncrm_customerjourney_marketingformsubmission](msdyncrm_customerjourney.md#BKMK_msdyncrm_customerjourney_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_customerjourney`|
|ReferencedAttribute|`msdyncrm_customerjourneyid`|
|ReferencingAttribute|`msdyncrm_customerjourneyid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_customerjourneyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_lead_marketingformsubmission_matched"></a> msdyncrm_lead_marketingformsubmission_matched

One-To-Many Relationship: [lead msdyncrm_lead_marketingformsubmission_matched](lead.md#BKMK_msdyncrm_lead_marketingformsubmission_matched)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyncrm_matchedleadid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_Lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingemail_marketingformsubmission"></a> msdyncrm_marketingemail_marketingformsubmission

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_marketingemail_marketingformsubmission](msdyncrm_marketingemail.md#BKMK_msdyncrm_marketingemail_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_marketingemailid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingemailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingform_marketingformsubmission"></a> msdyncrm_marketingform_marketingformsubmission

One-To-Many Relationship: [msdyncrm_marketingform msdyncrm_marketingform_marketingformsubmission](msdyncrm_marketingform.md#BKMK_msdyncrm_marketingform_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingform`|
|ReferencedAttribute|`msdyncrm_marketingformid`|
|ReferencingAttribute|`msdyncrm_marketingformid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingformid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_marketingpage_marketingformsubmission"></a> msdyncrm_marketingpage_marketingformsubmission

One-To-Many Relationship: [msdyncrm_marketingpage msdyncrm_marketingpage_marketingformsubmission](msdyncrm_marketingpage.md#BKMK_msdyncrm_marketingpage_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingpage`|
|ReferencedAttribute|`msdyncrm_marketingpageid`|
|ReferencingAttribute|`msdyncrm_marketingpageid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_marketingpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingformsubmission"></a> owner_msdyncrm_marketingformsubmission

One-To-Many Relationship: [owner owner_msdyncrm_marketingformsubmission](owner.md#BKMK_owner_msdyncrm_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingformsubmission"></a> team_msdyncrm_marketingformsubmission

One-To-Many Relationship: [team team_msdyncrm_marketingformsubmission](team.md#BKMK_team_msdyncrm_marketingformsubmission)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingformsubmission"></a> user_msdyncrm_marketingformsubmission

One-To-Many Relationship: [systemuser user_msdyncrm_marketingformsubmission](systemuser.md#BKMK_user_msdyncrm_marketingformsubmission)

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

- [msdyncrm_marketingformsubmission_AsyncOperations](#BKMK_msdyncrm_marketingformsubmission_AsyncOperations)
- [msdyncrm_marketingformsubmission_BulkDeleteFailures](#BKMK_msdyncrm_marketingformsubmission_BulkDeleteFailures)
- [msdyncrm_marketingformsubmission_field](#BKMK_msdyncrm_marketingformsubmission_field)
- [msdyncrm_marketingformsubmission_MailboxTrackingFolders](#BKMK_msdyncrm_marketingformsubmission_MailboxTrackingFolders)
- [msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingformsubmission_ProcessSession](#BKMK_msdyncrm_marketingformsubmission_ProcessSession)
- [msdyncrm_marketingformsubmission_SyncErrors](#BKMK_msdyncrm_marketingformsubmission_SyncErrors)

### <a name="BKMK_msdyncrm_marketingformsubmission_AsyncOperations"></a> msdyncrm_marketingformsubmission_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingformsubmission_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingformsubmission_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_BulkDeleteFailures"></a> msdyncrm_marketingformsubmission_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingformsubmission_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingformsubmission_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_field"></a> msdyncrm_marketingformsubmission_field

Many-To-One Relationship: [msdyncrm_marketingfieldsubmission msdyncrm_marketingformsubmission_field](msdyncrm_marketingfieldsubmission.md#BKMK_msdyncrm_marketingformsubmission_field)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_marketingfieldsubmission`|
|ReferencingAttribute|`msdyncrm_formsubmissionid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_field`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_MailboxTrackingFolders"></a> msdyncrm_marketingformsubmission_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingformsubmission_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingformsubmission_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_ProcessSession"></a> msdyncrm_marketingformsubmission_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingformsubmission_ProcessSession](processsession.md#BKMK_msdyncrm_marketingformsubmission_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingformsubmission_SyncErrors"></a> msdyncrm_marketingformsubmission_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingformsubmission_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingformsubmission_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingformsubmission_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

