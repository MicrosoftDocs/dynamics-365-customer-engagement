---
title: "Website (Adx_website) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Website (Adx_website) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Website (Adx_website) table/entity reference

Web Portal

## Messages

The following table lists the messages for the Website (Adx_website) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /adx_websites(*adx_websiteid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /adx_websites<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /adx_websites(*adx_websiteid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /adx_websites(*adx_websiteid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /adx_websites<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /adx_websites(*adx_websiteid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /adx_websites(*adx_websiteid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /adx_websites(*adx_websiteid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Website (Adx_website) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Website (Adx_website) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Website** |
| **DisplayCollectionName** | **Websites** |
| **SchemaName** | `Adx_website` |
| **CollectionSchemaName** | `Adx_websites` |
| **EntitySetName** | `adx_websites`|
| **LogicalName** | `adx_website` |
| **LogicalCollectionName** | `adx_websites` |
| **PrimaryIdAttribute** | `adx_websiteid` |
| **PrimaryNameAttribute** |`adx_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [adx_defaultbotconsumerid](#BKMK_adx_defaultbotconsumerid)
- [adx_DefaultLanguage](#BKMK_adx_DefaultLanguage)
- [adx_footerwebtemplateid](#BKMK_adx_footerwebtemplateid)
- [adx_headerwebtemplateid](#BKMK_adx_headerwebtemplateid)
- [Adx_name](#BKMK_Adx_name)
- [adx_parentwebsiteid](#BKMK_adx_parentwebsiteid)
- [Adx_PartialUrl](#BKMK_Adx_PartialUrl)
- [adx_primarydomainname](#BKMK_adx_primarydomainname)
- [adx_website_language](#BKMK_adx_website_language)
- [adx_website_version](#BKMK_adx_website_version)
- [Adx_websiteId](#BKMK_Adx_websiteId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_adx_defaultbotconsumerid"></a> adx_defaultbotconsumerid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Bot Consumer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_defaultbotconsumerid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_botconsumer|

### <a name="BKMK_adx_DefaultLanguage"></a> adx_DefaultLanguage

|Property|Value|
|---|---|
|Description|**Lookup to Website Language - the current default language of the website**|
|DisplayName|**Default Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_defaultlanguage`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|adx_websitelanguage|

### <a name="BKMK_adx_footerwebtemplateid"></a> adx_footerwebtemplateid

|Property|Value|
|---|---|
|Description|**Web Template to use as Website footer content.**|
|DisplayName|**Footer Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_footerwebtemplateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webtemplate|

### <a name="BKMK_adx_headerwebtemplateid"></a> adx_headerwebtemplateid

|Property|Value|
|---|---|
|Description|**Web Template to use as Website header content.**|
|DisplayName|**Header Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_headerwebtemplateid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_webtemplate|

### <a name="BKMK_Adx_name"></a> Adx_name

|Property|Value|
|---|---|
|Description|**Shows the name of the custom entity.**|
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
|MaxLength|100|

### <a name="BKMK_adx_parentwebsiteid"></a> adx_parentwebsiteid

|Property|Value|
|---|---|
|Description|**Unique identifier for Website associated with Website.**|
|DisplayName|**Parent Website**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_parentwebsiteid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|adx_website|

### <a name="BKMK_Adx_PartialUrl"></a> Adx_PartialUrl

|Property|Value|
|---|---|
|Description||
|DisplayName|**Partial URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_partialurl`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_adx_primarydomainname"></a> adx_primarydomainname

|Property|Value|
|---|---|
|Description|**Tracks the primary domain name of the Portal**|
|DisplayName|**Primary Domain Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_primarydomainname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|253|

### <a name="BKMK_adx_website_language"></a> adx_website_language

|Property|Value|
|---|---|
|Description||
|DisplayName|**Language**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_website_language`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_adx_website_version"></a> adx_website_version

|Property|Value|
|---|---|
|Description|**Version of the website record**|
|DisplayName|**Website Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`adx_website_version`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_Adx_websiteId"></a> Adx_websiteId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Website**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`adx_websiteid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Shows when the record was migrated.**|
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
|Description|**Shows the owner ID.**|
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
|Description|**Status of the Website**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`adx_website_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Website**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`adx_website_statuscode`|

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
|Description|**Shows the user who created the record.**|
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
|Description|**Shows when the record was created.**|
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
|Description|**Shows the user who updated the record.**|
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
|Description|**Shows when the record was updated.**|
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

- [adx_adx_botconsumer_adx_website_botconsumerid](#BKMK_adx_adx_botconsumer_adx_website_botconsumerid)
- [adx_adx_websitelanguage_adx_website_DefaultLanguage](#BKMK_adx_adx_websitelanguage_adx_website_DefaultLanguage)
- [adx_website_parentwebsite](#BKMK_adx_website_parentwebsite-many-to-one)
- [adx_webtemplate_website_footer](#BKMK_adx_webtemplate_website_footer)
- [adx_webtemplate_website_header](#BKMK_adx_webtemplate_website_header)
- [business_unit_adx_website](#BKMK_business_unit_adx_website)
- [lk_adx_website_createdby](#BKMK_lk_adx_website_createdby)
- [lk_adx_website_createdonbehalfby](#BKMK_lk_adx_website_createdonbehalfby)
- [lk_adx_website_modifiedby](#BKMK_lk_adx_website_modifiedby)
- [lk_adx_website_modifiedonbehalfby](#BKMK_lk_adx_website_modifiedonbehalfby)
- [owner_adx_website](#BKMK_owner_adx_website)
- [team_adx_website](#BKMK_team_adx_website)
- [user_adx_website](#BKMK_user_adx_website)

### <a name="BKMK_adx_adx_botconsumer_adx_website_botconsumerid"></a> adx_adx_botconsumer_adx_website_botconsumerid

One-To-Many Relationship: [adx_botconsumer adx_adx_botconsumer_adx_website_botconsumerid](adx_botconsumer.md#BKMK_adx_adx_botconsumer_adx_website_botconsumerid)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_botconsumer`|
|ReferencedAttribute|`adx_botconsumerid`|
|ReferencingAttribute|`adx_defaultbotconsumerid`|
|ReferencingEntityNavigationPropertyName|`adx_defaultbotconsumerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_adx_websitelanguage_adx_website_DefaultLanguage"></a> adx_adx_websitelanguage_adx_website_DefaultLanguage

One-To-Many Relationship: [adx_websitelanguage adx_adx_websitelanguage_adx_website_DefaultLanguage](adx_websitelanguage.md#BKMK_adx_adx_websitelanguage_adx_website_DefaultLanguage)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_websitelanguage`|
|ReferencedAttribute|`adx_websitelanguageid`|
|ReferencingAttribute|`adx_defaultlanguage`|
|ReferencingEntityNavigationPropertyName|`adx_DefaultLanguage`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_website_parentwebsite-many-to-one"></a> adx_website_parentwebsite

One-To-Many Relationship: [adx_website adx_website_parentwebsite](#BKMK_adx_website_parentwebsite-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_website`|
|ReferencedAttribute|`adx_websiteid`|
|ReferencingAttribute|`adx_parentwebsiteid`|
|ReferencingEntityNavigationPropertyName|`adx_parentwebsiteid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webtemplate_website_footer"></a> adx_webtemplate_website_footer

One-To-Many Relationship: [adx_webtemplate adx_webtemplate_website_footer](adx_webtemplate.md#BKMK_adx_webtemplate_website_footer)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webtemplate`|
|ReferencedAttribute|`adx_webtemplateid`|
|ReferencingAttribute|`adx_footerwebtemplateid`|
|ReferencingEntityNavigationPropertyName|`adx_footerwebtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_adx_webtemplate_website_header"></a> adx_webtemplate_website_header

One-To-Many Relationship: [adx_webtemplate adx_webtemplate_website_header](adx_webtemplate.md#BKMK_adx_webtemplate_website_header)

|Property|Value|
|---|---|
|ReferencedEntity|`adx_webtemplate`|
|ReferencedAttribute|`adx_webtemplateid`|
|ReferencingAttribute|`adx_headerwebtemplateid`|
|ReferencingEntityNavigationPropertyName|`adx_headerwebtemplateid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_business_unit_adx_website"></a> business_unit_adx_website

One-To-Many Relationship: [businessunit business_unit_adx_website](businessunit.md#BKMK_business_unit_adx_website)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_website_createdby"></a> lk_adx_website_createdby

One-To-Many Relationship: [systemuser lk_adx_website_createdby](systemuser.md#BKMK_lk_adx_website_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_website_createdonbehalfby"></a> lk_adx_website_createdonbehalfby

One-To-Many Relationship: [systemuser lk_adx_website_createdonbehalfby](systemuser.md#BKMK_lk_adx_website_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_website_modifiedby"></a> lk_adx_website_modifiedby

One-To-Many Relationship: [systemuser lk_adx_website_modifiedby](systemuser.md#BKMK_lk_adx_website_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_adx_website_modifiedonbehalfby"></a> lk_adx_website_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_adx_website_modifiedonbehalfby](systemuser.md#BKMK_lk_adx_website_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_adx_website"></a> owner_adx_website

One-To-Many Relationship: [owner owner_adx_website](owner.md#BKMK_owner_adx_website)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_adx_website"></a> team_adx_website

One-To-Many Relationship: [team team_adx_website](team.md#BKMK_team_adx_website)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_adx_website"></a> user_adx_website

One-To-Many Relationship: [systemuser user_adx_website](systemuser.md#BKMK_user_adx_website)

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

- [adx_adx_cloudflowconsumer_websiteid_adx_websi](#BKMK_adx_adx_cloudflowconsumer_websiteid_adx_websi)
- [adx_adx_website_adx_botconsumer_websiteid](#BKMK_adx_adx_website_adx_botconsumer_websiteid)
- [adx_adx_website_adx_websitelanguage](#BKMK_adx_adx_website_adx_websitelanguage)
- [adx_columnpermissionprofile_website](#BKMK_adx_columnpermissionprofile_website)
- [adx_invitation_website](#BKMK_adx_invitation_website)
- [adx_website_ActivityPointers](#BKMK_adx_website_ActivityPointers)
- [adx_website_ad](#BKMK_adx_website_ad)
- [adx_website_adplacement](#BKMK_adx_website_adplacement)
- [adx_website_adx_alertsubscriptions](#BKMK_adx_website_adx_alertsubscriptions)
- [adx_website_adx_entitypermission](#BKMK_adx_website_adx_entitypermission)
- [adx_website_adx_inviteredemptions](#BKMK_adx_website_adx_inviteredemptions)
- [adx_website_adx_portalcomments](#BKMK_adx_website_adx_portalcomments)
- [adx_website_adx_webtemplate](#BKMK_adx_website_adx_webtemplate)
- [adx_website_Annotations](#BKMK_adx_website_Annotations)
- [adx_website_Appointments](#BKMK_adx_website_Appointments)
- [adx_website_AsyncOperations](#BKMK_adx_website_AsyncOperations)
- [adx_website_BulkDeleteFailures](#BKMK_adx_website_BulkDeleteFailures)
- [adx_website_chats](#BKMK_adx_website_chats)
- [adx_website_communityforum](#BKMK_adx_website_communityforum)
- [adx_website_connections1](#BKMK_adx_website_connections1)
- [adx_website_connections2](#BKMK_adx_website_connections2)
- [adx_website_contentsnippet](#BKMK_adx_website_contentsnippet)
- [adx_website_DuplicateBaseRecord](#BKMK_adx_website_DuplicateBaseRecord)
- [adx_website_DuplicateMatchingRecord](#BKMK_adx_website_DuplicateMatchingRecord)
- [adx_website_Emails](#BKMK_adx_website_Emails)
- [adx_website_entityform](#BKMK_adx_website_entityform)
- [adx_website_entitylist](#BKMK_adx_website_entitylist)
- [adx_website_Faxes](#BKMK_adx_website_Faxes)
- [adx_website_forumnotification](#BKMK_adx_website_forumnotification)
- [adx_website_forumthreadtype](#BKMK_adx_website_forumthreadtype)
- [adx_website_Letters](#BKMK_adx_website_Letters)
- [adx_website_li_inmails](#BKMK_adx_website_li_inmails)
- [adx_website_li_messages](#BKMK_adx_website_li_messages)
- [adx_website_li_pointdrivepresentationvieweds](#BKMK_adx_website_li_pointdrivepresentationvieweds)
- [adx_website_MailboxTrackingFolders](#BKMK_adx_website_MailboxTrackingFolders)
- [adx_website_msdyn_bookingalerts](#BKMK_adx_website_msdyn_bookingalerts)
- [adx_website_msdyn_copilottranscripts](#BKMK_adx_website_msdyn_copilottranscripts)
- [adx_website_msdyn_ocliveworkitems](#BKMK_adx_website_msdyn_ocliveworkitems)
- [adx_website_msdyn_ocoutboundmessages](#BKMK_adx_website_msdyn_ocoutboundmessages)
- [adx_website_msdyn_ocsessions](#BKMK_adx_website_msdyn_ocsessions)
- [adx_website_msdyn_ocvoicemails](#BKMK_adx_website_msdyn_ocvoicemails)
- [adx_website_msfp_alerts](#BKMK_adx_website_msfp_alerts)
- [adx_website_msfp_surveyinvites](#BKMK_adx_website_msfp_surveyinvites)
- [adx_website_msfp_surveyresponses](#BKMK_adx_website_msfp_surveyresponses)
- [adx_website_pagenotification](#BKMK_adx_website_pagenotification)
- [adx_website_pagetag](#BKMK_adx_website_pagetag)
- [adx_website_pagetemplate](#BKMK_adx_website_pagetemplate)
- [adx_website_parentwebsite](#BKMK_adx_website_parentwebsite-one-to-many)
- [adx_website_PhoneCalls](#BKMK_adx_website_PhoneCalls)
- [adx_website_poll](#BKMK_adx_website_poll)
- [adx_website_pollplacement](#BKMK_adx_website_pollplacement)
- [adx_website_PrincipalObjectAttributeAccesses](#BKMK_adx_website_PrincipalObjectAttributeAccesses)
- [adx_website_ProcessSession](#BKMK_adx_website_ProcessSession)
- [adx_website_publishingstate](#BKMK_adx_website_publishingstate)
- [adx_website_publishingstatetransition](#BKMK_adx_website_publishingstatetransition)
- [adx_website_RecurringAppointmentMasters](#BKMK_adx_website_RecurringAppointmentMasters)
- [adx_website_redirect](#BKMK_adx_website_redirect)
- [adx_website_ServiceAppointments](#BKMK_adx_website_ServiceAppointments)
- [adx_website_SharePointDocumentLocations](#BKMK_adx_website_SharePointDocumentLocations)
- [adx_website_shortcut](#BKMK_adx_website_shortcut)
- [adx_website_sitemarker](#BKMK_adx_website_sitemarker)
- [adx_website_sitesetting](#BKMK_adx_website_sitesetting)
- [adx_website_SocialActivities](#BKMK_adx_website_SocialActivities)
- [adx_website_SyncErrors](#BKMK_adx_website_SyncErrors)
- [adx_website_tag](#BKMK_adx_website_tag)
- [adx_website_Tasks](#BKMK_adx_website_Tasks)
- [adx_website_urlhistory](#BKMK_adx_website_urlhistory)
- [adx_website_webfile](#BKMK_adx_website_webfile)
- [adx_website_webform](#BKMK_adx_website_webform)
- [adx_website_weblinkset](#BKMK_adx_website_weblinkset)
- [adx_website_webpage](#BKMK_adx_website_webpage)
- [adx_website_webpageaccesscontrolrule](#BKMK_adx_website_webpageaccesscontrolrule)
- [adx_website_webrole](#BKMK_adx_website_webrole)
- [adx_website_websiteaccess](#BKMK_adx_website_websiteaccess)
- [adx_website_websitebinding](#BKMK_adx_website_websitebinding)
- [adx_websitemigrationtracker_adx_website](#BKMK_adx_websitemigrationtracker_adx_website)

### <a name="BKMK_adx_adx_cloudflowconsumer_websiteid_adx_websi"></a> adx_adx_cloudflowconsumer_websiteid_adx_websi

Many-To-One Relationship: [adx_cloudflowconsumer adx_adx_cloudflowconsumer_websiteid_adx_websi](adx_cloudflowconsumer.md#BKMK_adx_adx_cloudflowconsumer_websiteid_adx_websi)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_cloudflowconsumer`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_adx_cloudflowconsumer_websiteid_adx_websi`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_adx_website_adx_botconsumer_websiteid"></a> adx_adx_website_adx_botconsumer_websiteid

Many-To-One Relationship: [adx_botconsumer adx_adx_website_adx_botconsumer_websiteid](adx_botconsumer.md#BKMK_adx_adx_website_adx_botconsumer_websiteid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_botconsumer`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_adx_website_adx_botconsumer_websiteid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_adx_website_adx_websitelanguage"></a> adx_adx_website_adx_websitelanguage

Many-To-One Relationship: [adx_websitelanguage adx_adx_website_adx_websitelanguage](adx_websitelanguage.md#BKMK_adx_adx_website_adx_websitelanguage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitelanguage`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_adx_website_adx_websitelanguage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_columnpermissionprofile_website"></a> adx_columnpermissionprofile_website

Many-To-One Relationship: [adx_columnpermissionprofile adx_columnpermissionprofile_website](adx_columnpermissionprofile.md#BKMK_adx_columnpermissionprofile_website)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_columnpermissionprofile`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_columnpermissionprofile_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_invitation_website"></a> adx_invitation_website

Many-To-One Relationship: [adx_invitation adx_invitation_website](adx_invitation.md#BKMK_adx_invitation_website)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_invitation`|
|ReferencingAttribute|`adx_website`|
|ReferencedEntityNavigationPropertyName|`adx_invitation_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_ActivityPointers"></a> adx_website_ActivityPointers

Many-To-One Relationship: [activitypointer adx_website_ActivityPointers](activitypointer.md#BKMK_adx_website_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_ad"></a> adx_website_ad

Many-To-One Relationship: [adx_ad adx_website_ad](adx_ad.md#BKMK_adx_website_ad)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_ad`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_ad`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adplacement"></a> adx_website_adplacement

Many-To-One Relationship: [adx_adplacement adx_website_adplacement](adx_adplacement.md#BKMK_adx_website_adplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_adplacement`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adx_alertsubscriptions"></a> adx_website_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription adx_website_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_adx_website_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adx_entitypermission"></a> adx_website_adx_entitypermission

Many-To-One Relationship: [adx_entitypermission adx_website_adx_entitypermission](adx_entitypermission.md#BKMK_adx_website_adx_entitypermission)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entitypermission`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adx_entitypermission`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adx_inviteredemptions"></a> adx_website_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption adx_website_adx_inviteredemptions](adx_inviteredemption.md#BKMK_adx_website_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adx_portalcomments"></a> adx_website_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment adx_website_adx_portalcomments](adx_portalcomment.md#BKMK_adx_website_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_adx_webtemplate"></a> adx_website_adx_webtemplate

Many-To-One Relationship: [adx_webtemplate adx_website_adx_webtemplate](adx_webtemplate.md#BKMK_adx_website_adx_webtemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webtemplate`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_adx_webtemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Annotations"></a> adx_website_Annotations

Many-To-One Relationship: [annotation adx_website_Annotations](annotation.md#BKMK_adx_website_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Appointments"></a> adx_website_Appointments

Many-To-One Relationship: [appointment adx_website_Appointments](appointment.md#BKMK_adx_website_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_AsyncOperations"></a> adx_website_AsyncOperations

Many-To-One Relationship: [asyncoperation adx_website_AsyncOperations](asyncoperation.md#BKMK_adx_website_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_BulkDeleteFailures"></a> adx_website_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure adx_website_BulkDeleteFailures](bulkdeletefailure.md#BKMK_adx_website_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_chats"></a> adx_website_chats

Many-To-One Relationship: [chat adx_website_chats](chat.md#BKMK_adx_website_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_communityforum"></a> adx_website_communityforum

Many-To-One Relationship: [adx_communityforum adx_website_communityforum](adx_communityforum.md#BKMK_adx_website_communityforum)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_communityforum`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_communityforum`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_connections1"></a> adx_website_connections1

Many-To-One Relationship: [connection adx_website_connections1](connection.md#BKMK_adx_website_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`adx_website_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_connections2"></a> adx_website_connections2

Many-To-One Relationship: [connection adx_website_connections2](connection.md#BKMK_adx_website_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`adx_website_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_contentsnippet"></a> adx_website_contentsnippet

Many-To-One Relationship: [adx_contentsnippet adx_website_contentsnippet](adx_contentsnippet.md#BKMK_adx_website_contentsnippet)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_contentsnippet`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_contentsnippet`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100700<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_DuplicateBaseRecord"></a> adx_website_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord adx_website_DuplicateBaseRecord](duplicaterecord.md#BKMK_adx_website_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`adx_website_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_DuplicateMatchingRecord"></a> adx_website_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord adx_website_DuplicateMatchingRecord](duplicaterecord.md#BKMK_adx_website_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`adx_website_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Emails"></a> adx_website_Emails

Many-To-One Relationship: [email adx_website_Emails](email.md#BKMK_adx_website_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_entityform"></a> adx_website_entityform

Many-To-One Relationship: [adx_entityform adx_website_entityform](adx_entityform.md#BKMK_adx_website_entityform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entityform`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_entityform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_entitylist"></a> adx_website_entitylist

Many-To-One Relationship: [adx_entitylist adx_website_entitylist](adx_entitylist.md#BKMK_adx_website_entitylist)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_entitylist`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_entitylist`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Faxes"></a> adx_website_Faxes

Many-To-One Relationship: [fax adx_website_Faxes](fax.md#BKMK_adx_website_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_forumnotification"></a> adx_website_forumnotification

Many-To-One Relationship: [adx_forumnotification adx_website_forumnotification](adx_forumnotification.md#BKMK_adx_website_forumnotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumnotification`|
|ReferencingAttribute|`adx_website`|
|ReferencedEntityNavigationPropertyName|`adx_website_forumnotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_forumthreadtype"></a> adx_website_forumthreadtype

Many-To-One Relationship: [adx_forumthreadtype adx_website_forumthreadtype](adx_forumthreadtype.md#BKMK_adx_website_forumthreadtype)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_forumthreadtype`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_forumthreadtype`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 101400<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Letters"></a> adx_website_Letters

Many-To-One Relationship: [letter adx_website_Letters](letter.md#BKMK_adx_website_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_li_inmails"></a> adx_website_li_inmails

Many-To-One Relationship: [li_inmail adx_website_li_inmails](li_inmail.md#BKMK_adx_website_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_li_messages"></a> adx_website_li_messages

Many-To-One Relationship: [li_message adx_website_li_messages](li_message.md#BKMK_adx_website_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_li_pointdrivepresentationvieweds"></a> adx_website_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed adx_website_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_adx_website_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_MailboxTrackingFolders"></a> adx_website_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder adx_website_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_adx_website_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_bookingalerts"></a> adx_website_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert adx_website_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_adx_website_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_copilottranscripts"></a> adx_website_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript adx_website_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_adx_website_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_ocliveworkitems"></a> adx_website_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem adx_website_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_adx_website_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_ocoutboundmessages"></a> adx_website_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage adx_website_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_adx_website_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_ocsessions"></a> adx_website_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession adx_website_msdyn_ocsessions](msdyn_ocsession.md#BKMK_adx_website_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msdyn_ocvoicemails"></a> adx_website_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail adx_website_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_adx_website_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msfp_alerts"></a> adx_website_msfp_alerts

Many-To-One Relationship: [msfp_alert adx_website_msfp_alerts](msfp_alert.md#BKMK_adx_website_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msfp_surveyinvites"></a> adx_website_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite adx_website_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_adx_website_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_msfp_surveyresponses"></a> adx_website_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse adx_website_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_adx_website_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_pagenotification"></a> adx_website_pagenotification

Many-To-One Relationship: [adx_pagenotification adx_website_pagenotification](adx_pagenotification.md#BKMK_adx_website_pagenotification)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagenotification`|
|ReferencingAttribute|`adx_website`|
|ReferencedEntityNavigationPropertyName|`adx_website_pagenotification`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_pagetag"></a> adx_website_pagetag

Many-To-One Relationship: [adx_pagetag adx_website_pagetag](adx_pagetag.md#BKMK_adx_website_pagetag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetag`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_pagetag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_pagetemplate"></a> adx_website_pagetemplate

Many-To-One Relationship: [adx_pagetemplate adx_website_pagetemplate](adx_pagetemplate.md#BKMK_adx_website_pagetemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pagetemplate`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_pagetemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_parentwebsite-one-to-many"></a> adx_website_parentwebsite

Many-To-One Relationship: [adx_website adx_website_parentwebsite](#BKMK_adx_website_parentwebsite-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_website`|
|ReferencingAttribute|`adx_parentwebsiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_parentwebsite`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Child Websites<br />MenuId: null<br />Order: 100500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_PhoneCalls"></a> adx_website_PhoneCalls

Many-To-One Relationship: [phonecall adx_website_PhoneCalls](phonecall.md#BKMK_adx_website_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_poll"></a> adx_website_poll

Many-To-One Relationship: [adx_poll adx_website_poll](adx_poll.md#BKMK_adx_website_poll)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_poll`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_poll`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_pollplacement"></a> adx_website_pollplacement

Many-To-One Relationship: [adx_pollplacement adx_website_pollplacement](adx_pollplacement.md#BKMK_adx_website_pollplacement)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_pollplacement`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_pollplacement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_PrincipalObjectAttributeAccesses"></a> adx_website_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess adx_website_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_adx_website_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_ProcessSession"></a> adx_website_ProcessSession

Many-To-One Relationship: [processsession adx_website_ProcessSession](processsession.md#BKMK_adx_website_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_publishingstate"></a> adx_website_publishingstate

Many-To-One Relationship: [adx_publishingstate adx_website_publishingstate](adx_publishingstate.md#BKMK_adx_website_publishingstate)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstate`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_publishingstate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_publishingstatetransition"></a> adx_website_publishingstatetransition

Many-To-One Relationship: [adx_publishingstatetransitionrule adx_website_publishingstatetransition](adx_publishingstatetransitionrule.md#BKMK_adx_website_publishingstatetransition)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_publishingstatetransitionrule`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_publishingstatetransition`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102400<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_RecurringAppointmentMasters"></a> adx_website_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster adx_website_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_adx_website_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_redirect"></a> adx_website_redirect

Many-To-One Relationship: [adx_redirect adx_website_redirect](adx_redirect.md#BKMK_adx_website_redirect)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_redirect`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_redirect`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102600<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_ServiceAppointments"></a> adx_website_ServiceAppointments

Many-To-One Relationship: [serviceappointment adx_website_ServiceAppointments](serviceappointment.md#BKMK_adx_website_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_SharePointDocumentLocations"></a> adx_website_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation adx_website_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_adx_website_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_shortcut"></a> adx_website_shortcut

Many-To-One Relationship: [adx_shortcut adx_website_shortcut](adx_shortcut.md#BKMK_adx_website_shortcut)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_shortcut`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_shortcut`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102700<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_sitemarker"></a> adx_website_sitemarker

Many-To-One Relationship: [adx_sitemarker adx_website_sitemarker](adx_sitemarker.md#BKMK_adx_website_sitemarker)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitemarker`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_sitemarker`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102800<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_sitesetting"></a> adx_website_sitesetting

Many-To-One Relationship: [adx_sitesetting adx_website_sitesetting](adx_sitesetting.md#BKMK_adx_website_sitesetting)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_sitesetting`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_sitesetting`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 102900<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_SocialActivities"></a> adx_website_SocialActivities

Many-To-One Relationship: [socialactivity adx_website_SocialActivities](socialactivity.md#BKMK_adx_website_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_SyncErrors"></a> adx_website_SyncErrors

Many-To-One Relationship: [syncerror adx_website_SyncErrors](syncerror.md#BKMK_adx_website_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_tag"></a> adx_website_tag

Many-To-One Relationship: [adx_tag adx_website_tag](adx_tag.md#BKMK_adx_website_tag)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_tag`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_tag`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_Tasks"></a> adx_website_Tasks

Many-To-One Relationship: [task adx_website_Tasks](task.md#BKMK_adx_website_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`adx_website_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_urlhistory"></a> adx_website_urlhistory

Many-To-One Relationship: [adx_urlhistory adx_website_urlhistory](adx_urlhistory.md#BKMK_adx_website_urlhistory)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_urlhistory`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_urlhistory`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_webfile"></a> adx_website_webfile

Many-To-One Relationship: [adx_webfile adx_website_webfile](adx_webfile.md#BKMK_adx_website_webfile)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webfile`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_webfile`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103200<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_webform"></a> adx_website_webform

Many-To-One Relationship: [adx_webform adx_website_webform](adx_webform.md#BKMK_adx_website_webform)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webform`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_webform`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_weblinkset"></a> adx_website_weblinkset

Many-To-One Relationship: [adx_weblinkset adx_website_weblinkset](adx_weblinkset.md#BKMK_adx_website_weblinkset)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_weblinkset`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_weblinkset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_webpage"></a> adx_website_webpage

Many-To-One Relationship: [adx_webpage adx_website_webpage](adx_webpage.md#BKMK_adx_website_webpage)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpage`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_webpage`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103500<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_webpageaccesscontrolrule"></a> adx_website_webpageaccesscontrolrule

Many-To-One Relationship: [adx_webpageaccesscontrolrule adx_website_webpageaccesscontrolrule](adx_webpageaccesscontrolrule.md#BKMK_adx_website_webpageaccesscontrolrule)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webpageaccesscontrolrule`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_webpageaccesscontrolrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103400<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_webrole"></a> adx_website_webrole

Many-To-One Relationship: [adx_webrole adx_website_webrole](adx_webrole.md#BKMK_adx_website_webrole)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_webrole`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_webrole`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103600<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_websiteaccess"></a> adx_website_websiteaccess

Many-To-One Relationship: [adx_websiteaccess adx_website_websiteaccess](adx_websiteaccess.md#BKMK_adx_website_websiteaccess)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websiteaccess`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_websiteaccess`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 103700<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_websitebinding"></a> adx_website_websitebinding

Many-To-One Relationship: [adx_websitebinding adx_website_websitebinding](adx_websitebinding.md#BKMK_adx_website_websitebinding)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitebinding`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_website_websitebinding`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Bindings<br />MenuId: null<br />Order: 100300<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_websitemigrationtracker_adx_website"></a> adx_websitemigrationtracker_adx_website

Many-To-One Relationship: [adx_websitemigrationtracker adx_websitemigrationtracker_adx_website](adx_websitemigrationtracker.md#BKMK_adx_websitemigrationtracker_adx_website)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_websitemigrationtracker`|
|ReferencingAttribute|`adx_websiteid`|
|ReferencedEntityNavigationPropertyName|`adx_websitemigrationtracker_adx_website`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [adx_website_list](#BKMK_adx_website_list)
- [adx_website_sponsor](#BKMK_adx_website_sponsor)

### <a name="BKMK_adx_website_list"></a> adx_website_list

See [list adx_website_list Many-To-Many Relationship](list.md#BKMK_adx_website_list)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_website_list`|
|IsCustomizable|True|
|SchemaName|`adx_website_list`|
|IntersectAttribute|`adx_websiteid`|
|NavigationPropertyName|`adx_website_list`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_website_sponsor"></a> adx_website_sponsor

See [account adx_website_sponsor Many-To-Many Relationship](account.md#BKMK_adx_website_sponsor)

|Property|Value|
|---|---|
|IntersectEntityName|`adx_website_sponsor`|
|IsCustomizable|True|
|SchemaName|`adx_website_sponsor`|
|IntersectAttribute|`adx_websiteid`|
|NavigationPropertyName|`adx_website_sponsor`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

