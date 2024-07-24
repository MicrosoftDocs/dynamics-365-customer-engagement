---
title: "Address (CustomerAddress) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Address (CustomerAddress) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Address (CustomerAddress) table/entity reference

Address and shipping information. Used to store additional addresses for an account or contact.

> [!NOTE]
> The Microsoft Dynamics 365 Field Service Address (CustomerAddress) table extends the [Microsoft Dataverse Address (CustomerAddress) table](/power-apps/developer/data-platform/reference/entities/customeraddress).




## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [customer_address_contract_line_items](#BKMK_customer_address_contract_line_items)
- [customer_address_contracts_as_billing_address](#BKMK_customer_address_contracts_as_billing_address)
- [customer_address_contracts_as_service_address](#BKMK_customer_address_contracts_as_service_address)

### <a name="BKMK_customer_address_contract_line_items"></a> customer_address_contract_line_items

Many-To-One Relationship: [contractdetail customer_address_contract_line_items](contractdetail.md#BKMK_customer_address_contract_line_items)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`serviceaddress`|
|ReferencedEntityNavigationPropertyName|`customer_address_contract_line_items`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_customer_address_contracts_as_billing_address"></a> customer_address_contracts_as_billing_address

Many-To-One Relationship: [contract customer_address_contracts_as_billing_address](contract.md#BKMK_customer_address_contracts_as_billing_address)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`billtoaddress`|
|ReferencedEntityNavigationPropertyName|`customer_address_contracts_as_billing_address`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_customer_address_contracts_as_service_address"></a> customer_address_contracts_as_service_address

Many-To-One Relationship: [contract customer_address_contracts_as_service_address](contract.md#BKMK_customer_address_contracts_as_service_address)

|Property|Value|
|---|---|
|ReferencingEntity|`contract`|
|ReferencingAttribute|`serviceaddress`|
|ReferencedEntityNavigationPropertyName|`customer_address_contracts_as_service_address`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.customeraddress?displayProperty=fullName>
