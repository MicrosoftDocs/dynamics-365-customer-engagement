---
title: "Contract entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about contract entity that is used to track customer service agreements. You can create contracts for existing customers that specify the type of service and terms that apply to each customer."
ms.custom: 
ms.date: 02/05/2021
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - contract status options, contract entities
  - status options, contract entities
  - contract entities, contract templates
  - contract entities, rules for using
  - contract entity, definition
  - contract templates, contract entities
  - contract entities, tracking customer services agreements
  - contract entities, status options
  - contract entities, introduction
  - tracking customer services agreements, contract entities
ms.assetid: 631e9570-86e5-490e-98dd-ee27925ea8e8
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer

---
# Contract entities

In the Dynamics 365 Customer Engagement (on-premises) platform, a *contract* is an agreement to provide support during specified coverage dates or for a specified number of cases or length of time. When customers contact customer service, the level of support they receive is determined by their contract.

> [!IMPORTANT]
> The Contract, Contract Line, and Contract Template entities are deprecated and and will not be supported from April 1, 2022. They will be removed in a future major release of Dynamics 365. This functionality has been replaced by [entitlements](../../../customer-service/create-entitlement-define-support-terms-customer.md) in Unified Interface. We recommend that you migrate your contracts to entitlements at the earliest to avoid any loss in functionality. For information on the migration strategy, see [Strategy for migrating from contracts to entitlements](../../../customer-service/contract-to-entitlement-migration.md).
  
 The contract entity is used to track customer service agreements. You can create contracts for existing customers that specify the type of service and terms that apply to each customer. New contracts are created based on the contract template. You can create contracts only for existing accounts and contacts.  
  
 A contract has the status of “Draft” until it is invoiced. You can change the contract template until the contract status changes. Each new contract is assigned a unique ID that can’t be used for another contract unless it is being renewed. When you renew a contract, it is saved as a draft with an ID that corresponds to the original contract. If a contract with a status of “Invoiced” or “Active” is modified, the amended contract remains associated with the original account.  
  
## In This Section  
 [Contract Entity](entities/contract.md)  
  
 [ContractDetail Entity](entities/contractdetail.md)  
  
 [Sample: Manage Contracts](sample-manage-contracts.md)  
  
## Related Sections  
 [Service entities (contract, incident, knowledge base)](service-entities.md)  
  
 [Incident (case) entities](incident-case-entities.md)  
  
 [Knowledge base entities](knowledge-management-entities.md)
