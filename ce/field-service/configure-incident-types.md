---
title: "Configure incident types (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/14/2019
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: krbjoran
ms.assetid: debef702-a12a-491c-8087-e7e4bdb14b19
caps.latest.revision: 16
ms.author: krbjoran
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Create work order templates with incident types

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Incident types act as service templates and allow users to quickly create work orders for the most common types of jobs that your company performs, including all of the necessary service tasks, products, services, required skills, and estimated work order duration.  
  
1. From the main menu, click **Field Service** > **Administration**, and then choose **Incident Type**.  
  
2. On the **Incident Type** screen, click **New** in the upper left corner.  
  
3. Name the incident type using the **Name** field.  
  
4. Use the **Description** field to add additional text describing the incident.  
  
5. Fill in the **Estimated Duration** for the length of the job.  
  
   > [!NOTE]
   >  Estimate Duration is set based on the total duration of all the service tasks on the incidents. The only way to set the duration manually on the incident is if the service tasks has no duration.  
  
6. Click **Save**.  
  
7. In the **Service Tasks** section, click **Add Incident Type Service Task record** to add a service task.  
  
8. In the **Product** section, click **Add Incident Type Product record** to add a product. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product or service](../field-service/create-product-or-service.md)  
  
9. In the **Service** section, click **Add Incident Type Service record** to add a service. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product or service](../field-service/create-product-or-service.md)  
  
10. In the **Notes** section, add any additional notes.  
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up territories](../field-service/set-up-territories.md)   
 [Create a work order](../field-service/create-work-order.md)   
 [Create work order types](../field-service/create-work-order-types.md)   
 [Set up work order sub-statuses](../field-service/set-up-work-order-sub-statuses.md)   
 [Set priorities](../field-service/set-priorities.md)   
 [Set up time groups](../field-service/set-up-time-groups.md)   
 [Set up service task types](../field-service/set-up-service-task-types.md)

## Introduction

Incident types are used to define the specific work order issue and the recommended prescription to resolve the issue. Whereas Work Order Types define the general category of a work order (inspection, repair, maintenance, etc), incident types define the specific request of a work order and effectively add more details to the work order type. 

As an example, an incident type can be:
- a specific error code on a machine; "Error code 0048"
- a common customer complaint or request; "The building temperature is too hot"
- a specific procedure; "Perform stress test"

Most importantly, adding an incident type to a work order can add other details such as duration and add related records including work order service tasks, work order products, work order services, and characteristics (skills). This means incident types can **effectively serve as work order templates** that pre-populate information, which can be manually edited as needed.

The value organizations get from using incident types is they codify issues, procedures, and resolutions and help standardize processes across geographies and business lines. This ensures all field technicians are performing the same actions to resolve work orders, and if better procedures are discovered, the incident type is updated and implemented across the entire organization. Another benefit is using incident types saves time creating work orders. Without using incident types, the customer service reps or dispatchers creating work orders would have to manually add the details. Consider the Connected Field Service scenario where IoT alerts create work orders. If you correlate IoT alerts with incident types, your organization can have a situation where IoT alerts create work orders with much of the details filled in.

Other important features of incident types are (1) multiple incident types can be added to a work order to define multiple issues or procedures that need to be completed (2) each incident type can be related to a customer asset to build service history and (3) relating incident types to requirement group templates allows you to auto-populate multiple requirements for a work order and schedule the work order to multiple resources.


 ## Prerequisites

 Incident types are available for all version of Field Service. However using incident types with requirement group templates for multi-resource scheduling is only available with Field Service v8.0+.

 Because incident types mostly represent a grouping of service tasks, products, and services, it is recommended to have these records created in the system before creating an incident type.

 A **service task** is checklist item that field technicians should complete as part of performing an incident type. 

 A **product** is a part that may be used when completing an incident type and can be billed to the customer and deducted from inventory if necessary.

 A **service** is labor that may be billed to the customer. **Note:** there is no Service entity. A service is created by creating a Product record with **Field Service Type = Service**. 

 To create these records, go to **Field Service > Settings**.

 > [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-incident-types-navigation.png)

The service tasks, products, and services you create will serve as the building blocks of incident types and can be associated to multiple incident types as needed. As an example, if "Put on safety goggles" is a service task that needs to be completed as part of many or all incident types, you simply create this service task once and associate it to the relevant incident types. This means there is one list of unique service tasks that are added to incident types and this creates **Incident Type Service Task** records.

 ## Create an incident type

 To create an incident type go to **Field Service > Settings > Incident Types > +New**

 Enter a **Name** and a **Description**.

 **Default Work Order Type** - the work order type selected here will populate the work order type field on the work order when this incident type is entered as the primary incident type. It will overwrite a previously entered work order type. This saves time and is convenient as an incident type should be related to a larger category. Entering a work order type will not populate an incident type.

> [!Note]
> **Pro Tip:** A default Price List can be added to a Work Order Type. THis means you can add a primary incident type that adds a work order type and the work order type will add a price list. this further saves time with automatic data population.

**Estimated Duration** - Enter a duration for this incident type. If you add multiple incidents to a work order, the work order duration will be the total of all incident durations as reflected in the duration of the resource requirement related to the work order. Service tasks can each have a duration as well, in which case the estimated duration of the incident type will be the sum total of the incident service task durations. The only way you can utilize the estimated duration field as the duration of the incident type is if 1) you do not add incident type service tasks or 2) none of the incident type service tasks you add have durations. If this incident type is set as the primary incident type of a work order this value will populate the primary incident type duration field.

**Copy Incident Items to Agreement** - This setting dictates if agreement "items" including service tasks, products, services, and characteristics (skills) should be added to the agreement when this incident is added to the agreement. This is important for two reasons.

  1. The incident you would like to add to an agreement may be slightly different than the incident you would add to a single work order that's not part of an agreement. As an example, normally the incident would require one hour of a service, but for the agreement, you negotiated with the customer two hours of a service. Imagine variations for all items making it better to start from scratch. Rather than having to create a second incident type just for this agreement, you can set Copy Incident Items to Agreement to **No**, add the incident to the agreement, then manually add the specific service tasks, product, services, etc. This way you can use the same incident type which helps for reporting later on. Set this option to **Yes** and the incident items will be added to the agreement and you can accept these items or make slight variations from there. 

  2. Incidents can be added to agreements for recurring work. This means agreements will generate work orders with predefined work order incidents attached. However, as mentioned earlier, incidents can be edited as processes and procedures change. But agreements can span multiple months and even years, so should the agreement use the original incident type at the time of agreement creation, or use the latest changes to the incident type? This could result in different work being performed at the end of the agreement than originally intended. Set to **Yes** if the incident should remain the same throughout the agreement life span by copying the incident details to the agreement at the time of agreement activation. Set to **No** if the work orders generated from the agreement should grab the latest incident type details when the work orders are generated from the agreement, which is generally at an ongoing basis depending on the **Generate Work Orders X Days In Advance** field on the Agreement Booking Setup. 


After setting basic details of the incident type, you should consider adding recommended products and services field technicians may need to complete the incident type, service tasks to guide field technicians through a check list of tasks, and characteristics (skills) that will help schedulers find the right resources to perform work orders this incident is added to. When this incident type is added to a work order, the related items will be added as well.

### Incident Type Product

Next add an incident type product by going to the product section and selecting **+New Incident Type Product**.

Select a **Product** and **Unit**

Enter a **Quantity**. This is the number of work order products that will be added to the work order when this incident is added. It can be manually overridden by the work order creator as needed. However, if for example, a process or procedure generally requires two units of a part to complete the job, you should enter 2 here.

Enter a **Name** if you want the eventual work order product to have a different name than the product name.

For scenarios where multiple products are added as part of an incident type, **Line Order** is a numeric value that can be used to define the order they appear in the work order product list. This is true for service tasks and service as well.

Because the **Description** field may be communicated to the customer or even be customized to appear on an invoice, there is also an **Internal Description** to add more details for the field technician to view.

### Incident Type Service

Similar to incident type products, add incident type services. 

The only difference is instead of quantity, there is a **Duration** field to represent the service time because a service represents labor and not a physical part. 

### Incident Type Service Tasks

Next go to Service Tasks and **+New Incident Type Service Task**.

Select a **Task Type** or create a new one in the system. 

If the task type you select has a duration, it will populate in the **Estimated Duration** field of the incident type service task and can be adjusted for this specific incident as needed. As you add incident service tasks, the duration of the incident type will be the sum of the service task durations. If you do not want the incident duration to be derived from service task durations, then you should either 1) set the incident service task duration to 0 minutes or null for all incident service task types or 2) consider removing durations from the original Task Type.

The order in which you add service task types is the order they will appear on the work orders when this incident is added. The order of service tasks is generally important for organizations and reflects a process that should be followed. It is common for organizations to have as many as 40 service tasks for a detailed process. After saving, you can edit the **Line Order** field as needed to change the order of service tasks where "1" is the service task that will appear first.

After adding multiple service tasks they will display in the incident service task list. In the example below, none of the individual service tasks was given an estimated duration because we chose to add an estimated duration at the incident type level instead.


### Incident Type Characteristics

Next, you can associate characteristics (skills) to incident types in order to define the skillset needed to perform such an incident type. Characteristics are also added to resources (field technicians) and this helps the system match work order incidents with the best resources who can do the job. This also means when this incident is added to a work order and scheduled, the schedule assistant and resource scheduling optimization will consider the characteristics.

> [!Note]
> If you want to utilize Requirement Groups with Incident Types for multi-resource scheduling, do not add characteristics (skills) to the incident type. Instead you should add required characteristics to the requirement group template. See the topic on [Requirement groups for Work Orders for more details](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/multi-resource-scheduling-requirement-groups#requirement-groups-for-work-orders)

Go to Characteristics and **+New Incident Type Characteristic**.

Select a **Characteristic** from the look up or create a new one.

Characteristics are a very versatile way to define the resource attributes needed to perform an incident types. 

Examples include:
- Skills; "JavaScript and HTML"
- Language proficiency; "Spanish"
- Certifications; "CPR certifications"
- Security clearance; "Building 12 access"

When characteristics are added to a resource, you can define the level of proficiency a resource 


Next, we are ready to use the incident type by adding it to a work order. From our incident type products, services, service tasks and characteristics, the system will create work order products, services, service tasks and characteristics.

 ## add an incident type to a work order

 ## add multiple incident types to a work order

 ## Use customer assets with incident types

 ## Incidents for multi-resource scheduling

## additional notes

- importing with excel


