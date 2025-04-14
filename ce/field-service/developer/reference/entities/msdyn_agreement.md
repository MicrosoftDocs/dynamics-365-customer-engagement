---
title: "Agreement (msdyn_agreement) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Agreement (msdyn_agreement) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Agreement (msdyn_agreement) table/entity reference (Microsoft Dynamics 365 Field Service)

Provides ability to store details about service agreements you have with your customers

## Messages

The following table lists the messages for the Agreement (msdyn_agreement) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agreements(*msdyn_agreementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_agreements<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agreements(*msdyn_agreementid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_FieldServiceAgreementSystemStatusAction`<br />Event: False |**msdyn_FieldServiceAgreementSystemStatusAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_agreements(*msdyn_agreementid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agreements<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_agreements(*msdyn_agreementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agreements(*msdyn_agreementid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agreements(*msdyn_agreementid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agreement (msdyn_agreement) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agreement** |
| **DisplayCollectionName** | **Agreements** |
| **SchemaName** | `msdyn_agreement` |
| **CollectionSchemaName** | `msdyn_agreements` |
| **EntitySetName** | `msdyn_agreements`|
| **LogicalName** | `msdyn_agreement` |
| **LogicalCollectionName** | `msdyn_agreements` |
| **PrimaryIdAttribute** | `msdyn_agreementid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementDetails](#BKMK_msdyn_AgreementDetails)
- [msdyn_agreementId](#BKMK_msdyn_agreementId)
- [msdyn_AgreementRecordGeneration](#BKMK_msdyn_AgreementRecordGeneration)
- [msdyn_AutoNumbering](#BKMK_msdyn_AutoNumbering)
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_ChildIndex](#BKMK_msdyn_ChildIndex)
- [msdyn_DateCanceled](#BKMK_msdyn_DateCanceled)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_EndDate](#BKMK_msdyn_EndDate)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_OriginatingAgreement](#BKMK_msdyn_OriginatingAgreement)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_ProcessStartedOn](#BKMK_msdyn_ProcessStartedOn)
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
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_AgreementDetails"></a> msdyn_AgreementDetails

|Property|Value|
|---|---|
|Description|**Shows the details of this agreement, as presented to the customer**|
|DisplayName|**Agreement Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementdetails`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100000|

### <a name="BKMK_msdyn_agreementId"></a> msdyn_agreementId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Agreement**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_AgreementRecordGeneration"></a> msdyn_AgreementRecordGeneration

|Property|Value|
|---|---|
|Description|**This field defines the time of day when Work Orders and Invoices are generated by the Agreement Booking Setups and Agreement Invoice Setups defined on this Agreement. If this field is blank, the logic will look to the overall setting on the Field Service Settings record.**|
|DisplayName|**Agreement Record Generation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementrecordgeneration`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AutoNumbering"></a> msdyn_AutoNumbering

|Property|Value|
|---|---|
|Description|**Internal field used to generate the next name upon entity creation. It is optionally copied to the msdyn_name field.**|
|DisplayName|**Auto-Numbering**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autonumbering`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_BillingAccount"></a> msdyn_BillingAccount

|Property|Value|
|---|---|
|Description|**Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.**|
|DisplayName|**Billing Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_billingaccount`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_ChildIndex"></a> msdyn_ChildIndex

|Property|Value|
|---|---|
|Description||
|DisplayName|**Child Index**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_childindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_DateCanceled"></a> msdyn_DateCanceled

|Property|Value|
|---|---|
|Description|**Enter the date this agreement was canceled.**|
|DisplayName|**Date Canceled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datecanceled`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Type a description of the agreement.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Shows the duration how long this agreement is active.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

|Property|Value|
|---|---|
|Description|**Enter the date when this agreement is no longer active.**|
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agreement Number**|
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

### <a name="BKMK_msdyn_OriginatingAgreement"></a> msdyn_OriginatingAgreement

|Property|Value|
|---|---|
|Description|**If this agreement originates from another agreement, you should specify the originating agreement here**|
|DisplayName|**Originating Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_originatingagreement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Price List that controls pricing for products added to this Agreement. By default the system will use the Price List specified on the account**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_ProcessStartedOn"></a> msdyn_ProcessStartedOn

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Process Started On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processstartedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_SalesTaxCode"></a> msdyn_SalesTaxCode

|Property|Value|
|---|---|
|Description|**Tax Code to be used to calculate tax when Agreement is taxable. By default the system will use the tax code specified on the service account**|
|DisplayName|**Sales Tax Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salestaxcode`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_taxcode|

### <a name="BKMK_msdyn_ServiceAccount"></a> msdyn_ServiceAccount

|Property|Value|
|---|---|
|Description|**Account to be serviced**|
|DisplayName|**Service Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceaccount`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|---|---|
|Description|**The service territory this Agreement relates to. By default this will be set to the Service Territory defined on the service account**|
|DisplayName|**Service Territory**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceterritory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|territory|

### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

|Property|Value|
|---|---|
|Description|**Enter the date from when this agreement is active.**|
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|---|---|
|Description|**Agreement Substatus**|
|DisplayName|**Substatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_substatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementsubstatus|

### <a name="BKMK_msdyn_SystemStatus"></a> msdyn_SystemStatus

|Property|Value|
|---|---|
|Description|**Tracks the current system status.**|
|DisplayName|**System Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_systemstatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_agreementsystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Estimate**|
|690970001|**Active**|
|690970002|**Expired**|
|690970003|**Canceled**|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**Specify if Agreement is taxable. By default an Agreement is taxable if billing account is not tax exempt, and Agreement type is taxable. If any of the above is false it will be set to non-taxable.**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agreement_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Agreement**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreement_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agreement**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreement_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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

- [msdyn_account_msdyn_agreement_BillingAccount](#BKMK_msdyn_account_msdyn_agreement_BillingAccount)
- [msdyn_account_msdyn_agreement_ServiceAccount](#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)
- [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-many-to-one)
- [msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus](#BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus)
- [msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode)
- [msdyn_territory_msdyn_agreement_ServiceTerritory](#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory)

### <a name="BKMK_msdyn_account_msdyn_agreement_BillingAccount"></a> msdyn_account_msdyn_agreement_BillingAccount

One-To-Many Relationship: [account msdyn_account_msdyn_agreement_BillingAccount](account.md#BKMK_msdyn_account_msdyn_agreement_BillingAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_billingaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_agreement_ServiceAccount"></a> msdyn_account_msdyn_agreement_ServiceAccount

One-To-Many Relationship: [account msdyn_account_msdyn_agreement_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_agreement_ServiceAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-many-to-one"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_originatingagreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_originatingagreement_msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus"></a> msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus

One-To-Many Relationship: [msdyn_agreementsubstatus msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus](msdyn_agreementsubstatus.md#BKMK_msdyn_msdyn_agreementsubstatus_msdyn_agreement_SubStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementsubstatus`|
|ReferencedAttribute|`msdyn_agreementsubstatusid`|
|ReferencingAttribute|`msdyn_substatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_substatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode"></a> msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode

One-To-Many Relationship: [msdyn_taxcode msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`msdyn_salestaxcode`|
|ReferencingEntityNavigationPropertyName|`msdyn_salestaxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory"></a> msdyn_territory_msdyn_agreement_ServiceTerritory

One-To-Many Relationship: [territory msdyn_territory_msdyn_agreement_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_agreement_ServiceTerritory)

|Property|Value|
|---|---|
|ReferencedEntity|`territory`|
|ReferencedAttribute|`territoryid`|
|ReferencingAttribute|`msdyn_serviceterritory`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceterritory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_agreement_msdyn_bookingalerts](#BKMK_msdyn_agreement_msdyn_bookingalerts)
- [msdyn_msdyn_agreement_msdyn_actual_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement)
- [msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-one-to-many)
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

### <a name="BKMK_msdyn_agreement_msdyn_bookingalerts"></a> msdyn_agreement_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_agreement_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreement_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreement_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement"></a> msdyn_msdyn_agreement_msdyn_actual_Agreement

Many-To-One Relationship: [msdyn_actual msdyn_msdyn_agreement_msdyn_actual_Agreement](msdyn_actual.md#BKMK_msdyn_msdyn_agreement_msdyn_actual_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_actual_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-one-to-many"></a> msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement

Many-To-One Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreement`|
|ReferencingAttribute|`msdyn_originatingagreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreement_OriginatingAgreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement

Many-To-One Relationship: [msdyn_agreementbookingdate msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingdate_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingincident_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Booking Incidents<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingproduct_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Booking Products<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Booking Services<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement

Many-To-One Relationship: [msdyn_agreementbookingservicetask msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingservicetask_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Booking Service Tasks<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement

Many-To-One Relationship: [msdyn_agreementbookingsetup msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement](msdyn_agreementbookingsetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingsetup`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementbookingsetup_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Bookings<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement

Many-To-One Relationship: [msdyn_agreementinvoicedate msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement](msdyn_agreementinvoicedate.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicedate`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementinvoicedate_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement

Many-To-One Relationship: [msdyn_agreementinvoiceproduct msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoiceproduct`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementinvoiceproduct_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement

Many-To-One Relationship: [msdyn_agreementinvoicesetup msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement](msdyn_agreementinvoicesetup.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementinvoicesetup`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_agreementinvoicesetup_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Agreement Invoices<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_workorder.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreement_msdyn_workorder_Agreement`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

