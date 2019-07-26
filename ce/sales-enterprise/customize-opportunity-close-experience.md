---
title: "Preview: Customize opportunity close form (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Customize the opportunity close experience in Dynaimcs 365 for Sales to enable sales reps to capture important details about why an opportunity was closed."
keywords: "Opportunity, Close, Closing, Customization, dialog box, quick create, custom fields,"
ms.date: 08/01/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1.x"
ms.assetid: 00b7d8fc-fc21-4c95-8e85-3d9ed19e828e
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Preview: Customize Opportunity close form

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Enable sales managers to draw key insights based on the information the sales representatives fill in while closing an opportunity.

System administrators or customizers can use the **Opportunity Close** quick create form to add custom fields, so that sales representatives can capture important details about why an opportunity was closed.

Sales managers can use this data to know which products are doing well and develop a better strategy.

> [!IMPORTANT]
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## What customizations are possible?

-   Customization of Opportunity Close entity to add custom fields or adding validations such as if an opportunity is closed as Won, the Profit margin (custom field) must be mandatory.  

    > [!IMPORTANT]
    > You can’t delete the out-of-the-box fields or customize the entity relationship.

-   Customization of Opportunity Close Quick Create form to capture details such as Profit Margin, Winning Product and so on,  when closing an opportunity.

-   Customization of Opportunity Close Information form to view details of the closed opportunity

-   Customization of views

## Create custom fields for Opportunity Close entity

To enable sales representatives to capture relevant data about opportunity close, create fields as required by your organization for the **Opportunity Close** entity. For example, for all the won opportunities, your organization would like to know the profit margin. To achieve this, create a new field called Profit margin.

To create fields,

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

1.  On the nav bar, select **Settings**, and then select **Customizations**.

    ![Customization option in the site map](media/customization-in-sitemap.png "Customization option in the site map")

2.  On the **Customization** page, select **Customize the System**.

    The solution explorer opens.

3.  In the solution explorer, under **Components**, expand **Entities**, and then expand **Opportunity Close**.

4.  Under **Opportunity Close** node, select **Fields**.

5.  To add a new field, on the Actions toolbar, select **New**, and enter a **Display Name** to generate the **Name**. For more information on the data to enter, see [Create and edit fields (attributes)](../customize/create-edit-fields.md)


## Add newly created custom fields to Opportunity Close form

After you’ve created the fields that are required by your organization, add those fields to the **Opportunity Close** form, so sales representatives can capture data in those fields at the time of closing opportunities.

1.  In the solution explorer, under **Components**, expand **Entities**, and then expand **Opportunity Close**.

2.  Under **Opportunity Close** node, select **Forms**.

    ![Forms node in Solution explorer](media/forms-node-solution-explorer.png "Forms node in Solution explorer")

3.  Open the **Opportunity Close** form of type **Quick Create**.

4.  Add or remove any fields, as required on the **Opportunity Close** form.

5.  Select **Save and Close**.

    Important!

    The Opportunity entity has the following statuses, which aren’t customizable:

    Open, Won, Lost. However, you can add multiple status reasons corresponding to the Won and Lost statuses. If you add custom values to a Status Reason field against a state (Won/Lost) in the Opportunity entity, you must add the same custom value to the OpporunityStatusCode field (attribute) on the Opportunity Close entity manually. This displays the correct customized
    values with right defaults preselected for each opportunity Win and Loss state.

6.  Open the **Information** form of type **Main** and make the same changes that you did in Step 4.

    The sales representatives or managers have a way to open the **Opportunity Close** record after an opportunity is closed, which uses the **Information** form. For these newly added or removed fields to reflect on the **Information** form, the changes must be made to the **Information** form, too.


### See also
[Close opportunity as won or lost](close-opportunity-won-lost-sales.md)  
[Enable customization of opportunity close form](enable-opportunity-close-customization.md)