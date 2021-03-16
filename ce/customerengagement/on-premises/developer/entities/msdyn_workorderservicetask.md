---
title: "msdyn_workorderservicetask Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderservicetask entity."
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
# msdyn_workorderservicetask Entity Reference

Store service tasks that are to be performed for this work order

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservicetasks(*msdyn_workorderservicetaskid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorderservicetasks|
|DisplayCollectionName|Work Order Service Tasks|
|DisplayName|Work Order Service Task|
|EntitySetName|msdyn_workorderservicetasks|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorderservicetasks|
|LogicalName|msdyn_workorderservicetask|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_workorderservicetaskid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorderservicetask|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ActualDuration](#BKMK_msdyn_ActualDuration)
- [msdyn_AgreementBookingServiceTask](#BKMK_msdyn_AgreementBookingServiceTask)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PercentComplete](#BKMK_msdyn_PercentComplete)
- [msdyn_TaskType](#BKMK_msdyn_TaskType)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
- [msdyn_workorderservicetaskId](#BKMK_msdyn_workorderservicetaskId)
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
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_ActualDuration"></a> msdyn_ActualDuration

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actualduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AgreementBookingServiceTask"></a> msdyn_AgreementBookingServiceTask

|Property|Value|
|--------|-----|
|Description|Agreement Booking Service Task linked to this Work Order Service Task|
|DisplayName|Agreement Booking Service Task|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingservicetask|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingservicetask|
|Type|Lookup|


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|Unique identifier for Resource Booking associated with Work Order Service Task.|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|--------|-----|
|Description|Unique identifier for Customer Asset associated with Work Order Service Task.|
|DisplayName|Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|--------|-----|
|Description|Shows the order of this task within the work order service tasks.|
|DisplayName|Line Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lineorder|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PercentComplete"></a> msdyn_PercentComplete

|Property|Value|
|--------|-----|
|Description||
|DisplayName|% Complete|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_percentcomplete|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_TaskType"></a> msdyn_TaskType

|Property|Value|
|--------|-----|
|Description|Unique identifier for Service Task Type associated with Work Order Service Task.|
|DisplayName|Task Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tasktype|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_servicetasktype|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Work Order Service Task.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order Incident associated with Work Order Service Task.|
|DisplayName|Work Order Incident|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderincident|
|RequiredLevel|None|
|Targets|msdyn_workorderincident|
|Type|Lookup|


### <a name="BKMK_msdyn_workorderservicetaskId"></a> msdyn_workorderservicetaskId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Work Order Service Task|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderservicetaskid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
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
|Description|Status of the Work Order Service Task|
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
|Description|Reason for the status of the Work Order Service Task|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
- [msdyn_AgreementBookingServiceTaskName](#BKMK_msdyn_AgreementBookingServiceTaskName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_TaskTypeName](#BKMK_msdyn_TaskTypeName)
- [msdyn_WorkOrderIncidentName](#BKMK_msdyn_WorkOrderIncidentName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_msdyn_AgreementBookingServiceTaskName"></a> msdyn_AgreementBookingServiceTaskName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingservicetaskname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TaskTypeName"></a> msdyn_TaskTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_tasktypename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderIncidentName"></a> msdyn_WorkOrderIncidentName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderincidentname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordername|
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

- [msdyn_workorderservicetask_ActivityPointers](#BKMK_msdyn_workorderservicetask_ActivityPointers)
- [msdyn_workorderservicetask_msdyn_bookingalerts](#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts)
- [msdyn_workorderservicetask_msdyn_approvals](#BKMK_msdyn_workorderservicetask_msdyn_approvals)
- [msdyn_workorderservicetask_SyncErrors](#BKMK_msdyn_workorderservicetask_SyncErrors)
- [msdyn_workorderservicetask_DuplicateMatchingRecord](#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)
- [msdyn_workorderservicetask_DuplicateBaseRecord](#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)
- [msdyn_workorderservicetask_SharePointDocumentLocations](#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations)
- [msdyn_workorderservicetask_AsyncOperations](#BKMK_msdyn_workorderservicetask_AsyncOperations)
- [msdyn_workorderservicetask_MailboxTrackingFolders](#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)
- [msdyn_workorderservicetask_ProcessSession](#BKMK_msdyn_workorderservicetask_ProcessSession)
- [msdyn_workorderservicetask_BulkDeleteFailures](#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)
- [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservicetask_Appointments](#BKMK_msdyn_workorderservicetask_Appointments)
- [msdyn_workorderservicetask_Emails](#BKMK_msdyn_workorderservicetask_Emails)
- [msdyn_workorderservicetask_Faxes](#BKMK_msdyn_workorderservicetask_Faxes)
- [msdyn_workorderservicetask_Letters](#BKMK_msdyn_workorderservicetask_Letters)
- [msdyn_workorderservicetask_PhoneCalls](#BKMK_msdyn_workorderservicetask_PhoneCalls)
- [msdyn_workorderservicetask_Tasks](#BKMK_msdyn_workorderservicetask_Tasks)
- [msdyn_workorderservicetask_RecurringAppointmentMasters](#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters)
- [msdyn_workorderservicetask_SocialActivities](#BKMK_msdyn_workorderservicetask_SocialActivities)
- [msdyn_workorderservicetask_connections1](#BKMK_msdyn_workorderservicetask_connections1)
- [msdyn_workorderservicetask_connections2](#BKMK_msdyn_workorderservicetask_connections2)
- [msdyn_workorderservicetask_QueueItems](#BKMK_msdyn_workorderservicetask_QueueItems)
- [msdyn_workorderservicetask_Annotations](#BKMK_msdyn_workorderservicetask_Annotations)
- [msdyn_workorderservicetask_ServiceAppointments](#BKMK_msdyn_workorderservicetask_ServiceAppointments)


### <a name="BKMK_msdyn_workorderservicetask_ActivityPointers"></a> msdyn_workorderservicetask_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_workorderservicetask_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderservicetask_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_msdyn_bookingalerts"></a> msdyn_workorderservicetask_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_workorderservicetask_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderservicetask_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_msdyn_approvals"></a> msdyn_workorderservicetask_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_workorderservicetask_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderservicetask_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_SyncErrors"></a> msdyn_workorderservicetask_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_workorderservicetask_SyncErrors](syncerror.md#BKMK_msdyn_workorderservicetask_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord"></a> msdyn_workorderservicetask_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorderservicetask_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_DuplicateBaseRecord"></a> msdyn_workorderservicetask_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorderservicetask_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_SharePointDocumentLocations"></a> msdyn_workorderservicetask_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_workorderservicetask_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderservicetask_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_AsyncOperations"></a> msdyn_workorderservicetask_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_workorderservicetask_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderservicetask_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_MailboxTrackingFolders"></a> msdyn_workorderservicetask_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_workorderservicetask_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_ProcessSession"></a> msdyn_workorderservicetask_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_workorderservicetask_ProcessSession](processsession.md#BKMK_msdyn_workorderservicetask_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_BulkDeleteFailures"></a> msdyn_workorderservicetask_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_workorderservicetask_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderservicetask_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservicetask_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_Appointments"></a> msdyn_workorderservicetask_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_workorderservicetask_Appointments](appointment.md#BKMK_msdyn_workorderservicetask_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_Emails"></a> msdyn_workorderservicetask_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_workorderservicetask_Emails](email.md#BKMK_msdyn_workorderservicetask_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_Faxes"></a> msdyn_workorderservicetask_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_workorderservicetask_Faxes](fax.md#BKMK_msdyn_workorderservicetask_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_Letters"></a> msdyn_workorderservicetask_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_workorderservicetask_Letters](letter.md#BKMK_msdyn_workorderservicetask_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_PhoneCalls"></a> msdyn_workorderservicetask_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_workorderservicetask_PhoneCalls](phonecall.md#BKMK_msdyn_workorderservicetask_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_Tasks"></a> msdyn_workorderservicetask_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_workorderservicetask_Tasks](task.md#BKMK_msdyn_workorderservicetask_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters"></a> msdyn_workorderservicetask_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_workorderservicetask_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderservicetask_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_SocialActivities"></a> msdyn_workorderservicetask_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_workorderservicetask_SocialActivities](socialactivity.md#BKMK_msdyn_workorderservicetask_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_connections1"></a> msdyn_workorderservicetask_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderservicetask_connections1](connection.md#BKMK_msdyn_workorderservicetask_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_connections2"></a> msdyn_workorderservicetask_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderservicetask_connections2](connection.md#BKMK_msdyn_workorderservicetask_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_QueueItems"></a> msdyn_workorderservicetask_QueueItems

**Added by**: System Solution Solution

Same as queueitem entity [msdyn_workorderservicetask_QueueItems](queueitem.md#BKMK_msdyn_workorderservicetask_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservicetask_Annotations"></a> msdyn_workorderservicetask_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_workorderservicetask_Annotations](annotation.md#BKMK_msdyn_workorderservicetask_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservicetask_ServiceAppointments"></a> msdyn_workorderservicetask_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_workorderservicetask_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderservicetask_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservicetask_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderservicetask_createdby](#BKMK_lk_msdyn_workorderservicetask_createdby)
- [lk_msdyn_workorderservicetask_createdonbehalfby](#BKMK_lk_msdyn_workorderservicetask_createdonbehalfby)
- [lk_msdyn_workorderservicetask_modifiedby](#BKMK_lk_msdyn_workorderservicetask_modifiedby)
- [lk_msdyn_workorderservicetask_modifiedonbehalfby](#BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby)
- [user_msdyn_workorderservicetask](#BKMK_user_msdyn_workorderservicetask)
- [team_msdyn_workorderservicetask](#BKMK_team_msdyn_workorderservicetask)
- [business_unit_msdyn_workorderservicetask](#BKMK_business_unit_msdyn_workorderservicetask)
- [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking)
- [msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)
- [msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType](#BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType)
- [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident)


### <a name="BKMK_lk_msdyn_workorderservicetask_createdby"></a> lk_msdyn_workorderservicetask_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservicetask_createdby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservicetask_createdonbehalfby"></a> lk_msdyn_workorderservicetask_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservicetask_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservicetask_modifiedby"></a> lk_msdyn_workorderservicetask_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservicetask_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby"></a> lk_msdyn_workorderservicetask_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservicetask_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservicetask_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderservicetask"></a> user_msdyn_workorderservicetask

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_workorderservicetask](systemuser.md#BKMK_user_msdyn_workorderservicetask) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderservicetask"></a> team_msdyn_workorderservicetask

**Added by**: System Solution Solution

See team Entity [team_msdyn_workorderservicetask](team.md#BKMK_team_msdyn_workorderservicetask) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderservicetask"></a> business_unit_msdyn_workorderservicetask

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_workorderservicetask](businessunit.md#BKMK_business_unit_msdyn_workorderservicetask) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservicetask_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask"></a> msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask

See msdyn_agreementbookingservicetask Entity [msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreementbookingservicetask_msdyn_workorderservicetask_AgreementBookingServiceTask) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType"></a> msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType

See msdyn_servicetasktype Entity [msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType](msdyn_servicetasktype.md#BKMK_msdyn_msdyn_servicetasktype_msdyn_workorderservicetask_TaskType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident

See msdyn_workorderincident Entity [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderservicetask?text=msdyn_workorderservicetask EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]