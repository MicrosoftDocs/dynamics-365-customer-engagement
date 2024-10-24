---
title: Set up the Service Scheduling experience
description: Learn how to set up the Service Scheduling experience in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to 
ms.date: 10/18/2024
ms.custom:
- bap-template
- evergreen 
---

# Set up Service Scheduling

You can set up service scheduling from the Power Platform admin center.

> [!NOTE]
> Scheduling in Customer Service Hub is a [customer-driven update](#set-up-scenarios). You need to avail and enable the service scheduling package, which also includes the Universal Resource Scheduling (URS) functionality. Learn more at [Released Versions of Dynamics 365 Core Service Scheduling](/dynamics365/released-versions/dynamics365-css).

## Prerequisites

- Make sure that you have the required security role or equivalent permissions. Learn more at [Manage security roles in service scheduling](manage-security-roles.md).

- Ensure your organization has Universal Resource Scheduling 3.2.0.405 or a later version. If your organization has a version prior to 3.2.0.405, then Universal Resource Scheduling installation fails. To check the Unified Resource Scheduling version on your instance, go to **Settings** > **Solutions**.

   Learn more at [Schedule anything with Universal Resource Scheduling (Sales, Customer Service, Field Service, Project Service Automation)](../../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

   > [!NOTE]
   > - If your organization doesn't have Universal Resource Scheduling, the **Core Service Scheduling** solution installs the latest version of Universal Resource Scheduling.
   > - If Field Service or Project Service is already installed on your organization with Universal Resource Scheduling 3.2.0.405 or later version, then Universal Resource Scheduling will also be upgraded to the latest version. Otherwise, the installation fails.
   > - The latest version of Universal Resource Scheduling might not be compatible with the older versions of Field Service or Project Service.
- Ensure your organization has Customer Service Hub application.

## Set up scenarios

How you set up service scheduling differs, based on the following scenarios:

- For new or existing organizations where the Core Service Scheduling solution isn't installed, [install Service Scheduling from the Power Platform admin center](install-service-scheduling-from-power-platform.md).

- For existing organizations where the Core Service Scheduling solution is already installed, further updates happen automatically.

### Related information

[Overview of Service Scheduling](basics-service-service-scheduling.md)

[Service Scheduling FAQ](service-scheduling-faq.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
