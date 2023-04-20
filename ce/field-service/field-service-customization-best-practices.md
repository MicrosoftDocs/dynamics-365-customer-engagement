---
title: Customization best practices
description: Learn about how to get the most out of your Dynamics 365 Field Service customizations.
ms.date: 1/20/2022

ms.topic: article
author: lmasieri
ms.author: lmasieri
---

# Customization best practices

Are you preparing to go live with Field Service?

Are you concerned about performance issues?

Are your forms loading slowly?

Are you encountering errors?

If so, this article is for you.

Follow these best practices to avoid performance, usability, and supportability issues with Dynamics 365 Field Service.

## Minimize custom fields on forms

System customizers add custom fields to entity forms to capture information specific to their industry and business, to run business processes, and to collect information to report on. However, too many custom fields on a form can cause performance issues.

To avoid performance issues:

- Minimize the number of custom fields on all forms. Starting with the work order form is a good idea if that is your most used form in the Field Service app.
- Among custom fields, minimizing _lookup_ type fields and _subgrids_ will have the greatest impact on form performance, like load times.
- Move custom fields (especially lookups and subgrids) from the first form tab to other form tabs.
- Hide lesser used fields by default on the form. 

## Don't edit or remove out-of-box fields from forms

Customers edit out-of-the-box fields to accommodate their business needs. However, editing out-of-the-box fields can cause errors, especially when processes depend on those field values.

To avoid errors:

- Hide unwanted fields from a form. 
- Move unwanted fields to another form tab.

Here is just one example: Field Service processes calculate the _Estimated Arrival Time_ field value on the Bookable Resource Booking record to indicate when a frontline worker is expected to arrive on site. If your organization does not need this field, hide it on the form rather than remove it.

For more information, see these articles: 
- [Optimize model-driven app form performance in Power Apps](/powerapps/maker/model-driven-apps/optimize-form-performance)
- [Design forms for performance in model-driven apps](/powerapps/maker/model-driven-apps/design-performant-forms)

## Do not edit option set (choice) values

Editing the option set values of out-of-the-box fields can cause errors, especially when processes depend on those field values or during upgrades.

To avoid errors:
- Only edit option set _labels_ and **never** edit option set _values_ of out-of-the-box fields.
- Do not remove any option set choices. 
- Do not add any option set choices.
  
Here is just one example: The Field Service work order includes a field called "System Status" by default. This field is an option set (type "choice") with options like Unscheduled, Scheduled, In progress, Completed, Canceled, etc. Each of these options has a label and an associated numeric value. System administrators can edit the labels of option sets (like "Unscheduled") but can never edit the associated numeric value of the label.    


## Use fewer custom scripts and follow best practices

System customizers write scripts, typically JavaScript web resources, to execute business logic. However, custom scripts can cause performance issues, errors, and complications when upgrading.

To avoid these issues:

- Minimize scripts running on load.
- Don't write scripts that call a lot of data or write multiple scripts that call the same data.

Follow more [form script best practices](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk), including the following best practices:

### Minimize the number of network requests and the amount of data requested in the OnLoad event

The higher the number of network requests made during a form load, and the more amount of data downloaded from those requests, the more time it will take for a form to load. Only request the minimum amount of data needed. Also, consider caching the data when possible to avoid requesting data unnecessarily on future page loads.

### Avoid using synchronous network requests

Synchronous network requests can cause slow page loads and unresponsive forms. [Use asynchronous requests instead](/powerapps/developer/model-driven-apps/best-practices/business-logic/interact-http-https-resources-asynchronously). See this [blog post](https://powerapps.microsoft.com/blog/turbocharge-your-model-driven-apps-by-transitioning-away-from-synchronous-requests/) for more examples. In addition, consider using "async and wait" in any scenario where multiple network calls for the same entity and record are needed; find [more details here](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Asynchronous/Async_await).

### Avoid including unnecessary JavaScript web resource libraries

The more scripts you add to the form, the more time it will take to download them. Usually scripts are cached in your browser after they are loaded the first time, but the performance the first time a form is viewed often creates a significant impression.

### Avoid loading all scripts in the Onload event

If you have code that only supports OnChange events for columns or the OnSave event, make sure to set the script library with the event handler for those events instead of the OnLoad event. This way loading those libraries can be deferred and increase performance when the form loads.

### Use collapsed tabs to defer loading web resources

When web resources or IFRAMES are included in sections inside a collapsed tab, they will not be loaded if the tab is collapsed. They will be loaded when the tab is expanded. When the tab state changes the TabStateChange event occurs. Any code that is required to support web resources or IFRAMEs within collapsed tabs can use event handlers for the TabStateChange event and reduce code that might otherwise have to occur in the OnLoad event.


### Avoid duplicate network requests in client-side code

Multiple or duplicate network requests can cause the web browser to stall and affect form load time. Reducing the number of requests can improve performance. An alternative is to consolidate network requests and cache the value of these requests. Also consider having these network requests done asynchronously as mentioned above.


### Avoid using roles and system user specific calls if the relevant information is available in XRM APIs

Use XRM APIs to avoid network requests to get user privilege info. See the following article on [transitioning away from synchronous requests](https://powerapps.microsoft.com/en-us/blog/turbocharge-your-model-driven-apps-by-transitioning-away-from-synchronous-requests). Similarly avoid system user calls if the information from XRM APIs meets your requirements. 



### Set default visibility options

Avoid using form scripts in the OnLoad event that hide form elements. Instead set the default visibility options for form elements that might be hidden to not be visible by default when the form loads. Then, use scripts in the OnLoad event to show those form elements you want to display.

For more information, see these resources:

- [Best practices (Developer Guide for Dynamics 365 Customer Engagement)](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk)
- [Optimize model-driven app form performance in Power Apps](/powerapps/maker/model-driven-apps/optimize-form-performance)
- [Unsupported customizations for Microsoft Dataverse (Dataverse)](/powerapps/developer/data-platform/supported-customizations#unsupported-customizations)

## Run Solution Checker on your scripts

The Power Apps solution checker is a useful tool from Microsoft that checks Power Apps solutions for issues and recommends best practices. These issues include problems with JavaScript, HTML, Plugins, and custom workflow activities.

For more information, see these resources:

- [Use solution checker to validate your apps in Power Apps](/powerapps/maker/data-platform/use-powerapps-checker)
- [How to run and use the Power Apps solution checker](https://carldesouza.com/how-to-run-and-use-the-power-apps-solution-checker/)
- [Dataverse Solution Checker](https://dynamics-chronicles.com/article/dataverse-solution-checker)

## Use asynchronous workflows instead of synchronous

System customizers often write synchronous workflows to perform business logic in real time that executes when data is changed in Field Service. However, running workflows synchronously will hurt performance.

To avoid performance issues, run workflows asynchronously.

## Activate Field Service and Resource Scheduling out-of-the-box processes

Field Service and Resource Scheduling ship with many processes that perform necessary business logic.

Deactivated processes can lead to errors.

To avoid issues, make sure all Field Service and Resource Scheduling processes are in an active state. Regularly [run the Field Service Solution Health Hub](troubleshoot-field-service-solution-health.md) to identify if processes are in a deactivated state. 

## Run Solution Health Hub to detect issues

Solution Health Hub allows you to get a better picture of the state of your environment and detect issues with your Dynamics 365 environment. The Solution Health Hub runs rules within an instance to validate the environment's configuration, which might change over time through natural system operations. Some of the rules are specific to Dynamics 365 Field Service and you can run the rules on demand when you encounter an issue. Some rules automatically trigger when Field Service is installed or updated. 

Regularly [run the Field Service Solution Health Hub](troubleshoot-field-service-solution-health.md) ruleset to monitor the health of your environment.

## Mobile app performance considerations

Customizing the mobile app can also affect performance. For more information, see this article: [Performance considerations when customizing the mobile app](improve-mobile-performance.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
