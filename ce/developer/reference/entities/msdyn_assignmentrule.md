---
title: "Assignment Rule (msdyn_assignmentrule) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Assignment Rule (msdyn_assignmentrule) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Assignment Rule (msdyn_assignmentrule) table/entity reference (Microsoft Dynamics 365)

Defines criteria based on which Entities are routed to Users or Sales Team

## Messages

The following table lists the messages for the Assignment Rule (msdyn_assignmentrule) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_assignmentrules<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_assignmentrules<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_assignmentrules(*msdyn_assignmentruleid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Assignment Rule (msdyn_assignmentrule) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Assignment Rule** |
| **DisplayCollectionName** | **assignmentrules** |
| **SchemaName** | `msdyn_assignmentrule` |
| **CollectionSchemaName** | `msdyn_assignmentrules` |
| **EntitySetName** | `msdyn_assignmentrules`|
| **LogicalName** | `msdyn_assignmentrule` |
| **LogicalCollectionName** | `msdyn_assignmentrules` |
| **PrimaryIdAttribute** | `msdyn_assignmentruleid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_assignmentruleId](#BKMK_msdyn_assignmentruleId)
- [msdyn_assignmentwindow](#BKMK_msdyn_assignmentwindow)
- [msdyn_attributefilter](#BKMK_msdyn_attributefilter)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DistributeTo](#BKMK_msdyn_DistributeTo)
- [msdyn_distributewithavailability](#BKMK_msdyn_distributewithavailability)
- [msdyn_distributewithcapacity](#BKMK_msdyn_distributewithcapacity)
- [msdyn_distributewithrecordcreation](#BKMK_msdyn_distributewithrecordcreation)
- [msdyn_DistributionType](#BKMK_msdyn_DistributionType)
- [msdyn_entityfilter](#BKMK_msdyn_entityfilter)
- [msdyn_evaluateentitymatchindataverse](#BKMK_msdyn_evaluateentitymatchindataverse)
- [msdyn_evaluateownermatchindataverse](#BKMK_msdyn_evaluateownermatchindataverse)
- [msdyn_evaluationorder](#BKMK_msdyn_evaluationorder)
- [msdyn_matchedrecords](#BKMK_msdyn_matchedrecords)
- [msdyn_matchtype](#BKMK_msdyn_matchtype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_objecttype](#BKMK_msdyn_objecttype)
- [msdyn_objecttypecode](#BKMK_msdyn_objecttypecode)
- [msdyn_recordcreationwindow](#BKMK_msdyn_recordcreationwindow)
- [msdyn_segmentid](#BKMK_msdyn_segmentid)
- [msdyn_sellerfilter](#BKMK_msdyn_sellerfilter)
- [msdyn_SpecificSellersOrTeams](#BKMK_msdyn_SpecificSellersOrTeams)
- [msdyn_triggertype](#BKMK_msdyn_triggertype)
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

### <a name="BKMK_msdyn_assignmentruleId"></a> msdyn_assignmentruleId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Assignment Rule**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_assignmentruleid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_assignmentwindow"></a> msdyn_assignmentwindow

|Property|Value|
|---|---|
|Description|**Assignment due in**|
|DisplayName|**Assignment due in**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignmentwindow`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|120|
|MinValue|0|

### <a name="BKMK_msdyn_attributefilter"></a> msdyn_attributefilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Attribute Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_attributefilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_DistributeTo"></a> msdyn_DistributeTo

|Property|Value|
|---|---|
|Description|**Setting depecting if the assignment is done for a team, queue or a seller.**|
|DisplayName|**Assign to Sellers, Teams or Queues.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_distributeto`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_distributeto`|

#### msdyn_DistributeTo Choices/Options

|Value|Label|
|---|---|
|0|**Sellers**|
|1|**Team**|
|2|**Queue**|

### <a name="BKMK_msdyn_distributewithavailability"></a> msdyn_distributewithavailability

|Property|Value|
|---|---|
|Description||
|DisplayName|**DistributeWithAvailability**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_distributewithavailability`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_assignmentrule_msdyn_distributewithavailability`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_distributewithcapacity"></a> msdyn_distributewithcapacity

|Property|Value|
|---|---|
|Description||
|DisplayName|**DistributeWithCapacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_distributewithcapacity`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_assignmentrule_msdyn_distributewithcapacity`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_distributewithrecordcreation"></a> msdyn_distributewithrecordcreation

|Property|Value|
|---|---|
|Description|**CheckEligibilityByRecordAge**|
|DisplayName|**CheckEligibilityByRecordAge**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_distributewithrecordcreation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_assignmentrule_msdyn_distributewithrecordcreation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DistributionType"></a> msdyn_DistributionType

|Property|Value|
|---|---|
|Description||
|DisplayName|**DistributionType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_distributiontype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_distributiontype`|

#### msdyn_DistributionType Choices/Options

|Value|Label|
|---|---|
|0|**RoundRobin**|
|1|**Load Balancing**|
|2|**Assign to any one team at random**|
|3|**Don't assign to any team**|
|4|**Add to any one queue at random**|
|5|**Don't add to any queue**|

### <a name="BKMK_msdyn_entityfilter"></a> msdyn_entityfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityfilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_evaluateentitymatchindataverse"></a> msdyn_evaluateentitymatchindataverse

|Property|Value|
|---|---|
|Description|**Value indicating if the entity match for the rule needs to be evaluated within Dataverse**|
|DisplayName|**Evaluate entity match in Dataverse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluateentitymatchindataverse`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_evaluateentitymatchindataverse`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_evaluateownermatchindataverse"></a> msdyn_evaluateownermatchindataverse

|Property|Value|
|---|---|
|Description|**Value indicating if the owner match for the rule needs to be evaluated within Dataverse**|
|DisplayName|**Evaluate owner match in Dataverse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluateownermatchindataverse`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_evaluateownermatchindataverse`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_evaluationorder"></a> msdyn_evaluationorder

|Property|Value|
|---|---|
|Description|**Evaluation order of the rule**|
|DisplayName|**EvaluationOrder**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_evaluationorder`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_matchedrecords"></a> msdyn_matchedrecords

|Property|Value|
|---|---|
|Description|**Records routed by this rule**|
|DisplayName|**Records Routed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_matchedrecords`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_matchtype"></a> msdyn_matchtype

|Property|Value|
|---|---|
|Description|**Setting depecting if the seller or team assignment needs to be done either by filtering attributes or by specifying sellers or teams**|
|DisplayName|**MatchType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_matchtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_matchtype`|

#### msdyn_matchtype Choices/Options

|Value|Label|
|---|---|
|0|**Filter using Attributes**|
|1|**Specific List**|
|2|**Any Sellers**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Assignment Rule**|
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

### <a name="BKMK_msdyn_objecttype"></a> msdyn_objecttype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Reference to the related entity logical name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objecttype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_objecttypecode"></a> msdyn_objecttypecode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_objecttypecode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|4|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_objecttypecode`|

#### msdyn_objecttypecode Choices/Options

|Value|Label|
|---|---|
|3|**Opportunity**|
|4|**Lead**|
|5|**Other**|

### <a name="BKMK_msdyn_recordcreationwindow"></a> msdyn_recordcreationwindow

|Property|Value|
|---|---|
|Description|**Assignment due in**|
|DisplayName|**Assignment due in**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recordcreationwindow`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|120|
|MinValue|0|

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

### <a name="BKMK_msdyn_sellerfilter"></a> msdyn_sellerfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Seller Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sellerfilter`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_SpecificSellersOrTeams"></a> msdyn_SpecificSellersOrTeams

|Property|Value|
|---|---|
|Description|**List of specific sellers or teams that needs to be assigned.**|
|DisplayName|**Sellers or Team.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_SpecificSellersOrTeams`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_triggertype"></a> msdyn_triggertype

|Property|Value|
|---|---|
|Description|**Trigger when the rule needs to be evaluated**|
|DisplayName|**TriggerType**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_triggertype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_assignmentrule_msdyn_triggertype`|

#### msdyn_triggertype Choices/Options

|Value|Label|
|---|---|
|0|**Entity Create**|
|1|**FieldUpdate**|

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
|Description|**Status of the Assignment Rule**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_assignmentrule_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Assignment Rule**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_assignmentrule_statuscode`|

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

- [business_unit_msdyn_assignmentrule](#BKMK_business_unit_msdyn_assignmentrule)
- [lk_msdyn_assignmentrule_createdby](#BKMK_lk_msdyn_assignmentrule_createdby)
- [lk_msdyn_assignmentrule_createdonbehalfby](#BKMK_lk_msdyn_assignmentrule_createdonbehalfby)
- [lk_msdyn_assignmentrule_modifiedby](#BKMK_lk_msdyn_assignmentrule_modifiedby)
- [lk_msdyn_assignmentrule_modifiedonbehalfby](#BKMK_lk_msdyn_assignmentrule_modifiedonbehalfby)
- [msdyn_msdyn_segment_msdyn_assignmentrule_segment](#BKMK_msdyn_msdyn_segment_msdyn_assignmentrule_segment)
- [owner_msdyn_assignmentrule](#BKMK_owner_msdyn_assignmentrule)
- [team_msdyn_assignmentrule](#BKMK_team_msdyn_assignmentrule)
- [user_msdyn_assignmentrule](#BKMK_user_msdyn_assignmentrule)

### <a name="BKMK_business_unit_msdyn_assignmentrule"></a> business_unit_msdyn_assignmentrule

One-To-Many Relationship: [businessunit business_unit_msdyn_assignmentrule](businessunit.md#BKMK_business_unit_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_assignmentrule_createdby"></a> lk_msdyn_assignmentrule_createdby

One-To-Many Relationship: [systemuser lk_msdyn_assignmentrule_createdby](systemuser.md#BKMK_lk_msdyn_assignmentrule_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_assignmentrule_createdonbehalfby"></a> lk_msdyn_assignmentrule_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_assignmentrule_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_assignmentrule_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_assignmentrule_modifiedby"></a> lk_msdyn_assignmentrule_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_assignmentrule_modifiedby](systemuser.md#BKMK_lk_msdyn_assignmentrule_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_assignmentrule_modifiedonbehalfby"></a> lk_msdyn_assignmentrule_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_assignmentrule_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_assignmentrule_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_segment_msdyn_assignmentrule_segment"></a> msdyn_msdyn_segment_msdyn_assignmentrule_segment

One-To-Many Relationship: [msdyn_segment msdyn_msdyn_segment_msdyn_assignmentrule_segment](msdyn_segment.md#BKMK_msdyn_msdyn_segment_msdyn_assignmentrule_segment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_segment`|
|ReferencedAttribute|`msdyn_segmentid`|
|ReferencingAttribute|`msdyn_segmentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_segmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_assignmentrule"></a> owner_msdyn_assignmentrule

One-To-Many Relationship: [owner owner_msdyn_assignmentrule](owner.md#BKMK_owner_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_assignmentrule"></a> team_msdyn_assignmentrule

One-To-Many Relationship: [team team_msdyn_assignmentrule](team.md#BKMK_team_msdyn_assignmentrule)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_assignmentrule"></a> user_msdyn_assignmentrule

One-To-Many Relationship: [systemuser user_msdyn_assignmentrule](systemuser.md#BKMK_user_msdyn_assignmentrule)

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

- [msdyn_assignmentrule_AsyncOperations](#BKMK_msdyn_assignmentrule_AsyncOperations)
- [msdyn_assignmentrule_BulkDeleteFailures](#BKMK_msdyn_assignmentrule_BulkDeleteFailures)
- [msdyn_assignmentrule_connections1](#BKMK_msdyn_assignmentrule_connections1)
- [msdyn_assignmentrule_connections2](#BKMK_msdyn_assignmentrule_connections2)
- [msdyn_assignmentrule_MailboxTrackingFolders](#BKMK_msdyn_assignmentrule_MailboxTrackingFolders)
- [msdyn_assignmentrule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_assignmentrule_PrincipalObjectAttributeAccesses)
- [msdyn_assignmentrule_ProcessSession](#BKMK_msdyn_assignmentrule_ProcessSession)
- [msdyn_assignmentrule_suggestionassignmentrule_lookup](#BKMK_msdyn_assignmentrule_suggestionassignmentrule_lookup)
- [msdyn_assignmentrule_SyncErrors](#BKMK_msdyn_assignmentrule_SyncErrors)
- [msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule](#BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule)

### <a name="BKMK_msdyn_assignmentrule_AsyncOperations"></a> msdyn_assignmentrule_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_assignmentrule_AsyncOperations](asyncoperation.md#BKMK_msdyn_assignmentrule_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_BulkDeleteFailures"></a> msdyn_assignmentrule_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_assignmentrule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_assignmentrule_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_connections1"></a> msdyn_assignmentrule_connections1

Many-To-One Relationship: [connection msdyn_assignmentrule_connections1](connection.md#BKMK_msdyn_assignmentrule_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_connections2"></a> msdyn_assignmentrule_connections2

Many-To-One Relationship: [connection msdyn_assignmentrule_connections2](connection.md#BKMK_msdyn_assignmentrule_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_MailboxTrackingFolders"></a> msdyn_assignmentrule_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_assignmentrule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_assignmentrule_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_PrincipalObjectAttributeAccesses"></a> msdyn_assignmentrule_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_assignmentrule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_assignmentrule_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_ProcessSession"></a> msdyn_assignmentrule_ProcessSession

Many-To-One Relationship: [processsession msdyn_assignmentrule_ProcessSession](processsession.md#BKMK_msdyn_assignmentrule_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_suggestionassignmentrule_lookup"></a> msdyn_assignmentrule_suggestionassignmentrule_lookup

Many-To-One Relationship: [msdyn_suggestionassignmentrule msdyn_assignmentrule_suggestionassignmentrule_lookup](msdyn_suggestionassignmentrule.md#BKMK_msdyn_assignmentrule_suggestionassignmentrule_lookup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_suggestionassignmentrule`|
|ReferencingAttribute|`msdyn_assignmentruleid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_suggestionassignmentrule_lookup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_assignmentrule_SyncErrors"></a> msdyn_assignmentrule_SyncErrors

Many-To-One Relationship: [syncerror msdyn_assignmentrule_SyncErrors](syncerror.md#BKMK_msdyn_assignmentrule_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_assignmentrule_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule"></a> msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule](msdyn_salesroutingrun.md#BKMK_msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_assignmentruleid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_assignmentrule_msdyn_salesroutingrun_assignmentrule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

