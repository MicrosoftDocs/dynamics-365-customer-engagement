---
title: Contract to entitlement migration | Microsoft Docs
description: Learn more about contract to entitlement migration for Dynamics 365 Customer Service.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 04/30/2020
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

# Contract to entitlement migration


<!--Is it OK to provide a date instead of just 4Q20? Or is the specific date not known? See my change below. -->

Dynamics 365 Customer Service will complete deprecation of contracts, contract line items, and contract template entities by [June 30, 2020 (4Q20)](/power-platform/important-changes-coming#contracts-contract-line-items-and-contract-templates-entities-are-deprecated). These items will be removed and replaced by entitlements and will not be included in future releases.

Migration support information is provided here to help customers prepare for deprecation of the following:

- Contracts
- Contract line items
- Contract template entities

## Migration planning

Depending on how your contract is set up, choose from the following options to prepare your migration:

- [Mapping: Contract template to Entitlement template](#1)
- [Mapping: Contract to Entitlements](#2):<BR>
  a. [Single Product Contract](#2a)<BR>
  b. [Contract and Entitlement cancellation](#2b)<BR>
  c. [Billing unit on contract](#2c)<BR>
  d. [Commands on Contract](#2d)<BR>
  e. [State mapping](#2e)

<a name="1"></a>

## Mapping: Contract template to Entitlement template

If you're currently using the Contract templates, use the following steps to map to the Entitlement template.

### Allocation Type

Allocation type to "Coverage Dates" on contract templates is used to allow any number of cases to be created between the start date and end date of a contract. To switch from the Contract template and map to the Entitlement template:

- **Step 1:**  Select **Coverage Dates** in **Allocation Type**.

  ![Allocation Type](media/contract-and-entitlement-allocation-type-1.png "Allocation Type")

- **Step 2:** Set **Restrict based on entitlement terms** to **No**.

  ![No restriction](media/contract-and-entitlement-allocation-type-2.png "No restriction")

> [!Important]
> After an entitlement is created from the Entitlement template, add custom code to copy the custom fields added on entitlement for parity with contract lines.

**Benefits with Entitlement:**

- Created cases will now display warning notices when they exceed the allocated terms.
- Customer usage can be monitored with the option to set and apply restrictions in the future.

## Custom fields


<!--The following isn't a complete sentence. Is it a description of "Custom fields"? For example, could you say "Custom fields are required for ...."? Also, when "Entitlement" is capitalized, does it refer to Entitlement templates? I would not capitalize generic entitlements. --> 

Fields that are required for business use case, but not available out of the box on Entitlement or for other required fields not available on Entitlements.

To switch from the Contract template and map to the Entitlement template:

- **Step 1:** Create custom fields with attributes on the Entitlement template.  For more information, see [Create and edit fields (attributes)](/dynamics365/customerengagement/on-premises/customize/create-edit-fields).
- **Step 2:** Place the created fields on the form as per business needs. Use the [basic update](/powerapps/developer/common-data-service/org-service/entity-operations-update-delete#basic-update) SDK code examples as a reference guide to update the entity. For more information, see [Add a field to a form](/dynamics365/customerengagement/on-premises/customize/add-field-form).

<a name="2"></a>

## Mapping: Contract to Entitlements

If you're currently using Contract, you can map to Entitlements by using the following steps:

- **Step 1:**	Create a separate Entitlement for each contract line.
- **Step 2:**	Create custom attributes on Entitlement for missing contract lines attributes.
- **Step 3:**	After an entitlement is created from the Entitlement template, add custom code to copy the custom fields added on the Entitlement for parity with contract lines.

<a name="2a"></a>

### 2a. Single product contract

If you have a contract tied to a single product, use the following steps:

 - **Step 1:** Create an entitlement.
 - **Step 2:** Add only one product in the **PRODUCTS** grid.


<!--Please confirm that "Allison Jones" in the following image is from an approved fictitious names list. -->

  ![Single product contract](media/single-product-contract.png "Single product contract")


<!--Just checking - In the following note, is "Contract group contract lines Contract" correct? -->


> [!Note]
> The concept of the Contract group contract lines Contract has been deprecated and is not available on entitlement. Entitlement does not provide concept grouping.

<a name="2b"></a>

### 2b. Contract and entitlement cancellation

A contract or entitlement can be canceled using the following steps:

**Cancel a contract**<BR>
Contracts can be canceled immediately or in the future by:
  
- **Step 1:**	Selecting a date.
- **Step 2:**	Selecting **Confirm**.

  ![Contract and entitlement cancellation](media/contract-and-entitlement-cancellation.png "Contract and entitlement cancellation")

**Cancel an entitlement**<BR>
Entitlement can be canceled immediately, but can't be canceled in the future.
  
![Cancel entitlement](media/cancel-entitlement.png "Cancel entitlement")

<a name="2c"></a>

### 2c. Billing unit on contract

Billing unit is not available in entitlement. To achieve this in entitlement, use custom logic.

For simple rollups, use rollup fields. For more information, see [rollup fields](/dynamics365/customerengagement/on-premises/customize/define-rollup-fields).

<a name="2d"></a>

### 2d. Commands on contract

The following is a list of commands that have been deprecated on entitlement:

- **Copy Contract:** To clone the contract.
- **Recalculate:** To recalculate the billing rollup.
- **Onhold:** To hold the contract.
- **Release Hold:** To release the on-hold contract.

The following is a list of commands available on Entitlements:

- **Renew:** To renew the expired entitlement.
- **Cancel:** To cancel the active entitlement.

<a name="2e"></a>

### 2e. State mapping

- The invoiced state in contract can be mapped to the waiting state in the entitlement.
- The draft, active, canceled, and expired states are the same for both contract and entitlement.
- The onhold state is not available in entitlement.

## Runtime impact

Use the following steps to migrate from contract to entitlement:

- **Step 1:** Move the contract and contract lines to entitlements.
- **Step 2:** Run update script to update entitlement on case instead of contracts.

For business requirement, if a resolved case needs to be updated, use the following steps:

- **Step 1:** Activate the case.
- **Step 2:** Update the entitlement lookup.
- **Step 3:** Resolve the case.

> [!IMPORTANT]
> Contract and contract lines allowed contract lines to be associated to a product that is different from the one listed in case. However, an entitlement requires the product listed in case matches the product listed in the entitlement.
>
> **Example**: Contract lines associated with the product Armband 100 can be associated in the Case list that is linked to another product, Armband 150. However, with Entitlement, an error will occur when you link an Entitlement associated with a product, Armband 100, with a Case linked to Armband 150.

### See also

[Important changes (deprecations) coming](/power-platform/important-changes-coming)
