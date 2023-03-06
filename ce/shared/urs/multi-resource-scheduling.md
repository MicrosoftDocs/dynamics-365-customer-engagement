Requirement groups bundle requirements commonly scheduled together. For example, you may require a pre-inspection, an installation, and a final inspection every time a specific job is performed. With a requirement group, all three requirements can be created with a single template. Each requirement in the template can have different required characteristics, and the work can be scheduled as a single unit. When scheduling using the schedule assistant, resources will be selected that match the characteristics for each requirement.

## Create a requirement group template

1. In Universal Resource Scheduling, open the **Settings** area. Under **Scheduling**, select **Requirement Group Templates**, and then select **New**.

1. Enter a **Name** for the requirement group and **Save** it. The table shows requirement details with a root requirement named after the template.

1. Add requirements and fill in the fields in the columns. All requirements within a requirement group must have the same duration. Change the duration of individual bookings after booking the requirement group.

   To add more details to a resource requirement, select **Open Form**.

   The **All** or **Any** setting allows you to add multiple option for fulfilling a requirement group, which is done by adding subgroups. 
   If the root requirement is set to **Any**, and each subgroup is set to **All**, the schedule assistant searches for either **all of option 1** *or* **all of Option 2**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of requirement group with two options.](../../common-scheduler/media/scheduling-multi-resource-2-options.png)

2. In the **Select** column on the root requirement, choose the preferred option. The **All** option means that resources must fulfill all requirements. **Any** means that the system searches for resources that can fulfill any requirement and that fulfilling one requirement fulfills the entire requirement group.

   These settings are especially useful when you add multiple option sets to a requirement group using subgroups. For example, if a job requires a certain skill and a specific certification, one resource can fulfill both requirements (option set 1) or two resources can fulfill one requirement each (option set 2). Any of these combinations would fulfill the requirement group.

3. **Save** the requirement group template.

## Create a requirement group

1. In Universal Resource Scheduling, open the **Resource Scheduling** area. Under **Scheduling**, select **Requirement Groups**, and then select **New**.

2. Enter a **Name**.

1. Optionally, choose an existing **Requirement group template** from the drop-down list.

3. Edit the requirements in the requirement group as required.

## Book a requirement group

Open a requirement group and select **Book** to launch the schedule assistant and get available resources that can fulfill the requirement group. By default, it recommends options that require the fewest resources first. You can also sort by **Earliest Time First** in the left pane.

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

## Additional notes

- **A template is not required**. A requirement group can be created and booked without a template being created first. Templates are recommended for repeatable scenarios. 
- **Order matters**. By default, the schedule assistant results will favor requirements within a requirement group with fewer resources. If options within a requirement group require the same number of resources, the schedule assistant results will favor the requirements listed first.
- **Duration must be equal**. All requirements within a requirement group must have the same duration. Changing the duration of the root/subgroups or any of the requirements will change the duration of **all requirements** within a requirement group. Duration of individual bookings can be changed after the fact, depending on cascade settings.
- You can book directly from a template because creating a template automatically creates related requirements in the background. The actual template is not scheduled. This increases efficiency for scenarios where you want to schedule a requirement group and create a template at the same time. However, editing **start time** and **end time** is not available through the template, only through resulting requirements. 
- The following fields are kept in sync between requirements in a requirement group. Editing these fields for one requirement will update all requirements:
  - Duration
  - Start
  - End
  - Fulfillment preference
  - Booking Setup Metadata
  - Work location
  - Latitude
  - Longitude
- Updating a requirement group template does not update previously created requirements from that template, only new requirements.
- Crews can be an option for fulfilling requirement groups. However, a crew might have more resources than required by the requirement group and will therefore rank lower in schedule assistant search results.
- Requirement group templates can be associated with Incident Types in Field Service. When a work order is created with the incident type, the requirement group will be automatically associated with the work order. When using an incident type associated with a requirement group template, you can only relate a single incident to a work order.
