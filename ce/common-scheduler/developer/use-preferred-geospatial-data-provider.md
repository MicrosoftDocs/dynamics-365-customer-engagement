---
title: "Extend Universal Resource Scheduling actions to use your preferred geospatial data provider | MicrosoftDocs"
description: "Provides information on how to use geospatial data providers of your choice instead of the default Bing Maps in Dynamics 365 Field Service and Dynamics 365 Project Service Automation."
ms.custom: 
  - dyn365-developer
  - dyn365-customerservice
ms.date: 01/29/2018
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: conceptual
author: FieldServiceDave
ms.author: daclar
search.app: 
  - D365CE
  - D365PS
  - D365FS
---
# Extend Universal Resource Scheduling actions to use your preferred geospatial data provider (Field Service, Project Service Automation)

You can create a *custom* plug-in and register on the Universal Resource Scheduling actions that provide geospatial functionality to use data from a data provider of your choice instead of the default Bing Maps API.

The following Universal Resource Scheduling [actions](../../customize/actions.md) provide geospatial functionality in [!INCLUDE[pn_dyn_365_field_service](../../includes/pn-dyn-365-field-service.md)] and [!INCLUDE[pn_dyn_365_project_service_auto](../../includes/pn-dyn-365-project-service-auto.md)]:
- **msdyn_GeocodeAddress** for geocoding addresses
- **msdyn_RetrieveDistanceMatrix** for calculating travel times and distances between two locations. 

The [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] and Project Service Automation solutions contain a plug-in registered on these two actions that, *by default*, uses the data provided by Bing Maps API to perform geospatial operations.

> [!div class="nextstepaction"]
> [Create custom plug-in to use your preferred geospatial data provider](create-custom-plugin-preferred-geospatial-data-provider.md)

### See also

[Register and deploy custom plug-in to use your preferred geospatial data provider](register-deploy-custom-plugin-preferred-geospatial-data-provider.md)

[Sample: Custom plug-in to use Google Maps API as geospatial data provider](sample-custom-plugin-google-geospatial-data-provider.md)

[Universal Resource Scheduling](../schedule-anything-with-universal-resource-scheduling.md)  
    


[!INCLUDE[footer-include](../../includes/footer-banner.md)]