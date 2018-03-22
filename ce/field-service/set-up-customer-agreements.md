---
title: "Set up customer agreements (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: 5a02d87a-56f4-47e8-ab2d-5d816e60dc8a
caps.latest.revision: 21
ms.author: "mkaur"
manager: "amyla"
---
# Set up customer agreements so you can automatically generate work orders and invoices (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

An agreement in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] provides the framework to automatically generated work orders and invoices. They are ideal for preventative maintenance-type work.  
  
 An agreement allows you to choose how often work orders will be generated (for example, daily, weekly, monthly, or yearly) and the details of the work order (such as incidents, products, services, and service tasks).  
  
 **Tips**:  
  
-   A single agreement can have numerous agreement schedules. As an example, you may create an agreement schedule called "Weekly Visits" that creates work orders every week with specified incidents, products, services, and service tasks. Additionally, within the same agreement, you may have another agreement scheduled titled "Monthly Visits" that creates work orders every month with different incidents, products, services, and service tasks.  
  
-   The price list on the agreement specifies the price of all products and services related to an agreement. It is important to add all products and services that will be used during the agreement to the agreement price list. Agreements usually contain a negotiated price for goods and services that are usually reflected in an entirely new price list.  
  
-   Though the agreement provides a framework to generate work orders, details can still be edited at the work-order level. As an example, though a work order may be generated from an agreement, more products and services can be added to the work order "ad hoc", and other details, such as price list and work order type, can be changed, assuming sufficient permissions.  
  
<a name="BKMK_CreateAgreement"></a>   
## Create an agreement  
  
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
  
<a name="BKMK_DefineBookingSetup"></a>   
## Define booking setup  
 Once the agreement has been created, specify how often work orders are generated.  
  
1.  In the **Booking Setups** section, click **+Add Booking Setup record**.  
  
2.  Fill in your information to create the agreement schedule. Use the handy tooltips as a guide.  
  
    - **Auto Generate Work Order** helps you decide if you want the system to automatically generate work orders. The system will generate work orders on a rolling basis. Generated work orders will appear in the active work order view with a status of open-unscheduled. If set to **No**, you have to manually generate the work order for each schedule date.  
  
        > [!NOTE]
        >  If you choose not to auto generate the work orders, you can go to the agreement booking dates and manually generate the work orders.  
  
    -   Given that the system is automatically generated work orders, do you want   it to schedule those work orders as well? If so, mark **Auto Generate Booking** as **Yes** and choose a preferred resource and start time. When the work order is generated, the system will also schedule it, creating a work order schedule and displaying it on the schedule board.  
  
    -   If you choose to have the system auto-generate work orders, then choose how many days in advance to **Generate Work Order Days in Advance**. If you choose a large number of days in advance, you may have a lot of work orders just sitting there, but if you choose too few days in advance, you may not have time to prepare.  
  
    - **Pre Booking Flexibility** and **Post Booking Flexibility** fields specify how many days before and after the anticipated schedule date thee work order is allowed to be scheduled. These will populate the **Time Window Start** and **Time Date Window End** fields that aid the schedule assistant.  
  
    -   The **Priority** will pass down to every work order that is generated from this agreement schedule.  
  
    -   The **Work Order Summary** will pass down to every work order that is generated from this agreement schedule.  
  
    -   If you configure the agreement to automatically generate bookings, then choose a:  
  
        - **Preferred Resource**: for the work order.  
  
        - **Time Window Start** and **Time Window End** can be specified to create a time window for generated work orders, and will be taken into account by the schedule assistant. (Example: Work Order should be scheduled between 8 a.m. and 12 p.m.)  
  
3.  To set up a recurring booking for this agreement, on the command bar at the top, click **Booking Recurrence**, specify the recurrence, and then click **Save**.  
  
4.  When you are done, click **Save**. This will automatically generate the agreement booking dates within 24 hours.  
  
5.  To add incidents to the agreement booking setup, click **+Add Agreement Booking incident record**.Use the tooltips as a guide to specify the incident details, and then click **Save & Close**.  
  
6.  To add agreement booking dates, click **+Add Agreement Booking Date record**  
  
    -   Use the tooltips as a guide to specify the booking date details and then click **Save & Close**.  
  
    -   There is a field on the incident type record called **Copy incident item to agreement** and if marked **Yes**, then when you link the incident to the agreement booking setup then all service task, products, and services that are associated with the incident will be copied to agreement booking setup. If you need to make changes to service tasks, products, or services you can do so from the service task, product, and services section within the agreement booking setup record. This information is automatically copied over to any work order that is created for the agreement booking setup.  
  
         If copy incident item to agreement is marked, **No** then the information is not copied over from the agreement booking setup but rather when work orders are created the service tasks, products, and services will inherited directly from the incident type service task, products, and services.  
  
<a name="BKMK_AddInvoiceSetup"></a>   
## Add invoice setup  
 Automatic billing invoices are generated at a set recurrence for a set price. The customer is billed for a product in the system. You can use this to bill customers for subscriptions, rental fees, and retainer services.  
  
1.  In the **Invoice Setups** section, click **+Add Agreement Invoice Setup record**. Fill in your information. Use the handy tooltips as a guide.  
  
2.  To set up an invoice recurrence for this invoice setup, on the command bar at the top, click **Invoice Recurrence**. Specify the recurrence details and then click **Save**. When you have recurrence set up the system will generate invoices on a rolling basis.  
  
    > [!NOTE]
    >  The invoice will generate in advance depending on what you have set in the **Generate Agreement Invoices X Days in Advance** field in the **Field Service Administration** settings under the **Agreement** section. This means the invoice due date is set based on your recurring invoice setup but it will be created `x` days in advance.  The generate invoice date setting does not override your invoice recurrence, that you specified in step 2.  
  
3.  Click **Save**.  
  
4.  In the **Invoice Product** section, click **+Add Agreement Invoice Product record**. The products will be added to your invoice at the time the invoice is generated.  
  
### See also   
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Set up agreement sub-statuses](../field-service/set-up-agreement-sub-statuses.md)   
 [Set up tax codes](../field-service/set-up-tax-codes.md)   
 [Set up payment terms](../field-service/set-up-payment-terms.md)<br>
 [User's Guide](../field-service/user-guide.md)
