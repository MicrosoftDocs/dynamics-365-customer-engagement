---
title: "Agreement Booking Service (msdyn_agreementbookingservice) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Agreement Booking Service (msdyn_agreementbookingservice) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Agreement Booking Service (msdyn_agreementbookingservice) table/entity reference (Microsoft Dynamics 365 Field Service)

Specify the booking service for the agreement.

## Messages

The following table lists the messages for the Agreement Booking Service (msdyn_agreementbookingservice) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_agreementbookingservices<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_agreementbookingservices<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_agreementbookingservices(*msdyn_agreementbookingserviceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Agreement Booking Service (msdyn_agreementbookingservice) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Agreement Booking Service (msdyn_agreementbookingservice) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Agreement Booking Service** |
| **DisplayCollectionName** | **Agreement Booking Services** |
| **SchemaName** | `msdyn_agreementbookingservice` |
| **CollectionSchemaName** | `msdyn_agreementbookingservices` |
| **EntitySetName** | `msdyn_agreementbookingservices`|
| **LogicalName** | `msdyn_agreementbookingservice` |
| **LogicalCollectionName** | `msdyn_agreementbookingservices` |
| **PrimaryIdAttribute** | `msdyn_agreementbookingserviceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_AgreementBookingIncident](#BKMK_msdyn_AgreementBookingIncident)
- [msdyn_agreementbookingserviceId](#BKMK_msdyn_agreementbookingserviceId)
- [msdyn_AgreementBookingSetup](#BKMK_msdyn_AgreementBookingSetup)
- [msdyn_Currency](#BKMK_msdyn_Currency)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_DurationToBill](#BKMK_msdyn_DurationToBill)
- [msdyn_IsCopied](#BKMK_msdyn_IsCopied)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Service](#BKMK_msdyn_Service)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**Unique identifier for Agreement associated with Agreement Booking Service.**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_agreement|

### <a name="BKMK_msdyn_AgreementBookingIncident"></a> msdyn_AgreementBookingIncident

|Property|Value|
|---|---|
|Description|**The Agreement Booking Incident related to this service**|
|DisplayName|**Agreement Booking Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingincident`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementbookingincident|

### <a name="BKMK_msdyn_agreementbookingserviceId"></a> msdyn_agreementbookingserviceId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Agreement Booking Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingserviceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_AgreementBookingSetup"></a> msdyn_AgreementBookingSetup

|Property|Value|
|---|---|
|Description|**Unique identifier for Agreement Booking Setup associated with Agreement Booking Service.**|
|DisplayName|**Agreement Booking Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingsetup`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_agreementbookingsetup|

### <a name="BKMK_msdyn_Currency"></a> msdyn_Currency

|Property|Value|
|---|---|
|Description||
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currency`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**Customer Asset related to this Service**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Shows the actual duration of service.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_DurationToBill"></a> msdyn_DurationToBill

|Property|Value|
|---|---|
|Description|**Enter the duration you want to bill the customer for. By default, this will default to the same value as the "Duration" field.**|
|DisplayName|**Duration To Bill**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationtobill`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_IsCopied"></a> msdyn_IsCopied

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Copied**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iscopied`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_agreementbookingservice_msdyn_iscopied`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|---|---|
|Description|**Shows the order of this service within the agreement services.**|
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Optionally set Price List that will determine the pricing for this service on the Work Order**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_Service"></a> msdyn_Service

|Property|Value|
|---|---|
|Description|**Unique identifier for Product/Service associated with Agreement Booking Service.**|
|DisplayName|**Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_service`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**The unit that determines the pricing for this service when Price List is set**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

|Property|Value|
|---|---|
|Description|**Enter the amount you wish to charge the customer per unit. This field is optional.**|
|DisplayName|**Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Agreement Booking Service**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementbookingservice_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Agreement Booking Service**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_agreementbookingservice_statuscode`|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_currency_Base](#BKMK_msdyn_currency_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_currency_Base"></a> msdyn_currency_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the currency in the base currency.**|
|DisplayName|**Currency (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_currency_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the unit amount in the base currency.**|
|DisplayName|**Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

- [business_unit_msdyn_agreementbookingservice](#BKMK_business_unit_msdyn_agreementbookingservice)
- [lk_msdyn_agreementbookingservice_createdby](#BKMK_lk_msdyn_agreementbookingservice_createdby)
- [lk_msdyn_agreementbookingservice_createdonbehalfby](#BKMK_lk_msdyn_agreementbookingservice_createdonbehalfby)
- [lk_msdyn_agreementbookingservice_modifiedby](#BKMK_lk_msdyn_agreementbookingservice_modifiedby)
- [lk_msdyn_agreementbookingservice_modifiedonbehalfby](#BKMK_lk_msdyn_agreementbookingservice_modifiedonbehalfby)
- [msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement)
- [msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident](#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident)
- [msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)
- [msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)
- [msdyn_product_msdyn_agreementbookingservice_Service](#BKMK_msdyn_product_msdyn_agreementbookingservice_Service)
- [msdyn_uom_msdyn_agreementbookingservice_Unit](#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit)
- [owner_msdyn_agreementbookingservice](#BKMK_owner_msdyn_agreementbookingservice)
- [team_msdyn_agreementbookingservice](#BKMK_team_msdyn_agreementbookingservice)
- [TransactionCurrency_msdyn_agreementbookingservice](#BKMK_TransactionCurrency_msdyn_agreementbookingservice)
- [user_msdyn_agreementbookingservice](#BKMK_user_msdyn_agreementbookingservice)

### <a name="BKMK_business_unit_msdyn_agreementbookingservice"></a> business_unit_msdyn_agreementbookingservice

One-To-Many Relationship: [businessunit business_unit_msdyn_agreementbookingservice](businessunit.md#BKMK_business_unit_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingservice_createdby"></a> lk_msdyn_agreementbookingservice_createdby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingservice_createdby](systemuser.md#BKMK_lk_msdyn_agreementbookingservice_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingservice_createdonbehalfby"></a> lk_msdyn_agreementbookingservice_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingservice_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingservice_modifiedby"></a> lk_msdyn_agreementbookingservice_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingservice_modifiedby](systemuser.md#BKMK_lk_msdyn_agreementbookingservice_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_agreementbookingservice_modifiedonbehalfby"></a> lk_msdyn_agreementbookingservice_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_agreementbookingservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_agreementbookingservice_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement"></a> msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_agreementbookingservice_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident"></a> msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident

One-To-Many Relationship: [msdyn_agreementbookingincident msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_agreementbookingincident_msdyn_agreementbookingservice_AgreementBookingIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingincident`|
|ReferencedAttribute|`msdyn_agreementbookingincidentid`|
|ReferencingAttribute|`msdyn_agreementbookingincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup"></a> msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup

One-To-Many Relationship: [msdyn_agreementbookingsetup msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup](msdyn_agreementbookingsetup.md#BKMK_msdyn_msdyn_agreementbookingsetup_msdyn_agreementbookingservice_AgreementBookingSetup)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingsetup`|
|ReferencedAttribute|`msdyn_agreementbookingsetupid`|
|ReferencingAttribute|`msdyn_agreementbookingsetup`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingsetup`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList"></a> msdyn_pricelevel_msdyn_agreementbookingservice_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_agreementbookingservice_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_agreementbookingservice_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_agreementbookingservice_Service"></a> msdyn_product_msdyn_agreementbookingservice_Service

One-To-Many Relationship: [product msdyn_product_msdyn_agreementbookingservice_Service](product.md#BKMK_msdyn_product_msdyn_agreementbookingservice_Service)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_service`|
|ReferencingEntityNavigationPropertyName|`msdyn_service`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit"></a> msdyn_uom_msdyn_agreementbookingservice_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_agreementbookingservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_agreementbookingservice"></a> owner_msdyn_agreementbookingservice

One-To-Many Relationship: [owner owner_msdyn_agreementbookingservice](owner.md#BKMK_owner_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_agreementbookingservice"></a> team_msdyn_agreementbookingservice

One-To-Many Relationship: [team team_msdyn_agreementbookingservice](team.md#BKMK_team_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_agreementbookingservice"></a> TransactionCurrency_msdyn_agreementbookingservice

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_agreementbookingservice](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_agreementbookingservice"></a> user_msdyn_agreementbookingservice

One-To-Many Relationship: [systemuser user_msdyn_agreementbookingservice](systemuser.md#BKMK_user_msdyn_agreementbookingservice)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_agreementbookingservice_ActivityPointers](#BKMK_msdyn_agreementbookingservice_ActivityPointers)
- [msdyn_agreementbookingservice_adx_inviteredemptions](#BKMK_msdyn_agreementbookingservice_adx_inviteredemptions)
- [msdyn_agreementbookingservice_adx_portalcomments](#BKMK_msdyn_agreementbookingservice_adx_portalcomments)
- [msdyn_agreementbookingservice_Annotations](#BKMK_msdyn_agreementbookingservice_Annotations)
- [msdyn_agreementbookingservice_Appointments](#BKMK_msdyn_agreementbookingservice_Appointments)
- [msdyn_agreementbookingservice_AsyncOperations](#BKMK_msdyn_agreementbookingservice_AsyncOperations)
- [msdyn_agreementbookingservice_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures)
- [msdyn_agreementbookingservice_chats](#BKMK_msdyn_agreementbookingservice_chats)
- [msdyn_agreementbookingservice_connections1](#BKMK_msdyn_agreementbookingservice_connections1)
- [msdyn_agreementbookingservice_connections2](#BKMK_msdyn_agreementbookingservice_connections2)
- [msdyn_agreementbookingservice_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord)
- [msdyn_agreementbookingservice_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord)
- [msdyn_agreementbookingservice_Emails](#BKMK_msdyn_agreementbookingservice_Emails)
- [msdyn_agreementbookingservice_Faxes](#BKMK_msdyn_agreementbookingservice_Faxes)
- [msdyn_agreementbookingservice_Letters](#BKMK_msdyn_agreementbookingservice_Letters)
- [msdyn_agreementbookingservice_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders)
- [msdyn_agreementbookingservice_msdyn_bookingalerts](#BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts)
- [msdyn_agreementbookingservice_msdyn_copilottranscripts](#BKMK_msdyn_agreementbookingservice_msdyn_copilottranscripts)
- [msdyn_agreementbookingservice_msdyn_ocliveworkitems](#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)
- [msdyn_agreementbookingservice_msdyn_ocsessions](#BKMK_msdyn_agreementbookingservice_msdyn_ocsessions)
- [msdyn_agreementbookingservice_msfp_alerts](#BKMK_msdyn_agreementbookingservice_msfp_alerts)
- [msdyn_agreementbookingservice_msfp_surveyinvites](#BKMK_msdyn_agreementbookingservice_msfp_surveyinvites)
- [msdyn_agreementbookingservice_msfp_surveyresponses](#BKMK_msdyn_agreementbookingservice_msfp_surveyresponses)
- [msdyn_agreementbookingservice_PhoneCalls](#BKMK_msdyn_agreementbookingservice_PhoneCalls)
- [msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservice_ProcessSession](#BKMK_msdyn_agreementbookingservice_ProcessSession)
- [msdyn_agreementbookingservice_RecurringAppointmentMasters](#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)
- [msdyn_agreementbookingservice_ServiceAppointments](#BKMK_msdyn_agreementbookingservice_ServiceAppointments)
- [msdyn_agreementbookingservice_SocialActivities](#BKMK_msdyn_agreementbookingservice_SocialActivities)
- [msdyn_agreementbookingservice_SyncErrors](#BKMK_msdyn_agreementbookingservice_SyncErrors)
- [msdyn_agreementbookingservice_Tasks](#BKMK_msdyn_agreementbookingservice_Tasks)
- [msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService)

### <a name="BKMK_msdyn_agreementbookingservice_ActivityPointers"></a> msdyn_agreementbookingservice_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_agreementbookingservice_ActivityPointers](activitypointer.md#BKMK_msdyn_agreementbookingservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_adx_inviteredemptions"></a> msdyn_agreementbookingservice_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_agreementbookingservice_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_agreementbookingservice_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_adx_portalcomments"></a> msdyn_agreementbookingservice_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_agreementbookingservice_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_agreementbookingservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Annotations"></a> msdyn_agreementbookingservice_Annotations

Many-To-One Relationship: [annotation msdyn_agreementbookingservice_Annotations](annotation.md#BKMK_msdyn_agreementbookingservice_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Appointments"></a> msdyn_agreementbookingservice_Appointments

Many-To-One Relationship: [appointment msdyn_agreementbookingservice_Appointments](appointment.md#BKMK_msdyn_agreementbookingservice_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_AsyncOperations"></a> msdyn_agreementbookingservice_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_agreementbookingservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_agreementbookingservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_BulkDeleteFailures"></a> msdyn_agreementbookingservice_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_agreementbookingservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_chats"></a> msdyn_agreementbookingservice_chats

Many-To-One Relationship: [chat msdyn_agreementbookingservice_chats](chat.md#BKMK_msdyn_agreementbookingservice_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_connections1"></a> msdyn_agreementbookingservice_connections1

Many-To-One Relationship: [connection msdyn_agreementbookingservice_connections1](connection.md#BKMK_msdyn_agreementbookingservice_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_connections2"></a> msdyn_agreementbookingservice_connections2

Many-To-One Relationship: [connection msdyn_agreementbookingservice_connections2](connection.md#BKMK_msdyn_agreementbookingservice_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord"></a> msdyn_agreementbookingservice_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementbookingservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord"></a> msdyn_agreementbookingservice_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_agreementbookingservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Emails"></a> msdyn_agreementbookingservice_Emails

Many-To-One Relationship: [email msdyn_agreementbookingservice_Emails](email.md#BKMK_msdyn_agreementbookingservice_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Faxes"></a> msdyn_agreementbookingservice_Faxes

Many-To-One Relationship: [fax msdyn_agreementbookingservice_Faxes](fax.md#BKMK_msdyn_agreementbookingservice_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Letters"></a> msdyn_agreementbookingservice_Letters

Many-To-One Relationship: [letter msdyn_agreementbookingservice_Letters](letter.md#BKMK_msdyn_agreementbookingservice_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders"></a> msdyn_agreementbookingservice_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_agreementbookingservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts"></a> msdyn_agreementbookingservice_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_agreementbookingservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_agreementbookingservice_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_copilottranscripts"></a> msdyn_agreementbookingservice_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_agreementbookingservice_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_agreementbookingservice_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems"></a> msdyn_agreementbookingservice_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_agreementbookingservice_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_agreementbookingservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msdyn_ocsessions"></a> msdyn_agreementbookingservice_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_agreementbookingservice_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_agreementbookingservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msfp_alerts"></a> msdyn_agreementbookingservice_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_agreementbookingservice_msfp_alerts](msfp_alert.md#BKMK_msdyn_agreementbookingservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msfp_surveyinvites"></a> msdyn_agreementbookingservice_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_agreementbookingservice_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_agreementbookingservice_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_msfp_surveyresponses"></a> msdyn_agreementbookingservice_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_agreementbookingservice_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_agreementbookingservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_PhoneCalls"></a> msdyn_agreementbookingservice_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_agreementbookingservice_PhoneCalls](phonecall.md#BKMK_msdyn_agreementbookingservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_ProcessSession"></a> msdyn_agreementbookingservice_ProcessSession

Many-To-One Relationship: [processsession msdyn_agreementbookingservice_ProcessSession](processsession.md#BKMK_msdyn_agreementbookingservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters"></a> msdyn_agreementbookingservice_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_agreementbookingservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_agreementbookingservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_ServiceAppointments"></a> msdyn_agreementbookingservice_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_agreementbookingservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_agreementbookingservice_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_SocialActivities"></a> msdyn_agreementbookingservice_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_agreementbookingservice_SocialActivities](socialactivity.md#BKMK_msdyn_agreementbookingservice_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_SyncErrors"></a> msdyn_agreementbookingservice_SyncErrors

Many-To-One Relationship: [syncerror msdyn_agreementbookingservice_SyncErrors](syncerror.md#BKMK_msdyn_agreementbookingservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_agreementbookingservice_Tasks"></a> msdyn_agreementbookingservice_Tasks

Many-To-One Relationship: [task msdyn_agreementbookingservice_Tasks](task.md#BKMK_msdyn_agreementbookingservice_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_agreementbookingservice_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService"></a> msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService

Many-To-One Relationship: [msdyn_workorderservice msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](msdyn_workorderservice.md#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_agreementbookingservice`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

