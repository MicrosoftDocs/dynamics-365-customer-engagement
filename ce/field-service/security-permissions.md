---
title: Security roles and column-level security profiles
description: Learn how security roles and column-level security profiles affect users in Dynamics 365 Field Service.
ms.date: 10/28/2024
ms.topic: conceptual
ms.author: jacoh
author: jasonccohen
---

# Security roles and column-level security profiles

Security roles define how different users access different types of records. Record-level permissions are granted at the table level. The Field Service security roles define permissions for tables used in the application. Learn more: [Security roles and privileges](/power-platform/admin/security-roles-privileges). All Field Service users must have a security role.

If you have certain columns associated with a table that contain data that is more sensitive than the other columns, use column-level security to control access to specific columns. For example, a user can have access to the account table but the revenue column is locked. If the user needs to update the revenue column, they need permission set up for that column. Therefore, the user needs a security role and column-level permissions to access the column. Learn more: [Column-level security to control access](/power-platform/admin/field-level-security).

:::image type="content" source="media/security-profile-diagram.png" alt-text="Diagram showing user access with a security role and column-level security.":::

## Field Service security roles

There are several user roles that the Field Service application introduces.

- **Field Service - Resource**:  Designed for frontline workers who carry out work orders for customers onsite and track their work in the Field Service mobile application. This role only lets frontline workers view and update information on work orders that are assigned to them.

- **Field Service - Dispatcher**: Enables users who are responsible for scheduling jobs and assigning work orders to frontline workers.

- **Field Service - Administrator**: Provides a broad set of permissions to all tables and settings in Field Service. Intended for IT administrators and service managers who configure the system for the rest of the organization.

- **Field Service - Inventory Purchase**: Designed for inventory managers who oversee inventory on service vehicles,  purchase and reorder inventory, and process product returns. This role has permissions for inventory-related entities within their business unit and expands permissions for resources or dispatchers.

- **IoT - Administrator**: Registers IoT devices, connects IoT data with the Field Service application, and manages business processes based on IoT alerts.

- **IoT - Endpoint User** is used by Microsoft to connect Dynamics 365 to IoT systems. For more information, go to [setting up security roles for Connected Field Service](cfs-security-roles.md).

Most organizations have several resources, some dispatchers, and few administrators. For example, a plumbing company has 20 plumbers with vehicles and equipment. There are three dispatchers who assign work to the plumbers, and one administrator who maintains the system so everyone is productive.

## Next steps

[Set up users, licenses, and security roles](users-licenses-permissions.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
