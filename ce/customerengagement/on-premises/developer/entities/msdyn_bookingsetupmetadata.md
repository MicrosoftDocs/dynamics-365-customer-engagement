---
title: "msdyn_bookingsetupmetadata Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bookingsetupmetadata entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_bookingsetupmetadata Entity Reference



**Added by**: Universal Resource Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bookingsetupmetadatas(*msdyn_bookingsetupmetadataid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_bookingsetupmetadatas|
|DisplayCollectionName|Booking Setup Metadata Records|
|DisplayName|Booking Setup Metadata|
|EntitySetName|msdyn_bookingsetupmetadatas|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_bookingsetupmetadatas|
|LogicalName|msdyn_bookingsetupmetadata|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_bookingsetupmetadataid|
|PrimaryNameAttribute|msdyn_entitylogicalname|
|SchemaName|msdyn_bookingsetupmetadata|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AvailableDurationMinimumPercentage](#BKMK_msdyn_AvailableDurationMinimumPercentage)
- [msdyn_BookingRelationshipLogicalName](#BKMK_msdyn_BookingRelationshipLogicalName)
- [msdyn_bookingsetupmetadataId](#BKMK_msdyn_bookingsetupmetadataId)
- [msdyn_BookingStatusFieldLogicalName](#BKMK_msdyn_BookingStatusFieldLogicalName)
- [msdyn_CancelBookingsWhenMoving](#BKMK_msdyn_CancelBookingsWhenMoving)
- [msdyn_CloneEntityQuery](#BKMK_msdyn_CloneEntityQuery)
- [msdyn_DefaultBookingCanceledStatus](#BKMK_msdyn_DefaultBookingCanceledStatus)
- [msdyn_DefaultBookingCommittedStatus](#BKMK_msdyn_DefaultBookingCommittedStatus)
- [msdyn_DefaultBookingDuration](#BKMK_msdyn_DefaultBookingDuration)
- [msdyn_DefaultRequirementActiveStatus](#BKMK_msdyn_DefaultRequirementActiveStatus)
- [msdyn_DefaultRequirementCanceledStatus](#BKMK_msdyn_DefaultRequirementCanceledStatus)
- [msdyn_DefaultRequirementCompletedStatus](#BKMK_msdyn_DefaultRequirementCompletedStatus)
- [msdyn_DisableRequirementAutoCreation](#BKMK_msdyn_DisableRequirementAutoCreation)
- [msdyn_EntityLogicalName](#BKMK_msdyn_EntityLogicalName)
- [msdyn_RequirementRelationshipLogicalName](#BKMK_msdyn_RequirementRelationshipLogicalName)
- [msdyn_ResourceAvailabilityRetrievalLimit](#BKMK_msdyn_ResourceAvailabilityRetrievalLimit)
- [msdyn_RetrieveConstraintsQuery](#BKMK_msdyn_RetrieveConstraintsQuery)
- [msdyn_RetrieveResourcesQuery](#BKMK_msdyn_RetrieveResourcesQuery)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_AvailableDurationMinimumPercentage"></a> msdyn_AvailableDurationMinimumPercentage

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Available Duration Minimum(%)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_availabledurationminimumpercentage|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_BookingRelationshipLogicalName"></a> msdyn_BookingRelationshipLogicalName

|Property|Value|
|--------|-----|
|Description|A unique identifier that links bookings to a scheduling entity.|
|DisplayName|Booking Relationship Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingrelationshiplogicalname|
|MaxLength|450|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_bookingsetupmetadataId"></a> msdyn_bookingsetupmetadataId

|Property|Value|
|--------|-----|
|Description|A unique identifier for an entity instance.|
|DisplayName|Booking Setup Metadata|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_bookingsetupmetadataid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_BookingStatusFieldLogicalName"></a> msdyn_BookingStatusFieldLogicalName

|Property|Value|
|--------|-----|
|Description|An option set that is used to group and filter statuses.|
|DisplayName|Booking Status Field Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingstatusfieldlogicalname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CancelBookingsWhenMoving"></a> msdyn_CancelBookingsWhenMoving

|Property|Value|
|--------|-----|
|Description|Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."|
|DisplayName|Cancel Bookings When Moving|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_cancelbookingswhenmoving|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_CancelBookingsWhenMoving Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_CloneEntityQuery"></a> msdyn_CloneEntityQuery

|Property|Value|
|--------|-----|
|Description|Query for retrieving resource requirements for cloning.|
|DisplayName|Clone Entity Query|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_cloneentityquery|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultBookingCanceledStatus"></a> msdyn_DefaultBookingCanceledStatus

|Property|Value|
|--------|-----|
|Description|The default booking canceled status to use when a user can't select a status.|
|DisplayName|Default Booking Canceled Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingcanceledstatus|
|RequiredLevel|None|
|Targets|bookingstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultBookingCommittedStatus"></a> msdyn_DefaultBookingCommittedStatus

|Property|Value|
|--------|-----|
|Description|The default booking committed status to use when a user can't select a status.|
|DisplayName|Default Booking Committed Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingcommittedstatus|
|RequiredLevel|None|
|Targets|bookingstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

|Property|Value|
|--------|-----|
|Description|The default booking duration to use when a duration is not provided.|
|DisplayName|Default Booking Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DefaultRequirementActiveStatus"></a> msdyn_DefaultRequirementActiveStatus

|Property|Value|
|--------|-----|
|Description|The default requirement active status to use when a user can't select a status|
|DisplayName|Default Requirement Active Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementactivestatus|
|RequiredLevel|None|
|Targets|msdyn_requirementstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultRequirementCanceledStatus"></a> msdyn_DefaultRequirementCanceledStatus

|Property|Value|
|--------|-----|
|Description|The default requirement canceled status to use when a user can't select a status.|
|DisplayName|Default Requirement Canceled Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementcanceledstatus|
|RequiredLevel|None|
|Targets|msdyn_requirementstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultRequirementCompletedStatus"></a> msdyn_DefaultRequirementCompletedStatus

|Property|Value|
|--------|-----|
|Description|The default requirement completed status to use when a user can't select a status.|
|DisplayName|Default Requirement Completed Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementcompletedstatus|
|RequiredLevel|None|
|Targets|msdyn_requirementstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DisableRequirementAutoCreation"></a> msdyn_DisableRequirementAutoCreation

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Disable Requirement Auto Creation for Bookings|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_disablerequirementautocreation|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DisableRequirementAutoCreation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_EntityLogicalName"></a> msdyn_EntityLogicalName

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Entity Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitylogicalname|
|MaxLength|450|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_RequirementRelationshipLogicalName"></a> msdyn_RequirementRelationshipLogicalName

|Property|Value|
|--------|-----|
|Description|A unique identifier that links requirements to an enabled scheduling entity.|
|DisplayName|Requirement Relationship Logical Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_requirementrelationshiplogicalname|
|MaxLength|450|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_ResourceAvailabilityRetrievalLimit"></a> msdyn_ResourceAvailabilityRetrievalLimit

|Property|Value|
|--------|-----|
|Description|The maximum number of resources to retrieve and show in schedule assistant.|
|DisplayName|Resource Availability Retrieval Limit|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourceavailabilityretrievallimit|
|MaxValue|1000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_RetrieveConstraintsQuery"></a> msdyn_RetrieveConstraintsQuery

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Retrieve Constraints Query|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveconstraintsquery|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Retrieve Resources Query|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveresourcesquery|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


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


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Booking Setup Metadata|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Booking Setup Metadata|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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
- [msdyn_CloneEntityQueryName](#BKMK_msdyn_CloneEntityQueryName)
- [msdyn_DefaultBookingCanceledStatusName](#BKMK_msdyn_DefaultBookingCanceledStatusName)
- [msdyn_DefaultBookingCommittedStatusName](#BKMK_msdyn_DefaultBookingCommittedStatusName)
- [msdyn_DefaultRequirementActiveStatusName](#BKMK_msdyn_DefaultRequirementActiveStatusName)
- [msdyn_DefaultRequirementCanceledStatusName](#BKMK_msdyn_DefaultRequirementCanceledStatusName)
- [msdyn_DefaultRequirementCompletedStatusName](#BKMK_msdyn_DefaultRequirementCompletedStatusName)
- [msdyn_RetrieveConstraintsQueryName](#BKMK_msdyn_RetrieveConstraintsQueryName)
- [msdyn_RetrieveResourcesQueryName](#BKMK_msdyn_RetrieveResourcesQueryName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_CloneEntityQueryName"></a> msdyn_CloneEntityQueryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_cloneentityqueryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultBookingCanceledStatusName"></a> msdyn_DefaultBookingCanceledStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingcanceledstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultBookingCommittedStatusName"></a> msdyn_DefaultBookingCommittedStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingcommittedstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultRequirementActiveStatusName"></a> msdyn_DefaultRequirementActiveStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementactivestatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultRequirementCanceledStatusName"></a> msdyn_DefaultRequirementCanceledStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementcanceledstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultRequirementCompletedStatusName"></a> msdyn_DefaultRequirementCompletedStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultrequirementcompletedstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RetrieveConstraintsQueryName"></a> msdyn_RetrieveConstraintsQueryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveconstraintsqueryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RetrieveResourcesQueryName"></a> msdyn_RetrieveResourcesQueryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveresourcesqueryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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

- [msdyn_bookingsetupmetadata_SyncErrors](#BKMK_msdyn_bookingsetupmetadata_SyncErrors)
- [msdyn_bookingsetupmetadata_AsyncOperations](#BKMK_msdyn_bookingsetupmetadata_AsyncOperations)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_ProcessSession](#BKMK_msdyn_bookingsetupmetadata_ProcessSession)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking)
- [msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement)


### <a name="BKMK_msdyn_bookingsetupmetadata_SyncErrors"></a> msdyn_bookingsetupmetadata_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_bookingsetupmetadata_SyncErrors](syncerror.md#BKMK_msdyn_bookingsetupmetadata_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingsetupmetadata_AsyncOperations"></a> msdyn_bookingsetupmetadata_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_bookingsetupmetadata_AsyncOperations](asyncoperation.md#BKMK_msdyn_bookingsetupmetadata_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_bookingsetupmetadata_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingsetupmetadata_ProcessSession"></a> msdyn_bookingsetupmetadata_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_bookingsetupmetadata_ProcessSession](processsession.md#BKMK_msdyn_bookingsetupmetadata_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_bookingsetupmetadata_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking"></a> msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking

Same as bookableresourcebooking entity [msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking](bookableresourcebooking.md#BKMK_msdyn_msdyn_bookingsetupmetadata_bookableresourcebooking) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|msdyn_bookingsetupmetadataid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_bookingsetupmetadata_bookableresour|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement"></a> msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement

Same as msdyn_resourcerequirement entity [msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_bookingsetupmetadata_msdyn_resourcerequirement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcerequirement|
|ReferencingAttribute|msdyn_bookingsetupmetadataid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_bookingsetupmetadata_msdyn_resource|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Requirements<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_bookingsetupmetadata_createdby](#BKMK_lk_msdyn_bookingsetupmetadata_createdby)
- [lk_msdyn_bookingsetupmetadata_createdonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby)
- [lk_msdyn_bookingsetupmetadata_modifiedby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby)
- [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby)
- [user_msdyn_bookingsetupmetadata](#BKMK_user_msdyn_bookingsetupmetadata)
- [team_msdyn_bookingsetupmetadata](#BKMK_team_msdyn_bookingsetupmetadata)
- [business_unit_msdyn_bookingsetupmetadata](#BKMK_business_unit_msdyn_bookingsetupmetadata)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus)
- [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus)
- [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus)


### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdby"></a> lk_msdyn_bookingsetupmetadata_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bookingsetupmetadata_createdby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby"></a> lk_msdyn_bookingsetupmetadata_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bookingsetupmetadata_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedby"></a> lk_msdyn_bookingsetupmetadata_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bookingsetupmetadata_modifiedby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby"></a> lk_msdyn_bookingsetupmetadata_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_bookingsetupmetadata_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bookingsetupmetadata_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_bookingsetupmetadata"></a> user_msdyn_bookingsetupmetadata

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_bookingsetupmetadata](systemuser.md#BKMK_user_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_team_msdyn_bookingsetupmetadata"></a> team_msdyn_bookingsetupmetadata

**Added by**: System Solution Solution

See team Entity [team_msdyn_bookingsetupmetadata](team.md#BKMK_team_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_bookingsetupmetadata"></a> business_unit_msdyn_bookingsetupmetadata

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_bookingsetupmetadata](businessunit.md#BKMK_business_unit_msdyn_bookingsetupmetadata) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus

**Added by**: Scheduling Solution

See bookingstatus Entity [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCanceledStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus"></a> msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus

**Added by**: Scheduling Solution

See bookingstatus Entity [msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_bookingsetupmetadata_DefaultBookingCommittedStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementActiveStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCanceledStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus"></a> msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus

See msdyn_requirementstatus Entity [msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus](msdyn_requirementstatus.md#BKMK_msdyn_msdyn_requirementstatus_msdyn_bookingsetupmetadata_DefaultRequirementCompletedStatus) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bookingsetupmetadata?text=msdyn_bookingsetupmetadata EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]