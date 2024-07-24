---
title: "Multistep Form (adx_webform) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Multistep Form (adx_webform) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Multistep Form (adx_webform) table/entity reference

Defines the necessary properties and relationships to the other key entities in order to control the initialization of the form within a web portal.

## Messages

The following table lists the messages for the Multistep Form (adx_webform) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_webforms(*adx_webformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_webforms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_webforms(*adx_webformid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_webforms(*adx_webformid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_webforms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_webforms(*adx_webformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_webforms(*adx_webformid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_webforms(*adx_webformid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Multistep Form (adx_webform) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Multistep Form (adx_webform) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Multistep Form** |
| **DisplayCollectionName** | **Multistep Forms** |
| **SchemaName** | `adx_webform` |
| **CollectionSchemaName** | `adx_webforms` |
| **EntitySetName** | `adx_webforms`|
| **LogicalName** | `adx_webform` |
| **LogicalCollectionName** | `adx_webforms` |
| **PrimaryIdAttribute** | `adx_webformid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_authenticationrequired](#BKMK_adx_authenticationrequired)
- [adx_editexistingrecordpermitted](#BKMK_adx_editexistingrecordpermitted)
- [adx_editexpiredmessage](#BKMK_adx_editexpiredmessage)
- [adx_editexpiredstatecode](#BKMK_adx_editexpiredstatecode)
- [adx_editexpiredstatuscode](#BKMK_adx_editexpiredstatuscode)
- [adx_editnotpermittedmessage](#BKMK_adx_editnotpermittedmessage)
- [adx_multiplerecordsperuserpermitted](#BKMK_adx_multiplerecordsperuserpermitted)
- [adx_name](#BKMK_adx_name)
- [adx_progressindicatorenabled](#BKMK_adx_progressindicatorenabled)
- [adx_progressindicatorignorelaststep](#BKMK_adx_progressindicatorignorelaststep)
- [adx_progressindicatorposition](#BKMK_adx_progressindicatorposition)
- [adx_progressindicatorprependstepnum](#BKMK_adx_progressindicatorprependstepnum)
- [adx_progressindicatortype](#BKMK_adx_progressindicatortype)
- [adx_provisionedlanguages](#BKMK_adx_provisionedlanguages)
- [adx_savechangeswarningmessage](#BKMK_adx_savechangeswarningmessage)
- [adx_savechangeswarningonclose](#BKMK_adx_savechangeswarningonclose)
- [adx_startnewsessiononload](#BKMK_adx_startnewsessiononload)
- [adx_startstep](#BKMK_adx_startstep)
- [adx_webformId](#BKMK_adx_webformId)
- [adx_websiteid](#BKMK_adx_websiteid)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_authenticationrequired"></a> adx_authenticationrequired

|Property|Value|
|---|---|
|Description|**Redirect to sign in if the user is anonymous.**|
|DisplayName|**Authentication Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_authenticationrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_authenticationrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_editexistingrecordpermitted"></a> adx_editexistingrecordpermitted

|Property|Value|
|---|---|
|Description|**Determines if an existing record can be edited. This setting is ignored If the form mode on the form step is set to edit mode. Otherwise, an edit form wouldn't function properly.**|
|DisplayName|**Edit Existing Record Permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexistingrecordpermitted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_editexistingrecordpermitted`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_editexpiredmessage"></a> adx_editexpiredmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_editexpiredstatecode"></a> adx_editexpiredstatecode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired State Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredstatecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_editexpiredstatuscode"></a> adx_editexpiredstatuscode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Expired Status Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editexpiredstatuscode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_editnotpermittedmessage"></a> adx_editnotpermittedmessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Edit Not Permitted Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_editnotpermittedmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_multiplerecordsperuserpermitted"></a> adx_multiplerecordsperuserpermitted

|Property|Value|
|---|---|
|Description||
|DisplayName|**Multiple Records Per User Permitted**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_multiplerecordsperuserpermitted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_multiplerecordsperuserpermitted`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_name"></a> adx_name

|Property|Value|
|---|---|
|Description|**Type the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|400|

### <a name="BKMK_adx_progressindicatorenabled"></a> adx_progressindicatorenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_progressindicatorenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_progressindicatorenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_progressindicatorignorelaststep"></a> adx_progressindicatorignorelaststep

|Property|Value|
|---|---|
|Description||
|DisplayName|**Ignore Last Step In Progress Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_progressindicatorignorelaststep`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_progressindicatorignorelaststep`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_progressindicatorposition"></a> adx_progressindicatorposition

|Property|Value|
|---|---|
|Description|**Location of the progress indicator relative to the form**|
|DisplayName|**Position**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_progressindicatorposition`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_webform_adx_progressindicatorposition`|

#### adx_progressindicatorposition Choices/Options

|Value|Label|
|---|---|
|756150000|**Top**|
|756150001|**Bottom**|
|756150002|**Left**|
|756150003|**Right**|

### <a name="BKMK_adx_progressindicatorprependstepnum"></a> adx_progressindicatorprependstepnum

|Property|Value|
|---|---|
|Description||
|DisplayName|**Prepend Step Number to Step Title**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_progressindicatorprependstepnum`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_progressindicatorprependstepnum`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_progressindicatortype"></a> adx_progressindicatortype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_progressindicatortype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|756150000|
|GlobalChoiceName|`adx_webform_adx_progressindicatortype`|

#### adx_progressindicatortype Choices/Options

|Value|Label|
|---|---|
|756150000|**Title**|
|756150001|**Numeric (Step 1 of N)**|
|756150002|**Progress Bar**|

### <a name="BKMK_adx_provisionedlanguages"></a> adx_provisionedlanguages

|Property|Value|
|---|---|
|Description||
|DisplayName|**Provisioned Languages**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_provisionedlanguages`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_savechangeswarningmessage"></a> adx_savechangeswarningmessage

|Property|Value|
|---|---|
|Description|**Default message: Your changes have not been saved. To stay on the page so that you can save your changes, click Cancel.**|
|DisplayName|**Save Changes Warning Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_savechangeswarningmessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

### <a name="BKMK_adx_savechangeswarningonclose"></a> adx_savechangeswarningonclose

|Property|Value|
|---|---|
|Description|**Displays a warning message to the user if they close the browser, or refresh the page, or click the previous button in a multiple step form and they have changes that haven't been saved.**|
|DisplayName|**Display Save Changes Warning On Close**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_savechangeswarningonclose`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_savechangeswarningonclose`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_startnewsessiononload"></a> adx_startnewsessiononload

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start New Session On Load**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_startnewsessiononload`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`adx_webform_adx_startnewsessiononload`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_adx_startstep"></a> adx_startstep

|Property|Value|
|---|---|
|Description|**Unique identifier for Form Step associated with Multistep Form.**|
|DisplayName|**Start Step**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_startstep`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webformstep|

### <a name="BKMK_adx_webformId"></a> adx_webformId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Multistep Form**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_webformid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_adx_websiteid"></a> adx_websiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website entity associated with this record**|
|DisplayName|**Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.**|
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
|Description|**Shows the status of the multistep Form.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_webform_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Select the Multistep Form's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_webform_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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
|Description|**Shows the business unit that owns the record.**|
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

- [adx_webform_startstep](#BKMK_adx_webform_startstep)
- [adx_website_webform](#BKMK_adx_website_webform)
- [business_unit_adx_webform](#BKMK_business_unit_adx_webform)
- [lk_adx_webform_createdby](#BKMK_lk_adx_webform_createdby)
- [lk_adx_webform_createdonbehalfby](#BKMK_lk_adx_webform_createdonbehalfby)
- [lk_adx_webform_modifiedby](#BKMK_lk_adx_webform_modifiedby)
- [lk_adx_webform_modifiedonbehalfby](#BKMK_lk_adx_webform_modifiedonbehalfby)
- [owner_adx_webform](#BKMK_owner_adx_webform)
- [team_adx_webform](#BKMK_team_adx_webform)
- [user_adx_webform](#BKMK_user_adx_webform)

### <a name="BKMK_adx_webform_startstep"></a> adx_webform_startstep

One-To-Many Relationship: [adx_webformstep adx_webform_startstep](adx_webformstep.md#BKMK_adx_webform_startstep)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webformstep`|
|ReferencedAttribute|`adx_webformstepid`|
|ReferencingAttribute|`adx_startstep`|
|ReferencingEntityNavigationPropertyName|`adx_startstep`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_webform"></a> adx_website_webform

One-To-Many Relationship: [adx_website adx_website_webform](adx_website.md#BKMK_adx_website_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencingEntityNavigationPropertyName|`adx_websiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_webform"></a> business_unit_adx_webform

One-To-Many Relationship: [businessunit business_unit_adx_webform](businessunit.md#BKMK_business_unit_adx_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webform_createdby"></a> lk_adx_webform_createdby

One-To-Many Relationship: [systemuser lk_adx_webform_createdby](systemuser.md#BKMK_lk_adx_webform_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webform_createdonbehalfby"></a> lk_adx_webform_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webform_createdonbehalfby](systemuser.md#BKMK_lk_adx_webform_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webform_modifiedby"></a> lk_adx_webform_modifiedby

One-To-Many Relationship: [systemuser lk_adx_webform_modifiedby](systemuser.md#BKMK_lk_adx_webform_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_webform_modifiedonbehalfby"></a> lk_adx_webform_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_webform_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_webform_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_webform"></a> owner_adx_webform

One-To-Many Relationship: [owner owner_adx_webform](owner.md#BKMK_owner_adx_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_webform"></a> team_adx_webform

One-To-Many Relationship: [team team_adx_webform](team.md#BKMK_team_adx_webform)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_webform"></a> user_adx_webform

One-To-Many Relationship: [systemuser user_adx_webform](systemuser.md#BKMK_user_adx_webform)

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

- [adx_webform_AsyncOperations](#BKMK_adx_webform_AsyncOperations)
- [adx_webform_BulkDeleteFailures](#BKMK_adx_webform_BulkDeleteFailures)
- [adx_webform_DuplicateBaseRecord](#BKMK_adx_webform_DuplicateBaseRecord)
- [adx_webform_DuplicateMatchingRecord](#BKMK_adx_webform_DuplicateMatchingRecord)
- [adx_webform_MailboxTrackingFolders](#BKMK_adx_webform_MailboxTrackingFolders)
- [adx_webform_PrincipalObjectAttributeAccesses](#BKMK_adx_webform_PrincipalObjectAttributeAccesses)
- [adx_webform_ProcessSession](#BKMK_adx_webform_ProcessSession)
- [adx_webform_SyncErrors](#BKMK_adx_webform_SyncErrors)
- [adx_webform_webformmetadata_entityformforcreate](#BKMK_adx_webform_webformmetadata_entityformforcreate)
- [adx_webformsession_webform](#BKMK_adx_webformsession_webform)
- [adx_webformstep_webform](#BKMK_adx_webformstep_webform)
- [adx_webpage_webform](#BKMK_adx_webpage_webform)

### <a name="BKMK_adx_webform_AsyncOperations"></a> adx_webform_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_webform_AsyncOperations](asyncoperation.md#BKMK_adx_webform_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_BulkDeleteFailures"></a> adx_webform_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_webform_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_webform_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_DuplicateBaseRecord"></a> adx_webform_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_webform_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_webform_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_DuplicateMatchingRecord"></a> adx_webform_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_webform_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_webform_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_MailboxTrackingFolders"></a> adx_webform_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_webform_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_webform_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_PrincipalObjectAttributeAccesses"></a> adx_webform_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_webform_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_webform_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_ProcessSession"></a> adx_webform_ProcessSession

Many-To-One Relationship: [processsession adx_webform_ProcessSession](processsession.md#BKMK_adx_webform_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_SyncErrors"></a> adx_webform_SyncErrors

Many-To-One Relationship: [syncerror adx_webform_SyncErrors](syncerror.md#BKMK_adx_webform_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_webform_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webform_webformmetadata_entityformforcreate"></a> adx_webform_webformmetadata_entityformforcreate

Many-To-One Relationship: [adx_webformmetadata adx_webform_webformmetadata_entityformforcreate](adx_webformmetadata.md#BKMK_adx_webform_webformmetadata_entityformforcreate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformmetadata`|
|ReferencingAttribute|`adx_entityformforcreate`|
|ReferencedEntityNavigationPropertyName|`adx_webform_webformmetadata_entityformforcreate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformsession_webform"></a> adx_webformsession_webform

Many-To-One Relationship: [adx_webformsession adx_webformsession_webform](adx_webformsession.md#BKMK_adx_webformsession_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformsession`|
|ReferencingAttribute|`adx_webform`|
|ReferencedEntityNavigationPropertyName|`adx_webformsession_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Sessions<br />MenuId: null<br />Order: 103000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webformstep_webform"></a> adx_webformstep_webform

Many-To-One Relationship: [adx_webformstep adx_webformstep_webform](adx_webformstep.md#BKMK_adx_webformstep_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webformstep`|
|ReferencingAttribute|`adx_webform`|
|ReferencedEntityNavigationPropertyName|`adx_webformstep_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Steps<br />MenuId: null<br />Order: 103100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_webpage_webform"></a> adx_webpage_webform

Many-To-One Relationship: [adx_webpage adx_webpage_webform](adx_webpage.md#BKMK_adx_webpage_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_webform`|
|ReferencedEntityNavigationPropertyName|`adx_webpage_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 107000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

