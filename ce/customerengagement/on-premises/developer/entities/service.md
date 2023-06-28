---
title: "Service entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Service entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Service entity reference

Activity that represents work done to satisfy a customer's need.

**Added by**: Service Solution


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveByResourcesService|<xref:Microsoft.Crm.Sdk.Messages.RetrieveByResourcesServiceRequest>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Services|
|DisplayCollectionName|Services|
|DisplayName|Service|
|EntitySetName|services|
|IsBPFEntity|False|
|LogicalCollectionName|services|
|LogicalName|service|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|serviceid|
|PrimaryNameAttribute|name|
|SchemaName|Service|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Used in conjunction with granularity to describes when services can be performed in relation to midnight on a given day.|
|DisplayName|Anchor Offset|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|anchoroffset|
|MaxValue|1440|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_CalendarId"></a> CalendarId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the calendar.|
|DisplayName|Calendar|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|calendarid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of activity that represents work done to satisfy a customer's need.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_Duration"></a> Duration

|Property|Value|
|--------|-----|
|Description|Duration of the service.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_Granularity"></a> Granularity

|Property|Value|
|--------|-----|
|Description|Describes how often the service is performed.|
|DisplayName|Granularity|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|granularity|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InitialStatusCode"></a> InitialStatusCode

|Property|Value|
|--------|-----|
|Description|Initial status reason for the service activity.|
|DisplayName|Initial Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|initialstatuscode|
|RequiredLevel|SystemRequired|
|Type|Status|

#### InitialStatusCode Choices/Options

|Value|Label|State|
|-----|-----|-----|
|1|Requested|0|
|2|Tentative|0|
|3|Pending|0|
|4|Reserved|0|
|6|In Progress|0|
|7|Arrived|0|
|8|Completed|1|
|9|Canceled|2|
|10|No Show|2|



### <a name="BKMK_IsSchedulable"></a> IsSchedulable

|Property|Value|
|--------|-----|
|Description|Information about whether the service can be scheduled.|
|DisplayName|Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isschedulable|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsSchedulable Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Active||
|0|Inactive||

**DefaultValue**: 1



### <a name="BKMK_IsVisible"></a> IsVisible

|Property|Value|
|--------|-----|
|Description|Information about whether the service is visible to users.|
|DisplayName|Is Visible|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|isvisible|
|RequiredLevel|None|
|Type|Boolean|

#### IsVisible Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the service.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ResourceSpecId"></a> ResourceSpecId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the resource specification with which the service is associated.|
|DisplayName|Required Resources|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|resourcespecid|
|RequiredLevel|SystemRequired|
|Targets|resourcespec|
|Type|Lookup|


### <a name="BKMK_ServiceId"></a> ServiceId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated service.|
|DisplayName|Service|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|serviceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ShowResources"></a> ShowResources

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Show Resources|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|showresources|
|RequiredLevel|None|
|Type|Boolean|

#### ShowResources Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_StrategyId"></a> StrategyId

|Property|Value|
|--------|-----|
|Description|Value that is taken from PluginTypeId in the Plugin Type record for the scheduling strategy. This is the ID of the scheduling strategy plug-in associated with the service.|
|DisplayName|Strategy|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|strategyid|
|RequiredLevel|SystemRequired|
|Targets|plugintype|
|Type|Lookup|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [ResourceSpecIdName](#BKMK_ResourceSpecIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the service.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the service was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the service.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the service.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the service was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the service.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ResourceSpecIdName"></a> ResourceSpecIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resourcespecidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [Service_SyncErrors](#BKMK_Service_SyncErrors)
- [Service_AsyncOperations](#BKMK_Service_AsyncOperations)
- [service_MailboxTrackingFolders](#BKMK_service_MailboxTrackingFolders)
- [Service_ProcessSessions](#BKMK_Service_ProcessSessions)
- [Service_BulkDeleteFailures](#BKMK_Service_BulkDeleteFailures)
- [service_PrincipalObjectAttributeAccesses](#BKMK_service_PrincipalObjectAttributeAccesses)
- [Service_Annotation](#BKMK_Service_Annotation)
- [service_accounts](#BKMK_service_accounts)
- [service_activity_pointers](#BKMK_service_activity_pointers)
- [service_contacts](#BKMK_service_contacts)
- [service_emails](#BKMK_service_emails)
- [service_socialactivities](#BKMK_service_socialactivities)
- [service_appointments](#BKMK_service_appointments)
- [service_service_appointments](#BKMK_service_service_appointments)
- [service_faxes](#BKMK_service_faxes)
- [service_incidentresolutions](#BKMK_service_incidentresolutions)
- [service_letters](#BKMK_service_letters)
- [service_phonecalls](#BKMK_service_phonecalls)
- [service_recurringappointmentmasters](#BKMK_service_recurringappointmentmasters)
- [service_tasks](#BKMK_service_tasks)
- [Service_DuplicateBaseRecord](#BKMK_Service_DuplicateBaseRecord)
- [Service_DuplicateMatchingRecord](#BKMK_Service_DuplicateMatchingRecord)
- [service_opportunityclose](#BKMK_service_opportunityclose)
- [service_orderclose](#BKMK_service_orderclose)
- [service_quoteclose](#BKMK_service_quoteclose)


### <a name="BKMK_Service_SyncErrors"></a> Service_SyncErrors

**Added by**: System Solution Solution

Same as the [Service_SyncErrors](syncerror.md#BKMK_Service_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Service_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_Service_AsyncOperations"></a> Service_AsyncOperations

**Added by**: System Solution Solution

Same as the [Service_AsyncOperations](asyncoperation.md#BKMK_Service_AsyncOperations) many-to-one relationship for the [asyncoperation](asyncoperation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Service_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_MailboxTrackingFolders"></a> service_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as the [service_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_service_MailboxTrackingFolders) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|service_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Service_ProcessSessions"></a> Service_ProcessSessions

**Added by**: System Solution Solution

Same as the [Service_ProcessSessions](processsession.md#BKMK_Service_ProcessSessions) many-to-one relationship for the [processsession](processsession.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Service_ProcessSessions|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 110|
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Service_BulkDeleteFailures"></a> Service_BulkDeleteFailures

**Added by**: System Solution Solution

Same as the [Service_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Service_BulkDeleteFailures) many-to-one relationship for the [bulkdeletefailure](bulkdeletefailure.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Service_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_PrincipalObjectAttributeAccesses"></a> service_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as the [service_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_service_PrincipalObjectAttributeAccesses) many-to-one relationship for the [principalobjectattributeaccess](principalobjectattributeaccess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|service_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Service_Annotation"></a> Service_Annotation

**Added by**: System Solution Solution

Same as the [Service_Annotation](annotation.md#BKMK_Service_Annotation) many-to-one relationship for the [annotation](annotation.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Service_Annotation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_service_accounts"></a> service_accounts

Same as the [service_accounts](account.md#BKMK_service_accounts) many-to-one relationship for the [account](account.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|preferredserviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_accounts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_activity_pointers"></a> service_activity_pointers

Same as the [service_activity_pointers](activitypointer.md#BKMK_service_activity_pointers) many-to-one relationship for the [activitypointer](activitypointer.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_activity_pointers|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_contacts"></a> service_contacts

Same as the [service_contacts](contact.md#BKMK_service_contacts) many-to-one relationship for the [contact](contact.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|preferredserviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_contacts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_emails"></a> service_emails

Same as the [service_emails](email.md#BKMK_service_emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_socialactivities"></a> service_socialactivities

Same as the [service_socialactivities](socialactivity.md#BKMK_service_socialactivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_socialactivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_appointments"></a> service_appointments

Same as the [service_appointments](appointment.md#BKMK_service_appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_service_appointments"></a> service_service_appointments

Same as the [service_service_appointments](serviceappointment.md#BKMK_service_service_appointments) many-to-one relationship for the [serviceappointment](serviceappointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_service_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_faxes"></a> service_faxes

Same as the [service_faxes](fax.md#BKMK_service_faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_incidentresolutions"></a> service_incidentresolutions

Same as the [service_incidentresolutions](incidentresolution.md#BKMK_service_incidentresolutions) many-to-one relationship for the [incidentresolution](incidentresolution.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incidentresolution|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_incidentresolutions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_letters"></a> service_letters

Same as the [service_letters](letter.md#BKMK_service_letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_phonecalls"></a> service_phonecalls

Same as the [service_phonecalls](phonecall.md#BKMK_service_phonecalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_recurringappointmentmasters"></a> service_recurringappointmentmasters

Same as the [service_recurringappointmentmasters](recurringappointmentmaster.md#BKMK_service_recurringappointmentmasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_recurringappointmentmasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_tasks"></a> service_tasks

Same as the [service_tasks](task.md#BKMK_service_tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Service_DuplicateBaseRecord"></a> Service_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as the [Service_DuplicateBaseRecord](duplicaterecord.md#BKMK_Service_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Service_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Service_DuplicateMatchingRecord"></a> Service_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as the [Service_DuplicateMatchingRecord](duplicaterecord.md#BKMK_Service_DuplicateMatchingRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Service_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_opportunityclose"></a> service_opportunityclose

**Added by**: Sales Solution

Same as the [service_opportunityclose](opportunityclose.md#BKMK_service_opportunityclose) many-to-one relationship for the [opportunityclose](opportunityclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityclose|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_opportunityclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_orderclose"></a> service_orderclose

**Added by**: Sales Solution

Same as the [service_orderclose](orderclose.md#BKMK_service_orderclose) many-to-one relationship for the [orderclose](orderclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|orderclose|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_orderclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_service_quoteclose"></a> service_quoteclose

**Added by**: Sales Solution

Same as the [service_quoteclose](quoteclose.md#BKMK_service_quoteclose) many-to-one relationship for the [quoteclose](quoteclose.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quoteclose|
|ReferencingAttribute|serviceid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|service_quoteclose|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_service_createdby](#BKMK_lk_service_createdby)
- [lk_service_createdonbehalfby](#BKMK_lk_service_createdonbehalfby)
- [lk_service_modifiedby](#BKMK_lk_service_modifiedby)
- [lk_service_modifiedonbehalfby](#BKMK_lk_service_modifiedonbehalfby)
- [organization_services](#BKMK_organization_services)
- [calendar_services](#BKMK_calendar_services)
- [plugin_type_service](#BKMK_plugin_type_service)
- [resource_spec_services](#BKMK_resource_spec_services)


### <a name="BKMK_lk_service_createdby"></a> lk_service_createdby

**Added by**: System Solution Solution

See the [lk_service_createdby](systemuser.md#BKMK_lk_service_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_service_createdonbehalfby"></a> lk_service_createdonbehalfby

**Added by**: System Solution Solution

See the [lk_service_createdonbehalfby](systemuser.md#BKMK_lk_service_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_service_modifiedby"></a> lk_service_modifiedby

**Added by**: System Solution Solution

See the [lk_service_modifiedby](systemuser.md#BKMK_lk_service_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_service_modifiedonbehalfby"></a> lk_service_modifiedonbehalfby

**Added by**: System Solution Solution

See the [lk_service_modifiedonbehalfby](systemuser.md#BKMK_lk_service_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_organization_services"></a> organization_services

**Added by**: System Solution Solution

See the [organization_services](organization.md#BKMK_organization_services) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_calendar_services"></a> calendar_services

**Added by**: System Solution Solution

See the [calendar_services](calendar.md#BKMK_calendar_services) one-to-many relationship for the [calendar](calendar.md) entity.

### <a name="BKMK_plugin_type_service"></a> plugin_type_service

**Added by**: System Solution Solution

See the [plugin_type_service](plugintype.md#BKMK_plugin_type_service) one-to-many relationship for the [plugintype](plugintype.md) entity.

### <a name="BKMK_resource_spec_services"></a> resource_spec_services

See the [resource_spec_services](resourcespec.md#BKMK_resource_spec_services) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
