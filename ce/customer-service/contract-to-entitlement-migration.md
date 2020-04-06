---
title: Contract to Entitlement Migration | Microsoft Docs
description: Learn more about contract to entitlement migration for Dynamics 365 Customer Service.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 04/03/2020
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

1. Mapping: Contract template to entitlement template
2. Mapping: Contract to entitlements:<BR>
  A. Single Product Contract<BR>
  B. Contract and Entitlement Cancellation<BR>
  C. Billing unit on contract<BR>
  D. Commands on Contract<BR>
  E. State mapping

### Mapping: Contract template to entitlement template
If you are currently using the Contract templates, use the following steps to map to the Entitlement template.

### Allocation Type
 Allocation type to ‘Coverage Dates’ on contract template is used to allow any number of cases to be created between start date and end date of contracts. To switch from the Contract template and map to the Entitlement template:

**STEP 1:**  Select **allocation type** <BR>
**STEP 2:** Set **Restriction based on entitlement terms** to **No**

**Benefits with entitlement:**
- Created cases will now display warning notices when they exceed allocated terms.
- Customer usage can be monitored with the option to set and apply restrictions in future.

### Custom Fields
Fields which are required for business use case, but not available out of box on entitlement or for other required fields not available on entitlements.

To switch from the Contract template and map to the Entitlement template:<BR>
**STEP 1:** Custom fields with attributes can be created on Entitlement template<BR>
**STEP 2:** Place the created fields on the form as per business needs

>[!Note] 
>The Calendar item has been deprecated on the Contract template and will not be available on the Entitlement template.

## Mapping: Contract to entitlements
If you are currently using Contract you can map to Entitlements via the steps provided below.

1.	Create a separate entitlement for each contract line.
2.	Create custom attributes on entitlement for missing contract lines attributes.
3.	Once entitlement is created from entitlement template, add Custom code to copy the custom fields added on entitlement for parity with contract lines.

### A. Single Product Contract<BR>
  If you have a contract tied to a single product, use the following steps:
 1. Create entitlement
 2. Add only one product in Product grid

![Single Product Contract](media\single-product-contract.png)

> [!Note]
> The concept of the Contract group contract lines Contract has been deprecated and are not available on Entitlement. Entitlement does not provide concept grouping.

### B. Contract and Entitlement Cancellation<BR>
Canceling a Contract or Entitlement can be canceled using the following steps:

**Cancel Contract**<BR>
Contracts can be canceled immediately or in the future by:
1.	Selecting a date
2.	Clicking cancel

![Contract and Entitlement Cancellation](media\contract-and-entitlement-cancellation.png)

**Cancel Entitlement**<BR>
Entitlement can be canceled immediately, but can not be canceled in future.

![Cancel Entitlement](media\cancel-entitlement.png)

### C. Billing unit on contract<BR>
Billing unit is not available in entitlement. To achieve this in entitlement use custom logic.
For simple rollups one can use rollup fields. [More details on rollup fields](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/define-rollup-fields).

### D. Commands on Contract <BR>
Below list of commands deprecated on entitlement:
1. Copy Contract – this command is used to clone the contract 
2. Recalculate – this command is used to recalculate the billing rollup
3. Onhold – to hold the contract
4. Release Hold – to release the holded contract

List of commands available on entitlements:
1. **Renew** to renew the expired entitlement 
2. **Cancel** to cancel the active entitlement

### E. State mapping <BR>
- Invoiced state in contract can be mapped to waiting state in entitlement
- Draft, active, canceled and expired are same for both contract and entitlement
- Onhold state is not available in entitlement

## Runtime impact
1.	Steps to migrate from contract to entitlement <BR>
(Move the contract and contract lines to entitlements).
2.	Run update script to update entitlement on case instead of contracts.

>[!Note] 
> - Contract lines (e.g.: Armhand 100) can be associated to the case with that product (e.g.: ARMhand 150). 
> - Entitlement product(s) should be the same as the product on a case for entitlement to be assigned to case.

### See Also:
- [Important changes (deprecations) coming](https://docs.microsoft.com/en-us/power-platform/important-changes-coming) 























