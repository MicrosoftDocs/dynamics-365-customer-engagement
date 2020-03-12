---
title: Modify case resolution dialog in Customer Service Hub | Microsoft Docs
description: Understand Cases in Customer Service Hub for Dynamics 365 Customer Service.
author: neeranelli
ms.author: lrobbin
manager: shujoshi
ms.date: 3/10/2019
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

Updates to the case resolution main form dialog (MFD) provides customers with additional functionality to support case resolution entities and edit dialog without code knowledge or experience.  This new functionality provides a powerful construct to expand the case resolution entity to support business needs that enable users to add and remove fields instantly without writing a single line of code. 

The new MFD experience is similar to the old experience, but behind the scenes this is a form which customers can freely edit.  Customers have the ability to go into the form designer and edit and modify fields as desired based on business needs.

## Status Values 

It is important to note, that when adding custom status values, you must update them in two locations:

- <b>Location 1: Case Resolution Entity:</b> Here is where you set the resolution type of the incident entity (status code).

- <b>Location 2: Enable Customizable Dialog:</b> Here is where you set the incident resolution entity (resolution type code).

Before you update Locations 1 and 2, use the following steps to access entities:

**Step 1:** Go to **Settings**

   > [!div class=mx-imgBorder]
   > ![Status Values - Select Settings](media/status-values-step-1.PNG)

**Step 2:** Click on **All legacy settings**
    
   > [!div class=mx-imgBorder]
   > ![Status Values - Select All Legacy settings](media/status-values-step-2.PNG)

**Step 3:** Click on **Customize the System**
    
   > [!div class=mx-imgBorder]
   > ![Status Values - Customize the system](media/status-values-step-3.PNG)

## Case Resolution Entity

### Location 1: Set Resolution Type

One example of how you can use case resolution is by resolving situations where you receive duplicate cases. In this example, we will show you how to set the resolution type to display which cases have duplicate status.  

The following steps walk you through how to set the resolution type for duplicate cases:

**Step 1:** Select on **Customize the System**

**Step 2:** Select **Case**

  > [!div class=mx-imgBorder]
  > ![customize the system](media/case_resolution_1a.png "from customize the system select case")

**Step 3:** Select Fields

  > [!div class=mx-imgBorder]
  > ![Select Fields](media/case_resolution_2.png "Select Fields")

**Step 4:** Select the field you wish to update.  For this example, we’ll select, **Status Reason** 

  > [!div class=mx-imgBorder]
  > ![Select the field you wish to update](media/case_resolution_3.png "Select the field you wish to update")

Once you select the entity, the **Status Reason** in the case window will display.

**Step 5:** From the **Status** field a drop down box will appear. For this example, we’ll select **Resolved**. 

  > [!div class=mx-imgBorder]
  > ![Select Resolved](media/case_resolution_4.png "Select Resolved")

**Step 6:** In the bottom right, select on **Add**.

  > [!div class=mx-imgBorder]
  > ![Select Add](media/case_resolution_5.png "Select Add")

Once you select Add, the **Add List Value** window will appear. 

**Step 7:**  In **Label** field, enter **Duplicate**. 

  > [!div class=mx-imgBorder]
  > ![Enter Duplicate](media/case_resolution_6.png "Enter Duplicate")

You’ve successfully added a duplicate status to the status code field, now you can edit the form to add the field you just created.  

## Enable Customizable Dialog

### Location 2: Set Incident Resolution Entity

Now that we've added the duplicate status to the case entity, we need to add it to the case resolution entity. 

The admin can enable customizable dialog on a form through accessing the advanced setting in the Customer Service Hub (CSH) screen and using the following steps:  

**Step 1:** Select **Service Management**

**Step 2:** Select **Service Configuration**

**Step 3:**	Use the drop down and select **Customizable Dialog**

**Step 4:**	Click **Save**

  > [!div class=mx-imgBorder]
  > ![Enable Customizable Dialog](media/case-resolution-entity.png "Enable Customizable Dialog")

> [!NOTE]
> The setting default is set to **Standard Dialogue**. Admin must select **Customizable Dialog** otherwise any changes made will be saved to the form, but will not be displayed for use. 

## Case Resolution Entity

  > [!div class=mx-imgBorder]
  > ![Case Resolution Entity](media/enable-customizable-dialog-1.png "Case Resolution Entity")

**Step 1:** Select **Case Resolution** entity

**Step 2:** Select **Fields**

**Step 3:** Select **Resolution Type Code**

  > [!div class=mx-imgBorder]
  > ![Case Resolution Entity](media/enable-customizable-dialog-2.png "Case Resolution Entity")

**Step 4:** Under Options section, click on plus symbol. This will enable the **Label** and **Value** fields to be populated.

**Step 5:** In the **Label** field, enter a value name, for this example we used **Duplicate**

**Step 6:** In the **Value** field, you want to confirm that the variable listed matches the value listed in the case entity.  

**Step 7:** Click **Save**

Now the a case resolution entity will appear in the dialog field as an option you can select.

> [!IMPORTANT] 
> - The system default for the **Value** variable is set at **10,000,000**. Values for both options must be the same. 
> - If you change the value in the **Case Entity**, you must update the value in the **Case Resolution Entity** to match.
> - If the values in the **Case Entity** do not match the values in the **Case Resolution Entity**, an error message will display when you try to resolve the case.  


## Edit Form
Case resolution allows you to tailor form fields to support the needs of your business.  You now can add or remove fields that don’t apply to your business model without using code.  

For example, your business model does not require a **Billable Time** field because your case resolutions do not track billable hours, therefore you would like to remove that field from the form.  Also, your business process needs the ability to specify the date when a case was resolved, because your agents enter the resolution on a different date from when the case was actually resolved.

The following steps will walk you through how to remove the **Billable Time** field and add a new **Resolution Date** field in the Form Editor.

**Step 1:**  Go to the **Case Resolution** entity and select on **Forms**.  
  > [!div class=mx-imgBorder]
  > ![Select on Forms](media/case_resolution_8.png "Select on Forms")

**Step 2:**  Select on the name of the form you want to edit. In this example, we’ll select the Information form.

  > [!div class=mx-imgBorder]
  > ![Select on the name of the form you want to edit](media/case_resolution_9.png "Select on the name of the form you want to edit")

This will open up the form in the form designer.

**Step 3:** a. Select on **Billable Time field**<BR>
b. On top nav bar, select on **Remove**. **Billable Time** field will disappear.

  > [!div class=mx-imgBorder]
  > ![Billable Time field](media/case_resolution_10.png "Billable Time field")

**Step 4:** a. Go to **Field** section. Find field you want to add to form designer.  For this example, we’ll be adding the **Resolution Date** field.
  
  b. Drag field and drop into the position of your choice in the form designer. 

  ![Go to Time field](media/case_resolution_11.png "Go to Time field")

You also have the ability to resize the fields so that align with others in the form:

  > [!div class=mx-imgBorder]
  > ![field properties](media/case_resolution_12.png "field properties")

Once you have updated the field(s) that you want you are done.

**Step 5:** a. Select **save**<BR>

  b. Select **publish**

  > [!div class=mx-imgBorder]
  > ![save and publish](media/case_resolution_13.png "save and publish")

Now when you open your case, the case resolution dialog should now display the fields you’ve added:

  > [!div class=mx-imgBorder]
  > ![save and publish](media/case_resolution_14.png "save and publish")

You will know if a case has been successfully resolved per the status bar at the top of the form. 

  > [!div class=mx-imgBorder]
  > ![status bar](media/case_resolution_15.png "status bar")

## Permissions

> [!NOTE] 
> Permissions need to be set per the example below, otherwise you will not see the modified case resolution dialog. Instead, you will see the box case resolution experience.

![Security Role: Customer Service Representative](media/csr-setting-case-resolution.png)

![Security Roles: Customer Service Representative (CSR) Manager](media/csr-manager-setting-case-resolution.png)

> [!IMPORTANT] 
> If you have created your own security roles, you'll need to update your roles before you can use the modified case resolution dialog.


 

### See also

[Work with cases](customer-service-hub-user-guide-create-a-case.md) 

[Create a case](customer-service-hub-user-guide-create-a-case.md)

[Merge cases](customer-service-hub-user-guide-merge-cases.md)

[Resolve, cancel, and reassign as case](customer-service-hub-user-guide-resolve-cancel-reassign-a-case.md)

[Create and manage parent and child cases](customer-service-hub-user-guide-create-and-manage-parent-and-child-cases.md)

[Case Queues and routing](customer-service-hub-user-guide-case-queues-and-routing.md)

[Convert case to knowledge article](customer-service-hub-user-guide-convert-case-to-knowledge-article.md)

[Case SLAs](customer-service-hub-user-guide-case-sla.md)

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)