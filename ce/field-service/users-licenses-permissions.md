---
title: Set up users, licenses, and security roles
description: Learn how to set up Field Service users and security roles in Dynamics 365 Field Service.
ms.date: 11/06/2023
ms.topic: conceptual
ms.author: jacoh
author: jasonccohen
---

# Set up users, licenses, and security roles

Field service management requires several individuals with different roles to complete a work order. Every individual that needs access to the Dynamics 365 Field Service application needs a user account, a Field Service license, and the right level of permissions. This article helps you set up users, assign licenses, and define permissions for licensed users.

## Prerequisites

- You need [admin permissions](/microsoft-365/admin/admin-overview/admin-overview?view=o365-worldwide&preserve-view=true) for Microsoft 365.
- Your organization [owns Field Service licenses](buy-fs.md). To try Field Service, [start a free trial](https://dynamics.microsoft.com/get-started/free-trial/?appname=fieldservice).

## Field Service security roles

There are several user roles that the Field Service application introduces.

- **Field Service - Resource**:  Designed for frontline workers who carry out work orders for customers onsite and track their work in the Field Service mobile application. This role only lets frontline workers view and update information on work orders that are assigned to them.

- **Field Service - Dispatcher**: Enables users who are responsible for scheduling jobs and assigning work orders to frontline workers.

- **Field Service - Administrator**: Provides a broad set of permissions to all tables and settings in Field Service. Intended for IT administrators and service managers who configure the system for the rest of the organization.

- **Field Service - Inventory Purchase**: Designed for inventory managers who oversee inventory on service vehicles,  purchase and reorder inventory, and process product returns. This role has permissions for inventory-related entities within their business unit and expands permissions for resources or dispatchers.

- **IoT - Administrator**: Registers IoT devices, connects IoT data with the Field Service application, and manages business processes based on IoT alerts.

- **IoT - Endpoint User** is used by Microsoft to connect Dynamics 365 to IoT systems. For more information, see [setting up security roles for Connected Field Service](cfs-security-roles.md).

Most organizations have several resources, some dispatchers, and few administrators. For example, a plumbing company has 20 plumbers with vehicles and equipment. There are three dispatchers who assign work to the plumbers, and one administrator who maintains the system so everyone is productive.

## Create user accounts

You use the Microsoft 365 admin center to [create user accounts](/power-platform/admin/create-users) for every user who needs access to Field Service.

### From your organization

To create user accounts for users within your organizations, add them individually or in bulk.

For more information, see [Add users](/microsoft-365/admin/add-users/add-users).

### B2B collaboration users

For scenarios, where you want to add a contractor or vendor to your Field Service applications, create a B2B collaboration user. Collaboration users are managed in the Microsoft Entra admin center.

For more information, see [Add Microsoft Entra B2B collaboration users](/entra/external-id/add-users-administrator).

If you run into issues when configuring external users, see [Troubleshooting B2B collaboration](/entra/external-id/troubleshoot).

## Assign licenses

With user accounts in place, assign the users a Field Service license. Users need a license assigned to access the Field Service application. There are [two types of licenses available](buy-fs.md).

Assign the users on of the following available licenses:

- Dynamics 365 Field Service
- Dynamics 365 Field Service Contractor

For more information, see [Assign licenses](/power-platform/admin/assign-licenses)

## Add users to an environment

Before licensed users can access the application, you need to add them to the environment that hosts the app. You can add specific users to an environment with a couple of steps.

For more information, see [Add users to an environment](/power-platform/admin/add-users-to-environment).
Alternatively, you can [use security groups to manage access to environments](/power-platform/admin/control-user-access).

## Assign security roles

Now that users have a license and access to the environment, they need a security role to get the right privileges for the application. [Security roles control the types of data tables a user can access and edit](/power-platform/admin/security-roles-privileges). For example, a user can have permission to see accounts, but not to see revenue fields for an account.

For more information, see [Assign security roles to a user](/power-platform/admin/assign-security-roles). To assign a security role to multiple users, consider managing them as a [team in Dataverse](/power-platform/admin/manage-teams).

Choose one of the [predefined Field Service security roles](#field-service-security-roles) or [create custom security roles for your business case](/power-platform/admin/create-edit-security-role).

## Next steps

- [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)
- [Configure offline capabilities in the mobile app](mobile/work-offline.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
