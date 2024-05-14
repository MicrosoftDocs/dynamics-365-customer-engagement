---
title: Overview of admin features in the Resource Scheduling Optimization add-in
description: Learn about key features to administer the Resource Scheduling Optimization add-in.
ms.date: 05/14/2024
ms.subservice: resource-scheduling-optimization
ms.topic: overview
author: AnilMur
ms.author: anilmur
---

# Overview of admin features in the Resource Scheduling Optimization add-in

Learn which administrative features help you maintain Resource Schedule Optimization in your environment.

## Periodic updates

Microsoft releases new versions of Resource Scheduling Optimization periodically. The [version history](./field-service-version-history-resource-scheduling-optimization.md#release-schedule) lists changes and updates. Some releases are rolled out to all stations on a set schedule. However, you can [selectively deploy a release](./rso-deployment.md#manage-the-resource-scheduling-optimization-instance) in your environment.

## Configuration and security roles

Learn how to [configure Resource Scheduling Optimization in your environment](./rso-configuration.md). The scheduling parameter updates and the data changes are unlikely to get modified over time. We recommend that you review [security roles](./rso-configuration.md#add-required-security-roles-to-users-who-will-configure-and-run-resource-scheduling-optimization) periodically because these roles might get modified or deleted.

## Bulk deletion jobs

Resource Scheduling Optimization includes two built-in system jobs:

- Delete Resource Scheduling Optimization Requests
- Delete Resource Scheduling Optimization Simulation Bookings

These [system jobs](/power-apps/developer/data-platform/asynchronous-service?tabs=webapi#retrieve-system-jobs) run daily and delete tables related to Resource Scheduling Optimization that are older than two weeks. Each time an optimization job runs, the service creates records that help with [monitoring](./rso-schedule-optimization.md#monitoring-optimization-requests) them. These records are meant to be purged periodically. 

While a system administrator or users with sufficient privilege can modify system jobs, we advise against doing so. Changed system jobs could lead to accumulated stale records that decrease system performance and delay or block updates.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
