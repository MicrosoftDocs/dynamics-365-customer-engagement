---
title: "Edit schedule board booking template | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
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
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Edit schedule board booking template

When a requirement is scheduled to a resource, a booking record is created and displayed on the schedule board during the respective resource's time slot. The fields displayed in the schedule baord booking can be edited and is called a **Booking Template**.

In this article we will discuss how to edit the booking template.

## Prerequisites
Field Service v6.1+

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

Schedule Board Tab Settings – Booking Templates
Booking templates define how a booking will be displayed on the schedule board’s Gantt chart. This is how it looks like initially:
Screenshot: Standard booking visualization
  
The visualization can be altered for every individual schedule board. To do that double-click the name of the board and scroll down to the Schedule Types setting. Since the board can show different entities, you can also specify individual booking templates for each entity. In this example, we will change the style of Work Order bookings. Select the Work Order entity and find the Booking Template at the end of the section.
 Screenshot: Schedule board settings - booking template
  

Modify the booking template
The booking template is defined by HTML and CSS, it can reference fields from the Bookable Resource Booking entity but also from linked entities. Here is a simple example of a Work Order template.
<div style="line-height: 11px !important; width: 99%; overflow: hidden; display: block; text-overflow: ellipsis;">
WO: 
<B>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_name}</B><br/>
Account: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_account_msdyn_workorder_ServiceAccount.name}</b><br/>
Incident: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}</b><br/>
Duration: <b>{duration} minutes</b><br/>
</div>
To avoid typing mistakes, navigate to Customization>Entities>Bookable Resource Bookings and copy the field name:
Fields from the Bookable Resource Booking entity can be referenced directly using the field name in curly brackets. Example: {duration}
If you want to display a field from a linked entity, find the name of n:1 relationship, for the Work Order entity it is msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder. Add a “.” Followed by the field name of the target entity, for example the Incident Type with field name msdyn_primaryincidenttype. Enclose the whole string with curly brackets: {msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}
Linking to yet another entity (e.g. from work order to account) is also possible, just concatenate the relationship name with a “.”.
The result of the above booking template looks like this:
Screenshot: Custom booking visualization
  

Advanced booking template styling using CSS
Navigate to Resources>Scheduling Parameters and set Disable Sanitizing HTML Templates to Yes. This is required to be able to include CSS statements into the booking templates.
Let’s assume that there is a customer rating that the dispatcher should see on the schedule board to prioritize jobs. The customizer has added a field new_customerrating on the Account entity and propagates that field to the Work Order entity with an integer range from 1 to 10. Using the approach above this field could easily be added to the booking template, but this would not be visually appealing.
Instead the booking template should draw 5 stars in gray color, this is the background. On top of these 5 gray stars we’ll put 5 orange stars, but only show a percentage of these, which corresponds with the customer rating.
Example: Customer rating is 4 out of 10, thus we only show 40% of the orange stars, which is 2 out of 5:
Screenshot: Star rating
  
In addition, the dispatcher should also see whether a work order is a service call or another type of job. The customizer has created a field new_isservicecall on the work order entity, values are 0 or 1. Using the same approach as above, we first draw a gray wrench as background, put an orange wrench on top and limit its size to 0% (new_isservicecall=0) or 100% (new_isservicecall=1).
Screenshot: Wrench rating
  
This is the final booking template:

    <div style="line-height: 11px !important; width: 99%; overflow: hidden; display: block; text-overflow: ellipsis;">
    <div class="back-stars" style="color: #AAAAAA; position: relative; display:inline-block;">
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
    <div class="customerrating" style="width:{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.new_customerrating}0%; color: #FFBC0B; position: absolute; top: 0; left:0; overflow: hidden; display:-webkit-box">
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
    </div>
    </div>
    <div class="repair-back" style="color: #AAAAAA; position: relative; display:inline-block; padding-left:10px; vertical-align:text-top;">
        <i class="fa fa-wrench aria-hidden="true""></i>
    <div class="repair" style="width:{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.new_isservicecall}00%; color: #FFBC0B; position: absolute; top: 0; left:0; padding-left:10px; overflow: hidden; display:-webkit-box">
        <i class="fa fa-wrench" aria-hidden="true"></i>
    </div>
    </div>
    <br/>
    WO:
    <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_name}</b><br/>
    Account: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_account_msdyn_workorder_ServiceAccount.name}</b><br/>
    Incident: <b>{msdyn_msdyn_workorder_bookableresourcebooking_WorkOrder.msdyn_primaryincidenttype}</b><br/>
    Duration: <b>{duration} minutes</b><br/>
    </div>

Here is the result of the change:

Screenshot of Wrench rating
  
When building these advanced booking templates, make sure to test on multiple browsers and also consider accessibility.



## Configuration considerations
## Additional Notes