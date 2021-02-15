---
title: Strategy for migrating from contracts to entitlements migration strategy | Microsoft Docs
description: Learn more about contract to entitlement migration for Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/10/2020
ms.topic: article
ms.service: dynamics-365-customerservice
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

# Strategy for migrating from contracts to entitlements

This document contains information about the settings that admins should manage when migrating contract records to entitlements. This migration support information will help customers prepare for the deprecation of the following:

- Contracts
- Contract line items
- Contract templates

## Plan the migration

The process of migrating contracts to entitlements is as follows:

1. **Contract template to entitlement template mapping:** For records that are based on contract templates, migrate them to the entitlement templates.
2. **Contracts to entitlements:** Migrate the contract lines to entitlements by creating individual entitlements.
3. **Runtime tasks:** Run scripts to perform the migration.

## Mapping: Contract templates to entitlement templates

For feature parity, perform the tasks mentioned in the following sections to map the contract templates to the entitlement templates.

### Allotment type

The allotment type based on coverage dates in the contracts template, which allows to create any number of cases between the start date and end date of a contract, isn't available in the entitlements template. To enable the same functionality, in the entitlement template, set the value for **Restrict based on entitlements terms** to **No**.

A screenshot of the allotment type in the contract template is as follows.


> ![Allotment Type](media/contract-and-entitlement-allocation-type-1.png "Allotment Type")

A screenshot of the entitlement template is as follows.


> ![Entitlement template based on "No restriction"](media/entitlement-template-sample.png  "Entitlement template based on No restriction")

After an entitlement is created from the entitlement template, add custom code to copy the custom fields added on entitlement for parity with contract lines.

> [!Note]
>
> The calendar option in the contracts template is not available in the entitlements template.

**Benefits in entitlement**

- Created cases will now display warning notices when they exceed the allocated terms.
- Customer usage can be monitored with the option to set and apply restrictions in the future.

### Custom fields

Create custom fields in entitlement templates to migrate data from the fields in the contract template that aren't available in the entitlement template. Perform the following steps to switch from the contract template and map to the entitlement template:

1. Create custom fields with attributes on the entitlement template. For more information, see [Create and edit fields (attributes)](/dynamics365/customerengagement/on-premises/customize/create-edit-fields).
2. Place the created fields on the form as per your business needs. For more information, see [Add a field to a form](/dynamics365/customerengagement/on-premises/customize/add-field-form).

## Mapping: Contracts to entitlements

If you're currently using contracts, you can map to entitlements by following these steps:

1. Create a separate entitlement for each contract line.
2. Create custom attributes on the entitlement for missing contract lines attributes.
3. After an entitlement is created from the entitlement template, add custom code to copy the custom fields added on the entitlement for parity with contract lines.

### Things to consider

This section provides information on the functionalities that are different between contracts and entitlements and need to be considered in the migration process.

#### Single product contract

If you've a contract tied to a single product, follow these steps:

1. Create an entitlement.
2. Add only one product in the **PRODUCTS** grid.

> ![Single product contract](media/single-product-contract.png "Single product contract")

> [!Note]
> The concept of grouping contract lines for a contract isn't available in entitlements. You need to create separate entitlements for every contract line.

#### Contract and entitlement cancellation

A contract or entitlement can be canceled using the following steps:

##### Cancel a contract

Contracts can be canceled immediately or in the future by selecting a date.
  
  ![Contract and entitlement cancellation](media/contract-and-entitlement-cancellation.png "Contract and entitlement cancellation")

##### Cancel an entitlement

An entitlement can be canceled only immediately; you can't set a date to cancel it in the future.
  
![Cancel entitlement](media/cancel-entitlement.png "Cancel entitlement")

#### Billing unit in contracts

Billing unit isn't available in entitlements. To achieve this capability in entitlements, use custom logic.

For simple rollups, use rollup fields. For more information, see [rollup fields](/dynamics365/customerengagement/on-premises/customize/define-rollup-fields).

#### Commands in contracts

The following commands have been deprecated in entitlements:

- **Copy Contract:** To clone the contract.
- **Recalculate:** To recalculate the billing rollup.
- **Hold Contract:** To hold the contract.
- **Release Hold:** To release the on-hold contract.

The following commands are available in entitlements:

- **Renew:** To renew the expired entitlement.
- **Cancel:** To cancel the active entitlement.

#### State mapping

- The invoiced state in a contract can be mapped to the waiting state in the entitlement.
- The draft, active, canceled, and expired states are the same for both contracts and entitlements.
- The on-hold state isn't available in entitlements.

## Runtime scripts for migrating contracts

After making sure that all aspects of feature parity for records in contracts are available in entitlements, perform the following steps to migrate from contracts to entitlements:

1. Move the contract and contract lines to entitlements using update scripts or an import tool such as Microsoft Excel.
2. Create and run update scripts to update entitlements on a case instead of contracts.

For business requirements, if a resolved case needs to be updated, perform the following steps:

1. Activate the case.
2. Update the entitlement lookup.
3. Resolve the case.

> [!IMPORTANT]
> In contracts and contract lines, the contract lines can be associated with a product that is different from the one listed in a case. However, in entitlements, the product listed in a case should match the product listed in the entitlement.
>
> **Example**: The contract lines associated with the product Armband 100 can be associated in the case list that is linked to another product, Armband 150. However, in entitlements, an error will occur when you link an entitlement associated with a product, Armband 100, with a case linked to Armband 150.

### See also

[Important changes (deprecations) coming](/power-platform/important-changes-coming)  
[SDK code samples in basic update](/powerapps/developer/common-data-service/org-service/entity-operations-update-delete#basic-update)


[!INCLUDE[footer-include](../includes/footer-banner.md)]