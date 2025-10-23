---
title: "Phone Number (msdyn_ocphonenumber) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Phone Number (msdyn_ocphonenumber) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Phone Number (msdyn_ocphonenumber) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Phone Number (msdyn_ocphonenumber) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_ocphonenumbers<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_TelephonyPhoneNumberPlanUpgradeAction`<br />Event: False |**msdyn_TelephonyPhoneNumberPlanUpgradeAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocphonenumbers<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocphonenumbers(*msdyn_ocphonenumberid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Phone Number (msdyn_ocphonenumber) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Phone Number** |
| **DisplayCollectionName** | **Phone Numbers** |
| **SchemaName** | `msdyn_ocphonenumber` |
| **CollectionSchemaName** | `msdyn_ocphonenumbers` |
| **EntitySetName** | `msdyn_ocphonenumbers`|
| **LogicalName** | `msdyn_ocphonenumber` |
| **LogicalCollectionName** | `msdyn_ocphonenumbers` |
| **PrimaryIdAttribute** | `msdyn_ocphonenumberid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_appmodule](#BKMK_msdyn_appmodule)
- [msdyn_carrierid](#BKMK_msdyn_carrierid)
- [msdyn_countryisocode](#BKMK_msdyn_countryisocode)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Objective](#BKMK_msdyn_Objective)
- [msdyn_occommunicationprovidersettingId](#BKMK_msdyn_occommunicationprovidersettingId)
- [msdyn_ocphonenumberId](#BKMK_msdyn_ocphonenumberId)
- [msdyn_ocphonenumbersource](#BKMK_msdyn_ocphonenumbersource)
- [msdyn_phoneinboundenabled](#BKMK_msdyn_phoneinboundenabled)
- [msdyn_phonenumber](#BKMK_msdyn_phonenumber)
- [msdyn_phonenumbertype](#BKMK_msdyn_phonenumbertype)
- [msdyn_phoneoutboundenabled](#BKMK_msdyn_phoneoutboundenabled)
- [msdyn_smsinboundenabled](#BKMK_msdyn_smsinboundenabled)
- [msdyn_smsoutboundenabled](#BKMK_msdyn_smsoutboundenabled)
- [msdyn_teamsresourceaccount](#BKMK_msdyn_teamsresourceaccount)
- [msdyn_type](#BKMK_msdyn_type)
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

### <a name="BKMK_msdyn_appmodule"></a> msdyn_appmodule

|Property|Value|
|---|---|
|Description|**Application module picklist**|
|DisplayName|**Application module**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_appmodule`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_appmodule`|

#### msdyn_appmodule Choices/Options

|Value|Label|
|---|---|
|192350000|**Service**|

### <a name="BKMK_msdyn_carrierid"></a> msdyn_carrierid

|Property|Value|
|---|---|
|Description|**Carrier associated to the phone number**|
|DisplayName|**Carrier**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_carrierid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occarrier|

### <a name="BKMK_msdyn_countryisocode"></a> msdyn_countryisocode

|Property|Value|
|---|---|
|Description|**ISO code for the country**|
|DisplayName|**Country ISO Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_countryisocode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|3|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Objective"></a> msdyn_Objective

|Property|Value|
|---|---|
|Description|**Objective of the phone number**|
|DisplayName|**Objective**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objective`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_objective`|

#### msdyn_Objective Choices/Options

|Value|Label|
|---|---|
|192350000|**Conversation**|
|192350001|**Lead**|

### <a name="BKMK_msdyn_occommunicationprovidersettingId"></a> msdyn_occommunicationprovidersettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for Communication Provider Setting associated with Phone Number.**|
|DisplayName|**Communication provider setting**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_occommunicationprovidersettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occommunicationprovidersetting|

### <a name="BKMK_msdyn_ocphonenumberId"></a> msdyn_ocphonenumberId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Phone number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocphonenumberid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_ocphonenumbersource"></a> msdyn_ocphonenumbersource

|Property|Value|
|---|---|
|Description|**Source of phone number**|
|DisplayName|**Phone number source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocphonenumbersource`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_ocphonenumbersource`|

#### msdyn_ocphonenumbersource Choices/Options

|Value|Label|
|---|---|
|192350000|**Direct Offer**|
|192350001|**Direct Routing**|

### <a name="BKMK_msdyn_phoneinboundenabled"></a> msdyn_phoneinboundenabled

|Property|Value|
|---|---|
|Description|**Indicates if inbound calling is enabled on the phone number**|
|DisplayName|**Phone Inbound Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phoneinboundenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_phoneinboundenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_phonenumber"></a> msdyn_phonenumber

|Property|Value|
|---|---|
|Description|**The phone number of the phone number entity.**|
|DisplayName|**Phone number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumber`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_phonenumbertype"></a> msdyn_phonenumbertype

|Property|Value|
|---|---|
|Description|**Phone Number Type (TeamsPhoneSystem, Default is ACS)**|
|DisplayName|**Phone Number Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumbertype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_phonenumbertype`|

#### msdyn_phonenumbertype Choices/Options

|Value|Label|
|---|---|
|0|**ACS**|
|1|**Teams**|

### <a name="BKMK_msdyn_phoneoutboundenabled"></a> msdyn_phoneoutboundenabled

|Property|Value|
|---|---|
|Description|**Indicates if inbound calling is enabled on the phone number**|
|DisplayName|**Phone Outbound Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phoneoutboundenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_phoneoutboundenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_smsinboundenabled"></a> msdyn_smsinboundenabled

|Property|Value|
|---|---|
|Description|**Indicates if inbound SMS is enabled on the phonenumber**|
|DisplayName|**SMS Inbound Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_smsinboundenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_smsinboundenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_smsoutboundenabled"></a> msdyn_smsoutboundenabled

|Property|Value|
|---|---|
|Description|**Indicates if outbound SMS is enabled on the phone number**|
|DisplayName|**SMS Outbound Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_smsoutboundenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_smsoutboundenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_teamsresourceaccount"></a> msdyn_teamsresourceaccount

|Property|Value|
|---|---|
|Description|**Microsoft Teams Resource Account Id**|
|DisplayName|**Microsoft Teams Resource Account Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_teamsresourceaccount`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|800|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description|**The phone number type**|
|DisplayName|**Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_ocphonenumber_msdyn_type`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|192350000|**Geo**|
|192350001|**Toll free**|
|192350002|**Short code**|
|192350003|**Mobile number**|

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
|Description|**Status of the phone number**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocphonenumber_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the phone number**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocphonenumber_statuscode`|

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

- [business_unit_msdyn_ocphonenumber](#BKMK_business_unit_msdyn_ocphonenumber)
- [lk_msdyn_ocphonenumber_createdby](#BKMK_lk_msdyn_ocphonenumber_createdby)
- [lk_msdyn_ocphonenumber_createdonbehalfby](#BKMK_lk_msdyn_ocphonenumber_createdonbehalfby)
- [lk_msdyn_ocphonenumber_modifiedby](#BKMK_lk_msdyn_ocphonenumber_modifiedby)
- [lk_msdyn_ocphonenumber_modifiedonbehalfby](#BKMK_lk_msdyn_ocphonenumber_modifiedonbehalfby)
- [msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid](#BKMK_msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid)
- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid)
- [owner_msdyn_ocphonenumber](#BKMK_owner_msdyn_ocphonenumber)
- [team_msdyn_ocphonenumber](#BKMK_team_msdyn_ocphonenumber)
- [user_msdyn_ocphonenumber](#BKMK_user_msdyn_ocphonenumber)

### <a name="BKMK_business_unit_msdyn_ocphonenumber"></a> business_unit_msdyn_ocphonenumber

One-To-Many Relationship: [businessunit business_unit_msdyn_ocphonenumber](businessunit.md#BKMK_business_unit_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocphonenumber_createdby"></a> lk_msdyn_ocphonenumber_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocphonenumber_createdby](systemuser.md#BKMK_lk_msdyn_ocphonenumber_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocphonenumber_createdonbehalfby"></a> lk_msdyn_ocphonenumber_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocphonenumber_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocphonenumber_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocphonenumber_modifiedby"></a> lk_msdyn_ocphonenumber_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocphonenumber_modifiedby](systemuser.md#BKMK_lk_msdyn_ocphonenumber_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocphonenumber_modifiedonbehalfby"></a> lk_msdyn_ocphonenumber_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocphonenumber_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocphonenumber_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid"></a> msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid

One-To-Many Relationship: [msdyn_occarrier msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid](msdyn_occarrier.md#BKMK_msdyn_msdyn_occarrier_msdyn_ocphonenumber_carrierid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occarrier`|
|ReferencedAttribute|`msdyn_occarrierid`|
|ReferencingAttribute|`msdyn_carrierid`|
|ReferencingEntityNavigationPropertyName|`msdyn_carrierid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocphonenumber_communicationprovidersettingid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_communicationprovidersettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocphonenumber"></a> owner_msdyn_ocphonenumber

One-To-Many Relationship: [owner owner_msdyn_ocphonenumber](owner.md#BKMK_owner_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocphonenumber"></a> team_msdyn_ocphonenumber

One-To-Many Relationship: [team team_msdyn_ocphonenumber](team.md#BKMK_team_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocphonenumber"></a> user_msdyn_ocphonenumber

One-To-Many Relationship: [systemuser user_msdyn_ocphonenumber](systemuser.md#BKMK_user_msdyn_ocphonenumber)

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

- [msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)
- [msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid)
- [msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid)
- [msdyn_msdyn_ocphonenumber_systemuser_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_systemuser_phonenumberid)
- [msdyn_ocphonenumber_AsyncOperations](#BKMK_msdyn_ocphonenumber_AsyncOperations)
- [msdyn_ocphonenumber_BulkDeleteFailures](#BKMK_msdyn_ocphonenumber_BulkDeleteFailures)
- [msdyn_ocphonenumber_DuplicateBaseRecord](#BKMK_msdyn_ocphonenumber_DuplicateBaseRecord)
- [msdyn_ocphonenumber_DuplicateMatchingRecord](#BKMK_msdyn_ocphonenumber_DuplicateMatchingRecord)
- [msdyn_ocphonenumber_MailboxTrackingFolders](#BKMK_msdyn_ocphonenumber_MailboxTrackingFolders)
- [msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid](#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid)
- [msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid](#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid)
- [msdyn_ocphonenumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses)
- [msdyn_ocphonenumber_ProcessSession](#BKMK_msdyn_ocphonenumber_ProcessSession)
- [msdyn_ocphonenumber_SyncErrors](#BKMK_msdyn_ocphonenumber_SyncErrors)

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid

Many-To-One Relationship: [msdyn_ocprovisioningstate msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](msdyn_ocprovisioningstate.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocprovisioningstate`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid

Many-To-One Relationship: [msdyn_ocsmschannelsetting msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid](msdyn_ocsmschannelsetting.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsmschannelsetting`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocphonenumber_msdyn_ocsmschannelsetting_phonenumberid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid

Many-To-One Relationship: [msdyn_smsnumber msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid](msdyn_smsnumber.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_smsnumber`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocphonenumber_msdyn_smsnumber_phonenumberid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_systemuser_phonenumberid"></a> msdyn_msdyn_ocphonenumber_systemuser_phonenumberid

Many-To-One Relationship: [systemuser msdyn_msdyn_ocphonenumber_systemuser_phonenumberid](systemuser.md#BKMK_msdyn_msdyn_ocphonenumber_systemuser_phonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`systemuser`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_ocphonenumber_systemuser_phonenumberid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_AsyncOperations"></a> msdyn_ocphonenumber_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocphonenumber_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocphonenumber_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_BulkDeleteFailures"></a> msdyn_ocphonenumber_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocphonenumber_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocphonenumber_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_DuplicateBaseRecord"></a> msdyn_ocphonenumber_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocphonenumber_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocphonenumber_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_DuplicateMatchingRecord"></a> msdyn_ocphonenumber_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocphonenumber_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocphonenumber_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_MailboxTrackingFolders"></a> msdyn_ocphonenumber_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocphonenumber_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocphonenumber_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid"></a> msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid

Many-To-One Relationship: [msdyn_ocvoicechannelsetting msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`msdyn_calleridphonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_calleridphonenumberid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid"></a> msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid

Many-To-One Relationship: [msdyn_ocvoicechannelsetting msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicechannelsetting`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_msdyn_ocvoicechannelsetting_phonenumberid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses"></a> msdyn_ocphonenumber_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocphonenumber_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocphonenumber_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_ProcessSession"></a> msdyn_ocphonenumber_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocphonenumber_ProcessSession](processsession.md#BKMK_msdyn_ocphonenumber_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocphonenumber_SyncErrors"></a> msdyn_ocphonenumber_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocphonenumber_SyncErrors](syncerror.md#BKMK_msdyn_ocphonenumber_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocphonenumber_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

