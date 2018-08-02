---
title: "Create a work order (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 9279d5ba-505c-4cf3-9e3f-1436ab7f52a4
caps.latest.revision: 24
ms.author: krbjoran
manager: shellyha
---
# Create a work order to coordinate and schedule resources and activities (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

A work order in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] has information on what work needs to be done. It is used to coordinate and schedule resources and activities. It can be used for different types of work, such as installations, repairs, or preventive maintenance.  
  
 A work order is usually created from a case or opportunity. It is then scheduled either manually or using the schedule assistant and then dispatched. Once the work is complete, it is reviewed and approved by a manager.  
  
> [!NOTE]
>  Products, service tasks, and characteristics are added automatically when you create a work order from an incident. Otherwise you can add them manually when you create a work order.   
  
<a name="BKMK_workorderlifecycle"></a>   
## Work order lifecycle  
  
- **Work order creation:** A work order is created, usually from a case or opportunity  
  
- **Schedule**: The work order is then scheduled.  
  
- **Dispatch**: The work order is dispatched.  
  
- **Service**: The work order is performed and details are updated.  
  
- **Review/Approval**: The work order is reviewed and approved by a supervisor.  
  
- **Invoice and inventory adjustment**: Inventory adjustments are made and an invoice is generated for the corresponding account.  
  
  ![Work order lifecycle in Dynamics 365 field service](../field-service/media/field-service-work-order-lifecycle.png "Work order lifecycle in Dynamics 365 field service")  
  
||||||||  
|-|-|-|-|-|-|-|  
|**What happens**|New work order is created.<br /><br /> Assigned incident, product, services, skills, territory, etc.|Work order schedule is created.<br /><br /> Resources assigned to the work order.<br /><br /> Date and time specified.|Field agent notified of work order.<br /><br /> Field agent may review and accept/decline the work order.|Work order is carried out.<br /><br /> Information about what is performed in the field is entered through the mobile app.|Supervisor verifies that all work was done properly, and that all information regarding the work order is correct.|Invoice is created based on products and services used.<br /><br /> Inventory adjustments are made.<br /><br /> Products converted into equipment (if applicable)|  
|**Who performs the task**|Agreement is automatically generated on a recurring basis.<br /><br /> Case: By customer support.<br /><br /> Sales order: By sales/scheduling.<br /><br /> Ad-hoc: By field agent or centralized scheduling.|Dispatcher<br /><br /> Field Agent<br /><br /> Dispatcher with help of scheduling assistant<br /><br /> Routing engine|Notification sent by system automatically to field agent, customer, and other parties. **Note:**  Notifications need to set up in the system.|Field agent|Field supervisor/manager,<br /><br /> back-office accounting|Automatically sent by system|  
|**Work order status**|Open - unscheduled|Open - unscheduled|Open - unscheduled|Open - unscheduled, then open-completed|Open - completed then closed-posted|Closed-posted|  
|**Work order schedule status**|N/A|Scheduled|Scheduled|Scheduled<br /><br /> Accepted/Declined<br /><br /> Custom Status|Completed|Completed|  
  
<a name="BKMK_newworkorder"></a>   
## Create a work order  
  
1. From the main menu, click **Field Service** > **Work orders**.  
  
2. Click **+New** in the upper-left corner.  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    - **Summary**  
  
        - **General**: Fill in the basic information regarding the work order, such as the work order number and the service account it is associated with, a brief summary, and status, which can show whether the work order is unscheduled, scheduled, in progress, or finished.  
  
        - **Primary Incident**: Enter more information regarding the nature of the work to be performed.  
  
        - **Total**: Enter pricing information for the work order. This will show total pricing information for tasks, including products and services.  
  
    - **Settings**  
  
        - **General**: Specify the category the work order may fall into. Also, fill in important information regarding the location of the work order, price list, service territory, and more.  
  
        - **Sales tax**: Sales tax information is inherited from the service account.  
  
        - **Preferences**: Enter the resource and time information for the work order.  
  
        - **Follow up**: Shows instructions of how to proceed if desired, or whether the work order calls for a follow-up.  
  
        - **Related to**: Specify if the work order is related to an originating work order or agreement.  
  
        - **Preferences**: Specify any preferred time windows.  
  
        - **Source**: Specify source information regarding the work order.  
  
    - **Address**: The address where the work will be performed. The address should be inherited from the service account.  
  
    - **Location**: Shows the address location on the map.  
  
<a name="BKMK_Addtasks"></a>   
## Add service tasks, products, or services to the work order  
 When the work order has been created and saved, you can then add any related tasks, products, or services to the work order.  
  
- Go to the **Service Tasks** section and click **+Add Work Order Service Task record**. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)] [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up service task types  ](../field-service/set-up-service-task-types.md)  
  
- Go to the **Products** or **Services** section and click the **+**  button. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)][!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a product or service ](../field-service/create-product-or-service.md)  
  
  > [!NOTE]
  >  When you add a product, remember that if you want to reserve a product for the work order, set **Allocated** to **Yes**.  
  
### See also  
    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Submit and approve time-off requests](../field-service/submit-approve-time-off-requests.md)   
 [Schedule a work order](../field-service/schedule-work-order.md)   
 [Configure the schedule board](../field-service/configure-schedule-board.md)<br>
 [User's Guide](../field-service/user-guide.md)
