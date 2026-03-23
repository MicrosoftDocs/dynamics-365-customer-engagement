---
title: Company alignment and legal entities
ms.reviewer: wesmith
description: Learn how company, legal entities, and accounts are defined in the Dynamics 365 Project Operations integration with Field Service.
ms.date: 01/28/2026
ms.topic: concept-article
author: vhorvathms
ms.author: vhorvath
---

# Company alignment and legal entities

When you work with Field Service and the [Integrated Project Operations with Finance deployment model](project-operations-integration-inventory.md), it's important to understand the concept of company and legal entities.

## Company alignment

Dynamics 365 Field Service and Dynamics 365 Finance don't automatically share the same concept of a company. To ensure operational records users create in Field Service can post financially, dual-write adds a Company field to relevant tables like account, product, and warehouse. Field Service uses this company value to enforce company alignment across work orders and their related transactions.

Field Service requires a **Service Account**. Dual-write adds the **Company** value from Finance to the account record. The service account's company determines the company for the work order and its product, services, and related transactions.

If the service account and the company don't match on a work order and the work order transactional records, transactions don't synchronize until the discrepancy is resolved.

To help users identify and correct issues, Field Service highlights company misalignment in several places:

- On the work order
- On the work order product or work order service
- On the finance and operations transaction

As a best practice, consider:

- Create incident type records with products and services that align with the company.
- Select the incident type that matches the service account's company on the work order.
- Avoid mixing products and services from different companies on the same work order.

Learn more in [Company concept in Dataverse](/dynamics365/fin-ops-core/fin-ops/data-entities/company-data).

## Legal entities and accounts

In Finance, a legal entity represents the company that performs work, owns financial transactions, and posts to the general ledger. It's the financial boundary for how you track, bill, and account for work.

A single legal entity can include many types of accounts, such as:

- Customers
- Vendors
- Suppliers
- Other business partners

These accounts are business records associated with the legal entity. They're not legal entities themselves. Instead, they're the organizations the legal entity does business with.

When these accounts synchronize into Dataverse through Dual-write, they appear in Field Service as **Billing accounts** or **Service accounts**. Field Service uses these accounts to:

- Associate work orders
- Track operational activity
- Generate material usage
- Produce billable actuals
- Send billing information downstream

Field Service doesn't define or manage legal entities. Instead, it transacts against the accounts that belong to a legal entity, using whatever configuration you set up in Finance.

Company alignment in Field Service reflects the financial ownership defined in Finance. Field Service enforces company consistency operationally, while Finance defines company and legal entity ownership financially.

This setup ensures that all work order activity aligns to the correct legal entity for financial posting and reporting.

## Next steps

- [Set up Field Service integration with Project Operations](project-operations-integration-setup.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
