---
title: "ProcessStage Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProcessStage entity."
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
# ProcessStage Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Stage associated with a process.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/processstages(*processstageid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveActivePath|<xref href="Microsoft.Dynamics.CRM.RetrieveActivePath?text=RetrieveActivePath Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveActivePathRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/processstages<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

**DisplayName**: Process Stage<br />
**DisplayCollectionName**: Process Stages<br />
**SchemaName**: ProcessStage<br />
**CollectionSchemaName**: ProcessStages<br />
**LogicalName**: processstage<br />
**LogicalCollectionName**: processstages<br />
**EntitySetName**: processstages<br />
**PrimaryIdAttribute**: processstageid<br />
**PrimaryNameAttribute**: stagename<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [PrimaryEntityTypeCode](#BKMK_PrimaryEntityTypeCode)
- [ProcessId](#BKMK_ProcessId)
- [ProcessStageId](#BKMK_ProcessStageId)
- [StageCategory](#BKMK_StageCategory)
- [StageName](#BKMK_StageName)


### <a name="BKMK_PrimaryEntityTypeCode"></a> PrimaryEntityTypeCode

**Description**: Primary entity associated with the stage.<br />
**DisplayName**: Primary Entity<br />
**LogicalName**: primaryentitytypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Shows the ID of the process.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: workflow


### <a name="BKMK_ProcessStageId"></a> ProcessStageId

**Description**: Shows the ID of the process stage record.<br />
**DisplayName**: Process Stage<br />
**LogicalName**: processstageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_StageCategory"></a> StageCategory

**Description**: Select the category of the sales process.<br />
**DisplayName**: Stage Category<br />
**LogicalName**: stagecategory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Qualify
- **Value**: 1 **Label**: Develop
- **Value**: 2 **Label**: Propose
- **Value**: 3 **Label**: Close
- **Value**: 4 **Label**: Identify
- **Value**: 5 **Label**: Research
- **Value**: 6 **Label**: Resolve
- **Value**: 7 **Label**: Approval



### <a name="BKMK_StageName"></a> StageName

**Description**: Type a name for the process stage.<br />
**DisplayName**: Process Stage Name<br />
**LogicalName**: stagename<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [ClientData](#BKMK_ClientData)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [ProcessIdName](#BKMK_ProcessIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ClientData"></a> ClientData

**Description**: Step metadata for process stage<br />
**DisplayName**: Client Data<br />
**LogicalName**: clientdata<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: TextArea<br />
**IsLocalizable**: False<br />
**MaxLength**: 1073741823


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Select the business unit that owns the record.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: processidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version number of the process stage.<br />
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

- [processstage_msdyn_iotalert](#BKMK_processstage_msdyn_iotalert)
- [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid)
- [processstage_lead](#BKMK_processstage_lead)
- [processstage_products](#BKMK_processstage_products)
- [processstage_productpricelevels](#BKMK_processstage_productpricelevels)
- [processstage_BookableResource](#BKMK_processstage_BookableResource)
- [processstage_BookableResourceBooking](#BKMK_processstage_BookableResourceBooking)
- [processstage_BookableResourceBookingHeader](#BKMK_processstage_BookableResourceBookingHeader)
- [processstage_BookableResourceCharacteristic](#BKMK_processstage_BookableResourceCharacteristic)
- [processstage_campaigns](#BKMK_processstage_campaigns)
- [processstage_campaignactivities](#BKMK_processstage_campaignactivities)
- [processstage_campaignresponses](#BKMK_processstage_campaignresponses)
- [processstage_lists](#BKMK_processstage_lists)
- [processstage_Entitlement](#BKMK_processstage_Entitlement)
- [processstage_incident](#BKMK_processstage_incident)
- [lk_phonetocaseprocess_activestageid](#BKMK_lk_phonetocaseprocess_activestageid)
- [processstage_invoices](#BKMK_processstage_invoices)
- [lk_leadtoopportunitysalesprocess_activestageid](#BKMK_lk_leadtoopportunitysalesprocess_activestageid)
- [processstage_opportunity](#BKMK_processstage_opportunity)
- [lk_opportunitysalesprocess_activestageid](#BKMK_lk_opportunitysalesprocess_activestageid)
- [processstage_quotes](#BKMK_processstage_quotes)
- [processstage_salesliteratures](#BKMK_processstage_salesliteratures)
- [processstage_salesorders](#BKMK_processstage_salesorders)
- [processstage_competitors](#BKMK_processstage_competitors)
- [processstage_msdyn_timegroup](#BKMK_processstage_msdyn_timegroup)
- [processstage_msdyn_timegroupdetail](#BKMK_processstage_msdyn_timegroupdetail)
- [lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid](#BKMK_lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid)
- [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid](#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid)
- [processstage_msdyn_expense](#BKMK_processstage_msdyn_expense)
- [processstage_msdyn_journal](#BKMK_processstage_msdyn_journal)
- [processstage_msdyn_project](#BKMK_processstage_msdyn_project)
- [processstage_msdyn_agreement](#BKMK_processstage_msdyn_agreement)
- [processstage_msdyn_agreementbookingsetup](#BKMK_processstage_msdyn_agreementbookingsetup)
- [processstage_msdyn_agreementinvoicesetup](#BKMK_processstage_msdyn_agreementinvoicesetup)
- [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid](#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid)
- [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid](#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid)
- [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid](#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid)
- [processstage_msdyn_purchaseorder](#BKMK_processstage_msdyn_purchaseorder)
- [processstage_msdyn_purchaseorderbill](#BKMK_processstage_msdyn_purchaseorderbill)
- [processstage_msdyn_purchaseorderreceipt](#BKMK_processstage_msdyn_purchaseorderreceipt)
- [processstage_msdyn_quotebookingsetup](#BKMK_processstage_msdyn_quotebookingsetup)
- [processstage_msdyn_workorder](#BKMK_processstage_msdyn_workorder)
- [processstage_knowledgearticle](#BKMK_processstage_knowledgearticle)
- [processstage_contact](#BKMK_processstage_contact)
- [processstage_teams](#BKMK_processstage_teams)
- [ProcessStage_SyncErrors](#BKMK_ProcessStage_SyncErrors)
- [processstage_recurringappointmentmasters](#BKMK_processstage_recurringappointmentmasters)
- [processstage_letters](#BKMK_processstage_letters)
- [processstage_faxes](#BKMK_processstage_faxes)
- [processstage_tasks](#BKMK_processstage_tasks)
- [processstage_account](#BKMK_processstage_account)
- [lk_translationprocess_activestageid](#BKMK_lk_translationprocess_activestageid)
- [processstage_systemusers](#BKMK_processstage_systemusers)
- [lk_newprocess_activestageid](#BKMK_lk_newprocess_activestageid)
- [processstage_emails](#BKMK_processstage_emails)
- [processstage_appointments](#BKMK_processstage_appointments)
- [processstage_phonecalls](#BKMK_processstage_phonecalls)
- [lk_expiredprocess_activestageid](#BKMK_lk_expiredprocess_activestageid)


### <a name="BKMK_processstage_msdyn_iotalert"></a> processstage_msdyn_iotalert

Same as msdyn_iotalert entity [processstage_msdyn_iotalert](msdyn_iotalert.md#BKMK_processstage_msdyn_iotalert) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_iotalert<br />
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


### <a name="BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid"></a> lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid<br />
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


### <a name="BKMK_processstage_lead"></a> processstage_lead

Same as lead entity [processstage_lead](lead.md#BKMK_processstage_lead) Many-To-One relationship.

**ReferencingEntity**: lead<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_lead<br />
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


### <a name="BKMK_processstage_products"></a> processstage_products

Same as product entity [processstage_products](product.md#BKMK_processstage_products) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_products<br />
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


### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

Same as productpricelevel entity [processstage_productpricelevels](productpricelevel.md#BKMK_processstage_productpricelevels) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_productpricelevels<br />
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


### <a name="BKMK_processstage_BookableResource"></a> processstage_BookableResource

Same as bookableresource entity [processstage_BookableResource](bookableresource.md#BKMK_processstage_BookableResource) Many-To-One relationship.

**ReferencingEntity**: bookableresource<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_BookableResource<br />
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


### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

Same as bookableresourcebooking entity [processstage_BookableResourceBooking](bookableresourcebooking.md#BKMK_processstage_BookableResourceBooking) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebooking<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_BookableResourceBooking<br />
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


### <a name="BKMK_processstage_BookableResourceBookingHeader"></a> processstage_BookableResourceBookingHeader

Same as bookableresourcebookingheader entity [processstage_BookableResourceBookingHeader](bookableresourcebookingheader.md#BKMK_processstage_BookableResourceBookingHeader) Many-To-One relationship.

**ReferencingEntity**: bookableresourcebookingheader<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_BookableResourceBookingHeader<br />
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


### <a name="BKMK_processstage_BookableResourceCharacteristic"></a> processstage_BookableResourceCharacteristic

Same as bookableresourcecharacteristic entity [processstage_BookableResourceCharacteristic](bookableresourcecharacteristic.md#BKMK_processstage_BookableResourceCharacteristic) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecharacteristic<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_BookableResourceCharacteristic<br />
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


### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

Same as campaign entity [processstage_campaigns](campaign.md#BKMK_processstage_campaigns) Many-To-One relationship.

**ReferencingEntity**: campaign<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_campaigns<br />
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


### <a name="BKMK_processstage_campaignactivities"></a> processstage_campaignactivities

Same as campaignactivity entity [processstage_campaignactivities](campaignactivity.md#BKMK_processstage_campaignactivities) Many-To-One relationship.

**ReferencingEntity**: campaignactivity<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_campaignactivities<br />
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


### <a name="BKMK_processstage_campaignresponses"></a> processstage_campaignresponses

Same as campaignresponse entity [processstage_campaignresponses](campaignresponse.md#BKMK_processstage_campaignresponses) Many-To-One relationship.

**ReferencingEntity**: campaignresponse<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_campaignresponses<br />
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


### <a name="BKMK_processstage_lists"></a> processstage_lists

Same as list entity [processstage_lists](list.md#BKMK_processstage_lists) Many-To-One relationship.

**ReferencingEntity**: list<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_lists<br />
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


### <a name="BKMK_processstage_Entitlement"></a> processstage_Entitlement

Same as entitlement entity [processstage_Entitlement](entitlement.md#BKMK_processstage_Entitlement) Many-To-One relationship.

**ReferencingEntity**: entitlement<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_Entitlement<br />
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


### <a name="BKMK_processstage_incident"></a> processstage_incident

Same as incident entity [processstage_incident](incident.md#BKMK_processstage_incident) Many-To-One relationship.

**ReferencingEntity**: incident<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_incident<br />
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


### <a name="BKMK_lk_phonetocaseprocess_activestageid"></a> lk_phonetocaseprocess_activestageid

Same as phonetocaseprocess entity [lk_phonetocaseprocess_activestageid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: phonetocaseprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_phonetocaseprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_processstage_invoices"></a> processstage_invoices

Same as invoice entity [processstage_invoices](invoice.md#BKMK_processstage_invoices) Many-To-One relationship.

**ReferencingEntity**: invoice<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_invoices<br />
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


### <a name="BKMK_lk_leadtoopportunitysalesprocess_activestageid"></a> lk_leadtoopportunitysalesprocess_activestageid

Same as leadtoopportunitysalesprocess entity [lk_leadtoopportunitysalesprocess_activestageid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: leadtoopportunitysalesprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_leadtoopportunitysalesprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_processstage_opportunity"></a> processstage_opportunity

Same as opportunity entity [processstage_opportunity](opportunity.md#BKMK_processstage_opportunity) Many-To-One relationship.

**ReferencingEntity**: opportunity<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_opportunity<br />
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


### <a name="BKMK_lk_opportunitysalesprocess_activestageid"></a> lk_opportunitysalesprocess_activestageid

Same as opportunitysalesprocess entity [lk_opportunitysalesprocess_activestageid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: opportunitysalesprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_opportunitysalesprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_processstage_quotes"></a> processstage_quotes

Same as quote entity [processstage_quotes](quote.md#BKMK_processstage_quotes) Many-To-One relationship.

**ReferencingEntity**: quote<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_quotes<br />
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


### <a name="BKMK_processstage_salesliteratures"></a> processstage_salesliteratures

Same as salesliterature entity [processstage_salesliteratures](salesliterature.md#BKMK_processstage_salesliteratures) Many-To-One relationship.

**ReferencingEntity**: salesliterature<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_salesliteratures<br />
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


### <a name="BKMK_processstage_salesorders"></a> processstage_salesorders

Same as salesorder entity [processstage_salesorders](salesorder.md#BKMK_processstage_salesorders) Many-To-One relationship.

**ReferencingEntity**: salesorder<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_salesorders<br />
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


### <a name="BKMK_processstage_competitors"></a> processstage_competitors

Same as competitor entity [processstage_competitors](competitor.md#BKMK_processstage_competitors) Many-To-One relationship.

**ReferencingEntity**: competitor<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_competitors<br />
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


### <a name="BKMK_processstage_msdyn_timegroup"></a> processstage_msdyn_timegroup

Same as msdyn_timegroup entity [processstage_msdyn_timegroup](msdyn_timegroup.md#BKMK_processstage_msdyn_timegroup) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroup<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_timegroup<br />
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


### <a name="BKMK_processstage_msdyn_timegroupdetail"></a> processstage_msdyn_timegroupdetail

Same as msdyn_timegroupdetail entity [processstage_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_processstage_msdyn_timegroupdetail) Many-To-One relationship.

**ReferencingEntity**: msdyn_timegroupdetail<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_timegroupdetail<br />
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


### <a name="BKMK_lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid"></a> lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid

Same as msdyn_bpf_665e73aa18c247d886bfc50499c73b82 entity [lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_665e73aa18c247d886bfc50499c73b82<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid<br />
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


### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid

Same as msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid<br />
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


### <a name="BKMK_processstage_msdyn_expense"></a> processstage_msdyn_expense

Same as msdyn_expense entity [processstage_msdyn_expense](msdyn_expense.md#BKMK_processstage_msdyn_expense) Many-To-One relationship.

**ReferencingEntity**: msdyn_expense<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_expense<br />
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


### <a name="BKMK_processstage_msdyn_journal"></a> processstage_msdyn_journal

Same as msdyn_journal entity [processstage_msdyn_journal](msdyn_journal.md#BKMK_processstage_msdyn_journal) Many-To-One relationship.

**ReferencingEntity**: msdyn_journal<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_journal<br />
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


### <a name="BKMK_processstage_msdyn_project"></a> processstage_msdyn_project

Same as msdyn_project entity [processstage_msdyn_project](msdyn_project.md#BKMK_processstage_msdyn_project) Many-To-One relationship.

**ReferencingEntity**: msdyn_project<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_project<br />
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


### <a name="BKMK_processstage_msdyn_agreement"></a> processstage_msdyn_agreement

Same as msdyn_agreement entity [processstage_msdyn_agreement](msdyn_agreement.md#BKMK_processstage_msdyn_agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_agreement<br />
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


### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

Same as msdyn_agreementbookingsetup entity [processstage_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_processstage_msdyn_agreementbookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingsetup<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_agreementbookingsetup<br />
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


### <a name="BKMK_processstage_msdyn_agreementinvoicesetup"></a> processstage_msdyn_agreementinvoicesetup

Same as msdyn_agreementinvoicesetup entity [processstage_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_processstage_msdyn_agreementinvoicesetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicesetup<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_agreementinvoicesetup<br />
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


### <a name="BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid"></a> lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_2c5fe86acc8b414b8322ae571000c799<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid<br />
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


### <a name="BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid"></a> lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_989e9b1857e24af18787d5143b67523b<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid<br />
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


### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid<br />
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


### <a name="BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid"></a> lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid

Same as msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 entity [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid<br />
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


### <a name="BKMK_processstage_msdyn_purchaseorder"></a> processstage_msdyn_purchaseorder

Same as msdyn_purchaseorder entity [processstage_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_processstage_msdyn_purchaseorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorder<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_purchaseorder<br />
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


### <a name="BKMK_processstage_msdyn_purchaseorderbill"></a> processstage_msdyn_purchaseorderbill

Same as msdyn_purchaseorderbill entity [processstage_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_processstage_msdyn_purchaseorderbill) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderbill<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_purchaseorderbill<br />
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


### <a name="BKMK_processstage_msdyn_purchaseorderreceipt"></a> processstage_msdyn_purchaseorderreceipt

Same as msdyn_purchaseorderreceipt entity [processstage_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_processstage_msdyn_purchaseorderreceipt) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderreceipt<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_purchaseorderreceipt<br />
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


### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

Same as msdyn_quotebookingsetup entity [processstage_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_processstage_msdyn_quotebookingsetup) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingsetup<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_quotebookingsetup<br />
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


### <a name="BKMK_processstage_msdyn_workorder"></a> processstage_msdyn_workorder

Same as msdyn_workorder entity [processstage_msdyn_workorder](msdyn_workorder.md#BKMK_processstage_msdyn_workorder) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_msdyn_workorder<br />
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


### <a name="BKMK_processstage_knowledgearticle"></a> processstage_knowledgearticle

Same as knowledgearticle entity [processstage_knowledgearticle](knowledgearticle.md#BKMK_processstage_knowledgearticle) Many-To-One relationship.

**ReferencingEntity**: knowledgearticle<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_knowledgearticle<br />
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


### <a name="BKMK_processstage_contact"></a> processstage_contact

Same as contact entity [processstage_contact](contact.md#BKMK_processstage_contact) Many-To-One relationship.

**ReferencingEntity**: contact<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_contact<br />
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


### <a name="BKMK_processstage_teams"></a> processstage_teams

Same as team entity [processstage_teams](team.md#BKMK_processstage_teams) Many-To-One relationship.

**ReferencingEntity**: team<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_teams<br />
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


### <a name="BKMK_ProcessStage_SyncErrors"></a> ProcessStage_SyncErrors

Same as syncerror entity [ProcessStage_SyncErrors](syncerror.md#BKMK_ProcessStage_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: ProcessStage_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_processstage_recurringappointmentmasters"></a> processstage_recurringappointmentmasters

Same as recurringappointmentmaster entity [processstage_recurringappointmentmasters](recurringappointmentmaster.md#BKMK_processstage_recurringappointmentmasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_recurringappointmentmasters<br />
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


### <a name="BKMK_processstage_letters"></a> processstage_letters

Same as letter entity [processstage_letters](letter.md#BKMK_processstage_letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_letters<br />
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


### <a name="BKMK_processstage_faxes"></a> processstage_faxes

Same as fax entity [processstage_faxes](fax.md#BKMK_processstage_faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_faxes<br />
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


### <a name="BKMK_processstage_tasks"></a> processstage_tasks

Same as task entity [processstage_tasks](task.md#BKMK_processstage_tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_tasks<br />
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


### <a name="BKMK_processstage_account"></a> processstage_account

Same as account entity [processstage_account](account.md#BKMK_processstage_account) Many-To-One relationship.

**ReferencingEntity**: account<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_account<br />
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


### <a name="BKMK_lk_translationprocess_activestageid"></a> lk_translationprocess_activestageid

Same as translationprocess entity [lk_translationprocess_activestageid](translationprocess.md#BKMK_lk_translationprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: translationprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_translationprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_processstage_systemusers"></a> processstage_systemusers

Same as systemuser entity [processstage_systemusers](systemuser.md#BKMK_processstage_systemusers) Many-To-One relationship.

**ReferencingEntity**: systemuser<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_systemusers<br />
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


### <a name="BKMK_lk_newprocess_activestageid"></a> lk_newprocess_activestageid

Same as newprocess entity [lk_newprocess_activestageid](newprocess.md#BKMK_lk_newprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: newprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_newprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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


### <a name="BKMK_processstage_emails"></a> processstage_emails

Same as email entity [processstage_emails](email.md#BKMK_processstage_emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_emails<br />
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


### <a name="BKMK_processstage_appointments"></a> processstage_appointments

Same as appointment entity [processstage_appointments](appointment.md#BKMK_processstage_appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_appointments<br />
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


### <a name="BKMK_processstage_phonecalls"></a> processstage_phonecalls

Same as phonecall entity [processstage_phonecalls](phonecall.md#BKMK_processstage_phonecalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: stageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: processstage_phonecalls<br />
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


### <a name="BKMK_lk_expiredprocess_activestageid"></a> lk_expiredprocess_activestageid

Same as expiredprocess entity [lk_expiredprocess_activestageid](expiredprocess.md#BKMK_lk_expiredprocess_activestageid) Many-To-One relationship.

**ReferencingEntity**: expiredprocess<br />
**ReferencingAttribute**: activestageid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: processstage_expiredprocess<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_process_processstage"></a> process_processstage

See workflow Entity [process_processstage](workflow.md#BKMK_process_processstage) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.processstage?text=processstage EntityType" />