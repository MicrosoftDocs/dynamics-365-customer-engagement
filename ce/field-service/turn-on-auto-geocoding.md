---
title: "Turn on auto geocoding (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 74e7dc26-094a-45fe-8da8-eae407978bfa
caps.latest.revision: 18
ms.author: krbjoran
manager: shellyha
---
# Turn on auto geocoding to calculate estimated travel time (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

With Dynamics 365 for [!INCLUDE[pn_field_service](../includes/pn-field-service.md)], it's important to geocode each service account record with latitude and longitude values so that when you generate work orders for that service location, the work order inherits the coordinates and the system can calculate estimated travel time when attempting to schedule the work order to a resource.  
  
 When you turn on the auto geocode system setting, the system will attempt to automatically add the appropriate latitude and longitude values based on the account's address.  
  
> [!IMPORTANT]
>  To use the schedule board booking functionality, geocoding, and location services, you need to turn on maps.  
>   
> 1. From the main menu, click **Resource Scheduling** > **Administration**.  
> 2. Click **Scheduling parameters**.  
> 3. Open record and scroll down to the **Resource Scheduling Optimization** section.  
> 4. On the **Connect to Maps** field, choose **Yes**.  
> 5. Accept terms and save the record.  
  
<a name="BKMK_TurnOnAutoGeocoding"></a>   
## Turn on automatic geocoding  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Field Service Settings**.  
  
2.  Under the **Other** section, go to **Auto Geo Code Addresses**, and then select **Yes**.  
  
3.  Click the **Save** button in the lower right corner.  
  
<a name="BKMK_GeocodeWorkOrderAddress"></a>   
## Geocode the address on a work order  
  
1. Open a work order.  
  
2. Ensure the work order has an accurate address.  
  
3. On the top command bar, click **Geo Code**.  
  
4. On the map dialog box, make sure you have the correct address, and then click **Change**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a work order](../field-service/create-work-order.md)  
  
<a name="BKMK_GeocodeAcctAddress"></a>   
## Geocode the address on an account record  
  
1. Open an account record  
  
2. Ensure the account has an accurate address.  
  
3. To geocode the account address, on the top command bar, click the **More Commands** button, and then select **Geo Code**.  
  
4. On the map dialog box, make sure you have the correct address, and then click **Change**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with accounts and contacts](../basics/accounts-contacts.md)  
  
### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Install](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [User's Guide](../field-service/user-guide.md)<br>
 [Extend Universal Resource Scheduling actions to use your preferred geospatial data provider](../common-scheduler/developer/use-preferred-geospatial-data-provider.md)
