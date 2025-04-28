Requirement groups bundle requirements commonly scheduled together. For example, you might require a preinspection, an installation, and a final inspection every time a specific job is performed. With a requirement group, all three requirements can be created with a single template. Each requirement in the template can have distinct characteristics, and the work can be scheduled collectively as a single unit. With the schedule assistant, resources are selected that match the characteristics for each requirement.

## Create a requirement group template

1. In Resource Scheduling, open the **Settings** area. Under **Scheduling**, select **Requirement Group Templates**, and then select **New**.

1. Enter a **Name** for the requirement group and **Save** it.

1. In the bottom panel, select the requirement group. Consider the following options on how the schedule assistant should return results.

   - **Select**
     - **All** (default): Resources must fulfill all requirements.
     - **Any**: Resources can fulfill any requirement and that fulfilling one requirement fulfills the entire requirement group.

     The **All** or **Any** setting allows you to add multiple options for fulfilling a requirement group, which is done by adding subgroups.
     If the root requirement is set to **Any**, and each subgroup is set to **All**, the schedule assistant searches for either **all of option 1** *or* **all of option 2**.

     These settings are especially useful when you add multiple option sets to a requirement group using subgroups. For example, if a job requires a certain skill and a specific certification, one resource can fulfill both requirements (option set 1) or two resources can fulfill one requirement each (option set 2). Any of these combinations would fulfill the requirement group.

   - **Part of Same**
     - **Location**: Only teams of resources working at the same physical location (organizational unit) are available to book. The Resource Associations (msdyn_bookableresourceassociations) and the Bookable Resource Group (bookableresourcegroup) entities determine the location.

     - **Resource Tree**: The teams of resources must actually be associated to the same resource type in order to be returned as a team. This option adds more stringencies to the search.

       For example, let’s assume there's one physical location, Location A. There are two facilities at location A: facility 1 and facility 2. If resource 1 is associated to facility 1, and "Same Resource Tree" is selected, the one team that can be assembled is facility 1 + resource 1. Facility 2 and resource 1 can't be returned. This combo could however be returned if "Same Location" is the only option selected.

      > [!Note]
      > If neither of these two options are selected on the requirement relationship (msdyn_requirementrelationship), and work location is set to facility, the schedule assistant search will execute as if “Same Resource Tree” was selected.

     - **Same Organizational Unit**: Only teams with the same parent organizational unit are available to book. It ignores the Bookable Resource Group (bookableresourcegroup) and the Resource Associations (msdyn_bookableresourceassociations) entities. It only checks the parent organizational unit. This option is the most stringent.

     > [!Note]
     > The **Part of Same** field schema name is **msdyn_requirementrelationship**

1. Add requirements and fill in the fields in the columns. All requirements within a requirement group must have the same duration. Change the duration of individual bookings after booking the requirement group.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of requirement group with two options.](../../common-scheduler/media/scheduling-multi-resource-2-options.png)

1. To add more details to a resource requirement, select **Open Form** and enter more filters for the schedule assistant.

1. On the **Scheduling** tab, choose the work location.

   - **Facility** work location implies the interaction takes place at the facility and travel time is calculated as the distance between the customer location and the facility location. The requirement's latitude and longitude fields are used as the customer location. It also means at least one facility or facility pool must return in schedule assistant search results in order for a resource to be returned.
  
   - **On Site** work location implies the interaction takes place at the customer location and travel time is calculated as the distance between the customer location and the resource (typically field technician) location, which is variable based on the resource's schedule that day. The requirement's latitude and longitude fields are used as the customer location. As a result, facility resources and facility pools are excluded from the results.

   - **Location Agnostic** work location implies the interaction takes place remotely and the location of the customer nor the resource is considered for scheduling. Travel time isn't applicable and isn't calculated. Facility resources can still be returned as part of the schedule assistant search, but travel time isn't displayed or considered in ranking.

1. **Save** the requirement group template.

## Create a requirement group

1. In Resource Scheduling, open the **Resource Scheduling** area. Under **Scheduling**, select **Requirement Groups**, and then select **New**.

1. Enter a **Name**.

1. To use a template, select an existing **Requirement group template** from the drop-down list and **Save**.

   To create your own requirement group, select **Save** and fill out the information for the group and its requirements. Refer to the Requirement group template for more information.

## Book a requirement group

Open a requirement group and select **Book** to launch the schedule assistant and get available resources that can fulfill the requirement group. By default, it recommends options that require the fewest resources first. Book the selected resource or resources. Then save and close the requirement group.

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
