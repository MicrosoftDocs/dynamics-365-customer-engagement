---
title: "Overview of case management | MicrosoftDocs"
description: "This topic provides information on how to manage cases in Dynamics 365 Customer Service apps."
author: platkat
ms.author: ktaylor
manager: shujoshi
---

# Overview of case management 

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

A case typically represents a situation or incident that's reported by a customer and requires a resolution. Cases are designed to track the process from the initial intake of an incident, through the remediation process, to the final resolution. Dynamics 365 Customer Service has several components that work together to provide an end-to-end case management solution that not only helps identify cases but also routes each case to the most appropriate agent who can provide guidance and resolve the case. Here are some of the most commonly used components:

* **Cases:** A case represents a single incident of service. In other words, it represents anything, in the context of a customer interaction, that requires some type of resolution or answer. Multiple cases can be associated with a single customer at any time.

* **Activities:** An activity typically represents an interaction with a customer, like a phone call. Multiple activities can be associated with a single case.

* **Entitlements:** Entitlements specify the amount of support services that a customer is entitled to. Think of them as support contracts.

* **Knowledge articles:** The knowledge base is a repository of informational articles that help customer service representatives resolve cases.

* **Queues:** A queue is a place to organize and store activities and cases that are waiting to be processed.

* **Service level agreements (SLAs):** SLAs are a way to track and define what should happen when a case is opened, like how long it should take to respond to a customer.

* **Record creation and update rules:** Record creation and update rules can be applied to different activity types to automatically create Dynamics 365 records.

* **Routing rules:** Routing rules are applied to cases to automatically route them to a specific queue or user.

* **Business process flows:** A business process flow represents a guided process that has different stages and steps that are used to resolve a specific item, like a case.

As your organization tracks metrics on the types of cases that come in, you can create queues, routing rules, and flows to triage cases in the most efficient way.
