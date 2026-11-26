---
title: Deploy the Resource Scheduling Optimization add-on for Dynamics 365 Field Service
description: Learn how to deploy and manage the deployment for the Resource Scheduling Optimization add-on for Dynamics 365 Field Service.
ms.date: 09/28/2026
ms.topic: how-to
ms.custom: 
    - bap-template
    - ai-gen-docs-bap
    - ai-seo-date: 06/24/2026
ms.subservice: resource-scheduling-optimization
author: andrewclear-ms
ms.author: anclear
ai-usage: ai-assisted
---

# Deploy the Resource Scheduling Optimization add-on for Dynamics 365 Field Service

After [getting access to Resource Scheduling Optimization](rso-get-install.md) either by purchasing a license or through your Microsoft representative, deploy it to your Dynamics 365 Field Service environment.

## Deployment steps

1. Verify Field Service is installed in your environment. The Field Service app appears in the Dynamics 365 apps menu when logged in as a system administrator.

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). Select **Manage** > **Environments**, and then select the environment where you want to install the Resource Scheduling Optimization Add-on.

1. Select **Dynamics 365 apps**, and then select **Install app**.

1. Select **Resource Scheduling Optimization**, review the Terms of Service, select the agreement box, and then select **Install**. The install operation might take up to an hour to complete.

   > [!NOTE]
   > It might take several hours between the time the subscription appears in the Microsoft 365 Admin Center and the Power Platform Admin Center.

1. When installation finishes, confirm **Resource Scheduling Optimization** appears in the
   environment's **Dynamics 365 apps** list with a **Status** of **Installed**.

### Bulk deletion jobs

Resource Scheduling Optimization includes two built-in system jobs:

- Delete Resource Scheduling Optimization Requests
- Delete Resource Scheduling Optimization Simulation Bookings

These [system jobs](/power-apps/developer/data-platform/asynchronous-service?tabs=webapi#retrieve-system-jobs) run daily and delete tables related to Resource Scheduling Optimization that are older than two weeks. Each time an optimization job runs, the service creates records that help with [monitoring](./rso-schedule-optimization.md#monitoring-optimization-requests) them. These records are meant to be purged periodically.

While a system administrator or users with sufficient privilege can modify system jobs, we advise against doing so. Changed system jobs could lead to accumulated stale records that decrease system performance and delay or block updates.

## Configuration and security roles

Learn how to [configure Resource Scheduling Optimization in your environment](./rso-configuration.md). The scheduling parameter updates and the data changes are unlikely to get modified over time. We recommend that you review security roles periodically because these roles might get modified or deleted.

## Privacy notice

[!INCLUDE[cc_privacy_rso_location_info_bing_maps](../includes/cc-privacy-rso-location-info-bing-maps.md)]

## Next steps

- [Quickstart for Resource Scheduling Optimization](rso-quickstart.md)
- [Resource Scheduling Optimization configuration](rso-configuration.md)

## Related information

If you run into issues with Resource Scheduling Optimization, see the following troubleshooting articles:

- [Troubleshoot RSO deployment](/troubleshoot/dynamics-365/field-service/rso/troubleshoot-rso-deployment)
- [A requirement isn't scheduled in RSO](/troubleshoot/dynamics-365/field-service/rso/requirement-not-scheduled-in-rso)
- [User lacks privileges error](/troubleshoot/dynamics-365/field-service/rso/user-lacks-privileges-error)
- [SAS key isn't configured error](/troubleshoot/dynamics-365/field-service/rso/sas-key-not-configured-error)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
