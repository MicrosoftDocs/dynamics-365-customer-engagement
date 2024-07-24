---
title: "Form (msdynmkt_marketingform) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Form (msdynmkt_marketingform) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Form (msdynmkt_marketingform) table/entity reference



## Messages

The following table lists the messages for the Form (msdynmkt_marketingform) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_marketingforms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_marketingforms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_marketingforms(*msdynmkt_marketingformid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Form (msdynmkt_marketingform) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Form (msdynmkt_marketingform) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Form** |
| **DisplayCollectionName** | **Forms** |
| **SchemaName** | `msdynmkt_marketingform` |
| **CollectionSchemaName** | `msdynmkt_marketingforms` |
| **EntitySetName** | `msdynmkt_marketingforms`|
| **LogicalName** | `msdynmkt_marketingform` |
| **LogicalCollectionName** | `msdynmkt_marketingforms` |
| **PrimaryIdAttribute** | `msdynmkt_marketingformid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdynmkt_compliancesettings4id](#BKMK_msdynmkt_compliancesettings4id)
- [msdynmkt_conditionalcontent](#BKMK_msdynmkt_conditionalcontent)
- [msdynmkt_designerhtml](#BKMK_msdynmkt_designerhtml)
- [msdynmkt_doubleoptintogglemodifiedby](#BKMK_msdynmkt_doubleoptintogglemodifiedby)
- [msdynmkt_doubleoptintogglemodifiedon](#BKMK_msdynmkt_doubleoptintogglemodifiedon)
- [msdynmkt_errormessage](#BKMK_msdynmkt_errormessage)
- [msdynmkt_formhtml](#BKMK_msdynmkt_formhtml)
- [msdynmkt_isdoiforciblydisabled](#BKMK_msdynmkt_isdoiforciblydisabled)
- [msdynmkt_marketingformId](#BKMK_msdynmkt_marketingformId)
- [msdynmkt_marketingformtemplateid](#BKMK_msdynmkt_marketingformtemplateid)
- [msdynmkt_marketingformtype](#BKMK_msdynmkt_marketingformtype)
- [msdynmkt_matchingstrategyid](#BKMK_msdynmkt_matchingstrategyid)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_placeholders](#BKMK_msdynmkt_placeholders)
- [msdynmkt_portalpublishingstatus](#BKMK_msdynmkt_portalpublishingstatus)
- [msdynmkt_portalurl](#BKMK_msdynmkt_portalurl)
- [msdynmkt_redirectenabled](#BKMK_msdynmkt_redirectenabled)
- [msdynmkt_redirecturl](#BKMK_msdynmkt_redirecturl)
- [msdynmkt_standalonehtml](#BKMK_msdynmkt_standalonehtml)
- [msdynmkt_standalonepublishstatus](#BKMK_msdynmkt_standalonepublishstatus)
- [msdynmkt_successmessage](#BKMK_msdynmkt_successmessage)
- [msdynmkt_targetentity](#BKMK_msdynmkt_targetentity)
- [msdynmkt_uniquename](#BKMK_msdynmkt_uniquename)
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

### <a name="BKMK_msdynmkt_compliancesettings4id"></a> msdynmkt_compliancesettings4id

|Property|Value|
|---|---|
|Description|**Unique identifier for Compliance profile associated with Form.**|
|DisplayName|**Compliance profile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_compliancesettings4id`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_compliancesettings4|

### <a name="BKMK_msdynmkt_conditionalcontent"></a> msdynmkt_conditionalcontent

|Property|Value|
|---|---|
|Description||
|DisplayName|**Conditional Content**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_conditionalcontent`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_designerhtml"></a> msdynmkt_designerhtml

|Property|Value|
|---|---|
|Description|**Marked-up HTML used by Form Editor**|
|DisplayName|**Designer HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_designerhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_doubleoptintogglemodifiedby"></a> msdynmkt_doubleoptintogglemodifiedby

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the Is Double Opt-In Forcibly Disabled column.**|
|DisplayName|**Double Opt-In Override Toggle Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doubleoptintogglemodifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdynmkt_doubleoptintogglemodifiedon"></a> msdynmkt_doubleoptintogglemodifiedon

|Property|Value|
|---|---|
|Description|**Date and time when the Is Double Opt-In Forcibly Disabled column was modified.**|
|DisplayName|**Double Opt-In Override Toggle Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_doubleoptintogglemodifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdynmkt_errormessage"></a> msdynmkt_errormessage

|Property|Value|
|---|---|
|Description|**Error message**|
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_errormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_formhtml"></a> msdynmkt_formhtml

|Property|Value|
|---|---|
|Description|**Finilized HTML served to C2**|
|DisplayName|**Form HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_formhtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_isdoiforciblydisabled"></a> msdynmkt_isdoiforciblydisabled

|Property|Value|
|---|---|
|Description|**If yes, Double Opt-In will be disabled for this marketing form, even if the form's compliance profile has Double Opt-In enabled.**|
|DisplayName|**Is Double Opt-In Forcibly Disabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_isdoiforciblydisabled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_doubleoptindetails_msdynmkt_isforciblydisabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_marketingformId"></a> msdynmkt_marketingformId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Form ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_marketingformtemplateid"></a> msdynmkt_marketingformtemplateid

|Property|Value|
|---|---|
|Description|**Form template**|
|DisplayName|**Form template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformtemplateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_marketingformtemplate|

### <a name="BKMK_msdynmkt_marketingformtype"></a> msdynmkt_marketingformtype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Marketing form type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_marketingformtype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120000|
|GlobalChoiceName|`msdynmkt_marketingformtype`|

#### msdynmkt_marketingformtype Choices/Options

|Value|Label|
|---|---|
|534120000|**Marketing form**|
|534120001|**Registration form**|

### <a name="BKMK_msdynmkt_matchingstrategyid"></a> msdynmkt_matchingstrategyid

|Property|Value|
|---|---|
|Description|**Matching Strategy associated with Form.**|
|DisplayName|**Matching Strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_matchingstrategyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_matchingstrategy|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**Name of the Form**|
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

### <a name="BKMK_msdynmkt_placeholders"></a> msdynmkt_placeholders

|Property|Value|
|---|---|
|Description|**Placeholders**|
|DisplayName|**Placeholders**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_placeholders`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500000|

### <a name="BKMK_msdynmkt_portalpublishingstatus"></a> msdynmkt_portalpublishingstatus

|Property|Value|
|---|---|
|Description|**(Deprecated) PortalPublishingStatus - use standalonepublishstatus instead**|
|DisplayName|**(Deprecated) PortalPublishingStatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_portalpublishingstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|534120001|
|GlobalChoiceName|`msdynmkt_marketingform_msdynmkt_portalpublishingstatus`|

#### msdynmkt_portalpublishingstatus Choices/Options

|Value|Label|
|---|---|
|534120001|**NotStarted**|
|534120002|**Publishing**|
|534120003|**Failed**|
|534120004|**Succeeded**|

### <a name="BKMK_msdynmkt_portalurl"></a> msdynmkt_portalurl

|Property|Value|
|---|---|
|Description|**(Deprecated) Portal Url**|
|DisplayName|**(Deprecated) Portal Url**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_portalurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_redirectenabled"></a> msdynmkt_redirectenabled

|Property|Value|
|---|---|
|Description|**Redirect after submission**|
|DisplayName|**Redirect after submission**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_redirectenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdynmkt_marketingform_redirectenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdynmkt_redirecturl"></a> msdynmkt_redirecturl

|Property|Value|
|---|---|
|Description|**Redirect URL**|
|DisplayName|**Redirect URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_redirecturl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdynmkt_standalonehtml"></a> msdynmkt_standalonehtml

|Property|Value|
|---|---|
|Description||
|DisplayName|**Standalone page HTML**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_standalonehtml`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdynmkt_standalonepublishstatus"></a> msdynmkt_standalonepublishstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Standalone page publish status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_standalonepublishstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_msdynmkt_marketingform_msdynmkt_standalonepublishstatus`|

#### msdynmkt_standalonepublishstatus Choices/Options

|Value|Label|
|---|---|
|534120001|**NotStarted**|
|534120002|**InProgress**|
|534120003|**Failed**|
|534120004|**Succeeded**|

### <a name="BKMK_msdynmkt_successmessage"></a> msdynmkt_successmessage

|Property|Value|
|---|---|
|Description|**Thank you message**|
|DisplayName|**Thank you message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_successmessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msdynmkt_targetentity"></a> msdynmkt_targetentity

|Property|Value|
|---|---|
|Description|**Audience**|
|DisplayName|**Audience**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_targetentity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_uniquename"></a> msdynmkt_uniquename

|Property|Value|
|---|---|
|Description|**Unique Name for the entity.**|
|DisplayName|**Unique Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_uniquename`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|128|

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
|Description|**Status of the Form**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingform_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Form**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_marketingform_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **Live**<br />State:0<br />TransitionData: None|
|3|Label: **Live, Editing**<br />State:0<br />TransitionData: None|

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

- [business_unit_msdynmkt_marketingform](#BKMK_business_unit_msdynmkt_marketingform)
- [lk_msdynmkt_marketingform_createdby](#BKMK_lk_msdynmkt_marketingform_createdby)
- [lk_msdynmkt_marketingform_createdonbehalfby](#BKMK_lk_msdynmkt_marketingform_createdonbehalfby)
- [lk_msdynmkt_marketingform_modifiedby](#BKMK_lk_msdynmkt_marketingform_modifiedby)
- [lk_msdynmkt_marketingform_modifiedonbehalfby](#BKMK_lk_msdynmkt_marketingform_modifiedonbehalfby)
- [msdynmkt_compliancesettings4_marketingform](#BKMK_msdynmkt_compliancesettings4_marketingform)
- [msdynmkt_marketingform_doubleoptintogglemodifiedby](#BKMK_msdynmkt_marketingform_doubleoptintogglemodifiedby)
- [msdynmkt_marketingformtemplate_marketingform](#BKMK_msdynmkt_marketingformtemplate_marketingform)
- [msdynmkt_matchingstrategy_marketingform](#BKMK_msdynmkt_matchingstrategy_marketingform)
- [owner_msdynmkt_marketingform](#BKMK_owner_msdynmkt_marketingform)
- [team_msdynmkt_marketingform](#BKMK_team_msdynmkt_marketingform)
- [user_msdynmkt_marketingform](#BKMK_user_msdynmkt_marketingform)

### <a name="BKMK_business_unit_msdynmkt_marketingform"></a> business_unit_msdynmkt_marketingform

One-To-Many Relationship: [businessunit business_unit_msdynmkt_marketingform](businessunit.md#BKMK_business_unit_msdynmkt_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingform_createdby"></a> lk_msdynmkt_marketingform_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingform_createdby](systemuser.md#BKMK_lk_msdynmkt_marketingform_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingform_createdonbehalfby"></a> lk_msdynmkt_marketingform_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingform_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingform_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingform_modifiedby"></a> lk_msdynmkt_marketingform_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingform_modifiedby](systemuser.md#BKMK_lk_msdynmkt_marketingform_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_marketingform_modifiedonbehalfby"></a> lk_msdynmkt_marketingform_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_marketingform_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_marketingform_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_compliancesettings4_marketingform"></a> msdynmkt_compliancesettings4_marketingform

One-To-Many Relationship: [msdynmkt_compliancesettings4 msdynmkt_compliancesettings4_marketingform](msdynmkt_compliancesettings4.md#BKMK_msdynmkt_compliancesettings4_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_compliancesettings4`|
|ReferencedAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingAttribute|`msdynmkt_compliancesettings4id`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_compliancesettings4id`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_marketingform_doubleoptintogglemodifiedby"></a> msdynmkt_marketingform_doubleoptintogglemodifiedby

One-To-Many Relationship: [systemuser msdynmkt_marketingform_doubleoptintogglemodifiedby](systemuser.md#BKMK_msdynmkt_marketingform_doubleoptintogglemodifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdynmkt_doubleoptintogglemodifiedby`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_doubleoptintogglemodifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_marketingformtemplate_marketingform"></a> msdynmkt_marketingformtemplate_marketingform

One-To-Many Relationship: [msdynmkt_marketingformtemplate msdynmkt_marketingformtemplate_marketingform](msdynmkt_marketingformtemplate.md#BKMK_msdynmkt_marketingformtemplate_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_marketingformtemplate`|
|ReferencedAttribute|`msdynmkt_marketingformtemplateid`|
|ReferencingAttribute|`msdynmkt_marketingformtemplateid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_marketingformtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_matchingstrategy_marketingform"></a> msdynmkt_matchingstrategy_marketingform

One-To-Many Relationship: [msdynmkt_matchingstrategy msdynmkt_matchingstrategy_marketingform](msdynmkt_matchingstrategy.md#BKMK_msdynmkt_matchingstrategy_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_matchingstrategy`|
|ReferencedAttribute|`msdynmkt_matchingstrategyid`|
|ReferencingAttribute|`msdynmkt_matchingstrategyid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_matchingstrategyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_marketingform"></a> owner_msdynmkt_marketingform

One-To-Many Relationship: [owner owner_msdynmkt_marketingform](owner.md#BKMK_owner_msdynmkt_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_marketingform"></a> team_msdynmkt_marketingform

One-To-Many Relationship: [team team_msdynmkt_marketingform](team.md#BKMK_team_msdynmkt_marketingform)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_marketingform"></a> user_msdynmkt_marketingform

One-To-Many Relationship: [systemuser user_msdynmkt_marketingform](systemuser.md#BKMK_user_msdynmkt_marketingform)

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

- [msdynmkt_marketingform_AsyncOperations](#BKMK_msdynmkt_marketingform_AsyncOperations)
- [msdynmkt_marketingform_BulkDeleteFailures](#BKMK_msdynmkt_marketingform_BulkDeleteFailures)
- [msdynmkt_marketingform_MailboxTrackingFolders](#BKMK_msdynmkt_marketingform_MailboxTrackingFolders)
- [msdynmkt_marketingform_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_marketingform_PrincipalObjectAttributeAccesses)
- [msdynmkt_marketingform_ProcessSession](#BKMK_msdynmkt_marketingform_ProcessSession)
- [msdynmkt_marketingform_SyncErrors](#BKMK_msdynmkt_marketingform_SyncErrors)
- [msdynmkt_marketingformsubmission_marketingform](#BKMK_msdynmkt_marketingformsubmission_marketingform)
- [msdynmkt_msdynmkt_marketingform_contact_marketingformid](#BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid)
- [msdynmkt_msdynmkt_marketingform_lead_marketingformid](#BKMK_msdynmkt_msdynmkt_marketingform_lead_marketingformid)
- [msevtmgt_msdynmkt_marketingform_msevtmgt_event](#BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event)

### <a name="BKMK_msdynmkt_marketingform_AsyncOperations"></a> msdynmkt_marketingform_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_marketingform_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_marketingform_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingform_BulkDeleteFailures"></a> msdynmkt_marketingform_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_marketingform_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_marketingform_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingform_MailboxTrackingFolders"></a> msdynmkt_marketingform_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_marketingform_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_marketingform_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingform_PrincipalObjectAttributeAccesses"></a> msdynmkt_marketingform_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_marketingform_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_marketingform_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingform_ProcessSession"></a> msdynmkt_marketingform_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_marketingform_ProcessSession](processsession.md#BKMK_msdynmkt_marketingform_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingform_SyncErrors"></a> msdynmkt_marketingform_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_marketingform_SyncErrors](syncerror.md#BKMK_msdynmkt_marketingform_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingform_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_marketingformsubmission_marketingform"></a> msdynmkt_marketingformsubmission_marketingform

Many-To-One Relationship: [msdynmkt_marketingformsubmission msdynmkt_marketingformsubmission_marketingform](msdynmkt_marketingformsubmission.md#BKMK_msdynmkt_marketingformsubmission_marketingform)

|Property|Value|
|---|---|
|ReferencingEntity|`msdynmkt_marketingformsubmission`|
|ReferencingAttribute|`msdynmkt_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_marketingformsubmission_marketingform`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid"></a> msdynmkt_msdynmkt_marketingform_contact_marketingformid

Many-To-One Relationship: [contact msdynmkt_msdynmkt_marketingform_contact_marketingformid](contact.md#BKMK_msdynmkt_msdynmkt_marketingform_contact_marketingformid)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`msdynmkt_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_marketingform_contact_marketingformid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_msdynmkt_marketingform_lead_marketingformid"></a> msdynmkt_msdynmkt_marketingform_lead_marketingformid

Many-To-One Relationship: [lead msdynmkt_msdynmkt_marketingform_lead_marketingformid](lead.md#BKMK_msdynmkt_msdynmkt_marketingform_lead_marketingformid)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`msdynmkt_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_msdynmkt_marketingform_lead_marketingformid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event"></a> msevtmgt_msdynmkt_marketingform_msevtmgt_event

Many-To-One Relationship: [msevtmgt_event msevtmgt_msdynmkt_marketingform_msevtmgt_event](msevtmgt_event.md#BKMK_msevtmgt_msdynmkt_marketingform_msevtmgt_event)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_marketingformid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msdynmkt_marketingform_msevtmgt_event`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

