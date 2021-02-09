---
title: Create or edit a service | Microsoft Docs
description: Create or edit a service in Dynamics 365 Customer Service.
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/05/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Create or edit a service

To make scheduling services quick and easy, it’s helpful to predefine the specifics of the services you’d provide to customers. By using the service records in Dynamics 365 Customer Service, you can define: 

- How long a service activity lasts 

- What resources are available for the service activity, like users, facilities, or equipment 

A service requires at least one selection rule and one or more resources, resource groups, or teams before the service can be scheduled with a service activity.

## Create or change a service

1. Make sure that you have the Manager, Vice President, CEO-Business Manager, System Administrator, or System Customizer security role or equivalent permissions. 

2. Sign in to **Customer Service Hub**, and then select the **Scheduling** tab. 

3. Select **Services**.
  
   ![Select Services](media/uci-services-navigation.png "Services selection on the left-hand panel")

4. Do one of the following:
  - To create a new service, select **New**.
  
  - To edit a service, open a service from the list.

5. Type or modify information in the text boxes. 

    a. Under **General**, enter a name and description to reflect the specifics of the service and describes what the service is. Also, specify the initial status of the service activity when it is created. If your organization prefers to approve all service activities before committing them to the schedule, you can select **Requested** or **Tentative**.
    
    b. Under **Scheduling**, in **Default Duration**, select how long the service lasts. This can be changed when the service activity is created. The maximum duration of an appointment or service activity is 10 days. 

    c. In **Start Activities Every**, select how often service activities can start. This allows the start times of service activities to be staggered.
    
    d. In **Beginning At**, select the time when the service activities must begin.
  
   ![Edit scheduling details](media/uci-new-service.png "Edit scheduling details such as start times and duration")
   
6. On the **Required Resources** tab, define a selection rule.
  
   ![Define selection rule](media/uci-define-selection-rule.png "Define a selection rule on the Required Resources tab")
   
    |Option  |Description|
    |---------|---------|
    | Add a Selection Rule  | You can add complexity to a rule by adding a subrule to it. |
    | Add Resources | Add users, facilities, equipment, or teams as resources to a selection rule. |
    | Add Resource Groups | Resource groups are users, facilities, or equipment that can be scheduled interchangeably. |
    
    > [!Note]
    > You can save a service without defining a selection rule, but you won’t be able to schedule that service.
    
7. When you're ready to save your data, select **Save**.

## Activate or deactivate a service

You can make a service available or unavailable for scheduling by activating or deactivating it.
  
   ![Activate or deactivate service](media/uci-activate-deactivate-service.png "Activate or deactivate a service")


### See also  

[Unified Interface-based service scheduling overview](uci-scheduling-overview.md)

[Add facilities and equipment](uci-add-facilities-equipment.md)

[Schedule a service activity](uci-schedule-service-activity.md)

[Create resource groups](uci-create-resource-groups.md)

[Use sites to manage your service locations](uci-create-sites.md)

[Navigate the service calendar](uci-navigate-service-calendar.md)



    
    
