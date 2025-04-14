---
title: "Account table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Account table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Account table/entity reference (Microsoft Dynamics 365)

Business that represents a customer or potential customer. The company that is billed in business transactions.

> [!NOTE]
> The Microsoft Dynamics 365 Account table extends the [Microsoft Dataverse Account table](/power-apps/developer/data-platform/reference/entities/account).



## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DefaultPriceLevelId](#BKMK_DefaultPriceLevelId)
- [msdyn_accountkpiid](#BKMK_msdyn_accountkpiid)
- [msdyn_gdproptout](#BKMK_msdyn_gdproptout)
- [msdyn_PrimaryTimeZone](#BKMK_msdyn_PrimaryTimeZone)
- [msdyn_salesaccelerationinsightid](#BKMK_msdyn_salesaccelerationinsightid)
- [OriginatingLeadId](#BKMK_OriginatingLeadId)
- [PreferredEquipmentId](#BKMK_PreferredEquipmentId)
- [PreferredServiceId](#BKMK_PreferredServiceId)
- [TeamsFollowed](#BKMK_TeamsFollowed)
- [TerritoryId](#BKMK_TerritoryId)

### <a name="BKMK_DefaultPriceLevelId"></a> DefaultPriceLevelId

|Property|Value|
|---|---|
|Description|**Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`defaultpricelevelid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_accountkpiid"></a> msdyn_accountkpiid

|Property|Value|
|---|---|
|Description||
|DisplayName|**KPI**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_accountkpiid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_accountkpiitem|

### <a name="BKMK_msdyn_gdproptout"></a> msdyn_gdproptout

|Property|Value|
|---|---|
|Description|**Describes whether account is opted out or not**|
|DisplayName|**GDPR Optout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gdproptout`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_account_msdyn_gdproptout`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PrimaryTimeZone"></a> msdyn_PrimaryTimeZone

|Property|Value|
|---|---|
|Description|**Indicates the primary time zone that the client works on.**|
|DisplayName|**Primary Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_primarytimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyn_salesaccelerationinsightid"></a> msdyn_salesaccelerationinsightid

|Property|Value|
|---|---|
|Description|**Sales Acceleration Insights ID**|
|DisplayName|**Sales Acceleration Insights ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_salesaccelerationinsightid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_salesaccelerationinsight|

### <a name="BKMK_OriginatingLeadId"></a> OriginatingLeadId

|Property|Value|
|---|---|
|Description|**Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.**|
|DisplayName|**Originating Lead**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`originatingleadid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|lead|

### <a name="BKMK_PreferredEquipmentId"></a> PreferredEquipmentId

|Property|Value|
|---|---|
|Description|**Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.**|
|DisplayName|**Preferred Facility/Equipment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`preferredequipmentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|equipment|

### <a name="BKMK_PreferredServiceId"></a> PreferredServiceId

|Property|Value|
|---|---|
|Description|**Choose the account's preferred service for reference when you schedule service activities.**|
|DisplayName|**Preferred Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`preferredserviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|service|

### <a name="BKMK_TeamsFollowed"></a> TeamsFollowed

|Property|Value|
|---|---|
|Description|**Number of users or conversations followed the record**|
|DisplayName|**TeamsFollowed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`teamsfollowed`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_TerritoryId"></a> TerritoryId

|Property|Value|
|---|---|
|Description|**Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.**|
|DisplayName|**Territory**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`territoryid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|territory|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [OpenDeals](#BKMK_OpenDeals)
- [OpenDeals_Date](#BKMK_OpenDeals_Date)
- [OpenDeals_State](#BKMK_OpenDeals_State)
- [OpenRevenue](#BKMK_OpenRevenue)
- [OpenRevenue_Base](#BKMK_OpenRevenue_Base)
- [OpenRevenue_Date](#BKMK_OpenRevenue_Date)
- [OpenRevenue_State](#BKMK_OpenRevenue_State)

### <a name="BKMK_OpenDeals"></a> OpenDeals

|Property|Value|
|---|---|
|Description|**Number of open opportunities against an account and its child accounts.**|
|DisplayName|**Open Deals**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opendeals`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OpenDeals_Date"></a> OpenDeals_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Open Deals.**|
|DisplayName|**Open Deals (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opendeals_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OpenDeals_State"></a> OpenDeals_State

|Property|Value|
|---|---|
|Description|**State of rollup field Open Deals.**|
|DisplayName|**Open Deals (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`opendeals_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OpenRevenue"></a> OpenRevenue

|Property|Value|
|---|---|
|Description|**Sum of open revenue against an account and its child accounts.**|
|DisplayName|**Open Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`openrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OpenRevenue_Base"></a> OpenRevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the Open Revenue in base currency.**|
|DisplayName|**Open Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`openrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_OpenRevenue_Date"></a> OpenRevenue_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Open Revenue.**|
|DisplayName|**Open Revenue (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`openrevenue_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OpenRevenue_State"></a> OpenRevenue_State

|Property|Value|
|---|---|
|Description|**State of rollup field Open Revenue.**|
|DisplayName|**Open Revenue (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`openrevenue_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [account_originating_lead](#BKMK_account_originating_lead)
- [equipment_accounts](#BKMK_equipment_accounts)
- [msdyn_insightsid_salesaccelerationinsights](#BKMK_msdyn_insightsid_salesaccelerationinsights)
- [msdyn_msdyn_accountkpiitem_account_accountkpiid](#BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid)
- [price_level_accounts](#BKMK_price_level_accounts)
- [service_accounts](#BKMK_service_accounts)
- [territory_accounts](#BKMK_territory_accounts)

### <a name="BKMK_account_originating_lead"></a> account_originating_lead

One-To-Many Relationship: [lead account_originating_lead](lead.md#BKMK_account_originating_lead)

|Property|Value|
|---|---|
|ReferencedEntity|`lead`|
|ReferencedAttribute|`leadid`|
|ReferencingAttribute|`originatingleadid`|
|ReferencingEntityNavigationPropertyName|`originatingleadid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_equipment_accounts"></a> equipment_accounts

One-To-Many Relationship: [equipment equipment_accounts](equipment.md#BKMK_equipment_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`equipment`|
|ReferencedAttribute|`equipmentid`|
|ReferencingAttribute|`preferredequipmentid`|
|ReferencingEntityNavigationPropertyName|`preferredequipmentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_insightsid_salesaccelerationinsights"></a> msdyn_insightsid_salesaccelerationinsights

One-To-Many Relationship: [msdyn_salesaccelerationinsight msdyn_insightsid_salesaccelerationinsights](msdyn_salesaccelerationinsight.md#BKMK_msdyn_insightsid_salesaccelerationinsights)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_salesaccelerationinsight`|
|ReferencedAttribute|`msdyn_salesaccelerationinsightid`|
|ReferencingAttribute|`msdyn_salesaccelerationinsightid`|
|ReferencingEntityNavigationPropertyName|`msdyn_salesaccelerationinsightid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid"></a> msdyn_msdyn_accountkpiitem_account_accountkpiid

One-To-Many Relationship: [msdyn_accountkpiitem msdyn_msdyn_accountkpiitem_account_accountkpiid](msdyn_accountkpiitem.md#BKMK_msdyn_msdyn_accountkpiitem_account_accountkpiid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_accountkpiitem`|
|ReferencedAttribute|`msdyn_accountkpiitemid`|
|ReferencingAttribute|`msdyn_accountkpiid`|
|ReferencingEntityNavigationPropertyName|`msdyn_accountkpiid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_price_level_accounts"></a> price_level_accounts

One-To-Many Relationship: [pricelevel price_level_accounts](pricelevel.md#BKMK_price_level_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`defaultpricelevelid`|
|ReferencingEntityNavigationPropertyName|`defaultpricelevelid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_service_accounts"></a> service_accounts

One-To-Many Relationship: [service service_accounts](service.md#BKMK_service_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`service`|
|ReferencedAttribute|`serviceid`|
|ReferencingAttribute|`preferredserviceid`|
|ReferencingEntityNavigationPropertyName|`preferredserviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_territory_accounts"></a> territory_accounts

One-To-Many Relationship: [territory territory_accounts](territory.md#BKMK_territory_accounts)

|Property|Value|
|---|---|
|ReferencedEntity|`territory`|
|ReferencedAttribute|`territoryid`|
|ReferencingAttribute|`territoryid`|
|ReferencingEntityNavigationPropertyName|`territoryid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [account_bookableresource_AccountId](#BKMK_account_bookableresource_AccountId)
- [account_BulkOperations](#BKMK_account_BulkOperations)
- [account_CampaignResponses](#BKMK_account_CampaignResponses)
- [account_entitlement_Account](#BKMK_account_entitlement_Account)
- [account_entitlement_Customer](#BKMK_account_entitlement_Customer)
- [account_IncidentResolutions](#BKMK_account_IncidentResolutions)
- [account_msdyn_copilottranscripts](#BKMK_account_msdyn_copilottranscripts)
- [account_msdyn_ocliveworkitems](#BKMK_account_msdyn_ocliveworkitems)
- [account_msdyn_ocsessions](#BKMK_account_msdyn_ocsessions)
- [account_msdyn_orgchartnode_msdyn_parentrecord](#BKMK_account_msdyn_orgchartnode_msdyn_parentrecord)
- [account_msfp_alerts](#BKMK_account_msfp_alerts)
- [account_msfp_surveyinvites](#BKMK_account_msfp_surveyinvites)
- [account_msfp_surveyresponses](#BKMK_account_msfp_surveyresponses)
- [account_OpportunityCloses](#BKMK_account_OpportunityCloses)
- [account_OrderCloses](#BKMK_account_OrderCloses)
- [account_Posts](#BKMK_account_Posts)
- [account_QuoteCloses](#BKMK_account_QuoteCloses)
- [Account_ServiceAppointments](#BKMK_Account_ServiceAppointments)
- [contract_billingcustomer_accounts](#BKMK_contract_billingcustomer_accounts)
- [contract_customer_accounts](#BKMK_contract_customer_accounts)
- [contractlineitem_customer_accounts](#BKMK_contractlineitem_customer_accounts)
- [CreatedAccount_BulkOperationLogs2](#BKMK_CreatedAccount_BulkOperationLogs2)
- [incident_customer_accounts](#BKMK_incident_customer_accounts)
- [invoice_customer_accounts](#BKMK_invoice_customer_accounts)
- [lead_customer_accounts](#BKMK_lead_customer_accounts)
- [lead_parent_account](#BKMK_lead_parent_account)
- [msdyn_account_dailyaccountkpiitem_entityid](#BKMK_msdyn_account_dailyaccountkpiitem_entityid)
- [msdyn_account_msdyn_accountkpiitem_accountid](#BKMK_msdyn_account_msdyn_accountkpiitem_accountid)
- [msdyn_account_msdyn_aicontactsuggestion_sourcerecord](#BKMK_msdyn_account_msdyn_aicontactsuggestion_sourcerecord)
- [msdyn_account_msdyn_customerasset_Account](#BKMK_msdyn_account_msdyn_customerasset_Account)
- [msdyn_account_msdyn_iotdevice_Account](#BKMK_msdyn_account_msdyn_iotdevice_Account)
- [msdyn_account_msdyn_mostcontacted_regardingObjectId](#BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId)
- [msdyn_account_msdyn_mostcontactedby_regardingObjectId](#BKMK_msdyn_account_msdyn_mostcontactedby_regardingObjectId)
- [msdyn_account_msdyn_ocliveworkitem_Customer](#BKMK_msdyn_account_msdyn_ocliveworkitem_Customer)
- [msdyn_account_msdyn_salesroutingrun_targetobject](#BKMK_msdyn_account_msdyn_salesroutingrun_targetobject)
- [msdyn_account_msdyn_warranty_WarrantyHolder](#BKMK_msdyn_account_msdyn_warranty_WarrantyHolder)
- [msdyn_account_msdyn_warranty_WarrantyProvider](#BKMK_msdyn_account_msdyn_warranty_WarrantyProvider)
- [msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User)
- [msdyn_msdyn_preferredagent_account_msdyn_recordId](#BKMK_msdyn_msdyn_preferredagent_account_msdyn_recordId)
- [msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid](#BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid)
- [msdyn_sabackupdiagnostic_account_msdyn_target](#BKMK_msdyn_sabackupdiagnostic_account_msdyn_target)
- [msdyn_salesaccelerationinsights_account](#BKMK_msdyn_salesaccelerationinsights_account)
- [msdyn_salesroutingdiagnostic_account_msdyn_target](#BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target)
- [msdyn_salessuggestion_account](#BKMK_msdyn_salessuggestion_account)
- [msdyn_sequencetarget_account_msdyn_target](#BKMK_msdyn_sequencetarget_account_msdyn_target)
- [msdyn_swarm_account](#BKMK_msdyn_swarm_account)
- [opportunity_customer_accounts](#BKMK_opportunity_customer_accounts)
- [opportunity_parent_account](#BKMK_opportunity_parent_account)
- [order_customer_accounts](#BKMK_order_customer_accounts)
- [quote_customer_accounts](#BKMK_quote_customer_accounts)
- [SourceAccount_BulkOperationLogs](#BKMK_SourceAccount_BulkOperationLogs)

### <a name="BKMK_account_bookableresource_AccountId"></a> account_bookableresource_AccountId

Many-To-One Relationship: [bookableresource account_bookableresource_AccountId](bookableresource.md#BKMK_account_bookableresource_AccountId)

|Property|Value|
|---|---|
|ReferencingEntity|`bookableresource`|
|ReferencingAttribute|`accountid`|
|ReferencedEntityNavigationPropertyName|`account_bookableresource_AccountId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_account_BulkOperations"></a> account_BulkOperations

Many-To-One Relationship: [bulkoperation account_BulkOperations](bulkoperation.md#BKMK_account_BulkOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_BulkOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_CampaignResponses"></a> account_CampaignResponses

Many-To-One Relationship: [campaignresponse account_CampaignResponses](campaignresponse.md#BKMK_account_CampaignResponses)

|Property|Value|
|---|---|
|ReferencingEntity|`campaignresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_CampaignResponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_entitlement_Account"></a> account_entitlement_Account

Many-To-One Relationship: [entitlement account_entitlement_Account](entitlement.md#BKMK_account_entitlement_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`accountid`|
|ReferencedEntityNavigationPropertyName|`account_entitlement_Account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_account_entitlement_Customer"></a> account_entitlement_Customer

Many-To-One Relationship: [entitlement account_entitlement_Customer](entitlement.md#BKMK_account_entitlement_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`entitlement`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`account_entitlement_Customer`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `e800e964-32d6-4024-bcea-2df605b0e762`|

### <a name="BKMK_account_IncidentResolutions"></a> account_IncidentResolutions

Many-To-One Relationship: [incidentresolution account_IncidentResolutions](incidentresolution.md#BKMK_account_IncidentResolutions)

|Property|Value|
|---|---|
|ReferencingEntity|`incidentresolution`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_IncidentResolutions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msdyn_copilottranscripts"></a> account_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript account_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_account_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msdyn_ocliveworkitems"></a> account_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem account_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_account_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msdyn_ocsessions"></a> account_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession account_msdyn_ocsessions](msdyn_ocsession.md#BKMK_account_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msdyn_orgchartnode_msdyn_parentrecord"></a> account_msdyn_orgchartnode_msdyn_parentrecord

Many-To-One Relationship: [msdyn_orgchartnode account_msdyn_orgchartnode_msdyn_parentrecord](msdyn_orgchartnode.md#BKMK_account_msdyn_orgchartnode_msdyn_parentrecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_orgchartnode`|
|ReferencingAttribute|`msdyn_parentrecord`|
|ReferencedEntityNavigationPropertyName|`new_account_msdyn_orgchartnodeupdated_msdyn_parentrecordupdated`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: Unique indentifier for the parent entity record<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_account_msfp_alerts"></a> account_msfp_alerts

Many-To-One Relationship: [msfp_alert account_msfp_alerts](msfp_alert.md#BKMK_account_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msfp_surveyinvites"></a> account_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite account_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_account_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_msfp_surveyresponses"></a> account_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse account_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_account_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_OpportunityCloses"></a> account_OpportunityCloses

Many-To-One Relationship: [opportunityclose account_OpportunityCloses](opportunityclose.md#BKMK_account_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_OrderCloses"></a> account_OrderCloses

Many-To-One Relationship: [orderclose account_OrderCloses](orderclose.md#BKMK_account_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_account_Posts"></a> account_Posts

Many-To-One Relationship: [post account_Posts](post.md#BKMK_account_Posts)

|Property|Value|
|---|---|
|ReferencingEntity|`post`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_Posts`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_account_QuoteCloses"></a> account_QuoteCloses

Many-To-One Relationship: [quoteclose account_QuoteCloses](quoteclose.md#BKMK_account_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`account_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_Account_ServiceAppointments"></a> Account_ServiceAppointments

Many-To-One Relationship: [serviceappointment Account_ServiceAppointments](serviceappointment.md#BKMK_Account_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Account_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `CRMActivity.RollupRelatedByParty`<br />ViewId: `00000000-0000-0000-00aa-000010001903`|

### <a name="BKMK_contract_billingcustomer_accounts"></a> contract_billingcustomer_accounts

Many-To-One Relationship: [contract contract_billingcustomer_accounts](contract.md#BKMK_contract_billingcustomer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`billingcustomerid`|
|ReferencedEntityNavigationPropertyName|`contract_billingcustomer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_contract_customer_accounts"></a> contract_customer_accounts

Many-To-One Relationship: [contract contract_customer_accounts](contract.md#BKMK_contract_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`contract_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMContract.RollupRelatedByObject`<br />ViewId: `59ef9ab3-4784-4332-96ca-b4ca2d797929`|

### <a name="BKMK_contractlineitem_customer_accounts"></a> contractlineitem_customer_accounts

Many-To-One Relationship: [contractdetail contractlineitem_customer_accounts](contractdetail.md#BKMK_contractlineitem_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`contractlineitem_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CreatedAccount_BulkOperationLogs2"></a> CreatedAccount_BulkOperationLogs2

Many-To-One Relationship: [bulkoperationlog CreatedAccount_BulkOperationLogs2](bulkoperationlog.md#BKMK_CreatedAccount_BulkOperationLogs2)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`createdobjectid`|
|ReferencedEntityNavigationPropertyName|`CreatedAccount_BulkOperationLogs2`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_incident_customer_accounts"></a> incident_customer_accounts

Many-To-One Relationship: [incident incident_customer_accounts](incident.md#BKMK_incident_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`incident`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`incident_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Service`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMIncident.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010003501`|

### <a name="BKMK_invoice_customer_accounts"></a> invoice_customer_accounts

Many-To-One Relationship: [invoice invoice_customer_accounts](invoice.md#BKMK_invoice_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`invoice`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`invoice_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 40<br />QueryApi: `CRMInvoice.RollupRelatedByObject`<br />ViewId: `a84eb3ff-6dc5-4f57-bbf0-7b664c11fb62`|

### <a name="BKMK_lead_customer_accounts"></a> lead_customer_accounts

Many-To-One Relationship: [lead lead_customer_accounts](lead.md#BKMK_lead_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`lead_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_lead_parent_account"></a> lead_parent_account

Many-To-One Relationship: [lead lead_parent_account](lead.md#BKMK_lead_parent_account)

|Property|Value|
|---|---|
|ReferencingEntity|`lead`|
|ReferencingAttribute|`parentaccountid`|
|ReferencedEntityNavigationPropertyName|`lead_parent_account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `f7ba26ee-3f8e-4cf2-8e02-0b4bbcd16da8`|

### <a name="BKMK_msdyn_account_dailyaccountkpiitem_entityid"></a> msdyn_account_dailyaccountkpiitem_entityid

Many-To-One Relationship: [msdyn_dailyaccountkpiitem msdyn_account_dailyaccountkpiitem_entityid](msdyn_dailyaccountkpiitem.md#BKMK_msdyn_account_dailyaccountkpiitem_entityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_dailyaccountkpiitem`|
|ReferencingAttribute|`msdyn_entityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_dailyaccountkpiitem_entityid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_accountkpiitem_accountid"></a> msdyn_account_msdyn_accountkpiitem_accountid

Many-To-One Relationship: [msdyn_accountkpiitem msdyn_account_msdyn_accountkpiitem_accountid](msdyn_accountkpiitem.md#BKMK_msdyn_account_msdyn_accountkpiitem_accountid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_accountkpiitem`|
|ReferencingAttribute|`msdyn_accountid`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_accountkpiitem_accountid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_aicontactsuggestion_sourcerecord"></a> msdyn_account_msdyn_aicontactsuggestion_sourcerecord

Many-To-One Relationship: [msdyn_aicontactsuggestion msdyn_account_msdyn_aicontactsuggestion_sourcerecord](msdyn_aicontactsuggestion.md#BKMK_msdyn_account_msdyn_aicontactsuggestion_sourcerecord)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_aicontactsuggestion`|
|ReferencingAttribute|`msdyn_sourcerecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_aicontactsuggestion_sourcerecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_customerasset_Account"></a> msdyn_account_msdyn_customerasset_Account

Many-To-One Relationship: [msdyn_customerasset msdyn_account_msdyn_customerasset_Account](msdyn_customerasset.md#BKMK_msdyn_account_msdyn_customerasset_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_customerasset_Account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_iotdevice_Account"></a> msdyn_account_msdyn_iotdevice_Account

Many-To-One Relationship: [msdyn_iotdevice msdyn_account_msdyn_iotdevice_Account](msdyn_iotdevice.md#BKMK_msdyn_account_msdyn_iotdevice_Account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevice`|
|ReferencingAttribute|`msdyn_account`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_iotdevice_Account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId"></a> msdyn_account_msdyn_mostcontacted_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontacted msdyn_account_msdyn_mostcontacted_regardingObjectId](msdyn_mostcontacted.md#BKMK_msdyn_account_msdyn_mostcontacted_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontacted`|
|ReferencingAttribute|`msdyn_account_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_mostcontacted_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_mostcontactedby_regardingObjectId"></a> msdyn_account_msdyn_mostcontactedby_regardingObjectId

Many-To-One Relationship: [msdyn_mostcontactedby msdyn_account_msdyn_mostcontactedby_regardingObjectId](msdyn_mostcontactedby.md#BKMK_msdyn_account_msdyn_mostcontactedby_regardingObjectId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_mostcontactedby`|
|ReferencingAttribute|`msdyn_account_regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_mostcontactedby_regardingObjectId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_ocliveworkitem_Customer"></a> msdyn_account_msdyn_ocliveworkitem_Customer

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_account_msdyn_ocliveworkitem_Customer](msdyn_ocliveworkitem.md#BKMK_msdyn_account_msdyn_ocliveworkitem_Customer)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_customer`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_ocliveworkitem_Customer`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_salesroutingrun_targetobject"></a> msdyn_account_msdyn_salesroutingrun_targetobject

Many-To-One Relationship: [msdyn_salesroutingrun msdyn_account_msdyn_salesroutingrun_targetobject](msdyn_salesroutingrun.md#BKMK_msdyn_account_msdyn_salesroutingrun_targetobject)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingrun`|
|ReferencingAttribute|`msdyn_targetobject`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_salesroutingrun_targetobject`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_warranty_WarrantyHolder"></a> msdyn_account_msdyn_warranty_WarrantyHolder

Many-To-One Relationship: [msdyn_warranty msdyn_account_msdyn_warranty_WarrantyHolder](msdyn_warranty.md#BKMK_msdyn_account_msdyn_warranty_WarrantyHolder)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warranty`|
|ReferencingAttribute|`msdyn_warrantyholder`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_warranty_WarrantyHolder`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Warranty Held<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_account_msdyn_warranty_WarrantyProvider"></a> msdyn_account_msdyn_warranty_WarrantyProvider

Many-To-One Relationship: [msdyn_warranty msdyn_account_msdyn_warranty_WarrantyProvider](msdyn_warranty.md#BKMK_msdyn_account_msdyn_warranty_WarrantyProvider)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_warranty`|
|ReferencingAttribute|`msdyn_warrantyprovider`|
|ReferencedEntityNavigationPropertyName|`msdyn_account_msdyn_warranty_WarrantyProvider`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: Warranties Provided<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User"></a> msdyn_msdyn_conversationparticipantinsights_account_msdyn_User

Many-To-One Relationship: [msdyn_conversationparticipantinsights msdyn_msdyn_conversationparticipantinsights_account_msdyn_User](msdyn_conversationparticipantinsights.md#BKMK_msdyn_msdyn_conversationparticipantinsights_account_msdyn_User)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_conversationparticipantinsights`|
|ReferencingAttribute|`msdyn_user`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_conversationparticipantinsights_account_msdyn_user`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_preferredagent_account_msdyn_recordId"></a> msdyn_msdyn_preferredagent_account_msdyn_recordId

Many-To-One Relationship: [msdyn_preferredagent msdyn_msdyn_preferredagent_account_msdyn_recordId](msdyn_preferredagent.md#BKMK_msdyn_msdyn_preferredagent_account_msdyn_recordId)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_preferredagent`|
|ReferencingAttribute|`msdyn_recordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_preferredagent_account_msdyn_recordId`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid"></a> msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid

Many-To-One Relationship: [msdyn_salescopilotinsight msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid](msdyn_salescopilotinsight.md#BKMK_msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salescopilotinsight`|
|ReferencingAttribute|`msdyn_targetentityid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_salescopilotinsight_account_msdyn_targetentityid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sabackupdiagnostic_account_msdyn_target"></a> msdyn_sabackupdiagnostic_account_msdyn_target

Many-To-One Relationship: [msdyn_sabackupdiagnostic msdyn_sabackupdiagnostic_account_msdyn_target](msdyn_sabackupdiagnostic.md#BKMK_msdyn_sabackupdiagnostic_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sabackupdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sabackupdiagnostic_account_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationinsights_account"></a> msdyn_salesaccelerationinsights_account

Many-To-One Relationship: [msdyn_salesaccelerationinsight msdyn_salesaccelerationinsights_account](msdyn_salesaccelerationinsight.md#BKMK_msdyn_salesaccelerationinsights_account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesaccelerationinsight`|
|ReferencingAttribute|`msdyn_relatedrecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationinsights_account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target"></a> msdyn_salesroutingdiagnostic_account_msdyn_target

Many-To-One Relationship: [msdyn_salesroutingdiagnostic msdyn_salesroutingdiagnostic_account_msdyn_target](msdyn_salesroutingdiagnostic.md#BKMK_msdyn_salesroutingdiagnostic_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salesroutingdiagnostic`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesroutingdiagnostic_account_msdyn_target`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salessuggestion_account"></a> msdyn_salessuggestion_account

Many-To-One Relationship: [msdyn_salessuggestion msdyn_salessuggestion_account](msdyn_salessuggestion.md#BKMK_msdyn_salessuggestion_account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_salessuggestion`|
|ReferencingAttribute|`msdyn_relatedrecord`|
|ReferencedEntityNavigationPropertyName|`msdyn_salessuggestion_account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sequencetarget_account_msdyn_target"></a> msdyn_sequencetarget_account_msdyn_target

Many-To-One Relationship: [msdyn_sequencetarget msdyn_sequencetarget_account_msdyn_target](msdyn_sequencetarget.md#BKMK_msdyn_sequencetarget_account_msdyn_target)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_sequencetarget`|
|ReferencingAttribute|`msdyn_target`|
|ReferencedEntityNavigationPropertyName|`msdyn_sequencetarget_account_msdyn_target`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_swarm_account"></a> msdyn_swarm_account

Many-To-One Relationship: [msdyn_swarm msdyn_swarm_account](msdyn_swarm.md#BKMK_msdyn_swarm_account)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_swarm`|
|ReferencingAttribute|`msdyn_swarmrelatedrecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_swarm_account`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_opportunity_customer_accounts"></a> opportunity_customer_accounts

Many-To-One Relationship: [opportunity opportunity_customer_accounts](opportunity.md#BKMK_opportunity_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`opportunity_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10<br />QueryApi: `CRMOpportunity.RollupRelatedByObject`<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_opportunity_parent_account"></a> opportunity_parent_account

Many-To-One Relationship: [opportunity opportunity_parent_account](opportunity.md#BKMK_opportunity_parent_account)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunity`|
|ReferencingAttribute|`parentaccountid`|
|ReferencedEntityNavigationPropertyName|`opportunity_parent_account`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 1<br />QueryApi: null<br />ViewId: `00000000-0000-0000-00aa-000010001203`|

### <a name="BKMK_order_customer_accounts"></a> order_customer_accounts

Many-To-One Relationship: [salesorder order_customer_accounts](salesorder.md#BKMK_order_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorder`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`order_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 30<br />QueryApi: `CRMSalesOrder.RollupRelatedByObject`<br />ViewId: `71f7da6e-2772-4097-89d1-3670ff8348bb`|

### <a name="BKMK_quote_customer_accounts"></a> quote_customer_accounts

Many-To-One Relationship: [quote quote_customer_accounts](quote.md#BKMK_quote_customer_accounts)

|Property|Value|
|---|---|
|ReferencingEntity|`quote`|
|ReferencingAttribute|`customerid`|
|ReferencedEntityNavigationPropertyName|`quote_customer_accounts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 20<br />QueryApi: `CRMQuote.RollupRelatedByObject`<br />ViewId: `642095db-91dd-4813-bb31-665a3a2bae61`|

### <a name="BKMK_SourceAccount_BulkOperationLogs"></a> SourceAccount_BulkOperationLogs

Many-To-One Relationship: [bulkoperationlog SourceAccount_BulkOperationLogs](bulkoperationlog.md#BKMK_SourceAccount_BulkOperationLogs)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkoperationlog`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`SourceAccount_BulkOperationLogs`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [accountleads_association](#BKMK_accountleads_association)
- [BulkOperation_Accounts](#BKMK_BulkOperation_Accounts)
- [CampaignActivity_Accounts](#BKMK_CampaignActivity_Accounts)
- [listaccount_association](#BKMK_listaccount_association)
- [msdyn_msdyn_functionallocation_account](#BKMK_msdyn_msdyn_functionallocation_account)
- [msdyn_msdyn_warranty_account](#BKMK_msdyn_msdyn_warranty_account)

### <a name="BKMK_accountleads_association"></a> accountleads_association

See [lead accountleads_association Many-To-Many Relationship](lead.md#BKMK_accountleads_association)

|Property|Value|
|---|---|
|IntersectEntityName|`accountleads`|
|IsCustomizable|False|
|SchemaName|`accountleads_association`|
|IntersectAttribute|`leadid`|
|NavigationPropertyName|`accountleads_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_BulkOperation_Accounts"></a> BulkOperation_Accounts

See [bulkoperation BulkOperation_Accounts Many-To-Many Relationship](bulkoperation.md#BKMK_BulkOperation_Accounts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`BulkOperation_Accounts`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`BulkOperation_Logs_Accounts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 11<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_CampaignActivity_Accounts"></a> CampaignActivity_Accounts

See [campaignactivity CampaignActivity_Accounts Many-To-Many Relationship](campaignactivity.md#BKMK_CampaignActivity_Accounts)

|Property|Value|
|---|---|
|IntersectEntityName|`bulkoperationlog`|
|IsCustomizable|False|
|SchemaName|`CampaignActivity_Accounts`|
|IntersectAttribute|`regardingobjectid`|
|NavigationPropertyName|`CampaignActivity_Logs_Accounts`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 11<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_listaccount_association"></a> listaccount_association

See [list listaccount_association Many-To-Many Relationship](list.md#BKMK_listaccount_association)

|Property|Value|
|---|---|
|IntersectEntityName|`listmember`|
|IsCustomizable|False|
|SchemaName|`listaccount_association`|
|IntersectAttribute|`entityid`|
|NavigationPropertyName|`listaccount_association`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: `List.RetrieveListsForMember`<br />ViewId: `bdd93547-53f6-4609-b591-9f48ce86295f`|

### <a name="BKMK_msdyn_msdyn_functionallocation_account"></a> msdyn_msdyn_functionallocation_account

See [msdyn_functionallocation msdyn_msdyn_functionallocation_account Many-To-Many Relationship](msdyn_functionallocation.md#BKMK_msdyn_msdyn_functionallocation_account)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_functionallocation_account`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_functionallocation_account`|
|IntersectAttribute|`accountid`|
|NavigationPropertyName|`msdyn_msdyn_functionallocation_account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warranty_account"></a> msdyn_msdyn_warranty_account

See [msdyn_warranty msdyn_msdyn_warranty_account Many-To-Many Relationship](msdyn_warranty.md#BKMK_msdyn_msdyn_warranty_account)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_warranty_account`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_warranty_account`|
|IntersectAttribute|`accountid`|
|NavigationPropertyName|`msdyn_msdyn_warranty_account`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Covered Accounts<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.account?displayProperty=fullName>
