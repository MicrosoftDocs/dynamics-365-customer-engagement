---
title: Deploy Resource Scheduling Optimization for Dynamics 365 Field Service
description: Learn how to deploy Resource Scheduling Optimization for Dynamics 365 Field Service
ms.date: 09/07/2022
ms.topic: article
ms.reviewer: mhart

ms.subservice: resource-scheduling-optimization
author: FeifeiQiu
ms.author: feiqiu
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Deploy Resource Scheduling Optimization for Dynamics 365 Field Service

After [getting access to Resource Scheduling Optimization](./rso-get-install.md) either by purchasing a license or through your local Microsoft representative, you must deploy it to your Dynamics 365 Field Service environment.

## Deployment steps

1. Verify Field Service is installed in your environment. The Field Service app appears in the Dynamics 365 main menu when logged in as a system administrator.

   :::image type="content" source="media/field-service-navigation.png" alt-text="Screenshot of Field Service in navigation.":::

1. Go to the Power Platform admin center: [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/). In the left pane, select **Resources** > **Dynamics 365 apps**.

1. Find Resource Scheduling Optimization and select **Manage**.

   :::image type="content" source="media/rso-upgrade-manage-powerapps-admin.png" alt-text="Screenshot of the Dynamics 365 admin center.":::

1. Select the organization where the Resource Scheduling Optimization solution will be installed, review the Terms of Service and select the agreement box, and then select **Deploy** to start the Resource Scheduling Optimization deployment.

   > [!NOTE]
   > It may take several hours between the time the subscription appears in Microsoft 365 Admin Center and Power Platform Admin Center.

   :::image type="content" source="media/rso-instance.png" alt-text="Screenshot of the Deploy Resource Scheduling Optimization instance page.":::
  
   Resource Scheduling Optimization is associated with a single Dynamics 365 organization in the tenant. You can change the associated organization through the Resource Scheduling Optimization deployment app’s page. If additional Resource Scheduling Optimization instances are needed for development and testing environments and you have an Enterprise Agreement with Microsoft, contact your technical account manager or commercial executive (formerly licensing specialist). Such instances are not yet available to cloud solution providers or retail purchase.

## Manage the Resource Scheduling Optimization instance

After the initial deployment, you can manage the deployed instance.

1. Go to the Power Platform admin center: [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/). In the left pane, select **Resources** > **Dynamics 365 apps**.

1. Find Resource Scheduling Optimization and select **Manage**.

   :::image type="content" source="media/rso-completed.png" alt-text="Screenshot of the Manage Resource Scheduling Optimization instance page.":::

   - Select **Upgrade to new version** to get the latest version. This option only shows if a newer version is available.

   - Select **Change Organization** to change the Resource Scheduling Optimization deployment from a Dynamics 365 organization to another. This action will not delete data inside of the original Dynamics 365 organization and you can always change it back.

   - Select **Delete current deployment** to delete Resource Scheduling Optimization Azure resources. The Resource Scheduling Optimization solution will remain, which will not impact anything inside of the Dynamics 365 organization.

## Privacy notice

[!INCLUDE[cc_privacy_rso_location_info_bing_maps](../includes/cc-privacy-rso-location-info-bing-maps.md)]

[!INCLUDE[footer-include](../includes/footer-banner.md)]
