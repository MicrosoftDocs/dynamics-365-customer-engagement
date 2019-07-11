---

title: Weekly time entry with support for customization
description: This topic provides information about how to implement custom business rules that support an organization's practices.
author: stsporen
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 07/09/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Weekly time entry with support for customization

[!INCLUDE[cc-applies-to-psa-app-3.x](../../includes/cc-applies-to-psa-app-3x.md)]

In Microsoft Dynamics 365 for Project Service Automation (PSA) version 3.3, we introduced a modern grid that allows project resources to complete a quick time entry for up to one week at a time. The grid includes the ability to total entries by date, by row, or by week. Resources can make copies of time entries within the week and then bulk copy from previous weeks. With this feature, system customizers can customize this view to add fields, add lookups to other entities, and implement custom business rules to support their organization's practices.  

Time entry, and the new weekly time grid, is accessed through the sitemap. The non-extensible custom time entry experience that was part of prior PSA versions has been replaced with the extensible weekly time entry grid in addition to an alternate experience on the read-only grid and calendar. With this change, users will be able to enter time in weekly amounts

## Page layout
The new weekly time entry grid is a custom control with a toolbar and two main sections, **Dimensions** and **Duration**. In addition to the ribbon on the top of the form, the toolbar includes an action button that applies to only this custom control for the time entry grid. The action buttons on the ribbon apply to the three types of controls that are supported for time entry; weekly time entry, read-only, and calendar control.  

### Dimensions 
The **Dimensions** section lists all the dimensions as column headers against which time duration can be entered. The following dimensions are supported out of the box: ‘

- Project
- Project Task
- Role
- Type
- Entry Status 

The **Dimensions** section does not allow inline editing. This section is backed by a view that enables support for custom fields to be added to the weekly time entry grid. Details on how to add custom fields is covered in detail in the **Extensibility** section later in this topic. 

### Duration
The **Duration** section lists the days of the week as column headers. This section can be edited inline. After a time entry row has been created with appropriate dimensions, users will be able to quickly enter time durations spent on those dimensions inline.

## Create a new time entry
To create a new time entry in the time entry grid, click **New**. This will open the **Time Entry Quick Create** page where users can choose the time entry date and enter data for the dimensions **Project**, **Project Task**, **Role**, and **Duration** in minutes, hours, or days by typing **h**, **m**, or **d**, along with the number. In addition, users can also enter a description and any external comments for the time entry. When saved, the values entered against the dimensions will appear in the **Dimensions** section. Duration information that is entered in the **Duration** field will appear on date for which the time entry was created. 

Lookup fields are backed by system views. For example, after the user enters a project, the **Project Task** field is set by default to the **Copy** view. To create time entries for tasks not assigned to a user, click **Change View** on the lookup dialog, and then select the view **All Active project tasks**.

## Edit a time entry
Details from some fields on the time entry page, such as **Description** and **External Comments** are not shown on the weekly time entry grid. Instead, a small triangle indicator is shown on the duration cell that has these additional details. Click **Edit Details** on the cell to view the data entered on the **Quick Edit** pane. Users will need to open the **Quick Edit** pane to edit or update the details for a specific time entry that is not part of the weekly time entry grid.

## Copy a time entry row
After the first time entry row has been created, users can select **Copy Row** to copy the entire row, including dimensions and duration, to a new row. Users can also select **Edit Row** to make updates to dimension values and edit the durations inline in the **Duration** section. 

## Open a time entry
To support optimal and quick entry on the most prominent fields, the weekly time entry grid displays a subset of chosen dimensions and time durations on the grid. To view all the details of a single time entry, under **Edit Entry**, select **Open**.

## Submit a time entry
Users can choose to submit a single time entry or group of time entries by choosing a block of cells or an entire time entry row. After the selection is made, select **Submit** to submit the selected time entries. Submitted time entries will appear as pending approval entries on the approvers’ **Approval** page. Successfully submitted time entries can't be edited.

## Recall a time entry
If needed, you can recall a submitted time entry. You can recall a single time entry, a block of time entries, or an entire row of time entries. Recalled time entries will be available to resources for editing.

## Time entry status
A new time entry is automatically assigned a status of **Draft**. When the time entry is submitted, the status is updated to**Submitted**. When a submitted time entry is approved, the status is updated to **Approved**. If the time entry is rejected, the status of the entry is changed to **Returned** and becomes be available for corrections and re-submission. Only time entries with a status of **Draft** can be deleted.

## View rejection comments
When a time entry is rejected by an approver, the approver may add rejection comments to help the resource understand the reason for rejection. To view rejection comments on a time entry, select **Open entry** to open the time entry entity form. The rejection comments will be displayed on the timeline. The resource can add a response to the rejection comments in the timeline prior to re-submitting the entry.  

### Copy week
After a few time entries have been created, **Copy week** allows users to bulk create additional time entries. Select **Copy week** to open the **Copy** dialog. Set the date range to copy the time periods the the **From period: Start Date: End date:** fields. Specify the date for which time entries are to be created in the **To Period Start Date:** field. Clicking **Copy** creates a copy of the time entries for the corresponding day of the week entered in the **To Period** field. For example, Monday's time entry from last week is copied into Monday for the week indicated in the **To Period** field.

### Import
Import from bookings, assignments, and exchange follows the same UI pattern, which allows a user to specify the date range from which bookings are imported. The user then must explicitly select the bookings that should be copied into draft time entries. Users no longer see the pattern from the previous release, where suggested time entries show up on the grid and calendar, and which were lost in session refresh. 

## Extensiblity
### Add custom fields with lookups to other entities
There are three parts to adding a custom field to the weekly time entry grid: adding the custom field to the quick create page, configuring the grid to show the custom field, and adding the custom field to the row or cell edit task flow as appropriate. 

You will also need to ensure that the new field has the necessary validations in the row or cell edit task flow. This includes locking the field based on the time entry status.  

### Add the custom field to the quick create form
You need to add the custom field to the **Create Time Entry Quick Create** page so that users can populate it when adding a time entry using the **New** button.

### Configure the grid to show the custom field
There are two options to add a custom field to the weekly time entry grid. The first is to customize the view **My Weekly Time Entries**  and add the custom field to that view. You can choose the position and size of the custom field in the grid by editing them in the view. 

The second option is to create a new custom time entry view and set it as default. This view should contain the **Description** and **External Comments** fields, in addition to the columns that you want to have in the grid. You can choose the position, size, and default sort of the grid by editing in this view. Next, you should configure the custom control for this view to be **Time Entry Grid**. Add this control to the view, and select it for web, phone, and tablet. Configure the parameters for the weekly time entry grid. **Start Date** should be **msdyn_date**, **Duration** should be **msdyn_duration**, and **Status** should be **msdyn_entrystatus**. For our default view, **Read-only Status List** is **192350002,192350003,192350004**, **Row Edit Task Flow** is **msdyn_timeentryrowedit**, and **Cell Edit Task Flow** is **msdyn_timeentryedit**; these can be customized to add or remove read-only statuses or to use a different task-based experience (TBX) for row or cell edit. These fields should be bound to a static value.

### Add the custom field to the appropriate edit task flow
The **TBX** pages used for editing are found under **Processes**, and the default pages are **Project Service - Time Entry Row Edit** and **Project Service - Time Entry Edit**. You can either edit these default pages or create new custom TBX pages. 

> [!NOTE]
> Either option will remove some out-of-the-box (OOB) filtering on **Project** and **Project Task**. All lookup views for the entities will be visible, whereas OOB only the relevant lookup views are enabled. 

You must determine the appropriate task flow for the custom field. Most likely, if you added the field to the grid, it should go in the row edit task flow for fields that apply to the entire row of time entries. If the custom field is unique per day, for example a custom field for **End time**, it should go in the cell edit task flow. 

To add the custom field to a task flow, drag a **Field** into the appropriate position on the page, and then set it's properties. **Source** should be Time Entry, and **Data Field** should be the custom field. **Field** is the display name on the **TBX** page. Select **Apply** to save the changes to the field. Select **Update** to save your changes to the page.

To use a new custom **TBX** page instead, create a new process. The category should be **Business Process Flow**, the entity should be **Time Entry**, and the business process type should be **Run process as a task flow**. Under **Properties**, the **Page name** should be the display name for the page. Add all of the relevant fields to the TBX page. Save and activate the process, and then update the custom control property for the relevant task flow to the value of **Nam** on the process (in the example, "new_customrowedit"). 

### Add a new option set value
To add option set values to OOB field, open the edit window for that field and click **Edit** next to the option set under **Type**. Next, add a new option with a custom label and color. If you want to add a new time entry status, the OOB field is **Entry Status** and not **Status**.

### Designate a new time entry status as read-only
To designate a new time entry status as read-only, add the new time entry value (the number, not the label) to the **Read-only Status List** property which will lock the editable portion of the time entry grid for rows with the new status. 

Next, add business rules to lock all of the fields on the **Time Entry Row Edit** and **Time Entry Edit TBX** pages. You can access the business rules for these pages by navigating to the business process flow editor for the page and selecting **Business Rules**. You can add the new status to the condition in the existing business rules or add a new business rule for the new status. 

### Add custom validation rules
There are two types of validation rules that you can add to the weekly time entry grid experience: 

- Client-side business rules that work on the **Quick Create** and **TBX** pages.
- Server-side plug-in validations which apply to all time entry updates.

### Business rules
Use business rules to lock and unlock fields, default fields, and define validations that only require information from the current time entry record. The business rules for a **TBX** page can be accessed by opening the business process flow editor for the form and then selecting **Business Rules**. This opens a window with the business rules for the **TBX** page where you can edit the business rules or add a new one. For even more customized validations, you can use a business rule to run JavaScript. 

### Plug-in validations
You should use plug-in validations for any validations that require more context than is available in a single time entry record or that you want to run on inline updates in the grid. To complete the validation, create a custom plug-in on the time entry entity. 

> [!IMPORTANT]
> At this time, there is a known issue on the **TBX** page when the update fails a plug-in validation. This prevents the user from correcting the information and reselecting **Done**. To work around this issue, set up business rule validations to prevent this situation as much as possible. 
