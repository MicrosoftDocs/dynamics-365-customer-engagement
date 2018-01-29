---
title: "Dynamics 365 Customer Engagement Readme (Known Issues) | MicrosoftDocs"
ms.date: 01/29/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 99ea6ece-c35a-4f0e-85a4-26622cd87031
---

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
required to take the following actions to maintain the connectivity to Dynamics
365 Customer Engagement applications.

1.  Use [supported
    browsers](https://technet.microsoft.com/library/hh699710.aspx#Anchor_2) to
    access the Microsoft Dynamics 365 web application. For help identifying if a
    browser supports the TLS 1.2 requirement, go to this [validation test
    page](https://tls1-2validationtest.crm10.dynamics.com/TLSvalidation.html).

2.  Recompile your custom Windows clients that were built using the .NET
    Framework 4.5.2 to use the .NET Framework 4.6.2 or later.

3.  Download and update your Dynamics 365 for Outlook to [version
    8.2.2.137](https://www.microsoft.com/download/details.aspx?id=56327).

4.  Download [latest version of developer
    tools](https://docs.microsoft.com/dynamics365/customer-engagement/developer/download-tools-nuget)
    from NuGet.

5.  Download and update your Unified Service Desk to [version
    3.1.0](https://www.microsoft.com/download/details.aspx?id=56144). If you
    want to continue to use older versions of Unified Service Desk, you must
    [update the client desktop’s registry
    entries](https://blogs.msdn.microsoft.com/usd/2017/10/20/unified-service-desk-and-tls-1-2-mandate-for-dynamics-365-online/).

Please refer to the following information to help identify whether you are
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
| Customer Service - Case management scenarios      | Customer Service Hub                   | Customer Service Hub                | Customer Service            |

 

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
    grids. They're available in all other places, such as forms.

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

    -   When assigning a record to a user with insufficient privileges the
        assignment fails as expected, but no error message is shown.

    -   Phone to case process: The Find Case option on the Identify stage isn't
        available for update for an existing case.

    -   On mobile devices, email is read-only on the Customer Service Hub.

    -   Links in the body of an email aren't selectable.

    -   Scrolling in the body of an email stops working after the user opens any
        attachment. The workaround is to refresh the form.

    -   The Knowledge Articles Related Translations sub-grid is hidden when the
        user zooms in.

    -   Anchor links aren't working in the Knowledge Search control.

    -   Knowledge Base Search control causes an error when the auto-suggestion
        feature is used without adding the auto-suggest field to the form.

-   Other

-   User and team queues aren't available in the Add to Queue lookup.

-   Access team template definition, is currently not supported.

-   When associating a large number of case records in a Parent-child
    relationship at one go, using the Associate Child Cases action on the cases
    grid, a maximum of 25 case records is shown in the Set Parent Child
    Relationship dialog.

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
    of the activity dashboard.

-   The ribbon context for any entity of Activity type defaults to
    Activitypointer, and hence the stream quick actions show commands relevant
    for all activities, rather than honoring the entity’s ribbon context.

-   Custom interactive dashboards of any Activity entity other than the
    Activitypointer are known to result in an error

-   Filtering by using multi-select option sets in global filters isn't
    supported.

### Charts in Unified Interface

-   Charts show the message "Loading" when the user doesn't have the read
    privilege for the chart's underlying entity.

-   On devices, a pie chart with too many slices might not show all data
    indexes.

-   On iOS devices, a chart in expand mode might look blurred.

-   On phone devices, the chart overlaps the records available in a grid after
    you close the expanded view for the grid page.

-   On some grids, the Show Chart button shows an empty chart selector because
    no chart exists for the underlying entity.

-   Users will experience some right-to-left issues on charts, such as tooltips
    not showing up.

-   When you select **Show Chart** on a grid while in offline mode, no chart
    will be displayed.

Subject tree control

-   To select a value for the subject attribute on a form or on the Convert-to
    dialogs, click on the space that displays the subject value. Clicking on the
    down arrow of the Subject tree control does not launch the subject flyout.

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

-   The Lookup control shows two vertical scrollbars. There is no functional
    impact due to this.

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

-   In grids, when viewing records available from 2nd to Nth page, any command
    bar action performed will take you back to the 1st page of the grid. The
    command bar action is successfully completed and there is no functional
    impact due to this.

-   If the Quick find view definition is customized to include any Date-time
    attributes as find columns, then the Quick find search for Date-time fields
    returns incorrect results. The records retuned are for searched date -1.

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

-   The bBsingthe user esingan and focusing on fieldThe Save button still shows
    after the user saves an appointment task.

-   Scrolling in the body of an email stops working after the user opens an
    attachment twice on the device.

-   The Regarding field is not populated when the user replies to an email from
    the Activity pane.

-   An error occurs when multiple records are set for the **Call To** field and
    the direction is changed to **Incoming**.

-   Unable to open activities from a record set.

-   Related campaign field is not present in convert to opportunity dialog.

-   Converting a custom activity to opportunity results in an error. Social
    Activities views are not displayed in My Activities views. The workaround is
    viewing Social activities in All Activities view.

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
    Chrome, Internet Explorer 11, and Microsoft Edge the lookup sometimes stays
    in the "Loading…" state forever.

-   The Back button doesn't work on Outlook 2016 and Outlook 2013. On browsers,
    selecting the back icon navigates to the previous webpage (this is the same
    action as selecting the browser Back button).

-   The ability to follow and email while composing isn't available.

-   The app isn't supported while accessing it from Outlook Web Application from
    Safari or Firefox.

-   The app is currently not supported on Outlook for Mac.

-   While scrolling in the app, the action might be delayed, or the app might
    become unresponsive for few seconds.

-   When tracking / set regarding to an email, and selecting **View email in
    Dynamics 365**, one of sections in the email entity might display an error
    "You are not a member of this organization."

-   Opening and closing the app a few times repeatedly on Internet Explorer and
    Microsoft Edge in Outlook Web Access causes the browser to be unresponsive.

Dynamics 365 for Outlook

Microsoft has released Dynamics 365 for Outlook version 8.2.2.137 update. This
update includes support for Transport Layer Security (TLS) 1.2, which is
required for connecting Dynamics 365 for Outlook with Dynamics 365 (online),
version 9.0. See [Version 8.2.2.137 Update for Dynamics 365 for
Outlook](https://www.microsoft.com/en-us/download/details.aspx?id=56327).

Inactivity timeout
------------------

-   Inactivity timeout isn't enforced in the following clients:

    -   Outlook

    -   Dynamics 365 for tablets

    -   Dynamics 365 for phones

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
    contain any of the following:

    -   Any input or output arguments of the type Entity, EntityCollection, or
        Option Set (picklist).

    -   More than one output argument of the type EntityReference.

    -   Any input arguments of the type EntityReference.

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
        disappear on refresh.

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

-   **Offline web resources are not available on Windows tablets**. Web
    resources are not available in offline mode on Windows tablets.

-   **Background synchronization frequency is not defined.** The background
    synchronization frequency is determined by the operating system; not by the
    mobile app.

-   **Limitation for mobile offline JavaScript client SDK for Create Record and
    Update Record**. The client SDK can't be used to create or update intersect
    entity records, offline disabled entity records, or activity party entity
    records. Data input validation does not occur. All data-related validations
    occur during the sync to Dynamics 365.

-   **Limitation for mobile offline JavaScript client SDK Delete**. The client
    APIs can't be used to delete the intersect entity, offline disabled entity,
    or activity party entities.

-   **Limitations for mobile offline JavaScript client SDK Retrieve**.

    -   OData query options should start with `\$` similar to URL query
        parameters.

    -   `\$select` only retrieves the attribute of the base entity and not of the
        related entity.

    -   `\$expand` only uses navigation property names.

    -   Only `\$select` can be specified inside `\$expand`.

    -   Only 5,000 related records can be retrieved.

    -   A next link is not provided.

-   **Limitations for mobile offline JavaScript client SDK Retrieve Multiple**

    -   `\$select` only retrieves the attribute of the base entity and not of the
        related entity.

    -   `\$expand` only uses navigation property names.

    -   Only `\$select` can be specified inside `\$expand`.

    -   You can use a navigation property only when both participating entities
        are offline-enabled.

    -   MaxPageSize is optional and should be greater than zero.

    -   `\$filter` does not function. These conditional operators are supported:
        =, !=, \< \>, \<=, \>=.

    -   Only AND, OR, NOT logical operators are supported.

    -   `\$filter` can be applied on base entity attributes, but not on related
        attributes.

    -   `\$expand` returns next links for N:1 relationships.

    -   Next link is JSON formatted and users must construct the next Retrieve
        call using the next link.

    -   `\$skiptoken`, `\$getOnlyRelatedEntity` is for internal use only, and should
        not be changed by users.

    -   `\$skip` is not supported.

    -   FetchXml only retrieves base entity attributes.

-   **Limitations on views in mobile offline**

    -   Entity views that have a date hierarchy-based parameter used as filter
        criteria, are not available in mobile offline.

    -   Only system views are supported in mobile offline.

    -   If a view has attributes from any other offline-disabled entity, data
        will not be shown in that view in mobile offline.

-   **Limitation on mobile offline security**

    -   Field level security attribute sharing is not supported in offline mode.

-   Any Business Process Flow that updates the entity will throw conflict errors
    when syncing offline changes, where the entity records have been created or
    updated. The work around is to disable conflict detection from Mobile
    Offline settings for the organization.

    -   With Business Process Flow enabled, lead to opportunity qualify fails in
        offline mode.

    -   With Business Process Flow enabled, opportunity creation fails in
        offline mode.

-   When you change the organization URL, the mobile offline feature is
    disabled.

-   When you delete an entity field and immediately create another entity field
    with the same name, but a different data type, you might see an offline sync
    failure. The workaround is to do one of the following:

    -   Don't give columns the same name if they have different data types.

    -   If it’s necessary to give the columns that have different data types the
        same name, wait at least 10 minutes after you delete the field before
        you re-create it.

-   Activity Entity views, such as All Appointments, All Tasks, and All Phone
    calls, aren't supported in offline mode. Only the full activity views, such
    as All Activities and My Activities, are supported in offline mode.

-   Only the Lead to Opportunity Sales Process Cross Entity business process
    flow is supported in offline mode. Other cross-entity business process flows
    aren't supported in offline mode.

-   Multiple instances of business process flows on a single record aren't
    supported in offline mode.

-   Activity Grid fails to load in offline mode unless email is added to the
    Mobile Offline profile.

-   Users are not notified of any unsaved changes during sign-out or
    reconfiguration.

-   The Email body is rendered blank in offline mode.

-   Calendar view is not supported in offline mode. There might be some
    inconsistencies in the Calendar view data in offline mode.

-   IFrames are not supported in offline mode.

-   Updates to a business unit for a user role when the user is offline are not
    synced properly upon reconnection.

-   Attachment records created in online mode on the client are not immediately
    available in the offline database. They are available after the next sync
    from the server.

-   When you create child entities from the parent entity subgrid in offline
    mode, parent records are not pre-populated

-   When you close an opportunity from the gird, the grid does not auto-refresh.

-   The Profile Analyze Report does not include activity views.

-   The Profile Analyze Report incorrectly indicates offline availability for
    activity entity views, such as My Appointment.

-   Client sync might take up to eleven minutes when the app is re-launched in
    online mode.

-   Records with an associated Business Process Flow must have sufficient
    permissions configured on the Business Process Flow entity.

-   In the Opportunity entity form, the Opportunity Product subgrid does not
    load successfully in offline mode. It remains in a 'loading' state.

-   Next Stage intermittently fails to respond in offline mode.

-   The option to switch between view modes is intermittently unavailable in
    offline mode.

-   Mobile offline does not support virtual entities. If a virtual entity is
    enabled for mobile offline, the associated profile metadata will result in
    an error.

-   Any form with the multiselect option set, will not be supported for mobile
    offline.

-   The Timeline control is not supported in offline mode.

-   Attachments are not immediately available for offline synchronization.

Unified Service Desk
--------------------

-   Case form does not load completely on IE11 browser

-   Download and update your Unified Service Desk to [version
    3.1.0](https://www.microsoft.com/download/details.aspx?id=56144). If you
    want to continue to use older versions of Unified Service Desk, you will
    need to update the client desktop’s registry entries[. Read the blog about
    Unified Service Desk and TLS 1.2
    mandate](https://blogs.msdn.microsoft.com/usd/2017/10/20/unified-service-desk-and-tls-1-2-mandate-for-dynamics-365-online/)
    to update these registry entries. . Read the blog about Unified Service Desk
    and TLS 1.2 mandate￼￼￼￼ to update these registry entries. . Read the blog
    about Unified Service Desk and TLS 1.2 mandate￼￼￼￼ to update these registry
    entries. . Read the blog about Unified Service Desk and TLS 1.2 mandate￼￼￼￼
    to update these registry entries. . Read the blog about Unified Service Desk
    and TLS 1.2 mandate￼￼￼￼ to update these registry entries. . Read the blog
    about Unified Service Desk and TLS 1.2 mandate￼￼￼￼ to update these registry
    entries. . Read the blog about Unified Service Desk and TLS 1.2 mandate￼￼￼￼
    to update these registry entries. . Read the blog about Unified Service Desk
    and TLS 1.2 mandate￼￼￼￼ to update these registry entries. . Read the blog
    about Unified Service Desk and TLS 1.2 mandate￼￼￼￼ to update these registry
    entries. . Read the blog about Unified Service Desk and TLS 1.2 mandate￼￼￼￼
    to update these registry entries. . Read the blog about Unified Service Desk
    and TLS 1.2 mandate￼￼￼ to update these registry entries. . Read the blog
    about Unified Service Desk and TLS 1.2 mandate￼ to update these registry
    entries. . Read the blog about Unified Service Desk and TLS 1.2 mandate to
    update these registry entries.

-   Apps built using Unified Interface are not supported with Unified Service
    Desk. More information: [Unified Interface framework for new
    apps](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/new-in-july-2017-update#unified-interface-framework-for-new-apps)Unified
    Interface framework for new appsUnified Interface framework for new
    appsUnified Interface framework for new apps

-   **Interactive Service Hub**: With the Dynamics 365 (online), version 9.0
    release, Interactive Service Hub has been rebuilt as a Unified Interface
    app, and is called Customer Service Hub. This implies
    that [support](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/interactive-service-hub-page-hosted-control) for
    the Interactive Service Hub in Unified Service Desk is available only if you
    are running Dynamics 365, version 8.2 or an earlier supported version of
    Microsoft Dynamics CRM.support for the Interactive Service Hub in Unified
    Service Desk is available only if you are running Dynamics 365, version 8.2
    or an earlier supported version of Microsoft Dynamics CRM.support for the
    Interactive Service Hub in Unified Service Desk is available only if you are
    running Dynamics 365, version 8.2 or an earlier supported version of
    Microsoft Dynamics CRM.support for the Interactive Service Hub in Unified
    Service Desk is available only if you are running Dynamics 365, version 8.2
    or an earlier supported version of Microsoft Dynamics CRM.

-   **Relationship Insights**: Although you can view information from the
    relationship assistant in the Unified Service Desk client, you cannot
    interact with the information. More information: [Relationship
    Insights](https://docs.microsoft.com/dynamics365/customer-engagement/admin/relationship-insights)Relationship
    InsightsRelationship InsightsRelationship Insights

-   **LinkedIn Sales Navigator for Microsoft Dynamics 365 for Sales**: This is
    not supported.

-   **Multi-select option sets**: Although multi-select option sets display fine
    when hosted in Unified Service Desk (using [CRM
    Page](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/crm-page-hosted-control) type
    of hosted control), you cannot change selections in multi-select option sets
    using the Unified Service Desk APIs.CRM Page type of hosted control), you
    cannot change selections in multi-select option sets using the Unified
    Service Desk APIs.CRM Page type of hosted control), you cannot change
    selections in multi-select option sets using the Unified Service Desk
    APIs.CRM Page type of hosted control), you cannot change selections in
    multi-select option sets using the Unified Service Desk APIs.

-   **URL addressability in business apps**: Business apps (app modules) use the
    appid value in the URLs to refer to resources displayed in an app. For
    example:
    “https://.crm.dynamics.com/main.aspx?appid=b0f40cd2-22a6-e711-a94e-000d3a1a7a9b&pagetype=entitylist&etn=bookableresourcebooking.”
    Unified Service Desk does not support the use of appid values in URLs to
    refer to a resource. More information: [Design custom business apps by using
    the app
    designer](https://docs.microsoft.com/dynamics365/customer-engagement/customize/design-custom-business-apps-using-app-designer)Design
    custom business apps by using the app designer

Third-party notice 
-------------------

[Third-party notice](https://go.microsoft.com/fwlink/p/?linkid=853765)
