---
title: "Add and customize marketing calendars for any form or entity (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to add a marketing calender to an entity or form and then customize its features in Dynamics 365 for Marketing"
keywords: "marketing execution;email;landing page;marketing page;customer journey"
ms.date: 04/01/2018
ms.service: 
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c6759aea-6c77-4607-8fdd-ea1f0768892f
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer: renwe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create and customize marketing calendars

The marketing calendar is supplied as a standard control that you can add to any entity or form. The following subsections explain how customize the settings of any calendar, and how to add a calendar display to an entity or form.

### Open the PowerApps customization window

To add and/or customize a marketing calendar, you must work in a **PowerApps** customization window. To get there:

1. Use the app-selector menu to open the **Dynamics 365 – custom app**.

2. In the custom app, go to **Settings \&gt; Customization \&gt; Customizations** and then choose **Customize the System** from the **Customization** page.
3. A **PowerApps** customization pop-up window opens. Use the left panel to navigate and select the item you want to customize. Then use the area on the right to make your settings.


See the remaining sections of this topic for instructions about how to use these settings to add and customize your calendars.

### Add a marketing calendar to an entity

When you add the calendar control at the entity level, it becomes available on that entity&#39;s list view either by default or via the **Show as** button (as described in Use the calendar).

**IMPORTANT** : You can only add entity-level calendars to entities that have start and end dates. (However, you can add form-level calendars to any entity.)

To add an entity-level calendar to any entity:

1. Open a PowerApps customization window. In the left panel, expand **Components \&gt; Entities** to see a list of all entities. Then select the entity where you want to add the calendar.

2. Go to the **Controls** tab and choose **Add control**.

3. The **Add Control** dialog opens. Use it to find and add the control called **Marketing Calendar**.
4. The **Controls** tab updates to show configuration settings for the new calendar.

Do the following:
  - Select the **Marketing Calendar** in the **Control** section and then configure the mappings and quick-view form IDs for each entity you&#39;d like to include in this calendar, plus other configuration settings. For details about these settings, see Configure the entities available to a calendar.
  - Make the calendar the default view for any or all the available form factors (web, phone, and tablet) by using the radio buttons at the top, as required.
5. Save and publish your settings.

### Add a marketing calendar to a form

You can add a marketing calendar to any form where you think it could be useful. You can position it as a new section for any existing form tab or create a tab that&#39;s dedicated to showing the calendar by itself. Calendars that you add at the form level can only show one type of entity (such as events, appointments, _or_ sessions).

1. Open a PowerApps customization window. In the left panel, expand **Components \&gt; Entities** to see a list of all entities. Then expand the entity where you want to add the calendar and choose **Forms** to see a list of forms currently available to that entity. Select or create the form where you want to add the calendar.

2. In the form editor, go to the **Insert** tab and add a container to host the calendar (such as a tab or a section):

1. With the newly created tab or section selected, choose **Insert \&gt; Sub-Grid**.
2. The **Set Properties** window opens. On the **Display** tab, give the sub grid a **Name** and **Label**.

3. In the **Data Source** section, choose the type of entity that you want to show in your calendar. Make the following settings:
  - **Records:** Choose **All record types** to show any type of record, or choose Only related records to show only records that have a relation to a currently shown record (such as rooms reserved for a displayed event, or engagements assigned to a displayed speaker).
  - **Entity** : Chose the type of entity you want to show in the calendar. The entity you choose must include fields for a start date and end date, and must also have a quick-create form available.
  - **Default view** : Choose a system view defined for your selected entity. This setting will filter the collection of records shown on the calendar.

1. Go to the **Controls** tab and select **Add control**.
2. The **Add Control** dialog opens. Use it to find and add the control called **Marketing Calendar**.

1. The **Controls** tab updates to show configuration settings for the new calendar.

Do the following:
  - Select the **Marketing Calendar** in the **Control** section and then configure the mappings and quick-view form IDs for the entity you chose to include in this calendar, plus other configuration settings. For details about these settings, see Configure the entities available to a calendar.
  - Make the calendar the default view for any or all the available form factors (web, phone, and tablet) by using the radio buttons at the top, as required.
2. Save and publish your settings.

### Configure the entities available to a calendar

After you have added a marketing calendar to an entity or form you must configure it with the collection of entities that it should display and create. The settings are the same in each case.

1. Open a PowerApps customization window and go to the entity or form where you are creating or editing the calendar.
  - For entity-level calendars, go to the **Controls** tab for the entity. More information: Add a marketing calendar to an entity list view
  - For form-level calendars, open the properties for the sub-grid that is positioning the calendar and then open the **Controls** tab on the **Set properties** page. More information: Add a marketing calendar to a form.

From now on, the procedure is the same whether you are creating or editing an entity-level or form-level calendar.

1. Select **Marketing Calendar** in the **Control** section to opens its configuration settings in the bottom section of the window.
2. You can add up to five entities to show in entity-level calendars, or just one for form-level calendars. Note the following:
  - **Entity 1** is fixed. For an entity-level calendar, this is always the entity itself. For form-level calendars, this is the entity selected for the sub-grid that hosts the calendar.
  - Form-level calendars can only display the entity set for **Entity 1**. You can add more entities to enable users to create those types of records from the calendar, but the calendar won&#39;t display them so doing so is likely to confuse users.
  - Entity-level calendars can both display up to five entities of any type that has a start date, end date, and quick-create form.
3.
4.Use the **Configure property** buttons ![](data:image/*;base64,iVBORw0KGgoAAAANSUhEUgAAABEAAAARCAYAAAA7bUf6AAAABHNCSVQICAgIfAhkiAAAAZtJREFUOE+lkyuPwlAQhYfNqiIqEKhKoEFQgiGhKSggqUAQSEgt4Weg0DgEpgJXiyGEH0BwGBIsAkFIK3gLHrO9k7RZtu3CZo9penvnu+ectiG0Bf/U51/mj8cjLBYLuFwukEqlIBKJ0HjoXSfn8xlKpRJEo1Fg5ufzOcxmM7pnCy+12+2wUCigJElou8Hb7YbVahUnkwnNfryKczgcwAZApVKBRCIB7XYb7vc7cBxHV9JvNk6nE6qqiv1+H6/XK7loNBqYzWbR7gQty6LxQIhpmpjP57HT6bjnsBi6rmMmkyGgI18Ic8AAg8GA8jsyDIMcbDYbd83XCSuxWCxit9t1AY/HA3u9HoG32+0TwAPZ7/eYTqepA0cMMBqNPBG+k9w4P0t0NjkdrNdrjwNngSAMoCgK1mo1NwLrgnWQy+WeSvQjEWS5XGI8HqfM9XqdXmdQiYGQ4XCIzWaTTpRlGTVNCyzRD0L/TqvVAlEUYbVawXg8pq9xOp1COBx+9UHTc4LYMUAQBCiXy5BMJiEWiwHP828BXMjbuwM2fgFEe5LyB3HtHQAAAABJRU5ErkJggg==)
 to make each of the following settings for **Entity 1** :
 to make each of the following settings for **Entity 1** :

  - **Start Date** : Select the field from the target entity where the start date is defined for each record.
  - **End Date** : Select the field from the target entity where the end date is defined for each record.
  - **Name/Title** : Select the field that defines the record name for the target entity. This value will be shown on the calendar to identify the record.
  - **Description** : Select the field that describes the record name for the target entity. This value is shown for calendar items when in day or week view.
  - **Parent entity** : Select a parent entity (optional). In the future, this will be used to group child items under parent items when they are displayed in the calendar, but in the current version this setting has no effect. This will be useful, for example, for sessions, which have events as a parent entity.
  - **Entity 1 quick view form ID** : When users select an item in the calendar, it displays a quick-view form with information about the selected record that includes a button for opening the full record for editing. You can choose any form for this purpose—you might create a custom one, but many people simply use the existing quick-create form. If you don&#39;t provide a value here, then users that select this type of calendar item will go straight to the edit form. To set this, choose the **Configure property** button for this setting, then choose the Bind to a static value radio button and paste the ID in the field provided here. For details about how to find the ID for a quick-view form, see Find the form ID for a quick-view form.

4. If you are creating an entity-level calendar and want to add another entity to the current calendar, then choose an entity for **Entity 2** and repeat the previous step for that entity. You can add up to five entities to entity-level calendars.
5. Make the following general settings as required (they are optional). They appear after the **Entity** settings and apply to the calendar as a whole:
  - **Default duration for new items** : Specify the default duration (in minutes) applied to new items created by this calendar. When a user creates a new item (for example, an appointment), they will select a start date and time. The end date and time for that item will then automatically be set this number of minutes later, but the user is free to change it as needed.
  - **Default view** : Choose which calendar view to show when the calendar is first opened (day, month, year, or agenda).
  - **Default view date** : Choose a date to show when the calendar is first opened. You can specify this as a static value, or to match a field value from the entity that is showing the calendar. Leave this blank to show the current date.
6. Save and publish your settings.

### Find the form ID for a quick-view form

Part of the calendar configuration gives you the option of choosing a quick-view form for each entity displayed by the calendar. When a user selects a calendar item, the content of this form is displayed in a read-only pop-up dialog. You can choose any form for this purpose—you might create a custom one, but many people simply use the existing quick-create form. More information: Configure the entities available to a calendar.

When specifying the form, you must use the ID of the form you want to use. Here is how to find the required ID:

1. Open a PowerApps customization window and expand **Components \&gt; Entities** to see a list of all entities. Then expand the entity you are adding to your calendar and choose **Forms** to see a list of forms currently available to that entity.

2. Select the form you want to use as a quick-view form. The form opens in a new window.

3. Inspect the URL at the top of the new window and find the part that looks something like the following:

**… formId%3d5895E983-598B-4834-80F9-68A4E9F4F744%26 …**

1. Copy the value shown between **formId%3d** and **%26** (&quot;5895E983-598B-4834-80F9-68A4E9F4F744&quot; in the previous example)
2. Paste this value into the **Entity n quick-view form ID** setting described in Configure the entities available to a calendar.

### Configure the main marketing calendar

### Set the color used for each type of entity shown in the calendar

Each item displayed on the calendar uses a color to indicate which type of item it is. By default, events are green, sessions are blue, and appointments are red. Entities with no color configured show as gray. To customize the color for any entity:

1. Open a PowerApps customization window. In the left panel, expand **Components \&gt; Entities** to see a list of all entities. Then select the entity you want to assign a color to.

2. Use the **Color** setting on the **General** tab to set a color for the entity.
3. Save and publish your settings.