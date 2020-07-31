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

## Navigate to timeline configurations

Timelines are located on forms within entities. To access timeline configurations, you must start with the entity list.  You can access the entity list a couple of ways depending on the model-driven app you are using.

To access the entities list via **Power Apps**, go to:
1.	Go to **Power Apps** URL: [make.powerapps.com](https://make.powerapps.com "make.powerapps.com")
2.	Under **Data** section.
3.	Select **Entities**.

  ![Select Entities in Power Apps navigation pane](media\timeline-access-option-2.png "Select Entities in Power Apps navigation pane")

> [!Important] 
> When accessing timeline, if you are not taken to the new form designer experience in Power Apps, you are not using the latest experience.

### Select an entity form for timeline configuration

Every instance of the timeline that’s applied on a form can be configured.  Example: An Account entity will have forms, and each form can have a timeline that can be configured.  However, there’s only one timeline per form.  

To begin, select the entity and form where you want to add and configure your timeline. 

1. The following is a list of entities. You can add a timeline to any entity.

    ![List of entities in Power Apps](media\timeline-list-of-entities-power-apps.png "List of entities in Power Apps")

2.	For this example, we selected the **Account** entity.

    ![Select Account in the entity list](media\timeline-select-account-entity-list.png "Select Account in the entity list")

3.	On the **Account** entity page, select **Forms**.

    ![Select Form tab](media\timeline-select-form-tab.png "Select Form tab")

4.	The **Forms** landing page displays a list of **Form types**. Timelines can only be used on **Main** form types.

    ![Forms of type Main](media\timeline-form-type-main.png "Forms of type Main")

5.	For this example, we select **Account for Interactive experiences**. 

### Add or remove a timeline from an entity form

Timeline is a component and you'll need to access **Components** to make timeline configurations. After you've selected a **Main** form type, the following page appears:

1. In the **Account for Interactive experiences** form, from the left nav, select **Components**. 

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
2.	To confirm the record type is displaying on the form, click on the ![Create a timeline record icon](media\timeline-create-a-record-icon.png "Create a timeline record icon") (Create a timeline record icon) in the top right nav in timeline. 
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

b. When the **Filter** icon is filled in, it means filters has been selected and set. To view what filters have been selected you can just click on the ![Filter icon](media\timeline-filter-icon.png "Filter icon") **Filter** icon and the display will open showing which filters have been set.</li>

c. When you select the ![Filter icon](media\timeline-filter-icon.png "Filter icon") **Filter** icon the following list appears.<br> 

d. You can select how you want to filter your data by checking the box next to the filter.<br>

e. You can clear filters by clicking on the ![Clear all filters icon](media\timeline-clear-all-filters-icon.png "Clear all filters icon") **Clear all filters** icon.

3. If **Timeline** option is greyed out, it means it already exists on the form. You can only have one timeline per form.

    ![Timeline greyed out](media\timeline-option-greyed-out.png "Timeline greyed out")


    To remove the **Timeline** component from a form, highlight the inside **Timeline** component area and hit the **Delete** key.  This will remove the **Timeline** component from the form.


**b.** Based on our selection, all activity items with an <b>overdue status</b> now appear.<br>

**c.** <b>Filter</b> icon is filled in telling you a filter item has been selected.<br>

**d.** To clear filter selections, click on the ![Clear all filters icon](media\timeline-clear-all-filters-icon.png "Clear all filters icon") <b>Clear all filters</b> icon to clear all filters.

![Display options - Advanced - How to filter activity types on timeline](media\timeline-how-to-filter-activity-types-display-options-advanced-2.png "Display options - Advanced - How to filter activity types on timeline")

### Expand filter pane 

## Understand the timeline component on the form

In the form body, the Timeline component is added into the section called **TIMELINE**. section. To configure properties of the Timeline component, select the Timeline component inside the Timeline section and you'll see the properties in the right pane. 

![Understanding the timeline component on the form](media\timeline-component-2.png "Understanding the timeline component on the form")

## Configure properties of timeline component

The timeline component can be configured and tailored to support specific business needs. The Timeline form is comprised of features and functionality you configure in the timeline component which is then displayed in the entity form.

The following sections describe how to configure the things like display options, records to show, and activity types to include. 

## Display options 

- **Name**: Use this field to change the name of the Timeline component. This field is only for your (system administrator’s) reference and doesn’t impact how it is rendered at the runtime. 

    There are character limitations for this field. For example, you can’t have spaces and you must use underscores (_).

- **Records shown in page**: This field allows you to define the number of records to show in the Timeline section at the runtime. If there are more records than the number you define here, users will see an option to load more records. By default, this field is set to 10. 
The following image shows the timeline at runtime when the Record shown in page field is set to 10.

  | Configuration | Runtime | 
  | ------------------ | ------------ | 
  | ![Display options - Records shown on page](media\timeline-record-shown-on-page.png "Display options - Records shown on page")  | ![Display options - Records shown on page](media\timeline-records-shown-on-page-runtime.png "Display options - Records shown on page")  |   

- **Record types shown**: Select which record types you want to show in the timeline. Users will also be able to create new records of the record types you select here. You can select from: Activities, Notes, and Posts. All these are selected by default.

    - **Activities**. There are multiple customizable sub-activity record types to support business needs. You can create, add, and display a number of different customized sub-activity record types under the Activity section of timeline properties.    
    - **Notes**. Notes allow users to capture notes related to the entity record. Notes are typically used to grab thoughts, summary information, and provide feedback on a record, for example, a case. 
    - **Posts.**  There are two types of posts, Auto Posts and User Posts. 
        - **Auto Posts**. These are system generated and notify you of account activity that has occurred. 
        - **User Posts**. User posts are used to communicate with other users in your organization.

    The following image shows that because you  selected Activities, Notes, and Posts in the **Record types to show** section of timeline properties, users will see an option to create these record types at the runtime. The records of these record types will also be shown in the Timeline section at the runtime.  

    | Configuration | Runtime | 
    | ------------------ | ------------ | 
    | ![Select the records types to show in Timeline](media\timeline-record-types-to-show-config.png "Select the records types to show in Timeline")  | ![Option to create the record types that are selected in timeline properties](media\timeline-record-type-to-show-runtime.png "Record types shown based on the record types selected in timeline properties")  |   
    
    The timeline shows an icon before the activity, post, note, and custom entity making it easy for you to identify the record type. Dates and timestamps are shown for each activity, note, or post in the timeline. 
    
    ![Option to create the record types that are selected in timeline properties](media\timeline-icons-activity-post-notes.png "Record types shown based on the record types selected in timeline properties")

## Advanced section

The Advanced section covers settings that span across an activity, note, or post, which are the three (3) primary record types that appear in the timeline section. This section is collapsed by default. When you enable or  disable settings in the Advanced section, you won't be able to see the changes at the runtime (even though it may appear there is activity occurring on the timeline component) until you save and publish your changes and refresh the entity form.

![Advanced settings in Timeline properties](media\timeline-properties-advanced-section-config.png "Advanced settings in Timeline properties")


- **Quick entry record type**: Select the record type that you want to enable for quick create. For example, if Notes is selected in the drop-down list, users will see an option to quicly create a note from the timeline. When you select this option, 

  | Configuration | Runtime | 
  | ------------------ | ------------ | 
  | ![Select which record type to enable for quick entry](media\timeline-quick-entry-note-config.png "Select which record type to enable for quick entry")  | ![Notes enabled for quick entry in Timeline at runtime](media\timeline-quick-entry-note-runtime.png "Notes enabled for quick entry in Timeline at runtime")  |   

- **Sort default**: This setting controls the order of how the data must be sorted on the timeline. The default setting for this feature is set to **Descending**.
    
- **Enable filter pane**: Define whether you want to enable filter options on timeline. This setting is enabled by default.

    When the **Enable filter pane** check box is selected, a filter icon is shown on the Timeline. More information: [How to filter records in Timeline](customer-service-hub-user-guide-timeline-overview.md#filter-records)
    
    ![Select which record type to enable for quick entry](media\timeline-filter-runtime.png "Select which record type to enable for quick entry").  

- **Expand filter pane**: The **Expand filter pane** setting is used to display an expanded filter pane at the top of timeline anytime a record is opened. This setting is disabled by default. The Expand filter pane feature provides quick access to filtering options for timeline records. 

  | Runtime when Expand filter pane is disabled | Runtime when Expand filter pane is enabled | 
  | ------------------ | ------------ | 
  | ![Timeline with Expand filter pane option disabled](media\timeline-expand-filter-pane-disabled-runtime.png "Timeline with Expand filter pane option disabled")  | ![Timeline with Expand filter pane option enabled](media\timeline-expand-filter-pane-enabled-runtime.png "Timeline with Expand filter pane option enabled")  |   
   
- **Enable search bar**: Define whether you want to enable or disable search bar on timeline. When you select this check box, a **Search timeline** box appears in the Timeline section allowing users to easily search for records in the timeline. When you search for a phrase in the timeline, it searches in the title of the record or body and description fields of the record, and then displays the search results. This setting is enabled by default. More information: [Search records on timeline](customer-service-hub-user-guide-timeline-overview.md#search-records-on-timeline)

- **Expand all records by default**: When this check box is selected, all records in the timeline are shown in an expanded view. This option is disabled by default. Select or clear the check box to enable or disable this option.  timeline-expand-all-records-enabled-runtime  timeline-expand-all-records-disabled-runtime

  | Runtime when Expand all records by default is disabled | Runtime when Expand all records by default is enabled | 
  | ------------------ | ------------ | 
  | ![Timeline with Expand all records by default option disabled](media\timeline-expand-all-records-disabled-runtime.png "Timeline with Expand all records by default option disabled")  | ![Timeline with Expand all records by default option enabled](media\timeline-expand-all-records-enabled-runtime.png "Timeline with Expand all records by default option enabled")  |   

  > [!NOTE]
  > The records in timeline might contain images, but they won't display when the record is collapsed. Records with images must be expanded to be viewed. Use the caret icons (˅ or ^) to expand or collapse a record. Records with images will often display the message "The email has been blocked due to potentially harmful content. View full Email content." When you select this message, the warning goes away. If you don't see a message and still don't see the image displaying, refer to [Timeline FAQs](timeline-faqs.md).

- **Enable "What you've missed" summary**: This setting shows users when there are new records that they haven't seen. This setting is disabled by default. To enable, select this check box. When enabled, you'll see a notification like this:

1.	Click the upward facing caret (^) to expand and view **Activities** under **Record settings**.
2.	Once expanded, a list of **Activity types** is displayed.
3.	When you select **Activity type**, a fly-out appears. 
4.	To enable an **Activity type**, click the box next to **Enable** and select **Done**.
5.	To disable an **Activity type**, uncheck the box next to **Enable** and select **Done**. This will grey out all other items in the box and disable the activity type from displaying on the timeline.  This also disables the activity type from being created or viewed in timeline.  
6.	When you enable an **Activity type**, it will appear in a drop down box when you click on the ![Create a timeline record](media\timeline-create-a-record-icon.png "Create a timeline record") icon to **Create a timeline record** in the top right nav in the timeline section of the entity record. 
7.	Also, the **Activity type** can be viewed in the body of the timeline section of the form. 

## Record settings section
The **Record settings** section allow you to define detailed settings for the record types that you selected in the **Record types to show** setting. For example, if you selected check boxes for **Activities** and **Notes** in the **Record types to show** section, the **Record settings** section will provide you more settings related to these two record types.

### Configure activity record types

After you select **Activities** in the **Records types to show** section, you can also select which type of activities you want to enable to be shown on the timeline. 
When you expand the **Activities** under **Record settings**, a list of all the activity types that can be either enabled or disabled on the entity form is shown. 

1. Expand **Activities** under **Record settings**. A list of all the activity types that can be either enabled or disabled on the entity form is shown.
2.	Select the activity type that you want to enable, for example, select **Email**.  A fly-out appears. 

  ![Configure activity type to display in timeline](media\timeline-enable-activity-type-config.png "Configure activity type to display in timeline")



3. Configure the following options:
    
    1. **Enable**: To show the activity type in the the fly-out menu that appears when you select the **Create a timeline record** icon ![](media\timeline-create-a-record-icon.png "Create a timeline record") in the timeline section, select **Enable**.  The activity type will appear as shown in the following image:

10.	Check the box next to **Create directly from timeline** to enable.
11.	When enabled, the activity type will appear in a drop down box when you click on the ![Create a timeline record](media\timeline-create-a-record-icon.png "Create a timeline record") **Create a timeline record** icon in the top right nav in the timeline section of the entity record.

        To prevent an activity type from appearing in the fly-ot, clear the **Enable** check box. 

       > [!NOTE]
       > Additional settings for a record type are disabled until you enable the record type.  
    
    2. **Enable status tags**: Status tags display in the timeline to help users to see at a glance whether an activity, for example, an email is in the Active, Overdue, or Closed state. Status tags are enabled by default. The following image shows where users will see the status tag is in the timeline at the runtime:

        ![Activity status in the timeline](media\timeline-enable-status-tag-runtime.png "Activity status in the timeline")
    
    3. **Create directly from timeline**: When you enable this setting for an activity type, users can quickly create a record for this activity type from the timeline. The following image shows where users will see the option to create the activity record from the timeline at the runtime:
 
       ![Email activity in the flyout](media\timeline-email-option-in-create-timeline-flyout-runtime.png "Email activity in the flyout")

    4. **Select form**: Records are displayed using the default form for each activity type. However, for some activity type records, for example, an appointment or email, you can either select the default form or a different card form if one is available.  

       ![Select a different form for an activity type](media\timeline-select-form-different-form-config.png "Select a different form for an activity type")
    
       You can't use the **Email card form** in the timeline unless you select and publish it first.  

       > [!NOTE]
       > - Not all activity types support creating forms of type form, so Default will be the only option you can select for these activity types.
       > - If you create a new card form, you must go to the parent entity and add the new form of type Card before it starts appearing in the configuration for timeline.  If **Default** is displayed, you are not using the card form.

### How to customize a card from in timeline

All card forms are broken out into the following four (4) sections:

| Labels | Section | Description |
|--------|---------|-------------|
|a | **ColorStrip Section** | This section does not appear on the timeline record. The **ColorStrip** is located on the left of the card form.|
|b | **Header Section** | This section is displayed on the timeline record, however only the first two fields are displayed on the timeline record. For this example, only the **Subject** and **Modified On** fields are visible. |
|c | **Details Section** | This section is displayed on timeline record, however only the first three fields are displayed on the timeline record. For this example, only the **To**, **CC**, and **Description** fields are visible on the timeline record.|
| d | **Footer Section** | This section is not displayed on the timeline record. | 
| e | **Entity Fields** | You can select which fields you want to add to your card form from the field options listed on the right.  You can customize your card form by dragging and dropping the fields you want to use into the sections you want that field to appear in on the timeline record. | 

![Display options - Advanced - How to customize a card from in timeline](media\timeline-customize-card-form-display-option-advanced-1.png "Display options - Advanced - How to customize a card from in timeline")

Each individual card form has to be customized for each activity record such as email, tasks, posts, and so on. 

**Header Section**<br>
The displays the title/subject in your timeline email form. You can have up to six (6) fields in the Header section, only the first two (2) fields will be seen on the timeline record. Also empty fields will be ignored by the form in all sections.<br>

<ol>
<b>a.  Header - Field 1.</b> Regardless of the field you choose, it will appear as a bold header at the top of your timeline record. For this example we selected <b>Subject</b> for this field.<br>

**b.**	**Header - Field 2.** Again regardless of the field you choose, this field appears in the bottom right corner of the timeline record.  For this example we selected **Modified On** for this field.
</ol>

**Details Section** <br>
This displays in the body of your the timeline email record. You can have up to four (4) fields in the **Detail** section, but only the first three (3) fields are seen on the timeline record.

<ol>
<b>c.	Details - Field 1.</b> As before, regardless of the field you choose, this field will always appear below the Header - Field 1 as a sub-header on the timeline record. For this example we selected <b>To</b> for this field.<br>

**d.**	**Details - Field 2.** This field will display one line of text in a summary view on the timeline record.  When you expand your timeline record,  content in this field is fully displayed with format. For this example we selected **CC** for this field.<br>

**e.**	**Details - Field 3.** This field follows the content in Details -Field 2 and is part of the main body of your timeline record that is only viewable when you expand the record. For this example we selected **Description** for this field.
</ol>

**Footer Section**<br>
This section is not visible on the timeline record.  

<ol>
<b>f.	Footer – Field 1.</b> For this example we selected **Owner** for this field.<br>

**g.**	**Footer – Field 2.** For this example we selected **Regarding** for this field.<br>

**h.**	**Footer – Field 3.** For this example we selected **Priority** for this field.
</ol>

![Display options - Advanced - How to customize a card from in timeline](media\timeline-how-to-configure-activity-record-types-display-options-advanced-2.png "Display options - Advanced - How to customize a card from in timeline")

### How to set date in the sort activities by feature in timeline

How you view data is important and setting a default display view of your data varies based on the needs of your business. Admins can choose how data is sorted and create a default sort setting for **Activity types** in **Record settings**. **Last Updated** is on all activities which is why it is set as the default in ascending order.    

1.	The **Sort activity by** feature in the **Activities record settings** allows you to control how data is sorted in timeline.  
2.	When you select the **Sort activities by** field, a list appears. You can select from this list how you want your data to be sorted and displayed on timeline in the form.

    There are some unique date fields, for example: 

    | Labels | Section | Description |
    |--------|---------|-------------|
    |a | **Date sent** | This only occurs in email. If you sort by Date sent, most activities will not contain a Date Sent and therefore will be grouped together without any ordering. |
    |b | **Sort date** | You can't create a custom date field.  If you create one, it will not display, so in answer to this, **Sort date** was created.  It does not have a value and therefore allows you to choose your own.  It is empty by default. |

    ![Display options - Advanced - How to set date in the sort activities by feature in timeline](media\timeline-how-to-set-date-in-sort-activities-by-feature-1.png "Display options - Advanced - How to set date in the sort activities by feature in timeline")

    > [!IMPORTANT]
    > - Sort date is intended for users to programmatically map each activity with a date of choice to have more control.  It’s a customization option that allows you to sort activities any way you want by whatever date you want.  You will have to populate each field and it requires that you update all activities to populate the Sort date with a value.  However, once you complete the configuration, you have flexiblity to sort anyway you want.  
    > - Sort dates have to be configured for each timeline instance and set up must be completed in all three main forms for the Account entity in order to work.


### How to set create activities form type in timeline

The **Create activities** feature allows you to choose which type of form you want to work in based on your business needs.  

- **Quick create form** appears in a model on the right. There are some activities which do not support quick create that will always use email for example. For more information, see [Create or edit model-driven app quick create forms for a streamlined data entry experience](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-quick-create-forms).

- **Main form** navigates you to the activity entity main form. For more information, see [Create or edit a model-driven app main form for an entity](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-main-forms).

Select **Create activities** using feature to select either a **Quick create form** or **Main form**.

> [!NOTE]
> If a **quick create** form for an activity has not been created, then the main form will be used. If **quick create** form is not supported, such as with email, the **main form** will always be used. 

![Display options - Advanced - How to set create activities form type in timeline](media\timeline-how-to-set-create-activities-form-type-1.png "Display options - Advanced - How to set create activities form type in timeline")

### Timeline performance impacts

You only want to enable activities that you need on this form. When working with 10 or more **Activity types**, you will receive a warning notice letting you know the number of activity types you have selected impacts the performance speed on your timeline.  To improve timeline performance speed, consider limiting activity types to 10 or less. 

Warning notice will display when you select more than 10 activity types

![Display options - Advanced - Timeline performance impacts](media\timeline-performance-impacts-1.png "Display options - Advanced - Timeline performance impacts")

## Notes on timeline

Use the following steps for **Notes**:

1. Select **Notes**
2. The section will expand to see **Coming soon** which indicates you have **Notes** enabled. 
3. Once enabled, you can now click on the ![Create a timeline record](media\timeline-create-a-record-icon.png "Create a timeline record") (Create a timeline record) icon 
4. Flyout will appear. Select **Notes**
5. Begin writing your **Note** using rich text and just click **Add Note** at the bottom to save.

![Notes on timeline](media\timeline-notes-1.png "Notes on timeline")

## Posts on timeline

Use the following steps for **Posts**:

1. Select **Post**
2. The section will expand to see **Coming soon** which indicates you have **Post** enabled. 
3. Once enabled, you can now click on the ![Create a timeline record](media\timeline-create-a-record-icon.png "Create a timeline record") (Create a timeline record) icon 
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
