---
title: "ProcessStage entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the ProcessStage entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# ProcessStage entity reference

Stage associated with a process.


## Messages

|Message|SDK class or method|
|-|-|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveActivePath|<xref:Microsoft.Crm.Sdk.Messages.RetrieveActivePathRequest>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|ProcessStages|
|DisplayCollectionName|Process Stages|
|DisplayName|Process Stage|
|EntitySetName|processstages|
|IsBPFEntity|False|
|LogicalCollectionName|processstages|
|LogicalName|processstage|
|OwnershipType|None|
|PrimaryIdAttribute|processstageid|
|PrimaryNameAttribute|stagename|
|SchemaName|ProcessStage|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [PrimaryEntityTypeCode](#BKMK_PrimaryEntityTypeCode)
- [ProcessId](#BKMK_ProcessId)
- [ProcessStageId](#BKMK_ProcessStageId)
- [StageCategory](#BKMK_StageCategory)
- [StageName](#BKMK_StageName)


### <a name="BKMK_PrimaryEntityTypeCode"></a> PrimaryEntityTypeCode

|Property|Value|
|--------|-----|
|Description|Primary entity associated with the stage.|
|DisplayName|Primary Entity|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|primaryentitytypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_ProcessId"></a> ProcessId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process.|
|DisplayName|Process|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|processid|
|RequiredLevel|SystemRequired|
|Targets|workflow|
|Type|Lookup|


### <a name="BKMK_ProcessStageId"></a> ProcessStageId

|Property|Value|
|--------|-----|
|Description|Shows the ID of the process stage record.|
|DisplayName|Process Stage|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|processstageid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_StageCategory"></a> StageCategory

|Property|Value|
|--------|-----|
|Description|Select the category of the sales process.|
|DisplayName|Stage Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stagecategory|
|RequiredLevel|None|
|Type|Picklist|

#### StageCategory Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Qualify||
|1|Develop||
|2|Propose||
|3|Close||
|4|Identify||
|5|Research||
|6|Resolve||
|7|Approval||



### <a name="BKMK_StageName"></a> StageName

|Property|Value|
|--------|-----|
|Description|Type a name for the process stage.|
|DisplayName|Process Stage Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|stagename|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|

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

|Property|Value|
|--------|-----|
|Description|Step metadata for process stage|
|DisplayName|Client Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|clientdata|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Select the business unit that owns the record.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the process stage.|
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

- [processstage_knowledgearticle](#BKMK_processstage_knowledgearticle)
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


### <a name="BKMK_processstage_knowledgearticle"></a> processstage_knowledgearticle

Same as the [processstage_knowledgearticle](knowledgearticle.md#BKMK_processstage_knowledgearticle) many-to-one relationship for the [knowledgearticle](knowledgearticle.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_knowledgearticle|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_lead"></a> processstage_lead

**Added by**: Lead Management Solution

Same as the [processstage_lead](lead.md#BKMK_processstage_lead) many-to-one relationship for the [lead](lead.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|lead|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_lead|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_products"></a> processstage_products

**Added by**: Product Management Solution

Same as the [processstage_products](product.md#BKMK_processstage_products) many-to-one relationship for the [product](product.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_productpricelevels"></a> processstage_productpricelevels

**Added by**: Product Management Solution

Same as the [processstage_productpricelevels](productpricelevel.md#BKMK_processstage_productpricelevels) many-to-one relationship for the [productpricelevel](productpricelevel.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_productpricelevels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_BookableResource"></a> processstage_BookableResource

**Added by**: Scheduling Solution

Same as the [processstage_BookableResource](bookableresource.md#BKMK_processstage_BookableResource) many-to-one relationship for the [bookableresource](bookableresource.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresource|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_BookableResource|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_BookableResourceBooking"></a> processstage_BookableResourceBooking

**Added by**: Scheduling Solution

Same as the [processstage_BookableResourceBooking](bookableresourcebooking.md#BKMK_processstage_BookableResourceBooking) many-to-one relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebooking|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_BookableResourceBooking|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_BookableResourceBookingHeader"></a> processstage_BookableResourceBookingHeader

**Added by**: Scheduling Solution

Same as the [processstage_BookableResourceBookingHeader](bookableresourcebookingheader.md#BKMK_processstage_BookableResourceBookingHeader) many-to-one relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcebookingheader|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_BookableResourceBookingHeader|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_BookableResourceCharacteristic"></a> processstage_BookableResourceCharacteristic

**Added by**: Scheduling Solution

Same as the [processstage_BookableResourceCharacteristic](bookableresourcecharacteristic.md#BKMK_processstage_BookableResourceCharacteristic) many-to-one relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecharacteristic|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_BookableResourceCharacteristic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_campaigns"></a> processstage_campaigns

**Added by**: Marketing Solution

Same as the [processstage_campaigns](campaign.md#BKMK_processstage_campaigns) many-to-one relationship for the [campaign](campaign.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaign|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_campaigns|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_campaignactivities"></a> processstage_campaignactivities

**Added by**: Marketing Solution

Same as the [processstage_campaignactivities](campaignactivity.md#BKMK_processstage_campaignactivities) many-to-one relationship for the [campaignactivity](campaignactivity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignactivity|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_campaignactivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_campaignresponses"></a> processstage_campaignresponses

**Added by**: Marketing Solution

Same as the [processstage_campaignresponses](campaignresponse.md#BKMK_processstage_campaignresponses) many-to-one relationship for the [campaignresponse](campaignresponse.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|campaignresponse|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_campaignresponses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_lists"></a> processstage_lists

**Added by**: Marketing Solution

Same as the [processstage_lists](list.md#BKMK_processstage_lists) many-to-one relationship for the [list](list.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|list|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_lists|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_Entitlement"></a> processstage_Entitlement

**Added by**: Service Solution

Same as the [processstage_Entitlement](entitlement.md#BKMK_processstage_Entitlement) many-to-one relationship for the [entitlement](entitlement.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlement|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_Entitlement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_incident"></a> processstage_incident

**Added by**: Service Solution

Same as the [processstage_incident](incident.md#BKMK_processstage_incident) many-to-one relationship for the [incident](incident.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|incident|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_incident|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_phonetocaseprocess_activestageid"></a> lk_phonetocaseprocess_activestageid

**Added by**: Service Solution

Same as the [lk_phonetocaseprocess_activestageid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_activestageid) many-to-one relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonetocaseprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_phonetocaseprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_invoices"></a> processstage_invoices

**Added by**: Sales Solution

Same as the [processstage_invoices](invoice.md#BKMK_processstage_invoices) many-to-one relationship for the [invoice](invoice.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoice|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_invoices|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_leadtoopportunitysalesprocess_activestageid"></a> lk_leadtoopportunitysalesprocess_activestageid

**Added by**: Sales Solution

Same as the [lk_leadtoopportunitysalesprocess_activestageid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid) many-to-one relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadtoopportunitysalesprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_leadtoopportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_opportunity"></a> processstage_opportunity

**Added by**: Sales Solution

Same as the [processstage_opportunity](opportunity.md#BKMK_processstage_opportunity) many-to-one relationship for the [opportunity](opportunity.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunity|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_opportunity|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_opportunitysalesprocess_activestageid"></a> lk_opportunitysalesprocess_activestageid

**Added by**: Sales Solution

Same as the [lk_opportunitysalesprocess_activestageid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_activestageid) many-to-one relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_quotes"></a> processstage_quotes

**Added by**: Sales Solution

Same as the [processstage_quotes](quote.md#BKMK_processstage_quotes) many-to-one relationship for the [quote](quote.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|quote|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_quotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_salesliteratures"></a> processstage_salesliteratures

**Added by**: Sales Solution

Same as the [processstage_salesliteratures](salesliterature.md#BKMK_processstage_salesliteratures) many-to-one relationship for the [salesliterature](salesliterature.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesliterature|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_salesliteratures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_salesorders"></a> processstage_salesorders

**Added by**: Sales Solution

Same as the [processstage_salesorders](salesorder.md#BKMK_processstage_salesorders) many-to-one relationship for the [salesorder](salesorder.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorder|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_salesorders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_competitors"></a> processstage_competitors

**Added by**: Sales Solution

Same as the [processstage_competitors](competitor.md#BKMK_processstage_competitors) many-to-one relationship for the [competitor](competitor.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|competitor|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_competitors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_contact"></a> processstage_contact

Same as the [processstage_contact](contact.md#BKMK_processstage_contact) many-to-one relationship for the [contact](contact.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|contact|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_contact|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_teams"></a> processstage_teams

Same as the [processstage_teams](team.md#BKMK_processstage_teams) many-to-one relationship for the [team](team.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|team|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_teams|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_ProcessStage_SyncErrors"></a> ProcessStage_SyncErrors

Same as the [ProcessStage_SyncErrors](syncerror.md#BKMK_ProcessStage_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|ProcessStage_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_processstage_recurringappointmentmasters"></a> processstage_recurringappointmentmasters

Same as the [processstage_recurringappointmentmasters](recurringappointmentmaster.md#BKMK_processstage_recurringappointmentmasters) many-to-one relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_recurringappointmentmasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_letters"></a> processstage_letters

Same as the [processstage_letters](letter.md#BKMK_processstage_letters) many-to-one relationship for the [letter](letter.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_faxes"></a> processstage_faxes

Same as the [processstage_faxes](fax.md#BKMK_processstage_faxes) many-to-one relationship for the [fax](fax.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_tasks"></a> processstage_tasks

Same as the [processstage_tasks](task.md#BKMK_processstage_tasks) many-to-one relationship for the [task](task.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_account"></a> processstage_account

Same as the [processstage_account](account.md#BKMK_processstage_account) many-to-one relationship for the [account](account.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|account|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_account|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_translationprocess_activestageid"></a> lk_translationprocess_activestageid

Same as the [lk_translationprocess_activestageid](translationprocess.md#BKMK_lk_translationprocess_activestageid) many-to-one relationship for the [translationprocess](translationprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|translationprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_translationprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_systemusers"></a> processstage_systemusers

Same as the [processstage_systemusers](systemuser.md#BKMK_processstage_systemusers) many-to-one relationship for the [systemuser](systemuser.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|systemuser|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_systemusers|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_newprocess_activestageid"></a> lk_newprocess_activestageid

Same as the [lk_newprocess_activestageid](newprocess.md#BKMK_lk_newprocess_activestageid) many-to-one relationship for the [newprocess](newprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|newprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_newprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_emails"></a> processstage_emails

Same as the [processstage_emails](email.md#BKMK_processstage_emails) many-to-one relationship for the [email](email.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_appointments"></a> processstage_appointments

Same as the [processstage_appointments](appointment.md#BKMK_processstage_appointments) many-to-one relationship for the [appointment](appointment.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_phonecalls"></a> processstage_phonecalls

Same as the [processstage_phonecalls](phonecall.md#BKMK_processstage_phonecalls) many-to-one relationship for the [phonecall](phonecall.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_phonecalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_expiredprocess_activestageid"></a> lk_expiredprocess_activestageid

Same as the [lk_expiredprocess_activestageid](expiredprocess.md#BKMK_lk_expiredprocess_activestageid) many-to-one relationship for the [expiredprocess](expiredprocess.md) entity.

|Property|Value|
|--------|-----|
|ReferencingEntity|expiredprocess|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|processstage_expiredprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.


### <a name="BKMK_process_processstage"></a> process_processstage

See the [process_processstage](workflow.md#BKMK_process_processstage) one-to-many relationship for the [workflow](workflow.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
