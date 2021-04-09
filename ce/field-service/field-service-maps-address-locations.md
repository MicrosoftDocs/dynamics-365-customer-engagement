---
title: "Enable location and map settings in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn all about location and map settings and how to enable them in Dynamics 365 Field Service.
ms.custom:
- dyn365-fieldservice
ms.date: 03/24/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Enable location and map settings in Dynamics 365 Field Service

Locations and maps are important for getting the most value out of Field Service. For example, knowing the location of work orders and resources allows the solution to effectively route the closest technician (resource) to the service request (work order).

Enable location and map settings to perform functions like:

- Easily get directions so technicians can arrive on time for service appointments.
- Attach latitude and longitude values to addresses (geocode).
- See work orders on a map.
- Configuring geofencing.


> [!Important]
> By connecting to a mapping service, you are allowing the system to share your data. Data includes - but is not limited to - addresses and coordinates, with external systems outside of your Microsoft Dynamics 365 environment. ("Mapping service" refers to Bing Maps or other third-party mapping service designated by you or your operating system). This also applies to Government Cloud environments. Your use of the mapping service will also be subject to their separate terms of use. Data imported from such external systems into Microsoft Dynamics 365 are subject to the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement).

## Connect to maps

Go to **Resource Scheduling app** > **Administration** > **Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot of settings](media/quickstart-rs-settings.png) 

Set **Connect to Maps** to **Yes**.

Connecting to Maps is enabled by default for new environments. To confirm your environment is connected to maps - or to disconnect maps - go to to **Resource Scheduling app** > **Administration** > **Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot of setting connect to maps to yes](media/Perform-Initial-Configurations-image7.png)  

> [!Note]
> In Field Service version 8.8.10.44+ the Bing Maps API key is hidden.

Save and close.

## Enable auto geocoding for addresses

Geocoding is associating a latitude and longitude to an address. Geocoding allows dispatchers to locate work orders more effectively than providing only an address.

"Auto geocode addresses" means that after entering an address on records such as accounts, contacts, users, and work orders, the system will automatically attempt to locate the address and populate latitude and longitude values. Disallowing auto geocoding for addresses requires the user to select a geocode option to manually geocode an address.

From the Field Service App, go to  **Settings** > **Field Service Settings** > **Other** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service Administration from Dynamics 365 dropdown menu](media/quickstart-fs-settings.png)  

In the **Other** section, decide if you would like the application to auto geocode addresses. The recommended setting is **Yes.**
 


> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service settings showing the auto geocode for addresses set to yes.](./media/admin-enable-address-suggestions.png)

## Enable address suggestions

Field service users can quickly enter account service addresses using Bing Maps address recommendations. As you enter an address, the system will make recommendations. Using address suggestions helps ensure accuracy and reduces data entry errors. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a new work order in Field Service, showing address suggestions in a dropdown menu.](./media/workordernewaddress.png)

Address recommendations are also available on the mobile app for technicians with the appropriate security role. 

To enable location recommendations in Field Service, go to **Settings** > **Field Service Settings** > **Other** tab. 

Address recommendations are on the account, work order, and booking forms.

> [!Note]
> By default, the _Field Service - Resource_ security role has read-only privileges and cannot edit addresses.

## Enable Bing Maps (Show Bing Maps on forms)

Enabling maps makes it so dispatchers and technicians can see a map view on work orders, accounts, and other records.

> [!div class="mx-imgBorder"]
> ![Screenshot of work order map](media/work-order-map.png) 

Bing Maps is enabled by default for new environments. To confirm Bing Maps is enabled - or to disable Bing Maps - go to **Advanced Settings** > **Settings** > **Administration** > **System Settings** > **General tab** 


> [!div class="mx-imgBorder"]
> ![Screenshot of system settings in Field Service, showing the option to enable Bing Maps.](./media/admin-enable-bing-maps-on-forms.png)

For more information on enabling maps for the work order form, see this article on [managing Bing Maps](https://docs.microsoft.com/dynamics365/customer-engagement/admin/manage-bing-maps-organization).

## Enable booking maps

Booking maps is a feature that allows frontline workers to see their scheduled jobs on a map.

> [!div class="mx-imgBorder"]
> ![Screenshot of bookings on a map in the Field Service mobile app.](./media/mobile-2020-booking-maps.png)

For more information, see this article: [Enable geospatial features in your environment](https://docs.microsoft.com/powerapps/maker/canvas-apps/geospatial-overview#enable-the-geospatial-features-for-the-environment) 

## Test geocoding

Finally, let’s test geocoding.

Go to **Field Service** > **Work Orders** and select **+New**.

Begin typing an address.

> [!div class="mx-imgBorder"]
> ![Screenshot of work order address form](media/Perform-Initial-Configurations-image13.png)  

The system will find the address and present it as a suggestion.

> [!div class="mx-imgBorder"]
> ![Screenshot of address suggestion](media/Perform-Initial-Configurations-image14.png)  

After selecting the correct address, the form will populate the rest of the address, including the latitude and longitude.

> [!div class="mx-imgBorder"]
> ![Screenshot of address with latitude and longitude populated on work order form.](media/Perform-Initial-Configurations-image15.png)  

If you don't want the system to auto geocode addresses, select the geocode button in the top ribbon.

> [!div class="mx-imgBorder"]
> ![Screenshot of the geocode button in the top ribbon.](media/Perform-Initial-Configurations-image16.png)  

>[!Tip]
> When using Field Service, it's not common practice to enter addresses on a work order. The standard process is to geocode accounts, and when a service account is entered on a work order as the service location, the geocoded address is pulled from the account and added to the work order.

>[!Tip]
> It's possible to geocode multiple records at once by selecting the records from a view. In the following screenshot, we are mass-geocoding accounts.

> [!div class="mx-imgBorder"]
> ![Screenshot of mass Geocoding multiple account records.](media/Perform-Initial-Configurations-image17.png)  



## See also

- [Location tracking, sharing, and auditing](mobile-powerapp-location-auditing.md)
- [Geofencing](mobile-powerapp-geofence.md)

















