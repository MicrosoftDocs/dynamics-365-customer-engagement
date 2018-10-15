---
title: Create or change a service in service scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to create or change a service in service scheduling in Dynamics 365 for Customer Service
keywords: Service management; Dynamics 365; Customer Service; Service scheduling
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamiccs 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 93c16131-07ba-413b-a2e2-0f51ca1dfe07
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create or edit a service in Service Scheduling

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. By using the service records in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can define:  
  
-   How long a service activity would last  
  
-   What resources are available for the service activity, like resources, facilities, or equipment  
  
> [!NOTE]
> A service requires at least one selection rule and one or more resources, resource groups, or teams before the service can be scheduled with a service activity.

## Create a service
  
Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.
2. From the list of entity records, select **Scheduling > Service**.
   - The **Active Services** view is displayed. You can switch between various system views using the drop-down.
   - Select **Show Chart** in the command bar to see the chart view.
   - Select any existing service to see additional options in the command bar

3. On the command bar, select **New** to create a new service. To edit a service, open a service from the list.  
  
4. In the **General** section, enter a **Name** and **Description** to reflect the specifics of the service and describe what the service is. </br> Also, specify the initial status of the service activity when it is created. If your organization prefers to approve all service activities before committing them to the schedule, you can select **Requested** or **Tentative**.
5. Select **Save** to save the service.

   ![Create a service](media/create-service-csh.png)

5. In the **Resource Requirement** section, define your selection rule:

   - Add a new requirement subgroup by selecting **Subgroup**. 
   - Add a new resource requirement by selecting **Requirement**.
   - In **Duration**, enter the duration to define how long the service lasts. This can be changed when the service activity is created. 

     > [!NOTE]
     > The maximum duration of an appointment or service activity is 10 days.
   - Choose if the service is **Part of Same** organizational unit, resource tree or location.
   - Lookup or quick create a **Fulfillment Preference**.
   - Specify the **Organizational Unit**.
   - Add **Resource Categories**  and define **Characteristics**.
   - Add **Preferred Resource**. You can add as many resources as you want, and they can be a mix of individual users, facilities, equipment, and teams. 
   - Define **Sort Option** to sort according to most and least business impact.
   - Provide **Effort Required**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Capacity vs. effort—understand the difference](service-scheduling-faq.md#what-is-capacity-and-effort-what-is-the-difference).

   You can add complexity to a rule by adding a subrule to it.  

   ![Resource requirement](media/resource-requirement-csh.png)

   > [!NOTE]
   >  You can save a service without defining a selection rule, but you won’t be able to schedule that service.   

7.  When you’re ready to save your data, select **Save**.  
  
## Activate or deactivate a service  
 You can make a service available on unavailable for scheduling by activating or deactivating it. To do this, in the list of service records, select a service, then select **Activate** or **Deactivate** in the command bar.  

## Test your service  
 Before you start using a service, test it. Create a service activity with no criteria other than the service. You can use the results to confirm that the service is selecting correctly. The message bar will also display any problems with the search.  
  
1.  In the Customer Service hub sitemap, select **Scheduling** > **Service Activity**. This bypasses the scheduling form.  
  
2.  Select the service to test.  
  
3.  Select **Find Available Times**. 
  
### See also  

[Create and manage resource categories](resource-categories-service-scheduling.md)
 
[Set work hours to define availability](set-work-hours-resource.md)