---
title: "Event Registration (msevtmgt_EventRegistration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Event Registration (msevtmgt_EventRegistration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Event Registration (msevtmgt_EventRegistration) table/entity reference



## Messages

The following table lists the messages for the Event Registration (msevtmgt_EventRegistration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msevtmgt_eventregistrations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_eventregistrations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_eventregistrations(*msevtmgt_eventregistrationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Event Registration (msevtmgt_EventRegistration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Event Registration (msevtmgt_EventRegistration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Event Registration** |
| **DisplayCollectionName** | **Event Registrations** |
| **SchemaName** | `msevtmgt_EventRegistration` |
| **CollectionSchemaName** | `msevtmgt_EventRegistrations` |
| **EntitySetName** | `msevtmgt_eventregistrations`|
| **LogicalName** | `msevtmgt_eventregistration` |
| **LogicalCollectionName** | `msevtmgt_eventregistrations` |
| **PrimaryIdAttribute** | `msevtmgt_eventregistrationid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_linkedregistrationid](#BKMK_msdynmkt_linkedregistrationid)
- [msevtmgt_Area](#BKMK_msevtmgt_Area)
- [msevtmgt_CompanySize](#BKMK_msevtmgt_CompanySize)
- [msevtmgt_ContactId](#BKMK_msevtmgt_ContactId)
- [msevtmgt_correlationid](#BKMK_msevtmgt_correlationid)
- [msevtmgt_createdFromApi](#BKMK_msevtmgt_createdFromApi)
- [msevtmgt_EventId](#BKMK_msevtmgt_EventId)
- [msevtmgt_EventRegistrationId](#BKMK_msevtmgt_EventRegistrationId)
- [msevtmgt_eventregistrationticketid](#BKMK_msevtmgt_eventregistrationticketid)
- [msevtmgt_Industry](#BKMK_msevtmgt_Industry)
- [msevtmgt_internalregistrationstatus](#BKMK_msevtmgt_internalregistrationstatus)
- [msevtmgt_iscanceled](#BKMK_msevtmgt_iscanceled)
- [msevtmgt_Memo](#BKMK_msevtmgt_Memo)
- [msevtmgt_Name](#BKMK_msevtmgt_Name)
- [msevtmgt_originaltimestamp](#BKMK_msevtmgt_originaltimestamp)
- [msevtmgt_PrimaryRole](#BKMK_msevtmgt_PrimaryRole)
- [msevtmgt_publishingstate](#BKMK_msevtmgt_publishingstate)
- [msevtmgt_qrcode](#BKMK_msevtmgt_qrcode)
- [msevtmgt_registeredby](#BKMK_msevtmgt_registeredby)
- [msevtmgt_registrationnotificationseen](#BKMK_msevtmgt_registrationnotificationseen)
- [msevtmgt_registrationoperation](#BKMK_msevtmgt_registrationoperation)
- [msevtmgt_registrationstatus](#BKMK_msevtmgt_registrationstatus)
- [msevtmgt_SyncedWithProvider](#BKMK_msevtmgt_SyncedWithProvider)
- [msevtmgt_TimesCheckedIn](#BKMK_msevtmgt_TimesCheckedIn)
- [msevtmgt_WebinarRegistrationID](#BKMK_msevtmgt_WebinarRegistrationID)
- [msevtmgt_YearsInIndustry](#BKMK_msevtmgt_YearsInIndustry)
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
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_linkedregistrationid"></a> msdynmkt_linkedregistrationid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Linked Registration Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_linkedregistrationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_Area"></a> msevtmgt_Area

|Property|Value|
|---|---|
|Description||
|DisplayName|**Area**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_area`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_area`|

#### msevtmgt_Area Choices/Options

|Value|Label|
|---|---|
|100000000|**Administration**|
|100000001|**Customer service**|
|100000002|**Executive/management**|
|100000003|**Logistics**|
|100000004|**Finance**|
|100000005|**HR**|
|100000006|**IT**|
|100000007|**Legal**|
|100000008|**Marketing**|
|100000009|**Sales**|

### <a name="BKMK_msevtmgt_CompanySize"></a> msevtmgt_CompanySize

|Property|Value|
|---|---|
|Description||
|DisplayName|**Company size**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_companysize`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_companysize`|

#### msevtmgt_CompanySize Choices/Options

|Value|Label|
|---|---|
|100000000|**50 or less**|
|100000001|**51 to 100**|
|100000002|**101 to 250**|
|100000003|**251 to 500**|
|100000004|**501 to 1000**|
|100000005|**1001 to 2500**|
|100000006|**2501 to 5000**|
|100000007|**5001 to 10000**|
|100000008|**10001 or more**|

### <a name="BKMK_msevtmgt_ContactId"></a> msevtmgt_ContactId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_contactid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_correlationid"></a> msevtmgt_correlationid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Correlation ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_correlationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_createdFromApi"></a> msevtmgt_createdFromApi

|Property|Value|
|---|---|
|Description|**A flag that indicates the origin of the registration**|
|DisplayName|**createdFromApi**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_createdfromapi`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_eventregistration_msevtmgt_createdfromapi`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_EventId"></a> msevtmgt_EventId

|Property|Value|
|---|---|
|Description|**Unique identifier for the event associated with the event registration**|
|DisplayName|**Event**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_event|

### <a name="BKMK_msevtmgt_EventRegistrationId"></a> msevtmgt_EventRegistrationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Event registration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventregistrationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_eventregistrationticketid"></a> msevtmgt_eventregistrationticketid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Event registration ticket**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_eventregistrationticketid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|36|

### <a name="BKMK_msevtmgt_Industry"></a> msevtmgt_Industry

|Property|Value|
|---|---|
|Description||
|DisplayName|**Industry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_industry`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_industry`|

#### msevtmgt_Industry Choices/Options

|Value|Label|
|---|---|
|100000000|**Architecture and engineering**|
|100000001|**Financial services**|
|100000002|**Manufacturing**|
|100000003|**Media, entertainment**|
|100000004|**Professional services**|
|100000005|**Public sector**|
|100000006|**Retail**|
|100000007|**Wholesale and distribution**|
|100000008|**Other**|

### <a name="BKMK_msevtmgt_internalregistrationstatus"></a> msevtmgt_internalregistrationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Internal registration status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_internalregistrationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventregistration_msevtmgt_internalregistrationstatus`|

#### msevtmgt_internalregistrationstatus Choices/Options

|Value|Label|
|---|---|
|100000000|**New**|
|100000001|**Ready**|

### <a name="BKMK_msevtmgt_iscanceled"></a> msevtmgt_iscanceled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is canceled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_iscanceled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_eventregistration_msevtmgt_iscanceled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_Memo"></a> msevtmgt_Memo

|Property|Value|
|---|---|
|Description||
|DisplayName|**Memo**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_memo`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msevtmgt_Name"></a> msevtmgt_Name

|Property|Value|
|---|---|
|Description|**Unique identifier of the registration record**|
|DisplayName|**Registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_originaltimestamp"></a> msevtmgt_originaltimestamp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Original timestamp**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_originaltimestamp`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_PrimaryRole"></a> msevtmgt_PrimaryRole

|Property|Value|
|---|---|
|Description|**Primary role of the event attendee**|
|DisplayName|**Primary role**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_primaryrole`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_primaryrole`|

#### msevtmgt_PrimaryRole Choices/Options

|Value|Label|
|---|---|
|100000000|**Attendee**|
|100000001|**Journalist**|
|100000002|**Other**|

### <a name="BKMK_msevtmgt_publishingstate"></a> msevtmgt_publishingstate

|Property|Value|
|---|---|
|Description|**The publishing state of the event registration**|
|DisplayName|**Publishing state**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_publishingstate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msevtmgt_eventregistration_msevtmgt_publishingstate`|

#### msevtmgt_publishingstate Choices/Options

|Value|Label|
|---|---|
|100000000|**Pending**|
|100000001|**Published**|
|100000002|**Parent webinar failed**|
|100000003|**Failed to publish**|
|100000004|**Webinar provider error**|

### <a name="BKMK_msevtmgt_qrcode"></a> msevtmgt_qrcode

|Property|Value|
|---|---|
|Description||
|DisplayName|**QR code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_qrcode`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msevtmgt_registeredby"></a> msevtmgt_registeredby

|Property|Value|
|---|---|
|Description|**A lookup to the contact who created this event registration**|
|DisplayName|**Registered by**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registeredby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

### <a name="BKMK_msevtmgt_registrationnotificationseen"></a> msevtmgt_registrationnotificationseen

|Property|Value|
|---|---|
|Description|**Indicates whether the registration creation notification has been seen**|
|DisplayName|**Registration notification seen**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationnotificationseen`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_event_msevtmgt_registrationnotificationseen`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_registrationoperation"></a> msevtmgt_registrationoperation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration operation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationoperation`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_registrationstatus"></a> msevtmgt_registrationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Registration status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_registrationstatus`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_SyncedWithProvider"></a> msevtmgt_SyncedWithProvider

|Property|Value|
|---|---|
|Description|**A flag that indicates that the registration was synced with the provider**|
|DisplayName|**Synced with provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_syncedwithprovider`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_nooryes`|

#### msevtmgt_SyncedWithProvider Choices/Options

|Value|Label|
|---|---|
|100000001|**No**|
|100000002|**Yes**|

### <a name="BKMK_msevtmgt_TimesCheckedIn"></a> msevtmgt_TimesCheckedIn

|Property|Value|
|---|---|
|Description|**Deprecated attribute**|
|DisplayName|**(Deprecated) Times checked-in**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_timescheckedin`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msevtmgt_WebinarRegistrationID"></a> msevtmgt_WebinarRegistrationID

|Property|Value|
|---|---|
|Description|**Webinar ID of the event registration**|
|DisplayName|**Webinar registration ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarregistrationid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_YearsInIndustry"></a> msevtmgt_YearsInIndustry

|Property|Value|
|---|---|
|Description||
|DisplayName|**Years in industry**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_yearsinindustry`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_yearsinindustry`|

#### msevtmgt_YearsInIndustry Choices/Options

|Value|Label|
|---|---|
|100000000|**Under one year**|
|100000001|**1 to 5 years**|
|100000002|**5 to 10 years**|
|100000003|**Over 10 years**|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
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
|Description|**Status of the event registration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventregistration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the event registration**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_eventregistration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

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
|Description|**The time zone code that was in use when the record was created**|
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
|Description|**The date and time when the record was created**|
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
|Description|**The date and time when the record was modified**|
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
|Description|**Unique identifier for the team that owns the record**|
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
|Description|**Unique identifier for the user that owns the record**|
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

- [business_unit_msevtmgt_eventregistration](#BKMK_business_unit_msevtmgt_eventregistration)
- [lk_msevtmgt_eventregistration_createdby](#BKMK_lk_msevtmgt_eventregistration_createdby)
- [lk_msevtmgt_eventregistration_createdonbehalfby](#BKMK_lk_msevtmgt_eventregistration_createdonbehalfby)
- [lk_msevtmgt_eventregistration_modifiedby](#BKMK_lk_msevtmgt_eventregistration_modifiedby)
- [lk_msevtmgt_eventregistration_modifiedonbehalfby](#BKMK_lk_msevtmgt_eventregistration_modifiedonbehalfby)
- [msevtmgt_contact_eventregistration_registeredby](#BKMK_msevtmgt_contact_eventregistration_registeredby)
- [msevtmgt_contact_msevtmgt_eventregistration_Contact](#BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact)
- [msevtmgt_Event_EventRegistration](#BKMK_msevtmgt_Event_EventRegistration)
- [owner_msevtmgt_eventregistration](#BKMK_owner_msevtmgt_eventregistration)
- [team_msevtmgt_eventregistration](#BKMK_team_msevtmgt_eventregistration)
- [user_msevtmgt_eventregistration](#BKMK_user_msevtmgt_eventregistration)

### <a name="BKMK_business_unit_msevtmgt_eventregistration"></a> business_unit_msevtmgt_eventregistration

One-To-Many Relationship: [businessunit business_unit_msevtmgt_eventregistration](businessunit.md#BKMK_business_unit_msevtmgt_eventregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventregistration_createdby"></a> lk_msevtmgt_eventregistration_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventregistration_createdby](systemuser.md#BKMK_lk_msevtmgt_eventregistration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventregistration_createdonbehalfby"></a> lk_msevtmgt_eventregistration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventregistration_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventregistration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventregistration_modifiedby"></a> lk_msevtmgt_eventregistration_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventregistration_modifiedby](systemuser.md#BKMK_lk_msevtmgt_eventregistration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_eventregistration_modifiedonbehalfby"></a> lk_msevtmgt_eventregistration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_eventregistration_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_eventregistration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_eventregistration_registeredby"></a> msevtmgt_contact_eventregistration_registeredby

One-To-Many Relationship: [contact msevtmgt_contact_eventregistration_registeredby](contact.md#BKMK_msevtmgt_contact_eventregistration_registeredby)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_registeredby`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_registeredby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact"></a> msevtmgt_contact_msevtmgt_eventregistration_Contact

One-To-Many Relationship: [contact msevtmgt_contact_msevtmgt_eventregistration_Contact](contact.md#BKMK_msevtmgt_contact_msevtmgt_eventregistration_Contact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msevtmgt_contactid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_ContactId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_Event_EventRegistration"></a> msevtmgt_Event_EventRegistration

One-To-Many Relationship: [msevtmgt_event msevtmgt_Event_EventRegistration](msevtmgt_event.md#BKMK_msevtmgt_Event_EventRegistration)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_event`|
|ReferencedAttribute|`msevtmgt_eventid`|
|ReferencingAttribute|`msevtmgt_eventid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_EventId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_owner_msevtmgt_eventregistration"></a> owner_msevtmgt_eventregistration

One-To-Many Relationship: [owner owner_msevtmgt_eventregistration](owner.md#BKMK_owner_msevtmgt_eventregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msevtmgt_eventregistration"></a> team_msevtmgt_eventregistration

One-To-Many Relationship: [team team_msevtmgt_eventregistration](team.md#BKMK_team_msevtmgt_eventregistration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msevtmgt_eventregistration"></a> user_msevtmgt_eventregistration

One-To-Many Relationship: [systemuser user_msevtmgt_eventregistration](systemuser.md#BKMK_user_msevtmgt_eventregistration)

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

- [msdynmkt_marketingformsubmission_eventregistration](#BKMK_msdynmkt_marketingformsubmission_eventregistration)
- [msevtmgt_eventregistration_ActivityPointers](#BKMK_msevtmgt_eventregistration_ActivityPointers)
- [msevtmgt_eventregistration_adx_alertsubscriptions](#BKMK_msevtmgt_eventregistration_adx_alertsubscriptions)
- [msevtmgt_eventregistration_adx_inviteredemptions](#BKMK_msevtmgt_eventregistration_adx_inviteredemptions)
- [msevtmgt_eventregistration_adx_portalcomments](#BKMK_msevtmgt_eventregistration_adx_portalcomments)
- [msevtmgt_eventregistration_Annotations](#BKMK_msevtmgt_eventregistration_Annotations)
- [msevtmgt_eventregistration_Appointments](#BKMK_msevtmgt_eventregistration_Appointments)
- [msevtmgt_eventregistration_AsyncOperations](#BKMK_msevtmgt_eventregistration_AsyncOperations)
- [msevtmgt_EventRegistration_AttendeePass](#BKMK_msevtmgt_EventRegistration_AttendeePass)
- [msevtmgt_eventregistration_BulkDeleteFailures](#BKMK_msevtmgt_eventregistration_BulkDeleteFailures)
- [msevtmgt_eventregistration_chats](#BKMK_msevtmgt_eventregistration_chats)
- [msevtmgt_eventregistration_Emails](#BKMK_msevtmgt_eventregistration_Emails)
- [msevtmgt_eventregistration_Faxes](#BKMK_msevtmgt_eventregistration_Faxes)
- [msevtmgt_eventregistration_Letters](#BKMK_msevtmgt_eventregistration_Letters)
- [msevtmgt_eventregistration_li_inmails](#BKMK_msevtmgt_eventregistration_li_inmails)
- [msevtmgt_eventregistration_li_messages](#BKMK_msevtmgt_eventregistration_li_messages)
- [msevtmgt_eventregistration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds)
- [msevtmgt_eventregistration_MailboxTrackingFolders](#BKMK_msevtmgt_eventregistration_MailboxTrackingFolders)
- [msevtmgt_eventregistration_msdyn_bookingalerts](#BKMK_msevtmgt_eventregistration_msdyn_bookingalerts)
- [msevtmgt_eventregistration_msdyn_copilottranscripts](#BKMK_msevtmgt_eventregistration_msdyn_copilottranscripts)
- [msevtmgt_eventregistration_msdyn_ocliveworkitems](#BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems)
- [msevtmgt_eventregistration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages)
- [msevtmgt_eventregistration_msdyn_ocsessions](#BKMK_msevtmgt_eventregistration_msdyn_ocsessions)
- [msevtmgt_eventregistration_msdyn_ocvoicemails](#BKMK_msevtmgt_eventregistration_msdyn_ocvoicemails)
- [msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId](#BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId)
- [msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee](#BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee)
- [msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee](#BKMK_msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee)
- [msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID](#BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID)
- [msevtmgt_EventRegistration_msevtmgt_Speaker](#BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker)
- [msevtmgt_eventregistration_msfp_alerts](#BKMK_msevtmgt_eventregistration_msfp_alerts)
- [msevtmgt_eventregistration_msfp_surveyinvites](#BKMK_msevtmgt_eventregistration_msfp_surveyinvites)
- [msevtmgt_eventregistration_msfp_surveyresponses](#BKMK_msevtmgt_eventregistration_msfp_surveyresponses)
- [msevtmgt_eventregistration_PhoneCalls](#BKMK_msevtmgt_eventregistration_PhoneCalls)
- [msevtmgt_eventregistration_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_eventregistration_PrincipalObjectAttributeAccesses)
- [msevtmgt_eventregistration_ProcessSession](#BKMK_msevtmgt_eventregistration_ProcessSession)
- [msevtmgt_eventregistration_RecurringAppointmentMasters](#BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters)
- [msevtmgt_eventregistration_ServiceAppointments](#BKMK_msevtmgt_eventregistration_ServiceAppointments)
- [msevtmgt_eventregistration_SocialActivities](#BKMK_msevtmgt_eventregistration_SocialActivities)
- [msevtmgt_eventregistration_SyncErrors](#BKMK_msevtmgt_eventregistration_SyncErrors)
- [msevtmgt_eventregistration_Tasks](#BKMK_msevtmgt_eventregistration_Tasks)
- [msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration](#BKMK_msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration)

### <a name="BKMK_msdynmkt_marketingformsubmission_eventregistration"></a> msdynmkt_marketingformsubmission_eventregistration

Many-To-One Relationship: [msdynmkt_marketingformsubmission msdynmkt_marketingformsubmission_eventregistration](msdynmkt_marketingformsubmission.md#BKMK_msdynmkt_marketingformsubmission_eventregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`msdynmkt_eventregistration`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_eventregistration`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_ActivityPointers"></a> msevtmgt_eventregistration_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_eventregistration_ActivityPointers](activitypointer.md#BKMK_msevtmgt_eventregistration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_adx_alertsubscriptions"></a> msevtmgt_eventregistration_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_eventregistration_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_eventregistration_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_adx_inviteredemptions"></a> msevtmgt_eventregistration_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_eventregistration_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_eventregistration_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_adx_portalcomments"></a> msevtmgt_eventregistration_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_eventregistration_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_eventregistration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Annotations"></a> msevtmgt_eventregistration_Annotations

Many-To-One Relationship: [annotation msevtmgt_eventregistration_Annotations](annotation.md#BKMK_msevtmgt_eventregistration_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Appointments"></a> msevtmgt_eventregistration_Appointments

Many-To-One Relationship: [appointment msevtmgt_eventregistration_Appointments](appointment.md#BKMK_msevtmgt_eventregistration_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_AsyncOperations"></a> msevtmgt_eventregistration_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_eventregistration_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_eventregistration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_EventRegistration_AttendeePass"></a> msevtmgt_EventRegistration_AttendeePass

Many-To-One Relationship: [msevtmgt_attendeepass msevtmgt_EventRegistration_AttendeePass](msevtmgt_attendeepass.md#BKMK_msevtmgt_EventRegistration_AttendeePass)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_attendeepass`|
|ReferencingAttribute|`msevtmgt_eventregistrationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_EventRegistration_AttendeePass`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_BulkDeleteFailures"></a> msevtmgt_eventregistration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_eventregistration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_eventregistration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_chats"></a> msevtmgt_eventregistration_chats

Many-To-One Relationship: [chat msevtmgt_eventregistration_chats](chat.md#BKMK_msevtmgt_eventregistration_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Emails"></a> msevtmgt_eventregistration_Emails

Many-To-One Relationship: [email msevtmgt_eventregistration_Emails](email.md#BKMK_msevtmgt_eventregistration_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Faxes"></a> msevtmgt_eventregistration_Faxes

Many-To-One Relationship: [fax msevtmgt_eventregistration_Faxes](fax.md#BKMK_msevtmgt_eventregistration_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Letters"></a> msevtmgt_eventregistration_Letters

Many-To-One Relationship: [letter msevtmgt_eventregistration_Letters](letter.md#BKMK_msevtmgt_eventregistration_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_li_inmails"></a> msevtmgt_eventregistration_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_eventregistration_li_inmails](li_inmail.md#BKMK_msevtmgt_eventregistration_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_li_messages"></a> msevtmgt_eventregistration_li_messages

Many-To-One Relationship: [li_message msevtmgt_eventregistration_li_messages](li_message.md#BKMK_msevtmgt_eventregistration_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds"></a> msevtmgt_eventregistration_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_eventregistration_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_eventregistration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_MailboxTrackingFolders"></a> msevtmgt_eventregistration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_eventregistration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_eventregistration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_bookingalerts"></a> msevtmgt_eventregistration_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_eventregistration_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_eventregistration_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_copilottranscripts"></a> msevtmgt_eventregistration_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_eventregistration_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_eventregistration_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems"></a> msevtmgt_eventregistration_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_eventregistration_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_eventregistration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages"></a> msevtmgt_eventregistration_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_eventregistration_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_eventregistration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocsessions"></a> msevtmgt_eventregistration_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_eventregistration_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_eventregistration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msdyn_ocvoicemails"></a> msevtmgt_eventregistration_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_eventregistration_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_eventregistration_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId"></a> msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId

Many-To-One Relationship: [msevtmgt_checkin msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId](msevtmgt_checkin.md#BKMK_msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_checkin`|
|ReferencingAttribute|`msevtmgt_registrationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msevtmgt_checkin_RegistrationId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee"></a> msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee

Many-To-One Relationship: [msevtmgt_eventpurchaseattendee msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee](msevtmgt_eventpurchaseattendee.md#BKMK_msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_eventpurchaseattendee`|
|ReferencingAttribute|`msevtmgt_eventregistrationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_EventRegistration_msevtmgt_eventpurchaseattendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee"></a> msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee

Many-To-One Relationship: [msevtmgt_hotelroomreservation msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee](msevtmgt_hotelroomreservation.md#BKMK_msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_hotelroomreservation`|
|ReferencingAttribute|`msevtmgt_attendee`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msevtmgt_hotelroomreservation_Attendee`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID"></a> msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID

Many-To-One Relationship: [msevtmgt_sessionregistration msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID](msevtmgt_sessionregistration.md#BKMK_msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_sessionregistration`|
|ReferencingAttribute|`msevtmgt_registrationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msevtmgt_sessionregistration_RegistrationID`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker"></a> msevtmgt_EventRegistration_msevtmgt_Speaker

Many-To-One Relationship: [msevtmgt_speaker msevtmgt_EventRegistration_msevtmgt_Speaker](msevtmgt_speaker.md#BKMK_msevtmgt_EventRegistration_msevtmgt_Speaker)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_speaker`|
|ReferencingAttribute|`msevtmgt_eventregistration`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_EventRegistration_msevtmgt_Speaker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msfp_alerts"></a> msevtmgt_eventregistration_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_eventregistration_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_eventregistration_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msfp_surveyinvites"></a> msevtmgt_eventregistration_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_eventregistration_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_eventregistration_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_msfp_surveyresponses"></a> msevtmgt_eventregistration_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_eventregistration_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_eventregistration_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_PhoneCalls"></a> msevtmgt_eventregistration_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_eventregistration_PhoneCalls](phonecall.md#BKMK_msevtmgt_eventregistration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_PrincipalObjectAttributeAccesses"></a> msevtmgt_eventregistration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_eventregistration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_eventregistration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_ProcessSession"></a> msevtmgt_eventregistration_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_eventregistration_ProcessSession](processsession.md#BKMK_msevtmgt_eventregistration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters"></a> msevtmgt_eventregistration_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_eventregistration_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_eventregistration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_ServiceAppointments"></a> msevtmgt_eventregistration_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_eventregistration_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_eventregistration_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_SocialActivities"></a> msevtmgt_eventregistration_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_eventregistration_SocialActivities](socialactivity.md#BKMK_msevtmgt_eventregistration_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_SyncErrors"></a> msevtmgt_eventregistration_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_eventregistration_SyncErrors](syncerror.md#BKMK_msevtmgt_eventregistration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_eventregistration_Tasks"></a> msevtmgt_eventregistration_Tasks

Many-To-One Relationship: [task msevtmgt_eventregistration_Tasks](task.md#BKMK_msevtmgt_eventregistration_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_eventregistration_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration"></a> msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration

Many-To-One Relationship: [msevtmgt_registrationresponse msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration](msevtmgt_registrationresponse.md#BKMK_msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_registrationresponse`|
|ReferencingAttribute|`msevtmgt_eventregistration`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_eventregistration_msevtmgt_registrationresponse_eventregistration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msevtmgt_eventregistration_msevtmgt_session"></a> msevtmgt_eventregistration_msevtmgt_session

See [msevtmgt_session msevtmgt_eventregistration_msevtmgt_session Many-To-Many Relationship](msevtmgt_session.md#BKMK_msevtmgt_eventregistration_msevtmgt_session)

|Property|Value|
|---|---|
|IntersectEntityName|`msevtmgt_eventregistration_msevtmgt_session`|
|IsCustomizable|True|
|SchemaName|`msevtmgt_eventregistration_msevtmgt_session`|
|IntersectAttribute|`msevtmgt_eventregistrationid`|
|NavigationPropertyName|`msevtmgt_eventregistration_msevtmgt_session`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

