Requirement groups allow you to define groups of resources that would be appropriate for a job, and then schedule all the resources with a single search. Requirement groups allow you to mix and match the different types of resources needed for a job, such as individual field technicians, a whole crew, equipment, and facilities.  

For example, use a requirement group to find resources for a work order requiring: 
   
  - 1 field techician with skill A *and* skill B; OR
  - 2 field techinicians, one with skill A and the other with skill B

Use a requirement group to find resources for a sales demonstration requiring:
  
  - 2 people in the same sales territory, with both working onsite
   
  - 2 people in the same sales territory, with one onsite and one working remotely
  
  Or, use a requirement group to find resources for a project that can be done by any resource with the right piece of equipment who is available at 9 AM during a selected week.  

Schedule resource groups using resource availability search, and recommend groups of resources based on requirements such as availability, travel time, and the ability for the resources to arrive onsite at the same time. 

Scheduling resources using requriment groups takes the following steps:

- Create a requirement group template.
- Add the requirement group template to a requirement.
- Book the requirement via resource availability search.
- Use split view to see the scheduled requirement group on the schedule board.

## Create a requirement group template

1. Navigate to **Universal Resource Scheduling** > **Requirement Groups**, and then choose **New**.

2. Enter a name for the requirement group, and set the **Is Template** field to **Yes**. Choose **Save**. The system displays a control that shows a grid view of requirement details with a root named after the template.

3. In the root, set a duration for all related requirements. Note that changing the duration for the root or an individual requirement changes the duration for all requirements in the group. 

4. Select the root, and then choose **Add requirements**. Fill the the fields across the columns. If details you need to add aren't displayed in the columns, select the requirement and then choose **Open Form** to add details in the requirement form.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two requirements](./media/scheduling-multi-resource-2-requirements.png)

5. Set the **All** or **Any** option. Setting **All** means all requirements must be fulfilled, so the the system searches for one resource for each requirement. In the previous example, the system would search for two resources. Setting **Any** means the system searches for one resource that can fulfill any requirement. 

6. **Save** the requirement group template.

## Create a new requirement group

1. Navigate to **Universal Resource Scheduling** > **Requirement Group** > **New**

2. Enter a **Name**. 

3. Select a template from the drop-down list, and then choose **Save**.

4. If needed, edit the requirements, and then choose **Book**.

> ![Screenshot showing where to find book command for requirement group](./media/scheduling-multi-resource-group.png)

> [!Note]
> It is possible to relate requirements within requirement groups to jobs such as work orders, Projects, and other entities; however the intended use for work orders is through Incident Types described later in this article.

The requirement group is noted on all related requirements.
> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group lookup from individual requirements](./media/scheduling-multi-resource-rg-field.png)

## Book the requirement group 

Selecting Book from a requirement group triggers Resource Availability Search (Schedule Assistant).

> [!div class="mx-imgBorder"]
> ![Screenshot of schedule assistant for requirement group](./media/scheduling-multi-resource-schedule-assistant.png)

Resource Availability Search will display different options to fulfill the requirement group noting the particular requirement it is fulfilling in the Requirement column. 

By default it will recommend options with fewer resources first, in an attempt to minimize travel time and/or cost. A second option is to sort results by **Earliest Time First** in the left pane.

Selecting and booking an option for multiple requirements will create multiple bookings reflected on the schedule board.

## Use split view to see the scheduled requirement group on the schedule board

If multiple bookings are created when scheduling a requirement group, it is possible to use the split view feature on the schedule board to view all related bookings.  

> [!div class="mx-imgBorder"]
> ![Screenshot of splitview schedule board view of requirement group bookings](./media/scheduling-multi-resource-split-view.png)
In the above picture, the lower split view is showing all bookings scheduled from the requirement group.

## Tips and tricks when using templates for requirement groups

**Order matters** - by default the schedule assistant results will favor requirements within a requirement group with fewer resources. If options within a requirement group require the same number of resources, the schedule assistant results will favor the requirements listed first.

**Duration must be equal** - All requirements within a requirement group must have the same duration. Changing the duration of the root/subgroups or any of the requirements will change the duration of **all requirements** within a requirement group. Duration of individual bookings can be changed after the fact depending on cascade settings. A list of fields that are in sync can be found in the **Additional Notes** section below.

**Template is not required** - a requirement group can be created and booked without a template being created first. Template is recommended for repeatable scenarios. 

- It is possible to book directly from a template because creating a template will automatically create related requirements in the background. The actual template is not scheduled. This increases efficiency for scenarios where you want to schedule a requirement group and create a template at the same time. However, editing **start time** and **end time** is not available via the template, only ia resulting requirements. 

- The following fields are kept in sync between requirements in a requirement group. Editing these fields for one requirement will update all requirements.
  - Duration
  - Start
  - End
  - Fulfillment preference
  - Booking Setup Metadata
  - Work location
  - Latitude
  - Longitude
  - Schedulable entity (work order, Project, custom entity etc.) 

- Updating a requirement group template will not update previously created requirements from that template, only new requirements going forward.

- Crews can show as an option to fulfill requirement groups, however a crew can have more resources than are required by the requirement group and will therefore rank lower in schedule assistant search results.

## Requirement groups for work orders

For field service scenarios, requirement group templates are designed to work with incident types. An incident type is a way of automatically adding duration, service tasks, products, services and other attributes to a work order. Adding an incident type to a work order can also automatically add requirement groups. This is achieved by **associating a requirement group template to an incident type**.
 

1) create a requirement group template
2) create an incident type or select an existing one and associate the requirement group template 
3) add the incident type to a work order and verify related requirements are added
4) book the work order

### Create a requirement group template

See above for details

### Create an incident type or select an existing one and associate the requirement group template 

Navigate to **Field Service Settings** > **Incident Types**.

Select an incident type or create a new one.

> [!Note]
> Incident Types with characteristics cannot have requirement group templates

Select **Requirement Group** under related entities and **add a new one**.
> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group template from incident type](./media/scheduling-multi-resource-incident-rgt.png)

Select a requirement group template from the dropdown menu to associate the template with the incident type, and then choose **Save**.
> [!div class="mx-imgBorder"]
> ![Screenshot of associating requirement group template with incident type](./media/scheduling-multi-resource-incident-rgt2.png)

### Add the incident type to a work order and verify related requirements are added

Navigate to **Field Service** > **Work Orders** > **New**

Fill out required work order details and add the incident type **before saving**

This is done by choosing an incident type for the **Primary Incident Type** field or navigating to *** > **Work Order Incident Types**.

> [!Note]
> When an incident type with a requirement group template is added to a work order, this limits the number of work order incidents to 1, and more cannot be added.

Navigate to **Work Order** > **Requirement Groups** to verify requirements have been added to the work order according to the requirement group template.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group added to work order when work order incident type is created](./media/scheduling-multi-resource-work-order-requirements.png)

### Book the work order

Choose **Book** to schedule the work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of scheduling requirement group from a work order via schedule assistant](./media/scheduling-multi-resource-work-order-book.png)

## Tips and tricks for using requirement groups to schedule work orders

- When requirement groups are related to onsite work with a location (work orders), Schedule Assistant looks for groups of resources that can arrive at the same time, not resources that can begin traveling at the same time.

- If an incident type has a characteristic associated with it, it is not possible to add a requirement group template and vice versa.

- When an incident type with a requirement group template is added to a work order, this limits the number of work order incidents to 1, and more cannot be added.
  
- After scheduling multiple requirements to multiple resources and thus creating multiple bookings, the work order status is driven by the same logic as scheduling crews, pools, or manually scheduling the same work order multiple times. This means if at least 1 booking has a status of **in progress**, then the related work order will have a status of **Open-In Progress**. Additionally, the work order status will only become **Open-Completed** if all related bookings have a status of **completed** (not including canceled bookings). 

## Using the "All" or "Any" setting to add multiple option sets
The All or Any setting is powerful when you need to add multiple option sets to a requirement group, which is done by adding subgroups. 

In the following example, the root is set to **Any** but each option within the root is set to **All**. This means when attempting to book the requirement group the system searches for either **all of option 1** OR **all of Option 2**. The system searches for two resources each with one required skill (characteristic), *or* searches for one resource with two required skills.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with two options](./media/scheduling-multi-resource-2-options.png)

