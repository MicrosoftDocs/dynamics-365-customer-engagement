---
title: "Turn on auto geocoding (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to turn on auto geocoding in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Turn on auto geocoding to calculate estimated travel time (Field Service)

With Dynamics 365 for [!INCLUDE[pn_field_service](../includes/pn-field-service.md)], it's important to geocode each service account record with latitude and longitude values so that when you generate work orders for that service location, the work order inherits the coordinates and the system can calculate estimated travel time when attempting to schedule the work order to a resource.  
  
 When you turn on the auto geocode system setting, the system will attempt to automatically add the appropriate latitude and longitude values based on the account's address.  
  
> [!IMPORTANT]
>  To use the schedule board booking functionality, geocoding, and location services, you need to turn on maps.  
>   
> 1. From the main menu, go to **Resource Scheduling** > **Administration**.  
> 2. Select **Scheduling parameters**.  
> 3. Open record and scroll down to the **Resource Scheduling Optimization** section.  
> 4. On the **Connect to Maps** field, choose **Yes**.  
> 5. Accept terms and save the record.  
  
<a name="BKMK_TurnOnAutoGeocoding"></a>

## Turn on automatic geocoding  
  
1.  From the main menu, go to **Field Service** > **Administration**, and then choose **Field Service Settings**.  
  
2.  Under the **Other** section, go to **Auto Geo Code Addresses**, and then select **Yes**.  
  
3.  Select the **Save** button in the lower right corner.  
  
<a name="BKMK_GeocodeWorkOrderAddress"></a>

## Geocode the address on a work order  
  
1. Open a work order.  
  
2. Ensure the work order has an accurate address.  
  
3. On the top command bar, select **Geo Code**.  
  
4. On the map dialog box, make sure you have the correct address, and then select **Change**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a work order](../field-service/create-work-order.md)  
  
<a name="BKMK_GeocodeAcctAddress"></a>   
## Geocode the address on an account record  
  
1. Open an account record  
  
2. Ensure the account has an accurate address.  
  
3. To geocode the account address, on the top command bar, select the **More Commands** button, and then select **Geo Code**.  
  
4. On the map dialog box, make sure you have the correct address, and then select **Change**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with accounts and contacts](../customerengagement/on-premises/basics/accounts-contacts.md)  
  
### See also   
 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Install](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [User's Guide](../field-service/user-guide.md)<br>
 [Extend Universal Resource Scheduling actions to use your preferred geospatial data provider](../common-scheduler/developer/use-preferred-geospatial-data-provider.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]