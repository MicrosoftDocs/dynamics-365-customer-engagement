---
title: "ProcessStage Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the ProcessStage entity."
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
# ProcessStage Entity Reference

Stage associated with a process.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/processstages(*processstageid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveActivePath|<xref href="Microsoft.Dynamics.CRM.RetrieveActivePath?text=RetrieveActivePath Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveActivePathRequest>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/processstages<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

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

#### StageCategory Options

|Value|Label|
|-----|-----|
|0|Qualify|
|1|Develop|
|2|Propose|
|3|Close|
|4|Identify|
|5|Research|
|6|Resolve|
|7|Approval|



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
- [processstage_msdyn_timeentry](#BKMK_processstage_msdyn_timeentry)
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
- [processstage_msdyn_iotalert](#BKMK_processstage_msdyn_iotalert)
- [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid)
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


### <a name="BKMK_processstage_lead"></a> processstage_lead

**Added by**: Lead Management Solution

Same as lead entity [processstage_lead](lead.md#BKMK_processstage_lead) Many-To-One relationship.

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

Same as product entity [processstage_products](product.md#BKMK_processstage_products) Many-To-One relationship.

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

Same as productpricelevel entity [processstage_productpricelevels](productpricelevel.md#BKMK_processstage_productpricelevels) Many-To-One relationship.

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

Same as bookableresource entity [processstage_BookableResource](bookableresource.md#BKMK_processstage_BookableResource) Many-To-One relationship.

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

Same as bookableresourcebooking entity [processstage_BookableResourceBooking](bookableresourcebooking.md#BKMK_processstage_BookableResourceBooking) Many-To-One relationship.

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

Same as bookableresourcebookingheader entity [processstage_BookableResourceBookingHeader](bookableresourcebookingheader.md#BKMK_processstage_BookableResourceBookingHeader) Many-To-One relationship.

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

Same as bookableresourcecharacteristic entity [processstage_BookableResourceCharacteristic](bookableresourcecharacteristic.md#BKMK_processstage_BookableResourceCharacteristic) Many-To-One relationship.

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

Same as campaign entity [processstage_campaigns](campaign.md#BKMK_processstage_campaigns) Many-To-One relationship.

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

Same as campaignactivity entity [processstage_campaignactivities](campaignactivity.md#BKMK_processstage_campaignactivities) Many-To-One relationship.

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

Same as campaignresponse entity [processstage_campaignresponses](campaignresponse.md#BKMK_processstage_campaignresponses) Many-To-One relationship.

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

Same as list entity [processstage_lists](list.md#BKMK_processstage_lists) Many-To-One relationship.

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

Same as entitlement entity [processstage_Entitlement](entitlement.md#BKMK_processstage_Entitlement) Many-To-One relationship.

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

Same as incident entity [processstage_incident](incident.md#BKMK_processstage_incident) Many-To-One relationship.

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

Same as phonetocaseprocess entity [lk_phonetocaseprocess_activestageid](phonetocaseprocess.md#BKMK_lk_phonetocaseprocess_activestageid) Many-To-One relationship.

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

Same as invoice entity [processstage_invoices](invoice.md#BKMK_processstage_invoices) Many-To-One relationship.

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

Same as leadtoopportunitysalesprocess entity [lk_leadtoopportunitysalesprocess_activestageid](leadtoopportunitysalesprocess.md#BKMK_lk_leadtoopportunitysalesprocess_activestageid) Many-To-One relationship.

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

Same as opportunity entity [processstage_opportunity](opportunity.md#BKMK_processstage_opportunity) Many-To-One relationship.

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

Same as opportunitysalesprocess entity [lk_opportunitysalesprocess_activestageid](opportunitysalesprocess.md#BKMK_lk_opportunitysalesprocess_activestageid) Many-To-One relationship.

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

Same as quote entity [processstage_quotes](quote.md#BKMK_processstage_quotes) Many-To-One relationship.

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

Same as salesliterature entity [processstage_salesliteratures](salesliterature.md#BKMK_processstage_salesliteratures) Many-To-One relationship.

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

Same as salesorder entity [processstage_salesorders](salesorder.md#BKMK_processstage_salesorders) Many-To-One relationship.

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

Same as competitor entity [processstage_competitors](competitor.md#BKMK_processstage_competitors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|competitor|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_competitors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_timegroup"></a> processstage_msdyn_timegroup

**Added by**: Active Solution Solution

Same as msdyn_timegroup entity [processstage_msdyn_timegroup](msdyn_timegroup.md#BKMK_processstage_msdyn_timegroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroup|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_timegroup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_timegroupdetail"></a> processstage_msdyn_timegroupdetail

**Added by**: Active Solution Solution

Same as msdyn_timegroupdetail entity [processstage_msdyn_timegroupdetail](msdyn_timegroupdetail.md#BKMK_processstage_msdyn_timegroupdetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timegroupdetail|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_timegroupdetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid"></a> lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_665e73aa18c247d886bfc50499c73b82 entity [lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_665e73aa18c247d886bfc50499c73b82|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid"></a> lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d entity [lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_expense"></a> processstage_msdyn_expense

**Added by**: Active Solution Solution

Same as msdyn_expense entity [processstage_msdyn_expense](msdyn_expense.md#BKMK_processstage_msdyn_expense) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_expense|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_journal"></a> processstage_msdyn_journal

**Added by**: Active Solution Solution

Same as msdyn_journal entity [processstage_msdyn_journal](msdyn_journal.md#BKMK_processstage_msdyn_journal) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journal|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_journal|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_project"></a> processstage_msdyn_project

**Added by**: Active Solution Solution

Same as msdyn_project entity [processstage_msdyn_project](msdyn_project.md#BKMK_processstage_msdyn_project) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_project|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_project|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_timeentry"></a> processstage_msdyn_timeentry

**Added by**: Active Solution Solution

Same as msdyn_timeentry entity [processstage_msdyn_timeentry](msdyn_timeentry.md#BKMK_processstage_msdyn_timeentry) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_timeentry|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_agreement"></a> processstage_msdyn_agreement

**Added by**: Active Solution Solution

Same as msdyn_agreement entity [processstage_msdyn_agreement](msdyn_agreement.md#BKMK_processstage_msdyn_agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_agreement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_agreementbookingsetup"></a> processstage_msdyn_agreementbookingsetup

**Added by**: Active Solution Solution

Same as msdyn_agreementbookingsetup entity [processstage_msdyn_agreementbookingsetup](msdyn_agreementbookingsetup.md#BKMK_processstage_msdyn_agreementbookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingsetup|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_agreementbookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_agreementinvoicesetup"></a> processstage_msdyn_agreementinvoicesetup

**Added by**: Active Solution Solution

Same as msdyn_agreementinvoicesetup entity [processstage_msdyn_agreementinvoicesetup](msdyn_agreementinvoicesetup.md#BKMK_processstage_msdyn_agreementinvoicesetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicesetup|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_agreementinvoicesetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid"></a> lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid"></a> lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_989e9b1857e24af18787d5143b67523b|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_989e9b1857e24af18787d5143b67523b_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid"></a> lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 entity [lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_purchaseorder"></a> processstage_msdyn_purchaseorder

**Added by**: Active Solution Solution

Same as msdyn_purchaseorder entity [processstage_msdyn_purchaseorder](msdyn_purchaseorder.md#BKMK_processstage_msdyn_purchaseorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorder|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_purchaseorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_purchaseorderbill"></a> processstage_msdyn_purchaseorderbill

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderbill entity [processstage_msdyn_purchaseorderbill](msdyn_purchaseorderbill.md#BKMK_processstage_msdyn_purchaseorderbill) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderbill|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_purchaseorderbill|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_purchaseorderreceipt"></a> processstage_msdyn_purchaseorderreceipt

**Added by**: Active Solution Solution

Same as msdyn_purchaseorderreceipt entity [processstage_msdyn_purchaseorderreceipt](msdyn_purchaseorderreceipt.md#BKMK_processstage_msdyn_purchaseorderreceipt) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderreceipt|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_purchaseorderreceipt|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

**Added by**: Active Solution Solution

Same as msdyn_quotebookingsetup entity [processstage_msdyn_quotebookingsetup](msdyn_quotebookingsetup.md#BKMK_processstage_msdyn_quotebookingsetup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingsetup|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_quotebookingsetup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_workorder"></a> processstage_msdyn_workorder

**Added by**: Active Solution Solution

Same as msdyn_workorder entity [processstage_msdyn_workorder](msdyn_workorder.md#BKMK_processstage_msdyn_workorder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_workorder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_msdyn_iotalert"></a> processstage_msdyn_iotalert

**Added by**: Active Solution Solution

Same as msdyn_iotalert entity [processstage_msdyn_iotalert](msdyn_iotalert.md#BKMK_processstage_msdyn_iotalert) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_msdyn_iotalert|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid"></a> lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid

**Added by**: Active Solution Solution

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|
|ReferencingAttribute|activestageid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_knowledgearticle"></a> processstage_knowledgearticle

Same as knowledgearticle entity [processstage_knowledgearticle](knowledgearticle.md#BKMK_processstage_knowledgearticle) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgearticle|
|ReferencingAttribute|stageid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|processstage_knowledgearticle|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_processstage_contact"></a> processstage_contact

Same as contact entity [processstage_contact](contact.md#BKMK_processstage_contact) Many-To-One relationship.

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

Same as team entity [processstage_teams](team.md#BKMK_processstage_teams) Many-To-One relationship.

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

Same as syncerror entity [ProcessStage_SyncErrors](syncerror.md#BKMK_ProcessStage_SyncErrors) Many-To-One relationship.

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

Same as recurringappointmentmaster entity [processstage_recurringappointmentmasters](recurringappointmentmaster.md#BKMK_processstage_recurringappointmentmasters) Many-To-One relationship.

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

Same as letter entity [processstage_letters](letter.md#BKMK_processstage_letters) Many-To-One relationship.

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

Same as fax entity [processstage_faxes](fax.md#BKMK_processstage_faxes) Many-To-One relationship.

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

Same as task entity [processstage_tasks](task.md#BKMK_processstage_tasks) Many-To-One relationship.

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

Same as account entity [processstage_account](account.md#BKMK_processstage_account) Many-To-One relationship.

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

Same as translationprocess entity [lk_translationprocess_activestageid](translationprocess.md#BKMK_lk_translationprocess_activestageid) Many-To-One relationship.

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

Same as systemuser entity [processstage_systemusers](systemuser.md#BKMK_processstage_systemusers) Many-To-One relationship.

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

Same as newprocess entity [lk_newprocess_activestageid](newprocess.md#BKMK_lk_newprocess_activestageid) Many-To-One relationship.

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

Same as email entity [processstage_emails](email.md#BKMK_processstage_emails) Many-To-One relationship.

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

Same as appointment entity [processstage_appointments](appointment.md#BKMK_processstage_appointments) Many-To-One relationship.

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

Same as phonecall entity [processstage_phonecalls](phonecall.md#BKMK_processstage_phonecalls) Many-To-One relationship.

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

Same as expiredprocess entity [lk_expiredprocess_activestageid](expiredprocess.md#BKMK_lk_expiredprocess_activestageid) Many-To-One relationship.

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

See workflow Entity [process_processstage](workflow.md#BKMK_process_processstage) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.processstage?text=processstage EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]