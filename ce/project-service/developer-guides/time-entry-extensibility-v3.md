# Weekly time entry with support for customization
Applies to Dynamics 365 for Project Service version 3.3 and above

## Introduction
With PSA v3.3 we introduced a modern grid that will allow project resources quick time entry for a week in one go. It includes features to total by date and by row, as well as the total for the whole week. Resources can make copies of time entries within the week and perform bulk copies from previous weeks. With this feature, system customizers can customize this view to add custom fields, lookups to other entities and implement custom business rules to support their organization's practices.  

## Features
Users access Time Entry via the sitemap and land on the default view of the new weekly time entry grid.  The non-extensible custom time entry experience that was part of prior version (v2.x and earlier) has been replaced with this extensible weekly time entry grid in addition to alternate experience on the native ‘read-only grid’ and ‘calendar’ user experiences. With this change, users will be able to enter time for one week at a time.

### Layout
The new weekly time entry grid is a custom control with a toolbar and 2 logical sections, namely  a ‘Dimensions’ section and the ‘Duration’ section. In addition to the ribbon on the top of the form, the control houses a toolbar with action button that applies to only this custom control. The action buttons on the ribbon applies to all 3 types of controls supported for time entry, ie;weekly time entry grid, read only grid and calendar control.  
#### Dimensions section
The left section of the dark splitter is the ‘Dimensions’ section which lists all the dimensions as column headers against which time duration can be entered against. The following dimensions are supported out of the box: ‘Project’, ‘Project Task’, ‘Role’, ‘Type’, ‘Entry Status’. The ‘Dimensions’ section does not inline editability yet. The dimensions section is backed by a view to enable support for custom fields to be added to the weekly time entry grid. Details on how to add custom fields is covered in detail in the Extensibility section. 
#### Duration section
The right section of the dark splitter is the ‘Duration’ section which lists the days of the week as column headers. This section is inline editable. Once a time entry row has been created with appropriate dimensions, users will be able to quickly enter time durations spent on those dimensions inline by moving across the section using keyboard ‘tab’ or mouse clicks.

### New
In order to create a new time entry, users click on the **New** button on the control toolbar. This invokes the time entry quick create form. Users can choose the time entry date and enter data for the dimensions ‘Project’, ‘Project Task’, ‘Role’ and ‘Duration’ in minutes, hours, or days by typing **h**, **m** or **d**, along with the number. In addition, users can also enter ‘Description’ and ‘External Comments’ for the time entry. On save, the values entered against the dimensions will appear in the ‘Dimensions’ section, duration entered on the duration field will appear on date for which the time entry was created. 

Lookup fields are backed by system views. For example, after the user enters a project, the **Project Task** field is set by default to the Copy view. To create time entries for tasks not assigned to a user, click **Change View** on the lookup dialog, and then select the view **All Active project tasks**.

### Edit Entry
Addition details on the time entry such as ‘Description’ and ‘External Comments’ are not shown on the weekly time entry grid. Instead a small triangle indicator is shown on the duration cell that has these additional details. Clicking on **Edit details** on the cell will show the data entered on the quick edit pane on the side. Users will need to invoke the quick edit pane to edit/update the details for specific time entry that is not part of the weekly time entry grid.

### Copy Row
Once the first time entry row has been created, **Copy Row** function allows copying the entire row (dimensions and duration) as a new row, users can now use **Edit Row** to make updates to appropriate dimension values and edit the durations inline on the ‘Duration’ section. 

### Open Entry
To support optimal and quick entry on the most prominent fields the weekly time entry grid displayed a subset of chosen dimensions and time duration on the grid. To view all the details of a single time entry, **Open** action is available under the **Edit Entry** dropdown.

### Time entry actions impacting the Entry Status
The Following time entry actions are supported:

#### Submit
Users can choose to submit a single time entry or group of time entries by choosing a block of cells or an entire time entry row. Once the selection is made, ‘Submit’ action on the control toolbar submits the chosen time entries. Submitted time entries will appear as pending approval entries on the approvers’ approval page. It will not be possible to edit submitted time entries once the submission is successful.

#### Recall
If needed submitted time entries can be recalled. Similar to selection for submission, a single submitted time entry or block of time entries or an entire row of time entries can be recalled. Recalled time entries will be available to resources for editing.

### Entry Status
A newly created time entry will appear with status *Draft*. On submission, this time entry transitions to *Submitted* state. When a time entry in *Submitted* state is successfully approved, this time entry transitions to *Approved* state. When the time entry was rejection by the approver, then the time entry state is updated to *Returned* and will be available for the resource for corrections and re-submission. Only time entries in *Draft* state can be deleted.

### Viewing Rejection comments
When a time entry is rejected by an approver, optionally the approver may add rejection comments to help the resource understand the reason for rejection. To view rejection comments on a time entry, **Open entry** must be invoked to open the time entry entity form. The rejection comments will be displayed on the timeline. The resource can add a response to the rejection comments in the timeline prior to re-submitting the entry.  

### Copy week
After a few time entries have been created, the **Copy week** allows users to bulk create additional time entries. Click the **Copy week** command to open the Copy dialog. Set the date range to copy the time periods from in the *From period: Start Date: End date:* fields. Specify the date for which time entries are to be created in the *To Period Start Date:* fields. Clicking Copy creates a copy of the time entries for the corresponding day of the week entered in the *To Period* field. For example, Monday's time entry from last week is copied into Monday for the week indicated in the *To Period* field.

### Import
Import from bookings, assignments and Exchange follows the same UI pattern, which allows a user to specify the date range from which bookings are imported. The user then must explicitly select the bookings that should be copied into Draft time entries. Users no longer see the pattern from the previous release, where suggested time entries show up on the grid and calendar, and which were lost in session refresh. 

## Extensiblity
### Add customer fields, with lookups to other entities
There are three parts to adding a custom field to the weekly time entry grid: adding the custom field to the quick create form, configuring the grid to show the custom field, and adding the custom field to the row or cell edit task flow as appropriate. 

You will also need to ensure that the new field has the necessary validations in the row or cell edit task flow (including locking based on status) – see the “Add custom validation rules” section below for details. 
#### Add the custom field to the quick create form
You need to add the custom field to the quick create form so that users can populate it when adding a time entry using the "New" button. The form to edit is "Create Time Entry". 
#### Configure the grid to show the custom field
There are two options to add a custom field to the weekly time entry grid. The first is to customize the view "My Weekly Time Entries" and add the custom field to that view. You can choose the position and size of the custom field in the grid by editing them in the view. 

The second option is to create a new custom time entry view and set it as default. This view should contain the "Description" and "External Comments" fields, in addition to the columns that you want to have in the grid. You can choose the position, size, and default sort of the grid by editing them in this view. Then, you should configure the custom control for this view to be "Time Entry Grid". Add this control to the view, and select it for web, phone and tablet. Then, configure the parameters for the weekly time entry grid. "Start Date" should be "msdyn_date", "Duration" should be "msdyn_duration", and "Status" should be "msdyn_entrystatus". For our default view, "Read-only Status List" is "192350002,192350003,192350004", "Row Edit Task Flow" is "msdyn_timeentryrowedit", and "Cell Edit Task Flow" is "msdyn_timeentryedit"; these can be customized to add or remove read-only statuses or to use a different TBX for row or cell edit. These fields should be bound to a static value.

#### Add the custom field to the appropriate edit task flow
The TBX forms used for the edit experience are found under "Processes", and the default forms are "Project Service - Time Entry Row Edit" and "Project Service - Time Entry Edit". You can either edit these default forms or create new custom TBX forms. Note that either option will remove some OOB filtering on "Project" and Project Task" -- all lookup views for the entities will be visible, whereas OOB only the relevant lookup views are enabled. 

You need to determine the appropriate task flow for the custom field. Most likely, if you added the field to the grid, it should go in the row edit task flow (for fields that apply to the entire row of time entries). If the custom field is unique per day (e.g. a custom field for end time), it should go in the cell edit task flow. 

To add the custom field to a task flow, drag a "Field" into the appropriate position on the form, then set its properties. "Source" should be Time Entry, and "Data Field" should be the custom field. "Field" is the display name on the TBX form. Click **Apply** to save the changes to the field. Click **Update** to save your changes to the form.

To use a new custom TBX form instead, create a new process. The category should be "Business Process Flow", the entity should be "Time Entry", and the business process type should be "Run process as a task flow". Under "Properties", the "Page name" should be the display name for the form. Add all relevant fields (using the process described above) to the TBX form. Save and activate the process. Then, update the custom control property for the relevant task flow to the value of "Name" on the process (in the example, "new_customrowedit"). 

### Add custom option set values to OOB fields
#### Add a new option set value
To add option set values to an OOB field, open the edit window for that field and click **Edit** next to the option set under "Type". Then, you can add a new option with a custom label and color. If you want to add a new time entry status, the OOB field is "Entry Status", not "Status".

#### Designate a new time entry status as read-only
First, you need to add the new time entry value (the number, not the label) to the "Read-only Status List" property to lock the editable portion of the time entry grid for rows with the new status. 

Then, you need to add business rules to lock all the fields on the Time Entry Row Edit and Time Entry Edit TBX forms. You can access the business rules for these forms by navigating to the business process flow editor for the form and clicking "Business Rules" at the top right. You can either add the new status to the condition in the existing business rules or add a new business rule for the new status. 

### Add custom validation rules
There are two types of validation rules that you can add to the weekly time entry grid experience: client-side business rules that work on the quick create and TBX forms, and server-side plugin validations which apply to all time entry updates. 

#### Business rules
You should use business rules for locking/unlocking fields, defaulting fields, and validations which only require information from the current time entry record. The business rules for a TBX form can be accessed by opening the business process flow editor for the form and clicking on "Business Rules" at the top right. This opens a window with the business rules for the TBX form, and you can edit the business rules or add a new one. You can use a business rule to run JavaScript for even more customized validations. 

#### Plugin validations
You should use plugin validations for any validations which require more context than is available in a single time entry record or that you want to run on inline updates in the grid. To do so, create a custom plugin on the time entry entity. However, there is a bug on the TBX forms when the update fails a plugin validation that prevents the user from correcting the information and clicking "Done" again; therefore, you should have business rule validations to prevent that situation as much as possible. 
