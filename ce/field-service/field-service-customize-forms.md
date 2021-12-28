---
title: "How to customize Field Service forms and best practices | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/05/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# How to customize Field Service forms

While setting up Field Service for your organization, you may have to customize the forms that frontline workers, dispatchers, service managers and other roles use to view important information and document their work. IT administrators may customize Field Service forms so users can capture information unique to your business or industry and to ensure the form layout matches your business processes.

Customizing forms properly is very important for maximizing performance, like the time it takes for forms to load and save changes; and for improving usability, like how easy it is for users to view and update information. 

In this article we will walk through how to edit or "customize" the Work Order form for back office workers (there is a separate mobile work order form for frontline workers), but the steps below should be used to edit or customize any Field Service form. 

## Prerequisites

System administrator security role
Field Service - Adminsitrator security role

## 1. Understand the default work order form

Before customizing the work order form, it is very important to understand the default work order form that is included with Field Servive. This means understanding the fields and the recommended process flow. This will help you determine if you need to make minor changes to the default form or create something completely new. Using the default fields and process is recommended for performance, usability, and upgradability reasons.

Go to the Field Service app > Work Orders > select an existing record or create a new one.

View and understand the default fields and determine which ones can be used for your business.

The following fields are critical to the Field Service work order process and are highly recommended. If your organziation does not plan to use these fields then you may want to consider creating an entirely new entity table.

Work Order Number
System Status
Service Account
Price List
Work Order type
Work Location
Address and Latitude and Longitude

Make a note of fields you will want to utilize and those that are unneeded. 

The following subgrids are also critical to the Field Service work order process and are highly recommended.

Bookings
Service Tasks
Products
Services

[Read more about the work order fields and functions]()

The work order form is optimized for the following standard work order process.


[Read more about the Field Service work order process]()

## 2. Create new fields as needed

After understanding the existing fields and processes on the work order form, you may need to create additional fields based on your unique business processes.

Go to https://make.powerapps.com 

Create new fields also called "columns" as needed.

Do not add them to the form yet.


## 3. Do not delete existing fields 

Do not delete work order fields that you do not need. We will hide them from the form later on.

## 4. Follow guidelines to edit existing fields

In general, it is highly recommended to not edit existing fields. 

As an example, editing fields in the following ways is unsupported and can cause errors and upgradeissues.

- Changing field types
- Removing choice otions
- Adding Choice options


As an example you should not change the type of a field from _Date Only_ to _Date and Time_, or change a _Whole Number_ field to a _Decimal_.  

You should also never edit the _numeric values_ for Choice type fields (also called "option sets"), though you can edit the Choice _labels_. As an example, the Work Order System Status field is a Choice type field with options of Unscheduled, Scheduled, In Progress, Completed, etc. It is acceptable to change the labels like "Unscheduled" but never the associated numeric value. You can also not add or remove options to existing Choice type fields.

However, simply changing field display names labels or the choice option labels is allowed. 

As an example, you can change the display name of Service Account to Customer.

As another example, you can change the System status choice label from In Progress to Work Started. 



## 5. Decide to use the default form or create a new one

We are now ready to create a form that includes a combination of existing work order fields and your custom fields. 

You will first have to choose to either use and customize the default Work Order Main form or create a new one. 

If you want to use many of the default work order fields and your business process is close to the standard work order process (or you're willing to adopt the standard work order process) then it is highly recommended to use the default Work Order Main form and make changes within that form. This will ensure your work order form will be upgraded and you can benefit from improvements. 

If you have a very unique business process and a lot of custom fields (greater than 100), then it is recommended to create a new custom form.

### Option 1: Use and customize the existing work order form (recommended)

a. Go to the Work Order Main form

c. Hide unwanted tabs

d. Hide unwanted subgrids

e. Hide unwanted fields

f. Move unwanted fields away from the first from tab


b. Add your custom fields to the appropriate form tabs
    Do not add custom fields to the first form tab unless absolutely necessary 
    
e. Follow form design best practices

https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-and-edit-forms

> [!Note]
> You can make a copy of the form

### Option 2: Create an entirely custom work order form

a. Create a new form

b. Add critical fields

c. Add cirtical subgrids

c. Follow form design best practices

		a. https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-and-edit-forms
	

## 8. Test your forms
		a. Performance bench mark
		b. Best practice violations 

## Summary of recommended best practices

	- Hide unwanted fields, do not remove them, and move them away from the first tab
	- Use Form component control
	- Move lesser used fields away from 
	- Minimize lookup controls
	- Minimize subgrids 
	- Do not add additional subgrids or lookups to main form tab
	- Design productive forms - https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/design-productive-forms
	- Design performant forms - https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/design-performant-forms

## Other considerations
	- Create forms for different roles
    - required vs business recommended fields


## Need to update the mobile work order form for frontline workers?

View this article.

## See also
