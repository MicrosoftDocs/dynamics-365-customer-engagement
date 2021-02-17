---
title: "msdyn_agreement Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreement entity."
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
# msdyn_agreement Entity Reference

Provides ability to store details about service agreements you have with your customers

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreements<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreements<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_agreements|
|DisplayCollectionName|Agreements|
|DisplayName|Agreement|
|EntitySetName|msdyn_agreements|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_agreements|
|LogicalName|msdyn_agreement|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_agreementid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_agreement|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementDetails](#BKMK_msdyn_AgreementDetails)
- [msdyn_agreementId](#BKMK_msdyn_agreementId)
- [msdyn_AgreementRecordGeneration](#BKMK_msdyn_AgreementRecordGeneration)
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_ChildIndex](#BKMK_msdyn_ChildIndex)
- [msdyn_DateCanceled](#BKMK_msdyn_DateCanceled)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_EndDate](#BKMK_msdyn_EndDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OriginatingAgreement](#BKMK_msdyn_OriginatingAgreement)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_SalesTaxCode](#BKMK_msdyn_SalesTaxCode)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_StartDate](#BKMK_msdyn_StartDate)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [traversedpath](#BKMK_traversedpath)
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


### <a name="BKMK_msdyn_AgreementDetails"></a> msdyn_AgreementDetails

|Property|Value|
|--------|-----|
|Description|Shows the details of this agreement, as presented to the customer|
|DisplayName|Agreement Details|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementdetails|
|MaxLength|100000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_agreementId"></a> msdyn_agreementId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Agreement|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_agreementid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_AgreementRecordGeneration"></a> msdyn_AgreementRecordGeneration

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|This field defines the time of day when Work Orders and Invoices are generated by the Agreement Booking Setups and Agreement Invoice Setups defined on this Agreement. If this field is blank, the logic will look to the overall setting on the Field Service Settings record.|
|DisplayName|Agreement Record Generation|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementrecordgeneration|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

|Property|Value|
|--------|-----|
|Description|Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.|
|DisplayName|Billing Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccount|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_ChildIndex"></a> msdyn_ChildIndex

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Child Index|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_childindex|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DateCanceled"></a> msdyn_DateCanceled

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date this agreement was canceled.|
|DisplayName|Date Canceled|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_datecanceled|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|--------|-----|
|Description|Type a description of the agreement.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|--------|-----|
|Description|Shows the duration how long this agreement is active.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date when this agreement is no longer active.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enddate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Agreement Number|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_OriginatingAgreement"></a> msdyn_OriginatingAgreement

|Property|Value|
|--------|-----|
|Description|If this agreement originates from another agreement, you should specify the originating agreement here|
|DisplayName|Originating Agreement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_originatingagreement|
|RequiredLevel|None|
|Targets|msdyn_agreement|
|Type|Lookup|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Price List that controls pricing for products added to this Agreement. By default the system will use the Price List specified on the account|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

|Property|Value|
|--------|-----|
|Description|Tax Code to be used to calculate tax when Agreement is taxable. By default the system will use the tax code specified on the service account|
|DisplayName|Sales Tax Code|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salestaxcode|
|RequiredLevel|None|
|Targets|msdyn_taxcode|
|Type|Lookup|


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

|Property|Value|
|--------|-----|
|Description|Account to be serviced|
|DisplayName|Service Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccount|
|RequiredLevel|ApplicationRequired|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|--------|-----|
|Description|The service territory this Agreement relates to. By default this will be set to the Service Territory defined on the service account|
|DisplayName|Service Territory|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_serviceterritory|
|RequiredLevel|None|
|Targets|territory|
|Type|Lookup|


### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the date from when this agreement is active.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|--------|-----|
|Description|Agreement Substatus|
|DisplayName|Substatus|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_substatus|
|RequiredLevel|None|
|Targets|msdyn_agreementsubstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|--------|-----|
|Description|Tracks the current system status.|
|DisplayName|System Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_systemstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_SystemStatus Options

|Value|Label|
|-----|-----|
|690970000|Estimate|
|690970001|Active|
|690970002|Expired|
|690970003|Canceled|



### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|--------|-----|
|Description|Specify if Agreement is taxable. By default an Agreement is taxable if billing account is not tax exempt, and Agreement type is taxable. If any of the above is false it will be set to non-taxable.|
|DisplayName|Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_Taxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



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


### <a name="BKMK_processid"></a> processid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the process associated with the entity.|
|DisplayName|Process Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|processid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_stageid"></a> stageid

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Contains the ID of the stage where the entity is located.|
|DisplayName|Stage Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|stageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Agreement|
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
|Description|Reason for the status of the Agreement|
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.|
|DisplayName|Traversed Path|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|traversedpath|
|MaxLength|1250|
|RequiredLevel|None|
|Type|String|


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
- [msdyn_BillingAccountName](#BKMK_msdyn_BillingAccountName)
- [msdyn_BillingAccountYomiName](#BKMK_msdyn_BillingAccountYomiName)
- [msdyn_OriginatingAgreementName](#BKMK_msdyn_OriginatingAgreementName)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_SalesTaxCodeName](#BKMK_msdyn_SalesTaxCodeName)
- [msdyn_ServiceAccountName](#BKMK_msdyn_ServiceAccountName)
- [msdyn_ServiceAccountYomiName](#BKMK_msdyn_ServiceAccountYomiName)
- [msdyn_ServiceTerritoryName](#BKMK_msdyn_ServiceTerritoryName)
- [msdyn_SubStatusName](#BKMK_msdyn_SubStatusName)
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


### <a name="BKMK_msdyn_BillingAccountName"></a> msdyn_BillingAccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BillingAccountYomiName"></a> msdyn_BillingAccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_billingaccountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OriginatingAgreementName"></a> msdyn_OriginatingAgreementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_originatingagreementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricelistname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SalesTaxCodeName"></a> msdyn_SalesTaxCodeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salestaxcodename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceaccountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ServiceTerritoryName"></a> msdyn_ServiceTerritoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_serviceterritoryname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_substatusname|
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

- [msdyn_agreement_ActivityPointers](#BKMK_msdyn_agreement_ActivityPointers)
- [msdyn_agreement_msdyn_bookingalerts](#BKMK_msdyn_agreement_msdyn_bookingalerts)
- [msdyn_agreement_msdyn_approvals](#BKMK_msdyn_agreement_msdyn_approvals)
- [msdyn_agreement_SyncErrors](#BKMK_msdyn_agreement_SyncErrors)
- [msdyn_agreement_DuplicateMatchingRecord](#BKMK_msdyn_agreement_DuplicateMatchingRecord)
- [msdyn_agreement_DuplicateBaseRecord](#BKMK_msdyn_agreement_DuplicateBaseRecord)
- [msdyn_agreement_SharePointDocumentLocations](#BKMK_msdyn_agreement_SharePointDocumentLocations)
- [msdyn_agreement_AsyncOperations](#BKMK_msdyn_agreement_AsyncOperations)
- [msdyn_agreement_MailboxTrackingFolders](#BKMK_msdyn_agreement_MailboxTrackingFolders)
- [msdyn_agreement_ProcessSession](#BKMK_msdyn_agreement_ProcessSession)
- [msdyn_agreement_BulkDeleteFailures](#BKMK_msdyn_agreement_BulkDeleteFailures)
- [msdyn_agreement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses)
- [msdyn_agreement_Appointments](#BKMK_msdyn_agreement_Appointments)
- [msdyn_agreement_Emails](#BKMK_msdyn_agreement_Emails)
- [msdyn_agreement_Faxes](#BKMK_msdyn_agreement_Faxes)
- [msdyn_agreement_Letters](#BKMK_msdyn_agreement_Letters)
- [msdyn_agreement_PhoneCalls](#BKMK_msdyn_agreement_PhoneCalls)
- [msdyn_agreement_Tasks](#BKMK_msdyn_agreement_Tasks)
- [msdyn_agreement_RecurringAppointmentMasters](#BKMK_msdyn_agreement_RecurringAppointmentMasters)
- [msdyn_agreement_SocialActivities](#BKMK_msdyn_agreement_SocialActivities)
- [msdyn_agreement_connections1](#BKMK_msdyn_agreement_connections1)
- [msdyn_agreement_connections2](#BKMK_msdyn_agreement_connections2)
- [msdyn_agreement_Annotations](#BKMK_msdyn_agreement_Annotations)
- [msdyn_agreement_ServiceAppointments](#BKMK_msdyn_agreement_ServiceAppointments)
- [bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [msdyn_msdyn_agreement_invoicedetail_Agreement](#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement)
- [msdyn_msdyn_agreement_msdyn_actual_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement)
- [msdyn_msdyn_agreement_msdyn_workorder_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement)
- [msdyn_msdyn_agreement_quotedetail_Agreement](#BKMK_msdyn_msdyn_agreement_quotedetail_Agreement)
- [msdyn_msdyn_agreement_salesorderdetail_Agreement](#BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement)


### <a name="BKMK_msdyn_agreement_ActivityPointers"></a> msdyn_agreement_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_agreement_ActivityPointers](activitypointer.md#BKMK_msdyn_agreement_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_msdyn_bookingalerts"></a> msdyn_agreement_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_agreement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreement_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_msdyn_approvals"></a> msdyn_agreement_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_agreement_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreement_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_SyncErrors"></a> msdyn_agreement_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_agreement_SyncErrors](syncerror.md#BKMK_msdyn_agreement_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_DuplicateMatchingRecord"></a> msdyn_agreement_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_agreement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreement_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_DuplicateBaseRecord"></a> msdyn_agreement_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_agreement_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreement_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_SharePointDocumentLocations"></a> msdyn_agreement_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_agreement_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreement_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_AsyncOperations"></a> msdyn_agreement_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_agreement_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreement_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_MailboxTrackingFolders"></a> msdyn_agreement_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_agreement_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreement_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_ProcessSession"></a> msdyn_agreement_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_agreement_ProcessSession](processsession.md#BKMK_msdyn_agreement_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_BulkDeleteFailures"></a> msdyn_agreement_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_agreement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreement_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses"></a> msdyn_agreement_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_agreement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_agreement_Appointments](appointment.md#BKMK_msdyn_agreement_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_Emails"></a> msdyn_agreement_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_agreement_Emails](email.md#BKMK_msdyn_agreement_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_Faxes"></a> msdyn_agreement_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_agreement_Faxes](fax.md#BKMK_msdyn_agreement_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_Letters"></a> msdyn_agreement_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_agreement_Letters](letter.md#BKMK_msdyn_agreement_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_PhoneCalls"></a> msdyn_agreement_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_agreement_PhoneCalls](phonecall.md#BKMK_msdyn_agreement_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_agreement_Tasks](task.md#BKMK_msdyn_agreement_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_agreement_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreement_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_SocialActivities"></a> msdyn_agreement_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_agreement_SocialActivities](socialactivity.md#BKMK_msdyn_agreement_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_connections1"></a> msdyn_agreement_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_agreement_connections1](connection.md#BKMK_msdyn_agreement_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_connections2"></a> msdyn_agreement_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_agreement_connections2](connection.md#BKMK_msdyn_agreement_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_agreement_Annotations"></a> msdyn_agreement_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_agreement_Annotations](annotation.md#BKMK_msdyn_agreement_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_agreement_ServiceAppointments"></a> msdyn_agreement_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_agreement_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreement_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_agreement_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|ReferencingAttribute|bpf_msdyn_agreementid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: msdyn_agreement<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement"></a> msdyn_msdyn_agreement_invoicedetail_Agreement

Same as invoicedetail entity [msdyn_msdyn_agreement_invoicedetail_Agreement](invoicedetail.md#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_invoicedetail_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement"></a> msdyn_msdyn_agreement_msdyn_actual_Agreement

Same as msdyn_actual entity [msdyn_msdyn_agreement_msdyn_actual_Agreement](msdyn_actual.md#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_actual_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

Same as msdyn_agreement entity [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreement|
|ReferencingAttribute|msdyn_originatingagreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingdate|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingincident|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Booking Incidents<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Booking Products<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Booking Services<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservicetask|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Booking Service Tasks<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

Same as msdyn_agreementbookingsetup entity [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreementbookingsetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingsetup|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Bookings<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement

Same as msdyn_agreementinvoicedate entity [msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](msdyn_agreementinvoicedate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicedate|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement

Same as msdyn_agreementinvoiceproduct entity [msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement

Same as msdyn_agreementinvoicesetup entity [msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](msdyn_agreementinvoicesetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoicesetup|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Agreement Invoices<br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

Same as msdyn_workorder entity [msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_workorder.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_msdyn_workorder_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_quotedetail_Agreement"></a> msdyn_msdyn_agreement_quotedetail_Agreement

Same as quotedetail entity [msdyn_msdyn_agreement_quotedetail_Agreement](quotedetail.md#BKMK_msdyn_msdyn_agreement_quotedetail_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_quotedetail_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement"></a> msdyn_msdyn_agreement_salesorderdetail_Agreement

Same as salesorderdetail entity [msdyn_msdyn_agreement_salesorderdetail_Agreement](salesorderdetail.md#BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|msdyn_agreement|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_agreement_salesorderdetail_Agreement|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_agreement_createdby](#BKMK_lk_msdyn_agreement_createdby)
- [lk_msdyn_agreement_createdonbehalfby](#BKMK_lk_msdyn_agreement_createdonbehalfby)
- [lk_msdyn_agreement_modifiedby](#BKMK_lk_msdyn_agreement_modifiedby)
- [lk_msdyn_agreement_modifiedonbehalfby](#BKMK_lk_msdyn_agreement_modifiedonbehalfby)
- [user_msdyn_agreement](#BKMK_user_msdyn_agreement)
- [team_msdyn_agreement](#BKMK_team_msdyn_agreement)
- [business_unit_msdyn_agreement](#BKMK_business_unit_msdyn_agreement)
- [processstage_msdyn_agreement](#BKMK_processstage_msdyn_agreement)
- [msdyn_account_msdyn_agreement_BillingAccount](#BKMK_msdyn_account_msdyn_agreement_BillingAccount)
- [msdyn_account_msdyn_agreement_ServiceAccount](#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)
- [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement)
- [msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus](#BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus)
- [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode)
- [msdyn_pricelevel_msdyn_agreement_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList)
- [msdyn_territory_msdyn_agreement_ServiceTerritory](#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory)


### <a name="BKMK_lk_msdyn_agreement_createdby"></a> lk_msdyn_agreement_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreement_createdby](systemuser.md#BKMK_lk_msdyn_agreement_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_createdonbehalfby"></a> lk_msdyn_agreement_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreement_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreement_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_modifiedby"></a> lk_msdyn_agreement_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreement_modifiedby](systemuser.md#BKMK_lk_msdyn_agreement_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_modifiedonbehalfby"></a> lk_msdyn_agreement_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_agreement_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreement_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreement"></a> user_msdyn_agreement

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_agreement](systemuser.md#BKMK_user_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

**Added by**: System Solution Solution

See team Entity [team_msdyn_agreement](team.md#BKMK_team_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreement"></a> business_unit_msdyn_agreement

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_agreement](businessunit.md#BKMK_business_unit_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_agreement"></a> processstage_msdyn_agreement

**Added by**: System Solution Solution

See processstage Entity [processstage_msdyn_agreement](processstage.md#BKMK_processstage_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_agreement_BillingAccount"></a> msdyn_account_msdyn_agreement_BillingAccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_agreement_BillingAccount](account.md#BKMK_msdyn_account_msdyn_agreement_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_agreement_ServiceAccount"></a> msdyn_account_msdyn_agreement_ServiceAccount

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_agreement_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_agreement_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus"></a> msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus

See msdyn_agreementsubstatus Entity [msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus](msdyn_agreementsubstatus.md#BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode"></a> msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_agreement_PriceList"></a> msdyn_pricelevel_msdyn_agreement_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_agreement_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory"></a> msdyn_territory_msdyn_agreement_ServiceTerritory

**Added by**: Application Common Solution

See territory Entity [msdyn_territory_msdyn_agreement_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreement?text=msdyn_agreement EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]