---
title: "Work Order (msdyn_workorder) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Work Order (msdyn_workorder) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work Order (msdyn_workorder) table/entity reference (Microsoft Dynamics 365 Field Service)

Work orders store all information about the job performed for an account. Stores incident details, resource, expenses, tasks, communications, billing and more

## Messages

The following table lists the messages for the Work Order (msdyn_workorder) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workorders(*msdyn_workorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_workorders<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workorders(*msdyn_workorderid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `msdyn_FieldServiceWorkOrderSystemStatusAction`<br />Event: False |**msdyn_FieldServiceWorkOrderSystemStatusAction action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `msdyn_UpdateWorkOrderRecap`<br />Event: True |**msdyn_UpdateWorkOrderRecap action** |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_workorders(*msdyn_workorderid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workorders<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_workorders(*msdyn_workorderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workorders(*msdyn_workorderid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workorders(*msdyn_workorderid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Order (msdyn_workorder) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Order** |
| **DisplayCollectionName** | **Work Orders** |
| **SchemaName** | `msdyn_workorder` |
| **CollectionSchemaName** | `msdyn_workorders` |
| **EntitySetName** | `msdyn_workorders`|
| **LogicalName** | `msdyn_workorder` |
| **LogicalCollectionName** | `msdyn_workorders` |
| **PrimaryIdAttribute** | `msdyn_workorderid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Address1](#BKMK_msdyn_Address1)
- [msdyn_Address2](#BKMK_msdyn_Address2)
- [msdyn_Address3](#BKMK_msdyn_Address3)
- [msdyn_AddressName](#BKMK_msdyn_AddressName)
- [msdyn_Agreement](#BKMK_msdyn_Agreement)
- [msdyn_AutoNumbering](#BKMK_msdyn_AutoNumbering)
- [msdyn_BillingAccount](#BKMK_msdyn_BillingAccount)
- [msdyn_BookingSummary](#BKMK_msdyn_BookingSummary)
- [msdyn_ChildIndex](#BKMK_msdyn_ChildIndex)
- [msdyn_City](#BKMK_msdyn_City)
- [msdyn_ClosedBy](#BKMK_msdyn_ClosedBy)
- [msdyn_completedon](#BKMK_msdyn_completedon)
- [msdyn_CostNTEPercent](#BKMK_msdyn_CostNTEPercent)
- [msdyn_Country](#BKMK_msdyn_Country)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_DateWindowEnd](#BKMK_msdyn_DateWindowEnd)
- [msdyn_DateWindowStart](#BKMK_msdyn_DateWindowStart)
- [msdyn_EstimateSubtotalAmount](#BKMK_msdyn_EstimateSubtotalAmount)
- [msdyn_firstarrivedon](#BKMK_msdyn_firstarrivedon)
- [msdyn_FollowUpNote](#BKMK_msdyn_FollowUpNote)
- [msdyn_FollowUpRequired](#BKMK_msdyn_FollowUpRequired)
- [msdyn_FunctionalLocation](#BKMK_msdyn_FunctionalLocation)
- [msdyn_Instructions](#BKMK_msdyn_Instructions)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_IoTAlert](#BKMK_msdyn_IoTAlert)
- [msdyn_IsFollowUp](#BKMK_msdyn_IsFollowUp)
- [msdyn_IsMobile](#BKMK_msdyn_IsMobile)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_nottoexceedcostamount](#BKMK_msdyn_nottoexceedcostamount)
- [msdyn_nottoexceedpriceamount](#BKMK_msdyn_nottoexceedpriceamount)
- [msdyn_OpportunityId](#BKMK_msdyn_OpportunityId)
- [msdyn_ParentWorkOrder](#BKMK_msdyn_ParentWorkOrder)
- [msdyn_phoneNumber](#BKMK_msdyn_phoneNumber)
- [msdyn_PostalCode](#BKMK_msdyn_PostalCode)
- [msdyn_PreferredResource](#BKMK_msdyn_PreferredResource)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_PriceNTEPercent](#BKMK_msdyn_PriceNTEPercent)
- [msdyn_PrimaryIncidentDescription](#BKMK_msdyn_PrimaryIncidentDescription)
- [msdyn_PrimaryIncidentEstimatedDuration](#BKMK_msdyn_PrimaryIncidentEstimatedDuration)
- [msdyn_PrimaryIncidentType](#BKMK_msdyn_PrimaryIncidentType)
- [msdyn_PrimaryResolution](#BKMK_msdyn_PrimaryResolution)
- [msdyn_Priority](#BKMK_msdyn_Priority)
- [msdyn_productsservicescost](#BKMK_msdyn_productsservicescost)
- [msdyn_productsservicescost_Base](#BKMK_msdyn_productsservicescost_Base)
- [msdyn_productsservicesestimatedcost](#BKMK_msdyn_productsservicesestimatedcost)
- [msdyn_productsservicesestimatedcost_Base](#BKMK_msdyn_productsservicesestimatedcost_Base)
- [msdyn_ReportedByContact](#BKMK_msdyn_ReportedByContact)
- [msdyn_ServiceAccount](#BKMK_msdyn_ServiceAccount)
- [msdyn_ServiceRequest](#BKMK_msdyn_ServiceRequest)
- [msdyn_ServiceTerritory](#BKMK_msdyn_ServiceTerritory)
- [msdyn_StateOrProvince](#BKMK_msdyn_StateOrProvince)
- [msdyn_SubStatus](#BKMK_msdyn_SubStatus)
- [msdyn_SubtotalAmount](#BKMK_msdyn_SubtotalAmount)
- [msdyn_SupportContact](#BKMK_msdyn_SupportContact)
- [msdyn_SystemStatus](#BKMK_msdyn_SystemStatus)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TaxCode](#BKMK_msdyn_TaxCode)
- [msdyn_TimeClosed](#BKMK_msdyn_TimeClosed)
- [msdyn_TimeFromPromised](#BKMK_msdyn_TimeFromPromised)
- [msdyn_TimeGroup](#BKMK_msdyn_TimeGroup)
- [msdyn_TimeGroupDetailSelected](#BKMK_msdyn_TimeGroupDetailSelected)
- [msdyn_TimeToPromised](#BKMK_msdyn_TimeToPromised)
- [msdyn_TimeWindowEnd](#BKMK_msdyn_TimeWindowEnd)
- [msdyn_TimeWindowStart](#BKMK_msdyn_TimeWindowStart)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_totalestimatedaftertaxprice](#BKMK_msdyn_totalestimatedaftertaxprice)
- [msdyn_totalestimatedaftertaxprice_Base](#BKMK_msdyn_totalestimatedaftertaxprice_Base)
- [msdyn_totalestimatedduration](#BKMK_msdyn_totalestimatedduration)
- [msdyn_TotalSalesTax](#BKMK_msdyn_TotalSalesTax)
- [msdyn_Trade](#BKMK_msdyn_Trade)
- [msdyn_workhourtemplate](#BKMK_msdyn_workhourtemplate)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_workorderarrivaltimekpiid](#BKMK_msdyn_workorderarrivaltimekpiid)
- [msdyn_workorderId](#BKMK_msdyn_workorderId)
- [msdyn_workorderresolutionkpiid](#BKMK_msdyn_workorderresolutionkpiid)
- [msdyn_WorkOrderSummary](#BKMK_msdyn_WorkOrderSummary)
- [msdyn_WorkOrderType](#BKMK_msdyn_WorkOrderType)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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

### <a name="BKMK_msdyn_Address1"></a> msdyn_Address1

|Property|Value|
|---|---|
|Description||
|DisplayName|**Street 1**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address1`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Address2"></a> msdyn_Address2

|Property|Value|
|---|---|
|Description||
|DisplayName|**Street 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address2`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Address3"></a> msdyn_Address3

|Property|Value|
|---|---|
|Description||
|DisplayName|**Street 3**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_address3`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_AddressName"></a> msdyn_AddressName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Address Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addressname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_Agreement"></a> msdyn_Agreement

|Property|Value|
|---|---|
|Description|**Shows the agreement linked to this work order.**|
|DisplayName|**Agreement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreement|

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

### <a name="BKMK_msdyn_BookingSummary"></a> msdyn_BookingSummary

|Property|Value|
|---|---|
|Description|**This column is used internally, and also used to display the bookable resource bookings associated with a work order in the FieldService.WorkOrderList PCF component.**|
|DisplayName|**Booked Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingsummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10000|

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
|MinValue|1|

### <a name="BKMK_msdyn_City"></a> msdyn_City

|Property|Value|
|---|---|
|Description||
|DisplayName|**City**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_city`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_ClosedBy"></a> msdyn_ClosedBy

|Property|Value|
|---|---|
|Description|**The user that last closed this work order**|
|DisplayName|**Closed By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_closedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_completedon"></a> msdyn_completedon

|Property|Value|
|---|---|
|Description|**When Bookings are used on a Work Order, this field is auto-populated based on the latest End Time from the related Bookings. Otherwise, this field is populated based on the change of System Status.**|
|DisplayName|**Completed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_completedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_CostNTEPercent"></a> msdyn_CostNTEPercent

|Property|Value|
|---|---|
|Description|**Indicates the percentage proximity or overage of the work order cost based on applied Cost not-to-exceed (rounded up to the nearest whole number).**|
|DisplayName|**Cost not-to-exceed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_costntepercent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Country"></a> msdyn_Country

|Property|Value|
|---|---|
|Description||
|DisplayName|**Country/Region**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_country`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|80|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**Customer Asset related to this incident reported**|
|DisplayName|**Primary Incident Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_DateWindowEnd"></a> msdyn_DateWindowEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_DateWindowStart"></a> msdyn_DateWindowStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Date Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimateSubtotalAmount"></a> msdyn_EstimateSubtotalAmount

|Property|Value|
|---|---|
|Description|**Enter the summary of total estimated billing amount for this work order**|
|DisplayName|**Estimate Subtotal Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatesubtotalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_firstarrivedon"></a> msdyn_firstarrivedon

|Property|Value|
|---|---|
|Description|**When Bookings are used on a Work Order, this field is auto-populated based on the earliest Actual Arrival Time from the related Bookings.**|
|DisplayName|**First Arrived On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_firstarrivedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_FollowUpNote"></a> msdyn_FollowUpNote

|Property|Value|
|---|---|
|Description|**Indicate the details of the follow up work**|
|DisplayName|**Follow Up Note (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_followupnote`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_FollowUpRequired"></a> msdyn_FollowUpRequired

|Property|Value|
|---|---|
|Description|**Allows indication if follow up work is required for a work order.**|
|DisplayName|**Follow Up Required (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_followuprequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorder_msdyn_followuprequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_FunctionalLocation"></a> msdyn_FunctionalLocation

|Property|Value|
|---|---|
|Description|**Workorder's functional location**|
|DisplayName|**Functional Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_functionallocation`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_functionallocation|

### <a name="BKMK_msdyn_Instructions"></a> msdyn_Instructions

|Property|Value|
|---|---|
|Description|**Shows instructions for booked resources. By default, this information is taken from the work order instructions field on the service account.**|
|DisplayName|**Instructions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_instructions`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_IoTAlert"></a> msdyn_IoTAlert

|Property|Value|
|---|---|
|Description|**The iot alert which initiated this work order.**|
|DisplayName|**IoT Alert**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iotalert`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotalert|

### <a name="BKMK_msdyn_IsFollowUp"></a> msdyn_IsFollowUp

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is FollowUp (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfollowup`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorder_msdyn_isfollowup`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsMobile"></a> msdyn_IsMobile

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Mobile**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ismobile`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorder_msdyn_ismobile`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Work Order Number**|
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

### <a name="BKMK_msdyn_nottoexceedcostamount"></a> msdyn_nottoexceedcostamount

|Property|Value|
|---|---|
|Description|**The value of not-to-exceed cost for the work order in base currency.**|
|DisplayName|**Cost not-to-exceed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nottoexceedcostamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_nottoexceedpriceamount"></a> msdyn_nottoexceedpriceamount

|Property|Value|
|---|---|
|Description|**The value of not-to-exceed price for the work order in base currency.**|
|DisplayName|**Price not-to-exceed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nottoexceedpriceamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_OpportunityId"></a> msdyn_OpportunityId

|Property|Value|
|---|---|
|Description|**Unique identifier for Opportunity associated with Work Order.**|
|DisplayName|**Opportunity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_opportunityid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|opportunity|

### <a name="BKMK_msdyn_ParentWorkOrder"></a> msdyn_ParentWorkOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order associated with Work Order.**|
|DisplayName|**Parent Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentworkorder`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_phoneNumber"></a> msdyn_phoneNumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Customer Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phoneNumber`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Phone|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|250|

### <a name="BKMK_msdyn_PostalCode"></a> msdyn_PostalCode

|Property|Value|
|---|---|
|Description||
|DisplayName|**Postal Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postalcode`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20|

### <a name="BKMK_msdyn_PreferredResource"></a> msdyn_PreferredResource

|Property|Value|
|---|---|
|Description|**The customer Preferred Resource to work on this job. Should be taken into consideration while scheduling resources**|
|DisplayName|**Preferred Resource (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Price List that controls pricing for products / services added to this work order. By default the system will use the Price List specified on the account**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_PriceNTEPercent"></a> msdyn_PriceNTEPercent

|Property|Value|
|---|---|
|Description|**Indicates the percentage proximity or overage of the work order price based on applied Price not-to-exceed (rounded up to the nearest whole number).**|
|DisplayName|**Price not-to-exceed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricentepercent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_PrimaryIncidentDescription"></a> msdyn_PrimaryIncidentDescription

|Property|Value|
|---|---|
|Description|**Incident description**|
|DisplayName|**Primary Incident Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryincidentdescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_PrimaryIncidentEstimatedDuration"></a> msdyn_PrimaryIncidentEstimatedDuration

|Property|Value|
|---|---|
|Description|**Shows the time estimated to resolve this incident.**|
|DisplayName|**Primary Incident Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryincidentestimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_PrimaryIncidentType"></a> msdyn_PrimaryIncidentType

|Property|Value|
|---|---|
|Description|**Primary incident type reported**|
|DisplayName|**Primary Incident Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryincidenttype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_incidenttype|

### <a name="BKMK_msdyn_PrimaryResolution"></a> msdyn_PrimaryResolution

|Property|Value|
|---|---|
|Description||
|DisplayName|**Primary Resolution**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primaryresolution`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resolution|

### <a name="BKMK_msdyn_Priority"></a> msdyn_Priority

|Property|Value|
|---|---|
|Description|**Priority of the Work Order. To be taken into consideration while scheduling resources**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_priority|

### <a name="BKMK_msdyn_productsservicescost"></a> msdyn_productsservicescost

|Property|Value|
|---|---|
|Description|**The total actual cost of the products and services**|
|DisplayName|**Total Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productsservicescost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_productsservicescost_Base"></a> msdyn_productsservicescost_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Cost in base currency.**|
|DisplayName|**Total Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productsservicescost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_productsservicesestimatedcost"></a> msdyn_productsservicesestimatedcost

|Property|Value|
|---|---|
|Description|**The total estimated cost of the products and services**|
|DisplayName|**Total Estimated Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productsservicesestimatedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_productsservicesestimatedcost_Base"></a> msdyn_productsservicesestimatedcost_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Estimated Cost in base currency.**|
|DisplayName|**Total Estimated Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productsservicesestimatedcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_ReportedByContact"></a> msdyn_ReportedByContact

|Property|Value|
|---|---|
|Description|**The contact that reported this Work Order**|
|DisplayName|**Reported By Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reportedbycontact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|contact|

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

### <a name="BKMK_msdyn_ServiceRequest"></a> msdyn_ServiceRequest

|Property|Value|
|---|---|
|Description|**Case of which this work order originates from**|
|DisplayName|**Case**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_servicerequest`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|incident|

### <a name="BKMK_msdyn_ServiceTerritory"></a> msdyn_ServiceTerritory

|Property|Value|
|---|---|
|Description|**The service territory this work order relates to. By default this will be set to the Service Territory defined on the service account**|
|DisplayName|**Service Territory**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_serviceterritory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|territory|

### <a name="BKMK_msdyn_StateOrProvince"></a> msdyn_StateOrProvince

|Property|Value|
|---|---|
|Description||
|DisplayName|**State Or Province**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_stateorprovince`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SubStatus"></a> msdyn_SubStatus

|Property|Value|
|---|---|
|Description|**Work Order subsstatus**|
|DisplayName|**Substatus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_substatus`|
|RequiredLevel|Recommended|
|Type|Lookup|
|Targets|msdyn_workordersubstatus|

### <a name="BKMK_msdyn_SubtotalAmount"></a> msdyn_SubtotalAmount

|Property|Value|
|---|---|
|Description|**Enter the summary of subtotal billing amount excluding tax for this work order.**|
|DisplayName|**Subtotal Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtotalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_SupportContact"></a> msdyn_SupportContact

|Property|Value|
|---|---|
|Description|**A support contact can be specified so that the individual working on the work order has someone to contact for assistance.**|
|DisplayName|**Support Contact**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_supportcontact`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

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
|GlobalChoiceName|`msdyn_wosystemstatus`|

#### msdyn_SystemStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Unscheduled**|
|690970001|**Scheduled**|
|690970002|**In Progress**|
|690970003|**Completed**|
|690970004|**Posted**|
|690970005|**Canceled**|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**Shows whether sales tax is to be charged for this work order.**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorder_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TaxCode"></a> msdyn_TaxCode

|Property|Value|
|---|---|
|Description|**Tax Code to be used to calculate tax when Work Order is taxable. By default the system will use the tax code specified on the service account**|
|DisplayName|**Sales Tax Code**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxcode`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_taxcode|

### <a name="BKMK_msdyn_TimeClosed"></a> msdyn_TimeClosed

|Property|Value|
|---|---|
|Description|**Enter the time this work order was last closed.**|
|DisplayName|**Closed On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeclosed`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeFromPromised"></a> msdyn_TimeFromPromised

|Property|Value|
|---|---|
|Description|**Enter the starting range of the time promised to the account that incidents will be resolved.**|
|DisplayName|**Time From Promised**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timefrompromised`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeGroup"></a> msdyn_TimeGroup

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fulfillment Preference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timegroup`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_timegroup|

### <a name="BKMK_msdyn_TimeGroupDetailSelected"></a> msdyn_TimeGroupDetailSelected

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Group Detail Selected (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timegroupdetailselected`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_timegroupdetail|

### <a name="BKMK_msdyn_TimeToPromised"></a> msdyn_TimeToPromised

|Property|Value|
|---|---|
|Description|**Enter the ending range of the time promised to the account that incidents will be resolved.**|
|DisplayName|**Time To Promised**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timetopromised`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeWindowEnd"></a> msdyn_TimeWindowEnd

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TimeWindowStart"></a> msdyn_TimeWindowStart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Time Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|---|---|
|Description|**Enter the summary of total billing amount for this work order.**|
|DisplayName|**Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalestimatedaftertaxprice"></a> msdyn_totalestimatedaftertaxprice

|Property|Value|
|---|---|
|Description|**The estimated price after adding tax to the subtotal**|
|DisplayName|**Total Estimated After Tax Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalestimatedaftertaxprice`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|900000000000000|
|MinValue|0|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalestimatedaftertaxprice_Base"></a> msdyn_totalestimatedaftertaxprice_Base

|Property|Value|
|---|---|
|Description|**Value of the Total Estimated After Tax Price in base currency.**|
|DisplayName|**Total Estimated After Tax Price (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalestimatedaftertaxprice_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|0|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalestimatedduration"></a> msdyn_totalestimatedduration

|Property|Value|
|---|---|
|Description|**Calculated from the estimated duration of Work Order Incidents and Work Order Service Tasks not related to a Work Order Incident on the Work Order. Intended to be read-only.**|
|DisplayName|**Total Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalestimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_TotalSalesTax"></a> msdyn_TotalSalesTax

|Property|Value|
|---|---|
|Description|**Enter the summary of total sales tax charged for this work order.**|
|DisplayName|**Total Sales Tax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalsalestax`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_Trade"></a> msdyn_Trade

|Property|Value|
|---|---|
|Description|**Select the Trade that associated with the Work Order.**|
|DisplayName|**Trade**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_trade`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_trade|

### <a name="BKMK_msdyn_workhourtemplate"></a> msdyn_workhourtemplate

|Property|Value|
|---|---|
|Description|**The working hours for a requirement.**|
|DisplayName|**Work Hour Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workhourtemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workhourtemplate|

### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_worklocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_worklocation`|

#### msdyn_WorkLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Onsite**|
|690970001|**Facility**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_workorderarrivaltimekpiid"></a> msdyn_workorderarrivaltimekpiid

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Work Order Arrival Time KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderarrivaltimekpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slakpiinstance|

### <a name="BKMK_msdyn_workorderId"></a> msdyn_workorderId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**WO Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_workorderresolutionkpiid"></a> msdyn_workorderresolutionkpiid

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Work Order Resolution KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderresolutionkpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|slakpiinstance|

### <a name="BKMK_msdyn_WorkOrderSummary"></a> msdyn_WorkOrderSummary

|Property|Value|
|---|---|
|Description|**Type a summary description of the job.**|
|DisplayName|**Work Order Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordersummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_WorkOrderType"></a> msdyn_WorkOrderType

|Property|Value|
|---|---|
|Description|**Work Order Type**|
|DisplayName|**Work Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordertype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workordertype|

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
|Description|**Shows the ID of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Shows the ID of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Work Order**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorder_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorder_statuscode`|

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

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**Shows a comma-separated list of string values representing the unique identifiers of stages in a business process flow instance in the order that they occur.**|
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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_DisplayAddress](#BKMK_msdyn_DisplayAddress)
- [msdyn_estimatesubtotalamount_Base](#BKMK_msdyn_estimatesubtotalamount_Base)
- [msdyn_mapcontrol](#BKMK_msdyn_mapcontrol)
- [msdyn_nottoexceedcostamount_Base](#BKMK_msdyn_nottoexceedcostamount_Base)
- [msdyn_nottoexceedpriceamount_Base](#BKMK_msdyn_nottoexceedpriceamount_Base)
- [msdyn_subtotalamount_Base](#BKMK_msdyn_subtotalamount_Base)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalsalestax_Base](#BKMK_msdyn_totalsalestax_Base)
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

### <a name="BKMK_msdyn_DisplayAddress"></a> msdyn_DisplayAddress

|Property|Value|
|---|---|
|Description|**Combined address field suitable for display**|
|DisplayName|**Display Address**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_displayaddress`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_estimatesubtotalamount_Base"></a> msdyn_estimatesubtotalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate subtotal amount in the base currency.**|
|DisplayName|**Estimate Subtotal Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatesubtotalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_mapcontrol"></a> msdyn_mapcontrol

|Property|Value|
|---|---|
|Description||
|DisplayName|**This field should only be used to load the custom map control**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mapcontrol`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_nottoexceedcostamount_Base"></a> msdyn_nottoexceedcostamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Cost not-to-exceed in base currency.**|
|DisplayName|**Cost not-to-exceed (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nottoexceedcostamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_nottoexceedpriceamount_Base"></a> msdyn_nottoexceedpriceamount_Base

|Property|Value|
|---|---|
|Description|**Value of the Price not-to-exceed in base currency.**|
|DisplayName|**Price not-to-exceed (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nottoexceedpriceamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_subtotalamount_Base"></a> msdyn_subtotalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the subtotal amount in the base currency.**|
|DisplayName|**Subtotal Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtotalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the total amount in the base currency.**|
|DisplayName|**Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalsalestax_Base"></a> msdyn_totalsalestax_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the total sales tax in the base currency.**|
|DisplayName|**Total Sales Tax (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalsalestax_base`|
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

- [msdyn_account_msdyn_workorder_BillingAccount](#BKMK_msdyn_account_msdyn_workorder_BillingAccount)
- [msdyn_account_msdyn_workorder_ServiceAccount](#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)
- [msdyn_bookableresource_msdyn_workorder_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)
- [msdyn_bookableresource_msdyn_workorder_SupportContact](#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)
- [msdyn_contact_msdyn_workorder_ReportedByContact](#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)
- [msdyn_incident_msdyn_workorder_ServiceRequest](#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest)
- [msdyn_msdyn_agreement_msdyn_workorder_Agreement](#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation](#BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation)
- [msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)
- [msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert)
- [msdyn_msdyn_priority_msdyn_workorder_Priority](#BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority)
- [msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution](#BKMK_msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution)
- [msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode)
- [msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected](#BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected)
- [msdyn_msdyn_trade_msdyn_workorder_Trade](#BKMK_msdyn_msdyn_trade_msdyn_workorder_Trade)
- [msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate](#BKMK_msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate)
- [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-many-to-one)
- [msdyn_msdyn_workordersubstatus_msdyn_workorder_Status](#BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status)
- [msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType)
- [msdyn_opportunity_msdyn_workorder](#BKMK_msdyn_opportunity_msdyn_workorder)
- [msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)
- [msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)
- [msdyn_territory_msdyn_workorder_ServiceTerritory](#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)

### <a name="BKMK_msdyn_account_msdyn_workorder_BillingAccount"></a> msdyn_account_msdyn_workorder_BillingAccount

One-To-Many Relationship: [account msdyn_account_msdyn_workorder_BillingAccount](account.md#BKMK_msdyn_account_msdyn_workorder_BillingAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_billingaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_billingaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_workorder_ServiceAccount"></a> msdyn_account_msdyn_workorder_ServiceAccount

One-To-Many Relationship: [account msdyn_account_msdyn_workorder_ServiceAccount](account.md#BKMK_msdyn_account_msdyn_workorder_ServiceAccount)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_serviceaccount`|
|ReferencingEntityNavigationPropertyName|`msdyn_serviceaccount`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource"></a> msdyn_bookableresource_msdyn_workorder_PreferredResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_workorder_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorder_PreferredResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_preferredresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact"></a> msdyn_bookableresource_msdyn_workorder_SupportContact

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_workorder_SupportContact](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_workorder_SupportContact)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_supportcontact`|
|ReferencingEntityNavigationPropertyName|`msdyn_SupportContact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_contact_msdyn_workorder_ReportedByContact"></a> msdyn_contact_msdyn_workorder_ReportedByContact

One-To-Many Relationship: [contact msdyn_contact_msdyn_workorder_ReportedByContact](contact.md#BKMK_msdyn_contact_msdyn_workorder_ReportedByContact)

|Property|Value|
|---|---|
|ReferencedEntity|`contact`|
|ReferencedAttribute|`contactid`|
|ReferencingAttribute|`msdyn_reportedbycontact`|
|ReferencingEntityNavigationPropertyName|`msdyn_reportedbycontact`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_incident_msdyn_workorder_ServiceRequest"></a> msdyn_incident_msdyn_workorder_ServiceRequest

One-To-Many Relationship: [incident msdyn_incident_msdyn_workorder_ServiceRequest](incident.md#BKMK_msdyn_incident_msdyn_workorder_ServiceRequest)

|Property|Value|
|---|---|
|ReferencedEntity|`incident`|
|ReferencedAttribute|`incidentid`|
|ReferencingAttribute|`msdyn_servicerequest`|
|ReferencingEntityNavigationPropertyName|`msdyn_servicerequest`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement"></a> msdyn_msdyn_agreement_msdyn_workorder_Agreement

One-To-Many Relationship: [msdyn_agreement msdyn_msdyn_agreement_msdyn_workorder_Agreement](msdyn_agreement.md#BKMK_msdyn_msdyn_agreement_msdyn_workorder_Agreement)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreement`|
|ReferencedAttribute|`msdyn_agreementid`|
|ReferencingAttribute|`msdyn_agreement`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation"></a> msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation

One-To-Many Relationship: [msdyn_functionallocation msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation](msdyn_functionallocation.md#BKMK_msdyn_msdyn_functionallocation_msdyn_workorder_FunctionalLocation)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocation`|
|ReferencedAttribute|`msdyn_functionallocationid`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencingEntityNavigationPropertyName|`msdyn_FunctionalLocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType"></a> msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType

One-To-Many Relationship: [msdyn_incidenttype msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType](msdyn_incidenttype.md#BKMK_msdyn_msdyn_incidenttype_msdyn_workorder_PrimaryIncidentType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_incidenttype`|
|ReferencedAttribute|`msdyn_incidenttypeid`|
|ReferencingAttribute|`msdyn_primaryincidenttype`|
|ReferencingEntityNavigationPropertyName|`msdyn_primaryincidenttype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert"></a> msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert

One-To-Many Relationship: [msdyn_iotalert msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_workorder_IoTAlert)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotalert`|
|ReferencedAttribute|`msdyn_iotalertid`|
|ReferencingAttribute|`msdyn_iotalert`|
|ReferencingEntityNavigationPropertyName|`msdyn_IoTAlert`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority"></a> msdyn_msdyn_priority_msdyn_workorder_Priority

One-To-Many Relationship: [msdyn_priority msdyn_msdyn_priority_msdyn_workorder_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_workorder_Priority)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`msdyn_priority`|
|ReferencingEntityNavigationPropertyName|`msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution"></a> msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution

One-To-Many Relationship: [msdyn_resolution msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution](msdyn_resolution.md#BKMK_msdyn_msdyn_resolution_msdyn_workorder_PrimaryResolution)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resolution`|
|ReferencedAttribute|`msdyn_resolutionid`|
|ReferencingAttribute|`msdyn_primaryresolution`|
|ReferencingEntityNavigationPropertyName|`msdyn_PrimaryResolution`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode"></a> msdyn_msdyn_taxcode_msdyn_workorder_TaxCode

One-To-Many Relationship: [msdyn_taxcode msdyn_msdyn_taxcode_msdyn_workorder_TaxCode](msdyn_taxcode.md#BKMK_msdyn_msdyn_taxcode_msdyn_workorder_TaxCode)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_taxcode`|
|ReferencedAttribute|`msdyn_taxcodeid`|
|ReferencingAttribute|`msdyn_taxcode`|
|ReferencingEntityNavigationPropertyName|`msdyn_taxcode`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected"></a> msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected

One-To-Many Relationship: [msdyn_timegroupdetail msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected](msdyn_timegroupdetail.md#BKMK_msdyn_msdyn_timegroupdetail_msdyn_workorder_TimeGroupDetailSelected)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_timegroupdetail`|
|ReferencedAttribute|`msdyn_timegroupdetailid`|
|ReferencingAttribute|`msdyn_timegroupdetailselected`|
|ReferencingEntityNavigationPropertyName|`msdyn_timegroupdetailselected`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_trade_msdyn_workorder_Trade"></a> msdyn_msdyn_trade_msdyn_workorder_Trade

One-To-Many Relationship: [msdyn_trade msdyn_msdyn_trade_msdyn_workorder_Trade](msdyn_trade.md#BKMK_msdyn_msdyn_trade_msdyn_workorder_Trade)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_trade`|
|ReferencedAttribute|`msdyn_tradeid`|
|ReferencingAttribute|`msdyn_trade`|
|ReferencingEntityNavigationPropertyName|`msdyn_Trade`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate"></a> msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate

One-To-Many Relationship: [msdyn_workhourtemplate msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate](msdyn_workhourtemplate.md#BKMK_msdyn_msdyn_workhourtemplate_msdyn_workorder_workhourtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workhourtemplate`|
|ReferencedAttribute|`msdyn_workhourtemplateid`|
|ReferencingAttribute|`msdyn_workhourtemplate`|
|ReferencingEntityNavigationPropertyName|`msdyn_workhourtemplate`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-many-to-one"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_parentworkorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_parentworkorder_msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status"></a> msdyn_msdyn_workordersubstatus_msdyn_workorder_Status

One-To-Many Relationship: [msdyn_workordersubstatus msdyn_msdyn_workordersubstatus_msdyn_workorder_Status](msdyn_workordersubstatus.md#BKMK_msdyn_msdyn_workordersubstatus_msdyn_workorder_Status)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordersubstatus`|
|ReferencedAttribute|`msdyn_workordersubstatusid`|
|ReferencingAttribute|`msdyn_substatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_substatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType

One-To-Many Relationship: [msdyn_workordertype msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_workorder_WorkOrderType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`msdyn_workordertype`|
|ReferencingEntityNavigationPropertyName|`msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_opportunity_msdyn_workorder"></a> msdyn_opportunity_msdyn_workorder

One-To-Many Relationship: [opportunity msdyn_opportunity_msdyn_workorder](opportunity.md#BKMK_msdyn_opportunity_msdyn_workorder)

|Property|Value|
|---|---|
|ReferencedEntity|`opportunity`|
|ReferencedAttribute|`opportunityid`|
|ReferencingAttribute|`msdyn_opportunityid`|
|ReferencingEntityNavigationPropertyName|`msdyn_opportunityid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi"></a> msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi

One-To-Many Relationship: [slakpiinstance msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi](slakpiinstance.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_arrival_timekpi)

|Property|Value|
|---|---|
|ReferencedEntity|`slakpiinstance`|
|ReferencedAttribute|`slakpiinstanceid`|
|ReferencingAttribute|`msdyn_workorderarrivaltimekpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderarrivaltimekpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid"></a> msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid

One-To-Many Relationship: [slakpiinstance msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid](slakpiinstance.md#BKMK_msdyn_slakpiinstance_msdyn_workorder_resolutionkpiid)

|Property|Value|
|---|---|
|ReferencedEntity|`slakpiinstance`|
|ReferencedAttribute|`slakpiinstanceid`|
|ReferencingAttribute|`msdyn_workorderresolutionkpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderresolutionkpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory"></a> msdyn_territory_msdyn_workorder_ServiceTerritory

One-To-Many Relationship: [territory msdyn_territory_msdyn_workorder_ServiceTerritory](territory.md#BKMK_msdyn_territory_msdyn_workorder_ServiceTerritory)

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

- [msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_actual_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_iotalert_Workorder](#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)
- [msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder)
- [msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rma_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-one-to-many)
- [msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)
- [msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)
- [msdyn_workorder_msdyn_bookingalerts](#BKMK_msdyn_workorder_msdyn_bookingalerts)
- [msdyn_workorder_msdyn_workordernte_workorder](#BKMK_msdyn_workorder_msdyn_workordernte_workorder)

### <a name="BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder"></a> msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder

Many-To-One Relationship: [bookableresourcebooking msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder](bookableresourcebooking.md#BKMK_msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresourcebooking`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_actual_WorkOrder

Many-To-One Relationship: [msdyn_actual msdyn_msdyn_workorder_msdyn_actual_WorkOrder](msdyn_actual.md#BKMK_msdyn_msdyn_workorder_msdyn_actual_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_actual`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_actual_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder

Many-To-One Relationship: [msdyn_agreementbookingdate msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingdate`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_agreementbookingdate_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_allocatedtoworkorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_inventoryjournal_AllocatedToWorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder"></a> msdyn_msdyn_workorder_msdyn_iotalert_Workorder

Many-To-One Relationship: [msdyn_iotalert msdyn_msdyn_workorder_msdyn_iotalert_Workorder](msdyn_iotalert.md#BKMK_msdyn_msdyn_workorder_msdyn_iotalert_Workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_iotalert_Workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder

Many-To-One Relationship: [msdyn_purchaseorder msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder](msdyn_purchaseorder.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorder`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_purchaseorder_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder

Many-To-One Relationship: [msdyn_purchaseorderproduct msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder](msdyn_purchaseorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderproduct`|
|ReferencingAttribute|`msdyn_associatetoworkorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_purchaseorderproduct_AssociateToWorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Purchase Order Products<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder"></a> msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder

Many-To-One Relationship: [msdyn_purchaseorderreceiptproduct msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencingAttribute|`msdyn_associatetoworkorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_purchaseorderreceiptproduct_AssociateToWorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder

Many-To-One Relationship: [msdyn_requirementcharacteristic msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder](msdyn_requirementcharacteristic.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementcharacteristic`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_requirementcharacteristic_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Characteristics<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder

Many-To-One Relationship: [msdyn_requirementresourcepreference msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder](msdyn_requirementresourcepreference.md#BKMK_msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_requirementresourcepreference`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Resource Preferences<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder

Many-To-One Relationship: [msdyn_resourcerequirement msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder](msdyn_resourcerequirement.md#BKMK_msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_resourcerequirement`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_resourcerequirement_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Requirements<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rma_WorkOrder

Many-To-One Relationship: [msdyn_rma msdyn_msdyn_workorder_msdyn_rma_WorkOrder](msdyn_rma.md#BKMK_msdyn_msdyn_workorder_msdyn_rma_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rma`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_rma_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Work Order<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtv_WorkOrder

Many-To-One Relationship: [msdyn_rtv msdyn_msdyn_workorder_msdyn_rtv_WorkOrder](msdyn_rtv.md#BKMK_msdyn_msdyn_workorder_msdyn_rtv_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtv`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_rtv_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: RTVs<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder

Many-To-One Relationship: [msdyn_rtvproduct msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_rtvproduct_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder

Many-To-One Relationship: [msdyn_timeentry msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder](msdyn_timeentry.md#BKMK_msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_timeentry`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_timeentry_WorkOrder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-one-to-many"></a> msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_parentworkorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorder_ParentWorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder

Many-To-One Relationship: [msdyn_workorderincident msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorderincident_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

Many-To-One Relationship: [msdyn_workorderproduct msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder

Many-To-One Relationship: [msdyn_workorderresolution msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder](msdyn_workorderresolution.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorderresolution_WorkOrder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder

Many-To-One Relationship: [msdyn_workorderservice msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](msdyn_workorderservice.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder

Many-To-One Relationship: [msdyn_workorderservicetask msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorder_msdyn_workorderservicetask_WorkOrder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Service Tasks<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorder_msdyn_bookingalerts"></a> msdyn_workorder_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workorder_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorder_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorder_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorder_msdyn_workordernte_workorder"></a> msdyn_workorder_msdyn_workordernte_workorder

Many-To-One Relationship: [msdyn_workordernte msdyn_workorder_msdyn_workordernte_workorder](msdyn_workordernte.md#BKMK_msdyn_workorder_msdyn_workordernte_workorder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workordernte`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorder_msdyn_workordernte_workorder`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_msdyn_workorder_knowledgearticle"></a> msdyn_msdyn_workorder_knowledgearticle

See [knowledgearticle msdyn_msdyn_workorder_knowledgearticle Many-To-Many Relationship](knowledgearticle.md#BKMK_msdyn_msdyn_workorder_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_workorder_knowledgearticle`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_workorder_knowledgearticle`|
|IntersectAttribute|`msdyn_workorderid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

