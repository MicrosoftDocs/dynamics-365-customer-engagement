---
title: Create or change a service in service scheduling(Dynamics 365 for Customer Service) | MicrosoftDocs
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

# Create or change a service

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. By using the service records in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can define:  
  
-   How long a service activity would last  
  
-   What resources are available for the service activity, like users, facilities, or equipment  
  
> [!NOTE]
> A service requires at least one selection rule and one or more resources, resource groups, or teams before the service can be scheduled with a service activity.

## Create or change a service
  
Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.

1. In the Customer Service Hub sitemap, go to **Service Scheduling**.
2. From the list of entity records, select **Scheduling > Service**.
   - The **Active Services** view is displayed. You can switch between various system views using the drop-down.
   - Select **Show Chart** in the command bar to see the chart view.
   - Select any existing service to see additional options in the command bar

3. On the command bar, select **New** to create a new service. To edit a service, open a service from the list.  
  
4. In the **General** section, enter a **Name** and **Description** to reflect the specifics of the service and describe what the service is. </br> Also, specify the initial status of the service activity when it is created. If your organization prefers to approve all service activities before committing them to the schedule, you can select **Requested** or **Tentative**.

5. Under **Scheduling**, in **Default Duration**, select how long the service lasts. This can be changed when the service activity is created. 

   > [!NOTE]
   > The maximum duration of an appointment or service activity is 10 days.

6. In **Start Activities Every**, select how often service activities can start. This allows the start times of service activities to be staggered.
  
7. In **Beginning At**, select the time when the service activities must begin.
  
8.  In the **Required Resources** area, define a selection rule:  
  
    1.  Choose a selection rule in the right-hand pane.  
  
         Selection rules appear in the tree beside the **Selection Rule** button ![Gear button](../customer-service/media/crm-ua-selection-rule-gear.gif "Gear button").  
  
    2.  Choose one of the items under **Common Tasks** to define the selection rule by indicating how many resources are required and in what combination. 
  
 **Add a Selection Rule**  
  
   You can add complexity to a rule by adding a subrule to it.  
  
 **Add Resources**  
  
   Add users, facilities, equipment, or teams as resources to a selection rule.  
  
 **Add Resource Groups**  
  
   Resource groups are users, facilities, or equipment that can be scheduled interchangeably.  
  
   > [!NOTE]
   >  You can save a service without defining a selection rule, but you won’t be able to schedule that service.   
   >  More information: [Create or edit a selection rule](create-simple-selection-rule.md)  
  
7.  When you’re ready to save your data, click **Save**. A new resource category is created and is activated by default. 
  
## Activate or deactivate a service  
 You can make a service available on unavailable for scheduling by activating or deactivating it. To do this, in the list of service records, select a service, then select **Activate** or **Deactivate** in the command bar.  

## Test your service  
 Before you start using a service, test it. Create a service activity with no criteria other than the service. You can use the results to confirm that the service is selecting correctly. The message bar will also display any problems with the search.  
  
1.  In the Customer Service hub sitemap, select **Scheduling** > **Service Activity**. This bypasses the scheduling form.  
  
2.  Select the service to test.  
  
3.  Select **Find Available Times**. 
  
### See also  
 [Set the capacity required for a service or resource](set-capacity-required-service-resource.md)   
 [Create or change a resource group](create-edit-resource-group.md)   
 [Set work hours for a resource](set-work-hours-resource.md)
