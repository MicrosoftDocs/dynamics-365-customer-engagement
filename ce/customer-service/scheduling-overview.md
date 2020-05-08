---
title: "Customer Service Scheduling - Overview | MicrosoftDocs"
description: "Overview of Service Scheduling options in Dynamics 365 Customer Service."
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 05/08/2020
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
ms.custom: 
  - ""
applies_to: 
  - ""
---

## Upcoming changes to the Service Scheduling experience

As previously announced, the legacy service scheduling experience is currently being deprecated, aligned with the expected Unified Interface transition date of 12/01/2020. More information: [Legacy web client is deprecated](https://docs.microsoft.com/power-platform/important-changes-coming#legacy-web-client-is-deprecated). Because of this change, there are currently two approaches you can take to transition to a new scheduling experience. 

### Option #1: Migrate to the Core Service Scheduling experience

The established approach is to migrate to the Core Service Scheduling experience built on Universal Resource Scheduling (URS). More information: [Service Scheduling Guide](customer-service/basics-service-service-scheduling.md). This option is best if you are a new Customer Service user, have already migrated, or are not otherwise blocked by the absence of the features listed in the [Cons of migrating to the Core Service Scheduling experience](#cons-of-migrating-to-the-core-service-scheduling-experience) section below.

Consider the following pros and cons before deciding to migrate.

#### Pros of migrating to the Core Service Scheduling experience:
- It aligns with the URS long-term strategy
- Scheduling interoperability is available across Customer Service, Field Service, and Project Service Automation applications

#### Cons of migrating to the Core Service Scheduling experience:
- Appointment, Recurring Service Appointment, and Customer preferred selection are not supported
- Schedule boards are not customizable
- There isn't a public extended API for supporting Appointment and Recurring Service Appointment features
- Legacy customer administrators must run the migration tool and install the Core Service Scheduling package before using URS
- You cannot roll back once the migration tool executes.

### Option #2: Wait for the "UCIfied" scheduling experience in August 2020

If you are blocked by the absence of the features outlined above, we are offering an incremental option to wait for a “UCIfied” scheduling experience. “UCIfied” means that the product team will update the existing service scheduling experience for Unified Interface while continuing to use the legacy APIs. The timeline for the UCIfied scheduling experience is 2020 Release Wave 2, with Early Access available in August. Before this date, you would use legacy service scheduling. More information: [.

This option is recommended if you are a legacy service scheduling user who is blocked by absence of certain features in URS, or if you are facing COVID-19-related capacity constraints that hinder your ability to migrate to URS. 

#### Pros of waiting for the UCIfied scheduling experience:

- No feature gaps between the legacy web client experience and United Interface  

- The same scheduling process is in place

- No manual migration is needed to start using the UCIfied experience 

- No action is requires if you have or are currently building a custom UI that calls the legacy scheduling API 

#### Cons of waiting for the UCIfied scheduling experience:

- The URS engine design is different from the legacy scheduling engine. The URS Schedule Board and UCIfied Service Calendar are not interoperable. 

- This option does not align with the long-term product direction, so you would still need to migrate to URS at a later date (this timeline will be determined in 2021). 

### Summary of migration options

The following table summarizes both options: 
