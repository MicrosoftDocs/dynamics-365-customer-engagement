---
title: Customization best practices
description: Learn how to get the most out of your Dynamics 365 Field Service customizations.
ms.date: 06/25/2024
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
---

# Customization best practices

Follow these best practices to avoid performance, usability, and supportability issues with Dynamics 365 Field Service.

## Minimize custom fields on forms

System customizers add custom fields to entity forms to capture information that is specific to their industry and business, to run business processes, and to collect information to report on. However, too many custom fields on a form can cause performance issues.

To avoid performance issues:

- Minimize the number of custom fields on all forms. If the work order form is your most-used form in the Field Service app, it's a good idea to start with that form.
- Minimize the number of lookup-type fields and subgrids among custom fields.
- Move custom fields (especially lookups and subgrids) from the first form tab to other form tabs.
- Hide less-used fields on a form by default.

## Don't change out-of-box web resources, option sets, security roles, or workflows

Don't change or customize out-of-box web resources, option sets, security roles, or workflows. Otherwise, you might cause unintended system behavior.

Organizations that customize these components might not immediately experience issues in their environment. However, changes that Microsoft releases to the customized out-of-box components aren't applied to the top layer of those components. Instead, the specific customized layer overrides all future changes, and those overrides eventually cause unpredictable errors and behavior.

## Don't modify, edit, or delete date fields or system statuses

Modifying, editing, or deleting date fields and statuses can affect business logic and might cause issues with solution updates. Examples of work order date fields include **Time From Promised** and **Time To Promised**. Examples of status fields include **System Status** for the work order and **System Status** for the agreement.

## Don't edit out-of-box fields or remove them from forms

Customers edit out-of-box fields to accommodate their business needs. However, editing out-of-box fields can cause errors, especially when processes depend on the values of those fields.

To avoid errors:

- Hide unwanted fields on a form.
- Move unwanted fields to another form tab.

For example, Field Service processes calculate the value of the **Estimated Arrival Time** field on the *Bookable Resource Booking* record to indicate when a frontline worker is expected to arrive on-site. If your organization doesn't need this field, [hide it on the form](field-service-customize-forms.md#step-5-hide-form-tabs-sections-and-fields) instead of removing it.

## Don't edit option set (choice) values

Editing the option set values of out-of-box fields can cause errors, especially when processes depend on the values of those fields or during upgrades.

To avoid errors:

- Edit only the option set *labels* of out-of-box fields. **Never** edit the option set *values* of these fields.
- Don't remove any option set choices.
- Don't add any option set choices.

For example, the Field Service work order includes a **System Status** field by default. This field is an option set (of the *choice* type) and has options such as *Unscheduled*, *Scheduled*, *In progress*, *Completed*, and *Canceled*. Each option has a label and an associated numeric value. System administrators can edit the labels of option sets (such as *Unscheduled*), but they can never edit the numeric value that is associated with the label.

## Use fewer custom scripts and follow best practices

System customizers write scripts, typically JavaScript web resources, to run business logic. However, custom scripts can cause performance issues, errors, and complications during upgrades.

To avoid these issues:

- Minimize the number of scripts that run on load.
- Don't write scripts that call lots of data, and don't write multiple scripts that call the same data.

The following subsections describe best practices. In addition, follow the form script best practices in [Best practices for developing with Dynamics 365 Customer Engagement](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk).

### Minimize the number of network requests and the amount of data requested in the OnLoad event

The more network requests are made during a form load, and the more data is downloaded from those requests, the more time it takes to load the form. Request only the minimum amount of data that is needed. In addition, consider caching the data when possible, to avoid requesting data unnecessarily during future form loads.

### Avoid using synchronous network requests

Synchronous network requests can cause slow page loads and unresponsive forms. [Use asynchronous requests instead](/power-apps/developer/model-driven-apps/best-practices/business-logic/interact-http-https-resources-asynchronously). The following blog post provides more examples: [Turbocharge your model-driven apps by transitioning away from synchronous requests](https://www.microsoft.com/power-platform/blog/power-apps/turbocharge-your-model-driven-apps-by-transitioning-away-from-synchronous-requests/). In addition, consider using "async and wait" in any scenario where multiple network calls for the same entity and record are needed. [Learn more about async and await](https://developer.mozilla.org/docs/Learn/JavaScript/Asynchronous/Promises#async_and_await).

### Avoid including unnecessary JavaScript web resource libraries

The more scripts you add to a form, the more time it takes to download them. Usually, scripts are cached in your browser after they are loaded for the first time. However, the performance the first time a form is viewed often creates a significant impression.

### Avoid loading all scripts in the Onload event

If you have code that supports only `OnChange` events for columns or only the `OnSave` event, be sure to set the script library with the event handler for those events instead of the `OnLoad` event. In this way, loading of those libraries can be deferred, and performance increases when the form is loaded.

### Use collapsed tabs to defer loading of web resources

Web resources or iFrame components that are included in sections on a collapsible tab aren't loaded if the tab is collapsed. They are loaded only when the tab is expanded. When the tab state changes, the `TabStateChange` event occurs. Any code that is required to support web resources or iFrames on collapsed tabs can use event handlers for the `TabStateChange` event and reduce the code that might otherwise have to occur in the `OnLoad` event.

### Avoid duplicate network requests in client-side code

Multiple or duplicate network requests can cause the web browser to stall and affect form load time. Reducing the number of requests can improve performance. An alternative is to consolidate network requests and cache the value of the requests. In addition, consider asynchronous network requests, as was mentioned earlier.

### Avoid using roles and system user-specific calls if the relevant information is available in XRM APIs

Use XRM APIs to avoid network requests to get user privilege information. [Learn more about how to transition away from synchronous requests](https://www.microsoft.com/power-platform/blog/power-apps/turbocharge-your-model-driven-apps-by-transitioning-away-from-synchronous-requests/). In addition, avoid system user calls if the information from XRM APIs meets your requirements. 

### Set default visibility options

In the `OnLoad` event, avoid using form scripts that hide form elements. Instead, for form elements that might be hidden, set the default visibility options so that the elements are hidden by default when the form is loaded. Then use scripts in the `OnLoad` event to show the form elements that you want to be visible.

Learn more in the following resources:

- [Design forms for performance in model-driven apps](/power-apps/maker/model-driven-apps/design-performant-forms)
- [Unsupported customizations](/power-apps/developer/data-platform/supported-customizations#unsupported-customizations)

## Run solution checker on your scripts

The Power Apps solution checker is a useful tool from Microsoft that checks Power Apps solutions for issues and recommends best practices. These issues include problems with JavaScript, HTML, plugins, and custom workflow activities.

Learn more in the following resources:

- [Improve component performance, stability and reliability with solution checker](/power-apps/maker/data-platform/use-powerapps-checker)
- [How to Run and Use the Power Apps Solution Checker](https://carldesouza.com/how-to-run-and-use-the-power-apps-solution-checker/)
- [Dataverse Solution Checker](https://dynamics-chronicles.com/article/dataverse-solution-checker)

## Use asynchronous workflows instead of synchronous workflows

System customizers often write synchronous workflows to perform, in real time, business logic that runs when data is changed in Field Service. However, running workflows synchronously decreases performance. To avoid performance issues, run workflows asynchronously instead.

## Activate Field Service and Resource Scheduling out-of-the-box processes

Field Service and Resource Scheduling include many processes that perform necessary business logic. Deactivated processes can lead to errors. To avoid issues, make sure that all Field Service and Resource Scheduling processes are in an active state. To identify whether processes are in a deactivated state, regularly [run the Field Service Solution Health Hub](troubleshoot-field-service-solution-health.md).

## Run the Solution Health Hub to detect issues

The Solution Health Hub helps you to get a better picture of the state of your environment and detect issues with your Dynamics 365 environment. An environment's configuration might change over time through natural system operations. The Solution Health Hub runs rules within an instance to validate the environment's configuration. Some of the rules are specific to Field Service, and you can run them on demand when you encounter an issue. Some rules are automatically triggered when Field Service is installed or updated.

To monitor the health of your environment, regularly [run the Solution Health Hub ruleset](troubleshoot-field-service-solution-health.md).

## Mobile app performance considerations

Customizing the mobile app can affect performance. Learn more in [Performance considerations when customizing the mobile app](mobile/improve-mobile-performance.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
