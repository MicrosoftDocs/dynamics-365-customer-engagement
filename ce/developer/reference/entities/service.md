---
title: "Service table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Service table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Service table/entity reference (Microsoft Dynamics 365)

Activity that represents work done to satisfy a customer's need.

## Messages

The following table lists the messages for the Service table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /services<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /services(*serviceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /services(*serviceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveByResourcesService`<br />Event: False |**RetrieveByResourcesService function** |<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourcesServiceRequest>|
| `RetrieveMultiple`<br />Event: True |`GET` /services<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /services(*serviceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /services(*serviceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Service table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Service** |
| **DisplayCollectionName** | **Services** |
| **SchemaName** | `Service` |
| **CollectionSchemaName** | `Services` |
| **EntitySetName** | `services`|
| **LogicalName** | `service` |
| **LogicalCollectionName** | `services` |
| **PrimaryIdAttribute** | `serviceid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AnchorOffset](#BKMK_AnchorOffset)
- [CalendarId](#BKMK_CalendarId)
- [Description](#BKMK_Description)
- [Duration](#BKMK_Duration)
- [Granularity](#BKMK_Granularity)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InitialStatusCode](#BKMK_InitialStatusCode)
- [IsSchedulable](#BKMK_IsSchedulable)
- [IsVisible](#BKMK_IsVisible)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ResourceSpecId](#BKMK_ResourceSpecId)
- [ServiceId](#BKMK_ServiceId)
- [ShowResources](#BKMK_ShowResources)
- [StrategyId](#BKMK_StrategyId)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AnchorOffset"></a> AnchorOffset

|Property|Value|
|---|---|
|Description|**Used in conjunction with granularity to describes when services can be performed in relation to midnight on a given day.**|
|DisplayName|**Anchor Offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`anchoroffset`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|1440|
|MinValue|0|

### <a name="BKMK_CalendarId"></a> CalendarId

|Property|Value|
|---|---|
|Description|**Unique identifier of the calendar.**|
|DisplayName|**Calendar**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`calendarid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_Description"></a> Description

|Property|Value|
|---|---|
|Description|**Description of activity that represents work done to satisfy a customer's need.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|---|---|
|Description|**Duration of the service.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`duration`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_Granularity"></a> Granularity

|Property|Value|
|---|---|
|Description|**Describes how often the service is performed.**|
|DisplayName|**Granularity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`granularity`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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

### <a name="BKMK_InitialStatusCode"></a> InitialStatusCode

|Property|Value|
|---|---|
|Description|**Initial status reason for the service activity.**|
|DisplayName|**Initial Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`initialstatuscode`|
|RequiredLevel|SystemRequired|
|Type|Status|
|DefaultFormValue|4|
|GlobalChoiceName|`service_initialstatuscode`|

#### InitialStatusCode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Requested**<br />State:0<br />TransitionData: None|
|2|Label: **Tentative**<br />State:0<br />TransitionData: None|
|3|Label: **Pending**<br />State:0<br />TransitionData: None|
|4|Label: **Reserved**<br />State:0<br />TransitionData: None|
|6|Label: **In Progress**<br />State:0<br />TransitionData: None|
|7|Label: **Arrived**<br />State:0<br />TransitionData: None|
|8|Label: **Completed**<br />State:1<br />TransitionData: None|
|9|Label: **Canceled**<br />State:2<br />TransitionData: None|
|10|Label: **No Show**<br />State:2<br />TransitionData: None|

### <a name="BKMK_IsSchedulable"></a> IsSchedulable

|Property|Value|
|---|---|
|Description|**Information about whether the service can be scheduled.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isschedulable`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`service_isschedulable`|
|DefaultValue|True|
|True Label|Active|
|False Label|Inactive|

### <a name="BKMK_IsVisible"></a> IsVisible

|Property|Value|
|---|---|
|Description|**Information about whether the service is visible to users.**|
|DisplayName|**Is Visible**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`isvisible`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`service_isvisible`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Name of the service.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|160|

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

### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

|Property|Value|
|---|---|
|Description|**Unique identifier of the resource specification with which the service is associated.**|
|DisplayName|**Required Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`resourcespecid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|resourcespec|

### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated service.**|
|DisplayName|**Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`serviceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ShowResources"></a> ShowResources

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Show Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`showresources`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`service_showresources`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_StrategyId"></a> StrategyId

|Property|Value|
|---|---|
|Description|**Value that is taken from PluginTypeId in the Plugin Type record for the scheduling strategy. This is the ID of the scheduling strategy plug-in associated with the service.**|
|DisplayName|**Strategy**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`strategyid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|plugintype|

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
|Description|**Unique identifier of the user who created the service.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the service was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the service.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the service.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the service was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the service.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
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
|RequiredLevel|SystemRequired|
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

- [calendar_services](#BKMK_calendar_services)
- [lk_service_createdby](#BKMK_lk_service_createdby)
- [lk_service_createdonbehalfby](#BKMK_lk_service_createdonbehalfby)
- [lk_service_modifiedby](#BKMK_lk_service_modifiedby)
- [lk_service_modifiedonbehalfby](#BKMK_lk_service_modifiedonbehalfby)
- [organization_services](#BKMK_organization_services)
- [plugin_type_service](#BKMK_plugin_type_service)
- [resource_spec_services](#BKMK_resource_spec_services)

### <a name="BKMK_calendar_services"></a> calendar_services

One-To-Many Relationship: [calendar calendar_services](calendar.md#BKMK_calendar_services)

|Property|Value|
|---|---|
|ReferencedEntity|`calendar`|
|ReferencedAttribute|`calendarid`|
|ReferencingAttribute|`calendarid`|
|ReferencingEntityNavigationPropertyName|`calendarid_calendar`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_service_createdby"></a> lk_service_createdby

One-To-Many Relationship: [systemuser lk_service_createdby](systemuser.md#BKMK_lk_service_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_service_createdonbehalfby"></a> lk_service_createdonbehalfby

One-To-Many Relationship: [systemuser lk_service_createdonbehalfby](systemuser.md#BKMK_lk_service_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_service_modifiedby"></a> lk_service_modifiedby

One-To-Many Relationship: [systemuser lk_service_modifiedby](systemuser.md#BKMK_lk_service_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_service_modifiedonbehalfby"></a> lk_service_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_service_modifiedonbehalfby](systemuser.md#BKMK_lk_service_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_services"></a> organization_services

One-To-Many Relationship: [organization organization_services](organization.md#BKMK_organization_services)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_plugin_type_service"></a> plugin_type_service

One-To-Many Relationship: [plugintype plugin_type_service](plugintype.md#BKMK_plugin_type_service)

|Property|Value|
|---|---|
|ReferencedEntity|`plugintype`|
|ReferencedAttribute|`plugintypeid`|
|ReferencingAttribute|`strategyid`|
|ReferencingEntityNavigationPropertyName|`strategyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_resource_spec_services"></a> resource_spec_services

One-To-Many Relationship: [resourcespec resource_spec_services](resourcespec.md#BKMK_resource_spec_services)

|Property|Value|
|---|---|
|ReferencedEntity|`resourcespec`|
|ReferencedAttribute|`resourcespecid`|
|ReferencingAttribute|`resourcespecid`|
|ReferencingEntityNavigationPropertyName|`resourcespecid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [adx_inviteredemption_service_serviceid](#BKMK_adx_inviteredemption_service_serviceid)
- [adx_portalcomment_service_serviceid](#BKMK_adx_portalcomment_service_serviceid)
- [msdyn_copilottranscript_service_serviceid](#BKMK_msdyn_copilottranscript_service_serviceid)
- [msdyn_ocliveworkitem_service_serviceid](#BKMK_msdyn_ocliveworkitem_service_serviceid)
- [msdyn_ocsession_service_serviceid](#BKMK_msdyn_ocsession_service_serviceid)
- [msfp_alert_service_serviceid](#BKMK_msfp_alert_service_serviceid)
- [msfp_surveyinvite_service_serviceid](#BKMK_msfp_surveyinvite_service_serviceid)
- [msfp_surveyresponse_service_serviceid](#BKMK_msfp_surveyresponse_service_serviceid)
- [service_accounts](#BKMK_service_accounts)
- [service_activity_pointers](#BKMK_service_activity_pointers)
- [service_adx_inviteredemptions](#BKMK_service_adx_inviteredemptions)
- [service_adx_portalcomments](#BKMK_service_adx_portalcomments)
- [Service_Annotation](#BKMK_Service_Annotation)
- [service_appointments](#BKMK_service_appointments)
- [Service_AsyncOperations](#BKMK_Service_AsyncOperations)
- [Service_BulkDeleteFailures](#BKMK_Service_BulkDeleteFailures)
- [service_calendar_rules](#BKMK_service_calendar_rules)
- [service_chats](#BKMK_service_chats)
- [service_contacts](#BKMK_service_contacts)
- [Service_DuplicateBaseRecord](#BKMK_Service_DuplicateBaseRecord)
- [Service_DuplicateMatchingRecord](#BKMK_Service_DuplicateMatchingRecord)
- [service_emails](#BKMK_service_emails)
- [service_faxes](#BKMK_service_faxes)
- [service_incidentresolutions](#BKMK_service_incidentresolutions)
- [service_letters](#BKMK_service_letters)
- [service_MailboxTrackingFolders](#BKMK_service_MailboxTrackingFolders)
- [service_opportunityclose](#BKMK_service_opportunityclose)
- [service_orderclose](#BKMK_service_orderclose)
- [service_phonecalls](#BKMK_service_phonecalls)
- [service_PrincipalObjectAttributeAccesses](#BKMK_service_PrincipalObjectAttributeAccesses)
- [Service_ProcessSessions](#BKMK_Service_ProcessSessions)
- [service_quoteclose](#BKMK_service_quoteclose)
- [service_recurringappointmentmasters](#BKMK_service_recurringappointmentmasters)
- [service_service_appointments](#BKMK_service_service_appointments)
- [service_socialactivities](#BKMK_service_socialactivities)
- [Service_SyncErrors](#BKMK_Service_SyncErrors)
- [service_tasks](#BKMK_service_tasks)

### <a name="BKMK_adx_inviteredemption_service_serviceid"></a> adx_inviteredemption_service_serviceid

Many-To-One Relationship: [adx_inviteredemption adx_inviteredemption_service_serviceid](adx_inviteredemption.md#BKMK_adx_inviteredemption_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_adx_inviteredemption`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_adx_portalcomment_service_serviceid"></a> adx_portalcomment_service_serviceid

Many-To-One Relationship: [adx_portalcomment adx_portalcomment_service_serviceid](adx_portalcomment.md#BKMK_adx_portalcomment_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_adx_inviteredemption_adx_portalcomment`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_copilottranscript_service_serviceid"></a> msdyn_copilottranscript_service_serviceid

Many-To-One Relationship: [msdyn_copilottranscript msdyn_copilottranscript_service_serviceid](msdyn_copilottranscript.md#BKMK_msdyn_copilottranscript_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_copilottranscript_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msdyn_ocliveworkitem_service_serviceid"></a> msdyn_ocliveworkitem_service_serviceid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_ocliveworkitem_service_serviceid](msdyn_ocliveworkitem.md#BKMK_msdyn_ocliveworkitem_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocliveworkitem_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msdyn_ocsession_service_serviceid"></a> msdyn_ocsession_service_serviceid

Many-To-One Relationship: [msdyn_ocsession msdyn_ocsession_service_serviceid](msdyn_ocsession.md#BKMK_msdyn_ocsession_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocsession_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msfp_alert_service_serviceid"></a> msfp_alert_service_serviceid

Many-To-One Relationship: [msfp_alert msfp_alert_service_serviceid](msfp_alert.md#BKMK_msfp_alert_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msfp_alert_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msfp_surveyinvite_service_serviceid"></a> msfp_surveyinvite_service_serviceid

Many-To-One Relationship: [msfp_surveyinvite msfp_surveyinvite_service_serviceid](msfp_surveyinvite.md#BKMK_msfp_surveyinvite_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyinvite_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_msfp_surveyresponse_service_serviceid"></a> msfp_surveyresponse_service_serviceid

Many-To-One Relationship: [msfp_surveyresponse msfp_surveyresponse_service_serviceid](msfp_surveyresponse.md#BKMK_msfp_surveyresponse_service_serviceid)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`msfp_surveyresponse_service_serviceid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_service_accounts"></a> service_accounts

Many-To-One Relationship: [account service_accounts](account.md#BKMK_service_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`account`|
|ReferencingAttribute|`preferredserviceid`|
|ReferencedEntityNavigationPropertyName|`service_accounts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_activity_pointers"></a> service_activity_pointers

Many-To-One Relationship: [activitypointer service_activity_pointers](activitypointer.md#BKMK_service_activity_pointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_activity_pointers`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_service_adx_inviteredemptions"></a> service_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption service_adx_inviteredemptions](adx_inviteredemption.md#BKMK_service_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`service_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_adx_portalcomments"></a> service_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment service_adx_portalcomments](adx_portalcomment.md#BKMK_service_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`service_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_Annotation"></a> Service_Annotation

Many-To-One Relationship: [annotation Service_Annotation](annotation.md#BKMK_Service_Annotation)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`Service_Annotation`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_appointments"></a> service_appointments

Many-To-One Relationship: [appointment service_appointments](appointment.md#BKMK_service_appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_appointments`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_AsyncOperations"></a> Service_AsyncOperations

Many-To-One Relationship: [asyncoperation Service_AsyncOperations](asyncoperation.md#BKMK_Service_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Service_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_BulkDeleteFailures"></a> Service_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Service_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Service_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Service_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_calendar_rules"></a> service_calendar_rules

Many-To-One Relationship: [calendarrule service_calendar_rules](calendarrule.md#BKMK_service_calendar_rules)

|Property|Value|
|---|---|
|ReferencingEntity|`calendarrule`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_calendar_rules`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_chats"></a> service_chats

Many-To-One Relationship: [chat service_chats](chat.md#BKMK_service_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`service_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_contacts"></a> service_contacts

Many-To-One Relationship: [contact service_contacts](contact.md#BKMK_service_contacts)

|Property|Value|
|---|---|
|ReferencingEntity|`contact`|
|ReferencingAttribute|`preferredserviceid`|
|ReferencedEntityNavigationPropertyName|`service_contacts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_DuplicateBaseRecord"></a> Service_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord Service_DuplicateBaseRecord](duplicaterecord.md#BKMK_Service_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`Service_DuplicateBaseRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_DuplicateMatchingRecord"></a> Service_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord Service_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Service_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`Service_DuplicateMatchingRecord`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_emails"></a> service_emails

Many-To-One Relationship: [email service_emails](email.md#BKMK_service_emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_emails`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_faxes"></a> service_faxes

Many-To-One Relationship: [fax service_faxes](fax.md#BKMK_service_faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_faxes`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_incidentresolutions"></a> service_incidentresolutions

Many-To-One Relationship: [incidentresolution service_incidentresolutions](incidentresolution.md#BKMK_service_incidentresolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_incidentresolutions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_letters"></a> service_letters

Many-To-One Relationship: [letter service_letters](letter.md#BKMK_service_letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_letters`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_MailboxTrackingFolders"></a> service_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder service_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_service_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`service_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_opportunityclose"></a> service_opportunityclose

Many-To-One Relationship: [opportunityclose service_opportunityclose](opportunityclose.md#BKMK_service_opportunityclose)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_opportunityclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_service_orderclose"></a> service_orderclose

Many-To-One Relationship: [orderclose service_orderclose](orderclose.md#BKMK_service_orderclose)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_orderclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_service_phonecalls"></a> service_phonecalls

Many-To-One Relationship: [phonecall service_phonecalls](phonecall.md#BKMK_service_phonecalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_phonecalls`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_PrincipalObjectAttributeAccesses"></a> service_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess service_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_service_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`service_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_ProcessSessions"></a> Service_ProcessSessions

Many-To-One Relationship: [processsession Service_ProcessSessions](processsession.md#BKMK_Service_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Service_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_quoteclose"></a> service_quoteclose

Many-To-One Relationship: [quoteclose service_quoteclose](quoteclose.md#BKMK_service_quoteclose)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_quoteclose`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RetrieveByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_service_recurringappointmentmasters"></a> service_recurringappointmentmasters

Many-To-One Relationship: [recurringappointmentmaster service_recurringappointmentmasters](recurringappointmentmaster.md#BKMK_service_recurringappointmentmasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_recurringappointmentmasters`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_service_appointments"></a> service_service_appointments

Many-To-One Relationship: [serviceappointment service_service_appointments](serviceappointment.md#BKMK_service_service_appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_service_appointments`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_socialactivities"></a> service_socialactivities

Many-To-One Relationship: [socialactivity service_socialactivities](socialactivity.md#BKMK_service_socialactivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_socialactivities`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Service_SyncErrors"></a> Service_SyncErrors

Many-To-One Relationship: [syncerror Service_SyncErrors](syncerror.md#BKMK_Service_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Service_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_service_tasks"></a> service_tasks

Many-To-One Relationship: [task service_tasks](task.md#BKMK_service_tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`serviceid`|
|ReferencedEntityNavigationPropertyName|`service_tasks`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

