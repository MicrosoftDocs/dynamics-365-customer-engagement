---
title: Deployment
ms.date: 09/10/2019
ms.topic: article
ms.custom: 
  - dyn365-fieldservice
ms.service: dynamics-365-customerservice
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Deploy Resource Scheduling Optimization (RSO)

After [getting access to RSO](./rso-get-install.md) either by purchasing a license or through your local Microsoft representative, you must deploy it to your Dynamics 365 Field Service environment.

## Deployment steps 

1. Verify Field Service is installed in your environment. The Field Service app will appear in the Dynamics 365 main menu when logged in as a system administrator.
> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service in navigation](media/field-service-navigation.png)


2. Go to the Dynamics 365 admin center and select the **Applications** tab.

> [!NOTE]
> **Do not** install the Resource Scheduling Optimization solution from the solution page. Follow the next steps using the RSO deployment app.

3. Select the **Resource Scheduling Optimization** application to configure or manage.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the Applications tab with RSO highlighted](media/rso-welcome.png)

4. Select the organization where the RSO solution will be installed, review the Terms of Service and select the agreement box, and then select **Deploy** to start the RSO deployment.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the "Deploy Resource Scheduling Optimization instance" window](media/rso-instance.png)
    
RSO is associated with a single Dynamics 365 organization in the tenant. You can change the associated organization through the RSO deployment app’s page. If additional RSO instances are needed for development and testing environments and you have an Enterprise Agreement with Microsoft, contact your technical account manager. Such instances are not yet available to Cloud Solution Providers or retail purchase.

5. Select **Upgrade to new version** to apply a new update if one is available.

6. Use **Change Organization** to change the RSO deployment from a Dynamics 365 organization to another. This will not delete data inside of the original Dynamics 365 organization an you can always change it back.

7. Use **Delete current deployment** to delete RSO Azure resources. The RSO solution will remain, which will not impact anything inside of the Dynamics 365 organization.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of the "Manage Resource Scheduling Optimization instance" window](media/rso-completed.png)

## Privacy notice  
[!INCLUDE[cc_privacy_rso_location_info_bing_maps](../includes/cc-privacy-rso-location-info-bing-maps.md)]