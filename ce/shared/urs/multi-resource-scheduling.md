Requirement groups bundle requirements that you commonly schedule together. When a job needs more than one resource — for example, two technicians with different skills, a technician plus specialized equipment, or a facility appointment that needs a room and a specific staff member — use requirement groups to schedule them all to the same time slot.

If the same group of people always works together, consider using [crews](../../field-service/resource-crews.md) instead. Requirement groups are for flexible combinations that change per job.

## Requirement group scheduling at a glance

| Step | What you do | Key detail |
|---|---|---|
| **1. Create a template** | Define a reusable set of requirements with a requirement group template. | Each requirement can have distinct characteristics and work locations. |
| **2. Create a group** | Create a requirement group from a template or from scratch. | Use **All** (all requirements filled) or **Any** (any one option works). |
| **3. Book the group** | Use the schedule assistant to find the best combination of resources. | The assistant finds resources that can all arrive at the same time. |

## Prerequisites

- Multiple [bookable resources](../../field-service/set-up-bookable-resources.md) with relevant [characteristics](../../field-service/set-up-characteristics.md).
- A requirement group template (optional, for reuse).

> [!IMPORTANT]
> Requirement groups can't be scheduled for multiple days. Use single requirements with [multi-day scheduling](../../field-service/schedule-multi-day-work.md) instead.

## Step 1: Create a requirement group template

1. In Resource Scheduling, open the **Settings** area. Under **Scheduling**, select **Requirement Group Templates**, then select **New**.

1. Enter a **Name** for the requirement group and **Save** it.

1. In the bottom panel, select the requirement group. Configure the following options for how the schedule assistant returns results:

   | Setting | Options | Details |
   |---|---|---|
   | **Select** | **All** (default) / **Any** | **All**: Resources must fulfill all requirements. **Any**: Resources can fulfill any requirement. Use subgroups to combine these — for example, set root to **Any** and each subgroup to **All** for the assistant to search for either **all of option 1** *or* **all of option 2**. |
   | **Part of Same** | **Location** / **Resource Tree** / **Organizational Unit** | Controls how strictly the assistant groups resources. **Location** uses [Bookable Resource Association](../../field-service/developer/reference/entities/msdyn_bookableresourceassociation.md) and [Bookable Resource Group](../../field-service/developer/reference/entities/bookableresourcegroup.md). **Resource Tree** adds type association. **Organizational Unit** (most stringent) checks only the parent org unit. |

   :::image type="content" source="../../common-scheduler/media/scheduling-multi-resource-2-options.png" alt-text="Screenshot of requirement group with two options.":::

1. Select **+ Requirements** to add requirements and fill in the fields in the columns. All requirements within a requirement group must have the same duration. Change the duration of individual bookings after booking the requirement group by setting the **Cascade Crew Changes** option on the **Scheduling** tab of the booking to **No**.

1. To add more details to a resource requirement, select a resource requirement in the form, then select **Open Form**, and enter more filters for the schedule assistant. For example, on the **Scheduling** tab, choose the work location:

   | Work location | Behavior |
   |---|---|
   | **Facility** | The interaction takes place at a facility. Travel time is calculated from the customer location to the facility. At least one facility or facility pool must return in results. |
   | **On Site** | The interaction takes place at the customer location. Travel time is calculated from the resource location to the customer. Facility resources and pools are excluded. |
   | **Location Agnostic** | The interaction takes place remotely. No location or travel time is considered. Facility resources can still appear, but travel time isn't displayed or ranked. |

   > [!NOTE]
   > You can select a maximum of 10 values per requirement for the following fields: Resource Categories, Characteristics, and Preferred Resource.

1. **Save** the requirement group template.

## Step 2: Create a requirement group

1. In Resource Scheduling, open the **Resource Scheduling** area. Under **Scheduling**, select **Requirement Groups**, then select **New**.

1. Enter a **Name**.

1. To use a template, select an existing **Requirement group template** from the drop-down list and **Save**.

      To create your own requirement group, select **Save** and fill out the information for the group and its requirements. Learn more in [Create a requirement group template](#step-1-create-a-requirement-group-template).

## Step 3: Book the requirement group

Open a requirement group and select **Book** to launch the schedule assistant and get available resources that can fulfill the requirement group. By default, it recommends options that require the fewest resources first. Book the selected resources. Then save and close the requirement group.

Booking an option for multiple requirements creates multiple bookings.

> [!NOTE]
> For onsite work, the schedule assistant looks for groups of resources that can **arrive at the same time**, not resources that can begin traveling at the same time.

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
