Requirement groups bundle requirements that you commonly schedule together. For example, you might require a preinspection, an installation, and a final inspection every time you perform a specific job. With a requirement group, you can create all three requirements with a single template. Each requirement in the template can have distinct characteristics, and you can schedule the work collectively as a single unit. With the schedule assistant, you select resources that match the characteristics for each requirement.

## Create a requirement group template

1. In Resource Scheduling, open the **Settings** area. Under **Scheduling**, select **Requirement Group Templates**, then select **New**.

1. Enter a **Name** for the requirement group and **Save** it.

1. In the bottom panel, select the requirement group. Consider the following options on how the schedule assistant should return results.

   - **Select**
     - **All** (default): Resources must fulfill all requirements.
     - **Any**: Resources can fulfill any requirement.

     The **All** or **Any** setting allows you to add multiple options for fulfilling a requirement group by adding subgroups.
     If the root requirement is set to **Any**, and each subgroup is set to **All**, the schedule assistant searches for either **all of option 1** *or* **all of option 2**.

   - **Part of Same** (schema name is **msdyn_requirementrelationship**)
     - **Location**: Only teams of resources working at the same physical location (organizational unit) are available to book. The [Bookable Resource Association (msdyn_bookableresourceassociation)](../../field-service/developer/reference/entities/msdyn_bookableresourceassociation.md) and the [Bookable Resource Group (bookableresourcegroup)](../../field-service/developer/reference/entities/bookableresourcegroup.md) entities determine the location.

     - **Resource Tree**: The teams of resources must actually be associated to the same resource type in order to be returned as a team. This option adds more stringencies to the search.

     - **Organizational Unit**: Only teams with the same parent organizational unit are available to book. It ignores the Bookable Resource Group (bookableresourcegroup) and the Bookable Resource Association (msdyn_bookableresourceassociation) entities. It only checks the parent organizational unit. This option is the most stringent.

    :::image type="content" source="../../common-scheduler/media/scheduling-multi-resource-2-options.png" alt-text="Screenshot of requirement group with two options.":::

1. Select **+ Requirements** to add requirements and fill in the fields in the columns. All requirements within a requirement group must have the same duration. Change the duration of individual bookings after booking the requirement group by setting the **Cascade Crew Changes** option on the **Scheduling** tab of the booking to **No**.

1. To add more details to a resource requirement, select a resource requirement in the form, then select **Open Form**, and enter more filters for the schedule assistant. For example, on the **Scheduling** tab, choose the work location.

   - **Facility**: The interaction takes place at a facility and travel time is calculated as the distance between the customer location and the facility location. The requirement's latitude and longitude fields are used as the customer location. It also means at least one facility or facility pool must return in schedule assistant search results in order for a resource to be returned.
  
   - **On Site**: The interaction takes place at the customer location and travel time is calculated as the distance between the customer location and the resource (typically field technician) location, which is variable based on the resource's schedule that day. The requirement's latitude and longitude fields are used as the customer location. Facility resources and facility pools are excluded from the results.

   - **Location Agnostic**: The interaction takes place remotely and neither the location of the customer nor the resource is considered for scheduling. Travel time isn't applicable and isn't calculated. Facility resources can still be returned as part of the schedule assistant search, but travel time isn't displayed or considered in ranking.

   > [!NOTE]
   > You can select a maximum of 10 values per requirement for the following fields: Resource Categories, Characteristics, and Preferred Resource.

1. **Save** the requirement group template.

## Create a requirement group

1. In Resource Scheduling, open the **Resource Scheduling** area. Under **Scheduling**, select **Requirement Groups**, then select **New**.

1. Enter a **Name**.

1. To use a template, select an existing **Requirement group template** from the drop-down list and **Save**.

      To create your own requirement group, select **Save** and fill out the information for the group and its requirements. Learn more in [Create a requirement group template](#create-a-requirement-group-template).

## Book a requirement group

Open a requirement group and select **Book** to launch the schedule assistant and get available resources that can fulfill the requirement group. By default, it recommends options that require the fewest resources first. Book the selected resources. Then save and close the requirement group.

Booking an option for multiple requirements creates multiple bookings.

## Keyboard shortcuts

You can use keyboard shortcuts when creating requirement groups.

| Command | Keys |
|  --- | --- |
| Expand collapsed row | SHIFT ALT + |
| Collapse expanded row | SHIFT ALT - |
| Indent task | SHIFT ALT right arrow |
| Outdent task | SHIFT ALT left arrow |
| Move task up | SHIFT ALT up arrow |
| Move task down | SHIFT ALT down arrow |
| Add new row | SHIFT ALT insert |
| Delete row |  SHIFT ALT delete |
| Refresh | SHIFT ALT F5 |
| Edit | SHIFT ALT F2 |
