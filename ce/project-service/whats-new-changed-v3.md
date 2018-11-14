---
title: What's new or changed in Project Service Automation version 3
description: This topic provides information about what is new and changed in PSA version 3.
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 11/13/2018
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Dynamics 365 for Project Service 3.x
ms.author: john.burrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  
---

# What's new or changed in Project Service Automation version 3
[!INCLUDE[cc-applies-to-psa-app-2-4x-9-0-platform](../includes/cc-applies-to-psa-app-2-4x-9-0-platform.md)]

This topic provides information about the changes to UI, functionality, and terminology in Project Service Automation (PSA) between v2 and v3.

## Project scheduling
The project schedule, which was known as the Work Breakdown Structure (WBS) in v2, has been renamed Schedule and is accessed by clicking the **Schedule** tab. 
The schedule now has a new surface for interaction that is both modern and accessible, however the underlying PSA scheduling engine has not changed. The control buttons in the schedule grid’s ribbon allow you to interact with the schedule similar to the previous version of PSA. Additional changes to the schedule include:

- **Gantt chart** - The Gantt chart is no longer present. A new Gannt visualization will be returning in a future update.
- **Column headers** - You can hide column headers in the grid by clicking the down indicator next to the column title. 
- **Columns** - You can un-hide hidden columns by clicking **Add column**. 
- **Transaction category** - A **Transaction category** lookup has been added to the schedule grid and is shown by default. 
 
## Project templates
The following changes have been made to project template functionality.

### Create a project template 
You can create a project template in v3 similar to previous version of PSA. The template can contain only a schedule and the schedule can include assignments, but they are not required. If the schedule does have assignments, they can only be for generic resources. You can generate resource requirements for generic resources, but they can't be booked with real resources in the template. You can't book a real resource to a team in a template. 

### Create template from existing template
When you create a new project template from an existing template in PSA v3, the following happens: 

- The source project’s schedule is copied into the template. 
- Generic resources are copied into the team and any generic resource assignments are copied over. Requirements for the generic resources are not copied over. 

### Create a template from an existing project
When you create a new project template from an existing project, the following happens: 

- The source project’s schedule is copied into the template. 
- Generic resources are copied into the team and any generic resource assignments are preserved. Requirements for the generic resources are not copied over.	
- Named resources, both assigned or unassigned are removed from the team and replaced with generic resources.
- If present, customer information is removed. 
- If present, references to quotes and contracts are removed. 

### Create a project from a template
In PSA v3, when you create a new project from a template, the following happens:

- The schedule, team, and assignments are copied to the new project.   
- The start date is either the copy date or date selected by the user.   
- For any generic team members with resource requirements in the template, the requirements are not copied or generated automatically. You will need to generate them. 

## Copy a project
In PSA v3, when you copy a project, the following happens: 

- The estimated start date is copied, but can be changed.  
- The project schedule and tasks are copied. 
- Generic resources and their assignments are copied. Resource requirements for the generic resources are not copied. You will need to re-generate them. 
- Real resources and their assignments are not copied. Instead, they are replaced by generic resources. 
- Actuals are not copied to the new project. 

## Move a scheduled project
When you move the schedule of existing project forward, the following happens: 

- Task dates are automatically moved to correspond with the movement period. 
- Assigned generic resources remain assigned.   
- If they are generated before the project is moved, requirements for the generic resource remain the same and are not automatically re-generated. You will need to generate them again to reflect the new assignments due to the task movement. 
- Assignments on real resources change to correspond with the task date movement. Bookings on real resources do not change. You will need to modify the bookings using the reconciliation view. 
- Team resources with bookings but no assignments do not change. 
- Actuals do not move. 

## Estimates
Estimates have been split into two tabs, **Resource assignment** and **Estimates**. The **Resource assignment** tab contains the effort estimates and shows the resource assignments for the tasks in a time-phased view. You can edit the estimates based on what the scheduling engine has generated.

The **Estimates** tab shows the cost and sales amounts for resource assignments. The amounts are read-only. The costing and sales pricing are now driven from the team member assignments on the schedule. This means that if you have a task without any assignment, the task will show under the unassigned bucket. This also means that without **role**, which is a default pricing dimension, there will be no estimated cost or sales if you have a customer or contract/quote associated with the project. 
  
Category is also supported on tasks in the schedule view. Grouping by category on the time-phased view of estimates will provide a better experience, especially when you also have expense estimates in your project. Expense estimates are entered using a grid on a separate tab. 

## Resource management
In PSA v3, staffing a project with generic or real resources has changed dramatically from the 2.x release With the new Unified Client UI and changes in the relationship between bookings and assignments, staffing a project iwth generic or real resources has changed dramatically in the PSA v3 release. However, the concepts of bookable resources, both **real** and **generic** remain the same, as do team members, requirements, assignments, and bookings.   

### Assign a real bookable resource 
In PSA v3, bookings and task assignments are not as tightly intertwined as previous versions of PSA. You can use the team grid to book a **real** team member, similar to in-market.
Using the resource picker on the schedule, you can select the team member created in the team view and then assign them to tasks. You can continue to assign tasks to them, even past their bookings. Use the **Reconciliation** tab to reconcile team members that have differences in bookings and assignments.
The resource picker will show the team members for the project. You can also use the recource picker search for and view other bookable resources that are not part of the project team. You can assign them to a task and they will become part of the project team. You will need to book them using the **Schedule board** or **Reconciliation** tab.

### Assign a generic bookable resource on a task and project team and then fulfill with a real resource via Schedule Board 
In PSA v3, the generate team functionality is not used for generic resources. Instead, you can create and directly assign a generic resource from the schedule by typing the position name of the generic resource in the resource cell of the schedule. Or, you can select the resource icon in the cell and then, using the resource picker, type the name of the generic resource you want to create. This will open a quick create panel that allows you to set the role and organization unit of the generic resource team member. After you create the resource, it is assigned to the task and you can continue to assign that generic resource to other tasks in the schedule.    
 
When you have assigned the resource to all of the appropriate tasks, you can generate a resource requirement and then fulfill it by directly booking with the **Schedule board** or by submitting a resource request. You can also add generic resources directly to the team member grid. 

Generic resources are added to the project team with no resource requirements and with the start/end dates of the project until the resource requirement is generated. To generate a requirement, select the generic resource and click **Generate**. The requirement link now shows and the required hours will be populated with the assigned hours. You can click the link to open and update the requirement.
  
When the booking is complete and totally fulfilled by a named resource, the generic resource is replaced with the named resource and the assignment on the schedule is updated with the named resource. 

Proposed resources for requirements are now stored on a tab instead of a separate section.

### Multiple names resources fulfilling a generic resource
When fulfilling a requirement with multiple resources the generic resource remains on the team with the assignment to the task and the booked real team members are not assigned as part of the position.  The project manager will then be able to assign the work as they see fit to the real resources.  The Reconciliation View will assist them in breaking up the bookings across multiple resources to task assignments. The reason this is not done automatically is because in any scenario more complicated than a really simple one, such as where you have a bundle of tasks making up the requirement, the intent of how the project manager wants to assign, needs to be assumed.  Since the system cannot understand intent, chances are the assumptions will be different than intended and an incorrect or unpredictable result will happen.  So, the predictable outcome is that the generic remains assigned until the project manager deliberately assigns, with the assistance of the Reconciliation view.

### Reconciliation
The Reconciliation tab shows for each project team member, their bookings and assignments for the project down to the individual task assignment.  The view shows hours in cells which can represent time points from months down to days.  This view assists project managers to be able to reconcile team member bookings and their assignments for their project team as bookings and task assignments are not tightly coupled to allow for flexibility when planning a project. 

For each resource, the view takes the difference between a team members bookings and rollup of their resources’ assignments.  It shows the following two differences that can occur with bookings and assignments in a project: 

•	Booking shortage.  Booking shortages occur when a resource has more assignments than they have bookings.  Since this capacity has not been reserved, a project manager may wish to correct this by extending the resource’s bookings to cover the deficit. 
•	Excess bookings.  An excess of bookings occurs where a resource has been booked to the project but has not been assigned to tasks.  This may be an acceptable occurrence, for example the resource has been booked prior to task assignment.  However, in other cases the resource may not be planned to be assigned, and the PM should consider cancelling the resource’s bookings to allow the capacity to be used for another project. 

When you have a situation where you have task assignments for a resource without bookings (a booking shortage) you can select the aggregate booking shortage and click the Extend Booking button.  This will bring up a surface where you can see the booking needed to address the resource’s shortage along with their availability.   
 
## Time and expense
This section is a high-level overview of the changes in time, expense and approval in version 3.x of Project Service Automation.  For a more detailed view, please see the Time, expense, and approvals how-to guide. 

As part of Dynamics 365 for Project Service Automation solution, the 'Time entry' feature has been refreshed to leverage the Unified Interface framework. This enables delivery of a consistent, uniform user interface that follows responsive design for optimal viewing on any screen size or device. 

### Landing page
The non-extensible custom time entry experience has been deprecated in favor of providing extensible & accessible native grid experience.  Users access the 'Time Entry' via the sitemap on the left and land on the default view of an editable grid.  
With this change users will no longer be able to enter time for one week at a time, instead create time entry per day in the grid.  Once a few time entries have been created, users can bulk create time entries with 'Copy' function explained in the 'Bulk Create/Copy' section of this document. 
 
### Creating new time entries 
Clicking on the 'New' button in the ribbon invokes a time entry quick create form where you enter duration in minutes, hours or days by starting to type h, m or d along with quantity.  
 
Lookup fields are backed by system views. For instance, once the user enters the project, project task field is set by default to 'My open project tasks' view. To create time entries for tasks not assigned to the user, click on the 'Change view' on the lookup and choose the appropriate view 'All Active project tasks'.  
Once the time entry has been created and shows up in the grid, the grid allows inline editing to update any values.  

### Bulk Create/Copy 
After a few time entries have been created, ‘Copy’ function allows bulk creating additional time entries. Click on the 'Copy' button to invoke the Copy dialog. User will be able to set the date range from which time periods must be copied from in the 'From period: Start Date:    End date'. Specify the date for which time entries must be created in 'To Period' Start Date: Clicking on 'Copy' will create a copy of the time entries to the corresponding day of the week indicated in the 'To Period'. For e.g.; Monday's time entry from last week will be copied into Monday for the week indicated in 'To Period'. 
 
### Import Data 
Import from bookings, Assignments and Exchange follows the same UI pattern to allow user to specify the date range from when bookings need to be imported. User then must explicitly choose the bookings that should be copied into 'Draft' time entries. Users will no longer see the pattern we had in the previous release where 'Suggested' time entries shows up on the grid and calendar which used to be lost in session refresh. 

### Change in Calendar Control
We have moved away from custom calendar control to OOB UC Calendar to display time entries for the week. It will be possible to view Day, Week and Month in the calendar. A limitation to note on the Calendar is that this control does not support actions on individual calendar items.  Ie; users will not be able to select one or more calendar items and submit or delete those items. Clicking on a calendar item will navigate the user to time entry entity form for any additional actions. 

### Extensibility
Capture data on custom fields in time/expense entry entities only:
Time entry leverages editable grid, read only grid and calendar controls from the platform, all these controls are native and therefore will support customizations. With this version of PSA it will be possible to add additional custom fields, set up lookup fields and back them up with custom views. It is also possible to set custom business logic based on values chosen/entered on specific custom fields.  

Capture data on custom fields in time/expense entry and propagate it through entities supporting the submission/approval flow:
The typical processing of time entries is shown below:
 
To support business requirements where time and expense entities need to capture custom pricing dimension and propagate the values set by a time entry resource in the custom pricing dimension through all entities in the process shown above please see the Pricing dimensions setup guide.

To support business requirements where time and expense entities need to capture custom non-pricing dimensions and propagate the values, partners and customers can either leverage the pricing dimensions setup and express the custom dimensions as pricing dimensions with no cost or bill rate. Another approach would be to add custom field to each of the entities by maintaining the same field name across all the entities. Create custom plugins to relate records in the entities participating in the submission/approval flow via transaction origin and transaction connection entities. Please see section 5.1.5 in Basic Guide to quoting, pricing and billing to understand usage of transaction origin and transaction connection entities. 

### Delegation on time and expense entry:
CDS platform does not presently offer formal support for one user to impersonate another user, therefore with PSA version 3.0 there is no support for delegated time and expense entry experiences. However, we would like to offer visibility to a design workaround that other partners and customers have leveraged to enable support for delegated time entry experiences in PSA v3.0. This is only a workaround to achieve the desired delegation outcome but not a complete solution, hence it is important to understand the limitations and only use this approach if the limitations are acceptable. This information should only be considered suggested guidance for custom implementation by a partner/customer. The product team will not offer formal support for this functionality through any of our support channels.

### Customization details 
The overall idea is to add 'Bookable Resource' to the create/edit experiences allowing the logged in user to act as a delegate by changing the 'Booking Resource' field to any other user for whom time and expense entries needs to be recorded. The following steps covers the 'Time entry' delegation, same will apply for Expense as well. 
 
1.	Ensure the user that will act as delegate has global security access on projects and project tasks. 
2.	Bookable Resource is a field on the 'Time entry' entity that is not exposed on the Quick create form, add 'Bookable Resource' field to the Quick Create form for Time entry.
3.	Optionally create a custom view to view only time entries created for the resource
a.	Ensure you publish the customizations on the app module designer for this view to shows up under the 'View Selector' on time entries page. 
4.	We have two plugins that handle setting the manager for non-project time entries:
PreValidateTimeEntryCreate
PreValidateTimeEntryUpdate
 
Create a new plugin to overwrite the manager field to the manager of the user assigned in the Bookable Resource field. Use the same Execution Stage as the OOB plugin (Pre-validation) and an Execution Order higher than OOB plugins (greater than 1) so that this custom plugin will be executed after the OOB plugins.  
 
### End user experience: 
1.	When creating a time entry, in the quick create form enter appropriate Project, Project task details and choose the user on 'Bookable Resource' field for whom time entries needs to be recorded for. 
2.	By default, this fields is defaulted to the logged in user, but given the user overrode this field, time entry is now created for the chosen 'Bookable Resource'.
3.	When submitting time entries created for these records, the entries will be queued up the approver user set in the project as expected. 
4.	When recalling time entries created for the other user, the time entries will be returned to 'Draft' state with Bookable Resource field set to the other user. 
5.	Optionally, Switch to the custom view to filter time entries created for the other user. 
 
### Limitations
1.	Copy and Import functions work only in the context of the logged in user, therefore it will be possible to Copy and Import time entries created for the logged in user as the Bookable Resource
2.	Non project time entries will be routed for approval to the manager of the Bookable resource only if point 4 under 'Customization Details' section is completed, otherwise non project time entries for the other user will be routed to the manager of the logged in user incorrectly. 

### Other changes 
•	'Bookings and Tasks' function has been removed. We will be looking to provide a holistic experience for team members to view their tasks and update status in a later update. 

## Multidimensional Pricing
This section is a high-level overview of the changes in sales and cost pricing in version 3.x of Project Service Automation.  For a more detailed view, please see the Pricing dimensions setup guide.

To maximize flexibility to meet different business requirements, version 3 of Project Service Automation supports discrete application of pricing dimension sets to cost and bill rates. Dimension values can be set as the default and propagated across the costing and pricing process from resource profiling to time entry to project actuals. Customer-specific configuration and modification or extension leverages standard Dynamics 365 customizability infrastructure.

Project Service ships with a default set of pricing dimensions, role and resource unit, and allows for the setup of prices and costs for each Role and Organizational Unit combination by default.

For customers of Project Service that wish to continue to use these out-of-the box fields as pricing dimensions version 3, there will not be any observable change. You can continue to use Project Service as usual. If, however, you see the need to price or cost for your resources using other additional attributes, then version 3 will allow for adding your own custom pricing dimensions to PSA.  The extension of custom pricing dimensions is a complicated configuration experience.  Please read the detailed Pricing dimensions setup guide.

## Quoting and Contracting
In the v3 of Dynamics 365 for Project Service Automation solution, the following aspects of Quoting and Contract setup and management have changed. 

### Setup Chargeability Options
In versions v2.x and prior, chargeability setup for roles and categories for specific quote and contract was using the Chargeability view that was in the top navigation of a quote line or a contract line. This was also where you could setup prices for those roles and / or Expense Categories.
As of v3.x, setup of chargeability options by role and / or Expense Categories will be done at the level of a Quote line or a Contract line. Pricing setup is separated from Chargeability setup. You will be able to find “Chargeable Roles” and “Chargeable Categories” as tabs on the Quote line and on the Contract line page without having to use the top navigation.
 
The setup of Chargeable Roles and Chargeable Categories also leverages the out-of-the-box Editable grid control. The supported options for Billing Type during the Quoting and Contracting phase for each role and Category remain unchanged from prior versions as “Chargeable” and “Non-Chargeable”. Complimentary is not a supported type during Quoting or Contracting phase. Complimentary is supported only during Time or Expense approval.  
 Create and edit Custom Pricing for a PSA Quote and PSA Project Contract
In versions v2.x and prior, using custom price list for specific quote and contract was done using the “Edit Prices” button on the Chargeability view. Chargeability view was located in the top navigation of a quote line or a contract line. This was also where you could setup chargeability options for roles and / or Expense Categories.
As of v3.x, creating and using a custom project price list on a PSA Quote and PSA Project contract has been separated from Chargeability setup. PSA Quote and PSA Project Contracts have a new tab called “Project Price Lists”. This tab shows an associated view of all Project Price Lists that are attached to the PSA Quote or a PSA Project Contract. For creating a custom price list from an existing price list that is already associated to the Project Quote or the Project Contract, you will need to click on grid action “Create custom pricing”. This will make a copy of all the associated price lists and attach them to the Project Quote or the Project Contract. You can now open the price list and edit Role prices or Expense Category price so that those pricing changes will only apply to this Project Quote or Project Contract. 
  
Figure 1:Before custom price lists have been created

 
Figure 2: After Custom price lists have been created
Please note: There may be a little lag from the time you click on “Create Custom Pricing” to when custom price lists get created. Refreshing the grid after a little gap is recommended instead of clicking multiple times. You can tell that custom price list have been created if you see the associated price list name has the quote name or the project contract name appended to it.

