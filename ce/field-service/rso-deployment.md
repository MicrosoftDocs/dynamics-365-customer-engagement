---
title: Deploy the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service
description: Learn how to deploy and manage the deployment for  the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 09/09/2025
ms.topic: how-to
ms.custom: bap-template
ms.subservice: resource-scheduling-optimization
author: andrewclear-ms
ms.author: anclear
---

# Deploy the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service

After [getting access to Resource Scheduling Optimization](rso-get-install.md) either by purchasing a license or through your Microsoft representative, deploy it to your Dynamics 365 Field Service environment.

You can deploy multiple instances of the Resource Scheduling Optimization add-in on the same Microsoft 365 tenant, however, a Resource Scheduling Optimization instance can connect to one Dynamics 365 organization only. If you need to have concurrent instances, for example in production and development organizations, see [Get licenses for multiple instances](rso-get-install.md#get-licenses-for-multiple-instances).

## Deployment steps

1. Verify Field Service is installed in your environment. The Field Service app appears in the Dynamics 365 apps menu when logged in as a system administrator.

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). In the left pane, select **Manage** > **Products - Dynamics 365 apps**.

1. Scroll through the list of apps or use the search field in the Power Platform admin center to find **Resource Scheduling Optimization** and select **Manage**.

1. Select the organization where you want to install the Resource Scheduling Optimization solution, review the Terms of Service, select the agreement box, and then select **Deploy** to start the Resource Scheduling Optimization deployment.

   > [!NOTE]
   > It may take several hours between the time the subscription appears in Microsoft 365 Admin Center and Power Platform Admin Center.

## Manage the Resource Scheduling Optimization instance

After the initial deployment, you can manage the deployed instance.

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/). In the left pane, select **Resources** > **Dynamics 365 apps**.

1. Find Resource Scheduling Optimization and select **Manage**.

1. Choose one of the following options:

   - Select **Upgrade to new version** to get the latest version. This option only shows if a newer version is available.

   - Select **Change Organization** to switch the Resource Scheduling Optimization deployment from one Dynamics 365 organization to another. This action doesn't delete data in the original Dynamics 365 organization, and you can always switch back.

   - Select **Delete current deployment** to delete Resource Scheduling Optimization Azure resources. The Resource Scheduling Optimization solution remains, so nothing inside the Dynamics 365 organization is affected.

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

[!INCLUDE[footer-include](../includes/footer-banner.md)]
