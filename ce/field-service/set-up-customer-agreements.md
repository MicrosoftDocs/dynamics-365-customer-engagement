---
title: "Set up customer agreements (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 07/23/2019
ms.reviewer: krbjoran
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
ms.assetid: 5a02d87a-56f4-47e8-ab2d-5d816e60dc8a
caps.latest.revision: 21
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Set up agreements to automatically generate work orders and invoices

Field Service Agreements allow organizations to automatically generate work orders and invoices with predefined details, frequency, and date range. Agreements are most commonly used for maintenance schedules where an organization must perform daily, weekly, or monthly inspections on equipment. 

Here are a few different ways agreements can be configured and utilized. The agreement generates:

- daily inspection work orders that dispatchers schedule via the schedule board or schedule assistant
- monthly maintenance work orders that are automatically scheduled by Resource Scheduling Optimization
- weekly work orders where the agreement assigns the same resource each time at a defined start time
- a single work order each month to inspect multiple customer assets at a customer location 
- multiple work orders each year to inspect multiple assets at a customer location
- quarterly invoices to bill customers for predefined products and services

To use agreements, first create the **Agreement**. This is where you'll define high level details such as the customer, date range, and price list. Next create an **Agreement Booking Setup** where you'll define how often work orders should be created for the agreement along with basic details of the eventual work orders like Work Order Type. After that, you'll add **Agreement Incidents, products, services, and service tasks** that define the specific details of the work to be performed as part of each work order that is generated. Finally, you'll **activate** the agreement and Agreement Booking Dates will be created along with work orders as the date approaches.

Let's walk through two scenarios to show how agreements can create work orders and invoices.

## Prerequisites
Field Service v6.1+

This article assumes you have work order related data such as accounts, incident types, products, services, and service tasks configured in your system. 

Consider specifying an agreement prefix and start number (optional). Go to **Field Service > Settings** then the Agreement section.

Enter an **Agreement Prefix** and **Agreement Starting Number**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-field-service-settings.png)

Doing so will dictate the Agreement Number when a new agreement is created. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-custom-prefix.png)


## Scenario 1: auto generate work orders for asset maintenance

An organization must perform monthly maintenance on a piece of equipment they installed at a customer's location for the next two years. They would like to use Dynamics 365 for Field Service to automatically generate the maintenance jobs in the middle of each month with some flexibility. They would like dispatchers to schedule the monthly maintenance jobs to the best and most appropriate field technicians and bill the customer for completed work at an agreed upon price.   

We will use agreements along with customer assets, incident types, and price lists to configure this scenario. 

### Step 1: Create an agreement

1.  From the main menu, click **Field Services** > **Agreements**.  
  
2.  On the **Active Agreements**> screen, choose **+New**.  
  
3.  Fill in your information. Use the handy tooltips as a guide.  
  
    - **Summary**.  
  
        - **General**: Fill in the basic information regarding the agreement, such as where the agreement work order will take place, and which account the bills will to got.  
  
            > [!NOTE]
            >  For the agreement option to be active in the system, and create agreement booking dates or agreement invoice dates, the agreement must be active. To do this make sure **System Status** for the agreement is set to **Active**.  
  
        - **Details**: Enter the start and end dates of the agreement  
  
    - **Settings**:  
  
        - **General**: Add a price list that control the price for products and services used in the agreement. Enter the work order service territory  
  
4.  Click **Save**.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-create.png)


### Step 2: Set up booking recurrence

Once the agreement has been created, specify how often work orders are generated.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-create-booking-setup.png)

  
1.  In the **Booking Setups** section, click **+Add Booking Setup record**.  
  
2.  Fill in your information to create the agreement schedule. Use the handy tooltips as a guide.  
  
    - **Auto Generate Work Order** helps you decide if you want the system to automatically generate work orders. The system will generate work orders on a rolling basis. Generated work orders will appear in the active work order view with a status of open-unscheduled. If set to **No**, you have to manually generate the work order for each schedule date.  
  
        > [!NOTE]
        >  If you choose not to auto generate the work orders, you can go to the agreement booking dates and manually generate the work orders.  
  
    -   Given that the system is automatically generated work orders, do you want   it to schedule those work orders as well? If so, mark **Auto Generate Booking** as **Yes** and choose a preferred resource and start time. When the work order is generated, the system will also schedule it, creating a work order schedule and displaying it on the schedule board.  
  
    -   If you choose to have the system auto-generate work orders, then choose how many days in advance to **Generate Work Order Days in Advance**. If you choose a large number of days in advance, you may have a lot of work orders just sitting there, but if you choose too few days in advance, you may not have time to prepare.  
  
    - **Pre Booking Flexibility** and **Post Booking Flexibility** fields specify how many days before and after the anticipated schedule date thee work order is allowed to be scheduled. These will populate the **Date Window Start** and **Date Window End** fields that aid the schedule assistant.  
  
    -   The **Priority** will pass down to every work order that is generated from this agreement schedule.  
  
    -   The **Work Order Summary** will pass down to every work order that is generated from this agreement schedule.  
  
    -   If you configure the agreement to automatically generate bookings, then choose a:  
  
        - **Preferred Resource**: for the work order.  
  
        - **Time Window Start** and **Time Window End** can be specified to create a time window for generated work orders, and will be taken into account by the schedule assistant. (Example: Work Order should be scheduled between 8 a.m. and 12 p.m.)  
  
3.  To set up a recurring booking for this agreement, on the command bar at the top, click **Booking Recurrence**, specify the recurrence, and then click **Save**.  
  
4.  When you are done, click **Save**. This will automatically generate the agreement booking dates within 24 hours.  
  
5.  To add incidents to the agreement booking setup, click **+Add Agreement Booking incident record**. Use the tooltips as a guide to specify the incident details, and then click **Save & Close**.  
  
6.  To add agreement booking dates, click **+Add Agreement Booking Date record**  
  
    -   Use the tooltips as a guide to specify the booking date details and then click **Save & Close**.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-booking-setup.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-booking-recurrence.png)


### Step 3: Add agreement work details


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-incident.png)


### Step 4: Activate agreement and view work orders

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-incident-items.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates-annotation.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates-details-work-order.png)




### Step 5: Perform agreement work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-work-order-summary.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-work-order-settings.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-schedule-assistant-filters.png)

invoices are created at close posting of work orders which is true whether work orders are part of an agreement or not.

## Scenario 2: auto generate invoices

Agreement invoices are used to automatically generate invoices for predefined products and services. The invoices are generated regardless of the work orders performed. As an example, let's configure the scenario where a customer pays a field service organization a quarterly amount for a service plan, similar to how you may pay a monthly cell phone bill regardless of the number of phone calls or texts you send. 


### Step 1: Create an agreement or select an existing one

You can add an agreement invoice to an existing agreement or add it to a new one. You can have an agreement with only an agreement invoice and no maintenance plan and even have multiple invoices for a single agreement.

In our example, we will add quarterly invoices to the agreement we just created. 

From the agreement, go to **Invoice Setup > Add New Agreement Invoice Setup**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-create-recurrence.png)


### Step 2: Set up invoice recurrence and products


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-setup-header.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-recurrence-pattern.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-add-products.png)


[only inventory or non inventory can be added]

[price list]

### Step 3: Activate invoice recurrence and view invoices
Because this agreement is already Active, the invoices will be eligible


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-dates.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-invoice-dates-generated.png)




> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-field-service-settings-invoice.png)

if no date is entered, when will invoices be generated



Automatic billing invoices are generated at a set recurrence for a set price. The customer is billed for a product in the system. You can use this to bill customers for subscriptions, rental fees, and retainer services.  
  
1.  In the **Invoice Setups** section, click **+Add Agreement Invoice Setup record**. Fill in your information. Use the handy tooltips as a guide.  
  
2.  To set up an invoice recurrence for this invoice setup, on the command bar at the top, click **Invoice Recurrence**. Specify the recurrence details and then click **Save**. When you have recurrence set up the system will generate invoices on a rolling basis.  
  
    > [!NOTE]
    >  The invoice will generate in advance depending on what you have set in the **Generate Agreement Invoices X Days in Advance** field in the **Field Service Administration** settings under the **Agreement** section. This means the invoice due date is set based on your recurring invoice setup but it will be created `x` days in advance.  The generate invoice date setting does not override your invoice recurrence, that you specified in step 2.  
  
3.  Click **Save**.  
  
4.  In the **Invoice Product** section, click **+Add Agreement Invoice Product record**. The products will be added to your invoice at the time the invoice is generated.  



## Configuration considerations


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-field-service-settings.png)

record generation time is time of user who set the setting? or time of user who created the agreement?


Agreement with multiple incident types


Agreement with multiple recurrences

Schedule agreement work orders with RSO

using invoices and work orders on same agreement?

entitilements/SLAs?

location/account

## Additional Notes

agreements work with the sales  opp quote order process

Generate agreement start time 



generate agreement dates x months - use those to understand work

copy incident items to agreement -   There is a field on the incident type record called **Copy incident item to agreement** and if marked **Yes**, then when you link the incident to the agreement booking setup then all service task, products, and services that are associated with the incident will be copied to agreement booking setup. If you need to make changes to service tasks, products, or services you can do so from the service task, product, and services section within the agreement booking setup record. This information is automatically copied over to any work order that is created for the agreement booking setup. If copy incident item to agreement is marked, **No** then the information is not copied over from the agreement booking setup but rather when work orders are created the service tasks, products, and services will inherited directly from the incident type service task, products, and services.  

 when are items copied to agreements? on add or on activate?

an agreement can only be for a single location - yes

what about the characteristics of the agreement incident

what can you do after activating a work order?

quote invoice as a substitute

you cannot manually generate agreement invoices like you can with agreement work orders

**Tips**:  
  
-   A single agreement can have numerous agreement schedules. As an example, you may create an agreement schedule called "Weekly Visits" that creates work orders every week with specified incidents, products, services, and service tasks. Additionally, within the same agreement, you may have another agreement scheduled titled "Monthly Visits" that creates work orders every month with different incidents, products, services, and service tasks.  
  
-   The price list on the agreement specifies the price of all products and services related to an agreement. It is important to add all products and services that will be used during the agreement to the agreement price list. Agreements usually contain a negotiated price for goods and services that are usually reflected in an entirely new price list.  
  
-   Though the agreement provides a framework to generate work orders, details can still be edited at the work-order level. As an example, though a work order may be generated from an agreement, more products and services can be added to the work order "ad hoc", and other details, such as price list and work order type, can be changed, assuming sufficient permissions.  

  
### See also   

