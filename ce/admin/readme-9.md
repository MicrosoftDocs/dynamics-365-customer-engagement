Dynamics 365 Customer Engagement<br>Readme / Known Issues
=========================================================

This document provides important, late-breaking information about this product
version:

-   Dynamics 365 (online), Enterprise edition, version 9.0

You'll also find information about known issues and possible workarounds.

Services and apps availability 
-------------------------------

| Services and Apps                                                                           | GA | Public Preview | Private Preview |
|---------------------------------------------------------------------------------------------|----|----------------|-----------------|
| Dynamics 365 for Sales, Enterprise edition and Dynamics 365 for Service, Enterprise edition | X  |                |                 |
| Dynamics 365 for Field Service                                                              | X  |                |                 |
| Dynamics 365 for Project Service                                                            | X  |                |                 |
| Portal capabilities for Dynamics 365                                                        | X  |                |                 |
| Relevance Search Enhancements                                                               | X  |                |                 |
| Learning Path                                                                               | X  |                |                 |
| Resource Scheduling Optimization                                                            | X  |                |                 |
| Glympse                                                                                     | X  |                |                 |
| Connected Field Service                                                                     | X  |                |                 |
| (Internet of Things)                                                                        |    |                |                 |
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
| Mobile offline (Dynamics 365 for tablets and phones)                                        | X  |                |                 |
| Relationship Insights - Relationship Analytics                                              |    |                | X               |

Transport Layer Security (TLS) Requirements
-------------------------------------------

Starting with Dynamics 365 (online), version 9.0, connections to Customer
Engagement applications are required to use TLS 1.2 (or later) security
protocols. This aligns with updated Microsoft and industry security policies and
best practices. To prevent any disruption to your organization, you might be
required to take actions to maintain the connectivity to Dynamics 365 Customer
Engagement applications.

Please refer to the following information to help you identify if you are
impacted and what steps you might need to take:

1.  [Blog announcement on connection security
    requirement](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

2.  [Technical support documentation with additional
    information](https://support.microsoft.com/help/4051700)

3.  Product documentation:

    1.  [Supported
        Extensions](https://docs.microsoft.com/dynamics365/customer-engagement/developer/supported-extensions)

    2.  [Web application
        requirements](https://docs.microsoft.com/dynamics365/customer-engagement/admin/web-application-requirements)

**If your organization is impacted by this requirement, you must take the
necessary steps to upgrade to TLS 1.2 prior to scheduling your instance
update.**

Sales and Customer Service web client apps
------------------------------------------

-   Sample data doesn't get installed under **Settings** \> **Data Management**.

-   Core Marketing:

    -   Activities aren't created after the campaign activity is distributed.

    -   Unable to add members in a locked marketing list by selecting **Add
        using advanced find**.

    -   Unable to create a dynamic marketing list.

    -   Unable to add members in a marketing list by selecting **Add using
        advanced find**.

    -   Occasionally unable to unsubscribe an account, contact, or lead from the
        campaign activity.

-   Suggestions aren't available on the Product sub-grid in Quote, Order, or
    Invoice forms.

-   Unable to create a new data source entity when there are spaces in the
    entity's name.

-   The campaign response form doesn't load, so it can't be converted to a lead.

-   Unable to convert a campaign response to a lead.

-   Unable to open a Campaign Activity page to unsubscribe an account, contact,
    or lead, or to update a campaign.

-   Unable to add a custom view as a subcomponent for the Account entity in a
    solution.

-   Using the Customer Service Representative role, the user is unable to save a
    case for a customer with Entitlement setting for Decrease Remaining On
    upon Case Creation. There is no issue in saving a case record otherwise.

-   Pricing error notifications aren't displayed on the Quote Order Invoice
    detail forms.

-   Unable to Add Quote from an opportunity form for products that are
    read-only.

-   The **Save & Close** command for a Price List Item displays an error and
    doesn't close the window properly.

-   In organizations using languages other than English, an unexpected error
    occurs while trying to assign a security role to a newly created user.

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
    Opportunity Quotes) appears as an ellipsis above the grid but isn't aligned
    correctly.

-   Web resources aren't rendered on the dashboards.

-   Web resources and IFrame tags aren't displayed with the height and width
    they're allocated in the mobile app configuration.

-   The Quote command bar is missing icons.

-   Opportunity Product Quick Create opens in a new window instead of through a
    sliding dialog box.

-   A few activity-specific commands aren't available from activity entity
    grids. They're available in all other places (forms, and so on).

-   On mobile devices, email is read-only on the Sales Hub.

-   Links in the body of an email aren't selectable.

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

    -   The Case business process flow isn't available when a new case is being
        created. It's available after the Case form is saved.

    -   Phone to case process: The Find Case option on the Identify stage isn't
        available for update for an existing case.

    -   The SLA lookup, when added via case entity form customization renders as
        read-only and the user will not be able to use the look-up to associate
        an on-demand SLA with the case record. This impacts only those set of
        customers who are on 9.0 version already and receiving an interim 9.0
        update. This issue does not impact new users signing for Dynamics 365
        trial.

    -   The Similar Cases sub-grid isn't available on the Case form.

    -   On mobile devices, email is read-only on the Customer Service Hub.

    -   Links in the body of an email aren't selectable.

    -   Scrolling in the body of an email stops working after the user opens any
        attachment. The workaround is to refresh the form.

    -   The Knowledge Articles Related Translations sub-grid is hidden when the
        user zooms in.

    -   Anchor links aren't working in the Knowledge Search control.

-   Other

-   User and team queues aren't available in the Add to Queue lookup.

-   Fallback forms are shown for the main forms for Category, Feedback, and
    Knowledge Article View entities, because their intended main forms (called
    *interactive forms*) are inactive by default. The workaround is to activate
    the forms manually. This issue will be fixed in the upcoming release, but
    orgs upgrading from Potassium Preview will need to manually activate the
    forms.

-   Invalid commands are visible for custom activities from the site map.

-   Activities are opened in the Main form layout instead of a Quick Create form
    when creating a record from a bound dashboard.

App modules and the App Designer
--------------------------------

-   The app module URL suffix provides a friendly URL for the app module in the
    form \<server url\>/apps/sales. Admins can set this URL suffix for their
    organization to provide their users a friendly URL. However, this URL suffix
    can't be exported or imported via solutions at this time.

-   In some versions of the Firefox browser, the check boxes on the Create App
    page in the app designer don't appear.

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

-   When filters are ungrouped, the order of the filters isn't persisted.

Data visualization 
-------------------

### Dashboards in Unified Interface 

-   Users will experience some right-to-left issues, such as the dashboard
    picker and label not being properly aligned.

-   On a Windows 10 phone or Internet Explorer, users will experience problems
    on the dashboard because this device and browser aren't supported.

### Interactive dashboards in Unified Interface

-   Interactive dashboards aren't supported in offline mode.

-   Any metadata settings in option sets to configure visual filter colors have
    no effect, and charts won't be rendered in customized colors.

-   When an activity grid is configured to be rendered as a calendar control,
    the **Open Dashboards** command opens the Activity Pointer dashboard instead
    of the actual activity dashboard.

-   Filtering by using multi-select option sets in global filters isn't
    supported.

### Charts in Unified Interface

-   Charts show the message "Loading" when the user doesn't have the read
    privilege for the chart's underlying entity.

-   On devices, a pie chart with too many slices might not show all data
    indexes.

-   On iOS devices, a chart in expand mode might look blurred.

-   Filters on a chart aren't preserved. If you select **Hide Chart** and then
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
    Timeline control in a dashboard shows the message "An unexpected error
    occurred." This is a transient problem; the workaround is to close the
    dashboard editor and refresh the page.

-   In certain resolutions on dashboards, when you open the filter pane in the
    Timeline control, the filter pane almost covers the Timeline control and the
    user can't see the records. The workaround is to customize the dashboard and
    increase the height of the Timeline control.

-   In dashboards, if the Timeline control is too short, some filters won't be
    visible because the filter pane isn't scrollable.

Field controls and mobile application in Unified Interface
----------------------------------------------------------

-   Visual controls aren't fully functional.

-   Selecting a location card doesn't open the map in the native app of the
    device.

-   The Phone Call activity quick-create form isn't opened when the call action
    is initiated on the mobile app.

-   Date fields can't be set in Internet Explorer 11, Firefox, or Microsoft
    Edge.

-   The date-time control uses browser locale as opposed to user locale for
    editing.

-   In text controls, long strings aren't getting wrapped in read mode.

-   Unable to add an unresolved email ID to a party list.

-   Incorrect quick-create forms are rendered when a new record is created by
    using **+New** in the Regarding lookup field.

-   The Lookup most recently used list doesn't take into account the lookup
    view.

-   Can’t enable web resources for offline through an imported solution.

-   For related grids, command flyouts don't open in See More mode.

-   Entities that haven't been enabled for Unified Interface appear in
    multiple-entity grids (for example, the Activity grid).

-   Device settings aren't preserved across app restarts for an online org with
    no cache.

-   Cache mode doesn't work for disconnected mode.

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

-   The control isn't aligned correctly on iOS devices.

-   The control UI isn't displayed correctly on Android 5.

Timer control in Unified Interface
----------------------------------

-   SLA Timer doesn't pause or resume when a case is put on hold or resumed. The
    workaround is to refresh the form.

Activities in Unified Interface
-------------------------------

-   Unable to resolve the email address of a contact for received email.

-   Task, Phone Call, Appointment, and Custom activities don't honor the
    **read-only in mobile** flag on Unified Interface.

-   The Save button still shows after the user saves an appointment task.

-   Scrolling in the body of an email stops working after the user opens an
    attachment twice on the device.

-   The Regarding field is not populated when the user replies to an email from
    the Activity pane.

-   An error occurs when multiple records are set for the **Call To** field and
    the direction is changed to **Incoming**.

-   Unable to open activities from a record set.

-   Related campaign field is not present in convert to opportunity dialog.

-   Converting a custom activity to opportunity results in an error.

-   Social Activities views are not displayed in My Activities views. The
    workaround is viewing Social activities in All Activities view.

Dynamics 365 App for Outlook
----------------------------

-   Dynamics 365 App for Outlook is currently available as a Public Preview and
    can be enabled through **System Settings** \> **Previews** \> **Enable
    Dynamics 365 App for Outlook Preview**. The previously released version of
    the app isn't supported with this release.

-   Initial loading might take some time.

-   When selecting **See more** to see more entities, Outlook 2013 and Outlook
    2016 display an add-in error, Chrome and Internet Explorer 11 display a
    "long running script" error message, and Edge displays a blank screen for a
    while and then navigates to the previous page.

-   On Outlook 2013 and Outlook 2016, Outlook frequently displays "add-in
    error."

-   On Internet Explorer 11, Internet Explorer frequently displays a "long
    running script" error message.

-   When navigating to a record's main form, Outlook 2013 and Outlook 2016
    display an add-in error; in Chrome and Internet Explorer 11 the app displays
    a "Script Error" message.

-   When entering text in the **Look for Records** field when you set regarding,
    in Outlook 2013 and Outlook 2016, some of the characters disappear. On
    Chrome, Internet Explorer 11, and Edge the lookup sometimes stays in the
    "Loading…" state forever.

-   The Back button doesn't work on Outlook 2016 and Outlook 2013. On browsers,
    selecting the back icon navigates to the previous webpage (this is the same
    action as selecting the browser Back button).

-   The ability to follow and email while composing isn't available.

-   The app isn't supported while accessing it from Outlook Web Application from
    Safari or Firefox.

-   The app is currently not supported on Outlook for Mac.

-   While scrolling in the app, the action might be delayed or the app might
    become unresponsive for few seconds.

-   When tracking / set regarding to an email, and selecting **View email in
    Dynamics 365**, one of sections in the email entity might display an error
    "You are not a member of this organization."

Inactivity timeout
------------------

-   Inactivity timeout isn't enforced in the following clients:

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
    cause an error message and won't complete the operation successfully.

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

    -   Doesn't appear on a new form in create mode.

    -   Doesn't change dynamically when the height of a field or component
        changes and might leave an empty space. However, this empty space will
        disappear on refresh

Important note for Field Service or Project Service Automation organizations that update to Dynamics 365 version 9.0, or later 
-------------------------------------------------------------------------------------------------------------------------------

When you update to version 9.0, or later, you must also update the Project
Service Automation and Field Service Solutions. After updating to version 9.0,
or later, go to the Dynamics 365 Administration Center, Manage Solutions page to
update the preferred solution.

Cortana integration with Dynamics 365
-------------------------------------

-   The Cortana integration with Dynamics 365 provides access to sales
    activities, accounts, and tasks through Cortana. However, reactive Cortana
    commands using voice or text aren't available currently. Voice or text
    commands such as "Dynamics 365 open account called Contoso" or "CRM find
    account called Contoso" will be redirected to open as a web search in Bing.
    Although the rest of the capabilities are still available, we are working on
    these reactive commands and plan to release them in a future update.

Mobile Offline
--------------

-   Any BPF which will update the entity will throw conflict errors on upsync of
    any offline changes, where the entity records have been created or updated.
    Work around is to disable conflict detection from Mobile Offline settings
    for the org.

-   Change of organization URL leads to disabling of mobile offline feature

-   When you delete an entity field and immediately create another entity field
    with the same name and a different data type, you might see an Offline Sync
    failure. The workaround is to do one of the following:

    -   Don't give the same name to columns that have different data types.

    -   If it is necessary to give the same name to columns that have different
        data types, wait at least 10 minutes after you delete the field before
        you re-create a field with the same name and a different data type.

-   Multi-select option set on a form isn't supported in offline.

-   Activity Entity views like All Appointments, All Tasks, and All Phone calls
    aren't supported in offline. Only the full activity views like All
    Activities and My Activities are supported in offline.

-   Only the Lead to Opportunity Sales Process Cross Entity business process
    flow is supported in offline. Other cross-entity business process flows
    aren't supported in offline

-   Multiple instances of business process flows on a single record aren't
    supported in offline.

-   Activity Grid fails to load in offline unless email is added to the Mobile
    Offline profile

-   User is not notified of any unsaved changes during sign-out or reconfigure

-   Email body is rendered blank in offline mode

-   Calendar view is not supported in offline, and there could be some
    inconsistencies in the data in this view in offline.

-   IFrames are not supported in offline mode

-   Updates to a BU for a user role when the user is offline are not synced
    properly on reconnecting

-   Attachment records created in online mode on the client are not immediately
    available in offlineDB. They are available after the next sync from server.

-   In Offline mode, parent records are not pre-populated on create of child
    entities from subgrid of parent entity

-   Grid does not auto-refresh on closing of opportunity from grid

-   Profile Analyze Report does not include activity views.

-   Profile Analyze Report does gives wrong indication for activity entity views
    like My Appointment etc.

-   Client sync may take up to 11 minutes when app is re-launched in online Mode

-   Records with a BPF associated need to have sufficient privileges configured
    on BPF entity also.

-   Opportunity products subgrid in opportunity record is in loading state in
    offline.

-   With BPF enabled, lead to opportunity qualify fails in offline mode

-   With BPF enabled, opportunity creation fails in offline mode

-   Next Stage does not respond in offline mode intermittently

-   On activities show as option to switch between view modes is not available
    in offline intermittently

Third-party notice 
-------------------

[Third-party notice](https://go.microsoft.com/fwlink/p/?linkid=853765)
