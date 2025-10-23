---
title: Use preferred geospatial data provider in Universal Resource Scheduling
description: Learn how to use the geospatial data provider of your choice instead of the default Bing Maps by creating a custom plug-in.
ms.date: 07/28/2025
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: puneet-singh1

ms.subservice: common-scheduler
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---
# Use preferred geospatial data provider in Universal Resource Scheduling

You can create a *custom* plug-in and register on the Universal Resource Scheduling actions that provide geospatial functionality to use data from a data provider of your choice instead of the default Bing Maps API.

The following Universal Resource Scheduling [actions](../../customerengagement/on-premises/customize/actions.md) provide geospatial functionality in Dynamics 365 Field Service and Dynamics 365 Project Operations:

- **msdyn_GeocodeAddress** for geocoding addresses
- **msdyn_RetrieveDistanceMatrix** for calculating travel times and distances between two locations. 

The Field Service and Project Operation solutions contain a plug-in registered on these two actions that, *by default*, use the data provided by Bing Maps API to perform geospatial operations.

> [!div class="nextstepaction"]
> [Create custom plug-in to use your preferred geospatial data provider](create-custom-plugin-preferred-geospatial-data-provider.md)

### Additional resources

- [Register and deploy custom plug-in to use your preferred geospatial data provider](register-deploy-custom-plugin-preferred-geospatial-data-provider.md)

- [Sample: Custom plug-in to use Google Maps API as geospatial data provider](sample-custom-plugin-google-geospatial-data-provider.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
