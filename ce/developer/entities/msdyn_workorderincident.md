---
title: "msdyn_workorderincident Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderincident entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_workorderincident Entity Reference

Specify work order incidents reported to you by the client. These are also referred to as problem codes.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderincidents<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderincidents<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderincidents(*msdyn_workorderincidentid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorderincidents|
|DisplayCollectionName|Work Order Incidents|
|DisplayName|Work Order Incident|
|EntitySetName|msdyn_workorderincidents|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorderincidents|
|LogicalName|msdyn_workorderincident|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_workorderincidentid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorderincident|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementBookingIncident](#BKMK_msdyn_AgreementBookingIncident)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_EstimatedDuration](#BKMK_msdyn_EstimatedDuration)
- [msdyn_IncidentResolved](#BKMK_msdyn_IncidentResolved)
- [msdyn_IncidentType](#BKMK_msdyn_IncidentType)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IsMobile](#BKMK_msdyn_IsMobile)
- [msdyn_IsPrimary](#BKMK_msdyn_IsPrimary)
- [msdyn_ItemsPopulated](#BKMK_msdyn_ItemsPopulated)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ResourceRequirement](#BKMK_msdyn_ResourceRequirement)
- [msdyn_TasksPercentCompleted](#BKMK_msdyn_TasksPercentCompleted)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_workorderincidentId](#BKMK_msdyn_workorderincidentId)
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


### <a name="BKMK_msdyn_AgreementBookingIncident"></a> msdyn_AgreementBookingIncident

|Property|Value|
|--------|-----|
|Description|Agreement Booking Incident linked to this Work Order Incident|
|DisplayName|Agreement Booking Incident|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingincident|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingincident|
|Type|Lookup|


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|--------|-----|
|Description|Customer Asset related to this incident reported|
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
|Description|Incident description|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_EstimatedDuration"></a> msdyn_EstimatedDuration

|Property|Value|
|--------|-----|
|Description|Shows the time estimated to resolve this incident.|
|DisplayName|Estimated Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatedduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_IncidentResolved"></a> msdyn_IncidentResolved

|Property|Value|
|--------|-----|
|Description|Shows if the incident has been resolved by one of its related tasks.|
|DisplayName|Incident Resolved|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_incidentresolved|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IncidentResolved Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IncidentType"></a> msdyn_IncidentType

|Property|Value|
|--------|-----|
|Description|Incident type reported|
|DisplayName|Incident Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_incidenttype|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_incidenttype|
|Type|Lookup|


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


### <a name="BKMK_msdyn_IsMobile"></a> msdyn_IsMobile

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Mobile|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ismobile|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsMobile Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsPrimary"></a> msdyn_IsPrimary

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Primary|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_isprimary|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_IsPrimary Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_ItemsPopulated"></a> msdyn_ItemsPopulated

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Items Populated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_itemspopulated|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_ItemsPopulated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



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
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceRequirement"></a> msdyn_ResourceRequirement

|Property|Value|
|--------|-----|
|Description|Resource Requirement|
|DisplayName|Resource Requirement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirement|
|RequiredLevel|None|
|Targets|msdyn_resourcerequirement|
|Type|Lookup|


### <a name="BKMK_msdyn_TasksPercentCompleted"></a> msdyn_TasksPercentCompleted

|Property|Value|
|--------|-----|
|Description|Shows the percent completed on associated tasks. This indicates the total of completed tasks, but not if the incident was resolved.|
|DisplayName|Tasks % Completed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taskspercentcompleted|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|Parent Work Order where incident was reported on|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_workorderincidentId"></a> msdyn_workorderincidentId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Work Order Incident|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderincidentid|
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
|Description|Status of the Work Order Incident|
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
|Description|Reason for the status of the Work Order Incident|
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
- [msdyn_AgreementBookingIncidentName](#BKMK_msdyn_AgreementBookingIncidentName)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_IncidentTypeName](#BKMK_msdyn_IncidentTypeName)
- [msdyn_ResourceRequirementName](#BKMK_msdyn_ResourceRequirementName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_AgreementBookingIncidentName"></a> msdyn_AgreementBookingIncidentName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingincidentname|
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


### <a name="BKMK_msdyn_IncidentTypeName"></a> msdyn_IncidentTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_incidenttypename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceRequirementName"></a> msdyn_ResourceRequirementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcerequirementname|
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

- [msdyn_workorderincident_ActivityPointers](#BKMK_msdyn_workorderincident_ActivityPointers)
- [msdyn_workorderincident_msdyn_approvals](#BKMK_msdyn_workorderincident_msdyn_approvals)
- [msdyn_workorderincident_msdyn_bookingalerts](#BKMK_msdyn_workorderincident_msdyn_bookingalerts)
- [msdyn_workorderincident_SyncErrors](#BKMK_msdyn_workorderincident_SyncErrors)
- [msdyn_workorderincident_DuplicateMatchingRecord](#BKMK_msdyn_workorderincident_DuplicateMatchingRecord)
- [msdyn_workorderincident_DuplicateBaseRecord](#BKMK_msdyn_workorderincident_DuplicateBaseRecord)
- [msdyn_workorderincident_SharePointDocumentLocations](#BKMK_msdyn_workorderincident_SharePointDocumentLocations)
- [msdyn_workorderincident_SharePointDocuments](#BKMK_msdyn_workorderincident_SharePointDocuments)
- [msdyn_workorderincident_AsyncOperations](#BKMK_msdyn_workorderincident_AsyncOperations)
- [msdyn_workorderincident_MailboxTrackingFolders](#BKMK_msdyn_workorderincident_MailboxTrackingFolders)
- [msdyn_workorderincident_UserEntityInstanceDatas](#BKMK_msdyn_workorderincident_UserEntityInstanceDatas)
- [msdyn_workorderincident_ProcessSession](#BKMK_msdyn_workorderincident_ProcessSession)
- [msdyn_workorderincident_BulkDeleteFailures](#BKMK_msdyn_workorderincident_BulkDeleteFailures)
- [msdyn_workorderincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses)
- [msdyn_workorderincident_Appointments](#BKMK_msdyn_workorderincident_Appointments)
- [msdyn_workorderincident_Emails](#BKMK_msdyn_workorderincident_Emails)
- [msdyn_workorderincident_Faxes](#BKMK_msdyn_workorderincident_Faxes)
- [msdyn_workorderincident_Letters](#BKMK_msdyn_workorderincident_Letters)
- [msdyn_workorderincident_PhoneCalls](#BKMK_msdyn_workorderincident_PhoneCalls)
- [msdyn_workorderincident_Tasks](#BKMK_msdyn_workorderincident_Tasks)
- [msdyn_workorderincident_RecurringAppointmentMasters](#BKMK_msdyn_workorderincident_RecurringAppointmentMasters)
- [msdyn_workorderincident_SocialActivities](#BKMK_msdyn_workorderincident_SocialActivities)
- [msdyn_workorderincident_connections1](#BKMK_msdyn_workorderincident_connections1)
- [msdyn_workorderincident_connections2](#BKMK_msdyn_workorderincident_connections2)
- [msdyn_workorderincident_QueueItems](#BKMK_msdyn_workorderincident_QueueItems)
- [msdyn_workorderincident_Annotations](#BKMK_msdyn_workorderincident_Annotations)
- [msdyn_workorderincident_ServiceAppointments](#BKMK_msdyn_workorderincident_ServiceAppointments)
- [msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident)
- [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident)


### <a name="BKMK_msdyn_workorderincident_ActivityPointers"></a> msdyn_workorderincident_ActivityPointers

Same as activitypointer entity [msdyn_workorderincident_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderincident_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_msdyn_approvals"></a> msdyn_workorderincident_msdyn_approvals

Same as msdyn_approval entity [msdyn_workorderincident_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderincident_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_msdyn_bookingalerts"></a> msdyn_workorderincident_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_workorderincident_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderincident_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_SyncErrors"></a> msdyn_workorderincident_SyncErrors

Same as syncerror entity [msdyn_workorderincident_SyncErrors](syncerror.md#BKMK_msdyn_workorderincident_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_DuplicateMatchingRecord"></a> msdyn_workorderincident_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorderincident_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderincident_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_DuplicateBaseRecord"></a> msdyn_workorderincident_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorderincident_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderincident_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_SharePointDocumentLocations"></a> msdyn_workorderincident_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_workorderincident_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderincident_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_SharePointDocuments"></a> msdyn_workorderincident_SharePointDocuments

Same as sharepointdocument entity [msdyn_workorderincident_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_workorderincident_SharePointDocuments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocument|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_SharePointDocuments|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 60|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_AsyncOperations"></a> msdyn_workorderincident_AsyncOperations

Same as asyncoperation entity [msdyn_workorderincident_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderincident_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_MailboxTrackingFolders"></a> msdyn_workorderincident_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderincident_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderincident_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_UserEntityInstanceDatas"></a> msdyn_workorderincident_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderincident_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderincident_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_ProcessSession"></a> msdyn_workorderincident_ProcessSession

Same as processsession entity [msdyn_workorderincident_ProcessSession](processsession.md#BKMK_msdyn_workorderincident_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_BulkDeleteFailures"></a> msdyn_workorderincident_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderincident_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderincident_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses"></a> msdyn_workorderincident_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderincident_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_Appointments"></a> msdyn_workorderincident_Appointments

Same as appointment entity [msdyn_workorderincident_Appointments](appointment.md#BKMK_msdyn_workorderincident_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_Emails"></a> msdyn_workorderincident_Emails

Same as email entity [msdyn_workorderincident_Emails](email.md#BKMK_msdyn_workorderincident_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_Faxes"></a> msdyn_workorderincident_Faxes

Same as fax entity [msdyn_workorderincident_Faxes](fax.md#BKMK_msdyn_workorderincident_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_Letters"></a> msdyn_workorderincident_Letters

Same as letter entity [msdyn_workorderincident_Letters](letter.md#BKMK_msdyn_workorderincident_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_PhoneCalls"></a> msdyn_workorderincident_PhoneCalls

Same as phonecall entity [msdyn_workorderincident_PhoneCalls](phonecall.md#BKMK_msdyn_workorderincident_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_Tasks"></a> msdyn_workorderincident_Tasks

Same as task entity [msdyn_workorderincident_Tasks](task.md#BKMK_msdyn_workorderincident_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_RecurringAppointmentMasters"></a> msdyn_workorderincident_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_workorderincident_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderincident_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_SocialActivities"></a> msdyn_workorderincident_SocialActivities

Same as socialactivity entity [msdyn_workorderincident_SocialActivities](socialactivity.md#BKMK_msdyn_workorderincident_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_connections1"></a> msdyn_workorderincident_connections1

Same as connection entity [msdyn_workorderincident_connections1](connection.md#BKMK_msdyn_workorderincident_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_connections2"></a> msdyn_workorderincident_connections2

Same as connection entity [msdyn_workorderincident_connections2](connection.md#BKMK_msdyn_workorderincident_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_QueueItems"></a> msdyn_workorderincident_QueueItems

Same as queueitem entity [msdyn_workorderincident_QueueItems](queueitem.md#BKMK_msdyn_workorderincident_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderincident_Annotations"></a> msdyn_workorderincident_Annotations

Same as annotation entity [msdyn_workorderincident_Annotations](annotation.md#BKMK_msdyn_workorderincident_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderincident_ServiceAppointments"></a> msdyn_workorderincident_ServiceAppointments

Same as serviceappointment entity [msdyn_workorderincident_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderincident_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderincident_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident

Same as msdyn_requirementcharacteristic entity [msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident](msdyn_requirementcharacteristic.md#BKMK_msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_requirementcharacteristic|
|ReferencingAttribute|msdyn_workorderincident|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderincident_msdyn_requirementcharacteristic_WorkOrderIncident|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Characteristics<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident

Same as msdyn_workordercharacteristic entity [msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident](msdyn_workordercharacteristic.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workordercharacteristic|
|ReferencingAttribute|msdyn_workorderincident|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderincident_msdyn_workordercharacteristic_WorkOrderIncident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident

Same as msdyn_workorderproduct entity [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_workorderincident|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident

Same as msdyn_workorderservice entity [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_workorderincident|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident

Same as msdyn_workorderservicetask entity [msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|msdyn_workorderincident|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderincident_msdyn_workorderservicetask_WorkOrderIncident|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Work Order Service Tasks<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderincident_createdby](#BKMK_lk_msdyn_workorderincident_createdby)
- [lk_msdyn_workorderincident_createdonbehalfby](#BKMK_lk_msdyn_workorderincident_createdonbehalfby)
- [lk_msdyn_workorderincident_modifiedby](#BKMK_lk_msdyn_workorderincident_modifiedby)
- [lk_msdyn_workorderincident_modifiedonbehalfby](#BKMK_lk_msdyn_workorderincident_modifiedonbehalfby)
- [user_msdyn_workorderincident](#BKMK_user_msdyn_workorderincident)
- [team_msdyn_workorderincident](#BKMK_team_msdyn_workorderincident)
- [business_unit_msdyn_workorderincident](#BKMK_business_unit_msdyn_workorderincident)
- [msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident](#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType)
- [msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement](#BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement)
- [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder)


### <a name="BKMK_lk_msdyn_workorderincident_createdby"></a> lk_msdyn_workorderincident_createdby

See systemuser Entity [lk_msdyn_workorderincident_createdby](systemuser.md#BKMK_lk_msdyn_workorderincident_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_createdonbehalfby"></a> lk_msdyn_workorderincident_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderincident_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderincident_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_modifiedby"></a> lk_msdyn_workorderincident_modifiedby

See systemuser Entity [lk_msdyn_workorderincident_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderincident_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderincident_modifiedonbehalfby"></a> lk_msdyn_workorderincident_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderincident_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderincident_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderincident"></a> user_msdyn_workorderincident

See systemuser Entity [user_msdyn_workorderincident](systemuser.md#BKMK_user_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderincident"></a> team_msdyn_workorderincident

See team Entity [team_msdyn_workorderincident](team.md#BKMK_team_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderincident"></a> business_unit_msdyn_workorderincident

See businessunit Entity [business_unit_msdyn_workorderincident](businessunit.md#BKMK_business_unit_msdyn_workorderincident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident"></a> msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident

See msdyn_agreementbookingincident Entity [msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_workorderincident_AgreementBookingIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType

See msdyn_incidenttype Entity [msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorderincident_IncidentType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement"></a> msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement

See msdyn_resourcerequirement Entity [msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_resourcerequirement_msdyn_workorderincident_ResourceRequirement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderincident?text=msdyn_workorderincident EntityType" />