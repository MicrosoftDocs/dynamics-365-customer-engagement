---
title: Modify case resolution dialog in Customer Service Hub | Microsoft Docs
description: Understand Cases in Customer Service Hub for Dynamics 365 Customer Service.
author: neeranelli
ms.author: lrobbin
manager: shujoshi
ms.date: 2/3/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Modify Case Resolution Dialog

Updates to the case resolution main form dialog (MFD) provides customers with additional functionality to support case resolution entities and edit dialog without code knowledge or experience.  The new functionality provides a powerful construct to expand the case resolution entity to support business needs that enable users to add and remove fields instantly without writing a single line of code. 

The new MFD experience is similar to the old experience, but behind the scenes this is a form which customers can freely edit.  Customers have the ability to go into the form designer and edit and modify fields as desired based on business needs.

## Set Resolution Type
One example of how case resolution can be used, is by resolving situations where you receive duplicate cases. You now can set the resolution type to display which cases have duplicate status.  

The following steps provide walk you through how to set the resolution type for duplicate cases:

<b>Step 1:</b> Click on <b>Customize the System</b><BR> 
<b>Step 2:</b> Select <b>Case</b>

![customize the system](media\case_resolution_1a.png "from customize the system select case")

<b>Step 3:</b> Select Fields

![Select Fields](media\case_resolution_2.png "Select Fields")

<b>Step 4:</b> Select the field you wish to update.  For this example, we’ll select, <b>Status Reason</b> 

![Select the field you wish to update](media\case_resolution_3.png "Select the field you wish to update")

Once you select the entity, the <b>Status Reason</b> in the case window will display.

<b>Step 5:</b> From the <b>Status</b> field a drop down box will appear. For this example, we’ll select <b>Resolved</b>. 

![Select Resolved](media\case_resolution_4.png "Select Resolved")

<b>Step 6:</b> In the bottom right, click on <b>Add</b>.

!click Add](media\case_resolution_5.png "click Add")

Once you click Add, the <b>Add List Value</b> window will appear. 

<b>Step 7:</b>  In <b>Label</b> field, enter <b>Duplicate</b>. 

![Enter Duplicate](media\case_resolution_6.png "Enter Duplicate")

You’ve successfully added a duplicate status to the status code field, now you can edit the form to add the field you just created.  

## Edit Form
Case resolution allows you to tailor form fields to support the needs of your business.  You now can add or remove fields that don’t apply to your business model without using code.  

For example, your business model does not require a <b>Billable Time</b> field because your case resolutions do not track billable hours, therefore you would like to remove that field from the form.  Also, your business process needs the ability to specify the date when a case was resolved, because your agents enter the resolution on a different date from when the case was actually resolved.

The following steps will walk you through how to remove the <b>Billable Time</b> field and add a new <b>Resolution Date</b> field in the Form Editor.

<b>Step 1:</b>  Go to the <b>Case Resolution</b> entity and click on <b>Forms</b>.  

![Click on Forms](media\case_resolution_8.png "Click on Forms")

<b>Step 2:</b>  Click on the name of the form you want to edit. In this example, we’ll select the Information form.

![Click on the name of the form you want to edit](media\case_resolution_9.png "Click on the name of the form you want to edit")

This will open up the form in the form designer.

<b>Step 3:</b> a. Click on <b>Billable Time field</b><BR>
b. On top nav bar, click on <b>Remove</b>. <b>Billable Time</b> field will disappear.

![Billable Time field](media\case_resolution_10.png "Billable Time field")

<b>Step 4:</b> a. Go to <b>Field</b> section. Find field you want to add to form designer.  For this example, we’ll be adding the <b>Resolution Date</b> field.<BR>
b. Drag field and drop into the position of your choice in the form designer. 

![Go to Time field](media\case_resolution_11.png "Go to Time field")

You also have the ability to resize the fields so that align with others in the form:

![field properties](media\case_resolution_12.png "field properties")

Once you have updated the field(s) that you want you are done.

<b>Step 5:</b> a. Click <b>save</b><BR>
b. Click <b>publish</b>

![save and publish](media\case_resolution_13.png "save and publish")

Now when you open your case, the case resolution dialog should now display the fields you’ve added:

![save and publish](media\case_resolution_14.png "save and publish")

You will know if a case has been successfully resolved per the status bar at the top of the form. 

![status bar](media\case_resolution_15.png "status bar")

### See also

[Work with cases](customer-service-hub-user-guide-work-with-cases.md)

[Create a case](customer-service-hub-user-guide-create-a-case.md)

[Merge cases](customer-service-hub-user-guide-merge-cases.md)

[Resolve, cancel, and reassign as case](customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md)

[Create and manage parent and child cases](customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)

[Case Queues and routing](customer-service-hub-user-guide-case-queues-and-routing.md)

[Convert case to knowledge article](customer-service-hub-user-guide-convert-case-to-knowledge-article.md)

[Case SLAs](customer-service-hub-user-guide-case-sla.md)

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)


























