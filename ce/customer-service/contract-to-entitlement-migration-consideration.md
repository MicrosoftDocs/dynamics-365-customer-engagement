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

## Plan your migration 

Depending on how your contract is set up, use one of the following options to prepare for migration:
  
  A. Mapping: Contract template to Entitlement template <BR>
  B. Mapping: Contract to entitlements<BR> 
  C. Entitlement cancellation 

### A. Mapping: Contract template to entitlement template 

  Allocation type equal to 'Coverage Dates', allow n number of cases created between start  date and end date of contract.  

  This can be achieved in entitlement by picking the allocation type and settings 'Restriction based on entitlement terms' to No, this would allow creation of case with warning in case allocated terms have exceeded.  

  Additional advantage monitor the usage, and later can restrict if required. 

  Calendar on contract template is deprecate and not available on entitlement.  

  For any other fields required on contract template and not available on Entitlement template, create custom attributes on entitlement template. 

  B. Mapping: Contract to entitlements 

  Contracts groups contract lines. Entitlement doesn’t have concept of grouping.  

  Create separate entitlement for each contract lines 

  Create custom attributes on entitlement for missing contract lines attributes. 

  Scenario where contract is tied to single product. Create entitlement and add only one product in Product grid. 

  When entitlement is created from entitlement template. Add Custom code to copy the custom fields added on entitlement for parity with contract lines. - provide the sdk reference (Talk to Arvind) 

## Entitlement cancellation 

Contract can be cancelled immediately or in future by setting the future date when clicked on cancel 

Entitlement can be cancelled immediately. Entitlement doesn’t have capability to be cancelled in future. 

### State Mapping 
|Contract  |Contract lines   |Entitlements |
|----------|-----------------|-------------|
|Draft     |Existing/Renewed |Draft        |
|Invoiced  |Existing/Renewed |Waiting      |
|Active    |Existing/Renewed |Active       |
|Onhold <BR>(invoiced and active) |  |NOTE: How this is used runtime?<BR> <li>Cannot add contract lines - This should not be critical.</li><li> Runtime is taken care:<BR>While case is created, Lookup (active) - can be taken care in entitlement</li> |
|Canceled  |Canceled         |Canceled     |
|Expired   |Expired          |Expired      |

### Command on Contract 
|Copy           |Nothing OOB for this <BR> If this feature is required on entitlement please reach out to us via ideas |
|---------------|---------------------------|
|Recalculate    |This is related to Billing unit. Not available with entitlement|
|Invoiced       |Driven by status |
|Onhold<BR>Release Hold (goes back to active or invoiced) | Not available OOB, can they built it custom.   |
|Renew    |   |
|Cancel   |   | 

### Billing unit 
- Wait for data – Arvind is working on this 

### API calls mapping 
- Search in docs – Deepa to work on it 

### Runtime impact 
- Move the contract and contract lines to entitlements 
- Run update script to update entitlement on case instead of contracts  
  - New records use entitlement 
  - Check via SDK – Deepa to validate this 
    - Number of terms will be impacted. 
    - Check via grid if bulk edit works  