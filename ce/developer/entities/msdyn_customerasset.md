---
title: "msdyn_customerasset Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_customerasset entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_customerasset Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_customerassets<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_customerassets<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Customer Asset<br />
**DisplayCollectionName**: Customer Assets<br />
**SchemaName**: msdyn_customerasset<br />
**CollectionSchemaName**: msdyn_customerassets<br />
**LogicalName**: msdyn_customerasset<br />
**LogicalCollectionName**: msdyn_customerassets<br />
**EntitySetName**: msdyn_customerassets<br />
**PrimaryIdAttribute**: msdyn_customerassetid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_customerassetId](#BKMK_msdyn_customerassetId)
- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MasterAsset](#BKMK_msdyn_MasterAsset)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentAsset](#BKMK_msdyn_ParentAsset)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_RegistrationStatus](#BKMK_msdyn_RegistrationStatus)
- [msdyn_WorkOrderProduct](#BKMK_msdyn_WorkOrderProduct)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Shows the sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_Account"></a> msdyn_Account

**Description**: Parent Customer of this Asset<br />
**DisplayName**: Account<br />
**LogicalName**: msdyn_account<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_customerassetId"></a> msdyn_customerassetId

**Description**: Shows the entity instances.<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerassetid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: Device ID used to register with IoT hub. This will not be used if there are two or more connected devices for this asset.<br />
**DisplayName**: Device ID<br />
**LogicalName**: msdyn_deviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: The last command sent to any of the connected devices for this asset.<br />
**DisplayName**: Last Command Sent<br />
**LogicalName**: msdyn_lastcommandsent<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_iotdevicecommand


### <a name="BKMK_msdyn_LastCommandSentTime"></a> msdyn_LastCommandSentTime

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: The timestamp of the last command sent for any of the connected devices for this asset.<br />
**DisplayName**: Last Command Sent Time<br />
**LogicalName**: msdyn_lastcommandsenttime<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

**Description**: <br />
**DisplayName**: Latitude<br />
**LogicalName**: msdyn_latitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 90<br />
**MinValue**: -90<br />
**Precision**: 5


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

**Description**: <br />
**DisplayName**: Longitude<br />
**LogicalName**: msdyn_longitude<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Double<br />
**MaxValue**: 180<br />
**MinValue**: -180<br />
**Precision**: 5


### <a name="BKMK_msdyn_MasterAsset"></a> msdyn_MasterAsset

**Description**: Top level Asset, (if this asset is a sub asset)<br />
**DisplayName**: Master Asset<br />
**LogicalName**: msdyn_masterasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ParentAsset"></a> msdyn_ParentAsset

**Description**: Parent Asset<br />
**DisplayName**: Parent Asset<br />
**LogicalName**: msdyn_parentasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

**Description**: Reference to Product associated with this Asset<br />
**DisplayName**: Product<br />
**LogicalName**: msdyn_product<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_RegistrationStatus"></a> msdyn_RegistrationStatus

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: A status field that denotes whether all the devices connected to this asset are registered with the IoT hub.<br />
**DisplayName**: Registration Status<br />
**LogicalName**: msdyn_registrationstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Unknown
- **Value**: 192350001 **Label**: Unregistered
- **Value**: 192350002 **Label**: In Progress
- **Value**: 192350003 **Label**: Registered
- **Value**: 192350004 **Label**: Error



### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

**Description**: Indicates a link to the Work Order Product from where this Asset was auto created by the system.<br />
**DisplayName**: Work Order Product<br />
**LogicalName**: msdyn_workorderproduct<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_workorderproduct


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Customer Asset<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Customer Asset<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

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
- [msdyn_AccountName](#BKMK_msdyn_AccountName)
- [msdyn_AccountYomiName](#BKMK_msdyn_AccountYomiName)
- [msdyn_LastCommandSentName](#BKMK_msdyn_LastCommandSentName)
- [msdyn_MasterAssetName](#BKMK_msdyn_MasterAssetName)
- [msdyn_ParentAssetName](#BKMK_msdyn_ParentAssetName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_WorkOrderProductName](#BKMK_msdyn_WorkOrderProductName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AccountName"></a> msdyn_AccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_AccountYomiName"></a> msdyn_AccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_accountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_LastCommandSentName"></a> msdyn_LastCommandSentName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_lastcommandsentname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_MasterAssetName"></a> msdyn_MasterAssetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_masterassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ParentAssetName"></a> msdyn_ParentAssetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_parentassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_productname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderProductName"></a> msdyn_WorkOrderProductName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workorderproductname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)
- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_customerasset_msdyn_approvals](#BKMK_msdyn_customerasset_msdyn_approvals)
- [msdyn_customerasset_msdyn_bookingalerts](#BKMK_msdyn_customerasset_msdyn_bookingalerts)
- [msdyn_customerasset_SyncErrors](#BKMK_msdyn_customerasset_SyncErrors)
- [msdyn_customerasset_DuplicateMatchingRecord](#BKMK_msdyn_customerasset_DuplicateMatchingRecord)
- [msdyn_customerasset_DuplicateBaseRecord](#BKMK_msdyn_customerasset_DuplicateBaseRecord)
- [msdyn_customerasset_AsyncOperations](#BKMK_msdyn_customerasset_AsyncOperations)
- [msdyn_customerasset_MailboxTrackingFolders](#BKMK_msdyn_customerasset_MailboxTrackingFolders)
- [msdyn_customerasset_UserEntityInstanceDatas](#BKMK_msdyn_customerasset_UserEntityInstanceDatas)
- [msdyn_customerasset_ProcessSession](#BKMK_msdyn_customerasset_ProcessSession)
- [msdyn_customerasset_BulkDeleteFailures](#BKMK_msdyn_customerasset_BulkDeleteFailures)
- [msdyn_customerasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_customerasset_Emails](#BKMK_msdyn_customerasset_Emails)
- [msdyn_customerasset_Faxes](#BKMK_msdyn_customerasset_Faxes)
- [msdyn_customerasset_Letters](#BKMK_msdyn_customerasset_Letters)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_customerasset_SocialActivities](#BKMK_msdyn_customerasset_SocialActivities)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_customerasset_ServiceAppointments](#BKMK_msdyn_customerasset_ServiceAppointments)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset

Same as msdyn_iotalert entity [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](msdyn_iotalert.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

Same as msdyn_iotdevicecommand entity [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevicecommand<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

Same as activitypointer entity [msdyn_customerasset_ActivityPointers](activitypointer.md#BKMK_msdyn_customerasset_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_msdyn_approvals"></a> msdyn_customerasset_msdyn_approvals

Same as msdyn_approval entity [msdyn_customerasset_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_customerasset_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_msdyn_approvals<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_msdyn_bookingalerts"></a> msdyn_customerasset_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_customerasset_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_customerasset_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_msdyn_bookingalerts<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_SyncErrors"></a> msdyn_customerasset_SyncErrors

Same as syncerror entity [msdyn_customerasset_SyncErrors](syncerror.md#BKMK_msdyn_customerasset_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_DuplicateMatchingRecord"></a> msdyn_customerasset_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_customerasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_DuplicateBaseRecord"></a> msdyn_customerasset_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_customerasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_AsyncOperations"></a> msdyn_customerasset_AsyncOperations

Same as asyncoperation entity [msdyn_customerasset_AsyncOperations](asyncoperation.md#BKMK_msdyn_customerasset_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_MailboxTrackingFolders"></a> msdyn_customerasset_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_customerasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_customerasset_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_UserEntityInstanceDatas"></a> msdyn_customerasset_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_customerasset_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_customerasset_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_ProcessSession"></a> msdyn_customerasset_ProcessSession

Same as processsession entity [msdyn_customerasset_ProcessSession](processsession.md#BKMK_msdyn_customerasset_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_BulkDeleteFailures"></a> msdyn_customerasset_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_customerasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_customerasset_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses"></a> msdyn_customerasset_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_customerasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

Same as appointment entity [msdyn_customerasset_Appointments](appointment.md#BKMK_msdyn_customerasset_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Appointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_Emails"></a> msdyn_customerasset_Emails

Same as email entity [msdyn_customerasset_Emails](email.md#BKMK_msdyn_customerasset_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Emails<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_Faxes"></a> msdyn_customerasset_Faxes

Same as fax entity [msdyn_customerasset_Faxes](fax.md#BKMK_msdyn_customerasset_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Faxes<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_Letters"></a> msdyn_customerasset_Letters

Same as letter entity [msdyn_customerasset_Letters](letter.md#BKMK_msdyn_customerasset_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Letters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_PhoneCalls"></a> msdyn_customerasset_PhoneCalls

Same as phonecall entity [msdyn_customerasset_PhoneCalls](phonecall.md#BKMK_msdyn_customerasset_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_PhoneCalls<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

Same as task entity [msdyn_customerasset_Tasks](task.md#BKMK_msdyn_customerasset_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Tasks<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_customerasset_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_RecurringAppointmentMasters<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_SocialActivities"></a> msdyn_customerasset_SocialActivities

Same as socialactivity entity [msdyn_customerasset_SocialActivities](socialactivity.md#BKMK_msdyn_customerasset_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_SocialActivities<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

Same as connection entity [msdyn_customerasset_connections1](connection.md#BKMK_msdyn_customerasset_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

Same as connection entity [msdyn_customerasset_connections2](connection.md#BKMK_msdyn_customerasset_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_connections2<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

Same as annotation entity [msdyn_customerasset_Annotations](annotation.md#BKMK_msdyn_customerasset_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_Annotations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

Same as serviceappointment entity [msdyn_customerasset_ServiceAppointments](serviceappointment.md#BKMK_msdyn_customerasset_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_customerasset_ServiceAppointments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Customer Asset
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservicetask<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

Same as msdyn_customerasset entity [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_masterasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Items of Master Asset
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

Same as msdyn_customerasset entity [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_parentasset<br />
**IsHierarchical**: True<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Items of Parent Asset
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset

Same as msdyn_quotebookingincident entity [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingincident<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset

Same as msdyn_quotebookingproduct entity [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset

Same as msdyn_quotebookingservice entity [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset

Same as msdyn_quotebookingservicetask entity [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservicetask<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset

Same as msdyn_rmaproduct entity [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

Same as msdyn_workorder entity [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_workorder.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

Same as msdyn_workorderincident entity [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_workorderincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderincident<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

Same as msdyn_workorderproduct entity [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

Same as msdyn_workorderservice entity [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_workorderservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

Same as msdyn_workorderservicetask entity [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservicetask<br />
**ReferencingAttribute**: msdyn_customerasset<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)
- [lk_msdyn_customerasset_createdby](#BKMK_lk_msdyn_customerasset_createdby)
- [lk_msdyn_customerasset_createdonbehalfby](#BKMK_lk_msdyn_customerasset_createdonbehalfby)
- [lk_msdyn_customerasset_modifiedby](#BKMK_lk_msdyn_customerasset_modifiedby)
- [lk_msdyn_customerasset_modifiedonbehalfby](#BKMK_lk_msdyn_customerasset_modifiedonbehalfby)
- [user_msdyn_customerasset](#BKMK_user_msdyn_customerasset)
- [team_msdyn_customerasset](#BKMK_team_msdyn_customerasset)
- [business_unit_msdyn_customerasset](#BKMK_business_unit_msdyn_customerasset)
- [msdyn_account_msdyn_customerasset_Account](#BKMK_msdyn_account_msdyn_customerasset_Account)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_product_msdyn_customerasset_Product](#BKMK_msdyn_product_msdyn_customerasset_Product)


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

See msdyn_iotdevicecommand Entity [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_createdby"></a> lk_msdyn_customerasset_createdby

See systemuser Entity [lk_msdyn_customerasset_createdby](systemuser.md#BKMK_lk_msdyn_customerasset_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_createdonbehalfby"></a> lk_msdyn_customerasset_createdonbehalfby

See systemuser Entity [lk_msdyn_customerasset_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_modifiedby"></a> lk_msdyn_customerasset_modifiedby

See systemuser Entity [lk_msdyn_customerasset_modifiedby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_modifiedonbehalfby"></a> lk_msdyn_customerasset_modifiedonbehalfby

See systemuser Entity [lk_msdyn_customerasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_customerasset"></a> user_msdyn_customerasset

See systemuser Entity [user_msdyn_customerasset](systemuser.md#BKMK_user_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

See team Entity [team_msdyn_customerasset](team.md#BKMK_team_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

See businessunit Entity [business_unit_msdyn_customerasset](businessunit.md#BKMK_business_unit_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_customerasset_Account"></a> msdyn_account_msdyn_customerasset_Account

See account Entity [msdyn_account_msdyn_customerasset_Account](account.md#BKMK_msdyn_account_msdyn_customerasset_Account) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

See product Entity [msdyn_product_msdyn_customerasset_Product](product.md#BKMK_msdyn_product_msdyn_customerasset_Product) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_customerasset?text=msdyn_customerasset EntityType" />