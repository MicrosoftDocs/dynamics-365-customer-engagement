---
title: "Dynamics 365 Customer Engagement Readme (Known Issues) | MicrosoftDocs"
ms.date: 06/04/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 99ea6ece-c35a-4f0e-85a4-26622cd87031
author: "kathleenmcgrath"
ms.author: "kmcgrath"
manager: "renwe"
---

Dynamics 365 Customer Engagement<br>Readme / Known Issues
=========================================================

This document provides important information about this product version:

-   Dynamics 365 (online), Enterprise edition, version 9.0

You'll also find information about known issues and possible workarounds.

Services and apps availability
-------------------------------

| Services and Apps                                    | GA | Public Preview | Private Preview |
|------------------------------------------------------|----|----------------|-----------------|
| Dynamics 365 for Sales                               | X  |                |                 |
| Dynamics 365 for Customer Service                    | X  |                |                 |
| Dynamics 365 for Field Service                       | X  |                |                 |
| Dynamics 365 for Project Service                     | X  |                |                 |
| Portal capabilities for Dynamics 365                 | X  |                |                 |
| Relevance Search Enhancements                        | X  |                |                 |
| Learning Path                                        | X  |                |                 |
| Resource Scheduling Optimization                     | X  |                |                 |
| Glympse                                              | X  |                |                 |
| Connected Field Service (Internet of Things)         | X  |                |                 |
| Machine Learning                                     | X  |                |                 |
| Office 365 Group                                     | X  |                |                 |
| Gamification                                         | X  |                |                 |
| Organizational Insights                              | X  |                |                 |
| CaféX Live Assist                                    | X  |                |                 |
| Document recommendations                             | X  |                |                 |
| Company News                                         | X  |                |                 |
| Unified Service Desk                                 | X  |                |                 |
| Voice of the Customer                                | X  |                |                 |
| Dynamics 365 App for Outlook                         | X  |                |                 |
| Embedded intelligence – Auto capture                 | X  |                |                 |
| Embedded intelligence – Relationship assistant       | X  |                |                 |
| Embedded intelligence – Email engagement             | X  |                |                 |
| LinkedIn (Lead Gen Forms only)                       |    | X              |                 |
| Mobile offline (Dynamics 365 for phones and tablets) | X  |                |                 |
| Sales insights add-on – Relationship analytics       |    | X              |                 |

Transport Layer Security (TLS) Requirements
-------------------------------------------

Starting with Dynamics 365 (online), version 9.0, connections to Customer
Engagement applications are required to use TLS 1.2 (or later) security
protocols. This aligns with updated Microsoft and industry security policies and
best practices. To prevent any disruption to your organization, you might be
required to take the following actions to maintain the connectivity to Dynamics
365 Customer Engagement applications.

1.  Use [supported
    browsers](https://technet.microsoft.com/library/hh699710.aspx) to access the
    Microsoft Dynamics 365 web application. For help identifying if a browser
    supports the TLS 1.2 requirement, go to this [validation test
    page](https://go.microsoft.com/fwlink/?linkid=874490).

2.  Recompile your custom Windows clients that were built using the .NET
    Framework 4.5.2 to use the .NET Framework 4.6.2 or later.

3.  Download and update your Dynamics 365 for Outlook to [version
    8.2.2.137](https://www.microsoft.com/download/details.aspx?id=56327).

4.  Download the [latest version of developer
    tools](https://docs.microsoft.com/dynamics365/customer-engagement/developer/download-tools-nuget)
    from NuGet.

5.  Download and update your Unified Service Desk to [the latest
    version](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/download-unified-service-desk)
    (versions 3.1, 3.2, and 3.3 are TLS 1.2 compliant). If you want to continue
    to use older versions of Unified Service Desk, you must [update the client
    desktop’s registry
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

**Note** If your organization is impacted by this requirement, you must take the
necessary steps to upgrade to TLS 1.2 prior to scheduling your instance update.

Sales and Customer Service web client apps
------------------------------------------

-   Core Marketing:

    -   Activities aren't created after the campaign activity is distributed.

    -   Unable to add members in a locked marketing list by selecting **Add
        using advanced find**.

    -   Unable to create a dynamic marketing list.

    -   Unable to add members in a marketing list by selecting **Add using
        advanced find**.

    -   Occasionally unable to unsubscribe an account, contact, or lead from the
        campaign activity.

-   Suggestions aren't available on the Product subgrid in Quote, Order, or
    Invoice forms.

-   Unable to create a new data source entity when there are spaces in the
    entity's name.

-   The campaign response form doesn't load, so it can't be converted to a lead.

-   Unable to convert a campaign response to a lead.

-   Unable to open a Campaign Activity page to unsubscribe an account, contact,
    or lead, or to update a campaign.

-   Unable to add a custom view as a subcomponent for the Account entity in a
    solution.

-   Pricing error notifications aren't displayed on the Quote Order Invoice
    detail forms.

-   Unable to Add Quote from an opportunity form for products that are
    read-only.

-   The **Save & Close** command for a Price List Item displays an error and
    doesn't close the window properly.

-   In organizations using languages other than English, an unexpected error
    occurs while trying to assign a security role to a newly created user.

-   Knowledge Articles are displayed unformatted when relevance search is
    enabled.

-   If there is any text in the quick find search when a view is changed,
    records are not refreshed in the Knowledge Article form.

-   Knowledge Articles sometimes display an inaccurate number of article views.

-   When you give a long name (more than 41 characters) to a custom entity
    enabled for Knowledge Management, you might get an error.

-   Search of Knowledge Articles on custom dashboards might not return results.

-   Only the first keyword added to a Knowledge Article returns results in a
    quick find search.

-   If a Knowledge Article is in read-only mode, links in the article will not
    work.

Sales Hub and Customer Service Hub apps 
----------------------------------------

For best performance, the following table shows the **recommended app** to use
in the browser or on mobile devices for each scenario. 

| **Service**                                       | **Unified Interface app in a browser** | **Unified Interface app on mobile** | **Web client in a browser** |
|---------------------------------------------------|----------------------------------------|-------------------------------------|-----------------------------|
| Sales                                             | –                                      | Sales Hub                           | Sales                       |
| Customer Service – Knowledge management scenarios | Customer Service Hub                   | Customer Service Hub                | –                           |
| Customer Service – Case management scenarios      | Customer Service Hub                   | Customer Service Hub                | –                           |

 

### Sales Hub app on Dynamics 365 for tablets and Dynamics 365 for phones

-   An error is displayed on iPads whenever a user tries to add a product to an
    opportunity. The workaround is to dismiss the error.

-   The command bar action of a subgrid that has no title (Opportunity product,
    Opportunity Quotes) appears as an ellipsis above the grid but isn't aligned
    correctly.

-   Web resources aren't rendered on the dashboards.

-   Web resources and IFrame tags aren't displayed with the height and width
    they're allocated in the mobile app configuration.

-   The Quote command bar is missing icons.

-   Opportunity Product Quick Create opens in a new window instead of through a
    sliding dialog box.

-   A few activity-specific commands aren't available from the activity entity
    grids. They're available in all other places, such as forms.

-   On mobile devices, email is read-only on the Sales Hub.

-   Links in the body of an email aren't selectable.

### Customer Service Hub app on Dynamics 365 for tablets and Dynamics 365 for phones 

-   Forms

    -   When you install the Community portal, the Read-only in Mobile metadata
        flag is enabled for the Case entity. This results in the Case entity
        being read-only in the Customer Service Hub. The workaround is to go to
        entity customizations and clear the **Read-only in mobile** check box in
        the Case entity metadata. Then, select **Save** and **Publish all
        customizations**.

    -   Phone to case process: The Find Case option on the Identify stage isn't
        available for update for an existing case.

    -   On mobile devices, email is read-only on the Customer Service Hub.

    -   Links in the body of an email aren't selectable.

    -   When you have too many subgrids on your form, Customer Service Hub has
        performance issues in Internet Explorer 11. As a workaround, you can
        reduce the number of subgrids on the first page/tab.

    -   Quick forms with multiple lines of text occupy a large amount of
        vertical space on the Reference Panel section in forms. Scroll downwards
        to see more fields.

    -   In the Knowledge Article form, related articles are opened in a new form
        instead of within the subgrid.

    -   The page background color changes when you select Related Product or
        Related Article in the Knowledge Article form.

-   Other

    -   Some organizations might see duplicate views for All Accounts on the
        Account homepage grid and for All Contacts for the Contact homepage
        grid. For organizations updating or signing up to the latest version,
        the redundant pair of views display as 'All Accounts (not available)'
        and 'All Contacts (not available)'. Updating organizations will also
        find these views in a deactivated state, provided they are not
        customized. The guidance is not to use them, even though they continue
        to be fully supported.

    -   When a record is selected from the Queues entity grid and Pick or
        Release command actions are performed on an iPad, it results in
        displaying an empty dialog box. This issue is not observed on a web
        browser.

    -   When an opened article is closed in the KB search control, recent cases
        and entitlements are opened instead of the KB search control.

### Customer Service Hub (Internet Explorer 11 only)

-   The Calendar control for date-time fields doesn’t load for forms. The user
    will have to manually enter the date in the applicable format.

-   When viewing information in tile view mode on the Tier 1 dashboard, the full
    set of records for the title is not displayed in the records flyout. Users
    will have to switch to stream view to see all records.

-   When interacting with the look-up control on forms or dialogs, selecting the
    scroll bar causes the look-up control to close. Users can either use the
    scroll button of the mouse or use the keyboard Up and Down arrow keys to see
    the full set of records.

-   In Knowledge Articles, the Title, Description and Keywords text boxes are
    misaligned.

### Sales (professional license)

-   After the purchase of professional licenses for Dynamics 365 for Sales, the
    admin will not see a Sales Professional option while configuring the
    instance under **Which scenario fits best**. Instead, the admin must select
    **None**.

-   After the instance has been configured, a licensed admin must go to the
    Admin Center, select the instance just created, select Solutions, and
    install **Dynamics 365 for Sales, Professional**.

-   The professional license app access option is not available as a security
    role. Before the licensed users can access the app, the admin must give them
    the **Sales, Enterprise app access** security role.

App modules and the app designer
--------------------------------

-   The app module URL suffix provides a friendly URL for the app module in the
    form \<server url\>/apps/sales. Admins can set this URL suffix for their
    organization to provide their users a friendly URL. However, this URL suffix
    can't be exported or imported via solutions at this time.

-   In some versions of the Firefox browser, the check boxes on the Create App
    page in the app designer don't appear.

-   Any change in the name of a chart or dashboard made through corresponding
    editors launched from the app designer, will be reflected in the app
    designer only after refresh.

-   The Custom Business Process Flow entity that is created for a custom
    business process flow might not get automatically added to the app designer
    canvas when the business process flow is added to the app module.

-   In the app designer, the option to set **App for Outlook Dashboard** as your
    default dashboard is available for all Unified Interface apps, but the
    dashboard is only supported for Dynamics 365 App for Outlook. If you select
    this dashboard for another app, the dashboard will not load and users will
    see a blank screen or error message.

View designer 
--------------

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

### Charts in Unified Interface

-   Charts show the message "Loading" when the user doesn't have Read
    permissions for the chart's underlying entity.

-   On devices, a pie chart with too many slices might not show all data
    indexes.

-   On iOS devices, a chart might look blurred in expand mode.

-   On phone devices, the chart overlaps the records available in a grid after
    you close the expanded view for the grid page.

-   On some grids, the **Show Chart** button shows an empty chart selector
    because no chart exists for the underlying entity.

-   Users will experience some right-to-left issues on charts, such as tooltips
    not showing up.

Subject tree control
--------------------

-   To select a value for the subject attribute on a form or on the Convert-to
    dialogs, select the space that displays the subject value. Selecting the
    down arrow of the **Subject tree** control does not launch the subject
    flyout.

Timeline control
----------------

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

-   In text controls, long strings don’t get wrapped in read mode.

-   Unable to add an unresolved email ID to a party list.

-   The Lookup most recently used list doesn't take into account the lookup
    view.

-   Can’t enable web resources for offline through an imported solution.

-   For related grids, command flyouts don't open in See More mode.

-   Entities that haven't been enabled for Unified Interface appear in
    multiple-entity grids (for example, the Activity grid).

-   Device settings aren't preserved across app restarts for an online org with
    no cache.

-   Cache mode doesn't work in disconnected mode.

Grids and lists in Unified Interface
------------------------------------

-   In grids, when viewing records available from the second to Nth page, any
    command bar action performed will take you back to the first page of the
    grid. The command bar action is successfully completed and there is no
    functional impact.

-   On tablets, in some languages, the index (character) filters might be
    displayed too close to each other. The workaround is to use the Search
    command to find records that begin with a certain character.

-   On tablets, resizing column width on grids can be harder because of the
    smaller dragging touch target. The workaround is to change the column width
    in the view definition if some columns need to be wider.

Multi-select option set in Unified Interface
--------------------------------------------

-   The multi-select option set has known issues in Unified Interface.

-   The multi-select option set control always appears in edit mode.

-   The multi-select option set control drop-down arrow appears as a square box.

-   The control isn't aligned correctly on iOS devices.

-   The control UI isn't displayed correctly on Android 5.

Date time control in Unified Interface
--------------------------------------

The date time control in Unified Interface relies on browser support. It has
known issues in browsers such as Internet Explorer 11 and Firefox. It also has
localization and format issues.

Dynamics 365 App for Outlook
----------------------------

-   Initial loading might take some time.

-   In Outlook 2013 and Outlook 2016, Outlook frequently displays "add-in
    error."

-   In Internet Explorer 11, Internet Explorer frequently displays a "long
    running script" error message.

-   In Outlook 2013 and Outlook 2016, when entering text in the **Look for
    Records** field when you set regarding, some of the characters disappear. In
    Chrome, Internet Explorer 11, and Microsoft Edge, the lookup sometimes stays
    in the "Loading…" state.

-   The ability to follow an email while composing isn't available.

-   The app isn't supported while accessing it from Outlook Web Application from
    Safari or Firefox.

-   When tracking / set regarding for an email, if you select **View email in
    Dynamics 365**, one of the sections in the email entity might display an
    error "You are not a member of this organization."

-   Opening and closing the app a few times repeatedly in Internet Explorer and
    Microsoft Edge in Outlook Web Access causes the browser to become
    unresponsive.

-   If there are any custom security roles, [the roles need to be assigned to
    Dynamics 365 App for Outlook App
    Module](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/outlook-app/deploy-dynamics-365-app-for-outlook#provide-security-role-access).

Dynamics 365 for Outlook
------------------------

-   Microsoft has released Dynamics 365 for Outlook version 8.2.2.137 update.
    This update includes support for Transport Layer Security (TLS) 1.2, which
    is required for connecting Dynamics 365 for Outlook with Dynamics 365
    (online), version 9.0. See [Version 8.2.2.137 Update for Dynamics 365 for
    Outlook](https://www.microsoft.com/en-us/download/details.aspx?id=56327).

-   In offline mode, adding an attachment to a Note in Dynamics 365 for Outlook
    might show the message “Microsoft Dynamics 365 has encountered an error.” A
    workaround for this issue is to dismiss the notification and upload the
    attachment.

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

-   Empty subgrids show a message with the entity schema name instead of the
    display name.

-   Star symbols for fields secured via field-level security, might be
    incorrectly positioned in certain cases, for example in a multi-select
    option set field that has been secured by field-level security.

-   The mandatory field indicator in some bulk edit forms might be positioned
    incorrectly.

-   Sort and filter icons are incorrectly positioned on the activity wall on
    iPads.

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

Mobile Offline
--------------

We’re working to improve mobile offline capabilities in Dynamics 365 for phones
and tablets for release in the second quarter of 2019, and are currently
onboarding only a limited set of new customers. When a preview program opens for
mobile offline capabilities in Dynamics 365 for phones and tablets, we’ll let
customers know. Existing customers who are already using mobile offline
capabilities are not affected.

**Note:** The mobile app for Dynamics 365 for Field Service continues to support
mobile offline capabilities for existing and new customers.

Unified Service Desk
--------------------

-   Download and update your Unified Service Desk to the [latest
    version](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/download-unified-service-desk).
    If you want to continue to use versions of Unified Service Desk older than
    3.1, you will need to update the client desktop’s registry entries. Read the
    [blog](https://blogs.msdn.microsoft.com/usd/2017/10/20/unified-service-desk-and-tls-1-2-mandate-for-dynamics-365-online/)
    about Unified Service Desk and TLS 1.2 mandate to update these registry
    entries.

-   You can integrate apps built using Unified Interface in the Unified Service
    Desk using the preview capabilities in [version
    3.3](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/whats-new-unified-service-desk-administrators#whats-new-in-includepn-unified-service-desk-3-3includespn-unified-service-desk-3-3md).
    This support is not available in earlier versions. More
    information: [Support for Unified Interface Apps in Unified Service
    Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/support-unified-interfaces-apps-usd)

-   **Interactive Service Hub**: With the Dynamics 365 (online), version 9.0
    release, Interactive Service Hub has been rebuilt as a Unified Interface app
    and is called Customer Service Hub. This implies
    that [support](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/interactive-service-hub-page-hosted-control) for
    the Interactive Service Hub in Unified Service Desk is available only if you
    are running Dynamics 365, version 8.2 or an earlier supported version of
    Microsoft Dynamics CRM. You can integrate with Customer Service Hub in
    Unified Service Desk in the same way as any other Unified Interface app.
    More information: [Support for Unified Interface Apps in Unified Service
    Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/support-unified-interfaces-apps-usd)

-   **Relationship Insights**: Although you can view information from the
    relationship assistant in the Unified Service Desk client, you cannot
    interact with the information in the client. More information: [Embedded
    intelligence](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/embedded-intelligence)

-   **LinkedIn Sales Navigator for Microsoft Dynamics 365 for Sales**: This is
    not supported.

-   **Multi-select option sets**: Although multi-select option sets display fine
    when hosted in Unified Service Desk (using [CRM
    Page](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/crm-page-hosted-control) type
    of hosted control), you cannot change selections in multi-select option sets
    using the Unified Service Desk APIs.

-   **URL addressability in business apps**: Business apps (app modules) use the
    appid value in the URLs to refer to resources displayed in an app. For
    example:
    “https://.crm.dynamics.com/main.aspx?appid=b0f40cd2-22a6-e711-a94e-000d3a1a7a9b&pagetype=entitylist&etn=bookableresourcebooking.”
    Unified Service Desk has added support for the usage of appid values in URLs
    to refer to a resource from version 3.3. More information: [Design custom
    business apps by using the app
    designer](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/design-custom-business-apps-using-app-designer)

Third-party notice 
-------------------

[Third-party notice](https://go.microsoft.com/fwlink/p/?linkid=853765).
