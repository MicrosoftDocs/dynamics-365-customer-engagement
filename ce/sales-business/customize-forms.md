---
title: "Customize forms in Dynamics 365 for Sales | Microsoft Docs"
description: "Modify the forms included in Dynamics 365 for Sales to fit the needs of your organization."
keywords: "form; customize"
ms.date: 11/15/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e82c6918-fe81-4812-ad78-77d178111064
author: brycho
ms.author: brycho
manager: amyla
ms.reviewer: 
topic-status: Drafting
---

# Customize forms in Dynamics 365 Sales, Business edition 

In Dynamics 365, forms provide the user interface that people use to interact with the data they need to do their work. It is important that the forms people use are designed to allow them to find or enter the information they need efficiently. You can use the Form Designer to customize the forms included with Dynamics 365 to meet the specific needs of your organization.

> [!NOTE]

> In the Business edition, you can’t rearrange or remove the sections on a form or add additional sections to the form.

> [!IMPORTANT]

> Only customizations done within the app are supported. You should not try to customize your forms for the Business edition app outside of the app itself.

## How do forms relate to entities?

A form is a set of data-entry fields for a given entity that matches the items that your organization tracks for the entity. For example, your organization might have fields that track a customer’s previous orders along with specific requested reorder dates.

When you publish a customized form, you are publishing an updated version of the entity associated with the form.

## View the forms available for you to customize

- Open **Advanced Settings**, and then under **Customization**, choose **Forms**.

![Customize forms in Advance settings](media/form-cust-1.png "Customize forms in Advance settings")

 The list of forms available to customize is displayed. The name of the form is Business for all entities. The page also displays the date on which the form was published, and whether the form is active or not.

![List of forms](media/form-cust-2.png "List of forms")

## Open the form you want to customize

- To open a form, choose the form you want in the **Name** column, or select a form, and then click **Edit** above the search field.
If you select more than one form, the **Edit** link is not displayed.

ART3 GOES HERE

 The sections of the form are displayed on the left side of the designer with tabs that contain additional information about the form. The available tabs depend on the form. For example, the Account form has a **Summary** tab and a **Details** tab. The Opportunity form has a **Product Line** tab but no **Details** tab. Each tab includes different parts of the form .

> [!TIP]

> You can see whether the form you opened is published in the upper-right corner of the designer.

## Components tab

Use the **Components** tab to add or modify fields. 

ART4 GOES HERE

## Existing fields

When you click **Existing Fields**, the fields associated with the entity for the form are displayed. If you add a new field that was not included with the app, it becomes a custom field.

ART5 GOES HERE

## New fields

When you click **New Fields**, you can select from the different field types available for your field.

ART6 GOES HERE

## Properties tab

The **Properties** tab shows the properties for the section of the form or field you select. When you select a section or field on a form, the **Properties** tab automatically opens. If you select a section that is not available for customization, the **Properties** tab will not display anything, and you cannot click it to display properties.

ART7 GOES HERE

## Search for a field

You can use the **Search** box on the **Components** tab to search for a field by name. Just type all or part of the name and then press Enter. The list of fields displayed automatically updates the list of fields to include only those that match your search text. For example, if you want to find fields related to email, type “email” (without quotation marks) in the **Search** box. The list of fields updates to show only fields that include “email” in the name.

ART8 GOES HERE

## Filter the list of displayed fields

You can also filter which fields are displayed on the **Components** tab. When you select **All Fields**, the list displays all the fields for the entity associated with the form. When you select **Custom Fields**, the list displays only the fields created by you or another customizer.

To filter the list of fields displayed, select either **All Fields** or **Custom Fields** in the **Filter** drop-down.

ART9 GOES HERE

To show only the fields that are not already used on the form, select the **Only Show unused fields** checkbox.

ART10 GOES HERE

## Customize the header for a form

Updating the fields included in the header works the same way as other sections of the form. Fields in headers support all field types other than multi-line fields, such as a multi-line text field. By default, headers include a single row with 3 or 4 columns, depending on the form.

You can rearrange the fields between columns by dragging the field from one column to another. The existing field in the target column will switch places with the field you move. You cannot, however, drag or cut and paste a field from another section of a form to the header, or from the header to another section of the form.

> [!NOTE] 

> The Header section of a form cannot be deleted from the form. 

To customize the fields used in the header, click the **Show header fields** arrow.

ART11 GOES HERE

If you want to replace a field used in the header, you need to first remove one of the fields. Dragging a field from the **Components** tab over an existing field does not allow you to replace the existing field.

## Common tasks for customizing your forms

This section includes some of the common tasks you can perform to customize your forms.

### Add fields to a form

1.	Open the form you want to add a field to.
2.	On the **Components** tab, click **Existing Fields** or **New Fields** to display a list of fields available.
3.	Select the section of the form you want to add the field to.
4.	Do one of the following:
    -	Double-click the field in the **Components** pane.
    -	Select the field in the **Components** pane, and then press Enter.
    -	Drag the field from the **Components** pane and drop it onto the section of the form where you want it.
    
If you double-click a field or select it and press Enter, the field will be added as the last field in the section currently selected.

## Add a custom field

If you need to include a field on a form that is not already available, you can create a new field and define the properties for it. You can set the properties either before or after you add it to a form. Fields that you create are listed as custom fields on the **Components** tab.

By default, the maximum number of custom fields you can add to a form is 10. This value can be changed by your administrator. If  you attempt to add more than the allowed number of custom fields, you’ll receive an error message. 

## Rearrange the fields on a form

You can rearrange the fields on a form so they’re displayed in a different order, or move fields from one section to another. To do so, click the field you want to move, or use the Tab key to navigate between sections and fields until the one you want is selected. Then do one of the following:

-	Drag the field to a different place in the same section or to a different section of the form.
-	Use the common keyboard shortcut Ctrl+X to cut the field from its current position. Then select the field (either in the same section or a different section) that you want the field to be positioned after and press Ctrl+V to paste it. If you don’t select a field in a section, the field will be positioned as the last field in the section when you paste it. 

## Remove fields from a form

To remove a field from a form, select the field in the designer and then click Remove at the top of the designer.

ART12 GOES HERE

Note that you can’t remove locked fields (indicated by a red padlock icon next to the field name). A red asterisk next to the label indicates the field is set to **Business Required**.

ART13 GOES HERE

When you attempt to remove a locked field, you will see the following error message:

ART14 GOES HERE

When a field is removed from a form, it is moved to the list of unused fields on the **Components** tab.

## Modify properties for a field

You can edit the properties for any field on the form. To change the properties for the field, select the field. When you select a field, the **Properties** tab is automatically opened and displays the properties for the selected field. The properties available depend on the type of field that’s selected. You can change any of the properties displayed except those that are locked.

After you make your changes, click **Apply** to apply the changes. You may have to scroll down to see the **Apply** button when using lower screen resolutions.

ART15 GOES HERE

## Change the label of a field

To change a field label, click the field, and then click the **Edit** button. This is the same as changing the value for the label in the **Properties** tab.

ART16 GOES HERE

When you click the **Edit** button, the label is displayed in a text field where you can change it.

ART17 GOES HERE

## Making fields optional or required

You can specify that a field is optional, business recommended, or business required by setting the **Field Requirement** property. When a field is set to **Business Required**, a red asterisk is displayed next to the label on the form.

ART18 GOES HERE

Note that when you change this property, the metadata is updated for all forms that use that field.

You cannot remove fields set to **Business Required** from a form. You can change the field to **Optional**, and then remove it, however.

## Save a form

When you’re finished customizing your form, or to save your progress, click **Save** or **Save and Close** in the upper-right corner of the designer. If the form you have open has not been changed since it was last saved, the **Save** button is disabled.

ART19 GOES HERE

Forms that contain errors will not be saved, and forms that are not saved cannot be published. You’ll need to correct any errors in the form before you can save and publish it. Errors are highlighted in red in the designer so that you can easily find them.

## Publish a form

After you save the changes to your form, you’ll need to publish it to make it available to users. To publish your form, click **Publish**.

ART20 GOES HERE




