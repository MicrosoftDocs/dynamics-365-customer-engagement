---
title: Set the capacity required for a service or resource (Dynamics 365 Customer Service) | MicrosoftDocs
description: View how to set the capacity required for a service or resource in Dynamics 365 Customer Service
ms.date: 09/15/2017
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6a67450b-dccc-471c-9e09-13a169f497cf
author: lalexms
ms.author: laalexan
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
search.app: 
  - D365CE
  - D365FS
---

# Set the capacity (number of activities in stipulated time) for a service or resource (Customer Service)

Define a limit to the number of activities a resource can perform in a stipulated time by setting the capacity of the resource and services in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] for Customer Service. 

> [!IMPORTANT]
> Service scheduling has been deprecated. For more information, see [Important changes coming](/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
You must set both the capacity of the service and the resources required for the service.  
  
When you set capacity of a resource and service, the service calendar doesn’t allow booking the resources once they reach their capacity.  
  
## Set the capacity of a service  
  
1. Before you start, make sure you have the Schedule Manager role assigned or have the required permissions for doing the scheduling tasks.  
  
2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
3. Click **Services**.  
  
4. In the list of services, open the service you want to set the capacity for.  
  
5. Under **Required Resources**, in the column on the right, double-click or tap the selection rule you want to modify.  
  
6. In the **Edit a Selection Rule** dialog box, expand the **Scheduling Details** area.  
  
7. In **Select Criteria**, to make sure everyone has the same workload, select **Least Busy**. Or, to make sure each member works at full capacity before assigning work to anyone else, select **Most Busy**.  
  
8. In **Capacity Required**, specify the capacity required by a resource to perform this service.  
  
    For example, a workshop has four work compartments. The capacity of the workshop is 4, that is, the workshop can have four different services scheduled for the same time. You can then add different workers, where the more skilled workers complete two tasks at once, so their capacity can be set to 2. They can have two jobs scheduled for the same time.  
  
9. Click **OK**.  
  
10. **Save & Close**.  
  
<a name="Collapsed4"></a>   
## Set the capacity of a resource  
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
2. [!INCLUDE[proc_settings_bus_management](../includes/proc-settings-bus-management.md)]  
  
3. Click **Facilities/Equipment**.  
  
4. In the list of records, open the record you want to set the capacity for.  
  
5. In the user record, on the nav bar, click the **chevron** button next to the record name, and then **Work Hours**.  
  
    -OR-  
  
    In the Facilities/Equipment record, under **Common**, click **Work Hours**.  
  
6. On the **Monthly View** tab, double-click the date on the calendar that is the first day you want the new schedule to start, or any date that will be affected by this edit.  
  
7. In the **Edit Schedule** dialog box, select one of the following and then click **OK**:  
  
   1. **This date only**. This option changes only the date selected. If you select this option, skip to step 8.  
  
   2. **From \<this date> onward**. This option changes only the schedule going forward.  
  
   3. **Entire recurring weekly schedule from start to end**. This option changes this entire schedule from the start to end date. Selecting this option might change past days, which might affect reports regarding hours worked in the past.  
  
8. In the **Weekly Schedule** dialog box, click the work hours link for the schedule you want to edit.  
  
    If working hours have not been set previously, the link is displayed as "Set Working Hours." You must set up a schedule for a user, facility, or equipment before you can continue. More information: [Set work hours for a resource](../customer-service/set-work-hours-resource.md)  
  
9. In the **Set Work Hours and Service Restrictions** dialog box, click **Show Capacity**, and then in the **Capacity** column, enter the capacity.  
  
10. Click **OK**.  
  
11. Click **Save & Close**.  
  
### See also  
 [Create or edit a selection rule](../field-service/create-simple-selection-rule.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
