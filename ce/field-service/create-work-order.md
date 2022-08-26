---
title: "Create a work order in Dynamics 365 Field Service (contains video) | Microsoft Docs"
description: Learn how to create a work order in Dynamics 365 Field Service
ms.date: 08/26/2021
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

A work order in Dynamics 365 Field Service has information on what work needs to be done. Work orders are used to coordinate and schedule resources and activities and can be used for different types of work, such as installations, repairs, or preventive maintenance.  
  
A work order is often created from a case or opportunity, and then scheduled either manually or using the schedule assistant and then dispatched. Once the work is complete, it's reviewed and approved by a manager.  

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4ynSf]

For additional Field Service videos, go to [this full video playlist](https://aka.ms/fs-videos).

## Work order lifecycle  
  
- **Work order creation**: A work order is created, usually from a case or opportunity.  
  
- **Schedule**: The work order is scheduled.  
  
- **Dispatch**: The work order is dispatched.  
  
- **Service**: The work order is performed and details are updated.  
  
- **Review/Approval**: The work order is reviewed and approved by a supervisor.  
  
- **Invoice and inventory adjustment**: Inventory adjustments are made, and an invoice is generated for the corresponding account.  

:::image type="content" source="../field-service/media/work-order-lifecycle.png" alt-text="Work order lifecycle in Dynamics 365 Field Service.":::  
  
|  | Create | Schedule | Dispatch | Service | Review | Invoice |  
|-|-|-|-|-|-|-|  
|**What happens**|New work order is created.<br /><br /> Assigned incident, product, services, skills, territory, etc.| Work order schedule is created.<br /><br /> Resources assigned to the work order.<br /><br /> Date and time specified.|Field agent notified of work order.<br /><br /> Field agent may review and accept/decline the work order.| Work order is carried out.<br /><br /> Information about what is performed in the field is entered through the mobile app.|Supervisor verifies that all the work was done properly, and that all information regarding the work order is correct.|Invoice is created based on products and services used.<br /><br /> Inventory adjustments are made.<br /><br /> Products converted into equipment (if applicable)|  
|**Who performs the task**|Agreement is automatically generated on a recurring basis.<br /><br /> Case: By customer support.<br /><br /> Opportunity: By sales/scheduling.<br /><br /> Unplanned: By field agent or centralized scheduling.|Dispatcher<br /><br /> Field Agent<br /><br /> Dispatcher with help of scheduling assistant<br /><br /> Routing engine|Notification, if set up, sent by system automatically to field agent, customer, and other parties. |Field agent|Field supervisor/manager,<br /><br /> back-office accounting|Automatically sent by system|  
|**Work order status**|Open - unscheduled|Open - scheduled|Open - scheduled|Open - unscheduled, then open-completed|Open - completed then closed-posted|Closed-posted|  
|**Work order schedule status**|N/A|Scheduled|Scheduled|Scheduled<br /><br /> Accepted/Declined<br /><br /> Custom Status|Completed|Completed|  
  
## Create a work order  

### From the get started page

1. As a Field Service administrator or system administrator in the **Field Service** app, go to the **Get Started** page.

> [!div class="mx-imgBorder"]
> ![Screenshot of the getting started page in Field Service.](./media/get-started.png "Screenshot of the getting started page in Field Service.")

2. Select **Create** in the **Create your work orders** section.

3. Fill in the basic information about the work order.

4. In the form, add as many tasks, products, and services as needed.

5. If you want to immediately schedule the work order, select **Save & Book**. Select **Save & Close** to only save the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of the new work order form triggered from the get started page in Field Service.](./media/get-started-wo.png "Screenshot of the new work order form triggered from the get started page in Field Service.")

### From the work order form and record list

Go to **Field Service** > **Service** > **Work Orders** > **+New**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the active work orders list in Field Service.](./media/quickstart-work-order-new.png "Screenshot of the active work orders list in Field Service.")

At a minimum, enter information in the following required fields.

- For **Service Account**, select an account from the list or create a new one.
- For **Work Order Type**, select a work order type from the list or create a new one. 
- For **System Status**, select **Open-Unscheduled**.
- For **Price List**, select a price list from list or create new one. 
- Set **Taxable** to **No**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order in Field Service.](./media/quickstart-work-order-new2.png "Screenshot of a work order in Field Service.")

  
- For **Summary**:  

  - **General**: Fill in the basic information regarding the work order, such as the work order number and the service account it’s associated with, a brief summary, and status, which can show whether the work order is unscheduled, scheduled, in progress, or finished.  
  - **Primary Incident**: Enter more information regarding the nature of the work to be performed.  
  - **Total**: Enter pricing information for the work order. This will show total pricing information for tasks, including products and services.  
  
- For **Settings**:  

  - **General**: Specify the category the work order may fall into. Also, fill in important information regarding the location of the work order, price list, service territory, and more.  
  - **Sales tax**: Sales tax can be added to the total amount of the work order based on work order details like service account, billing account, and work order type. The **Taxable** field will be set to yes if work order type is **Taxable** and the billing account is **Not Tax Exempt**. If the work order is taxable, a **Sales Tax Code** lookup field will display and inherit a value from the service account. It can also be updated manually.
  - **Preferences**: Enter the resource and time information for the work order.  
  - **Follow up**: Shows instructions of how to proceed if desired, or whether the work order calls for a follow-up.  
  - **Related to**: Specify if the work order is related to an originating work order or agreement.  
  - **Preferences**: Specify any preferred time windows.  
  - **Source**: Specify source information regarding the work order.  
- **Address**: The address where the work will be performed. The address should be inherited from the service account.  
- **Location**: Shows the address location on the map.  
  
Then choose **Save and close**.

## Add service tasks, products, or services to the work order  

When the work order has been created and saved, you can then add any related tasks, products, or services to the work order.  
  
- Go to the **Service Tasks** section and select **+Add Work Order Service Task record**. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)] For more information, go to this article: [Set up service task types](../field-service/set-up-service-task-types.md). 
  
- Go to the **Products** or **Services** section and select the **+**  button. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)] For more information, go to this article: [Create a product or service ](../field-service/create-product-or-service.md).
  
  > [!NOTE]
  > When you add a product, remember that if you want to reserve a product for the work order, set **Allocated** to **Yes**.  

Consider using incident types to add more details and instructions to your work orders. For more information, go to the article on [configuring incident types](configure-incident-types.md).

## Work order user interface settings

### Open work order subgrids as popup dialog boxes

Configure work order subentities to pop out as dialog boxes and edit them without having to leave the work order form. This configuration helps dispatchers maintain context through navigation.

> [!div class="mx-imgBorder"]
> ![Screenshot of a popout work order product creation form.](./media/work-order-mfd-wop.png "Screenshot of a popout work order product creation form.")

From the Field Service app, go to **Settings** > **Field Service Settings** > **Other section** and set the **Work Order Subgrid Records Open as Popups** field to **Yes**.

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

> [!NOTE]
> The simplified work order commands are available as an early access feature in 2021 release wave 2.


In the Field Service 2021 release wave 2 update (8.8.47+), the work order ribbon is simplified upon upgrade because a new Field Service setting called **Show Simplified Work Order Commands** is set to **Yes** by default. 

> [!div class="mx-imgBorder"]
> ![Field Service settings showing the Show Simplified Work Order Commands option.](./media/work-order-ribbon-setting.png "Field Service settings showing the Show Simplified Work Order Commands option.")

For a guided walkthrough, check out the following video on simplified work order commands, ability to turn price calculations on and off, and more 2021 release wave 2 updates to the work order.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWP4vU]

When **Show Simplified Work Order Commands** is set to *Yes*, the work order form ribbon command is simplified and certain commands are reduced, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Work order form showing the simplified work order ribbon.](./media/work-order-ribbon-form-enabled.png "Work order form showing the simplified work order ribbon.")

The setting also applies to the ribbon commands displayed in the list of active work orders.

> [!div class="mx-imgBorder"]
> ![List of active work orders in Field Service.](./media/work-order-ribbon-enabled-homepage.png "List of active work orders in Field Service.")

This setting also applies when a record is selected from the work order list.

> [!div class="mx-imgBorder"]
> ![Work order list with a work order selected.](./media/work-order-ribbon-enabled-homepage-selected.png "Work order list with a work order selected.")

Set **Show Simplified Work Order Commands** to **No** to show the full list of ribbon commands on the work order form, work order list, and when a record is selected on the work order list.

> [!div class="mx-imgBorder"]
> ![Work order commands with the Show Simplified Work Order Commands set to No.](./media/work-order-ribbon-disabled.png "Work order commands with the Show Simplified Work Order Commands set to No.")


> [!NOTE]
> The **Show Chart** ribbon command is *not* impacted by the **Show Simplified Work Order Commands** setting.

## Additional notes

The getting started work order create form doesn’t support switching forms. If added as a form to other parts of the app, switching to this form will leave you unable to switch back.

Products, service tasks, and characteristics are added automatically when you create a work order from an incident. Otherwise, you can add them manually when you create a work order.

### See also  

 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Submit and approve time-off requests](../field-service/submit-approve-time-off-requests.md)   
 [Schedule a work order](../field-service/schedule-work-order.md)   
 [Configure the schedule board](../field-service/configure-schedule-board.md)<br>
 [User's Guide](../field-service/user-guide.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
