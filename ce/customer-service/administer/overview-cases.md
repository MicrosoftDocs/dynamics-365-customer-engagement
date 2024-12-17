---
title: Overview of case management
description: This topic provides information on how to manage cases in Dynamics 365 Customer Service apps.
ms.date: 12/21/2023
ms.topic: overview
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
searchScope: 
  - D365-App-customerservicehub
  - D365-Entity-incident
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Customer Service
---

# Overview of case management

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Case management is the core record that tracks individual customer service issues across channels and customer service representatives (service representatives or representatives) over time. Customers want to have a long and happy relationship with brands over time, and throughout that relationship they may have several support inquiries through more than one support channel. To achieve this goal, Dynamics 365 Customer Service provides enhanced case configuration and improved case analytics for supervisors.

A case typically represents a situation or incident that's reported by a customer and requires a resolution. Cases are designed to track the process from the initial intake of an incident, through the remediation process, to the final resolution. Dynamics 365 Customer Service has several components that work together to provide an end-to-end case management solution that not only helps identify cases but also routes each case to the most appropriate representative who can provide guidance and resolve the case. Here are some of the most commonly used components:

* **Cases:** A case represents a single incident of service. In other words, it represents anything, in the context of a customer interaction, that requires some type of resolution or answer. Multiple cases can be associated with a single customer at any time.

* **Activities:** An activity typically represents an interaction with a customer, like a phone call. Multiple activities can be associated with a single case.

* **Entitlements:** Entitlements specify the amount of support services that a customer is entitled to. Think of them as support contracts.

* **Knowledge articles:** The knowledge base is a repository of informational articles that help representatives resolve cases.

* **Queues:** A queue is a place to organize and store activities and cases that are waiting to be processed.

* **Copilot generated case summaries**: Copilot case summaries help representatives to quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

* **Service-level agreements (SLAs):** SLAs are a way to track and define what should happen when a case is opened, like how long it should take to respond to a customer.

* **Record creation and update rules:** Record creation and update rules can be applied to different activity types to automatically create Dynamics 365 records.

* **Routing rules:** Routing rules are applied to cases to automatically route them to a specific queue or user.

* **Business process flows:** A business process flow represents a guided process that has different stages and steps that are used to resolve a specific item, like a case.

As your organization tracks metrics on the types of cases that come in, you can create queues, routing rules, and flows to triage cases in the most efficient way.

### Related information

[Set up record routing](set-up-record-routing.md)  
[Create cases](../use/customer-service-hub-user-guide-create-a-case.md)  
[Automatically create or update records](automatically-create-update-records.md)  
