---
title: "Use Resource Scheduling Optimization to schedule multiple bookings on a recurring basis (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: dyn365-fieldservice; dyn365-projectservice
ms.date: 09/30/2017
searchScope:
  - Customer Service
  - Field Service
  - Project Service
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 5423740c-79b3-4c6d-9b7c-6fdcec791425
caps.latest.revision: 22
ms.author: krbjoran
manager: shellyha
---
# Use Resource Scheduling Optimization to schedule multiple bookings on a recurring basis (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use [!INCLUDE[pn_resource_scheduling_ optimization_msdyn365](../includes/pn-resource-scheduling-optimization-msdyn365.md)] to automatically set up the system to schedule multiple bookings on a recurring basis.  
  
 The Resource Scheduling Optimization solution minimizes overall travel time and maximizes efficient use of all resources. It takes many constraints into account, such as resource availability, skills required, working hours, duration, and time windows to optimize the schedule.  
  
 For example, if you are using [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] you can set up the system to automatically schedule work orders.  
  
<!--In [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)], you can set it up to automatically schedule resources for projects.-->  
  
 If you've enabled the Common Scheduling Solution for other entities such as cases, opportunities, or leads, you can also use Resource Scheduling Optimization to automatically schedule time to work on those. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Scheduling anything in Dynamics 365 with Universal Resource Scheduling](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md)  
  
## Prerequisites  
 Before you  install [!INCLUDE[pn_resource_scheduling_ optimization_msdyn365](../includes/pn-resource-scheduling-optimization-msdyn365.md)], you need to have [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] with the correct licensing to use Resource Scheduling Optimization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=833491)  
  
## Deploy (admin task)  
 To use this feature, first you need to install [!INCLUDE[pn_resource_scheduling_ optimization_msdyn365](../includes/pn-resource-scheduling-optimization-msdyn365.md)].  
  
1.  Sign in to [https://portal.office.com](https://portal.office.com) with your global administrator or [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] system administrator credentials.  
  
2.  Select **Admin centers** > **Dynamics 365**.  
  
3.  Select the **Instances** tab, and then the instance to add the solution to.  
  
4.  Select **Applications**.  
  
5.  Under **Manage Applications**, select the **Resource Scheduling Optimization** solution and then **Manage**.  
  
6.  On the sign-in screen, use your global administrator or Dynamics 365 system administrator credentials. This is same info you used in Step 1.  
  
7.  Select the organization from the drop-down menu. Verify the credentials and select **Deploy**.  
  
 ![Deploy Resource Scheduling Optimization instance](media/common-scheduler-deploy-resource-scheduling-instance.png "Deploy Resource Scheduling Optimization instance")  
  
    > [!NOTE]
    > [!INCLUDE[pn_resource_scheduling_ optimization_msdyn365](../includes/pn-resource-scheduling-optimization-msdyn365.md)] can only be deployed to one organization at a time in your tenant. If you get an error on this screen it is typically from the user name or password being entered incorrectly.  
  
8.  On the **Confirmation** window, select **Yes**.  
  
9. On the **Deploy Resource Scheduling Optimization Instance** screen, verify your credentials and then select **Deploy**.  
  
     Once authentication is successful, **Please wait** will appear at the top of the screen.  
  
10. Select **Agree** to proceed through the **Terms of Service**.  
  
     The status will show **Installation in progress**.  
  
11. When the status changes to **Waiting to link to Dynamics 365 organization**, select **Link**.  
  
12. When the deployment is complete, select **Finish**.  
  
 You will then be taken to the **Manage Resource Scheduling Optimization Instance** screen, where you can do the following:  
  
- **Check for Updates**: Check for updates to your Resource Scheduling Optimization  instances.  
  
- **Update User Credentials**: Update the user credentials to whoever will be maintaining the link  between Resource Scheduling Optimization and your organization. This  user has a Resource Scheduling Optimization security role and can publish the Resource Scheduling Optimization schedule and run optimization jobs.  
  
- **Change Organization**: If you have multiple organizations in your tenant that use Resource Scheduling Optimization, then use this action to switch the connection to a different org.  
  
- **Open Organization**: Opens the organization where[!INCLUDE[pn_resource_scheduling_ optimization_msdyn365](../includes/pn-resource-scheduling-optimization-msdyn365.md)] is deployed in a new tab.  
  
## Enable Resource Scheduling Optimization  
 To use Resource Scheduling Optimization, your user profile needs to have a security role. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Assign security roles](#BKMK_AssignRoles)  
  
1.  From the main menu, select **Resource Scheduling** > **Administration**.  
  
2.  Select **Scheduling Parameters**.  
  
3.  Open a record and scroll down to the **Resource Scheduling Optimization** section.  
  
4.  To use the schedule board booking functionality, geocoding, and location services, you need to turn on Maps. On the **Connect to Maps** field, choose **Yes** and accept the terms.  
  
5.  On the **Enable Resource Scheduling Optimization** field, choose **Yes**.  
  
 ![Enable Resource Scheduling](../common-scheduler/media/common-scheduler-enable-resource-scheduling.png "Enable Resource Scheduling")  
  
6.  Accept the terms and save the record.  
  
## Set latitude and longitude values  
 Next you'll  need to set the latitude and longitude for the resource's organizational unit. These values are used by   Resource Scheduling Optimization if the start and end location on the resource record are set to the  company address.  
  
1.  From the main menu, select **Resource Scheduling** > **Organization Units**.  
  
2.  From the list of records, open an  organizational unit record.  
  
3.  Manually enter the latitude and longitude values on the form.  
  
    > [!NOTE]
    >  To get latitude and longitude values, you can use a map service such as Bing Maps to find the latitude and longitude of an address.  
  
4.  Save your changes. Then reload the form and populate the latitude and longitude for all organizational units that are being optimized by Resource Scheduling Optimization.  
  
## Set Booking Statuses  
 The booking status needs to be set so that Resource Scheduling Optimization will know how to handle bookings.  
  
1.  From the main menu, select **Resource Scheduling** > **Booking Statuses**.  
  
2.  From the list of records, open a booking status record.  
  
3.  In the **Resource Scheduling Optimization** section, choose one of the following for **Scheduling Method**:  
  
    - **Optimize**: A booking with this status lets Resource Scheduling Optimization move the booking around to optimize the best schedule.  
  
    - **Do Not Move**: A booking with this status prohibits Resource Scheduling Optimization from changing the booking in any way. This behaves the same as if you set the booking to "locked to resource + time" on the scheduling lock options.  
  
    - **Ignore**: A booking with this status Resource Scheduling Optimization will completely ignore.  It is as  if it doesn’t exist. Use this when the booking status is  proposed but not confirmed, or  canceled.  
  
<a name="BKMK_AssignRoles"></a>   
## Assign security roles  
 The next step is to assign a security role to the user name used to deploy Resource Scheduling Optimization to your organization.  
  
1.  From the main menu, select **Settings** > **Security** > **Users**.  
  
2.  Select the user and then select **Manage Roles**.  
  
3.  Check the box for **Resource Scheduling Optimization** and select **OK**.  
  
4.  Save your changes.  
  
5.  Then add the user to the **Resource Scheduling Optimization – Administration, Field Security** profile.  
  
     From the main menu, select **Settings** > **Security** > **Field Security Profiles**.  
  
6.  Select **Resource Scheduling Optimization – Administration**.  
  
7.  On the left, select **Users**, and then **Add**.  
  
8.  Select the user name,  then **Select**, then **Add**.  
  
9. **Save & Close**.  
  
### Enable Resource Scheduling Optimization for resources  
 Next, you need to tell the system which Field Service resource will be used by Resource Scheduling Optimization.  For example, if you need 10 field techs but you only want five of them to be used by Resource Scheduling Optimization for automatic scheduling, then enable just those five resources.  
  
> [!NOTE]
>  Resource Scheduling Optimization will not work if the resource type is an asset or resource group.  
  
1.  From the main menu, go to **Field Service** > **Administration** > **Resources**.  
  
2.  Select a resource from the list of bookable resources.  
  
3.  Scroll down to **Resource Scheduling Optimization**. For **Optimize Schedule**, select **Yes**.  
  
> [!NOTE]
>  Under the **Common** section, make sure the resource has start and end locations and organizational unit set.  
  
## Set up the system to automatically schedule multiple activities  
  
1.  From the main menu, go to **Resource Scheduling** > **Resource Scheduling Optimization Administration**.  
  
2.  On the command bar, select **New**.  
  
3. **Name**: Enter a name.  
  
4. **Schedule**: Choose how Resource Scheduling Optimization will run:  
  
    1. **Timer**: Define how often this schedule will run.  
  
    2. **Timer Mode**: The instant when the schedule will start the timer. Choose **Fixed** or **After Job Completion**.                          For example, if the timer is set to 30 minutes, the first run will start 30 minutes from publish date/time. Fixed = run every   30 minutes. After job completion = run 30 minutes from the end of the last Resource Scheduling Optimization job execution.  
  
    3. **Valid From and Valid To:** The first/last date and time when this schedule will be valid for execution.  
  
5.  Expand the **Filter** menu. Specify when the engine should run - months, days of the month, days of the week, hours and/or minutes.  
  
    > [!NOTE]
    >  This is an advanced option. If you leave all the filter options empty, the system will run using all the options.  
  
**Define Scope**  
  
1. **Scope**: Define what Resource Scheduling Optimization should optimize for:  
  
    1.  Choose **Select a Value** to select an existing scope. Or **New** to create a new scope:  
  
        1. **Name**: Enter a name.  
  
        2. **Resource Requirement State:** Select which resource requirement should be selected based on its current state. Choose **Only Scheduled or Schedule** or **Unscheduled**.  
  
        3. **Range Reference**: The starting time to be used for all subsequent work order calculations. Choose **Job Current Time** or **Beginning of the Job's Current Day**.  
  
        4. **Range Offset**: Enter the amount of time that should be added to the range reference to define range start.  
  
        5. **Range Duration (days):** Amount of days added to the range reference.  
  
        6.  Select **Save.**  
  
        7.  Select **Add Territory Record** to add a territory to the scope.  
  
2.  When you're done save and close the record.  
  
**Define Goal**  
  
1. **Goal**: Define how bookings should be optimized:  
  
    1.  Choose **Select a value** to select an existing goal. Or **New** to create a new goal:  
  
        1. **Name**: Enter a name.  
  
        2. **Engine Effort Level**: Choose how much effort Resource Scheduling Optimization should make to find the best auto-scheduling option.  
  
        3.  Choose **Constraints**:  
  
            - **Schedule Within Working Hours**: Verifies that the task is not scheduled outside of the resource's working hours.  
  
            - **Meets Required Characteristics**: Verifies the resource meets all the required characteristics, i.e. skills needed to complete the work.  
  
            - **Locked to Resource**: If marked, Resource Scheduling Optimization will not change any locked resources in the booking requirement.  
  
            - **Scheduling Windows**: If marked, Resource Scheduling Optimization will not change any locked scheduling windows in the booking requirement.  
  
            - **Restricted Resources**: If marked, Resource Scheduling Optimization will check resource preference to see if it's "restricted." If the requirement has a restricted resource in which there is no expiration, or expiration in the past, Resource Scheduling Optimization will not schedule this resource for this booking requirement.  
  
        4.  Choose **Objectives**:  
  
            - **Locked Booking**: The system will try to schedule the scenario that successfully creates or assigns the most “Locked” schedules to appropriate resources.  
  
            - **High Priority Requirements**: The system will evaluate this objective, and give priority to the booking requirements with the highest priority.  
  
            - **Maximize Total Working Hours**: The system will choose the results, and the resource with the highest aggregate work time will win this objective.  
  
            - **Minimize Total Travel Time**: The system will choose the results, and the resource  with the lowest aggregate travel time will win this objective.  
  
        5.  Select **Save & Close**.  
  
 Once you have defined a scope and goal, select **Save** to save the schedule. Then **Publish** to publish it.  
  
> [!NOTE]
>  To manually run  scheduling optimization, on the command bar, select **RUN NOW**.  
  
### Publish or Reset Scheduling Optimization  
  
1.  From the main menu, select **Resource Scheduling** > **Resource Scheduling Optimization Administration**.  
  
2.  Select the schedule you want to publish or reset.  
  
    -   To publish, on the command bar, select **PUBLISH ALL**.  
  
## Monitor Scheduling Optimization Request  
  
1.  From the main menu, go to **Resource Scheduling** > **Resource Scheduling Optimization Administration**.  
  
2.  From the list, open a published schedule.  
  
3.  Go to the **Scheduling Optimization Request** section  and open a record to see the bookings that were created.  
  
> [!NOTE]
>  To see why a booking was not created, from the main menu go  to **Resource Scheduling** > **Resource Requirements**. Select the **Requirements: Invalid data for Optimization Engine** view.

![Troubleshoot bookings](media/common-scheduler-troubleshoot-bookings.png "Troubleshoot bookings")  
  
## Enable schedule optimization for an existing work order  
  
1.  Open an existing work order.  
  
2.  At the top, select the menu next to the work order number and then **Requirements**.  
  
 ![Work Order sub-menu](media/common-scheduler-work-order-submenu.png "Work Order sub-menu")  
  
3.  Under the **Resource Requirement Associated** view, select the work order number.  
  
4.  For schedule optimizing to work, make sure these fields are set:  
  
    - **Duration**: This is how much time is expected to complete the work.  
  
    - **Scheduling Method**: This must be set to **Optimize**.  
  
    - **Priority**: Enter the priority of the work order.  
  
    - **Work Location**: Select either **On Site** or **Location Agnostic**. If this is set to **Location Agnostic** then latitude and longitude are not required.  
  
    - **Latitude** and **Longitude**: These must have a value if **Work Location** field is set to **On Site**.  
  
    - **Territory**: This must have a value that is in the scope of Resource Scheduling Optimization.  
  
5.  Save your changes and close the form.  
  
<a name="bkmk_step3 "></a>   
## Privacy notice  
[!INCLUDE[cc_privacy_rso_location_info_bing_maps](../includes/cc-privacy-rso-location-info-bing-maps.md)]
  
### See also  
 [Install Dynamics 365 for Field Service](../field-service/install-field-service.md)<br>
 [Install Dynamics 365 for Project Service Automation](../project-service/install-customize.md)
