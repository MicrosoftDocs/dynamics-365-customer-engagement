---
title: "msdyn_agreement Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_agreement entity."
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
# msdyn_agreement Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Provides ability to store details about service agreements you have with your customers

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_agreements<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_agreements<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_agreements(*msdyn_agreementid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Agreement<br />
**DisplayCollectionName**: Agreements<br />
**SchemaName**: msdyn_agreement<br />
**CollectionSchemaName**: msdyn_agreements<br />
**LogicalName**: msdyn_agreement<br />
**LogicalCollectionName**: msdyn_agreements<br />
**EntitySetName**: msdyn_agreements<br />
**PrimaryIdAttribute**: msdyn_agreementid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementDetails](#BKMK_msdyn_AgreementDetails)
- [msdyn_agreementId](#BKMK_msdyn_agreementId)
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


### <a name="BKMK_msdyn_AgreementDetails"></a> msdyn_AgreementDetails

**Description**: Shows the details of this agreement, as presented to the customer<br />
**DisplayName**: Agreement Details<br />
**LogicalName**: msdyn_agreementdetails<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100000


### <a name="BKMK_msdyn_agreementId"></a> msdyn_agreementId

**Description**: Shows the entity instances.<br />
**DisplayName**: Agreement<br />
**LogicalName**: msdyn_agreementid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

**Description**: Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.<br />
**DisplayName**: Billing Account<br />
**LogicalName**: msdyn_billingaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ChildIndex"></a> msdyn_ChildIndex

**Description**: <br />
**DisplayName**: Child Index<br />
**LogicalName**: msdyn_childindex<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_DateCanceled"></a> msdyn_DateCanceled

**Description**: Enter the date this agreement was canceled.<br />
**DisplayName**: Date Canceled<br />
**LogicalName**: msdyn_datecanceled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

**Description**: Type a description of the agreement.<br />
**DisplayName**: Description<br />
**LogicalName**: msdyn_description<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

**Description**: Shows the duration how long this agreement is active.<br />
**DisplayName**: Duration<br />
**LogicalName**: msdyn_duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

**Description**: Enter the date when this agreement is no longer active.<br />
**DisplayName**: End Date<br />
**LogicalName**: msdyn_enddate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: <br />
**DisplayName**: Agreement Number<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OriginatingAgreement"></a> msdyn_OriginatingAgreement

**Description**: If this agreement originates from another agreement, you should specify the originating agreement here<br />
**DisplayName**: Originating Agreement<br />
**LogicalName**: msdyn_originatingagreement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

**Description**: Price List that controls pricing for products added to this Agreement. By default the system will use the Price List specified on the account<br />
**DisplayName**: Price List<br />
**LogicalName**: msdyn_pricelist<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: pricelevel


### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

**Description**: Tax Code to be used to calculate tax when Agreement is taxable. By default the system will use the tax code specified on the service account<br />
**DisplayName**: Sales Tax Code<br />
**LogicalName**: msdyn_salestaxcode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_taxcode


### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

**Description**: Account to be serviced<br />
**DisplayName**: Service Account<br />
**LogicalName**: msdyn_serviceaccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: account


### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

**Description**: The service territory this Agreement relates to. By default this will be set to the Service Territory defined on the service account<br />
**DisplayName**: Service Territory<br />
**LogicalName**: msdyn_serviceterritory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: territory


### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

**Description**: Enter the date from when this agreement is active.<br />
**DisplayName**: Start Date<br />
**LogicalName**: msdyn_startdate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

**Description**: Agreement Sub-status<br />
**DisplayName**: Sub-Status<br />
**LogicalName**: msdyn_substatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementsubstatus


### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

**Description**: Tracks the current system status.<br />
**DisplayName**: System Status<br />
**LogicalName**: msdyn_systemstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Estimate
- **Value**: 690970001 **Label**: Active
- **Value**: 690970002 **Label**: Expired
- **Value**: 690970003 **Label**: Canceled



### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

**Description**: Specify if Agreement is taxable. By default an Agreement is taxable if billing account is not tax exempt, and Agreement type is taxable. If any of the above is false it will be set to non-taxable.<br />
**DisplayName**: Taxable<br />
**LogicalName**: msdyn_taxable<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


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


### <a name="BKMK_processid"></a> processid

**Description**: Contains the ID of the process associated with the entity.<br />
**DisplayName**: Process Id<br />
**LogicalName**: processid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_stageid"></a> stageid

**Description**: Contains the ID of the stage where the entity is located.<br />
**DisplayName**: Stage Id<br />
**LogicalName**: stageid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Agreement<br />
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

**Description**: Reason for the status of the Agreement<br />
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


### <a name="BKMK_traversedpath"></a> traversedpath

**Description**: Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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


### <a name="BKMK_msdyn_BillingAccountName"></a> msdyn_BillingAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_BillingAccountYomiName"></a> msdyn_BillingAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_billingaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_OriginatingAgreementName"></a> msdyn_OriginatingAgreementName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_originatingagreementname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_pricelistname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SalesTaxCodeName"></a> msdyn_SalesTaxCodeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_salestaxcodename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ServiceAccountName"></a> msdyn_ServiceAccountName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceAccountYomiName"></a> msdyn_ServiceAccountYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceaccountyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_msdyn_ServiceTerritoryName"></a> msdyn_ServiceTerritoryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_serviceterritoryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_SubStatusName"></a> msdyn_SubStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_substatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_agreement_ActivityPointers](#BKMK_msdyn_agreement_ActivityPointers)
- [msdyn_agreement_msdyn_approvals](#BKMK_msdyn_agreement_msdyn_approvals)
- [msdyn_agreement_msdyn_bookingalerts](#BKMK_msdyn_agreement_msdyn_bookingalerts)
- [msdyn_agreement_SyncErrors](#BKMK_msdyn_agreement_SyncErrors)
- [msdyn_agreement_DuplicateMatchingRecord](#BKMK_msdyn_agreement_DuplicateMatchingRecord)
- [msdyn_agreement_DuplicateBaseRecord](#BKMK_msdyn_agreement_DuplicateBaseRecord)
- [msdyn_agreement_SharePointDocumentLocations](#BKMK_msdyn_agreement_SharePointDocumentLocations)
- [msdyn_agreement_SharePointDocuments](#BKMK_msdyn_agreement_SharePointDocuments)
- [msdyn_agreement_AsyncOperations](#BKMK_msdyn_agreement_AsyncOperations)
- [msdyn_agreement_MailboxTrackingFolders](#BKMK_msdyn_agreement_MailboxTrackingFolders)
- [msdyn_agreement_UserEntityInstanceDatas](#BKMK_msdyn_agreement_UserEntityInstanceDatas)
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

Same as activitypointer entity [msdyn_agreement_ActivityPointers](activitypointer.md#BKMK_msdyn_agreement_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_ActivityPointers<br />
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


### <a name="BKMK_msdyn_agreement_msdyn_approvals"></a> msdyn_agreement_msdyn_approvals

Same as msdyn_approval entity [msdyn_agreement_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_agreement_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_agreement_msdyn_bookingalerts"></a> msdyn_agreement_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_agreement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreement_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_agreement_SyncErrors"></a> msdyn_agreement_SyncErrors

Same as syncerror entity [msdyn_agreement_SyncErrors](syncerror.md#BKMK_msdyn_agreement_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_SyncErrors<br />
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


### <a name="BKMK_msdyn_agreement_DuplicateMatchingRecord"></a> msdyn_agreement_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_agreement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreement_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_agreement_DuplicateBaseRecord"></a> msdyn_agreement_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_agreement_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreement_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_agreement_SharePointDocumentLocations"></a> msdyn_agreement_SharePointDocumentLocations

Same as sharepointdocumentlocation entity [msdyn_agreement_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_agreement_SharePointDocumentLocations) Many-To-One relationship.

**ReferencingEntity**: sharepointdocumentlocation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_SharePointDocumentLocations<br />
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


### <a name="BKMK_msdyn_agreement_SharePointDocuments"></a> msdyn_agreement_SharePointDocuments

Same as sharepointdocument entity [msdyn_agreement_SharePointDocuments](sharepointdocument.md#BKMK_msdyn_agreement_SharePointDocuments) Many-To-One relationship.

**ReferencingEntity**: sharepointdocument<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_SharePointDocuments<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 60

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_agreement_AsyncOperations"></a> msdyn_agreement_AsyncOperations

Same as asyncoperation entity [msdyn_agreement_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreement_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_AsyncOperations<br />
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


### <a name="BKMK_msdyn_agreement_MailboxTrackingFolders"></a> msdyn_agreement_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_agreement_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreement_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_agreement_UserEntityInstanceDatas"></a> msdyn_agreement_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_agreement_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_agreement_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_agreement_ProcessSession"></a> msdyn_agreement_ProcessSession

Same as processsession entity [msdyn_agreement_ProcessSession](processsession.md#BKMK_msdyn_agreement_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_ProcessSession<br />
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


### <a name="BKMK_msdyn_agreement_BulkDeleteFailures"></a> msdyn_agreement_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_agreement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreement_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses"></a> msdyn_agreement_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_agreement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_agreement_Appointments"></a> msdyn_agreement_Appointments

Same as appointment entity [msdyn_agreement_Appointments](appointment.md#BKMK_msdyn_agreement_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Appointments<br />
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


### <a name="BKMK_msdyn_agreement_Emails"></a> msdyn_agreement_Emails

Same as email entity [msdyn_agreement_Emails](email.md#BKMK_msdyn_agreement_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Emails<br />
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


### <a name="BKMK_msdyn_agreement_Faxes"></a> msdyn_agreement_Faxes

Same as fax entity [msdyn_agreement_Faxes](fax.md#BKMK_msdyn_agreement_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Faxes<br />
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


### <a name="BKMK_msdyn_agreement_Letters"></a> msdyn_agreement_Letters

Same as letter entity [msdyn_agreement_Letters](letter.md#BKMK_msdyn_agreement_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Letters<br />
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


### <a name="BKMK_msdyn_agreement_PhoneCalls"></a> msdyn_agreement_PhoneCalls

Same as phonecall entity [msdyn_agreement_PhoneCalls](phonecall.md#BKMK_msdyn_agreement_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_PhoneCalls<br />
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


### <a name="BKMK_msdyn_agreement_Tasks"></a> msdyn_agreement_Tasks

Same as task entity [msdyn_agreement_Tasks](task.md#BKMK_msdyn_agreement_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Tasks<br />
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


### <a name="BKMK_msdyn_agreement_RecurringAppointmentMasters"></a> msdyn_agreement_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_agreement_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreement_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_agreement_SocialActivities"></a> msdyn_agreement_SocialActivities

Same as socialactivity entity [msdyn_agreement_SocialActivities](socialactivity.md#BKMK_msdyn_agreement_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_SocialActivities<br />
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


### <a name="BKMK_msdyn_agreement_connections1"></a> msdyn_agreement_connections1

Same as connection entity [msdyn_agreement_connections1](connection.md#BKMK_msdyn_agreement_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_connections1<br />
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


### <a name="BKMK_msdyn_agreement_connections2"></a> msdyn_agreement_connections2

Same as connection entity [msdyn_agreement_connections2](connection.md#BKMK_msdyn_agreement_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_connections2<br />
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


### <a name="BKMK_msdyn_agreement_Annotations"></a> msdyn_agreement_Annotations

Same as annotation entity [msdyn_agreement_Annotations](annotation.md#BKMK_msdyn_agreement_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_Annotations<br />
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


### <a name="BKMK_msdyn_agreement_ServiceAppointments"></a> msdyn_agreement_ServiceAppointments

Same as serviceappointment entity [msdyn_agreement_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreement_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_agreement_ServiceAppointments<br />
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


### <a name="BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) Many-To-One relationship.

**ReferencingEntity**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**ReferencingAttribute**: bpf_msdyn_agreementid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: msdyn_agreement
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement"></a> msdyn_msdyn_agreement_invoicedetail_Agreement

Same as invoicedetail entity [msdyn_msdyn_agreement_invoicedetail_Agreement](invoicedetail.md#BKMK_msdyn_msdyn_agreement_invoicedetail_Agreement) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_invoicedetail_Agreement<br />
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


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement"></a> msdyn_msdyn_agreement_msdyn_actual_Agreement

Same as msdyn_actual entity [msdyn_msdyn_agreement_msdyn_actual_Agreement](msdyn_actual.md#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_actual_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

Same as msdyn_agreement entity [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreement<br />
**ReferencingAttribute**: msdyn_originatingagreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement<br />
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


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement

Same as msdyn_agreementbookingdate entity [msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingdate<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement<br />
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


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingincident<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Booking Incidents
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Booking Products
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Booking Services
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservicetask<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Booking Service Tasks
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

Same as msdyn_agreementbookingsetup entity [msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreementbookingsetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingsetup<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Bookings
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement

Same as msdyn_agreementinvoicedate entity [msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](msdyn_agreementinvoicedate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicedate<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement

Same as msdyn_agreementinvoiceproduct entity [msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement

Same as msdyn_agreementinvoicesetup entity [msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](msdyn_agreementinvoicesetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoicesetup<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseLabel
- **Group**: Details
- **Label**: Agreement Invoices
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

Same as msdyn_workorder entity [msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_workorder.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorder<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_msdyn_workorder_Agreement<br />
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


### <a name="BKMK_msdyn_msdyn_agreement_quotedetail_Agreement"></a> msdyn_msdyn_agreement_quotedetail_Agreement

Same as quotedetail entity [msdyn_msdyn_agreement_quotedetail_Agreement](quotedetail.md#BKMK_msdyn_msdyn_agreement_quotedetail_Agreement) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_quotedetail_Agreement<br />
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


### <a name="BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement"></a> msdyn_msdyn_agreement_salesorderdetail_Agreement

Same as salesorderdetail entity [msdyn_msdyn_agreement_salesorderdetail_Agreement](salesorderdetail.md#BKMK_msdyn_msdyn_agreement_salesorderdetail_Agreement) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: msdyn_agreement<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_agreement_salesorderdetail_Agreement<br />
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

See systemuser Entity [lk_msdyn_agreement_createdby](systemuser.md#BKMK_lk_msdyn_agreement_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_createdonbehalfby"></a> lk_msdyn_agreement_createdonbehalfby

See systemuser Entity [lk_msdyn_agreement_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreement_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_modifiedby"></a> lk_msdyn_agreement_modifiedby

See systemuser Entity [lk_msdyn_agreement_modifiedby](systemuser.md#BKMK_lk_msdyn_agreement_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_agreement_modifiedonbehalfby"></a> lk_msdyn_agreement_modifiedonbehalfby

See systemuser Entity [lk_msdyn_agreement_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreement_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_agreement"></a> user_msdyn_agreement

See systemuser Entity [user_msdyn_agreement](systemuser.md#BKMK_user_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_team_msdyn_agreement"></a> team_msdyn_agreement

See team Entity [team_msdyn_agreement](team.md#BKMK_team_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_agreement"></a> business_unit_msdyn_agreement

See businessunit Entity [business_unit_msdyn_agreement](businessunit.md#BKMK_business_unit_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_processstage_msdyn_agreement"></a> processstage_msdyn_agreement

See processstage Entity [processstage_msdyn_agreement](processstage.md#BKMK_processstage_msdyn_agreement) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_agreement_BillingAccount"></a> msdyn_account_msdyn_agreement_BillingAccount

See account Entity [msdyn_account_msdyn_agreement_BillingAccount](account.md#BKMK_msdyn_account_msdyn_agreement_BillingAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_agreement_ServiceAccount"></a> msdyn_account_msdyn_agreement_ServiceAccount

See account Entity [msdyn_account_msdyn_agreement_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_agreement_ServiceAccount) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

See msdyn_agreement Entity [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus"></a> msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus

See msdyn_agreementsubstatus Entity [msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus](msdyn_agreementsubstatus.md#BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode"></a> msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode

See msdyn_taxcode Entity [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_agreement_PriceList"></a> msdyn_pricelevel_msdyn_agreement_PriceList

See pricelevel Entity [msdyn_pricelevel_msdyn_agreement_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_agreement_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory"></a> msdyn_territory_msdyn_agreement_ServiceTerritory

See territory Entity [msdyn_territory_msdyn_agreement_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_agreement?text=msdyn_agreement EntityType" />