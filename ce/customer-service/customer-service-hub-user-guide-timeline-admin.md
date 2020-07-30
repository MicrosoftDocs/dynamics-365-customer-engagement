---
title: "Configuring Timeline | MicrosoftDocs"
description: "Timeline configuration overview for administrators"
ms.date: 07/27/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Configuring Timeline 

The timeline control provides an easy and immersive experience to view information related to an entity, such as cases, accounts, or contacts which gives users a better understanding  and helps them deliver more personalized service in an efficient and effective manner. 

This experience gives system administrators the ability to configure the information displayed in each timeline to help users access information and create new activity records, such as emails and tasks directly from the timeline quickly so they can deliver more personalized service. 

## How to navigate to timeline configurations

Timelines are located on forms within entities. To access timeline configurations, you must start with the entity list.  You can access the entity list a couple of ways depending on the model-driven app you are using.

To access the entities list via **Power Apps**, go to:
1.	Go to **Power Apps** URL: [make.powerapps.com](https://make.powerapps.com "make.powerapps.com")
2.	Under **Data** section.
3.	Select **Entities**.

  ![How to navigate to timeline configurations - Option 2](media\timeline-access-option-2.png "How to navigate to timeline configurations - Option 2")

> [!Important] 
> When accessing timeline, if you are not taken to the new form designer experience in Power Apps, you are not using the latest experience.

### Select an entity form for timeline configuration

Every instance of the timeline that’s applied on a form can be configured.  Example: An Account entity will have forms, and each form can have a timeline that can be configured.  However, there’s only one timeline per form.  

To begin, select the entity and form where you want to add and configure your timeline. 
1.	The following is a list of entities. You can add a timeline to any entity.
2.	For this example, we selected the **Account** entity.
3.	From the **Account** entity landing page there is list of tabs at the top, select **Forms**.
4.	The **Forms** landing page displays a list of **Form types**. Timelines can only be used on **Main** form types.
5.	For this example, we selected **Account for Interactive experiences**. 

![How to navigate to timeline configurations](media\timeline-configuration-1.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-2.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-3.png "How to navigate to timeline configurations")

![How to navigate to timeline configurations](media\timeline-configuration-4.png "How to navigate to timeline configurations")

### Adding or removing a timeline from an entity form

Timeline is a component and you will need to access **Components** to make timeline configurations. Once you have selected a **Main** form type, the following landing page will appear:

1. From the left nav, select **Components**.  
2. In the left nav, scroll down to the **Timeline** component, then drag and drop in a section on the form. 
3. If **Timeline** component is greyed out, it means it already exists on the form. You can only have one timeline per form.
4. To remove the **Timeline** component from a form, highlight the inside **Timeline** component area and hit the **Delete** key.  This will remove the **Timeline** component from the form.

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-1.png "Adding or removing a timeline from an entity form")

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-2.png "Adding or removing a timeline from an entity form")

![Adding or removing a timeline from an entity form](media\timeline-add-or-remove-entity-from-form-3.png "Adding or removing a timeline from an entity form")

> [!Note] 
> Since the timeline component relies exclusively on underlying related data, it will always say Almost there when added to the timeline section. Since we are in a create and/or edit state on the form, there’s no underlying data, therefore the area is blank.

## Understanding the timeline component on the form

In the body of the entity form located in the center there is an area titled TIMELINE section and within that section is another area titled Timeline.  The following outlines and clarifies the different between these two:     

1.	The outside section (titled **TIMELINE**) is what houses the **Timeline** component. 
2.	When you select **TIMELINE**, the **Display options** under the **Properties** tab in the right nav change to support the **TIMELINE** section.
3.	Inside the **TIMELINE** section is where the **Timeline** component is located.
4.	When you select the **Timeline** component, the **Display options** under the **Properties** tab in the right nav change to support the **Timeline** component items.

![Understanding the timeline component on the form](media\timeline-component-1.png "Understanding the timeline component on the form")

![Understanding the timeline component on the form](media\timeline-component-2.png "Understanding the timeline component on the form")

## How to configure timeline component

The timeline component is rich in features and functionality that can be configured and tailored to support specific business needs.  The Timeline form is comprised of features and functionality you configure in the timeline component which is then displayed in the entity form.

The following overview provides a detailed breakdown of each timeline feature, what it supports, how it is configured, and how it is displayed in the corresponding timeline section on the entity form:

- **Display options** 
  - [Timeline component name](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#timeline-component-name)
  - [Records shown on page](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#records-shown-on-page)
  - [Record types shown](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#record-types-shown) 
  - [Advanced](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#advanced)

- **Record settings** 
  - [Activities](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#advanced)
  -	[Notes](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#notes)
  -	[Posts](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-timeline-overview#posts)

- **[How to create and add custom activities](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-custom-activity-in-timeline)**

## Display options 

### Timeline component name

The **Name** field under the **Properties** tab in the **Display options** section is only there as Admin’s reference. 

1.	In the **Name** field, you can change Timeline to another name.
2.	For this example we changed the **Name** field to, **Bob**. 
3.	The **Name** ‘Bob’ does not display on the rendered form.  The name change is for Admin reference only. 
4.	If you use the Name feature, there are character limitations.  For example, you cannot have spaces, you must use underscores (_).

![Display options - Timeline component name](media\timeline-component-name-display-options-1.png "Display options - Timeline component name")

![Display options - Timeline component name](media\timeline-component-name-display-options-2.png "Display options - Timeline component name")

### Records shown on page

This section allows you to control the number records that appear before displaying Load more at the bottom of the section.

1.	The default setting on the Records shown on page is set to 10 records. You can update this to any number, there is no limit.
2.	Pre the default setting shown in this example, the form shows a max. of 10 records, but you can display up to 50 records.
3.	Once records exceed 10, Load more feature appears at the bottom of the form to display more records. 

![Display options - Records shown on page](media\timeline-records-shown-on-page-display-options-1.png "Display options - Records shown on page")

### Record types shown

There are three (3) primary record types which include: activities, notes, and posts.  All record types are enabled by default.

- **Activities** can have a large number of customizable sub-activity record types to support business needs. Depending on what you have installed, Admin can create, add, and display a number of different customized sub-activity record types under the Activity section of the drop-down menu on the timeline.    
- **Notes** allow you to capture notes related to the entity record. Use notes to grab thoughts, summary information, and provide feedback on a case for example and include edits whenever you want. 
- **Posts.**  There are two types of posts, Auto Posts and User Posts. 
    - **Auto Posts** are system generated and notify you of account activity that has occurred. 
    - **User Posts** allows you leave a message for another user on a record.

This section allows you to enable these record types to display in timeline. 

1.	To enable **Record types shown** for Activities, Notes, and Posts on a form simply check the box next to the record  type you want to show.
2.	To confirm the record type is displaying on the form, click on the ![](media\timeline-create-a-record-icon.png "Create a timeline record icon") (Create a timeline record icon) in the top right nav in timeline. 
3.	A drop down will appear and display the list of enabled record types.
4.	When you enable **Activities**, you see **Activity** record types: Applications, email, phone calls, tasks on the form.
5.	When you enable **Notes**, you see Note record types on the form.
6.	When you enable **Posts**, you see Post record types on the form.

![Display options - Record types shown](media\timeline-record-types-shown-display-options-1.png "Display options - Record types shown")

> [!Note]
> Activities, noted, and posts are standard entities. If your administrator or system customizer has configured other entities, then those will appear.

### Activity, note, post icons and date / timestamp display on timelines

The timeline shows a simple icon before the activity, post, note, and custom entity making it easy for you to identify the record type. Dates and timestamps will always appear on each record on the bottom right of the preview.

1. Activity record icons
2. Note icons
3. Post icons
4. Date/timestamp display can be viewed at all times.

![Display options - Activity, note, post icons and date / timestamp display on timelines](media\timeline-activity-note-post-icons-and-timestamp-display-display-options-1.png "Display options - Activity, note, post icons and date / timestamp display on timelines")

## Advanced

The **Advanced** feature works across and is independent of all record types and is collapsed by default. Also, when enabling and disabling **Advanced** features you will not be able to view updates (even though it may appear there is activity occurring on the timeline component) until you save and publish your configuration updates and refresh the entity form. 

**Advanced** covers common settings that span across an activity, note, or post, which are the three (3) primary record types that appear in the timeline section. 

### Quick entry record type and sort order default

The following is a detailed overview of the **Advanced** configuration options starting with selecting your **quick entry record type**:

1.	Select **Advanced** to expand this feature in the configuration view.
2.	The **Quick entry record** type provides you with quick access to create either a **Note** or a **Post**.  The default setting for this feature is set to **Notes**.  
3.	When you select **Notes** it will display under the search bar in timeline. Also, you will see a paperclip icon which allows you to attach files. You can only attach files to Notes.
4.	When you select **Posts** it will display under the search bar in timeline. 
5.	The **Sort order default** feature controls the order of how all data is sorted on the timeline.  The default setting for this feature is set to Descending. 

![Display options - Advanced - Quick entry record type and sort order default](media\timeline-quick-entry-record-type-and-sort-order-default-display-settings-advanced-1.png "Display options - Advanced - Quick entry record type and sort order default")

### Enable filter pane

Using filters provides a quick option to sort and look for specific data quickly. 
 
6.	The **filter pane** feature allows you to enable or disable filter functionality on timeline. It is enabled by default.
7.	Enable the **filter pane** by checking the box next to the feature.  This will enable the filter icon to display on the timeline.
8.	To disable the **filter pane**, uncheck the box next to the feature and the filter icon will no longer appear on the timeline. 

![Display options - Advanced - Enable filter pane](media\timeline-enable-filter-pane-display-options-advanced-1.png "Display options - Advanced - Enable filter pane")

### How to filter activity types on timeline

Filters are valuable for sorting data. You can quickly filter activities, posts, and notes with multiple options to see what matters to you. The filter is available for the activities, posts, notes, and custom entities that are present in timeline. Timeline filters and displays the records and the count that are present in the timeline.

You can customize data using the data filters and either choose to keep filters in place or clear them when you are done.

a. When the **Filter** icon is transparent on the entity form, it means there are no items that have been chosen to filter by and there the filter is unpopulated.<br>

b. When the **Filter** icon is filled in, it means filters has been selected and set. To view what filters have been selected you can just click on the ![](media\timeline-filter-icon.png "Filter icon") **Filter** icon and the display will open showing which filters have been set.</li>

c. When you select the ![](media\timeline-filter-icon.png "Filter icon") **Filter** icon the following list appears.<br> 

d. You can select how you want to filter your data by checking the box next to the filter.<br>

e. You can clear filters by clicking on the ![](media\timeline-clear-all-filters-icon.png "Clear all filters icon") **Clear all filters** icon.

![Display options - Advanced - How to filter activity types on timeline](media\timeline-how-to-filter-activity-types-display-options-advanced-1.png "Display options - Advanced - How to filter activity types on timeline")

When you select the filter icon, the Filter by menu is displayed and you can filter items based on the following categories:

|Category                   |Sub-category                            |
|---------------------------|----------------------------------------|
|Record type                |<li>Notes</li>                     <li>Posts</li><li>Activities</li>                     |
|Activity type              |<li>Appointment</li><li>Campaign Activity</li> <li>Campaign Response</li><li>Email</li><li>Fax</li><li>Case Resolution</li><li>Letter</li><li>Opportunity Case</li>   <li>Order Case</li><li>Phone Call</li><li>Quote Close</li>           <li>Recurring Appointment</li><li>Social Activity</li><li>Task</li>   <li>Project Service Approval</li><li>Booking Alert</li><li>Conversation</li><li>Session</li><li>Customer Voice survey invite</li><li>Customer Voice survey response</li><li>Custom activities (as configured by your administrator)</li>|
|Activity status            |<li>Active</li><li>Overdue</li>       <li>Closed</li>                         |
|Activity due date (active) |<li>Next 30 days</li><li>Next 7 days</li><li>Next 24 hours</li><li>Last 24 hours</li><li>Last 7 days</li>   <li>Last 30 days</li>                   |
|Posts by                   |<li>Auto post</li><li>Users</li>                          |
|Modified date              |<li>Last 24 hours</li><li>Last 7 days</li><li>Last 30 days</li>                   |

When you use the filter based on an activity status then those activities, notes, and posts are displayed:

**a.** Select an activity item. In this example we selected <b>Overdue</b>.
<br>

**b.** Based on our selection, all activity items with an <b>overdue status</b> now appear.<br>

**c.** <b>Filter</b> icon is filled in telling you a filter item has been selected.<br>

**d.** To clear filter selections, click on the ![](media\timeline-clear-all-filters-icon.png "Clear all filters icon") <b>Clear all filters</b> icon to clear all filters.

![Display options - Advanced - How to filter activity types on timeline](media\timeline-how-to-filter-activity-types-display-options-advanced-2.png "Display options - Advanced - How to filter activity types on timeline")

### Expand filter pane 

The **Expand filter pane** feature provides quick access to sorting options within timeline.  It is enabled by default.

9.	The **Expand filter pane by default** feature displays an expanded filter pane at the top of the form anytime it is opened and refreshed and is disabled by default.
10.	Enable the **Expand filter pane** by checking the box next to the feature.  This will enable the filter pane to appear at the top of the form anytime the form is opened and refreshed.
11.	To disable the **Expand filter pane**, uncheck the box next to the feature and the filter pane will not appear on the timeline.

![Display options - Advanced - Expand filter pane ](media\timeline-expand-filter-pane-display-options-advanced-1.png "Display options - Advanced - Expand filter pane")

### Enable search bar

You can easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title of the record or body and description fields of the record then displays the record for you. 

12.	The **search bar** feature enables the **Search timeline** bar functionality and is enabled by default.
13.	Enable the **search bar** feature and it will display a **search bar** at the top of the timeline form.
14.	To disable the search bar uncheck the box next to the feature and the search bar will no longer on the timeline. 

![Display options - Advanced - Enable search bar](media\timeline-enable-search-bar-display-options-advanced-1.png "Display options - Advanced - Enable search bar")

### Expand all records in timeline

**Expand all records by default** displays all activities in an expanded view in timeline. 

15.	**Expand all records** is disabled by default.
16.	Enable the **Expand all records** by checking the box next to the feature, this will now allow records to expand and display in the form by default each time it is opened. 
17.	To disable **Expand all records**, clear the box next to the feature it will no longer display activities in an expanded view.

![Display options - Advanced - Expand all records in timeline](media\timeline-expand-all-records-display-options-advanced-1.png "Display options - Advanced - Expand all records in timeline")

### Expand records with images in timeline

You can send and receive records with images, but they will not display when the record is collapsed. Records with images must be expanded to be viewed.

**a.** Records when collapsed provide a visual summary.<br>

**b.** To expand an individual record, click anywhere on the timeline record to expand and collapse.  In the bottom right corner of the record there is a caret:  
<li>When the caret is facing downward (˅) the record is collapsed.</li> 
<li>When the caret is facing upward (^) the record it expanded.</li> 

**c.** Records with images will often display the following notice. When you click on this message the warning will go away. 

![Expand records with images in timeline](media\timeline-expand-records-with-images-display-optiones-advanced-1.png)

If you don’t see a message and the image is not displaying, see [Timeline FAQs](timeline-faqs.md) for more information.
<li> Once you click on the warning message, the image will display.</li>

![Display options - Advanced - Expand records with images in timeline](media\timeline-expand-records-with-images-display-optiones-advanced-2.png "Display options - Advanced - Expand records with images in timeline")

### Enable “What you’ve missed” summary

**What you’ve missed** helps you stay on top of updates and changes made records by displaying updates at the top of the timeline when you access a record. 

18.	The **What you’ve missed** feature displays new records you have not seen and it is disabled by default.
19.	To enable **What you’ve missed**, select the box next to the feature. Now when you view a customer’s account, a box will appear at the top of the timeline section notifying you updates. 
20.	To disable **What you’ve missed**, uncheck the box next to the feature and you will notifications will not display when you access an account.

![Display options - Advanced - Enable “What you’ve missed” summary](media\timeline-what-you-missed-display-options-advanced-1.png "Display options - Advanced - Enable “What you’ve missed” summary")

## Record Settings

The **Record types to show** is tied to the **Record settings** which supports Activities, Notes, and Posts in the timeline.

1.	The **Record settings** allows you manage the settings within the record types. 
2.	**Activities** record type is tied to **Activities** in record settings.
3.	**Notes** record type is tied to **Notes** in record settings.
4.	**Posts** record type is tied to **Posts** in record settings.
5.	To enable or disable a record type simply check or uncheck the box and that record type will either display or no longer appear in the **Record settings** section.

![Display options - Advanced - Record Settings](media\timeline-record-settings-display-options-advanced-1.png "Display options - Advanced - Record Settings")

### How to configure activity record types

When you expand the **Activities record settings** on the timeline component section a list will display showing all the activity types that can be either enabled or disabled on the entity form. 

1.	Click the upward facing caret (^) to expand and view **Activities** under **Record settings**.
2.	Once expanded, a list of **Activity types** is displayed.
3.	When you select **Activity type**, a fly-out appears. 
4.	To enable an **Activity type**, click the box next to **Enable** and select **Done**.
5.	To disable an **Activity type**, uncheck the box next to **Enable** and select **Done**. This will grey out all other items in the box and disable the activity type from displaying on the timeline.  This also disables the activity type from being created or viewed in timeline.  
6.	When you enable an **Activity type**, it will appear in a drop down box when you click on the ![](media\timeline-create-a-record-icon.png "Create a timeline record") icon to **Create a timeline record** in the top right nav in the timeline section of the entity record. 
7.	Also, the **Activity type** can be viewed in the body of the timeline section of the form. 

> [!NOTE]
> A check mark appears on the right next to enabled **Activity types**.  Additional settings for a record type are disabled until you enable the record type.  

![Display options - Advanced - How to configure activity record types](media\timeline-how-to-configure-activity-record-types-display-options-advanced-1.png "Display options - Advanced - How to configure activity record types")

### Enable status tags on activity record types

Status tags match the status filter and displays in the timeline to help you to see at a glance the **Active**, **Overdue**, or **Closed** state of the activity record, such as on a task, appointment or email.  Admin can enable or disable status tags for any **Activity type** in the **Record settings**. Status tags are enabled by default.

8.	Check the box next to **Enable status tag** functionality to display status tags on activity types on the timeline.  
9.	When enabled, status tags such as **Active**, **Overdue**, or **Closed** will appear in the timeline for that activity.

![Display options - Advanced - Enable status tags on activity record types](media\timeline-enable-status-tags-on-activity-record-types-display-options-advanced-1.png "Display options - Advanced - Enable status tags on activity record types")

### Enable the ability to create directly from timeline

Having the ability to quickly click and create an activity such as, an email, task, appointment, etc. streamlines productivity.  Admins have the ability to enable activity types so they can be created directly on the timeline.    

10.	Check the box next to **Create directly from timeline** to enable.
11.	When enabled, the activity type will appear in a drop down box when you click on the ![](media\timeline-create-a-record-icon.png "Create a timeline record") **Create a timeline record** icon in the top right nav in the timeline section of the entity record.

![Display options - Advanced - Enable the ability to create directly from timeline](media\timeline-enable-ability-to-create-directly-from-timeline-1.png "Display options - Advanced - Enable the ability to create directly from timeline")

### Create and use card forms in timeline

Records are displayed using the default setting for each activity type. However, if you want to display record information for an appointment or email, for example, you can either edit the existing card form, use a different card form from record settings, or customize your own. 

12.	You can change the default card settings to a different card form if one has been created.  
13.	If you create a new card form, you must go to the parent entity and add the new form of card type there before it will appear in the timeline list for configuration.  If **Default** is displayed, you are not using the card form.  You can not use the **Email card form** in timeline unless you select and publish it first.	

> [!NOTE]
> Not all activity types allow you to create card types, so the default selection will be you’re only option for those records.

![Display options - Advanced - Create and use card forms in timeline](media\timeline-create-and-use-card-forms-display-options-advanced-1.png "Display options - Advanced - Create and use card forms in timeline")

### How to customize a card from in timeline

All card forms are broken out into the following four (4) sections:

**a.** **ColorStrip Section.** This section does not appear on the timeline record. The **ColorStrip** is located on the left of the card form.<br>

**b.** **Header Section.** This section is displayed on the timeline record, however only the first two fields are displayed on the timeline record. For this example, only the **Subject** and **Modified On** fields are visible.<br>

**c.** **Details Section.** This section is displayed on timeline record, however only the first three fields are displayed on the timeline record. For this example, only the **To**, **CC**, and **Description** fields are visible on the timeline record.<br>

**d.** **Footer Section.**	This section is not displayed on the timeline record.<br>

**e.** **Entity Fields.** You can select which fields you want to add to your card form from the field options listed on the right.  You can customize your card form by dragging and dropping the fields you want to use into the sections you want that field to appear in on the timeline record.

![Display options - Advanced - How to customize a card from in timeline](media\timeline-customize-card-form-display-option-advanced-1.png "Display options - Advanced - How to customize a card from in timeline")

Each individual card form has to be customized for each activity record such as email, tasks, posts, etc. 

**Header Section**<br>
The displays the title/subject in your timeline email form. You can have up to six (6) fields in the Header section, only the first two (2) fields will be seen on the timeline record. Also empty fields will be ignored by the form in all sections.<br>

<ol>
<b>f.  Header - Field 1.</b> Regardless of the field you choose, it will appear as a bold header at the top of your timeline record. For this example we selected <b>Subject</b> for this field.<br>

**g.**	**Header - Field 2.** Again regardless of the field you choose, this field appears in the bottom right corner of the timeline record.  For this example we selected **Modified On** for this field.
</ol>

**Details Section** <br>
This displays in the body of your the timeline email record. You can have up to four (4) fields in the **Detail** section, but only the first three (3) fields are seen on the timeline record.

<ol>
<b>h.	Details - Field 1.</b> As before, regardless of the field you choose, this field will always appear below the Header - Field 1 as a sub-header on the timeline record. For this example we selected <b>To</b> for this field.<br>

**i.**	**Details - Field 2.** This field will display one line of text in a summary view on the timeline record.  When you expand your timeline record,  content in this field is fully displayed with format. For this example we selected **CC** for this field.<br>

**j.**	**Details - Field 3.** This field follows the content in Details -Field 2 and is part of the main body of your timeline record that is only viewable when you expand the record. For this example we selected **Description** for this field.
</ol>

**Footer Section**<br>
This section is not visible on the timeline record.  

<ol>
<b>k.	Footer – Field 1.</b> For this example we selected **Owner** for this field.<br>

**l.**	**Footer – Field 2.** For this example we selected **Regarding** for this field.<br>

**m.**	**Footer – Field 3.** For this example we selected **Priority** for this field.
</ol>

![Display options - Advanced - How to customize a card from in timeline](media\timeline-how-to-configure-activity-record-types-display-options-advanced-2.png "Display options - Advanced - How to customize a card from in timeline")

### How to set date in the sort activities by feature in timeline

How you view data is important and setting a default display view of your data varies based on the needs of your business. Admins can choose how data is sorted and create a default sort setting for **Activity types** in **Record settings**. **Last Updated** is on all activities which is why it is set as the default in ascending order.    

14.	The **Sort activity by** feature in the **Activities record settings** allows you to control how data is sorted in timeline.  
15.	When you select the **Sort activities by** field, a list appears. You can select from this list how you want your data to be sorted and displayed on timeline in the form.

There are some unique date fields, for example:<br> 

<ol>
16a. <b>Date sent.</b> This only occurs in email. If you sort by Date sent, most activities will not contain a Date Sent and therefore will be grouped together without any ordering.<br>

16b. **Sort date.**  You cannot create a custom date field.  If you create one, it will not display, so in answer to this, **Sort date** was created.  It does not have a value and therefore allows you to choose your own.  Is empty by default.
</ol>

> [!IMPORTANT]
> Sort date is intended for users to programatically program and map each activity with a date of choice to have more control.  It’s a cusomization option that allows you to sort activities any way you want by whatever date you want.  You will have to populate each field and it requires that you update all activities to populate the Sort date with a value.  However, once you complete configurability you have flexiblity to sort anyway you want.  

> [!NOTE]
> Sort dates have to be configured for each timeline instance and set up must be completed in all three main forms for the Account enity in order to work.

![Display options - Advanced - How to set date in the sort activities by feature in timeline](media\timeline-how-to-set-date-in-sort-activities-by-feature-1.png "Display options - Advanced - How to set date in the sort activities by feature in timeline")

### How to set create activities form type in timeline

The **Create activities** feature allows you to choose which type of form you want to work in based on your business needs.  

- **Quick create form** appears in a model on the right. There are some activities which do not support quick create that will always use email for example. For more information, see [Create or edit model-driven app quick create forms for a streamlined data entry experience](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-quick-create-forms).

- **Main form** navigates you to the activity entity main form. For more information, see [Create or edit a model-driven app main form for an entity](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-main-forms).

17.	 Select **Create activities** using feature to select either a **Quick create form** or **Main form**.

> [!NOTE]
> If a **quick create** form for an activity has not been created, then the main form will be used. If **quick create** form is not supported, such as with email, the **main form** will always be used. 

![Display options - Advanced - How to set create activities form type in timeline](media\timeline-how-to-set-create-activities-form-type-1.png "Display options - Advanced - How to set create activities form type in timeline")

### Timeline performance impacts

You only want to enable activities that you need on this form. When working with 10 or more **Activity types**, you will receive a warning notice letting you know the number of activity types you have selected impacts the performance speed on your timeline.  To improve timeline performance speed, consider limiting activity types to 10 or less. 

18.	Warning notice will display when you select more than 10 activity types

![Display options - Advanced - Timeline performance impacts](media\timeline-performance-impacts-1.png "Display options - Advanced - Timeline performance impacts")

## Notes on timeline

Use the following steps for **Notes**:

1. Select **Notes**
2. The section will expand to see **Coming soon** which indicates you have **Notes** enabled. 
3. Once enabled, you can now click on the ![](media\timeline-create-a-record-icon.png "Create a timeline record") (Create a timeline record) icon 
4. Flyout will appear. Select **Notes**
5. Begin writing your **Note** using rich text and just click **Add Note** at the bottom to save.

![Notes on timeline](media\timeline-notes-1.png "Notes on timeline")

## Posts on timeline

Use the following steps for **Posts**:

1. Select **Post**
2. The section will expand to see **Coming soon** which indicates you have **Post** enabled. 
3. Once enabled, you can now click on the ![](media\timeline-create-a-record-icon.png "Create a timeline record") (Create a timeline record) icon 
4. Flyout will appear. Select **Posts**
5. Begin writing your **Post**.

![Posts on timeline](media\timeline-posts-1.png "Posts on timeline")

## Save and publish timeline updates and changes

Before you can view any configuration changes on the entity form, you must save and publish your updates first on the timeline component. 

1.	Before you can publish, you must **Save** any changes made in the timeline component first
2.	Once your configuration changes are saved, select **Publish**.  Timeline updates are now live in your timeline environment and can be viewed.

    ![Save and publish timeline updates and changes](media\timeline-save-and-publish-updates-and-changes-1.png "Save and publish timeline updates and changes")

## How to configure dashboard timelines

Timelines can be configured and put on a dashboard. However, dashboards are not supported by Power Apps. For more information see [Set up timeline section (control)](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control).

> [!NOTE]
> Capabilities on a dashboard timeline are different than those in an embedded dashboard timeline.  For more information see [Create or edit model-driven app dashboards](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-dashboards).

## How to create and add custom activities to timeline

You can create custom entities to display on the timeline by enabling specific options during the creation of the entity. See the [How to create and add custom activities](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control#enable-custom-activity-in-timeline) for a step by step guide.

### See Also

[Timeline FAQs](timeline-faqs.md)
