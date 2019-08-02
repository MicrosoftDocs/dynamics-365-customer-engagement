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

From the main menu, click **Field Services** > **Agreements** > **+New**.  
  
Fill in your information. Use the handy tooltips as a guide.  
    
**Service Account & Billing Account** - Fill in the basic information regarding the agreement, such as where the agreement work order will take place, and which account the invoices will go to.  

**System Status** - defines if the agreement is currently being executed. Set to **Estimate** while building a new agreement and adding details. We will set to **Active** later on when the details are set and we are ready to begin agreement work orders or invoices.

**Start & End dates** - define the duration of the agreement.
  
**price list** - controls the price list populated on work orders and invoices generated from this agreement and effectively work order product, work order service, and invoice product and invoice service prices. It is recommended to add the relevant products and services to the price list with the agreed upon prices to the price list entered here. Because agreements typically involve negotiation, it is common to create a specific price list solely for this agreement. The price list on resulting work orders and invoices can be manually updated as needed.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-create.png)

In the Other tab you can enter more details such as the **Service Territory** resulting work orders should be part of, and **Record Generation Time** which dictates the time of day work orders, invoices, and other records related to this agreement should be generated. This is important because some organizations do not want agreements creating work orders in the middle of the working day. 

Finally, **Save**.  

### Step 2: Set up booking recurrence

Once the agreement has been created, specify how often work orders are generated.  

In the **Booking Setups** section, click **+Add Booking Setup record**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-create-booking-setup.png)

Fill in your information to create the agreement schedule. Use the handy tooltips as a guide.

**Name** - enter the name of the agreement schedule. An example is "Montlhy Maintenance". Naming is important because an agreement can have multiple booking recurrences. As an example, the service organization may perform weekly and monthly maintenance as part of the same agreement.

### Work Order Settings  

**Auto Generate Work Order** - set to **Yes** to have this agreement automatically generate work orders. The system will generate work orders on a rolling basis. Generated work orders will appear in the active work order view with a status of open-unscheduled. If set to **No**, you have to manually generate the work order for each schedule date.   

**Generate Work Orders Day in Advance** - dictates how many days before the expected service date the work order will be generated. If you choose a large number of days in advance, you may have a lot of work orders just sitting there, but if you choose too few days in advance, you may not have time to prepare.
 
**Work Order Type**, **Priority**, **Work Order Summary**, and **Work Location** entered here are passed down to resulting work orders.

### Booking Settings

-   **Auto Generate Booking** - set to **Yes** to have the system book generated work orders (regardless of auto generated or manually generated). If set to Yes, you must specify a resource and time for the booking. If set to **No** the generated work orders must be scheduled via the normal scheduling process: manually, with the schedule assistant, or with resource scheduling optimization. 

> [!Note]
> Bookings made by agreements will not consider existing bookings, meaning it will double book on top of exisitng schedules.
  
-   If you choose to have the system auto-generate work orders, then choose how many days in advance to **Generate Work Order Days in Advance**.   
  
- **Pre Booking Flexibility** and **Post Booking Flexibility** fields specify how many days before and after the anticipated schedule date thee work order is allowed to be scheduled. These will populate the **Date Window Start** and **Date Window End** fields that aid the schedule assistant.  
  
-   The **Priority** will pass down to every work order that is generated from this agreement schedule.  
  
-   The **Work Order Summary** will pass down to every work order that is generated from this agreement schedule.  
  
-   If you configure the agreement to automatically generate bookings, then choose a:  
  
- **Preferred Resource**: for the work order.  
  
- **Time Window Start** and **Time Window End** can be specified to create a time window for generated work orders, and will be taken into account by the schedule assistant. (Example: Work Order should be scheduled between 8 a.m. and 12 p.m.)  
  
1.  To set up a recurring booking for this agreement, on the command bar at the top, click **Booking Recurrence**, specify the recurrence, and then click **Save**.  
  
2.  When you are done, click **Save**. This will automatically generate the agreement booking dates within 24 hours.  
  
3.  To add incidents to the agreement booking setup, click **+Add Agreement Booking incident record**. Use the tooltips as a guide to specify the incident details, and then click **Save & Close**.  
  
4.  To add agreement booking dates, click **+Add Agreement Booking Date record**  
  
    -   Use the tooltips as a guide to specify the booking date details and then click **Save & Close**.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-booking-setup.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-booking-recurrence.png)


### Step 3: Add agreement work details


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-incident.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-incident-items.png)


### Step 4: Activate agreement and view work orders



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates-annotation.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates-details.png)




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

if no date is entered, when will invoices be generated - day of date at record generation time



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

record generation time is time of user 


Agreement with multiple incident types
- how are you tracking assets - if one asset for a work order you can ensure all time spent on that work order was for that asset
- multiple people 


Agreement with multiple recurrences
- if youre doing something monthly, quartlery, and yearly, multiple recurrences

Schedule agreement work orders with RSO
- make sure the requirements of generated work orders are set to optimize. this can be achieved with a workflow, or by default for all work flows. 

using invoices and work orders on same agreement?
- could be the same
- pay cell phone whether make calls or not

entitilements/SLAs?
- pre and bost bookings are effectively your SLA
- dont bill for work orders from the agreement by setting up entitlement at the incident type level because organizations commonly create incident types specifically for agreements. can be done with price list.


location/account

## Additional Notes

agreements work with the sales opp quote order process. 
- service-maintenance based lead
- opportunity > opportunity lines with service based lines > monthly maintenance and start and end date 
- (can go straight to quote) quote > quote lines (service based lines) > quote booking setup > won > order > active agreement

if no number is entered, when will invoices be generated? day of at record generation

if no number is entered, when will work orders be generated? day of at record generation

generate agreement dates x months - use those to understand work

if generate WO is no and generate booking is yes, booking will happen when WO is generated.

copy incident items to agreement -   There is a field on the incident type record called **Copy incident item to agreement** and if marked **Yes**, then when you link the incident to the agreement booking setup then all service task, products, and services that are associated with the incident will be copied to agreement booking setup. If you need to make changes to service tasks, products, or services you can do so from the service task, product, and services section within the agreement booking setup record. This information is automatically copied over to any work order that is created for the agreement booking setup. If copy incident item to agreement is marked, **No** then the information is not copied over from the agreement booking setup but rather when work orders are created the service tasks, products, and services will inherited directly from the incident type service task, products, and services.  

 when are items copied to agreements? on add or on activate? looks like on add. what about when no? asynchronous 

an agreement can only be for a single location - yes

what about the characteristics of the agreement incident

what can you do after activating an agreement?

quote invoice as a substitute

you cannot manually generate agreement invoices like you can with agreement work orders

agreement sub status note

can pick an incidet type with requirement groups for an agreemnt

changing booking recurrence will update booking dates   

**Tips**:  
  
-   A single agreement can have numerous agreement schedules. As an example, you may create an agreement schedule called "Weekly Visits" that creates work orders every week with specified incidents, products, services, and service tasks. Additionally, within the same agreement, you may have another agreement scheduled titled "Monthly Visits" that creates work orders every month with different incidents, products, services, and service tasks.  
  
-   The price list on the agreement specifies the price of all products and services related to an agreement. It is important to add all products and services that will be used during the agreement to the agreement price list. Agreements usually contain a negotiated price for goods and services that are usually reflected in an entirely new price list.  
  
-   Though the agreement provides a framework to generate work orders, details can still be edited at the work-order level. As an example, though a work order may be generated from an agreement, more products and services can be added to the work order "ad hoc", and other details, such as price list and work order type, can be changed, assuming sufficient permissions.  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/agreement-active-booking-dates-details-work-order.png)
  
### See also   

