---
title: Contract to Entitlement Migration | Microsoft Docs
description: Learn more about contract to entitlement migration for Dynamics 365 Customer Service.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 04/23/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Contract to Entitlement Migration

Dynamics 365 Customer Service will be completing deprecation of contracts, contract line items, and contract template entities by [4Q20](https://docs.microsoft.com/en-us/power-platform/important-changes-coming#contracts-contract-line-items-and-contract-templates-entities-are-deprecated). These items will be removed and replaced by entitlements and will not be included in future releases.

The following migration support information has been provided to assist customers and prepare for the deprecation of the following:
- contracts
- contracts line items
- contract template entities

## Migration planning
Depending on how your contract is set up, choose from the following options to prepare your migration:

1. [Mapping: Contract template to entitlement template](#1)
2. [Mapping: Contract to entitlements](#2):<BR>
  a. [Single Product Contract](#2a)<BR>
  b. [Contract and Entitlement Cancellation](#2b)<BR>
  c. [Billing unit on contract](#2c)<BR>
  d. [Commands on Contract](#2d)<BR>
  e. [State mapping](#2e)

<a name="1"></a>

### Mapping: Contract template to entitlement template
If you are currently using the Contract templates, use the following steps to map to the Entitlement template.

### Allocation Type
 Allocation type to ‘Coverage Dates’ on contract template is used to allow any number of cases to be created between start date and end date of contracts. To switch from the Contract template and map to the Entitlement template:

**STEP 1:**  Select **allocation type** <BR>

![Allocation Type](
media\contract-and-entitlement-allocation-type-1.png)

**STEP 2:** Set **Restriction based on entitlement terms** to **No**

![Allocation Type](
media\contract-and-entitlement-allocation-type-2.png)

**Benefits with entitlement:**
- Created cases will now display warning notices when they exceed allocated terms.
- Customer usage can be monitored with the option to set and apply restrictions in future.

<a name="2"></a>

## Mapping: Contract to entitlements
If you are currently using Contract you can map to Entitlements via the steps provided below.

1.	Create a separate entitlement for each contract line.
2.	Create custom attributes on entitlement for missing contract lines attributes.
3.	Once entitlement is created from entitlement template, add Custom code to copy the custom fields added on entitlement for parity with contract lines.

<a name="2a"></a>

### 2a. Single Product Contract<BR>
  If you have a contract tied to a single product, use the following steps:
 1. Create entitlement
 2. Add only one product in Product grid

![Single Product Contract](media\single-product-contract.png)

> [!Note]
> The concept of the Contract group contract lines Contract has been deprecated and are not available on Entitlement. Entitlement does not provide concept grouping.

<a name="2b"></a>

### 2b. Contract and Entitlement Cancellation<BR>
Canceling a Contract or Entitlement can be canceled using the following steps:

**Cancel Contract**<BR>
Contracts can be canceled immediately or in the future by:
1.	Selecting a date
2.	Clicking cancel

![Contract and Entitlement Cancellation](media\contract-and-entitlement-cancellation.png)

**Cancel Entitlement**<BR>
Entitlement can be canceled immediately, but can not be canceled in future.

![Cancel Entitlement](media\cancel-entitlement.png)

<a name="2c"></a>

### 2c. Billing unit on contract<BR>
Billing unit is not available in entitlement. To achieve this in entitlement use custom logic.
For simple rollups one can use rollup fields. [More details on rollup fields](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/define-rollup-fields).

<a name="2d"></a>

### 2d. Commands on Contract <BR>
Below list of commands deprecated on entitlement:
1. Copy Contract – this command is used to clone the contract 
2. Recalculate – this command is used to recalculate the billing rollup
3. Onhold – to hold the contract
4. Release Hold – to release the holded contract

List of commands available on entitlements:
- **Renew** to renew the expired entitlement 
- **Cancel** to cancel the active entitlement

<a name="2e"></a>

### 2e. State mapping <BR>
- Invoiced state in contract can be mapped to waiting state in entitlement
- Draft, active, canceled and expired are same for both contract and entitlement
- Onhold state is not available in entitlement

## Runtime impact
Use the following steps to migrate from contract to entitlement:<BR>
**Step 1**: Move the contract and contract lines to entitlements <BR>
**Step 2**: Run update script to update entitlement on case instead of contracts

For business requirement, if resolved case needs to be updated, use the following steps: <BR>
**Step 1**:	Activate the case <BR>
**Step 2**:	Update the entitlement lookup<BR>
**Step 3**:	Resolve the case

>[!Important] 
> 
> Once entitlement is created from entitlement template, add Custom code to copy the custom fields added on entitlement for parity with contract lines.

**Benefits with entitlement:**
- Created cases will now display warning notices when they exceed allocated terms.
- Customer usage can be monitored with the option to set and apply restrictions in future.

### Custom Fields
Fields which are required for business use case, but not available out of box on entitlement or for other required fields not available on entitlements.

To switch from the Contract template and map to the Entitlement template:<BR>
**STEP 1:** Create custom fields with attributes can be created on Entitlement template.  For more information, see [Create and edit fields (attributes)](https://nam06.safelinks.protection.outlook.com/?url=https%3A%2F%2Fdocs.microsoft.com%2Fen-us%2Fdynamics365%2Fcustomerengagement%2Fon-premises%2Fcustomize%2Fcreate-edit-fields&data=02%7C01%7CLeslie.Robbins%40microsoft.com%7C3ced38d114ed4219470508d7e74954d0%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C637232174499616769&sdata=8zKG2iuS%2F5%2B2hiqD7OLwQjlxrTxtaiyB6YYzThNK6zQ%3D&reserved=0).<BR>
**STEP 2:** Place the created fields on the form as per business needs. Use the SDK code examples in the [basic update](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/org-service/entity-operations-update-delete#basic-update) section as a reference guide to update the entity. For more information, see [Add a field to a from](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/add-field-form).


>[!Important] 
> 
> Contract and Contract Lines allowed Contract Lines to be associated to a product different than the one listed in Case. However, Entitlement requires the product listed in Case match the product listed in Entitlement. 
>
> **Example**: Contract lines associated with the product (e.g.: Armhand 100) can be associated in the Case list which is linked to another product (e.g.: ARMhand 150). However with Entitlement, an error will occur when you link an Entitlement associated with a product, 'Armhand 100', with a Case linked to 'Armhand 150'.

### See Also:
- [Important changes (deprecations) coming](https://docs.microsoft.com/en-us/power-platform/important-changes-coming) 























