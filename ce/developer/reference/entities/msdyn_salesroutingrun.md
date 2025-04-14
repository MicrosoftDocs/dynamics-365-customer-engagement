---
title: "Sales routing run (msdyn_salesroutingrun) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales routing run (msdyn_salesroutingrun) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales routing run (msdyn_salesroutingrun) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sales routing run (msdyn_salesroutingrun) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesroutingruns<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesroutingruns<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesroutingruns(*msdyn_salesroutingrunid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales routing run (msdyn_salesroutingrun) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales routing run** |
| **DisplayCollectionName** | **Sales routing runs** |
| **SchemaName** | `msdyn_salesroutingrun` |
| **CollectionSchemaName** | `msdyn_salesroutingruns` |
| **EntitySetName** | `msdyn_salesroutingruns`|
| **LogicalName** | `msdyn_salesroutingrun` |
| **LogicalCollectionName** | `msdyn_salesroutingruns` |
| **PrimaryIdAttribute** | `msdyn_salesroutingrunid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_assignmentruleid](#BKMK_msdyn_assignmentruleid)
- [msdyn_connectedsequenceids](#BKMK_msdyn_connectedsequenceids)
- [msdyn_connectsequencestatus](#BKMK_msdyn_connectsequencestatus)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_isrecordassigned](#BKMK_msdyn_isrecordassigned)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ownerassigned](#BKMK_msdyn_ownerassigned)
- [msdyn_ownerassignedIdType](#BKMK_msdyn_ownerassignedIdType)
- [msdyn_previousowner](#BKMK_msdyn_previousowner)
- [msdyn_previousownerIdType](#BKMK_msdyn_previousownerIdType)
- [msdyn_previoussegmentid](#BKMK_msdyn_previoussegmentid)
- [msdyn_routingrequestsource](#BKMK_msdyn_routingrequestsource)
- [msdyn_routingstatus](#BKMK_msdyn_routingstatus)
- [msdyn_salesroutingrunId](#BKMK_msdyn_salesroutingrunId)
- [msdyn_saruninstanceid](#BKMK_msdyn_saruninstanceid)
- [msdyn_segmentationstatus](#BKMK_msdyn_segmentationstatus)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [msdyn_targetobject](#BKMK_msdyn_targetobject)
- [msdyn_targetobjectIdType](#BKMK_msdyn_targetobjectIdType)
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

### <a name="BKMK_msdyn_assignmentruleid"></a> msdyn_assignmentruleid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Assignment Rule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignmentruleid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_assignmentrule|

### <a name="BKMK_msdyn_connectedsequenceids"></a> msdyn_connectedsequenceids

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connected sequences**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectedsequenceids`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_connectsequencestatus"></a> msdyn_connectsequencestatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Connect sequence status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_connectsequencestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesroutingrun_msdyn_connectsequencestatus`|

#### msdyn_connectsequencestatus Choices/Options

|Value|Label|
|---|---|
|0|**In progress**|
|1|**Successfully connected to a sequence**|
|2|**Something went wrong**|
|3|**Skipped as segmentation failed**|
|4|**No sequence connected to this segment**|
|5|**Sequence unchanged**|
|6|**Seller needs additional access**|
|7|**Sequence is either deleted or inactive**|
|8|**D365WorkAssignment app user doesn't have the necessary permissions.**|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50000|

### <a name="BKMK_msdyn_isrecordassigned"></a> msdyn_isrecordassigned

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is record assigned**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isrecordassigned`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_salesroutingrun_msdyn_isrecordassigned`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

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

### <a name="BKMK_msdyn_ownerassigned"></a> msdyn_ownerassigned

|Property|Value|
|---|---|
|Description|**Assigned owner id**|
|DisplayName|**Assigned owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ownerassigned`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|queue, systemuser, team|

### <a name="BKMK_msdyn_ownerassignedIdType"></a> msdyn_ownerassignedIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ownerassignedidtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_previousowner"></a> msdyn_previousowner

|Property|Value|
|---|---|
|Description|**Previous owner id**|
|DisplayName|**Previous owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previousowner`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue, systemuser, team|

### <a name="BKMK_msdyn_previousownerIdType"></a> msdyn_previousownerIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_previousowneridtype`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_msdyn_previoussegmentid"></a> msdyn_previoussegmentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Previous segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previoussegmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_routingrequestsource"></a> msdyn_routingrequestsource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing request source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingrequestsource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesroutingrun_msdyn_routingrequestsource`|

#### msdyn_routingrequestsource Choices/Options

|Value|Label|
|---|---|
|0|**New record**|
|1|**Record updated**|
|2|**Manually reassigned**|
|3|**Reassignment scheduled**|
|4|**Manually resegmented**|
|5|**Force routed manually**|

### <a name="BKMK_msdyn_routingstatus"></a> msdyn_routingstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Routing status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_routingstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesroutingrun_msdyn_routingstatus`|

#### msdyn_routingstatus Choices/Options

|Value|Label|
|---|---|
|1|**Run is in progress**|
|2|**Owner assigned successfully**|
|3|**There was an issue with the server**|
|4|**Record doesn't meet any conditions**|
|5|**No sellers meet the conditions**|
|6|**Eligible sellers don't have availability**|
|7|**Eligible sellers don't have capacity**|
|8|**No assignment rule for this record's segment**|
|9|**Owner assigned manually**|
|10|**Record unassigned as seller lacks security role privileges**|
|11|**Seller not assigned as record is older than the set timeframe**|
|12|**Found multiple eligible teams**|
|13|**Couldn't find eligible team**|
|14|**Found multiple eligible queues**|
|15|**Couldn't find eligible queue**|
|16|**Skipped as segmentation failed**|
|17|**Rules won't run for this segment**|
|18|**D365WorkAssignment app user doesn't have the necessary permissions.**|

### <a name="BKMK_msdyn_salesroutingrunId"></a> msdyn_salesroutingrunId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Sales routing run**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesroutingrunid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_saruninstanceid"></a> msdyn_saruninstanceid

|Property|Value|
|---|---|
|Description||
|DisplayName|**SARunInstance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saruninstanceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_saruninstance|

### <a name="BKMK_msdyn_segmentationstatus"></a> msdyn_segmentationstatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Segmentation status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_salesroutingrun_msdyn_segmentationstatus`|

#### msdyn_segmentationstatus Choices/Options

|Value|Label|
|---|---|
|0|**In Progress**|
|1|**Segmentation successful**|
|2|**Something went wrong**|
|3|**No matching segments**|
|4|**Matched with previous segment**|
|5|**No segmentation required**|
|6|**D365WorkAssignment app user doesn't have the necessary permissions.**|

### <a name="BKMK_msdyn_segmentid"></a> msdyn_segmentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_segmentid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_segment|

### <a name="BKMK_msdyn_targetobject"></a> msdyn_targetobject

|Property|Value|
|---|---|
|Description||
|DisplayName|**Target Object**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_targetobject`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account, contact, lead, msdyn_salessuggestion, opportunity|

### <a name="BKMK_msdyn_targetobjectIdType"></a> msdyn_targetobjectIdType

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_targetobjectidtype`|
|RequiredLevel|None|
|Type|EntityName|

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
|Description|**Status of the Sales routing run**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesroutingrun_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Inprogress**<br />DefaultStatus: 1<br />InvariantName: `Inprogress`|
|1|Label: **Succeeded**<br />DefaultStatus: 2<br />InvariantName: `Succeeded`|
|2|Label: **Failed**<br />DefaultStatus: 3<br />InvariantName: `Failed`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales routing run**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesroutingrun_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Run is in progress**<br />State:0<br />TransitionData: None|
|2|Label: **Owner assigned successfully**<br />State:1<br />TransitionData: None|
|3|Label: **There was an issue with the server**<br />State:2<br />TransitionData: None|
|4|Label: **Record doesn't meet any conditions**<br />State:2<br />TransitionData: None|
|5|Label: **No sellers meet the conditions**<br />State:2<br />TransitionData: None|
|6|Label: **Eligible sellers don't have availability**<br />State:2<br />TransitionData: None|
|7|Label: **Eligible sellers don't have capacity**<br />State:2<br />TransitionData: None|
|8|Label: **No assignment rule for this record's segment**<br />State:2<br />TransitionData: None|
|9|Label: **Owner assigned manually**<br />State:1<br />TransitionData: None|
|10|Label: **Record unassigned as seller lacks security role privileges**<br />State:2<br />TransitionData: None|
|11|Label: **Seller not assigned as record is older than the set timeframe**<br />State:2<br />TransitionData: None|
|12|Label: **Found multiple eligible teams**<br />State:2<br />TransitionData: None|
|13|Label: **Couldn't find eligible team**<br />State:2<br />TransitionData: None|
|14|Label: **Found multiple eligible queues**<br />State:2<br />TransitionData: None|
|15|Label: **Couldn't find eligible queue**<br />State:2<br />TransitionData: None|
|16|Label: **Skipped as segmentation failed**<br />State:2<br />TransitionData: None|
|17|Label: **Rules won't run for this segment**<br />State:1<br />TransitionData: None|
|18|Label: **D365WorkAssignment app user doesn't have the necessary permissions.**<br />State:2<br />TransitionData: None|

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
|DisplayName|**Assignment attempt**|
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

- [business_unit_msdyn_salesroutingrun](#BKMK_business_unit_msdyn_salesroutingrun)
- [lk_msdyn_salesroutingrun_createdby](#BKMK_lk_msdyn_salesroutingrun_createdby)
- [lk_msdyn_salesroutingrun_createdonbehalfby](#BKMK_lk_msdyn_salesroutingrun_createdonbehalfby)
- [lk_msdyn_salesroutingrun_modifiedby](#BKMK_lk_msdyn_salesroutingrun_modifiedby)
- [lk_msdyn_salesroutingrun_modifiedonbehalfby](#BKMK_lk_msdyn_salesroutingrun_modifiedonbehalfby)
- [msdyn_account_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_account_msdyn_salesroutingrun_targetobject)
- [msdyn_contact_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject)
- [msdyn_lead_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject)
- [msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule](#BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule)
- [msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid](#BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid)
- [msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid](#BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid)
- [msdyn_msdyn_segment_msdyn_salesroutingrun_segment](#BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_segment)
- [msdyn_opportunity_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject)
- [msdyn_queue_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned)
- [msdyn_queue_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner)
- [msdyn_salessuggestion_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject)
- [msdyn_systemuser_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_systemuser_msdyn_salesroutingrun_ownerassigned)
- [msdyn_systemuser_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_systemuser_msdyn_salesroutingrun_previousowner)
- [msdyn_team_msdyn_salesroutingrun_ownerassigned](#BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned)
- [msdyn_team_msdyn_salesroutingrun_previousowner](#BKMK_msdyn_team_msdyn_salesroutingrun_previousowner)
- [owner_msdyn_salesroutingrun](#BKMK_owner_msdyn_salesroutingrun)
- [team_msdyn_salesroutingrun](#BKMK_team_msdyn_salesroutingrun)
- [user_msdyn_salesroutingrun](#BKMK_user_msdyn_salesroutingrun)

### <a name="BKMK_business_unit_msdyn_salesroutingrun"></a> business_unit_msdyn_salesroutingrun

One-To-Many Relationship: [businessunit business_unit_msdyn_salesroutingrun](businessunit.md#BKMK_business_unit_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingrun_createdby"></a> lk_msdyn_salesroutingrun_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingrun_createdby](systemuser.md#BKMK_lk_msdyn_salesroutingrun_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingrun_createdonbehalfby"></a> lk_msdyn_salesroutingrun_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingrun_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesroutingrun_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingrun_modifiedby"></a> lk_msdyn_salesroutingrun_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingrun_modifiedby](systemuser.md#BKMK_lk_msdyn_salesroutingrun_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesroutingrun_modifiedonbehalfby"></a> lk_msdyn_salesroutingrun_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesroutingrun_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesroutingrun_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_salesroutingrun_targetobject"></a> msdyn_account_msdyn_salesroutingrun_targetobject

One-To-Many Relationship: [account msdyn_account_msdyn_salesroutingrun_targetobject](account.md#BKMK_msdyn_account_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject"></a> msdyn_contact_msdyn_salesroutingrun_targetobject

One-To-Many Relationship: [contact msdyn_contact_msdyn_salesroutingrun_targetobject](contact.md#BKMK_msdyn_contact_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_contact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject"></a> msdyn_lead_msdyn_salesroutingrun_targetobject

One-To-Many Relationship: [lead msdyn_lead_msdyn_salesroutingrun_targetobject](lead.md#BKMK_msdyn_lead_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_lead`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule"></a> msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule

One-To-Many Relationship: [msdyn_assignmentrule msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule](msdyn_assignmentrule.md#BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_assignmentrule`|
|ReferencedAttribute|`msdyn_assignmentruleid`|
|ReferencingAttribute|`msdyn_assignmentruleid`|
|ReferencingEntityNavigationPropertyName|`msdyn_assignmentruleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid"></a> msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid

One-To-Many Relationship: [msdyn_saruninstance msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid](msdyn_saruninstance.md#BKMK_msdyn_msdyn_saruninstance_msdyn_salesroutingrun_saruninstanceid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_saruninstance`|
|ReferencedAttribute|`msdyn_saruninstanceid`|
|ReferencingAttribute|`msdyn_saruninstanceid`|
|ReferencingEntityNavigationPropertyName|`msdyn_saruninstanceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid"></a> msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid](msdyn_segment.md#BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_previoussegmentid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_previoussegmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_previoussegmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_segment"></a> msdyn_msdyn_segment_msdyn_salesroutingrun_segment

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_msdyn_salesroutingrun_segment](msdyn_segment.md#BKMK_msdyn_msdyn_segment_msdyn_salesroutingrun_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_segmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject"></a> msdyn_opportunity_msdyn_salesroutingrun_targetobject

One-To-Many Relationship: [opportunity msdyn_opportunity_msdyn_salesroutingrun_targetobject](opportunity.md#BKMK_msdyn_opportunity_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_opportunity`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned"></a> msdyn_queue_msdyn_salesroutingrun_ownerassigned

One-To-Many Relationship: [queue msdyn_queue_msdyn_salesroutingrun_ownerassigned](queue.md#BKMK_msdyn_queue_msdyn_salesroutingrun_ownerassigned)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_ownerassigned`|
|ReferencingEntityNavigationPropertyName|`msdyn_ownerassigned_queue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner"></a> msdyn_queue_msdyn_salesroutingrun_previousowner

One-To-Many Relationship: [queue msdyn_queue_msdyn_salesroutingrun_previousowner](queue.md#BKMK_msdyn_queue_msdyn_salesroutingrun_previousowner)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_previousowner`|
|ReferencingEntityNavigationPropertyName|`msdyn_previousowner_queue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject"></a> msdyn_salessuggestion_msdyn_salesroutingrun_targetobject

One-To-Many Relationship: [msdyn_salessuggestion msdyn_salessuggestion_msdyn_salesroutingrun_targetobject](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salessuggestion`|
|ReferencedAttribute|`msdyn_salessuggestionid`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencingEntityNavigationPropertyName|`msdyn_targetobject_msdyn_salessuggestion`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_salesroutingrun_ownerassigned"></a> msdyn_systemuser_msdyn_salesroutingrun_ownerassigned

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_salesroutingrun_ownerassigned](systemuser.md#BKMK_msdyn_systemuser_msdyn_salesroutingrun_ownerassigned)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_ownerassigned`|
|ReferencingEntityNavigationPropertyName|`msdyn_ownerassigned_systemuser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_salesroutingrun_previousowner"></a> msdyn_systemuser_msdyn_salesroutingrun_previousowner

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_salesroutingrun_previousowner](systemuser.md#BKMK_msdyn_systemuser_msdyn_salesroutingrun_previousowner)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_previousowner`|
|ReferencingEntityNavigationPropertyName|`msdyn_previousowner_systemuser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned"></a> msdyn_team_msdyn_salesroutingrun_ownerassigned

One-To-Many Relationship: [team msdyn_team_msdyn_salesroutingrun_ownerassigned](team.md#BKMK_msdyn_team_msdyn_salesroutingrun_ownerassigned)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`msdyn_ownerassigned`|
|ReferencingEntityNavigationPropertyName|`msdyn_ownerassigned_team`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_team_msdyn_salesroutingrun_previousowner"></a> msdyn_team_msdyn_salesroutingrun_previousowner

One-To-Many Relationship: [team msdyn_team_msdyn_salesroutingrun_previousowner](team.md#BKMK_msdyn_team_msdyn_salesroutingrun_previousowner)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`msdyn_previousowner`|
|ReferencingEntityNavigationPropertyName|`msdyn_previousowner_team`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_salesroutingrun"></a> owner_msdyn_salesroutingrun

One-To-Many Relationship: [owner owner_msdyn_salesroutingrun](owner.md#BKMK_owner_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_salesroutingrun"></a> team_msdyn_salesroutingrun

One-To-Many Relationship: [team team_msdyn_salesroutingrun](team.md#BKMK_team_msdyn_salesroutingrun)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_salesroutingrun"></a> user_msdyn_salesroutingrun

One-To-Many Relationship: [systemuser user_msdyn_salesroutingrun](systemuser.md#BKMK_user_msdyn_salesroutingrun)

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

- [msdyn_salesroutingrun_AsyncOperations](#BKMK_msdyn_salesroutingrun_AsyncOperations)
- [msdyn_salesroutingrun_BulkDeleteFailures](#BKMK_msdyn_salesroutingrun_BulkDeleteFailures)
- [msdyn_salesroutingrun_DuplicateBaseRecord](#BKMK_msdyn_salesroutingrun_DuplicateBaseRecord)
- [msdyn_salesroutingrun_DuplicateMatchingRecord](#BKMK_msdyn_salesroutingrun_DuplicateMatchingRecord)
- [msdyn_salesroutingrun_MailboxTrackingFolders](#BKMK_msdyn_salesroutingrun_MailboxTrackingFolders)
- [msdyn_salesroutingrun_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesroutingrun_PrincipalObjectAttributeAccesses)
- [msdyn_salesroutingrun_ProcessSession](#BKMK_msdyn_salesroutingrun_ProcessSession)
- [msdyn_salesroutingrun_SyncErrors](#BKMK_msdyn_salesroutingrun_SyncErrors)

### <a name="BKMK_msdyn_salesroutingrun_AsyncOperations"></a> msdyn_salesroutingrun_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesroutingrun_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesroutingrun_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_BulkDeleteFailures"></a> msdyn_salesroutingrun_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesroutingrun_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesroutingrun_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_DuplicateBaseRecord"></a> msdyn_salesroutingrun_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesroutingrun_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salesroutingrun_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_DuplicateMatchingRecord"></a> msdyn_salesroutingrun_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesroutingrun_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salesroutingrun_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_MailboxTrackingFolders"></a> msdyn_salesroutingrun_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesroutingrun_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesroutingrun_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_PrincipalObjectAttributeAccesses"></a> msdyn_salesroutingrun_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesroutingrun_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesroutingrun_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_ProcessSession"></a> msdyn_salesroutingrun_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesroutingrun_ProcessSession](processsession.md#BKMK_msdyn_salesroutingrun_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingrun_SyncErrors"></a> msdyn_salesroutingrun_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesroutingrun_SyncErrors](syncerror.md#BKMK_msdyn_salesroutingrun_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingrun_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

