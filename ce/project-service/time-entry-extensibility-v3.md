---

title: Customize weekly time entry 
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

# Customize weekly time entry 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In Microsoft Dynamics 365 Project Service Automation version 3.3, Microsoft introduced a modern grid that lets project resources quickly enter time for up to one week at a time. The new weekly time entry grid can show totals for entries by date, by row, or by week. Resources can make copies of time entries within the week and also bulk-copy from previous weeks. System customizers can customize the view by adding fields, adding lookups to other entities, and implementing custom business rules to support their organization's practices.

Time entry and the new weekly time grid are accessed through the site map. The non-extensible custom time entry experience that was part of earlier PSA versions has been replaced by the extensible weekly time entry grid, and also by an alternative experience in the read-only grid and calendar. Because of this change, users can enter time in weekly amounts.

## Page layout
The new weekly time entry grid is a custom control that has a toolbar and two main sections, **Dimensions** and **Duration**. The toolbar includes a button that applies only to this custom control for the time entry grid. By contrast, the buttons on the Action Pane at the top of the page apply to the three types of controls that are supported for time entry: the weekly time entry control, the read-only control, and the calendar control.

### Dimensions
The **Dimensions** section shows, as column headings, all the dimensions that time can be entered against. The following dimensions are supported out of the box:

- Project
- Project Task
- Role
- Type
- Entry Status

The **Dimensions** section doesn't allow for inline editing. This section is backed by a view that enables custom fields to be added to the weekly time entry grid. For information about how to add custom fields, see the "Extensibility" section later in this topic.

### Duration
The Duration section shows the days of the week as column headers. This section allows for inline editing. After a time entry row is created that has appropriate dimensions, users can quickly enter, inline, the amount of time that they spent on those dimensions.

## Create a new time entry
To create a new time entry in the time entry grid, select **New**. The **Time Entry Quick Create** dialog box appears. In this dialog box, users can select the time entry date, and then enter data for the **Project**, **Project Task**, **Role**, and **Duration** dimensions in minutes, hours, or days by typing **h**, **m**, or **d**, together with the number. Users can also enter a description and comments that can be shared externally for the time entry. When users save their changes, the values that they entered against the dimensions appear in the **Dimensions** section. Duration information that they entered in the **Duration** field appears on the date that the time entry was created for.

Lookup fields are backed by system views. For example, after a user enters a project, the **Project Task** field is set to the **Copy** view by default. To create time entries for tasks that aren't assigned to a user, select **Change View** in the lookup dialog box, and then select the **All Active Project Tasks** view.

## Edit a time entry
Details from some fields on the time entry page, such as **Description** and **External Comments**, aren't shown in the weekly time entry grid. Instead, a small triangular indicator appears in duration cells that have these additional details. Select the cell, and then select **Edit Details** to view the data in the **Quick Edit** pane. To edit or update the details for a specific time entry that isn't part of the weekly time entry grid, users must open the **Quick Edit** pane.

## Copy a time entry row
After the first time entry row has been created, users can select **Copy Row** to copy the whole row to a new row. When a row is copied in this way, dimensions and durations are also copied. Users can also select **Edit Row** to update dimension values and durations inline in the **Duration** section.

## Open a time entry
To support optimal and quick entry in the most prominent fields, the weekly time entry grid show a subset of selected dimensions and time durations. To view all the details of a single time entry, under **Edit Entry**, select **Open**.

## Submit a time entry
Users can submit a single time entry or a group of time entries by selecting a block of cells or a whole time entry row, and then selecting **Submit**. Submitted time entries appear as entries that are pending approval on the approvers' **Approval** page. After time entries are successfully submitted, they can't be edited.

## Recall a time entry
You can recall time entries that you've submitted. You can recall a single time entry, a block of time entries, or a whole row of time entries. Recalled time entries are available to resources for editing.

## Time entry status
New time entries are automatically assigned a status of **Draft**. When a time entry is submitted, the status is updated to **Submitted**. When a submitted time entry is approved, the status is updated to **Approved**. If a time entry is rejected, the status is updated to **Returned**, and the entry becomes available for correction and resubmission. Only time entries that have a status of **Draft** can be deleted.

## View rejection comments
When a time entry is rejected by an approver, the approver might add rejection comments to help the resource understand the reason for the rejection. To view the rejection comments for a time entry, select **Open entry**. The rejection comments will be shown in the timeline. In the timeline, the resource can respond to the rejection comments before he or she resubmits the entry.

## Copy week
After a few time entries have been created, users can select **Copy Week** to bulk-create additional time entries. The **Copy** dialog box appears. In the **From period** section, use the **Start Date** and **End Date** fields to define the date range to copy time entries from. In the **To Period** section, in the **Start Date** field, specify the date to create time entries for. Then select **Copy**. For the specified date in the "to" period, a copy of the time entries for the corresponding day of the week in the "from" period is created. For example, Monday's time entry from last week is copied into Monday of the week that is specified as the "to" period.

## Import
The same basic process is used to import from bookings, assignments, and exchanges. Users can specify the date range that bookings are imported from. They must then explicitly select the bookings that should be copied into draft time entries. In the previous release, suggested time entries appeared in the grid and the calendar, and were lost when the session was refreshed.

## Extensibility
### Add custom fields that have lookups to other entities
There are three main steps to adding a custom field to the weekly time entry grid.

1.	Add the custom field to the quick create dialog box.
2.	Configure the grid to show the custom field.
3.	Add the custom field to either the row edit task flow or the cell edit task flow, as appropriate.

You must also make sure that the new field has the required validations in the row or cell edit task flow. As part of this step, you must lock the field, based on the time entry status.

#### Add the custom field to the quick create dialog box
You must add the custom field to the Create Time Entry Quick Create dialog box. so that users can enter a value for it when they add time entries by using the **New** button.

#### Configure the grid to show the custom field
There are two ways add a custom field to the weekly time entry grid. The first option is to customize the **My Weekly Time Entries** view and add the custom field to it. You can choose the position and size of the custom field in the grid by editing those properties in the view.

The second option is to create a new custom time entry view and set it as the default view. This view should contain the **Description** and **External Comments** fields, in addition to the columns that you want to have in the grid. You can choose the position, size, and default sort order of the grid by editing those properties in the view. Next, configure the custom control for this view so that it's a **Time Entry Grid** control. Add this control to the view, and select it for web, phone, and tablet. Next, configure the parameters for the weekly time entry grid. Set the **Start Date** field to **msdyn_date**, set the **Duration** field to **msdyn_duration**, and set the **Status** field to **msdyn_entrystatus**. For the default view, the **Read-only Status List** field is set to **192350002,192350003,192350004**, the **Row Edit Task Flow** field is set to **msdyn_timeentryrowedit**, and the **Cell Edit Task Flow** field is set to **msdyn_timeentryedit**. You can customize these fields to add or remove read-only status, or to use a different task-based experience (TBX) for row or cell editing. These fields should be bound to a static value.

#### Add the custom field to the appropriate edit task flow
The TBX pages that are used for editing can be found under **Processes**. The default pages are **Project Service - Time Entry Row Edit** and **Project Service - Time Entry Edit**. You can either edit these default pages or create new custom TBX pages.

> [!NOTE] 
> Both options will remove some out-of-box filtering on **Project** and **Project Task** entities, so that all lookup views for the entities will be visible. Out of the box, only the relevant lookup views are visible.

You must determine the appropriate task flow for the custom field. Most likely, if you added the field to the grid, it should go in the row edit task flow that is used for fields that apply to the whole row of time entries. If the custom field has a unique value every day, such as a custom field for **End time**, it should go in the cell edit task flow.

To add the custom field to a task flow, drag a **Field** element into the appropriate position on the page, and then set its properties. Set the **Source** property to **Time Entry**, and set the **Data Field** property to the custom field. The **Field** property specifies the display name on the TBX page. Select **Apply** to save your changes to the field. Then select **Update** to save your changes to the page.

To use a new custom TBX page instead, create a new process. Set the category to **Business Process Flow**, set the entity to **Time Entry**, and set the business process type to **Run process as a task flow**. Under **Properties**, the **Page name** property should be set to the display name for the page. Add all the relevant fields to the TBX page. Save and activate the process, and then update the custom control property for the relevant task flow to the value of **Name** on the process.

### Add new option set values
To add option set values to an out-of-box field, open the editing page for the field, and then, under **Type**, select **Edit** next to the option set. Next, add a new option that has a custom label and color. If you want to add a new time entry status, the out-of-box field is named **Entry Status**, not **Status**.

### Designate a new time entry status as read-only
To designate a new time entry status as read-only, add the new time entry value (the number, not the label) to the **Read-only Status List** property. The editable part of the time entry grid will be locked for rows that have the new status.
Next, add business rules to lock all the fields on the **Time Entry Row Edit** and **Time Entry Edit** TBX pages. You can access the business rules for these pages by opening the business process flow editor for the page and then selecting **Business Rules**. You can add the new status to the condition in the existing business rules, or you can add a new business rule for the new status.

### Add custom validation rules
There are two types of validation rules that you can add for the weekly time entry grid experience:
•	Client-side business rules that work in quick create dialog boxes and on TBX pages
•	Server-side plug-in validations that apply to all time entry updates

#### Business rules
Use business rules to lock and unlock fields, enter default values in fields, and define validations that require information only from the current time entry record. You can access the business rules for a TBX page by opening the business process flow editor for the page and then selecting **Business Rules**. You can then edit the existing business rules or add a new business rule. For even more customized validations, you can use a business rule to run JavaScript.

#### Plug-in validations
You should use plug-in validations for any validations that require more context than is available in a single time entry record, or for any validations that you want to run on inline updates in the grid. To complete the validation, create a custom plug-in on the **Time Entry** entity.

> [!IMPORTANT] 
> Currently, a known issue on the TBX pages prevents users from correcting information and reselecting Done when an update fails a plug-in validation. As a workaround, set up business rule validations to prevent this situation as much as possible.
