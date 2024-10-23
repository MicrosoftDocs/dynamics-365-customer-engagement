---
title: Set up users, licenses, and security roles
description: Learn how to set up Field Service users and security roles in Dynamics 365 Field Service.
ms.date: 10/23/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
---

# Set up users, licenses, and security roles

Field service management requires several individuals with different roles to complete a work order. Every individual that needs access to the Dynamics 365 Field Service application needs a user account, a Field Service license, and the right level of permissions. This article helps you set up users, assign licenses, and define permissions for licensed users.

## Prerequisites

- You need [admin permissions](/microsoft-365/admin/admin-overview/admin-overview?view=o365-worldwide&preserve-view=true) for Microsoft 365.
- Your organization [owns Field Service licenses](buy-fs.md). To try Field Service, [start a free trial](https://dynamics.microsoft.com/get-started/free-trial/?appname=fieldservice).

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

Now that users have a license and access to the environment, they need a security role to get the right privileges for the application.

For more information, see [Assign security roles to a user](/power-platform/admin/assign-security-roles). To assign a security role to multiple users, consider managing them as a [team in Dataverse](/power-platform/admin/manage-teams).

Choose one of the [predefined Field Service security roles](security-permissions.md#field-service-security-roles) or [create custom security roles for your business case](/power-platform/admin/create-edit-security-role).

## Next steps

- [Set defaults for work orders, bookings, the schedule board, and agreements](configure-default-settings.md)
- [Configure offline capabilities in the mobile app](mobile/work-offline.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
