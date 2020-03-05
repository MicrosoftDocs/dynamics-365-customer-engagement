---
title: Contract to Entitlement Migration Consideration 
description: Visit this page to see what's recently updated or added on Contract to Entitlement Migration Consideration 
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 03/04/2020
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

Dynamics 365 Customer Service will be completing debrecation of contracts, contract line items, and contract template entities by the October 2020 release.  These items will be removed and replaced by entitlements, and will not be included in future  releases.

The following migration support information has been provided to assist customers and prepare for the deprecation of the following:   
  - contracts
  - contracts line items
  - contract template entities

## Prerequisites

<Question: Are there any customer system prerequisites?>

## Migration planning 

Depending on how your contract is set up, choose from the following options to prepare your migration:
  
  A. Mapping: Contract template to entitlement template <BR>
  B. Mapping: Contract to entitlements<BR> 
    - Single Product Contract<BR>
  C. Contract and Entitlement Cancellation 

### A. Mapping: Contract template to entitlement template 

If you are currently using the Contract templates, use the following steps to map to the Entitlement template. 

> [!NOTE:] 
> The Contract template 'allocation type' is equal  to the 'coverage dates' on the Entitlment template, and allows you to create a number of cases between the start-date and end-date of a contract.  

 <need screenshot/graphic to display here>

To switch from the Contract template and map to the Entitlement template: 
  1. Select <b>allocation type</b>
  2. Set <b>Restriction based on entitlement terms</b> to <b> No</b>
  
### Benefits
- Created cases will now display warning notices when they exeed allocated terms and conditions.  
- Customer usage can be monitored with the option to set and apply restrictions.

> [!NOTE:] 
> The following items have beeen deprecated on the Contract template and are not be available on the Entitlment template:
> - Calendar  
> - Required fields. However, custom fields with attributes can be created on Entitlement template. 

### B. Mapping: Contract to entitlements 

If you are currently using Contract you can map to Entitlements via the steps provided below.

<need screenshot/graphic to display here>

1. Create a separate entitlement for each contract line.
2. Create custom attributes on entitlement for missing contract lines attributes. 

### Single Product Contract

If you have a contract tied to a single product, use the following steps:

<need screenshot/graphic to display here>

1. Create entitlement and add only one product in Product grid. 
2. Once entitlement is created from entitlement template, add Custom code to copy the custom fields added on entitlement for parity with contract lines.

<Provide sdk sample code reference (Arvind)> 

> [!NOTE:]
> The following Contract items have been deprecated and are not available on Entitlement: 
> - Contracts groups contract lines. (Entitlement does not provide concept grouping).  

### Contract and Entitlement Cancellation 

Canceling a Contract or Entitlement can be cancled using the following steps:

#### Cancel Contract

Contracts can be cancelled immediately or in the future by: 

<need screenshot/graphic to display here>

1. Selecting a <b>date</b> 
2. Clicking <b>cancel</b> 

#### Cancel Entitlment 

Entitlement can be cancelled immediately, but can not be cancelled in future. 

## State Mapping 
|Contract  |Contract lines   |Entitlements |
|----------|-----------------|-------------|
|Draft     |Existing/Renewed |Draft        |
|Invoiced  |Existing/Renewed |Waiting      |
|Active    |Existing/Renewed |Active       |
|Onhold <BR>(invoiced and active) |  |NOTE: How this is used runtime?<BR> <li>Cannot add contract lines - This should not be critical.</li><li> Runtime is taken care:<BR>While case is created, Lookup (active) - can be taken care in entitlement</li> |
|Canceled  |Canceled         |Canceled     |
|Expired   |Expired          |Expired      |

## Command on Contract 
|Copy           |Nothing OOB for this <BR> If this feature is required on entitlement please reach out to us via ideas |
|---------------|---------------------------|
|Recalculate    |This is related to Billing unit. Not available with entitlement|
|Invoiced       |Driven by status |
|Onhold<BR>Release Hold (goes back to active or invoiced) | Not available OOB, can they built it custom.   |
|Renew    |   |
|Cancel   |   | 

## Billing unit 

what is the 'Billing unit'?  Need content to support this section. 

<need screenshot/graphic to display here>

<waiting on content (Arvind)> 

## API calls mapping 

How do we support API call mapping?  Need content and information to support this section. 

<need screenshot/graphic to display here>

<waiting on content (Deepa)> 

## Runtime impact 

What is runtime impact?  Need more content and information to support this section.

<need screenshot/graphic to display here>

1. Move the contract and contract lines to entitlements 
2. Run update script to update entitlement on case instead of contracts  
  - New records use entitlement 
  - Check via SDK – Deepa to validate this 
    - Number of terms will be impacted. 
    - Check via grid if bulk edit works  

## See Also
- 

