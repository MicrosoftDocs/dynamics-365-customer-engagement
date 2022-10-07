---
title: "Create a work order in Dynamics 365 Field Service (contains video) | Microsoft Docs"
description: Learn how to create a work order in Dynamics 365 Field Service
ms.date: 08/26/2022
ms.reviewer: mhart
ms.topic: article
author: jasonccohen
ms.author: jacoh
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Create a work order to coordinate and schedule resources and activities

A work order in Dynamics 365 Field Service has information on what work needs to be done. Work orders are used to coordinate and schedule resources and activities. They can be used for different types of work, such as installations, repairs, or preventive maintenance.  
  
A work order is often created from a case or an opportunity. It gets scheduled either manually or using the schedule assistant and then dispatched. Once the work is complete, it's reviewed and approved by a manager.  

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4ynSf]

For more Field Service videos, go to [this full video playlist](https://aka.ms/fs-videos).

## Work order lifecycle  
  
- **Work order creation**: A work order is created, usually from a case or opportunity.  
  
- **Schedule**: The work order is scheduled.  
  
- **Dispatch**: The work order is dispatched.  
  
- **Service**: The work order is performed and details are updated.  
  
- **Review/Approval**: The work order is reviewed and approved by a supervisor.  
  
- **Invoice and inventory adjustment**: Inventory adjustments are made, and an invoice is generated for the corresponding account.  

:::image type="content" source="./media/work-order-lifecycle.png" alt-text="Work order lifecycle in Dynamics 365 Field Service.":::  
  
|  | Create | Schedule | Dispatch | Service | Review | Invoice |  
|-|-|-|-|-|-|-|  
|**What happens**|New work order is created.<br /><br /> Assigned incident, product, services, skills, territory, etc.| Work order schedule is created.<br /><br /> Resources assigned to the work order.<br /><br /> Date and time specified.|Field agent notified of work order.<br /><br /> Field agent may review and accept/decline the work order.| Work order is carried out.<br /><br /> Information about what is performed in the field is entered through the mobile app.|Supervisor verifies that all the work was done properly, and that all information regarding the work order is correct.|Invoice is created based on products and services used.<br /><br /> Inventory adjustments are made.<br /><br /> Products converted into equipment (if applicable)|  
|**Who performs the task**|Agreement is automatically generated on a recurring basis.<br /><br /> Case: By customer support.<br /><br /> Opportunity: By sales/scheduling.<br /><br /> Unplanned: By field agent or centralized scheduling.|Dispatcher<br /><br /> Field Agent<br /><br /> Dispatcher with help of scheduling assistant<br /><br /> Routing engine|Notification, if set up, sent by system automatically to field agent, customer, and other parties. |Field agent|Field supervisor/manager,<br /><br /> back-office accounting|Automatically sent by system|  
|**Work order status**|Open - unscheduled|Open - scheduled|Open - scheduled|Open - unscheduled, then open-completed|Open - completed then closed-posted|Closed-posted|  
|**Work order schedule status**|N/A|Scheduled|Scheduled|Scheduled<br /><br /> Accepted/Declined<br /><br /> Custom Status|Completed|Completed|  
  
## Create a work order

You can create a work order quickly from the Get Started page and from the Work Order list.

### From the Get Started page

1. As a Field Service administrator or system administrator in the **Field Service** app, go to the **Get Started** page.

   :::image type="content" source="media/get-started.png" alt-text="Screenshot of the getting started page in Field Service.":::  

1. Select **Create** in the **Create your work orders** section.

1. Fill in the basic information about the work order.

   :::image type="content" source="media/get-started-wo.png" alt-text="Screenshot of the new work order form triggered from the get started page in Field Service.":::

1. In the form, add as many tasks, products, and services as needed.

1. If you want to immediately schedule the work order, select **Save & Book**. Select **Save & Close** to only save the work order.

### From the work order form and record list

1. Go to **Field Service** > **Service** > **Work Orders**.

1. Select **+New**.

   :::image type="content" source="media/create-new-work-order-list.png" alt-text="Screenshot of the active work orders list in Field Service.":::

1. At a minimum, enter information in the following required fields.

    - For **Service Account**, select an account from the list or [create a new service account](work-order-customer-account.md#create-a-service-account).
    - For **Work Order Type**, select a work order type from the list or [create a new work order type](create-work-order-types.md).
    - For **System Status**, select **Open-Unscheduled**.
    - For **Price List**, select a price list from list or [create a new price list](create-price-list.md).
    - Set **Taxable** to **No**.
  
   :::image type="content" source="media/quickstart-work-order-new2.png" alt-text="Screenshot of a work order in Field Service.":::
  
1. Provide optional information for the work order as applicable. Service tasks, products, or services are added later.
  
1. Select **Save** or **Save and close**.

## Add service tasks, products, or services to the work order  

When the work order has been created and saved, you can then add any related tasks, products, or services to the work order.  
  
- Go to the **Service Tasks** section and select **+Add Work Order Service Task record**. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)] For more information, see [Set up service task types](../field-service/set-up-service-task-types.md).
  
- Go to the **Products** or **Services** section and select the **+**  button. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)] For more information, see [Create a product or service](../field-service/create-product-or-service.md).
  
  > [!NOTE]
  > When you add a product, remember that if you want to reserve a product for the work order, set **Allocated** to **Yes**.  

Consider using incident types to add more details and instructions to your work orders. For more information, see [Configure incident types](configure-incident-types.md).

## Work order user interface settings

### Open work order subgrids as popup dialog boxes

Configure work order subentities to pop out as dialog boxes and edit them without having to leave the work order form. This configuration helps dispatchers maintain context through navigation.

> [!div class="mx-imgBorder"]
> ![Screenshot of a popout work order product creation form.](./media/work-order-mfd-wop.png "Screenshot of a popout work order product creation form.")

From the Field Service app, change to the **Settings** area. Go to **Field Service Settings** > **Other** and set the **Work Order Subgrid Records Open as Popups** field to **Yes**.

Popup navigation will now be enabled when the following entities are selected from a work order:

- Work order product
- Work order service
- Work order service task
- Work order incident
- Bookable resource booking
- Time entry

> [!NOTE]
> This feature is available in Unified Interface only.

### Show simplified work order commands

In the Field Service 2021 release wave 2 update (8.8.47+), the work order ribbon is simplified upon upgrade because a new Field Service setting called **Show Simplified Work Order Commands** is set to **Yes** by default.

:::image type="content" source="media/work-order-ribbon-setting.png" alt-text="Field Service settings showing the Show Simplified Work Order Commands option.":::

The ribbon on the work order form, work order list, and when a record is selected on the work order list show a reduced number of commands.

:::image type="content" source="media/work-order-ribbon-enabled.png" alt-text="Work order commands with the Show Simplified Work Order Commands set to Yes.":::

Check out the following video on simplified work order commands, ability to turn price calculations on and off, and more 2021 release wave 2 updates to the work order.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWP4vU]

To show the full list of ribbon commands on the work order form, work order list, and when a record is selected on the work order list, update the setting. Open the **Settings** area and go to **Field Service Settings** > **Work Order / Bookings** and set the **Show Simplified Work Order Commands** field to **No**.

:::image type="content" source="media/work-order-ribbon-disabled.png" alt-text="Work order commands with the Show Simplified Work Order Commands set to No.":::

## Additional notes

The Get Started work order create form doesn’t support switching forms. If added as a form to other parts of the app, switching to this form will leave you unable to switch back.

Products, service tasks, and characteristics are added automatically when you create a work order from an incident. Otherwise, you can add them manually when you create a work order.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
