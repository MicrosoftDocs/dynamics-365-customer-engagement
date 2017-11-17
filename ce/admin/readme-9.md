---
title: "Dynamics 365 Customer Engagement General Availability Readme (Known Issues) | MicrosoftDocs"
ms.date: 11/17/2017
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 99ea6ece-c35a-4f0e-85a4-26622cd87031
---
Dynamics 365 Customer Engagement<br/>General Availability Readme (Known Issues)
===============================================================================

This document provides important, late-breaking information about this product
version:

-   Dynamics 365 (online), version 9.0

You’ll also find information about known issues and possible workarounds.

Services and apps availability 
-------------------------------

| Services and Apps                                                                           | GA | Public Preview | Private Preview |
|---------------------------------------------------------------------------------------------|----|----------------|-----------------|
| Dynamics 365 for Sales, and Dynamics 365 for Customer Service | X  |                |                 |
| Dynamics 365 for Field Service                                                              | X  |                |                 |
| Dynamics 365 for Project Service                                                            | X  |                |                 |
| Portal capabilities for Dynamics 365                                                        | X  |                |                 |
| Relevance Search Enhancements                                                               | X  |                |                 |
| Learning Path                                                                               | X  |                |                 |
| Resource Scheduling Optimizer                                                               | X  |                |                 |
| Glympse                                                                                     | X  |                |                 |
| Connected Field Service (Internet of Things)                                                | X  |                |                 |
| Machine Learning                                                                            | X  |                |                 |
| Office 365 Group                                                                            | X  |                |                 |
| Gamification                                                                                | X  |                |                 |
| Organizational Insights                                                                     | X  |                |                 |
| CaféX Live Assist                                                                           | X  |                |                 |
| Document recommendations                                                                    | X  |                |                 |
| Company News                                                                                | X  |                |                 |
| Unified Service Desk                                                                        | X  |                |                 |
| Voice of the Customer                                                                       | X  |                |                 |
| Dynamics 365 App for Outlook                                                                |    | X              |                 |
| Relationship Insights - Auto Data Capture                                                   |    | X              |                 |
| Relationship Insights - Relationship Assistance                                             |    | X              |                 |
| Relationship Insights - Email Engagement                                                    |    | X              |                 |
| Customer Insights                                                                           |    | X              |                 |
| LinkedIn (Lead Gen Forms only)                                                              |    | X              |                 |
| Cortana                                                                                     |    | X              |                 |
| Mobile offline (Dynamics 365 for tablets and phones)                                        |    |                | X               |
| Relationship Insights - Relationship Analytics                                              |    |                | X               |

Sales and Customer Service web client apps
------------------------------------------

-   Sample data does not get installed under **Settings** \> **Data
    Management**.

-   Core Marketing:

    -   Activities are not created after the campaign activity is distributed.

    -   Unable to add members in a locked marketing list by selecting **Add
        using advanced find**.

    -   Unable to create a dynamic marketing list.

    -   Unable to add members in a marketing list by selecting **Add using
        advanced find**.

    -   Occasionally unable to unsubscribe an account, contact, or lead from the
        campaign activity.

-   Suggestions are not available on the Product sub-grid in Quote, Order, or
    Invoice forms.

-   Unable to create a new data source entity when there are spaces in the
    entity’s name.

-   The campaign response form does not load, so it can’t be converted to a
    lead.

-   Unable to convert a campaign response to a lead.

-   Unable to open a Campaign Activity page to unsubscribe an account, contact,
    or lead, or to update a campaign.

-   Unable to add a custom view as a subcomponent for the Account entity in a
    solution.

-   Using the Customer Service Representative role, the user is unable to save a
    case for a customer with Entitlement setting for Decrease Remaining On
    upon Case Creation. There is no issue in saving a case record otherwise.

-   Pricing error notifications are not displayed on the Quote Order Invoice
    detail forms.

-   Unable to Add Quote from an opportunity form for products that are
    read-only.

-   The **Save & Close** command for a Price List Item displays an error and
    does not close the window properly.

Sales Hub and Customer Service Hub apps

For best performance, the following table shows the **recommended app** to use
in the browser or on mobile devices for each scenario. 

| **Service**                                       | **Unified Interface app in a browser** | **Unified Interface app on mobile** | **Web client in a browser** |
|---------------------------------------------------|----------------------------------------|-------------------------------------|-----------------------------|
| Sales                                             | –                                      | Sales Hub                           | Sales                       |
| Customer Service – Knowledge management scenarios | Customer Service Hub                   | Customer Service Hub                | –                           |
| Customer Service - Case management scenarios      | –                                      | Customer Service Hub                | Customer Service            |

 

### Sales Hub app on Dynamics 365 for tablets and Dynamics 365 for phones

-   An error is displayed on iPads whenever a user tries to add a product to an
    opportunity. The workaround is to dismiss the error.

-   The command bar action of a sub-grid that has no title (Opportunity product,
    Opportunity Quotes) appears as an ellipsis above the grid but is not aligned
    correctly.

-   Web resources are not rendered on the dashboards.

-   Web resources and iframe tags are not displayed with the height and width
    they’re allocated in the mobile app configuration.

-   The Quote command bar is missing icons.

-   Opportunity Product Quick Create opens in a new window instead of through a
    sliding dialog box.

-   On activities, **Convert to Opportunity** and **Convert to Case** are not
    available

### Customer Service Hub app on Dynamics 365 for tablets and Dynamics 365 for phones 

-   Forms

    -   When you install the Community portal, the Read-only in Mobile metadata
        flag is enabled for the Case entity. This results in the Case entity
        being read-only in the Customer Service Hub. The workaround is to go to
        entity customizations, and for the Case entity metadata, clear the
        **Read-only in mobile** check box. Then, select **Save** and **Publish
        all customizations**.

    -   In certain Trial organizations, saving knowledge articles causes a
        duplicate record error due to an issue with the knowledge article
        sequence number. The workaround is to update the prefix of the knowledge
        article public number (**Settings** \> **Administration** \> **Auto
        Numbering** \> **Knowledge Articles**) or update the article sequence
        number by using an API.

    -   The Case business process flow is not available when a new case is being
        created. It is available after the Case form is saved.

    -   Phone to case process: The Find Case option on the Identify stage is not
        available for update for an existing case.

    -   On devices, changing the owner value by using the owner lookup is not
        functional. The workaround is to use the **Assign** action from the
        command bar.

    -   The Similar Cases sub-grid is not available on the Case form.

    -   Email is read-only on the Customer Service Hub.

    -   Links in the body of an email are not selectable.

    -   Scrolling in the body of an email stops working after the user opens any
        attachment. The workaround is to refresh the form.

    -   On opening the read-only user and Entitlement form, a script error is
        displayed.

    -   The Knowledge Articles Related Translations sub-grid is hidden when the
        user zooms in.

    -   Anchor links are not working in the Knowledge Search control.

-   Quickly navigating from Activities forms while they are still loading might
    lead to intermittent errors in the application.

-   On activities, **Convert to Case** and **Convert to Opportunity** are not
    available

-   Other

-   User and team queues are not available in the Add to Queue lookup.

-   Fallback forms are shown for the main forms for Category, Feedback, and
    Knowledge Article View entities, because their intended main forms (called
    *interactive forms*) are inactive by default. The workaround is to activate
    the forms manually. This issue will be fixed in the upcoming release, but
    orgs upgrading from Potassium Preview will need to manually activate the
    forms.

-   Invalid commands are visible for custom activities from the site map.

App modules and the App Designer
--------------------------------

-   The app module URL suffix provides a friendly URL for the app module in the
    form \<server url\>/apps/sales. Admins can set this URL suffix for their
    organization to provide their users a friendly URL. However, this URL suffix
    cannot be exported or imported via solutions at this time.

-   In some versions of the Firefox browser, the check boxes on the Create App
    page in the app designer don’t appear.

-   Any change in the name of a chart or dashboard made through corresponding
    editors launched from the app designer will be reflected in the app designer
    for the app module only after refresh.

-   The Custom Business Process Flow entity that is created for a custom
    business process flow might not get automatically added to the app designer
    canvas when the business process flow is added to the app module.

View designer
-------------

-   When the view designer is opened, sample data from several columns overlap
    intermittently.

-   When filters are ungrouped, the order of the filters is not persisted.

Data visualization 
-------------------

### Dashboards in Unified Interface 

-   Users will experience some right-to-left issues, such as the dashboard
    picker and label are not properly aligned.

-   On a Windows 10 phone or Internet Explorer, users will experience problems
    on the dashboard because this device and browser are not supported.

### Interactive dashboards in Unified Interface

-   Interactive dashboards are not supported in offline mode.

-   Any metadata settings in option sets to configure visual filter colors have
    no effect, and charts will not be rendered in customized colors.

-   Occasionally, streams don’t show any data for the records. The workaround is
    to reload the application.

-   Occasionally, filtering doesn’t work on custom interactive dashboards. The
    workaround is to reload the application.

-   When an activity grid is configured to be rendered as a calendar control,
    the **Open Dashboards** command opens the Activity Pointer dashboard instead
    of the actual activity dashboard.

-   Doughnut charts, pie charts; and other charts might not be rendered
    correctly; this can affect the usability of some of the charts in visual
    filters.

-   Doughnut and tag charts hide other data points when filtering is done on
    them and show only the data point that was used for filtering.

-   In global filters and applied filters, the default minimum value of numeric
    data type appears in scientific notation instead of decimal.

-   Under certain conditions, after you select **Switch to Tile View** or
    **Switch to Stream View**, some of the tiles and streams might show a **See
    more** action. This action is not intended to be shown and will be fixed in
    a future release.

-   Filtering by using multi-select option sets in global filters is not
    supported.

### Charts in Unified Interface

-   Charts show the message “Loading” when the user does not have the read
    privilege for the chart’s underlying entity.

-   On devices, a pie chart with too many slices might not show all data
    indexes.

-   On iOS devices, a chart in expand mode might look blurred.

-   Filters on a chart are not preserved. If you select **Hide Chart** and then
    **Show Chart**, the chart filter is lost and all the data in the entire view
    is reloaded.

-   On phone devices, the chart overlaps the records available in a grid after
    you close the expanded view for the grid page.

-   On some grids, the Show Chart button shows an empty chart selector because
    no chart exists for the underlying entity.

-   Users will experience some right-to-left issues on charts, such as tooltips
    not showing up.

-   When you select **Show Chart** on a grid while in offline mode, no chart
    will be displayed.

Timeline control

-   Trying to enable **Show Filter Pane** in the configuration property of the
    Timeline control in a dashboard shows the message “An unexpected error
    occurred.” This is a transient problem; the workaround is to close the
    dashboard editor and refresh the page.

-   In certain resolutions on dashboards, when you open the filter pane in the
    Timeline control, the filter pane almost covers the Timeline control and the
    user cannot see the records. The workaround is to customize the dashboard
    and increase the height of the Timeline control.

-   In dashboards, if the Timeline control is too short, some filters will not
    be visible because the filter pane is not scrollable.

Field controls and mobile application in Unified Interface
----------------------------------------------------------

-   Visual controls are not fully functional.

-   Selecting a location card does not open the map in the native app of the
    device.

-   The Phone Call activity quick-create form is not opened when the call action
    is initiated on the mobile app.

-   Date fields cannot be set in Internet Explorer 11, Firefox, or Edge.

-   The date-time control uses browser locale as opposed to user locale for
    editing.

-   On Android devices, when you perform a quick create and use the **Duration**
    field, the inline mode of editing the duration value causes the entire quick
    create form to scroll up. The workaround is to swipe down to locate the
    **Duration** field, and then continue the update. There are no issues with
    using the out-of-the-box values when you use the **Duration** field selector
    (down arrow).

-   In text controls, long strings are not getting wrapped in read mode.

-   Unable to add an unresolved email ID to a party list.

-   Incorrect quick-create forms are rendered when a new record is created by
    using **+New** in the Regarding lookup field.

-   The Lookup most recently used list doesn't take into account the lookup
    view.

-   Unable to change the value of the Owner field in the header fields section.

-   For related grids, command flyouts do not open in See More mode.

-   Entities that have not been enabled for Unified Interface appear in
    multiple-entity grids (for example, the Activity grid).

-   Device settings are not preserved across app restarts for an online org with
    no cache.

-   Cache mode does not work for disconnected mode.

Grids and lists in Unified Interface
------------------------------------

-   On tablets, in some languages, the index (character) filters might be
    displayed too close to each other. The workaround is to use the Search
    command to find records that begin with a certain character.

-   The due date filter on an activities grid might not work as expected in
    conjunction with other filters on the page, such as the view selector and
    index (character) filters.

-   On tablets, resizing column width on grids can be harder because of the
    smaller dragging touch target. The workaround is to change the column width
    in the view definition if some columns need to be wider.

Multi-select option set in Unified Interface
--------------------------------------------

-   The multi-select option set control always appears in edit mode.

-   The multi-select option set control drop-down arrow appears as a square box.

-   The control is not aligned correctly on iOS devices.

-   The control UI is not displayed correctly on Android 5.

Timer control in Unified Interface
----------------------------------

-   SLA Timer does not pause or resume when a case is put on hold or resumed.
    The workaround is to refresh the form.

Subject control in Unified Interface
------------------------------------

-   The subject tree is not displayed when the Subject attribute is selected
    while converting an activity to a case and when creating a case by using the
    quick create mode.

Dynamics 365 App for Outlook
----------------------------

-   Dynamics 365 App for Outlook is currently available as a Public Preview and
    can be enabled through **System Settings** \> **Previews** tab \> **Enable
    Dynamics 365 App for Outlook Preview**. The previously released version of
    the app is not supported with this release.

-   Initial loading might take some time.

-   When selecting **See more** to see more entities, Outlook 2013 and Outlook
    2016 display an add-in error, Chrome and IE 11 display a “long running
    script” error message, and Edge displays a blank screen for a while and then
    navigates to the previous page.

-   On Outlook 2013 and Outlook 2016, Outlook frequently displays “add-in
    error.”

-   On IE 11, IE frequently displays a “long running script” error message.

-   When navigating to a record’s main form, Outlook 2013 and Outlook 2016
    display an add-in error; in Chrome and IE 11 the app displays a “Script
    Error” message.

-   When entering text in the **Look for Records** field when you set regarding,
    in Outlook 2013 and Outlook 2016, some of the characters disappear. On
    Chrome, IE 11, and Edge the lookup sometimes stays in the “Loading…” state
    forever.

-   The Back button does not work on Outlook 2016 and Outlook 2013. On browsers,
    selecting the back icon navigates to the previous webpage (this is the same
    action as selecting the browser Back button).

-   The ability to follow and email while composing is not available.

-   The app is not supported while accessing it from Outlook Web Application
    from Safari or Firefox.

-   The app is currently not supported on Outlook for Mac.

-   While scrolling in the app, the action might be delayed or the app might
    become unresponsive for few seconds.

-   When tracking / set regarding to an email, and selecting **View email in
    Dynamics 365**, one of sections in the email entity might display an error
    “You not a member of this organization.”

Inactivity timeout
------------------

-   Inactivity timeout is not enforced in the following clients:

    -   Outlook

    -   Dynamics 365 for tablets

    -   Dynamics 365 for phones

    -   Unified Service Desk using the WPF browser

    -   Unified Interface

    -   Live Assist (Chat)

-   Portal capabilities for Dynamics 365 has its own session and inactivity
    timeout settings that are independent of the timeout settings in System
    Settings. This is by design.

Business process flows
----------------------

### Action Steps

This feature is in Public Preview and can be activated under System Settings.
When activated, users should observe the following behaviors:

-   Action steps within business process flows cannot use process actions that
    contain any of the following: any input or output arguments of type Entity,
    EntityCollection, or Option Set (picklist); more than one output argument of
    type EntityReference; or any input arguments of type EntityReference.

-   Action steps on business process flows cannot be exported or imported as
    part of a solution.

-   When configured with an on-demand (real-time) workflow and called from the
    mobile Unified Interface, an action step on a business process flow will
    cause an error message and will not complete the operation successfully.

### Business process entity customization

This feature is in Public Preview and can be activated under System Settings.
When activated, users should observe the following behavior:

-   When a new business process definition is added to an application through
    the app designer, the corresponding business process entity is also added to
    the site map if the primary data entity for that business process is already
    on the site map.

Web client visual refresh
-------------------------

-   Because the font size for list and grid views has been slightly increased,
    column data might be constrained, depending on the data you have. We are
    considering whether to increase column widths or decrease font size in a
    later release.

-   Some empty areas can occasionally be seen on certain forms, for example a
    marketing list. Select Ctrl+F5 to remove these.

-   Empty sub-grids show a message with the entity schema name instead of the
    display name.

-   Star symbols for fields secured via field-level security, might be
    incorrectly positioned in certain cases, for example in a multi-select
    option set field that has been secured by field-level security.

-   The mandatory field indicator in some bulk edit forms might be positioned
    incorrectly.

-   Sort and filter icons are incorrectly positioned on the activity wall on
    iPad.

-   The calculator icon might be incorrectly positioned in certain rollup fields
    and calculated fields.

-   Gray shading on the web client forms:

    -   Does not appear on a new form in create mode.

    -   Does not change dynamically when the height of a field or component
        changes and might leave an empty space. However, this empty space will
        disappear on refresh

Project Service Automation 
---------------------------

-   Product bundles do not work correctly on project-based opportunities,
    quotes, and orders.

-   The Contract Performance tab does not work correctly for project contracts
    in the amounts for actual costs and actual effort.

-   The project estimated cost and actual cost fields only show labor cost
    amounts and not expense cost amounts.

-   When there are multiple project price lists with overlapping date ranges,
    the price defaulted to for roles and expense categories might be
    indeterministic.

-   Taxes of Fixed Price Milestones do not generate separate tax actuals.
    Transactions representing taxes collected/paid are typically recorded as
    actuals along with the main transaction. However, taxes for milestones are
    not recorded as a separate actual entry. The tax amount gets combined with
    the milestone amount, and the actual is recorded for the entire amount.

-   When a project is linked to a contract and the customer field on the project
    gets updated in the process, the change is not propagated to actuals.

-   Project Opportunity is not shown on the Sales tab of the project in the
    Opportunities section.

-   In languages other than English, the Invoice Line page does not show actions
    under the New ribbon action.

-   The Confirm button and the + button to add new lines are not disabled on the
    journal details page for journals that are already confirmed.

-   Contract confirmation does not correctly process unbilled actuals that came
    from journals. Unbilled sales actuals are cancelled and reversed by contract
    confirmation.

Cortana integration with Dynamics 365
-------------------------------------

-   The Cortana integration with Dynamics 365 provides access to sales
    activities, accounts, and tasks through Cortana. However, reactive Cortana
    commands using voice or text are not available currently. Voice or text
    commands such as "Dynamics 365 open account called Contoso" or "CRM find
    account called Contoso" will be redirected to open as a web search in Bing.
    Although the rest of the capabilities are still available, we are working on
    these reactive commands and plan to release them in a future update.

Third-party notice 
-------------------

[Third-party notice](https://go.microsoft.com/fwlink/p/?linkid=853765)
